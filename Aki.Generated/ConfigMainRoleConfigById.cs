using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200051D RID: 1309
	public class ConfigMainRoleConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EB9 RID: 7865 RVA: 0x0010A603 File Offset: 0x00108803
		static ConfigMainRoleConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMainRoleConfigById.CreateStaticDefaultValue), new Action(ConfigMainRoleConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x0010A624 File Offset: 0x00108824
		public static void CreateStaticDefaultValue()
		{
			ConfigMainRoleConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMainRoleConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_main_role_change.db"),
				new ValueTuple<string, object>("文件", "z.主角切换.xlsx"),
				new ValueTuple<string, object>("表名", "MainRoleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `MainRoleConfig` where Id = ?")
			});
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x0010A6A3 File Offset: 0x001088A3
		public static void ResetStaticDefaultValue()
		{
			ConfigMainRoleConfigById.LogPair = null;
			ConfigMainRoleConfigById.HandleId = 0;
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x0010A6B1 File Offset: 0x001088B1
		public static void Init()
		{
			ConfigMainRoleConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigMainRoleConfigById.HandleId, "db_main_role_change.db", "select BinData from `MainRoleConfig` where Id = ?");
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x0010A6CC File Offset: 0x001088CC
		public static MainRoleConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMainRoleConfigById.HandleId, ConfigMainRoleConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MainRoleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MainRoleConfig?(MainRoleConfig.GetRootAsMainRoleConfig(configBuffer));
				}
			}
			ConfigMainRoleConfigById.LogPair.Clear();
			ConfigMainRoleConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMainRoleConfigById.HandleId, 1, p0Id, ConfigMainRoleConfigById.LogPair) || ConfigCommon.Step(ConfigMainRoleConfigById.HandleId, true, ConfigMainRoleConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMainRoleConfigById.HandleId, ConfigMainRoleConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMainRoleConfigById.HandleId, 0, ConfigMainRoleConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMainRoleConfigById.HandleId, ConfigMainRoleConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MainRoleConfig rootAsMainRoleConfig = MainRoleConfig.GetRootAsMainRoleConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MainRoleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMainRoleConfigById.HandleId, ConfigMainRoleConfigById.LogPair);
			return new MainRoleConfig?(rootAsMainRoleConfig);
		}

		// Token: 0x040023AF RID: 9135
		private const string DB = "db_main_role_change.db";

		// Token: 0x040023B0 RID: 9136
		private const string FILE = "z.主角切换.xlsx";

		// Token: 0x040023B1 RID: 9137
		private const string TABLE = "MainRoleConfig";

		// Token: 0x040023B2 RID: 9138
		private const string COMMAND = "select BinData from `MainRoleConfig` where Id = ?";

		// Token: 0x040023B3 RID: 9139
		private const string KEY_PREFIX = "MainRoleConfigById";

		// Token: 0x040023B4 RID: 9140
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023B5 RID: 9141
		private static int HandleId;
	}
}
