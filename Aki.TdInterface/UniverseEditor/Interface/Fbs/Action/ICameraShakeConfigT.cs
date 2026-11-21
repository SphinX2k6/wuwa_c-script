using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006914 RID: 26900
	public class ICameraShakeConfigT
	{
		// Token: 0x1700C608 RID: 50696
		// (get) Token: 0x0602E17E RID: 188798 RVA: 0x0064C7D6 File Offset: 0x0064A9D6
		// (set) Token: 0x0602E17F RID: 188799 RVA: 0x0064C7DE File Offset: 0x0064A9DE
		public ECameraShakeType Type { get; set; }

		// Token: 0x0602E180 RID: 188800 RVA: 0x0064C7E7 File Offset: 0x0064A9E7
		public ICameraShakeConfigT()
		{
			this.Type = ECameraShakeType.Constant;
		}
	}
}
