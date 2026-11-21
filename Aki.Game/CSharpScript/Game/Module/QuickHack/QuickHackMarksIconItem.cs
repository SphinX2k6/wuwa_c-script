using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F50 RID: 16208
	[NullableContext(2)]
	[Nullable(0)]
	public class QuickHackMarksIconItem : UiPanelBase
	{
		// Token: 0x06029077 RID: 168055 RVA: 0x00B84F4C File Offset: 0x00B8314C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06029078 RID: 168056 RVA: 0x00B85018 File Offset: 0x00B83218
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x06029079 RID: 168057 RVA: 0x00B8502C File Offset: 0x00B8322C
		protected override void OnBeforeDestroy()
		{
			this.StopLoopAudio();
			TimerHandle timer = this.Timer;
			if (timer != null)
			{
				timer.Remove();
			}
			this.Timer = null;
			this.OnFinish = null;
			QuickHackMarkInstance mark = this.Mark;
			if (mark != null)
			{
				mark.UnRegisterOnProgressChange();
			}
			this.Mark = null;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0602907A RID: 168058 RVA: 0x00B8508F File Offset: 0x00B8328F
		public int GetMarkId()
		{
			return this.MarkId;
		}

		// Token: 0x0602907B RID: 168059 RVA: 0x00B85098 File Offset: 0x00B83298
		[NullableContext(1)]
		public void StartPerform(QuickHackMarkInstance mark, Action<int> onFinish)
		{
			this.Mark = mark;
			this.MarkId = mark.GetId();
			string iconPath = mark.GetIconPath();
			bool flag = !StringUtils.IsBlank(iconPath);
			UUITexture iconTexture = base.GetTexture(2);
			UUITexture iconMaskTexture = base.GetTexture(3);
			this.SequencePlayer.PlaySequencePurely("Start", false, false);
			this.UpdateColorStyle(true);
			iconTexture.SetUIActive(false);
			iconMaskTexture.SetUIActive(false);
			if (flag)
			{
				base.SetTextureByPath(iconPath, iconTexture, null, delegate(bool result)
				{
					if (result)
					{
						iconTexture.SetUIActive(true);
					}
				});
				base.SetTextureByPath(iconPath, iconMaskTexture, null, delegate(bool result)
				{
					if (result)
					{
						iconMaskTexture.SetUIActive(true);
					}
				});
			}
			this.OnFinish = onFinish;
			mark.RegisterOnProgressChange(new Action<double>(this.UpdateProgress));
			mark.RegisterOnStateChange(new Action<EQuickHackMarkState, EQuickHackMarkState>(this.OnStateChange));
			this.UpdateState(null, mark.GetCurrentState());
			this.UpdateProgress(mark.GetCurrentProgress());
		}

		// Token: 0x0602907C RID: 168060 RVA: 0x00B851AB File Offset: 0x00B833AB
		private void UpdateProgress(double progress)
		{
			base.GetSprite(1).SetFillAmount((float)progress);
			base.GetTexture(3).SetFillAmount((float)progress);
		}

		// Token: 0x0602907D RID: 168061 RVA: 0x00B851C9 File Offset: 0x00B833C9
		private void OnStateChange(EQuickHackMarkState lastState, EQuickHackMarkState state)
		{
			this.UpdateState(new EQuickHackMarkState?(lastState), state);
		}

		// Token: 0x0602907E RID: 168062 RVA: 0x00B851D8 File Offset: 0x00B833D8
		private void UpdateState(EQuickHackMarkState? lastState, EQuickHackMarkState state)
		{
			if (state == EQuickHackMarkState.Upload)
			{
				this.StartLoopAudio();
				return;
			}
			if (lastState.GetValueOrDefault() == EQuickHackMarkState.Upload)
			{
				this.StopLoopAudio();
				AudioSystem.Instance.PostEvent("play_ui_focus_mode_scanning_qh_done");
			}
			if (state == EQuickHackMarkState.Duration)
			{
				QuickHackMarkInstance mark = this.Mark;
				bool flag;
				if (mark == null)
				{
					flag = (null != null);
				}
				else
				{
					EntityHandle owner = mark.GetOwner();
					if (owner == null)
					{
						flag = (null != null);
					}
					else
					{
						WorldEntity entity = owner.Entity;
						flag = (((entity != null) ? entity.GetComponent<SceneItemQuickHackComponent>() : null) != null);
					}
				}
				if (flag)
				{
					this.UpdateColorStyle(false);
				}
			}
			if (state == EQuickHackMarkState.Finish)
			{
				QuickHackMarkInstance mark2 = this.Mark;
				if (mark2 != null)
				{
					mark2.UnRegisterOnProgressChange();
				}
				QuickHackMarkInstance mark3 = this.Mark;
				if (mark3 != null)
				{
					mark3.UnRegisterOnStateChange();
				}
				this.Timer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					this.FinishPerform();
				}, 100f, null, null, true, 1f);
			}
		}

		// Token: 0x0602907F RID: 168063 RVA: 0x00B85298 File Offset: 0x00B83498
		private void FinishPerform()
		{
			this.Timer = null;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.StopSequenceByKey("Start", false, false);
			}
			Action<int> onFinish = this.OnFinish;
			if (onFinish != null)
			{
				onFinish(this.MarkId);
			}
			this.OnFinish = null;
			this.Mark = null;
		}

		// Token: 0x06029080 RID: 168064 RVA: 0x00B852EC File Offset: 0x00B834EC
		private void StartLoopAudio()
		{
			if (this.LoopAudioEventHandle != 0)
			{
				return;
			}
			int num = AudioSystem.Instance.PostEvent("play_ui_focus_mode_scanning_loop");
			if (num != 0)
			{
				this.LoopAudioEventHandle = num;
				EventSystem.Instance.Add(EEventName.OnQuickHackClose, new Action(this.OnQuickHackClose));
			}
		}

		// Token: 0x06029081 RID: 168065 RVA: 0x00B85338 File Offset: 0x00B83538
		private void OnQuickHackClose()
		{
			this.StopLoopAudio();
		}

		// Token: 0x06029082 RID: 168066 RVA: 0x00B85340 File Offset: 0x00B83540
		private void StopLoopAudio()
		{
			if (this.LoopAudioEventHandle == 0)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(this.LoopAudioEventHandle, EAudioActionType.Stop, null);
			this.LoopAudioEventHandle = 0;
			EventSystem.Instance.Remove(EEventName.OnQuickHackClose, new Action(this.OnQuickHackClose));
		}

		// Token: 0x06029083 RID: 168067 RVA: 0x00B85394 File Offset: 0x00B83594
		private void UpdateColorStyle(bool isRed)
		{
			string hexStr = isRed ? "#FF4F4BFF" : "#6CF4F8FF";
			base.GetTexture(2).SetColor(FColor.FromHex(hexStr));
			this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(isRed ? "QuickHackMarkBackgroundRed" : "QuickHackMarkBackgroundBlue"), base.GetSprite(4), false, null, null);
			this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(isRed ? "QuickHackMarkProgressRed" : "QuickHackMarkProgressBlue"), base.GetSprite(1), false, null, null);
		}

		// Token: 0x04016547 RID: 91463
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04016548 RID: 91464
		private QuickHackMarkInstance Mark;

		// Token: 0x04016549 RID: 91465
		private int MarkId;

		// Token: 0x0401654A RID: 91466
		private Action<int> OnFinish;

		// Token: 0x0401654B RID: 91467
		private TimerHandle Timer;

		// Token: 0x0401654C RID: 91468
		private int LoopAudioEventHandle;

		// Token: 0x02009AC9 RID: 39625
		[NullableContext(0)]
		private class EComponentType
		{
			// Token: 0x040303A3 RID: 197539
			public const int IconItem = 0;

			// Token: 0x040303A4 RID: 197540
			public const int ProgressSprite = 1;

			// Token: 0x040303A5 RID: 197541
			public const int SkillIconTexture = 2;

			// Token: 0x040303A6 RID: 197542
			public const int SkillIconMaskTexture = 3;

			// Token: 0x040303A7 RID: 197543
			public const int BgSprite = 4;
		}
	}
}
