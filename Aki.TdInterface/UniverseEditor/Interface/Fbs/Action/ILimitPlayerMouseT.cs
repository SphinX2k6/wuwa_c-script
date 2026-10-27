using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A1B RID: 27163
	public class ILimitPlayerMouseT
	{
		// Token: 0x1700C97F RID: 51583
		// (get) Token: 0x0602F881 RID: 194689 RVA: 0x006789D2 File Offset: 0x00676BD2
		// (set) Token: 0x0602F882 RID: 194690 RVA: 0x006789DA File Offset: 0x00676BDA
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x0602F883 RID: 194691 RVA: 0x006789E3 File Offset: 0x00676BE3
		public ILimitPlayerMouseT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
		}
	}
}
