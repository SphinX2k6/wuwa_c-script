using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A9E RID: 2718
	public class ConfigWorldProgressCurveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FC9 RID: 16329 RVA: 0x001C3033 File Offset: 0x001C1233
		static ConfigWorldProgressCurveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWorldProgressCurveById.CreateStaticDefaultValue), new Action(ConfigWorldProgressCurveById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x001C3054 File Offset: 0x001C1254
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

		// Token: 0x06003FCB RID: 16331 RVA: 0x001C30D3 File Offset: 0x001C12D3
		public static void ResetStaticDefaultValue()
		{
			ConfigWorldProgressCurveById.LogPair = null;
			ConfigWorldProgressCurveById.HandleId = 0;
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x001C30E1 File Offset: 0x001C12E1
		public static void Init()
		{
			ConfigWorldProgressCurveById.HandleId = ConfigCommon.InitDataStatement(ConfigWorldProgressCurveById.HandleId, "db_anniversaryt.db", "select BinData from `WorldProgressCurve` where Id=?");
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x001C30FC File Offset: 0x001C12FC
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

		// Token: 0x04004A38 RID: 19000
		private const string DB = "db_anniversaryt.db";

		// Token: 0x04004A39 RID: 19001
		private const string FILE = "z.周年庆主题活动.xlsx";

		// Token: 0x04004A3A RID: 19002
		private const string TABLE = "WorldProgressCurve";

		// Token: 0x04004A3B RID: 19003
		private const string COMMAND = "select BinData from `WorldProgressCurve` where Id=?";

		// Token: 0x04004A3C RID: 19004
		private const string KEY_PREFIX = "WorldProgressCurveById";

		// Token: 0x04004A3D RID: 19005
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A3E RID: 19006
		private static int HandleId;
	}
}
