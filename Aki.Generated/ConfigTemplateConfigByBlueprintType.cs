using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009CB RID: 2507
	public class ConfigTemplateConfigByBlueprintType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AD6 RID: 15062 RVA: 0x001A6787 File Offset: 0x001A4987
		static ConfigTemplateConfigByBlueprintType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTemplateConfigByBlueprintType.CreateStaticDefaultValue), new Action(ConfigTemplateConfigByBlueprintType.ResetStaticDefaultValue));
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x001A67A8 File Offset: 0x001A49A8
		public static void CreateStaticDefaultValue()
		{
			ConfigTemplateConfigByBlueprintType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTemplateConfigByBlueprintType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_template.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Entity/Template.csv"),
				new ValueTuple<string, object>("表名", "TemplateConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TemplateConfig` where BlueprintType=?")
			});
		}

		// Token: 0x06003AD8 RID: 15064 RVA: 0x001A6827 File Offset: 0x001A4A27
		public static void ResetStaticDefaultValue()
		{
			ConfigTemplateConfigByBlueprintType.LogPair = null;
			ConfigTemplateConfigByBlueprintType.HandleId = 0;
		}

		// Token: 0x06003AD9 RID: 15065 RVA: 0x001A6835 File Offset: 0x001A4A35
		public static void Init()
		{
			ConfigTemplateConfigByBlueprintType.HandleId = ConfigCommon.InitDataStatement(ConfigTemplateConfigByBlueprintType.HandleId, "db_template.db", "select BinData from `TemplateConfig` where BlueprintType=?");
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x001A6850 File Offset: 0x001A4A50
		public static TemplateConfig? GetConfig(string p0BlueprintType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTemplateConfigByBlueprintType.HandleId, ConfigTemplateConfigByBlueprintType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("TemplateConfigByBlueprintType#" + p0BlueprintType);
				if (configBuffer != null)
				{
					return new TemplateConfig?(TemplateConfig.GetRootAsTemplateConfig(configBuffer));
				}
			}
			ConfigTemplateConfigByBlueprintType.LogPair.Clear();
			ConfigTemplateConfigByBlueprintType.LogPair.Add(new ValueTuple<string, object>("BlueprintType", p0BlueprintType));
			if (!ConfigCommon.BindString(ConfigTemplateConfigByBlueprintType.HandleId, 1, p0BlueprintType, ConfigTemplateConfigByBlueprintType.LogPair) || ConfigCommon.Step(ConfigTemplateConfigByBlueprintType.HandleId, true, ConfigTemplateConfigByBlueprintType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTemplateConfigByBlueprintType.HandleId, ConfigTemplateConfigByBlueprintType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTemplateConfigByBlueprintType.HandleId, 0, ConfigTemplateConfigByBlueprintType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTemplateConfigByBlueprintType.HandleId, ConfigTemplateConfigByBlueprintType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TemplateConfig rootAsTemplateConfig = TemplateConfig.GetRootAsTemplateConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("TemplateConfigByBlueprintType#" + p0BlueprintType, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTemplateConfigByBlueprintType.HandleId, ConfigTemplateConfigByBlueprintType.LogPair);
			return new TemplateConfig?(rootAsTemplateConfig);
		}

		// Token: 0x04004473 RID: 17523
		private const string DB = "db_template.db";

		// Token: 0x04004474 RID: 17524
		private const string FILE = "UniverseEditor/Entity/Template.csv";

		// Token: 0x04004475 RID: 17525
		private const string TABLE = "TemplateConfig";

		// Token: 0x04004476 RID: 17526
		private const string COMMAND = "select BinData from `TemplateConfig` where BlueprintType=?";

		// Token: 0x04004477 RID: 17527
		private const string KEY_PREFIX = "TemplateConfigByBlueprintType";

		// Token: 0x04004478 RID: 17528
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004479 RID: 17529
		private static int HandleId;
	}
}
