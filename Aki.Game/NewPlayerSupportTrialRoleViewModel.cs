using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200087D RID: 2173
[NullableContext(1)]
[Nullable(0)]
public class NewPlayerSupportTrialRoleViewModel
{
	// Token: 0x17000C1D RID: 3101
	// (get) Token: 0x0600628A RID: 25226 RVA: 0x001F6A75 File Offset: 0x001F4C75
	public ETrialRoleType TrialRoleType
	{
		get
		{
			return this.TrialRoleTypeIntl;
		}
	}

	// Token: 0x17000C1E RID: 3102
	// (get) Token: 0x0600628B RID: 25227 RVA: 0x001F6A7D File Offset: 0x001F4C7D
	public string CaptionIcon
	{
		get
		{
			return this.CaptionIconIntl;
		}
	}

	// Token: 0x17000C1F RID: 3103
	// (get) Token: 0x0600628C RID: 25228 RVA: 0x001F6A85 File Offset: 0x001F4C85
	public string CaptionText
	{
		get
		{
			return this.CaptionTextIntl;
		}
	}

	// Token: 0x17000C20 RID: 3104
	// (get) Token: 0x0600628D RID: 25229 RVA: 0x001F6A8D File Offset: 0x001F4C8D
	public int? SelectedGroupId
	{
		get
		{
			return this.SelectedGroupIdIntl;
		}
	}

	// Token: 0x17000C21 RID: 3105
	// (get) Token: 0x0600628E RID: 25230 RVA: 0x001F6A95 File Offset: 0x001F4C95
	public int HelpId
	{
		get
		{
			return this.HelpIdIntl;
		}
	}

	// Token: 0x0600628F RID: 25231 RVA: 0x001F6AA0 File Offset: 0x001F4CA0
	public NewPlayerSupportTrialRoleViewModel(ETrialRoleType trialRoleType, string captionIcon, string captionText, int helpId, int? selectedGroupId = null)
	{
		this.TrialRoleTypeIntl = trialRoleType;
		this.CaptionIconIntl = captionIcon;
		this.CaptionTextIntl = captionText;
		this.HelpIdIntl = helpId;
		this.SelectedGroupIdIntl = selectedGroupId;
	}

	// Token: 0x06006290 RID: 25232 RVA: 0x001F6AFC File Offset: 0x001F4CFC
	public int? GetCurUseTrialRoleId()
	{
		TrialRoleGroupData curUseTrialRole = TrialRoleModel.Instance.GetCurUseTrialRole(this.TrialRoleType);
		if (curUseTrialRole == null)
		{
			return null;
		}
		return new int?(curUseTrialRole.TrialRoleId);
	}

	// Token: 0x06006291 RID: 25233 RVA: 0x001F6B31 File Offset: 0x001F4D31
	[NullableContext(2)]
	public TrialRoleGroupData CurUseTrialRoleGroupData()
	{
		return TrialRoleModel.Instance.GetCurUseTrialRole(this.TrialRoleType);
	}

	// Token: 0x06006292 RID: 25234 RVA: 0x001F6B43 File Offset: 0x001F4D43
	[NullableContext(2)]
	public TrialRoleGroupData GetTrialRoleByGroupId(int groupId)
	{
		return TrialRoleModel.Instance.GetDataByGroupId(groupId);
	}

	// Token: 0x06006293 RID: 25235 RVA: 0x001F6B50 File Offset: 0x001F4D50
	public List<TrialRoleGroupData> GetTrialRoleList()
	{
		return TrialRoleModel.Instance.GetDataListByType(this.TrialRoleType);
	}

	// Token: 0x06006294 RID: 25236 RVA: 0x001F6B62 File Offset: 0x001F4D62
	public void SetRequestTrialRoleLvUpFunc(Action<int> func)
	{
		this.RequestTrialRoleLvUpFunc = func;
	}

	// Token: 0x06006295 RID: 25237 RVA: 0x001F6B6B File Offset: 0x001F4D6B
	[NullableContext(2)]
	public Action<int> GetRequestTrialRoleLvUpFunc()
	{
		return this.RequestTrialRoleLvUpFunc;
	}

	// Token: 0x06006296 RID: 25238 RVA: 0x001F6B73 File Offset: 0x001F4D73
	public void SetRequestSetCurUseTrialRoleFunc(Action<int, Action<int>> func)
	{
		this.RequestSetCurUseTrialRoleFunc = func;
	}

	// Token: 0x06006297 RID: 25239 RVA: 0x001F6B7C File Offset: 0x001F4D7C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, Action<int>> GetRequestSetCurUseTrialRoleFunc()
	{
		return this.RequestSetCurUseTrialRoleFunc;
	}

	// Token: 0x06006298 RID: 25240 RVA: 0x001F6B84 File Offset: 0x001F4D84
	public void SetTrialRoleGroupUnlockDesc(Dictionary<int, string> descMap)
	{
		this.TrialGroupUnlockDescMap = descMap;
	}

	// Token: 0x06006299 RID: 25241 RVA: 0x001F6B90 File Offset: 0x001F4D90
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

	// Token: 0x04003FCD RID: 16333
	private ETrialRoleType TrialRoleTypeIntl;

	// Token: 0x04003FCE RID: 16334
	private string CaptionIconIntl = "";

	// Token: 0x04003FCF RID: 16335
	private string CaptionTextIntl = "";

	// Token: 0x04003FD0 RID: 16336
	private int? SelectedGroupIdIntl;

	// Token: 0x04003FD1 RID: 16337
	private int HelpIdIntl;

	// Token: 0x04003FD2 RID: 16338
	private Dictionary<int, string> TrialGroupUnlockDescMap = new Dictionary<int, string>();

	// Token: 0x04003FD3 RID: 16339
	[Nullable(2)]
	private Action<int> RequestTrialRoleLvUpFunc;

	// Token: 0x04003FD4 RID: 16340
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, Action<int>> RequestSetCurUseTrialRoleFunc;
}
