using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000549 RID: 1353
	public class ConfigMatchThreeLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FC1 RID: 8129 RVA: 0x00110568 File Offset: 0x0010E768
		static ConfigMatchThreeLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeLevelById.CreateStaticDefaultValue), new Action(ConfigMatchThreeLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x00110588 File Offset: 0x0010E788
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymatchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeLevel` where Id=?")
			});
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x00110607 File Offset: 0x0010E807
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeLevelById.LogPair = null;
			ConfigMatchThreeLevelById.HandleId = 0;
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x00110615 File Offset: 0x0010E815
		public static void Init()
		{
			ConfigMatchThreeLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeLevelById.HandleId, "db_activitymatchthree.db", "select BinData from `MatchThreeLevel` where Id=?");
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00110630 File Offset: 0x0010E830
		public static MatchThreeLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeLevelById.HandleId, ConfigMatchThreeLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MatchThreeLevel?(MatchThreeLevel.GetRootAsMatchThreeLevel(configBuffer));
				}
			}
			ConfigMatchThreeLevelById.LogPair.Clear();
			ConfigMatchThreeLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMatchThreeLevelById.HandleId, 1, p0Id, ConfigMatchThreeLevelById.LogPair) || ConfigCommon.Step(ConfigMatchThreeLevelById.HandleId, true, ConfigMatchThreeLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMatchThreeLevelById.HandleId, ConfigMatchThreeLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeLevelById.HandleId, 0, ConfigMatchThreeLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMatchThreeLevelById.HandleId, ConfigMatchThreeLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MatchThreeLevel rootAsMatchThreeLevel = MatchThreeLevel.GetRootAsMatchThreeLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMatchThreeLevelById.HandleId, ConfigMatchThreeLevelById.LogPair);
			return new MatchThreeLevel?(rootAsMatchThreeLevel);
		}

		// Token: 0x040024E3 RID: 9443
		private const string DB = "db_activitymatchthree.db";

		// Token: 0x040024E4 RID: 9444
		private const string FILE = "s.三消活动.xlsx";

		// Token: 0x040024E5 RID: 9445
		private const string TABLE = "MatchThreeLevel";

		// Token: 0x040024E6 RID: 9446
		private const string COMMAND = "select BinData from `MatchThreeLevel` where Id=?";

		// Token: 0x040024E7 RID: 9447
		private const string KEY_PREFIX = "MatchThreeLevelById";

		// Token: 0x040024E8 RID: 9448
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024E9 RID: 9449
		private static int HandleId;
	}
}
