using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200509A RID: 20634
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeDetailView : UiViewBase
	{
		// Token: 0x06033A7F RID: 211583 RVA: 0x00E758AF File Offset: 0x00E73AAF
		public RoverlikeDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033A80 RID: 211584 RVA: 0x00E758C4 File Offset: 0x00E73AC4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033A81 RID: 211585 RVA: 0x00E75930 File Offset: 0x00E73B30
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeDetailView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeDetailView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033A82 RID: 211586 RVA: 0x00E75973 File Offset: 0x00E73B73
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06033A83 RID: 211587 RVA: 0x00E75978 File Offset: 0x00E73B78
		private void InitTabComponent()
		{
			CommonTabComponentData<RoverlikeTabItem> data = new CommonTabComponentData<RoverlikeTabItem>(new Func<UUIItem, int?, RoverlikeTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
			this.TabComponent = new TabComponentWithCaptionItem<RoverlikeTabItem>(base.GetItem(0), data, new Action(this.OnCloseClicked), false);
			this.TabComponent.SetHelpButtonShowState(false);
			this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
		}

		// Token: 0x06033A84 RID: 211588 RVA: 0x00E759F0 File Offset: 0x00E73BF0
		private UniTask RefreshTabListAsync()
		{
			RoverlikeDetailView.<RefreshTabListAsync>d__10 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<RoverlikeDetailView.<RefreshTabListAsync>d__10>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033A85 RID: 211589 RVA: 0x00E75A33 File Offset: 0x00E73C33
		private RoverlikeTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new RoverlikeTabItem();
		}

		// Token: 0x06033A86 RID: 211590 RVA: 0x00E75A3C File Offset: 0x00E73C3C
		private CommonTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x06033A87 RID: 211591 RVA: 0x00E75A74 File Offset: 0x00E73C74
		private void ToggleCallBack(int index)
		{
			UiDynamicTab data = this.TabDataList[index];
			EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
			RoverlikeTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, null, null);
			this.CurSelectTabView = new EUiTabViewName?(euiTabViewName);
		}

		// Token: 0x06033A88 RID: 211592 RVA: 0x00E75ACC File Offset: 0x00E73CCC
		private void OnCloseClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401B657 RID: 112215
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<RoverlikeTabItem> TabComponent;

		// Token: 0x0401B658 RID: 112216
		[Nullable(2)]
		private TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401B659 RID: 112217
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401B65A RID: 112218
		private EUiTabViewName? CurSelectTabView;

		// Token: 0x0200AD5F RID: 44383
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04035939 RID: 219449
			CaptionItem,
			// Token: 0x0403593A RID: 219450
			Content
		}
	}
}
