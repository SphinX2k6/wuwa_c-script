using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053FF RID: 21503
	public class IInhalationMatchingT
	{
		// Token: 0x17009E3D RID: 40509
		// (get) Token: 0x06023511 RID: 144657 RVA: 0x004E3AA7 File Offset: 0x004E1CA7
		// (set) Token: 0x06023512 RID: 144658 RVA: 0x004E3AAF File Offset: 0x004E1CAF
		public int InhalationStrength { get; set; }

		// Token: 0x17009E3E RID: 40510
		// (get) Token: 0x06023513 RID: 144659 RVA: 0x004E3AB8 File Offset: 0x004E1CB8
		// (set) Token: 0x06023514 RID: 144660 RVA: 0x004E3AC0 File Offset: 0x004E1CC0
		public ICategoryMatchingConditionT EntityMatch { get; set; }

		// Token: 0x06023515 RID: 144661 RVA: 0x004E3AC9 File Offset: 0x004E1CC9
		public IInhalationMatchingT()
		{
			this.InhalationStrength = 0;
			this.EntityMatch = null;
		}
	}
}
