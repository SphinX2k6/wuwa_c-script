using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A6A RID: 2666
	public class ConfigUiNormalConfigByViewNameIfNull : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E90 RID: 16016 RVA: 0x001BBBB5 File Offset: 0x001B9DB5
		static ConfigUiNormalConfigByViewNameIfNull()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiNormalConfigByViewNameIfNull.CreateStaticDefaultValue), new Action(ConfigUiNormalConfigByViewNameIfNull.ResetStaticDefaultValue));
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x001BBBD4 File Offset: 0x001B9DD4
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

		// Token: 0x06003E92 RID: 16018 RVA: 0x001BBC53 File Offset: 0x001B9E53
		public static void ResetStaticDefaultValue()
		{
			ConfigUiNormalConfigByViewNameIfNull.LogPair = null;
			ConfigUiNormalConfigByViewNameIfNull.HandleId = 0;
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x001BBC61 File Offset: 0x001B9E61
		public static void Init()
		{
			ConfigUiNormalConfigByViewNameIfNull.HandleId = ConfigCommon.InitDataStatement(ConfigUiNormalConfigByViewNameIfNull.HandleId, "db_ui.db", "select BinData from `UiNormalConfig` where ViewName = ? AND (SELECT count(0) from `UiNormalConfig` WHERE ViewName = ?) > 0 OR ViewName = \"DefaultView\" AND (SELECT count(0) from `UiNormalConfig` WHERE ViewName = ?) <= 0");
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x001BBC7C File Offset: 0x001B9E7C
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

		// Token: 0x040048CC RID: 18636
		private const string DB = "db_ui.db";

		// Token: 0x040048CD RID: 18637
		private const string FILE = "u.UiNormal层级队列配置.csv";

		// Token: 0x040048CE RID: 18638
		private const string TABLE = "UiNormalConfig";

		// Token: 0x040048CF RID: 18639
		private const string COMMAND = "select BinData from `UiNormalConfig` where ViewName = ? AND (SELECT count(0) from `UiNormalConfig` WHERE ViewName = ?) > 0 OR ViewName = \"DefaultView\" AND (SELECT count(0) from `UiNormalConfig` WHERE ViewName = ?) <= 0";

		// Token: 0x040048D0 RID: 18640
		private const string KEY_PREFIX = "UiNormalConfigByViewNameIfNull";

		// Token: 0x040048D1 RID: 18641
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048D2 RID: 18642
		private static int HandleId;
	}
}
