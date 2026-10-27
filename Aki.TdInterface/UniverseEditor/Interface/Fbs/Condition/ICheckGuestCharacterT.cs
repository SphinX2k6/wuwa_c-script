using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A43 RID: 19011
	public class ICheckGuestCharacterT
	{
		// Token: 0x170089A2 RID: 35234
		// (get) Token: 0x0601DC50 RID: 121936 RVA: 0x0042F960 File Offset: 0x0042DB60
		// (set) Token: 0x0601DC51 RID: 121937 RVA: 0x0042F968 File Offset: 0x0042DB68
		public ECondition Type { get; set; }

		// Token: 0x170089A3 RID: 35235
		// (get) Token: 0x0601DC52 RID: 121938 RVA: 0x0042F971 File Offset: 0x0042DB71
		// (set) Token: 0x0601DC53 RID: 121939 RVA: 0x0042F979 File Offset: 0x0042DB79
		public int GuestCharacterId { get; set; }

		// Token: 0x0601DC54 RID: 121940 RVA: 0x0042F982 File Offset: 0x0042DB82
		public ICheckGuestCharacterT()
		{
			this.Type = ECondition.CompareVar;
			this.GuestCharacterId = 0;
		}
	}
}
