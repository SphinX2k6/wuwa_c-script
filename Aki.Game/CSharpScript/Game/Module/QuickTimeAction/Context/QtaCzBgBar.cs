using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02004F47 RID: 20295
	[NullableContext(1)]
	[Nullable(0)]
	public class QtaCzBgBar
	{
		// Token: 0x060340A4 RID: 213156 RVA: 0x00C345FC File Offset: 0x00C327FC
		public void InitByConfig(SQtaCustomizationParam_BgBar cfg)
		{
			this.CzProgress.InitByConfig(cfg.Progress, EQtaCustomization_ProgressResetType.停止);
			this.Anchor = new FLinearColor?(cfg.Anchor);
			this.Angle = cfg.Angle;
		}

		// Token: 0x0401BA3E RID: 113214
		public QtaCzProgress CzProgress = new QtaCzProgress();

		// Token: 0x0401BA3F RID: 113215
		public FLinearColor? Anchor;

		// Token: 0x0401BA40 RID: 113216
		public float Angle;
	}
}
