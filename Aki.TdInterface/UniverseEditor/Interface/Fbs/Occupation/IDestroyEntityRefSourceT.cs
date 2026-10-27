using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004399 RID: 17305
	public class IDestroyEntityRefSourceT
	{
		// Token: 0x17007A51 RID: 31313
		// (get) Token: 0x06019C03 RID: 105475 RVA: 0x003AFC9C File Offset: 0x003ADE9C
		// (set) Token: 0x06019C04 RID: 105476 RVA: 0x003AFCA4 File Offset: 0x003ADEA4
		public ERefSourceType Type { get; set; }

		// Token: 0x17007A52 RID: 31314
		// (get) Token: 0x06019C05 RID: 105477 RVA: 0x003AFCAD File Offset: 0x003ADEAD
		// (set) Token: 0x06019C06 RID: 105478 RVA: 0x003AFCB5 File Offset: 0x003ADEB5
		public int EntityId { get; set; }

		// Token: 0x06019C07 RID: 105479 RVA: 0x003AFCBE File Offset: 0x003ADEBE
		public IDestroyEntityRefSourceT()
		{
			this.Type = ERefSourceType.AwakeEntity;
			this.EntityId = 0;
		}
	}
}
