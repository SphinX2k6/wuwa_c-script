using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x0200537C RID: 21372
	[NullableContext(1)]
	[Nullable(0)]
	public class MovieModeAspectView : UiPanelBase
	{
		// Token: 0x17008360 RID: 33632
		// (get) Token: 0x0603697C RID: 223612 RVA: 0x00CECE69 File Offset: 0x00CEB069
		// (set) Token: 0x0603697D RID: 223613 RVA: 0x00CECE76 File Offset: 0x00CEB076
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

		// Token: 0x0603697E RID: 223614 RVA: 0x00CECE80 File Offset: 0x00CEB080
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

		// Token: 0x0603697F RID: 223615 RVA: 0x00CECEEC File Offset: 0x00CEB0EC
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
			this.RealtimeLayers = this.AdaptUiLayers.Intersect(this.RealtimeAdaptUiLayers).ToArray<ELayerType>();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MovieMode;
			ELogAuthor author = ELogAuthor.CB;
			string message = "设置适配的UI层级";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AdaptUiLayers", (from layer in this.AdaptUiLayers
			select layer.ToString()).ToArray<string>());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RealtimeLayers", (from layer in this.RealtimeLayers
			select layer.ToString()).ToArray<string>());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.IsBanAdaptation = this.OpenParam.IsBanAdaptation;
			this.SaveUiLayerSafeZoneInfo();
		}

		// Token: 0x06036980 RID: 223616 RVA: 0x00CED080 File Offset: 0x00CEB280
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

		// Token: 0x06036981 RID: 223617 RVA: 0x00CED0A8 File Offset: 0x00CEB2A8
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

		// Token: 0x06036982 RID: 223618 RVA: 0x00CED0FC File Offset: 0x00CEB2FC
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

		// Token: 0x06036983 RID: 223619 RVA: 0x00CED198 File Offset: 0x00CEB398
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

		// Token: 0x06036984 RID: 223620 RVA: 0x00CED2BC File Offset: 0x00CEB4BC
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

		// Token: 0x06036985 RID: 223621 RVA: 0x00CED2FF File Offset: 0x00CEB4FF
		private void RemoveTick()
		{
			MovieModeController.Instance.RemoveTick(this.TickHandle);
			this.TickHandle = -1;
		}

		// Token: 0x06036986 RID: 223622 RVA: 0x00CED318 File Offset: 0x00CEB518
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

		// Token: 0x06036987 RID: 223623 RVA: 0x00CED5D4 File Offset: 0x00CEB7D4
		private void SetupAnimation(float screenSize, float targetValue)
		{
			this.CurrentValue = (this.IsFadeIn ? screenSize : targetValue);
			this.TargetValue = (this.IsFadeIn ? targetValue : screenSize);
			this.TotalOffset = Math.Abs(this.TargetValue - this.CurrentValue);
			this.Speed = ((this.BlendTime == 0f) ? 0f : ((this.TargetValue - this.CurrentValue) / this.BlendTime));
			this.ApplyStretchValues(this.CurrentValue);
		}

		// Token: 0x06036988 RID: 223624 RVA: 0x00CED658 File Offset: 0x00CEB858
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

		// Token: 0x06036989 RID: 223625 RVA: 0x00CED70C File Offset: 0x00CEB90C
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

		// Token: 0x0603698A RID: 223626 RVA: 0x00CED766 File Offset: 0x00CEB966
		private float GetAspectOffsetValue()
		{
			if (!this.IsWidthBlend)
			{
				return this.OriginalUiHeight - this.CurrentValue;
			}
			return this.OriginalUiWidth - this.CurrentValue;
		}

		// Token: 0x0603698B RID: 223627 RVA: 0x00CED78C File Offset: 0x00CEB98C
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

		// Token: 0x0603698C RID: 223628 RVA: 0x00CED984 File Offset: 0x00CEBB84
		private void AdaptRealtimeUiLayer()
		{
			if (this.RealtimeLayers.Length == 0 || this.IsBanAdaptation)
			{
				return;
			}
			this.ApplyLayerAdaptation(this.RealtimeLayers, this.GetAspectOffsetValue());
		}

		// Token: 0x0603698D RID: 223629 RVA: 0x00CED9AC File Offset: 0x00CEBBAC
		private unsafe void SetAdaptUiLayerVisible(bool bVisible)
		{
			if (this.AdaptUiLayers == null || this.OpenParam.IsIgnoreUiLayerVisible.GetValueOrDefault())
			{
				return;
			}
			foreach (ELayerType elayerType in this.AdaptUiLayers)
			{
				if (!this.RealtimeLayers.Contains(elayerType))
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

		// Token: 0x0603698E RID: 223630 RVA: 0x00CEDA88 File Offset: 0x00CEBC88
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

		// Token: 0x0603698F RID: 223631 RVA: 0x00CEDBFF File Offset: 0x00CEBDFF
		public bool IsHorizontalBlackBarsVisible()
		{
			return !this.IsBanAdaptation && !this.AspectOffset.IsWidthBlend && this.AspectOffset.Offset > 0f;
		}

		// Token: 0x06036990 RID: 223632 RVA: 0x00CEDC2A File Offset: 0x00CEBE2A
		public IMovieModeAspectOffset GetAspectOffset()
		{
			return this.AspectOffset;
		}

		// Token: 0x06036991 RID: 223633 RVA: 0x00CEDC34 File Offset: 0x00CEBE34
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

		// Token: 0x0401CDAD RID: 118189
		private bool Enable;

		// Token: 0x0401CDAE RID: 118190
		[Nullable(2)]
		private UUITexture Texture1;

		// Token: 0x0401CDAF RID: 118191
		[Nullable(2)]
		private UUITexture Texture2;

		// Token: 0x0401CDB0 RID: 118192
		private readonly float CacheRatio = 2.3703704f;

		// Token: 0x0401CDB1 RID: 118193
		private float BlendTime;

		// Token: 0x0401CDB2 RID: 118194
		private float Duration;

		// Token: 0x0401CDB3 RID: 118195
		private float Speed;

		// Token: 0x0401CDB4 RID: 118196
		private float CurrentValue;

		// Token: 0x0401CDB5 RID: 118197
		private float TargetValue;

		// Token: 0x0401CDB6 RID: 118198
		private bool IsWidthBlend;

		// Token: 0x0401CDB7 RID: 118199
		private int TickHandle = -1;

		// Token: 0x0401CDB8 RID: 118200
		private bool IsFadeIn = true;

		// Token: 0x0401CDB9 RID: 118201
		[Nullable(2)]
		private CustomPromise FadeCompletePromise;

		// Token: 0x0401CDBA RID: 118202
		private float OriginalUiWidth;

		// Token: 0x0401CDBB RID: 118203
		private float OriginalUiHeight;

		// Token: 0x0401CDBC RID: 118204
		private readonly IMovieModeAspectOffset AspectOffset = new MovieModeAspectOffset
		{
			IsFadeIn = true,
			IsWidthBlend = false,
			Offset = 0f,
			Progress = 0f
		};

		// Token: 0x0401CDBD RID: 118205
		private float TotalOffset;

		// Token: 0x0401CDBE RID: 118206
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

		// Token: 0x0401CDBF RID: 118207
		private readonly ELayerType[] RealtimeAdaptUiLayers = new ELayerType[]
		{
			ELayerType.Loading
		};

		// Token: 0x0401CDC0 RID: 118208
		[Nullable(2)]
		private ELayerType[] AdaptUiLayers;

		// Token: 0x0401CDC1 RID: 118209
		private ELayerType[] RealtimeLayers = Array.Empty<ELayerType>();

		// Token: 0x0401CDC2 RID: 118210
		[Nullable(2)]
		private ULGUICanvasScaler CanvasScaler;

		// Token: 0x0401CDC3 RID: 118211
		private bool IsBanAdaptation;

		// Token: 0x0401CDC4 RID: 118212
		private readonly Dictionary<ELayerType, IUiLayerSafeZone> UiLayerSafeZoneInfos = new Dictionary<ELayerType, IUiLayerSafeZone>();

		// Token: 0x0200B5ED RID: 46573
		[NullableContext(0)]
		private enum EChildItem
		{
			// Token: 0x040371B8 RID: 225720
			Texture1,
			// Token: 0x040371B9 RID: 225721
			Texture2
		}
	}
}
