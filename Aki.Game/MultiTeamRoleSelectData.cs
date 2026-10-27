using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200278B RID: 10123
[NullableContext(1)]
[Nullable(0)]
public class MultiTeamRoleSelectData
{
	// Token: 0x06014C35 RID: 85045 RVA: 0x00540F38 File Offset: 0x0053F138
	public List<RoleDataBase> GetSourceRoleList()
	{
		List<RoleDataBase> list = new List<RoleDataBase>();
		foreach (MultiTeamRoleData multiTeamRoleData in this.MultiTeamRoleDataList)
		{
			list.AddRange(multiTeamRoleData.GetSourceRoleList());
		}
		return list;
	}

	// Token: 0x06014C36 RID: 85046 RVA: 0x00540F98 File Offset: 0x0053F198
	public List<MultiTeamRoleData> GetMultiTeamRoleDataList()
	{
		return this.MultiTeamRoleDataList;
	}

	// Token: 0x06014C37 RID: 85047 RVA: 0x00540FA0 File Offset: 0x0053F1A0
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

	// Token: 0x06014C38 RID: 85048 RVA: 0x0054101B File Offset: 0x0053F21B
	public void SetMultiTeamTagData(MultiTeamTagDataItem data)
	{
		this.MultiTeamTagData = data;
		this.NeedShowTag = true;
	}

	// Token: 0x04009C29 RID: 39977
	public EFilterSortGroupId? UseWay;

	// Token: 0x04009C2A RID: 39978
	[Nullable(2)]
	public Action BackCallBack;

	// Token: 0x04009C2B RID: 39979
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<int[], bool> CanConfirmFunc;

	// Token: 0x04009C2C RID: 39980
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<int[], int[]> ConfirmCallBack;

	// Token: 0x04009C2D RID: 39981
	[Nullable(2)]
	public Func<int, bool> IsNeedRevive;

	// Token: 0x04009C2E RID: 39982
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<int, int[], bool> IfCanSelectCheck;

	// Token: 0x04009C2F RID: 39983
	public int TeamLength;

	// Token: 0x04009C30 RID: 39984
	public List<int> InitSelectRoleList = new List<int>();

	// Token: 0x04009C31 RID: 39985
	private readonly List<MultiTeamRoleData> MultiTeamRoleDataList = new List<MultiTeamRoleData>();

	// Token: 0x04009C32 RID: 39986
	public List<int> UnRecommendRole = new List<int>();

	// Token: 0x04009C33 RID: 39987
	[Nullable(2)]
	public MultiTeamTagDataItem MultiTeamTagData;

	// Token: 0x04009C34 RID: 39988
	public bool NeedShowTag;

	// Token: 0x04009C35 RID: 39989
	public string Tips = "";

	// Token: 0x04009C36 RID: 39990
	public string ConfirmBtnText = "";

	// Token: 0x04009C37 RID: 39991
	public ERoleViewSource RoleViewSource;
}
