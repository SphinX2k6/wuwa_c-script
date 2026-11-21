using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005554 RID: 21844
	public class IConditionHitConfigWithBulletT
	{
		// Token: 0x17009C2B RID: 39979
		// (get) Token: 0x06022A9F RID: 141983 RVA: 0x004C64FE File Offset: 0x004C46FE
		// (set) Token: 0x06022AA0 RID: 141984 RVA: 0x004C6506 File Offset: 0x004C4706
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x17009C2C RID: 39980
		// (get) Token: 0x06022AA1 RID: 141985 RVA: 0x004C650F File Offset: 0x004C470F
		// (set) Token: 0x06022AA2 RID: 141986 RVA: 0x004C6517 File Offset: 0x004C4717
		public string State { get; set; }

		// Token: 0x17009C2D RID: 39981
		// (get) Token: 0x06022AA3 RID: 141987 RVA: 0x004C6520 File Offset: 0x004C4720
		// (set) Token: 0x06022AA4 RID: 141988 RVA: 0x004C6528 File Offset: 0x004C4728
		public THitBulletTypeUnion HitBullets { get; set; }

		// Token: 0x06022AA5 RID: 141989 RVA: 0x004C6531 File Offset: 0x004C4731
		public IConditionHitConfigWithBulletT()
		{
			this.Conditions = null;
			this.State = null;
			this.HitBullets = null;
		}
	}
}
