using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200045C RID: 1116
	public class ConfigItemIconTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A32 RID: 6706 RVA: 0x000ED870 File Offset: 0x000EBA70
		static ConfigItemIconTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemIconTagById.CreateStaticDefaultValue), new Action(ConfigItemIconTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x000ED890 File Offset: 0x000EBA90
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

		// Token: 0x06001A34 RID: 6708 RVA: 0x000ED90F File Offset: 0x000EBB0F
		public static void ResetStaticDefaultValue()
		{
			ConfigItemIconTagById.LogPair = null;
			ConfigItemIconTagById.HandleId = 0;
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x000ED91D File Offset: 0x000EBB1D
		public static void Init()
		{
			ConfigItemIconTagById.HandleId = ConfigCommon.InitDataStatement(ConfigItemIconTagById.HandleId, "db_component_config.db", "select BinData from `ItemIconTag` where Id=?");
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x000ED938 File Offset: 0x000EBB38
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

		// Token: 0x04001E68 RID: 7784
		private const string DB = "db_component_config.db";

		// Token: 0x04001E69 RID: 7785
		private const string FILE = "t.通用组件配置.xlsx";

		// Token: 0x04001E6A RID: 7786
		private const string TABLE = "ItemIconTag";

		// Token: 0x04001E6B RID: 7787
		private const string COMMAND = "select BinData from `ItemIconTag` where Id=?";

		// Token: 0x04001E6C RID: 7788
		private const string KEY_PREFIX = "ItemIconTagById";

		// Token: 0x04001E6D RID: 7789
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E6E RID: 7790
		private static int HandleId;
	}
}
