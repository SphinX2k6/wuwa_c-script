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
	// Token: 0x020053A1 RID: 21409
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleAreaProgressTips : UiTickViewBase
	{
		// Token: 0x06036B2B RID: 224043 RVA: 0x00CF20EE File Offset: 0x00CF02EE
		public MoraleAreaProgressTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036B2C RID: 224044 RVA: 0x00CF20F8 File Offset: 0x00CF02F8
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

		// Token: 0x06036B2D RID: 224045 RVA: 0x00CF21C0 File Offset: 0x00CF03C0
		private void InitDataParam()
		{
		}

		// Token: 0x06036B2E RID: 224046 RVA: 0x00CF21C4 File Offset: 0x00CF03C4
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleAreaProgressTips.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleAreaProgressTips.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036B2F RID: 224047 RVA: 0x00CF2207 File Offset: 0x00CF0407
		protected override void OnStart()
		{
			this.UpdateData();
		}

		// Token: 0x06036B30 RID: 224048 RVA: 0x00CF220F File Offset: 0x00CF040F
		protected override void OnAfterShow()
		{
			this.PlayAllProgress().Forget();
		}

		// Token: 0x06036B31 RID: 224049 RVA: 0x00CF221C File Offset: 0x00CF041C
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

		// Token: 0x06036B32 RID: 224050 RVA: 0x00CF2250 File Offset: 0x00CF0450
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

		// Token: 0x06036B33 RID: 224051 RVA: 0x00CF22C4 File Offset: 0x00CF04C4
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

		// Token: 0x06036B34 RID: 224052 RVA: 0x00CF231C File Offset: 0x00CF051C
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

		// Token: 0x06036B35 RID: 224053 RVA: 0x00CF236E File Offset: 0x00CF056E
		public float GetStartValue()
		{
			MoraleAreaProgressTips.Params @params = this.OpenParam as MoraleAreaProgressTips.Params;
			return (float)((@params != null) ? @params.StartNum : 0);
		}

		// Token: 0x06036B36 RID: 224054 RVA: 0x00CF2388 File Offset: 0x00CF0588
		public float GetAddValue()
		{
			MoraleAreaProgressTips.Params @params = this.OpenParam as MoraleAreaProgressTips.Params;
			return (float)((@params != null) ? @params.AddNum : 0);
		}

		// Token: 0x06036B37 RID: 224055 RVA: 0x00CF23A2 File Offset: 0x00CF05A2
		public float GetTargetValue()
		{
			return this.GetStartValue() + this.GetAddValue();
		}

		// Token: 0x06036B38 RID: 224056 RVA: 0x00CF23B4 File Offset: 0x00CF05B4
		public void UpdateProgressDesc()
		{
			float addValue = this.GetAddValue();
			UUIText text = base.GetText(7);
			MoraleAreaProgressTips.Params @params = this.OpenParam as MoraleAreaProgressTips.Params;
			string textStringId = ((@params != null) ? @params.SourceDescKey : null) ?? "";
			LguiUtil.Instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlySingleElementList<object>(addValue));
		}

		// Token: 0x06036B39 RID: 224057 RVA: 0x00CF2408 File Offset: 0x00CF0608
		private MoraleAreaProgressItem CreatePercentItem()
		{
			return new MoraleAreaProgressItem();
		}

		// Token: 0x06036B3A RID: 224058 RVA: 0x00CF240F File Offset: 0x00CF060F
		private MoraleAreaProgressPointItem CreatePercentPointItem()
		{
			return new MoraleAreaProgressPointItem();
		}

		// Token: 0x06036B3B RID: 224059 RVA: 0x00CF2418 File Offset: 0x00CF0618
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

		// Token: 0x06036B3C RID: 224060 RVA: 0x00CF2490 File Offset: 0x00CF0690
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

		// Token: 0x06036B3D RID: 224061 RVA: 0x00CF2544 File Offset: 0x00CF0744
		public UniTask InitCurve()
		{
			MoraleAreaProgressTips.<InitCurve>d__32 <InitCurve>d__;
			<InitCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurve>d__.<>4__this = this;
			<InitCurve>d__.<>1__state = -1;
			<InitCurve>d__.<>t__builder.Start<MoraleAreaProgressTips.<InitCurve>d__32>(ref <InitCurve>d__);
			return <InitCurve>d__.<>t__builder.Task;
		}

		// Token: 0x06036B3E RID: 224062 RVA: 0x00CF2588 File Offset: 0x00CF0788
		public float GetCurveTime(UCurveFloat curve)
		{
			int num = curve.FloatCurve.Keys.Num();
			if (num <= 0)
			{
				return 1000f;
			}
			return curve.FloatCurve.Keys.Get(num - 1).Time * 1000f;
		}

		// Token: 0x06036B3F RID: 224063 RVA: 0x00CF25CE File Offset: 0x00CF07CE
		public float GetCurveValue(UCurveFloat curve, float time)
		{
			return curve.GetFloatValue(time / 1000f);
		}

		// Token: 0x06036B40 RID: 224064 RVA: 0x00CF25E0 File Offset: 0x00CF07E0
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

		// Token: 0x06036B41 RID: 224065 RVA: 0x00CF2624 File Offset: 0x00CF0824
		public UniTask PlayNewProgress()
		{
			MoraleAreaProgressTips.<PlayNewProgress>d__36 <PlayNewProgress>d__;
			<PlayNewProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayNewProgress>d__.<>4__this = this;
			<PlayNewProgress>d__.<>1__state = -1;
			<PlayNewProgress>d__.<>t__builder.Start<MoraleAreaProgressTips.<PlayNewProgress>d__36>(ref <PlayNewProgress>d__);
			return <PlayNewProgress>d__.<>t__builder.Task;
		}

		// Token: 0x06036B42 RID: 224066 RVA: 0x00CF2668 File Offset: 0x00CF0868
		public UniTask PlayGridProgress()
		{
			MoraleAreaProgressTips.<PlayGridProgress>d__37 <PlayGridProgress>d__;
			<PlayGridProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayGridProgress>d__.<>4__this = this;
			<PlayGridProgress>d__.<>1__state = -1;
			<PlayGridProgress>d__.<>t__builder.Start<MoraleAreaProgressTips.<PlayGridProgress>d__37>(ref <PlayGridProgress>d__);
			return <PlayGridProgress>d__.<>t__builder.Task;
		}

		// Token: 0x06036B43 RID: 224067 RVA: 0x00CF26AC File Offset: 0x00CF08AC
		public UniTask PlayAllProgress()
		{
			MoraleAreaProgressTips.<PlayAllProgress>d__38 <PlayAllProgress>d__;
			<PlayAllProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAllProgress>d__.<>4__this = this;
			<PlayAllProgress>d__.<>1__state = -1;
			<PlayAllProgress>d__.<>t__builder.Start<MoraleAreaProgressTips.<PlayAllProgress>d__38>(ref <PlayAllProgress>d__);
			return <PlayAllProgress>d__.<>t__builder.Task;
		}

		// Token: 0x06036B44 RID: 224068 RVA: 0x00CF26EF File Offset: 0x00CF08EF
		protected override void OnTick(float delta)
		{
			this.TickNewProgress(delta);
			this.TickGridProgress(delta);
		}

		// Token: 0x06036B45 RID: 224069 RVA: 0x00CF2700 File Offset: 0x00CF0900
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

		// Token: 0x06036B46 RID: 224070 RVA: 0x00CF2770 File Offset: 0x00CF0970
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

		// Token: 0x06036B47 RID: 224071 RVA: 0x00CF27DD File Offset: 0x00CF09DD
		public void LogInfo()
		{
		}

		// Token: 0x0401CE37 RID: 118327
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<MoraleAreaProgressItem, MoraleAreaProgressData> PercentLayout;

		// Token: 0x0401CE38 RID: 118328
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<MoraleAreaProgressPointItem, MoraleAreaProgressData> PointLayout;

		// Token: 0x0401CE39 RID: 118329
		public UCurveFloat NewProgressCurve;

		// Token: 0x0401CE3A RID: 118330
		public UCurveFloat GridProgressCurve;

		// Token: 0x0401CE3B RID: 118331
		[Nullable(2)]
		public CustomPromise NewProgressPromise;

		// Token: 0x0401CE3C RID: 118332
		[Nullable(2)]
		public CustomPromise GridProgressPromise;

		// Token: 0x0401CE3D RID: 118333
		public bool IsPlayingNewProgress;

		// Token: 0x0401CE3E RID: 118334
		public bool IsPlayingGridProgress;

		// Token: 0x0401CE3F RID: 118335
		public float NewProgressTime;

		// Token: 0x0401CE40 RID: 118336
		public float GridProgressTime;

		// Token: 0x0401CE41 RID: 118337
		public float DeltaNewProgressTime;

		// Token: 0x0401CE42 RID: 118338
		public float DeltaGridProgressTime;

		// Token: 0x0200B61B RID: 46619
		[Nullable(0)]
		public class Params
		{
			// Token: 0x04037297 RID: 225943
			public int StartNum;

			// Token: 0x04037298 RID: 225944
			public int AddNum;

			// Token: 0x04037299 RID: 225945
			public string SourceDescKey;

			// Token: 0x0403729A RID: 225946
			public List<MoraleAreaProgressData> InfoList;

			// Token: 0x0403729B RID: 225947
			public bool IsMultipleView;
		}

		// Token: 0x0200B61C RID: 46620
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403729C RID: 225948
			public const int LayoutProgress = 0;

			// Token: 0x0403729D RID: 225949
			public const int ItemProgressTemplate = 1;

			// Token: 0x0403729E RID: 225950
			public const int ItemNewProgressRoot = 2;

			// Token: 0x0403729F RID: 225951
			public const int SliderNewProgress = 3;

			// Token: 0x040372A0 RID: 225952
			public const int LayoutProgressPoint = 4;

			// Token: 0x040372A1 RID: 225953
			public const int ItemProgressPointTemplate = 5;

			// Token: 0x040372A2 RID: 225954
			public const int TxtProgressValue = 6;

			// Token: 0x040372A3 RID: 225955
			public const int TxtSourceDesc = 7;
		}
	}
}
