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
	// Token: 0x02006092 RID: 24722
	[NullableContext(1)]
	[Nullable(0)]
	public class DigitalScreenaView : UiTickViewBase
	{
		// Token: 0x0603B4ED RID: 242925 RVA: 0x010C9014 File Offset: 0x010C7214
		public DigitalScreenaView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B4EE RID: 242926 RVA: 0x010C9084 File Offset: 0x010C7284
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

		// Token: 0x0603B4EF RID: 242927 RVA: 0x010C9150 File Offset: 0x010C7350
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

		// Token: 0x0603B4F0 RID: 242928 RVA: 0x010C9280 File Offset: 0x010C7480
		protected override void OnBeforeHide()
		{
			PlotModel.Instance.InDigitalScreen = false;
			this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
			AudioSystem.Instance.ExecuteAction("play_ui_digital_screen", EAudioActionType.Stop, null);
			this.RemoveTimerCheck();
		}

		// Token: 0x0603B4F1 RID: 242929 RVA: 0x010C92D4 File Offset: 0x010C74D4
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

		// Token: 0x0603B4F2 RID: 242930 RVA: 0x010C9338 File Offset: 0x010C7538
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

		// Token: 0x0603B4F3 RID: 242931 RVA: 0x010C9420 File Offset: 0x010C7620
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

		// Token: 0x0603B4F4 RID: 242932 RVA: 0x010C9570 File Offset: 0x010C7770
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

		// Token: 0x0603B4F5 RID: 242933 RVA: 0x010C96AC File Offset: 0x010C78AC
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

		// Token: 0x0603B4F6 RID: 242934 RVA: 0x010C977C File Offset: 0x010C797C
		private void SetMultiLineTextAnimTimer()
		{
			this.TimerHandleNextLine = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.SetMultiLineWaitingSkipTimer();
			}, (float)((int)TimeUtil.Instance.SetTimeMillisecond((double)DigitalScreenModel.Instance.DuringTimes[this.CurLine])), null, null, true, 1f);
		}

		// Token: 0x0603B4F7 RID: 242935 RVA: 0x010C97CC File Offset: 0x010C79CC
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

		// Token: 0x0603B4F8 RID: 242936 RVA: 0x010C98A0 File Offset: 0x010C7AA0
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

		// Token: 0x0603B4F9 RID: 242937 RVA: 0x010C99AC File Offset: 0x010C7BAC
		protected override UniTask OnBeforeHideAsync()
		{
			DigitalScreenaView.<OnBeforeHideAsync>d__37 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<DigitalScreenaView.<OnBeforeHideAsync>d__37>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B4FA RID: 242938 RVA: 0x010C99EF File Offset: 0x010C7BEF
		protected override void OnBeforeDestroy()
		{
			if (this.OnUpdateDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnUpdateInternal));
				this.OnUpdateDelegate = null;
			}
		}

		// Token: 0x0401F3D9 RID: 127961
		private static readonly FName factor = new FName("factor");

		// Token: 0x0401F3DA RID: 127962
		private const string FONTSUFFIX = "</size>";

		// Token: 0x0401F3DB RID: 127963
		private const string LOOP_DIGITAL_SCREEN = "play_ui_digital_screen";

		// Token: 0x0401F3DC RID: 127964
		[Nullable(2)]
		private ULGUIPlayTweenComponent TextPlayTweenComp;

		// Token: 0x0401F3DD RID: 127965
		private int CurLine;

		// Token: 0x0401F3DE RID: 127966
		private int LineCount = 1;

		// Token: 0x0401F3DF RID: 127967
		private int From = 1;

		// Token: 0x0401F3E0 RID: 127968
		private string LeftText = "";

		// Token: 0x0401F3E1 RID: 127969
		private string MiddleText = "";

		// Token: 0x0401F3E2 RID: 127970
		private int ContentPos;

		// Token: 0x0401F3E3 RID: 127971
		private string LeftTextWithLine = "";

		// Token: 0x0401F3E4 RID: 127972
		private string LeftTextWithoutLine = "";

		// Token: 0x0401F3E5 RID: 127973
		private string MiddleTextWithLine = "";

		// Token: 0x0401F3E6 RID: 127974
		private string MiddleTextWithoutLine = "";

		// Token: 0x0401F3E7 RID: 127975
		private bool IsTweening;

		// Token: 0x0401F3E8 RID: 127976
		private bool IsTextWithLine;

		// Token: 0x0401F3E9 RID: 127977
		private int Progress;

		// Token: 0x0401F3EA RID: 127978
		private int TextStart;

		// Token: 0x0401F3EB RID: 127979
		private string FontPrefix = "";

		// Token: 0x0401F3EC RID: 127980
		private float TickDeltaTime;

		// Token: 0x0401F3ED RID: 127981
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F3EE RID: 127982
		[Nullable(2)]
		private TimerHandle TimerHandleCloseUi;

		// Token: 0x0401F3EF RID: 127983
		[Nullable(2)]
		private TimerHandle TimerHandleNextLine;

		// Token: 0x0401F3F0 RID: 127984
		[Nullable(2)]
		private Action<float> OnUpdateDelegate;

		// Token: 0x0200B95F RID: 47455
		[NullableContext(0)]
		private class EDigitalScreenView
		{
			// Token: 0x040392BC RID: 234172
			public const int ButtonMask = 0;

			// Token: 0x040392BD RID: 234173
			public const int TextName = 1;

			// Token: 0x040392BE RID: 234174
			public const int TextList = 2;

			// Token: 0x040392BF RID: 234175
			public const int TextureBg = 3;

			// Token: 0x040392C0 RID: 234176
			public const int LogoIcon = 4;
		}
	}
}
