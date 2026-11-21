using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005410 RID: 21520
	public class IAutoConfigT
	{
		// Token: 0x17009864 RID: 39012
		// (get) Token: 0x06021A89 RID: 137865 RVA: 0x004A3A68 File Offset: 0x004A1C68
		// (set) Token: 0x06021A8A RID: 137866 RVA: 0x004A3A70 File Offset: 0x004A1C70
		public bool IsCircle { get; set; }

		// Token: 0x17009865 RID: 39013
		// (get) Token: 0x06021A8B RID: 137867 RVA: 0x004A3A79 File Offset: 0x004A1C79
		// (set) Token: 0x06021A8C RID: 137868 RVA: 0x004A3A81 File Offset: 0x004A1C81
		public int Interval { get; set; }

		// Token: 0x06021A8D RID: 137869 RVA: 0x004A3A8A File Offset: 0x004A1C8A
		public IAutoConfigT()
		{
			this.IsCircle = false;
			this.Interval = 0;
		}
	}
}
