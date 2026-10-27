using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020015EB RID: 5611
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerRoleInfoPanel : UiPanelBase
{
	// Token: 0x06009E6A RID: 40554 RVA: 0x00228F38 File Offset: 0x00227138
	protected unsafe override void OnRegisterComponent()
	{
		int num = 22;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIMultiTemplateLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(17, new Action(delegate()
		{
			Action onClickConfirm = this.OnClickConfirm;
			if (onClickConfirm == null)
			{
				return;
			}
			onClickConfirm();
		}));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(18, new Action(this.OnDetailClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009E6B RID: 40555 RVA: 0x002292A8 File Offset: 0x002274A8
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerRoleInfoPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerRoleInfoPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009E6C RID: 40556 RVA: 0x002292EB File Offset: 0x002274EB
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(16);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06009E6D RID: 40557 RVA: 0x00229300 File Offset: 0x00227500
	public void Refresh(int roleId)
	{
		if (roleId == 0)
		{
			return;
		}
		this.RoleId = roleId;
		WheelTowerModel.Instance.TmpSelectRoleId = roleId;
		int id = WheelTowerModel.Instance.TryGetRealRoleId(roleId);
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(id);
		if (roleConfig == null)
		{
			return;
		}
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.ShowTextNew(roleConfig.Value.Name);
		}
		this.RefreshTag(roleConfig.Value);
		this.RefreshSkill(roleConfig.Value);
		this.RefreshTemplate(roleId);
		this.RefreshConflict(roleId);
		this.RefreshLeftBtn();
		this.RefreshSkillBranch();
	}

	// Token: 0x06009E6E RID: 40558 RVA: 0x0022939C File Offset: 0x0022759C
	public void RefreshLeftBtn()
	{
		UUIButtonComponent button = base.GetButton(18);
		if (button == null)
		{
			return;
		}
		UUIItem uuiitem = button.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(WheelTowerModel.Instance.TmpSelectedRoleMap.Count != 0);
	}

	// Token: 0x06009E6F RID: 40559 RVA: 0x002293DF File Offset: 0x002275DF
	[NullableContext(1)]
	private RoleSkillItem CreateRoleSkillItem()
	{
		RoleSkillItem roleSkillItem = new RoleSkillItem();
		roleSkillItem.SetToggleCallback(new Action<int>(this.OnSkillItemClick));
		return roleSkillItem;
	}

	// Token: 0x06009E70 RID: 40560 RVA: 0x002293F8 File Offset: 0x002275F8
	private void OnSkillItemClick(int skillId)
	{
		GenericLayout<RoleSkillItem, int> skillLayout = this.SkillLayout;
		if (skillLayout != null)
		{
			skillLayout.SelectGridProxyByKey(skillId, false);
		}
		Aki.Config.Skill? skillConfigById = RoleSkillConfig.Instance.GetSkillConfigById(skillId);
		if (skillConfigById == null)
		{
			return;
		}
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.ShowTextNew(skillConfigById.Value.SkillName);
		}
		UUIText text2 = base.GetText(6);
		if (text2 != null)
		{
			text2.SetText(RoleSkillConfig.Instance.GetSkillTypeNameLocalText(skillConfigById.Value.SkillType) ?? string.Empty, true);
		}
		int num = WheelTowerModel.Instance.TryGetRealRoleId(this.RoleId);
		bool flag = WheelTowerModel.Instance.IsEnhanceSkill(num, skillId);
		UUIText text3 = base.GetText(12);
		if (text3 != null)
		{
			text3.SetUIActive(flag);
		}
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(8);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		if (flag)
		{
			string item3 = ConfigMultiTextLang.GetLocalTextNew(RoleConfig.Instance.GetRoleConfig(num).Value.Name, null) ?? string.Empty;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "WheelBattleRoleInfo_StrTips", new <>z__ReadOnlySingleElementList<object>(item3));
			ValueTuple<string, string[]>? roleSkillEnhanceDescAndParam = WheelTowerModel.Instance.GetRoleSkillEnhanceDescAndParam(num, skillConfigById.Value.SkillType);
			if (roleSkillEnhanceDescAndParam != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(10), roleSkillEnhanceDescAndParam.Value.Item1, roleSkillEnhanceDescAndParam.Value.Item2);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), skillConfigById.Value.SkillDescribe, skillConfigById.Value.SkillDetailNum());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), skillConfigById.Value.SkillDescribe, skillConfigById.Value.SkillDetailNum());
	}

	// Token: 0x06009E71 RID: 40561 RVA: 0x002295E4 File Offset: 0x002277E4
	private void RefreshTemplate(int roleId)
	{
		bool flag = WheelTowerModel.Instance.IsTemplateRole(roleId);
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (flag)
		{
			UUIText text = base.GetText(14);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(WheelTowerModel.Instance.GetTemplateRoleDesc(roleId));
		}
	}

	// Token: 0x06009E72 RID: 40562 RVA: 0x00229634 File Offset: 0x00227834
	private void RefreshConflict(int roleId)
	{
		if (WheelTowerModel.Instance.IsTemplateRole(roleId) || WheelTowerModel.Instance.SelectedEnergyInfo.GetRoleEnergy(roleId) <= 0)
		{
			WarningTips warningTipsPanel = this.WarningTipsPanel;
			if (warningTipsPanel == null)
			{
				return;
			}
			warningTipsPanel.SetUiActive(false);
			return;
		}
		else
		{
			IConflictInfo conflictInfo = WheelTowerModel.Instance.CheckConflict(roleId);
			WarningTips warningTipsPanel2 = this.WarningTipsPanel;
			if (warningTipsPanel2 != null)
			{
				warningTipsPanel2.SetUiActive(conflictInfo != null);
			}
			if (conflictInfo == null)
			{
				return;
			}
			if (conflictInfo.WeaponConflict && conflictInfo.PhantomConflict)
			{
				WarningTips warningTipsPanel3 = this.WarningTipsPanel;
				if (warningTipsPanel3 == null)
				{
					return;
				}
				warningTipsPanel3.SetTextById("WheelBattleRoleInfo_WeaponAndPhantomConflict");
				return;
			}
			else
			{
				if (!conflictInfo.WeaponConflict)
				{
					if (conflictInfo.PhantomConflict)
					{
						WarningTips warningTipsPanel4 = this.WarningTipsPanel;
						if (warningTipsPanel4 == null)
						{
							return;
						}
						warningTipsPanel4.SetTextById("WheelBattleRoleInfo_PhantomConflict");
					}
					return;
				}
				WarningTips warningTipsPanel5 = this.WarningTipsPanel;
				if (warningTipsPanel5 == null)
				{
					return;
				}
				warningTipsPanel5.SetTextById("WheelBattleRoleInfo_WeaponConflict");
				return;
			}
		}
	}

	// Token: 0x06009E73 RID: 40563 RVA: 0x002296FC File Offset: 0x002278FC
	private void RefreshTag(RoleInfo roleInfo)
	{
		int[] roleTagByRoleInfo = RoleModel.Instance.GetRoleTagByRoleInfo(roleInfo);
		GenericLayout<RoleTagMediumIconItem, int> tagLayout = this.TagLayout;
		if (tagLayout != null)
		{
			tagLayout.RefreshByData(((roleTagByRoleInfo != null) ? roleTagByRoleInfo.ToList<int>() : null) ?? new List<int>(), null, false);
		}
		GenericLayout<RoleTagMediumIconItem, int> tagLayout2 = this.TagLayout;
		if (tagLayout2 == null)
		{
			return;
		}
		UUIItem rootUiItem = tagLayout2.GetRootUiItem();
		if (rootUiItem == null)
		{
			return;
		}
		rootUiItem.SetUIActive(roleTagByRoleInfo != null && roleTagByRoleInfo.Length != 0);
	}

	// Token: 0x06009E74 RID: 40564 RVA: 0x00229764 File Offset: 0x00227964
	private void RefreshSkill(RoleInfo roleInfo)
	{
		IReadOnlyList<Aki.Config.Skill> skillList2 = RoleSkillConfig.Instance.GetSkillList(roleInfo.SkillId);
		if (skillList2 == null)
		{
			return;
		}
		List<Aki.Config.Skill> list = skillList2.ToList<Aki.Config.Skill>();
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleInfo.Id, true);
		RoleSkillData roleSkillData = (roleDataById != null) ? roleDataById.GetSkillData() : null;
		if (roleSkillData != null && roleSkillData.HasAnySkillUpgrade())
		{
			for (int i = 0; i < list.Count; i++)
			{
				int skillIdAfterUpgrade = roleSkillData.GetSkillIdAfterUpgrade(list[i].Id);
				if (skillIdAfterUpgrade > 0)
				{
					Aki.Config.Skill? skillConfigById = RoleSkillConfig.Instance.GetSkillConfigById(skillIdAfterUpgrade);
					if (skillConfigById != null)
					{
						list[i] = skillConfigById.Value;
					}
				}
			}
		}
		List<int> skillList = new List<int>();
		IEnumerable<int> enumerable = ConfigCommonParamById.GetIntArrayConfig("DisplaySkillTypes") ?? Array.Empty<int>();
		int enhancedSkillIndex = -1;
		foreach (int num in enumerable)
		{
			foreach (Aki.Config.Skill skill in list)
			{
				if (skill.SkillType == num)
				{
					skillList.Add(skill.Id);
					if (enhancedSkillIndex == -1 && WheelTowerModel.Instance.IsEnhanceSkill(roleInfo.Id, skill.Id))
					{
						enhancedSkillIndex = skillList.Count - 1;
						break;
					}
					break;
				}
			}
		}
		GenericLayout<RoleSkillItem, int> skillLayout = this.SkillLayout;
		if (skillLayout == null)
		{
			return;
		}
		skillLayout.RefreshByData(skillList, delegate
		{
			if (skillList.Count == 0)
			{
				return;
			}
			int index = (enhancedSkillIndex == -1) ? 0 : enhancedSkillIndex;
			RoleSkillItem layoutItemByIndex = this.SkillLayout.GetLayoutItemByIndex(index);
			if (layoutItemByIndex != null)
			{
				layoutItemByIndex.SetSelectedState(true, true);
			}
			this.OnSkillItemClick(skillList[index]);
		}, false);
	}

	// Token: 0x06009E75 RID: 40565 RVA: 0x00229934 File Offset: 0x00227B34
	private void OnDetailClick()
	{
		Dictionary<int, int>.ValueCollection values = WheelTowerModel.Instance.TmpSelectedRoleMap.Values;
		if (values.Count <= 0)
		{
			return;
		}
		List<int> list = values.ToList<int>();
		RoleController instance = RoleController.Instance;
		OpenRoleMainViewData openRoleMainViewData = new OpenRoleMainViewData();
		openRoleMainViewData.AgentType = ERoleAgentType.Normal;
		List<int> list2 = list;
		openRoleMainViewData.SelectRoleId = new int?(list2[list2.Count - 1]);
		openRoleMainViewData.RoleIdList = list;
		openRoleMainViewData.Source = new ERoleViewSource?(ERoleViewSource.WheelTower);
		instance.OpenRoleMainViewByParam(openRoleMainViewData);
	}

	// Token: 0x06009E76 RID: 40566 RVA: 0x002299A4 File Offset: 0x00227BA4
	private void RefreshSkillBranch()
	{
		bool flag = RoleModel.Instance.IsRoleHasBranch(this.RoleId);
		TeamRoleSelectSkillBranchItem skillBranchSwitchItem = this.SkillBranchSwitchItem;
		if (skillBranchSwitchItem != null)
		{
			skillBranchSwitchItem.SetUiActive(flag);
		}
		UUIItem item = base.GetItem(20);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (!flag)
		{
			return;
		}
		TeamRoleSelectSkillBranchItem skillBranchSwitchItem2 = this.SkillBranchSwitchItem;
		if (skillBranchSwitchItem2 != null)
		{
			skillBranchSwitchItem2.SetActiveBranchIndex(RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(this.RoleId));
		}
		TeamRoleSelectSkillBranchItem skillBranchSwitchItem3 = this.SkillBranchSwitchItem;
		if (skillBranchSwitchItem3 == null)
		{
			return;
		}
		skillBranchSwitchItem3.RefreshIcon(delegate(int index)
		{
			int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(this.RoleId, index);
			SkillBranch? skillBranchConfigById = RoleConfig.Instance.GetSkillBranchConfigById(roleBranchIdByIndex);
			return ((skillBranchConfigById != null) ? skillBranchConfigById.GetValueOrDefault().Icon : null) ?? string.Empty;
		});
	}

	// Token: 0x06009E77 RID: 40567 RVA: 0x00229A2C File Offset: 0x00227C2C
	private void SwitchSkillBranchHandler(int skillBranch)
	{
		int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(this.RoleId, skillBranch);
		if (RoleModel.Instance.IsInGamePlayRoleEdit)
		{
			RoleController.Instance.ModifyRoleSkillBranchInCurrentGamePlay(this.RoleId, roleBranchIdByIndex, true);
			return;
		}
		RoleController.Instance.RequestRoleSkillBranchModify(this.RoleId, roleBranchIdByIndex);
	}

	// Token: 0x040046C8 RID: 18120
	public Action OnClickConfirm;

	// Token: 0x040046C9 RID: 18121
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTagMediumIconItem, int> TagLayout;

	// Token: 0x040046CA RID: 18122
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleSkillItem, int> SkillLayout;

	// Token: 0x040046CB RID: 18123
	private WarningTips WarningTipsPanel;

	// Token: 0x040046CC RID: 18124
	private TeamRoleSelectSkillBranchItem SkillBranchSwitchItem;

	// Token: 0x040046CD RID: 18125
	private int RoleId;
}
