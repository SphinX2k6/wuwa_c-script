using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.HandBook
{
	// Token: 0x02005765 RID: 22373
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoHandBookView : UiViewBase
	{
		// Token: 0x06038D6C RID: 232812 RVA: 0x00D80CF4 File Offset: 0x00D7EEF4
		public KurotatoHandBookView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038D6D RID: 232813 RVA: 0x00D80D08 File Offset: 0x00D7EF08
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

		// Token: 0x06038D6E RID: 232814 RVA: 0x00D80D74 File Offset: 0x00D7EF74
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoHandBookView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoHandBookView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038D6F RID: 232815 RVA: 0x00D80DB8 File Offset: 0x00D7EFB8
		protected override void OnBeforeShow()
		{
			KurotatoLevelSelectViewData kurotatoLevelSelectViewData = this.OpenParam as KurotatoLevelSelectViewData;
			if (kurotatoLevelSelectViewData != null)
			{
				int? roleId = kurotatoLevelSelectViewData.RoleId;
				int num = 0;
				if (roleId.GetValueOrDefault() > num & roleId != null)
				{
					this.TabComponent.SelectToggleByIndex(1, false);
					goto IL_48;
				}
			}
			this.TabComponent.SelectToggleByIndex(0, false);
			IL_48:
			this.BindRedDot();
		}

		// Token: 0x06038D70 RID: 232816 RVA: 0x00D80E13 File Offset: 0x00D7F013
		protected override void OnBeforeHide()
		{
			this.ReadCurrentTabRedDot();
			this.UnBindRedDot();
		}

		// Token: 0x06038D71 RID: 232817 RVA: 0x00D80E21 File Offset: 0x00D7F021
		private void OnClickBtnBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038D72 RID: 232818 RVA: 0x00D80E2A File Offset: 0x00D7F02A
		private void OnClickBtnHelp()
		{
			HelpController.Instance.OpenHelpById(575);
		}

		// Token: 0x06038D73 RID: 232819 RVA: 0x00D80E3B File Offset: 0x00D7F03B
		private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new KurotatoTabItem();
		}

		// Token: 0x06038D74 RID: 232820 RVA: 0x00D80E44 File Offset: 0x00D7F044
		private void ToggleCallBack(int index)
		{
			UiDynamicTab data = this.TabDataList[index];
			EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
			CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			KurotatoHandBookTabViewData extraParams = new KurotatoHandBookTabViewData
			{
				OnCloseView = new Action(this.OnClickBtnBack),
				LevelSelectViewData = (this.OpenParam as KurotatoLevelSelectViewData)
			};
			this.TabViewComponent.ToggleCallBack(data, viewName, tabItemByIndex, extraParams, null);
		}

		// Token: 0x06038D75 RID: 232821 RVA: 0x00D80EBC File Offset: 0x00D7F0BC
		private CommonTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x06038D76 RID: 232822 RVA: 0x00D80EF4 File Offset: 0x00D7F0F4
		private void BindRedDot()
		{
			this.BindRedDotByName(EUiTabViewName.KurotatoHandBookRoleTabView, ERedDotName.RedDotKurotatoRole, true);
			this.BindRedDotByName(EUiTabViewName.KurotatoHandBookWeaponTabView, ERedDotName.RedDotKurotatoWeaponAndProp, true);
		}

		// Token: 0x06038D77 RID: 232823 RVA: 0x00D80F18 File Offset: 0x00D7F118
		private void UnBindRedDot()
		{
			this.BindRedDotByName(EUiTabViewName.KurotatoHandBookRoleTabView, ERedDotName.RedDotKurotatoRole, false);
			this.BindRedDotByName(EUiTabViewName.KurotatoHandBookWeaponTabView, ERedDotName.RedDotKurotatoWeaponAndProp, false);
		}

		// Token: 0x06038D78 RID: 232824 RVA: 0x00D80F3C File Offset: 0x00D7F13C
		private void ReadCurrentTabRedDot()
		{
			int selectedIndex = this.TabComponent.GetSelectedIndex();
			if (selectedIndex < 0)
			{
				return;
			}
			EUiTabViewName left = (EUiTabViewName)this.TabDataList[selectedIndex].ChildViewName;
			KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
			if (left == EUiTabViewName.KurotatoHandBookRoleTabView)
			{
				activityData.ReadRoleRedDot();
				return;
			}
			if (left == EUiTabViewName.KurotatoHandBookWeaponTabView)
			{
				activityData.ReadKurotatoItemRedDot();
				activityData.ReadKurotatoWeaponRedDot();
			}
		}

		// Token: 0x06038D79 RID: 232825 RVA: 0x00D80FAC File Offset: 0x00D7F1AC
		private void BindRedDotByName(EUiTabViewName viewName, ERedDotName redDotName, bool bIsBind)
		{
			int num = this.TabDataList.FindIndex((UiDynamicTab config) => (EUiTabViewName)config.ChildViewName == viewName);
			if (num >= 0)
			{
				CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(num);
				if (tabItemByIndex == null)
				{
					return;
				}
				if (bIsBind)
				{
					tabItemByIndex.BindRedDot(redDotName, new int?(0));
					return;
				}
				tabItemByIndex.UnBindRedDot();
			}
		}

		// Token: 0x0401DD05 RID: 122117
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401DD06 RID: 122118
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401DD07 RID: 122119
		[Nullable(2)]
		private TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0200B968 RID: 47464
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04038116 RID: 229654
			ItemCaption,
			// Token: 0x04038117 RID: 229655
			ItemContent
		}
	}
}
