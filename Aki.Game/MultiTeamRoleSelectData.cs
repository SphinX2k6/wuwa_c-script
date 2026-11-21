using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C76 RID: 7286
[NullableContext(1)]
[Nullable(0)]
public class MultiTeamRoleSelectData
{
	// Token: 0x0601211F RID: 74015 RVA: 0x0054FF18 File Offset: 0x0054E118
	public List<RoleDataBase> GetSourceRoleList()
	{
		List<RoleDataBase> list = new List<RoleDataBase>();
		foreach (MultiTeamRoleData multiTeamRoleData in this.MultiTeamRoleDataList)
		{
			list.AddRange(multiTeamRoleData.GetSourceRoleList());
		}
		return list;
	}

	// Token: 0x06012120 RID: 74016 RVA: 0x0054FF78 File Offset: 0x0054E178
	public List<MultiTeamRoleData> GetMultiTeamRoleDataList()
	{
		return this.MultiTeamRoleDataList;
	}

	// Token: 0x06012121 RID: 74017 RVA: 0x0054FF80 File Offset: 0x0054E180
	public static MultiTeamRoleSelectData Phrase(EFilterSortGroupId? useWay, int teamLength, int[] initSelectRoleList, [Nullable(2)] Action backCallBack, [Nullable(new byte[]
	{
		2,
		1
	})] Func<int[], bool> canConfirmFunc, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Action<int[], int[]> confirmCallBack, [Nullable(2)] Func<int, bool> isNeedRevive, List<MultiTeamRoleData> multiTeamRoleDataList, [Nullable(2)] int[] unRecommendRole = null, string tips = "", string confirmBtnText = "")
	{
		MultiTeamRoleSelectData multiTeamRoleSelectData = new MultiTeamRoleSelectData();
		multiTeamRoleSelectData.UseWay = useWay;
		multiTeamRoleSelectData.TeamLength = teamLength;
		multiTeamRoleSelectData.InitSelectRoleList.AddRange(initSelectRoleList);
		multiTeamRoleSelectData.BackCallBack = backCallBack;
		multiTeamRoleSelectData.CanConfirmFunc = canConfirmFunc;
		multiTeamRoleSelectData.ConfirmCallBack = confirmCallBack;
		multiTeamRoleSelectData.IsNeedRevive = isNeedRevive;
		multiTeamRoleSelectData.MultiTeamRoleDataList.AddRange(multiTeamRoleDataList);
		if (unRecommendRole != null)
		{
			multiTeamRoleSelectData.UnRecommendRole.AddRange(unRecommendRole);
		}
		multiTeamRoleSelectData.Tips = tips;
		multiTeamRoleSelectData.ConfirmBtnText = confirmBtnText;
		return multiTeamRoleSelectData;
	}

	// Token: 0x06012122 RID: 74018 RVA: 0x0054FFFB File Offset: 0x0054E1FB
	public void SetMultiTeamTagData(MultiTeamTagDataItem data)
	{
		this.MultiTeamTagData = data;
		this.NeedShowTag = true;
	}

	// Token: 0x04009D89 RID: 40329
	public EFilterSortGroupId? UseWay;

	// Token: 0x04009D8A RID: 40330
	[Nullable(2)]
	public Action BackCallBack;

	// Token: 0x04009D8B RID: 40331
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<int[], bool> CanConfirmFunc;

	// Token: 0x04009D8C RID: 40332
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<int[], int[]> ConfirmCallBack;

	// Token: 0x04009D8D RID: 40333
	[Nullable(2)]
	public Func<int, bool> IsNeedRevive;

	// Token: 0x04009D8E RID: 40334
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<int, int[], bool> IfCanSelectCheck;

	// Token: 0x04009D8F RID: 40335
	public int TeamLength;

	// Token: 0x04009D90 RID: 40336
	public List<int> InitSelectRoleList = new List<int>();

	// Token: 0x04009D91 RID: 40337
	private readonly List<MultiTeamRoleData> MultiTeamRoleDataList = new List<MultiTeamRoleData>();

	// Token: 0x04009D92 RID: 40338
	public List<int> UnRecommendRole = new List<int>();

	// Token: 0x04009D93 RID: 40339
	public bool ShowUnRecommendBtn = true;

	// Token: 0x04009D94 RID: 40340
	[Nullable(2)]
	public MultiTeamTagDataItem MultiTeamTagData;

	// Token: 0x04009D95 RID: 40341
	public bool NeedShowTag;

	// Token: 0x04009D96 RID: 40342
	public string Tips = "";

	// Token: 0x04009D97 RID: 40343
	public string ConfirmBtnText = "";

	// Token: 0x04009D98 RID: 40344
	public ERoleViewSource RoleViewSource;

	// Token: 0x04009D99 RID: 40345
	public bool ShowDetailButton = true;

	// Token: 0x04009D9A RID: 40346
	public bool IsSingleSelect;

	// Token: 0x04009D9B RID: 40347
	public bool ShowInitSelectRoleInfo;
}
