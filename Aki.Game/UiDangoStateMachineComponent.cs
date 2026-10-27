using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.NPC.Tuanzi;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002C9E RID: 11422
[NullableContext(2)]
[Nullable(0)]
public class UiDangoStateMachineComponent : UiModelComponentBase
{
	// Token: 0x06017DEF RID: 97775 RVA: 0x00611B97 File Offset: 0x0060FD97
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
	}

	// Token: 0x06017DF0 RID: 97776 RVA: 0x00611BBB File Offset: 0x0060FDBB
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnDangoMeshLoadComplete));
	}

	// Token: 0x06017DF1 RID: 97777 RVA: 0x00611BDF File Offset: 0x0060FDDF
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnDangoMeshLoadComplete));
	}

	// Token: 0x06017DF2 RID: 97778 RVA: 0x00611C03 File Offset: 0x0060FE03
	public void SetState(EDangoState dangoState, float stateParam = 0f, float stateParam2 = 0f)
	{
		this.DangoState = dangoState;
		this.DangoStateParam = stateParam;
		this.DangoStateParam2 = stateParam2;
		this.Execute();
	}

	// Token: 0x06017DF3 RID: 97779 RVA: 0x00611C20 File Offset: 0x0060FE20
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

	// Token: 0x06017DF4 RID: 97780 RVA: 0x00611C7C File Offset: 0x0060FE7C
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

	// Token: 0x06017DF5 RID: 97781 RVA: 0x00611CB3 File Offset: 0x0060FEB3
	public void OnDangoMeshLoadComplete()
	{
		this.Execute();
	}

	// Token: 0x0400B1F6 RID: 45558
	private EDangoState DangoState;

	// Token: 0x0400B1F7 RID: 45559
	private float DangoStateParam;

	// Token: 0x0400B1F8 RID: 45560
	private float DangoStateParam2;

	// Token: 0x0400B1F9 RID: 45561
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B1FA RID: 45562
	private UiModelActorComponent ActorComponent;
}
