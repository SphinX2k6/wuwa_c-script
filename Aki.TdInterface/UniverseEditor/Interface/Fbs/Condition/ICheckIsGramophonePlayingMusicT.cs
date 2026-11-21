using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F54 RID: 20308
	public class ICheckIsGramophonePlayingMusicT
	{
		// Token: 0x17009123 RID: 37155
		// (get) Token: 0x0601F997 RID: 129431 RVA: 0x004654AD File Offset: 0x004636AD
		// (set) Token: 0x0601F998 RID: 129432 RVA: 0x004654B5 File Offset: 0x004636B5
		public ECondition Type { get; set; }

		// Token: 0x17009124 RID: 37156
		// (get) Token: 0x0601F999 RID: 129433 RVA: 0x004654BE File Offset: 0x004636BE
		// (set) Token: 0x0601F99A RID: 129434 RVA: 0x004654C6 File Offset: 0x004636C6
		public int TargetGramophone { get; set; }

		// Token: 0x17009125 RID: 37157
		// (get) Token: 0x0601F99B RID: 129435 RVA: 0x004654CF File Offset: 0x004636CF
		// (set) Token: 0x0601F99C RID: 129436 RVA: 0x004654D7 File Offset: 0x004636D7
		public IGramophoneCheckConditionT CheckCondition { get; set; }

		// Token: 0x0601F99D RID: 129437 RVA: 0x004654E0 File Offset: 0x004636E0
		public ICheckIsGramophonePlayingMusicT()
		{
			this.Type = ECondition.CompareVar;
			this.TargetGramophone = 0;
			this.CheckCondition = null;
		}
	}
}
