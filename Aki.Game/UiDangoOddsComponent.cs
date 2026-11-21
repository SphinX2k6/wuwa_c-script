using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020021F6 RID: 8694
[NullableContext(1)]
[Nullable(0)]
public class UiDangoOddsComponent : UiModelComponentBase
{
	// Token: 0x06015659 RID: 87641 RVA: 0x00637558 File Offset: 0x00635758
	protected override void OnInit()
	{
		this.UiOddsItem = new RacingBetsOddsItem();
		this.UiOddsItem.CreateByResourceIdAsync("UiItem_RoleBetNum", UiLayer.Instance.GetLayerRootUiItem(ELayerType.Pop), false);
		this.NeedTick = true;
		this.UiModelActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.UiModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
	}

	// Token: 0x0601565A RID: 87642 RVA: 0x006375B7 File Offset: 0x006357B7
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x0601565B RID: 87643 RVA: 0x006375DB File Offset: 0x006357DB
	protected override void OnTick(float deltaTime)
	{
		this.FollowRootPosition();
	}

	// Token: 0x0601565C RID: 87644 RVA: 0x006375E3 File Offset: 0x006357E3
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
		this.UiOddsItem.Destroy(null);
	}

	// Token: 0x0601565D RID: 87645 RVA: 0x00637613 File Offset: 0x00635813
	private void OnModelLoadComplete()
	{
		this.FollowRootPosition();
	}

	// Token: 0x0601565E RID: 87646 RVA: 0x0063761C File Offset: 0x0063581C
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

	// Token: 0x0601565F RID: 87647 RVA: 0x00637685 File Offset: 0x00635885
	public void SetOffset(float offset)
	{
		if (offset == 0f)
		{
			return;
		}
		this.OddsOffset.Z = (double)offset;
	}

	// Token: 0x06015660 RID: 87648 RVA: 0x0063769D File Offset: 0x0063589D
	public void Refresh(int odds, int rank, bool isBet)
	{
		this.UiOddsItem.RefreshUi(odds, rank, isBet);
	}

	// Token: 0x06015661 RID: 87649 RVA: 0x006376AD File Offset: 0x006358AD
	public void SetVisible(bool visible)
	{
		this.UiOddsItem.SetVisible(visible);
	}

	// Token: 0x0400B55C RID: 46428
	protected UiModelActorComponent UiModelActorComponent;

	// Token: 0x0400B55D RID: 46429
	protected UiModelDataComponent UiModelDataComponent;

	// Token: 0x0400B55E RID: 46430
	protected RacingBetsOddsItem UiOddsItem;

	// Token: 0x0400B55F RID: 46431
	private readonly Vector OddsOffset = Vector.Create(0.0, 0.0, 120.0);

	// Token: 0x0400B560 RID: 46432
	private readonly Vector TargetOffset = Vector.Create(0.0, 0.0, 120.0);
}
