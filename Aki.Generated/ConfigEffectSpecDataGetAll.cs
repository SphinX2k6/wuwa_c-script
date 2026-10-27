using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200025B RID: 603
	public class ConfigEffectSpecDataGetAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E26 RID: 3622 RVA: 0x000A97B4 File Offset: 0x000A79B4
		static ConfigEffectSpecDataGetAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEffectSpecDataGetAll.CreateStaticDefaultValue), new Action(ConfigEffectSpecDataGetAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x000A97D4 File Offset: 0x000A79D4
		public static void CreateStaticDefaultValue()
		{
			ConfigEffectSpecDataGetAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEffectSpecDataGetAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_effectspec.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/EffectSpec.csv"),
				new ValueTuple<string, object>("表名", "EffectSpecData"),
				new ValueTuple<string, object>("语句", "select BinData from `EffectSpecData`")
			});
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x000A9853 File Offset: 0x000A7A53
		public static void ResetStaticDefaultValue()
		{
			ConfigEffectSpecDataGetAll.LogPair = null;
			ConfigEffectSpecDataGetAll.HandleId = 0;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x000A9861 File Offset: 0x000A7A61
		public static void Init()
		{
			ConfigEffectSpecDataGetAll.HandleId = ConfigCommon.InitDataStatement(ConfigEffectSpecDataGetAll.HandleId, "db_effectspec.db", "select BinData from `EffectSpecData`");
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x000A987C File Offset: 0x000A7A7C
		[NullableContext(2)]
		public static IReadOnlyList<EffectSpecData> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEffectSpecDataGetAll.HandleId, ConfigEffectSpecDataGetAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<EffectSpecData> readOnlyList = (IReadOnlyList<EffectSpecData>)ConfigCommon.GetConfig("EffectSpecDataGetAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<EffectSpecData> list = new List<EffectSpecData>();
			while (ConfigCommon.Step(ConfigEffectSpecDataGetAll.HandleId, false, ConfigEffectSpecDataGetAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEffectSpecDataGetAll.HandleId, 0, ConfigEffectSpecDataGetAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEffectSpecDataGetAll.HandleId, ConfigEffectSpecDataGetAll.LogPair);
					return null;
				}
				EffectSpecData rootAsEffectSpecData = EffectSpecData.GetRootAsEffectSpecData(new ByteBuffer(item2));
				list.Add(rootAsEffectSpecData);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("EffectSpecDataGetAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigEffectSpecDataGetAll.HandleId, ConfigEffectSpecDataGetAll.LogPair);
			return list;
		}

		// Token: 0x04001061 RID: 4193
		private const string DB = "db_effectspec.db";

		// Token: 0x04001062 RID: 4194
		private const string FILE = "UniverseEditor/EffectSpec.csv";

		// Token: 0x04001063 RID: 4195
		private const string TABLE = "EffectSpecData";

		// Token: 0x04001064 RID: 4196
		private const string COMMAND = "select BinData from `EffectSpecData`";

		// Token: 0x04001065 RID: 4197
		private const string KEY_PREFIX = "EffectSpecDataGetAll";

		// Token: 0x04001066 RID: 4198
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001067 RID: 4199
		private static int HandleId;
	}
}
