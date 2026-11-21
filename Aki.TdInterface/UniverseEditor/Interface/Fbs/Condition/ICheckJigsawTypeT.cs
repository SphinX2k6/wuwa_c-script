using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F87 RID: 20359
	public class ICheckJigsawTypeT
	{
		// Token: 0x17009198 RID: 37272
		// (get) Token: 0x0601FB61 RID: 129889 RVA: 0x0046870E File Offset: 0x0046690E
		// (set) Token: 0x0601FB62 RID: 129890 RVA: 0x00468716 File Offset: 0x00466916
		public ECheckJigsawInfoType Type { get; set; }

		// Token: 0x0601FB63 RID: 129891 RVA: 0x0046871F File Offset: 0x0046691F
		public ICheckJigsawTypeT()
		{
			this.Type = ECheckJigsawInfoType.CheckJigsawItemPlaceIndex;
		}
	}
}
