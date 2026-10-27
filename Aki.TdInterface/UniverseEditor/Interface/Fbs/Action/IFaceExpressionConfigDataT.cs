using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200674B RID: 26443
	public class IFaceExpressionConfigDataT
	{
		// Token: 0x1700C451 RID: 50257
		// (get) Token: 0x0602DFFB RID: 188411 RVA: 0x00649761 File Offset: 0x00647961
		// (set) Token: 0x0602DFFC RID: 188412 RVA: 0x00649769 File Offset: 0x00647969
		public int Id { get; set; }

		// Token: 0x1700C452 RID: 50258
		// (get) Token: 0x0602DFFD RID: 188413 RVA: 0x00649772 File Offset: 0x00647972
		// (set) Token: 0x0602DFFE RID: 188414 RVA: 0x0064977A File Offset: 0x0064797A
		public IFaceExpressionConfig_UnionUnion FaceExpression { get; set; }

		// Token: 0x1700C453 RID: 50259
		// (get) Token: 0x0602DFFF RID: 188415 RVA: 0x00649783 File Offset: 0x00647983
		// (set) Token: 0x0602E000 RID: 188416 RVA: 0x0064978B File Offset: 0x0064798B
		public IFaceExpressionConfig_UnionUnion MaleVariant { get; set; }

		// Token: 0x1700C454 RID: 50260
		// (get) Token: 0x0602E001 RID: 188417 RVA: 0x00649794 File Offset: 0x00647994
		// (set) Token: 0x0602E002 RID: 188418 RVA: 0x0064979C File Offset: 0x0064799C
		public bool CloseAutoBlink { get; set; }

		// Token: 0x1700C455 RID: 50261
		// (get) Token: 0x0602E003 RID: 188419 RVA: 0x006497A5 File Offset: 0x006479A5
		// (set) Token: 0x0602E004 RID: 188420 RVA: 0x006497AD File Offset: 0x006479AD
		public byte NullMask { get; set; }

		// Token: 0x0602E005 RID: 188421 RVA: 0x006497B6 File Offset: 0x006479B6
		public IFaceExpressionConfigDataT()
		{
			this.Id = 0;
			this.FaceExpression = null;
			this.MaleVariant = null;
			this.CloseAutoBlink = false;
			this.NullMask = 0;
		}
	}
}
