using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000546 RID: 1350
	public class ConfigMatchThreeFillRulesById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FAF RID: 8111 RVA: 0x0010FE90 File Offset: 0x0010E090
		static ConfigMatchThreeFillRulesById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeFillRulesById.CreateStaticDefaultValue), new Action(ConfigMatchThreeFillRulesById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x0010FEB0 File Offset: 0x0010E0B0
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeFillRulesById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeFillRulesById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_matchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeFillRules"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeFillRules` where Id=?")
			});
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x0010FF2F File Offset: 0x0010E12F
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeFillRulesById.LogPair = null;
			ConfigMatchThreeFillRulesById.HandleId = 0;
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x0010FF3D File Offset: 0x0010E13D
		public static void Init()
		{
			ConfigMatchThreeFillRulesById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeFillRulesById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeFillRules` where Id=?");
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x0010FF58 File Offset: 0x0010E158
		public static MatchThreeFillRules? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeFillRulesById.HandleId, ConfigMatchThreeFillRulesById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeFillRulesById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MatchThreeFillRules?(MatchThreeFillRules.GetRootAsMatchThreeFillRules(configBuffer));
				}
			}
			ConfigMatchThreeFillRulesById.LogPair.Clear();
			ConfigMatchThreeFillRulesById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMatchThreeFillRulesById.HandleId, 1, p0Id, ConfigMatchThreeFillRulesById.LogPair) || ConfigCommon.Step(ConfigMatchThreeFillRulesById.HandleId, true, ConfigMatchThreeFillRulesById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMatchThreeFillRulesById.HandleId, ConfigMatchThreeFillRulesById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeFillRulesById.HandleId, 0, ConfigMatchThreeFillRulesById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMatchThreeFillRulesById.HandleId, ConfigMatchThreeFillRulesById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MatchThreeFillRules rootAsMatchThreeFillRules = MatchThreeFillRules.GetRootAsMatchThreeFillRules(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeFillRulesById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMatchThreeFillRulesById.HandleId, ConfigMatchThreeFillRulesById.LogPair);
			return new MatchThreeFillRules?(rootAsMatchThreeFillRules);
		}

		// Token: 0x040024CE RID: 9422
		private const string DB = "db_matchthree.db";

		// Token: 0x040024CF RID: 9423
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x040024D0 RID: 9424
		private const string TABLE = "MatchThreeFillRules";

		// Token: 0x040024D1 RID: 9425
		private const string COMMAND = "select BinData from `MatchThreeFillRules` where Id=?";

		// Token: 0x040024D2 RID: 9426
		private const string KEY_PREFIX = "MatchThreeFillRulesById";

		// Token: 0x040024D3 RID: 9427
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024D4 RID: 9428
		private static int HandleId;
	}
}
