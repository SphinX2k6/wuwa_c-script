using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000009 RID: 9
	public class ConfigAbnormalDamageConfigByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000036 RID: 54 RVA: 0x0005B416 File Offset: 0x00059616
		static ConfigAbnormalDamageConfigByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbnormalDamageConfigByLevel.CreateStaticDefaultValue), new Action(ConfigAbnormalDamageConfigByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0005B438 File Offset: 0x00059638
		public static void CreateStaticDefaultValue()
		{
			ConfigAbnormalDamageConfigByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbnormalDamageConfigByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_abnormaldamage.db"),
				new ValueTuple<string, object>("文件", "y.异常伤害.xlsx"),
				new ValueTuple<string, object>("表名", "AbnormalDamageConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `AbnormalDamageConfig` where Level=?")
			});
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0005B4B7 File Offset: 0x000596B7
		public static void ResetStaticDefaultValue()
		{
			ConfigAbnormalDamageConfigByLevel.LogPair = null;
			ConfigAbnormalDamageConfigByLevel.HandleId = 0;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0005B4C5 File Offset: 0x000596C5
		public static void Init()
		{
			ConfigAbnormalDamageConfigByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigAbnormalDamageConfigByLevel.HandleId, "db_abnormaldamage.db", "select BinData from `AbnormalDamageConfig` where Level=?");
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0005B4E0 File Offset: 0x000596E0
		public static AbnormalDamageConfig? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbnormalDamageConfigByLevel.HandleId, ConfigAbnormalDamageConfigByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbnormalDamageConfigByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbnormalDamageConfig?(AbnormalDamageConfig.GetRootAsAbnormalDamageConfig(configBuffer));
				}
			}
			ConfigAbnormalDamageConfigByLevel.LogPair.Clear();
			ConfigAbnormalDamageConfigByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigAbnormalDamageConfigByLevel.HandleId, 1, p0Level, ConfigAbnormalDamageConfigByLevel.LogPair) || ConfigCommon.Step(ConfigAbnormalDamageConfigByLevel.HandleId, true, ConfigAbnormalDamageConfigByLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbnormalDamageConfigByLevel.HandleId, ConfigAbnormalDamageConfigByLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbnormalDamageConfigByLevel.HandleId, 0, ConfigAbnormalDamageConfigByLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbnormalDamageConfigByLevel.HandleId, ConfigAbnormalDamageConfigByLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbnormalDamageConfig rootAsAbnormalDamageConfig = AbnormalDamageConfig.GetRootAsAbnormalDamageConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbnormalDamageConfigByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbnormalDamageConfigByLevel.HandleId, ConfigAbnormalDamageConfigByLevel.LogPair);
			return new AbnormalDamageConfig?(rootAsAbnormalDamageConfig);
		}

		// Token: 0x04000023 RID: 35
		private const string DB = "db_abnormaldamage.db";

		// Token: 0x04000024 RID: 36
		private const string FILE = "y.异常伤害.xlsx";

		// Token: 0x04000025 RID: 37
		private const string TABLE = "AbnormalDamageConfig";

		// Token: 0x04000026 RID: 38
		private const string COMMAND = "select BinData from `AbnormalDamageConfig` where Level=?";

		// Token: 0x04000027 RID: 39
		private const string KEY_PREFIX = "AbnormalDamageConfigByLevel";

		// Token: 0x04000028 RID: 40
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000029 RID: 41
		private static int HandleId;
	}
}
