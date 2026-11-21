using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005566 RID: 21862
	public class IConnectorLogicTypeT
	{
		// Token: 0x17009C5C RID: 40028
		// (get) Token: 0x06022B6B RID: 142187 RVA: 0x004C8127 File Offset: 0x004C6327
		// (set) Token: 0x06022B6C RID: 142188 RVA: 0x004C812F File Offset: 0x004C632F
		public EConnectorLogicType Type { get; set; }

		// Token: 0x17009C5D RID: 40029
		// (get) Token: 0x06022B6D RID: 142189 RVA: 0x004C8138 File Offset: 0x004C6338
		// (set) Token: 0x06022B6E RID: 142190 RVA: 0x004C8140 File Offset: 0x004C6340
		public IConnectorEffectConfigT EffectConfig { get; set; }

		// Token: 0x06022B6F RID: 142191 RVA: 0x004C8149 File Offset: 0x004C6349
		public IConnectorLogicTypeT()
		{
			this.Type = EConnectorLogicType.Range;
			this.EffectConfig = null;
		}
	}
}
