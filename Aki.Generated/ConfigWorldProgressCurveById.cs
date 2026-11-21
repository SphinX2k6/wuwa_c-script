using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B73 RID: 2931
	public class ConfigWorldProgressCurveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044C7 RID: 17607 RVA: 0x001E23C7 File Offset: 0x001E05C7
		static ConfigWorldProgressCurveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWorldProgressCurveById.CreateStaticDefaultValue), new Action(ConfigWorldProgressCurveById.ResetStaticDefaultValue));
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x001E23E8 File Offset: 0x001E05E8
		public static void CreateStaticDefaultValue()
		{
			ConfigWorldProgressCurveById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWorldProgressCurveById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_anniversaryt.db"),
				new ValueTuple<string, object>("文件", "z.周年庆主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "WorldProgressCurve"),
				new ValueTuple<string, object>("语句", "select BinData from `WorldProgressCurve` where Id=?")
			});
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x001E2467 File Offset: 0x001E0667
		public static void ResetStaticDefaultValue()
		{
			ConfigWorldProgressCurveById.LogPair = null;
			ConfigWorldProgressCurveById.HandleId = 0;
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x001E2475 File Offset: 0x001E0675
		public static void Init()
		{
			ConfigWorldProgressCurveById.HandleId = ConfigCommon.InitDataStatement(ConfigWorldProgressCurveById.HandleId, "db_anniversaryt.db", "select BinData from `WorldProgressCurve` where Id=?");
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x001E2490 File Offset: 0x001E0690
		public static WorldProgressCurve? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWorldProgressCurveById.HandleId, ConfigWorldProgressCurveById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WorldProgressCurveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WorldProgressCurve?(WorldProgressCurve.GetRootAsWorldProgressCurve(configBuffer));
				}
			}
			ConfigWorldProgressCurveById.LogPair.Clear();
			ConfigWorldProgressCurveById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWorldProgressCurveById.HandleId, 1, p0Id, ConfigWorldProgressCurveById.LogPair) || ConfigCommon.Step(ConfigWorldProgressCurveById.HandleId, true, ConfigWorldProgressCurveById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWorldProgressCurveById.HandleId, ConfigWorldProgressCurveById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWorldProgressCurveById.HandleId, 0, ConfigWorldProgressCurveById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWorldProgressCurveById.HandleId, ConfigWorldProgressCurveById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WorldProgressCurve rootAsWorldProgressCurve = WorldProgressCurve.GetRootAsWorldProgressCurve(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WorldProgressCurveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWorldProgressCurveById.HandleId, ConfigWorldProgressCurveById.LogPair);
			return new WorldProgressCurve?(rootAsWorldProgressCurve);
		}

		// Token: 0x0400500B RID: 20491
		private const string DB = "db_anniversaryt.db";

		// Token: 0x0400500C RID: 20492
		private const string FILE = "z.周年庆主题活动.xlsx";

		// Token: 0x0400500D RID: 20493
		private const string TABLE = "WorldProgressCurve";

		// Token: 0x0400500E RID: 20494
		private const string COMMAND = "select BinData from `WorldProgressCurve` where Id=?";

		// Token: 0x0400500F RID: 20495
		private const string KEY_PREFIX = "WorldProgressCurveById";

		// Token: 0x04005010 RID: 20496
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04005011 RID: 20497
		private static int HandleId;
	}
}
