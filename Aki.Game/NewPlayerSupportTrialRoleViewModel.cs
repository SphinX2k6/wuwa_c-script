using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020013C9 RID: 5065
[NullableContext(1)]
[Nullable(0)]
public class NewPlayerSupportTrialRoleViewModel
{
	// Token: 0x17000BFD RID: 3069
	// (get) Token: 0x06008EF5 RID: 36597 RVA: 0x001EDF55 File Offset: 0x001EC155
	public ETrialRoleType TrialRoleType
	{
		get
		{
			return this.TrialRoleTypeIntl;
		}
	}

	// Token: 0x17000BFE RID: 3070
	// (get) Token: 0x06008EF6 RID: 36598 RVA: 0x001EDF5D File Offset: 0x001EC15D
	public string CaptionIcon
	{
		get
		{
			return this.CaptionIconIntl;
		}
	}

	// Token: 0x17000BFF RID: 3071
	// (get) Token: 0x06008EF7 RID: 36599 RVA: 0x001EDF65 File Offset: 0x001EC165
	public string CaptionText
	{
		get
		{
			return this.CaptionTextIntl;
		}
	}

	// Token: 0x17000C00 RID: 3072
	// (get) Token: 0x06008EF8 RID: 36600 RVA: 0x001EDF6D File Offset: 0x001EC16D
	public int? SelectedGroupId
	{
		get
		{
			return this.SelectedGroupIdIntl;
		}
	}

	// Token: 0x17000C01 RID: 3073
	// (get) Token: 0x06008EF9 RID: 36601 RVA: 0x001EDF75 File Offset: 0x001EC175
	public int HelpId
	{
		get
		{
			return this.HelpIdIntl;
		}
	}

	// Token: 0x06008EFA RID: 36602 RVA: 0x001EDF80 File Offset: 0x001EC180
	public NewPlayerSupportTrialRoleViewModel(ETrialRoleType trialRoleType, string captionIcon, string captionText, int helpId, int? selectedGroupId = null)
	{
		this.TrialRoleTypeIntl = trialRoleType;
		this.CaptionIconIntl = captionIcon;
		this.CaptionTextIntl = captionText;
		this.HelpIdIntl = helpId;
		this.SelectedGroupIdIntl = selectedGroupId;
	}

	// Token: 0x06008EFB RID: 36603 RVA: 0x001EDFDC File Offset: 0x001EC1DC
	public int? GetCurUseTrialRoleId()
	{
		TrialRoleGroupData curUseTrialRole = TrialRoleModel.Instance.GetCurUseTrialRole(this.TrialRoleType);
		if (curUseTrialRole == null)
		{
			return null;
		}
		return new int?(curUseTrialRole.TrialRoleId);
	}

	// Token: 0x06008EFC RID: 36604 RVA: 0x001EE011 File Offset: 0x001EC211
	[NullableContext(2)]
	public TrialRoleGroupData CurUseTrialRoleGroupData()
	{
		return TrialRoleModel.Instance.GetCurUseTrialRole(this.TrialRoleType);
	}

	// Token: 0x06008EFD RID: 36605 RVA: 0x001EE023 File Offset: 0x001EC223
	[NullableContext(2)]
	public TrialRoleGroupData GetTrialRoleByGroupId(int groupId)
	{
		return TrialRoleModel.Instance.GetDataByGroupId(groupId);
	}

	// Token: 0x06008EFE RID: 36606 RVA: 0x001EE030 File Offset: 0x001EC230
	public List<TrialRoleGroupData> GetTrialRoleList()
	{
		return TrialRoleModel.Instance.GetDataListByType(this.TrialRoleType);
	}

	// Token: 0x06008EFF RID: 36607 RVA: 0x001EE042 File Offset: 0x001EC242
	public void SetRequestTrialRoleLvUpFunc(Action<int> func)
	{
		this.RequestTrialRoleLvUpFunc = func;
	}

	// Token: 0x06008F00 RID: 36608 RVA: 0x001EE04B File Offset: 0x001EC24B
	[NullableContext(2)]
	public Action<int> GetRequestTrialRoleLvUpFunc()
	{
		return this.RequestTrialRoleLvUpFunc;
	}

	// Token: 0x06008F01 RID: 36609 RVA: 0x001EE053 File Offset: 0x001EC253
	public void SetRequestSetCurUseTrialRoleFunc(Action<int, Action<int>> func)
	{
		this.RequestSetCurUseTrialRoleFunc = func;
	}

	// Token: 0x06008F02 RID: 36610 RVA: 0x001EE05C File Offset: 0x001EC25C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, Action<int>> GetRequestSetCurUseTrialRoleFunc()
	{
		return this.RequestSetCurUseTrialRoleFunc;
	}

	// Token: 0x06008F03 RID: 36611 RVA: 0x001EE064 File Offset: 0x001EC264
	public void SetTrialRoleGroupUnlockDesc(Dictionary<int, string> descMap)
	{
		this.TrialGroupUnlockDescMap = descMap;
	}

	// Token: 0x06008F04 RID: 36612 RVA: 0x001EE070 File Offset: 0x001EC270
	[NullableContext(2)]
	public string GetTrialRoleGroupUnlockDesc(int groupId)
	{
		string result;
		if (!this.TrialGroupUnlockDescMap.TryGetValue(groupId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x04003F35 RID: 16181
	private ETrialRoleType TrialRoleTypeIntl;

	// Token: 0x04003F36 RID: 16182
	private string CaptionIconIntl = "";

	// Token: 0x04003F37 RID: 16183
	private string CaptionTextIntl = "";

	// Token: 0x04003F38 RID: 16184
	private int? SelectedGroupIdIntl;

	// Token: 0x04003F39 RID: 16185
	private int HelpIdIntl;

	// Token: 0x04003F3A RID: 16186
	private Dictionary<int, string> TrialGroupUnlockDescMap = new Dictionary<int, string>();

	// Token: 0x04003F3B RID: 16187
	[Nullable(2)]
	private Action<int> RequestTrialRoleLvUpFunc;

	// Token: 0x04003F3C RID: 16188
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, Action<int>> RequestSetCurUseTrialRoleFunc;
}
