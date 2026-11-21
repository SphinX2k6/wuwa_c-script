using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x020052B5 RID: 21173
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class PinballMainRootViewBase<TViewModel> : PinballMainRootViewBase
	{
		// Token: 0x06034B3E RID: 215870 RVA: 0x00EBC8EB File Offset: 0x00EBAAEB
		[NullableContext(1)]
		public PinballMainRootViewBase(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x1700666D RID: 26221
		// (get) Token: 0x06034B3F RID: 215871 RVA: 0x00EBC8F4 File Offset: 0x00EBAAF4
		// (set) Token: 0x06034B40 RID: 215872 RVA: 0x00EBC901 File Offset: 0x00EBAB01
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
