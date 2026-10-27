using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200027C RID: 636
	public class ConfigEntitySelfEventConfigByKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EED RID: 3821 RVA: 0x000ADD4C File Offset: 0x000ABF4C
		static ConfigEntitySelfEventConfigByKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntitySelfEventConfigByKey.CreateStaticDefaultValue), new Action(ConfigEntitySelfEventConfigByKey.ResetStaticDefaultValue));
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x000ADD6C File Offset: 0x000ABF6C
		public static void CreateStaticDefaultValue()
		{
			ConfigEntitySelfEventConfigByKey.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntitySelfEventConfigByKey.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entityselfeventconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/s.实体自身事件/*.csv*"),
				new ValueTuple<string, object>("表名", "EntitySelfEventConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EntitySelfEventConfig` where Key=?")
			});
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x000ADDEB File Offset: 0x000ABFEB
		public static void ResetStaticDefaultValue()
		{
			ConfigEntitySelfEventConfigByKey.LogPair = null;
			ConfigEntitySelfEventConfigByKey.HandleId = 0;
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x000ADDF9 File Offset: 0x000ABFF9
		public static void Init()
		{
			ConfigEntitySelfEventConfigByKey.HandleId = ConfigCommon.InitDataStatement(ConfigEntitySelfEventConfigByKey.HandleId, "db_entityselfeventconfig.db", "select BinData from `EntitySelfEventConfig` where Key=?");
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x000ADE14 File Offset: 0x000AC014
		public static EntitySelfEventConfig? GetConfig(string p0Key, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntitySelfEventConfigByKey.HandleId, ConfigEntitySelfEventConfigByKey.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("EntitySelfEventConfigByKey#" + p0Key);
				if (configBuffer != null)
				{
					return new EntitySelfEventConfig?(EntitySelfEventConfig.GetRootAsEntitySelfEventConfig(configBuffer));
				}
			}
			ConfigEntitySelfEventConfigByKey.LogPair.Clear();
			ConfigEntitySelfEventConfigByKey.LogPair.Add(new ValueTuple<string, object>("Key", p0Key));
			if (!ConfigCommon.BindString(ConfigEntitySelfEventConfigByKey.HandleId, 1, p0Key, ConfigEntitySelfEventConfigByKey.LogPair) || ConfigCommon.Step(ConfigEntitySelfEventConfigByKey.HandleId, true, ConfigEntitySelfEventConfigByKey.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEntitySelfEventConfigByKey.HandleId, ConfigEntitySelfEventConfigByKey.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntitySelfEventConfigByKey.HandleId, 0, ConfigEntitySelfEventConfigByKey.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEntitySelfEventConfigByKey.HandleId, ConfigEntitySelfEventConfigByKey.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EntitySelfEventConfig rootAsEntitySelfEventConfig = EntitySelfEventConfig.GetRootAsEntitySelfEventConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("EntitySelfEventConfigByKey#" + p0Key, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEntitySelfEventConfigByKey.HandleId, ConfigEntitySelfEventConfigByKey.LogPair);
			return new EntitySelfEventConfig?(rootAsEntitySelfEventConfig);
		}

		// Token: 0x04001148 RID: 4424
		private const string DB = "db_entityselfeventconfig.db";

		// Token: 0x04001149 RID: 4425
		private const string FILE = "k.可视化编辑/c.Csv/s.实体自身事件/*.csv*";

		// Token: 0x0400114A RID: 4426
		private const string TABLE = "EntitySelfEventConfig";

		// Token: 0x0400114B RID: 4427
		private const string COMMAND = "select BinData from `EntitySelfEventConfig` where Key=?";

		// Token: 0x0400114C RID: 4428
		private const string KEY_PREFIX = "EntitySelfEventConfigByKey";

		// Token: 0x0400114D RID: 4429
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400114E RID: 4430
		private static int HandleId;
	}
}
