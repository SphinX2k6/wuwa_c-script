using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C2 RID: 2498
	public class ConfigTeamConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AA0 RID: 15008 RVA: 0x001A552C File Offset: 0x001A372C
		static ConfigTeamConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeamConfigById.CreateStaticDefaultValue), new Action(ConfigTeamConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x001A554C File Offset: 0x001A374C
		public static void CreateStaticDefaultValue()
		{
			ConfigTeamConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTeamConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_teamconfig.db"),
				new ValueTuple<string, object>("文件", "z.组队配置.xlsx"),
				new ValueTuple<string, object>("表名", "TeamConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TeamConfig` where Id = ?")
			});
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x001A55CB File Offset: 0x001A37CB
		public static void ResetStaticDefaultValue()
		{
			ConfigTeamConfigById.LogPair = null;
			ConfigTeamConfigById.HandleId = 0;
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x001A55D9 File Offset: 0x001A37D9
		public static void Init()
		{
			ConfigTeamConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTeamConfigById.HandleId, "db_teamconfig.db", "select BinData from `TeamConfig` where Id = ?");
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x001A55F4 File Offset: 0x001A37F4
		public static TeamConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTeamConfigById.HandleId, ConfigTeamConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TeamConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TeamConfig?(TeamConfig.GetRootAsTeamConfig(configBuffer));
				}
			}
			ConfigTeamConfigById.LogPair.Clear();
			ConfigTeamConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTeamConfigById.HandleId, 1, p0Id, ConfigTeamConfigById.LogPair) || ConfigCommon.Step(ConfigTeamConfigById.HandleId, true, ConfigTeamConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTeamConfigById.HandleId, ConfigTeamConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTeamConfigById.HandleId, 0, ConfigTeamConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTeamConfigById.HandleId, ConfigTeamConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TeamConfig rootAsTeamConfig = TeamConfig.GetRootAsTeamConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TeamConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTeamConfigById.HandleId, ConfigTeamConfigById.LogPair);
			return new TeamConfig?(rootAsTeamConfig);
		}

		// Token: 0x04004434 RID: 17460
		private const string DB = "db_teamconfig.db";

		// Token: 0x04004435 RID: 17461
		private const string FILE = "z.组队配置.xlsx";

		// Token: 0x04004436 RID: 17462
		private const string TABLE = "TeamConfig";

		// Token: 0x04004437 RID: 17463
		private const string COMMAND = "select BinData from `TeamConfig` where Id = ?";

		// Token: 0x04004438 RID: 17464
		private const string KEY_PREFIX = "TeamConfigById";

		// Token: 0x04004439 RID: 17465
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400443A RID: 17466
		private static int HandleId;
	}
}
