using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000B0C RID: 2828
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerTeamSelectView : UiViewBase
{
	// Token: 0x06007450 RID: 29776 RVA: 0x0023F66E File Offset: 0x0023D86E
	[NullableContext(1)]
	public WheelTowerTeamSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007451 RID: 29777 RVA: 0x0023F678 File Offset: 0x0023D878
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007452 RID: 29778 RVA: 0x0023F744 File Offset: 0x0023D944
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerTeamSelectView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerTeamSelectView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007453 RID: 29779 RVA: 0x0023F788 File Offset: 0x0023D988
	protected override void OnStart()
	{
		PopupCaptionItem caption = this.Caption;
		if (caption != null)
		{
			caption.SetCloseCallBack(new Action(this.CloseSelf));
		}
		PopupCaptionItem caption2 = this.Caption;
		if (caption2 != null)
		{
			caption2.SetTitleIcon(UiResourceConfig.Instance.GetResourcePath("WheelTower_ActivityIcon"));
		}
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06007454 RID: 29780 RVA: 0x0023F7E4 File Offset: 0x0023D9E4
	protected override void OnBeforeShow()
	{
		WheelTowerTeamSelectMainPanel selectPanel = this.SelectPanel;
		if (selectPanel != null)
		{
			selectPanel.RefreshPanel();
		}
		this.RefreshInfoPanel(WheelTowerModel.Instance.TmpSelectRoleId, true);
	}

	// Token: 0x06007455 RID: 29781 RVA: 0x0023F808 File Offset: 0x0023DA08
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.Clear();
	}

	// Token: 0x06007456 RID: 29782 RVA: 0x0023F81C File Offset: 0x0023DA1C
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (!(configParams[0] == "RoleTab"))
		{
			return null;
		}
		int index = int.Parse(configParams[1]);
		WheelTowerTeamSelectMainPanel selectPanel = this.SelectPanel;
		UUIItem uuiitem = (selectPanel != null) ? selectPanel.GetTabItem(index) : null;
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

	// Token: 0x06007457 RID: 29783 RVA: 0x0023F86C File Offset: 0x0023DA6C
	private void OnRoleSelect(int roleId)
	{
		bool force = WheelTowerModel.Instance.SelectedRoleList.Count == 0;
		int realRoleId = WheelTowerModel.Instance.GetRealRoleId(roleId);
		if (realRoleId != 0 && WheelTowerModel.Instance.IsSelectRole(realRoleId))
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.WheelTowerTemplateReplaceConfirm);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				WheelTowerModel.Instance.TryAddOrDeleteRole(realRoleId);
				WheelTowerModel.Instance.TryAddOrDeleteRole(roleId);
				WheelTowerTeamSelectMainPanel selectPanel = this.SelectPanel;
				if (selectPanel == null)
				{
					return;
				}
				selectPanel.RefreshPanel();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			this.RefreshInfoPanel(roleId, force);
			return;
		}
		int templateRoleId = WheelTowerModel.Instance.GetTemplateRoleId(roleId);
		if (templateRoleId != 0 && WheelTowerModel.Instance.IsSelectRole(templateRoleId))
		{
			WheelTowerModel.Instance.TryAddOrDeleteRole(templateRoleId);
		}
		WheelTowerModel.Instance.TryAddOrDeleteRole(roleId);
		this.RefreshInfoPanel(roleId, force);
	}

	// Token: 0x06007458 RID: 29784 RVA: 0x0023F958 File Offset: 0x0023DB58
	private void OnTeamSelect(int teamId)
	{
		int teamMaxRoleCount = WheelTowerModel.Instance.GetTeamMaxRoleCount();
		List<int> list = new List<int>(teamMaxRoleCount);
		for (int i = 0; i < teamMaxRoleCount; i++)
		{
			list.Add(0);
		}
		FormationData formationData = FormationModel.Instance.GetFormationData(teamId);
		int num = 0;
		foreach (KeyValuePair<int, FormationRoleData> keyValuePair in (((formationData != null) ? formationData.GetRoleDataMapWithTrial(false) : null) ?? new Dictionary<int, FormationRoleData>()))
		{
			list[num] = keyValuePair.Value.ConfigId;
			num++;
		}
		foreach (int roleId in WheelTowerModel.Instance.TmpSelectedRoleMap.Values)
		{
			int roleCurrentBranchId = RoleModel.Instance.GetRoleCurrentBranchId(roleId);
			if (roleCurrentBranchId > 0)
			{
				RoleModel.Instance.SetRoleSkillBranchGamePlayCache(roleId, roleCurrentBranchId, ESkillBranchCacheType.WheelTower);
			}
		}
		List<int> list2 = new List<int>();
		foreach (int num2 in list)
		{
			if (num2 > 0)
			{
				list2.Add(num2);
			}
		}
		WheelTowerModel.Instance.SetTmpSelectRoleList(list2);
		WheelTowerStrShowPanel strPanel = this.StrPanel;
		if (strPanel == null)
		{
			return;
		}
		strPanel.Refresh();
	}

	// Token: 0x06007459 RID: 29785 RVA: 0x0023FAD4 File Offset: 0x0023DCD4
	private void OnSelectModeChange(ESelectMode selectMode, int roleId)
	{
		this.RefreshInfoPanel(roleId, true);
		WheelTowerStrShowPanel strPanel = this.StrPanel;
		if (strPanel != null)
		{
			strPanel.Refresh();
		}
		WheelTowerStrShowPanel strPanel2 = this.StrPanel;
		if (strPanel2 != null)
		{
			strPanel2.SetUiActive(selectMode == ESelectMode.Team);
		}
		WheelTowerRoleInfoPanel infoPanel = this.InfoPanel;
		if (infoPanel == null)
		{
			return;
		}
		infoPanel.SetUiActive(selectMode != ESelectMode.Team);
	}

	// Token: 0x0600745A RID: 29786 RVA: 0x0023FB28 File Offset: 0x0023DD28
	private void RefreshInfoPanel(int roleId, bool force = false)
	{
		WheelTowerRoleInfoPanel infoPanel = this.InfoPanel;
		if (infoPanel != null)
		{
			infoPanel.RefreshLeftBtn();
		}
		if ((roleId == WheelTowerModel.Instance.TmpSelectRoleId || roleId <= 0) && !force)
		{
			return;
		}
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.PlayOrReplaySequenceByName("Switch", false, null);
		}
		WheelTowerRoleInfoPanel infoPanel2 = this.InfoPanel;
		if (infoPanel2 == null)
		{
			return;
		}
		infoPanel2.Refresh(roleId);
	}

	// Token: 0x0600745B RID: 29787 RVA: 0x0023FB91 File Offset: 0x0023DD91
	private void OnClickConfirm()
	{
		WheelTowerModel.Instance.TmpToSelect();
		base.CloseMe(null);
	}

	// Token: 0x040049DD RID: 18909
	private PopupCaptionItem Caption;

	// Token: 0x040049DE RID: 18910
	private WheelTowerTeamSelectMainPanel SelectPanel;

	// Token: 0x040049DF RID: 18911
	private WheelTowerRoleInfoPanel InfoPanel;

	// Token: 0x040049E0 RID: 18912
	private WheelTowerStrShowPanel StrPanel;

	// Token: 0x040049E1 RID: 18913
	private LevelSequencePlayer SeqPlayer;
}
