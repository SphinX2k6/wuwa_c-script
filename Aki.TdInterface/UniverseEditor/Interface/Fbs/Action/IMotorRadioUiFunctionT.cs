using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B2E RID: 27438
	public class IMotorRadioUiFunctionT
	{
		// Token: 0x1700CBE7 RID: 52199
		// (get) Token: 0x06030291 RID: 197265 RVA: 0x0068BC4B File Offset: 0x00689E4B
		// (set) Token: 0x06030292 RID: 197266 RVA: 0x0068BC53 File Offset: 0x00689E53
		public EEnableFunctionType Type { get; set; }

		// Token: 0x1700CBE8 RID: 52200
		// (get) Token: 0x06030293 RID: 197267 RVA: 0x0068BC5C File Offset: 0x00689E5C
		// (set) Token: 0x06030294 RID: 197268 RVA: 0x0068BC64 File Offset: 0x00689E64
		public TMotorRadioOperationRestrictionUnion DisplayMode { get; set; }

		// Token: 0x06030295 RID: 197269 RVA: 0x0068BC6D File Offset: 0x00689E6D
		public IMotorRadioUiFunctionT()
		{
			this.Type = EEnableFunctionType.TeleportDungeon;
			this.DisplayMode = null;
		}
	}
}
