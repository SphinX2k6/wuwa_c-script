using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200132D RID: 4909
[NullableContext(1)]
[Nullable(0)]
public class BusinessTipsPopularityUpView : UiViewBase
{
	// Token: 0x06008855 RID: 34901 RVA: 0x001D187D File Offset: 0x001CFA7D
	public BusinessTipsPopularityUpView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008856 RID: 34902 RVA: 0x001D1888 File Offset: 0x001CFA88
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

	// Token: 0x06008857 RID: 34903 RVA: 0x001D19FC File Offset: 0x001CFBFC
	private void OnConfirm()
	{
		base.CloseMe(null);
	}

	// Token: 0x06008858 RID: 34904 RVA: 0x001D1A08 File Offset: 0x001CFC08
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

	// Token: 0x06008859 RID: 34905 RVA: 0x001D1A50 File Offset: 0x001CFC50
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessTipsPopularityUpView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessTipsPopularityUpView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600885A RID: 34906 RVA: 0x001D1A94 File Offset: 0x001CFC94
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

	// Token: 0x0600885B RID: 34907 RVA: 0x001D1AE4 File Offset: 0x001CFCE4
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

	// Token: 0x0600885C RID: 34908 RVA: 0x001D1B30 File Offset: 0x001CFD30
	protected override void OnAfterDestroy()
	{
		MoonChasingBusinessModel.Instance.SetIsInDelegate(false);
	}

	// Token: 0x0600885D RID: 34909 RVA: 0x001D1B40 File Offset: 0x001CFD40
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

	// Token: 0x0600885E RID: 34910 RVA: 0x001D1B8C File Offset: 0x001CFD8C
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

	// Token: 0x0600885F RID: 34911 RVA: 0x001D1BD7 File Offset: 0x001CFDD7
	private void InitDialog()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.PopularityUpData.DialogName, Array.Empty<object>());
	}

	// Token: 0x06008860 RID: 34912 RVA: 0x001D1BFA File Offset: 0x001CFDFA
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

	// Token: 0x06008861 RID: 34913 RVA: 0x001D1C3A File Offset: 0x001CFE3A
	private void InitTitle()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.PopularityUpData.Title, Array.Empty<object>());
	}

	// Token: 0x06008862 RID: 34914 RVA: 0x001D1C60 File Offset: 0x001CFE60
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

	// Token: 0x06008863 RID: 34915 RVA: 0x001D1D4B File Offset: 0x001CFF4B
	private void StartTween(int startValue)
	{
		AudioSystem.Instance.PostEvent("play_ui_figure_up_2s");
		this.TweenTime = 2f / (float)this.PlayCount;
		this.PlayTween(startValue, 1);
	}

	// Token: 0x06008864 RID: 34916 RVA: 0x001D1D78 File Offset: 0x001CFF78
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

	// Token: 0x06008865 RID: 34917 RVA: 0x001D1E9C File Offset: 0x001D009C
	private void StopTween()
	{
		if (this.ExpTweener != null)
		{
			this.ExpTweener.Kill(false);
			this.ExpTweener = null;
		}
	}

	// Token: 0x06008866 RID: 34918 RVA: 0x001D1EBC File Offset: 0x001D00BC
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

	// Token: 0x06008867 RID: 34919 RVA: 0x001D1F00 File Offset: 0x001D0100
	private void PlayFillAmount(int value)
	{
		this.LastBar.SetFillAmount((float)value / (float)this.PopularityValue);
		this.CurrentText.SetText("<color=#ffd52b>" + value.ToString() + "</color>/" + this.PopularityValue.ToString(), true);
	}

	// Token: 0x06008868 RID: 34920 RVA: 0x001D1F4F File Offset: 0x001D014F
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

	// Token: 0x04003CC8 RID: 15560
	[Nullable(2)]
	protected ULTweener ExpTweener;

	// Token: 0x04003CC9 RID: 15561
	[Nullable(2)]
	protected FLTweenIntSetterDynamic Delegate;

	// Token: 0x04003CCA RID: 15562
	[Nullable(2)]
	private MoonChasingPopularityUpData PopularityUpData;

	// Token: 0x04003CCB RID: 15563
	protected int PopularityValue;

	// Token: 0x04003CCC RID: 15564
	private int PlayCount;

	// Token: 0x04003CCD RID: 15565
	private float TweenTime;

	// Token: 0x04003CCE RID: 15566
	private UUISprite CurrentBar;

	// Token: 0x04003CCF RID: 15567
	private UUIText CurrentText;

	// Token: 0x04003CD0 RID: 15568
	private UUISprite LastBar;

	// Token: 0x04003CD1 RID: 15569
	private const float TWEEN_TIME = 2f;

	// Token: 0x02007983 RID: 31107
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04028035 RID: 163893
		public const int Title = 0;

		// Token: 0x04028036 RID: 163894
		public const int Name = 1;

		// Token: 0x04028037 RID: 163895
		public const int Content = 2;

		// Token: 0x04028038 RID: 163896
		public const int ExpItem = 3;

		// Token: 0x04028039 RID: 163897
		public const int ConfirmBtn = 4;

		// Token: 0x0402803A RID: 163898
		public const int AddValue = 5;

		// Token: 0x0402803B RID: 163899
		public const int CurrentValue = 6;

		// Token: 0x0402803C RID: 163900
		public const int CurrentBar = 7;

		// Token: 0x0402803D RID: 163901
		public const int LastBar = 8;

		// Token: 0x0402803E RID: 163902
		public const int LevelUpItem = 9;

		// Token: 0x0402803F RID: 163903
		public const int NormalItem = 10;

		// Token: 0x04028040 RID: 163904
		public const int RoleSpine = 11;

		// Token: 0x04028041 RID: 163905
		public const int LanternItem = 12;

		// Token: 0x04028042 RID: 163906
		public const int BgTexture = 13;
	}
}
