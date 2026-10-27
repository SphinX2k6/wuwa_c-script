using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x020066FC RID: 26364
	[NullableContext(2)]
	[Nullable(0)]
	public class DropCatchGameplayLeftMsgView : UiPanelBase
	{
		// Token: 0x06041DE7 RID: 269799 RVA: 0x00FF946C File Offset: 0x00FF766C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUISprite))
			};
		}

		// Token: 0x06041DE8 RID: 269800 RVA: 0x00FF94DC File Offset: 0x00FF76DC
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequence));
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06041DE9 RID: 269801 RVA: 0x00FF9538 File Offset: 0x00FF7738
		protected override void OnBeforeShow()
		{
			IDropCatchGameplayLeftMsgParams dropCatchGameplayLeftMsgParams = this.OpenParam as IDropCatchGameplayLeftMsgParams;
			EDropCatchGameplayLeftMsgType type = dropCatchGameplayLeftMsgParams.Type;
			if (type != EDropCatchGameplayLeftMsgType.Gameplay)
			{
				if (type == EDropCatchGameplayLeftMsgType.DropItem)
				{
					UUIItem item = base.GetItem(1);
					if (item != null)
					{
						item.SetUIActive(false);
					}
					UUIItem item2 = base.GetItem(2);
					if (item2 != null)
					{
						item2.SetUIActive(true);
					}
				}
			}
			else
			{
				UUIItem item3 = base.GetItem(1);
				if (item3 != null)
				{
					item3.SetUIActive(true);
				}
				UUIItem item4 = base.GetItem(2);
				if (item4 != null)
				{
					item4.SetUIActive(false);
				}
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), dropCatchGameplayLeftMsgParams.TextId, Array.Empty<object>());
			if (!StringUtils.IsEmpty(dropCatchGameplayLeftMsgParams.Icon))
			{
				base.TrySetSpriteByPath(dropCatchGameplayLeftMsgParams.Icon, base.GetSprite(3), true, null, null);
			}
		}

		// Token: 0x06041DEA RID: 269802 RVA: 0x00FF95F8 File Offset: 0x00FF77F8
		protected override void OnAfterShow()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsSequenceInPlaying("Start"))
			{
				UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 != null)
				{
					sequencePlayer2.ReplaySequence("Start");
				}
			}
			else
			{
				UiSequencePlayer sequencePlayer3 = this.SequencePlayer;
				if (sequencePlayer3 != null)
				{
					sequencePlayer3.StopSequenceByKey("Close", false, false);
				}
				UiSequencePlayer sequencePlayer4 = this.SequencePlayer;
				if (sequencePlayer4 != null)
				{
					sequencePlayer4.PlaySequence("Start", false, null);
				}
			}
			Action<bool> activeCallback = this.ActiveCallback;
			if (activeCallback != null)
			{
				activeCallback(true);
			}
			this.ClearTimer();
			IDropCatchGameplayLeftMsgParams dropCatchGameplayLeftMsgParams = this.OpenParam as IDropCatchGameplayLeftMsgParams;
			if (dropCatchGameplayLeftMsgParams.Duration == null)
			{
				return;
			}
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				UiSequencePlayer sequencePlayer5 = this.SequencePlayer;
				if (sequencePlayer5 == null)
				{
					return;
				}
				sequencePlayer5.PlaySequence("Close", false, null);
			}, dropCatchGameplayLeftMsgParams.Duration.Value * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
		}

		// Token: 0x06041DEB RID: 269803 RVA: 0x00FF96DB File Offset: 0x00FF78DB
		[NullableContext(1)]
		private void OnEndSequence(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				base.Hide(null);
			}
		}

		// Token: 0x06041DEC RID: 269804 RVA: 0x00FF96F1 File Offset: 0x00FF78F1
		private void ClearTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			}
			this.TimerHandle = null;
		}

		// Token: 0x06041DED RID: 269805 RVA: 0x00FF971D File Offset: 0x00FF791D
		protected override void OnAfterHide()
		{
			Action<bool> activeCallback = this.ActiveCallback;
			if (activeCallback == null)
			{
				return;
			}
			activeCallback(false);
		}

		// Token: 0x06041DEE RID: 269806 RVA: 0x00FF9730 File Offset: 0x00FF7930
		protected override void OnBeforeDestroy()
		{
			this.ClearTimer();
		}

		// Token: 0x040224FA RID: 140538
		private UiSequencePlayer SequencePlayer;

		// Token: 0x040224FB RID: 140539
		private TimerHandle TimerHandle;

		// Token: 0x040224FC RID: 140540
		public Action<bool> ActiveCallback;
	}
}
