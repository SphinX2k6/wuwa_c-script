using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002C8C RID: 11404
[NullableContext(2)]
[Nullable(0)]
public class UiModelLoadingIconComponent : UiModelComponentBase
{
	// Token: 0x06017D47 RID: 97607 RVA: 0x006102E0 File Offset: 0x0060E4E0
	protected override void OnInit()
	{
		this.LoadingItem = new RoleModelLoadingItem();
		this.LoadingItem.CreateByResourceIdAsync("UiItem_Loading_Prefab", UiLayer.Instance.GetLayerRootUiItem(ELayerType.Pop), false).Forget();
		this.UiModelActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.UiModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
	}

	// Token: 0x06017D48 RID: 97608 RVA: 0x0061033C File Offset: 0x0060E53C
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.BeforeModelLoadStart));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x06017D49 RID: 97609 RVA: 0x0061038D File Offset: 0x0060E58D
	protected override void OnTick(float deltaTime)
	{
		this.RefreshIconPosition();
	}

	// Token: 0x06017D4A RID: 97610 RVA: 0x00610398 File Offset: 0x0060E598
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.BeforeModelLoadStart));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
		this.LoadingItem.Destroy(null);
	}

	// Token: 0x06017D4B RID: 97611 RVA: 0x006103F5 File Offset: 0x0060E5F5
	private void BeforeModelLoadStart()
	{
		this.NeedTick = true;
		this.RefreshIconPosition();
		this.LoadingItem.SetLoadingActive(true);
	}

	// Token: 0x06017D4C RID: 97612 RVA: 0x00610410 File Offset: 0x0060E610
	private void OnModelLoadComplete()
	{
		this.NeedTick = false;
		this.LoadingItem.SetLoadingActive(false);
	}

	// Token: 0x06017D4D RID: 97613 RVA: 0x00610425 File Offset: 0x0060E625
	public void SetLoadingOpen(bool isOpen)
	{
		this.LoadingItem.SetLoadingOpen(isOpen);
	}

	// Token: 0x06017D4E RID: 97614 RVA: 0x00610433 File Offset: 0x0060E633
	public void SetLoadingActive(bool state)
	{
		this.LoadingItem.SetLoadingActive(state);
	}

	// Token: 0x06017D4F RID: 97615 RVA: 0x00610441 File Offset: 0x0060E641
	public void SetFollowUiItem(UUIItem item)
	{
		this.FollowUiItem = item;
		if (this.NeedTick)
		{
			this.RefreshIconPosition();
		}
	}

	// Token: 0x06017D50 RID: 97616 RVA: 0x00610458 File Offset: 0x0060E658
	private void RefreshIconPosition()
	{
		UUIItem followUiItem = this.FollowUiItem;
		if (followUiItem != null)
		{
			if (followUiItem.IsValid())
			{
				FVector lguispaceAbsolutePosition = followUiItem.GetLGUISpaceAbsolutePosition();
				FVector2D pivot = followUiItem.GetPivot();
				UUIItem layerRootUiItem = UiLayer.Instance.GetLayerRootUiItem(ELayerType.Pop);
				if (layerRootUiItem == null)
				{
					return;
				}
				FVector lguispaceAbsolutePosition2 = layerRootUiItem.GetLGUISpaceAbsolutePosition();
				FVector2D pivot2 = layerRootUiItem.GetPivot();
				float num = lguispaceAbsolutePosition2.X + (0.5f - pivot2.X) * layerRootUiItem.GetWidth();
				float num2 = lguispaceAbsolutePosition2.Y + (0.5f - pivot2.Y) * layerRootUiItem.GetHeight();
				FVector2D iconPosition = new FVector2D(lguispaceAbsolutePosition.X + (0.5f - pivot.X) * followUiItem.GetWidth() - num, lguispaceAbsolutePosition.Y + (0.5f - pivot.Y) * followUiItem.GetHeight() - num2);
				this.LoadingItem.SetIconPosition(iconPosition);
			}
			return;
		}
		UiModelDataComponent uiModelDataComponent = this.UiModelDataComponent;
		if (((uiModelDataComponent != null) ? new bool?(uiModelDataComponent.GetLoadingIconFollowState()) : null).GetValueOrDefault() && this.UiModelActorComponent != null)
		{
			FVector2D actorLguiPos = UiModelUtil.Instance.GetActorLguiPos(this.UiModelActorComponent.GetActor(), null);
			this.LoadingItem.SetIconPosition(actorLguiPos);
		}
	}

	// Token: 0x0400B1B9 RID: 45497
	protected UiModelActorComponent UiModelActorComponent;

	// Token: 0x0400B1BA RID: 45498
	protected UiModelDataComponent UiModelDataComponent;

	// Token: 0x0400B1BB RID: 45499
	protected RoleModelLoadingItem LoadingItem;

	// Token: 0x0400B1BC RID: 45500
	private UUIItem FollowUiItem;
}
