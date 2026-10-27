using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028EE RID: 10478
[NullableContext(1)]
[Nullable(0)]
public class RoleViewAgent
{
	// Token: 0x06015A1B RID: 88603 RVA: 0x00575A05 File Offset: 0x00573C05
	public void Init(List<int> roleIdList, int selectRoleId, EUiTabViewName? selectTabName, ERoleViewSource source = ERoleViewSource.Normal)
	{
		this.RoleIdList = roleIdList;
		this.CurSelectRoleId = selectRoleId;
		this.CurSelectTabName = selectTabName;
		this.Source = source;
	}

	// Token: 0x06015A1C RID: 88604 RVA: 0x00575A24 File Offset: 0x00573C24
	public IReadOnlyList<int> GetRoleIdList()
	{
		if (this.RoleIdList.Count <= 0)
		{
			return RoleModel.Instance.GetRoleSystemRoleList(true);
		}
		return this.RoleIdList;
	}

	// Token: 0x06015A1D RID: 88605 RVA: 0x00575A48 File Offset: 0x00573C48
	public void CheckMainRoleToIdList(int mainRoleId)
	{
		if (this.RoleIdList.Count == 0)
		{
			return;
		}
		if (this.RoleIdList.IndexOf(mainRoleId) >= 0)
		{
			return;
		}
		if (!RoleModel.Instance.IsMainRole(mainRoleId))
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < this.RoleIdList.Count; i++)
		{
			if (RoleModel.Instance.IsMainRole(this.RoleIdList[i]))
			{
				num = i;
				break;
			}
		}
		if (num != -1)
		{
			this.RoleIdList[num] = mainRoleId;
		}
	}

	// Token: 0x06015A1E RID: 88606 RVA: 0x00575AC8 File Offset: 0x00573CC8
	public int GetCurSelectRoleId()
	{
		bool flag = this.GetRoleIdList().IndexOf(this.CurSelectRoleId) >= 0;
		if (this.CurSelectRoleId <= 0 || !flag)
		{
			this.CurSelectRoleId = this.GetDefaultSelectRoleId();
		}
		return this.CurSelectRoleId;
	}

	// Token: 0x06015A1F RID: 88607 RVA: 0x00575B0C File Offset: 0x00573D0C
	public int GetDefaultSelectRoleId()
	{
		if (this.RoleIdList.Count > 0)
		{
			return this.RoleIdList[0];
		}
		int? battleTeamFirstRoleId = RoleModel.Instance.GetBattleTeamFirstRoleId();
		List<int> roleSystemRoleList = RoleModel.Instance.GetRoleSystemRoleList(true);
		if (battleTeamFirstRoleId != null && roleSystemRoleList.IndexOf(battleTeamFirstRoleId.Value) >= 0)
		{
			return battleTeamFirstRoleId.Value;
		}
		if (roleSystemRoleList.Count <= 0)
		{
			Log.Instance.Error(ELogModule.Role, ELogAuthor.BB, "取不到角色数据！", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0;
		}
		return roleSystemRoleList[0];
	}

	// Token: 0x06015A20 RID: 88608 RVA: 0x00575B9A File Offset: 0x00573D9A
	public void SetCurSelectRoleId(int roleId)
	{
		this.CurSelectRoleId = roleId;
	}

	// Token: 0x06015A21 RID: 88609 RVA: 0x00575BA4 File Offset: 0x00573DA4
	[NullableContext(2)]
	public RoleDataBase GetCurSelectRoleData()
	{
		int curSelectRoleId = this.GetCurSelectRoleId();
		return RoleModel.Instance.GetRoleDataById(curSelectRoleId, true);
	}

	// Token: 0x17001D0E RID: 7438
	// (get) Token: 0x06015A22 RID: 88610 RVA: 0x00575BC4 File Offset: 0x00573DC4
	// (set) Token: 0x06015A23 RID: 88611 RVA: 0x00575BCC File Offset: 0x00573DCC
	public ERoleViewState RoleViewState
	{
		get
		{
			return this.RoleViewStateInternal;
		}
		set
		{
			this.RoleViewStateInternal = value;
		}
	}

	// Token: 0x06015A24 RID: 88612 RVA: 0x00575BD8 File Offset: 0x00573DD8
	public virtual ERoleSystemMode GetRoleSystemMode()
	{
		RoleDataBase curSelectRoleData = this.GetCurSelectRoleData();
		if (!curSelectRoleData.IsTrialRole())
		{
			return ERoleSystemMode.Normal;
		}
		if (!RoleUtils.IsSpecialTrialRole(curSelectRoleData.GetDataId()))
		{
			return ERoleSystemMode.Trial;
		}
		return ERoleSystemMode.SpecialTrial;
	}

	// Token: 0x06015A25 RID: 88613 RVA: 0x00575C08 File Offset: 0x00573E08
	public IRoleSystemUiParams GetRoleSystemUiParams()
	{
		ERoleSystemMode roleSystemMode = this.GetRoleSystemMode();
		return RoleUiDefine.roleSystemModeUiParam[roleSystemMode];
	}

	// Token: 0x06015A26 RID: 88614 RVA: 0x00575C27 File Offset: 0x00573E27
	public void SetCurSelectTabName(EUiTabViewName tabName)
	{
		this.CurSelectTabName = new EUiTabViewName?(tabName);
	}

	// Token: 0x06015A27 RID: 88615 RVA: 0x00575C35 File Offset: 0x00573E35
	public EUiTabViewName? GetCurSelectTabName()
	{
		return this.CurSelectTabName;
	}

	// Token: 0x06015A28 RID: 88616 RVA: 0x00575C3D File Offset: 0x00573E3D
	public void SetPreSelectTabName(EUiTabViewName? tabName)
	{
		this.PreSelectTabName = tabName;
	}

	// Token: 0x06015A29 RID: 88617 RVA: 0x00575C46 File Offset: 0x00573E46
	public EUiTabViewName? GetPreSelectTabName()
	{
		return this.PreSelectTabName;
	}

	// Token: 0x06015A2A RID: 88618 RVA: 0x00575C50 File Offset: 0x00573E50
	public List<UiDynamicTab> GetRoleTabDataList()
	{
		ERoleSystemMode roleSystemMode = this.GetRoleSystemMode();
		return new List<UiDynamicTab>(RoleModel.Instance.GetRoleTabListByUiParam(roleSystemMode, this.GetCurSelectRoleId()));
	}

	// Token: 0x06015A2B RID: 88619 RVA: 0x00575C7C File Offset: 0x00573E7C
	public int GetCurRoleResonanceGroupIndex()
	{
		RoleDataBase curSelectRoleData = this.GetCurSelectRoleData();
		return RoleModel.Instance.GetRoleResonanceGroupIndex(curSelectRoleData);
	}

	// Token: 0x06015A2C RID: 88620 RVA: 0x00575C9C File Offset: 0x00573E9C
	[NullableContext(2)]
	public List<ResonantChain> GetCurRoleResonanceConfigList()
	{
		RoleDataBase curSelectRoleData = this.GetCurSelectRoleData();
		return RoleModel.Instance.GetRoleResonanceConfigList(curSelectRoleData);
	}

	// Token: 0x0400A0DF RID: 41183
	protected List<int> RoleIdList;

	// Token: 0x0400A0E0 RID: 41184
	protected EUiTabViewName? CurSelectTabName;

	// Token: 0x0400A0E1 RID: 41185
	protected int CurSelectRoleId;

	// Token: 0x0400A0E2 RID: 41186
	protected ERoleViewState RoleViewStateInternal;

	// Token: 0x0400A0E3 RID: 41187
	public ETeamPositionType? TeamPositionType;

	// Token: 0x0400A0E4 RID: 41188
	protected EUiTabViewName? PreSelectTabName;

	// Token: 0x0400A0E5 RID: 41189
	public ERoleViewSource Source;
}
