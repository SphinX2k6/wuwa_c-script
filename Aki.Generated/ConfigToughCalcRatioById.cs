using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC3 RID: 2755
	public class ConfigToughCalcRatioById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040A6 RID: 16550 RVA: 0x001CA5E0 File Offset: 0x001C87E0
		static ConfigToughCalcRatioById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigToughCalcRatioById.CreateStaticDefaultValue), new Action(ConfigToughCalcRatioById.ResetStaticDefaultValue));
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x001CA600 File Offset: 0x001C8800
		public static void CreateStaticDefaultValue()
		{
			ConfigToughCalcRatioById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigToughCalcRatioById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tough_modifier.db"),
				new ValueTuple<string, object>("文件", "r.韧性计算系数.xlsx"),
				new ValueTuple<string, object>("表名", "ToughCalcRatio"),
				new ValueTuple<string, object>("语句", "select BinData from `ToughCalcRatio` where Id=?")
			});
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x001CA67F File Offset: 0x001C887F
		public static void ResetStaticDefaultValue()
		{
			ConfigToughCalcRatioById.LogPair = null;
			ConfigToughCalcRatioById.HandleId = 0;
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x001CA68D File Offset: 0x001C888D
		public static void Init()
		{
			ConfigToughCalcRatioById.HandleId = ConfigCommon.InitDataStatement(ConfigToughCalcRatioById.HandleId, "db_tough_modifier.db", "select BinData from `ToughCalcRatio` where Id=?");
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x001CA6A8 File Offset: 0x001C88A8
		public static ToughCalcRatio? GetConfig(long p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigToughCalcRatioById.HandleId, ConfigToughCalcRatioById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ToughCalcRatioById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ToughCalcRatio?(ToughCalcRatio.GetRootAsToughCalcRatio(configBuffer));
				}
			}
			ConfigToughCalcRatioById.LogPair.Clear();
			ConfigToughCalcRatioById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindFloat64(ConfigToughCalcRatioById.HandleId, 1, (double)p0Id, ConfigToughCalcRatioById.LogPair) || ConfigCommon.Step(ConfigToughCalcRatioById.HandleId, true, ConfigToughCalcRatioById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigToughCalcRatioById.HandleId, ConfigToughCalcRatioById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigToughCalcRatioById.HandleId, 0, ConfigToughCalcRatioById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigToughCalcRatioById.HandleId, ConfigToughCalcRatioById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ToughCalcRatio rootAsToughCalcRatio = ToughCalcRatio.GetRootAsToughCalcRatio(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ToughCalcRatioById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigToughCalcRatioById.HandleId, ConfigToughCalcRatioById.LogPair);
			return new ToughCalcRatio?(rootAsToughCalcRatio);
		}

		// Token: 0x04004B3B RID: 19259
		private const string DB = "db_tough_modifier.db";

		// Token: 0x04004B3C RID: 19260
		private const string FILE = "r.韧性计算系数.xlsx";

		// Token: 0x04004B3D RID: 19261
		private const string TABLE = "ToughCalcRatio";

		// Token: 0x04004B3E RID: 19262
		private const string COMMAND = "select BinData from `ToughCalcRatio` where Id=?";

		// Token: 0x04004B3F RID: 19263
		private const string KEY_PREFIX = "ToughCalcRatioById";

		// Token: 0x04004B40 RID: 19264
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B41 RID: 19265
		private static int HandleId;
	}
}
