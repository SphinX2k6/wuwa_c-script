using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E51 RID: 15953
	public class IBvbNpcHpValueT
	{
		// Token: 0x17006BB9 RID: 27577
		// (get) Token: 0x060157C3 RID: 88003 RVA: 0x003198AA File Offset: 0x00317AAA
		// (set) Token: 0x060157C4 RID: 88004 RVA: 0x003198B2 File Offset: 0x00317AB2
		public ESystemVarName Type { get; set; }

		// Token: 0x060157C5 RID: 88005 RVA: 0x003198BB File Offset: 0x00317ABB
		public IBvbNpcHpValueT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
