using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

// Token: 0x02002795 RID: 10133
[NullableContext(1)]
[Nullable(0)]
public class NpcPerformInteractState : NpcPerformBaseState
{
	// Token: 0x06019675 RID: 104053 RVA: 0x007C4E37 File Offset: 0x007C3037
	public NpcPerformInteractState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x06019676 RID: 104054 RVA: 0x007C4E58 File Offset: 0x007C3058
	public override bool CanChangeFrom(ENpcPerformState fromState)
	{
		CommonNpcPerformComponent component = this.Owner.Entity.GetComponent<CommonNpcPerformComponent>();
		return this.HaveInteractConfig && fromState == ENpcPerformState.Idle && !component.IsInPlot;
	}

	// Token: 0x06019677 RID: 104055 RVA: 0x007C4E90 File Offset: 0x007C3090
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

	// Token: 0x06019678 RID: 104056 RVA: 0x007C4F34 File Offset: 0x007C3134
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

	// Token: 0x06019679 RID: 104057 RVA: 0x007C50B8 File Offset: 0x007C32B8
	protected override void OnUpdate(float delta)
	{
	}

	// Token: 0x0601967A RID: 104058 RVA: 0x007C50BC File Offset: 0x007C32BC
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

	// Token: 0x0601967B RID: 104059 RVA: 0x007C5144 File Offset: 0x007C3344
	protected override void OnDestroy()
	{
	}

	// Token: 0x0601967C RID: 104060 RVA: 0x007C5146 File Offset: 0x007C3346
	private void OnInteractPlotEnd()
	{
		this.StateMachine.Switch(ENpcPerformState.Idle);
	}

	// Token: 0x0400DE95 RID: 56981
	private string InteractMontage = "";

	// Token: 0x0400DE96 RID: 56982
	[Nullable(2)]
	private UAnimMontage MontagePlaying;

	// Token: 0x0400DE97 RID: 56983
	private bool HaveInteractConfig;

	// Token: 0x0400DE98 RID: 56984
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IEnumerable<IConditionalNpcPerformOnInteract> ConditionalInteractConfig;

	// Token: 0x0400DE99 RID: 56985
	private string ConditionalInteractMontage = "";

	// Token: 0x0400DE9A RID: 56986
	private bool NotInterrupMontageOnExit;
}
