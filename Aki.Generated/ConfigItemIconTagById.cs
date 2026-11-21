using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000472 RID: 1138
	public class ConfigItemIconTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AB6 RID: 6838 RVA: 0x000F3FC4 File Offset: 0x000F21C4
		static ConfigItemIconTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemIconTagById.CreateStaticDefaultValue), new Action(ConfigItemIconTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x000F3FE4 File Offset: 0x000F21E4
		public static void CreateStaticDefaultValue()
		{
			ConfigItemIconTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemIconTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_component_config.db"),
				new ValueTuple<string, object>("文件", "t.通用组件配置.xlsx"),
				new ValueTuple<string, object>("表名", "ItemIconTag"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemIconTag` where Id=?")
			});
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x000F4063 File Offset: 0x000F2263
		public static void ResetStaticDefaultValue()
		{
			ConfigItemIconTagById.LogPair = null;
			ConfigItemIconTagById.HandleId = 0;
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x000F4071 File Offset: 0x000F2271
		public static void Init()
		{
			ConfigItemIconTagById.HandleId = ConfigCommon.InitDataStatement(ConfigItemIconTagById.HandleId, "db_component_config.db", "select BinData from `ItemIconTag` where Id=?");
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x000F408C File Offset: 0x000F228C
		public static ItemIconTag? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemIconTagById.HandleId, ConfigItemIconTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("ItemIconTagById#" + p0Id);
				if (configBuffer != null)
				{
					return new ItemIconTag?(ItemIconTag.GetRootAsItemIconTag(configBuffer));
				}
			}
			ConfigItemIconTagById.LogPair.Clear();
			ConfigItemIconTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigItemIconTagById.HandleId, 1, p0Id, ConfigItemIconTagById.LogPair) || ConfigCommon.Step(ConfigItemIconTagById.HandleId, true, ConfigItemIconTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigItemIconTagById.HandleId, ConfigItemIconTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemIconTagById.HandleId, 0, ConfigItemIconTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigItemIconTagById.HandleId, ConfigItemIconTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ItemIconTag rootAsItemIconTag = ItemIconTag.GetRootAsItemIconTag(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("ItemIconTagById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigItemIconTagById.HandleId, ConfigItemIconTagById.LogPair);
			return new ItemIconTag?(rootAsItemIconTag);
		}

		// Token: 0x04001F02 RID: 7938
		private const string DB = "db_component_config.db";

		// Token: 0x04001F03 RID: 7939
		private const string FILE = "t.通用组件配置.xlsx";

		// Token: 0x04001F04 RID: 7940
		private const string TABLE = "ItemIconTag";

		// Token: 0x04001F05 RID: 7941
		private const string COMMAND = "select BinData from `ItemIconTag` where Id=?";

		// Token: 0x04001F06 RID: 7942
		private const string KEY_PREFIX = "ItemIconTagById";

		// Token: 0x04001F07 RID: 7943
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F08 RID: 7944
		private static int HandleId;
	}
}
