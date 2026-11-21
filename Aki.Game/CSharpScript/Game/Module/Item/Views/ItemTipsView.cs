using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Item.Views
{
	// Token: 0x02004803 RID: 18435
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemTipsView : UiViewBase
	{
		// Token: 0x0602E492 RID: 189586 RVA: 0x00CE871C File Offset: 0x00CE691C
		public ItemTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602E493 RID: 189587 RVA: 0x00CE8730 File Offset: 0x00CE6930
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseBtn)),
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickCloseBtn))
			};
		}

		// Token: 0x0602E494 RID: 189588 RVA: 0x00CE87C8 File Offset: 0x00CE69C8
		protected override UniTask OnBeforeStartAsync()
		{
			ItemTipsView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ItemTipsView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E495 RID: 189589 RVA: 0x00CE880C File Offset: 0x00CE6A0C
		private UniTask CreateItemTips(ItemTipsData data)
		{
			ItemTipsView.<CreateItemTips>d__10 <CreateItemTips>d__;
			<CreateItemTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemTips>d__.<>4__this = this;
			<CreateItemTips>d__.data = data;
			<CreateItemTips>d__.<>1__state = -1;
			<CreateItemTips>d__.<>t__builder.Start<ItemTipsView.<CreateItemTips>d__10>(ref <CreateItemTips>d__);
			return <CreateItemTips>d__.<>t__builder.Task;
		}

		// Token: 0x0602E496 RID: 189590 RVA: 0x00CE8858 File Offset: 0x00CE6A58
		private UniTask CreatePowerTips(ItemTipsData data)
		{
			ItemTipsView.<CreatePowerTips>d__11 <CreatePowerTips>d__;
			<CreatePowerTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreatePowerTips>d__.<>4__this = this;
			<CreatePowerTips>d__.data = data;
			<CreatePowerTips>d__.<>1__state = -1;
			<CreatePowerTips>d__.<>t__builder.Start<ItemTipsView.<CreatePowerTips>d__11>(ref <CreatePowerTips>d__);
			return <CreatePowerTips>d__.<>t__builder.Task;
		}

		// Token: 0x0602E497 RID: 189591 RVA: 0x00CE88A4 File Offset: 0x00CE6AA4
		private UniTask CreateCardTips(ItemTipsData data)
		{
			ItemTipsView.<CreateCardTips>d__12 <CreateCardTips>d__;
			<CreateCardTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCardTips>d__.<>4__this = this;
			<CreateCardTips>d__.data = data;
			<CreateCardTips>d__.<>1__state = -1;
			<CreateCardTips>d__.<>t__builder.Start<ItemTipsView.<CreateCardTips>d__12>(ref <CreateCardTips>d__);
			return <CreateCardTips>d__.<>t__builder.Task;
		}

		// Token: 0x0602E498 RID: 189592 RVA: 0x00CE88F0 File Offset: 0x00CE6AF0
		private UniTask CreateHonamiStoryTips(ItemTipsData data)
		{
			ItemTipsView.<CreateHonamiStoryTips>d__13 <CreateHonamiStoryTips>d__;
			<CreateHonamiStoryTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateHonamiStoryTips>d__.<>4__this = this;
			<CreateHonamiStoryTips>d__.data = data;
			<CreateHonamiStoryTips>d__.<>1__state = -1;
			<CreateHonamiStoryTips>d__.<>t__builder.Start<ItemTipsView.<CreateHonamiStoryTips>d__13>(ref <CreateHonamiStoryTips>d__);
			return <CreateHonamiStoryTips>d__.<>t__builder.Task;
		}

		// Token: 0x0602E499 RID: 189593 RVA: 0x00CE893C File Offset: 0x00CE6B3C
		private UniTask CreateTitleTips(int titleId)
		{
			ItemTipsView.<CreateTitleTips>d__14 <CreateTitleTips>d__;
			<CreateTitleTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateTitleTips>d__.<>4__this = this;
			<CreateTitleTips>d__.titleId = titleId;
			<CreateTitleTips>d__.<>1__state = -1;
			<CreateTitleTips>d__.<>t__builder.Start<ItemTipsView.<CreateTitleTips>d__14>(ref <CreateTitleTips>d__);
			return <CreateTitleTips>d__.<>t__builder.Task;
		}

		// Token: 0x0602E49A RID: 189594 RVA: 0x00CE8988 File Offset: 0x00CE6B88
		private UniTask CreateFurnitureTips(ItemTipsData data)
		{
			ItemTipsView.<CreateFurnitureTips>d__15 <CreateFurnitureTips>d__;
			<CreateFurnitureTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateFurnitureTips>d__.<>4__this = this;
			<CreateFurnitureTips>d__.data = data;
			<CreateFurnitureTips>d__.<>1__state = -1;
			<CreateFurnitureTips>d__.<>t__builder.Start<ItemTipsView.<CreateFurnitureTips>d__15>(ref <CreateFurnitureTips>d__);
			return <CreateFurnitureTips>d__.<>t__builder.Task;
		}

		// Token: 0x0602E49B RID: 189595 RVA: 0x00CE89D4 File Offset: 0x00CE6BD4
		private UniTask CreatePinballItemTips(ItemTipsData data)
		{
			ItemTipsView.<CreatePinballItemTips>d__16 <CreatePinballItemTips>d__;
			<CreatePinballItemTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreatePinballItemTips>d__.<>4__this = this;
			<CreatePinballItemTips>d__.data = data;
			<CreatePinballItemTips>d__.<>1__state = -1;
			<CreatePinballItemTips>d__.<>t__builder.Start<ItemTipsView.<CreatePinballItemTips>d__16>(ref <CreatePinballItemTips>d__);
			return <CreatePinballItemTips>d__.<>t__builder.Task;
		}

		// Token: 0x0602E49C RID: 189596 RVA: 0x00CE8A1F File Offset: 0x00CE6C1F
		protected override void OnBeforeShow()
		{
			IItemTipsUiProxy tipsProxy = this.TipsProxy;
			if (tipsProxy == null)
			{
				return;
			}
			tipsProxy.SetActive(true);
		}

		// Token: 0x0602E49D RID: 189597 RVA: 0x00CE8A32 File Offset: 0x00CE6C32
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EUiTabViewName, int?>(EEventName.ChangeChildView, new Action<EUiTabViewName, int?>(this.OnChangeChildView));
		}

		// Token: 0x0602E49E RID: 189598 RVA: 0x00CE8A4D File Offset: 0x00CE6C4D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.ChangeChildView, new Action<EUiTabViewName, int?>(this.OnChangeChildView));
		}

		// Token: 0x0602E49F RID: 189599 RVA: 0x00CE8A68 File Offset: 0x00CE6C68
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Emit<int, int>(EEventName.CloseItemTips, this.ConfigId, this.IncId);
		}

		// Token: 0x0602E4A0 RID: 189600 RVA: 0x00CE8A88 File Offset: 0x00CE6C88
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			ItemTipsView.<OnPlayingCloseSequenceAsync>d__21 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<ItemTipsView.<OnPlayingCloseSequenceAsync>d__21>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E4A1 RID: 189601 RVA: 0x00CE8ACB File Offset: 0x00CE6CCB
		private void OnClickCloseBtn()
		{
			UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.ItemTips);
			this.DoCloseMe();
		}

		// Token: 0x0602E4A2 RID: 189602 RVA: 0x00CE8ADA File Offset: 0x00CE6CDA
		private void OnChangeChildView(EUiTabViewName eUiTabViewName, int? o)
		{
			this.DoCloseMe();
		}

		// Token: 0x0602E4A3 RID: 189603 RVA: 0x00CE8AE2 File Offset: 0x00CE6CE2
		protected void DoCloseMe()
		{
			base.CloseMe(null);
		}

		// Token: 0x04018A73 RID: 100979
		protected int IncId;

		// Token: 0x04018A74 RID: 100980
		protected int ConfigId;

		// Token: 0x04018A75 RID: 100981
		[Nullable(2)]
		protected object ExtraParam;

		// Token: 0x04018A76 RID: 100982
		protected bool HideNum;

		// Token: 0x04018A77 RID: 100983
		protected ETipsUiType UiTipsType = ETipsUiType.ItemTipsComponent;

		// Token: 0x04018A78 RID: 100984
		[Nullable(2)]
		protected IItemTipsUiProxy TipsProxy;

		// Token: 0x0200A439 RID: 42041
		[NullableContext(0)]
		private class EItemTipsViewDefine
		{
			// Token: 0x04032E07 RID: 208391
			public const int MaskCloseBtn = 0;

			// Token: 0x04032E08 RID: 208392
			public const int Content = 1;

			// Token: 0x04032E09 RID: 208393
			public const int CloseBtn = 2;
		}
	}
}
