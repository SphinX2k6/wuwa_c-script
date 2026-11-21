using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005563 RID: 21859
	public class IConnectorEffectConfigT
	{
		// Token: 0x17009C56 RID: 40022
		// (get) Token: 0x06022B53 RID: 142163 RVA: 0x004C7EA2 File Offset: 0x004C60A2
		// (set) Token: 0x06022B54 RID: 142164 RVA: 0x004C7EAA File Offset: 0x004C60AA
		public string EffectPath { get; set; }

		// Token: 0x17009C57 RID: 40023
		// (get) Token: 0x06022B55 RID: 142165 RVA: 0x004C7EB3 File Offset: 0x004C60B3
		// (set) Token: 0x06022B56 RID: 142166 RVA: 0x004C7EBB File Offset: 0x004C60BB
		public string StartPoint { get; set; }

		// Token: 0x17009C58 RID: 40024
		// (get) Token: 0x06022B57 RID: 142167 RVA: 0x004C7EC4 File Offset: 0x004C60C4
		// (set) Token: 0x06022B58 RID: 142168 RVA: 0x004C7ECC File Offset: 0x004C60CC
		public string EndPoint { get; set; }

		// Token: 0x06022B59 RID: 142169 RVA: 0x004C7ED5 File Offset: 0x004C60D5
		public IConnectorEffectConfigT()
		{
			this.EffectPath = null;
			this.StartPoint = null;
			this.EndPoint = null;
		}
	}
}
