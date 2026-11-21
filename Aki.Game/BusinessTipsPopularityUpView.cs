using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007E1 RID: 2017
[NullableContext(1)]
[Nullable(0)]
public class BusinessTipsPopularityUpView : UiViewBase
{
	// Token: 0x06005BF0 RID: 23536 RVA: 0x001DA6E9 File Offset: 0x001D88E9
	public BusinessTipsPopularityUpView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005BF1 RID: 23537 RVA: 0x001DA6F4 File Offset: 0x001D88F4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUISprite)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(USpineSkeletonAnimationComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnConfirm))
		};
	}

	// Token: 0x06005BF2 RID: 23538 RVA: 0x001DA868 File Offset: 0x001D8A68
	private void OnConfirm()
	{
		base.CloseMe(null);
	}

	// Token: 0x06005BF3 RID: 23539 RVA: 0x001DA874 File Offset: 0x001D8A74
	private void InitSequenceData()
	{
		if (this.PopularityUpData.LastPopularity >= this.PopularityUpData.CurrentPopularity)
		{
			UiViewData uiViewData = new UiViewData();
			uiViewData.StartSequenceName = "Start01";
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.SetSequenceName(uiViewData);
		}
	}

	// Token: 0x06005BF4 RID: 23540 RVA: 0x001DA8BC File Offset: 0x001D8ABC
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessTipsPopularityUpView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessTipsPopularityUpView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005BF5 RID: 23541 RVA: 0x001DA900 File Offset: 0x001D8B00
	protected override void OnAfterPlayStartSequence()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.PlaySequencePurely("PopStart", false, false);
		}
		int currentPopularity = this.PopularityUpData.CurrentPopularity;
		int lastPopularity = this.PopularityUpData.LastPopularity;
		int num = currentPopularity - lastPopularity;
		this.PlayBtnShow();
		if (num > 0)
		{
			this.StartTween(lastPopularity);
		}
	}

	// Token: 0x06005BF6 RID: 23542 RVA: 0x001DA950 File Offset: 0x001D8B50
	protected override void OnBeforeDestroy()
	{
		if (this.Delegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(this.PlayFillAmount));
			this.Delegate = null;
		}
		this.StopTween();
		AudioSystem.Instance.ExecuteAction("play_ui_figure_up_2s", EAudioActionType.Stop, null);
	}

	// Token: 0x06005BF7 RID: 23543 RVA: 0x001DA99C File Offset: 0x001D8B9C
	protected override void OnAfterDestroy()
	{
		MoonChasingBusinessModel.Instance.SetIsInDelegate(false);
	}

	// Token: 0x06005BF8 RID: 23544 RVA: 0x001DA9AC File Offset: 0x001D8BAC
	private UniTask InitRoleSpine(bool isLevelUp)
	{
		BusinessTipsPopularityUpView.<InitRoleSpine>d__19 <InitRoleSpine>d__;
		<InitRoleSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleSpine>d__.<>4__this = this;
		<InitRoleSpine>d__.isLevelUp = isLevelUp;
		<InitRoleSpine>d__.<>1__state = -1;
		<InitRoleSpine>d__.<>t__builder.Start<BusinessTipsPopularityUpView.<InitRoleSpine>d__19>(ref <InitRoleSpine>d__);
		return <InitRoleSpine>d__.<>t__builder.Task;
	}

	// Token: 0x06005BF9 RID: 23545 RVA: 0x001DA9F8 File Offset: 0x001D8BF8
	private UniTask InitBgTexture(bool isLevelUp)
	{
		BusinessTipsPopularityUpView.<InitBgTexture>d__20 <InitBgTexture>d__;
		<InitBgTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBgTexture>d__.<>4__this = this;
		<InitBgTexture>d__.isLevelUp = isLevelUp;
		<InitBgTexture>d__.<>1__state = -1;
		<InitBgTexture>d__.<>t__builder.Start<BusinessTipsPopularityUpView.<InitBgTexture>d__20>(ref <InitBgTexture>d__);
		return <InitBgTexture>d__.<>t__builder.Task;
	}

	// Token: 0x06005BFA RID: 23546 RVA: 0x001DAA43 File Offset: 0x001D8C43
	private void InitDialog()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.PopularityUpData.DialogName, Array.Empty<object>());
	}

	// Token: 0x06005BFB RID: 23547 RVA: 0x001DAA66 File Offset: 0x001D8C66
	private void InitLantern(bool isLevelUp)
	{
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(isLevelUp);
		}
		UUIItem item2 = base.GetItem(10);
		if (item2 != null)
		{
			item2.SetUIActive(!isLevelUp);
		}
		UUIItem item3 = base.GetItem(12);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(isLevelUp);
	}

	// Token: 0x06005BFC RID: 23548 RVA: 0x001DAAA6 File Offset: 0x001D8CA6
	private void InitTitle()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.PopularityUpData.Title, Array.Empty<object>());
	}

	// Token: 0x06005BFD RID: 23549 RVA: 0x001DAACC File Offset: 0x001D8CCC
	private void InitBar()
	{
		Popularity currentPopularityConfig = MoonChasingBusinessModel.Instance.GetCurrentPopularityConfig();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), currentPopularityConfig.PopularityRating, Array.Empty<object>());
		int currentPopularity = this.PopularityUpData.CurrentPopularity;
		int lastPopularity = this.PopularityUpData.LastPopularity;
		int num = currentPopularity - lastPopularity;
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetUIActive(num > 0);
		}
		if (num > 0)
		{
			UUIText text2 = base.GetText(5);
			if (text2 != null)
			{
				text2.SetText("+" + num.ToString(), true);
			}
		}
		UUISprite sprite = base.GetSprite(8);
		if (sprite != null)
		{
			sprite.SetFillAmount((float)lastPopularity / (float)this.PopularityValue);
		}
		this.CurrentBar.SetFillAmount((float)lastPopularity / (float)this.PopularityValue);
		this.CurrentText.SetText("<color=#ffd52b>" + lastPopularity.ToString() + "</color>/" + this.PopularityValue.ToString(), true);
	}

	// Token: 0x06005BFE RID: 23550 RVA: 0x001DABB7 File Offset: 0x001D8DB7
	private void StartTween(int startValue)
	{
		AudioSystem.Instance.PostEvent("play_ui_figure_up_2s");
		this.TweenTime = 2f / (float)this.PlayCount;
		this.PlayTween(startValue, 1);
	}

	// Token: 0x06005BFF RID: 23551 RVA: 0x001DABE4 File Offset: 0x001D8DE4
	private void PlayTween(int popularityValue, int playCount)
	{
		this.PopularityValue = MoonChasingBusinessModel.Instance.GetPopularityConfigByValue(popularityValue).PopularityValue;
		if (this.PlayCount > playCount)
		{
			this.CurrentBar.SetFillAmount(1f);
			this.ExpTweener = ULTweenBPLibrary.IntTo(GlobalData.World, this.Delegate, popularityValue, this.PopularityValue, this.TweenTime, 0f, LTweenEase.OutCubic);
			ULTweener expTweener = this.ExpTweener;
			if (expTweener == null)
			{
				return;
			}
			expTweener.OnCompleteCallBack.Bind(delegate()
			{
				this.OnComplete(this.PopularityValue, playCount);
			});
			return;
		}
		else
		{
			int ownCount = MoonChasingModel.Instance.GetPopularityValue();
			this.CurrentBar.SetFillAmount((float)ownCount / (float)this.PopularityValue);
			this.ExpTweener = ULTweenBPLibrary.IntTo(GlobalData.World, this.Delegate, popularityValue, ownCount, this.TweenTime, 0f, LTweenEase.OutCubic);
			ULTweener expTweener2 = this.ExpTweener;
			if (expTweener2 == null)
			{
				return;
			}
			expTweener2.OnCompleteCallBack.Bind(delegate()
			{
				this.OnComplete(ownCount, playCount);
			});
			return;
		}
	}

	// Token: 0x06005C00 RID: 23552 RVA: 0x001DAD08 File Offset: 0x001D8F08
	private void StopTween()
	{
		if (this.ExpTweener != null)
		{
			this.ExpTweener.Kill(false);
			this.ExpTweener = null;
		}
	}

	// Token: 0x06005C01 RID: 23553 RVA: 0x001DAD28 File Offset: 0x001D8F28
	private void PlayBtnShow()
	{
		UUIButtonComponent button = base.GetButton(4);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(true);
		}
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequencePurely("BtnStart", false, false);
	}

	// Token: 0x06005C02 RID: 23554 RVA: 0x001DAD6C File Offset: 0x001D8F6C
	private void PlayFillAmount(int value)
	{
		this.LastBar.SetFillAmount((float)value / (float)this.PopularityValue);
		this.CurrentText.SetText("<color=#ffd52b>" + value.ToString() + "</color>/" + this.PopularityValue.ToString(), true);
	}

	// Token: 0x06005C03 RID: 23555 RVA: 0x001DADBB File Offset: 0x001D8FBB
	private void OnComplete(int endValue, int playCount)
	{
		this.StopTween();
		if (playCount >= this.PlayCount)
		{
			return;
		}
		this.PlayTween(endValue, playCount + 1);
		AudioSystem.Instance.PostEvent("play_ui_zhuiyuejie_levelup");
	}

	// Token: 0x04003D60 RID: 15712
	[Nullable(2)]
	protected ULTweener ExpTweener;

	// Token: 0x04003D61 RID: 15713
	[Nullable(2)]
	protected FLTweenIntSetterDynamic Delegate;

	// Token: 0x04003D62 RID: 15714
	[Nullable(2)]
	private MoonChasingPopularityUpData PopularityUpData;

	// Token: 0x04003D63 RID: 15715
	protected int PopularityValue;

	// Token: 0x04003D64 RID: 15716
	private int PlayCount;

	// Token: 0x04003D65 RID: 15717
	private float TweenTime;

	// Token: 0x04003D66 RID: 15718
	private UUISprite CurrentBar;

	// Token: 0x04003D67 RID: 15719
	private UUIText CurrentText;

	// Token: 0x04003D68 RID: 15720
	private UUISprite LastBar;

	// Token: 0x04003D69 RID: 15721
	private const float TWEEN_TIME = 2f;

	// Token: 0x02006B0D RID: 27405
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04023362 RID: 144226
		public const int Title = 0;

		// Token: 0x04023363 RID: 144227
		public const int Name = 1;

		// Token: 0x04023364 RID: 144228
		public const int Content = 2;

		// Token: 0x04023365 RID: 144229
		public const int ExpItem = 3;

		// Token: 0x04023366 RID: 144230
		public const int ConfirmBtn = 4;

		// Token: 0x04023367 RID: 144231
		public const int AddValue = 5;

		// Token: 0x04023368 RID: 144232
		public const int CurrentValue = 6;

		// Token: 0x04023369 RID: 144233
		public const int CurrentBar = 7;

		// Token: 0x0402336A RID: 144234
		public const int LastBar = 8;

		// Token: 0x0402336B RID: 144235
		public const int LevelUpItem = 9;

		// Token: 0x0402336C RID: 144236
		public const int NormalItem = 10;

		// Token: 0x0402336D RID: 144237
		public const int RoleSpine = 11;

		// Token: 0x0402336E RID: 144238
		public const int LanternItem = 12;

		// Token: 0x0402336F RID: 144239
		public const int BgTexture = 13;
	}
}
