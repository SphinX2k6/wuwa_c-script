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
	// Token: 0x0200473C RID: 18236
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoHandBookView : UiViewBase
	{
		// Token: 0x0602DC7C RID: 187516 RVA: 0x00CCF7B8 File Offset: 0x00CCD9B8
		public KurotatoHandBookView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DC7D RID: 187517 RVA: 0x00CCF7CC File Offset: 0x00CCD9CC
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

		// Token: 0x0602DC7E RID: 187518 RVA: 0x00CCF838 File Offset: 0x00CCDA38
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoHandBookView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoHandBookView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DC7F RID: 187519 RVA: 0x00CCF87C File Offset: 0x00CCDA7C
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

		// Token: 0x0602DC80 RID: 187520 RVA: 0x00CCF8D7 File Offset: 0x00CCDAD7
		protected override void OnBeforeHide()
		{
			this.ReadCurrentTabRedDot();
			this.UnBindRedDot();
		}

		// Token: 0x0602DC81 RID: 187521 RVA: 0x00CCF8E5 File Offset: 0x00CCDAE5
		private void OnClickBtnBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602DC82 RID: 187522 RVA: 0x00CCF8EE File Offset: 0x00CCDAEE
		private void OnClickBtnHelp()
		{
			HelpController.Instance.OpenHelpById(575);
		}

		// Token: 0x0602DC83 RID: 187523 RVA: 0x00CCF8FF File Offset: 0x00CCDAFF
		private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new KurotatoTabItem();
		}

		// Token: 0x0602DC84 RID: 187524 RVA: 0x00CCF908 File Offset: 0x00CCDB08
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

		// Token: 0x0602DC85 RID: 187525 RVA: 0x00CCF980 File Offset: 0x00CCDB80
		private CommonTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x0602DC86 RID: 187526 RVA: 0x00CCF9B8 File Offset: 0x00CCDBB8
		private void BindRedDot()
		{
			this.BindRedDotByName(EUiTabViewName.KurotatoHandBookRoleTabView, ERedDotName.RedDotKurotatoRole, true);
			this.BindRedDotByName(EUiTabViewName.KurotatoHandBookWeaponTabView, ERedDotName.RedDotKurotatoWeaponAndProp, true);
		}

		// Token: 0x0602DC87 RID: 187527 RVA: 0x00CCF9DC File Offset: 0x00CCDBDC
		private void UnBindRedDot()
		{
			this.BindRedDotByName(EUiTabViewName.KurotatoHandBookRoleTabView, ERedDotName.RedDotKurotatoRole, false);
			this.BindRedDotByName(EUiTabViewName.KurotatoHandBookWeaponTabView, ERedDotName.RedDotKurotatoWeaponAndProp, false);
		}

		// Token: 0x0602DC88 RID: 187528 RVA: 0x00CCFA00 File Offset: 0x00CCDC00
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

		// Token: 0x0602DC89 RID: 187529 RVA: 0x00CCFA70 File Offset: 0x00CCDC70
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

		// Token: 0x0401879B RID: 100251
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401879C RID: 100252
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401879D RID: 100253
		[Nullable(2)]
		private TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0200A383 RID: 41859
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04032B12 RID: 207634
			ItemCaption,
			// Token: 0x04032B13 RID: 207635
			ItemContent
		}
	}
}
