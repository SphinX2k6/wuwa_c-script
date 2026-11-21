using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D5 RID: 1493
	public class ConfigMotorQualityByQualityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600230B RID: 8971 RVA: 0x00123360 File Offset: 0x00121560
		static ConfigMotorQualityByQualityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorQualityByQualityId.CreateStaticDefaultValue), new Action(ConfigMotorQualityByQualityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x00123380 File Offset: 0x00121580
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorQualityByQualityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorQualityByQualityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorQuality` where QualityId=?")
			});
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x001233FF File Offset: 0x001215FF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorQualityByQualityId.LogPair = null;
			ConfigMotorQualityByQualityId.HandleId = 0;
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x0012340D File Offset: 0x0012160D
		public static void Init()
		{
			ConfigMotorQualityByQualityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorQualityByQualityId.HandleId, "db_motordiy.db", "select BinData from `MotorQuality` where QualityId=?");
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x00123428 File Offset: 0x00121628
		public static MotorQuality? GetConfig(int p0QualityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorQualityByQualityId.HandleId, ConfigMotorQualityByQualityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorQualityByQualityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QualityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorQuality?(MotorQuality.GetRootAsMotorQuality(configBuffer));
				}
			}
			ConfigMotorQualityByQualityId.LogPair.Clear();
			ConfigMotorQualityByQualityId.LogPair.Add(new ValueTuple<string, object>("QualityId", p0QualityId));
			if (!ConfigCommon.BindInt(ConfigMotorQualityByQualityId.HandleId, 1, p0QualityId, ConfigMotorQualityByQualityId.LogPair) || ConfigCommon.Step(ConfigMotorQualityByQualityId.HandleId, true, ConfigMotorQualityByQualityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorQualityByQualityId.HandleId, ConfigMotorQualityByQualityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorQualityByQualityId.HandleId, 0, ConfigMotorQualityByQualityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorQualityByQualityId.HandleId, ConfigMotorQualityByQualityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorQuality rootAsMotorQuality = MotorQuality.GetRootAsMotorQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorQualityByQualityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QualityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorQualityByQualityId.HandleId, ConfigMotorQualityByQualityId.LogPair);
			return new MotorQuality?(rootAsMotorQuality);
		}

		// Token: 0x040028B7 RID: 10423
		private const string DB = "db_motordiy.db";

		// Token: 0x040028B8 RID: 10424
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x040028B9 RID: 10425
		private const string TABLE = "MotorQuality";

		// Token: 0x040028BA RID: 10426
		private const string COMMAND = "select BinData from `MotorQuality` where QualityId=?";

		// Token: 0x040028BB RID: 10427
		private const string KEY_PREFIX = "MotorQualityByQualityId";

		// Token: 0x040028BC RID: 10428
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028BD RID: 10429
		private static int HandleId;
	}
}
