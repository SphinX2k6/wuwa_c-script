using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal;
using UnrealEngine;

// Token: 0x02002E23 RID: 11811
[NullableContext(2)]
[Nullable(0)]
public class AnimalStateMachineComponent : EntityComponent
{
	// Token: 0x06018E1C RID: 101916 RVA: 0x00669636 File Offset: 0x00667836
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.StateMachine = new StateMachine<Entity, EAnimalPerformState>(base.Entity, new Action<EAnimalPerformState, EAnimalPerformState>(this.OnSwitchState));
		return true;
	}

	// Token: 0x06018E1D RID: 101917 RVA: 0x00669658 File Offset: 0x00667858
	protected override bool OnStart()
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		this.ConfigId = component.GetPbDataId();
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		CharacterAnimationComponent animComp = this.AnimComp;
		UAnimInstance uanimInstance = (animComp != null) ? animComp.MainAnimInstance : null;
		IBPI_AnimalEcological_C ibpi_AnimalEcological_C = uanimInstance as IBPI_AnimalEcological_C;
		if (ibpi_AnimalEcological_C == null)
		{
			return true;
		}
		this.EcologicalInterface = ibpi_AnimalEcological_C;
		if (!UKuroStaticLibrary.IsObjectClassByName(uanimInstance, CharacterNameDefines.Instance.ABP_BASEANIMAL) && !UKuroStaticLibrary.IsObjectClassByName(uanimInstance, CharacterNameDefines.Instance.ABP_BASERUNANIMAL))
		{
			return true;
		}
		EntityArgs<IBPI_AnimalEcological_C> entityArgs = new EntityArgs<IBPI_AnimalEcological_C>(this.EcologicalInterface);
		this.StateMachine.AddState<AnimalPerformBornState>(EAnimalPerformState.Born, entityArgs);
		this.StateMachine.AddState<AnimalPerformStandState>(EAnimalPerformState.Stand, entityArgs);
		this.StateMachine.AddState<AnimalPerformIdleState>(EAnimalPerformState.Idle, entityArgs);
		this.StateMachine.AddState<AnimalPerformInteractState>(EAnimalPerformState.Interact, entityArgs);
		this.StateMachine.AddState<AnimalPerformUnderAttackState>(EAnimalPerformState.UnderAttack, entityArgs);
		this.StateMachine.AddState<AnimalPerformAlertState>(EAnimalPerformState.Alert, entityArgs);
		this.StateMachine.AddState<AnimalPerformTakeOffState>(EAnimalPerformState.TakeOff, entityArgs);
		this.StateMachine.AddState<AnimalPerformSystemUiState>(EAnimalPerformState.SystemUi, entityArgs);
		return true;
	}

	// Token: 0x06018E1E RID: 101918 RVA: 0x00669778 File Offset: 0x00667978
	protected override void OnActivate()
	{
		this.StartStateMachine();
	}

	// Token: 0x06018E1F RID: 101919 RVA: 0x00669780 File Offset: 0x00667980
	protected override void OnTick(float delta)
	{
		if (!this.Initialize)
		{
			return;
		}
		this.StateMachine.Update(delta);
	}

	// Token: 0x06018E20 RID: 101920 RVA: 0x00669797 File Offset: 0x00667997
	protected override bool OnEnd()
	{
		this.Initialize = false;
		this.StateMachine.Destroy();
		return true;
	}

	// Token: 0x06018E21 RID: 101921 RVA: 0x006697AC File Offset: 0x006679AC
	private void OnSwitchState(EAnimalPerformState oldState, EAnimalPerformState newState)
	{
	}

	// Token: 0x06018E22 RID: 101922 RVA: 0x006697AE File Offset: 0x006679AE
	public void StartStateMachine()
	{
		this.StateMachine.Start(this.StartState);
		this.Initialize = true;
	}

	// Token: 0x06018E23 RID: 101923 RVA: 0x006697CC File Offset: 0x006679CC
	public EAnimalEcologicalState CurrentState()
	{
		return AnimalStateMachineComponent.GetUeState(this.StateMachine.CurrentState.Value);
	}

	// Token: 0x06018E24 RID: 101924 RVA: 0x006697F1 File Offset: 0x006679F1
	public void SwitchState(EAnimalPerformState state)
	{
		if (!this.Initialize)
		{
			return;
		}
		this.StateMachine.Switch(state);
	}

	// Token: 0x06018E25 RID: 101925 RVA: 0x0066980C File Offset: 0x00667A0C
	public float GetWaitTime()
	{
		AnimalPerformStateBase animalPerformStateBase = this.StateMachine.GetState(this.StateMachine.CurrentState.Value) as AnimalPerformStateBase;
		if (animalPerformStateBase == null)
		{
			return 0f;
		}
		return animalPerformStateBase.GetActionTime();
	}

	// Token: 0x06018E26 RID: 101926 RVA: 0x0066984B File Offset: 0x00667A4B
	public AnimalPerformStateBase GetState(EAnimalPerformState state)
	{
		if (!this.Initialize)
		{
			return null;
		}
		return this.StateMachine.GetState(state) as AnimalPerformStateBase;
	}

	// Token: 0x06018E27 RID: 101927 RVA: 0x00669868 File Offset: 0x00667A68
	public AnimalPerformStateBase GetCurrentState()
	{
		if (!this.Initialize)
		{
			return null;
		}
		return this.GetState(this.StateMachine.CurrentState.Value);
	}

	// Token: 0x06018E28 RID: 101928 RVA: 0x00669898 File Offset: 0x00667A98
	[NullableContext(1)]
	public static string GetStateName(EAnimalPerformState state)
	{
		switch (state)
		{
		case EAnimalPerformState.Born:
			return "None";
		case EAnimalPerformState.Stand:
			return "None";
		case EAnimalPerformState.Idle:
			return "空闲";
		case EAnimalPerformState.Interact:
			return "交互";
		case EAnimalPerformState.UnderAttack:
			return "受击";
		case EAnimalPerformState.TakeOff:
			return "起飞";
		case EAnimalPerformState.Alert:
			return "警觉";
		case EAnimalPerformState.SystemUi:
			return "系统UI";
		default:
			return "None";
		}
	}

	// Token: 0x06018E29 RID: 101929 RVA: 0x00669902 File Offset: 0x00667B02
	public static EAnimalEcologicalState GetUeState(EAnimalPerformState state)
	{
		switch (state)
		{
		case EAnimalPerformState.Born:
			return EAnimalEcologicalState.None;
		case EAnimalPerformState.Stand:
			return EAnimalEcologicalState.None;
		case EAnimalPerformState.Idle:
			return EAnimalEcologicalState.空闲;
		case EAnimalPerformState.Interact:
			return EAnimalEcologicalState.交互;
		case EAnimalPerformState.UnderAttack:
			return EAnimalEcologicalState.受击;
		case EAnimalPerformState.TakeOff:
			return EAnimalEcologicalState.起飞;
		case EAnimalPerformState.Alert:
			return EAnimalEcologicalState.警觉;
		case EAnimalPerformState.SystemUi:
			return EAnimalEcologicalState.系统UI;
		default:
			return EAnimalEcologicalState.None;
		}
	}

	// Token: 0x06018E2A RID: 101930 RVA: 0x0066993D File Offset: 0x00667B3D
	public static EAnimalPerformState GetTsState(EAnimalEcologicalState state)
	{
		switch (state)
		{
		case EAnimalEcologicalState.None:
			return EAnimalPerformState.Stand;
		case EAnimalEcologicalState.空闲:
			return EAnimalPerformState.Idle;
		case EAnimalEcologicalState.警觉:
			return EAnimalPerformState.Alert;
		case EAnimalEcologicalState.受击:
			return EAnimalPerformState.UnderAttack;
		case EAnimalEcologicalState.起飞:
			return EAnimalPerformState.TakeOff;
		case EAnimalEcologicalState.交互:
			return EAnimalPerformState.Interact;
		case EAnimalEcologicalState.系统UI:
			return EAnimalPerformState.SystemUi;
		default:
			return EAnimalPerformState.Stand;
		}
	}

	// Token: 0x06018E2B RID: 101931 RVA: 0x00669974 File Offset: 0x00667B74
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		AnimalStateMachineComponent animalStateMachineComponent = (AnimalStateMachineComponent)componentTemplate;
		if (base.CanResetComponentProperty("ConfigId"))
		{
			this.ConfigId = animalStateMachineComponent.ConfigId;
		}
		if (base.CanResetComponentProperty("AnimComp"))
		{
			if (animalStateMachineComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("EcologicalInterface"))
		{
			if (animalStateMachineComponent.EcologicalInterface == null)
			{
				this.EcologicalInterface = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<IBPI_AnimalEcological_C>(this.EcologicalInterface), "EcologicalInterface"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("StateMachine"))
		{
			if (animalStateMachineComponent.StateMachine == null)
			{
				this.StateMachine = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<StateMachine<Entity, EAnimalPerformState>>(this.StateMachine), "StateMachine"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("Initialize"))
		{
			this.Initialize = animalStateMachineComponent.Initialize;
		}
		return true;
	}

	// Token: 0x0400BAA2 RID: 47778
	private int ConfigId;

	// Token: 0x0400BAA3 RID: 47779
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400BAA4 RID: 47780
	private IBPI_AnimalEcological_C EcologicalInterface;

	// Token: 0x0400BAA5 RID: 47781
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private StateMachine<Entity, EAnimalPerformState> StateMachine;

	// Token: 0x0400BAA6 RID: 47782
	private readonly EAnimalPerformState StartState;

	// Token: 0x0400BAA7 RID: 47783
	private bool Initialize;
}
