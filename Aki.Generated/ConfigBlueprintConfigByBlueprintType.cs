using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000103 RID: 259
	public class ConfigBlueprintConfigByBlueprintType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000613 RID: 1555 RVA: 0x0007BFEF File Offset: 0x0007A1EF
		static ConfigBlueprintConfigByBlueprintType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlueprintConfigByBlueprintType.CreateStaticDefaultValue), new Action(ConfigBlueprintConfigByBlueprintType.ResetStaticDefaultValue));
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0007C010 File Offset: 0x0007A210
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

		// Token: 0x06000615 RID: 1557 RVA: 0x0007C08F File Offset: 0x0007A28F
		public static void ResetStaticDefaultValue()
		{
			ConfigBlueprintConfigByBlueprintType.LogPair = null;
			ConfigBlueprintConfigByBlueprintType.HandleId = 0;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0007C09D File Offset: 0x0007A29D
		public static void Init()
		{
			ConfigBlueprintConfigByBlueprintType.HandleId = ConfigCommon.InitDataStatement(ConfigBlueprintConfigByBlueprintType.HandleId, "db_blueprint.db", "select BinData from `BlueprintConfig` where BlueprintType=?");
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0007C0B8 File Offset: 0x0007A2B8
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

		// Token: 0x040006F9 RID: 1785
		private const string DB = "db_blueprint.db";

		// Token: 0x040006FA RID: 1786
		private const string FILE = "UniverseEditor/Entity/Blueprint.csv";

		// Token: 0x040006FB RID: 1787
		private const string TABLE = "BlueprintConfig";

		// Token: 0x040006FC RID: 1788
		private const string COMMAND = "select BinData from `BlueprintConfig` where BlueprintType=?";

		// Token: 0x040006FD RID: 1789
		private const string KEY_PREFIX = "BlueprintConfigByBlueprintType";

		// Token: 0x040006FE RID: 1790
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006FF RID: 1791
		private static int HandleId;
	}
}
