using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A6 RID: 1446
	public class ConfigMotorGiftQualityByQualityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021F1 RID: 8689 RVA: 0x001198C4 File Offset: 0x00117AC4
		static ConfigMotorGiftQualityByQualityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorGiftQualityByQualityId.CreateStaticDefaultValue), new Action(ConfigMotorGiftQualityByQualityId.ResetStaticDefaultValue));
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x001198E4 File Offset: 0x00117AE4
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

		// Token: 0x060021F3 RID: 8691 RVA: 0x00119963 File Offset: 0x00117B63
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorGiftQualityByQualityId.LogPair = null;
			ConfigMotorGiftQualityByQualityId.HandleId = 0;
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00119971 File Offset: 0x00117B71
		public static void Init()
		{
			ConfigMotorGiftQualityByQualityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorGiftQualityByQualityId.HandleId, "db_motorskin.db", "select BinData from `MotorGiftQuality` where QualityId=?");
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x0011998C File Offset: 0x00117B8C
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

		// Token: 0x0400276E RID: 10094
		private const string DB = "db_motorskin.db";

		// Token: 0x0400276F RID: 10095
		private const string FILE = "m.礼包外显表.xlsx";

		// Token: 0x04002770 RID: 10096
		private const string TABLE = "MotorGiftQuality";

		// Token: 0x04002771 RID: 10097
		private const string COMMAND = "select BinData from `MotorGiftQuality` where QualityId=?";

		// Token: 0x04002772 RID: 10098
		private const string KEY_PREFIX = "MotorGiftQualityByQualityId";

		// Token: 0x04002773 RID: 10099
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002774 RID: 10100
		private static int HandleId;
	}
}
