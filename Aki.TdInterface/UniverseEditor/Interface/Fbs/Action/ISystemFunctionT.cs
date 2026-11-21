using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A53 RID: 31315
	public class ISystemFunctionT
	{
		// Token: 0x1700E56F RID: 58735
		// (get) Token: 0x06037317 RID: 226071 RVA: 0x0075F672 File Offset: 0x0075D872
		// (set) Token: 0x06037318 RID: 226072 RVA: 0x0075F67A File Offset: 0x0075D87A
		public ESystemFunction Type { get; set; }

		// Token: 0x06037319 RID: 226073 RVA: 0x0075F683 File Offset: 0x0075D883
		public ISystemFunctionT()
		{
			this.Type = ESystemFunction.BuyGoods;
		}
	}
}
