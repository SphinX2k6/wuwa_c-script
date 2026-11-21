using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000CE RID: 206
	public class ConfigAvignonStageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004D5 RID: 1237 RVA: 0x00078A3B File Offset: 0x00076C3B
		static ConfigAvignonStageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvignonStageById.CreateStaticDefaultValue), new Action(ConfigAvignonStageById.ResetStaticDefaultValue));
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00078A5C File Offset: 0x00076C5C
		public static void CreateStaticDefaultValue()
		{
			ConfigAvignonStageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvignonStageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avignon.db"),
				new ValueTuple<string, object>("文件", "a.阿维纽林神学院.xlsx"),
				new ValueTuple<string, object>("表名", "AvignonStage"),
				new ValueTuple<string, object>("语句", "select BinData from `AvignonStage` where Id=?")
			});
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00078ADB File Offset: 0x00076CDB
		public static void ResetStaticDefaultValue()
		{
			ConfigAvignonStageById.LogPair = null;
			ConfigAvignonStageById.HandleId = 0;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00078AE9 File Offset: 0x00076CE9
		public static void Init()
		{
			ConfigAvignonStageById.HandleId = ConfigCommon.InitDataStatement(ConfigAvignonStageById.HandleId, "db_avignon.db", "select BinData from `AvignonStage` where Id=?");
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00078B04 File Offset: 0x00076D04
		public static AvignonStage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvignonStageById.HandleId, ConfigAvignonStageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvignonStageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AvignonStage?(AvignonStage.GetRootAsAvignonStage(configBuffer));
				}
			}
			ConfigAvignonStageById.LogPair.Clear();
			ConfigAvignonStageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAvignonStageById.HandleId, 1, p0Id, ConfigAvignonStageById.LogPair) || ConfigCommon.Step(ConfigAvignonStageById.HandleId, true, ConfigAvignonStageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAvignonStageById.HandleId, ConfigAvignonStageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvignonStageById.HandleId, 0, ConfigAvignonStageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAvignonStageById.HandleId, ConfigAvignonStageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AvignonStage rootAsAvignonStage = AvignonStage.GetRootAsAvignonStage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvignonStageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAvignonStageById.HandleId, ConfigAvignonStageById.LogPair);
			return new AvignonStage?(rootAsAvignonStage);
		}

		// Token: 0x04000586 RID: 1414
		private const string DB = "db_avignon.db";

		// Token: 0x04000587 RID: 1415
		private const string FILE = "a.阿维纽林神学院.xlsx";

		// Token: 0x04000588 RID: 1416
		private const string TABLE = "AvignonStage";

		// Token: 0x04000589 RID: 1417
		private const string COMMAND = "select BinData from `AvignonStage` where Id=?";

		// Token: 0x0400058A RID: 1418
		private const string KEY_PREFIX = "AvignonStageById";

		// Token: 0x0400058B RID: 1419
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400058C RID: 1420
		private static int HandleId;
	}
}
