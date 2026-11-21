using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007FA RID: 2042
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingMemoryView : UiViewBase
{
	// Token: 0x06005CF7 RID: 23799 RVA: 0x001DE36A File Offset: 0x001DC56A
	public MoonChasingMemoryView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005CF8 RID: 23800 RVA: 0x001DE380 File Offset: 0x001DC580
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIDraggableComponent))
		};
	}

	// Token: 0x06005CF9 RID: 23801 RVA: 0x001DE3DC File Offset: 0x001DC5DC
	protected override UniTask OnBeforeStartAsync()
	{
		MoonChasingMemoryView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MoonChasingMemoryView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005CFA RID: 23802 RVA: 0x001DE41F File Offset: 0x001DC61F
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(delegate
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x06005CFB RID: 23803 RVA: 0x001DE44C File Offset: 0x001DC64C
	protected override void OnBeforeShow()
	{
		bool redDotVisible = MoonChasingModel.Instance.CheckMemoryRedDotState();
		this.DetailBtn.SetRedDotVisible(redDotVisible);
	}

	// Token: 0x06005CFC RID: 23804 RVA: 0x001DE470 File Offset: 0x001DC670
	protected override void OnBeforeDestroy()
	{
		this.MoveComponent.Destroy();
	}

	// Token: 0x06005CFD RID: 23805 RVA: 0x001DE47D File Offset: 0x001DC67D
	private void InitBtn()
	{
		this.DetailBtn = new ButtonItem(base.GetItem(1));
		this.DetailBtn.SetFunction(delegate(int _)
		{
			this.OnButtonJump();
		});
	}

	// Token: 0x06005CFE RID: 23806 RVA: 0x001DE4A8 File Offset: 0x001DC6A8
	private void InitMoveComponent()
	{
		this.MoveComponent = new BuildingMapMoveComponent(base.GetDraggable(2), false, false, false);
		float valueOrDefault = ConfigCommonParamById.GetFloatConfig("MoonFiestaMapSizeParam").GetValueOrDefault(1f);
		this.MoveComponent.SetScaleSafeArea((double)valueOrDefault, 2.0);
		this.MoveComponent.SetScale((double)valueOrDefault, ESetScaleSource.Other, null);
	}

	// Token: 0x06005CFF RID: 23807 RVA: 0x001DE508 File Offset: 0x001DC708
	private UniTask InitMapTile()
	{
		MoonChasingMemoryView.<InitMapTile>d__14 <InitMapTile>d__;
		<InitMapTile>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitMapTile>d__.<>4__this = this;
		<InitMapTile>d__.<>1__state = -1;
		<InitMapTile>d__.<>t__builder.Start<MoonChasingMemoryView.<InitMapTile>d__14>(ref <InitMapTile>d__);
		return <InitMapTile>d__.<>t__builder.Task;
	}

	// Token: 0x06005D00 RID: 23808 RVA: 0x001DE54B File Offset: 0x001DC74B
	private void OnButtonJump()
	{
		UiManager.Instance.OpenView(EUiViewName.MoonChasingMemoryDetailView, this.MemoryItemData, null);
		MoonChasingModel.Instance.RemoveMemoryRedDot();
	}

	// Token: 0x04003DDC RID: 15836
	[Nullable(2)]
	private BuildingMapTileModule MapTile;

	// Token: 0x04003DDD RID: 15837
	private BuildingMapMoveComponent MoveComponent;

	// Token: 0x04003DDE RID: 15838
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003DDF RID: 15839
	private ButtonItem DetailBtn;

	// Token: 0x04003DE0 RID: 15840
	private List<IMemoryItemData> MemoryItemData = new List<IMemoryItemData>();

	// Token: 0x02006B32 RID: 27442
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04023420 RID: 144416
		public const int Caption = 0;

		// Token: 0x04023421 RID: 144417
		public const int Button = 1;

		// Token: 0x04023422 RID: 144418
		public const int MapItem = 2;
	}
}
