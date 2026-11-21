using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020021E5 RID: 8677
[NullableContext(2)]
[Nullable(0)]
public class UiModelLoadingIconComponent : UiModelComponentBase
{
	// Token: 0x060155BB RID: 87483 RVA: 0x00635E80 File Offset: 0x00634080
	protected override void OnInit()
	{
		this.LoadingItem = new RoleModelLoadingItem();
		this.LoadingItem.CreateByResourceIdAsync("UiItem_Loading_Prefab", UiLayer.Instance.GetLayerRootUiItem(ELayerType.Pop), false).Forget();
		this.UiModelActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.UiModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
	}

	// Token: 0x060155BC RID: 87484 RVA: 0x00635EDC File Offset: 0x006340DC
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.BeforeModelLoadStart));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x060155BD RID: 87485 RVA: 0x00635F2D File Offset: 0x0063412D
	protected override void OnTick(float deltaTime)
	{
		this.RefreshIconPosition();
	}

	// Token: 0x060155BE RID: 87486 RVA: 0x00635F38 File Offset: 0x00634138
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.BeforeModelLoadStart));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
		this.LoadingItem.Destroy(null);
	}

	// Token: 0x060155BF RID: 87487 RVA: 0x00635F95 File Offset: 0x00634195
	private void BeforeModelLoadStart()
	{
		this.NeedTick = true;
		this.RefreshIconPosition();
		this.LoadingItem.SetLoadingActive(true);
	}

	// Token: 0x060155C0 RID: 87488 RVA: 0x00635FB0 File Offset: 0x006341B0
	private void OnModelLoadComplete()
	{
		this.NeedTick = false;
		this.LoadingItem.SetLoadingActive(false);
	}

	// Token: 0x060155C1 RID: 87489 RVA: 0x00635FC5 File Offset: 0x006341C5
	public void SetLoadingOpen(bool isOpen)
	{
		this.LoadingItem.SetLoadingOpen(isOpen);
	}

	// Token: 0x060155C2 RID: 87490 RVA: 0x00635FD3 File Offset: 0x006341D3
	public void SetLoadingActive(bool state)
	{
		this.LoadingItem.SetLoadingActive(state);
	}

	// Token: 0x060155C3 RID: 87491 RVA: 0x00635FE1 File Offset: 0x006341E1
	public void SetFollowUiItem(UUIItem item)
	{
		this.FollowUiItem = item;
		if (this.NeedTick)
		{
			this.RefreshIconPosition();
		}
	}

	// Token: 0x060155C4 RID: 87492 RVA: 0x00635FF8 File Offset: 0x006341F8
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

	// Token: 0x0400B524 RID: 46372
	protected UiModelActorComponent UiModelActorComponent;

	// Token: 0x0400B525 RID: 46373
	protected UiModelDataComponent UiModelDataComponent;

	// Token: 0x0400B526 RID: 46374
	protected RoleModelLoadingItem LoadingItem;

	// Token: 0x0400B527 RID: 46375
	private UUIItem FollowUiItem;
}
