using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009BE RID: 2494
	public class ConfigTakeWeedsDifficultyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A88 RID: 14984 RVA: 0x001A4CBF File Offset: 0x001A2EBF
		static ConfigTakeWeedsDifficultyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTakeWeedsDifficultyById.CreateStaticDefaultValue), new Action(ConfigTakeWeedsDifficultyById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x001A4CE0 File Offset: 0x001A2EE0
		public static void CreateStaticDefaultValue()
		{
			ConfigTakeWeedsDifficultyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTakeWeedsDifficultyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_takeweeds.db"),
				new ValueTuple<string, object>("文件", "g.割草活动.xlsx"),
				new ValueTuple<string, object>("表名", "TakeWeedsDifficulty"),
				new ValueTuple<string, object>("语句", "select BinData from `TakeWeedsDifficulty` where Id=?")
			});
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x001A4D5F File Offset: 0x001A2F5F
		public static void ResetStaticDefaultValue()
		{
			ConfigTakeWeedsDifficultyById.LogPair = null;
			ConfigTakeWeedsDifficultyById.HandleId = 0;
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x001A4D6D File Offset: 0x001A2F6D
		public static void Init()
		{
			ConfigTakeWeedsDifficultyById.HandleId = ConfigCommon.InitDataStatement(ConfigTakeWeedsDifficultyById.HandleId, "db_takeweeds.db", "select BinData from `TakeWeedsDifficulty` where Id=?");
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x001A4D88 File Offset: 0x001A2F88
		public static TakeWeedsDifficulty? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTakeWeedsDifficultyById.HandleId, ConfigTakeWeedsDifficultyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TakeWeedsDifficultyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TakeWeedsDifficulty?(TakeWeedsDifficulty.GetRootAsTakeWeedsDifficulty(configBuffer));
				}
			}
			ConfigTakeWeedsDifficultyById.LogPair.Clear();
			ConfigTakeWeedsDifficultyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTakeWeedsDifficultyById.HandleId, 1, p0Id, ConfigTakeWeedsDifficultyById.LogPair) || ConfigCommon.Step(ConfigTakeWeedsDifficultyById.HandleId, true, ConfigTakeWeedsDifficultyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTakeWeedsDifficultyById.HandleId, ConfigTakeWeedsDifficultyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTakeWeedsDifficultyById.HandleId, 0, ConfigTakeWeedsDifficultyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTakeWeedsDifficultyById.HandleId, ConfigTakeWeedsDifficultyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TakeWeedsDifficulty rootAsTakeWeedsDifficulty = TakeWeedsDifficulty.GetRootAsTakeWeedsDifficulty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TakeWeedsDifficultyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTakeWeedsDifficultyById.HandleId, ConfigTakeWeedsDifficultyById.LogPair);
			return new TakeWeedsDifficulty?(rootAsTakeWeedsDifficulty);
		}

		// Token: 0x04004418 RID: 17432
		private const string DB = "db_takeweeds.db";

		// Token: 0x04004419 RID: 17433
		private const string FILE = "g.割草活动.xlsx";

		// Token: 0x0400441A RID: 17434
		private const string TABLE = "TakeWeedsDifficulty";

		// Token: 0x0400441B RID: 17435
		private const string COMMAND = "select BinData from `TakeWeedsDifficulty` where Id=?";

		// Token: 0x0400441C RID: 17436
		private const string KEY_PREFIX = "TakeWeedsDifficultyById";

		// Token: 0x0400441D RID: 17437
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400441E RID: 17438
		private static int HandleId;
	}
}
