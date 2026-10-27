using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DigitalScreen
{
	// Token: 0x02006F11 RID: 28433
	[NullableContext(1)]
	[Nullable(0)]
	public class DigitalScreenaView : UiTickViewBase
	{
		// Token: 0x0604533F RID: 283455 RVA: 0x0111F074 File Offset: 0x0111D274
		public DigitalScreenaView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06045340 RID: 283456 RVA: 0x0111F0E4 File Offset: 0x0111D2E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06045341 RID: 283457 RVA: 0x0111F1B0 File Offset: 0x0111D3B0
		protected override void OnStart()
		{
			PlotModel.Instance.InDigitalScreen = true;
			this.InitInfo();
			AudioSystem.Instance.PostEvent("play_ui_digital_screen");
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TextPlayTweenComp = (base.GetText(2).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			this.LevelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
			if (DigitalScreenModel.Instance.StartTimes[0] == 0f)
			{
				this.ResumeNextLine();
			}
			else
			{
				this.TimerHandleNextLine = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.ResumeNextLine();
				}, (float)((int)TimeUtil.Instance.SetTimeMillisecond((double)DigitalScreenModel.Instance.StartTimes[0])), null, null, true, 1f);
			}
			this.TimerHandleCloseUi = TimerSystem.Instance.Delay(delegate(float _)
			{
				base.CloseMe(null);
			}, (float)((int)TimeUtil.Instance.SetTimeMillisecond((double)DigitalScreenModel.Instance.ExistTime)), null, null, true, 1f);
		}

		// Token: 0x06045342 RID: 283458 RVA: 0x0111F2E0 File Offset: 0x0111D4E0
		protected override void OnBeforeHide()
		{
			PlotModel.Instance.InDigitalScreen = false;
			this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
			AudioSystem.Instance.ExecuteAction("play_ui_digital_screen", EAudioActionType.Stop, null);
			this.RemoveTimerCheck();
		}

		// Token: 0x06045343 RID: 283459 RVA: 0x0111F334 File Offset: 0x0111D534
		private void RemoveTimerCheck()
		{
			if (this.TimerHandleCloseUi != null && TimerSystem.Instance.Has(this.TimerHandleCloseUi))
			{
				TimerSystem.Instance.Remove(this.TimerHandleCloseUi);
			}
			if (this.TimerHandleNextLine != null && TimerSystem.Instance.Has(this.TimerHandleNextLine))
			{
				TimerSystem.Instance.Remove(this.TimerHandleNextLine);
			}
		}

		// Token: 0x06045344 RID: 283460 RVA: 0x0111F398 File Offset: 0x0111D598
		protected override void OnTick(float deltaTime)
		{
			if (!this.IsTweening)
			{
				this.TickDeltaTime += deltaTime;
				if (this.TickDeltaTime >= 300f)
				{
					if (this.ContentPos == 0)
					{
						if (this.IsTextWithLine)
						{
							UUIText text = base.GetText(1);
							if (text != null)
							{
								text.SetText(this.LeftTextWithoutLine, true);
							}
							this.IsTextWithLine = false;
						}
						else
						{
							UUIText text2 = base.GetText(1);
							if (text2 != null)
							{
								text2.SetText(this.LeftTextWithLine, true);
							}
							this.IsTextWithLine = true;
						}
					}
					else if (this.ContentPos == 1)
					{
						if (this.IsTextWithLine)
						{
							UUIText text3 = base.GetText(2);
							if (text3 != null)
							{
								text3.SetText(this.MiddleTextWithoutLine, true);
							}
							this.IsTextWithLine = false;
						}
						else
						{
							UUIText text4 = base.GetText(2);
							if (text4 != null)
							{
								text4.SetText(this.MiddleTextWithLine, true);
							}
							this.IsTextWithLine = true;
						}
					}
					this.TickDeltaTime = 0f;
				}
			}
		}

		// Token: 0x06045345 RID: 283461 RVA: 0x0111F480 File Offset: 0x0111D680
		private void OnUpdateInternal(float progress)
		{
			ULGUIPlayTween_Int ulguiplayTween_Int = this.TextPlayTweenComp.GetPlayTween() as ULGUIPlayTween_Int;
			int num = (int)Math.Round((double)(progress * (float)(ulguiplayTween_Int.to - ulguiplayTween_Int.from))) + ulguiplayTween_Int.from;
			if (this.Progress < num)
			{
				this.Progress = num;
				string fontPrefix = this.FontPrefix;
				string text = DigitalScreenModel.Instance.Text;
				string str = fontPrefix + ((text != null) ? text.Substring(this.TextStart, this.Progress - this.TextStart) : null) + "</size>";
				string fontPrefix2 = this.FontPrefix;
				string text2 = DigitalScreenModel.Instance.Text;
				string str2 = fontPrefix2 + ((text2 != null) ? text2.Substring(this.TextStart, this.Progress - this.TextStart) : null) + "_</size>";
				if (this.ContentPos == 1)
				{
					this.LeftTextWithLine = this.LeftText + str2;
					this.LeftTextWithoutLine = this.LeftText + str;
					UUIText text3 = base.GetText(1);
					if (text3 == null)
					{
						return;
					}
					text3.SetText(this.LeftTextWithLine, true);
					return;
				}
				else if (this.ContentPos == 0)
				{
					this.MiddleTextWithLine = this.MiddleText + str2;
					this.MiddleTextWithoutLine = this.MiddleText + str;
					UUIText text4 = base.GetText(2);
					if (text4 == null)
					{
						return;
					}
					text4.SetText(this.MiddleTextWithLine, true);
				}
			}
		}

		// Token: 0x06045346 RID: 283462 RVA: 0x0111F5D0 File Offset: 0x0111D7D0
		private void InitInfo()
		{
			this.CurLine = -1;
			this.LineCount = DigitalScreenModel.Instance.StartTimes.Length;
			this.From = 0;
			if (!StringUtils.IsBlank(DigitalScreenModel.Instance.BackgroundPicture))
			{
				base.SetTextureByPath(DigitalScreenModel.Instance.BackgroundPicture, base.GetTexture(3), null, null);
			}
			if (DigitalScreenModel.Instance.ViewType == 0 && !StringUtils.IsBlank(DigitalScreenModel.Instance.LogoIcon))
			{
				this.SetSpriteByPath(DigitalScreenModel.Instance.LogoIcon, base.GetSprite(4), false, null, null);
			}
			this.LeftTextWithoutLine = "";
			this.LeftTextWithLine = "_";
			this.MiddleTextWithoutLine = "";
			this.MiddleTextWithLine = "_";
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText("", true);
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetText("", true);
			}
			UUIText text3 = base.GetText(2);
			if (text3 != null)
			{
				text3.SetCustomMaterialScalarParameter(DigitalScreenaView.factor, DigitalScreenModel.Instance.TextFactor);
			}
			UUIText text4 = base.GetText(1);
			if (text4 == null)
			{
				return;
			}
			text4.SetCustomMaterialScalarParameter(DigitalScreenaView.factor, DigitalScreenModel.Instance.TextFactor);
		}

		// Token: 0x06045347 RID: 283463 RVA: 0x0111F70C File Offset: 0x0111D90C
		private void SetTweenAndPlay(int from, int to, float time, int startDelay)
		{
			ULGUIPlayTweenComponent textPlayTweenComp = this.TextPlayTweenComp;
			ULGUIPlayTween_Int ulguiplayTween_Int = ((textPlayTweenComp != null) ? textPlayTweenComp.GetPlayTween() : null) as ULGUIPlayTween_Int;
			if (ulguiplayTween_Int == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiManager;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[DigitalScreenaView] SetTweenAndPlay 获取 ULGUIPlayTween_Int 失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("hasComp", this.TextPlayTweenComp != null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ulguiplayTween_Int.from = from;
			ulguiplayTween_Int.to = to;
			ulguiplayTween_Int.duration = time;
			ulguiplayTween_Int.startDelay = (float)startDelay;
			this.TextPlayTweenComp.Play();
			this.From = to;
			this.IsTweening = true;
			ULTweener tweener = ulguiplayTween_Int.GetTweener();
			if (tweener != null)
			{
				this.OnUpdateDelegate = new Action<float>(this.OnUpdateInternal);
				ULTweener ultweener = tweener;
				FTweenerFloatDynamicDelegate ftweenerFloatDynamicDelegate = DelegateUtils.ToManualReleaseDelegate<FTweenerFloatDynamicDelegate>(new Action<float>(this.OnUpdateInternal));
				ultweener.OnUpdate(ftweenerFloatDynamicDelegate);
			}
		}

		// Token: 0x06045348 RID: 283464 RVA: 0x0111F7DC File Offset: 0x0111D9DC
		private void SetMultiLineTextAnimTimer()
		{
			this.TimerHandleNextLine = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.SetMultiLineWaitingSkipTimer();
			}, (float)((int)TimeUtil.Instance.SetTimeMillisecond((double)DigitalScreenModel.Instance.DuringTimes[this.CurLine])), null, null, true, 1f);
		}

		// Token: 0x06045349 RID: 283465 RVA: 0x0111F82C File Offset: 0x0111DA2C
		private void SetMultiLineWaitingSkipTimer()
		{
			if (this.CurLine >= this.LineCount)
			{
				return;
			}
			this.IsTweening = false;
			ULGUIPlayTweenComponent textPlayTweenComp = this.TextPlayTweenComp;
			ULGUIPlayTween ulguiplayTween = (textPlayTweenComp != null) ? textPlayTweenComp.GetPlayTween() : null;
			ULTweener ultweener = (ulguiplayTween != null) ? ulguiplayTween.GetTweener() : null;
			if (ultweener != null)
			{
				ULTweener ultweener2 = ultweener;
				FTweenerFloatDynamicDelegate ftweenerFloatDynamicDelegate = null;
				ultweener2.OnUpdate(ftweenerFloatDynamicDelegate);
				if (this.OnUpdateDelegate != null)
				{
					DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnUpdateInternal));
					this.OnUpdateDelegate = null;
				}
			}
			if (DigitalScreenModel.Instance.DelayTimes[this.CurLine] == 0f)
			{
				this.ResumeNextLine();
				return;
			}
			this.TimerHandleNextLine = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.ResumeNextLine();
			}, (float)((int)TimeUtil.Instance.SetTimeMillisecond((double)DigitalScreenModel.Instance.DelayTimes[this.CurLine])), null, null, true, 1f);
		}

		// Token: 0x0604534A RID: 283466 RVA: 0x0111F900 File Offset: 0x0111DB00
		private void ResumeNextLine()
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(this.LeftTextWithoutLine, true);
			}
			UUIText text2 = base.GetText(2);
			if (text2 != null)
			{
				text2.SetText(this.MiddleTextWithoutLine, true);
			}
			this.CurLine++;
			if (this.CurLine >= DigitalScreenModel.Instance.Size)
			{
				return;
			}
			this.ContentPos = ((DigitalScreenModel.Instance.ContentPos[this.CurLine] != 0) ? 1 : 0);
			this.TextStart = this.Progress;
			this.LeftText = this.LeftTextWithoutLine;
			this.MiddleText = this.MiddleTextWithoutLine;
			this.FontPrefix = "<size=" + DigitalScreenModel.Instance.Font[this.CurLine].ToString() + ">";
			this.SetTweenAndPlay(this.From, this.From + DigitalScreenModel.Instance.TextLength[this.CurLine], DigitalScreenModel.Instance.DuringTimes[this.CurLine], 0);
			this.SetMultiLineTextAnimTimer();
		}

		// Token: 0x0604534B RID: 283467 RVA: 0x0111FA0C File Offset: 0x0111DC0C
		protected override UniTask OnBeforeHideAsync()
		{
			DigitalScreenaView.<OnBeforeHideAsync>d__37 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<DigitalScreenaView.<OnBeforeHideAsync>d__37>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604534C RID: 283468 RVA: 0x0111FA4F File Offset: 0x0111DC4F
		protected override void OnBeforeDestroy()
		{
			if (this.OnUpdateDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnUpdateInternal));
				this.OnUpdateDelegate = null;
			}
		}

		// Token: 0x04024124 RID: 147748
		private static readonly FName factor = new FName("factor");

		// Token: 0x04024125 RID: 147749
		private const string FONTSUFFIX = "</size>";

		// Token: 0x04024126 RID: 147750
		private const string LOOP_DIGITAL_SCREEN = "play_ui_digital_screen";

		// Token: 0x04024127 RID: 147751
		[Nullable(2)]
		private ULGUIPlayTweenComponent TextPlayTweenComp;

		// Token: 0x04024128 RID: 147752
		private int CurLine;

		// Token: 0x04024129 RID: 147753
		private int LineCount = 1;

		// Token: 0x0402412A RID: 147754
		private int From = 1;

		// Token: 0x0402412B RID: 147755
		private string LeftText = "";

		// Token: 0x0402412C RID: 147756
		private string MiddleText = "";

		// Token: 0x0402412D RID: 147757
		private int ContentPos;

		// Token: 0x0402412E RID: 147758
		private string LeftTextWithLine = "";

		// Token: 0x0402412F RID: 147759
		private string LeftTextWithoutLine = "";

		// Token: 0x04024130 RID: 147760
		private string MiddleTextWithLine = "";

		// Token: 0x04024131 RID: 147761
		private string MiddleTextWithoutLine = "";

		// Token: 0x04024132 RID: 147762
		private bool IsTweening;

		// Token: 0x04024133 RID: 147763
		private bool IsTextWithLine;

		// Token: 0x04024134 RID: 147764
		private int Progress;

		// Token: 0x04024135 RID: 147765
		private int TextStart;

		// Token: 0x04024136 RID: 147766
		private string FontPrefix = "";

		// Token: 0x04024137 RID: 147767
		private float TickDeltaTime;

		// Token: 0x04024138 RID: 147768
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04024139 RID: 147769
		[Nullable(2)]
		private TimerHandle TimerHandleCloseUi;

		// Token: 0x0402413A RID: 147770
		[Nullable(2)]
		private TimerHandle TimerHandleNextLine;

		// Token: 0x0402413B RID: 147771
		[Nullable(2)]
		private Action<float> OnUpdateDelegate;

		// Token: 0x0200CD6D RID: 52589
		[NullableContext(0)]
		private class EDigitalScreenView
		{
			// Token: 0x0403DE8D RID: 253581
			public const int ButtonMask = 0;

			// Token: 0x0403DE8E RID: 253582
			public const int TextName = 1;

			// Token: 0x0403DE8F RID: 253583
			public const int TextList = 2;

			// Token: 0x0403DE90 RID: 253584
			public const int TextureBg = 3;

			// Token: 0x0403DE91 RID: 253585
			public const int LogoIcon = 4;
		}
	}
}
