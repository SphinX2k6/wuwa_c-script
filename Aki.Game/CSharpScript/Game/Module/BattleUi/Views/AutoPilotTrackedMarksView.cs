using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C94 RID: 19604
	[NullableContext(2)]
	[Nullable(0)]
	public class AutoPilotTrackedMarksView : BattleChildView
	{
		// Token: 0x06030E91 RID: 200337 RVA: 0x00DA4C71 File Offset: 0x00DA2E71
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.AutoPilotTrackMark = new AutoPilotTrackMark();
			this.AutoPilotTrackMark.Initialize(this.RootItem);
		}

		// Token: 0x06030E92 RID: 200338 RVA: 0x00DA4C96 File Offset: 0x00DA2E96
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

		// Token: 0x06030E93 RID: 200339 RVA: 0x00DA4CB7 File Offset: 0x00DA2EB7
		public void OnShowBattleChildViewPanel()
		{
			AutoPilotTrackMark autoPilotTrackMark = this.AutoPilotTrackMark;
			if (autoPilotTrackMark == null)
			{
				return;
			}
			autoPilotTrackMark.OnUiShow();
		}

		// Token: 0x06030E94 RID: 200340 RVA: 0x00DA4CC9 File Offset: 0x00DA2EC9
		public void Update(float delta)
		{
			AutoPilotTrackMark autoPilotTrackMark = this.AutoPilotTrackMark;
			if (autoPilotTrackMark == null)
			{
				return;
			}
			autoPilotTrackMark.Update(delta);
		}

		// Token: 0x06030E95 RID: 200341 RVA: 0x00DA4CDC File Offset: 0x00DA2EDC
		public void OnHideBattleChildViewPanel()
		{
			AutoPilotTrackMark autoPilotTrackMark = this.AutoPilotTrackMark;
			if (autoPilotTrackMark == null)
			{
				return;
			}
			autoPilotTrackMark.OnUiHide();
		}

		// Token: 0x06030E96 RID: 200342 RVA: 0x00DA4CEE File Offset: 0x00DA2EEE
		protected override bool DestroyOverride()
		{
			return true;
		}

		// Token: 0x04019F58 RID: 106328
		private AutoPilotTrackMark AutoPilotTrackMark;
	}
}
