using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D50 RID: 19792
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopRootView : UiViewBase
	{
		// Token: 0x06033226 RID: 209446 RVA: 0x00BEC8C5 File Offset: 0x00BEAAC5
		public RoleDevelopRootView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033227 RID: 209447 RVA: 0x00BEC908 File Offset: 0x00BEAB08
		protected unsafe override void OnRegisterComponent()
		{
			int num = 25;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(22, new Action<EToggleState>(this.OnClickToggleRoleMark));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(23, new Action(this.OnIntroductionBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033228 RID: 209448 RVA: 0x00BECCDC File Offset: 0x00BEAEDC
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopRootView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopRootView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033229 RID: 209449 RVA: 0x00BECD20 File Offset: 0x00BEAF20
		protected override void OnStart()
		{
			base.GetButton(23).RootUIComp.Get().SetUIActive(true);
			this.RefreshRoleGridLayout();
			this.RefreshHotRoleGridLayout();
			this.RefreshRoleDevelopCategoryLayout();
			EventSystem.Instance.Add(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			EventSystem.Instance.Add<int>(EEventName.ActiveRole, new Action<int>(this.OnActiveRole));
		}

		// Token: 0x0603322A RID: 209450 RVA: 0x00BECDB0 File Offset: 0x00BEAFB0
		protected override void OnHandleLoadScene()
		{
			if (UiSceneManager.Instance.HasRoleSystemRoleActor())
			{
				return;
			}
			int value = RoleModel.Instance.GetCurSelectMainRoleId().Value;
			this.ViewModel = new RoleViewViewModel(value, true, ERoleViewSource.Normal);
			this.ViewModel.HandleLoadScene(null);
		}

		// Token: 0x0603322B RID: 209451 RVA: 0x00BECDF7 File Offset: 0x00BEAFF7
		protected override void OnHandleReleaseScene()
		{
			this.TryReleaseScene();
		}

		// Token: 0x0603322C RID: 209452 RVA: 0x00BECDFF File Offset: 0x00BEAFFF
		private void TryReleaseScene()
		{
			if (this.ViewModel != null)
			{
				this.ViewModel.HandleReleaseScene();
			}
			this.ViewModel = null;
		}

		// Token: 0x0603322D RID: 209453 RVA: 0x00BECE1C File Offset: 0x00BEB01C
		protected override void OnBeforeDestroy()
		{
			this.TryReleaseScene();
			this.TryShowUiRoleModel();
			EventSystem.Instance.Remove(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
			EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			EventSystem.Instance.Remove<int>(EEventName.ActiveRole, new Action<int>(this.OnActiveRole));
		}

		// Token: 0x0603322E RID: 209454 RVA: 0x00BECE8C File Offset: 0x00BEB08C
		protected override void OnBeforeShow()
		{
			this.TryHideUiRoleModel();
			if (this.NeedRebuildDataOnShow)
			{
				this.RoleDevelopDataList = RoleDevelopModel.Instance.GetNormalRoleDevelopData();
				this.RoleDataList = new List<RoleDataBase>();
				this.RefreshRoleGridLayout();
				this.RefreshHotRoleGridLayout();
			}
			this.NeedRebuildDataOnShow = false;
			if (this.RefreshOnShow)
			{
				this.RefreshTitleView();
				this.RefreshProjectView(false);
				this.RefreshCategoryHint();
				this.RoleLayout.RefreshWithoutDataSync();
				this.HotRoleLayout.RefreshWithoutDataSync();
			}
			this.RefreshOnShow = false;
		}

		// Token: 0x0603322F RID: 209455 RVA: 0x00BECF0D File Offset: 0x00BEB10D
		protected override void OnBeforeHide()
		{
			this.RefreshOnShow = true;
		}

		// Token: 0x06033230 RID: 209456 RVA: 0x00BECF18 File Offset: 0x00BEB118
		private void InitData()
		{
			this.RoleDevelopDataList = RoleDevelopModel.Instance.GetNormalRoleDevelopData();
			List<RoleDevelopData> allHotRoleDevelopData = RoleDevelopModel.Instance.GetAllHotRoleDevelopData(false);
			RoleDevelopRootViewData roleDevelopRootViewData = this.OpenParam as RoleDevelopRootViewData;
			int? roleId = (roleDevelopRootViewData != null) ? roleDevelopRootViewData.RoleId : null;
			if (roleId != null && roleId.GetValueOrDefault() != 0)
			{
				this.CurSelectRoleDevelopData = (this.RoleDevelopDataList.Find((RoleDevelopData data) => data.GetId() == roleId.Value) ?? allHotRoleDevelopData.Find((RoleDevelopData data) => data.GetId() == roleId.Value));
			}
		}

		// Token: 0x06033231 RID: 209457 RVA: 0x00BECFBA File Offset: 0x00BEB1BA
		private void InitSortEntrance()
		{
			this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(base.GetItem(4), new TUpdateDataListFunction<RoleDataBase>(this.OnUpdateSortList));
		}

		// Token: 0x06033232 RID: 209458 RVA: 0x00BECFDC File Offset: 0x00BEB1DC
		private UniTask InitCaptainItem()
		{
			RoleDevelopRootView.<InitCaptainItem>d__31 <InitCaptainItem>d__;
			<InitCaptainItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaptainItem>d__.<>4__this = this;
			<InitCaptainItem>d__.<>1__state = -1;
			<InitCaptainItem>d__.<>t__builder.Start<RoleDevelopRootView.<InitCaptainItem>d__31>(ref <InitCaptainItem>d__);
			return <InitCaptainItem>d__.<>t__builder.Task;
		}

		// Token: 0x06033233 RID: 209459 RVA: 0x00BED020 File Offset: 0x00BEB220
		private UniTask InitRoleDevelopTagItem()
		{
			RoleDevelopRootView.<InitRoleDevelopTagItem>d__32 <InitRoleDevelopTagItem>d__;
			<InitRoleDevelopTagItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleDevelopTagItem>d__.<>4__this = this;
			<InitRoleDevelopTagItem>d__.<>1__state = -1;
			<InitRoleDevelopTagItem>d__.<>t__builder.Start<RoleDevelopRootView.<InitRoleDevelopTagItem>d__32>(ref <InitRoleDevelopTagItem>d__);
			return <InitRoleDevelopTagItem>d__.<>t__builder.Task;
		}

		// Token: 0x06033234 RID: 209460 RVA: 0x00BED064 File Offset: 0x00BEB264
		private UniTask InitRoleElementItem()
		{
			RoleDevelopRootView.<InitRoleElementItem>d__33 <InitRoleElementItem>d__;
			<InitRoleElementItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleElementItem>d__.<>4__this = this;
			<InitRoleElementItem>d__.<>1__state = -1;
			<InitRoleElementItem>d__.<>t__builder.Start<RoleDevelopRootView.<InitRoleElementItem>d__33>(ref <InitRoleElementItem>d__);
			return <InitRoleElementItem>d__.<>t__builder.Task;
		}

		// Token: 0x06033235 RID: 209461 RVA: 0x00BED0A7 File Offset: 0x00BEB2A7
		private void InitRoleDevelopCategoryItem()
		{
			this.CategoryLayout = new GenericLayout<RoleDevelopCategoryItem, RoleDevelopCategoryData>(base.GetHorizontalLayout(11), new Func<RoleDevelopCategoryItem>(this.CreateRoleDevelopCategoryItem), null, false, true);
		}

		// Token: 0x06033236 RID: 209462 RVA: 0x00BED0CC File Offset: 0x00BEB2CC
		private UniTask InitRoleDevelopViewItem()
		{
			RoleDevelopRootView.<InitRoleDevelopViewItem>d__35 <InitRoleDevelopViewItem>d__;
			<InitRoleDevelopViewItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleDevelopViewItem>d__.<>4__this = this;
			<InitRoleDevelopViewItem>d__.<>1__state = -1;
			<InitRoleDevelopViewItem>d__.<>t__builder.Start<RoleDevelopRootView.<InitRoleDevelopViewItem>d__35>(ref <InitRoleDevelopViewItem>d__);
			return <InitRoleDevelopViewItem>d__.<>t__builder.Task;
		}

		// Token: 0x06033237 RID: 209463 RVA: 0x00BED110 File Offset: 0x00BEB310
		private void RefreshCategoryHint()
		{
			List<RoleDevelopCategoryItem> layoutItemList = this.CategoryLayout.GetLayoutItemList();
			RoleDevelopProjectBaseData projectData = this.CurSelectRoleDevelopData.GetProjectData();
			foreach (RoleDevelopCategoryItem roleDevelopCategoryItem in layoutItemList)
			{
				ERoleDevelopCategoryType categoryType = roleDevelopCategoryItem.CategoryType;
				bool isShowUpgrade = projectData.IsShowUpgradeHint(categoryType);
				bool isShowFinish = projectData.IsShowFinishHint(categoryType);
				roleDevelopCategoryItem.RefreshHint(isShowUpgrade, isShowFinish);
			}
		}

		// Token: 0x06033238 RID: 209464 RVA: 0x00BED18C File Offset: 0x00BEB38C
		private void InitRoleGridLayout()
		{
			AActor owner = base.GetItem(3).GetOwner();
			this.HotRoleLayout = new GenericLayout<RoleDevelopHotRoleGridItem, RoleDevelopData>(base.GetGridLayout(1), new Func<RoleDevelopHotRoleGridItem>(this.CreateHotRoleGridItem), (AUIBaseActor)owner, false, true);
			this.RoleLayout = new GenericLayout<RoleDevelopGridItem, RoleDevelopData>(base.GetGridLayout(2), new Func<RoleDevelopGridItem>(this.CreateRoleGridItem), (AUIBaseActor)owner, false, true);
		}

		// Token: 0x06033239 RID: 209465 RVA: 0x00BED1F4 File Offset: 0x00BEB3F4
		private void TryShowUiRoleModel()
		{
			TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
			if (roleSystemRoleActor == null)
			{
				return;
			}
			UiModelBase model = roleSystemRoleActor.Model;
			UiModelUtil.Instance.StopFade(model);
			UiModelUtil.Instance.SetDitherEffect(model, 1f);
			UiModelUtil.Instance.SetVisible(model, true);
		}

		// Token: 0x0603323A RID: 209466 RVA: 0x00BED240 File Offset: 0x00BEB440
		private void TryHideUiRoleModel()
		{
			TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
			if (roleSystemRoleActor == null)
			{
				return;
			}
			UiModelBase model = roleSystemRoleActor.Model;
			UiModelUtil.Instance.StopFade(model);
			UiModelUtil.Instance.SetDitherEffect(model, 0f);
			UiModelUtil.Instance.SetVisible(model, false);
		}

		// Token: 0x0603323B RID: 209467 RVA: 0x00BED28C File Offset: 0x00BEB48C
		private void RefreshRoleGridLayout()
		{
			List<RoleDevelopData> roleDevelopDataList = this.RoleDevelopDataList;
			if (this.RoleDataList.Count <= 0)
			{
				foreach (RoleDevelopData roleDevelopData in roleDevelopDataList)
				{
					int id = roleDevelopData.GetId();
					RoleInstance roleInstance = RoleModel.Instance.GetRoleInstanceById(id);
					if (roleInstance == null)
					{
						roleInstance = new RoleInstance(id);
					}
					this.RoleDataList.Add(roleInstance);
				}
				this.FilterSortEntrance.UpdateData(EFilterSortGroupId.RoleDev, this.RoleDataList, Array.Empty<object>());
				return;
			}
			this.RoleLayout.RefreshByData(this.RoleDevelopDataList, new Action(this.OnRoleGridLayoutRefresh), true);
		}

		// Token: 0x0603323C RID: 209468 RVA: 0x00BED348 File Offset: 0x00BEB548
		private void RefreshHotRoleGridLayout()
		{
			List<RoleDevelopData> allHotRoleDevelopData = RoleDevelopModel.Instance.GetAllHotRoleDevelopData(true);
			if (allHotRoleDevelopData.Count <= 0)
			{
				this.HotRoleLayout.SetActive(false);
				return;
			}
			this.HotRoleLayout.SetActive(true);
			this.HotRoleLayout.RefreshByData(allHotRoleDevelopData, new Action(this.OnHotRoleGridLayoutRefresh), true);
		}

		// Token: 0x0603323D RID: 209469 RVA: 0x00BED39C File Offset: 0x00BEB59C
		private void RefreshRoleDevelopCategoryLayout()
		{
			List<RoleDevelopCategoryData> data = new List<RoleDevelopCategoryData>(RoleDevelopDefine.roleDevelopCategoryConfig);
			RoleDevelopRootViewData roleDevelopRootViewData = this.OpenParam as RoleDevelopRootViewData;
			if (this.CurSelectCategoryType == null)
			{
				this.CurSelectCategoryType = new ERoleDevelopCategoryType?(((roleDevelopRootViewData != null) ? roleDevelopRootViewData.CategoryType : null).GetValueOrDefault(ERoleDevelopCategoryType.Role));
			}
			this.CategoryLayout.RefreshByData(data, delegate
			{
				this.CategoryLayout.SelectGridProxyByKey(this.CurSelectCategoryType.Value, true);
			}, false);
		}

		// Token: 0x0603323E RID: 209470 RVA: 0x00BED410 File Offset: 0x00BEB610
		private void RefreshTitleView()
		{
			if (this.CurSelectRoleDevelopData == null)
			{
				return;
			}
			RoleDevelopRoleBaseData developRoleData = this.CurSelectRoleDevelopData.GetDevelopRoleData();
			base.GetText(6).SetText(developRoleData.GetName(), true);
			base.SetTextureByPath(developRoleData.GetRoleSmallIconPath(), base.GetTexture(5), null, null);
			this.ElementItem.Refresh(developRoleData.GetElementId(), false, 0);
			this.RoleDevelopTagItem.RefreshByData(this.CurSelectRoleDevelopData.GetHotRoleTag());
			this.RefreshMainProperty();
			this.RefreshRoleMarkToggle();
		}

		// Token: 0x0603323F RID: 209471 RVA: 0x00BED498 File Offset: 0x00BEB698
		private void RefreshMainProperty()
		{
			UUIText text = base.GetText(9);
			if (this.CurSelectRoleDevelopData == null)
			{
				text.SetUIActive(false);
				return;
			}
			if (RoleDevelopUtil.IsAnyProspectRole(this.CurSelectRoleDevelopData.GetId()))
			{
				text.SetUIActive(false);
				return;
			}
			int keyProperty = this.CurSelectRoleDevelopData.GetDevelopRoleData().GetKeyProperty();
			if (keyProperty == 0)
			{
				text.SetUIActive(false);
				return;
			}
			RoleDevProject? roleDevProjectConfig = RoleDevConfig.Instance.GetRoleDevProjectConfig(this.CurSelectRoleDevelopData.GetId());
			PropertyIndex? propertyIndexConfigByIndex = RoleDevConfig.Instance.GetPropertyIndexConfigByIndex(keyProperty);
			text.SetUIActive(true);
			int[] propertyValueArray = roleDevProjectConfig.Value.GetPropertyValueArray();
			string text2;
			if (propertyValueArray[0] != 1)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendFormatted<double>((double)propertyValueArray[1] / 100.0, "F1");
				defaultInterpolatedStringHandler.AppendLiteral("%");
				text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				text2 = propertyValueArray[1].ToString();
			}
			string str = text2;
			string text3 = ConfigMultiTextLang.GetLocalTextNew(propertyIndexConfigByIndex.Value.Name, null) + " " + str;
			text3 = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("RoleProject_TargetProperty", null), new string[]
			{
				text3
			});
			text.SetText(text3, true);
		}

		// Token: 0x06033240 RID: 209472 RVA: 0x00BED5C8 File Offset: 0x00BEB7C8
		private void RefreshProjectView(bool forceRefresh = false)
		{
			if (this.CurSelectRoleDevelopData == null || this.CurSelectCategoryType == null)
			{
				return;
			}
			foreach (KeyValuePair<ERoleDevelopCategoryType, UUIItem> keyValuePair in this.ProjectLayoutMap)
			{
				ERoleDevelopCategoryType eroleDevelopCategoryType;
				UUIItem uuiitem;
				keyValuePair.Deconstruct(out eroleDevelopCategoryType, out uuiitem);
				ERoleDevelopCategoryType eroleDevelopCategoryType2 = eroleDevelopCategoryType;
				uuiitem.SetUIActive(eroleDevelopCategoryType2 == this.CurSelectCategoryType.Value);
			}
			foreach (KeyValuePair<ERoleDevelopCategoryType, UUIItem> keyValuePair in this.ProjectScrollViewMap)
			{
				ERoleDevelopCategoryType eroleDevelopCategoryType;
				UUIItem uuiitem;
				keyValuePair.Deconstruct(out eroleDevelopCategoryType, out uuiitem);
				ERoleDevelopCategoryType eroleDevelopCategoryType3 = eroleDevelopCategoryType;
				uuiitem.SetUIActive(eroleDevelopCategoryType3 == this.CurSelectCategoryType.Value);
			}
			foreach (RoleDevelopProjectBasePanel roleDevelopProjectBasePanel in this.ProjectPanelMap.Values)
			{
				roleDevelopProjectBasePanel.RefreshView(this.CurSelectRoleDevelopData, forceRefresh);
			}
			bool uiactive = this.CurSelectCategoryType.Value == ERoleDevelopCategoryType.Phantom && RoleDevelopUtil.IsAnyProspectRole(this.CurSelectRoleDevelopData.GetId());
			base.GetItem(21).SetUIActive(uiactive);
		}

		// Token: 0x06033241 RID: 209473 RVA: 0x00BED72C File Offset: 0x00BEB92C
		private void RefreshRoleMarkToggle()
		{
			int id = this.CurSelectRoleDevelopData.GetId();
			UUIExtendToggle extendToggle = base.GetExtendToggle(22);
			extendToggle.RootUIComp.Get().SetUIActive(true);
			EToggleState state = (RoleDevelopModel.Instance.DevTargetRoleId == id) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x06033242 RID: 209474 RVA: 0x00BED77C File Offset: 0x00BEB97C
		private void OnHotRoleGridItemSelected(RoleDevelopData data)
		{
			this.RoleLayout.DeselectCurrentGridProxy();
			this.HotRoleLayout.DeselectCurrentGridProxy();
			this.HotRoleLayout.SelectGridProxyByKey(data.GetId(), false);
			this.CurSelectRoleDevelopData = data;
			this.IsSelectedFromHotRole = true;
			this.RefreshTitleView();
			this.RefreshProjectView(true);
			this.RefreshCategoryHint();
			this.UiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x06033243 RID: 209475 RVA: 0x00BED7F4 File Offset: 0x00BEB9F4
		private void OnRoleGridItemSelected(RoleDevelopData data)
		{
			this.RoleLayout.DeselectCurrentGridProxy();
			this.HotRoleLayout.DeselectCurrentGridProxy();
			this.RoleLayout.SelectGridProxyByKey(data.GetId(), false);
			this.CurSelectRoleDevelopData = data;
			this.IsSelectedFromHotRole = false;
			this.RefreshTitleView();
			this.RefreshProjectView(true);
			this.RefreshCategoryHint();
			this.UiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x06033244 RID: 209476 RVA: 0x00BED869 File Offset: 0x00BEBA69
		private void OnCloseButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06033245 RID: 209477 RVA: 0x00BED872 File Offset: 0x00BEBA72
		private RoleDevelopHotRoleGridItem CreateHotRoleGridItem()
		{
			RoleDevelopHotRoleGridItem roleDevelopHotRoleGridItem = new RoleDevelopHotRoleGridItem();
			roleDevelopHotRoleGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnHotRoleGridItemToggleChanged));
			roleDevelopHotRoleGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnHotRoleGridItemCanExecuteChange));
			return roleDevelopHotRoleGridItem;
		}

		// Token: 0x06033246 RID: 209478 RVA: 0x00BED89D File Offset: 0x00BEBA9D
		private RoleDevelopGridItem CreateRoleGridItem()
		{
			RoleDevelopGridItem roleDevelopGridItem = new RoleDevelopGridItem();
			roleDevelopGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnRoleGridItemToggleChanged));
			roleDevelopGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnRoleGridItemCanExecuteChange));
			return roleDevelopGridItem;
		}

		// Token: 0x06033247 RID: 209479 RVA: 0x00BED8C8 File Offset: 0x00BEBAC8
		private void OnRoleGridItemToggleChanged(MediumItemGridExtendCallback callbackParameter)
		{
			this.OnRoleGridItemSelected((RoleDevelopData)callbackParameter.Data);
		}

		// Token: 0x06033248 RID: 209480 RVA: 0x00BED8DC File Offset: 0x00BEBADC
		private bool OnRoleGridItemCanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			if (this.IsSelectedFromHotRole)
			{
				return true;
			}
			int id = ((RoleDevelopData)data).GetId();
			RoleDevelopData curSelectRoleDevelopData = this.CurSelectRoleDevelopData;
			int? num = (curSelectRoleDevelopData != null) ? new int?(curSelectRoleDevelopData.GetId()) : null;
			return !(id == num.GetValueOrDefault() & num != null);
		}

		// Token: 0x06033249 RID: 209481 RVA: 0x00BED932 File Offset: 0x00BEBB32
		private void OnHotRoleGridItemToggleChanged(MediumItemGridExtendCallback callbackParameter)
		{
			this.OnHotRoleGridItemSelected((RoleDevelopData)callbackParameter.Data);
		}

		// Token: 0x0603324A RID: 209482 RVA: 0x00BED948 File Offset: 0x00BEBB48
		private bool OnHotRoleGridItemCanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			if (!this.IsSelectedFromHotRole)
			{
				return true;
			}
			int id = ((RoleDevelopData)data).GetId();
			RoleDevelopData curSelectRoleDevelopData = this.CurSelectRoleDevelopData;
			int? num = (curSelectRoleDevelopData != null) ? new int?(curSelectRoleDevelopData.GetId()) : null;
			return !(id == num.GetValueOrDefault() & num != null);
		}

		// Token: 0x0603324B RID: 209483 RVA: 0x00BED99E File Offset: 0x00BEBB9E
		private RoleDevelopCategoryItem CreateRoleDevelopCategoryItem()
		{
			RoleDevelopCategoryItem roleDevelopCategoryItem = new RoleDevelopCategoryItem();
			roleDevelopCategoryItem.SetToggleCallback(new Action<RoleDevelopCategoryData>(this.OnRoleDevelopCategoryItemToggle));
			roleDevelopCategoryItem.SetCanExecuteCallback(new Func<RoleDevelopCategoryData, bool>(this.OnRoleDevelopCategoryItemCanExecute));
			return roleDevelopCategoryItem;
		}

		// Token: 0x0603324C RID: 209484 RVA: 0x00BED9CC File Offset: 0x00BEBBCC
		private void OnRoleDevelopCategoryItemToggle(RoleDevelopCategoryData data)
		{
			this.CategoryLayout.DeselectCurrentGridProxy();
			this.CategoryLayout.SelectGridProxyByKey(data.CategoryType, false);
			this.CurSelectCategoryType = new ERoleDevelopCategoryType?(data.CategoryType);
			this.RefreshProjectView(false);
			RoleDevelopProjectBasePanel roleDevelopProjectBasePanel;
			if (this.ProjectPanelMap.TryGetValue(this.CurSelectCategoryType.Value, out roleDevelopProjectBasePanel))
			{
				roleDevelopProjectBasePanel.PlaySequenceByName("Start", false);
			}
		}

		// Token: 0x0603324D RID: 209485 RVA: 0x00BEDA3C File Offset: 0x00BEBC3C
		private bool OnRoleDevelopCategoryItemCanExecute(RoleDevelopCategoryData data)
		{
			ERoleDevelopCategoryType? curSelectCategoryType = this.CurSelectCategoryType;
			ERoleDevelopCategoryType categoryType = data.CategoryType;
			return !(curSelectCategoryType.GetValueOrDefault() == categoryType & curSelectCategoryType != null);
		}

		// Token: 0x0603324E RID: 209486 RVA: 0x00BEDA6C File Offset: 0x00BEBC6C
		private void OnClickToggleRoleMark(EToggleState state)
		{
			int id = this.CurSelectRoleDevelopData.GetId();
			int roleId = (RoleDevelopModel.Instance.DevTargetRoleId == id) ? 0 : id;
			RoleDevelopProjectPhantomPanel roleDevelopProjectPhantomPanel = (RoleDevelopProjectPhantomPanel)this.ProjectPanelMap[ERoleDevelopCategoryType.Phantom];
			RoleController.Instance.RequestUpdateDevelopTarget(roleId, ERoleDevelopUpdateTargetSource.RoleDevelop, new int?(roleDevelopProjectPhantomPanel.SelectPlanId), roleDevelopProjectPhantomPanel.SelectFirstVisionMonsterId);
		}

		// Token: 0x0603324F RID: 209487 RVA: 0x00BEDAC6 File Offset: 0x00BEBCC6
		private void OnCommonItemCountAnyChange(int configId, int count)
		{
			if (this.CurSelectCategoryType == null)
			{
				return;
			}
			this.ProjectPanelMap[this.CurSelectCategoryType.Value].OnCommonItemCountAnyChange(configId);
			this.RefreshCategoryHint();
		}

		// Token: 0x06033250 RID: 209488 RVA: 0x00BEDAF8 File Offset: 0x00BEBCF8
		private void OnRoleDevTargetRoleIdChange()
		{
			this.RefreshRoleMarkToggle();
			this.RoleLayout.RefreshWithoutDataSync();
			this.HotRoleLayout.RefreshWithoutDataSync();
		}

		// Token: 0x06033251 RID: 209489 RVA: 0x00BEDB16 File Offset: 0x00BEBD16
		private void OnActiveRole(int roleId)
		{
			this.NeedRebuildDataOnShow = true;
		}

		// Token: 0x06033252 RID: 209490 RVA: 0x00BEDB20 File Offset: 0x00BEBD20
		private void OnUpdateSortList(List<RoleDataBase> dataList, bool isOutSideChange, EFilterSortType operationType)
		{
			this.RoleDataList = dataList;
			Dictionary<int, int> orderMap = new Dictionary<int, int>();
			for (int i = 0; i < dataList.Count; i++)
			{
				orderMap[dataList[i].GetRoleId()] = i;
			}
			int targetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			this.RoleDevelopDataList.Sort(delegate(RoleDevelopData a, RoleDevelopData b)
			{
				int id = a.GetId();
				int id2 = b.GetId();
				if (targetRoleId > 0)
				{
					if (id == targetRoleId)
					{
						return -1;
					}
					if (id2 == targetRoleId)
					{
						return 1;
					}
				}
				int num = orderMap.ContainsKey(id) ? orderMap[id] : int.MaxValue;
				int num2 = orderMap.ContainsKey(id2) ? orderMap[id2] : int.MaxValue;
				return num - num2;
			});
			this.RoleLayout.RefreshByData(this.RoleDevelopDataList, new Action(this.OnRoleGridLayoutRefresh), true);
			base.GetScrollViewWithScrollbar(24).SetScrollProgress(0f);
		}

		// Token: 0x06033253 RID: 209491 RVA: 0x00BEDBC5 File Offset: 0x00BEBDC5
		private bool IsNormalRole(int roleId)
		{
			return !RoleDevelopUtil.IsAnyProspectRole(roleId);
		}

		// Token: 0x06033254 RID: 209492 RVA: 0x00BEDBD0 File Offset: 0x00BEBDD0
		private void OnRoleGridLayoutRefresh()
		{
			if (this.CurSelectRoleDevelopData == null)
			{
				this.CurSelectRoleDevelopData = this.RoleDevelopDataList[0];
			}
			int id = this.CurSelectRoleDevelopData.GetId();
			if (!this.IsNormalRole(id))
			{
				return;
			}
			this.RoleLayout.SelectGridProxyByKey(id, false);
			this.OnRoleGridItemSelected(this.CurSelectRoleDevelopData);
		}

		// Token: 0x06033255 RID: 209493 RVA: 0x00BEDC2C File Offset: 0x00BEBE2C
		private void OnHotRoleGridLayoutRefresh()
		{
			int id = this.CurSelectRoleDevelopData.GetId();
			if (this.IsNormalRole(id))
			{
				return;
			}
			this.HotRoleLayout.SelectGridProxyByKey(id, true);
			this.OnHotRoleGridItemSelected(this.CurSelectRoleDevelopData);
		}

		// Token: 0x06033256 RID: 209494 RVA: 0x00BEDC70 File Offset: 0x00BEBE70
		private void OnIntroductionBtnClick()
		{
			int id = this.CurSelectRoleDevelopData.GetId();
			if (RoleDevelopUtil.IsAnyProspectRole(id))
			{
				ChannelController.Instance.OpenGameIntroduction();
				return;
			}
			ChannelController.Instance.OpenGameIntroductionByRoleId(id);
		}

		// Token: 0x0401B2D5 RID: 111317
		private PopupCaptionItem CaptainItem;

		// Token: 0x0401B2D6 RID: 111318
		private GenericLayout<RoleDevelopHotRoleGridItem, RoleDevelopData> HotRoleLayout;

		// Token: 0x0401B2D7 RID: 111319
		private GenericLayout<RoleDevelopGridItem, RoleDevelopData> RoleLayout;

		// Token: 0x0401B2D8 RID: 111320
		[Nullable(2)]
		private RoleDevelopData CurSelectRoleDevelopData;

		// Token: 0x0401B2D9 RID: 111321
		private bool IsSelectedFromHotRole;

		// Token: 0x0401B2DA RID: 111322
		private RoleDevelopTagItem RoleDevelopTagItem;

		// Token: 0x0401B2DB RID: 111323
		private ERoleDevelopCategoryType? CurSelectCategoryType;

		// Token: 0x0401B2DC RID: 111324
		private GenericLayout<RoleDevelopCategoryItem, RoleDevelopCategoryData> CategoryLayout;

		// Token: 0x0401B2DD RID: 111325
		private CommonElementItem ElementItem;

		// Token: 0x0401B2DE RID: 111326
		private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

		// Token: 0x0401B2DF RID: 111327
		private List<RoleDataBase> RoleDataList = new List<RoleDataBase>();

		// Token: 0x0401B2E0 RID: 111328
		private List<RoleDevelopData> RoleDevelopDataList = new List<RoleDevelopData>();

		// Token: 0x0401B2E1 RID: 111329
		private Dictionary<ERoleDevelopCategoryType, RoleDevelopProjectBasePanel> ProjectPanelMap = new Dictionary<ERoleDevelopCategoryType, RoleDevelopProjectBasePanel>();

		// Token: 0x0401B2E2 RID: 111330
		private Dictionary<ERoleDevelopCategoryType, UUIItem> ProjectLayoutMap = new Dictionary<ERoleDevelopCategoryType, UUIItem>();

		// Token: 0x0401B2E3 RID: 111331
		private Dictionary<ERoleDevelopCategoryType, UUIItem> ProjectScrollViewMap = new Dictionary<ERoleDevelopCategoryType, UUIItem>();

		// Token: 0x0401B2E4 RID: 111332
		private bool RefreshOnShow;

		// Token: 0x0401B2E5 RID: 111333
		private bool NeedRebuildDataOnShow;

		// Token: 0x0401B2E6 RID: 111334
		[Nullable(2)]
		private RoleViewViewModel ViewModel;

		// Token: 0x0200AEBF RID: 44735
		[NullableContext(0)]
		public static class EComponentType
		{
			// Token: 0x04035125 RID: 217381
			public const int Caption = 0;

			// Token: 0x04035126 RID: 217382
			public const int GridNewRole = 1;

			// Token: 0x04035127 RID: 217383
			public const int GridOwnRole = 2;

			// Token: 0x04035128 RID: 217384
			public const int RoleItem = 3;

			// Token: 0x04035129 RID: 217385
			public const int FilterSortItem = 4;

			// Token: 0x0403512A RID: 217386
			public const int TextureRole = 5;

			// Token: 0x0403512B RID: 217387
			public const int TxtRoleName = 6;

			// Token: 0x0403512C RID: 217388
			public const int Tag = 7;

			// Token: 0x0403512D RID: 217389
			public const int DevelopTag = 8;

			// Token: 0x0403512E RID: 217390
			public const int TxtProperty = 9;

			// Token: 0x0403512F RID: 217391
			public const int ElementIcon = 10;

			// Token: 0x04035130 RID: 217392
			public const int ToggleLayout = 11;

			// Token: 0x04035131 RID: 217393
			public const int DevelopToggle = 12;

			// Token: 0x04035132 RID: 217394
			public const int SubRoleViewLayout = 13;

			// Token: 0x04035133 RID: 217395
			public const int SubRoleViewScrollView = 14;

			// Token: 0x04035134 RID: 217396
			public const int SubSkillViewLayout = 15;

			// Token: 0x04035135 RID: 217397
			public const int SubSkillViewScrollView = 16;

			// Token: 0x04035136 RID: 217398
			public const int SubWeaponViewLayout = 17;

			// Token: 0x04035137 RID: 217399
			public const int SubWeaponViewScrollView = 18;

			// Token: 0x04035138 RID: 217400
			public const int SubPhantomViewLayout = 19;

			// Token: 0x04035139 RID: 217401
			public const int SubPhantomViewScrollView = 20;

			// Token: 0x0403513A RID: 217402
			public const int EmptyPanel = 21;

			// Token: 0x0403513B RID: 217403
			public const int ToggleRoleMark = 22;

			// Token: 0x0403513C RID: 217404
			public const int IntroductionBtn = 23;

			// Token: 0x0403513D RID: 217405
			public const int ScrollView = 24;
		}
	}
}
