using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B3D RID: 2877
	public class ConfigUiFloatConfigByViewNameIfNull : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004382 RID: 17282 RVA: 0x001DAA6D File Offset: 0x001D8C6D
		static ConfigUiFloatConfigByViewNameIfNull()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiFloatConfigByViewNameIfNull.CreateStaticDefaultValue), new Action(ConfigUiFloatConfigByViewNameIfNull.ResetStaticDefaultValue));
		}

		// Token: 0x06004383 RID: 17283 RVA: 0x001DAA8C File Offset: 0x001D8C8C
		public static void CreateStaticDefaultValue()
		{
			ConfigUiFloatConfigByViewNameIfNull.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiFloatConfigByViewNameIfNull.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ui.db"),
				new ValueTuple<string, object>("文件", "u.UiFloat层级配置.csv"),
				new ValueTuple<string, object>("表名", "UiFloatConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `UiFloatConfig` where ViewName = ? AND (SELECT count(0) from `UiFloatConfig` WHERE ViewName = ?) > 0 OR ViewName = \"DefaultView\" AND (SELECT count(0) from `UiFloatConfig` WHERE ViewName = ?) <= 0")
			});
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x001DAB0B File Offset: 0x001D8D0B
		public static void ResetStaticDefaultValue()
		{
			ConfigUiFloatConfigByViewNameIfNull.LogPair = null;
			ConfigUiFloatConfigByViewNameIfNull.HandleId = 0;
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x001DAB19 File Offset: 0x001D8D19
		public static void Init()
		{
			ConfigUiFloatConfigByViewNameIfNull.HandleId = ConfigCommon.InitDataStatement(ConfigUiFloatConfigByViewNameIfNull.HandleId, "db_ui.db", "select BinData from `UiFloatConfig` where ViewName = ? AND (SELECT count(0) from `UiFloatConfig` WHERE ViewName = ?) > 0 OR ViewName = \"DefaultView\" AND (SELECT count(0) from `UiFloatConfig` WHERE ViewName = ?) <= 0");
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x001DAB34 File Offset: 0x001D8D34
		public static UiFloatConfig? GetConfig(string p0ViewName, string p1ViewName, string p2ViewName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiFloatConfigByViewNameIfNull.HandleId, ConfigUiFloatConfigByViewNameIfNull.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("UiFloatConfigByViewNameIfNull");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0ViewName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1ViewName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p2ViewName);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new UiFloatConfig?(UiFloatConfig.GetRootAsUiFloatConfig(configBuffer));
				}
			}
			ConfigUiFloatConfigByViewNameIfNull.LogPair.Clear();
			ConfigUiFloatConfigByViewNameIfNull.LogPair.Add(new ValueTuple<string, object>("ViewName", p0ViewName));
			ConfigUiFloatConfigByViewNameIfNull.LogPair.Add(new ValueTuple<string, object>("ViewName", p1ViewName));
			ConfigUiFloatConfigByViewNameIfNull.LogPair.Add(new ValueTuple<string, object>("ViewName", p2ViewName));
			if (!ConfigCommon.BindString(ConfigUiFloatConfigByViewNameIfNull.HandleId, 1, p0ViewName, ConfigUiFloatConfigByViewNameIfNull.LogPair) || !ConfigCommon.BindString(ConfigUiFloatConfigByViewNameIfNull.HandleId, 2, p1ViewName, ConfigUiFloatConfigByViewNameIfNull.LogPair) || !ConfigCommon.BindString(ConfigUiFloatConfigByViewNameIfNull.HandleId, 3, p2ViewName, ConfigUiFloatConfigByViewNameIfNull.LogPair) || ConfigCommon.Step(ConfigUiFloatConfigByViewNameIfNull.HandleId, true, ConfigUiFloatConfigByViewNameIfNull.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigUiFloatConfigByViewNameIfNull.HandleId, ConfigUiFloatConfigByViewNameIfNull.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiFloatConfigByViewNameIfNull.HandleId, 0, ConfigUiFloatConfigByViewNameIfNull.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigUiFloatConfigByViewNameIfNull.HandleId, ConfigUiFloatConfigByViewNameIfNull.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			UiFloatConfig rootAsUiFloatConfig = UiFloatConfig.GetRootAsUiFloatConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("UiFloatConfigByViewNameIfNull");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0ViewName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1ViewName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p2ViewName);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigUiFloatConfigByViewNameIfNull.HandleId, ConfigUiFloatConfigByViewNameIfNull.LogPair);
			return new UiFloatConfig?(rootAsUiFloatConfig);
		}

		// Token: 0x04004E91 RID: 20113
		private const string DB = "db_ui.db";

		// Token: 0x04004E92 RID: 20114
		private const string FILE = "u.UiFloat层级配置.csv";

		// Token: 0x04004E93 RID: 20115
		private const string TABLE = "UiFloatConfig";

		// Token: 0x04004E94 RID: 20116
		private const string COMMAND = "select BinData from `UiFloatConfig` where ViewName = ? AND (SELECT count(0) from `UiFloatConfig` WHERE ViewName = ?) > 0 OR ViewName = \"DefaultView\" AND (SELECT count(0) from `UiFloatConfig` WHERE ViewName = ?) <= 0";

		// Token: 0x04004E95 RID: 20117
		private const string KEY_PREFIX = "UiFloatConfigByViewNameIfNull";

		// Token: 0x04004E96 RID: 20118
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E97 RID: 20119
		private static int HandleId;
	}
}
