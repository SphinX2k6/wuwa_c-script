using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005501 RID: 21761
	public class ILiftFloorSeqMarkT
	{
		// Token: 0x1700A0AB RID: 41131
		// (get) Token: 0x06023F01 RID: 147201 RVA: 0x004F7E67 File Offset: 0x004F6067
		// (set) Token: 0x06023F02 RID: 147202 RVA: 0x004F7E6F File Offset: 0x004F606F
		public int Floor { get; set; }

		// Token: 0x1700A0AC RID: 41132
		// (get) Token: 0x06023F03 RID: 147203 RVA: 0x004F7E78 File Offset: 0x004F6078
		// (set) Token: 0x06023F04 RID: 147204 RVA: 0x004F7E80 File Offset: 0x004F6080
		public string Mark { get; set; }

		// Token: 0x06023F05 RID: 147205 RVA: 0x004F7E89 File Offset: 0x004F6089
		public ILiftFloorSeqMarkT()
		{
			this.Floor = 0;
			this.Mark = null;
		}
	}
}
