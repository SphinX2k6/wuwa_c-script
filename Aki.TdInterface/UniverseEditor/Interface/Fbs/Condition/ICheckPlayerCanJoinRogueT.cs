using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FB7 RID: 20407
	public class ICheckPlayerCanJoinRogueT
	{
		// Token: 0x170091F3 RID: 37363
		// (get) Token: 0x0601FCE7 RID: 130279 RVA: 0x0046B20A File Offset: 0x0046940A
		// (set) Token: 0x0601FCE8 RID: 130280 RVA: 0x0046B212 File Offset: 0x00469412
		public ECheckPlayerCanJoinActivityType Type { get; set; }

		// Token: 0x170091F4 RID: 37364
		// (get) Token: 0x0601FCE9 RID: 130281 RVA: 0x0046B21B File Offset: 0x0046941B
		// (set) Token: 0x0601FCEA RID: 130282 RVA: 0x0046B223 File Offset: 0x00469423
		public bool CanJoin { get; set; }

		// Token: 0x170091F5 RID: 37365
		// (get) Token: 0x0601FCEB RID: 130283 RVA: 0x0046B22C File Offset: 0x0046942C
		// (set) Token: 0x0601FCEC RID: 130284 RVA: 0x0046B234 File Offset: 0x00469434
		public ERogueThemeType RogueType { get; set; }

		// Token: 0x0601FCED RID: 130285 RVA: 0x0046B23D File Offset: 0x0046943D
		public ICheckPlayerCanJoinRogueT()
		{
			this.Type = ECheckPlayerCanJoinActivityType.Rogue;
			this.CanJoin = false;
			this.RogueType = ERogueThemeType.ZhongQu;
		}
	}
}
