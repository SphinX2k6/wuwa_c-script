using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x020052B2 RID: 21170
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballMainChildViewBase<TViewModel> : PinballMainChildViewBase
	{
		// Token: 0x1700666C RID: 26220
		// (get) Token: 0x06034B0E RID: 215822 RVA: 0x00EBC047 File Offset: 0x00EBA247
		// (set) Token: 0x06034B0F RID: 215823 RVA: 0x00EBC054 File Offset: 0x00EBA254
		public new TViewModel ViewModel
		{
			get
			{
				return (TViewModel)((object)this.ViewModel);
			}
			set
			{
				this.ViewModel = value;
			}
		}
	}
}
