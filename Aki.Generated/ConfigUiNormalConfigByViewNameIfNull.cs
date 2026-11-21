using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B3F RID: 2879
	public class ConfigUiNormalConfigByViewNameIfNull : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600438E RID: 17294 RVA: 0x001DAF49 File Offset: 0x001D9149
		static ConfigUiNormalConfigByViewNameIfNull()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiNormalConfigByViewNameIfNull.CreateStaticDefaultValue), new Action(ConfigUiNormalConfigByViewNameIfNull.ResetStaticDefaultValue));
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x001DAF68 File Offset: 0x001D9168
		public static void CreateStaticDefaultValue()
		{
			ConfigUiNormalConfigByViewNameIfNull.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiNormalConfigByViewNameIfNull.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ui.db"),
				new ValueTuple<string, object>("文件", "u.UiNormal层级队列配置.csv"),
				new ValueTuple<string, object>("表名", "UiNormalConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `UiNormalConfig` where ViewName = ? AND (SELECT count(0) from `UiNormalConfig` WHERE ViewName = ?) > 0 OR ViewName = \"DefaultView\" AND (SELECT count(0) from `UiNormalConfig` WHERE ViewName = ?) <= 0")
			});
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x001DAFE7 File Offset: 0x001D91E7
		public static void ResetStaticDefaultValue()
		{
			ConfigUiNormalConfigByViewNameIfNull.LogPair = null;
			ConfigUiNormalConfigByViewNameIfNull.HandleId = 0;
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x001DAFF5 File Offset: 0x001D91F5
		public static void Init()
		{
			ConfigUiNormalConfigByViewNameIfNull.HandleId = ConfigCommon.InitDataStatement(ConfigUiNormalConfigByViewNameIfNull.HandleId, "db_ui.db", "select BinData from `UiNormalConfig` where ViewName = ? AND (SELECT count(0) from `UiNormalConfig` WHERE ViewName = ?) > 0 OR ViewName = \"DefaultView\" AND (SELECT count(0) from `UiNormalConfig` WHERE ViewName = ?) <= 0");
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x001DB010 File Offset: 0x001D9210
		public static UiNormalConfig? GetConfig(string p0ViewName, string p1ViewName, string p2ViewName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiNormalConfigByViewNameIfNull.HandleId, ConfigUiNormalConfigByViewNameIfNull.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("UiNormalConfigByViewNameIfNull");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0ViewName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1ViewName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p2ViewName);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new UiNormalConfig?(UiNormalConfig.GetRootAsUiNormalConfig(configBuffer));
				}
			}
			ConfigUiNormalConfigByViewNameIfNull.LogPair.Clear();
			ConfigUiNormalConfigByViewNameIfNull.LogPair.Add(new ValueTuple<string, object>("ViewName", p0ViewName));
			ConfigUiNormalConfigByViewNameIfNull.LogPair.Add(new ValueTuple<string, object>("ViewName", p1ViewName));
			ConfigUiNormalConfigByViewNameIfNull.LogPair.Add(new ValueTuple<string, object>("ViewName", p2ViewName));
			if (!ConfigCommon.BindString(ConfigUiNormalConfigByViewNameIfNull.HandleId, 1, p0ViewName, ConfigUiNormalConfigByViewNameIfNull.LogPair) || !ConfigCommon.BindString(ConfigUiNormalConfigByViewNameIfNull.HandleId, 2, p1ViewName, ConfigUiNormalConfigByViewNameIfNull.LogPair) || !ConfigCommon.BindString(ConfigUiNormalConfigByViewNameIfNull.HandleId, 3, p2ViewName, ConfigUiNormalConfigByViewNameIfNull.LogPair) || ConfigCommon.Step(ConfigUiNormalConfigByViewNameIfNull.HandleId, true, ConfigUiNormalConfigByViewNameIfNull.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigUiNormalConfigByViewNameIfNull.HandleId, ConfigUiNormalConfigByViewNameIfNull.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiNormalConfigByViewNameIfNull.HandleId, 0, ConfigUiNormalConfigByViewNameIfNull.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigUiNormalConfigByViewNameIfNull.HandleId, ConfigUiNormalConfigByViewNameIfNull.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			UiNormalConfig rootAsUiNormalConfig = UiNormalConfig.GetRootAsUiNormalConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("UiNormalConfigByViewNameIfNull");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0ViewName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1ViewName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p2ViewName);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigUiNormalConfigByViewNameIfNull.HandleId, ConfigUiNormalConfigByViewNameIfNull.LogPair);
			return new UiNormalConfig?(rootAsUiNormalConfig);
		}

		// Token: 0x04004E9F RID: 20127
		private const string DB = "db_ui.db";

		// Token: 0x04004EA0 RID: 20128
		private const string FILE = "u.UiNormal层级队列配置.csv";

		// Token: 0x04004EA1 RID: 20129
		private const string TABLE = "UiNormalConfig";

		// Token: 0x04004EA2 RID: 20130
		private const string COMMAND = "select BinData from `UiNormalConfig` where ViewName = ? AND (SELECT count(0) from `UiNormalConfig` WHERE ViewName = ?) > 0 OR ViewName = \"DefaultView\" AND (SELECT count(0) from `UiNormalConfig` WHERE ViewName = ?) <= 0";

		// Token: 0x04004EA3 RID: 20131
		private const string KEY_PREFIX = "UiNormalConfigByViewNameIfNull";

		// Token: 0x04004EA4 RID: 20132
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004EA5 RID: 20133
		private static int HandleId;
	}
}
