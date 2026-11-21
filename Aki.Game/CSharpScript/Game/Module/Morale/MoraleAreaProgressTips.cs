using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02004384 RID: 17284
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleAreaProgressTips : UiTickViewBase
	{
		// Token: 0x0602BA71 RID: 178801 RVA: 0x00C41196 File Offset: 0x00C3F396
		public MoraleAreaProgressTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BA72 RID: 178802 RVA: 0x00C411A0 File Offset: 0x00C3F3A0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(4, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIText))
			};
		}

		// Token: 0x0602BA73 RID: 178803 RVA: 0x00C41268 File Offset: 0x00C3F468
		private void InitDataParam()
		{
		}

		// Token: 0x0602BA74 RID: 178804 RVA: 0x00C4126C File Offset: 0x00C3F46C
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleAreaProgressTips.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleAreaProgressTips.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA75 RID: 178805 RVA: 0x00C412AF File Offset: 0x00C3F4AF
		protected override void OnStart()
		{
			this.UpdateData();
		}

		// Token: 0x0602BA76 RID: 178806 RVA: 0x00C412B7 File Offset: 0x00C3F4B7
		protected override void OnAfterShow()
		{
			this.PlayAllProgress().Forget();
		}

		// Token: 0x0602BA77 RID: 178807 RVA: 0x00C412C4 File Offset: 0x00C3F4C4
		protected override void OnBeforeDestroy()
		{
			this.IsPlayingGridProgress = false;
			this.IsPlayingNewProgress = false;
			CustomPromise newProgressPromise = this.NewProgressPromise;
			if (newProgressPromise != null)
			{
				newProgressPromise.SetResult();
			}
			CustomPromise gridProgressPromise = this.GridProgressPromise;
			if (gridProgressPromise == null)
			{
				return;
			}
			gridProgressPromise.SetResult();
		}

		// Token: 0x0602BA78 RID: 178808 RVA: 0x00C412F8 File Offset: 0x00C3F4F8
		public void UpdateData()
		{
			this.UpdateProgressDesc();
			MoraleAreaProgressTips.Params @params = this.OpenParam as MoraleAreaProgressTips.Params;
			IReadOnlyList<MoraleAreaProgressData> readOnlyList = (@params != null) ? @params.InfoList : null;
			IReadOnlyList<MoraleAreaProgressData> data = readOnlyList ?? Array.Empty<MoraleAreaProgressData>();
			GenericLayout<MoraleAreaProgressItem, MoraleAreaProgressData> percentLayout = this.PercentLayout;
			if (percentLayout != null)
			{
				percentLayout.RefreshByData(data, null, false);
			}
			GenericLayout<MoraleAreaProgressPointItem, MoraleAreaProgressData> pointLayout = this.PointLayout;
			if (pointLayout != null)
			{
				pointLayout.RefreshByData(data, null, false);
			}
			this.UpdateNewProgress(0f);
			this.UpdateGridProgress(0f);
		}

		// Token: 0x0602BA79 RID: 178809 RVA: 0x00C4136C File Offset: 0x00C3F56C
		public void UpdateProgressText(float score)
		{
			UUIText text = base.GetText(6);
			float totalValue = this.GetTotalValue();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>((int)score);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<float>(totalValue);
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			if (text == null)
			{
				return;
			}
			text.SetText(newText, true);
		}

		// Token: 0x0602BA7A RID: 178810 RVA: 0x00C413C4 File Offset: 0x00C3F5C4
		public float GetTotalValue()
		{
			MoraleAreaProgressTips.Params @params = this.OpenParam as MoraleAreaProgressTips.Params;
			IReadOnlyList<MoraleAreaProgressData> readOnlyList = (@params != null) ? @params.InfoList : null;
			IReadOnlyList<MoraleAreaProgressData> readOnlyList2 = readOnlyList ?? Array.Empty<MoraleAreaProgressData>();
			if (readOnlyList2.Count == 0)
			{
				return 1f;
			}
			IReadOnlyList<MoraleAreaProgressData> readOnlyList3 = readOnlyList2;
			return (float)readOnlyList3[readOnlyList3.Count - 1].TargetScore;
		}

		// Token: 0x0602BA7B RID: 178811 RVA: 0x00C41416 File Offset: 0x00C3F616
		public float GetStartValue()
		{
			MoraleAreaProgressTips.Params @params = this.OpenParam as MoraleAreaProgressTips.Params;
			return (float)((@params != null) ? @params.StartNum : 0);
		}

		// Token: 0x0602BA7C RID: 178812 RVA: 0x00C41430 File Offset: 0x00C3F630
		public float GetAddValue()
		{
			MoraleAreaProgressTips.Params @params = this.OpenParam as MoraleAreaProgressTips.Params;
			return (float)((@params != null) ? @params.AddNum : 0);
		}

		// Token: 0x0602BA7D RID: 178813 RVA: 0x00C4144A File Offset: 0x00C3F64A
		public float GetTargetValue()
		{
			return this.GetStartValue() + this.GetAddValue();
		}

		// Token: 0x0602BA7E RID: 178814 RVA: 0x00C4145C File Offset: 0x00C3F65C
		public void UpdateProgressDesc()
		{
			float addValue = this.GetAddValue();
			UUIText text = base.GetText(7);
			MoraleAreaProgressTips.Params @params = this.OpenParam as MoraleAreaProgressTips.Params;
			string textStringId = ((@params != null) ? @params.SourceDescKey : null) ?? "";
			LguiUtil.Instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlySingleElementList<object>(addValue));
		}

		// Token: 0x0602BA7F RID: 178815 RVA: 0x00C414B0 File Offset: 0x00C3F6B0
		private MoraleAreaProgressItem CreatePercentItem()
		{
			return new MoraleAreaProgressItem();
		}

		// Token: 0x0602BA80 RID: 178816 RVA: 0x00C414B7 File Offset: 0x00C3F6B7
		private MoraleAreaProgressPointItem CreatePercentPointItem()
		{
			return new MoraleAreaProgressPointItem();
		}

		// Token: 0x0602BA81 RID: 178817 RVA: 0x00C414C0 File Offset: 0x00C3F6C0
		public void UpdateNewProgress(float percent)
		{
			float num = Math.Max(0f, Math.Min(percent, 1f));
			UUISliderComponent slider = base.GetSlider(3);
			float startValue = this.GetStartValue();
			float totalValue = this.GetTotalValue();
			float addValue = this.GetAddValue();
			float num2 = addValue * num / totalValue;
			float inValue = startValue / totalValue + num2;
			if (slider != null)
			{
				slider.SetValue(inValue, true);
			}
			if (this.GridProgressTime <= 0f)
			{
				float score = startValue + addValue * num;
				this.UpdateProgressText(score);
			}
		}

		// Token: 0x0602BA82 RID: 178818 RVA: 0x00C41538 File Offset: 0x00C3F738
		public void UpdateGridProgress(float percent)
		{
			float num = Math.Max(0f, Math.Min(percent, 1f));
			float startValue = this.GetStartValue();
			float addValue = this.GetAddValue();
			float num2 = startValue + addValue * num;
			GenericLayout<MoraleAreaProgressItem, MoraleAreaProgressData> percentLayout = this.PercentLayout;
			List<MoraleAreaProgressItem> list = (percentLayout != null) ? percentLayout.GetLayoutItemList() : null;
			if (list != null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					list[i].SetUiProgressByScore((int)num2);
				}
			}
			GenericLayout<MoraleAreaProgressPointItem, MoraleAreaProgressData> pointLayout = this.PointLayout;
			List<MoraleAreaProgressPointItem> list2 = (pointLayout != null) ? pointLayout.GetLayoutItemList() : null;
			if (list2 != null)
			{
				for (int j = 0; j < list2.Count; j++)
				{
					list2[j].SetUiProgressByScore((int)num2);
				}
			}
			this.UpdateProgressText(num2);
		}

		// Token: 0x0602BA83 RID: 178819 RVA: 0x00C415EC File Offset: 0x00C3F7EC
		public UniTask InitCurve()
		{
			MoraleAreaProgressTips.<InitCurve>d__32 <InitCurve>d__;
			<InitCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurve>d__.<>4__this = this;
			<InitCurve>d__.<>1__state = -1;
			<InitCurve>d__.<>t__builder.Start<MoraleAreaProgressTips.<InitCurve>d__32>(ref <InitCurve>d__);
			return <InitCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA84 RID: 178820 RVA: 0x00C41630 File Offset: 0x00C3F830
		public float GetCurveTime(UCurveFloat curve)
		{
			int num = curve.FloatCurve.Keys.Num();
			if (num <= 0)
			{
				return 1000f;
			}
			return curve.FloatCurve.Keys.Get(num - 1).Time * 1000f;
		}

		// Token: 0x0602BA85 RID: 178821 RVA: 0x00C41676 File Offset: 0x00C3F876
		public float GetCurveValue(UCurveFloat curve, float time)
		{
			return curve.GetFloatValue(time / 1000f);
		}

		// Token: 0x0602BA86 RID: 178822 RVA: 0x00C41688 File Offset: 0x00C3F888
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<UCurveFloat> LoadCurveFloat(string resId)
		{
			MoraleAreaProgressTips.<LoadCurveFloat>d__35 <LoadCurveFloat>d__;
			<LoadCurveFloat>d__.<>t__builder = AsyncUniTaskMethodBuilder<UCurveFloat>.Create();
			<LoadCurveFloat>d__.resId = resId;
			<LoadCurveFloat>d__.<>1__state = -1;
			<LoadCurveFloat>d__.<>t__builder.Start<MoraleAreaProgressTips.<LoadCurveFloat>d__35>(ref <LoadCurveFloat>d__);
			return <LoadCurveFloat>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA87 RID: 178823 RVA: 0x00C416CC File Offset: 0x00C3F8CC
		public UniTask PlayNewProgress()
		{
			MoraleAreaProgressTips.<PlayNewProgress>d__36 <PlayNewProgress>d__;
			<PlayNewProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayNewProgress>d__.<>4__this = this;
			<PlayNewProgress>d__.<>1__state = -1;
			<PlayNewProgress>d__.<>t__builder.Start<MoraleAreaProgressTips.<PlayNewProgress>d__36>(ref <PlayNewProgress>d__);
			return <PlayNewProgress>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA88 RID: 178824 RVA: 0x00C41710 File Offset: 0x00C3F910
		public UniTask PlayGridProgress()
		{
			MoraleAreaProgressTips.<PlayGridProgress>d__37 <PlayGridProgress>d__;
			<PlayGridProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayGridProgress>d__.<>4__this = this;
			<PlayGridProgress>d__.<>1__state = -1;
			<PlayGridProgress>d__.<>t__builder.Start<MoraleAreaProgressTips.<PlayGridProgress>d__37>(ref <PlayGridProgress>d__);
			return <PlayGridProgress>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA89 RID: 178825 RVA: 0x00C41754 File Offset: 0x00C3F954
		public UniTask PlayAllProgress()
		{
			MoraleAreaProgressTips.<PlayAllProgress>d__38 <PlayAllProgress>d__;
			<PlayAllProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAllProgress>d__.<>4__this = this;
			<PlayAllProgress>d__.<>1__state = -1;
			<PlayAllProgress>d__.<>t__builder.Start<MoraleAreaProgressTips.<PlayAllProgress>d__38>(ref <PlayAllProgress>d__);
			return <PlayAllProgress>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA8A RID: 178826 RVA: 0x00C41797 File Offset: 0x00C3F997
		protected override void OnTick(float delta)
		{
			this.TickNewProgress(delta);
			this.TickGridProgress(delta);
		}

		// Token: 0x0602BA8B RID: 178827 RVA: 0x00C417A8 File Offset: 0x00C3F9A8
		public void TickNewProgress(float delta)
		{
			if (!this.IsPlayingNewProgress)
			{
				return;
			}
			this.DeltaNewProgressTime += delta;
			float time = this.DeltaNewProgressTime;
			if (this.DeltaNewProgressTime >= this.NewProgressTime)
			{
				time = this.NewProgressTime;
				this.IsPlayingNewProgress = false;
				CustomPromise newProgressPromise = this.NewProgressPromise;
				if (newProgressPromise != null)
				{
					newProgressPromise.SetResult();
				}
			}
			float curveValue = this.GetCurveValue(this.NewProgressCurve, time);
			this.UpdateNewProgress(curveValue);
		}

		// Token: 0x0602BA8C RID: 178828 RVA: 0x00C41818 File Offset: 0x00C3FA18
		public void TickGridProgress(float delta)
		{
			if (!this.IsPlayingGridProgress)
			{
				return;
			}
			this.DeltaGridProgressTime += delta;
			float time = this.DeltaGridProgressTime;
			if (this.DeltaGridProgressTime >= this.GridProgressTime)
			{
				time = this.GridProgressTime;
				this.IsPlayingGridProgress = false;
				CustomPromise gridProgressPromise = this.GridProgressPromise;
				if (gridProgressPromise != null)
				{
					gridProgressPromise.SetResult();
				}
			}
			float curveValue = this.GetCurveValue(this.GridProgressCurve, time);
			this.UpdateGridProgress(curveValue);
		}

		// Token: 0x0602BA8D RID: 178829 RVA: 0x00C41885 File Offset: 0x00C3FA85
		public void LogInfo()
		{
		}

		// Token: 0x040178CF RID: 96463
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<MoraleAreaProgressItem, MoraleAreaProgressData> PercentLayout;

		// Token: 0x040178D0 RID: 96464
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<MoraleAreaProgressPointItem, MoraleAreaProgressData> PointLayout;

		// Token: 0x040178D1 RID: 96465
		public UCurveFloat NewProgressCurve;

		// Token: 0x040178D2 RID: 96466
		public UCurveFloat GridProgressCurve;

		// Token: 0x040178D3 RID: 96467
		[Nullable(2)]
		public CustomPromise NewProgressPromise;

		// Token: 0x040178D4 RID: 96468
		[Nullable(2)]
		public CustomPromise GridProgressPromise;

		// Token: 0x040178D5 RID: 96469
		public bool IsPlayingNewProgress;

		// Token: 0x040178D6 RID: 96470
		public bool IsPlayingGridProgress;

		// Token: 0x040178D7 RID: 96471
		public float NewProgressTime;

		// Token: 0x040178D8 RID: 96472
		public float GridProgressTime;

		// Token: 0x040178D9 RID: 96473
		public float DeltaNewProgressTime;

		// Token: 0x040178DA RID: 96474
		public float DeltaGridProgressTime;

		// Token: 0x0200A053 RID: 41043
		[Nullable(0)]
		public class Params
		{
			// Token: 0x04031CEC RID: 204012
			public int StartNum;

			// Token: 0x04031CED RID: 204013
			public int AddNum;

			// Token: 0x04031CEE RID: 204014
			public string SourceDescKey;

			// Token: 0x04031CEF RID: 204015
			public List<MoraleAreaProgressData> InfoList;

			// Token: 0x04031CF0 RID: 204016
			public bool IsMultipleView;
		}

		// Token: 0x0200A054 RID: 41044
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031CF1 RID: 204017
			public const int LayoutProgress = 0;

			// Token: 0x04031CF2 RID: 204018
			public const int ItemProgressTemplate = 1;

			// Token: 0x04031CF3 RID: 204019
			public const int ItemNewProgressRoot = 2;

			// Token: 0x04031CF4 RID: 204020
			public const int SliderNewProgress = 3;

			// Token: 0x04031CF5 RID: 204021
			public const int LayoutProgressPoint = 4;

			// Token: 0x04031CF6 RID: 204022
			public const int ItemProgressPointTemplate = 5;

			// Token: 0x04031CF7 RID: 204023
			public const int TxtProgressValue = 6;

			// Token: 0x04031CF8 RID: 204024
			public const int TxtSourceDesc = 7;
		}
	}
}
