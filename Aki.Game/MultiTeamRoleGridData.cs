using System;
using System.Runtime.CompilerServices;

// Token: 0x02002788 RID: 10120
[NullableContext(2)]
[Nullable(0)]
public class MultiTeamRoleGridData
{
	// Token: 0x06014C25 RID: 85029 RVA: 0x00540CBF File Offset: 0x0053EEBF
	public RoleDataBase GetRole()
	{
		return this.Role;
	}

	// Token: 0x06014C26 RID: 85030 RVA: 0x00540CC7 File Offset: 0x0053EEC7
	public bool GetIsRecommend()
	{
		return this.IsRecommend;
	}

	// Token: 0x06014C27 RID: 85031 RVA: 0x00540CCF File Offset: 0x0053EECF
	public bool GetIsHighlight()
	{
		return this.IsHighlight;
	}

	// Token: 0x06014C28 RID: 85032 RVA: 0x00540CD7 File Offset: 0x0053EED7
	public bool GetIsLock()
	{
		return this.IsLock;
	}

	// Token: 0x06014C29 RID: 85033 RVA: 0x00540CDF File Offset: 0x0053EEDF
	public bool GetIsUnRecommend()
	{
		return this.IsUnRecommend;
	}

	// Token: 0x06014C2A RID: 85034 RVA: 0x00540CE7 File Offset: 0x0053EEE7
	[NullableContext(1)]
	public static MultiTeamRoleGridData Phrase(RoleDataBase role, bool isRecommend, bool isHighlight, bool isLock = false, bool isUnRecommend = false)
	{
		return new MultiTeamRoleGridData
		{
			Role = role,
			IsRecommend = isRecommend,
			IsHighlight = isHighlight,
			IsLock = isLock,
			IsUnRecommend = isUnRecommend
		};
	}

	// Token: 0x04009C1E RID: 39966
	private RoleDataBase Role;

	// Token: 0x04009C1F RID: 39967
	private bool IsRecommend;

	// Token: 0x04009C20 RID: 39968
	private bool IsHighlight;

	// Token: 0x04009C21 RID: 39969
	private bool IsLock;

	// Token: 0x04009C22 RID: 39970
	private bool IsUnRecommend;
}
