using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal;
using UnrealEngine;

// Token: 0x0200237F RID: 9087
[NullableContext(2)]
[Nullable(0)]
public class AnimalStateMachineComponent : EntityComponent
{
	// Token: 0x060166E5 RID: 91877 RVA: 0x0068F54E File Offset: 0x0068D74E
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.StateMachine = new StateMachine<Entity, EAnimalPerformState>(base.Entity, new Action<EAnimalPerformState, EAnimalPerformState>(this.OnSwitchState));
		return true;
	}

	// Token: 0x060166E6 RID: 91878 RVA: 0x0068F570 File Offset: 0x0068D770
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

	// Token: 0x060166E7 RID: 91879 RVA: 0x0068F690 File Offset: 0x0068D890
	protected override void OnActivate()
	{
		this.StartStateMachine();
	}

	// Token: 0x060166E8 RID: 91880 RVA: 0x0068F698 File Offset: 0x0068D898
	protected override void OnTick(float delta)
	{
		if (!this.Initialize)
		{
			return;
		}
		this.StateMachine.Update(delta);
	}

	// Token: 0x060166E9 RID: 91881 RVA: 0x0068F6AF File Offset: 0x0068D8AF
	protected override bool OnEnd()
	{
		this.Initialize = false;
		this.StateMachine.Destroy();
		return true;
	}

	// Token: 0x060166EA RID: 91882 RVA: 0x0068F6C4 File Offset: 0x0068D8C4
	private void OnSwitchState(EAnimalPerformState oldState, EAnimalPerformState newState)
	{
	}

	// Token: 0x060166EB RID: 91883 RVA: 0x0068F6C6 File Offset: 0x0068D8C6
	public void StartStateMachine()
	{
		this.StateMachine.Start(this.StartState);
		this.Initialize = true;
	}

	// Token: 0x060166EC RID: 91884 RVA: 0x0068F6E4 File Offset: 0x0068D8E4
	public EAnimalEcologicalState CurrentState()
	{
		return AnimalStateMachineComponent.GetUeState(this.StateMachine.CurrentState.Value);
	}

	// Token: 0x060166ED RID: 91885 RVA: 0x0068F709 File Offset: 0x0068D909
	public void SwitchState(EAnimalPerformState state)
	{
		if (!this.Initialize)
		{
			return;
		}
		this.StateMachine.Switch(state);
	}

	// Token: 0x060166EE RID: 91886 RVA: 0x0068F724 File Offset: 0x0068D924
	public float GetWaitTime()
	{
		AnimalPerformStateBase animalPerformStateBase = this.StateMachine.GetState(this.StateMachine.CurrentState.Value) as AnimalPerformStateBase;
		if (animalPerformStateBase == null)
		{
			return 0f;
		}
		return animalPerformStateBase.GetActionTime();
	}

	// Token: 0x060166EF RID: 91887 RVA: 0x0068F763 File Offset: 0x0068D963
	public AnimalPerformStateBase GetState(EAnimalPerformState state)
	{
		if (!this.Initialize)
		{
			return null;
		}
		return this.StateMachine.GetState(state) as AnimalPerformStateBase;
	}

	// Token: 0x060166F0 RID: 91888 RVA: 0x0068F780 File Offset: 0x0068D980
	public AnimalPerformStateBase GetCurrentState()
	{
		if (!this.Initialize)
		{
			return null;
		}
		return this.GetState(this.StateMachine.CurrentState.Value);
	}

	// Token: 0x060166F1 RID: 91889 RVA: 0x0068F7B0 File Offset: 0x0068D9B0
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

	// Token: 0x060166F2 RID: 91890 RVA: 0x0068F81A File Offset: 0x0068DA1A
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

	// Token: 0x060166F3 RID: 91891 RVA: 0x0068F855 File Offset: 0x0068DA55
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

	// Token: 0x060166F4 RID: 91892 RVA: 0x0068F88C File Offset: 0x0068DA8C
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		AnimalStateMachineComponent animalStateMachineComponent = (AnimalStateMachineComponent)componentTemplate;
		this.ConfigId = animalStateMachineComponent.ConfigId;
		if (animalStateMachineComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		if (animalStateMachineComponent.EcologicalInterface == null)
		{
			this.EcologicalInterface = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.EcologicalInterface), "EcologicalInterface"))
		{
			return false;
		}
		if (animalStateMachineComponent.StateMachine == null)
		{
			this.StateMachine = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateMachine), "StateMachine"))
		{
			return false;
		}
		this.Initialize = animalStateMachineComponent.Initialize;
		return true;
	}

	// Token: 0x170022EE RID: 8942
	// (get) Token: 0x060166F5 RID: 91893 RVA: 0x0068F945 File Offset: 0x0068DB45
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170022EF RID: 8943
	// (get) Token: 0x060166F6 RID: 91894 RVA: 0x0068F948 File Offset: 0x0068DB48
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170022F0 RID: 8944
	// (get) Token: 0x060166F7 RID: 91895 RVA: 0x0068F94B File Offset: 0x0068DB4B
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170022F1 RID: 8945
	// (get) Token: 0x060166F8 RID: 91896 RVA: 0x0068F94E File Offset: 0x0068DB4E
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400BE30 RID: 48688
	private int ConfigId;

	// Token: 0x0400BE31 RID: 48689
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400BE32 RID: 48690
	private IBPI_AnimalEcological_C EcologicalInterface;

	// Token: 0x0400BE33 RID: 48691
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private StateMachine<Entity, EAnimalPerformState> StateMachine;

	// Token: 0x0400BE34 RID: 48692
	private readonly EAnimalPerformState StartState;

	// Token: 0x0400BE35 RID: 48693
	private bool Initialize;
}
