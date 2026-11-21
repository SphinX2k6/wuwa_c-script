using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E69 RID: 7785
[NullableContext(1)]
[Nullable(0)]
public class RoleViewAgent
{
	// Token: 0x0601341F RID: 78879 RVA: 0x005A08D1 File Offset: 0x0059EAD1
	public void Init(List<int> roleIdList, int selectRoleId, EUiTabViewName? selectTabName, ERoleViewSource source = ERoleViewSource.Normal, bool useMainViewSort = false)
	{
		this.RoleIdList = roleIdList;
		this.CurSelectRoleId = selectRoleId;
		this.CurSelectTabName = selectTabName;
		this.Source = source;
		this.UseMainViewSort = useMainViewSort;
	}

	// Token: 0x06013420 RID: 78880 RVA: 0x005A08F8 File Offset: 0x0059EAF8
	public IReadOnlyList<int> GetRoleIdList([Nullable(2)] Comparison<int> customCompare = null)
	{
		if (this.RoleIdList.Count <= 0)
		{
			return RoleModel.Instance.GetRoleSystemRoleList(true, customCompare);
		}
		return this.RoleIdList;
	}

	// Token: 0x06013421 RID: 78881 RVA: 0x005A091C File Offset: 0x0059EB1C
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

	// Token: 0x06013422 RID: 78882 RVA: 0x005A099C File Offset: 0x0059EB9C
	public int GetCurSelectRoleId()
	{
		bool flag = this.GetRoleIdList(null).IndexOf(this.CurSelectRoleId) >= 0;
		if (this.CurSelectRoleId <= 0 || !flag)
		{
			this.CurSelectRoleId = this.GetDefaultSelectRoleId();
		}
		return this.CurSelectRoleId;
	}

	// Token: 0x06013423 RID: 78883 RVA: 0x005A09E0 File Offset: 0x0059EBE0
	public int GetDefaultSelectRoleId()
	{
		if (this.RoleIdList.Count > 0)
		{
			return this.RoleIdList[0];
		}
		int? battleTeamFirstRoleId = RoleModel.Instance.GetBattleTeamFirstRoleId();
		List<int> roleSystemRoleList = RoleModel.Instance.GetRoleSystemRoleList(true, null);
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

	// Token: 0x06013424 RID: 78884 RVA: 0x005A0A6F File Offset: 0x0059EC6F
	public void SetCurSelectRoleId(int roleId)
	{
		this.CurSelectRoleId = roleId;
	}

	// Token: 0x06013425 RID: 78885 RVA: 0x005A0A78 File Offset: 0x0059EC78
	[NullableContext(2)]
	public RoleDataBase GetCurSelectRoleData()
	{
		int curSelectRoleId = this.GetCurSelectRoleId();
		return RoleModel.Instance.GetRoleDataById(curSelectRoleId, true);
	}

	// Token: 0x17001D68 RID: 7528
	// (get) Token: 0x06013426 RID: 78886 RVA: 0x005A0A98 File Offset: 0x0059EC98
	// (set) Token: 0x06013427 RID: 78887 RVA: 0x005A0AA0 File Offset: 0x0059ECA0
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

	// Token: 0x06013428 RID: 78888 RVA: 0x005A0AAC File Offset: 0x0059ECAC
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

	// Token: 0x06013429 RID: 78889 RVA: 0x005A0ADC File Offset: 0x0059ECDC
	public IRoleSystemUiParams GetRoleSystemUiParams()
	{
		ERoleSystemMode roleSystemMode = this.GetRoleSystemMode();
		return RoleUiDefine.roleSystemModeUiParam[roleSystemMode];
	}

	// Token: 0x0601342A RID: 78890 RVA: 0x005A0AFB File Offset: 0x0059ECFB
	public void SetCurSelectTabName(EUiTabViewName tabName)
	{
		this.CurSelectTabName = new EUiTabViewName?(tabName);
	}

	// Token: 0x0601342B RID: 78891 RVA: 0x005A0B09 File Offset: 0x0059ED09
	public EUiTabViewName? GetCurSelectTabName()
	{
		return this.CurSelectTabName;
	}

	// Token: 0x0601342C RID: 78892 RVA: 0x005A0B11 File Offset: 0x0059ED11
	public void SetPreSelectTabName(EUiTabViewName? tabName)
	{
		this.PreSelectTabName = tabName;
	}

	// Token: 0x0601342D RID: 78893 RVA: 0x005A0B1A File Offset: 0x0059ED1A
	public EUiTabViewName? GetPreSelectTabName()
	{
		return this.PreSelectTabName;
	}

	// Token: 0x0601342E RID: 78894 RVA: 0x005A0B24 File Offset: 0x0059ED24
	public List<UiDynamicTab> GetRoleTabDataList()
	{
		ERoleSystemMode roleSystemMode = this.GetRoleSystemMode();
		return new List<UiDynamicTab>(RoleModel.Instance.GetRoleTabListByUiParam(roleSystemMode, this.GetCurSelectRoleId()));
	}

	// Token: 0x0601342F RID: 78895 RVA: 0x005A0B50 File Offset: 0x0059ED50
	public int GetCurRoleResonanceGroupIndex()
	{
		RoleDataBase curSelectRoleData = this.GetCurSelectRoleData();
		return RoleModel.Instance.GetRoleResonanceGroupIndex(curSelectRoleData);
	}

	// Token: 0x06013430 RID: 78896 RVA: 0x005A0B70 File Offset: 0x0059ED70
	[NullableContext(2)]
	public List<ResonantChain> GetCurRoleResonanceConfigList()
	{
		RoleDataBase curSelectRoleData = this.GetCurSelectRoleData();
		return RoleModel.Instance.GetRoleResonanceConfigList(curSelectRoleData);
	}

	// Token: 0x0400A4C9 RID: 42185
	protected List<int> RoleIdList;

	// Token: 0x0400A4CA RID: 42186
	protected EUiTabViewName? CurSelectTabName;

	// Token: 0x0400A4CB RID: 42187
	protected int CurSelectRoleId;

	// Token: 0x0400A4CC RID: 42188
	protected ERoleViewState RoleViewStateInternal;

	// Token: 0x0400A4CD RID: 42189
	public ETeamPositionType? TeamPositionType;

	// Token: 0x0400A4CE RID: 42190
	protected EUiTabViewName? PreSelectTabName;

	// Token: 0x0400A4CF RID: 42191
	public ERoleViewSource Source;

	// Token: 0x0400A4D0 RID: 42192
	public bool UseMainViewSort;
}
