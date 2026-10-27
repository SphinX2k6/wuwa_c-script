using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002B65 RID: 11109
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueRoleInfoGrid : UiPanelBase
{
	// Token: 0x0601705F RID: 94303 RVA: 0x005D8578 File Offset: 0x005D6778
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

	// Token: 0x06017060 RID: 94304 RVA: 0x005D860C File Offset: 0x005D680C
	private void OnBtnRoleClick()
	{
		SurvivorsTabMainViewData param = new SurvivorsTabMainViewData
		{
			SkipTabType = new ETabType?(ETabType.Role)
		};
		UiManager.Instance.OpenView(EUiViewName.SurvivorsTabMainView, param, null);
	}

	// Token: 0x06017061 RID: 94305 RVA: 0x005D863C File Offset: 0x005D683C
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SetSelectOn(false);
	}

	// Token: 0x06017062 RID: 94306 RVA: 0x005D8658 File Offset: 0x005D6858
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

	// Token: 0x06017063 RID: 94307 RVA: 0x005D8710 File Offset: 0x005D6910
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

	// Token: 0x06017064 RID: 94308 RVA: 0x005D875C File Offset: 0x005D695C
	public void SetLevelUp()
	{
		this.LevelSequencePlayer.StopSequenceByKey("PreArm", false, true);
		this.LevelSequencePlayer.PlayOrReplaySequenceByName("LevelUp", false, null);
	}

	// Token: 0x0400AC18 RID: 44056
	private const string SURVIVORS_LV_KEY = "SurvivorsCombat_Lv";

	// Token: 0x0400AC19 RID: 44057
	private const string SEQ_PRE_SELECT = "PreArm";

	// Token: 0x0400AC1A RID: 44058
	private const string SEQ_LEVEL_UP = "LevelUp";

	// Token: 0x0400AC1B RID: 44059
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;
}
