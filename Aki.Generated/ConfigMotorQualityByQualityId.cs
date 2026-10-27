using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005BE RID: 1470
	public class ConfigMotorQualityByQualityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002281 RID: 8833 RVA: 0x0011CA78 File Offset: 0x0011AC78
		static ConfigMotorQualityByQualityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorQualityByQualityId.CreateStaticDefaultValue), new Action(ConfigMotorQualityByQualityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x0011CA98 File Offset: 0x0011AC98
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

		// Token: 0x06002283 RID: 8835 RVA: 0x0011CB17 File Offset: 0x0011AD17
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorQualityByQualityId.LogPair = null;
			ConfigMotorQualityByQualityId.HandleId = 0;
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x0011CB25 File Offset: 0x0011AD25
		public static void Init()
		{
			ConfigMotorQualityByQualityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorQualityByQualityId.HandleId, "db_motordiy.db", "select BinData from `MotorQuality` where QualityId=?");
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x0011CB40 File Offset: 0x0011AD40
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

		// Token: 0x04002816 RID: 10262
		private const string DB = "db_motordiy.db";

		// Token: 0x04002817 RID: 10263
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x04002818 RID: 10264
		private const string TABLE = "MotorQuality";

		// Token: 0x04002819 RID: 10265
		private const string COMMAND = "select BinData from `MotorQuality` where QualityId=?";

		// Token: 0x0400281A RID: 10266
		private const string KEY_PREFIX = "MotorQualityByQualityId";

		// Token: 0x0400281B RID: 10267
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400281C RID: 10268
		private static int HandleId;
	}
}
