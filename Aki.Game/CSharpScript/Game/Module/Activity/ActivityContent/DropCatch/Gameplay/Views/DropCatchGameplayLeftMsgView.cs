using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x0200564C RID: 22092
	[NullableContext(2)]
	[Nullable(0)]
	public class DropCatchGameplayLeftMsgView : UiPanelBase
	{
		// Token: 0x06036933 RID: 223539 RVA: 0x00F3A860 File Offset: 0x00F38A60
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

		// Token: 0x06036934 RID: 223540 RVA: 0x00F3A8D0 File Offset: 0x00F38AD0
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

		// Token: 0x06036935 RID: 223541 RVA: 0x00F3A92C File Offset: 0x00F38B2C
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

		// Token: 0x06036936 RID: 223542 RVA: 0x00F3A9EC File Offset: 0x00F38BEC
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

		// Token: 0x06036937 RID: 223543 RVA: 0x00F3AACF File Offset: 0x00F38CCF
		[NullableContext(1)]
		private void OnEndSequence(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				base.Hide(null);
			}
		}

		// Token: 0x06036938 RID: 223544 RVA: 0x00F3AAE5 File Offset: 0x00F38CE5
		private void ClearTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			}
			this.TimerHandle = null;
		}

		// Token: 0x06036939 RID: 223545 RVA: 0x00F3AB11 File Offset: 0x00F38D11
		protected override void OnAfterHide()
		{
			Action<bool> activeCallback = this.ActiveCallback;
			if (activeCallback == null)
			{
				return;
			}
			activeCallback(false);
		}

		// Token: 0x0603693A RID: 223546 RVA: 0x00F3AB24 File Offset: 0x00F38D24
		protected override void OnBeforeDestroy()
		{
			this.ClearTimer();
		}

		// Token: 0x0401CD53 RID: 118099
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401CD54 RID: 118100
		private TimerHandle TimerHandle;

		// Token: 0x0401CD55 RID: 118101
		public Action<bool> ActiveCallback;
	}
}
