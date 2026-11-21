using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.SkillButtonUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CC9 RID: 19657
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleSkillGamepadItem : BattleSkillItem
	{
		// Token: 0x170061D2 RID: 25042
		// (get) Token: 0x0603122F RID: 201263 RVA: 0x00DB82A7 File Offset: 0x00DB64A7
		public bool IsMainButton
		{
			get
			{
				return this.ButtonAreaType == EGamepadButtonAreaType.Main;
			}
		}

		// Token: 0x170061D3 RID: 25043
		// (get) Token: 0x06031230 RID: 201264 RVA: 0x00DB82B2 File Offset: 0x00DB64B2
		public bool IsSubButton
		{
			get
			{
				return this.ButtonAreaType == EGamepadButtonAreaType.Sub;
			}
		}

		// Token: 0x170061D4 RID: 25044
		// (get) Token: 0x06031231 RID: 201265 RVA: 0x00DB82BD File Offset: 0x00DB64BD
		public bool IsLeftButton
		{
			get
			{
				return this.ButtonAreaType == EGamepadButtonAreaType.Left;
			}
		}

		// Token: 0x06031232 RID: 201266 RVA: 0x00DB82C8 File Offset: 0x00DB64C8
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

		// Token: 0x06031233 RID: 201267 RVA: 0x00DB8394 File Offset: 0x00DB6594
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

		// Token: 0x06031234 RID: 201268 RVA: 0x00DB83F0 File Offset: 0x00DB65F0
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

		// Token: 0x06031235 RID: 201269 RVA: 0x00DB84C0 File Offset: 0x00DB66C0
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

		// Token: 0x06031236 RID: 201270 RVA: 0x00DB853C File Offset: 0x00DB673C
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

		// Token: 0x06031237 RID: 201271 RVA: 0x00DB865D File Offset: 0x00DB685D
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

		// Token: 0x06031238 RID: 201272 RVA: 0x00DB8694 File Offset: 0x00DB6894
		public override void RefreshEnable(bool bForce = false)
		{
			if (this.BehaviorButtonData != null)
			{
				base.SetSkillItemEnable(this.BehaviorButtonData.IsEnable(), bForce);
				return;
			}
			base.RefreshEnable(bForce);
		}

		// Token: 0x06031239 RID: 201273 RVA: 0x00DB86B8 File Offset: 0x00DB68B8
		public override void RefreshSkillCoolDown()
		{
			if (this.SkillButtonData == null)
			{
				base.FinishSkillCoolDown();
				return;
			}
			base.RefreshSkillCoolDown();
		}

		// Token: 0x0603123A RID: 201274 RVA: 0x00DB86D0 File Offset: 0x00DB68D0
		public void PlaySwitchCd()
		{
			this.HideCdText = true;
			SkillButtonUiGamepadDataBase gamepadData = this.GamepadData;
			float num = (float)((gamepadData != null) ? gamepadData.SwitchInteractData.SwitchTime : 0) * (float)TimeUtil.Instance.Millisecond;
			base.PlaySkillTimeDown((double)num, (double)num, null);
		}

		// Token: 0x0603123B RID: 201275 RVA: 0x00DB8714 File Offset: 0x00DB6914
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

		// Token: 0x0603123C RID: 201276 RVA: 0x00DB8870 File Offset: 0x00DB6A70
		[NullableContext(1)]
		protected override bool CheckSkillIconIsTexture(string skillIconPath)
		{
			return this.SkillButtonData != null && base.CheckSkillIconIsTexture(skillIconPath);
		}

		// Token: 0x0603123D RID: 201277 RVA: 0x00DB8883 File Offset: 0x00DB6A83
		public override void RefreshSkillIcon()
		{
			if (this.BehaviorButtonData != null)
			{
				base.SetSkillIcon(this.BehaviorButtonData.GetSkillTexturePath());
				return;
			}
			base.RefreshSkillIcon();
		}

		// Token: 0x0603123E RID: 201278 RVA: 0x00DB88A8 File Offset: 0x00DB6AA8
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

		// Token: 0x0603123F RID: 201279 RVA: 0x00DB8933 File Offset: 0x00DB6B33
		public override void Deactivate()
		{
			base.Deactivate();
			this.IsRefreshOnce = false;
		}

		// Token: 0x06031240 RID: 201280 RVA: 0x00DB8942 File Offset: 0x00DB6B42
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

		// Token: 0x06031241 RID: 201281 RVA: 0x00DB8962 File Offset: 0x00DB6B62
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

		// Token: 0x06031242 RID: 201282 RVA: 0x00DB8999 File Offset: 0x00DB6B99
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

		// Token: 0x06031243 RID: 201283 RVA: 0x00DB89D8 File Offset: 0x00DB6BD8
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

		// Token: 0x06031244 RID: 201284 RVA: 0x00DB8A38 File Offset: 0x00DB6C38
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

		// Token: 0x06031245 RID: 201285 RVA: 0x00DB8AA1 File Offset: 0x00DB6CA1
		private void InitLevelSequencePlayer()
		{
			if (this.LevelSequencePlayer != null)
			{
				return;
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0401A0A9 RID: 106665
		public SkillButtonUiGamepadDataBase GamepadData;

		// Token: 0x0401A0AA RID: 106666
		public EGamepadButtonAreaType ButtonAreaType;

		// Token: 0x0401A0AB RID: 106667
		public bool IsSecondButton;

		// Token: 0x0401A0AC RID: 106668
		[Nullable(1)]
		private string KeyName = string.Empty;

		// Token: 0x0401A0AD RID: 106669
		private bool IsRefreshOnce;

		// Token: 0x0401A0AE RID: 106670
		public BehaviorButtonData BehaviorButtonData;

		// Token: 0x0401A0AF RID: 106671
		public BehaviorButtonData SrcBehaviorButtonData;

		// Token: 0x0401A0B0 RID: 106672
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A0B1 RID: 106673
		private bool IsPlayPressSeq;

		// Token: 0x0401A0B2 RID: 106674
		private BattleSkillSwitchInteractItem SwitchInteractItem;
	}
}
