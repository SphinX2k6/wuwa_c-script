using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001BED RID: 7149
[NullableContext(2)]
[Nullable(0)]
public class BattleRoleData
{
	// Token: 0x0600D518 RID: 54552 RVA: 0x003113E2 File Offset: 0x0030F5E2
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

	// Token: 0x0600D519 RID: 54553 RVA: 0x00311421 File Offset: 0x0030F621
	public void SetReady(bool bReady)
	{
		this.IsReady = bReady;
	}

	// Token: 0x1700118D RID: 4493
	// (get) Token: 0x0600D51A RID: 54554 RVA: 0x0031142C File Offset: 0x0030F62C
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

	// Token: 0x1700118E RID: 4494
	// (get) Token: 0x0600D51B RID: 54555 RVA: 0x00311464 File Offset: 0x0030F664
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

	// Token: 0x04006190 RID: 24976
	public int ConfigId;

	// Token: 0x04006191 RID: 24977
	public int SkinId;

	// Token: 0x04006192 RID: 24978
	public int? OnlineIndex;

	// Token: 0x04006193 RID: 24979
	public string PlayerName;

	// Token: 0x04006194 RID: 24980
	public int Level;

	// Token: 0x04006195 RID: 24981
	public bool IsSelf;

	// Token: 0x04006196 RID: 24982
	public bool IsReady;

	// Token: 0x04006197 RID: 24983
	public int PlayerId;

	// Token: 0x04006198 RID: 24984
	public string ThirdPartyOnlineId;
}
