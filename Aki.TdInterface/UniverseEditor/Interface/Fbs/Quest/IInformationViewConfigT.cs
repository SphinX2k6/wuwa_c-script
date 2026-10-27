using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EAC RID: 16044
	public class IInformationViewConfigT
	{
		// Token: 0x17006F62 RID: 28514
		// (get) Token: 0x06016A8F RID: 92815 RVA: 0x00345ADD File Offset: 0x00343CDD
		// (set) Token: 0x06016A90 RID: 92816 RVA: 0x00345AE5 File Offset: 0x00343CE5
		public TInformationViewUnion InformationView { get; set; }

		// Token: 0x06016A91 RID: 92817 RVA: 0x00345AEE File Offset: 0x00343CEE
		public IInformationViewConfigT()
		{
			this.InformationView = null;
		}
	}
}
