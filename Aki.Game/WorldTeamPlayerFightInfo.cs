using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

// Token: 0x020017C4 RID: 6084
[NullableContext(1)]
[Nullable(0)]
public class WorldTeamPlayerFightInfo
{
	// Token: 0x0600EDE4 RID: 60900 RVA: 0x0045C244 File Offset: 0x0045A444
	public WorldTeamPlayerFightInfo(string name, int playerId, int curRoleId, string playStationOnlineName, string playStationAccountId, string xboxUserId, string xboxOnlineName, List<WorldTeamRoleInfo> roleInfos)
	{
		this.NameInternal = name;
		this.PlayerIdInternal = playerId;
		this.RoleInfosInternal = roleInfos;
		this.CurRoleIdInternal = curRoleId;
		if (Info.Instance.IsPs5Platform())
		{
			this.ThirdPartyIdInternal = playStationAccountId;
			this.ThirdPartyOnlineNameInternal = playStationOnlineName;
			return;
		}
		this.ThirdPartyIdInternal = xboxUserId;
		this.ThirdPartyOnlineNameInternal = xboxOnlineName;
	}

	// Token: 0x170016C5 RID: 5829
	// (get) Token: 0x0600EDE5 RID: 60901 RVA: 0x0045C2A1 File Offset: 0x0045A4A1
	public int PlayerId
	{
		get
		{
			return this.PlayerIdInternal;
		}
	}

	// Token: 0x170016C6 RID: 5830
	// (get) Token: 0x0600EDE6 RID: 60902 RVA: 0x0045C2A9 File Offset: 0x0045A4A9
	// (set) Token: 0x0600EDE7 RID: 60903 RVA: 0x0045C2B1 File Offset: 0x0045A4B1
	public int CurRoleId
	{
		get
		{
			return this.CurRoleIdInternal;
		}
		set
		{
			this.CurRoleIdInternal = value;
		}
	}

	// Token: 0x170016C7 RID: 5831
	// (get) Token: 0x0600EDE8 RID: 60904 RVA: 0x0045C2BA File Offset: 0x0045A4BA
	// (set) Token: 0x0600EDE9 RID: 60905 RVA: 0x0045C2C2 File Offset: 0x0045A4C2
	public List<WorldTeamRoleInfo> RoleInfos
	{
		get
		{
			return this.RoleInfosInternal;
		}
		set
		{
			this.RoleInfosInternal = value;
		}
	}

	// Token: 0x0600EDEA RID: 60906 RVA: 0x0045C2CC File Offset: 0x0045A4CC
	[NullableContext(2)]
	public WorldTeamRoleInfo GetRoleInfoByConfigId(int configId)
	{
		foreach (WorldTeamRoleInfo worldTeamRoleInfo in this.RoleInfosInternal)
		{
			if (worldTeamRoleInfo.RoleId == configId)
			{
				return worldTeamRoleInfo;
			}
		}
		return null;
	}

	// Token: 0x170016C8 RID: 5832
	// (get) Token: 0x0600EDEB RID: 60907 RVA: 0x0045C328 File Offset: 0x0045A528
	// (set) Token: 0x0600EDEC RID: 60908 RVA: 0x0045C330 File Offset: 0x0045A530
	public string Name
	{
		get
		{
			return this.NameInternal;
		}
		set
		{
			this.NameInternal = value;
		}
	}

	// Token: 0x170016C9 RID: 5833
	// (get) Token: 0x0600EDED RID: 60909 RVA: 0x0045C339 File Offset: 0x0045A539
	public string ThirdPartyOnlineName
	{
		get
		{
			return this.ThirdPartyOnlineNameInternal;
		}
	}

	// Token: 0x170016CA RID: 5834
	// (get) Token: 0x0600EDEE RID: 60910 RVA: 0x0045C341 File Offset: 0x0045A541
	public string ThirdPartyId
	{
		get
		{
			return this.ThirdPartyIdInternal;
		}
	}

	// Token: 0x040086AC RID: 34476
	private readonly int PlayerIdInternal;

	// Token: 0x040086AD RID: 34477
	private string NameInternal;

	// Token: 0x040086AE RID: 34478
	private int CurRoleIdInternal;

	// Token: 0x040086AF RID: 34479
	private List<WorldTeamRoleInfo> RoleInfosInternal;

	// Token: 0x040086B0 RID: 34480
	private readonly string ThirdPartyIdInternal;

	// Token: 0x040086B1 RID: 34481
	private readonly string ThirdPartyOnlineNameInternal;
}
