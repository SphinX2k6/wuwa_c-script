using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

// Token: 0x02003226 RID: 12838
[NullableContext(1)]
[Nullable(0)]
public class NpcPerformInteractState : NpcPerformBaseState
{
	// Token: 0x0601BAF0 RID: 113392 RVA: 0x0079C69B File Offset: 0x0079A89B
	public NpcPerformInteractState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x0601BAF1 RID: 113393 RVA: 0x0079C6BC File Offset: 0x0079A8BC
	public override bool CanChangeFrom(ENpcPerformState fromState)
	{
		CommonNpcPerformComponent component = this.Owner.Entity.GetComponent<CommonNpcPerformComponent>();
		return this.HaveInteractConfig && fromState == ENpcPerformState.Idle && !component.IsInPlot;
	}

	// Token: 0x0601BAF2 RID: 113394 RVA: 0x0079C6F4 File Offset: 0x0079A8F4
	[NullableContext(2)]
	protected override void OnCreate(IEntityArgs args = null)
	{
		base.OnCreate(args);
		Aki.TDConfigMgr.Component.NpcPerformComponent p = args.GetP1<Aki.TDConfigMgr.Component.NpcPerformComponent>();
		string value;
		if (p == null)
		{
			value = null;
		}
		else
		{
			INpcPerformOnInteract showOnInteract = p.ShowOnInteract;
			value = ((showOnInteract != null) ? showOnInteract.Montage : null);
		}
		if (string.IsNullOrEmpty(value) && ((p != null) ? p.ConditionalShowOnInteracts : null) == null)
		{
			this.HaveInteractConfig = false;
			return;
		}
		this.HaveInteractConfig = true;
		string value2;
		if (p == null)
		{
			value2 = null;
		}
		else
		{
			INpcPerformOnInteract showOnInteract2 = p.ShowOnInteract;
			value2 = ((showOnInteract2 != null) ? showOnInteract2.Montage : null);
		}
		if (!string.IsNullOrEmpty(value2))
		{
			this.InteractMontage = p.ShowOnInteract.Montage;
			return;
		}
		if (((p != null) ? p.ConditionalShowOnInteracts : null) != null)
		{
			this.ConditionalInteractConfig = p.ConditionalShowOnInteracts;
		}
	}

	// Token: 0x0601BAF3 RID: 113395 RVA: 0x0079C798 File Offset: 0x0079A998
	protected override void OnEnter(ENpcPerformState? lastState)
	{
		if (!string.IsNullOrEmpty(this.InteractMontage))
		{
			ResourceSystem.Instance.LoadAsync<UAnimMontage>(this.InteractMontage, delegate([Nullable(2)] UAnimMontage asset, string path)
			{
				if (asset == null || !asset.IsValid())
				{
					return;
				}
				EntityHandle owner = this.Owner;
				if (owner == null || !owner.Valid)
				{
					return;
				}
				base.PlayMontage(new IPlayMontageParam
				{
					MontageAsset = asset
				});
				this.MontagePlaying = asset;
			}, 100, "js_undefined");
		}
		EventSystem.Instance.AddWithTarget(this.Owner, EEventName.OnInteractPlotEnd, new Action(this.OnInteractPlotEnd));
		this.ConditionalInteractMontage = "";
		this.NotInterrupMontageOnExit = false;
		if (this.ConditionalInteractConfig != null)
		{
			CharacterActorComponent component = this.Owner.Entity.GetComponent<CharacterActorComponent>();
			foreach (IConditionalNpcPerformOnInteract conditionalNpcPerformOnInteract in this.ConditionalInteractConfig)
			{
				if (LevelGeneralController.Instance.CheckConditionNew(conditionalNpcPerformOnInteract.Condition, component.Owner, EntityContext.Create(this.ActorComp.Entity.Id, null), null))
				{
					this.ConditionalInteractMontage = conditionalNpcPerformOnInteract.Perform.Montage;
					if (conditionalNpcPerformOnInteract.Perform.NotInterruptMontageWhenFinishedInteract != null)
					{
						this.NotInterrupMontageOnExit = conditionalNpcPerformOnInteract.Perform.NotInterruptMontageWhenFinishedInteract.Value;
						break;
					}
					break;
				}
			}
			if (!string.IsNullOrEmpty(this.ConditionalInteractMontage))
			{
				ResourceSystem.Instance.LoadAsync<UAnimMontage>(this.ConditionalInteractMontage, delegate([Nullable(2)] UAnimMontage asset, string path)
				{
					if (asset == null || !asset.IsValid())
					{
						return;
					}
					base.PlayMontage(new IPlayMontageParam
					{
						MontageAsset = asset
					});
					this.MontagePlaying = asset;
				}, 100, "js_undefined");
			}
		}
	}

	// Token: 0x0601BAF4 RID: 113396 RVA: 0x0079C91C File Offset: 0x0079AB1C
	protected override void OnUpdate(float delta)
	{
	}

	// Token: 0x0601BAF5 RID: 113397 RVA: 0x0079C920 File Offset: 0x0079AB20
	protected override void OnExit(ENpcPerformState nextState)
	{
		EventSystem.Instance.RemoveWithTarget(this.Owner, EEventName.OnInteractPlotEnd, new Action(this.OnInteractPlotEnd));
		this.Owner.Entity.GetComponent<CharacterActorComponent>().ClearInput(false, true);
		if (!this.NotInterrupMontageOnExit)
		{
			base.StopMontage(new IStopMontageParam
			{
				Method = new EStopMethod?(EStopMethod.BlendOut),
				BlendOutTime = new float?(0.5f),
				Montage = this.MontagePlaying
			});
			this.MontagePlaying = null;
		}
	}

	// Token: 0x0601BAF6 RID: 113398 RVA: 0x0079C9A8 File Offset: 0x0079ABA8
	protected override void OnDestroy()
	{
	}

	// Token: 0x0601BAF7 RID: 113399 RVA: 0x0079C9AA File Offset: 0x0079ABAA
	private void OnInteractPlotEnd()
	{
		this.StateMachine.Switch(ENpcPerformState.Idle);
	}

	// Token: 0x0400D9F6 RID: 55798
	private string InteractMontage = "";

	// Token: 0x0400D9F7 RID: 55799
	[Nullable(2)]
	private UAnimMontage MontagePlaying;

	// Token: 0x0400D9F8 RID: 55800
	private bool HaveInteractConfig;

	// Token: 0x0400D9F9 RID: 55801
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IEnumerable<IConditionalNpcPerformOnInteract> ConditionalInteractConfig;

	// Token: 0x0400D9FA RID: 55802
	private string ConditionalInteractMontage = "";

	// Token: 0x0400D9FB RID: 55803
	private bool NotInterrupMontageOnExit;
}
