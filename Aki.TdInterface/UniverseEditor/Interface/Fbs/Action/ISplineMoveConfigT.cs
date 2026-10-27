using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200717F RID: 29055
	public class ISplineMoveConfigT
	{
		// Token: 0x1700D7D5 RID: 55253
		// (get) Token: 0x0603383E RID: 211006 RVA: 0x006F0889 File Offset: 0x006EEA89
		// (set) Token: 0x0603383F RID: 211007 RVA: 0x006F0891 File Offset: 0x006EEA91
		public ESplineMoveConfigType Type { get; set; }

		// Token: 0x1700D7D6 RID: 55254
		// (get) Token: 0x06033840 RID: 211008 RVA: 0x006F089A File Offset: 0x006EEA9A
		// (set) Token: 0x06033841 RID: 211009 RVA: 0x006F08A2 File Offset: 0x006EEAA2
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700D7D7 RID: 55255
		// (get) Token: 0x06033842 RID: 211010 RVA: 0x006F08AB File Offset: 0x006EEAAB
		// (set) Token: 0x06033843 RID: 211011 RVA: 0x006F08B3 File Offset: 0x006EEAB3
		public int SplineEntityId { get; set; }

		// Token: 0x06033844 RID: 211012 RVA: 0x006F08BC File Offset: 0x006EEABC
		public ISplineMoveConfigT()
		{
			this.Type = ESplineMoveConfigType.Open;
			this.Target = null;
			this.SplineEntityId = 0;
		}
	}
}
