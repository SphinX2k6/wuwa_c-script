using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02004723 RID: 18211
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoTabMainView : UiViewBase
	{
		// Token: 0x0602DBEE RID: 187374 RVA: 0x00CCC0D8 File Offset: 0x00CCA2D8
		public KurotatoTabMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DBEF RID: 187375 RVA: 0x00CCC0EC File Offset: 0x00CCA2EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DBF0 RID: 187376 RVA: 0x00CCC178 File Offset: 0x00CCA378
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoTabMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoTabMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DBF1 RID: 187377 RVA: 0x00CCC1BC File Offset: 0x00CCA3BC
		private UniTask CreateCaptionItem()
		{
			KurotatoTabMainView.<CreateCaptionItem>d__11 <CreateCaptionItem>d__;
			<CreateCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaptionItem>d__.<>4__this = this;
			<CreateCaptionItem>d__.<>1__state = -1;
			<CreateCaptionItem>d__.<>t__builder.Start<KurotatoTabMainView.<CreateCaptionItem>d__11>(ref <CreateCaptionItem>d__);
			return <CreateCaptionItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602DBF2 RID: 187378 RVA: 0x00CCC200 File Offset: 0x00CCA400
		private UniTask CreateArchiveButton()
		{
			KurotatoTabMainView.<CreateArchiveButton>d__12 <CreateArchiveButton>d__;
			<CreateArchiveButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateArchiveButton>d__.<>4__this = this;
			<CreateArchiveButton>d__.<>1__state = -1;
			<CreateArchiveButton>d__.<>t__builder.Start<KurotatoTabMainView.<CreateArchiveButton>d__12>(ref <CreateArchiveButton>d__);
			return <CreateArchiveButton>d__.<>t__builder.Task;
		}

		// Token: 0x0602DBF3 RID: 187379 RVA: 0x00CCC243 File Offset: 0x00CCA443
		private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new KurotatoTabItem();
		}

		// Token: 0x0602DBF4 RID: 187380 RVA: 0x00CCC24C File Offset: 0x00CCA44C
		private void ToggleCallBack(int index)
		{
			this.CurrentTabIndex = index;
			TabData tabData = this.TabDataList[index];
			CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			KurotatoInstInfo currentSaveInstInfo = this.GetCurrentSaveInstInfo();
			this.TabViewComponent.ToggleCallBack(tabData, tabData.ViewName, tabItemByIndex, currentSaveInstInfo, null);
		}

		// Token: 0x0602DBF5 RID: 187381 RVA: 0x00CCC2A0 File Offset: 0x00CCA4A0
		private CommonTabData GetCommonData(int index)
		{
			TabData tabData = this.TabDataList[index];
			return new CommonTabData(UiResourceConfig.Instance.GetResourcePath(tabData.IconResourceId), new CommonTabTitleData(tabData.TitleId, Array.Empty<object>()), null);
		}

		// Token: 0x0602DBF6 RID: 187382 RVA: 0x00CCC2E0 File Offset: 0x00CCA4E0
		protected override void OnBeforeShow()
		{
			bool flag = this.SaveParam != null && this.SaveParam.InstInfos.Count > 1;
			ButtonItem archiveButton = this.ArchiveButton;
			if (archiveButton != null)
			{
				archiveButton.SetActive(flag);
			}
			if (flag)
			{
				this.RefreshArchiveButtonText();
			}
			TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
			if (tabComponent == null)
			{
				return;
			}
			tabComponent.SelectToggleByIndex(0, true);
		}

		// Token: 0x0602DBF7 RID: 187383 RVA: 0x00CCC339 File Offset: 0x00CCA539
		private void RefreshArchiveButtonText()
		{
			ButtonItem archiveButton = this.ArchiveButton;
			if (archiveButton == null)
			{
				return;
			}
			archiveButton.SetLocalTextNew((this.CurrentSaveIndex == 0) ? "Kurotato_Save_Old" : "Kurotato_Save_New", Array.Empty<object>());
		}

		// Token: 0x0602DBF8 RID: 187384 RVA: 0x00CCC364 File Offset: 0x00CCA564
		[NullableContext(2)]
		private KurotatoInstInfo GetCurrentSaveInstInfo()
		{
			if (this.SaveParam == null)
			{
				return null;
			}
			return this.SaveParam.InstInfos[this.CurrentSaveIndex];
		}

		// Token: 0x0602DBF9 RID: 187385 RVA: 0x00CCC386 File Offset: 0x00CCA586
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602DBFA RID: 187386 RVA: 0x00CCC38F File Offset: 0x00CCA58F
		private void OnBtnArchiveClick()
		{
			if (this.SaveParam == null)
			{
				return;
			}
			this.CurrentSaveIndex = ((this.CurrentSaveIndex == 0) ? 1 : 0);
			this.RefreshArchiveButtonText();
			this.ToggleCallBack(this.CurrentTabIndex);
		}

		// Token: 0x0602DBFB RID: 187387 RVA: 0x00CCC3BC File Offset: 0x00CCA5BC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length < 2 || configParams[0] != "DetailTab")
			{
				return null;
			}
			int num;
			if (!int.TryParse(configParams[1], out num))
			{
				return null;
			}
			int num2 = num - 1;
			if (num2 < 0)
			{
				return null;
			}
			TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
			CommonTabItem commonTabItem = (tabComponent != null) ? tabComponent.GetTabItemByIndex(num2) : null;
			UUIItem uuiitem = (commonTabItem != null) ? commonTabItem.GetRootItem() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x04018741 RID: 100161
		private List<TabData> TabDataList = new List<TabData>();

		// Token: 0x04018742 RID: 100162
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x04018743 RID: 100163
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabViewComponent<TabData> TabViewComponent;

		// Token: 0x04018744 RID: 100164
		[Nullable(2)]
		private IKurotatoSaveViewOpenParam SaveParam;

		// Token: 0x04018745 RID: 100165
		private int CurrentSaveIndex;

		// Token: 0x04018746 RID: 100166
		private int CurrentTabIndex;

		// Token: 0x04018747 RID: 100167
		[Nullable(2)]
		private ButtonItem ArchiveButton;

		// Token: 0x0200A35D RID: 41821
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04032A7D RID: 207485
			CaptionList,
			// Token: 0x04032A7E RID: 207486
			Content,
			// Token: 0x04032A7F RID: 207487
			BtnArchive
		}
	}
}
