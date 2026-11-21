using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007359 RID: 29529
	public class IOpenConfirmBox2WithReturnT
	{
		// Token: 0x1700D88E RID: 55438
		// (get) Token: 0x06033861 RID: 211041 RVA: 0x006F1AD5 File Offset: 0x006EFCD5
		// (set) Token: 0x06033862 RID: 211042 RVA: 0x006F1ADD File Offset: 0x006EFCDD
		public ESystemType Type { get; set; }

		// Token: 0x1700D88F RID: 55439
		// (get) Token: 0x06033863 RID: 211043 RVA: 0x006F1AE6 File Offset: 0x006EFCE6
		// (set) Token: 0x06033864 RID: 211044 RVA: 0x006F1AEE File Offset: 0x006EFCEE
		public int Id { get; set; }

		// Token: 0x1700D890 RID: 55440
		// (get) Token: 0x06033865 RID: 211045 RVA: 0x006F1AF7 File Offset: 0x006EFCF7
		// (set) Token: 0x06033866 RID: 211046 RVA: 0x006F1AFF File Offset: 0x006EFCFF
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06033867 RID: 211047 RVA: 0x006F1B08 File Offset: 0x006EFD08
		public IOpenConfirmBox2WithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.Id = 0;
			this.ReturnVar = null;
		}
	}
}
