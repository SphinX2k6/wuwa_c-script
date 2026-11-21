using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA1 RID: 2721
	public class ConfigTemplateConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FDA RID: 16346 RVA: 0x001C5D15 File Offset: 0x001C3F15
		static ConfigTemplateConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTemplateConfigById.CreateStaticDefaultValue), new Action(ConfigTemplateConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x001C5D34 File Offset: 0x001C3F34
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

		// Token: 0x06003FDC RID: 16348 RVA: 0x001C5DB3 File Offset: 0x001C3FB3
		public static void ResetStaticDefaultValue()
		{
			ConfigTemplateConfigById.LogPair = null;
			ConfigTemplateConfigById.HandleId = 0;
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x001C5DC1 File Offset: 0x001C3FC1
		public static void Init()
		{
			ConfigTemplateConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTemplateConfigById.HandleId, "db_template.db", "select BinData from `TemplateConfig` where Id=?");
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x001C5DDC File Offset: 0x001C3FDC
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

		// Token: 0x04004A4D RID: 19021
		private const string DB = "db_template.db";

		// Token: 0x04004A4E RID: 19022
		private const string FILE = "UniverseEditor/Entity/Template.csv";

		// Token: 0x04004A4F RID: 19023
		private const string TABLE = "TemplateConfig";

		// Token: 0x04004A50 RID: 19024
		private const string COMMAND = "select BinData from `TemplateConfig` where Id=?";

		// Token: 0x04004A51 RID: 19025
		private const string KEY_PREFIX = "TemplateConfigById";

		// Token: 0x04004A52 RID: 19026
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A53 RID: 19027
		private static int HandleId;
	}
}
