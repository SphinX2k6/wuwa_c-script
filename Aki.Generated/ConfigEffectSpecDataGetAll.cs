using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200026F RID: 623
	public class ConfigEffectSpecDataGetAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E9E RID: 3742 RVA: 0x000AFA78 File Offset: 0x000ADC78
		static ConfigEffectSpecDataGetAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEffectSpecDataGetAll.CreateStaticDefaultValue), new Action(ConfigEffectSpecDataGetAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x000AFA98 File Offset: 0x000ADC98
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

		// Token: 0x06000EA0 RID: 3744 RVA: 0x000AFB17 File Offset: 0x000ADD17
		public static void ResetStaticDefaultValue()
		{
			ConfigEffectSpecDataGetAll.LogPair = null;
			ConfigEffectSpecDataGetAll.HandleId = 0;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x000AFB25 File Offset: 0x000ADD25
		public static void Init()
		{
			ConfigEffectSpecDataGetAll.HandleId = ConfigCommon.InitDataStatement(ConfigEffectSpecDataGetAll.HandleId, "db_effectspec.db", "select BinData from `EffectSpecData`");
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x000AFB40 File Offset: 0x000ADD40
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

		// Token: 0x040010ED RID: 4333
		private const string DB = "db_effectspec.db";

		// Token: 0x040010EE RID: 4334
		private const string FILE = "UniverseEditor/EffectSpec.csv";

		// Token: 0x040010EF RID: 4335
		private const string TABLE = "EffectSpecData";

		// Token: 0x040010F0 RID: 4336
		private const string COMMAND = "select BinData from `EffectSpecData`";

		// Token: 0x040010F1 RID: 4337
		private const string KEY_PREFIX = "EffectSpecDataGetAll";

		// Token: 0x040010F2 RID: 4338
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010F3 RID: 4339
		private static int HandleId;
	}
}
