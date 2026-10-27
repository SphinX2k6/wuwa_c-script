using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200515B RID: 20827
	[NullableContext(2)]
	[Nullable(0)]
	public class GymItemBase : UiPanelBase
	{
		// Token: 0x060353EA RID: 218090 RVA: 0x00C9B864 File Offset: 0x00C99A64
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

		// Token: 0x060353EB RID: 218091 RVA: 0x00C9B8C0 File Offset: 0x00C99AC0
		public double GetAnchorOffsetX()
		{
			return (double)this.RootItem.GetAnchorOffsetX();
		}

		// Token: 0x060353EC RID: 218092 RVA: 0x00C9B8CE File Offset: 0x00C99ACE
		public virtual void Refresh()
		{
		}

		// Token: 0x060353ED RID: 218093 RVA: 0x00C9B8D0 File Offset: 0x00C99AD0
		protected void OnFocus()
		{
			if (this.Level > 0 && this.CallbackOnFocus != null)
			{
				this.CallbackOnFocus(this.Level);
			}
		}

		// Token: 0x060353EE RID: 218094 RVA: 0x00C9B8F4 File Offset: 0x00C99AF4
		protected void OnHover()
		{
			if (this.Level > 0 && this.CallbackOnHover != null)
			{
				this.CallbackOnHover(this.Level);
			}
		}

		// Token: 0x060353EF RID: 218095 RVA: 0x00C9B918 File Offset: 0x00C99B18
		protected void OnUnHover()
		{
			if (this.Level > 0 && this.CallbackOnUnHover != null)
			{
				this.CallbackOnUnHover(this.Level);
			}
		}

		// Token: 0x060353F0 RID: 218096 RVA: 0x00C9B93C File Offset: 0x00C99B3C
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

		// Token: 0x060353F1 RID: 218097 RVA: 0x00C9B9BC File Offset: 0x00C99BBC
		protected bool GetRedDotState()
		{
			return this.Level > 0 && PhantomArenaModel.Instance.GetGymRedDotById(this.Level, this.ActivityId);
		}

		// Token: 0x060353F2 RID: 218098 RVA: 0x00C9B9DF File Offset: 0x00C99BDF
		public virtual void RefreshRedDot()
		{
		}

		// Token: 0x0401C54E RID: 116046
		public int Level = -1;

		// Token: 0x0401C54F RID: 116047
		public int ActivityId;

		// Token: 0x0401C550 RID: 116048
		public Action<int> CallbackOnClick;

		// Token: 0x0401C551 RID: 116049
		public Action<int> CallbackOnHover;

		// Token: 0x0401C552 RID: 116050
		public Action<int> CallbackOnFocus;

		// Token: 0x0401C553 RID: 116051
		public Action<int> CallbackOnUnHover;

		// Token: 0x0401C554 RID: 116052
		protected UiSequencePlayer SequencePlayer;
	}
}
