using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02002798 RID: 10136
[NullableContext(1)]
[Nullable(0)]
public class TeamSceneRoleSelectView : UiViewBase
{
	// Token: 0x06014CDA RID: 85210 RVA: 0x0054682C File Offset: 0x00544A2C
	public TeamSceneRoleSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014CDB RID: 85211 RVA: 0x00546838 File Offset: 0x00544A38
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

	// Token: 0x06014CDC RID: 85212 RVA: 0x00546BC8 File Offset: 0x00544DC8
	protected override UniTask OnBeforeStartAsync()
	{
		TeamSceneRoleSelectView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TeamSceneRoleSelectView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014CDD RID: 85213 RVA: 0x00546C0C File Offset: 0x00544E0C
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

	// Token: 0x06014CDE RID: 85214 RVA: 0x00546D68 File Offset: 0x00544F68
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

	// Token: 0x06014CDF RID: 85215 RVA: 0x00546DEB File Offset: 0x00544FEB
	protected override void OnAfterShow()
	{
		this.HasAfterShow = true;
		this.NotifyCurrentRoleSelect();
	}

	// Token: 0x06014CE0 RID: 85216 RVA: 0x00546DFC File Offset: 0x00544FFC
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

	// Token: 0x06014CE1 RID: 85217 RVA: 0x00546E56 File Offset: 0x00545056
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

	// Token: 0x06014CE2 RID: 85218 RVA: 0x00546E84 File Offset: 0x00545084
	private void NotifyCurrentRoleSelect()
	{
		RoleDataBase curSelectRole = this.CurSelectRole;
		int? num = (curSelectRole != null) ? new int?(curSelectRole.GetDataId()) : null;
		if (num != null)
		{
			this.NotifyRoleSelect(num.Value);
		}
	}

	// Token: 0x06014CE3 RID: 85219 RVA: 0x00546EC7 File Offset: 0x005450C7
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

	// Token: 0x06014CE4 RID: 85220 RVA: 0x00546EF5 File Offset: 0x005450F5
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x06014CE5 RID: 85221 RVA: 0x00546F2F File Offset: 0x0054512F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x06014CE6 RID: 85222 RVA: 0x00546F6C File Offset: 0x0054516C
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

	// Token: 0x06014CE7 RID: 85223 RVA: 0x00547040 File Offset: 0x00545240
	private UniTask InitCaption()
	{
		TeamSceneRoleSelectView.<InitCaption>d__29 <InitCaption>d__;
		<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaption>d__.<>4__this = this;
		<InitCaption>d__.<>1__state = -1;
		<InitCaption>d__.<>t__builder.Start<TeamSceneRoleSelectView.<InitCaption>d__29>(ref <InitCaption>d__);
		return <InitCaption>d__.<>t__builder.Task;
	}

	// Token: 0x06014CE8 RID: 85224 RVA: 0x00547083 File Offset: 0x00545283
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

	// Token: 0x06014CE9 RID: 85225 RVA: 0x005470B8 File Offset: 0x005452B8
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

	// Token: 0x06014CEA RID: 85226 RVA: 0x00547138 File Offset: 0x00545338
	protected bool IsHighlightIndex(int position)
	{
		TeamRoleSelectViewData data = this.Data;
		int? num = (data != null) ? data.Position : null;
		return position == num.GetValueOrDefault() & num != null;
	}

	// Token: 0x06014CEB RID: 85227 RVA: 0x00547172 File Offset: 0x00545372
	protected bool IsShowGray(int roleId)
	{
		TeamRoleSelectViewData data = this.Data;
		return data == null || !data.CanUseSpecialTrialRole || !RoleUtils.IsSpecialTrialRole(roleId);
	}

	// Token: 0x06014CEC RID: 85228 RVA: 0x00547198 File Offset: 0x00545398
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
			if (!(((data3 != null) ? data3.FormationRoleList : null) ?? Array.Empty<int>()).Contains(dataId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PrefabTextItem_1024721374_Text", Array.Empty<object>());
				return false;
			}
		}
		return state != EToggleState.ETT_Checked || this.CurSelectRole != roleDataBase;
	}

