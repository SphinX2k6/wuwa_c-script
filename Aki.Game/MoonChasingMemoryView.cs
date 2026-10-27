using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001346 RID: 4934
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingMemoryView : UiViewBase
{
	// Token: 0x0600895C RID: 35164 RVA: 0x001D54FE File Offset: 0x001D36FE
	public MoonChasingMemoryView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600895D RID: 35165 RVA: 0x001D5514 File Offset: 0x001D3714
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIDraggableComponent))
		};
	}

	// Token: 0x0600895E RID: 35166 RVA: 0x001D5570 File Offset: 0x001D3770
	protected override UniTask OnBeforeStartAsync()
	{
		MoonChasingMemoryView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MoonChasingMemoryView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600895F RID: 35167 RVA: 0x001D55B3 File Offset: 0x001D37B3
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(delegate
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x06008960 RID: 35168 RVA: 0x001D55E0 File Offset: 0x001D37E0
	protected override void OnBeforeShow()
	{
		bool redDotVisible = MoonChasingModel.Instance.CheckMemoryRedDotState();
		this.DetailBtn.SetRedDotVisible(redDotVisible);
	}

	// Token: 0x06008961 RID: 35169 RVA: 0x001D5604 File Offset: 0x001D3804
	protected override void OnBeforeDestroy()
	{
		this.MoveComponent.Destroy();
	}

	// Token: 0x06008962 RID: 35170 RVA: 0x001D5611 File Offset: 0x001D3811
	private void InitBtn()
	{
		this.DetailBtn = new ButtonItem(base.GetItem(1));
		this.DetailBtn.SetFunction(delegate(int _)
		{
			this.OnButtonJump();
		});
	}

	// Token: 0x06008963 RID: 35171 RVA: 0x001D563C File Offset: 0x001D383C
	private void InitMoveComponent()
	{
		this.MoveComponent = new BuildingMapMoveComponent(base.GetDraggable(2), false, false, false);
		float valueOrDefault = ConfigCommonParamById.GetFloatConfig("MoonFiestaMapSizeParam").GetValueOrDefault(1f);
		this.MoveComponent.SetScaleSafeArea((double)valueOrDefault, 2.0);
		this.MoveComponent.SetScale((double)valueOrDefault, ESetScaleSource.Other, null);
	}

	// Token: 0x06008964 RID: 35172 RVA: 0x001D569C File Offset: 0x001D389C
	private UniTask InitMapTile()
	{
		MoonChasingMemoryView.<InitMapTile>d__14 <InitMapTile>d__;
		<InitMapTile>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitMapTile>d__.<>4__this = this;
		<InitMapTile>d__.<>1__state = -1;
		<InitMapTile>d__.<>t__builder.Start<MoonChasingMemoryView.<InitMapTile>d__14>(ref <InitMapTile>d__);
		return <InitMapTile>d__.<>t__builder.Task;
	}

	// Token: 0x06008965 RID: 35173 RVA: 0x001D56DF File Offset: 0x001D38DF
	private void OnButtonJump()
	{
		UiManager.Instance.OpenView(EUiViewName.MoonChasingMemoryDetailView, this.MemoryItemData, null);
		MoonChasingModel.Instance.RemoveMemoryRedDot();
	}

	// Token: 0x04003D44 RID: 15684
	[Nullable(2)]
	private BuildingMapTileModule MapTile;

	// Token: 0x04003D45 RID: 15685
	private BuildingMapMoveComponent MoveComponent;

	// Token: 0x04003D46 RID: 15686
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003D47 RID: 15687
	private ButtonItem DetailBtn;

	// Token: 0x04003D48 RID: 15688
	private List<IMemoryItemData> MemoryItemData = new List<IMemoryItemData>();

	// Token: 0x020079A8 RID: 31144
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x040280F3 RID: 164083
		public const int Caption = 0;

		// Token: 0x040280F4 RID: 164084
		public const int Button = 1;

		// Token: 0x040280F5 RID: 164085
		public const int MapItem = 2;
	}
}
