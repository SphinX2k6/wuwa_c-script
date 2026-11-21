using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC7 RID: 28359
	public class IFocusOnCustomMapMarkT
	{
		// Token: 0x1700D00A RID: 53258
		// (get) Token: 0x0603111D RID: 200989 RVA: 0x006A778C File Offset: 0x006A598C
		// (set) Token: 0x0603111E RID: 200990 RVA: 0x006A7794 File Offset: 0x006A5994
		public EMapMarkType Type { get; set; }

		// Token: 0x1700D00B RID: 53259
		// (get) Token: 0x0603111F RID: 200991 RVA: 0x006A779D File Offset: 0x006A599D
		// (set) Token: 0x06031120 RID: 200992 RVA: 0x006A77A5 File Offset: 0x006A59A5
		public int MarkId { get; set; }

		// Token: 0x06031121 RID: 200993 RVA: 0x006A77AE File Offset: 0x006A59AE
		public IFocusOnCustomMapMarkT()
		{
			this.Type = EMapMarkType.Custom;
			this.MarkId = 0;
		}
	}
}
