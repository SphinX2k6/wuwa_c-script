using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

// Token: 0x020022E0 RID: 8928
[NullableContext(1)]
[Nullable(0)]
public class WorldTeamPlayerFightInfo
{
	// Token: 0x0601194C RID: 72012 RVA: 0x0044F578 File Offset: 0x0044D778
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

	// Token: 0x1700168E RID: 5774
	// (get) Token: 0x0601194D RID: 72013 RVA: 0x0044F5D5 File Offset: 0x0044D7D5
	public int PlayerId
	{
		get
		{
			return this.PlayerIdInternal;
		}
	}

	// Token: 0x1700168F RID: 5775
	// (get) Token: 0x0601194E RID: 72014 RVA: 0x0044F5DD File Offset: 0x0044D7DD
	// (set) Token: 0x0601194F RID: 72015 RVA: 0x0044F5E5 File Offset: 0x0044D7E5
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

	// Token: 0x17001690 RID: 5776
	// (get) Token: 0x06011950 RID: 72016 RVA: 0x0044F5EE File Offset: 0x0044D7EE
	// (set) Token: 0x06011951 RID: 72017 RVA: 0x0044F5F6 File Offset: 0x0044D7F6
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

	// Token: 0x06011952 RID: 72018 RVA: 0x0044F600 File Offset: 0x0044D800
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

	// Token: 0x17001691 RID: 5777
	// (get) Token: 0x06011953 RID: 72019 RVA: 0x0044F65C File Offset: 0x0044D85C
	// (set) Token: 0x06011954 RID: 72020 RVA: 0x0044F664 File Offset: 0x0044D864
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

	// Token: 0x17001692 RID: 5778
	// (get) Token: 0x06011955 RID: 72021 RVA: 0x0044F66D File Offset: 0x0044D86D
	public string ThirdPartyOnlineName
	{
		get
		{
			return this.ThirdPartyOnlineNameInternal;
		}
	}

	// Token: 0x17001693 RID: 5779
	// (get) Token: 0x06011956 RID: 72022 RVA: 0x0044F675 File Offset: 0x0044D875
	public string ThirdPartyId
	{
		get
		{
			return this.ThirdPartyIdInternal;
		}
	}

	// Token: 0x0400856E RID: 34158
	private readonly int PlayerIdInternal;

	// Token: 0x0400856F RID: 34159
	private string NameInternal;

	// Token: 0x04008570 RID: 34160
	private int CurRoleIdInternal;

	// Token: 0x04008571 RID: 34161
	private List<WorldTeamRoleInfo> RoleInfosInternal;

	// Token: 0x04008572 RID: 34162
	private readonly string ThirdPartyIdInternal;

	// Token: 0x04008573 RID: 34163
	private readonly string ThirdPartyOnlineNameInternal;
}
