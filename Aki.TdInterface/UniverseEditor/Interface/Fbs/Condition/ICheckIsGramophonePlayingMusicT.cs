using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A8E RID: 19086
	public class ICheckIsGramophonePlayingMusicT
	{
		// Token: 0x17008A47 RID: 35399
		// (get) Token: 0x0601DEF4 RID: 122612 RVA: 0x00434321 File Offset: 0x00432521
		// (set) Token: 0x0601DEF5 RID: 122613 RVA: 0x00434329 File Offset: 0x00432529
		public ECondition Type { get; set; }

		// Token: 0x17008A48 RID: 35400
		// (get) Token: 0x0601DEF6 RID: 122614 RVA: 0x00434332 File Offset: 0x00432532
		// (set) Token: 0x0601DEF7 RID: 122615 RVA: 0x0043433A File Offset: 0x0043253A
		public int TargetGramophone { get; set; }

		// Token: 0x17008A49 RID: 35401
		// (get) Token: 0x0601DEF8 RID: 122616 RVA: 0x00434343 File Offset: 0x00432543
		// (set) Token: 0x0601DEF9 RID: 122617 RVA: 0x0043434B File Offset: 0x0043254B
		public IGramophoneCheckConditionT CheckCondition { get; set; }

		// Token: 0x0601DEFA RID: 122618 RVA: 0x00434354 File Offset: 0x00432554
		public ICheckIsGramophonePlayingMusicT()
		{
			this.Type = ECondition.CompareVar;
			this.TargetGramophone = 0;
			this.CheckCondition = null;
		}
	}
}
