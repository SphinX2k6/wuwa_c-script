using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000290 RID: 656
	public class ConfigEntitySelfEventConfigByKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F65 RID: 3941 RVA: 0x000B4010 File Offset: 0x000B2210
		static ConfigEntitySelfEventConfigByKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntitySelfEventConfigByKey.CreateStaticDefaultValue), new Action(ConfigEntitySelfEventConfigByKey.ResetStaticDefaultValue));
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x000B4030 File Offset: 0x000B2230
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

		// Token: 0x06000F67 RID: 3943 RVA: 0x000B40AF File Offset: 0x000B22AF
		public static void ResetStaticDefaultValue()
		{
			ConfigEntitySelfEventConfigByKey.LogPair = null;
			ConfigEntitySelfEventConfigByKey.HandleId = 0;
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x000B40BD File Offset: 0x000B22BD
		public static void Init()
		{
			ConfigEntitySelfEventConfigByKey.HandleId = ConfigCommon.InitDataStatement(ConfigEntitySelfEventConfigByKey.HandleId, "db_entityselfeventconfig.db", "select BinData from `EntitySelfEventConfig` where Key=?");
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x000B40D8 File Offset: 0x000B22D8
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

		// Token: 0x040011D4 RID: 4564
		private const string DB = "db_entityselfeventconfig.db";

		// Token: 0x040011D5 RID: 4565
		private const string FILE = "k.可视化编辑/c.Csv/s.实体自身事件/*.csv*";

		// Token: 0x040011D6 RID: 4566
		private const string TABLE = "EntitySelfEventConfig";

		// Token: 0x040011D7 RID: 4567
		private const string COMMAND = "select BinData from `EntitySelfEventConfig` where Key=?";

		// Token: 0x040011D8 RID: 4568
		private const string KEY_PREFIX = "EntitySelfEventConfigByKey";

		// Token: 0x040011D9 RID: 4569
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011DA RID: 4570
		private static int HandleId;
	}
}
