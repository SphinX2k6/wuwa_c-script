using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C25 RID: 23589
	[NullableContext(2)]
	[Nullable(0)]
	public class PianoQteLogic
	{
		// Token: 0x06039EF9 RID: 237305 RVA: 0x0104B100 File Offset: 0x01049300
		public void EnterPianoQte()
		{
			if (this.Model == null)
			{
				this.Model = PianoGameplayModel.Instance;
				this.BaseMusicFadeOutTime = this.Model.PianoGameplaySetting.MusicFadeOutTime * 1000f;
				this.MusicStartRecoverTime = this.Model.PianoGameplaySetting.MusicStartRecoverTime * 1000f;
				this.TargetMusicRecoverTime = this.Model.PianoGameplaySetting.MusicRecoverTime * 1000f;
			}
		}

		// Token: 0x06039EFA RID: 237306 RVA: 0x0104B174 File Offset: 0x01049374
		public void ExitPianoQte()
		{
			if (this.ShowKeyTimer != null)
			{
				TimerSystem.Instance.Remove(this.ShowKeyTimer);
				this.ShowKeyTimer = null;
			}
			this.SetAllKeysVisible(false, null);
			this.TargetMusicFadeOutTime = 0f;
			this.CurrentMusicFadeOutTime = 0f;
			this.TargetMusicRecoverTime = 0f;
			this.CurrentMusicRecoverTime = 0f;
			this.AutoPlayEnabled = false;
			this.StopAllTimers();
			this.SwitchState(EPianoGameplayQteState.Idle);
		}

		// Token: 0x06039EFB RID: 237307 RVA: 0x0104B1F1 File Offset: 0x010493F1
		public void ExecutePianoSequenceEvent(EPianoSequenceKeyType key)
		{
			if (key == EPianoSequenceKeyType.ShowKey)
			{
				this.SwitchState(EPianoGameplayQteState.ShowKey);
				this.ShowKeys();
				return;
			}
			if (key != EPianoSequenceKeyType.SeqEnd)
			{
				return;
			}
			if (PianoGameplayModel.Instance.GameplayStage == EPianoGameplayStage.Practice)
			{
				PianoGameplayModel.Instance.GameplayStage = EPianoGameplayStage.Normal;
			}
		}

		// Token: 0x06039EFC RID: 237308 RVA: 0x0104B220 File Offset: 0x01049420
		private void SwitchState(EPianoGameplayQteState state)
		{
			if (this.State == state)
			{
				return;
			}
			this.State = state;
			switch (this.State)
			{
			case EPianoGameplayQteState.ShowKey:
				this.ShowKeys();
				return;
			case EPianoGameplayQteState.Judge:
				this.StartJudgeTimer();
				return;
			case EPianoGameplayQteState.JudgeFail:
				this.JudgeFail();
				return;
			case EPianoGameplayQteState.JudgeSuccess:
				this.JudgeSuccess();
				return;
			case EPianoGameplayQteState.WaitRecover:
				this.WaitRecover();
				return;
			case EPianoGameplayQteState.Recover:
				this.RecoverMusic();
				return;
			default:
				return;
			}
		}

		// Token: 0x06039EFD RID: 237309 RVA: 0x0104B290 File Offset: 0x01049490
		private void HandleStateTick(float deltaTime)
		{
			EPianoGameplayQteState state = this.State;
			if (state == EPianoGameplayQteState.JudgeFail)
			{
				this.HandleJudgeFailTick(deltaTime);
				return;
			}
			if (state != EPianoGameplayQteState.Recover)
			{
				return;
			}
			this.HandleRecoverTick(deltaTime);
		}

		// Token: 0x06039EFE RID: 237310 RVA: 0x0104B2BC File Offset: 0x010494BC
		private void ShowKeys()
		{
			if (this.Model == null)
			{
				return;
			}
			if (this.ShowKeyTimer != null && this.ShowKeyTimer.Valid())
			{
				return;
			}
			if (this.JudgeTimer != null && this.JudgeTimer.Valid())
			{
				return;
			}
			this.CurShowKey = 0;
			this.SetAllKeysVisible(false, null);
			if (this.Model.PianoGameplaySetting.KeyDelay <= 0f)
			{
				this.SetAllKeysVisible(true, null);
				this.SwitchState(EPianoGameplayQteState.Judge);
				return;
			}
			this.ShowSingleKey();
		}

		// Token: 0x06039EFF RID: 237311 RVA: 0x0104B34A File Offset: 0x0104954A
		private void ShowSingleKey(float _)
		{
			this.ShowSingleKey();
		}

		// Token: 0x06039F00 RID: 237312 RVA: 0x0104B354 File Offset: 0x01049554
		private void ShowSingleKey()
		{
			this.Model.BtnPianoItemList[this.CurShowKey].SetVisibility(true, null);
			this.CurShowKey++;
			if (this.CurShowKey >= this.Model.BtnPianoItemList.Count)
			{
				this.ShowKeyTimer = null;
				this.SwitchState(EPianoGameplayQteState.Judge);
				return;
			}
			float keyDelay = this.Model.PianoGameplaySetting.KeyDelay;
			this.ShowKeyTimer = TimerSystem.Instance.Delay(new TTimerAction(this.ShowSingleKey), keyDelay * 1000f, null, null, true, 1f);
		}

		// Token: 0x06039F01 RID: 237313 RVA: 0x0104B3F8 File Offset: 0x010495F8
		private void SetAllKeysVisible(bool visible, EPianoQteResult? qteResult = null)
		{
			if (this.Model == null)
			{
				return;
			}
			foreach (PianoQteBtnItem pianoQteBtnItem in this.Model.BtnPianoItemList)
			{
				pianoQteBtnItem.SetVisibility(visible, qteResult);
			}
		}

		// Token: 0x06039F02 RID: 237314 RVA: 0x0104B458 File Offset: 0x01049658
		private void JudgeFail()
		{
			this.SetAllKeysVisible(false, new EPianoQteResult?(EPianoQteResult.Fail));
			if (this.ShowKeyTimer != null && this.ShowKeyTimer.Valid())
			{
				TimerSystem.Instance.Remove(this.ShowKeyTimer);
				this.ShowKeyTimer = null;
			}
			EPianoGameplayQteFailReason judgeFailReason = this.JudgeFailReason;
			if (judgeFailReason != EPianoGameplayQteFailReason.Timeout)
			{
				if (judgeFailReason == EPianoGameplayQteFailReason.WrongKey)
				{
					float num = 0f;
					if (this.JudgeTimer != null && this.JudgeTimer.Valid())
					{
						num = TimerSystem.Instance.GetNextRemainTime(this.JudgeTimer);
					}
					this.TargetMusicFadeOutTime = this.BaseMusicFadeOutTime + num;
				}
			}
			else
			{
				this.TargetMusicFadeOutTime = this.BaseMusicFadeOutTime;
			}
			this.StopJudgeTimer();
			this.StopAutoPlayTimer();
			this.CurrentMusicFadeOutTime = this.TargetMusicFadeOutTime;
		}

		// Token: 0x06039F03 RID: 237315 RVA: 0x0104B510 File Offset: 0x01049710
		private void HandleJudgeFailTick(float deltaTime)
		{
			float value = 0f;
			if (this.CurrentMusicFadeOutTime <= 0f)
			{
				AudioSystem.Instance.SetRtpcValue("level_3_8_piano_volume", value, null);
				this.SwitchState(EPianoGameplayQteState.WaitRecover);
				return;
			}
			this.CurrentMusicFadeOutTime -= deltaTime;
			if (this.CurrentMusicFadeOutTime <= 0f)
			{
				this.CurrentMusicFadeOutTime = 0f;
			}
			value = this.CurrentMusicFadeOutTime / this.TargetMusicFadeOutTime;
			AudioSystem.Instance.SetRtpcValue("level_3_8_piano_volume", value, null);
		}

		// Token: 0x06039F04 RID: 237316 RVA: 0x0104B59E File Offset: 0x0104979E
		private void JudgeSuccess()
		{
			this.StopJudgeTimer();
			this.StopAutoPlayTimer();
		}

		// Token: 0x06039F05 RID: 237317 RVA: 0x0104B5AC File Offset: 0x010497AC
		private void StartJudgeTimer()
		{
			if (this.JudgeTimer != null && this.JudgeTimer.Valid())
			{
				return;
			}
			this.JudgeTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.JudgeTimer = null;
				this.JudgeFailReason = EPianoGameplayQteFailReason.Timeout;
				this.SwitchState(EPianoGameplayQteState.JudgeFail);
			}, this.Model.PianoGameplaySetting.JudgeTime * 1000f, null, null, true, 1f);
			this.StartAutoPlay();
		}

		// Token: 0x06039F06 RID: 237318 RVA: 0x0104B60F File Offset: 0x0104980F
		private void StopJudgeTimer()
		{
			if (this.JudgeTimer != null && this.JudgeTimer.Valid())
			{
				TimerSystem.Instance.Remove(this.JudgeTimer);
			}
			this.JudgeTimer = null;
		}

		// Token: 0x06039F07 RID: 237319 RVA: 0x0104B640 File Offset: 0x01049840
		private void HandleRecoverTick(float deltaTime)
		{
			float value = 0f;
			if (this.TargetMusicRecoverTime <= 0f)
			{
				AudioSystem.Instance.SetRtpcValue("level_3_8_piano_volume", value, null);
				this.SwitchState(EPianoGameplayQteState.Idle);
				return;
			}
			this.CurrentMusicRecoverTime += deltaTime;
			if (this.CurrentMusicRecoverTime >= this.TargetMusicRecoverTime)
			{
				this.CurrentMusicRecoverTime = this.TargetMusicRecoverTime;
			}
			value = this.CurrentMusicRecoverTime / this.TargetMusicRecoverTime;
			AudioSystem.Instance.SetRtpcValue("level_3_8_piano_volume", value, null);
			if (this.CurrentMusicRecoverTime >= this.TargetMusicRecoverTime)
			{
				this.SwitchState(EPianoGameplayQteState.Idle);
			}
		}

		// Token: 0x06039F08 RID: 237320 RVA: 0x0104B6E5 File Offset: 0x010498E5
		private void WaitRecover()
		{
			this.MusicRecoverTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.SwitchState(EPianoGameplayQteState.Recover);
			}, this.MusicStartRecoverTime, null, null, true, 1f);
		}

		// Token: 0x06039F09 RID: 237321 RVA: 0x0104B711 File Offset: 0x01049911
		private void RecoverMusic()
		{
			this.CurrentMusicRecoverTime = 0f;
		}

		// Token: 0x17006E5C RID: 28252
		// (get) Token: 0x06039F0A RID: 237322 RVA: 0x0104B71E File Offset: 0x0104991E
		public bool IsAutoPlayEnabled
		{
			get
			{
				return this.AutoPlayEnabled;
			}
		}

		// Token: 0x06039F0B RID: 237323 RVA: 0x0104B726 File Offset: 0x01049926
		public void SetAutoPlay(bool enable)
		{
			if (this.AutoPlayEnabled == enable)
			{
				return;
			}
			this.AutoPlayEnabled = enable;
			if (!enable)
			{
				this.StopAutoPlayTimer();
				return;
			}
			if (this.JudgeTimer != null && this.JudgeTimer.Valid())
			{
				this.AutoPlayPressKey();
			}
		}

		// Token: 0x06039F0C RID: 237324 RVA: 0x0104B75E File Offset: 0x0104995E
		private void StartAutoPlay()
		{
			if (!this.AutoPlayEnabled)
			{
				return;
			}
			if (this.AutoPlayTimer != null && this.AutoPlayTimer.Valid())
			{
				return;
			}
			this.AutoPlayPressKey();
		}

		// Token: 0x06039F0D RID: 237325 RVA: 0x0104B785 File Offset: 0x01049985
		private void AutoPlayPressKey(float _)
		{
			this.AutoPlayPressKey();
		}

		// Token: 0x06039F0E RID: 237326 RVA: 0x0104B790 File Offset: 0x01049990
		private void AutoPlayPressKey()
		{
			this.AutoPlayTimer = null;
			if (!this.AutoPlayEnabled || this.Model == null)
			{
				return;
			}
			PianoQteBtnItem pianoQteBtnItem = this.Model.BtnPianoItemList.Find((PianoQteBtnItem btnItem) => btnItem.Visibility);
			if (pianoQteBtnItem == null)
			{
				return;
			}
			this.OnKeyInput(pianoQteBtnItem.KeyName);
			if (this.JudgeTimer != null && this.JudgeTimer.Valid())
			{
				float autoPlayDelay = this.Model.PianoGameplaySetting.AutoPlayDelay;
				if (autoPlayDelay <= 0f)
				{
					this.AutoPlayPressKey();
					return;
				}
				this.AutoPlayTimer = TimerSystem.Instance.Delay(new TTimerAction(this.AutoPlayPressKey), autoPlayDelay * 1000f, null, null, true, 1f);
			}
		}

		// Token: 0x06039F0F RID: 237327 RVA: 0x0104B855 File Offset: 0x01049A55
		private void StopAutoPlayTimer()
		{
			if (this.AutoPlayTimer != null && this.AutoPlayTimer.Valid())
			{
				TimerSystem.Instance.Remove(this.AutoPlayTimer);
			}
			this.AutoPlayTimer = null;
		}

		// Token: 0x06039F10 RID: 237328 RVA: 0x0104B884 File Offset: 0x01049A84
		[NullableContext(1)]
		public void OnKeyInput(string keyName)
		{
			bool flag = true;
			int num = 0;
			foreach (PianoQteBtnItem pianoQteBtnItem in this.Model.BtnPianoItemList)
			{
				if (keyName == pianoQteBtnItem.KeyName)
				{
					if (!pianoQteBtnItem.Visibility)
					{
						return;
					}
					if (flag)
					{
						pianoQteBtnItem.SetVisibility(false, new EPianoQteResult?(EPianoQteResult.Success));
						break;
					}
					this.JudgeFailReason = EPianoGameplayQteFailReason.WrongKey;
					this.SwitchState(EPianoGameplayQteState.JudgeFail);
					flag = false;
					break;
				}
				else
				{
					flag = !pianoQteBtnItem.Visibility;
					num++;
				}
			}
			if (num == this.Model.BtnPianoItemList.Count - 1 && flag)
			{
				this.JudgeSuccess();
			}
		}

		// Token: 0x06039F11 RID: 237329 RVA: 0x0104B944 File Offset: 0x01049B44
		public void OnPause()
		{
			if (this.ShowKeyTimer != null)
			{
				TimerSystem.Instance.Pause(this.ShowKeyTimer, null);
			}
			if (this.JudgeTimer != null && this.JudgeTimer.Valid())
			{
				TimerSystem.Instance.Pause(this.JudgeTimer, null);
			}
			if (this.MusicRecoverTimer != null && this.MusicRecoverTimer.Valid())
			{
				TimerSystem.Instance.Pause(this.MusicRecoverTimer, null);
			}
			if (this.AutoPlayTimer != null && this.AutoPlayTimer.Valid())
			{
				TimerSystem.Instance.Pause(this.AutoPlayTimer, null);
			}
		}

		// Token: 0x06039F12 RID: 237330 RVA: 0x0104B9E0 File Offset: 0x01049BE0
		public void OnResume()
		{
			if (this.ShowKeyTimer != null)
			{
				TimerSystem.Instance.Resume(this.ShowKeyTimer);
			}
			if (this.JudgeTimer != null && this.JudgeTimer.Valid())
			{
				TimerSystem.Instance.Resume(this.JudgeTimer);
			}
			if (this.MusicRecoverTimer != null && this.MusicRecoverTimer.Valid())
			{
				TimerSystem.Instance.Resume(this.MusicRecoverTimer);
			}
			if (this.AutoPlayTimer != null && this.AutoPlayTimer.Valid())
			{
				TimerSystem.Instance.Resume(this.AutoPlayTimer);
			}
		}

		// Token: 0x06039F13 RID: 237331 RVA: 0x0104BA78 File Offset: 0x01049C78
		public void Tick(float deltaTime)
		{
			this.HandleStateTick(deltaTime);
		}

		// Token: 0x06039F14 RID: 237332 RVA: 0x0104BA84 File Offset: 0x01049C84
		private void StopAllTimers()
		{
			if (this.ShowKeyTimer != null && this.ShowKeyTimer.Valid())
			{
				TimerSystem.Instance.Remove(this.ShowKeyTimer);
				this.ShowKeyTimer = null;
			}
			if (this.JudgeTimer != null && this.JudgeTimer.Valid())
			{
				TimerSystem.Instance.Remove(this.JudgeTimer);
				this.JudgeTimer = null;
			}
			if (this.MusicRecoverTimer != null && this.MusicRecoverTimer.Valid())
			{
				TimerSystem.Instance.Remove(this.MusicRecoverTimer);
				this.MusicRecoverTimer = null;
			}
			if (this.AutoPlayTimer != null && this.AutoPlayTimer.Valid())
			{
				TimerSystem.Instance.Remove(this.AutoPlayTimer);
				this.AutoPlayTimer = null;
			}
		}

		// Token: 0x0401EA26 RID: 125478
		private PianoGameplayModel Model;

		// Token: 0x0401EA27 RID: 125479
		private int CurShowKey;

		// Token: 0x0401EA28 RID: 125480
		private TimerHandle ShowKeyTimer;

		// Token: 0x0401EA29 RID: 125481
		private TimerHandle JudgeTimer;

		// Token: 0x0401EA2A RID: 125482
		private EPianoGameplayQteFailReason JudgeFailReason;

		// Token: 0x0401EA2B RID: 125483
		private EPianoGameplayQteState State;

		// Token: 0x0401EA2C RID: 125484
		private float BaseMusicFadeOutTime;

		// Token: 0x0401EA2D RID: 125485
		private float TargetMusicFadeOutTime;

		// Token: 0x0401EA2E RID: 125486
		private float CurrentMusicFadeOutTime;

		// Token: 0x0401EA2F RID: 125487
		private float MusicStartRecoverTime;

		// Token: 0x0401EA30 RID: 125488
		private float TargetMusicRecoverTime;

		// Token: 0x0401EA31 RID: 125489
		private float CurrentMusicRecoverTime;

		// Token: 0x0401EA32 RID: 125490
		private TimerHandle MusicRecoverTimer;

		// Token: 0x0401EA33 RID: 125491
		private bool AutoPlayEnabled;

		// Token: 0x0401EA34 RID: 125492
		private TimerHandle AutoPlayTimer;
	}
}
