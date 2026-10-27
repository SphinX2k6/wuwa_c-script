using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02004F45 RID: 20293
	public class QtaCzProgressData
	{
		// Token: 0x0603409C RID: 213148 RVA: 0x00C343A0 File Offset: 0x00C325A0
		[NullableContext(1)]
		public void InitByConfig(SQtaCustomizationParam_Progress cfg)
		{
			this.Init = cfg.InitProgress * 0.01f;
			this.Max = cfg.MaxProgress * 0.01f;
			this.AutoSpeed = cfg.AutoSpeed * 0.01f;
			this.AdditionSpeed = cfg.AdditionSpeed * 0.01f;
		}

		// Token: 0x0401BA34 RID: 113204
		private const float PERCENT = 0.01f;

		// Token: 0x0401BA35 RID: 113205
		public float Init;

		// Token: 0x0401BA36 RID: 113206
		public float Max;

		// Token: 0x0401BA37 RID: 113207
		public float AutoSpeed;

		// Token: 0x0401BA38 RID: 113208
		public float AdditionSpeed;
	}
}
