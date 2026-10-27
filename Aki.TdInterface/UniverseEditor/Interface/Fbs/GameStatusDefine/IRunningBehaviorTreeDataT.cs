using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046FE RID: 18174
	public class IRunningBehaviorTreeDataT
	{
		// Token: 0x17008202 RID: 33282
		// (get) Token: 0x0601BDA5 RID: 114085 RVA: 0x003F2CBE File Offset: 0x003F0EBE
		// (set) Token: 0x0601BDA6 RID: 114086 RVA: 0x003F2CC6 File Offset: 0x003F0EC6
		public IRunningQuestsT Quest { get; set; }

		// Token: 0x17008203 RID: 33283
		// (get) Token: 0x0601BDA7 RID: 114087 RVA: 0x003F2CCF File Offset: 0x003F0ECF
		// (set) Token: 0x0601BDA8 RID: 114088 RVA: 0x003F2CD7 File Offset: 0x003F0ED7
		public List<IRunningTreeT> LevelPlays { get; set; }

		// Token: 0x17008204 RID: 33284
		// (get) Token: 0x0601BDA9 RID: 114089 RVA: 0x003F2CE0 File Offset: 0x003F0EE0
		// (set) Token: 0x0601BDAA RID: 114090 RVA: 0x003F2CE8 File Offset: 0x003F0EE8
		public List<int> FinishedQuests { get; set; }

		// Token: 0x17008205 RID: 33285
		// (get) Token: 0x0601BDAB RID: 114091 RVA: 0x003F2CF1 File Offset: 0x003F0EF1
		// (set) Token: 0x0601BDAC RID: 114092 RVA: 0x003F2CF9 File Offset: 0x003F0EF9
		public List<int> FinishedLevelPlays { get; set; }

		// Token: 0x17008206 RID: 33286
		// (get) Token: 0x0601BDAD RID: 114093 RVA: 0x003F2D02 File Offset: 0x003F0F02
		// (set) Token: 0x0601BDAE RID: 114094 RVA: 0x003F2D0A File Offset: 0x003F0F0A
		public List<Record_String_StringT> GlobalVars { get; set; }

		// Token: 0x17008207 RID: 33287
		// (get) Token: 0x0601BDAF RID: 114095 RVA: 0x003F2D13 File Offset: 0x003F0F13
		// (set) Token: 0x0601BDB0 RID: 114096 RVA: 0x003F2D1B File Offset: 0x003F0F1B
		public List<IGameCurrBreakNodeEventInfoT> TriggerBreakNodes { get; set; }

		// Token: 0x17008208 RID: 33288
		// (get) Token: 0x0601BDB1 RID: 114097 RVA: 0x003F2D24 File Offset: 0x003F0F24
		// (set) Token: 0x0601BDB2 RID: 114098 RVA: 0x003F2D2C File Offset: 0x003F0F2C
		public List<IHideRangeInfoT> HideRangeInfos { get; set; }

		// Token: 0x17008209 RID: 33289
		// (get) Token: 0x0601BDB3 RID: 114099 RVA: 0x003F2D35 File Offset: 0x003F0F35
		// (set) Token: 0x0601BDB4 RID: 114100 RVA: 0x003F2D3D File Offset: 0x003F0F3D
		public string HideGroupInfo { get; set; }

		// Token: 0x1700820A RID: 33290
		// (get) Token: 0x0601BDB5 RID: 114101 RVA: 0x003F2D46 File Offset: 0x003F0F46
		// (set) Token: 0x0601BDB6 RID: 114102 RVA: 0x003F2D4E File Offset: 0x003F0F4E
		public List<Record_String_IRunningFlowInfoT> FlowInfos { get; set; }

		// Token: 0x1700820B RID: 33291
		// (get) Token: 0x0601BDB7 RID: 114103 RVA: 0x003F2D57 File Offset: 0x003F0F57
		// (set) Token: 0x0601BDB8 RID: 114104 RVA: 0x003F2D5F File Offset: 0x003F0F5F
		public byte NullMask { get; set; }

		// Token: 0x0601BDB9 RID: 114105 RVA: 0x003F2D68 File Offset: 0x003F0F68
		public IRunningBehaviorTreeDataT()
		{
			this.Quest = null;
			this.LevelPlays = null;
			this.FinishedQuests = null;
			this.FinishedLevelPlays = null;
			this.GlobalVars = null;
			this.TriggerBreakNodes = null;
			this.HideRangeInfos = null;
			this.HideGroupInfo = null;
			this.FlowInfos = null;
			this.NullMask = 0;
		}
	}
}
