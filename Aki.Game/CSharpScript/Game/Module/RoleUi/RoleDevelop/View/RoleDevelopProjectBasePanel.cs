using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003CFB RID: 15611
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoleDevelopProjectBasePanel : UiPanelBase
	{
		// Token: 0x06027F67 RID: 163687 RVA: 0x00B2E3A7 File Offset: 0x00B2C5A7
		protected override void OnBeforeCreateImplement()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x06027F68 RID: 163688 RVA: 0x00B2E3C4 File Offset: 0x00B2C5C4
		public void RefreshView(RoleDevelopData data, bool forceRefresh = false, bool isActive = true)
		{
			this.Data = data;
			this.OnDataChanged();
			bool flag = forceRefresh || this.PendingForceRefresh;
			if (!isActive)
			{
				this.PendingForceRefresh = flag;
				return;
			}
			this.PendingForceRefresh = false;
			this.OnRefreshView(flag);
		}

		// Token: 0x06027F69 RID: 163689
		protected abstract void OnRefreshView(bool forceRefresh);

		// Token: 0x06027F6A RID: 163690 RVA: 0x00B2E404 File Offset: 0x00B2C604
		protected virtual void OnDataChanged()
		{
		}

		// Token: 0x06027F6B RID: 163691 RVA: 0x00B2E406 File Offset: 0x00B2C606
		public virtual void OnCommonItemCountAnyChange(int configId)
		{
		}

		// Token: 0x06027F6C RID: 163692 RVA: 0x00B2E408 File Offset: 0x00B2C608
		public void PlaySequenceByName(string sequenceName, bool blockClick = false)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName(sequenceName, blockClick, null);
		}

		// Token: 0x06027F6D RID: 163693 RVA: 0x00B2E430 File Offset: 0x00B2C630
		public void StopSequenceByName(string sequenceName, bool needEvent = false, bool toLastFrame = false)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.StopSequenceByKey(sequenceName, needEvent, toLastFrame);
		}

		// Token: 0x04015C4E RID: 89166
		[Nullable(2)]
		protected RoleDevelopData Data;

		// Token: 0x04015C4F RID: 89167
		[Nullable(2)]
		public UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x04015C50 RID: 89168
		private bool PendingForceRefresh;
	}
}
