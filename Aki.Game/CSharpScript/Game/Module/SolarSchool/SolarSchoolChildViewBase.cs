using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityCommonRootView;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A13 RID: 23059
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolChildViewBase : CommonChildViewBase
	{
		// Token: 0x17006C6D RID: 27757
		// (get) Token: 0x06038C8D RID: 232589 RVA: 0x00FE5356 File Offset: 0x00FE3556
		protected SolarSchoolRootViewModel SolarSchoolViewModel
		{
			get
			{
				return (SolarSchoolRootViewModel)this.ViewModel;
			}
		}

		// Token: 0x17006C6E RID: 27758
		// (get) Token: 0x06038C8E RID: 232590 RVA: 0x00FE5363 File Offset: 0x00FE3563
		public virtual bool BackgroundVisible
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17006C6F RID: 27759
		// (get) Token: 0x06038C8F RID: 232591 RVA: 0x00FE5366 File Offset: 0x00FE3566
		public virtual bool SeasonFxVisible
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17006C70 RID: 27760
		// (get) Token: 0x06038C90 RID: 232592 RVA: 0x00FE5369 File Offset: 0x00FE3569
		public override bool ShouldKeepInStack
		{
			get
			{
				return !this.PresentFinished;
			}
		}

		// Token: 0x06038C91 RID: 232593 RVA: 0x00FE5374 File Offset: 0x00FE3574
		protected virtual SolarSchoolRootUiParams CreateRootUiParams()
		{
			return new SolarSchoolRootUiParams();
		}

		// Token: 0x06038C92 RID: 232594 RVA: 0x00FE537B File Offset: 0x00FE357B
		protected override void OnBeforeShowImplement()
		{
			base.OnBeforeShowImplement();
			this.SolarSchoolViewModel.RequestRootUi(this.CreateRootUiParams());
		}

		// Token: 0x06038C93 RID: 232595 RVA: 0x00FE5394 File Offset: 0x00FE3594
		public void MarkPresentFinished()
		{
			this.PresentFinished = true;
		}

		// Token: 0x06038C94 RID: 232596 RVA: 0x00FE539D File Offset: 0x00FE359D
		public void ClearPresentFinished()
		{
			this.PresentFinished = false;
		}

		// Token: 0x0401DE44 RID: 122436
		private bool PresentFinished;
	}
}
