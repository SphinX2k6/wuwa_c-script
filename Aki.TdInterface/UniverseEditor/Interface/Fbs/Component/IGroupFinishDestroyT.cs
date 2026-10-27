using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005354 RID: 21332
	public class IGroupFinishDestroyT
	{
		// Token: 0x17009CBA RID: 40122
		// (get) Token: 0x06022E56 RID: 142934 RVA: 0x004D568B File Offset: 0x004D388B
		// (set) Token: 0x06022E57 RID: 142935 RVA: 0x004D5693 File Offset: 0x004D3893
		public EGroupFinishConfig Type { get; set; }

		// Token: 0x17009CBB RID: 40123
		// (get) Token: 0x06022E58 RID: 142936 RVA: 0x004D569C File Offset: 0x004D389C
		// (set) Token: 0x06022E59 RID: 142937 RVA: 0x004D56A4 File Offset: 0x004D38A4
		public IEntityStateT SwitchSpecifiedStatus { get; set; }

		// Token: 0x06022E5A RID: 142938 RVA: 0x004D56AD File Offset: 0x004D38AD
		public IGroupFinishDestroyT()
		{
			this.Type = EGroupFinishConfig.Silence;
			this.SwitchSpecifiedStatus = null;
		}
	}
}
