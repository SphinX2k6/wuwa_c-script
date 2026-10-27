using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.SkillButtonUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CE7 RID: 23783
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleSkillGamepadItem : BattleSkillItem
	{
		// Token: 0x17008E00 RID: 36352
		// (get) Token: 0x0603C2D9 RID: 246489 RVA: 0x00E67CF3 File Offset: 0x00E65EF3
		public bool IsMainButton
		{
			get
			{
				return this.ButtonAreaType == EGamepadButtonAreaType.Main;
			}
		}

		// Token: 0x17008E01 RID: 36353
		// (get) Token: 0x0603C2DA RID: 246490 RVA: 0x00E67CFE File Offset: 0x00E65EFE
		public bool IsSubButton
		{
			get
			{
				return this.ButtonAreaType == EGamepadButtonAreaType.Sub;
			}
		}

		// Token: 0x17008E02 RID: 36354
		// (get) Token: 0x0603C2DB RID: 246491 RVA: 0x00E67D09 File Offset: 0x00E65F09
		public bool IsLeftButton
		{
			get
			{
				return this.ButtonAreaType == EGamepadButtonAreaType.Left;
			}
		}

		// Token: 0x0603C2DC RID: 246492 RVA: 0x00E67D14 File Offset: 0x00E65F14
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			if (!(param is int))
			{
				throw new InvalidCastException();
			}
			int num = (int)param;
			if (num < 4)
			{
				this.ButtonAreaType = EGamepadButtonAreaType.Main;
				return;
			}
			if (num < 8)
			{
				this.ButtonAreaType = EGamepadButtonAreaType.Main;
				this.IsSecondButton = true;
				this.CdFixedPoint = 0;
				UUIText coolDownUiText = this.CoolDownUiText;
				if (coolDownUiText != null)
				{
					coolDownUiText.SetUIItemScale(new FVector(1.667f, 1.667f, 1f));
				}
				this.IsHideNumComp = true;
				return;
			}
			if (num < 12)
			{
				this.ButtonAreaType = EGamepadButtonAreaType.Left;
				this.CdFixedPoint = 0;
				UUIText coolDownUiText2 = this.CoolDownUiText;
				if (coolDownUiText2 != null)
				{
					coolDownUiText2.SetUIItemScale(new FVector(1.667f, 1.667f, 1f));
				}
				this.IsHideNumComp = true;
				return;
			}
			this.ButtonAreaType = EGamepadButtonAreaType.Sub;
			this.CdFixedPoint = 1;
		}

		// Token: 0x0603C2DD RID: 246493 RVA: 0x00E67DE0 File Offset: 0x00E65FE0
		[NullableContext(1)]
		public void SetKeyName(string keyName)
		{
			this.KeyName = keyName;
			if (this.IsMainButton || this.IsLeftButton)
			{
				this.KeyItem.SetActive(false);
				return;
			}
			InputKeyItemData singleInputKeyItemData = new InputKeyItemData
			{
				KeyName = this.KeyName
			};
			this.KeyItem.RefreshByKeyList(singleInputKeyItemData, null);
			this.KeyItem.SetActive(true);
		}

		// Token: 0x0603C2DE RID: 246494 RVA: 0x00E67E3C File Offset: 0x00E6603C
		public override void Refresh(ISkillButtonData skillButtonData)
		{
			if (skillButtonData == null && this.IsSecondButton)
			{
				this.Deactivate();
				return;
			}
			if (this.IsSecondButton && this.SrcBehaviorButtonData == null && skillButtonData != null && skillButtonData.GetButtonType() == ESkillButtonType.幻象1)
			{
				SkillButtonUiGamepadDataBase gamepadData = this.GamepadData;
				if (gamepadData != null && gamepadData.SwitchInteractData.IsSwitchInteractOpen && this.GamepadData.SwitchInteractData.State == EGamepadSwitchInteractState.Explore)
				{
					this.Deactivate();
					return;
				}
			}
			bool flag = this.SkillButtonData != null || this.BehaviorButtonData != null;
			this.BehaviorButtonData = null;
			if (skillButtonData == null)
			{
				if (flag || !this.IsRefreshOnce)
				{
					this.IsRefreshOnce = true;
					this.RefreshWhenDisable();
				}
				return;
			}
			if (this.SkillButtonData != skillButtonData)
			{
				this.OnCoolDownFinishedCallback = null;
			}
			base.Refresh(skillButtonData);
			if (this.SrcBehaviorButtonData != null)
			{
				this.SwitchInteract(false, null);
			}
		}

		// Token: 0x0603C2DF RID: 246495 RVA: 0x00E67F0C File Offset: 0x00E6610C
		public void SwitchInteract(bool enable, SkillButtonData skillButtonData = null)
		{
			if (enable)
			{
				this.SrcBehaviorButtonData = this.BehaviorButtonData;
				this.BehaviorButtonData = null;
				this.OnCoolDownFinishedCallback = null;
				base.Refresh(skillButtonData);
			}
			else
			{
				this.SrcBehaviorButtonData = null;
			}
			if (this.SwitchInteractItem != null)
			{
				this.SwitchInteractItem.RefreshEnable(enable);
				return;
			}
			if (enable)
			{
				this.SwitchInteractItem = new BattleSkillSwitchInteractItem();
				this.SwitchInteractItem.Init(base.GetExtraContainer());
				this.SwitchInteractItem.RefreshEnable(true);
			}
		}

		// Token: 0x0603C2E0 RID: 246496 RVA: 0x00E67F88 File Offset: 0x00E66188
		private void RefreshWhenDisable()
		{
			if (this.SrcBehaviorButtonData != null)
			{
				this.SwitchInteract(false, null);
			}
			if (!this.IsMainButton)
			{
				this.Deactivate();
				return;
			}
			base.ResetButtonDisappearStateForReuse();
			this.SkillButtonData = null;
			base.SetSkillIcon(this.GamepadData.NoneIcon);
			this.RefreshSkillName();
			base.ResetSkillCoolDown();
			this.SetTextureHandleId = 0;
			this.OnCoolDownFinishedCallback = null;
			this.KeyActionName = null;
			this.KeyOperationType = null;
			this.PressActionType = EInputAction.None;
			this.RefreshDynamicEffect();
			base.CancelLoadDynamicEffectNiagara();
			base.CancelLoadCdCompletedNiagara();
			BattleSkillUltraItem ultraComponent = this.UltraComponent;
			if (ultraComponent != null)
			{
				ultraComponent.SetComponentActive(false);
			}
			BattleSkillNumItem numComponent = this.NumComponent;
			if (numComponent != null)
			{
				numComponent.SetComponentActive(false);
			}
			BattleSkillDotIndicatorItem dotIndicatorComponent = this.DotIndicatorComponent;
			if (dotIndicatorComponent != null)
			{
				dotIndicatorComponent.SetComponentActive(false);
			}
			BattleSkillSwitchComponent switchComponent = this.SwitchComponent;
			if (switchComponent != null)
			{
				switchComponent.SetComponentActive(false);
			}
			BattleSkillLongPressItem longPressComponent = this.LongPressComponent;
			if (longPressComponent != null)
			{
				longPressComponent.SetComponentActive(false);
			}
			BattleSkillConfigLongPressItem configLongPressComponent = this.ConfigLongPressComponent;
			if (configLongPressComponent != null)
			{
				configLongPressComponent.SetComponentActive(false);
			}
			BattleSkillExtraEffectItem extraEffectComponent = this.ExtraEffectComponent;
			if (extraEffectComponent != null)
			{
				extraEffectComponent.SetComponentActive(false);
			}
			if (!base.IsShowOrShowing)
			{
				base.Show(null);
			}
		}

		// Token: 0x0603C2E1 RID: 246497 RVA: 0x00E680A9 File Offset: 0x00E662A9
		public override void RefreshVisible()
		{
			if (!this.IsMainButton || base.IsHiddenByButtonDisappear)
			{
				base.RefreshVisible();
				return;
			}
			if (!this.IsVisible())
			{
				this.RefreshWhenDisable();
				return;
			}
			if (!base.IsShowOrShowing)
			{
				base.Show(null);
			}
		}

		// Token: 0x0603C2E2 RID: 246498 RVA: 0x00E680E0 File Offset: 0x00E662E0
		public override void RefreshEnable(bool bForce = false)
		{
			if (this.BehaviorButtonData != null)
			{
				base.SetSkillItemEnable(this.BehaviorButtonData.IsEnable(), bForce);
				return;
			}
			base.RefreshEnable(bForce);
		}

		// Token: 0x0603C2E3 RID: 246499 RVA: 0x00E68104 File Offset: 0x00E66304
		public override void RefreshSkillCoolDown()
		{
			if (this.SkillButtonData == null)
			{
				base.FinishSkillCoolDown();
				return;
			}
			base.RefreshSkillCoolDown();
		}

		// Token: 0x0603C2E4 RID: 246500 RVA: 0x00E6811C File Offset: 0x00E6631C
		public void PlaySwitchCd()
		{
			this.HideCdText = true;
			SkillButtonUiGamepadDataBase gamepadData = this.GamepadData;
			float num = (float)((gamepadData != null) ? gamepadData.SwitchInteractData.SwitchTime : 0) * (float)TimeUtil.Instance.Millisecond;
			base.PlaySkillTimeDown((double)num, (double)num, null);
		}

		// Token: 0x0603C2E5 RID: 246501 RVA: 0x00E68160 File Offset: 0x00E66360
		[NullableContext(1)]
		public void RefreshByBehaviorButtonData(BehaviorButtonData behaviorButtonData)
		{
			base.ResetButtonDisappearStateForReuse();
			this.SkillButtonData = null;
			this.BehaviorButtonData = behaviorButtonData;
			if (behaviorButtonData.ButtonType == 104)
			{
				SkillButtonUiGamepadDataBase gamepadData = this.GamepadData;
				if (gamepadData != null && gamepadData.SwitchInteractData.IsSwitchInteractOpen && this.GamepadData.SwitchInteractData.State == EGamepadSwitchInteractState.Explore)
				{
					SkillButtonData skillButtonDataByButton = SkillButtonUiModel.Instance.GetSkillButtonDataByButton(ESkillButtonType.幻象1);
					if (skillButtonDataByButton != null && skillButtonDataByButton.IsVisible())
					{
						skillButtonDataByButton.GetSkillId();
						this.SwitchInteract(true, skillButtonDataByButton);
						return;
					}
				}
			}
			base.ResetSkillCoolDown();
			this.SetTextureHandleId = 0;
			this.OnCoolDownFinishedCallback = null;
			this.PressActionType = EInputAction.None;
			this.RefreshDynamicEffect();
			base.CancelLoadDynamicEffectNiagara();
			base.CancelLoadCdCompletedNiagara();
			BattleSkillUltraItem ultraComponent = this.UltraComponent;
			if (ultraComponent != null)
			{
				ultraComponent.SetComponentActive(false);
			}
			BattleSkillNumItem numComponent = this.NumComponent;
			if (numComponent != null)
			{
				numComponent.SetComponentActive(false);
			}
			BattleSkillDotIndicatorItem dotIndicatorComponent = this.DotIndicatorComponent;
			if (dotIndicatorComponent != null)
			{
				dotIndicatorComponent.SetComponentActive(false);
			}
			BattleSkillSwitchComponent switchComponent = this.SwitchComponent;
			if (switchComponent != null)
			{
				switchComponent.SetComponentActive(false);
			}
			BattleSkillLongPressItem longPressComponent = this.LongPressComponent;
			if (longPressComponent != null)
			{
				longPressComponent.SetComponentActive(false);
			}
			BattleSkillConfigLongPressItem configLongPressComponent = this.ConfigLongPressComponent;
			if (configLongPressComponent != null)
			{
				configLongPressComponent.SetComponentActive(false);
			}
			BattleSkillExtraEffectItem extraEffectComponent = this.ExtraEffectComponent;
			if (extraEffectComponent != null)
			{
				extraEffectComponent.SetComponentActive(false);
			}
			this.RefreshVisible();
			this.RefreshSkillIcon();
			this.RefreshSkillName();
			this.RefreshKey();
			this.RefreshEnable(false);
			if (this.SrcBehaviorButtonData != null)
			{
				this.SwitchInteract(false, null);
			}
		}

		// Token: 0x0603C2E6 RID: 246502 RVA: 0x00E682BC File Offset: 0x00E664BC
		[NullableContext(1)]
		protected override bool CheckSkillIconIsTexture(string skillIconPath)
		{
			return this.SkillButtonData != null && base.CheckSkillIconIsTexture(skillIconPath);
		}

		// Token: 0x0603C2E7 RID: 246503 RVA: 0x00E682CF File Offset: 0x00E664CF
		public override void RefreshSkillIcon()
		{
			if (this.BehaviorButtonData != null)
			{
				base.SetSkillIcon(this.BehaviorButtonData.GetSkillTexturePath());
				return;
			}
			base.RefreshSkillIcon();
		}

		// Token: 0x0603C2E8 RID: 246504 RVA: 0x00E682F4 File Offset: 0x00E664F4
		public override bool IsVisible()
		{
			if (this.GamepadData.GetIsPressCombineButton() && (this.KeyName == EKey.Gamepad_LeftTrigger || this.KeyName == EKey.Gamepad_RightTrigger))
			{
				return false;
			}
			if (this.BehaviorButtonData != null)
			{
				return this.BehaviorButtonData.IsVisible();
			}
			ISkillButtonData skillButtonData = this.SkillButtonData;
			return (skillButtonData != null && skillButtonData.GetButtonType() == ESkillButtonType.副开火 && this.GamepadData.IsAim()) || base.IsVisible();
		}

		// Token: 0x0603C2E9 RID: 246505 RVA: 0x00E6837F File Offset: 0x00E6657F
		public override void Deactivate()
		{
			base.Deactivate();
			this.IsRefreshOnce = false;
		}

		// Token: 0x0603C2EA RID: 246506 RVA: 0x00E6838E File Offset: 0x00E6658E
		public override void Reset()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
			base.Reset();
		}

		// Token: 0x0603C2EB RID: 246507 RVA: 0x00E683AE File Offset: 0x00E665AE
		public override void RefreshKey()
		{
			if (this.IsMainButton || this.IsLeftButton)
			{
				this.KeyItem.SetActive(false);
				return;
			}
			this.SetKeyName(this.KeyName);
			this.KeyItem.SetActive(true);
		}

		// Token: 0x0603C2EC RID: 246508 RVA: 0x00E683E5 File Offset: 0x00E665E5
		public override void OnInputAction(bool bForcePlayClickEffect = false)
		{
			if (this.BehaviorButtonData != null)
			{
				if (this.BehaviorButtonData.IsEnable() && this.BehaviorButtonData.IsVisible())
				{
					BattleUiNiagaraItem clickEffect = this.ClickEffect;
					if (clickEffect == null)
					{
						return;
					}
					clickEffect.Play();
				}
				return;
			}
			base.OnInputAction(bForcePlayClickEffect);
		}

		// Token: 0x0603C2ED RID: 246509 RVA: 0x00E68424 File Offset: 0x00E66624
		public void PlayPressCombineButtonSeq()
		{
			this.InitLevelSequencePlayer();
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlaySequencePurely("ClickLbIn", false, false, null, null, false);
			this.CombinePressTipSprite.SetUIActive(true);
			this.IsPlayPressSeq = true;
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect == null)
			{
				return;
			}
			clickEffect.Stop();
		}

		// Token: 0x0603C2EE RID: 246510 RVA: 0x00E68484 File Offset: 0x00E66684
		public void PlayReleaseCombineButtonSeq()
		{
			if (!this.IsPlayPressSeq)
			{
				return;
			}
			this.IsPlayPressSeq = false;
			this.InitLevelSequencePlayer();
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlaySequencePurely("ClickLbOut", false, false, null, null, false);
			this.CombinePressTipSprite.SetUIActive(false);
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect == null)
			{
				return;
			}
			clickEffect.Stop();
		}

		// Token: 0x0603C2EF RID: 246511 RVA: 0x00E684ED File Offset: 0x00E666ED
		private void InitLevelSequencePlayer()
		{
			if (this.LevelSequencePlayer != null)
			{
				return;
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0401F5F0 RID: 128496
		public SkillButtonUiGamepadDataBase GamepadData;

		// Token: 0x0401F5F1 RID: 128497
		public EGamepadButtonAreaType ButtonAreaType;

		// Token: 0x0401F5F2 RID: 128498
		public bool IsSecondButton;

		// Token: 0x0401F5F3 RID: 128499
		[Nullable(1)]
		private string KeyName = string.Empty;

		// Token: 0x0401F5F4 RID: 128500
		private bool IsRefreshOnce;

		// Token: 0x0401F5F5 RID: 128501
		public BehaviorButtonData BehaviorButtonData;

		// Token: 0x0401F5F6 RID: 128502
		public BehaviorButtonData SrcBehaviorButtonData;

		// Token: 0x0401F5F7 RID: 128503
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F5F8 RID: 128504
		private bool IsPlayPressSeq;

		// Token: 0x0401F5F9 RID: 128505
		private BattleSkillSwitchInteractItem SwitchInteractItem;
	}
}
