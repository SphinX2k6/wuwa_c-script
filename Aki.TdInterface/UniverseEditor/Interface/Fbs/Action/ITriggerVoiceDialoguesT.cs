using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007491 RID: 29841
	public class ITriggerVoiceDialoguesT
	{
		// Token: 0x1700E289 RID: 57993
		// (get) Token: 0x060363BA RID: 222138 RVA: 0x0075F6B1 File Offset: 0x0075D8B1
		// (set) Token: 0x060363BB RID: 222139 RVA: 0x0075F6B9 File Offset: 0x0075D8B9
		public EInteractEffectType Type { get; set; }

		// Token: 0x1700E28A RID: 57994
		// (get) Token: 0x060363BC RID: 222140 RVA: 0x0075F6C2 File Offset: 0x0075D8C2
		// (set) Token: 0x060363BD RID: 222141 RVA: 0x0075F6CA File Offset: 0x0075D8CA
		public float DelayTime { get; set; }

		// Token: 0x1700E28B RID: 57995
		// (get) Token: 0x060363BE RID: 222142 RVA: 0x0075F6D3 File Offset: 0x0075D8D3
		// (set) Token: 0x060363BF RID: 222143 RVA: 0x0075F6DB File Offset: 0x0075D8DB
		public IPlayFlowT Flow { get; set; }

		// Token: 0x1700E28C RID: 57996
		// (get) Token: 0x060363C0 RID: 222144 RVA: 0x0075F6E4 File Offset: 0x0075D8E4
		// (set) Token: 0x060363C1 RID: 222145 RVA: 0x0075F6EC File Offset: 0x0075D8EC
		public bool ShowTalker { get; set; }

		// Token: 0x1700E28D RID: 57997
		// (get) Token: 0x060363C2 RID: 222146 RVA: 0x0075F6F5 File Offset: 0x0075D8F5
		// (set) Token: 0x060363C3 RID: 222147 RVA: 0x0075F6FD File Offset: 0x0075D8FD
		public byte NullMask { get; set; }

		// Token: 0x060363C4 RID: 222148 RVA: 0x0075F706 File Offset: 0x0075D906
		public ITriggerVoiceDialoguesT()
		{
			this.Type = EInteractEffectType.ModifyTipText;
			this.DelayTime = 0f;
			this.Flow = null;
			this.ShowTalker = false;
			this.NullMask = 0;
		}
	}
}
