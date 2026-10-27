using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200081E RID: 2078
	public class ConfigRogueBuffPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030C6 RID: 12486 RVA: 0x0016D040 File Offset: 0x0016B240
		static ConfigRogueBuffPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueBuffPoolById.CreateStaticDefaultValue), new Action(ConfigRogueBuffPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x0016D060 File Offset: 0x0016B260
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueBuffPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueBuffPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueBuffPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueBuffPool` where Id=?")
			});
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x0016D0DF File Offset: 0x0016B2DF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueBuffPoolById.LogPair = null;
			ConfigRogueBuffPoolById.HandleId = 0;
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x0016D0ED File Offset: 0x0016B2ED
		public static void Init()
		{
			ConfigRogueBuffPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueBuffPoolById.HandleId, "db_rogue.db", "select BinData from `RogueBuffPool` where Id=?");
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x0016D108 File Offset: 0x0016B308
		public static RogueBuffPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueBuffPoolById.HandleId, ConfigRogueBuffPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueBuffPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueBuffPool?(RogueBuffPool.GetRootAsRogueBuffPool(configBuffer));
				}
			}
			ConfigRogueBuffPoolById.LogPair.Clear();
			ConfigRogueBuffPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueBuffPoolById.HandleId, 1, p0Id, ConfigRogueBuffPoolById.LogPair) || ConfigCommon.Step(ConfigRogueBuffPoolById.HandleId, true, ConfigRogueBuffPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueBuffPoolById.HandleId, ConfigRogueBuffPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueBuffPoolById.HandleId, 0, ConfigRogueBuffPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueBuffPoolById.HandleId, ConfigRogueBuffPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueBuffPool rootAsRogueBuffPool = RogueBuffPool.GetRootAsRogueBuffPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueBuffPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueBuffPoolById.HandleId, ConfigRogueBuffPoolById.LogPair);
			return new RogueBuffPool?(rootAsRogueBuffPool);
		}

		// Token: 0x040038B8 RID: 14520
		private const string DB = "db_rogue.db";

		// Token: 0x040038B9 RID: 14521
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x040038BA RID: 14522
		private const string TABLE = "RogueBuffPool";

		// Token: 0x040038BB RID: 14523
		private const string COMMAND = "select BinData from `RogueBuffPool` where Id=?";

		// Token: 0x040038BC RID: 14524
		private const string KEY_PREFIX = "RogueBuffPoolById";

		// Token: 0x040038BD RID: 14525
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038BE RID: 14526
		private static int HandleId;
	}
}
