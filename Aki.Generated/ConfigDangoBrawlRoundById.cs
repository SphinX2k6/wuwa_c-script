using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001DE RID: 478
	public class ConfigDangoBrawlRoundById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B37 RID: 2871 RVA: 0x00098FB8 File Offset: 0x000971B8
		static ConfigDangoBrawlRoundById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlRoundById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlRoundById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00098FD8 File Offset: 0x000971D8
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlRoundById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlRoundById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗局内.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlRound"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlRound` where Id=?")
			});
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00099057 File Offset: 0x00097257
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlRoundById.LogPair = null;
			ConfigDangoBrawlRoundById.HandleId = 0;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00099065 File Offset: 0x00097265
		public static void Init()
		{
			ConfigDangoBrawlRoundById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlRoundById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlRound` where Id=?");
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00099080 File Offset: 0x00097280
		public static DangoBrawlRound? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlRoundById.HandleId, ConfigDangoBrawlRoundById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRoundById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlRound?(DangoBrawlRound.GetRootAsDangoBrawlRound(configBuffer));
				}
			}
			ConfigDangoBrawlRoundById.LogPair.Clear();
			ConfigDangoBrawlRoundById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlRoundById.HandleId, 1, p0Id, ConfigDangoBrawlRoundById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlRoundById.HandleId, true, ConfigDangoBrawlRoundById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlRoundById.HandleId, ConfigDangoBrawlRoundById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlRoundById.HandleId, 0, ConfigDangoBrawlRoundById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlRoundById.HandleId, ConfigDangoBrawlRoundById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlRound rootAsDangoBrawlRound = DangoBrawlRound.GetRootAsDangoBrawlRound(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRoundById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlRoundById.HandleId, ConfigDangoBrawlRoundById.LogPair);
			return new DangoBrawlRound?(rootAsDangoBrawlRound);
		}

		// Token: 0x04000CF6 RID: 3318
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CF7 RID: 3319
		private const string FILE = "t.团子乱斗局内.xlsx";

		// Token: 0x04000CF8 RID: 3320
		private const string TABLE = "DangoBrawlRound";

		// Token: 0x04000CF9 RID: 3321
		private const string COMMAND = "select BinData from `DangoBrawlRound` where Id=?";

		// Token: 0x04000CFA RID: 3322
		private const string KEY_PREFIX = "DangoBrawlRoundById";

		// Token: 0x04000CFB RID: 3323
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CFC RID: 3324
		private static int HandleId;
	}
}
