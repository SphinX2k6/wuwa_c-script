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
	// Token: 0x0200611C RID: 24860
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeDetailView : UiViewBase
	{
		// Token: 0x0603EDBD RID: 257469 RVA: 0x00F2EA9B File Offset: 0x00F2CC9B
		public RoverlikeDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603EDBE RID: 257470 RVA: 0x00F2EAB0 File Offset: 0x00F2CCB0
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

		// Token: 0x0603EDBF RID: 257471 RVA: 0x00F2EB1C File Offset: 0x00F2CD1C
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeDetailView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeDetailView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EDC0 RID: 257472 RVA: 0x00F2EB5F File Offset: 0x00F2CD5F
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0603EDC1 RID: 257473 RVA: 0x00F2EB64 File Offset: 0x00F2CD64
		private void InitTabComponent()
		{
			CommonTabComponentData<RoverlikeTabItem> data = new CommonTabComponentData<RoverlikeTabItem>(new Func<UUIItem, int?, RoverlikeTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
			this.TabComponent = new TabComponentWithCaptionItem<RoverlikeTabItem>(base.GetItem(0), data, new Action(this.OnCloseClicked), false);
			this.TabComponent.SetHelpButtonShowState(false);
			this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
		}

		// Token: 0x0603EDC2 RID: 257474 RVA: 0x00F2EBDC File Offset: 0x00F2CDDC
		private UniTask RefreshTabListAsync()
		{
			RoverlikeDetailView.<RefreshTabListAsync>d__10 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<RoverlikeDetailView.<RefreshTabListAsync>d__10>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EDC3 RID: 257475 RVA: 0x00F2EC1F File Offset: 0x00F2CE1F
		private RoverlikeTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new RoverlikeTabItem();
		}

		// Token: 0x0603EDC4 RID: 257476 RVA: 0x00F2EC28 File Offset: 0x00F2CE28
		private CommonTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x0603EDC5 RID: 257477 RVA: 0x00F2EC60 File Offset: 0x00F2CE60
		private void ToggleCallBack(int index)
		{
			UiDynamicTab data = this.TabDataList[index];
			EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
			RoverlikeTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, null, null);
			this.CurSelectTabView = new EUiTabViewName?(euiTabViewName);
		}

		// Token: 0x0603EDC6 RID: 257478 RVA: 0x00F2ECB8 File Offset: 0x00F2CEB8
		private void OnCloseClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x04020D2A RID: 134442
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<RoverlikeTabItem> TabComponent;

		// Token: 0x04020D2B RID: 134443
		[Nullable(2)]
		private TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x04020D2C RID: 134444
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x04020D2D RID: 134445
		private EUiTabViewName? CurSelectTabView;

		// Token: 0x0200C377 RID: 50039
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403AFD4 RID: 241620
			CaptionItem,
			// Token: 0x0403AFD5 RID: 241621
			Content
		}
	}
}
