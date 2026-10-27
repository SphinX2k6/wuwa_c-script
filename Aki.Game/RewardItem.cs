using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200132A RID: 4906
[NullableContext(2)]
[Nullable(0)]
public class RewardItem : UiPanelBase
{
	// Token: 0x06008832 RID: 34866 RVA: 0x001D0E36 File Offset: 0x001CF036
	public RewardItem(int itemId)
	{
		this.ItemId = itemId;
	}

	// Token: 0x17000BA0 RID: 2976
	// (get) Token: 0x06008833 RID: 34867 RVA: 0x001D0E45 File Offset: 0x001CF045
	protected int ItemId { get; }

	// Token: 0x06008834 RID: 34868 RVA: 0x001D0E50 File Offset: 0x001CF050
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

	// Token: 0x06008835 RID: 34869 RVA: 0x001D0EEC File Offset: 0x001CF0EC
	protected override UniTask OnBeforeStartAsync()
	{
		RewardItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RewardItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008836 RID: 34870 RVA: 0x001D0F30 File Offset: 0x001CF130
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

	// Token: 0x06008837 RID: 34871 RVA: 0x001D0F94 File Offset: 0x001CF194
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

	// Token: 0x06008838 RID: 34872 RVA: 0x001D0FC4 File Offset: 0x001CF1C4
	protected void KillExpTweener()
	{
		if (this.ExpTweener != null)
		{
			this.ExpTweener.Kill(false);
			this.ExpTweener = null;
		}
	}

	// Token: 0x06008839 RID: 34873 RVA: 0x001D0FE1 File Offset: 0x001CF1E1
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

	// Token: 0x0600883A RID: 34874 RVA: 0x001D1020 File Offset: 0x001CF220
	public UniTask ShowAddValue()
	{
		RewardItem.<ShowAddValue>d__18 <ShowAddValue>d__;
		<ShowAddValue>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowAddValue>d__.<>4__this = this;
		<ShowAddValue>d__.<>1__state = -1;
		<ShowAddValue>d__.<>t__builder.Start<RewardItem.<ShowAddValue>d__18>(ref <ShowAddValue>d__);
		return <ShowAddValue>d__.<>t__builder.Task;
	}

	// Token: 0x0600883B RID: 34875 RVA: 0x001D1064 File Offset: 0x001CF264
	private UniTask PlayAddAnimAndTween()
	{
		RewardItem.<PlayAddAnimAndTween>d__19 <PlayAddAnimAndTween>d__;
		<PlayAddAnimAndTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayAddAnimAndTween>d__.<>4__this = this;
		<PlayAddAnimAndTween>d__.<>1__state = -1;
		<PlayAddAnimAndTween>d__.<>t__builder.Start<RewardItem.<PlayAddAnimAndTween>d__19>(ref <PlayAddAnimAndTween>d__);
		return <PlayAddAnimAndTween>d__.<>t__builder.Task;
	}

	// Token: 0x0600883C RID: 34876 RVA: 0x001D10A8 File Offset: 0x001CF2A8
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

	// Token: 0x0600883D RID: 34877 RVA: 0x001D10FD File Offset: 0x001CF2FD
	private void PlayCurrentValueAmount(int value)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(value.ToString(), true);
	}

	// Token: 0x0600883E RID: 34878 RVA: 0x001D1118 File Offset: 0x001CF318
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

	// Token: 0x0600883F RID: 34879 RVA: 0x001D1174 File Offset: 0x001CF374
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

	// Token: 0x06008840 RID: 34880 RVA: 0x001D11CD File Offset: 0x001CF3CD
	public void UpdateItem(int addValue, int baseValue, bool isNeedRatio)
	{
		this.CurrentValue = addValue;
		this.BaseValue = baseValue;
		this.ShowLastValue();
		this.ShowRatio(isNeedRatio);
	}

	// Token: 0x04003CB8 RID: 15544
	private readonly int LastValue;

	// Token: 0x04003CB9 RID: 15545
	private int BaseValue;

	// Token: 0x04003CBA RID: 15546
	private int CurrentValue;

	// Token: 0x04003CBB RID: 15547
	protected FLTweenIntSetterDynamic CurrentValueDelegate;

	// Token: 0x04003CBC RID: 15548
	protected ULTweener ExpTweener;

	// Token: 0x04003CBD RID: 15549
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04003CBE RID: 15550
	private const int TWEEN_TIME = 1;

	// Token: 0x0200797B RID: 31099
	[NullableContext(0)]
	private static class ERewardItem
	{
		// Token: 0x0402800B RID: 163851
		public const int Icon = 0;

		// Token: 0x0402800C RID: 163852
		public const int LastValue = 1;

		// Token: 0x0402800D RID: 163853
		public const int ChangeValue = 2;

		// Token: 0x0402800E RID: 163854
		public const int CurrentValue = 3;

		// Token: 0x0402800F RID: 163855
		public const int RatioItem = 4;

		// Token: 0x04028010 RID: 163856
		public const int Ratio = 5;
	}
}
