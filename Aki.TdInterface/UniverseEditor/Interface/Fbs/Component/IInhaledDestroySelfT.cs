using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200540B RID: 21515
	public class IInhaledDestroySelfT
	{
		// Token: 0x17009E4B RID: 40523
		// (get) Token: 0x0602355D RID: 144733 RVA: 0x004E415A File Offset: 0x004E235A
		// (set) Token: 0x0602355E RID: 144734 RVA: 0x004E4162 File Offset: 0x004E2362
		public EInhaledPerResultType Type { get; set; }

		// Token: 0x0602355F RID: 144735 RVA: 0x004E416B File Offset: 0x004E236B
		public IInhaledDestroySelfT()
		{
			this.Type = EInhaledPerResultType.DestroySelf;
		}
	}
}
