using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x02004214 RID: 16916
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleLoading : UiTickViewBase, IUiViewResource
	{
		// Token: 0x0602ABB0 RID: 175024 RVA: 0x00C07C12 File Offset: 0x00C05E12
		public PhantomArenaBattleLoading(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602ABB1 RID: 175025 RVA: 0x00C07C28 File Offset: 0x00C05E28
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(5, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUITexture))
			};
		}

		// Token: 0x0602ABB2 RID: 175026 RVA: 0x00C07CF0 File Offset: 0x00C05EF0
		protected override void OnBeforeShow()
		{
			GameAudioController.Instance.UpdateLoadingType(new ELoadingPerform?(ELoadingPerform.Loading));
		}

		// Token: 0x0602ABB3 RID: 175027 RVA: 0x00C07D04 File Offset: 0x00C05F04
		protected override void OnBeforeHide()
		{
			GameAudioController.Instance.UpdateLoadingType(null);
		}

		// Token: 0x0602ABB4 RID: 175028 RVA: 0x00C07D24 File Offset: 0x00C05F24
		protected override void OnAfterHide()
		{
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaBattleLoadingHide);
		}

		// Token: 0x0602ABB5 RID: 175029 RVA: 0x00C07D38 File Offset: 0x00C05F38
		private UniTask InitLoadingBg()
		{
			PhantomArenaBattleLoading.<InitLoadingBg>d__19 <InitLoadingBg>d__;
			<InitLoadingBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoadingBg>d__.<>4__this = this;
			<InitLoadingBg>d__.<>1__state = -1;
			<InitLoadingBg>d__.<>t__builder.Start<PhantomArenaBattleLoading.<InitLoadingBg>d__19>(ref <InitLoadingBg>d__);
			return <InitLoadingBg>d__.<>t__builder.Task;
		}

		// Token: 0x0602ABB6 RID: 175030 RVA: 0x00C07D7C File Offset: 0x00C05F7C
		private UniTask InitOpponentLayout()
		{
			PhantomArenaBattleLoading.<InitOpponentLayout>d__20 <InitOpponentLayout>d__;
			<InitOpponentLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOpponentLayout>d__.<>4__this = this;
			<InitOpponentLayout>d__.<>1__state = -1;
			<InitOpponentLayout>d__.<>t__builder.Start<PhantomArenaBattleLoading.<InitOpponentLayout>d__20>(ref <InitOpponentLayout>d__);
			return <InitOpponentLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0602ABB7 RID: 175031 RVA: 0x00C07DBF File Offset: 0x00C05FBF
		private int GetOpponentIndex(int index)
		{
			if (index < 3)
			{
				return 3 + index;
			}
			return index - 3;
		}

		// Token: 0x0602ABB8 RID: 175032 RVA: 0x00C07DCC File Offset: 0x00C05FCC
		private UniTask InitOwnLayout()
		{
			PhantomArenaBattleLoading.<InitOwnLayout>d__22 <InitOwnLayout>d__;
			<InitOwnLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOwnLayout>d__.<>4__this = this;
			<InitOwnLayout>d__.<>1__state = -1;
			<InitOwnLayout>d__.<>t__builder.Start<PhantomArenaBattleLoading.<InitOwnLayout>d__22>(ref <InitOwnLayout>d__);
			return <InitOwnLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0602ABB9 RID: 175033 RVA: 0x00C07E10 File Offset: 0x00C06010
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleLoading.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleLoading.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ABBA RID: 175034 RVA: 0x00C07E53 File Offset: 0x00C06053
		private PhantomArenaBattleLoadingItem InitLoadItem()
		{
			return new PhantomArenaBattleLoadingItem();
		}

		// Token: 0x0602ABBB RID: 175035 RVA: 0x00C07E5C File Offset: 0x00C0605C
		protected void WaitEntityLoadFinish()
		{
			List<long> allEntityIdList = PhantomArenaBattleModel.Instance.BattleData.GetAllEntityIdList();
			if (allEntityIdList.Count == 0)
			{
				this.NotNeedEntity = true;
			}
			else
			{
				this.NotNeedEntity = false;
				this.EntityTotal = allEntityIdList.Count;
				this.CurCount = 0f;
				this.CountSpeed = 2f * (float)this.EntityTotal;
				this.WaitTask = WaitEntityTask.Create("PhantomArenaEntityNotify", allEntityIdList, delegate(bool? _)
				{
				}, 60000, true, false);
			}
			this.IsLoadStart = true;
		}

		// Token: 0x0602ABBC RID: 175036 RVA: 0x00C07EFC File Offset: 0x00C060FC
		protected override void OnTick(float delta)
		{
			if (!this.IsLoadStart || this.IsLoadEnd)
			{
				return;
			}
			if (!this.NotNeedEntity)
			{
				int currentLoading = PhantomArenaBattleModel.Instance.CurrentLoading;
				if (this.CurCount < (float)currentLoading)
				{
					float num = delta * this.CountSpeed / 1000f;
					this.CurCount = Math.Min(this.CurCount + num, (float)currentLoading);
					this.CurCount = Math.Min(this.CurCount, (float)this.EntityTotal);
				}
				float loadingValue = this.CurCount / (float)this.EntityTotal;
				this.SetLoadingValue(loadingValue);
				if (this.CurCount >= (float)this.EntityTotal)
				{
					this.OnLoadingEnd();
				}
				return;
			}
			this.NotNeedTimeCount += delta;
			if (this.NotNeedTimeCount >= 2f)
			{
				this.NotNeedTimeCount = 2f;
				this.SetLoadingValue(1f);
				this.OnLoadingEnd();
				return;
			}
			this.SetLoadingValue(this.NotNeedTimeCount / 2f);
		}

		// Token: 0x0602ABBD RID: 175037 RVA: 0x00C07FEC File Offset: 0x00C061EC
		protected void SetLoadingValue(float value)
		{
			UUISliderComponent slider = base.GetSlider(4);
			if (slider != null)
			{
				slider.SetValue(value, true);
			}
			UUISliderComponent slider2 = base.GetSlider(5);
			if (slider2 != null)
			{
				slider2.SetValue(value, true);
			}
			UUIText text = base.GetText(6);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Floor((double)(value * 100f)));
			defaultInterpolatedStringHandler.AppendLiteral("%");
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0602ABBE RID: 175038 RVA: 0x00C08063 File Offset: 0x00C06263
		protected void OnLoadingEnd()
		{
			this.IsLoadEnd = true;
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaBattleVsView, null, delegate(bool _, int _)
			{
				PhantomArenaBattleModel.Instance.IsBattleLoading = false;
				PhantomArenaBattleModel.Instance.CurrentLoading = 0;
				UiManager.Instance.CloseView(EUiViewName.PhantomArenaBattleLoading, null);
			});
		}

		// Token: 0x0602ABBF RID: 175039 RVA: 0x00C0809B File Offset: 0x00C0629B
		public string GetExtraResourceId(object param = null)
		{
			if (!PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				return "UiView_DesktopLoadingNew";
			}
			return "UiView_DesktopLoading";
		}

		// Token: 0x04017293 RID: 94867
		private const int CARD_FRONT = 3;

		// Token: 0x04017294 RID: 94868
		private const int CARD_TOTAL = 6;

		// Token: 0x04017295 RID: 94869
		private const float PER_INTERVAL = 2f;

		// Token: 0x04017296 RID: 94870
		protected GenericLayout<PhantomArenaBattleLoadingItem, IPhantomArenaBattleLoadingInfo> OpponentLayout;

		// Token: 0x04017297 RID: 94871
		protected GenericLayout<PhantomArenaBattleLoadingItem, IPhantomArenaBattleLoadingInfo> OwnLayout;

		// Token: 0x04017298 RID: 94872
		protected bool IsLoadStart;

		// Token: 0x04017299 RID: 94873
		protected bool IsLoadEnd;

		// Token: 0x0401729A RID: 94874
		protected bool NotNeedEntity;

		// Token: 0x0401729B RID: 94875
		protected float NotNeedTimeCount;

		// Token: 0x0401729C RID: 94876
		protected WaitEntityTask WaitTask;

		// Token: 0x0401729D RID: 94877
		protected int EntityTotal;

		// Token: 0x0401729E RID: 94878
		protected float CurCount;

		// Token: 0x0401729F RID: 94879
		protected float CountSpeed = 1f;

		// Token: 0x02009DFE RID: 40446
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031217 RID: 201239
			public const int OpponentLayout = 0;

			// Token: 0x04031218 RID: 201240
			public const int OpponentItem = 1;

			// Token: 0x04031219 RID: 201241
			public const int OwnLayout = 2;

			// Token: 0x0403121A RID: 201242
			public const int OwnItem = 3;

			// Token: 0x0403121B RID: 201243
			public const int SliderL = 4;

			// Token: 0x0403121C RID: 201244
			public const int SliderR = 5;

			// Token: 0x0403121D RID: 201245
			public const int TxtTitle = 6;

			// Token: 0x0403121E RID: 201246
			public const int LoadingBg = 7;
		}
	}
}
