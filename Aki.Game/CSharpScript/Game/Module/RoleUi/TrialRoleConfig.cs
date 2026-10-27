using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02004CE6 RID: 19686
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class TrialRoleConfig : ConfigBase
	{
		// Token: 0x06032D6D RID: 208237 RVA: 0x00BD93B8 File Offset: 0x00BD75B8
		public TrialRoleInfo? GetTrialRoleConfig(int id)
		{
			TrialRoleInfo? config = ConfigTrialRoleInfoById.GetConfig(id, true);
			if (config != null)
			{
				return new TrialRoleInfo?(config.Value);
			}
			return null;
		}

		// Token: 0x06032D6E RID: 208238 RVA: 0x00BD93EC File Offset: 0x00BD75EC
		[NullableContext(2)]
		public IReadOnlyList<TrialRoleInfo> GetTrialRoleConfigsByGroupId(int id)
		{
			return ConfigTrialRoleInfoByGroupId.GetConfigList(id, true);
		}

		// Token: 0x06032D6F RID: 208239 RVA: 0x00BD93F5 File Offset: 0x00BD75F5
		public IReadOnlyList<TrialRoleInfo> GetTrialRoleConfigListByType(ETrialRoleType trialRoleType)
		{
			return ConfigTrialRoleInfoByType.GetConfigList((int)trialRoleType, true) ?? new List<TrialRoleInfo>();
		}

		// Token: 0x06032D70 RID: 208240 RVA: 0x00BD9408 File Offset: 0x00BD7608
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

		// Token: 0x06032D71 RID: 208241 RVA: 0x00BD94E4 File Offset: 0x00BD76E4
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

		// Token: 0x06032D72 RID: 208242 RVA: 0x00BD9544 File Offset: 0x00BD7744
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

		// Token: 0x06032D73 RID: 208243 RVA: 0x00BD95B8 File Offset: 0x00BD77B8
		public int? GetTrialRoleGroupId(int id)
		{
			TrialRoleInfo? trialRoleConfig = this.GetTrialRoleConfig(id);
			if (trialRoleConfig == null)
			{
				return null;
			}
			return new int?(trialRoleConfig.GetValueOrDefault().GroupId);
		}

		// Token: 0x17007D9F RID: 32159
		// (get) Token: 0x06032D74 RID: 208244 RVA: 0x00BD95F4 File Offset: 0x00BD77F4
		public static TrialRoleConfig Instance
		{
			get
			{
				return TrialRoleConfig._Instance;
			}
		}

		// Token: 0x06032D75 RID: 208245 RVA: 0x00BD95FB File Offset: 0x00BD77FB
		public static TrialRoleConfig GetOrCreateInstance()
		{
			if (TrialRoleConfig._Instance == null)
			{
				TrialRoleConfig.CreateInstance();
			}
			return TrialRoleConfig._Instance;
		}

		// Token: 0x06032D76 RID: 208246 RVA: 0x00BD960F File Offset: 0x00BD780F
		public static bool CreateInstance()
		{
			if (TrialRoleConfig._Instance != null)
			{
				return true;
			}
			TrialRoleConfig._Instance = new TrialRoleConfig();
			return true;
		}

		// Token: 0x06032D77 RID: 208247 RVA: 0x00BD9625 File Offset: 0x00BD7825
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032D78 RID: 208248 RVA: 0x00BD9627 File Offset: 0x00BD7827
		public static void ResetStaticDefaultValue()
		{
			TrialRoleConfig._Instance = null;
		}

		// Token: 0x06032D79 RID: 208249 RVA: 0x00BD962F File Offset: 0x00BD782F
		static TrialRoleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TrialRoleConfig.CreateStaticDefaultValue), new Action(TrialRoleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401B0DB RID: 110811
		[Nullable(2)]
		private static TrialRoleConfig _Instance;
	}
}
