using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002C9D RID: 11421
[NullableContext(1)]
[Nullable(0)]
public class UiDangoOddsComponent : UiModelComponentBase
{
	// Token: 0x06017DE5 RID: 97765 RVA: 0x006119D4 File Offset: 0x0060FBD4
	protected override void OnInit()
	{
		this.UiOddsItem = new RacingBetsOddsItem();
		this.UiOddsItem.CreateByResourceIdAsync("UiItem_RoleBetNum", UiLayer.Instance.GetLayerRootUiItem(ELayerType.Pop), false);
		this.NeedTick = true;
		this.UiModelActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.UiModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
	}

	// Token: 0x06017DE6 RID: 97766 RVA: 0x00611A33 File Offset: 0x0060FC33
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x06017DE7 RID: 97767 RVA: 0x00611A57 File Offset: 0x0060FC57
	protected override void OnTick(float deltaTime)
	{
		this.FollowRootPosition();
	}

	// Token: 0x06017DE8 RID: 97768 RVA: 0x00611A5F File Offset: 0x0060FC5F
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
		this.UiOddsItem.Destroy(null);
	}

	// Token: 0x06017DE9 RID: 97769 RVA: 0x00611A8F File Offset: 0x0060FC8F
	private void OnModelLoadComplete()
	{
		this.FollowRootPosition();
	}

	// Token: 0x06017DEA RID: 97770 RVA: 0x00611A98 File Offset: 0x0060FC98
	private void FollowRootPosition()
	{
		if (this.UiModelActorComponent != null)
		{
			AActor actor = this.UiModelActorComponent.GetActor();
			float z = this.UiModelActorComponent.Actor.GetActorScale3D().Z;
			this.OddsOffset.Multiply((double)z, this.TargetOffset);
			FVector2D actorLguiPos = UiModelUtil.Instance.GetActorLguiPos(actor, this.TargetOffset);
			this.UiOddsItem.SetItemOffset(actorLguiPos);
		}
	}

	// Token: 0x06017DEB RID: 97771 RVA: 0x00611B01 File Offset: 0x0060FD01
	public void SetOffset(float offset)
	{
		if (offset == 0f)
		{
			return;
		}
		this.OddsOffset.Z = (double)offset;
	}

	// Token: 0x06017DEC RID: 97772 RVA: 0x00611B19 File Offset: 0x0060FD19
	public void Refresh(int odds, int rank, bool isBet)
	{
		this.UiOddsItem.RefreshUi(odds, rank, isBet);
	}

	// Token: 0x06017DED RID: 97773 RVA: 0x00611B29 File Offset: 0x0060FD29
	public void SetVisible(bool visible)
	{
		this.UiOddsItem.SetVisible(visible);
	}

	// Token: 0x0400B1F1 RID: 45553
	protected UiModelActorComponent UiModelActorComponent;

	// Token: 0x0400B1F2 RID: 45554
	protected UiModelDataComponent UiModelDataComponent;

	// Token: 0x0400B1F3 RID: 45555
	protected RacingBetsOddsItem UiOddsItem;

	// Token: 0x0400B1F4 RID: 45556
	private readonly Vector OddsOffset = Vector.Create(0.0, 0.0, 120.0);

	// Token: 0x0400B1F5 RID: 45557
	private readonly Vector TargetOffset = Vector.Create(0.0, 0.0, 120.0);
}
