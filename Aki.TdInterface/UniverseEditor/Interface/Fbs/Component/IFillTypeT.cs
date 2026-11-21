using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B8 RID: 22456
	public class IFillTypeT
	{
		// Token: 0x1700A25A RID: 41562
		// (get) Token: 0x0602440D RID: 148493 RVA: 0x004FB966 File Offset: 0x004F9B66
		// (set) Token: 0x0602440E RID: 148494 RVA: 0x004FB96E File Offset: 0x004F9B6E
		public EFillType Type { get; set; }

		// Token: 0x0602440F RID: 148495 RVA: 0x004FB977 File Offset: 0x004F9B77
		public IFillTypeT()
		{
			this.Type = EFillType.Fixed;
		}
	}
}
