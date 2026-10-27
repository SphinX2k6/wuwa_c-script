using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005408 RID: 21512
	public class IInhaledChangeSelfStateT
	{
		// Token: 0x17009E47 RID: 40519
		// (get) Token: 0x06023549 RID: 144713 RVA: 0x004E3FBF File Offset: 0x004E21BF
		// (set) Token: 0x0602354A RID: 144714 RVA: 0x004E3FC7 File Offset: 0x004E21C7
		public EInhaledPerResultType Type { get; set; }

		// Token: 0x17009E48 RID: 40520
		// (get) Token: 0x0602354B RID: 144715 RVA: 0x004E3FD0 File Offset: 0x004E21D0
		// (set) Token: 0x0602354C RID: 144716 RVA: 0x004E3FD8 File Offset: 0x004E21D8
		public string ChangeSelfState { get; set; }

		// Token: 0x0602354D RID: 144717 RVA: 0x004E3FE1 File Offset: 0x004E21E1
		public IInhaledChangeSelfStateT()
		{
			this.Type = EInhaledPerResultType.DestroySelf;
			this.ChangeSelfState = null;
		}
	}
}
