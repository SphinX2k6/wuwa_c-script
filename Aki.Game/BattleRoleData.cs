using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020010AC RID: 4268
[NullableContext(2)]
[Nullable(0)]
public class BattleRoleData
{
	// Token: 0x0600A92B RID: 43307 RVA: 0x0031C626 File Offset: 0x0031A826
	public void Init(int playerId, int configId, int skinId, int? onlineIndex, string playerName, int level, bool isSelf, bool isReady)
	{
		this.PlayerId = playerId;
		this.ConfigId = configId;
		this.SkinId = skinId;
		this.OnlineIndex = onlineIndex;
		this.PlayerName = playerName;
		this.Level = level;
		this.IsSelf = isSelf;
		this.IsReady = isReady;
	}

	// Token: 0x0600A92C RID: 43308 RVA: 0x0031C665 File Offset: 0x0031A865
	public void SetReady(bool bReady)
	{
		this.IsReady = bReady;
	}

	// Token: 0x170011B2 RID: 4530
	// (get) Token: 0x0600A92D RID: 43309 RVA: 0x0031C670 File Offset: 0x0031A870
	[Nullable(1)]
	public string Name
	{
		[NullableContext(1)]
		get
		{
			if (KuroSdkController.Instance.NeedShowThirdPartyId())
			{
				string thirdPartyOnlineId = this.ThirdPartyOnlineId;
				if (thirdPartyOnlineId != null && thirdPartyOnlineId != "")
				{
					return thirdPartyOnlineId;
				}
			}
			return this.PlayerName;
		}
	}

	// Token: 0x170011B3 RID: 4531
	// (get) Token: 0x0600A92E RID: 43310 RVA: 0x0031C6A8 File Offset: 0x0031A8A8
	public TrialRoleInfo? TrialRoleConfig
	{
		get
		{
			if (this.ConfigId <= 100000)
			{
				return null;
			}
			RoleConfig instance = RoleConfig.Instance;
			TrialRoleInfo? trialRoleConfigByGroupId = instance.GetTrialRoleConfigByGroupId(this.ConfigId);
			if (trialRoleConfigByGroupId == null)
			{
				return instance.GetTrialRoleConfig(this.ConfigId);
			}
			return trialRoleConfigByGroupId;
		}
	}

	// Token: 0x0400625F RID: 25183
	public int ConfigId;

	// Token: 0x04006260 RID: 25184
	public int SkinId;

	// Token: 0x04006261 RID: 25185
	public int? OnlineIndex;

	// Token: 0x04006262 RID: 25186
	public string PlayerName;

	// Token: 0x04006263 RID: 25187
	public int Level;

	// Token: 0x04006264 RID: 25188
	public bool IsSelf;

	// Token: 0x04006265 RID: 25189
	public bool IsReady;

	// Token: 0x04006266 RID: 25190
	public int PlayerId;

	// Token: 0x04006267 RID: 25191
	public string ThirdPartyOnlineId;
}
