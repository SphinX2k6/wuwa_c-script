using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02003F10 RID: 16144
	[NullableContext(1)]
	[Nullable(0)]
	public class QtaCzBgBar
	{
		// Token: 0x06028F12 RID: 167698 RVA: 0x00B7DD9C File Offset: 0x00B7BF9C
		public void InitByConfig(SQtaCustomizationParam_BgBar cfg)
		{
			this.CzProgress.InitByConfig(cfg.Progress, EQtaCustomization_ProgressResetType.停止);
			this.Anchor = new FLinearColor?(cfg.Anchor);
			this.Angle = cfg.Angle;
		}

		// Token: 0x04016413 RID: 91155
		public QtaCzProgress CzProgress = new QtaCzProgress();

		// Token: 0x04016414 RID: 91156
		public FLinearColor? Anchor;

		// Token: 0x04016415 RID: 91157
		public float Angle;
	}
}
