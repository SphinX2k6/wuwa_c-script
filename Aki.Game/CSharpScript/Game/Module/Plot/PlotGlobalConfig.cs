using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FF6 RID: 20470
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotGlobalConfig
	{
		// Token: 0x060345E0 RID: 214496 RVA: 0x00C4E4EC File Offset: 0x00C4C6EC
		public void Init()
		{
			if (this.IsInit)
			{
				return;
			}
			this.EndWaitTimeLevelC = this.GetFloatValue("LevelC.EndWaitTime");
			this.EndWaitTimeLevelD = this.GetFloatValue("LevelD.EndWaitTime");
			this.EndWaitTimeInteraction = this.GetFloatValue("Interaction.EndWaitTime");
			this.EndWaitTimeCenterText = this.GetFloatValue("CenterText.EndWaitTime");
			this.TextAnimSpeedSeq = this.GetFloatValue("Seq.CharPerSec") / (float)TimeUtil.Instance.Minute;
			this.TextAnimSpeedLevelC = this.GetFloatValue("LevelC.CharPerSec") / (float)TimeUtil.Instance.Minute;
			this.TextAnimSpeedLevelD = this.GetFloatValue("LevelD.CharPerSec") / (float)TimeUtil.Instance.Minute;
			this.TextAnimSpeedInteraction = this.GetFloatValue("Interaction.CharPerSec") / (float)TimeUtil.Instance.Minute;
			this.TextAnimSpeedCenterText = this.GetFloatValue("CenterText.CharPerSec");
			this.JumpWaitTime = this.GetFloatValue("Talk.JumpWaitTime");
			this.GuardTime = this.GetFloatValue("Talk.GuardTime");
			this.AudioDelay = this.GetFloatValue("Talk.AudioDelay");
			this.AudioTransitionDuration = this.GetFloatValue("Talk.AudioTransitionDuration");
			this.CenterTextFontSizeSmall = this.GetFloatValue("CenterText.FontSizeSmall");
			this.CenterTextFontSizeMiddle = this.GetFloatValue("CenterText.FontSizeMiddle");
			this.CenterTextFontSizeBig = this.GetFloatValue("CenterText.FontSizeBig");
			this.TemplateCameraShakePath = (this.GetGlobalConfigFromCsvText("PlotTemplate.CameraShake") ?? "");
			this.PlotGoBattleMaterialPath = (this.GetGlobalConfigFromCsvText("Plot.GoBattleMaterialPath") ?? "");
			this.InitPlotTemplateLookAtDelay();
			this.InitPlotTemplateCameraExitRotation();
			this.CallShowAudioEvent = (this.GetGlobalConfigFromCsvText("PhoneCall.CallShowAudioEvent") ?? "");
			this.CallHideAudioEvent = (this.GetGlobalConfigFromCsvText("PhoneCall.CallHideAudioEvent") ?? "");
			this.SequenceEndLeastTime = this.GetFloatValue("Sequence.SequenceEndLeastTime");
			this.TipsDuration = this.GetFloatValue("Plot.TipsDuration");
			this.SkipPressingTime = this.GetFloatValue("Plot.SkipPressingTime");
			this.DoubleClickInterval = this.GetFloatValue("Plot.DoubleClickInterval");
			this.ClickBufferTime = this.GetFloatValue("Plot.ClickBufferTime");
			this.DisableFlow = (this.GetFloatValue("Plot.DisableFlow") >= 1f);
			this.WaitCalmTime = this.GetFloatValue("Plot.WaitCalmTime") * (float)TimeUtil.Instance.InverseMillisecond;
			this.DragDist = this.GetFloatValue("Plot.DragDist");
			this.AudioEndWaitTimePrompt = this.GetFloatValue("Plot.AudioEndWaitTimePrompt");
			this.DefaultDurationPrompt = this.GetFloatValue("Plot.DefaultDurationPrompt");
			this.ProtectOptionTime = this.GetFloatValue("Plot.ProtectOptionTime") * (float)TimeUtil.Instance.InverseMillisecond;
			this.AudioEndDelay = this.GetFloatValue("Plot.AudioEndDelay");
			this.BubbleAudioEndDelay = this.GetFloatValue("Plot.BubbleAudioEndDelay");
			this.TransitionPopupTime = this.GetFloatValue("Plot.TransitionPopupTime");
			this.EntitySequenceScreenEffectPath = (this.GetGlobalConfigFromCsvText("Plot.EntitySequenceScreenEffectPath") ?? "");
			this.EntitySequencePostEffectPath = (this.GetGlobalConfigFromCsvText("Plot.EntitySequencePostEffectPath") ?? "");
			this.EntitySequenceAudioEvent = (this.GetGlobalConfigFromCsvText("Plot.EntitySequenceSkipAudio") ?? "play_ui_mainline_kuaijing");
			float floatValue = this.GetFloatValue("Plot.EntitySequenceSkipRate");
			this.EntitySequenceAccelerateRate = ((floatValue <= 0f) ? 30f : floatValue);
			this.AutoSelectOptionCharPerSec = this.GetFloatValue("Plot.AutoSelectOptionCharPerSec");
			this.IsInit = true;
		}

		// Token: 0x060345E1 RID: 214497 RVA: 0x00C4E850 File Offset: 0x00C4CA50
		private unsafe void InitPlotTemplateLookAtDelay()
		{
			string globalConfigFromCsvText = this.GetGlobalConfigFromCsvText("PlotTemplate.LookAtDelay");
			if (StringUtils.IsEmpty(globalConfigFromCsvText))
			{
				return;
			}
			string[] array = globalConfigFromCsvText.Split(',', StringSplitOptions.None);
			if (array.Length == 2)
			{
				int num = 2;
				List<float> list = new List<float>(num);
				CollectionsMarshal.SetCount<float>(list, num);
				Span<float> span = CollectionsMarshal.AsSpan<float>(list);
				int num2 = 0;
				*span[num2] = float.Parse(array[0]) * 1000f;
				num2++;
				*span[num2] = float.Parse(array[1]) * 1000f;
				this.PlotTemplateLookAtDelay = list;
			}
		}

		// Token: 0x060345E2 RID: 214498 RVA: 0x00C4E8D8 File Offset: 0x00C4CAD8
		private void InitPlotTemplateCameraExitRotation()
		{
			string globalConfigFromCsvText = this.GetGlobalConfigFromCsvText("PlotTemplate.CameraExitRotation");
			if (StringUtils.IsEmpty(globalConfigFromCsvText))
			{
				return;
			}
			string[] array = globalConfigFromCsvText.Split(',', StringSplitOptions.None);
			if (array.Length == 3)
			{
				this.PlotTemplateCameraExitRotation = Rotator.Create(float.Parse(array[0]), float.Parse(array[1]), float.Parse(array[2]));
			}
		}

		// Token: 0x060345E3 RID: 214499 RVA: 0x00C4E930 File Offset: 0x00C4CB30
		[return: Nullable(2)]
		private string GetGlobalConfigFromCsvText(string name)
		{
			GlobalConfigFromCsv? config = ConfigGlobalConfigFromCsvByName.GetConfig(name, true);
			if (config != null)
			{
				return config.Value.Value;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "已经使用的全局配置字段不能乱删！！！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("被删掉的全局配置字段", name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x060345E4 RID: 214500 RVA: 0x00C4E988 File Offset: 0x00C4CB88
		private float GetFloatValue(string key)
		{
			string globalConfigFromCsvText = this.GetGlobalConfigFromCsvText(key);
			if (globalConfigFromCsvText != null)
			{
				return float.Parse(globalConfigFromCsvText);
			}
			return 0f;
		}

		// Token: 0x0401BDC5 RID: 114117
		public float EndWaitTimeLevelC;

		// Token: 0x0401BDC6 RID: 114118
		public float EndWaitTimeLevelD;

		// Token: 0x0401BDC7 RID: 114119
		public float EndWaitTimeInteraction;

		// Token: 0x0401BDC8 RID: 114120
		public float EndWaitTimeCenterText;

		// Token: 0x0401BDC9 RID: 114121
		public float TextAnimSpeedSeq;

		// Token: 0x0401BDCA RID: 114122
		public float TextAnimSpeedLevelC;

		// Token: 0x0401BDCB RID: 114123
		public float TextAnimSpeedLevelD;

		// Token: 0x0401BDCC RID: 114124
		public float TextAnimSpeedInteraction;

		// Token: 0x0401BDCD RID: 114125
		public float TextAnimSpeedCenterText;

		// Token: 0x0401BDCE RID: 114126
		public float JumpWaitTime;

		// Token: 0x0401BDCF RID: 114127
		public float GuardTime;

		// Token: 0x0401BDD0 RID: 114128
		public float AudioDelay;

		// Token: 0x0401BDD1 RID: 114129
		public float AudioTransitionDuration;

		// Token: 0x0401BDD2 RID: 114130
		public float CenterTextFontSizeSmall;

		// Token: 0x0401BDD3 RID: 114131
		public float CenterTextFontSizeMiddle;

		// Token: 0x0401BDD4 RID: 114132
		public float CenterTextFontSizeBig;

		// Token: 0x0401BDD5 RID: 114133
		public string TemplateCameraShakePath = "";

		// Token: 0x0401BDD6 RID: 114134
		public string PlotGoBattleMaterialPath = "";

		// Token: 0x0401BDD7 RID: 114135
		public Rotator PlotTemplateCameraExitRotation = new Rotator();

		// Token: 0x0401BDD8 RID: 114136
		public List<float> PlotTemplateLookAtDelay = new List<float>
		{
			300f,
			1000f
		};

		// Token: 0x0401BDD9 RID: 114137
		public string CallShowAudioEvent = "";

		// Token: 0x0401BDDA RID: 114138
		public string CallHideAudioEvent = "";

		// Token: 0x0401BDDB RID: 114139
		public float SequenceEndLeastTime;

		// Token: 0x0401BDDC RID: 114140
		public float DoubleClickInterval;

		// Token: 0x0401BDDD RID: 114141
		public float TipsDuration;

		// Token: 0x0401BDDE RID: 114142
		public float SkipPressingTime;

		// Token: 0x0401BDDF RID: 114143
		public float ClickBufferTime;

		// Token: 0x0401BDE0 RID: 114144
		public bool DisableFlow;

		// Token: 0x0401BDE1 RID: 114145
		public float WaitCalmTime = 4000f;

		// Token: 0x0401BDE2 RID: 114146
		public float DragDist = 100f;

		// Token: 0x0401BDE3 RID: 114147
		public float SkipTipsOpenTime = 3f;

		// Token: 0x0401BDE4 RID: 114148
		public float AudioEndWaitTimePrompt;

		// Token: 0x0401BDE5 RID: 114149
		public float DefaultDurationPrompt;

		// Token: 0x0401BDE6 RID: 114150
		public float ProtectOptionTime;

		// Token: 0x0401BDE7 RID: 114151
		public float AudioEndDelay;

		// Token: 0x0401BDE8 RID: 114152
		public float BubbleAudioEndDelay;

		// Token: 0x0401BDE9 RID: 114153
		public float TransitionPopupTime;

		// Token: 0x0401BDEA RID: 114154
		public string EntitySequenceScreenEffectPath = "";

		// Token: 0x0401BDEB RID: 114155
		public string EntitySequencePostEffectPath = "";

		// Token: 0x0401BDEC RID: 114156
		public string EntitySequenceAudioEvent = "";

		// Token: 0x0401BDED RID: 114157
		public float EntitySequenceAccelerateRate;

		// Token: 0x0401BDEE RID: 114158
		public float AutoSelectOptionCharPerSec;

		// Token: 0x0401BDEF RID: 114159
		private bool IsInit;
	}
}
