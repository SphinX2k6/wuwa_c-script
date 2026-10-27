using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AB2 RID: 19122
	public class ICheckJigsawItemMoveT
	{
		// Token: 0x17008A9B RID: 35483
		// (get) Token: 0x0601E040 RID: 122944 RVA: 0x004368F2 File Offset: 0x00434AF2
		// (set) Token: 0x0601E041 RID: 122945 RVA: 0x004368FA File Offset: 0x00434AFA
		public ECheckJigsawInfoType Type { get; set; }

		// Token: 0x17008A9C RID: 35484
		// (get) Token: 0x0601E042 RID: 122946 RVA: 0x00436903 File Offset: 0x00434B03
		// (set) Token: 0x0601E043 RID: 122947 RVA: 0x0043690B File Offset: 0x00434B0B
		public int ItemEntityId { get; set; }

		// Token: 0x17008A9D RID: 35485
		// (get) Token: 0x0601E044 RID: 122948 RVA: 0x00436914 File Offset: 0x00434B14
		// (set) Token: 0x0601E045 RID: 122949 RVA: 0x0043691C File Offset: 0x00434B1C
		public ECompare Compare { get; set; }

		// Token: 0x0601E046 RID: 122950 RVA: 0x00436925 File Offset: 0x00434B25
		public ICheckJigsawItemMoveT()
		{
			this.Type = ECheckJigsawInfoType.CheckJigsawItemPlaceIndex;
			this.ItemEntityId = 0;
			this.Compare = ECompare.Eq;
		}
	}
}
