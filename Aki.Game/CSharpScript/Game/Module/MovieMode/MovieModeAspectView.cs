using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x0200435F RID: 17247
	[NullableContext(1)]
	[Nullable(0)]
	public class MovieModeAspectView : UiPanelBase
	{
		// Token: 0x1700572C RID: 22316
		// (get) Token: 0x0602B8C2 RID: 178370 RVA: 0x00C3BD61 File Offset: 0x00C39F61
		// (set) Token: 0x0602B8C3 RID: 178371 RVA: 0x00C3BD6E File Offset: 0x00C39F6E
		public new MovieModeAspectViewParams OpenParam
		{
			get
			{
				return (MovieModeAspectViewParams)this.OpenParam;
			}
			set
			{
				this.OpenParam = value;
			}
		}

		// Token: 0x0602B8C4 RID: 178372 RVA: 0x00C3BD78 File Offset: 0x00C39F78
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602B8C5 RID: 178373 RVA: 0x00C3BDE4 File Offset: 0x00C39FE4
		protected unsafe override void OnStart()
		{
			this.Texture1 = base.GetTexture(0);
			UUITexture texture = this.Texture1;
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			UUITexture texture2 = this.Texture1;
			if (texture2 != null)
			{
				texture2.SetAlpha(1f);
			}
			this.Texture2 = base.GetTexture(1);
			UUITexture texture3 = this.Texture2;
			if (texture3 != null)
			{
				texture3.SetUIActive(false);
			}
			UUITexture texture4 = this.Texture2;
			if (texture4 != null)
			{
				texture4.SetAlpha(1f);
			}
			base.GetRootItem().GetRenderCanvas().bPostTickUpdate = true;
			base.GetRootItem().SetRaycastTarget(false);
			this.AdaptUiLayers = (this.OpenParam.AdaptUiLayers ?? this.DefaultAdaptUiLayers);
			List<ELayerType> list = new List<ELayerType>();
			foreach (ELayerType elayerType in this.AdaptUiLayers)
			{
				if (Array.IndexOf<ELayerType>(this.RealtimeAdaptUiLayers, elayerType) >= 0 && !list.Contains(elayerType))
				{
					list.Add(elayerType);
				}
			}
			this.RealtimeLayers = list.ToArray();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MovieMode;
			ELogAuthor author = ELogAuthor.CB;
			string message = "设置适配的UI层级";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AdaptUiLayers", Array.ConvertAll<ELayerType, string>(this.AdaptUiLayers, (ELayerType layer) => layer.ToString()));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RealtimeLayers", Array.ConvertAll<ELayerType, string>(this.RealtimeLayers, (ELayerType layer) => layer.ToString()));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.IsBanAdaptation = this.OpenParam.IsBanAdaptation;
			this.SaveUiLayerSafeZoneInfo();
		}

		// Token: 0x0602B8C6 RID: 178374 RVA: 0x00C3BFA0 File Offset: 0x00C3A1A0
		protected override void OnBeforeDestroy()
		{
			CustomPromise fadeCompletePromise = this.FadeCompletePromise;
			if (fadeCompletePromise != null)
			{
				fadeCompletePromise.SetResult();
			}
			this.RemoveTick();
			this.SetAdaptUiLayerVisible(true);
			this.AdaptUiLayer(false);
		}

		// Token: 0x0602B8C7 RID: 178375 RVA: 0x00C3BFC8 File Offset: 0x00C3A1C8
		public UniTask Fade(bool isFadeIn, float blendTime)
		{
			MovieModeAspectView.<Fade>d__31 <Fade>d__;
			<Fade>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Fade>d__.<>4__this = this;
			<Fade>d__.isFadeIn = isFadeIn;
			<Fade>d__.blendTime = blendTime;
			<Fade>d__.<>1__state = -1;
			<Fade>d__.<>t__builder.Start<MovieModeAspectView.<Fade>d__31>(ref <Fade>d__);
			return <Fade>d__.<>t__builder.Task;
		}

		// Token: 0x0602B8C8 RID: 178376 RVA: 0x00C3C01C File Offset: 0x00C3A21C
		public void FadeReverse()
		{
			this.IsFadeIn = !this.IsFadeIn;
			this.Speed = -this.Speed;
			this.Duration = this.BlendTime - this.Duration;
			float num = this.IsWidthBlend ? this.OriginalUiWidth : this.OriginalUiHeight;
			float num2 = this.IsWidthBlend ? (this.OriginalUiHeight * this.CacheRatio) : (this.OriginalUiWidth / this.CacheRatio);
			float num3 = num / 2f + num2 / 2f;
			this.TargetValue = (this.IsFadeIn ? num3 : num);
		}

		// Token: 0x0602B8C9 RID: 178377 RVA: 0x00C3C0B8 File Offset: 0x00C3A2B8
		private void OnTick(float delta)
		{
			if (this.Duration >= this.BlendTime)
			{
				this.OnFadeComplete();
				return;
			}
			this.Duration += delta;
			this.CurrentValue += delta * this.Speed;
			this.CurrentValue = (this.IsFadeIn ? Math.Max(this.CurrentValue, this.TargetValue) : Math.Min(this.CurrentValue, this.TargetValue));
			this.ApplyStretchValues(this.CurrentValue);
			this.AdaptRealtimeUiLayer();
			this.AspectOffset.IsFadeIn = this.IsFadeIn;
			this.AspectOffset.IsWidthBlend = this.IsWidthBlend;
			this.AspectOffset.Offset = (this.IsWidthBlend ? (this.OriginalUiWidth - this.CurrentValue) : (this.OriginalUiHeight - this.CurrentValue));
			this.AspectOffset.Progress = ((this.TotalOffset == 0f) ? 0f : (this.AspectOffset.Offset / this.TotalOffset));
			EventSystem.Instance.Emit<IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetUpdate, this.AspectOffset);
		}

		// Token: 0x0602B8CA RID: 178378 RVA: 0x00C3C1DC File Offset: 0x00C3A3DC
		private void OnFadeComplete()
		{
			CustomPromise fadeCompletePromise = this.FadeCompletePromise;
			if (fadeCompletePromise != null)
			{
				fadeCompletePromise.SetResult();
			}
			this.RemoveTick();
			Log.Instance.Info(ELogModule.MovieMode, ELogAuthor.CB, "电影模式黑边设置完成", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602B8CB RID: 178379 RVA: 0x00C3C21F File Offset: 0x00C3A41F
		private void RemoveTick()
		{
			MovieModeController.Instance.RemoveTick(this.TickHandle);
			this.TickHandle = -1;
		}

		// Token: 0x0602B8CC RID: 178380 RVA: 0x00C3C238 File Offset: 0x00C3A438
		private unsafe void StartTransform()
		{
			if (!this.Enable)
			{
				return;
			}
			this.Enable = false;
			UUITexture texture = this.Texture1;
			if (texture != null)
			{
				texture.SetUIActive(!this.IsBanAdaptation);
			}
			UUITexture texture2 = this.Texture2;
			if (texture2 != null)
			{
				texture2.SetUIActive(!this.IsBanAdaptation);
			}
			this.OriginalUiWidth = UiLayer.Instance.UiRootItem.GetWidth();
			this.OriginalUiHeight = UiLayer.Instance.UiRootItem.GetHeight();
			float num = this.OriginalUiWidth / this.OriginalUiHeight;
			this.IsWidthBlend = (this.CacheRatio < num);
			this.AspectOffset.IsWidthBlend = this.IsWidthBlend;
			float num2 = this.IsWidthBlend ? this.OriginalUiWidth : this.OriginalUiHeight;
			float num3 = this.IsWidthBlend ? (this.OriginalUiHeight * this.CacheRatio) : (this.OriginalUiWidth / this.CacheRatio);
			float targetValue = num2 / 2f + num3 / 2f;
			this.SetupAnimation(num2, targetValue);
			this.Duration = 0f;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MovieMode;
			ELogAuthor author = ELogAuthor.CB;
			string message = "进出电影模式，更新黑边";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("uiWidth", this.OriginalUiWidth);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("uiHeight", this.OriginalUiHeight);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("isFadeIn", this.IsFadeIn);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("currentValue", this.CurrentValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("targetValue", this.TargetValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("BlendTime", this.BlendTime);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			if (this.BlendTime <= 0f)
			{
				this.CurrentValue = this.TargetValue;
				this.ApplyStretchValues(this.CurrentValue);
				this.AdaptRealtimeUiLayer();
				this.AspectOffset.IsFadeIn = this.IsFadeIn;
				this.AspectOffset.IsWidthBlend = this.IsWidthBlend;
				this.AspectOffset.Offset = (this.IsWidthBlend ? (this.OriginalUiWidth - this.CurrentValue) : (this.OriginalUiHeight - this.CurrentValue));
				this.AspectOffset.Progress = 1f;
				EventSystem.Instance.Emit<IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetUpdate, this.AspectOffset);
				this.OnFadeComplete();
				return;
			}
			this.TickHandle = MovieModeController.Instance.AddTick(new Action<float>(this.OnTick));
		}

		// Token: 0x0602B8CD RID: 178381 RVA: 0x00C3C4FC File Offset: 0x00C3A6FC
		private void SetupAnimation(float screenSize, float targetValue)
		{
			this.CurrentValue = (this.IsFadeIn ? screenSize : targetValue);
			this.TargetValue = (this.IsFadeIn ? targetValue : screenSize);
			this.TotalOffset = Math.Abs(this.TargetValue - this.CurrentValue);
			this.Speed = ((this.BlendTime == 0f) ? 0f : ((this.TargetValue - this.CurrentValue) / this.BlendTime));
			this.ApplyStretchValues(this.CurrentValue);
		}

		// Token: 0x0602B8CE RID: 178382 RVA: 0x00C3C580 File Offset: 0x00C3A780
		private void ApplyStretchValues(float value)
		{
			if (this.IsWidthBlend)
			{
				UUITexture texture = this.Texture1;
				if (texture != null)
				{
					texture.SetStretchRight(value);
				}
				UUITexture texture2 = this.Texture2;
				if (texture2 != null)
				{
					texture2.SetStretchLeft(value);
				}
				UUITexture texture3 = this.Texture1;
				if (texture3 != null)
				{
					texture3.SetStretchTop(0f);
				}
				UUITexture texture4 = this.Texture2;
				if (texture4 == null)
				{
					return;
				}
				texture4.SetStretchBottom(0f);
				return;
			}
			else
			{
				UUITexture texture5 = this.Texture1;
				if (texture5 != null)
				{
					texture5.SetStretchTop(value);
				}
				UUITexture texture6 = this.Texture2;
				if (texture6 != null)
				{
					texture6.SetStretchBottom(value);
				}
				UUITexture texture7 = this.Texture1;
				if (texture7 != null)
				{
					texture7.SetStretchRight(0f);
				}
				UUITexture texture8 = this.Texture2;
				if (texture8 == null)
				{
					return;
				}
				texture8.SetStretchLeft(0f);
				return;
			}
		}

		// Token: 0x0602B8CF RID: 178383 RVA: 0x00C3C634 File Offset: 0x00C3A834
		private void AdaptUiLayer(bool bAdapt)
		{
			if (this.AdaptUiLayers == null)
			{
				return;
			}
			if (this.IsBanAdaptation)
			{
				Log.Instance.Info(ELogModule.MovieMode, ELogAuthor.CB, "没有黑边,不需要适配UI", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.ApplyLayerAdaptation(this.AdaptUiLayers, bAdapt ? this.GetAspectOffsetValue() : 0f);
		}

		// Token: 0x0602B8D0 RID: 178384 RVA: 0x00C3C68E File Offset: 0x00C3A88E
		private float GetAspectOffsetValue()
		{
			if (!this.IsWidthBlend)
			{
				return this.OriginalUiHeight - this.CurrentValue;
			}
			return this.OriginalUiWidth - this.CurrentValue;
		}

		// Token: 0x0602B8D1 RID: 178385 RVA: 0x00C3C6B4 File Offset: 0x00C3A8B4
		private void ApplyLayerAdaptation(ELayerType[] layers, float offset)
		{
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			if (uiRootItem == null)
			{
				return;
			}
			float num = this.IsWidthBlend ? offset : 0f;
			float num2 = this.IsWidthBlend ? 0f : offset;
			float width = uiRootItem.GetWidth() - num * 2f;
			float height = uiRootItem.GetHeight() - num2 * 2f;
			float width2 = 0f;
			float height2 = 0f;
			float num3 = 0f;
			if (this.CanvasScaler == null)
			{
				this.CanvasScaler = uiRootItem.GetCanvasScaler();
			}
			ULGUICanvasScaler canvasScaler = this.CanvasScaler;
			if (canvasScaler != null)
			{
				canvasScaler.CalculateAdaptedSizeAndScale(width, height, ref width2, ref height2, ref num3);
			}
			FVector relativeScale3D = uiRootItem.RelativeScale3D;
			FVector uiitemScale = new FVector(relativeScale3D.X * num3, relativeScale3D.Y * num3, relativeScale3D.Z * num3);
			foreach (ELayerType elayerType in layers)
			{
				UUIItem layerRootUiItem = UiLayer.Instance.GetLayerRootUiItem(elayerType);
				if (layerRootUiItem == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.MovieMode;
					ELogAuthor author = ELogAuthor.CB;
					string message = "获取UI层失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("layer", elayerType.ToString());
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					layerRootUiItem.SetAnchorOffset(Vector2D.ZeroVector);
					layerRootUiItem.SetWidth(width2);
					layerRootUiItem.SetHeight(height2);
					layerRootUiItem.SetUIItemScale(uiitemScale);
					float stretchTop = layerRootUiItem.GetStretchTop();
					float stretchBottom = layerRootUiItem.GetStretchBottom();
					float stretchLeft = layerRootUiItem.GetStretchLeft();
					float stretchRight = layerRootUiItem.GetStretchRight();
					layerRootUiItem.SetStretchTop(stretchTop + this.UiLayerSafeZoneInfos[elayerType].StretchTop);
					layerRootUiItem.SetStretchBottom(stretchBottom + this.UiLayerSafeZoneInfos[elayerType].StretchBottom);
					layerRootUiItem.SetStretchLeft(stretchLeft + this.UiLayerSafeZoneInfos[elayerType].StretchLeft);
					layerRootUiItem.SetStretchRight(stretchRight + this.UiLayerSafeZoneInfos[elayerType].StretchRight);
				}
			}
		}

		// Token: 0x0602B8D2 RID: 178386 RVA: 0x00C3C8AC File Offset: 0x00C3AAAC
		private void AdaptRealtimeUiLayer()
		{
			if (this.RealtimeLayers.Length == 0 || this.IsBanAdaptation)
			{
				return;
			}
			this.ApplyLayerAdaptation(this.RealtimeLayers, this.GetAspectOffsetValue());
		}

		// Token: 0x0602B8D3 RID: 178387 RVA: 0x00C3C8D4 File Offset: 0x00C3AAD4
		private unsafe void SetAdaptUiLayerVisible(bool bVisible)
		{
			if (this.AdaptUiLayers == null || this.OpenParam.IsIgnoreUiLayerVisible.GetValueOrDefault())
			{
				return;
			}
			foreach (ELayerType elayerType in this.AdaptUiLayers)
			{
				if (Array.IndexOf<ELayerType>(this.RealtimeLayers, elayerType) < 0)
				{
					UUIItem layerRootUiItem = UiLayer.Instance.GetLayerRootUiItem(elayerType);
					if (layerRootUiItem != null)
					{
						layerRootUiItem.SetUIActive(bVisible);
					}
					Log instance = Log.Instance;
					ELogModule module = ELogModule.MovieMode;
					ELogAuthor author = ELogAuthor.CB;
					string message = "设置UI层可见状态";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("layer", elayerType.ToString());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("bVisible", bVisible);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}

		// Token: 0x0602B8D4 RID: 178388 RVA: 0x00C3C9B0 File Offset: 0x00C3ABB0
		private unsafe void SaveUiLayerSafeZoneInfo()
		{
			if (this.AdaptUiLayers == null)
			{
				return;
			}
			foreach (ELayerType elayerType in this.AdaptUiLayers)
			{
				UUIItem layerRootUiItem = UiLayer.Instance.GetLayerRootUiItem(elayerType);
				float num = (layerRootUiItem != null) ? layerRootUiItem.GetStretchLeft() : 0f;
				float num2 = (layerRootUiItem != null) ? layerRootUiItem.GetStretchRight() : 0f;
				float num3 = (layerRootUiItem != null) ? layerRootUiItem.GetStretchTop() : 0f;
				float num4 = (layerRootUiItem != null) ? layerRootUiItem.GetStretchBottom() : 0f;
				this.UiLayerSafeZoneInfos[elayerType] = new UiLayerSafeZone
				{
					StretchLeft = num,
					StretchRight = num2,
					StretchTop = num3,
					StretchBottom = num4
				};
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MovieMode;
				ELogAuthor author = ELogAuthor.CB;
				string message = "保存UI层安全区信息";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("layer", elayerType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("stretchLeft", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("stretchRight", num2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("stretchTop", num3);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("stretchBottom", num4);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			}
		}

		// Token: 0x0602B8D5 RID: 178389 RVA: 0x00C3CB27 File Offset: 0x00C3AD27
		public bool IsHorizontalBlackBarsVisible()
		{
			return !this.IsBanAdaptation && !this.AspectOffset.IsWidthBlend && this.AspectOffset.Offset > 0f;
		}

		// Token: 0x0602B8D6 RID: 178390 RVA: 0x00C3CB52 File Offset: 0x00C3AD52
		public IMovieModeAspectOffset GetAspectOffset()
		{
			return this.AspectOffset;
		}

		// Token: 0x0602B8D7 RID: 178391 RVA: 0x00C3CB5C File Offset: 0x00C3AD5C
		public unsafe void UpdateTransform()
		{
			this.OriginalUiWidth = UiLayer.Instance.UiRootItem.GetWidth();
			this.OriginalUiHeight = UiLayer.Instance.UiRootItem.GetHeight();
			float num = this.OriginalUiWidth / this.OriginalUiHeight;
			this.IsWidthBlend = (this.CacheRatio < num);
			this.AspectOffset.IsWidthBlend = this.IsWidthBlend;
			float num2 = this.IsWidthBlend ? this.OriginalUiWidth : this.OriginalUiHeight;
			float num3 = this.IsWidthBlend ? (this.OriginalUiHeight * this.CacheRatio) : (this.OriginalUiWidth / this.CacheRatio);
			float num4 = num2 / 2f + num3 / 2f;
			float num5 = this.IsFadeIn ? num2 : num4;
			float num6 = this.IsFadeIn ? num4 : num2;
			float num7 = MathUtils.Instance.Clamp(this.Duration / this.BlendTime, 0f, 1f);
			this.CurrentValue = num5 + (num6 - num5) * num7;
			this.TargetValue = num6;
			this.TotalOffset = Math.Abs(num6 - num5);
			this.Speed = ((this.BlendTime == 0f) ? 0f : ((num6 - num5) / this.BlendTime));
			this.ApplyStretchValues(this.CurrentValue);
			this.AdaptUiLayer(true);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MovieMode;
			ELogAuthor author = ELogAuthor.CB;
			string message = "屏幕分辨率有改变，更新黑边";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("uiWidth", this.OriginalUiWidth);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("uiHeight", this.OriginalUiHeight);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("isFadeIn", this.IsFadeIn);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("currentValue", this.CurrentValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("targetValue", this.TargetValue);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		}

		// Token: 0x04017845 RID: 96325
		private bool Enable;

		// Token: 0x04017846 RID: 96326
		[Nullable(2)]
		private UUITexture Texture1;

		// Token: 0x04017847 RID: 96327
		[Nullable(2)]
		private UUITexture Texture2;

		// Token: 0x04017848 RID: 96328
		private readonly float CacheRatio = 2.3703704f;

		// Token: 0x04017849 RID: 96329
		private float BlendTime;

		// Token: 0x0401784A RID: 96330
		private float Duration;

		// Token: 0x0401784B RID: 96331
		private float Speed;

		// Token: 0x0401784C RID: 96332
		private float CurrentValue;

		// Token: 0x0401784D RID: 96333
		private float TargetValue;

		// Token: 0x0401784E RID: 96334
		private bool IsWidthBlend;

		// Token: 0x0401784F RID: 96335
		private int TickHandle = -1;

		// Token: 0x04017850 RID: 96336
		private bool IsFadeIn = true;

		// Token: 0x04017851 RID: 96337
		[Nullable(2)]
		private CustomPromise FadeCompletePromise;

		// Token: 0x04017852 RID: 96338
		private float OriginalUiWidth;

		// Token: 0x04017853 RID: 96339
		private float OriginalUiHeight;

		// Token: 0x04017854 RID: 96340
		private readonly IMovieModeAspectOffset AspectOffset = new MovieModeAspectOffset
		{
			IsFadeIn = true,
			IsWidthBlend = false,
			Offset = 0f,
			Progress = 0f
		};

		// Token: 0x04017855 RID: 96341
		private float TotalOffset;

		// Token: 0x04017856 RID: 96342
		private readonly ELayerType[] DefaultAdaptUiLayers = new ELayerType[]
		{
			ELayerType.HUD,
			ELayerType.Normal,
			ELayerType.Plot,
			ELayerType.BattleFloat,
			ELayerType.Pop,
			ELayerType.Float,
			ELayerType.Loading
		};

		// Token: 0x04017857 RID: 96343
		private readonly ELayerType[] RealtimeAdaptUiLayers = new ELayerType[]
		{
			ELayerType.Loading
		};

		// Token: 0x04017858 RID: 96344
		[Nullable(2)]
		private ELayerType[] AdaptUiLayers;

		// Token: 0x04017859 RID: 96345
		private ELayerType[] RealtimeLayers = Array.Empty<ELayerType>();

		// Token: 0x0401785A RID: 96346
		[Nullable(2)]
		private ULGUICanvasScaler CanvasScaler;

		// Token: 0x0401785B RID: 96347
		private bool IsBanAdaptation;

		// Token: 0x0401785C RID: 96348
		private readonly Dictionary<ELayerType, IUiLayerSafeZone> UiLayerSafeZoneInfos = new Dictionary<ELayerType, IUiLayerSafeZone>();

		// Token: 0x0200A025 RID: 40997
		[NullableContext(0)]
		private enum EChildItem
		{
			// Token: 0x04031C0D RID: 203789
			Texture1,
			// Token: 0x04031C0E RID: 203790
			Texture2
		}
	}
}
