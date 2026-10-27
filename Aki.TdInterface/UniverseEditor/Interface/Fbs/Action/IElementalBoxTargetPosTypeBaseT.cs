using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006631 RID: 26161
	public class IElementalBoxTargetPosTypeBaseT
	{
		// Token: 0x1700C25E RID: 49758
		// (get) Token: 0x0602D6ED RID: 186093 RVA: 0x006394E6 File Offset: 0x006376E6
		// (set) Token: 0x0602D6EE RID: 186094 RVA: 0x006394EE File Offset: 0x006376EE
		public EElementalBoxTargetPosType Type { get; set; }

		// Token: 0x0602D6EF RID: 186095 RVA: 0x006394F7 File Offset: 0x006376F7
		public IElementalBoxTargetPosTypeBaseT()
		{
			this.Type = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
		}
	}
}