	// Token: 0x06014CED RID: 85229 RVA: 0x00547224 File Offset: 0x00545424
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
		onRoleSelect(this.CurSelectRole.GetDataId());
	}

	// Token: 0x06014CEE RID: 85230 RVA: 0x005472C0 File Offset: 0x005454C0
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
		this.RefreshRoleInfo();
		if (shouldNotifyRoleSelect)
		{
			this.NotifyRoleSelect(dataId);
		}
	}

	// Token: 0x06014CEF RID: 85231 RVA: 0x00547340 File Offset: 0x00545540
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

	// Token: 0x06014CF0 RID: 85232 RVA: 0x0054737C File Offset: 0x0054557C
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

	// Token: 0x06014CF1 RID: 85233 RVA: 0x00547438 File Offset: 0x00545638
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

	// Token: 0x06014CF2 RID: 85234 RVA: 0x005474E8 File Offset: 0x005456E8
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

	// Token: 0x06014CF3 RID: 85235 RVA: 0x005475CC File Offset: 0x005457CC
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

	// Token: 0x06014CF4 RID: 85236 RVA: 0x00547624 File Offset: 0x00545824
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

	// Token: 0x06014CF5 RID: 85237 RVA: 0x00547668 File Offset: 0x00545868
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
			TeamSceneRoleSelectView.<>c__DisplayClass43_0 CS$<>8__locals1 = new TeamSceneRoleSelectView.<>c__DisplayClass43_0();
			UUIItem uuiitem = (itemList != null) ? itemList[i] : null;
			TeamSceneRoleSelectView.<>c__DisplayClass43_0 CS$<>8__locals2 = CS$<>8__locals1;
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

	// Token: 0x06014CF6 RID: 85238 RVA: 0x00547793 File Offset: 0x00545993
	private RolePropertyDetailItem InitTypeDetailItem()
	{
		return new RolePropertyDetailItem();
	}

	// Token: 0x06014CF7 RID: 85239 RVA: 0x0054779C File Offset: 0x0054599C
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

	// Token: 0x06014CF8 RID: 85240 RVA: 0x00547814 File Offset: 0x00545A14
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

	// Token: 0x06014CF9 RID: 85241 RVA: 0x00547890 File Offset: 0x00545A90
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

	// Token: 0x06014CFA RID: 85242 RVA: 0x00547908 File Offset: 0x00545B08
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

	// Token: 0x06014CFB RID: 85243 RVA: 0x00547948 File Offset: 0x00545B48
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

	// Token: 0x06014CFC RID: 85244 RVA: 0x00547A54 File Offset: 0x00545C54
	private UniTask RequestRobotRoleProp()
	{
		TeamSceneRoleSelectView.<RequestRobotRoleProp>d__50 <RequestRobotRoleProp>d__;
		<RequestRobotRoleProp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRobotRoleProp>d__.<>4__this = this;
		<RequestRobotRoleProp>d__.<>1__state = -1;
		<RequestRobotRoleProp>d__.<>t__builder.Start<TeamSceneRoleSelectView.<RequestRobotRoleProp>d__50>(ref <RequestRobotRoleProp>d__);
		return <RequestRobotRoleProp>d__.<>t__builder.Task;
	}

	// Token: 0x06014CFD RID: 85245 RVA: 0x00547A98 File Offset: 0x00545C98
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

	// Token: 0x06014CFE RID: 85246 RVA: 0x00547B2C File Offset: 0x00545D2C
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

	// Token: 0x06014CFF RID: 85247 RVA: 0x00547C14 File Offset: 0x00545E14
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

	// Token: 0x06014D00 RID: 85248 RVA: 0x00547CAA File Offset: 0x00545EAA
	private void OnTypeToggleStateChanged(EToggleState state)
	{
		UUIItem item = base.GetItem(9);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(state == EToggleState.ETT_Checked);
	}

	// Token: 0x06014D01 RID: 85249 RVA: 0x00547CC2 File Offset: 0x00545EC2
	private void OnClickCloseType()
	{
		this.CloseTypeDetailPanel();
	}

	// Token: 0x06014D02 RID: 85250 RVA: 0x00547CCA File Offset: 0x00545ECA
	private void OnRoleChangeEnd()
	{
		this.IsNeedRefreshTeamList = true;
	}

	// Token: 0x06014D03 RID: 85251 RVA: 0x00547CD4 File Offset: 0x00545ED4
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

	// Token: 0x06014D04 RID: 85252 RVA: 0x00547D74 File Offset: 0x00545F74
	private void RefreshRoleListAfterChangeRole()
	{
		if (this.RoleList != null)
		{
			TeamRoleSelectViewData data = this.Data;
			if (((data != null) ? data.RoleList : null) != null)
			{
				RoleSelectModel instance = RoleSelectModel.Instance;
				bool flag = false;
				foreach (RoleDataBase roleDataBase in this.RoleList.ToList<RoleDataBase>())
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

	// Token: 0x04009CA3 RID: 40099
	[Nullable(2)]
	private TeamRoleSelectViewData Data;

	// Token: 0x04009CA4 RID: 40100
	private PopupCaptionItem CaptionItem;

	// Token: 0x04009CA5 RID: 40101
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x04009CA6 RID: 40102
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<TeamRoleGridBase, RoleDataBase> RoleScrollView;

	// Token: 0x04009CA7 RID: 40103
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<RoleDataBase> RoleList;

	// Token: 0x04009CA8 RID: 40104
	[Nullable(2)]
	private MiniElementItem MiniElementItem;

	// Token: 0x04009CA9 RID: 40105
	[Nullable(2)]
	private RoleTrialLabelItem TrialLabelItem;

	// Token: 0x04009CAA RID: 40106
	[Nullable(2)]
	private TeamRoleSelectSkillBranchItem ModeToggleItem;

	// Token: 0x04009CAB RID: 40107
	[Nullable(2)]
	private SimpleGenericLayout TypeIconLayout;

	// Token: 0x04009CAC RID: 40108
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<RolePropertyDetailItem, int> TypeDetailScrollView;

	// Token: 0x04009CAD RID: 40109
	[Nullable(2)]
	protected RoleDataBase CurSelectRole;

	// Token: 0x04009CAE RID: 40110
	private bool IsNeedRefreshTeamList;

	// Token: 0x04009CAF RID: 40111
	private bool HasAfterShow;

	// Token: 0x04009CB0 RID: 40112
	private bool PendingDetailOpenNotify;

	// Token: 0x04009CB1 RID: 40113
	private bool PendingDetailCloseNotify;

	// Token: 0x02008E02 RID: 36354
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402E145 RID: 188741
		CaptionItem,
		// Token: 0x0402E146 RID: 188742
		ScrollRole,
		// Token: 0x0402E147 RID: 188743
		RoleItem,
		// Token: 0x0402E148 RID: 188744
		FilterSortEntrance,
		// Token: 0x0402E149 RID: 188745
		BtnDetail,
		// Token: 0x0402E14A RID: 188746
		BtnConfirm,
		// Token: 0x0402E14B RID: 188747
		ToggleType,
		// Token: 0x0402E14C RID: 188748
		ScrollType,
		// Token: 0x0402E14D RID: 188749
		TypeItemIcon,
		// Token: 0x0402E14E RID: 188750
		PanelTypeDetail,
		// Token: 0x0402E14F RID: 188751
		ScrollTypeDetail,
		// Token: 0x0402E150 RID: 188752
		TypeDetailItem,
		// Token: 0x0402E151 RID: 188753
		TrailItem,
		// Token: 0x0402E152 RID: 188754
		PanelElement,
		// Token: 0x0402E153 RID: 188755
		LevelArtTxt,
		// Token: 0x0402E154 RID: 188756
		NameTxt,
		// Token: 0x0402E155 RID: 188757
		ModeToggle,
		// Token: 0x0402E156 RID: 188758
		PanelEmpty,
		// Token: 0x0402E157 RID: 188759
		PanelRole,
		// Token: 0x0402E158 RID: 188760
		ConfirmTxt,
		// Token: 0x0402E159 RID: 188761
		BtnCloseType
	}
}
