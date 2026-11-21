using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000296 RID: 662
	public class ConfigEntranceIconTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F89 RID: 3977 RVA: 0x000B4CFD File Offset: 0x000B2EFD
		static ConfigEntranceIconTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntranceIconTagById.CreateStaticDefaultValue), new Action(ConfigEntranceIconTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000B4D1C File Offset: 0x000B2F1C
		public static void CreateStaticDefaultValue()
		{
			ConfigEntranceIconTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntranceIconTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_component_config.db"),
				new ValueTuple<string, object>("文件", "t.通用组件配置.xlsx"),
				new ValueTuple<string, object>("表名", "EntranceIconTag"),
				new ValueTuple<string, object>("语句", "select BinData from `EntranceIconTag` where Id=?")
			});
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000B4D9B File Offset: 0x000B2F9B
		public static void ResetStaticDefaultValue()
		{
			ConfigEntranceIconTagById.LogPair = null;
			ConfigEntranceIconTagById.HandleId = 0;
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x000B4DA9 File Offset: 0x000B2FA9
		public static void Init()
		{
			ConfigEntranceIconTagById.HandleId = ConfigCommon.InitDataStatement(ConfigEntranceIconTagById.HandleId, "db_component_config.db", "select BinData from `EntranceIconTag` where Id=?");
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x000B4DC4 File Offset: 0x000B2FC4
		public static EntranceIconTag? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntranceIconTagById.HandleId, ConfigEntranceIconTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("EntranceIconTagById#" + p0Id);
				if (configBuffer != null)
				{
					return new EntranceIconTag?(EntranceIconTag.GetRootAsEntranceIconTag(configBuffer));
				}
			}
			ConfigEntranceIconTagById.LogPair.Clear();
			ConfigEntranceIconTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigEntranceIconTagById.HandleId, 1, p0Id, ConfigEntranceIconTagById.LogPair) || ConfigCommon.Step(ConfigEntranceIconTagById.HandleId, true, ConfigEntranceIconTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEntranceIconTagById.HandleId, ConfigEntranceIconTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntranceIconTagById.HandleId, 0, ConfigEntranceIconTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEntranceIconTagById.HandleId, ConfigEntranceIconTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EntranceIconTag rootAsEntranceIconTag = EntranceIconTag.GetRootAsEntranceIconTag(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("EntranceIconTagById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEntranceIconTagById.HandleId, ConfigEntranceIconTagById.LogPair);
			return new EntranceIconTag?(rootAsEntranceIconTag);
		}

		// Token: 0x040011FE RID: 4606
		private const string DB = "db_component_config.db";

		// Token: 0x040011FF RID: 4607
		private const string FILE = "t.通用组件配置.xlsx";

		// Token: 0x04001200 RID: 4608
		private const string TABLE = "EntranceIconTag";

		// Token: 0x04001201 RID: 4609
		private const string COMMAND = "select BinData from `EntranceIconTag` where Id=?";

		// Token: 0x04001202 RID: 4610
		private const string KEY_PREFIX = "EntranceIconTagById";

		// Token: 0x04001203 RID: 4611
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001204 RID: 4612
		private static int HandleId;
	}
}
