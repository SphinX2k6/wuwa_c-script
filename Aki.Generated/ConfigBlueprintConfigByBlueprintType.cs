using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000112 RID: 274
	public class ConfigBlueprintConfigByBlueprintType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600066D RID: 1645 RVA: 0x00081953 File Offset: 0x0007FB53
		static ConfigBlueprintConfigByBlueprintType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlueprintConfigByBlueprintType.CreateStaticDefaultValue), new Action(ConfigBlueprintConfigByBlueprintType.ResetStaticDefaultValue));
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00081974 File Offset: 0x0007FB74
		public static void CreateStaticDefaultValue()
		{
			ConfigBlueprintConfigByBlueprintType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlueprintConfigByBlueprintType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blueprint.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Entity/Blueprint.csv"),
				new ValueTuple<string, object>("表名", "BlueprintConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `BlueprintConfig` where BlueprintType=?")
			});
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x000819F3 File Offset: 0x0007FBF3
		public static void ResetStaticDefaultValue()
		{
			ConfigBlueprintConfigByBlueprintType.LogPair = null;
			ConfigBlueprintConfigByBlueprintType.HandleId = 0;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00081A01 File Offset: 0x0007FC01
		public static void Init()
		{
			ConfigBlueprintConfigByBlueprintType.HandleId = ConfigCommon.InitDataStatement(ConfigBlueprintConfigByBlueprintType.HandleId, "db_blueprint.db", "select BinData from `BlueprintConfig` where BlueprintType=?");
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00081A1C File Offset: 0x0007FC1C
		public static BlueprintConfig? GetConfig(string p0BlueprintType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlueprintConfigByBlueprintType.HandleId, ConfigBlueprintConfigByBlueprintType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("BlueprintConfigByBlueprintType#" + p0BlueprintType);
				if (configBuffer != null)
				{
					return new BlueprintConfig?(BlueprintConfig.GetRootAsBlueprintConfig(configBuffer));
				}
			}
			ConfigBlueprintConfigByBlueprintType.LogPair.Clear();
			ConfigBlueprintConfigByBlueprintType.LogPair.Add(new ValueTuple<string, object>("BlueprintType", p0BlueprintType));
			if (!ConfigCommon.BindString(ConfigBlueprintConfigByBlueprintType.HandleId, 1, p0BlueprintType, ConfigBlueprintConfigByBlueprintType.LogPair) || ConfigCommon.Step(ConfigBlueprintConfigByBlueprintType.HandleId, true, ConfigBlueprintConfigByBlueprintType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBlueprintConfigByBlueprintType.HandleId, ConfigBlueprintConfigByBlueprintType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlueprintConfigByBlueprintType.HandleId, 0, ConfigBlueprintConfigByBlueprintType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBlueprintConfigByBlueprintType.HandleId, ConfigBlueprintConfigByBlueprintType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BlueprintConfig rootAsBlueprintConfig = BlueprintConfig.GetRootAsBlueprintConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("BlueprintConfigByBlueprintType#" + p0BlueprintType, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBlueprintConfigByBlueprintType.HandleId, ConfigBlueprintConfigByBlueprintType.LogPair);
			return new BlueprintConfig?(rootAsBlueprintConfig);
		}

		// Token: 0x04000762 RID: 1890
		private const string DB = "db_blueprint.db";

		// Token: 0x04000763 RID: 1891
		private const string FILE = "UniverseEditor/Entity/Blueprint.csv";

		// Token: 0x04000764 RID: 1892
		private const string TABLE = "BlueprintConfig";

		// Token: 0x04000765 RID: 1893
		private const string COMMAND = "select BinData from `BlueprintConfig` where BlueprintType=?";

		// Token: 0x04000766 RID: 1894
		private const string KEY_PREFIX = "BlueprintConfigByBlueprintType";

		// Token: 0x04000767 RID: 1895
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000768 RID: 1896
		private static int HandleId;
	}
}
