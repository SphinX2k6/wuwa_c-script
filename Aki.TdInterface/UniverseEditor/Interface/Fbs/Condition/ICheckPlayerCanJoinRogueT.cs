using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AE2 RID: 19170
	public class ICheckPlayerCanJoinRogueT
	{
		// Token: 0x17008AFC RID: 35580
		// (get) Token: 0x0601E1D2 RID: 123346 RVA: 0x0043955E File Offset: 0x0043775E
		// (set) Token: 0x0601E1D3 RID: 123347 RVA: 0x00439566 File Offset: 0x00437766
		public ECheckPlayerCanJoinActivityType Type { get; set; }

		// Token: 0x17008AFD RID: 35581
		// (get) Token: 0x0601E1D4 RID: 123348 RVA: 0x0043956F File Offset: 0x0043776F
		// (set) Token: 0x0601E1D5 RID: 123349 RVA: 0x00439577 File Offset: 0x00437777
		public bool CanJoin { get; set; }

		// Token: 0x17008AFE RID: 35582
		// (get) Token: 0x0601E1D6 RID: 123350 RVA: 0x00439580 File Offset: 0x00437780
		// (set) Token: 0x0601E1D7 RID: 123351 RVA: 0x00439588 File Offset: 0x00437788
		public ERogueThemeType RogueType { get; set; }

		// Token: 0x0601E1D8 RID: 123352 RVA: 0x00439591 File Offset: 0x00437791
		public ICheckPlayerCanJoinRogueT()
		{
			this.Type = ECheckPlayerCanJoinActivityType.Rogue;
			this.CanJoin = false;
			this.RogueType = ERogueThemeType.ZhongQu;
		}
	}
}
