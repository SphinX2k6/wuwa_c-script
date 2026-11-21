using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005991 RID: 22929
	public class IInhaledDestroySelfT
	{
		// Token: 0x1700A685 RID: 42629
		// (get) Token: 0x06025615 RID: 153109 RVA: 0x00521186 File Offset: 0x0051F386
		// (set) Token: 0x06025616 RID: 153110 RVA: 0x0052118E File Offset: 0x0051F38E
		public EInhaledPerResultType Type { get; set; }

		// Token: 0x06025617 RID: 153111 RVA: 0x00521197 File Offset: 0x0051F397
		public IInhaledDestroySelfT()
		{
			this.Type = EInhaledPerResultType.DestroySelf;
		}
	}
}
