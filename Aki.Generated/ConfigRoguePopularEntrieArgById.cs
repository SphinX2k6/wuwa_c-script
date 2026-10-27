using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200082D RID: 2093
	public class ConfigRoguePopularEntrieArgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003120 RID: 12576 RVA: 0x0016F1C3 File Offset: 0x0016D3C3
		static ConfigRoguePopularEntrieArgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoguePopularEntrieArgById.CreateStaticDefaultValue), new Action(ConfigRoguePopularEntrieArgById.ResetStaticDefaultValue));
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x0016F1E4 File Offset: 0x0016D3E4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoguePopularEntrieArgById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoguePopularEntrieArgById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RoguePopularEntrieArg"),
				new ValueTuple<string, object>("语句", "select BinData from `RoguePopularEntrieArg` where Id=?")
			});
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x0016F263 File Offset: 0x0016D463
		public static void ResetStaticDefaultValue()
		{
			ConfigRoguePopularEntrieArgById.LogPair = null;
			ConfigRoguePopularEntrieArgById.HandleId = 0;
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x0016F271 File Offset: 0x0016D471
		public static void Init()
		{
			ConfigRoguePopularEntrieArgById.HandleId = ConfigCommon.InitDataStatement(ConfigRoguePopularEntrieArgById.HandleId, "db_rogue.db", "select BinData from `RoguePopularEntrieArg` where Id=?");
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x0016F28C File Offset: 0x0016D48C
		public static RoguePopularEntrieArg? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoguePopularEntrieArgById.HandleId, ConfigRoguePopularEntrieArgById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoguePopularEntrieArgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoguePopularEntrieArg?(RoguePopularEntrieArg.GetRootAsRoguePopularEntrieArg(configBuffer));
				}
			}
			ConfigRoguePopularEntrieArgById.LogPair.Clear();
			ConfigRoguePopularEntrieArgById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoguePopularEntrieArgById.HandleId, 1, p0Id, ConfigRoguePopularEntrieArgById.LogPair) || ConfigCommon.Step(ConfigRoguePopularEntrieArgById.HandleId, true, ConfigRoguePopularEntrieArgById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoguePopularEntrieArgById.HandleId, ConfigRoguePopularEntrieArgById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoguePopularEntrieArgById.HandleId, 0, ConfigRoguePopularEntrieArgById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoguePopularEntrieArgById.HandleId, ConfigRoguePopularEntrieArgById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoguePopularEntrieArg rootAsRoguePopularEntrieArg = RoguePopularEntrieArg.GetRootAsRoguePopularEntrieArg(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoguePopularEntrieArgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoguePopularEntrieArgById.HandleId, ConfigRoguePopularEntrieArgById.LogPair);
			return new RoguePopularEntrieArg?(rootAsRoguePopularEntrieArg);
		}

		// Token: 0x04003921 RID: 14625
		private const string DB = "db_rogue.db";

		// Token: 0x04003922 RID: 14626
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003923 RID: 14627
		private const string TABLE = "RoguePopularEntrieArg";

		// Token: 0x04003924 RID: 14628
		private const string COMMAND = "select BinData from `RoguePopularEntrieArg` where Id=?";

		// Token: 0x04003925 RID: 14629
		private const string KEY_PREFIX = "RoguePopularEntrieArgById";

		// Token: 0x04003926 RID: 14630
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003927 RID: 14631
		private static int HandleId;
	}
}
