using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000533 RID: 1331
	public class ConfigMatchThreeLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F3D RID: 7997 RVA: 0x00109E14 File Offset: 0x00108014
		static ConfigMatchThreeLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeLevelById.CreateStaticDefaultValue), new Action(ConfigMatchThreeLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x00109E34 File Offset: 0x00108034
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

		// Token: 0x06001F3F RID: 7999 RVA: 0x00109EB3 File Offset: 0x001080B3
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeLevelById.LogPair = null;
			ConfigMatchThreeLevelById.HandleId = 0;
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x00109EC1 File Offset: 0x001080C1
		public static void Init()
		{
			ConfigMatchThreeLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeLevelById.HandleId, "db_activitymatchthree.db", "select BinData from `MatchThreeLevel` where Id=?");
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x00109EDC File Offset: 0x001080DC
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

		// Token: 0x04002449 RID: 9289
		private const string DB = "db_activitymatchthree.db";

		// Token: 0x0400244A RID: 9290
		private const string FILE = "s.三消活动.xlsx";

		// Token: 0x0400244B RID: 9291
		private const string TABLE = "MatchThreeLevel";

		// Token: 0x0400244C RID: 9292
		private const string COMMAND = "select BinData from `MatchThreeLevel` where Id=?";

		// Token: 0x0400244D RID: 9293
		private const string KEY_PREFIX = "MatchThreeLevelById";

		// Token: 0x0400244E RID: 9294
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400244F RID: 9295
		private static int HandleId;
	}
}
