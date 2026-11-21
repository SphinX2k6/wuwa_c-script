using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.MovieMode;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D7E RID: 19838
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleControlTopPanel : BattleVisibleChildView
	{
		// Token: 0x06031C97 RID: 203927 RVA: 0x00DEC0E8 File Offset: 0x00DEA2E8
		public UniTask Init(UUIItem parentItem, string resourceId)
		{
			MotorcycleControlTopPanel.<Init>d__22 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.parentItem = parentItem;
			<Init>d__.resourceId = resourceId;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MotorcycleControlTopPanel.<Init>d__22>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06031C98 RID: 203928 RVA: 0x00DEC13C File Offset: 0x00DEA33C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
			this.IsInTouch = Info.Instance.IsInTouch();
			if (!this.IsInTouch)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(11, typeof(UUIItem)));
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(12, typeof(UUIItem)));
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(13, typeof(UUIItem)));
			}
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickMusicTitleButton));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickMusicBtnPrev));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickMusicBtnNext));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031C99 RID: 203929 RVA: 0x00DEC3C0 File Offset: 0x00DEA5C0
		protected override UniTask OnBeforeStartAsync()
		{
			MotorcycleControlTopPanel.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleControlTopPanel.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031C9A RID: 203930 RVA: 0x00DEC404 File Offset: 0x00DEA604
		private UniTask InitKeyItem(UUIItem item)
		{
			MotorcycleControlTopPanel.<InitKeyItem>d__25 <InitKeyItem>d__;
			<InitKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitKeyItem>d__.<>4__this = this;
			<InitKeyItem>d__.item = item;
			<InitKeyItem>d__.<>1__state = -1;
			<InitKeyItem>d__.<>t__builder.Start<MotorcycleControlTopPanel.<InitKeyItem>d__25>(ref <InitKeyItem>d__);
			return <InitKeyItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031C9B RID: 203931 RVA: 0x00DEC450 File Offset: 0x00DEA650
		protected override void OnStart()
		{
			this.TweenAnimPlayer.InitTweenAnim(8, base.GetItem(8), false);
			this.TweenAnimPlayer.InitTweenAnim(9, base.GetItem(9), false);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.MusicTitleText = base.GetText(2);
			this.MusicTitleViewWidth = base.GetItem(1).GetWidth();
			this.MusicTitleScrollSpeed = ConfigCommonParamById.GetFloatConfig("MusicTitleScrollSpeed").Value;
			this.MusicTitleScrollBeginTime = ConfigCommonParamById.GetFloatConfig("MusicTitleScrollBeginTime").Value;
			this.MusicTitleScrollEndTime = ConfigCommonParamById.GetFloatConfig("MusicTitleScrollEndTime").Value;
			this.RefreshMusicTitle();
			this.RefreshMusicPlayState();
			this.RefreshMusicVisible();
			this.RefreshBossStateAreaVisible();
			this.RefreshKeyNodeVisible();
			this.RefreshKeyItems();
			this.SetColorState(BattleUiModel.Instance.MotorcycleData.HudColorState);
			if (this.IsInTouch)
			{
				this.ApplyTouchUiEditData();
			}
			this.AddEvents();
		}

		// Token: 0x06031C9C RID: 203932 RVA: 0x00DEC54C File Offset: 0x00DEA74C
		public void OnShowBattleChildViewPanel()
		{
			this.MusicPlayStateDirty = true;
			this.RefreshMusicTitle();
		}

		// Token: 0x06031C9D RID: 203933 RVA: 0x00DEC55B File Offset: 0x00DEA75B
		public void OnHideBattleChildViewPanel()
		{
		}

		// Token: 0x06031C9E RID: 203934 RVA: 0x00DEC55D File Offset: 0x00DEA75D
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			BattleUiModel.Instance.UpdateBossStateArea(EBossStateAreaType.MotorcycleControlTop, true);
		}

		// Token: 0x06031C9F RID: 203935 RVA: 0x00DEC574 File Offset: 0x00DEA774
		protected override void OnAfterShow()
		{
			string sequenceName = AutoPilotModel.Instance.GetIsInMovieMode() ? "MovieIn" : "Start";
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
			}
			EventSystem.Instance.Emit(EEventName.OnMotorMusicPlayerShow);
			this.ResetAlpha();
		}

		// Token: 0x06031CA0 RID: 203936 RVA: 0x00DEC5D0 File Offset: 0x00DEA7D0
		protected override UniTask OnBeforeHideAsync()
		{
			MotorcycleControlTopPanel.<OnBeforeHideAsync>d__32 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<MotorcycleControlTopPanel.<OnBeforeHideAsync>d__32>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031CA1 RID: 203937 RVA: 0x00DEC613 File Offset: 0x00DEA813
		protected override void OnAutoDestroy()
		{
			base.OnAutoDestroy();
			if (this.StopPromise != null)
			{
				this.StopPromise.SetResult(true);
				this.StopPromise = null;
			}
		}

		// Token: 0x06031CA2 RID: 203938 RVA: 0x00DEC636 File Offset: 0x00DEA836
		protected override void OnBeforeDestroy()
		{
			this.TweenAnimPlayer.Clear(false);
			if (this.LevelSequencePlayer != null)
			{
				this.LevelSequencePlayer.Clear();
				this.LevelSequencePlayer = null;
			}
			this.RemoveEvents();
		}

		// Token: 0x06031CA3 RID: 203939 RVA: 0x00DEC664 File Offset: 0x00DEA864
		private void AddEvents()
		{
			base.GetExtendToggle(4).OnStateChange.Add(new Action<EToggleState>(this.OnMusicTogPlayStateChanged));
			EventSystem.Instance.Add<EBossStateAreaType, EBossStateAreaType>(EEventName.BattleUiBossStateAreaChanged, new Action<EBossStateAreaType, EBossStateAreaType>(this.OnBattleUiBossStateAreaChanged));
			EventSystem.Instance.Add(EEventName.OnMotorSwitchMusic, new Action(this.OnMotorSwitchMusic));
			EventSystem.Instance.Add(EEventName.OnMotorMusicEnableStateChanged, new Action<bool>(this.OnMotorMusicEnableStateChanged));
			if (!this.IsInTouch)
			{
				EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
				EventSystem.Instance.Add<bool>(EEventName.BattleUiPressMotorcycleCombineButtonChanged, new Action<bool>(this.OnInputCombineButton));
				InputDistributeController.Instance.BindActions(MotorcycleControlTopPanel.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
			else
			{
				EventSystem.Instance.Add<ECommonTouchUiEditGroup>(EEventName.OnTouchUiEditSave, new Action<ECommonTouchUiEditGroup>(this.OnTouchUiEditSave));
			}
			EventSystem.Instance.Add<EMotorcycleHudColorState>(EEventName.BattleUiMotorcycleHudColorStateChanged, new Action<EMotorcycleHudColorState>(this.OnHudColorStateChanged));
		}

		// Token: 0x06031CA4 RID: 203940 RVA: 0x00DEC778 File Offset: 0x00DEA978
		private void RemoveEvents()
		{
			base.GetExtendToggle(4).OnStateChange.Remove(new Action<EToggleState>(this.OnMusicTogPlayStateChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiBossStateAreaChanged, new Action<EBossStateAreaType, EBossStateAreaType>(this.OnBattleUiBossStateAreaChanged));
			EventSystem.Instance.Remove(EEventName.OnMotorSwitchMusic, new Action(this.OnMotorSwitchMusic));
			EventSystem.Instance.Remove(EEventName.OnMotorMusicEnableStateChanged, new Action<bool>(this.OnMotorMusicEnableStateChanged));
			if (!this.IsInTouch)
			{
				EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
				EventSystem.Instance.Remove(EEventName.BattleUiPressMotorcycleCombineButtonChanged, new Action<bool>(this.OnInputCombineButton));
				InputDistributeController.Instance.UnBindActions(MotorcycleControlTopPanel.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
			else
			{
				EventSystem.Instance.Remove(EEventName.OnTouchUiEditSave, new Action<ECommonTouchUiEditGroup>(this.OnTouchUiEditSave));
			}
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleHudColorStateChanged, new Action<EMotorcycleHudColorState>(this.OnHudColorStateChanged));
		}

		// Token: 0x06031CA5 RID: 203941 RVA: 0x00DEC88B File Offset: 0x00DEAA8B
		private void OnClickMusicTitleButton()
		{
			this.ResetAlpha();
			MotorcycleMusicPlayerController.Instance.OpenMusicPlayerView();
		}

		// Token: 0x06031CA6 RID: 203942 RVA: 0x00DEC89D File Offset: 0x00DEAA9D
		private void OnClickMusicBtnPrev()
		{
			this.ResetAlpha();
			MotorcycleMusicPlayerController.Instance.QuickPlayMusic(false);
		}

		// Token: 0x06031CA7 RID: 203943 RVA: 0x00DEC8B0 File Offset: 0x00DEAAB0
		private void OnClickMusicBtnNext()
		{
			this.ResetAlpha();
			MotorcycleMusicPlayerController.Instance.QuickPlayMusic(true);
		}

		// Token: 0x06031CA8 RID: 203944 RVA: 0x00DEC8C4 File Offset: 0x00DEAAC4
		private void OnMusicTogPlayStateChanged(EToggleState state)
		{
			this.ResetAlpha();
			if (!MotorcycleMusicPlayerController.Instance.CheckIsEnable(false))
			{
				this.RefreshMusicPlayState();
				return;
			}
			bool flag = state == EToggleState.ETT_Checked;
			if (MotorcycleMusicPlayerModel.Instance.GetCurPlayMusicId() > 0)
			{
				if (!MotorcycleMusicPlayerModel.Instance.GetIsPause() != flag)
				{
					if (flag)
					{
						MotorcycleMusicPlayerController.Instance.ResumeMusic();
					}
					else
					{
						MotorcycleMusicPlayerController.Instance.PauseMusic();
					}
				}
			}
			else
			{
				MotorcycleMusicPlayerController.Instance.QuickPlayMusic(true);
			}
			this.RefreshMusicPlayEffect(flag);
		}

		// Token: 0x06031CA9 RID: 203945 RVA: 0x00DEC93A File Offset: 0x00DEAB3A
		private void OnBattleUiBossStateAreaChanged(EBossStateAreaType lastType, EBossStateAreaType curType)
		{
			this.RefreshBossStateAreaVisible();
		}

		// Token: 0x06031CAA RID: 203946 RVA: 0x00DEC942 File Offset: 0x00DEAB42
		private void OnMotorMusicEnableStateChanged(bool isEnable)
		{
			this.RefreshMusicPlayState();
			this.RefreshMusicVisible();
		}

		// Token: 0x06031CAB RID: 203947 RVA: 0x00DEC950 File Offset: 0x00DEAB50
		private void RefreshMusicVisible()
		{
			base.SetVisible(2, MotorcycleMusicPlayerModel.Instance.IsEnable);
		}

		// Token: 0x06031CAC RID: 203948 RVA: 0x00DEC963 File Offset: 0x00DEAB63
		private void OnMotorSwitchMusic()
		{
			this.RefreshMusicTitle();
			this.RefreshMusicPlayState();
		}

		// Token: 0x06031CAD RID: 203949 RVA: 0x00DEC971 File Offset: 0x00DEAB71
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshKeyNodeVisible();
		}

		// Token: 0x06031CAE RID: 203950 RVA: 0x00DEC979 File Offset: 0x00DEAB79
		private void OnInputCombineButton(bool isPress)
		{
			this.RefreshKeyNodeVisible();
		}

		// Token: 0x06031CAF RID: 203951 RVA: 0x00DEC984 File Offset: 0x00DEAB84
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (!BattleUiModel.Instance.MotorcycleData.IsDriving)
			{
				return;
			}
			if (!MotorcycleMusicPlayerController.Instance.CheckIsEnable(false))
			{
				return;
			}
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			if (actionName == "载具音乐上一首")
			{
				this.OnClickMusicBtnPrev();
				return;
			}
			if (actionName == "载具音乐下一首")
			{
				this.OnClickMusicBtnNext();
				return;
			}
			if (actionName == "载具音乐播放暂停")
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(4);
				if (extendToggle.GetToggleState() == EToggleState.ETT_Checked)
				{
					extendToggle.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
					return;
				}
				extendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
			}
		}

		// Token: 0x06031CB0 RID: 203952 RVA: 0x00DECA14 File Offset: 0x00DEAC14
		private void RefreshKeyNodeVisible()
		{
			if (Info.Instance.IsInGamepad())
			{
				SkillButtonUiGamepadDataBase gamepadDataByType = SkillButtonUiModel.Instance.GetGamepadDataByType(ESkillButtonGamepadDataType.Motorcycle);
				bool uiactive = gamepadDataByType != null && gamepadDataByType.GetIsPressCombineButton();
				base.GetItem(6).SetUIActive(uiactive);
				return;
			}
			base.GetItem(6).SetUIActive(false);
		}

		// Token: 0x06031CB1 RID: 203953 RVA: 0x00DECA60 File Offset: 0x00DEAC60
		private void RefreshMusicTitle()
		{
			int curPlayMusicId = MotorcycleMusicPlayerModel.Instance.GetCurPlayMusicId();
			if (curPlayMusicId > 0)
			{
				PhonographMusic? phonographMusic;
				string key = ((PhonographConfig.Instance.GetMusicById(curPlayMusicId) != null) ? phonographMusic.GetValueOrDefault().Title : null) ?? string.Empty;
				UUIText musicTitleText = this.MusicTitleText;
				if (musicTitleText != null)
				{
					musicTitleText.ShowTextNew(key);
				}
			}
			else
			{
				UUIText musicTitleText2 = this.MusicTitleText;
				if (musicTitleText2 != null)
				{
					musicTitleText2.SetText(string.Empty, true);
				}
			}
			this.ResetMusicTitleScroll();
		}

		// Token: 0x06031CB2 RID: 203954 RVA: 0x00DECAE0 File Offset: 0x00DEACE0
		private void RefreshMusicPlayState()
		{
			bool flag = false;
			if (MotorcycleMusicPlayerModel.Instance.GetCurPlayMusicId() > 0)
			{
				flag = (!MotorcycleMusicPlayerModel.Instance.GetIsPause() && MotorcycleMusicPlayerModel.Instance.IsEnable);
			}
			base.GetExtendToggle(4).SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			this.RefreshMusicPlayEffect(flag);
			this.MusicPlayStateDirty = false;
		}

		// Token: 0x06031CB3 RID: 203955 RVA: 0x00DECB3C File Offset: 0x00DEAD3C
		private void RefreshMusicPlayEffect(bool bPlaying)
		{
			if (this.MusicEffectPlaying == bPlaying)
			{
				return;
			}
			this.MusicEffectPlaying = bPlaying;
			base.GetUiNiagara(10).SetUIActive(bPlaying);
			if (bPlaying)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer == null)
				{
					return;
				}
				levelSequencePlayer.PlaySequencePurely("Loop", false, false, null, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 == null)
				{
					return;
				}
				levelSequencePlayer2.StopSequenceByKey("Loop", false, false);
				return;
			}
		}

		// Token: 0x06031CB4 RID: 203956 RVA: 0x00DECBA5 File Offset: 0x00DEADA5
		private void ResetMusicTitleScroll()
		{
			this.MusicTitleScrollState = MotorcycleControlTopPanel.EScrollState.Begin;
			UUIText musicTitleText = this.MusicTitleText;
			if (musicTitleText == null)
			{
				return;
			}
			musicTitleText.SetAnchorOffsetX(0f);
		}

		// Token: 0x06031CB5 RID: 203957 RVA: 0x00DECBC4 File Offset: 0x00DEADC4
		private void RefreshBossStateAreaVisible()
		{
			bool bVisible = BattleUiModel.Instance.GetBossStateAreaType() >= EBossStateAreaType.MotorcycleControlTop;
			base.SetVisible(1, bVisible);
		}

		// Token: 0x06031CB6 RID: 203958 RVA: 0x00DECBEC File Offset: 0x00DEADEC
		private void RefreshKeyItems()
		{
			if (this.IsInTouch)
			{
				return;
			}
			for (int i = 0; i < this.KeyItemList.Count; i++)
			{
				InputMultiKeyItem inputMultiKeyItem = this.KeyItemList[i];
				string actionOrAxisName = MotorcycleControlTopPanel.ActionNameList[i];
				InputActionOrAxisKeyItem actionOrAxisKeyItem = new InputActionOrAxisKeyItem
				{
					ActionOrAxisName = actionOrAxisName
				};
				inputMultiKeyItem.RefreshByActionOrAxis(actionOrAxisKeyItem, true);
			}
		}

		// Token: 0x06031CB7 RID: 203959 RVA: 0x00DECC40 File Offset: 0x00DEAE40
		public void Tick(float delta)
		{
			if (!base.IsShowOrShowing)
			{
				return;
			}
			if (this.MusicPlayStateDirty)
			{
				this.RefreshMusicPlayState();
			}
			switch (this.MusicTitleScrollState)
			{
			case MotorcycleControlTopPanel.EScrollState.Begin:
				this.MusicTitleScrollTime -= delta;
				if (this.MusicTitleScrollTime <= 0f)
				{
					this.MusicTitleScrollTime = this.MusicTitleScrollEndTime;
					this.MusicTitleTextWidth = this.MusicTitleText.GetWidth();
					if (this.MusicTitleTextWidth > this.MusicTitleViewWidth)
					{
						this.MusicTitleScrollState = MotorcycleControlTopPanel.EScrollState.Scrolling;
						this.MusicTitleTextCurX = 0f;
					}
					else
					{
						this.MusicTitleScrollState = MotorcycleControlTopPanel.EScrollState.NoScroll;
					}
				}
				break;
			case MotorcycleControlTopPanel.EScrollState.Scrolling:
			{
				this.MusicTitleTextCurX -= delta * this.MusicTitleScrollSpeed;
				float num = this.MusicTitleViewWidth - this.MusicTitleTextWidth;
				if (this.MusicTitleTextCurX <= num)
				{
					this.MusicTitleTextCurX = num;
					this.MusicTitleScrollState = MotorcycleControlTopPanel.EScrollState.End;
				}
				this.MusicTitleText.SetAnchorOffsetX(this.MusicTitleTextCurX);
				break;
			}
			case MotorcycleControlTopPanel.EScrollState.End:
				this.MusicTitleScrollTime -= delta;
				if (this.MusicTitleScrollTime <= 0f)
				{
					this.MusicTitleScrollTime = this.MusicTitleScrollBeginTime;
					this.MusicTitleScrollState = MotorcycleControlTopPanel.EScrollState.Begin;
					this.MusicTitleText.SetAnchorOffsetX(0f);
				}
				break;
			}
			this.UpdateAlpha(delta);
		}

		// Token: 0x06031CB8 RID: 203960 RVA: 0x00DECD82 File Offset: 0x00DEAF82
		private void OnHudColorStateChanged(EMotorcycleHudColorState state)
		{
			this.SetColorState(state);
		}

		// Token: 0x06031CB9 RID: 203961 RVA: 0x00DECD8C File Offset: 0x00DEAF8C
		private void SetColorState(EMotorcycleHudColorState state)
		{
			if (state == EMotorcycleHudColorState.Parkour)
			{
				return;
			}
			if (this.ColorState == state)
			{
				return;
			}
			this.ColorState = state;
			if (state == EMotorcycleHudColorState.Nitrogen)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.StopSequenceByKey("TurnBlue", false, false);
				}
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 == null)
				{
					return;
				}
				levelSequencePlayer2.PlaySequencePurely("TurnGreen", false, false, null, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
				if (levelSequencePlayer3 != null)
				{
					levelSequencePlayer3.StopSequenceByKey("TurnGreen", false, false);
				}
				LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
				if (levelSequencePlayer4 == null)
				{
					return;
				}
				levelSequencePlayer4.PlaySequencePurely("TurnBlue", false, false, null, null, false);
				return;
			}
		}

		// Token: 0x06031CBA RID: 203962 RVA: 0x00DECE28 File Offset: 0x00DEB028
		private void UpdateAlpha(float delta)
		{
			if (this.AlphaTimeCountdown < 0f)
			{
				return;
			}
			this.AlphaTimeCountdown -= delta;
			if (this.AlphaTimeCountdown <= 0f)
			{
				this.AlphaTimeCountdown = -1f;
				this.TweenAnimPlayer.StopTweenAnim(9);
				this.TweenAnimPlayer.PlayTweenAnim(8);
			}
		}

		// Token: 0x06031CBB RID: 203963 RVA: 0x00DECE82 File Offset: 0x00DEB082
		private void ResetAlpha()
		{
			if (this.AlphaTimeCountdown == -1f)
			{
				this.TweenAnimPlayer.StopTweenAnim(8);
				this.TweenAnimPlayer.PlayTweenAnim(9);
			}
			this.AlphaTimeCountdown = 5000f;
		}

		// Token: 0x06031CBC RID: 203964 RVA: 0x00DECEB5 File Offset: 0x00DEB0B5
		private void ApplyTouchUiEditData()
		{
			TouchUiEditApplyHelper.ApplyCommonTouchUiEditData(ECommonTouchUiEditGroup.Motorcycle, this, "UiItem_MotorcycleControlTopEdit");
		}

		// Token: 0x06031CBD RID: 203965 RVA: 0x00DECEC3 File Offset: 0x00DEB0C3
		private void OnTouchUiEditSave(ECommonTouchUiEditGroup group)
		{
			if (group != ECommonTouchUiEditGroup.Motorcycle)
			{
				return;
			}
			this.ApplyTouchUiEditData();
		}

		// Token: 0x0401A5A5 RID: 107941
		[StaticVariableRuleIgnore]
		private static readonly string[] ActionNameList = new string[]
		{
			"载具音乐上一首",
			"载具音乐播放暂停",
			"载具音乐下一首"
		};

		// Token: 0x0401A5A6 RID: 107942
		private readonly BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401A5A7 RID: 107943
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A5A8 RID: 107944
		private bool MusicPlayStateDirty;

		// Token: 0x0401A5A9 RID: 107945
		[Nullable(2)]
		private UUIText MusicTitleText;

		// Token: 0x0401A5AA RID: 107946
		private float MusicTitleViewWidth;

		// Token: 0x0401A5AB RID: 107947
		private float MusicTitleTextWidth;

		// Token: 0x0401A5AC RID: 107948
		private MotorcycleControlTopPanel.EScrollState MusicTitleScrollState;

		// Token: 0x0401A5AD RID: 107949
		private float MusicTitleScrollTime;

		// Token: 0x0401A5AE RID: 107950
		private float MusicTitleScrollSpeed = 0.1f;

		// Token: 0x0401A5AF RID: 107951
		private float MusicTitleScrollBeginTime = 1000f;

		// Token: 0x0401A5B0 RID: 107952
		private float MusicTitleScrollEndTime = 1000f;

		// Token: 0x0401A5B1 RID: 107953
		private float MusicTitleTextCurX;

		// Token: 0x0401A5B2 RID: 107954
		[Nullable(2)]
		private IUiItemAspectOffsetConfig UiItemOffsetConfig;

		// Token: 0x0401A5B3 RID: 107955
		private readonly List<InputMultiKeyItem> KeyItemList = new List<InputMultiKeyItem>();

		// Token: 0x0401A5B4 RID: 107956
		private EMotorcycleHudColorState ColorState;

		// Token: 0x0401A5B5 RID: 107957
		private float AlphaTimeCountdown = -1f;

		// Token: 0x0401A5B6 RID: 107958
		private bool IsInTouch;

		// Token: 0x0401A5B7 RID: 107959
		private bool MusicEffectPlaying;

		// Token: 0x0401A5B8 RID: 107960
		[Nullable(2)]
		private CustomPromise<bool> StopPromise;

		// Token: 0x0200AA73 RID: 43635
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034AC7 RID: 215751
			MusicTitleButton,
			// Token: 0x04034AC8 RID: 215752
			MusicTitleNode,
			// Token: 0x04034AC9 RID: 215753
			MusicTitleText,
			// Token: 0x04034ACA RID: 215754
			MusicBtnPrev,
			// Token: 0x04034ACB RID: 215755
			MusicTogPlay,
			// Token: 0x04034ACC RID: 215756
			MusicBtnNext,
			// Token: 0x04034ACD RID: 215757
			KeyNode,
			// Token: 0x04034ACE RID: 215758
			RootItem,
			// Token: 0x04034ACF RID: 215759
			AniAlphaIn,
			// Token: 0x04034AD0 RID: 215760
			AniAlphaOut,
			// Token: 0x04034AD1 RID: 215761
			MusicPlayEffect,
			// Token: 0x04034AD2 RID: 215762
			KeyItem1,
			// Token: 0x04034AD3 RID: 215763
			KeyItem2,
			// Token: 0x04034AD4 RID: 215764
			KeyItem3
		}

		// Token: 0x0200AA74 RID: 43636
		[NullableContext(0)]
		private enum EScrollState
		{
			// Token: 0x04034AD6 RID: 215766
			NoScroll,
			// Token: 0x04034AD7 RID: 215767
			Begin,
			// Token: 0x04034AD8 RID: 215768
			Scrolling,
			// Token: 0x04034AD9 RID: 215769
			End
		}

		// Token: 0x0200AA75 RID: 43637
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x04034ADB RID: 215771
			BossStateArea = 1,
			// Token: 0x04034ADC RID: 215772
			MotorMusicEnable
		}
	}
}
