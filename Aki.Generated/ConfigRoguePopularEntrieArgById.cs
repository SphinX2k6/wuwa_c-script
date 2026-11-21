using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000849 RID: 2121
	public class ConfigRoguePopularEntrieArgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031C8 RID: 12744 RVA: 0x001764AB File Offset: 0x001746AB
		static ConfigRoguePopularEntrieArgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoguePopularEntrieArgById.CreateStaticDefaultValue), new Action(ConfigRoguePopularEntrieArgById.ResetStaticDefaultValue));
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x001764CC File Offset: 0x001746CC
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

		// Token: 0x060031CA RID: 12746 RVA: 0x0017654B File Offset: 0x0017474B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoguePopularEntrieArgById.LogPair = null;
			ConfigRoguePopularEntrieArgById.HandleId = 0;
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x00176559 File Offset: 0x00174759
		public static void Init()
		{
			ConfigRoguePopularEntrieArgById.HandleId = ConfigCommon.InitDataStatement(ConfigRoguePopularEntrieArgById.HandleId, "db_rogue.db", "select BinData from `RoguePopularEntrieArg` where Id=?");
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x00176574 File Offset: 0x00174774
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

		// Token: 0x040039E5 RID: 14821
		private const string DB = "db_rogue.db";

		// Token: 0x040039E6 RID: 14822
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x040039E7 RID: 14823
		private const string TABLE = "RoguePopularEntrieArg";

		// Token: 0x040039E8 RID: 14824
		private const string COMMAND = "select BinData from `RoguePopularEntrieArg` where Id=?";

		// Token: 0x040039E9 RID: 14825
		private const string KEY_PREFIX = "RoguePopularEntrieArgById";

		// Token: 0x040039EA RID: 14826
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039EB RID: 14827
		private static int HandleId;
	}
}
