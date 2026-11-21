using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007DE RID: 2014
[NullableContext(2)]
[Nullable(0)]
public class RewardItem : UiPanelBase
{
	// Token: 0x06005BCD RID: 23501 RVA: 0x001D9CA2 File Offset: 0x001D7EA2
	public RewardItem(int itemId)
	{
		this.ItemId = itemId;
	}

	// Token: 0x17000BC0 RID: 3008
	// (get) Token: 0x06005BCE RID: 23502 RVA: 0x001D9CB1 File Offset: 0x001D7EB1
	protected int ItemId { get; }

	// Token: 0x06005BCF RID: 23503 RVA: 0x001D9CBC File Offset: 0x001D7EBC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
	}

	// Token: 0x06005BD0 RID: 23504 RVA: 0x001D9D58 File Offset: 0x001D7F58
	protected override UniTask OnBeforeStartAsync()
	{
		RewardItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RewardItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005BD1 RID: 23505 RVA: 0x001D9D9C File Offset: 0x001D7F9C
	protected override void OnStart()
	{
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetUIActive(true);
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetUIActive(false);
		}
		UUIText text3 = base.GetText(3);
		if (text3 != null)
		{
			text3.SetUIActive(false);
		}
		this.ShowRatio(false);
		this.CurrentValueDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenIntSetterDynamic>(new Action<int>(this.PlayCurrentValueAmount));
	}

	// Token: 0x06005BD2 RID: 23506 RVA: 0x001D9E00 File Offset: 0x001D8000
	protected override void OnBeforeDestroy()
	{
		this.KillExpTweener();
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(this.PlayCurrentValueAmount));
		this.CurrentValueDelegate = null;
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.Clear();
	}

	// Token: 0x06005BD3 RID: 23507 RVA: 0x001D9E30 File Offset: 0x001D8030
	protected void KillExpTweener()
	{
		if (this.ExpTweener != null)
		{
			this.ExpTweener.Kill(false);
			this.ExpTweener = null;
		}
	}

	// Token: 0x06005BD4 RID: 23508 RVA: 0x001D9E4D File Offset: 0x001D804D
	private void ShowLastValue()
	{
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText(this.LastValue.ToString(), true);
		}
		UUIText text2 = base.GetText(3);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(this.CurrentValue.ToString(), true);
	}

	// Token: 0x06005BD5 RID: 23509 RVA: 0x001D9E8C File Offset: 0x001D808C
	public UniTask ShowAddValue()
	{
		RewardItem.<ShowAddValue>d__18 <ShowAddValue>d__;
		<ShowAddValue>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowAddValue>d__.<>4__this = this;
		<ShowAddValue>d__.<>1__state = -1;
		<ShowAddValue>d__.<>t__builder.Start<RewardItem.<ShowAddValue>d__18>(ref <ShowAddValue>d__);
		return <ShowAddValue>d__.<>t__builder.Task;
	}

	// Token: 0x06005BD6 RID: 23510 RVA: 0x001D9ED0 File Offset: 0x001D80D0
	private UniTask PlayAddAnimAndTween()
	{
		RewardItem.<PlayAddAnimAndTween>d__19 <PlayAddAnimAndTween>d__;
		<PlayAddAnimAndTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayAddAnimAndTween>d__.<>4__this = this;
		<PlayAddAnimAndTween>d__.<>1__state = -1;
		<PlayAddAnimAndTween>d__.<>t__builder.Start<RewardItem.<PlayAddAnimAndTween>d__19>(ref <PlayAddAnimAndTween>d__);
		return <PlayAddAnimAndTween>d__.<>t__builder.Task;
	}

	// Token: 0x06005BD7 RID: 23511 RVA: 0x001D9F14 File Offset: 0x001D8114
	private void ShowRatio(bool isNeedRatio)
	{
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(isNeedRatio);
		}
		if (isNeedRatio)
		{
			DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
			UUIText text = base.GetText(5);
			if (text == null)
			{
				return;
			}
			text.SetText(resultData.Ratio.ToString() + "%", true);
		}
	}

	// Token: 0x06005BD8 RID: 23512 RVA: 0x001D9F69 File Offset: 0x001D8169
	private void PlayCurrentValueAmount(int value)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(value.ToString(), true);
	}

	// Token: 0x06005BD9 RID: 23513 RVA: 0x001D9F84 File Offset: 0x001D8184
	private void PlaySecondTween()
	{
		this.KillExpTweener();
		AudioSystem.Instance.PostEvent("play_ui_figure_up_2");
		this.SequencePlayer.PlaySequenceAsync("Add", new CustomPromise<bool>(), false, false, null, false).ContinueWith(delegate()
		{
			if (base.IsDestroyOrDestroying)
			{
				return;
			}
			this.ExpTweener = ULTweenBPLibrary.IntTo(GlobalData.World, this.CurrentValueDelegate, this.BaseValue, this.CurrentValue, 1f, 0f, LTweenEase.OutCubic);
			this.ExpTweener.OnCompleteCallBack.Bind(new Action(this.FinishCurrentValueAmount));
		}).Forget();
	}

	// Token: 0x06005BDA RID: 23514 RVA: 0x001D9FE0 File Offset: 0x001D81E0
	private void FinishCurrentValueAmount()
	{
		this.KillExpTweener();
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetUIActive(true);
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetUIActive(false);
		}
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.PlayLevelSequenceByName("Addition02", false, null, false);
	}

	// Token: 0x06005BDB RID: 23515 RVA: 0x001DA039 File Offset: 0x001D8239
	public void UpdateItem(int addValue, int baseValue, bool isNeedRatio)
	{
		this.CurrentValue = addValue;
		this.BaseValue = baseValue;
		this.ShowLastValue();
		this.ShowRatio(isNeedRatio);
	}

	// Token: 0x04003D50 RID: 15696
	private readonly int LastValue;

	// Token: 0x04003D51 RID: 15697
	private int BaseValue;

	// Token: 0x04003D52 RID: 15698
	private int CurrentValue;

	// Token: 0x04003D53 RID: 15699
	protected FLTweenIntSetterDynamic CurrentValueDelegate;

	// Token: 0x04003D54 RID: 15700
	protected ULTweener ExpTweener;

	// Token: 0x04003D55 RID: 15701
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04003D56 RID: 15702
	private const int TWEEN_TIME = 1;

	// Token: 0x02006B05 RID: 27397
	[NullableContext(0)]
	private static class ERewardItem
	{
		// Token: 0x04023338 RID: 144184
		public const int Icon = 0;

		// Token: 0x04023339 RID: 144185
		public const int LastValue = 1;

		// Token: 0x0402333A RID: 144186
		public const int ChangeValue = 2;

		// Token: 0x0402333B RID: 144187
		public const int CurrentValue = 3;

		// Token: 0x0402333C RID: 144188
		public const int RatioItem = 4;

		// Token: 0x0402333D RID: 144189
		public const int Ratio = 5;
	}
}
