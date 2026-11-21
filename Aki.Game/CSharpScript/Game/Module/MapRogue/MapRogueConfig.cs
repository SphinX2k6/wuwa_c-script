using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004570 RID: 17776
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MapRogueConfig : ConfigBase
	{
		// Token: 0x0602CCBC RID: 183484 RVA: 0x00C8AA89 File Offset: 0x00C88C89
		public RogueResGridMapType? GetGridMapTypeConfigById(int typeId)
		{
			return ConfigRogueResGridMapTypeById.GetConfig(typeId, true);
		}

		// Token: 0x0602CCBD RID: 183485 RVA: 0x00C8AA92 File Offset: 0x00C88C92
		public RogueResGridEvent? GetGridEventConfigById(int id)
		{
			return ConfigRogueResGridEventById.GetConfig(id, true);
		}

		// Token: 0x0602CCBE RID: 183486 RVA: 0x00C8AA9B File Offset: 0x00C88C9B
		public RogueResInstGrid? GetInsGridConfigByInstId(int instId)
		{
			return ConfigRogueResInstGridById.GetConfig(instId, true);
		}

		// Token: 0x0602CCBF RID: 183487 RVA: 0x00C8AAA4 File Offset: 0x00C88CA4
		public RogueResEventCue? GetRogueResEventCueByType(string type)
		{
			return ConfigRogueResEventCueByType.GetConfig(type, true);
		}

		// Token: 0x0602CCC0 RID: 183488 RVA: 0x00C8AAAD File Offset: 0x00C88CAD
		public RogueResEffect? GetRogueEffectById(int id)
		{
			return ConfigRogueResEffectById.GetConfig(id, true);
		}

		// Token: 0x0602CCC1 RID: 183489 RVA: 0x00C8AAB6 File Offset: 0x00C88CB6
		public RogueResEffectTag? GetRogueEffectTagById(int id)
		{
			return ConfigRogueResEffectTagById.GetConfig(id, true);
		}

		// Token: 0x0602CCC2 RID: 183490 RVA: 0x00C8AABF File Offset: 0x00C88CBF
		public RogueResEventStep? GetRogueEventStepById(int id)
		{
			return ConfigRogueResEventStepById.GetConfig(id, true);
		}

		// Token: 0x0602CCC3 RID: 183491 RVA: 0x00C8AAC8 File Offset: 0x00C88CC8
		public RogueResEventPlot? GetRogueEventPlotById(int plotId)
		{
			return ConfigRogueResEventPlotByPlotId.GetConfig(plotId, true);
		}

		// Token: 0x0602CCC4 RID: 183492 RVA: 0x00C8AAD1 File Offset: 0x00C88CD1
		public RogueResMoodRule? GetMoodRuleById(int id)
		{
			return ConfigRogueResMoodRuleById.GetConfig(id, true);
		}

		// Token: 0x0602CCC5 RID: 183493 RVA: 0x00C8AADA File Offset: 0x00C88CDA
		public RogueResEventBg? GetEventBgById(int id)
		{
			return ConfigRogueResEventBgById.GetConfig(id, true);
		}

		// Token: 0x0602CCC6 RID: 183494 RVA: 0x00C8AAE3 File Offset: 0x00C88CE3
		public RogueResEventBgm? GetEventBgmById(int id)
		{
			return ConfigRogueResEventBgmById.GetConfig(id, true);
		}

		// Token: 0x0602CCC7 RID: 183495 RVA: 0x00C8AAEC File Offset: 0x00C88CEC
		public RogueResGridExplore? GetExploreByInstId(int instId)
		{
			return ConfigRogueResGridExploreByInstId.GetConfig(instId, true);
		}

		// Token: 0x0602CCC8 RID: 183496 RVA: 0x00C8AAF8 File Offset: 0x00C88CF8
		public RogueResGlobalParam? GetGlobalParamConfig()
		{
			IReadOnlyList<RogueResGlobalParam> configList = ConfigRogueResGlobalParamAll.GetConfigList(true);
			if (configList != null && configList.Count > 0)
			{
				return new RogueResGlobalParam?(configList[0]);
			}
			return null;
		}

		// Token: 0x17005A44 RID: 23108
		// (get) Token: 0x0602CCC9 RID: 183497 RVA: 0x00C8AB2E File Offset: 0x00C88D2E
		public static MapRogueConfig Instance
		{
			get
			{
				return MapRogueConfig._Instance;
			}
		}

		// Token: 0x0602CCCA RID: 183498 RVA: 0x00C8AB35 File Offset: 0x00C88D35
		public static MapRogueConfig GetOrCreateInstance()
		{
			if (MapRogueConfig._Instance == null)
			{
				MapRogueConfig.CreateInstance();
			}
			return MapRogueConfig._Instance;
		}

		// Token: 0x0602CCCB RID: 183499 RVA: 0x00C8AB49 File Offset: 0x00C88D49
		public static bool CreateInstance()
		{
			if (MapRogueConfig._Instance != null)
			{
				return true;
			}
			MapRogueConfig._Instance = new MapRogueConfig();
			return true;
		}

		// Token: 0x0602CCCC RID: 183500 RVA: 0x00C8AB5F File Offset: 0x00C88D5F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602CCCD RID: 183501 RVA: 0x00C8AB61 File Offset: 0x00C88D61
		public static void ResetStaticDefaultValue()
		{
			MapRogueConfig._Instance = null;
		}

		// Token: 0x0602CCCE RID: 183502 RVA: 0x00C8AB69 File Offset: 0x00C88D69
		static MapRogueConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MapRogueConfig.CreateStaticDefaultValue), new Action(MapRogueConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401800D RID: 98317
		[Nullable(2)]
		private static MapRogueConfig _Instance;
	}
}
