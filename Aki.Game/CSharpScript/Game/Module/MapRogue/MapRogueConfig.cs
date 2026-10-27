using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200559A RID: 21914
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MapRogueConfig : ConfigBase
	{
		// Token: 0x06037DBE RID: 228798 RVA: 0x00D3CD41 File Offset: 0x00D3AF41
		public RogueResGridMapType? GetGridMapTypeConfigById(int typeId)
		{
			return ConfigRogueResGridMapTypeById.GetConfig(typeId, true);
		}

		// Token: 0x06037DBF RID: 228799 RVA: 0x00D3CD4A File Offset: 0x00D3AF4A
		public RogueResGridEvent? GetGridEventConfigById(int id)
		{
			return ConfigRogueResGridEventById.GetConfig(id, true);
		}

		// Token: 0x06037DC0 RID: 228800 RVA: 0x00D3CD53 File Offset: 0x00D3AF53
		public RogueResInstGrid? GetInsGridConfigByInstId(int instId)
		{
			return ConfigRogueResInstGridById.GetConfig(instId, true);
		}

		// Token: 0x06037DC1 RID: 228801 RVA: 0x00D3CD5C File Offset: 0x00D3AF5C
		public RogueResEventCue? GetRogueResEventCueByType(string type)
		{
			return ConfigRogueResEventCueByType.GetConfig(type, true);
		}

		// Token: 0x06037DC2 RID: 228802 RVA: 0x00D3CD65 File Offset: 0x00D3AF65
		public RogueResEffect? GetRogueEffectById(int id)
		{
			return ConfigRogueResEffectById.GetConfig(id, true);
		}

		// Token: 0x06037DC3 RID: 228803 RVA: 0x00D3CD6E File Offset: 0x00D3AF6E
		public RogueResEffectTag? GetRogueEffectTagById(int id)
		{
			return ConfigRogueResEffectTagById.GetConfig(id, true);
		}

		// Token: 0x06037DC4 RID: 228804 RVA: 0x00D3CD77 File Offset: 0x00D3AF77
		public RogueResEventStep? GetRogueEventStepById(int id)
		{
			return ConfigRogueResEventStepById.GetConfig(id, true);
		}

		// Token: 0x06037DC5 RID: 228805 RVA: 0x00D3CD80 File Offset: 0x00D3AF80
		public RogueResEventPlot? GetRogueEventPlotById(int plotId)
		{
			return ConfigRogueResEventPlotByPlotId.GetConfig(plotId, true);
		}

		// Token: 0x06037DC6 RID: 228806 RVA: 0x00D3CD89 File Offset: 0x00D3AF89
		public RogueResMoodRule? GetMoodRuleById(int id)
		{
			return ConfigRogueResMoodRuleById.GetConfig(id, true);
		}

		// Token: 0x06037DC7 RID: 228807 RVA: 0x00D3CD92 File Offset: 0x00D3AF92
		public RogueResEventBg? GetEventBgById(int id)
		{
			return ConfigRogueResEventBgById.GetConfig(id, true);
		}

		// Token: 0x06037DC8 RID: 228808 RVA: 0x00D3CD9B File Offset: 0x00D3AF9B
		public RogueResEventBgm? GetEventBgmById(int id)
		{
			return ConfigRogueResEventBgmById.GetConfig(id, true);
		}

		// Token: 0x06037DC9 RID: 228809 RVA: 0x00D3CDA4 File Offset: 0x00D3AFA4
		public RogueResGridExplore? GetExploreByInstId(int instId)
		{
			return ConfigRogueResGridExploreByInstId.GetConfig(instId, true);
		}

		// Token: 0x06037DCA RID: 228810 RVA: 0x00D3CDB0 File Offset: 0x00D3AFB0
		public RogueResGlobalParam? GetGlobalParamConfig()
		{
			IReadOnlyList<RogueResGlobalParam> configList = ConfigRogueResGlobalParamAll.GetConfigList(true);
			if (configList != null && configList.Count > 0)
			{
				return new RogueResGlobalParam?(configList[0]);
			}
			return null;
		}

		// Token: 0x1700867D RID: 34429
		// (get) Token: 0x06037DCB RID: 228811 RVA: 0x00D3CDE6 File Offset: 0x00D3AFE6
		public static MapRogueConfig Instance
		{
			get
			{
				return MapRogueConfig._Instance;
			}
		}

		// Token: 0x06037DCC RID: 228812 RVA: 0x00D3CDED File Offset: 0x00D3AFED
		public static MapRogueConfig GetOrCreateInstance()
		{
			if (MapRogueConfig._Instance == null)
			{
				MapRogueConfig.CreateInstance();
			}
			return MapRogueConfig._Instance;
		}

		// Token: 0x06037DCD RID: 228813 RVA: 0x00D3CE01 File Offset: 0x00D3B001
		public static bool CreateInstance()
		{
			if (MapRogueConfig._Instance != null)
			{
				return true;
			}
			MapRogueConfig._Instance = new MapRogueConfig();
			return true;
		}

		// Token: 0x06037DCE RID: 228814 RVA: 0x00D3CE17 File Offset: 0x00D3B017
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037DCF RID: 228815 RVA: 0x00D3CE19 File Offset: 0x00D3B019
		public static void ResetStaticDefaultValue()
		{
			MapRogueConfig._Instance = null;
		}

		// Token: 0x06037DD0 RID: 228816 RVA: 0x00D3CE21 File Offset: 0x00D3B021
		static MapRogueConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MapRogueConfig.CreateStaticDefaultValue), new Action(MapRogueConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401D582 RID: 120194
		[Nullable(2)]
		private static MapRogueConfig _Instance;
	}
}
