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
	// Token: 0x0200574C RID: 22348
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoTabMainView : UiViewBase
	{
		// Token: 0x06038CDE RID: 232670 RVA: 0x00D7D81C File Offset: 0x00D7BA1C
		public KurotatoTabMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038CDF RID: 232671 RVA: 0x00D7D830 File Offset: 0x00D7BA30
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

		// Token: 0x06038CE0 RID: 232672 RVA: 0x00D7D8BC File Offset: 0x00D7BABC
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoTabMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoTabMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038CE1 RID: 232673 RVA: 0x00D7D900 File Offset: 0x00D7BB00
		private UniTask CreateCaptionItem()
		{
			KurotatoTabMainView.<CreateCaptionItem>d__11 <CreateCaptionItem>d__;
			<CreateCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaptionItem>d__.<>4__this = this;
			<CreateCaptionItem>d__.<>1__state = -1;
			<CreateCaptionItem>d__.<>t__builder.Start<KurotatoTabMainView.<CreateCaptionItem>d__11>(ref <CreateCaptionItem>d__);
			return <CreateCaptionItem>d__.<>t__builder.Task;
		}

		// Token: 0x06038CE2 RID: 232674 RVA: 0x00D7D944 File Offset: 0x00D7BB44
		private UniTask CreateArchiveButton()
		{
			KurotatoTabMainView.<CreateArchiveButton>d__12 <CreateArchiveButton>d__;
			<CreateArchiveButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateArchiveButton>d__.<>4__this = this;
			<CreateArchiveButton>d__.<>1__state = -1;
			<CreateArchiveButton>d__.<>t__builder.Start<KurotatoTabMainView.<CreateArchiveButton>d__12>(ref <CreateArchiveButton>d__);
			return <CreateArchiveButton>d__.<>t__builder.Task;
		}

		// Token: 0x06038CE3 RID: 232675 RVA: 0x00D7D987 File Offset: 0x00D7BB87
		private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new KurotatoTabItem();
		}

		// Token: 0x06038CE4 RID: 232676 RVA: 0x00D7D990 File Offset: 0x00D7BB90
		private void ToggleCallBack(int index)
		{
			this.CurrentTabIndex = index;
			TabData tabData = this.TabDataList[index];
			CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			KurotatoInstInfo currentSaveInstInfo = this.GetCurrentSaveInstInfo();
			this.TabViewComponent.ToggleCallBack(tabData, tabData.ViewName, tabItemByIndex, currentSaveInstInfo, null);
		}

		// Token: 0x06038CE5 RID: 232677 RVA: 0x00D7D9E4 File Offset: 0x00D7BBE4
		private CommonTabData GetCommonData(int index)
		{
			TabData tabData = this.TabDataList[index];
			return new CommonTabData(UiResourceConfig.Instance.GetResourcePath(tabData.IconResourceId), new CommonTabTitleData(tabData.TitleId, Array.Empty<object>()), null);
		}

		// Token: 0x06038CE6 RID: 232678 RVA: 0x00D7DA24 File Offset: 0x00D7BC24
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

		// Token: 0x06038CE7 RID: 232679 RVA: 0x00D7DA7D File Offset: 0x00D7BC7D
		private void RefreshArchiveButtonText()
		{
			ButtonItem archiveButton = this.ArchiveButton;
			if (archiveButton == null)
			{
				return;
			}
			archiveButton.SetLocalTextNew((this.CurrentSaveIndex == 0) ? "Kurotato_Save_Old" : "Kurotato_Save_New", Array.Empty<object>());
		}

		// Token: 0x06038CE8 RID: 232680 RVA: 0x00D7DAA8 File Offset: 0x00D7BCA8
		[NullableContext(2)]
		private KurotatoInstInfo GetCurrentSaveInstInfo()
		{
			if (this.SaveParam == null)
			{
				return null;
			}
			return this.SaveParam.InstInfos[this.CurrentSaveIndex];
		}

		// Token: 0x06038CE9 RID: 232681 RVA: 0x00D7DACA File Offset: 0x00D7BCCA
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038CEA RID: 232682 RVA: 0x00D7DAD3 File Offset: 0x00D7BCD3
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

		// Token: 0x06038CEB RID: 232683 RVA: 0x00D7DB00 File Offset: 0x00D7BD00
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

		// Token: 0x0401DCAB RID: 122027
		private List<TabData> TabDataList = new List<TabData>();

		// Token: 0x0401DCAC RID: 122028
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401DCAD RID: 122029
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabViewComponent<TabData> TabViewComponent;

		// Token: 0x0401DCAE RID: 122030
		[Nullable(2)]
		private IKurotatoSaveViewOpenParam SaveParam;

		// Token: 0x0401DCAF RID: 122031
		private int CurrentSaveIndex;

		// Token: 0x0401DCB0 RID: 122032
		private int CurrentTabIndex;

		// Token: 0x0401DCB1 RID: 122033
		[Nullable(2)]
		private ButtonItem ArchiveButton;

		// Token: 0x0200B93E RID: 47422
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04038073 RID: 229491
			CaptionList,
			// Token: 0x04038074 RID: 229492
			Content,
			// Token: 0x04038075 RID: 229493
			BtnArchive
		}
	}
}
