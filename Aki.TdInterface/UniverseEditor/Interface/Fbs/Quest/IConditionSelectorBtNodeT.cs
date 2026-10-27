using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DB3 RID: 15795
	public class IConditionSelectorBtNodeT
	{
		// Token: 0x17006CDE RID: 27870
		// (get) Token: 0x06016014 RID: 90132 RVA: 0x0032E7C4 File Offset: 0x0032C9C4
		// (set) Token: 0x06016015 RID: 90133 RVA: 0x0032E7CC File Offset: 0x0032C9CC
		public EBtNode Type { get; set; }

		// Token: 0x17006CDF RID: 27871
		// (get) Token: 0x06016016 RID: 90134 RVA: 0x0032E7D5 File Offset: 0x0032C9D5
		// (set) Token: 0x06016017 RID: 90135 RVA: 0x0032E7DD File Offset: 0x0032C9DD
		public int Id { get; set; }

		// Token: 0x17006CE0 RID: 27872
		// (get) Token: 0x06016018 RID: 90136 RVA: 0x0032E7E6 File Offset: 0x0032C9E6
		// (set) Token: 0x06016019 RID: 90137 RVA: 0x0032E7EE File Offset: 0x0032C9EE
		public string Desc { get; set; }

		// Token: 0x17006CE1 RID: 27873
		// (get) Token: 0x0601601A RID: 90138 RVA: 0x0032E7F7 File Offset: 0x0032C9F7
		// (set) Token: 0x0601601B RID: 90139 RVA: 0x0032E7FF File Offset: 0x0032C9FF
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17006CE2 RID: 27874
		// (get) Token: 0x0601601C RID: 90140 RVA: 0x0032E808 File Offset: 0x0032CA08
		// (set) Token: 0x0601601D RID: 90141 RVA: 0x0032E810 File Offset: 0x0032CA10
		public bool _FoldedForTree { get; set; }

		// Token: 0x17006CE3 RID: 27875
		// (get) Token: 0x0601601E RID: 90142 RVA: 0x0032E819 File Offset: 0x0032CA19
		// (set) Token: 0x0601601F RID: 90143 RVA: 0x0032E821 File Offset: 0x0032CA21
		public bool Disabled { get; set; }

		// Token: 0x17006CE4 RID: 27876
		// (get) Token: 0x06016020 RID: 90144 RVA: 0x0032E82A File Offset: 0x0032CA2A
		// (set) Token: 0x06016021 RID: 90145 RVA: 0x0032E832 File Offset: 0x0032CA32
		public IQuestScheduleConfigT UIConfig { get; set; }

		// Token: 0x17006CE5 RID: 27877
		// (get) Token: 0x06016022 RID: 90146 RVA: 0x0032E83B File Offset: 0x0032CA3B
		// (set) Token: 0x06016023 RID: 90147 RVA: 0x0032E843 File Offset: 0x0032CA43
		public IInformationViewConfigT InformationView { get; set; }

		// Token: 0x17006CE6 RID: 27878
		// (get) Token: 0x06016024 RID: 90148 RVA: 0x0032E84C File Offset: 0x0032CA4C
		// (set) Token: 0x06016025 RID: 90149 RVA: 0x0032E854 File Offset: 0x0032CA54
		public IInformationBoardConfigT InformationBoard { get; set; }

		// Token: 0x17006CE7 RID: 27879
		// (get) Token: 0x06016026 RID: 90150 RVA: 0x0032E85D File Offset: 0x0032CA5D
		// (set) Token: 0x06016027 RID: 90151 RVA: 0x0032E865 File Offset: 0x0032CA65
		public string TidQuestAliasName { get; set; }

		// Token: 0x17006CE8 RID: 27880
		// (get) Token: 0x06016028 RID: 90152 RVA: 0x0032E86E File Offset: 0x0032CA6E
		// (set) Token: 0x06016029 RID: 90153 RVA: 0x0032E876 File Offset: 0x0032CA76
		public string TidQuestAliasDesc { get; set; }

		// Token: 0x17006CE9 RID: 27881
		// (get) Token: 0x0601602A RID: 90154 RVA: 0x0032E87F File Offset: 0x0032CA7F
		// (set) Token: 0x0601602B RID: 90155 RVA: 0x0032E887 File Offset: 0x0032CA87
		public int DungeonId { get; set; }

		// Token: 0x17006CEA RID: 27882
		// (get) Token: 0x0601602C RID: 90156 RVA: 0x0032E890 File Offset: 0x0032CA90
		// (set) Token: 0x0601602D RID: 90157 RVA: 0x0032E898 File Offset: 0x0032CA98
		public bool DisableOnline { get; set; }

		// Token: 0x17006CEB RID: 27883
		// (get) Token: 0x0601602E RID: 90158 RVA: 0x0032E8A1 File Offset: 0x0032CAA1
		// (set) Token: 0x0601602F RID: 90159 RVA: 0x0032E8A9 File Offset: 0x0032CAA9
		public ISaveConfigT SaveConfig { get; set; }

		// Token: 0x17006CEC RID: 27884
		// (get) Token: 0x06016030 RID: 90160 RVA: 0x0032E8B2 File Offset: 0x0032CAB2
		// (set) Token: 0x06016031 RID: 90161 RVA: 0x0032E8BA File Offset: 0x0032CABA
		public IForceClosedRestrictionT ForceClosedRestriction { get; set; }

		// Token: 0x17006CED RID: 27885
		// (get) Token: 0x06016032 RID: 90162 RVA: 0x0032E8C3 File Offset: 0x0032CAC3
		// (set) Token: 0x06016033 RID: 90163 RVA: 0x0032E8CB File Offset: 0x0032CACB
		public List<string> Occupations { get; set; }

		// Token: 0x17006CEE RID: 27886
		// (get) Token: 0x06016034 RID: 90164 RVA: 0x0032E8D4 File Offset: 0x0032CAD4
		// (set) Token: 0x06016035 RID: 90165 RVA: 0x0032E8DC File Offset: 0x0032CADC
		public ILogicNodeOccupationT OccupationConfig { get; set; }

		// Token: 0x17006CEF RID: 27887
		// (get) Token: 0x06016036 RID: 90166 RVA: 0x0032E8E5 File Offset: 0x0032CAE5
		// (set) Token: 0x06016037 RID: 90167 RVA: 0x0032E8ED File Offset: 0x0032CAED
		public bool DisableSwitchOccupation { get; set; }

		// Token: 0x17006CF0 RID: 27888
		// (get) Token: 0x06016038 RID: 90168 RVA: 0x0032E8F6 File Offset: 0x0032CAF6
		// (set) Token: 0x06016039 RID: 90169 RVA: 0x0032E8FE File Offset: 0x0032CAFE
		public EBudgetCameraType BudgetCameraType { get; set; }

		// Token: 0x17006CF1 RID: 27889
		// (get) Token: 0x0601603A RID: 90170 RVA: 0x0032E907 File Offset: 0x0032CB07
		// (set) Token: 0x0601603B RID: 90171 RVA: 0x0032E90F File Offset: 0x0032CB0F
		public IQuestStatisticsT Statistics { get; set; }

		// Token: 0x17006CF2 RID: 27890
		// (get) Token: 0x0601603C RID: 90172 RVA: 0x0032E918 File Offset: 0x0032CB18
		// (set) Token: 0x0601603D RID: 90173 RVA: 0x0032E920 File Offset: 0x0032CB20
		public ETrackViewMode CompositeTrackViewMode { get; set; }

		// Token: 0x17006CF3 RID: 27891
		// (get) Token: 0x0601603E RID: 90174 RVA: 0x0032E929 File Offset: 0x0032CB29
		// (set) Token: 0x0601603F RID: 90175 RVA: 0x0032E931 File Offset: 0x0032CB31
		public IQuestRewardConfigT RewardConfig { get; set; }

		// Token: 0x17006CF4 RID: 27892
		// (get) Token: 0x06016040 RID: 90176 RVA: 0x0032E93A File Offset: 0x0032CB3A
		// (set) Token: 0x06016041 RID: 90177 RVA: 0x0032E942 File Offset: 0x0032CB42
		public TSpecialGamePlayConfigUnion SpecialGamePlayConfig { get; set; }

		// Token: 0x17006CF5 RID: 27893
		// (get) Token: 0x06016042 RID: 90178 RVA: 0x0032E94B File Offset: 0x0032CB4B
		// (set) Token: 0x06016043 RID: 90179 RVA: 0x0032E953 File Offset: 0x0032CB53
		public TEnableSystemConfigUnion EnableSystem { get; set; }

		// Token: 0x17006CF6 RID: 27894
		// (get) Token: 0x06016044 RID: 90180 RVA: 0x0032E95C File Offset: 0x0032CB5C
		// (set) Token: 0x06016045 RID: 90181 RVA: 0x0032E964 File Offset: 0x0032CB64
		public IWaveConfigT StartWave { get; set; }

		// Token: 0x17006CF7 RID: 27895
		// (get) Token: 0x06016046 RID: 90182 RVA: 0x0032E96D File Offset: 0x0032CB6D
		// (set) Token: 0x06016047 RID: 90183 RVA: 0x0032E975 File Offset: 0x0032CB75
		public IDisableTrackAnimT DisableTrackAnim { get; set; }

		// Token: 0x17006CF8 RID: 27896
		// (get) Token: 0x06016048 RID: 90184 RVA: 0x0032E97E File Offset: 0x0032CB7E
		// (set) Token: 0x06016049 RID: 90185 RVA: 0x0032E986 File Offset: 0x0032CB86
		public bool DisableSwitchGender { get; set; }

		// Token: 0x17006CF9 RID: 27897
		// (get) Token: 0x0601604A RID: 90186 RVA: 0x0032E98F File Offset: 0x0032CB8F
		// (set) Token: 0x0601604B RID: 90187 RVA: 0x0032E997 File Offset: 0x0032CB97
		public bool DisableFocusMode { get; set; }

		// Token: 0x17006CFA RID: 27898
		// (get) Token: 0x0601604C RID: 90188 RVA: 0x0032E9A0 File Offset: 0x0032CBA0
		// (set) Token: 0x0601604D RID: 90189 RVA: 0x0032E9A8 File Offset: 0x0032CBA8
		public bool DisableSkeletalAnimationCheck { get; set; }

		// Token: 0x17006CFB RID: 27899
		// (get) Token: 0x0601604E RID: 90190 RVA: 0x0032E9B1 File Offset: 0x0032CBB1
		// (set) Token: 0x0601604F RID: 90191 RVA: 0x0032E9B9 File Offset: 0x0032CBB9
		public ILogicProgramSpecialProcessT LogicProgramSpecialProcess { get; set; }

		// Token: 0x17006CFC RID: 27900
		// (get) Token: 0x06016050 RID: 90192 RVA: 0x0032E9C2 File Offset: 0x0032CBC2
		// (set) Token: 0x06016051 RID: 90193 RVA: 0x0032E9CA File Offset: 0x0032CBCA
		public IQuestBuffActiveRangeT QuestBuffActiveRange { get; set; }

		// Token: 0x17006CFD RID: 27901
		// (get) Token: 0x06016052 RID: 90194 RVA: 0x0032E9D3 File Offset: 0x0032CBD3
		// (set) Token: 0x06016053 RID: 90195 RVA: 0x0032E9DB File Offset: 0x0032CBDB
		public ISunSpiritProcessT SunSpiritProcess { get; set; }

		// Token: 0x17006CFE RID: 27902
		// (get) Token: 0x06016054 RID: 90196 RVA: 0x0032E9E4 File Offset: 0x0032CBE4
		// (set) Token: 0x06016055 RID: 90197 RVA: 0x0032E9EC File Offset: 0x0032CBEC
		public ITrackAreaTextT ModifyTrackAreaText { get; set; }

		// Token: 0x17006CFF RID: 27903
		// (get) Token: 0x06016056 RID: 90198 RVA: 0x0032E9F5 File Offset: 0x0032CBF5
		// (set) Token: 0x06016057 RID: 90199 RVA: 0x0032E9FD File Offset: 0x0032CBFD
		public bool DisableGlobalTraffic { get; set; }

		// Token: 0x17006D00 RID: 27904
		// (get) Token: 0x06016058 RID: 90200 RVA: 0x0032EA06 File Offset: 0x0032CC06
		// (set) Token: 0x06016059 RID: 90201 RVA: 0x0032EA0E File Offset: 0x0032CC0E
		public List<IAreaNameSystemPromptT> DisableSystemPrompt { get; set; }

		// Token: 0x17006D01 RID: 27905
		// (get) Token: 0x0601605A RID: 90202 RVA: 0x0032EA17 File Offset: 0x0032CC17
		// (set) Token: 0x0601605B RID: 90203 RVA: 0x0032EA1F File Offset: 0x0032CC1F
		public ITrackCustomBoardOnBtLogicNodeT TrackCustomBoard { get; set; }

		// Token: 0x17006D02 RID: 27906
		// (get) Token: 0x0601605C RID: 90204 RVA: 0x0032EA28 File Offset: 0x0032CC28
		// (set) Token: 0x0601605D RID: 90205 RVA: 0x0032EA30 File Offset: 0x0032CC30
		public bool PendingClientResults { get; set; }

		// Token: 0x17006D03 RID: 27907
		// (get) Token: 0x0601605E RID: 90206 RVA: 0x0032EA39 File Offset: 0x0032CC39
		// (set) Token: 0x0601605F RID: 90207 RVA: 0x0032EA41 File Offset: 0x0032CC41
		public List<IConditionSelectorBtNodeSlotT> Slots { get; set; }

		// Token: 0x17006D04 RID: 27908
		// (get) Token: 0x06016060 RID: 90208 RVA: 0x0032EA4A File Offset: 0x0032CC4A
		// (set) Token: 0x06016061 RID: 90209 RVA: 0x0032EA52 File Offset: 0x0032CC52
		public ushort NullMask { get; set; }

		// Token: 0x06016062 RID: 90210 RVA: 0x0032EA5C File Offset: 0x0032CC5C
		public IConditionSelectorBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.UIConfig = null;
			this.InformationView = null;
			this.InformationBoard = null;
			this.TidQuestAliasName = null;
			this.TidQuestAliasDesc = null;
			this.DungeonId = 0;
			this.DisableOnline = false;
			this.SaveConfig = null;
			this.ForceClosedRestriction = null;
			this.Occupations = null;
			this.OccupationConfig = null;
			this.DisableSwitchOccupation = false;
			this.BudgetCameraType = EBudgetCameraType.Role;
			this.Statistics = null;
			this.CompositeTrackViewMode = ETrackViewMode.All;
			this.RewardConfig = null;
			this.SpecialGamePlayConfig = null;
			this.EnableSystem = null;
			this.StartWave = null;
			this.DisableTrackAnim = null;
			this.DisableSwitchGender = false;
			this.DisableFocusMode = false;
			this.DisableSkeletalAnimationCheck = false;
			this.LogicProgramSpecialProcess = null;
			this.QuestBuffActiveRange = null;
			this.SunSpiritProcess = null;
			this.ModifyTrackAreaText = null;
			this.DisableGlobalTraffic = false;
			this.DisableSystemPrompt = null;
			this.TrackCustomBoard = null;
			this.PendingClientResults = false;
			this.Slots = null;
			this.NullMask = 0;
		}
	}
}
