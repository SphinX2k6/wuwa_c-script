using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005908 RID: 22792
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolEventCheckView : SolarSchoolHideHudViewBase
	{
		// Token: 0x0603830A RID: 230154 RVA: 0x00FB51D1 File Offset: 0x00FB33D1
		public SolarSchoolEventCheckView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603830B RID: 230155 RVA: 0x00FB5214 File Offset: 0x00FB3414
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnMaskClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603830C RID: 230156 RVA: 0x00FB52DC File Offset: 0x00FB34DC
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolEventCheckView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolEventCheckView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603830D RID: 230157 RVA: 0x00FB5320 File Offset: 0x00FB3520
		protected override void OnStart()
		{
			this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnSequencePlayEvent));
			this.PnlEventInfo.OnChoiceSelected = new Action<int>(this.OnChoiceSelected);
			this.PnlEventInfo.OnConfirmClick = new Action(this.OnConfirmClick);
			this.PnlEventInfo.OnResultDescTypingFinished = new Action(this.OnResultDescTypingFinished);
			this.Handler = (this.OpenParam as ISolarSchoolEventCheckViewHandler);
			if (this.Handler == null)
			{
				return;
			}
			this.PnlEventInfo.SetConfirmActive(false);
			this.SetMaskActive(true);
			this.Handler.OnViewReady(this);
		}

		// Token: 0x0603830E RID: 230158 RVA: 0x00FB53C8 File Offset: 0x00FB35C8
		protected override void OnBeforeDestroy()
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Unbind();
			}
			this.AnimationVersion++;
			this.NumberTool.Clear();
			UniTaskCompletionSource numberAnimPromise = this.NumberAnimPromise;
			if (numberAnimPromise != null)
			{
				numberAnimPromise.TrySetResult();
			}
			this.NumberAnimPromise = null;
			this.IsResultDescTyping = false;
			if (this.PnlEventInfo != null)
			{
				this.PnlEventInfo.OnResultDescTypingFinished = null;
			}
			ISolarSchoolEventCheckViewHandler handler = this.Handler;
			if (handler != null)
			{
				handler.OnViewClosed();
			}
			this.Handler = null;
		}

		// Token: 0x0603830F RID: 230159 RVA: 0x00FB5450 File Offset: 0x00FB3650
		public void ShowEvent(SolarSchoolEventCheck evt, IReadOnlyList<SolarSchoolEventCheckOpt> opts, float[] playerRadii)
		{
			this.OptionIds.Clear();
			if (opts != null)
			{
				foreach (SolarSchoolEventCheckOpt solarSchoolEventCheckOpt in opts)
				{
					this.OptionIds.Add(solarSchoolEventCheckOpt.Id);
				}
			}
			this.PnlEventInfo.RefreshEvent(evt, this.OptionIds);
			this.PlayerTargetRadii = playerRadii;
			this.PnlEventAttribute.SetEventAttr(new float[SolarSchoolDefine.AttrsShowList.Length]);
			this.PnlEventAttribute.SetPlayerAttr(playerRadii);
			this.PnlEventAttribute.SetPanelRatioVisible(false);
			this.PnlEventAttribute.SetPanelPointVisible(false, null);
			this.PnlEventAttribute.SetActive(true);
			this.SetMaskActive(false);
		}

		// Token: 0x06038310 RID: 230160 RVA: 0x00FB5524 File Offset: 0x00FB3724
		public void PlayJudgeAnim(bool success, double rate, int lowRateThreshold, float[] eventRadii)
		{
			this.SetMaskActive(true);
			this.JudgeSuccess = success;
			this.FinalRate = rate;
			this.LowRateThreshold = lowRateThreshold;
			this.EventTargetRadii = eventRadii;
			this.PnlEventAttribute.ResetResultColorTransition();
			this.PnlEventAttribute.SetEventAttr(new float[eventRadii.Length]);
			this.PnlEventAttribute.SetRatio(0.0, false);
			this.PnlEventAttribute.SetPanelRatioVisible(true);
			int num = this.AnimationVersion + 1;
			this.AnimationVersion = num;
			int animationVersion = num;
			this.PlayJudgeAnimAsync(animationVersion).Forget();
		}

		// Token: 0x06038311 RID: 230161 RVA: 0x00FB55B4 File Offset: 0x00FB37B4
		private UniTask PlayJudgeAnimAsync(int animationVersion)
		{
			SolarSchoolEventCheckView.<PlayJudgeAnimAsync>d__26 <PlayJudgeAnimAsync>d__;
			<PlayJudgeAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayJudgeAnimAsync>d__.<>4__this = this;
			<PlayJudgeAnimAsync>d__.animationVersion = animationVersion;
			<PlayJudgeAnimAsync>d__.<>1__state = -1;
			<PlayJudgeAnimAsync>d__.<>t__builder.Start<SolarSchoolEventCheckView.<PlayJudgeAnimAsync>d__26>(ref <PlayJudgeAnimAsync>d__);
			return <PlayJudgeAnimAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038312 RID: 230162 RVA: 0x00FB5600 File Offset: 0x00FB3800
		private void OnEventRadarProgress(float value)
		{
			this.PnlEventAttribute.SetEventAttr(this.ScaleRadii(this.EventTargetRadii, value));
			double num = this.FinalRate * (double)value;
			this.PnlEventAttribute.SetRatio(num, num < (double)this.LowRateThreshold);
		}

		// Token: 0x06038313 RID: 230163 RVA: 0x00FB5648 File Offset: 0x00FB3848
		private UniTask PlayPointHopAnimAsync(int animationVersion)
		{
			SolarSchoolEventCheckView.<PlayPointHopAnimAsync>d__28 <PlayPointHopAnimAsync>d__;
			<PlayPointHopAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPointHopAnimAsync>d__.<>4__this = this;
			<PlayPointHopAnimAsync>d__.animationVersion = animationVersion;
			<PlayPointHopAnimAsync>d__.<>1__state = -1;
			<PlayPointHopAnimAsync>d__.<>t__builder.Start<SolarSchoolEventCheckView.<PlayPointHopAnimAsync>d__28>(ref <PlayPointHopAnimAsync>d__);
			return <PlayPointHopAnimAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038314 RID: 230164 RVA: 0x00FB5694 File Offset: 0x00FB3894
		private void OnPointHopProgress(float value)
		{
			int num = this.HopPoints.Count - 1;
			float num2 = Math.Clamp(value, 0f, 1f) * (float)num;
			int num3 = Math.Min((int)num2, num - 1);
			double num4 = (double)(num2 - (float)num3);
			num4 *= 2.0 - num4;
			double x = this.HopPoints[num3].X + (this.HopPoints[num3 + 1].X - this.HopPoints[num3].X) * num4;
			double y = this.HopPoints[num3].Y + (this.HopPoints[num3 + 1].Y - this.HopPoints[num3].Y) * num4;
			this.ApplyPointAt(x, y);
		}

		// Token: 0x06038315 RID: 230165 RVA: 0x00FB575E File Offset: 0x00FB395E
		private void SetJudgeResultState()
		{
			if (this.JudgeSuccess)
			{
				this.PnlEventAttribute.SetSuccess();
				return;
			}
			this.PnlEventAttribute.SetFail();
		}

		// Token: 0x06038316 RID: 230166 RVA: 0x00FB5780 File Offset: 0x00FB3980
		private void OpenResultPopup()
		{
			SolarSchoolEventPopupParam param = new SolarSchoolEventPopupParam
			{
				PopupId = (this.JudgeSuccess ? ESolarSchoolPopupId.EventCheckSuccess : ESolarSchoolPopupId.EventCheckFail),
				OnCloseCallback = new Action(this.OnJudgeAnimFinished)
			};
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolEventPopupView, param, null);
		}

		// Token: 0x06038317 RID: 230167 RVA: 0x00FB57C8 File Offset: 0x00FB39C8
		private void OnJudgeAnimFinished()
		{
			ISolarSchoolEventCheckViewHandler handler = this.Handler;
			if (handler == null)
			{
				return;
			}
			handler.OnJudgeAnimFinished();
		}

		// Token: 0x06038318 RID: 230168 RVA: 0x00FB57DC File Offset: 0x00FB39DC
		[NullableContext(2)]
		public void ShowResult(bool success, string resultDescKey)
		{
			int num = this.AnimationVersion + 1;
			this.AnimationVersion = num;
			int animationVersion = num;
			this.PnlEventInfo.SetResultMark(success);
			this.PnlEventInfo.SetResultDesc(resultDescKey, !success);
			this.PnlEventInfo.SetConfirmActive(false);
			this.IsResultDescTyping = true;
			this.SetMaskActive(true);
			this.PlayResultAsync(animationVersion).Forget();
		}

		// Token: 0x06038319 RID: 230169 RVA: 0x00FB5840 File Offset: 0x00FB3A40
		private UniTask PlayResultAsync(int animationVersion)
		{
			SolarSchoolEventCheckView.<PlayResultAsync>d__34 <PlayResultAsync>d__;
			<PlayResultAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayResultAsync>d__.<>4__this = this;
			<PlayResultAsync>d__.<>1__state = -1;
			<PlayResultAsync>d__.<>t__builder.Start<SolarSchoolEventCheckView.<PlayResultAsync>d__34>(ref <PlayResultAsync>d__);
			return <PlayResultAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603831A RID: 230170 RVA: 0x00FB5884 File Offset: 0x00FB3A84
		private UniTask PlayNumberAnimAsync(Action<float> progressCallback, int duration)
		{
			UniTaskCompletionSource numberAnimPromise = this.NumberAnimPromise;
			if (numberAnimPromise != null)
			{
				numberAnimPromise.TrySetResult();
			}
			UniTaskCompletionSource promise = new UniTaskCompletionSource();
			this.NumberAnimPromise = promise;
			this.NumberTool.Init(0f, 1f, progressCallback, duration, delegate
			{
				if (this.NumberAnimPromise == promise)
				{
					this.NumberAnimPromise = null;
				}
				promise.TrySetResult();
			});
			this.NumberTool.StartScrolling();
			return promise.Task;
		}

		// Token: 0x0603831B RID: 230171 RVA: 0x00FB5900 File Offset: 0x00FB3B00
		private UniTask? CreateSequenceTask(string sequenceName)
		{
			if (this.UiViewSequence == null)
			{
				return null;
			}
			return new UniTask?(this.UiViewSequence.PlaySequenceAsync(sequenceName, new CustomPromise<bool>(), false, false, null));
		}

		// Token: 0x0603831C RID: 230172 RVA: 0x00FB5940 File Offset: 0x00FB3B40
		private unsafe static int? GetPositiveDuration(string paramKey)
		{
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			int paramInt = SolarSchoolConfig.Instance.GetParamInt(activityId, paramKey, 0);
			if (paramInt <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "SolarSchoolEventCheckView 动画时长参数无效";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("paramKey", paramKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("duration", paramInt);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return null;
			}
			return new int?(paramInt);
		}

		// Token: 0x0603831D RID: 230173 RVA: 0x00FB59F8 File Offset: 0x00FB3BF8
		private float[] ScaleRadii(float[] target, float progress)
		{
			float[] array = new float[target.Length];
			for (int i = 0; i < target.Length; i++)
			{
				array[i] = target[i] * progress;
			}
			return array;
		}

		// Token: 0x0603831E RID: 230174 RVA: 0x00FB5A28 File Offset: 0x00FB3C28
		private void BuildHopPoints()
		{
			Random rng = new Random();
			double startAngleRad = -1.5707963267948966;
			ERadarSampleRegion region = this.JudgeSuccess ? ERadarSampleRegion.Overlap : ERadarSampleRegion.AOnly;
			List<ValueTuple<double, double>> list = new List<ValueTuple<double, double>>();
			foreach (double margin in new double[]
			{
				0.1,
				0.06,
				0.02,
				0.0
			})
			{
				list = SolarSchoolRadarOverlapUtil.SamplePoints(this.EventTargetRadii, this.PlayerTargetRadii, region, 1, margin, 0.0, rng, startAngleRad, null);
				if (list.Count > 0)
				{
					break;
				}
			}
			if (list.Count == 0)
			{
				list.Add(new ValueTuple<double, double>(0.0, 0.0));
			}
			ERadarSampleRegion region2 = this.JudgeSuccess ? ERadarSampleRegion.AOnly : ERadarSampleRegion.Overlap;
			List<ValueTuple<double, double>> list2 = SolarSchoolRadarOverlapUtil.SamplePoints(this.EventTargetRadii, this.PlayerTargetRadii, region2, 1, 0.06, 0.22, rng, startAngleRad, list);
			List<ValueTuple<double, double>> list3 = new List<ValueTuple<double, double>>(list);
			list3.AddRange(list2);
			List<ValueTuple<double, double>> list4 = SolarSchoolRadarOverlapUtil.SamplePoints(this.EventTargetRadii, this.PlayerTargetRadii, ERadarSampleRegion.AFull, 4, 0.06, 0.22, rng, startAngleRad, list3);
			List<ValueTuple<double, double>> list5 = new List<ValueTuple<double, double>>(list4.Count);
			List<ValueTuple<double, double>> list6 = new List<ValueTuple<double, double>>(list4);
			ValueTuple<double, double> valueTuple = new ValueTuple<double, double>(0.0, 0.0);
			while (list6.Count > 0)
			{
				int index = 0;
				double num = -1.0;
				double num2 = Math.Cos(valueTuple.Item1) * valueTuple.Item2;
				double num3 = Math.Sin(valueTuple.Item1) * valueTuple.Item2;
				for (int j = 0; j < list6.Count; j++)
				{
					double num4 = Math.Cos(list6[j].Item1) * list6[j].Item2 - num2;
					double num5 = Math.Sin(list6[j].Item1) * list6[j].Item2 - num3;
					double num6 = num4 * num4 + num5 * num5;
					if (num6 > num)
					{
						num = num6;
						index = j;
					}
				}
				valueTuple = list6[index];
				list5.Add(valueTuple);
				list6.RemoveAt(index);
			}
			List<ValueTuple<double, double>> list7 = new List<ValueTuple<double, double>>(list5.Count + list2.Count + list.Count);
			list7.AddRange(list5);
			list7.AddRange(list2);
			list7.AddRange(list);
			this.HopPoints.Clear();
			foreach (ValueTuple<double, double> valueTuple2 in list7)
			{
				this.HopPoints.Add(Vector2D.Create(Math.Cos(valueTuple2.Item1) * valueTuple2.Item2, Math.Sin(valueTuple2.Item1) * valueTuple2.Item2));
			}
		}

		// Token: 0x0603831F RID: 230175 RVA: 0x00FB5D08 File Offset: 0x00FB3F08
		private void ApplyPointAt(double x, double y)
		{
			double num = Math.Sqrt(x * x + y * y);
			if (num > 9.99999993922529E-09)
			{
				double theta = Math.Atan2(y, x);
				double startAngleRad = -1.5707963267948966;
				double num2 = SolarSchoolRadarOverlapUtil.GetRadialBoundary(this.EventTargetRadii, theta, startAngleRad) - 0.06;
				if (num2 > 0.0 && num > num2)
				{
					double num3 = num2 / num;
					x *= num3;
					y *= num3;
				}
			}
			this.PnlEventAttribute.SetPointPosition((float)x, -(float)y);
		}

		// Token: 0x06038320 RID: 230176 RVA: 0x00FB5D89 File Offset: 0x00FB3F89
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			if (sequenceName != "Aim" || eventName != "Change")
			{
				return;
			}
			this.SetJudgeResultState();
		}

		// Token: 0x06038321 RID: 230177 RVA: 0x00FB5DAC File Offset: 0x00FB3FAC
		private void OnChoiceSelected(int optionId)
		{
			this.SetMaskActive(true);
			SolarSchoolEventInfoPanel pnlEventInfo = this.PnlEventInfo;
			if (pnlEventInfo != null)
			{
				pnlEventInfo.SetChoiceInteractable(false);
			}
			ISolarSchoolEventCheckViewHandler handler = this.Handler;
			if (handler == null)
			{
				return;
			}
			handler.OnChoiceSelected(optionId);
		}

		// Token: 0x06038322 RID: 230178 RVA: 0x00FB5DD8 File Offset: 0x00FB3FD8
		private void SetMaskActive(bool active)
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(active);
		}

		// Token: 0x06038323 RID: 230179 RVA: 0x00FB5E09 File Offset: 0x00FB4009
		private void OnConfirmClick()
		{
			ISolarSchoolEventCheckViewHandler handler = this.Handler;
			if (handler == null)
			{
				return;
			}
			handler.OnResultConfirmed();
		}

		// Token: 0x06038324 RID: 230180 RVA: 0x00FB5E1B File Offset: 0x00FB401B
		private void OnBtnMaskClick()
		{
			if (!this.IsResultDescTyping)
			{
				return;
			}
			SolarSchoolEventInfoPanel pnlEventInfo = this.PnlEventInfo;
			if (pnlEventInfo == null)
			{
				return;
			}
			pnlEventInfo.SkipResultDescTyping();
		}

		// Token: 0x06038325 RID: 230181 RVA: 0x00FB5E36 File Offset: 0x00FB4036
		private void OnResultDescTypingFinished()
		{
			this.IsResultDescTyping = false;
			this.PnlEventInfo.SetConfirmActive(true);
			this.SetMaskActive(false);
		}

		// Token: 0x0401D952 RID: 121170
		[Nullable(2)]
		private SolarSchoolEventInfoPanel PnlEventInfo;

		// Token: 0x0401D953 RID: 121171
		[Nullable(2)]
		private SolarSchoolEventAttributePanel PnlEventAttribute;

		// Token: 0x0401D954 RID: 121172
		[Nullable(2)]
		private ISolarSchoolEventCheckViewHandler Handler;

		// Token: 0x0401D955 RID: 121173
		private readonly List<int> OptionIds = new List<int>();

		// Token: 0x0401D956 RID: 121174
		private const float RadarStartAngleDeg = -90f;

		// Token: 0x0401D957 RID: 121175
		private const string JudgeResultSequenceEventName = "Change";

		// Token: 0x0401D958 RID: 121176
		private readonly List<Vector2D> HopPoints = new List<Vector2D>();

		// Token: 0x0401D959 RID: 121177
		private readonly ScrollingNumberTool NumberTool = new ScrollingNumberTool();

		// Token: 0x0401D95A RID: 121178
		[Nullable(2)]
		private UniTaskCompletionSource NumberAnimPromise;

		// Token: 0x0401D95B RID: 121179
		private int AnimationVersion;

		// Token: 0x0401D95C RID: 121180
		private bool JudgeSuccess;

		// Token: 0x0401D95D RID: 121181
		private bool IsResultDescTyping;

		// Token: 0x0401D95E RID: 121182
		private double FinalRate;

		// Token: 0x0401D95F RID: 121183
		private int LowRateThreshold;

		// Token: 0x0401D960 RID: 121184
		private float[] PlayerTargetRadii = Array.Empty<float>();

		// Token: 0x0401D961 RID: 121185
		private float[] EventTargetRadii = Array.Empty<float>();

		// Token: 0x0200B4C6 RID: 46278
		[Nullable(0)]
		private class SequenceNames
		{
			// Token: 0x04037E5B RID: 228955
			public const string TargetMove = "TargetMove";

			// Token: 0x04037E5C RID: 228956
			public const string TargetAim = "TargetAim";

			// Token: 0x04037E5D RID: 228957
			public const string Aim = "Aim";

			// Token: 0x04037E5E RID: 228958
			public const string EventResult = "EventResult";
		}

		// Token: 0x0200B4C7 RID: 46279
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04037E5F RID: 228959
			public const int PnlEventInfo = 0;

			// Token: 0x04037E60 RID: 228960
			public const int PnlEventAttribute = 1;

			// Token: 0x04037E61 RID: 228961
			public const int BtnMask = 2;
		}

		// Token: 0x0200B4C8 RID: 46280
		[NullableContext(0)]
		private static class AnimParams
		{
			// Token: 0x04037E62 RID: 228962
			public const int PointPathCount = 4;
		}
	}
}
