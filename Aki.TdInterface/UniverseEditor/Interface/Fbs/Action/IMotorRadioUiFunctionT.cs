using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007274 RID: 29300
	public class IMotorRadioUiFunctionT
	{
		// Token: 0x1700D6CC RID: 54988
		// (get) Token: 0x060330E8 RID: 209128 RVA: 0x006E4207 File Offset: 0x006E2407
		// (set) Token: 0x060330E9 RID: 209129 RVA: 0x006E420F File Offset: 0x006E240F
		public EEnableFunctionType Type { get; set; }

		// Token: 0x1700D6CD RID: 54989
		// (get) Token: 0x060330EA RID: 209130 RVA: 0x006E4218 File Offset: 0x006E2418
		// (set) Token: 0x060330EB RID: 209131 RVA: 0x006E4220 File Offset: 0x006E2420
		public TMotorRadioOperationRestrictionUnion DisplayMode { get; set; }

		// Token: 0x060330EC RID: 209132 RVA: 0x006E4229 File Offset: 0x006E2429
		public IMotorRadioUiFunctionT()
		{
			this.Type = EEnableFunctionType.TeleportDungeon;
			this.DisplayMode = null;
		}
	}
}
