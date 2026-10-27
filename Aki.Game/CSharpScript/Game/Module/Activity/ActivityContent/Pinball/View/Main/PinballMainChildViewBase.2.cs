using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x02006334 RID: 25396
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballMainChildViewBase<TViewModel> : PinballMainChildViewBase
	{
		// Token: 0x1700930A RID: 37642
		// (get) Token: 0x0603FE4D RID: 261709 RVA: 0x00F750EB File Offset: 0x00F732EB
		// (set) Token: 0x0603FE4E RID: 261710 RVA: 0x00F750F8 File Offset: 0x00F732F8
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
