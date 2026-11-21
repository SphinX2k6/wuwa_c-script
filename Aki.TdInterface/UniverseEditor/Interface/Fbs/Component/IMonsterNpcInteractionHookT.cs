using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B2C RID: 23340
	public class IMonsterNpcInteractionHookT
	{
		// Token: 0x1700AA5C RID: 43612
		// (get) Token: 0x06026638 RID: 157240 RVA: 0x005422A2 File Offset: 0x005404A2
		// (set) Token: 0x06026639 RID: 157241 RVA: 0x005422AA File Offset: 0x005404AA
		public EMonsterNpcInteractionType Type { get; set; }

		// Token: 0x0602663A RID: 157242 RVA: 0x005422B3 File Offset: 0x005404B3
		public IMonsterNpcInteractionHookT()
		{
			this.Type = EMonsterNpcInteractionType.WallRun;
		}
	}
}
