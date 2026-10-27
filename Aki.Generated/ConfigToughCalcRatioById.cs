using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009EE RID: 2542
	public class ConfigToughCalcRatioById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BA8 RID: 15272 RVA: 0x001AB24C File Offset: 0x001A944C
		static ConfigToughCalcRatioById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigToughCalcRatioById.CreateStaticDefaultValue), new Action(ConfigToughCalcRatioById.ResetStaticDefaultValue));
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x001AB26C File Offset: 0x001A946C
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

		// Token: 0x06003BAA RID: 15274 RVA: 0x001AB2EB File Offset: 0x001A94EB
		public static void ResetStaticDefaultValue()
		{
			ConfigToughCalcRatioById.LogPair = null;
			ConfigToughCalcRatioById.HandleId = 0;
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x001AB2F9 File Offset: 0x001A94F9
		public static void Init()
		{
			ConfigToughCalcRatioById.HandleId = ConfigCommon.InitDataStatement(ConfigToughCalcRatioById.HandleId, "db_tough_modifier.db", "select BinData from `ToughCalcRatio` where Id=?");
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x001AB314 File Offset: 0x001A9514
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

		// Token: 0x04004568 RID: 17768
		private const string DB = "db_tough_modifier.db";

		// Token: 0x04004569 RID: 17769
		private const string FILE = "r.韧性计算系数.xlsx";

		// Token: 0x0400456A RID: 17770
		private const string TABLE = "ToughCalcRatio";

		// Token: 0x0400456B RID: 17771
		private const string COMMAND = "select BinData from `ToughCalcRatio` where Id=?";

		// Token: 0x0400456C RID: 17772
		private const string KEY_PREFIX = "ToughCalcRatioById";

		// Token: 0x0400456D RID: 17773
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400456E RID: 17774
		private static int HandleId;
	}
}
