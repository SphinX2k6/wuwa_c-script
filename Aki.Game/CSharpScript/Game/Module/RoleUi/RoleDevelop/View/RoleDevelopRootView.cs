using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
	// Token: 0x02003D19 RID: 15641
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopRootView : UiViewBase
	{
		// Token: 0x06028089 RID: 163977 RVA: 0x00B35C3C File Offset: 0x00B33E3C
		public RoleDevelopRootView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602808A RID: 163978 RVA: 0x00B35C90 File Offset: 0x00B33E90
		protected unsafe override void OnRegisterComponent()
		{
			int num = 26;
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
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
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
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(21, new Action<EToggleState>(this.OnClickToggleRoleMark));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(22, new Action(this.OnIntroductionBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602808B RID: 163979 RVA: 0x00B36088 File Offset: 0x00B34288
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopRootView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopRootView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602808C RID: 163980 RVA: 0x00B360CC File Offset: 0x00B342CC
		protected override void OnStart()
		{
			base.GetButton(22).RootUIComp.Get().SetUIActive(true);
			this.RefreshRoleGridLayout();
			this.RefreshHotRoleGridLayout();
			this.RefreshRoleDevelopCategoryLayout();
			EventSystem.Instance.Add(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			EventSystem.Instance.Add<int>(EEventName.ActiveRole, new Action<int>(this.OnActiveRole));
		}

		// Token: 0x0602808D RID: 163981 RVA: 0x00B3615C File Offset: 0x00B3435C
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

		// Token: 0x0602808E RID: 163982 RVA: 0x00B361A3 File Offset: 0x00B343A3
		protected override void OnHandleReleaseScene()
		{
			this.TryReleaseScene();
		}

		// Token: 0x0602808F RID: 163983 RVA: 0x00B361AB File Offset: 0x00B343AB
		private void TryReleaseScene()
		{
			if (this.ViewModel != null)
			{
				this.ViewModel.HandleReleaseScene();
			}
			this.ViewModel = null;
		}

		// Token: 0x06028090 RID: 163984 RVA: 0x00B361C8 File Offset: 0x00B343C8
		protected override void OnBeforeDestroy()
		{
			this.TryReleaseScene();
			this.TryShowUiRoleModel();
			EventSystem.Instance.Remove(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
			EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			EventSystem.Instance.Remove<int>(EEventName.ActiveRole, new Action<int>(this.OnActiveRole));
		}

		// Token: 0x06028091 RID: 163985 RVA: 0x00B36238 File Offset: 0x00B34438
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
				this.TryRefreshCategoryLayoutByOverviewState();
				this.RefreshTitleView();
				this.RefreshProjectView(false);
				this.RefreshCategoryHint();
				this.RoleLayout.RefreshWithoutDataSync();
				this.HotRoleLayout.RefreshWithoutDataSync();
			}
			this.RefreshOnShow = false;
		}

		// Token: 0x06028092 RID: 163986 RVA: 0x00B362BF File Offset: 0x00B344BF
		protected override void OnBeforeHide()
		{
			this.RefreshOnShow = true;
		}

		// Token: 0x06028093 RID: 163987 RVA: 0x00B362C8 File Offset: 0x00B344C8
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

		// Token: 0x06028094 RID: 163988 RVA: 0x00B3636A File Offset: 0x00B3456A
		private void InitSortEntrance()
		{
			this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(base.GetItem(4), new TUpdateDataListFunction<RoleDataBase>(this.OnUpdateSortList));
		}

		// Token: 0x06028095 RID: 163989 RVA: 0x00B3638C File Offset: 0x00B3458C
		private UniTask InitCaptainItem()
		{
			RoleDevelopRootView.<InitCaptainItem>d__34 <InitCaptainItem>d__;
			<InitCaptainItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaptainItem>d__.<>4__this = this;
			<InitCaptainItem>d__.<>1__state = -1;
			<InitCaptainItem>d__.<>t__builder.Start<RoleDevelopRootView.<InitCaptainItem>d__34>(ref <InitCaptainItem>d__);
			return <InitCaptainItem>d__.<>t__builder.Task;
		}

		// Token: 0x06028096 RID: 163990 RVA: 0x00B363D0 File Offset: 0x00B345D0
		private UniTask InitRoleDevelopTagItem()
		{
			RoleDevelopRootView.<InitRoleDevelopTagItem>d__35 <InitRoleDevelopTagItem>d__;
			<InitRoleDevelopTagItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleDevelopTagItem>d__.<>4__this = this;
			<InitRoleDevelopTagItem>d__.<>1__state = -1;
			<InitRoleDevelopTagItem>d__.<>t__builder.Start<RoleDevelopRootView.<InitRoleDevelopTagItem>d__35>(ref <InitRoleDevelopTagItem>d__);
			return <InitRoleDevelopTagItem>d__.<>t__builder.Task;
		}

		// Token: 0x06028097 RID: 163991 RVA: 0x00B36414 File Offset: 0x00B34614
		private UniTask InitRoleElementItem()
		{
			RoleDevelopRootView.<InitRoleElementItem>d__36 <InitRoleElementItem>d__;
			<InitRoleElementItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleElementItem>d__.<>4__this = this;
			<InitRoleElementItem>d__.<>1__state = -1;
			<InitRoleElementItem>d__.<>t__builder.Start<RoleDevelopRootView.<InitRoleElementItem>d__36>(ref <InitRoleElementItem>d__);
			return <InitRoleElementItem>d__.<>t__builder.Task;
		}

		// Token: 0x06028098 RID: 163992 RVA: 0x00B36457 File Offset: 0x00B34657
		private void InitRoleDevelopCategoryItem()
		{
			this.CategoryLayout = new GenericLayout<RoleDevelopCategoryItem, RoleDevelopCategoryData>(base.GetHorizontalLayout(10), new Func<RoleDevelopCategoryItem>(this.CreateRoleDevelopCategoryItem), null, false, true);
		}

		// Token: 0x06028099 RID: 163993 RVA: 0x00B3647C File Offset: 0x00B3467C
		private UniTask InitRoleDevelopViewItem()
		{
			RoleDevelopRootView.<InitRoleDevelopViewItem>d__38 <InitRoleDevelopViewItem>d__;
			<InitRoleDevelopViewItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleDevelopViewItem>d__.<>4__this = this;
			<InitRoleDevelopViewItem>d__.<>1__state = -1;
			<InitRoleDevelopViewItem>d__.<>t__builder.Start<RoleDevelopRootView.<InitRoleDevelopViewItem>d__38>(ref <InitRoleDevelopViewItem>d__);
			return <InitRoleDevelopViewItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602809A RID: 163994 RVA: 0x00B364C0 File Offset: 0x00B346C0
		private void RefreshCategoryHint()
		{
			List<RoleDevelopCategoryItem> layoutItemList = this.CategoryLayout.GetLayoutItemList();
			RoleDevelopProjectBaseData projectData = this.CurSelectRoleDevelopData.GetProjectData();
			foreach (RoleDevelopCategoryItem roleDevelopCategoryItem in layoutItemList)
			{
				roleDevelopCategoryItem.RefreshHint(RoleDevelopUtil.GetCategoryHintType(projectData, roleDevelopCategoryItem.CategoryType));
			}
		}

		// Token: 0x0602809B RID: 163995 RVA: 0x00B36530 File Offset: 0x00B34730
		private void InitRoleGridLayout()
		{
			AActor owner = base.GetItem(3).GetOwner();
			this.HotRoleLayout = new GenericLayout<RoleDevelopHotRoleGridItem, RoleDevelopData>(base.GetGridLayout(1), new Func<RoleDevelopHotRoleGridItem>(this.CreateHotRoleGridItem), (AUIBaseActor)owner, false, true);
			this.RoleLayout = new GenericLayout<RoleDevelopGridItem, RoleDevelopData>(base.GetGridLayout(2), new Func<RoleDevelopGridItem>(this.CreateRoleGridItem), (AUIBaseActor)owner, false, true);
		}

		// Token: 0x0602809C RID: 163996 RVA: 0x00B36598 File Offset: 0x00B34798
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

		// Token: 0x0602809D RID: 163997 RVA: 0x00B365E4 File Offset: 0x00B347E4
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

		// Token: 0x0602809E RID: 163998 RVA: 0x00B36630 File Offset: 0x00B34830
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

		// Token: 0x0602809F RID: 163999 RVA: 0x00B366EC File Offset: 0x00B348EC
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

		// Token: 0x060280A0 RID: 164000 RVA: 0x00B36740 File Offset: 0x00B34940
		private void RefreshRoleDevelopCategoryLayout()
		{
			bool flag = this.IsOverviewAvailable();
			List<RoleDevelopCategoryData> list = new List<RoleDevelopCategoryData>();
			foreach (RoleDevelopCategoryData roleDevelopCategoryData in RoleDevelopDefine.roleDevelopCategoryConfig)
			{
				if (roleDevelopCategoryData.CategoryType != ERoleDevelopCategoryType.Overview || flag)
				{
					list.Add(roleDevelopCategoryData);
				}
			}
			RoleDevelopRootViewData roleDevelopRootViewData = this.OpenParam as RoleDevelopRootViewData;
			if (this.CurSelectCategoryType == null)
			{
				this.CurSelectCategoryType = new ERoleDevelopCategoryType?(((roleDevelopRootViewData != null) ? roleDevelopRootViewData.CategoryType : null) ?? this.GetDefaultCategoryType(flag));
			}
			if (this.CurSelectRoleDevelopData != null && this.CurSelectCategoryType.GetValueOrDefault() == ERoleDevelopCategoryType.Overview && !flag)
			{
				this.CurSelectCategoryType = new ERoleDevelopCategoryType?(ERoleDevelopCategoryType.Role);
			}
			this.LastOverviewAvailable = new bool?(flag);
			this.CategoryLayout.RefreshByData(list, delegate
			{
				this.CategoryLayout.SelectGridProxyByKey(this.CurSelectCategoryType.Value, true);
				if (this.CurSelectRoleDevelopData != null)
				{
					this.RefreshCategoryHint();
				}
			}, false);
		}

		// Token: 0x060280A1 RID: 164001 RVA: 0x00B3684C File Offset: 0x00B34A4C
		private bool IsOverviewAvailable()
		{
			return this.CurSelectRoleDevelopData != null && RoleModel.Instance.IsRoleOwned(this.CurSelectRoleDevelopData.GetId());
		}

		// Token: 0x060280A2 RID: 164002 RVA: 0x00B3686D File Offset: 0x00B34A6D
		private ERoleDevelopCategoryType GetDefaultCategoryType(bool isOverviewAvailable)
		{
			if (!isOverviewAvailable)
			{
				return ERoleDevelopCategoryType.Role;
			}
			return ERoleDevelopCategoryType.Overview;
		}

		// Token: 0x060280A3 RID: 164003 RVA: 0x00B36878 File Offset: 0x00B34A78
		private void ResetCategoryToDefaultOnRoleChange()
		{
			if (this.IsFirstRoleSelect)
			{
				this.IsFirstRoleSelect = false;
				RoleDevelopRootViewData roleDevelopRootViewData = this.OpenParam as RoleDevelopRootViewData;
				if (roleDevelopRootViewData != null && roleDevelopRootViewData.CategoryType != null)
				{
					this.TryRefreshCategoryLayoutByOverviewState();
					return;
				}
			}
			bool flag = this.IsOverviewAvailable();
			ERoleDevelopCategoryType defaultCategoryType = this.GetDefaultCategoryType(flag);
			bool? lastOverviewAvailable = this.LastOverviewAvailable;
			bool flag2 = flag;
			if (!(lastOverviewAvailable.GetValueOrDefault() == flag2 & lastOverviewAvailable != null))
			{
				this.CurSelectCategoryType = new ERoleDevelopCategoryType?(defaultCategoryType);
				this.RefreshRoleDevelopCategoryLayout();
				return;
			}
			ERoleDevelopCategoryType? curSelectCategoryType = this.CurSelectCategoryType;
			ERoleDevelopCategoryType eroleDevelopCategoryType = defaultCategoryType;
			if (curSelectCategoryType.GetValueOrDefault() == eroleDevelopCategoryType & curSelectCategoryType != null)
			{
				return;
			}
			this.CurSelectCategoryType = new ERoleDevelopCategoryType?(defaultCategoryType);
			this.CategoryLayout.DeselectCurrentGridProxy();
			this.CategoryLayout.SelectGridProxyByKey(defaultCategoryType, false);
		}

		// Token: 0x060280A4 RID: 164004 RVA: 0x00B36944 File Offset: 0x00B34B44
		private void TryRefreshCategoryLayoutByOverviewState()
		{
			bool? lastOverviewAvailable = this.LastOverviewAvailable;
			bool flag = this.IsOverviewAvailable();
			if (lastOverviewAvailable.GetValueOrDefault() == flag & lastOverviewAvailable != null)
			{
				return;
			}
			this.RefreshRoleDevelopCategoryLayout();
		}

		// Token: 0x060280A5 RID: 164005 RVA: 0x00B3697C File Offset: 0x00B34B7C
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
			this.RefreshRoleMarkToggle();
		}

		// Token: 0x060280A6 RID: 164006 RVA: 0x00B36A00 File Offset: 0x00B34C00
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
			foreach (KeyValuePair<ERoleDevelopCategoryType, RoleDevelopProjectBasePanel> keyValuePair2 in this.ProjectPanelMap)
			{
				ERoleDevelopCategoryType eroleDevelopCategoryType;
				RoleDevelopProjectBasePanel roleDevelopProjectBasePanel;
				keyValuePair2.Deconstruct(out eroleDevelopCategoryType, out roleDevelopProjectBasePanel);
				ERoleDevelopCategoryType eroleDevelopCategoryType4 = eroleDevelopCategoryType;
				roleDevelopProjectBasePanel.RefreshView(this.CurSelectRoleDevelopData, forceRefresh, eroleDevelopCategoryType4 == this.CurSelectCategoryType.Value);
			}
			bool uiactive = this.CurSelectCategoryType.Value == ERoleDevelopCategoryType.Phantom && RoleDevelopUtil.IsAnyProspectRole(this.CurSelectRoleDevelopData.GetId());
			base.GetItem(20).SetUIActive(uiactive);
		}

		// Token: 0x060280A7 RID: 164007 RVA: 0x00B36B80 File Offset: 0x00B34D80
		private void RefreshRoleMarkToggle()
		{
			int id = this.CurSelectRoleDevelopData.GetId();
			UUIExtendToggle extendToggle = base.GetExtendToggle(21);
			extendToggle.RootUIComp.Get().SetUIActive(true);
			bool flag = RoleDevelopModel.Instance.DevTargetRoleId == id;
			EToggleState state = flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleStateForce(state, false, false, false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(25), flag ? "RoleProject_CancelDevelopTarget" : "RoleProject_SetDevelopTarget", Array.Empty<object>());
		}

		// Token: 0x060280A8 RID: 164008 RVA: 0x00B36BFC File Offset: 0x00B34DFC
		private void OnHotRoleGridItemSelected(RoleDevelopData data)
		{
			this.RoleLayout.DeselectCurrentGridProxy();
			this.HotRoleLayout.DeselectCurrentGridProxy();
			this.HotRoleLayout.SelectGridProxyByKey(data.GetId(), false);
			this.CurSelectRoleDevelopData = data;
			this.IsSelectedFromHotRole = true;
			this.ResetCategoryToDefaultOnRoleChange();
			this.RefreshTitleView();
			this.RefreshProjectView(true);
			this.RefreshCategoryHint();
			this.UiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
			this.PlayCurSelectPanelStartSequence();
			this.TryLogSwitchPage(true);
		}

		// Token: 0x060280A9 RID: 164009 RVA: 0x00B36C84 File Offset: 0x00B34E84
		private void OnRoleGridItemSelected(RoleDevelopData data)
		{
			this.RoleLayout.DeselectCurrentGridProxy();
			this.HotRoleLayout.DeselectCurrentGridProxy();
			this.RoleLayout.SelectGridProxyByKey(data.GetId(), false);
			this.CurSelectRoleDevelopData = data;
			this.IsSelectedFromHotRole = false;
			this.ResetCategoryToDefaultOnRoleChange();
			this.RefreshTitleView();
			this.RefreshProjectView(true);
			this.RefreshCategoryHint();
			this.UiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
			this.PlayCurSelectPanelStartSequence();
			this.TryLogSwitchPage(true);
		}

		// Token: 0x060280AA RID: 164010 RVA: 0x00B36D0C File Offset: 0x00B34F0C
		private void OnCloseButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x060280AB RID: 164011 RVA: 0x00B36D15 File Offset: 0x00B34F15
		private RoleDevelopHotRoleGridItem CreateHotRoleGridItem()
		{
			RoleDevelopHotRoleGridItem roleDevelopHotRoleGridItem = new RoleDevelopHotRoleGridItem();
			roleDevelopHotRoleGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnHotRoleGridItemToggleChanged));
			roleDevelopHotRoleGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnHotRoleGridItemCanExecuteChange));
			return roleDevelopHotRoleGridItem;
		}

		// Token: 0x060280AC RID: 164012 RVA: 0x00B36D40 File Offset: 0x00B34F40
		private RoleDevelopGridItem CreateRoleGridItem()
		{
			RoleDevelopGridItem roleDevelopGridItem = new RoleDevelopGridItem();
			roleDevelopGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnRoleGridItemToggleChanged));
			roleDevelopGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnRoleGridItemCanExecuteChange));
			return roleDevelopGridItem;
		}

		// Token: 0x060280AD RID: 164013 RVA: 0x00B36D6B File Offset: 0x00B34F6B
		private void OnRoleGridItemToggleChanged(MediumItemGridExtendCallback callbackParameter)
		{
			this.OnRoleGridItemSelected((RoleDevelopData)callbackParameter.Data);
		}

		// Token: 0x060280AE RID: 164014 RVA: 0x00B36D80 File Offset: 0x00B34F80
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

		// Token: 0x060280AF RID: 164015 RVA: 0x00B36DD6 File Offset: 0x00B34FD6
		private void OnHotRoleGridItemToggleChanged(MediumItemGridExtendCallback callbackParameter)
		{
			this.OnHotRoleGridItemSelected((RoleDevelopData)callbackParameter.Data);
		}

		// Token: 0x060280B0 RID: 164016 RVA: 0x00B36DEC File Offset: 0x00B34FEC
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

		// Token: 0x060280B1 RID: 164017 RVA: 0x00B36E42 File Offset: 0x00B35042
		private RoleDevelopCategoryItem CreateRoleDevelopCategoryItem()
		{
			RoleDevelopCategoryItem roleDevelopCategoryItem = new RoleDevelopCategoryItem();
			roleDevelopCategoryItem.SetToggleCallback(new Action<RoleDevelopCategoryData>(this.OnRoleDevelopCategoryItemToggle));
			roleDevelopCategoryItem.SetCanExecuteCallback(new Func<RoleDevelopCategoryData, bool>(this.OnRoleDevelopCategoryItemCanExecute));
			return roleDevelopCategoryItem;
		}

		// Token: 0x060280B2 RID: 164018 RVA: 0x00B36E6D File Offset: 0x00B3506D
		private void OnRoleDevelopCategoryItemToggle(RoleDevelopCategoryData data)
		{
			this.SwitchToCategory(data.CategoryType, true);
		}

		// Token: 0x060280B3 RID: 164019 RVA: 0x00B36E7C File Offset: 0x00B3507C
		private void SwitchToCategory(ERoleDevelopCategoryType categoryType, bool needLog)
		{
			this.CategoryLayout.DeselectCurrentGridProxy();
			this.CategoryLayout.SelectGridProxyByKey(categoryType, false);
			this.CurSelectCategoryType = new ERoleDevelopCategoryType?(categoryType);
			this.RefreshProjectView(false);
			this.PlayCurSelectPanelStartSequence();
			this.TryLogSwitchPage(needLog);
		}

		// Token: 0x060280B4 RID: 164020 RVA: 0x00B36EBC File Offset: 0x00B350BC
		private void TryLogSwitchPage(bool needLog = true)
		{
			if (this.CurSelectRoleDevelopData == null || this.CurSelectCategoryType == null)
			{
				return;
			}
			ValueTuple<int, ERoleDevelopCategoryType> valueTuple = new ValueTuple<int, ERoleDevelopCategoryType>(this.CurSelectRoleDevelopData.GetId(), this.CurSelectCategoryType.Value);
			ValueTuple<int, ERoleDevelopCategoryType>? lastLogPage = this.LastLogPage;
			ValueTuple<int, ERoleDevelopCategoryType> valueTuple2 = valueTuple;
			bool flag = lastLogPage != null;
			bool flag2;
			if (!flag)
			{
				flag2 = false;
			}
			else if (!flag)
			{
				flag2 = true;
			}
			else
			{
				ValueTuple<int, ERoleDevelopCategoryType> valueOrDefault = lastLogPage.GetValueOrDefault();
				flag2 = (valueOrDefault.Item1 == valueTuple2.Item1 && valueOrDefault.Item2 == valueTuple2.Item2);
			}
			if (flag2)
			{
				return;
			}
			this.LastLogPage = new ValueTuple<int, ERoleDevelopCategoryType>?(valueTuple);
			if (needLog)
			{
				RoleController.Instance.LogRoleDevelopSwitchPage(valueTuple.Item1, valueTuple.Item2);
			}
		}

		// Token: 0x060280B5 RID: 164021 RVA: 0x00B36F6C File Offset: 0x00B3516C
		private void PlayCurSelectPanelStartSequence()
		{
			if (this.CurSelectCategoryType == null)
			{
				return;
			}
			RoleDevelopProjectBasePanel roleDevelopProjectBasePanel;
			if (this.ProjectPanelMap.TryGetValue(this.CurSelectCategoryType.Value, out roleDevelopProjectBasePanel))
			{
				roleDevelopProjectBasePanel.PlaySequenceByName("Start", false);
			}
		}

		// Token: 0x060280B6 RID: 164022 RVA: 0x00B36FB0 File Offset: 0x00B351B0
		public void SwitchCategory(ERoleDevelopCategoryType categoryType)
		{
			ERoleDevelopCategoryType? curSelectCategoryType = this.CurSelectCategoryType;
			if (curSelectCategoryType.GetValueOrDefault() == categoryType & curSelectCategoryType != null)
			{
				return;
			}
			foreach (RoleDevelopCategoryData roleDevelopCategoryData in RoleDevelopDefine.roleDevelopCategoryConfig)
			{
				if (roleDevelopCategoryData.CategoryType == categoryType)
				{
					this.SwitchToCategory(roleDevelopCategoryData.CategoryType, false);
					break;
				}
			}
		}

		// Token: 0x060280B7 RID: 164023 RVA: 0x00B37034 File Offset: 0x00B35234
		private bool OnRoleDevelopCategoryItemCanExecute(RoleDevelopCategoryData data)
		{
			ERoleDevelopCategoryType? curSelectCategoryType = this.CurSelectCategoryType;
			ERoleDevelopCategoryType categoryType = data.CategoryType;
			return !(curSelectCategoryType.GetValueOrDefault() == categoryType & curSelectCategoryType != null);
		}

		// Token: 0x060280B8 RID: 164024 RVA: 0x00B37064 File Offset: 0x00B35264
		private void OnClickToggleRoleMark(EToggleState state)
		{
			int id = this.CurSelectRoleDevelopData.GetId();
			int roleId = (RoleDevelopModel.Instance.DevTargetRoleId == id) ? 0 : id;
			RoleDevelopProjectPhantomPanel roleDevelopProjectPhantomPanel = (RoleDevelopProjectPhantomPanel)this.ProjectPanelMap[ERoleDevelopCategoryType.Phantom];
			RoleController.Instance.RequestUpdateDevelopTarget(roleId, ERoleDevelopUpdateTargetSource.RoleDevelop, new int?(roleDevelopProjectPhantomPanel.SelectPlanId), roleDevelopProjectPhantomPanel.SelectFirstVisionMonsterId);
		}

		// Token: 0x060280B9 RID: 164025 RVA: 0x00B370BE File Offset: 0x00B352BE
		private void OnCommonItemCountAnyChange(int configId, int count)
		{
			if (this.CurSelectCategoryType == null)
			{
				return;
			}
			this.ProjectPanelMap[this.CurSelectCategoryType.Value].OnCommonItemCountAnyChange(configId);
			this.RefreshCategoryHint();
		}

		// Token: 0x060280BA RID: 164026 RVA: 0x00B370F0 File Offset: 0x00B352F0
		private void OnRoleDevTargetRoleIdChange()
		{
			this.RefreshRoleMarkToggle();
			this.RoleLayout.RefreshWithoutDataSync();
			this.HotRoleLayout.RefreshWithoutDataSync();
		}

		// Token: 0x060280BB RID: 164027 RVA: 0x00B3710E File Offset: 0x00B3530E
		private void OnActiveRole(int roleId)
		{
			this.NeedRebuildDataOnShow = true;
		}

		// Token: 0x060280BC RID: 164028 RVA: 0x00B37118 File Offset: 0x00B35318
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
			base.GetScrollViewWithScrollbar(23).SetScrollProgress(0f);
		}

		// Token: 0x060280BD RID: 164029 RVA: 0x00B371BD File Offset: 0x00B353BD
		private bool IsNormalRole(int roleId)
		{
			return !RoleDevelopUtil.IsAnyProspectRole(roleId);
		}

		// Token: 0x060280BE RID: 164030 RVA: 0x00B371C8 File Offset: 0x00B353C8
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

		// Token: 0x060280BF RID: 164031 RVA: 0x00B37224 File Offset: 0x00B35424
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

		// Token: 0x060280C0 RID: 164032 RVA: 0x00B37268 File Offset: 0x00B35468
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

		// Token: 0x04015CA7 RID: 89255
		private PopupCaptionItem CaptainItem;

		// Token: 0x04015CA8 RID: 89256
		private GenericLayout<RoleDevelopHotRoleGridItem, RoleDevelopData> HotRoleLayout;

		// Token: 0x04015CA9 RID: 89257
		private GenericLayout<RoleDevelopGridItem, RoleDevelopData> RoleLayout;

		// Token: 0x04015CAA RID: 89258
		[Nullable(2)]
		private RoleDevelopData CurSelectRoleDevelopData;

		// Token: 0x04015CAB RID: 89259
		private bool IsSelectedFromHotRole;

		// Token: 0x04015CAC RID: 89260
		private RoleDevelopTagItem RoleDevelopTagItem;

		// Token: 0x04015CAD RID: 89261
		private ERoleDevelopCategoryType? CurSelectCategoryType;

		// Token: 0x04015CAE RID: 89262
		private GenericLayout<RoleDevelopCategoryItem, RoleDevelopCategoryData> CategoryLayout;

		// Token: 0x04015CAF RID: 89263
		private CommonElementItem ElementItem;

		// Token: 0x04015CB0 RID: 89264
		private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

		// Token: 0x04015CB1 RID: 89265
		private List<RoleDataBase> RoleDataList = new List<RoleDataBase>();

		// Token: 0x04015CB2 RID: 89266
		private List<RoleDevelopData> RoleDevelopDataList = new List<RoleDevelopData>();

		// Token: 0x04015CB3 RID: 89267
		private Dictionary<ERoleDevelopCategoryType, RoleDevelopProjectBasePanel> ProjectPanelMap = new Dictionary<ERoleDevelopCategoryType, RoleDevelopProjectBasePanel>();

		// Token: 0x04015CB4 RID: 89268
		private Dictionary<ERoleDevelopCategoryType, UUIItem> ProjectLayoutMap = new Dictionary<ERoleDevelopCategoryType, UUIItem>();

		// Token: 0x04015CB5 RID: 89269
		private Dictionary<ERoleDevelopCategoryType, UUIItem> ProjectScrollViewMap = new Dictionary<ERoleDevelopCategoryType, UUIItem>();

		// Token: 0x04015CB6 RID: 89270
		private bool RefreshOnShow;

		// Token: 0x04015CB7 RID: 89271
		private bool NeedRebuildDataOnShow;

		// Token: 0x04015CB8 RID: 89272
		private bool? LastOverviewAvailable;

		// Token: 0x04015CB9 RID: 89273
		private bool IsFirstRoleSelect = true;

		// Token: 0x04015CBA RID: 89274
		[TupleElementNames(new string[]
		{
			"RoleId",
			"CategoryType"
		})]
		[Nullable(0)]
		private ValueTuple<int, ERoleDevelopCategoryType>? LastLogPage;

		// Token: 0x04015CBB RID: 89275
		[Nullable(2)]
		private RoleViewViewModel ViewModel;

		// Token: 0x020098F3 RID: 39155
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FB4F RID: 195407
			Caption,
			// Token: 0x0402FB50 RID: 195408
			GridNewRole,
			// Token: 0x0402FB51 RID: 195409
			GridOwnRole,
			// Token: 0x0402FB52 RID: 195410
			RoleItem,
			// Token: 0x0402FB53 RID: 195411
			FilterSortItem,
			// Token: 0x0402FB54 RID: 195412
			TextureRole,
			// Token: 0x0402FB55 RID: 195413
			TxtRoleName,
			// Token: 0x0402FB56 RID: 195414
			Tag,
			// Token: 0x0402FB57 RID: 195415
			DevelopTag,
			// Token: 0x0402FB58 RID: 195416
			ElementIcon,
			// Token: 0x0402FB59 RID: 195417
			ToggleLayout,
			// Token: 0x0402FB5A RID: 195418
			DevelopToggle,
			// Token: 0x0402FB5B RID: 195419
			SubRoleViewLayout,
			// Token: 0x0402FB5C RID: 195420
			SubRoleViewScrollView,
			// Token: 0x0402FB5D RID: 195421
			SubSkillViewLayout,
			// Token: 0x0402FB5E RID: 195422
			SubSkillViewScrollView,
			// Token: 0x0402FB5F RID: 195423
			SubWeaponViewLayout,
			// Token: 0x0402FB60 RID: 195424
			SubWeaponViewScrollView,
			// Token: 0x0402FB61 RID: 195425
			SubPhantomViewLayout,
			// Token: 0x0402FB62 RID: 195426
			SubPhantomViewScrollView,
			// Token: 0x0402FB63 RID: 195427
			EmptyPanel,
			// Token: 0x0402FB64 RID: 195428
			ToggleRoleMark,
			// Token: 0x0402FB65 RID: 195429
			IntroductionBtn,
			// Token: 0x0402FB66 RID: 195430
			ScrollView,
			// Token: 0x0402FB67 RID: 195431
			OverviewPanel,
			// Token: 0x0402FB68 RID: 195432
			ToggleText
		}
	}
}
