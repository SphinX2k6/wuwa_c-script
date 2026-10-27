using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E73 RID: 15987
	public class IFreezeOnSightGamePlayConfigT
	{
		// Token: 0x17006EE1 RID: 28385
		// (get) Token: 0x06016861 RID: 92257 RVA: 0x0034152A File Offset: 0x0033F72A
		// (set) Token: 0x06016862 RID: 92258 RVA: 0x00341532 File Offset: 0x0033F732
		public ESpecialGamePlayConfigType Type { get; set; }

		// Token: 0x06016863 RID: 92259 RVA: 0x0034153B File Offset: 0x0033F73B
		public IFreezeOnSightGamePlayConfigT()
		{
			this.Type = ESpecialGamePlayConfigType.Stalking;
		}
	}
}
