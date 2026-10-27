using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CB2 RID: 23730
	[NullableContext(2)]
	[Nullable(0)]
	public class AutoPilotTrackedMarksView : BattleChildView
	{
		// Token: 0x0603BF3E RID: 245566 RVA: 0x00E545C9 File Offset: 0x00E527C9
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.AutoPilotTrackMark = new AutoPilotTrackMark();
			this.AutoPilotTrackMark.Initialize(this.RootItem);
		}

		// Token: 0x0603BF3F RID: 245567 RVA: 0x00E545EE File Offset: 0x00E527EE
		public override void Reset()
		{
			base.Reset();
			AutoPilotTrackMark autoPilotTrackMark = this.AutoPilotTrackMark;
			if (autoPilotTrackMark != null)
			{
				autoPilotTrackMark.Destroy(null);
			}
			this.AutoPilotTrackMark = null;
		}

		// Token: 0x0603BF40 RID: 245568 RVA: 0x00E5460F File Offset: 0x00E5280F
		public void OnShowBattleChildViewPanel()
		{
			AutoPilotTrackMark autoPilotTrackMark = this.AutoPilotTrackMark;
			if (autoPilotTrackMark == null)
			{
				return;
			}
			autoPilotTrackMark.OnUiShow();
		}

		// Token: 0x0603BF41 RID: 245569 RVA: 0x00E54621 File Offset: 0x00E52821
		public void Update(float delta)
		{
			AutoPilotTrackMark autoPilotTrackMark = this.AutoPilotTrackMark;
			if (autoPilotTrackMark == null)
			{
				return;
			}
			autoPilotTrackMark.Update(delta);
		}

		// Token: 0x0603BF42 RID: 245570 RVA: 0x00E54634 File Offset: 0x00E52834
		public void OnHideBattleChildViewPanel()
		{
			AutoPilotTrackMark autoPilotTrackMark = this.AutoPilotTrackMark;
			if (autoPilotTrackMark == null)
			{
				return;
			}
			autoPilotTrackMark.OnUiHide();
		}

		// Token: 0x0603BF43 RID: 245571 RVA: 0x00E54646 File Offset: 0x00E52846
		protected override bool DestroyOverride()
		{
			return true;
		}

		// Token: 0x0401F49F RID: 128159
		private AutoPilotTrackMark AutoPilotTrackMark;
	}
}
