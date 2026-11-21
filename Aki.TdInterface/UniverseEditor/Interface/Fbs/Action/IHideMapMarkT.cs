using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA5 RID: 28581
	public class IHideMapMarkT
	{
		// Token: 0x1700D15A RID: 53594
		// (get) Token: 0x060317BD RID: 202685 RVA: 0x006B52C0 File Offset: 0x006B34C0
		// (set) Token: 0x060317BE RID: 202686 RVA: 0x006B52C8 File Offset: 0x006B34C8
		public EMapMarkState Type { get; set; }

		// Token: 0x1700D15B RID: 53595
		// (get) Token: 0x060317BF RID: 202687 RVA: 0x006B52D1 File Offset: 0x006B34D1
		// (set) Token: 0x060317C0 RID: 202688 RVA: 0x006B52D9 File Offset: 0x006B34D9
		public int MarkId { get; set; }

		// Token: 0x060317C1 RID: 202689 RVA: 0x006B52E2 File Offset: 0x006B34E2
		public IHideMapMarkT()
		{
			this.Type = EMapMarkState.Show;
			this.MarkId = 0;
		}
	}
}
