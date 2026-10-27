using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000282 RID: 642
	public class ConfigEntranceIconTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F11 RID: 3857 RVA: 0x000AEA39 File Offset: 0x000ACC39
		static ConfigEntranceIconTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntranceIconTagById.CreateStaticDefaultValue), new Action(ConfigEntranceIconTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x000AEA58 File Offset: 0x000ACC58
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

		// Token: 0x06000F13 RID: 3859 RVA: 0x000AEAD7 File Offset: 0x000ACCD7
		public static void ResetStaticDefaultValue()
		{
			ConfigEntranceIconTagById.LogPair = null;
			ConfigEntranceIconTagById.HandleId = 0;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x000AEAE5 File Offset: 0x000ACCE5
		public static void Init()
		{
			ConfigEntranceIconTagById.HandleId = ConfigCommon.InitDataStatement(ConfigEntranceIconTagById.HandleId, "db_component_config.db", "select BinData from `EntranceIconTag` where Id=?");
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x000AEB00 File Offset: 0x000ACD00
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

		// Token: 0x04001172 RID: 4466
		private const string DB = "db_component_config.db";

		// Token: 0x04001173 RID: 4467
		private const string FILE = "t.通用组件配置.xlsx";

		// Token: 0x04001174 RID: 4468
		private const string TABLE = "EntranceIconTag";

		// Token: 0x04001175 RID: 4469
		private const string COMMAND = "select BinData from `EntranceIconTag` where Id=?";

		// Token: 0x04001176 RID: 4470
		private const string KEY_PREFIX = "EntranceIconTagById";

		// Token: 0x04001177 RID: 4471
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001178 RID: 4472
		private static int HandleId;
	}
}
