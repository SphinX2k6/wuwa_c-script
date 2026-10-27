using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud.PostVolumeGlobal;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.StaticScene;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.NewWorld.SceneItem.RefCompController;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.Weather
{
	// Token: 0x0200485F RID: 18527
	[NullableContext(2)]
	[Nullable(0)]
	public class ObservatoryModule
	{
		// Token: 0x060307D2 RID: 198610 RVA: 0x00B42280 File Offset: 0x00B40480
		public bool AccelerateTime(int areaId, int duration, Action callback = null, Action accelerateFinishedCallback = null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Weather;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[天文台]加速时间流逝";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AreaId", areaId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (duration <= 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Weather;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "[天文台]加速时间流逝时长不合法";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Duration", duration);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (this.ObservatoryWorking)
			{
				return false;
			}
			Observatory? config = ConfigObservatoryByAreaId.GetConfig(areaId, true);
			if (config == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Weather;
				ELogAuthor author3 = ELogAuthor.CK;
				string message3 = "[天文台]天气剧情配置不存在";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("AreaId", areaId);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return false;
			}
			this.ObservatoryWorking = true;
			this.AccelerationDuration = duration;
			this.AccelerationPassedTime = 0.0;
			this.AccelerateFinishedCallback = accelerateFinishedCallback;
			TimeOfDayController.Instance.PauseTime();
			EventSystem.Instance.Once(EEventName.PlotSequenceStarted, new Action(this.OnPlotSequenceStarted));
			EventSystem.Instance.Once(EEventName.PlotSequenceEnd, new Action(this.OnPlotSequenceEnd));
			FlowController.Instance.StartFlowForCallback(config.Value.FlowListName, config.Value.FlowId, config.Value.StateId, delegate
			{
				this.ObservatoryWorking = false;
				TimeOfDayController.Instance.ResumeTimeScale(true);
				this.PlayWeatherControlSequence(callback);
			}, null, 0L, false, false, false, null);
			return true;
		}

		// Token: 0x060307D3 RID: 198611 RVA: 0x00B42408 File Offset: 0x00B40608
		public void PlayWeatherControlSequence(Action callback = null)
		{
			this.FinishedCallback = callback;
			if (string.IsNullOrEmpty(this.ObservatorySequencePath))
			{
				this.ObservatorySequencePath = ConfigCommonParamById.GetStringConfig("ObservatorySequencePath");
			}
			if (string.IsNullOrEmpty(this.ObservatorySequencePath))
			{
				Log.Instance.Error(ELogModule.Weather, ELogAuthor.CK, "[天文台]天文台资源配置ObservatorySequencePath不存在, 检查c.参数.xlsx", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.PlaySequence(this.ObservatorySequencePath);
		}

		// Token: 0x060307D4 RID: 198612 RVA: 0x00B42472 File Offset: 0x00B40672
		private void OnPlotSequenceStarted()
		{
			this.StartAccelerateTime(this.AccelerationDuration);
		}

		// Token: 0x060307D5 RID: 198613 RVA: 0x00B42480 File Offset: 0x00B40680
		private unsafe void OnPlotSequenceEnd()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Weather;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[天文台]监听到Sequence停止事件, 恢复正常时间流逝";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AccelerationPassedTime", this.AccelerationPassedTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AccelerationDuration", this.AccelerationDuration);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.StopAccelerateTime();
		}

		// Token: 0x060307D6 RID: 198614 RVA: 0x00B42500 File Offset: 0x00B40700
		private unsafe void StartAccelerateTime(int duration)
		{
			if (!this.ObservatoryWorking)
			{
				if (this.ObservatoryWorkingTimerHandle != null)
				{
					TimerSystem.Instance.Remove(this.ObservatoryWorkingTimerHandle);
					this.ObservatoryWorkingTimerHandle = null;
				}
				return;
			}
			TimeOfDayModel timeOfDayModel = TimeOfDayModel.Instance;
			ULevelSequencePlayer sequencePlayer = SequenceModel.Instance.CurLevelSeqActor.SequencePlayer;
			FFrameRate frameRate = sequencePlayer.GetFrameRate();
			double num = (double)sequencePlayer.GetFrameDuration() / ((double)frameRate.Numerator / (double)frameRate.Denominator);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Weather;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[天文台]计算Sequence播放时长(秒)";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Duration", num);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			double accelerationFactor = 1.0;
			if (num != 0.0)
			{
				accelerationFactor = (double)duration / TodDayTime.ConvertFromRealTimeSecond(num);
			}
			if (this.ObservatoryWorkingTimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.ObservatoryWorkingTimerHandle);
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Weather;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "[天文台]加速时间";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TODDuration", duration);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SequenceDuration", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("AccelerationFactor", accelerationFactor);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.SetCloudSpeed(accelerationFactor);
			this.ObservatoryWorkingTimerHandle = TimerSystem.Instance.Forever(delegate(float deltaTime)
			{
				double num2 = TodDayTime.ConvertFromRealTimeSecond((double)deltaTime * TimeUtil.Instance.Millisecond) * accelerationFactor;
				double second = timeOfDayModel.GameTime.Second + num2;
				timeOfDayModel.GameTime.Second = second;
				UKuroRenderingRuntimeBPPluginBPLibrary.SetGlobalGITime(GlobalData.World, (float)TodDayTime.ConvertToHour(second));
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Weather;
				ELogAuthor author3 = ELogAuthor.CK;
				string message3 = "[天文台]加速时间";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("TODCurSecond", timeOfDayModel.GameTime.Second);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PassedTime", this.AccelerationPassedTime);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("AccelerationDuration", this.AccelerationDuration);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("TODDeltaTime", num2);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
				this.AccelerationPassedTime += num2;
				if (this.AccelerationPassedTime > (double)this.AccelerationDuration)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.Weather;
					ELogAuthor author4 = ELogAuthor.CK;
					string message4 = "[天文台]加速时间流逝结束, 恢复正常时间流逝";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("TODCurSecond", timeOfDayModel.GameTime.Second);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("PassedTime", this.AccelerationPassedTime);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("AccelerationDuration", this.AccelerationDuration);
					instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
					this.StopAccelerateTime();
				}
			}, 100f, 1f, null, null, true);
		}

		// Token: 0x060307D7 RID: 198615 RVA: 0x00B426A4 File Offset: 0x00B408A4
		private void StopAccelerateTime()
		{
			if (this.ObservatoryWorkingTimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.ObservatoryWorkingTimerHandle);
			}
			SimpleLevelSequenceActor simpleSequenceActor = this.SimpleSequenceActor;
			if (simpleSequenceActor != null)
			{
				simpleSequenceActor.Clear();
			}
			this.SimpleSequenceActor = null;
			this.ObservatoryWorkingTimerHandle = null;
			this.ObservatoryWorking = false;
			this.AccelerationDuration = 0;
			this.AccelerationPassedTime = 0.0;
			this.SetCloudSpeed(1.0);
			Action accelerateFinishedCallback = this.AccelerateFinishedCallback;
			if (accelerateFinishedCallback == null)
			{
				return;
			}
			accelerateFinishedCallback();
		}

		// Token: 0x060307D8 RID: 198616 RVA: 0x00B42728 File Offset: 0x00B40928
		private void SetCloudSpeed(double speed)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Weather;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[天文台]尝试设置体积云流速";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Speed", speed);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			UKuroGISystem kuroGISystem = UKuroGISystem.GetKuroGISystem(GlobalData.World.GetWorld());
			if (kuroGISystem == null)
			{
				Log.Instance.Error(ELogModule.Weather, ELogAuthor.CK, "[天文台]获取KuroGISystem失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			BP_GlobalGI_C bp_GlobalGI_C = kuroGISystem.GetKuroGlobalGIActor() as BP_GlobalGI_C;
			if (bp_GlobalGI_C == null)
			{
				Log.Instance.Error(ELogModule.Weather, ELogAuthor.CK, "[天文台]获取GlobalGI Actor失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			UChildActorComponent kuroVolumeCloudGlobal = bp_GlobalGI_C.KuroVolumeCloudGlobal;
			BP_KuroVolumeCloud_Global_C bp_KuroVolumeCloud_Global_C = ((kuroVolumeCloudGlobal != null) ? kuroVolumeCloudGlobal.ChildActor : null) as BP_KuroVolumeCloud_Global_C;
			if (bp_KuroVolumeCloud_Global_C == null)
			{
				Log.Instance.Error(ELogModule.Weather, ELogAuthor.CK, "[天文台]获取KuroVolumeCloud失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			bp_KuroVolumeCloud_Global_C.VolumeCloudSpeedMulti = (float)speed;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Weather;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "[天文台]设置体积云流速完成";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Speed", bp_KuroVolumeCloud_Global_C.VolumeCloudSpeedMulti);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}

		// Token: 0x060307D9 RID: 198617 RVA: 0x00B42840 File Offset: 0x00B40A40
		[NullableContext(1)]
		private void PlaySequence(string path)
		{
			ResourceSystem.Instance.LoadAsync<ULevelSequence>(path, delegate([Nullable(2)] ULevelSequence data, string _)
			{
				if (data == null || !data.IsValid())
				{
					Log.Instance.Error(ELogModule.Weather, ELogAuthor.CK, "[天文台]Sequence加载失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				if (this.SimpleSequenceActor == null || !this.SimpleSequenceActor.IsDirectorValid())
				{
					if (this.SimpleSequenceActor != null)
					{
						SimpleLevelSequenceActor simpleSequenceActor = this.SimpleSequenceActor;
						if (simpleSequenceActor != null)
						{
							simpleSequenceActor.Clear();
						}
					}
					this.SimpleSequenceActor = new SimpleLevelSequenceActor(data);
					this.SimpleSequenceActor.AddOnFinishedCallback(new Action(this.OnSequenceFinished));
				}
				else
				{
					this.SimpleSequenceActor.SetSequenceData(data);
				}
				this.SimpleSequenceActor.PlayLoop(false, 0, null, null, new RefCompDefine.PlayRateStruct(new float?(1f), EKuroEasingFuncType.KEF_Linear, new float?(0f), new float?(0f)));
			}, ResourceSystem.EResourceLoadPriority.Default, "js_undefined");
		}

		// Token: 0x060307DA RID: 198618 RVA: 0x00B42861 File Offset: 0x00B40A61
		private void OnSequenceFinished()
		{
			Action finishedCallback = this.FinishedCallback;
			if (finishedCallback == null)
			{
				return;
			}
			finishedCallback();
		}

		// Token: 0x0401A0BD RID: 106685
		private bool ObservatoryWorking;

		// Token: 0x0401A0BE RID: 106686
		private TimerHandle ObservatoryWorkingTimerHandle;

		// Token: 0x0401A0BF RID: 106687
		private SimpleLevelSequenceActor SimpleSequenceActor;

		// Token: 0x0401A0C0 RID: 106688
		private int AccelerationDuration;

		// Token: 0x0401A0C1 RID: 106689
		private double AccelerationPassedTime;

		// Token: 0x0401A0C2 RID: 106690
		private string ObservatorySequencePath;

		// Token: 0x0401A0C3 RID: 106691
		private Action FinishedCallback;

		// Token: 0x0401A0C4 RID: 106692
		private Action AccelerateFinishedCallback;
	}
}
