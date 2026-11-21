using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000AD8 RID: 2776
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerModeSelectView : UiTickViewBase
{
	// Token: 0x06007336 RID: 29494 RVA: 0x00238E6F File Offset: 0x0023706F
	[NullableContext(1)]
	public WheelTowerModeSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007337 RID: 29495 RVA: 0x00238E78 File Offset: 0x00237078
	protected unsafe override void OnRegisterComponent()
	{
		int num = 26;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnRewardClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnBattleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007338 RID: 29496 RVA: 0x00239270 File Offset: 0x00237470
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerModeSelectView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerModeSelectView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007339 RID: 29497 RVA: 0x002392B4 File Offset: 0x002374B4
	protected override void OnStart()
	{
		PopupCaptionItem caption = this.Caption;
		if (caption != null)
		{
			caption.SetCloseCallBack(new Action(this.OnCloseClick));
		}
		WheelTowerModeSelectView.ModeToggleItem normalToggleItem = this.NormalToggleItem;
		if (normalToggleItem != null)
		{
			normalToggleItem.SetToggleClickCallback(delegate
			{
				this.SetEndlessMode(false);
				this.RefreshView(false);
			});
		}
		WheelTowerModeSelectView.ModeToggleItem endlessToggleItem = this.EndlessToggleItem;
		if (endlessToggleItem != null)
		{
			endlessToggleItem.SetToggleClickCallback(delegate
			{
				this.SetEndlessMode(true);
				this.RefreshView(false);
			});
		}
		this.ScoreItem = new WheelTowerScoreItem(this, base.GetItem(10));
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		this.InitBgActive();
		this.SelectDefaultMode();
		this.AddHomeBtnExtraCallback();
	}

	// Token: 0x0600733A RID: 29498 RVA: 0x0023934F File Offset: 0x0023754F
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.Clear();
	}

	// Token: 0x0600733B RID: 29499 RVA: 0x00239364 File Offset: 0x00237564
	protected override void OnTick(float delta)
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(WheelTowerModel.Instance.ActivityData, null);
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		UUIText text = base.GetText(16);
		if (text != null)
		{
			text.SetUIActive(item);
		}
		if (item && text != null)
		{
			text.SetText(item2, true);
		}
	}

	// Token: 0x0600733C RID: 29500 RVA: 0x002393B4 File Offset: 0x002375B4
	protected override void OnBeforeShow()
	{
		this.OnTick(0f);
		this.OnRedDotRefresh(0);
	}

	// Token: 0x0600733D RID: 29501 RVA: 0x002393C8 File Offset: 0x002375C8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
	}

	// Token: 0x0600733E RID: 29502 RVA: 0x002393E6 File Offset: 0x002375E6
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
	}

	// Token: 0x0600733F RID: 29503 RVA: 0x00239404 File Offset: 0x00237604
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		WheelTowerModeSelectView.<OnBeforeShowAsyncImplementImplement>d__16 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<WheelTowerModeSelectView.<OnBeforeShowAsyncImplementImplement>d__16>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06007340 RID: 29504 RVA: 0x00239448 File Offset: 0x00237648
	private void SelectDefaultMode()
	{
		WheelTowerModel instance = WheelTowerModel.Instance;
		this.RefreshToggle();
		bool flag = instance.EndlessMode;
		if (!instance.ActivityData.IsLevelUnlocked(flag))
		{
			flag = false;
		}
		this.SetEndlessMode(flag);
		WheelTowerModeSelectView.ModeToggleItem normalToggleItem = this.NormalToggleItem;
		if (normalToggleItem != null)
		{
			normalToggleItem.SetToggleStateForce(!flag);
		}
		WheelTowerModeSelectView.ModeToggleItem endlessToggleItem = this.EndlessToggleItem;
		if (endlessToggleItem == null)
		{
			return;
		}
		endlessToggleItem.SetToggleStateForce(flag);
	}

	// Token: 0x06007341 RID: 29505 RVA: 0x002394A3 File Offset: 0x002376A3
	private void SetEndlessMode(bool endless)
	{
		WheelTowerModel.Instance.SetEndlessMode(endless);
	}

	// Token: 0x06007342 RID: 29506 RVA: 0x002394B0 File Offset: 0x002376B0
	private void InitBgActive()
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(true);
		}
		UUIItem item3 = base.GetItem(23);
		if (item3 != null)
		{
			item3.SetUIActive(true);
		}
		UUIItem item4 = base.GetItem(24);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(true);
	}

	// Token: 0x06007343 RID: 29507 RVA: 0x0023950C File Offset: 0x0023770C
	private void RefreshView(bool skipSwitchAnim = false)
	{
		bool endlessMode = WheelTowerModel.Instance.EndlessMode;
		string sequenceName = endlessMode ? "SwitchB_W" : "SwitchW_B";
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.PlayOrReplaySequenceByName(sequenceName, false, null);
		}
		if (skipSwitchAnim)
		{
			LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
			if (seqPlayer2 != null)
			{
				seqPlayer2.EndSequenceLastFrame(sequenceName);
			}
		}
		this.RefreshToggle();
		WheelTowerModeSelectView.ModeToggleItem normalToggleItem = this.NormalToggleItem;
		if (normalToggleItem != null)
		{
			normalToggleItem.SetToggleStateForce(!endlessMode);
		}
		WheelTowerModeSelectView.ModeToggleItem endlessToggleItem = this.EndlessToggleItem;
		if (endlessToggleItem != null)
		{
			endlessToggleItem.SetToggleStateForce(endlessMode);
		}
		WheelTowerModel instance = WheelTowerModel.Instance;
		int num = instance.GetMaxChallengeRound(null) + 1;
		UUIText text = base.GetText(9);
		if (text != null)
		{
			text.SetText(num.ToString(), true);
		}
		int totalScore = instance.GetTotalScore();
		UUIText text2 = base.GetText(11);
		if (text2 != null)
		{
			text2.SetText(totalScore.ToString(), true);
		}
		EScoreLevel totalScoreLevel = instance.GetTotalScoreLevel(totalScore, null, null);
		WheelTowerScoreItem scoreItem = this.ScoreItem;
		if (scoreItem != null)
		{
			scoreItem.Refresh(totalScoreLevel);
		}
		MonsterInfoPreview nextMonsterInfoPreview = instance.GetCurrentLevelRecord(null).NextMonsterInfoPreview;
		if (nextMonsterInfoPreview != null)
		{
			NewTowerWave? waveConfigById = WheelTowerConfig.Instance.GetWaveConfigById(nextMonsterInfoPreview.WaveConfigId);
			if (waveConfigById != null)
			{
				base.SetTextureShowUntilLoaded(waveConfigById.Value.SmallIcon, base.GetTexture(6), null);
			}
		}
		int currentRewardProgress = instance.ActivityData.GetCurrentRewardProgress(EFilterMode.All);
		int totalRewardProgress = instance.ActivityData.GetTotalRewardProgress(EFilterMode.All);
		UUIText text3 = base.GetText(13);
		if (text3 != null)
		{
			text3.SetText(currentRewardProgress.ToString(), true);
		}
		UUIText text4 = base.GetText(14);
		if (text4 == null)
		{
			return;
		}
		text4.SetText(totalRewardProgress.ToString(), true);
	}

	// Token: 0x06007344 RID: 29508 RVA: 0x002396BD File Offset: 0x002378BD
	private void RefreshToggle()
	{
		WheelTowerModeSelectView.ModeToggleItem normalToggleItem = this.NormalToggleItem;
		if (normalToggleItem != null)
		{
			normalToggleItem.Refresh(false);
		}
		WheelTowerModeSelectView.ModeToggleItem endlessToggleItem = this.EndlessToggleItem;
		if (endlessToggleItem == null)
		{
			return;
		}
		endlessToggleItem.Refresh(true);
	}

	// Token: 0x06007345 RID: 29509 RVA: 0x002396E4 File Offset: 0x002378E4
	private UniTask RefreshBossBgImage()
	{
		WheelTowerModeSelectView.<RefreshBossBgImage>d__22 <RefreshBossBgImage>d__;
		<RefreshBossBgImage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshBossBgImage>d__.<>4__this = this;
		<RefreshBossBgImage>d__.<>1__state = -1;
		<RefreshBossBgImage>d__.<>t__builder.Start<WheelTowerModeSelectView.<RefreshBossBgImage>d__22>(ref <RefreshBossBgImage>d__);
		return <RefreshBossBgImage>d__.<>t__builder.Task;
	}

	// Token: 0x06007346 RID: 29510 RVA: 0x00239727 File Offset: 0x00237927
	private void OnRewardClick()
	{
		UiManager.Instance.OpenView(EUiViewName.WheelTowerRewardView, null, delegate(bool success, int viewId)
		{
			if (success)
			{
				base.AddChildViewById(viewId);
			}
		});
	}

	// Token: 0x06007347 RID: 29511 RVA: 0x00239745 File Offset: 0x00237945
	private void OnBattleClick()
	{
		UiManager.Instance.OpenView(EUiViewName.WheelTowerRoundSelectView, null, null);
	}

	// Token: 0x06007348 RID: 29512 RVA: 0x00239758 File Offset: 0x00237958
	private void OnCloseClick()
	{
		if (GameModeController.Instance.IsInInstance())
		{
			InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(null, null, true);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06007349 RID: 29513 RVA: 0x0023977B File Offset: 0x0023797B
	private void AddHomeBtnExtraCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			WheelTowerModeSelectView.<>c.<<AddHomeBtnExtraCallback>b__26_0>d <<AddHomeBtnExtraCallback>b__26_0>d;
			<<AddHomeBtnExtraCallback>b__26_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExtraCallback>b__26_0>d.<>1__state = -1;
			<<AddHomeBtnExtraCallback>b__26_0>d.<>t__builder.Start<WheelTowerModeSelectView.<>c.<<AddHomeBtnExtraCallback>b__26_0>d>(ref <<AddHomeBtnExtraCallback>b__26_0>d);
			return <<AddHomeBtnExtraCallback>b__26_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x0600734A RID: 29514 RVA: 0x002397AC File Offset: 0x002379AC
	private void OnRedDotRefresh(int _)
	{
		this.RefreshView(true);
		UUIItem item = base.GetItem(25);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(WheelTowerModel.Instance.ActivityData.ShouldShowRewardRedDot());
	}

	// Token: 0x040048A4 RID: 18596
	[Nullable(1)]
	private const string IconPlay = "/Game/Aki/UI/UIResources/UiActivity/Atlas/ActivityMowingTower/MowingTower30/Main/SP_IconPlay.SP_IconPlay";

	// Token: 0x040048A5 RID: 18597
	[Nullable(1)]
	private const string IconLock = "/Game/Aki/UI/UIResources/UiActivity/Atlas/ActivityMowingTower/MowingTower30/Main/SP_IconLock.SP_IconLock";

	// Token: 0x040048A6 RID: 18598
	private PopupCaptionItem Caption;

	// Token: 0x040048A7 RID: 18599
	private WheelTowerModeSelectView.ModeToggleItem NormalToggleItem;

	// Token: 0x040048A8 RID: 18600
	private WheelTowerModeSelectView.ModeToggleItem EndlessToggleItem;

	// Token: 0x040048A9 RID: 18601
	private WheelTowerScoreItem ScoreItem;

	// Token: 0x040048AA RID: 18602
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x02006D6F RID: 28015
	[NullableContext(1)]
	[Nullable(0)]
	private class ModeToggleItem : UiPanelBase
	{
		// Token: 0x0603FBF2 RID: 261106 RVA: 0x012A7FDE File Offset: 0x012A61DE
		public ModeToggleItem(string iconPlay, string iconLock)
		{
			this.IconPlay = iconPlay;
			this.IconLock = iconLock;
		}

		// Token: 0x0603FBF3 RID: 261107 RVA: 0x012A7FF4 File Offset: 0x012A61F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggleSpriteTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FBF4 RID: 261108 RVA: 0x012A8100 File Offset: 0x012A6300
		protected override void OnStart()
		{
			UUIExtendToggle toggle = base.GetExtendToggle(0);
			toggle.CanExecuteChange.Bind(() => toggle.ToggleState != EToggleState.ETT_Checked);
			this.SetToggleStateForce(false);
		}

		// Token: 0x0603FBF5 RID: 261109 RVA: 0x012A8144 File Offset: 0x012A6344
		public void Refresh(bool endless)
		{
			WheelTowerModel instance = WheelTowerModel.Instance;
			bool flag = instance.ActivityData.IsLevelUnlocked(endless);
			bool flag2 = instance.IsLevelCompleted(endless);
			base.SetExtendToggleSpriteTransitionByPath(flag ? this.IconPlay : this.IconLock, base.GetUiExtendToggleSpriteTransition(1), null).Forget();
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetSelfInteractive(flag);
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(flag2);
			}
			UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(1);
			if (uiExtendToggleSpriteTransition != null)
			{
				uiExtendToggleSpriteTransition.RootUIComp.Get().SetUIActive(!flag2);
			}
			if (endless)
			{
				UUIText text = base.GetText(2);
				if (text != null)
				{
					text.ShowTextNew(flag ? "PrefabTextItem_2898489298_Text" : "WheelTower_EndlessCondition");
				}
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(instance.ActivityData.HasLevelRedDot(endless));
		}

		// Token: 0x0603FBF6 RID: 261110 RVA: 0x012A8223 File Offset: 0x012A6423
		public void SetToggleClickCallback(Action callback)
		{
			this.ToggleClickCallback = callback;
		}

		// Token: 0x0603FBF7 RID: 261111 RVA: 0x012A822C File Offset: 0x012A642C
		public void SetToggleStateForce(bool isSelect)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603FBF8 RID: 261112 RVA: 0x012A8249 File Offset: 0x012A6449
		private void OnToggleClick(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				Action toggleClickCallback = this.ToggleClickCallback;
				if (toggleClickCallback == null)
				{
					return;
				}
				toggleClickCallback();
			}
		}

		// Token: 0x04023E74 RID: 147060
		private readonly string IconPlay;

		// Token: 0x04023E75 RID: 147061
		private readonly string IconLock;

		// Token: 0x04023E76 RID: 147062
		[Nullable(2)]
		private Action ToggleClickCallback;
	}
}
