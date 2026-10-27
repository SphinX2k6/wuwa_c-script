using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009CC RID: 2508
	public class ConfigTemplateConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003ADC RID: 15068 RVA: 0x001A6981 File Offset: 0x001A4B81
		static ConfigTemplateConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTemplateConfigById.CreateStaticDefaultValue), new Action(ConfigTemplateConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x001A69A0 File Offset: 0x001A4BA0
		public static void CreateStaticDefaultValue()
		{
			ConfigTemplateConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTemplateConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_template.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Entity/Template.csv"),
				new ValueTuple<string, object>("表名", "TemplateConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TemplateConfig` where Id=?")
			});
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x001A6A1F File Offset: 0x001A4C1F
		public static void ResetStaticDefaultValue()
		{
			ConfigTemplateConfigById.LogPair = null;
			ConfigTemplateConfigById.HandleId = 0;
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x001A6A2D File Offset: 0x001A4C2D
		public static void Init()
		{
			ConfigTemplateConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTemplateConfigById.HandleId, "db_template.db", "select BinData from `TemplateConfig` where Id=?");
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x001A6A48 File Offset: 0x001A4C48
		public static TemplateConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTemplateConfigById.HandleId, ConfigTemplateConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TemplateConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TemplateConfig?(TemplateConfig.GetRootAsTemplateConfig(configBuffer));
				}
			}
			ConfigTemplateConfigById.LogPair.Clear();
			ConfigTemplateConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTemplateConfigById.HandleId, 1, p0Id, ConfigTemplateConfigById.LogPair) || ConfigCommon.Step(ConfigTemplateConfigById.HandleId, true, ConfigTemplateConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTemplateConfigById.HandleId, ConfigTemplateConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTemplateConfigById.HandleId, 0, ConfigTemplateConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTemplateConfigById.HandleId, ConfigTemplateConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TemplateConfig rootAsTemplateConfig = TemplateConfig.GetRootAsTemplateConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TemplateConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTemplateConfigById.HandleId, ConfigTemplateConfigById.LogPair);
			return new TemplateConfig?(rootAsTemplateConfig);
		}

		// Token: 0x0400447A RID: 17530
		private const string DB = "db_template.db";

		// Token: 0x0400447B RID: 17531
		private const string FILE = "UniverseEditor/Entity/Template.csv";

		// Token: 0x0400447C RID: 17532
		private const string TABLE = "TemplateConfig";

		// Token: 0x0400447D RID: 17533
		private const string COMMAND = "select BinData from `TemplateConfig` where Id=?";

		// Token: 0x0400447E RID: 17534
		private const string KEY_PREFIX = "TemplateConfigById";

		// Token: 0x0400447F RID: 17535
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004480 RID: 17536
		private static int HandleId;
	}
}
