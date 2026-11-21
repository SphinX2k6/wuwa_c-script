using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B3 RID: 29619
	public class IOptionLockTipT
	{
		// Token: 0x1700D997 RID: 55703
		// (get) Token: 0x06033CDC RID: 212188 RVA: 0x006FCE84 File Offset: 0x006FB084
		// (set) Token: 0x06033CDD RID: 212189 RVA: 0x006FCE8C File Offset: 0x006FB08C
		public string TidAppendText { get; set; }

		// Token: 0x1700D998 RID: 55704
		// (get) Token: 0x06033CDE RID: 212190 RVA: 0x006FCE95 File Offset: 0x006FB095
		// (set) Token: 0x06033CDF RID: 212191 RVA: 0x006FCE9D File Offset: 0x006FB09D
		public string TidHintText { get; set; }

		// Token: 0x1700D999 RID: 55705
		// (get) Token: 0x06033CE0 RID: 212192 RVA: 0x006FCEA6 File Offset: 0x006FB0A6
		// (set) Token: 0x06033CE1 RID: 212193 RVA: 0x006FCEAE File Offset: 0x006FB0AE
		public int AppendTextId { get; set; }

		// Token: 0x1700D99A RID: 55706
		// (get) Token: 0x06033CE2 RID: 212194 RVA: 0x006FCEB7 File Offset: 0x006FB0B7
		// (set) Token: 0x06033CE3 RID: 212195 RVA: 0x006FCEBF File Offset: 0x006FB0BF
		public int HintTextId { get; set; }

		// Token: 0x1700D99B RID: 55707
		// (get) Token: 0x06033CE4 RID: 212196 RVA: 0x006FCEC8 File Offset: 0x006FB0C8
		// (set) Token: 0x06033CE5 RID: 212197 RVA: 0x006FCED0 File Offset: 0x006FB0D0
		public byte NullMask { get; set; }

		// Token: 0x06033CE6 RID: 212198 RVA: 0x006FCED9 File Offset: 0x006FB0D9
		public IOptionLockTipT()
		{
			this.TidAppendText = null;
			this.TidHintText = null;
			this.AppendTextId = 0;
			this.HintTextId = 0;
			this.NullMask = 0;
		}
	}
}
