using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F58 RID: 28504
	public class ISelfEntityT
	{
		// Token: 0x1700D3CA RID: 54218
		// (get) Token: 0x060325B9 RID: 206265 RVA: 0x006CC922 File Offset: 0x006CAB22
		// (set) Token: 0x060325BA RID: 206266 RVA: 0x006CC92A File Offset: 0x006CAB2A
		public ETargetEntityType Type { get; set; }

		// Token: 0x060325BB RID: 206267 RVA: 0x006CC933 File Offset: 0x006CAB33
		public ISelfEntityT()
		{
			this.Type = ETargetEntityType.Target;
		}
	}
}
