using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000461 RID: 1121
	public class ConfigInstanceTrialRoleConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A50 RID: 6736 RVA: 0x000F1C77 File Offset: 0x000EFE77
		static ConfigInstanceTrialRoleConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceTrialRoleConfigById.CreateStaticDefaultValue), new Action(ConfigInstanceTrialRoleConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x000F1C98 File Offset: 0x000EFE98
		public static void CreateStaticDefaultValue()
		{
			ConfigInstanceTrialRoleConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInstanceTrialRoleConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_instance_dungeon.db"),
				new ValueTuple<string, object>("文件", "f.副本.xlsx"),
				new ValueTuple<string, object>("表名", "InstanceTrialRoleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `InstanceTrialRoleConfig` where Id = ?")
			});
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x000F1D17 File Offset: 0x000EFF17
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceTrialRoleConfigById.LogPair = null;
			ConfigInstanceTrialRoleConfigById.HandleId = 0;
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x000F1D25 File Offset: 0x000EFF25
		public static void Init()
		{
			ConfigInstanceTrialRoleConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceTrialRoleConfigById.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceTrialRoleConfig` where Id = ?");
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x000F1D40 File Offset: 0x000EFF40
		public static InstanceTrialRoleConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInstanceTrialRoleConfigById.HandleId, ConfigInstanceTrialRoleConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceTrialRoleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InstanceTrialRoleConfig?(InstanceTrialRoleConfig.GetRootAsInstanceTrialRoleConfig(configBuffer));
				}
			}
			ConfigInstanceTrialRoleConfigById.LogPair.Clear();
			ConfigInstanceTrialRoleConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInstanceTrialRoleConfigById.HandleId, 1, p0Id, ConfigInstanceTrialRoleConfigById.LogPair) || ConfigCommon.Step(ConfigInstanceTrialRoleConfigById.HandleId, true, ConfigInstanceTrialRoleConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInstanceTrialRoleConfigById.HandleId, ConfigInstanceTrialRoleConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInstanceTrialRoleConfigById.HandleId, 0, ConfigInstanceTrialRoleConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInstanceTrialRoleConfigById.HandleId, ConfigInstanceTrialRoleConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InstanceTrialRoleConfig rootAsInstanceTrialRoleConfig = InstanceTrialRoleConfig.GetRootAsInstanceTrialRoleConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceTrialRoleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInstanceTrialRoleConfigById.HandleId, ConfigInstanceTrialRoleConfigById.LogPair);
			return new InstanceTrialRoleConfig?(rootAsInstanceTrialRoleConfig);
		}

		// Token: 0x04001E8B RID: 7819
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001E8C RID: 7820
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001E8D RID: 7821
		private const string TABLE = "InstanceTrialRoleConfig";

		// Token: 0x04001E8E RID: 7822
		private const string COMMAND = "select BinData from `InstanceTrialRoleConfig` where Id = ?";

		// Token: 0x04001E8F RID: 7823
		private const string KEY_PREFIX = "InstanceTrialRoleConfigById";

		// Token: 0x04001E90 RID: 7824
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E91 RID: 7825
		private static int HandleId;
	}
}
