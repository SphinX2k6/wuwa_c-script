using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A93 RID: 2707
	public class ConfigTakeWeedsDifficultyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F86 RID: 16262 RVA: 0x001C4053 File Offset: 0x001C2253
		static ConfigTakeWeedsDifficultyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTakeWeedsDifficultyById.CreateStaticDefaultValue), new Action(ConfigTakeWeedsDifficultyById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x001C4074 File Offset: 0x001C2274
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

		// Token: 0x06003F88 RID: 16264 RVA: 0x001C40F3 File Offset: 0x001C22F3
		public static void ResetStaticDefaultValue()
		{
			ConfigTakeWeedsDifficultyById.LogPair = null;
			ConfigTakeWeedsDifficultyById.HandleId = 0;
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x001C4101 File Offset: 0x001C2301
		public static void Init()
		{
			ConfigTakeWeedsDifficultyById.HandleId = ConfigCommon.InitDataStatement(ConfigTakeWeedsDifficultyById.HandleId, "db_takeweeds.db", "select BinData from `TakeWeedsDifficulty` where Id=?");
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x001C411C File Offset: 0x001C231C
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

		// Token: 0x040049EB RID: 18923
		private const string DB = "db_takeweeds.db";

		// Token: 0x040049EC RID: 18924
		private const string FILE = "g.割草活动.xlsx";

		// Token: 0x040049ED RID: 18925
		private const string TABLE = "TakeWeedsDifficulty";

		// Token: 0x040049EE RID: 18926
		private const string COMMAND = "select BinData from `TakeWeedsDifficulty` where Id=?";

		// Token: 0x040049EF RID: 18927
		private const string KEY_PREFIX = "TakeWeedsDifficultyById";

		// Token: 0x040049F0 RID: 18928
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049F1 RID: 18929
		private static int HandleId;
	}
}
