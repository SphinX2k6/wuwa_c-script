using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000505 RID: 1285
	public class ConfigLongShanStageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E29 RID: 7721 RVA: 0x0010746F File Offset: 0x0010566F
		static ConfigLongShanStageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongShanStageById.CreateStaticDefaultValue), new Action(ConfigLongShanStageById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x00107490 File Offset: 0x00105690
		public static void CreateStaticDefaultValue()
		{
			ConfigLongShanStageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLongShanStageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_longshanactivity.db"),
				new ValueTuple<string, object>("文件", "l.龙山主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "LongShanStage"),
				new ValueTuple<string, object>("语句", "select BinData from `LongShanStage` where Id=?")
			});
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x0010750F File Offset: 0x0010570F
		public static void ResetStaticDefaultValue()
		{
			ConfigLongShanStageById.LogPair = null;
			ConfigLongShanStageById.HandleId = 0;
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0010751D File Offset: 0x0010571D
		public static void Init()
		{
			ConfigLongShanStageById.HandleId = ConfigCommon.InitDataStatement(ConfigLongShanStageById.HandleId, "db_longshanactivity.db", "select BinData from `LongShanStage` where Id=?");
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x00107538 File Offset: 0x00105738
		public static LongShanStage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLongShanStageById.HandleId, ConfigLongShanStageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanStageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LongShanStage?(LongShanStage.GetRootAsLongShanStage(configBuffer));
				}
			}
			ConfigLongShanStageById.LogPair.Clear();
			ConfigLongShanStageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLongShanStageById.HandleId, 1, p0Id, ConfigLongShanStageById.LogPair) || ConfigCommon.Step(ConfigLongShanStageById.HandleId, true, ConfigLongShanStageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLongShanStageById.HandleId, ConfigLongShanStageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLongShanStageById.HandleId, 0, ConfigLongShanStageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLongShanStageById.HandleId, ConfigLongShanStageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LongShanStage rootAsLongShanStage = LongShanStage.GetRootAsLongShanStage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanStageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLongShanStageById.HandleId, ConfigLongShanStageById.LogPair);
			return new LongShanStage?(rootAsLongShanStage);
		}

		// Token: 0x04002307 RID: 8967
		private const string DB = "db_longshanactivity.db";

		// Token: 0x04002308 RID: 8968
		private const string FILE = "l.龙山主题活动.xlsx";

		// Token: 0x04002309 RID: 8969
		private const string TABLE = "LongShanStage";

		// Token: 0x0400230A RID: 8970
		private const string COMMAND = "select BinData from `LongShanStage` where Id=?";

		// Token: 0x0400230B RID: 8971
		private const string KEY_PREFIX = "LongShanStageById";

		// Token: 0x0400230C RID: 8972
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400230D RID: 8973
		private static int HandleId;
	}
}
