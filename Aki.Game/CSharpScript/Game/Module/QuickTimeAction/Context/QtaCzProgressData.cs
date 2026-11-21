using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02003F0E RID: 16142
	public class QtaCzProgressData
	{
		// Token: 0x06028F0A RID: 167690 RVA: 0x00B7DB40 File Offset: 0x00B7BD40
		[NullableContext(1)]
		public void InitByConfig(SQtaCustomizationParam_Progress cfg)
		{
			this.Init = cfg.InitProgress * 0.01f;
			this.Max = cfg.MaxProgress * 0.01f;
			this.AutoSpeed = cfg.AutoSpeed * 0.01f;
			this.AdditionSpeed = cfg.AdditionSpeed * 0.01f;
		}

		// Token: 0x04016409 RID: 91145
		private const float PERCENT = 0.01f;

		// Token: 0x0401640A RID: 91146
		public float Init;

		// Token: 0x0401640B RID: 91147
		public float Max;

		// Token: 0x0401640C RID: 91148
		public float AutoSpeed;

		// Token: 0x0401640D RID: 91149
		public float AdditionSpeed;
	}
}
