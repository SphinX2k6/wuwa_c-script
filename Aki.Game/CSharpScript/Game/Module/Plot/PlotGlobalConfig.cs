using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FC0 RID: 16320
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotGlobalConfig
	{
		// Token: 0x0602946B RID: 169067 RVA: 0x00B9854C File Offset: 0x00B9674C
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

		// Token: 0x0602946C RID: 169068 RVA: 0x00B988B0 File Offset: 0x00B96AB0
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

		// Token: 0x0602946D RID: 169069 RVA: 0x00B98938 File Offset: 0x00B96B38
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

		// Token: 0x0602946E RID: 169070 RVA: 0x00B98990 File Offset: 0x00B96B90
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

		// Token: 0x0602946F RID: 169071 RVA: 0x00B989E8 File Offset: 0x00B96BE8
		private float GetFloatValue(string key)
		{
			string globalConfigFromCsvText = this.GetGlobalConfigFromCsvText(key);
			if (globalConfigFromCsvText != null)
			{
				return float.Parse(globalConfigFromCsvText);
			}
			return 0f;
		}

		// Token: 0x040167A1 RID: 92065
		public float EndWaitTimeLevelC;

		// Token: 0x040167A2 RID: 92066
		public float EndWaitTimeLevelD;

		// Token: 0x040167A3 RID: 92067
		public float EndWaitTimeInteraction;

		// Token: 0x040167A4 RID: 92068
		public float EndWaitTimeCenterText;

		// Token: 0x040167A5 RID: 92069
		public float TextAnimSpeedSeq;

		// Token: 0x040167A6 RID: 92070
		public float TextAnimSpeedLevelC;

		// Token: 0x040167A7 RID: 92071
		public float TextAnimSpeedLevelD;

		// Token: 0x040167A8 RID: 92072
		public float TextAnimSpeedInteraction;

		// Token: 0x040167A9 RID: 92073
		public float TextAnimSpeedCenterText;

		// Token: 0x040167AA RID: 92074
		public float JumpWaitTime;

		// Token: 0x040167AB RID: 92075
		public float GuardTime;

		// Token: 0x040167AC RID: 92076
		public float AudioDelay;

		// Token: 0x040167AD RID: 92077
		public float AudioTransitionDuration;

		// Token: 0x040167AE RID: 92078
		public float CenterTextFontSizeSmall;

		// Token: 0x040167AF RID: 92079
		public float CenterTextFontSizeMiddle;

		// Token: 0x040167B0 RID: 92080
		public float CenterTextFontSizeBig;

		// Token: 0x040167B1 RID: 92081
		public string TemplateCameraShakePath = "";

		// Token: 0x040167B2 RID: 92082
		public string PlotGoBattleMaterialPath = "";

		// Token: 0x040167B3 RID: 92083
		public Rotator PlotTemplateCameraExitRotation = new Rotator();

		// Token: 0x040167B4 RID: 92084
		public List<float> PlotTemplateLookAtDelay = new List<float>
		{
			300f,
			1000f
		};

		// Token: 0x040167B5 RID: 92085
		public string CallShowAudioEvent = "";

		// Token: 0x040167B6 RID: 92086
		public string CallHideAudioEvent = "";

		// Token: 0x040167B7 RID: 92087
		public float SequenceEndLeastTime;

		// Token: 0x040167B8 RID: 92088
		public float DoubleClickInterval;

		// Token: 0x040167B9 RID: 92089
		public float TipsDuration;

		// Token: 0x040167BA RID: 92090
		public float SkipPressingTime;

		// Token: 0x040167BB RID: 92091
		public float ClickBufferTime;

		// Token: 0x040167BC RID: 92092
		public bool DisableFlow;

		// Token: 0x040167BD RID: 92093
		public float WaitCalmTime = 4000f;

		// Token: 0x040167BE RID: 92094
		public float DragDist = 100f;

		// Token: 0x040167BF RID: 92095
		public float SkipTipsOpenTime = 3f;

		// Token: 0x040167C0 RID: 92096
		public float AudioEndWaitTimePrompt;

		// Token: 0x040167C1 RID: 92097
		public float DefaultDurationPrompt;

		// Token: 0x040167C2 RID: 92098
		public float ProtectOptionTime;

		// Token: 0x040167C3 RID: 92099
		public float AudioEndDelay;

		// Token: 0x040167C4 RID: 92100
		public float BubbleAudioEndDelay;

		// Token: 0x040167C5 RID: 92101
		public float TransitionPopupTime;

		// Token: 0x040167C6 RID: 92102
		public string EntitySequenceScreenEffectPath = "";

		// Token: 0x040167C7 RID: 92103
		public string EntitySequencePostEffectPath = "";

		// Token: 0x040167C8 RID: 92104
		public string EntitySequenceAudioEvent = "";

		// Token: 0x040167C9 RID: 92105
		public float EntitySequenceAccelerateRate;

		// Token: 0x040167CA RID: 92106
		public float AutoSelectOptionCharPerSec;

		// Token: 0x040167CB RID: 92107
		private bool IsInit;
	}
}
