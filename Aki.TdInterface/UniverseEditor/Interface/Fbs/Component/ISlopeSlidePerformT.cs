using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005939 RID: 22841
	public class ISlopeSlidePerformT
	{
		// Token: 0x1700AB72 RID: 43890
		// (get) Token: 0x06026A68 RID: 158312 RVA: 0x00552C32 File Offset: 0x00550E32
		// (set) Token: 0x06026A69 RID: 158313 RVA: 0x00552C3A File Offset: 0x00550E3A
		public ESlidePerformType Type { get; set; }

		// Token: 0x1700AB73 RID: 43891
		// (get) Token: 0x06026A6A RID: 158314 RVA: 0x00552C43 File Offset: 0x00550E43
		// (set) Token: 0x06026A6B RID: 158315 RVA: 0x00552C4B File Offset: 0x00550E4B
		public int TriggerLandingDistance { get; set; }

		// Token: 0x1700AB74 RID: 43892
		// (get) Token: 0x06026A6C RID: 158316 RVA: 0x00552C54 File Offset: 0x00550E54
		// (set) Token: 0x06026A6D RID: 158317 RVA: 0x00552C5C File Offset: 0x00550E5C
		public int FallbackLandingPointId { get; set; }

		// Token: 0x1700AB75 RID: 43893
		// (get) Token: 0x06026A6E RID: 158318 RVA: 0x00552C65 File Offset: 0x00550E65
		// (set) Token: 0x06026A6F RID: 158319 RVA: 0x00552C6D File Offset: 0x00550E6D
		public bool IsAllowJump { get; set; }

		// Token: 0x1700AB76 RID: 43894
		// (get) Token: 0x06026A70 RID: 158320 RVA: 0x00552C76 File Offset: 0x00550E76
		// (set) Token: 0x06026A71 RID: 158321 RVA: 0x00552C7E File Offset: 0x00550E7E
		public byte NullMask { get; set; }

		// Token: 0x06026A72 RID: 158322 RVA: 0x00552C87 File Offset: 0x00550E87
		public ISlopeSlidePerformT()
		{
			this.Type = ESlidePerformType.SlopeSlide;
			this.TriggerLandingDistance = 0;
			this.FallbackLandingPointId = 0;
			this.IsAllowJump = false;
			this.NullMask = 0;
		}
	}
}
