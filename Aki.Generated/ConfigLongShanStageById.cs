using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004EF RID: 1263
	public class ConfigLongShanStageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DA5 RID: 7589 RVA: 0x00100D1B File Offset: 0x000FEF1B
		static ConfigLongShanStageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongShanStageById.CreateStaticDefaultValue), new Action(ConfigLongShanStageById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00100D3C File Offset: 0x000FEF3C
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

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00100DBB File Offset: 0x000FEFBB
		public static void ResetStaticDefaultValue()
		{
			ConfigLongShanStageById.LogPair = null;
			ConfigLongShanStageById.HandleId = 0;
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00100DC9 File Offset: 0x000FEFC9
		public static void Init()
		{
			ConfigLongShanStageById.HandleId = ConfigCommon.InitDataStatement(ConfigLongShanStageById.HandleId, "db_longshanactivity.db", "select BinData from `LongShanStage` where Id=?");
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00100DE4 File Offset: 0x000FEFE4
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

		// Token: 0x0400226D RID: 8813
		private const string DB = "db_longshanactivity.db";

		// Token: 0x0400226E RID: 8814
		private const string FILE = "l.龙山主题活动.xlsx";

		// Token: 0x0400226F RID: 8815
		private const string TABLE = "LongShanStage";

		// Token: 0x04002270 RID: 8816
		private const string COMMAND = "select BinData from `LongShanStage` where Id=?";

		// Token: 0x04002271 RID: 8817
		private const string KEY_PREFIX = "LongShanStageById";

		// Token: 0x04002272 RID: 8818
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002273 RID: 8819
		private static int HandleId;
	}
}
