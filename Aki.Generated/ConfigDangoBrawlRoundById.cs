using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F0 RID: 496
	public class ConfigDangoBrawlRoundById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BA3 RID: 2979 RVA: 0x0009EEF0 File Offset: 0x0009D0F0
		static ConfigDangoBrawlRoundById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlRoundById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlRoundById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0009EF10 File Offset: 0x0009D110
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

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0009EF8F File Offset: 0x0009D18F
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlRoundById.LogPair = null;
			ConfigDangoBrawlRoundById.HandleId = 0;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0009EF9D File Offset: 0x0009D19D
		public static void Init()
		{
			ConfigDangoBrawlRoundById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlRoundById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlRound` where Id=?");
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0009EFB8 File Offset: 0x0009D1B8
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

		// Token: 0x04000D74 RID: 3444
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D75 RID: 3445
		private const string FILE = "t.团子乱斗局内.xlsx";

		// Token: 0x04000D76 RID: 3446
		private const string TABLE = "DangoBrawlRound";

		// Token: 0x04000D77 RID: 3447
		private const string COMMAND = "select BinData from `DangoBrawlRound` where Id=?";

		// Token: 0x04000D78 RID: 3448
		private const string KEY_PREFIX = "DangoBrawlRoundById";

		// Token: 0x04000D79 RID: 3449
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D7A RID: 3450
		private static int HandleId;
	}
}
