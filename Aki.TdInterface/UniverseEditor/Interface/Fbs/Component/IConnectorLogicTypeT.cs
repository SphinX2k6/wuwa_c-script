using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005007 RID: 20487
	public class IConnectorLogicTypeT
	{
		// Token: 0x1700947B RID: 38011
		// (get) Token: 0x06020C4B RID: 134219 RVA: 0x0048E6D7 File Offset: 0x0048C8D7
		// (set) Token: 0x06020C4C RID: 134220 RVA: 0x0048E6DF File Offset: 0x0048C8DF
		public EConnectorLogicType Type { get; set; }

		// Token: 0x1700947C RID: 38012
		// (get) Token: 0x06020C4D RID: 134221 RVA: 0x0048E6E8 File Offset: 0x0048C8E8
		// (set) Token: 0x06020C4E RID: 134222 RVA: 0x0048E6F0 File Offset: 0x0048C8F0
		public IConnectorEffectConfigT EffectConfig { get; set; }

		// Token: 0x06020C4F RID: 134223 RVA: 0x0048E6F9 File Offset: 0x0048C8F9
		public IConnectorLogicTypeT()
		{
			this.Type = EConnectorLogicType.Range;
			this.EffectConfig = null;
		}
	}
}
