using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x02006337 RID: 25399
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class PinballMainRootViewBase<TViewModel> : PinballMainRootViewBase
	{
		// Token: 0x0603FE7D RID: 261757 RVA: 0x00F7598F File Offset: 0x00F73B8F
		[NullableContext(1)]
		public PinballMainRootViewBase(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x1700930B RID: 37643
		// (get) Token: 0x0603FE7E RID: 261758 RVA: 0x00F75998 File Offset: 0x00F73B98
		// (set) Token: 0x0603FE7F RID: 261759 RVA: 0x00F759A5 File Offset: 0x00F73BA5
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
