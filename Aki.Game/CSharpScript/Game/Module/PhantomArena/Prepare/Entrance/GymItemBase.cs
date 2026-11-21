using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200412B RID: 16683
	[NullableContext(2)]
	[Nullable(0)]
	public class GymItemBase : UiPanelBase
	{
		// Token: 0x0602A2E6 RID: 172774 RVA: 0x00BE8D64 File Offset: 0x00BE6F64
		protected void OnClickLevel()
		{
			if (this.Level > 0 && this.CallbackOnClick != null)
			{
				if (!PhantomArenaModel.Instance.IsGymLock(this.Level, this.ActivityId))
				{
					this.CallbackOnClick(this.Level);
					return;
				}
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattleGym_Locked", Array.Empty<object>());
			}
		}

		// Token: 0x0602A2E7 RID: 172775 RVA: 0x00BE8DC0 File Offset: 0x00BE6FC0
		public double GetAnchorOffsetX()
		{
			return (double)this.RootItem.GetAnchorOffsetX();
		}

		// Token: 0x0602A2E8 RID: 172776 RVA: 0x00BE8DCE File Offset: 0x00BE6FCE
		public virtual void Refresh()
		{
		}

		// Token: 0x0602A2E9 RID: 172777 RVA: 0x00BE8DD0 File Offset: 0x00BE6FD0
		protected void OnFocus()
		{
			if (this.Level > 0 && this.CallbackOnFocus != null)
			{
				this.CallbackOnFocus(this.Level);
			}
		}

		// Token: 0x0602A2EA RID: 172778 RVA: 0x00BE8DF4 File Offset: 0x00BE6FF4
		protected void OnHover()
		{
			if (this.Level > 0 && this.CallbackOnHover != null)
			{
				this.CallbackOnHover(this.Level);
			}
		}

		// Token: 0x0602A2EB RID: 172779 RVA: 0x00BE8E18 File Offset: 0x00BE7018
		protected void OnUnHover()
		{
			if (this.Level > 0 && this.CallbackOnUnHover != null)
			{
				this.CallbackOnUnHover(this.Level);
			}
		}

		// Token: 0x0602A2EC RID: 172780 RVA: 0x00BE8E3C File Offset: 0x00BE703C
		public void PlayUnlock()
		{
			if (this.Level <= 0)
			{
				return;
			}
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			if (!instance.IsGymLock(this.Level, this.ActivityId) && !instance.IsGymUnlockChecked(this.Level, this.ActivityId))
			{
				PhantomArenaModel.Instance.SetGymUnlockChecked(this.Level, this.ActivityId);
				this.Refresh();
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PlaySequence("Unlock", false, null);
			}
		}

		// Token: 0x0602A2ED RID: 172781 RVA: 0x00BE8EBC File Offset: 0x00BE70BC
		protected bool GetRedDotState()
		{
			return this.Level > 0 && PhantomArenaModel.Instance.GetGymRedDotById(this.Level, this.ActivityId);
		}

		// Token: 0x0602A2EE RID: 172782 RVA: 0x00BE8EDF File Offset: 0x00BE70DF
		public virtual void RefreshRedDot()
		{
		}

		// Token: 0x04016F83 RID: 94083
		public int Level = -1;

		// Token: 0x04016F84 RID: 94084
		public int ActivityId;

		// Token: 0x04016F85 RID: 94085
		public Action<int> CallbackOnClick;

		// Token: 0x04016F86 RID: 94086
		public Action<int> CallbackOnHover;

		// Token: 0x04016F87 RID: 94087
		public Action<int> CallbackOnFocus;

		// Token: 0x04016F88 RID: 94088
		public Action<int> CallbackOnUnHover;

		// Token: 0x04016F89 RID: 94089
		protected UiSequencePlayer SequencePlayer;
	}
}
