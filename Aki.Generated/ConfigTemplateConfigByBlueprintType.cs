using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA0 RID: 2720
	public class ConfigTemplateConfigByBlueprintType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FD4 RID: 16340 RVA: 0x001C5B1B File Offset: 0x001C3D1B
		static ConfigTemplateConfigByBlueprintType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTemplateConfigByBlueprintType.CreateStaticDefaultValue), new Action(ConfigTemplateConfigByBlueprintType.ResetStaticDefaultValue));
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x001C5B3C File Offset: 0x001C3D3C
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

		// Token: 0x06003FD6 RID: 16342 RVA: 0x001C5BBB File Offset: 0x001C3DBB
		public static void ResetStaticDefaultValue()
		{
			ConfigTemplateConfigByBlueprintType.LogPair = null;
			ConfigTemplateConfigByBlueprintType.HandleId = 0;
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x001C5BC9 File Offset: 0x001C3DC9
		public static void Init()
		{
			ConfigTemplateConfigByBlueprintType.HandleId = ConfigCommon.InitDataStatement(ConfigTemplateConfigByBlueprintType.HandleId, "db_template.db", "select BinData from `TemplateConfig` where BlueprintType=?");
		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x001C5BE4 File Offset: 0x001C3DE4
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

		// Token: 0x04004A46 RID: 19014
		private const string DB = "db_template.db";

		// Token: 0x04004A47 RID: 19015
		private const string FILE = "UniverseEditor/Entity/Template.csv";

		// Token: 0x04004A48 RID: 19016
		private const string TABLE = "TemplateConfig";

		// Token: 0x04004A49 RID: 19017
		private const string COMMAND = "select BinData from `TemplateConfig` where BlueprintType=?";

		// Token: 0x04004A4A RID: 19018
		private const string KEY_PREFIX = "TemplateConfigByBlueprintType";

		// Token: 0x04004A4B RID: 19019
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A4C RID: 19020
		private static int HandleId;
	}
}
