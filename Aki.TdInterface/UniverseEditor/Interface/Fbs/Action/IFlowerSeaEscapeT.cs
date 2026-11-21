using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E91 RID: 28305
	public class IFlowerSeaEscapeT
	{
		// Token: 0x1700CF6F RID: 53103
		// (get) Token: 0x06030EA0 RID: 200352 RVA: 0x006A2601 File Offset: 0x006A0801
		// (set) Token: 0x06030EA1 RID: 200353 RVA: 0x006A2609 File Offset: 0x006A0809
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700CF70 RID: 53104
		// (get) Token: 0x06030EA2 RID: 200354 RVA: 0x006A2612 File Offset: 0x006A0812
		// (set) Token: 0x06030EA3 RID: 200355 RVA: 0x006A261A File Offset: 0x006A081A
		public int EndAreaEntityId { get; set; }

		// Token: 0x1700CF71 RID: 53105
		// (get) Token: 0x06030EA4 RID: 200356 RVA: 0x006A2623 File Offset: 0x006A0823
		// (set) Token: 0x06030EA5 RID: 200357 RVA: 0x006A262B File Offset: 0x006A082B
		public string ConfigDa { get; set; }

		// Token: 0x1700CF72 RID: 53106
		// (get) Token: 0x06030EA6 RID: 200358 RVA: 0x006A2634 File Offset: 0x006A0834
		// (set) Token: 0x06030EA7 RID: 200359 RVA: 0x006A263C File Offset: 0x006A083C
		public string SpreadingState { get; set; }

		// Token: 0x1700CF73 RID: 53107
		// (get) Token: 0x06030EA8 RID: 200360 RVA: 0x006A2645 File Offset: 0x006A0845
		// (set) Token: 0x06030EA9 RID: 200361 RVA: 0x006A264D File Offset: 0x006A084D
		public string PausedState { get; set; }

		// Token: 0x1700CF74 RID: 53108
		// (get) Token: 0x06030EAA RID: 200362 RVA: 0x006A2656 File Offset: 0x006A0856
		// (set) Token: 0x06030EAB RID: 200363 RVA: 0x006A265E File Offset: 0x006A085E
		public string ResetState { get; set; }

		// Token: 0x06030EAC RID: 200364 RVA: 0x006A2667 File Offset: 0x006A0867
		public IFlowerSeaEscapeT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.EndAreaEntityId = 0;
			this.ConfigDa = null;
			this.SpreadingState = null;
			this.PausedState = null;
			this.ResetState = null;
		}
	}
}
