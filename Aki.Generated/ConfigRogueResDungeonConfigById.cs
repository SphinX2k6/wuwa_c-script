using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200085B RID: 2139
	public class ConfigRogueResDungeonConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003234 RID: 12852 RVA: 0x00178BF4 File Offset: 0x00176DF4
		static ConfigRogueResDungeonConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResDungeonConfigById.CreateStaticDefaultValue), new Action(ConfigRogueResDungeonConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x00178C14 File Offset: 0x00176E14
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResDungeonConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResDungeonConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResDungeonConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResDungeonConfig` where Id=?")
			});
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x00178C93 File Offset: 0x00176E93
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResDungeonConfigById.LogPair = null;
			ConfigRogueResDungeonConfigById.HandleId = 0;
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x00178CA1 File Offset: 0x00176EA1
		public static void Init()
		{
			ConfigRogueResDungeonConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResDungeonConfigById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResDungeonConfig` where Id=?");
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x00178CBC File Offset: 0x00176EBC
		public static RogueResDungeonConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResDungeonConfigById.HandleId, ConfigRogueResDungeonConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResDungeonConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResDungeonConfig?(RogueResDungeonConfig.GetRootAsRogueResDungeonConfig(configBuffer));
				}
			}
			ConfigRogueResDungeonConfigById.LogPair.Clear();
			ConfigRogueResDungeonConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResDungeonConfigById.HandleId, 1, p0Id, ConfigRogueResDungeonConfigById.LogPair) || ConfigCommon.Step(ConfigRogueResDungeonConfigById.HandleId, true, ConfigRogueResDungeonConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResDungeonConfigById.HandleId, ConfigRogueResDungeonConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResDungeonConfigById.HandleId, 0, ConfigRogueResDungeonConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResDungeonConfigById.HandleId, ConfigRogueResDungeonConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResDungeonConfig rootAsRogueResDungeonConfig = RogueResDungeonConfig.GetRootAsRogueResDungeonConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResDungeonConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResDungeonConfigById.HandleId, ConfigRogueResDungeonConfigById.LogPair);
			return new RogueResDungeonConfig?(rootAsRogueResDungeonConfig);
		}

		// Token: 0x04003A63 RID: 14947
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A64 RID: 14948
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A65 RID: 14949
		private const string TABLE = "RogueResDungeonConfig";

		// Token: 0x04003A66 RID: 14950
		private const string COMMAND = "select BinData from `RogueResDungeonConfig` where Id=?";

		// Token: 0x04003A67 RID: 14951
		private const string KEY_PREFIX = "RogueResDungeonConfigById";

		// Token: 0x04003A68 RID: 14952
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A69 RID: 14953
		private static int HandleId;
	}
}
