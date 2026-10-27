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
	// Token: 0x02005D9C RID: 23964
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleControlTopPanel : BattleVisibleChildView
	{
		// Token: 0x0603CD3A RID: 249146 RVA: 0x00E9B830 File Offset: 0x00E99A30
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

		// Token: 0x0603CD3B RID: 249147 RVA: 0x00E9B884 File Offset: 0x00E99A84
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

		// Token: 0x0603CD3C RID: 249148 RVA: 0x00E9BB08 File Offset: 0x00E99D08
		protected override UniTask OnBeforeStartAsync()
		{
			MotorcycleControlTopPanel.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleControlTopPanel.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CD3D RID: 249149 RVA: 0x00E9BB4C File Offset: 0x00E99D4C
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

		// Token: 0x0603CD3E RID: 249150 RVA: 0x00E9BB98 File Offset: 0x00E99D98
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

		// Token: 0x0603CD3F RID: 249151 RVA: 0x00E9BC94 File Offset: 0x00E99E94
		public void OnShowBattleChildViewPanel()
		{
			this.MusicPlayStateDirty = true;
			this.RefreshMusicTitle();
		}

		// Token: 0x0603CD40 RID: 249152 RVA: 0x00E9BCA3 File Offset: 0x00E99EA3
		public void OnHideBattleChildViewPanel()
		{
		}

		// Token: 0x0603CD41 RID: 249153 RVA: 0x00E9BCA5 File Offset: 0x00E99EA5
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			BattleUiModel.Instance.UpdateBossStateArea(EBossStateAreaType.MotorcycleControlTop, true);
		}

		// Token: 0x0603CD42 RID: 249154 RVA: 0x00E9BCBC File Offset: 0x00E99EBC
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

		// Token: 0x0603CD43 RID: 249155 RVA: 0x00E9BD18 File Offset: 0x00E99F18
		protected override UniTask OnBeforeHideAsync()
		{
			MotorcycleControlTopPanel.<OnBeforeHideAsync>d__32 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<MotorcycleControlTopPanel.<OnBeforeHideAsync>d__32>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CD44 RID: 249156 RVA: 0x00E9BD5B File Offset: 0x00E99F5B
		protected override void OnAutoDestroy()
		{
			base.OnAutoDestroy();
			if (this.StopPromise != null)
			{
				this.StopPromise.SetResult(true);
				this.StopPromise = null;
			}
		}

		// Token: 0x0603CD45 RID: 249157 RVA: 0x00E9BD7E File Offset: 0x00E99F7E
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

		// Token: 0x0603CD46 RID: 249158 RVA: 0x00E9BDAC File Offset: 0x00E99FAC
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

		// Token: 0x0603CD47 RID: 249159 RVA: 0x00E9BEC0 File Offset: 0x00E9A0C0
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

		// Token: 0x0603CD48 RID: 249160 RVA: 0x00E9BFD3 File Offset: 0x00E9A1D3
		private void OnClickMusicTitleButton()
		{
			this.ResetAlpha();
			MotorcycleMusicPlayerController.Instance.OpenMusicPlayerView();
		}

		// Token: 0x0603CD49 RID: 249161 RVA: 0x00E9BFE5 File Offset: 0x00E9A1E5
		private void OnClickMusicBtnPrev()
		{
			this.ResetAlpha();
			MotorcycleMusicPlayerController.Instance.QuickPlayMusic(false);
		}

		// Token: 0x0603CD4A RID: 249162 RVA: 0x00E9BFF8 File Offset: 0x00E9A1F8
		private void OnClickMusicBtnNext()
		{
			this.ResetAlpha();
			MotorcycleMusicPlayerController.Instance.QuickPlayMusic(true);
		}

		// Token: 0x0603CD4B RID: 249163 RVA: 0x00E9C00C File Offset: 0x00E9A20C
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

		// Token: 0x0603CD4C RID: 249164 RVA: 0x00E9C082 File Offset: 0x00E9A282
		private void OnBattleUiBossStateAreaChanged(EBossStateAreaType lastType, EBossStateAreaType curType)
		{
			this.RefreshBossStateAreaVisible();
		}

		// Token: 0x0603CD4D RID: 249165 RVA: 0x00E9C08A File Offset: 0x00E9A28A
		private void OnMotorMusicEnableStateChanged(bool isEnable)
		{
			this.RefreshMusicPlayState();
			this.RefreshMusicVisible();
		}

		// Token: 0x0603CD4E RID: 249166 RVA: 0x00E9C098 File Offset: 0x00E9A298
		private void RefreshMusicVisible()
		{
			base.SetVisible(2, MotorcycleMusicPlayerModel.Instance.IsEnable);
		}

		// Token: 0x0603CD4F RID: 249167 RVA: 0x00E9C0AB File Offset: 0x00E9A2AB
		private void OnMotorSwitchMusic()
		{
			this.RefreshMusicTitle();
			this.RefreshMusicPlayState();
		}

		// Token: 0x0603CD50 RID: 249168 RVA: 0x00E9C0B9 File Offset: 0x00E9A2B9
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshKeyNodeVisible();
		}

		// Token: 0x0603CD51 RID: 249169 RVA: 0x00E9C0C1 File Offset: 0x00E9A2C1
		private void OnInputCombineButton(bool isPress)
		{
			this.RefreshKeyNodeVisible();
		}

		// Token: 0x0603CD52 RID: 249170 RVA: 0x00E9C0CC File Offset: 0x00E9A2CC
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

		// Token: 0x0603CD53 RID: 249171 RVA: 0x00E9C15C File Offset: 0x00E9A35C
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

		// Token: 0x0603CD54 RID: 249172 RVA: 0x00E9C1A8 File Offset: 0x00E9A3A8
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

		// Token: 0x0603CD55 RID: 249173 RVA: 0x00E9C228 File Offset: 0x00E9A428
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

		// Token: 0x0603CD56 RID: 249174 RVA: 0x00E9C284 File Offset: 0x00E9A484
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

		// Token: 0x0603CD57 RID: 249175 RVA: 0x00E9C2ED File Offset: 0x00E9A4ED
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

		// Token: 0x0603CD58 RID: 249176 RVA: 0x00E9C30C File Offset: 0x00E9A50C
		private void RefreshBossStateAreaVisible()
		{
			bool bVisible = BattleUiModel.Instance.GetBossStateAreaType() >= EBossStateAreaType.MotorcycleControlTop;
			base.SetVisible(1, bVisible);
		}

		// Token: 0x0603CD59 RID: 249177 RVA: 0x00E9C334 File Offset: 0x00E9A534
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

		// Token: 0x0603CD5A RID: 249178 RVA: 0x00E9C388 File Offset: 0x00E9A588
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

		// Token: 0x0603CD5B RID: 249179 RVA: 0x00E9C4CA File Offset: 0x00E9A6CA
		private void OnHudColorStateChanged(EMotorcycleHudColorState state)
		{
			this.SetColorState(state);
		}

		// Token: 0x0603CD5C RID: 249180 RVA: 0x00E9C4D4 File Offset: 0x00E9A6D4
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

		// Token: 0x0603CD5D RID: 249181 RVA: 0x00E9C570 File Offset: 0x00E9A770
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

		// Token: 0x0603CD5E RID: 249182 RVA: 0x00E9C5CA File Offset: 0x00E9A7CA
		private void ResetAlpha()
		{
			if (this.AlphaTimeCountdown == -1f)
			{
				this.TweenAnimPlayer.StopTweenAnim(8);
				this.TweenAnimPlayer.PlayTweenAnim(9);
			}
			this.AlphaTimeCountdown = 5000f;
		}

		// Token: 0x0603CD5F RID: 249183 RVA: 0x00E9C5FD File Offset: 0x00E9A7FD
		private void ApplyTouchUiEditData()
		{
			TouchUiEditApplyHelper.ApplyCommonTouchUiEditData(ECommonTouchUiEditGroup.Motorcycle, this, "UiItem_MotorcycleControlTopEdit");
		}

		// Token: 0x0603CD60 RID: 249184 RVA: 0x00E9C60B File Offset: 0x00E9A80B
		private void OnTouchUiEditSave(ECommonTouchUiEditGroup group)
		{
			if (group != ECommonTouchUiEditGroup.Motorcycle)
			{
				return;
			}
			this.ApplyTouchUiEditData();
		}

		// Token: 0x0401FAED RID: 129773
		[StaticVariableRuleIgnore]
		private static readonly string[] ActionNameList = new string[]
		{
			"载具音乐上一首",
			"载具音乐播放暂停",
			"载具音乐下一首"
		};

		// Token: 0x0401FAEE RID: 129774
		private readonly BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401FAEF RID: 129775
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FAF0 RID: 129776
		private bool MusicPlayStateDirty;

		// Token: 0x0401FAF1 RID: 129777
		[Nullable(2)]
		private UUIText MusicTitleText;

		// Token: 0x0401FAF2 RID: 129778
		private float MusicTitleViewWidth;

		// Token: 0x0401FAF3 RID: 129779
		private float MusicTitleTextWidth;

		// Token: 0x0401FAF4 RID: 129780
		private MotorcycleControlTopPanel.EScrollState MusicTitleScrollState;

		// Token: 0x0401FAF5 RID: 129781
		private float MusicTitleScrollTime;

		// Token: 0x0401FAF6 RID: 129782
		private float MusicTitleScrollSpeed = 0.1f;

		// Token: 0x0401FAF7 RID: 129783
		private float MusicTitleScrollBeginTime = 1000f;

		// Token: 0x0401FAF8 RID: 129784
		private float MusicTitleScrollEndTime = 1000f;

		// Token: 0x0401FAF9 RID: 129785
		private float MusicTitleTextCurX;

		// Token: 0x0401FAFA RID: 129786
		[Nullable(2)]
		private IUiItemAspectOffsetConfig UiItemOffsetConfig;

		// Token: 0x0401FAFB RID: 129787
		private readonly List<InputMultiKeyItem> KeyItemList = new List<InputMultiKeyItem>();

		// Token: 0x0401FAFC RID: 129788
		private EMotorcycleHudColorState ColorState;

		// Token: 0x0401FAFD RID: 129789
		private float AlphaTimeCountdown = -1f;

		// Token: 0x0401FAFE RID: 129790
		private bool IsInTouch;

		// Token: 0x0401FAFF RID: 129791
		private bool MusicEffectPlaying;

		// Token: 0x0401FB00 RID: 129792
		[Nullable(2)]
		private CustomPromise<bool> StopPromise;

		// Token: 0x0200C06D RID: 49261
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A104 RID: 237828
			MusicTitleButton,
			// Token: 0x0403A105 RID: 237829
			MusicTitleNode,
			// Token: 0x0403A106 RID: 237830
			MusicTitleText,
			// Token: 0x0403A107 RID: 237831
			MusicBtnPrev,
			// Token: 0x0403A108 RID: 237832
			MusicTogPlay,
			// Token: 0x0403A109 RID: 237833
			MusicBtnNext,
			// Token: 0x0403A10A RID: 237834
			KeyNode,
			// Token: 0x0403A10B RID: 237835
			RootItem,
			// Token: 0x0403A10C RID: 237836
			AniAlphaIn,
			// Token: 0x0403A10D RID: 237837
			AniAlphaOut,
			// Token: 0x0403A10E RID: 237838
			MusicPlayEffect,
			// Token: 0x0403A10F RID: 237839
			KeyItem1,
			// Token: 0x0403A110 RID: 237840
			KeyItem2,
			// Token: 0x0403A111 RID: 237841
			KeyItem3
		}

		// Token: 0x0200C06E RID: 49262
		[NullableContext(0)]
		private enum EScrollState
		{
			// Token: 0x0403A113 RID: 237843
			NoScroll,
			// Token: 0x0403A114 RID: 237844
			Begin,
			// Token: 0x0403A115 RID: 237845
			Scrolling,
			// Token: 0x0403A116 RID: 237846
			End
		}

		// Token: 0x0200C06F RID: 49263
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x0403A118 RID: 237848
			BossStateArea = 1,
			// Token: 0x0403A119 RID: 237849
			MotorMusicEnable
		}
	}
}
