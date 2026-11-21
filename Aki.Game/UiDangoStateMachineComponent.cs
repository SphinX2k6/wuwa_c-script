using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.NPC.Tuanzi;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020021F7 RID: 8695
[NullableContext(2)]
[Nullable(0)]
public class UiDangoStateMachineComponent : UiModelComponentBase
{
	// Token: 0x06015663 RID: 87651 RVA: 0x0063771B File Offset: 0x0063591B
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
	}

	// Token: 0x06015664 RID: 87652 RVA: 0x0063773F File Offset: 0x0063593F
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnDangoMeshLoadComplete));
	}

	// Token: 0x06015665 RID: 87653 RVA: 0x00637763 File Offset: 0x00635963
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnDangoMeshLoadComplete));
	}

	// Token: 0x06015666 RID: 87654 RVA: 0x00637787 File Offset: 0x00635987
	public void SetState(EDangoState dangoState, float stateParam = 0f, float stateParam2 = 0f)
	{
		this.DangoState = dangoState;
		this.DangoStateParam = stateParam;
		this.DangoStateParam2 = stateParam2;
		this.Execute();
	}

	// Token: 0x06015667 RID: 87655 RVA: 0x006377A4 File Offset: 0x006359A4
	private void Execute()
	{
		if (this.ModelDataComponent.GetModelLoadState() != EUiModelLoadState.LoadComplete)
		{
			return;
		}
		ABP_TuanziNPC_C dangoBp = this.GetDangoBp();
		EDangoState dangoState = this.DangoState;
		if (dangoState != EDangoState.ActionPerform)
		{
			if (dangoState != EDangoState.MoveJump)
			{
				return;
			}
			if (dangoBp != null)
			{
				dangoBp.StartJumpWithParams(this.DangoStateParam, this.DangoStateParam2);
			}
		}
		else if (dangoBp != null)
		{
			dangoBp.StartActionPerform((EDangoActionPerformType)this.DangoStateParam);
			return;
		}
	}

	// Token: 0x06015668 RID: 87656 RVA: 0x00637800 File Offset: 0x00635A00
	public ABP_TuanziNPC_C GetDangoBp()
	{
		UiModelActorComponent actorComponent = this.ActorComponent;
		USkeletalMeshComponent uskeletalMeshComponent = (actorComponent != null) ? actorComponent.MainMeshComponent : null;
		if (uskeletalMeshComponent == null)
		{
			return null;
		}
		UiModelActorComponent actorComponent2 = this.ActorComponent;
		if (actorComponent2 == null)
		{
			return null;
		}
		return actorComponent2.GetDangoAnimInstanceFromSkeletalMesh(uskeletalMeshComponent);
	}

	// Token: 0x06015669 RID: 87657 RVA: 0x00637837 File Offset: 0x00635A37
	public void OnDangoMeshLoadComplete()
	{
		this.Execute();
	}

	// Token: 0x0400B561 RID: 46433
	private EDangoState DangoState;

	// Token: 0x0400B562 RID: 46434
	private float DangoStateParam;

	// Token: 0x0400B563 RID: 46435
	private float DangoStateParam2;

	// Token: 0x0400B564 RID: 46436
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B565 RID: 46437
	private UiModelActorComponent ActorComponent;
}
