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
	// Token: 0x02004F87 RID: 20359
	[NullableContext(2)]
	[Nullable(0)]
	public class QuickHackMarksIconItem : UiPanelBase
	{
		// Token: 0x06034209 RID: 213513 RVA: 0x00C3B7A0 File Offset: 0x00C399A0
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

		// Token: 0x0603420A RID: 213514 RVA: 0x00C3B86C File Offset: 0x00C39A6C
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x0603420B RID: 213515 RVA: 0x00C3B880 File Offset: 0x00C39A80
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

		// Token: 0x0603420C RID: 213516 RVA: 0x00C3B8E3 File Offset: 0x00C39AE3
		public int GetMarkId()
		{
			return this.MarkId;
		}

		// Token: 0x0603420D RID: 213517 RVA: 0x00C3B8EC File Offset: 0x00C39AEC
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

		// Token: 0x0603420E RID: 213518 RVA: 0x00C3B9FF File Offset: 0x00C39BFF
		private void UpdateProgress(double progress)
		{
			base.GetSprite(1).SetFillAmount((float)progress);
			base.GetTexture(3).SetFillAmount((float)progress);
		}

		// Token: 0x0603420F RID: 213519 RVA: 0x00C3BA1D File Offset: 0x00C39C1D
		private void OnStateChange(EQuickHackMarkState lastState, EQuickHackMarkState state)
		{
			this.UpdateState(new EQuickHackMarkState?(lastState), state);
		}

		// Token: 0x06034210 RID: 213520 RVA: 0x00C3BA2C File Offset: 0x00C39C2C
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

		// Token: 0x06034211 RID: 213521 RVA: 0x00C3BAEC File Offset: 0x00C39CEC
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

		// Token: 0x06034212 RID: 213522 RVA: 0x00C3BB40 File Offset: 0x00C39D40
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

		// Token: 0x06034213 RID: 213523 RVA: 0x00C3BB8C File Offset: 0x00C39D8C
		private void OnQuickHackClose()
		{
			this.StopLoopAudio();
		}

		// Token: 0x06034214 RID: 213524 RVA: 0x00C3BB94 File Offset: 0x00C39D94
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

		// Token: 0x06034215 RID: 213525 RVA: 0x00C3BBE8 File Offset: 0x00C39DE8
		private void UpdateColorStyle(bool isRed)
		{
			string hexStr = isRed ? "#FF4F4BFF" : "#6CF4F8FF";
			base.GetTexture(2).SetColor(FColor.FromHex(hexStr));
			this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(isRed ? "QuickHackMarkBackgroundRed" : "QuickHackMarkBackgroundBlue"), base.GetSprite(4), false, null, null);
			this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(isRed ? "QuickHackMarkProgressRed" : "QuickHackMarkProgressBlue"), base.GetSprite(1), false, null, null);
		}

		// Token: 0x0401BB72 RID: 113522
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401BB73 RID: 113523
		private QuickHackMarkInstance Mark;

		// Token: 0x0401BB74 RID: 113524
		private int MarkId;

		// Token: 0x0401BB75 RID: 113525
		private Action<int> OnFinish;

		// Token: 0x0401BB76 RID: 113526
		private TimerHandle Timer;

		// Token: 0x0401BB77 RID: 113527
		private int LoopAudioEventHandle;

		// Token: 0x0200B099 RID: 45209
		[NullableContext(0)]
		private class EComponentType
		{
			// Token: 0x04035978 RID: 219512
			public const int IconItem = 0;

			// Token: 0x04035979 RID: 219513
			public const int ProgressSprite = 1;

			// Token: 0x0403597A RID: 219514
			public const int SkillIconTexture = 2;

			// Token: 0x0403597B RID: 219515
			public const int SkillIconMaskTexture = 3;

			// Token: 0x0403597C RID: 219516
			public const int BgSprite = 4;
		}
	}
}
