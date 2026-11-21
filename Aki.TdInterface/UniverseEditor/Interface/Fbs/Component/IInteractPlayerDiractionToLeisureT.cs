using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E2 RID: 23010
	public class IInteractPlayerDiractionToLeisureT
	{
		// Token: 0x1700A741 RID: 42817
		// (get) Token: 0x06025933 RID: 153907 RVA: 0x0052754E File Offset: 0x0052574E
		// (set) Token: 0x06025934 RID: 153908 RVA: 0x00527556 File Offset: 0x00525756
		public EInteractPlayerDiractionType Type { get; set; }

		// Token: 0x1700A742 RID: 42818
		// (get) Token: 0x06025935 RID: 153909 RVA: 0x0052755F File Offset: 0x0052575F
		// (set) Token: 0x06025936 RID: 153910 RVA: 0x00527567 File Offset: 0x00525767
		public int Begin { get; set; }

		// Token: 0x1700A743 RID: 42819
		// (get) Token: 0x06025937 RID: 153911 RVA: 0x00527570 File Offset: 0x00525770
		// (set) Token: 0x06025938 RID: 153912 RVA: 0x00527578 File Offset: 0x00525778
		public int End { get; set; }

		// Token: 0x06025939 RID: 153913 RVA: 0x00527581 File Offset: 0x00525781
		public IInteractPlayerDiractionToLeisureT()
		{
			this.Type = EInteractPlayerDiractionType.Npc;
			this.Begin = 0;
			this.End = 0;
		}
	}
}
