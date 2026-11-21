using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005BD RID: 1469
	public class ConfigMotorGiftQualityByQualityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600227B RID: 8827 RVA: 0x001201AC File Offset: 0x0011E3AC
		static ConfigMotorGiftQualityByQualityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorGiftQualityByQualityId.CreateStaticDefaultValue), new Action(ConfigMotorGiftQualityByQualityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x001201CC File Offset: 0x0011E3CC
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorGiftQualityByQualityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorGiftQualityByQualityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorskin.db"),
				new ValueTuple<string, object>("文件", "m.礼包外显表.xlsx"),
				new ValueTuple<string, object>("表名", "MotorGiftQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorGiftQuality` where QualityId=?")
			});
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x0012024B File Offset: 0x0011E44B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorGiftQualityByQualityId.LogPair = null;
			ConfigMotorGiftQualityByQualityId.HandleId = 0;
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x00120259 File Offset: 0x0011E459
		public static void Init()
		{
			ConfigMotorGiftQualityByQualityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorGiftQualityByQualityId.HandleId, "db_motorskin.db", "select BinData from `MotorGiftQuality` where QualityId=?");
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x00120274 File Offset: 0x0011E474
		public static MotorGiftQuality? GetConfig(int p0QualityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorGiftQualityByQualityId.HandleId, ConfigMotorGiftQualityByQualityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorGiftQualityByQualityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QualityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorGiftQuality?(MotorGiftQuality.GetRootAsMotorGiftQuality(configBuffer));
				}
			}
			ConfigMotorGiftQualityByQualityId.LogPair.Clear();
			ConfigMotorGiftQualityByQualityId.LogPair.Add(new ValueTuple<string, object>("QualityId", p0QualityId));
			if (!ConfigCommon.BindInt(ConfigMotorGiftQualityByQualityId.HandleId, 1, p0QualityId, ConfigMotorGiftQualityByQualityId.LogPair) || ConfigCommon.Step(ConfigMotorGiftQualityByQualityId.HandleId, true, ConfigMotorGiftQualityByQualityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorGiftQualityByQualityId.HandleId, ConfigMotorGiftQualityByQualityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorGiftQualityByQualityId.HandleId, 0, ConfigMotorGiftQualityByQualityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorGiftQualityByQualityId.HandleId, ConfigMotorGiftQualityByQualityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorGiftQuality rootAsMotorGiftQuality = MotorGiftQuality.GetRootAsMotorGiftQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorGiftQualityByQualityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QualityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorGiftQualityByQualityId.HandleId, ConfigMotorGiftQualityByQualityId.LogPair);
			return new MotorGiftQuality?(rootAsMotorGiftQuality);
		}

		// Token: 0x0400280F RID: 10255
		private const string DB = "db_motorskin.db";

		// Token: 0x04002810 RID: 10256
		private const string FILE = "m.礼包外显表.xlsx";

		// Token: 0x04002811 RID: 10257
		private const string TABLE = "MotorGiftQuality";

		// Token: 0x04002812 RID: 10258
		private const string COMMAND = "select BinData from `MotorGiftQuality` where QualityId=?";

		// Token: 0x04002813 RID: 10259
		private const string KEY_PREFIX = "MotorGiftQualityByQualityId";

		// Token: 0x04002814 RID: 10260
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002815 RID: 10261
		private static int HandleId;
	}
}
