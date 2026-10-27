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
	// Token: 0x02005244 RID: 21060
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleLoading : UiTickViewBase, IUiViewResource
	{
		// Token: 0x06035CB5 RID: 220341 RVA: 0x00CBA5D2 File Offset: 0x00CB87D2
		public PhantomArenaBattleLoading(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06035CB6 RID: 220342 RVA: 0x00CBA5E8 File Offset: 0x00CB87E8
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

		// Token: 0x06035CB7 RID: 220343 RVA: 0x00CBA6B0 File Offset: 0x00CB88B0
		protected override void OnBeforeShow()
		{
			GameAudioController.Instance.UpdateLoadingType(new ELoadingPerform?(ELoadingPerform.Loading));
		}

		// Token: 0x06035CB8 RID: 220344 RVA: 0x00CBA6C4 File Offset: 0x00CB88C4
		protected override void OnBeforeHide()
		{
			GameAudioController.Instance.UpdateLoadingType(null);
		}

		// Token: 0x06035CB9 RID: 220345 RVA: 0x00CBA6E4 File Offset: 0x00CB88E4
		protected override void OnAfterHide()
		{
			EventSystem.Instance.Emit(EEventName.OnPhantomArenaBattleLoadingHide);
		}

		// Token: 0x06035CBA RID: 220346 RVA: 0x00CBA6F8 File Offset: 0x00CB88F8
		private UniTask InitLoadingBg()
		{
			PhantomArenaBattleLoading.<InitLoadingBg>d__19 <InitLoadingBg>d__;
			<InitLoadingBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoadingBg>d__.<>4__this = this;
			<InitLoadingBg>d__.<>1__state = -1;
			<InitLoadingBg>d__.<>t__builder.Start<PhantomArenaBattleLoading.<InitLoadingBg>d__19>(ref <InitLoadingBg>d__);
			return <InitLoadingBg>d__.<>t__builder.Task;
		}

		// Token: 0x06035CBB RID: 220347 RVA: 0x00CBA73C File Offset: 0x00CB893C
		private UniTask InitOpponentLayout()
		{
			PhantomArenaBattleLoading.<InitOpponentLayout>d__20 <InitOpponentLayout>d__;
			<InitOpponentLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOpponentLayout>d__.<>4__this = this;
			<InitOpponentLayout>d__.<>1__state = -1;
			<InitOpponentLayout>d__.<>t__builder.Start<PhantomArenaBattleLoading.<InitOpponentLayout>d__20>(ref <InitOpponentLayout>d__);
			return <InitOpponentLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06035CBC RID: 220348 RVA: 0x00CBA77F File Offset: 0x00CB897F
		private int GetOpponentIndex(int index)
		{
			if (index < 3)
			{
				return 3 + index;
			}
			return index - 3;
		}

		// Token: 0x06035CBD RID: 220349 RVA: 0x00CBA78C File Offset: 0x00CB898C
		private UniTask InitOwnLayout()
		{
			PhantomArenaBattleLoading.<InitOwnLayout>d__22 <InitOwnLayout>d__;
			<InitOwnLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOwnLayout>d__.<>4__this = this;
			<InitOwnLayout>d__.<>1__state = -1;
			<InitOwnLayout>d__.<>t__builder.Start<PhantomArenaBattleLoading.<InitOwnLayout>d__22>(ref <InitOwnLayout>d__);
			return <InitOwnLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06035CBE RID: 220350 RVA: 0x00CBA7D0 File Offset: 0x00CB89D0
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleLoading.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleLoading.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035CBF RID: 220351 RVA: 0x00CBA813 File Offset: 0x00CB8A13
		private PhantomArenaBattleLoadingItem InitLoadItem()
		{
			return new PhantomArenaBattleLoadingItem();
		}

		// Token: 0x06035CC0 RID: 220352 RVA: 0x00CBA81C File Offset: 0x00CB8A1C
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

		// Token: 0x06035CC1 RID: 220353 RVA: 0x00CBA8BC File Offset: 0x00CB8ABC
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

		// Token: 0x06035CC2 RID: 220354 RVA: 0x00CBA9AC File Offset: 0x00CB8BAC
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

		// Token: 0x06035CC3 RID: 220355 RVA: 0x00CBAA23 File Offset: 0x00CB8C23
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

		// Token: 0x06035CC4 RID: 220356 RVA: 0x00CBAA5B File Offset: 0x00CB8C5B
		public string GetExtraResourceId(object param = null)
		{
			if (!PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				return "UiView_DesktopLoadingNew";
			}
			return "UiView_DesktopLoading";
		}

		// Token: 0x0401C85E RID: 116830
		private const int CARD_FRONT = 3;

		// Token: 0x0401C85F RID: 116831
		private const int CARD_TOTAL = 6;

		// Token: 0x0401C860 RID: 116832
		private const float PER_INTERVAL = 2f;

		// Token: 0x0401C861 RID: 116833
		protected GenericLayout<PhantomArenaBattleLoadingItem, IPhantomArenaBattleLoadingInfo> OpponentLayout;

		// Token: 0x0401C862 RID: 116834
		protected GenericLayout<PhantomArenaBattleLoadingItem, IPhantomArenaBattleLoadingInfo> OwnLayout;

		// Token: 0x0401C863 RID: 116835
		protected bool IsLoadStart;

		// Token: 0x0401C864 RID: 116836
		protected bool IsLoadEnd;

		// Token: 0x0401C865 RID: 116837
		protected bool NotNeedEntity;

		// Token: 0x0401C866 RID: 116838
		protected float NotNeedTimeCount;

		// Token: 0x0401C867 RID: 116839
		protected WaitEntityTask WaitTask;

		// Token: 0x0401C868 RID: 116840
		protected int EntityTotal;

		// Token: 0x0401C869 RID: 116841
		protected float CurCount;

		// Token: 0x0401C86A RID: 116842
		protected float CountSpeed = 1f;

		// Token: 0x0200B3C6 RID: 46022
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040367C4 RID: 223172
			public const int OpponentLayout = 0;

			// Token: 0x040367C5 RID: 223173
			public const int OpponentItem = 1;

			// Token: 0x040367C6 RID: 223174
			public const int OwnLayout = 2;

			// Token: 0x040367C7 RID: 223175
			public const int OwnItem = 3;

			// Token: 0x040367C8 RID: 223176
			public const int SliderL = 4;

			// Token: 0x040367C9 RID: 223177
			public const int SliderR = 5;

			// Token: 0x040367CA RID: 223178
			public const int TxtTitle = 6;

			// Token: 0x040367CB RID: 223179
			public const int LoadingBg = 7;
		}
	}
}
