using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02003C98 RID: 15512
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class TrialRoleConfig : ConfigBase
	{
		// Token: 0x06027B48 RID: 162632 RVA: 0x00B1ECC0 File Offset: 0x00B1CEC0
		public TrialRoleInfo? GetTrialRoleConfig(int id)
		{
			TrialRoleInfo? config = ConfigTrialRoleInfoById.GetConfig(id, true);
			if (config != null)
			{
				return new TrialRoleInfo?(config.Value);
			}
			return null;
		}

		// Token: 0x06027B49 RID: 162633 RVA: 0x00B1ECF4 File Offset: 0x00B1CEF4
		[NullableContext(2)]
		public IReadOnlyList<TrialRoleInfo> GetTrialRoleConfigsByGroupId(int id)
		{
			return ConfigTrialRoleInfoByGroupId.GetConfigList(id, true);
		}

		// Token: 0x06027B4A RID: 162634 RVA: 0x00B1ECFD File Offset: 0x00B1CEFD
		public IReadOnlyList<TrialRoleInfo> GetTrialRoleConfigListByType(ETrialRoleType trialRoleType)
		{
			return ConfigTrialRoleInfoByType.GetConfigList((int)trialRoleType, true) ?? new List<TrialRoleInfo>();
		}

		// Token: 0x06027B4B RID: 162635 RVA: 0x00B1ED10 File Offset: 0x00B1CF10
		public Dictionary<int, List<TrialRoleInfo>> GetTrialRoleAllConfigByType(ETrialRoleType trialRoleType)
		{
			Dictionary<int, List<TrialRoleInfo>> dictionary = new Dictionary<int, List<TrialRoleInfo>>();
			foreach (TrialRoleInfo item in this.GetTrialRoleConfigListByType(trialRoleType))
			{
				int groupId = item.GroupId;
				if (!dictionary.ContainsKey(groupId))
				{
					dictionary[groupId] = new List<TrialRoleInfo>();
				}
				dictionary[groupId].Add(item);
			}
			foreach (KeyValuePair<int, List<TrialRoleInfo>> keyValuePair in dictionary)
			{
				keyValuePair.Value.Sort((TrialRoleInfo a, TrialRoleInfo b) => a.WorldLevel - b.WorldLevel);
			}
			return dictionary;
		}

		// Token: 0x06027B4C RID: 162636 RVA: 0x00B1EDEC File Offset: 0x00B1CFEC
		public RoleInfo? GetRoleConfigByTrialRoleId(int id)
		{
			TrialRoleInfo? trialRoleConfig = this.GetTrialRoleConfig(id);
			if (trialRoleConfig == null)
			{
				return null;
			}
			RoleInfo? config = ConfigRoleInfoById.GetConfig(trialRoleConfig.Value.ParentId, true);
			if (config != null)
			{
				return new RoleInfo?(config.Value);
			}
			return null;
		}

		// Token: 0x06027B4D RID: 162637 RVA: 0x00B1EE4C File Offset: 0x00B1D04C
		public RoleInfo? GetRoleConfigByGroupId(int id)
		{
			IReadOnlyList<TrialRoleInfo> trialRoleConfigsByGroupId = this.GetTrialRoleConfigsByGroupId(id);
			if (trialRoleConfigsByGroupId == null || trialRoleConfigsByGroupId.Count == 0)
			{
				return null;
			}
			RoleConfig instance = RoleConfig.Instance;
			RoleInfo? roleInfo = (instance != null) ? instance.GetRoleConfig(trialRoleConfigsByGroupId[0].ParentId) : null;
			if (roleInfo != null)
			{
				return new RoleInfo?(roleInfo.Value);
			}
			return null;
		}

		// Token: 0x06027B4E RID: 162638 RVA: 0x00B1EEC0 File Offset: 0x00B1D0C0
		public int? GetTrialRoleGroupId(int id)
		{
			TrialRoleInfo? trialRoleConfig = this.GetTrialRoleConfig(id);
			if (trialRoleConfig == null)
			{
				return null;
			}
			return new int?(trialRoleConfig.GetValueOrDefault().GroupId);
		}

		// Token: 0x17005149 RID: 20809
		// (get) Token: 0x06027B4F RID: 162639 RVA: 0x00B1EEFC File Offset: 0x00B1D0FC
		public static TrialRoleConfig Instance
		{
			get
			{
				return TrialRoleConfig._Instance;
			}
		}

		// Token: 0x06027B50 RID: 162640 RVA: 0x00B1EF03 File Offset: 0x00B1D103
		public static TrialRoleConfig GetOrCreateInstance()
		{
			if (TrialRoleConfig._Instance == null)
			{
				TrialRoleConfig.CreateInstance();
			}
			return TrialRoleConfig._Instance;
		}

		// Token: 0x06027B51 RID: 162641 RVA: 0x00B1EF17 File Offset: 0x00B1D117
		public static bool CreateInstance()
		{
			if (TrialRoleConfig._Instance != null)
			{
				return true;
			}
			TrialRoleConfig._Instance = new TrialRoleConfig();
			return true;
		}

		// Token: 0x06027B52 RID: 162642 RVA: 0x00B1EF2D File Offset: 0x00B1D12D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06027B53 RID: 162643 RVA: 0x00B1EF2F File Offset: 0x00B1D12F
		public static void ResetStaticDefaultValue()
		{
			TrialRoleConfig._Instance = null;
		}

		// Token: 0x06027B54 RID: 162644 RVA: 0x00B1EF37 File Offset: 0x00B1D137
		static TrialRoleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TrialRoleConfig.CreateStaticDefaultValue), new Action(TrialRoleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04015A60 RID: 88672
		[Nullable(2)]
		private static TrialRoleConfig _Instance;
	}
}
