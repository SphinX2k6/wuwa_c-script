using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B61 RID: 27489
	public class ICustomAlertValueT
	{
		// Token: 0x1700C9C9 RID: 51657
		// (get) Token: 0x0602F4E3 RID: 193763 RVA: 0x0067508C File Offset: 0x0067328C
		// (set) Token: 0x0602F4E4 RID: 193764 RVA: 0x00675094 File Offset: 0x00673294
		public EValueChangeType Type { get; set; }

		// Token: 0x1700C9CA RID: 51658
		// (get) Token: 0x0602F4E5 RID: 193765 RVA: 0x0067509D File Offset: 0x0067329D
		// (set) Token: 0x0602F4E6 RID: 193766 RVA: 0x006750A5 File Offset: 0x006732A5
		public float CustomValue { get; set; }

		// Token: 0x0602F4E7 RID: 193767 RVA: 0x006750AE File Offset: 0x006732AE
		public ICustomAlertValueT()
		{
			this.Type = EValueChangeType.AddOrSub;
			this.CustomValue = 0f;
		}
	}
}
