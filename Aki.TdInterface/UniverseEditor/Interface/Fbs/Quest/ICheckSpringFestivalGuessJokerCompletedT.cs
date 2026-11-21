using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004185 RID: 16773
	public class ICheckSpringFestivalGuessJokerCompletedT
	{
		// Token: 0x170071A4 RID: 29092
		// (get) Token: 0x0601716F RID: 94575 RVA: 0x0034A892 File Offset: 0x00348A92
		// (set) Token: 0x06017170 RID: 94576 RVA: 0x0034A89A File Offset: 0x00348A9A
		public ESpringFestivalGameplayType Type { get; set; }

		// Token: 0x170071A5 RID: 29093
		// (get) Token: 0x06017171 RID: 94577 RVA: 0x0034A8A3 File Offset: 0x00348AA3
		// (set) Token: 0x06017172 RID: 94578 RVA: 0x0034A8AB File Offset: 0x00348AAB
		public int Id { get; set; }

		// Token: 0x170071A6 RID: 29094
		// (get) Token: 0x06017173 RID: 94579 RVA: 0x0034A8B4 File Offset: 0x00348AB4
		// (set) Token: 0x06017174 RID: 94580 RVA: 0x0034A8BC File Offset: 0x00348ABC
		public byte NullMask { get; set; }

		// Token: 0x06017175 RID: 94581 RVA: 0x0034A8C5 File Offset: 0x00348AC5
		public ICheckSpringFestivalGuessJokerCompletedT()
		{
			this.Type = ESpringFestivalGameplayType.MixDrinks;
			this.Id = 0;
			this.NullMask = 0;
		}
	}
}
