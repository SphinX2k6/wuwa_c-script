using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A68 RID: 2664
	public class ConfigUiFloatConfigByViewNameIfNull : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E84 RID: 16004 RVA: 0x001BB6D9 File Offset: 0x001B98D9
		static ConfigUiFloatConfigByViewNameIfNull()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiFloatConfigByViewNameIfNull.CreateStaticDefaultValue), new Action(ConfigUiFloatConfigByViewNameIfNull.ResetStaticDefaultValue));
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x001BB6F8 File Offset: 0x001B98F8
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

		// Token: 0x06003E86 RID: 16006 RVA: 0x001BB777 File Offset: 0x001B9977
		public static void ResetStaticDefaultValue()
		{
			ConfigUiFloatConfigByViewNameIfNull.LogPair = null;
			ConfigUiFloatConfigByViewNameIfNull.HandleId = 0;
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x001BB785 File Offset: 0x001B9985
		public static void Init()
		{
			ConfigUiFloatConfigByViewNameIfNull.HandleId = ConfigCommon.InitDataStatement(ConfigUiFloatConfigByViewNameIfNull.HandleId, "db_ui.db", "select BinData from `UiFloatConfig` where ViewName = ? AND (SELECT count(0) from `UiFloatConfig` WHERE ViewName = ?) > 0 OR ViewName = \"DefaultView\" AND (SELECT count(0) from `UiFloatConfig` WHERE ViewName = ?) <= 0");
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x001BB7A0 File Offset: 0x001B99A0
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

		// Token: 0x040048BE RID: 18622
		private const string DB = "db_ui.db";

		// Token: 0x040048BF RID: 18623
		private const string FILE = "u.UiFloat层级配置.csv";

		// Token: 0x040048C0 RID: 18624
		private const string TABLE = "UiFloatConfig";

		// Token: 0x040048C1 RID: 18625
		private const string COMMAND = "select BinData from `UiFloatConfig` where ViewName = ? AND (SELECT count(0) from `UiFloatConfig` WHERE ViewName = ?) > 0 OR ViewName = \"DefaultView\" AND (SELECT count(0) from `UiFloatConfig` WHERE ViewName = ?) <= 0";

		// Token: 0x040048C2 RID: 18626
		private const string KEY_PREFIX = "UiFloatConfigByViewNameIfNull";

		// Token: 0x040048C3 RID: 18627
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048C4 RID: 18628
		private static int HandleId;
	}
}
