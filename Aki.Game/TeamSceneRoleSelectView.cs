using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C83 RID: 7299
[NullableContext(1)]
[Nullable(0)]
public class TeamSceneRoleSelectView : UiViewBase
{
	// Token: 0x060121C5 RID: 74181 RVA: 0x00555918 File Offset: 0x00553B18
	public TeamSceneRoleSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060121C6 RID: 74182 RVA: 0x00555924 File Offset: 0x00553B24
	protected unsafe override void OnRegisterComponent()
	{
		int num = 21;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickDetail));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickConfirm));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnTypeToggleStateChanged));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(20, new Action(this.OnClickCloseType));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060121C7 RID: 74183 RVA: 0x00555CB4 File Offset: 0x00553EB4
	protected override UniTask OnBeforeStartAsync()
	{
		TeamSceneRoleSelectView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TeamSceneRoleSelectView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060121C8 RID: 74184 RVA: 0x00555CF8 File Offset: 0x00553EF8
	protected override void OnStart()
	{
		TeamRoleSelectViewData data = this.Data;
		this.RoleList = ((data != null) ? data.RoleList : null);
		List<RoleDataBase> roleList = this.RoleList;
		this.CurSelectRole = ((roleList != null) ? roleList.Find(delegate(RoleDataBase role)
		{
			int dataId = role.GetDataId();
			TeamRoleSelectViewData data3 = this.Data;
			int? num = (data3 != null) ? new int?(data3.CurrentRoleId) : null;
			return dataId == num.GetValueOrDefault() & num != null;
		}) : null);
		this.RoleScrollView = new LoopScrollView<TeamRoleGridBase, RoleDataBase>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<TeamRoleGridBase>(this.OnGridProxyCreate), false);
		this.TypeIconLayout = new SimpleGenericLayout(base.GetHorizontalLayout(7));
		this.TypeDetailScrollView = new GenericScrollViewNew<RolePropertyDetailItem, int>(base.GetScrollViewWithScrollbar(10), new Func<RolePropertyDetailItem>(this.InitTypeDetailItem), base.GetItem(11).GetOwner() as AUIBaseActor, false, null);
		this.InitRoleIndexMap();
		this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(base.GetItem(3), new TUpdateDataListFunction<RoleDataBase>(this.UpdateRoleList));
		List<RoleDataBase> roleList2 = this.RoleList;
		if (roleList2 != null)
		{
			roleList2.Sort((RoleDataBase a, RoleDataBase b) => b.GetRoleConfig().Priority - a.GetRoleConfig().Priority);
		}
		TeamRoleSelectViewData data2 = this.Data;
		if (data2 != null && data2.UseWay != null && this.RoleList != null)
		{
			this.FilterSortEntrance.UpdateData(this.Data.UseWay.Value, this.RoleList, Array.Empty<object>());
		}
	}

	// Token: 0x060121C9 RID: 74185 RVA: 0x00555E54 File Offset: 0x00554054
	protected override void OnBeforeShow()
	{
		this.HasAfterShow = false;
		TeamRoleSelectViewData data = this.Data;
		if (data != null)
		{
			Action<UUIItem> onModelLoadingAnchorChanged = data.OnModelLoadingAnchorChanged;
			if (onModelLoadingAnchorChanged != null)
			{
				onModelLoadingAnchorChanged(base.GetItem(17));
			}
		}
		if (this.PendingDetailCloseNotify)
		{
			this.PendingDetailCloseNotify = false;
			TeamRoleSelectViewData data2 = this.Data;
			if (data2 != null)
			{
				Action onDetailClose = data2.OnDetailClose;
				if (onDetailClose != null)
				{
					onDetailClose();
				}
			}
		}
		if (this.IsNeedRefreshTeamList)
		{
			this.RefreshRoleListAfterChangeRole();
			this.IsNeedRefreshTeamList = false;
		}
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.RoleWeaponTabView);
	}

	// Token: 0x060121CA RID: 74186 RVA: 0x00555ED7 File Offset: 0x005540D7
	protected override void OnAfterShow()
	{
		this.HasAfterShow = true;
		this.NotifyCurrentRoleSelect();
	}

	// Token: 0x060121CB RID: 74187 RVA: 0x00555EE8 File Offset: 0x005540E8
	protected override void OnBeforeHide()
	{
		this.HasAfterShow = false;
		TeamRoleSelectViewData data = this.Data;
		if (data != null)
		{
			Action<UUIItem> onModelLoadingAnchorChanged = data.OnModelLoadingAnchorChanged;
			if (onModelLoadingAnchorChanged != null)
			{
				onModelLoadingAnchorChanged(null);
			}
		}
		if (this.PendingDetailOpenNotify)
		{
			this.PendingDetailOpenNotify = false;
			TeamRoleSelectViewData data2 = this.Data;
			if (data2 == null)
			{
				return;
			}
			Action onDetailOpen = data2.OnDetailOpen;
			if (onDetailOpen == null)
			{
				return;
			}
			onDetailOpen();
		}
	}

	// Token: 0x060121CC RID: 74188 RVA: 0x00555F42 File Offset: 0x00554142
	private void CloseTypeDetailPanel()
	{
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(6);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060121CD RID: 74189 RVA: 0x00555F70 File Offset: 0x00554170
	private void NotifyCurrentRoleSelect()
	{
		RoleDataBase curSelectRole = this.CurSelectRole;
		int? num = (curSelectRole != null) ? new int?(curSelectRole.GetDataId()) : null;
		if (num != null)
		{
			this.NotifyRoleSelect(num.Value);
		}
	}

	// Token: 0x060121CE RID: 74190 RVA: 0x00555FB3 File Offset: 0x005541B3
	private void NotifyRoleSelect(int roleId)
	{
		if (!this.HasAfterShow || !base.GetActive())
		{
			return;
		}
		TeamRoleSelectViewData data = this.Data;
		if (data == null)
		{
			return;
		}
		Action<int> onRoleSelect = data.OnRoleSelect;
		if (onRoleSelect == null)
		{
			return;
		}
		onRoleSelect(roleId);
	}

	// Token: 0x060121CF RID: 74191 RVA: 0x00555FE1 File Offset: 0x005541E1
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x060121D0 RID: 74192 RVA: 0x0055601B File Offset: 0x0055421B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x060121D1 RID: 74193 RVA: 0x00556058 File Offset: 0x00554258
	protected override void OnBeforeDestroy()
	{
		TeamRoleSelectViewData data = this.Data;
		if (data != null)
		{
			Action<UUIItem> onModelLoadingAnchorChanged = data.OnModelLoadingAnchorChanged;
			if (onModelLoadingAnchorChanged != null)
			{
				onModelLoadingAnchorChanged(null);
			}
		}
		TeamRoleSelectViewData data2 = this.Data;
		if (data2 != null)
		{
			Action onHideFinishCallBack = data2.OnHideFinishCallBack;
			if (onHideFinishCallBack != null)
			{
				onHideFinishCallBack();
			}
		}
		FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
		if (filterSortEntrance != null)
		{
			filterSortEntrance.Destroy(null);
		}
		this.FilterSortEntrance = null;
		MiniElementItem miniElementItem = this.MiniElementItem;
		if (miniElementItem != null)
		{
			miniElementItem.Destroy(null);
		}
		this.MiniElementItem = null;
		this.TrialLabelItem = null;
		this.ModeToggleItem = null;
		this.TypeIconLayout = null;
		this.TypeDetailScrollView = null;
		LoopScrollView<TeamRoleGridBase, RoleDataBase> roleScrollView = this.RoleScrollView;
		if (roleScrollView != null)
		{
			roleScrollView.ClearGridProxies();
		}
		this.RoleScrollView = null;
		List<RoleDataBase> roleList = this.RoleList;
		if (roleList != null)
		{
			roleList.Clear();
		}
		this.RoleList = null;
		this.CurSelectRole = null;
		this.Data = null;
	}

	// Token: 0x060121D2 RID: 74194 RVA: 0x0055612C File Offset: 0x0055432C
	private UniTask InitCaption()
	{
		TeamSceneRoleSelectView.<InitCaption>d__29 <InitCaption>d__;
		<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaption>d__.<>4__this = this;
		<InitCaption>d__.<>1__state = -1;
		<InitCaption>d__.<>t__builder.Start<TeamSceneRoleSelectView.<InitCaption>d__29>(ref <InitCaption>d__);
		return <InitCaption>d__.<>t__builder.Task;
	}

	// Token: 0x060121D3 RID: 74195 RVA: 0x0055616F File Offset: 0x0055436F
	private void OnClickClose()
	{
		TeamRoleSelectViewData data = this.Data;
		if (data != null)
		{
			Action backCallBack = data.BackCallBack;
			if (backCallBack != null)
			{
				backCallBack();
			}
		}
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x060121D4 RID: 74196 RVA: 0x005561A4 File Offset: 0x005543A4
	private TeamRoleGridBase OnGridProxyCreate()
	{
		TeamRoleSelectViewData data = this.Data;
		TeamRoleGridBase teamRoleGridBase = (((data != null) ? data.OverrideGridProxyCreate : null) != null) ? this.Data.OverrideGridProxyCreate() : new TeamRoleGrid();
		teamRoleGridBase.IsHighlightIndex = new Func<int, bool>(this.IsHighlightIndex);
		teamRoleGridBase.IsShowGray = new Func<int, bool>(this.IsShowGray);
		teamRoleGridBase.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		teamRoleGridBase.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return teamRoleGridBase;
	}

	// Token: 0x060121D5 RID: 74197 RVA: 0x00556224 File Offset: 0x00554424
	protected bool IsHighlightIndex(int position)
	{
		TeamRoleSelectViewData data = this.Data;
		int? num = (data != null) ? data.Position : null;
		return position == num.GetValueOrDefault() & num != null;
	}

	// Token: 0x060121D6 RID: 74198 RVA: 0x0055625E File Offset: 0x0055445E
	protected bool IsShowGray(int roleId)
	{
		TeamRoleSelectViewData data = this.Data;
		return data == null || !data.CanUseSpecialTrialRole || !RoleUtils.IsSpecialTrialRole(roleId);
	}

	// Token: 0x060121D7 RID: 74199 RVA: 0x00556284 File Offset: 0x00554484
	protected bool CanExecuteChangeFunction(object data, bool isForceSelected, EToggleState state)
	{
		RoleDataBase roleDataBase = data as RoleDataBase;
		if (roleDataBase == null)
		{
			return false;
		}
		int dataId = roleDataBase.GetDataId();
		TeamRoleSelectViewData data2 = this.Data;
		if ((data2 == null || !data2.CanUseSpecialTrialRole) && RoleUtils.IsSpecialTrialRole(dataId))
		{
			TeamRoleSelectViewData data3 = this.Data;
			if (Array.IndexOf<int>(((data3 != null) ? data3.FormationRoleList : null) ?? Array.Empty<int>(), dataId) < 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PrefabTextItem_1024721374_Text", Array.Empty<object>());
				return false;
			}
		}
		return state != EToggleState.ETT_Checked || this.CurSelectRole != roleDataBase;
	}

	// Token: 0x060121D8 RID: 74200 RVA: 0x00556310 File Offset: 0x00554510
	protected void ToggleFunction(MediumItemGridExtendCallback @params)
	{
		if (@params.State != EToggleState.ETT_Checked)
		{
			return;
		}
		RoleDataBase curSelectRole = this.CurSelectRole;
		int? num = (curSelectRole != null) ? new int?(curSelectRole.GetDataId()) : null;
		if (num != null)
		{
			RoleSelectModel.Instance.SelectedRoleSet.Remove(num.Value);
		}
		RoleDataBase roleDataBase = @params.Data as RoleDataBase;
		if (roleDataBase == null)
		{
			return;
		}
		this.CurSelectRole = roleDataBase;
		this.SelectCurrentRole(false);
		this.NotifyRoleSelect(this.CurSelectRole.GetDataId());
	}

	// Token: 0x060121D9 RID: 74201 RVA: 0x00556398 File Offset: 0x00554598
	private void SelectCurrentRole(bool shouldNotifyRoleSelect = false)
	{
		if (this.RoleList == null || this.RoleScrollView == null || this.CurSelectRole == null)
		{
			return;
		}
		int gridIndex = this.RoleList.IndexOf(this.CurSelectRole);
		this.RoleScrollView.SelectGridProxy(gridIndex, false);
		int dataId = this.CurSelectRole.GetDataId();
		RoleSelectModel.Instance.SelectedRoleSet.Add(dataId);
		this.CloseTypeDetailPanel();
		this.RefreshConfirmText(dataId);
		this.RefreshConfirmButtonEnable(dataId);
		this.RefreshRoleInfo();
		if (shouldNotifyRoleSelect)
		{
			this.NotifyRoleSelect(dataId);
		}
	}

	// Token: 0x060121DA RID: 74202 RVA: 0x00556420 File Offset: 0x00554620
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		int num;
		if (configParams.Length != 0 && int.TryParse(configParams[0], out num) && num != 0)
		{
			UUIItem scrollItemByRoleId = this.GetScrollItemByRoleId(num);
			if (scrollItemByRoleId != null)
			{
				return new UUIItem[]
				{
					scrollItemByRoleId,
					scrollItemByRoleId
				};
			}
		}
		return null;
	}

	// Token: 0x060121DB RID: 74203 RVA: 0x0055645C File Offset: 0x0055465C
	[NullableContext(2)]
	private UUIItem GetScrollItemByRoleId(int roleId)
	{
		int index = 0;
		UUIItem result = null;
		if (this.RoleList != null)
		{
			foreach (RoleDataBase roleDataBase in this.RoleList)
			{
				if (roleDataBase.GetRoleId() == roleId)
				{
					index = this.RoleList.IndexOf(roleDataBase);
					LoopScrollView<TeamRoleGridBase, RoleDataBase> roleScrollView = this.RoleScrollView;
					result = ((roleScrollView != null) ? roleScrollView.GetGrid(index) : null);
					break;
				}
			}
		}
		TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			LoopScrollView<TeamRoleGridBase, RoleDataBase> roleScrollView2 = this.RoleScrollView;
			if (roleScrollView2 == null)
			{
				return;
			}
			roleScrollView2.ScrollToGridIndex(index, false);
		}, null, null);
		return result;
	}

	// Token: 0x060121DC RID: 74204 RVA: 0x00556518 File Offset: 0x00554718
	private void RefreshRoleInfo()
	{
		if (this.CurSelectRole == null)
		{
			this.SetRoleInfoActive(false);
			return;
		}
		this.SetRoleInfoActive(true);
		this.RefreshElement(this.CurSelectRole.GetRoleConfig().ElementId);
		this.RefreshTypeIcon();
		UUIArtText artText = base.GetArtText(14);
		if (artText != null)
		{
			artText.SetText(this.CurSelectRole.GetLevelData().GetLevel().ToString());
		}
		UUIText text = base.GetText(15);
		if (text != null)
		{
			text.SetText(this.CurSelectRole.GetName(null), true);
		}
		int dataId = this.CurSelectRole.GetDataId();
		this.RefreshTrialLabel(dataId);
		this.RefreshModeToggle(dataId);
	}

	// Token: 0x060121DD RID: 74205 RVA: 0x005565C8 File Offset: 0x005547C8
	private void SetRoleInfoActive(bool isActive)
	{
		UUIItem item = base.GetItem(17);
		if (item != null)
		{
			item.SetUIActive(!isActive);
		}
		UUIItem item2 = base.GetItem(18);
		if (item2 != null)
		{
			item2.SetUIActive(isActive);
		}
		UUIItem item3 = base.GetItem(13);
		if (item3 != null)
		{
			item3.SetUIActive(isActive);
		}
		SimpleGenericLayout typeIconLayout = this.TypeIconLayout;
		if (typeIconLayout != null)
		{
			typeIconLayout.SetActive(isActive);
		}
		UUIArtText artText = base.GetArtText(14);
		if (artText != null)
		{
			artText.SetUIActive(isActive);
		}
		UUIText text = base.GetText(15);
		if (text != null)
		{
			text.SetUIActive(isActive);
		}
		if (!isActive)
		{
			TeamRoleSelectViewData data = this.Data;
			if (data != null)
			{
				Action<int> onRoleSelect = data.OnRoleSelect;
				if (onRoleSelect != null)
				{
					onRoleSelect(0);
				}
			}
			this.CloseTypeDetailPanel();
			SimpleGenericLayout typeIconLayout2 = this.TypeIconLayout;
			if (typeIconLayout2 != null)
			{
				typeIconLayout2.RebuildLayout(0);
			}
			RoleTrialLabelItem trialLabelItem = this.TrialLabelItem;
			if (trialLabelItem != null)
			{
				trialLabelItem.SetUiActive(false);
			}
			TeamRoleSelectSkillBranchItem modeToggleItem = this.ModeToggleItem;
			if (modeToggleItem == null)
			{
				return;
			}
			modeToggleItem.SetUiActive(false);
		}
	}

	// Token: 0x060121DE RID: 74206 RVA: 0x005566AC File Offset: 0x005548AC
	private void RefreshConfirmText(int roleId)
	{
		TeamRoleSelectViewData data = this.Data;
		string text;
		if (data == null)
		{
			text = null;
		}
		else
		{
			Func<int, string> getConfirmButtonTextCallBack = data.GetConfirmButtonTextCallBack;
			text = ((getConfirmButtonTextCallBack != null) ? getConfirmButtonTextCallBack(roleId) : null);
		}
		string text2 = text;
		if (text2 != null && !string.IsNullOrEmpty(text2))
		{
			string textContentIdById = TextConfig.Instance.GetTextContentIdById(text2);
			if (textContentIdById != null)
			{
				base.GetText(19).ShowTextNew(textContentIdById);
			}
		}
	}

	// Token: 0x060121DF RID: 74207 RVA: 0x00556704 File Offset: 0x00554904
	private void RefreshConfirmButtonEnable(int roleId)
	{
		TeamRoleSelectViewData data = this.Data;
		if (((data != null) ? data.GetConfirmButtonEnableCallBack : null) == null)
		{
			return;
		}
		bool selfInteractive = this.Data.GetConfirmButtonEnableCallBack(roleId);
		base.GetButton(5).SetSelfInteractive(selfInteractive);
	}

	// Token: 0x060121E0 RID: 74208 RVA: 0x00556748 File Offset: 0x00554948
	private void RefreshElement(int elementId)
	{
		UUIItem item = base.GetItem(13);
		if (item == null)
		{
			return;
		}
		if (this.MiniElementItem == null)
		{
			this.MiniElementItem = new MiniElementItem(elementId, item, item.GetOwner());
		}
		this.MiniElementItem.RefreshMiniElement(elementId);
	}

	// Token: 0x060121E1 RID: 74209 RVA: 0x0055678C File Offset: 0x0055498C
	private void RefreshTypeIcon()
	{
		if (this.CurSelectRole == null || this.TypeIconLayout == null)
		{
			return;
		}
		int[] roleTagByRoleInfo = RoleModel.Instance.GetRoleTagByRoleInfo(this.CurSelectRole.GetRoleConfig());
		this.TypeIconLayout.RebuildLayout(roleTagByRoleInfo.Length);
		GenericScrollViewNew<RolePropertyDetailItem, int> typeDetailScrollView = this.TypeDetailScrollView;
		if (typeDetailScrollView != null)
		{
			typeDetailScrollView.RefreshByData(roleTagByRoleInfo, null, false);
		}
		List<UUIItem> itemList = this.TypeIconLayout.GetItemList();
		for (int i = 0; i < roleTagByRoleInfo.Length; i++)
		{
			TeamSceneRoleSelectView.<>c__DisplayClass44_0 CS$<>8__locals1 = new TeamSceneRoleSelectView.<>c__DisplayClass44_0();
			UUIItem uuiitem = (itemList != null) ? itemList[i] : null;
			TeamSceneRoleSelectView.<>c__DisplayClass44_0 CS$<>8__locals2 = CS$<>8__locals1;
			object obj;
			if (uuiitem == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = uuiitem.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUISprite.StaticClass()) : null);
			}
			CS$<>8__locals2.sprite = (obj as UUISprite);
			RoleTag? roleTagConfig = RoleConfig.Instance.GetRoleTagConfig(roleTagByRoleInfo[i]);
			if (uuiitem == null || CS$<>8__locals1.sprite == null || roleTagConfig == null)
			{
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(false);
				}
			}
			else
			{
				CS$<>8__locals1.sprite.SetUIActive(false);
				this.SetSpriteByPath(roleTagConfig.Value.TagIcon, CS$<>8__locals1.sprite, false, null, delegate(bool success)
				{
					if (success)
					{
						AActor owner2 = CS$<>8__locals1.sprite.GetOwner();
						UUIExtendToggleSpriteTransition uuiextendToggleSpriteTransition = ((owner2 != null) ? owner2.GetComponentByClass(UUIExtendToggleSpriteTransition.StaticClass()) : null) as UUIExtendToggleSpriteTransition;
						if (uuiextendToggleSpriteTransition != null)
						{
							uuiextendToggleSpriteTransition.SetAllStateSprite(CS$<>8__locals1.sprite.GetSprite());
						}
					}
					CS$<>8__locals1.sprite.SetUIActive(success);
				});
			}
		}
	}

	// Token: 0x060121E2 RID: 74210 RVA: 0x005568B7 File Offset: 0x00554AB7
	private RolePropertyDetailItem InitTypeDetailItem()
	{
		return new RolePropertyDetailItem();
	}

	// Token: 0x060121E3 RID: 74211 RVA: 0x005568C0 File Offset: 0x00554AC0
	private void RefreshModeToggle(int roleId)
	{
		if (this.ModeToggleItem == null)
		{
			return;
		}
		int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(roleId);
		bool flag = roleSkillBranchIndexInCurrentGamePlay > -1;
		this.ModeToggleItem.SetUiActive(flag);
		if (!flag)
		{
			return;
		}
		this.ModeToggleItem.SetActiveBranchIndex(roleSkillBranchIndexInCurrentGamePlay);
		this.ModeToggleItem.SetToggleInteractive(true);
		this.ModeToggleItem.RefreshIcon((int index) => FormationConfig.Instance.GetSkillBranchIcon(roleId, index));
	}

	// Token: 0x060121E4 RID: 74212 RVA: 0x00556938 File Offset: 0x00554B38
	private void SwitchSkillBranchHandler(int skillBranch)
	{
		RoleDataBase curSelectRole = this.CurSelectRole;
		int? num = (curSelectRole != null) ? new int?(curSelectRole.GetDataId()) : null;
		if (num == null)
		{
			return;
		}
		int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(num.Value, skillBranch);
		if (RoleModel.Instance.IsInGamePlayRoleEdit)
		{
			RoleController.Instance.ModifyRoleSkillBranchInCurrentGamePlay(num.Value, roleBranchIdByIndex, true);
			return;
		}
		RoleController.Instance.RequestRoleSkillBranchModify(num.Value, roleBranchIdByIndex);
	}

	// Token: 0x060121E5 RID: 74213 RVA: 0x005569B4 File Offset: 0x00554BB4
	private void OnRoleSkillBranchChanged(int roleId)
	{
		List<RoleDataBase> roleList = this.RoleList;
		int num = (roleList != null) ? roleList.FindIndex((RoleDataBase role) => role.GetDataId() == roleId) : -1;
		if (num < 0)
		{
			return;
		}
		LoopScrollView<TeamRoleGridBase, RoleDataBase> roleScrollView = this.RoleScrollView;
		if (roleScrollView != null)
		{
			roleScrollView.RefreshGridProxy(num);
		}
		RoleDataBase curSelectRole = this.CurSelectRole;
		if (curSelectRole != null && curSelectRole.GetDataId() == roleId)
		{
			this.RefreshModeToggle(roleId);
		}
	}

	// Token: 0x060121E6 RID: 74214 RVA: 0x00556A2C File Offset: 0x00554C2C
	private void RefreshTrialLabel(int roleId)
	{
		if (this.TrialLabelItem == null)
		{
			return;
		}
		if (!RoleUtils.IsTrialRole(roleId) || RoleUtils.GetTrialRoleType(roleId) == ETrialRoleType.None)
		{
			this.TrialLabelItem.SetUiActive(false);
			return;
		}
		this.TrialLabelItem.SetUiActive(true);
		this.TrialLabelItem.Refresh(roleId);
	}

	// Token: 0x060121E7 RID: 74215 RVA: 0x00556A6C File Offset: 0x00554C6C
	private void UpdateRoleList(List<RoleDataBase> list, bool isOutSideChange, EFilterSortType type)
	{
		this.RoleList = list;
		bool flag = this.RoleList.Count > 0;
		base.GetLoopScrollViewComponent(1).RootUIComp.Get().SetUIActive(flag);
		if (!flag)
		{
			this.SetRoleInfoActive(false);
			return;
		}
		RoleDataBase curSelectRole = this.CurSelectRole;
		int? num = (curSelectRole != null) ? new int?(curSelectRole.GetDataId()) : null;
		if (num != null)
		{
			RoleSelectModel.Instance.SelectedRoleSet.Remove(num.Value);
		}
		this.RoleScrollView.DeselectCurrentGridProxy(false);
		this.RoleScrollView.RefreshByData(this.RoleList, false, null, false);
		if (this.CurSelectRole == null)
		{
			this.SetRoleInfoActive(false);
			return;
		}
		if (type == EFilterSortType.Sort && !isOutSideChange)
		{
			this.CurSelectRole = this.RoleList[0];
			this.SelectCurrentRole(true);
			return;
		}
		if (!this.RoleList.Exists(delegate(RoleDataBase role)
		{
			int dataId = role.GetDataId();
			RoleDataBase curSelectRole2 = this.CurSelectRole;
			int? num2 = (curSelectRole2 != null) ? new int?(curSelectRole2.GetDataId()) : null;
			return dataId == num2.GetValueOrDefault() & num2 != null;
		}))
		{
			this.CurSelectRole = this.RoleList[0];
		}
		this.SelectCurrentRole(true);
	}

	// Token: 0x060121E8 RID: 74216 RVA: 0x00556B78 File Offset: 0x00554D78
	private UniTask RequestRobotRoleProp()
	{
		TeamSceneRoleSelectView.<RequestRobotRoleProp>d__51 <RequestRobotRoleProp>d__;
		<RequestRobotRoleProp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRobotRoleProp>d__.<>4__this = this;
		<RequestRobotRoleProp>d__.<>1__state = -1;
		<RequestRobotRoleProp>d__.<>t__builder.Start<TeamSceneRoleSelectView.<RequestRobotRoleProp>d__51>(ref <RequestRobotRoleProp>d__);
		return <RequestRobotRoleProp>d__.<>t__builder.Task;
	}

	// Token: 0x060121E9 RID: 74217 RVA: 0x00556BBC File Offset: 0x00554DBC
	private void InitRoleIndexMap()
	{
		RoleSelectModel.Instance.ClearData();
		TeamRoleSelectViewData data = this.Data;
		int[] array = (data != null) ? data.FormationRoleList : null;
		if (array == null || this.RoleList == null)
		{
			return;
		}
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		int num = Math.Min(3, array.Length);
		for (int i = 1; i <= num; i++)
		{
			int targetRoleId = array[i - 1];
			RoleDataBase roleDataBase = this.RoleList.Find((RoleDataBase r) => r.GetDataId() == targetRoleId);
			if (roleDataBase != null)
			{
				roleIndexMap[i] = roleDataBase;
			}
		}
	}

	// Token: 0x060121EA RID: 74218 RVA: 0x00556C50 File Offset: 0x00554E50
	private unsafe void OnClickDetail()
	{
		if (this.CurSelectRole == null)
		{
			return;
		}
		int dataId = this.CurSelectRole.GetDataId();
		TeamRoleSelectViewData data = this.Data;
		if (((data != null) ? data.DetailCallback : null) != null)
		{
			this.Data.DetailCallback(dataId);
			return;
		}
		List<int> list;
		if (dataId < 100000)
		{
			list = new List<int>();
		}
		else
		{
			int num = 1;
			List<int> list2 = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list2, num);
			list = list2;
			Span<int> span = CollectionsMarshal.AsSpan<int>(list2);
			int index = 0;
			*span[index] = dataId;
		}
		List<int> roleIdList = list;
		this.PendingDetailOpenNotify = true;
		RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, dataId, roleIdList, null, delegate(bool success, int _)
		{
			if (!success)
			{
				this.PendingDetailOpenNotify = false;
			}
		});
		EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnDetailViewClose));
		RoleModel.Instance.StartRecordRoleSkillBranchChangeRequest();
	}

	// Token: 0x060121EB RID: 74219 RVA: 0x00556D38 File Offset: 0x00554F38
	private void OnClickConfirm()
	{
		RoleDataBase curSelectRole = this.CurSelectRole;
		int? num = (curSelectRole != null) ? new int?(curSelectRole.GetDataId()) : null;
		if (num == null)
		{
			return;
		}
		TeamRoleSelectViewData data = this.Data;
		Func<int, bool> func = (data != null) ? data.CanConfirmFunc : null;
		if (func != null && !func(num.Value))
		{
			return;
		}
		TeamRoleSelectViewData data2 = this.Data;
		if (data2 != null)
		{
			Action<int> confirmCallBack = data2.ConfirmCallBack;
			if (confirmCallBack != null)
			{
				confirmCallBack(num.Value);
			}
		}
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x060121EC RID: 74220 RVA: 0x00556DCE File Offset: 0x00554FCE
	private void OnTypeToggleStateChanged(EToggleState state)
	{
		UUIItem item = base.GetItem(9);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(state == EToggleState.ETT_Checked);
	}

	// Token: 0x060121ED RID: 74221 RVA: 0x00556DE6 File Offset: 0x00554FE6
	private void OnClickCloseType()
	{
		this.CloseTypeDetailPanel();
	}

	// Token: 0x060121EE RID: 74222 RVA: 0x00556DEE File Offset: 0x00554FEE
	private void OnRoleChangeEnd()
	{
		this.IsNeedRefreshTeamList = true;
	}

	// Token: 0x060121EF RID: 74223 RVA: 0x00556DF8 File Offset: 0x00554FF8
	private void OnDetailViewClose(EUiViewName viewName, int _)
	{
		if (viewName == EUiViewName.RoleRootView)
		{
			EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnDetailViewClose));
			this.PendingDetailCloseNotify = true;
			foreach (int roleId in RoleModel.Instance.StopRecordRoleSkillBranchChangeRequest())
			{
				this.OnRoleSkillBranchChanged(roleId);
			}
		}
	}

	// Token: 0x060121F0 RID: 74224 RVA: 0x00556E98 File Offset: 0x00555098
	private void RefreshRoleListAfterChangeRole()
	{
		if (this.RoleList != null)
		{
			TeamRoleSelectViewData data = this.Data;
			if (((data != null) ? data.RoleList : null) != null)
			{
				RoleSelectModel instance = RoleSelectModel.Instance;
				bool flag = false;
				foreach (RoleDataBase roleDataBase in new List<RoleDataBase>(this.RoleList))
				{
					bool flag2 = this.CurSelectRole == roleDataBase;
					RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleDataBase.GetDataId(), true);
					if (roleDataById != null && roleDataById != roleDataBase)
					{
						flag = true;
						int num = this.Data.RoleList.IndexOf(roleDataBase);
						if (num > -1)
						{
							this.Data.RoleList[num] = roleDataById;
						}
						int roleIndex = instance.GetRoleIndex(roleDataBase.GetDataId());
						if (roleIndex > 0)
						{
							instance.RoleIndexMap[roleIndex] = roleDataById;
						}
						if (flag2)
						{
							this.CurSelectRole = roleDataById;
						}
					}
				}
				if (flag)
				{
					this.RoleList = this.Data.RoleList;
					this.RoleList.Sort((RoleDataBase a, RoleDataBase b) => b.GetRoleConfig().Priority - a.GetRoleConfig().Priority);
					if (this.Data.UseWay != null)
					{
						FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
						if (filterSortEntrance == null)
						{
							return;
						}
						filterSortEntrance.UpdateData(this.Data.UseWay.Value, this.RoleList, Array.Empty<object>());
					}
				}
				return;
			}
		}
	}

	// Token: 0x04009E07 RID: 40455
	[Nullable(2)]
	private TeamRoleSelectViewData Data;

	// Token: 0x04009E08 RID: 40456
	private PopupCaptionItem CaptionItem;

	// Token: 0x04009E09 RID: 40457
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x04009E0A RID: 40458
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<TeamRoleGridBase, RoleDataBase> RoleScrollView;

	// Token: 0x04009E0B RID: 40459
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<RoleDataBase> RoleList;

	// Token: 0x04009E0C RID: 40460
	[Nullable(2)]
	private MiniElementItem MiniElementItem;

	// Token: 0x04009E0D RID: 40461
	[Nullable(2)]
	private RoleTrialLabelItem TrialLabelItem;

	// Token: 0x04009E0E RID: 40462
	[Nullable(2)]
	private TeamRoleSelectSkillBranchItem ModeToggleItem;

	// Token: 0x04009E0F RID: 40463
	[Nullable(2)]
	private SimpleGenericLayout TypeIconLayout;

	// Token: 0x04009E10 RID: 40464
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<RolePropertyDetailItem, int> TypeDetailScrollView;

	// Token: 0x04009E11 RID: 40465
	[Nullable(2)]
	protected RoleDataBase CurSelectRole;

	// Token: 0x04009E12 RID: 40466
	private bool IsNeedRefreshTeamList;

	// Token: 0x04009E13 RID: 40467
	private bool HasAfterShow;

	// Token: 0x04009E14 RID: 40468
	private bool PendingDetailOpenNotify;

	// Token: 0x04009E15 RID: 40469
	private bool PendingDetailCloseNotify;

	// Token: 0x02007F89 RID: 32649
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029458 RID: 169048
		CaptionItem,
		// Token: 0x04029459 RID: 169049
		ScrollRole,
		// Token: 0x0402945A RID: 169050
		RoleItem,
		// Token: 0x0402945B RID: 169051
		FilterSortEntrance,
		// Token: 0x0402945C RID: 169052
		BtnDetail,
		// Token: 0x0402945D RID: 169053
		BtnConfirm,
		// Token: 0x0402945E RID: 169054
		ToggleType,
		// Token: 0x0402945F RID: 169055
		ScrollType,
		// Token: 0x04029460 RID: 169056
		TypeItemIcon,
		// Token: 0x04029461 RID: 169057
		PanelTypeDetail,
		// Token: 0x04029462 RID: 169058
		ScrollTypeDetail,
		// Token: 0x04029463 RID: 169059
		TypeDetailItem,
		// Token: 0x04029464 RID: 169060
		TrailItem,
		// Token: 0x04029465 RID: 169061
		PanelElement,
		// Token: 0x04029466 RID: 169062
		LevelArtTxt,
		// Token: 0x04029467 RID: 169063
		NameTxt,
		// Token: 0x04029468 RID: 169064
		ModeToggle,
		// Token: 0x04029469 RID: 169065
		PanelEmpty,
		// Token: 0x0402946A RID: 169066
		PanelRole,
		// Token: 0x0402946B RID: 169067
		ConfirmTxt,
		// Token: 0x0402946C RID: 169068
		BtnCloseType
	}
}
