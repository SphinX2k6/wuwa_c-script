using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020020E1 RID: 8417
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueRoleInfoGrid : UiPanelBase
{
	// Token: 0x06014A90 RID: 84624 RVA: 0x006050E0 File Offset: 0x006032E0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBtnRoleClick))
		};
	}

	// Token: 0x06014A91 RID: 84625 RVA: 0x00605174 File Offset: 0x00603374
	private void OnBtnRoleClick()
	{
		SurvivorsTabMainViewData param = new SurvivorsTabMainViewData
		{
			SkipTabType = new ETabType?(ETabType.Role)
		};
		UiManager.Instance.OpenView(EUiViewName.SurvivorsTabMainView, param, null);
	}

	// Token: 0x06014A92 RID: 84626 RVA: 0x006051A4 File Offset: 0x006033A4
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SetSelectOn(false);
	}

	// Token: 0x06014A93 RID: 84627 RVA: 0x006051C0 File Offset: 0x006033C0
	public void Refresh(int roleId, int lv)
	{
		SurvivorsRole? survivorsRole = SurvivorsRogueConfig.Instance.GetSurvivorsRole(roleId);
		if (survivorsRole == null)
		{
			return;
		}
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(survivorsRole.Value.TrialRoleId, true);
		RoleInfo? roleInfo = (roleDataById != null) ? new RoleInfo?(roleDataById.GetRoleConfig()) : null;
		if (roleInfo == null)
		{
			return;
		}
		base.SetRoleIcon(roleInfo.Value.RoleHeadIconCircle, base.GetTexture(1), roleId, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "SurvivorsCombat_Lv", new <>z__ReadOnlySingleElementList<object>(lv));
		base.GetText(3).SetUIActive(true);
	}

	// Token: 0x06014A94 RID: 84628 RVA: 0x00605278 File Offset: 0x00603478
	public void SetSelectOn(bool bUp)
	{
		base.GetItem(2).SetUIActive(bUp);
		if (bUp)
		{
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("PreArm", false, null);
			return;
		}
		this.LevelSequencePlayer.StopSequenceByKey("PreArm", false, true);
	}

	// Token: 0x06014A95 RID: 84629 RVA: 0x006052C4 File Offset: 0x006034C4
	public void SetLevelUp()
	{
		this.LevelSequencePlayer.StopSequenceByKey("PreArm", false, true);
		this.LevelSequencePlayer.PlayOrReplaySequenceByName("LevelUp", false, null);
	}

	// Token: 0x0400B01E RID: 45086
	private const string SURVIVORS_LV_KEY = "SurvivorsCombat_Lv";

	// Token: 0x0400B01F RID: 45087
	private const string SEQ_PRE_SELECT = "PreArm";

	// Token: 0x0400B020 RID: 45088
	private const string SEQ_LEVEL_UP = "LevelUp";

	// Token: 0x0400B021 RID: 45089
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;
}
