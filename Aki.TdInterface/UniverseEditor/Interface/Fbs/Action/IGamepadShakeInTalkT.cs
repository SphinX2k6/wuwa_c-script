using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006874 RID: 26740
	public class IGamepadShakeInTalkT
	{
		// Token: 0x1700C69D RID: 50845
		// (get) Token: 0x0602EA29 RID: 191017 RVA: 0x0065C23B File Offset: 0x0065A43B
		// (set) Token: 0x0602EA2A RID: 191018 RVA: 0x0065C243 File Offset: 0x0065A443
		public float DelayTime { get; set; }

		// Token: 0x1700C69E RID: 50846
		// (get) Token: 0x0602EA2B RID: 191019 RVA: 0x0065C24C File Offset: 0x0065A44C
		// (set) Token: 0x0602EA2C RID: 191020 RVA: 0x0065C254 File Offset: 0x0065A454
		public IGamepadShakeOptionsT Options { get; set; }

		// Token: 0x0602EA2D RID: 191021 RVA: 0x0065C25D File Offset: 0x0065A45D
		public IGamepadShakeInTalkT()
		{
			this.DelayTime = 0f;
			this.Options = null;
		}
	}
}
