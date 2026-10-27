using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200083F RID: 2111
	public class ConfigRogueResDungeonConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600318C RID: 12684 RVA: 0x0017190C File Offset: 0x0016FB0C
		static ConfigRogueResDungeonConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResDungeonConfigById.CreateStaticDefaultValue), new Action(ConfigRogueResDungeonConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x0017192C File Offset: 0x0016FB2C
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

		// Token: 0x0600318E RID: 12686 RVA: 0x001719AB File Offset: 0x0016FBAB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResDungeonConfigById.LogPair = null;
			ConfigRogueResDungeonConfigById.HandleId = 0;
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x001719B9 File Offset: 0x0016FBB9
		public static void Init()
		{
			ConfigRogueResDungeonConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResDungeonConfigById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResDungeonConfig` where Id=?");
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x001719D4 File Offset: 0x0016FBD4
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

		// Token: 0x0400399F RID: 14751
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039A0 RID: 14752
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039A1 RID: 14753
		private const string TABLE = "RogueResDungeonConfig";

		// Token: 0x040039A2 RID: 14754
		private const string COMMAND = "select BinData from `RogueResDungeonConfig` where Id=?";

		// Token: 0x040039A3 RID: 14755
		private const string KEY_PREFIX = "RogueResDungeonConfigById";

		// Token: 0x040039A4 RID: 14756
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039A5 RID: 14757
		private static int HandleId;
	}
}
