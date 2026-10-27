using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200044B RID: 1099
	public class ConfigInstanceTrialRoleConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019CC RID: 6604 RVA: 0x000EB523 File Offset: 0x000E9723
		static ConfigInstanceTrialRoleConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceTrialRoleConfigById.CreateStaticDefaultValue), new Action(ConfigInstanceTrialRoleConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x000EB544 File Offset: 0x000E9744
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

		// Token: 0x060019CE RID: 6606 RVA: 0x000EB5C3 File Offset: 0x000E97C3
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceTrialRoleConfigById.LogPair = null;
			ConfigInstanceTrialRoleConfigById.HandleId = 0;
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x000EB5D1 File Offset: 0x000E97D1
		public static void Init()
		{
			ConfigInstanceTrialRoleConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceTrialRoleConfigById.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceTrialRoleConfig` where Id = ?");
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x000EB5EC File Offset: 0x000E97EC
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

		// Token: 0x04001DF1 RID: 7665
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001DF2 RID: 7666
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001DF3 RID: 7667
		private const string TABLE = "InstanceTrialRoleConfig";

		// Token: 0x04001DF4 RID: 7668
		private const string COMMAND = "select BinData from `InstanceTrialRoleConfig` where Id = ?";

		// Token: 0x04001DF5 RID: 7669
		private const string KEY_PREFIX = "InstanceTrialRoleConfigById";

		// Token: 0x04001DF6 RID: 7670
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DF7 RID: 7671
		private static int HandleId;
	}
}
