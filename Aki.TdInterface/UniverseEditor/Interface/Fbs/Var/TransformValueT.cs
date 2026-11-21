using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F5C RID: 16220
	public class TransformValueT
	{
		// Token: 0x17006DC2 RID: 28098
		// (get) Token: 0x06016113 RID: 90387 RVA: 0x0032AED5 File Offset: 0x003290D5
		// (set) Token: 0x06016114 RID: 90388 RVA: 0x0032AEDD File Offset: 0x003290DD
		public IPosAndRotT Value { get; set; }

		// Token: 0x06016115 RID: 90389 RVA: 0x0032AEE6 File Offset: 0x003290E6
		public TransformValueT()
		{
			this.Value = null;
		}
	}
}
