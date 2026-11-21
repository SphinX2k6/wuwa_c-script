using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A92 RID: 2706
	public class ConfigSynthesisLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F80 RID: 16256 RVA: 0x001C3EC0 File Offset: 0x001C20C0
		static ConfigSynthesisLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSynthesisLevelAll.CreateStaticDefaultValue), new Action(ConfigSynthesisLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x001C3EE0 File Offset: 0x001C20E0
		public static void CreateStaticDefaultValue()
		{
			ConfigSynthesisLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSynthesisLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_compose.db"),
				new ValueTuple<string, object>("文件", "h.合成.xlsx"),
				new ValueTuple<string, object>("表名", "SynthesisLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `SynthesisLevel`")
			});
		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x001C3F5F File Offset: 0x001C215F
		public static void ResetStaticDefaultValue()
		{
			ConfigSynthesisLevelAll.LogPair = null;
			ConfigSynthesisLevelAll.HandleId = 0;
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x001C3F6D File Offset: 0x001C216D
		public static void Init()
		{
			ConfigSynthesisLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigSynthesisLevelAll.HandleId, "db_compose.db", "select BinData from `SynthesisLevel`");
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x001C3F88 File Offset: 0x001C2188
		[NullableContext(2)]
		public static IReadOnlyList<SynthesisLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSynthesisLevelAll.HandleId, ConfigSynthesisLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SynthesisLevel> readOnlyList = (IReadOnlyList<SynthesisLevel>)ConfigCommon.GetConfig("SynthesisLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SynthesisLevel> list = new List<SynthesisLevel>();
			while (ConfigCommon.Step(ConfigSynthesisLevelAll.HandleId, false, ConfigSynthesisLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSynthesisLevelAll.HandleId, 0, ConfigSynthesisLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSynthesisLevelAll.HandleId, ConfigSynthesisLevelAll.LogPair);
					return null;
				}
				SynthesisLevel rootAsSynthesisLevel = SynthesisLevel.GetRootAsSynthesisLevel(new ByteBuffer(item2));
				list.Add(rootAsSynthesisLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SynthesisLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSynthesisLevelAll.HandleId, ConfigSynthesisLevelAll.LogPair);
			return list;
		}

		// Token: 0x040049E4 RID: 18916
		private const string DB = "db_compose.db";

		// Token: 0x040049E5 RID: 18917
		private const string FILE = "h.合成.xlsx";

		// Token: 0x040049E6 RID: 18918
		private const string TABLE = "SynthesisLevel";

		// Token: 0x040049E7 RID: 18919
		private const string COMMAND = "select BinData from `SynthesisLevel`";

		// Token: 0x040049E8 RID: 18920
		private const string KEY_PREFIX = "SynthesisLevelAll";

		// Token: 0x040049E9 RID: 18921
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049EA RID: 18922
		private static int HandleId;
	}
}
