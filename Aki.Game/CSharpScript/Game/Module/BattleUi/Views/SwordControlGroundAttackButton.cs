using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Core.Common;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E21 RID: 20001
	[NullableContext(2)]
	[Nullable(0)]
	public class SwordControlGroundAttackButton : UiPanelBase
	{
		// Token: 0x17006243 RID: 25155
		// (get) Token: 0x060324FA RID: 206074 RVA: 0x00E1AADD File Offset: 0x00E18CDD
		private static CSharpScript.Game.Input.EInputAction AttackAction
		{
			get
			{
				return CSharpScript.Game.Input.EInputAction.攻击;
			}
		}

		// Token: 0x17006244 RID: 25156
		// (get) Token: 0x060324FB RID: 206075 RVA: 0x00E1AAE4 File Offset: 0x00E18CE4
		[Nullable(1)]
		private static string AttackActionName
		{
			[NullableContext(1)]
			get
			{
				return SwordControlGroundAttackButton.AttackAction.Name;
			}
		}

		// Token: 0x060324FC RID: 206076 RVA: 0x00E1AAF0 File Offset: 0x00E18CF0
		public SwordControlGroundAttackButton()
		{
			base.SkipDestroyActor = true;
		}

		// Token: 0x060324FD RID: 206077 RVA: 0x00E1AB00 File Offset: 0x00E18D00
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060324FE RID: 206078 RVA: 0x00E1ACDC File Offset: 0x00E18EDC
		protected override void OnStart()
		{
			this.SkillButton = base.GetButton(5);
			this.ClickEffect = new BattleUiNiagaraItem(base.GetUiNiagara(10));
			this.SkillNameText = base.GetText(11);
			UUIText skillNameText = this.SkillNameText;
			if (skillNameText != null)
			{
				skillNameText.SetUIActive(false);
			}
			UUINiagara uiNiagara = base.GetUiNiagara(6);
			if (uiNiagara != null)
			{
				uiNiagara.SetNiagaraUIActive(false, false);
			}
			UUINiagara uiNiagara2 = base.GetUiNiagara(7);
			if (uiNiagara2 != null)
			{
				uiNiagara2.SetNiagaraUIActive(false, true);
			}
			UUINiagara uiNiagara3 = base.GetUiNiagara(12);
			if (uiNiagara3 != null)
			{
				uiNiagara3.SetNiagaraUIActive(false, true);
			}
			this.BindButtonEvent();
			this.BindInputAction();
			this.SetInteractive(this.IsInteractive, true);
		}

		// Token: 0x060324FF RID: 206079 RVA: 0x00E1AD7F File Offset: 0x00E18F7F
		protected override void OnBeforeDestroy()
		{
			this.ReleaseAttackInput();
			this.UnBindInputAction();
			this.UnBindButtonEvent();
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect != null)
			{
				clickEffect.Stop();
			}
			this.ClickEffect = null;
			this.SkillButton = null;
			this.SkillNameText = null;
		}

		// Token: 0x06032500 RID: 206080 RVA: 0x00E1ADB9 File Offset: 0x00E18FB9
		public void SetInteractive(bool interactive, bool force = false)
		{
			if (this.IsInteractive == interactive && !force)
			{
				return;
			}
			this.IsInteractive = interactive;
			UUIButtonComponent skillButton = this.SkillButton;
			if (skillButton != null)
			{
				skillButton.SetSelfInteractive(interactive);
			}
			if (!interactive)
			{
				this.ReleaseAttackInput();
			}
		}

		// Token: 0x06032501 RID: 206081 RVA: 0x00E1ADEC File Offset: 0x00E18FEC
		private void BindButtonEvent()
		{
			UUIButtonComponent skillButton = this.SkillButton;
			if (skillButton != null)
			{
				skillButton.OnPointDownCallBack.Bind(new Action(this.OnPressButton));
			}
			UUIButtonComponent skillButton2 = this.SkillButton;
			if (skillButton2 != null)
			{
				skillButton2.OnPointUpCallBack.Bind(new Action(this.OnReleaseButton));
			}
			UUIButtonComponent skillButton3 = this.SkillButton;
			if (skillButton3 == null)
			{
				return;
			}
			skillButton3.OnPointCancelCallBack.Bind(new Action(this.OnReleaseButton));
		}

		// Token: 0x06032502 RID: 206082 RVA: 0x00E1AE60 File Offset: 0x00E19060
		private void UnBindButtonEvent()
		{
			UUIButtonComponent skillButton = this.SkillButton;
			if (skillButton != null)
			{
				skillButton.OnPointDownCallBack.Unbind();
			}
			UUIButtonComponent skillButton2 = this.SkillButton;
			if (skillButton2 != null)
			{
				skillButton2.OnPointUpCallBack.Unbind();
			}
			UUIButtonComponent skillButton3 = this.SkillButton;
			if (skillButton3 == null)
			{
				return;
			}
			skillButton3.OnPointCancelCallBack.Unbind();
		}

		// Token: 0x06032503 RID: 206083 RVA: 0x00E1AEAE File Offset: 0x00E190AE
		private void BindInputAction()
		{
			if (this.HasBindInputAction || Info.Instance.OperationType == EOperationType.Pad)
			{
				return;
			}
			InputDistributeController.Instance.BindAction(SwordControlGroundAttackButton.AttackActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			this.HasBindInputAction = true;
		}

		// Token: 0x06032504 RID: 206084 RVA: 0x00E1AEE8 File Offset: 0x00E190E8
		private void UnBindInputAction()
		{
			if (!this.HasBindInputAction)
			{
				return;
			}
			InputDistributeController.Instance.UnBindAction(SwordControlGroundAttackButton.AttackActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			this.HasBindInputAction = false;
		}

		// Token: 0x06032505 RID: 206085 RVA: 0x00E1AF15 File Offset: 0x00E19115
		[NullableContext(1)]
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (this.HasPressedAttackInput || actionName != SwordControlGroundAttackButton.AttackActionName || actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			if (!this.CanPlayClickEffect())
			{
				return;
			}
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect == null)
			{
				return;
			}
			clickEffect.Play();
		}

		// Token: 0x06032506 RID: 206086 RVA: 0x00E1AF4C File Offset: 0x00E1914C
		private void OnPressButton()
		{
			if (!this.CanPlayClickEffect() || this.HasPressedAttackInput)
			{
				return;
			}
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect != null)
			{
				clickEffect.Play();
			}
			this.HasPressedAttackInput = true;
			if (!InputDistributeController.Instance.InputAction(SwordControlGroundAttackButton.AttackActionName, true) && Info.Instance.OperationType != EOperationType.Pad)
			{
				InputController.Instance.InputAction(SwordControlGroundAttackButton.AttackAction, EInputState.Press);
			}
		}

		// Token: 0x06032507 RID: 206087 RVA: 0x00E1AFB1 File Offset: 0x00E191B1
		private void OnReleaseButton()
		{
			this.ReleaseAttackInput();
		}

		// Token: 0x06032508 RID: 206088 RVA: 0x00E1AFB9 File Offset: 0x00E191B9
		private bool CanPlayClickEffect()
		{
			if (this.IsInteractive && base.IsUiActiveInHierarchy())
			{
				BattleInputModel instance = BattleInputModel.Instance;
				return instance == null || instance.GetInputEnable(SwordControlGroundAttackButton.AttackAction);
			}
			return false;
		}

		// Token: 0x06032509 RID: 206089 RVA: 0x00E1AFE4 File Offset: 0x00E191E4
		private void ReleaseAttackInput()
		{
			if (!this.HasPressedAttackInput)
			{
				return;
			}
			this.HasPressedAttackInput = false;
			if (!InputDistributeController.Instance.InputAction(SwordControlGroundAttackButton.AttackActionName, false) && Info.Instance.OperationType != EOperationType.Pad)
			{
				InputController.Instance.InputAction(SwordControlGroundAttackButton.AttackAction, EInputState.Release);
			}
		}

		// Token: 0x0603250A RID: 206090 RVA: 0x00E1B030 File Offset: 0x00E19230
		public void SetSkillNameText(string textStringId)
		{
			if (string.IsNullOrEmpty(textStringId))
			{
				UUIText skillNameText = this.SkillNameText;
				if (skillNameText == null)
				{
					return;
				}
				skillNameText.SetUIActive(false);
				return;
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(this.SkillNameText, textStringId, Array.Empty<object>());
				UUIText skillNameText2 = this.SkillNameText;
				if (skillNameText2 == null)
				{
					return;
				}
				skillNameText2.SetUIActive(true);
				return;
			}
		}

		// Token: 0x0401AAB4 RID: 109236
		private UUIButtonComponent SkillButton;

		// Token: 0x0401AAB5 RID: 109237
		private BattleUiNiagaraItem ClickEffect;

		// Token: 0x0401AAB6 RID: 109238
		private UUIText SkillNameText;

		// Token: 0x0401AAB7 RID: 109239
		private bool IsInteractive;

		// Token: 0x0401AAB8 RID: 109240
		private bool HasBindInputAction;

		// Token: 0x0401AAB9 RID: 109241
		private bool HasPressedAttackInput;

		// Token: 0x0200ABCA RID: 43978
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040352A0 RID: 217760
			CoolDownItem,
			// Token: 0x040352A1 RID: 217761
			CoolDownBarSprite,
			// Token: 0x040352A2 RID: 217762
			CoolDownText,
			// Token: 0x040352A3 RID: 217763
			SkillSprite,
			// Token: 0x040352A4 RID: 217764
			SkillTexture,
			// Token: 0x040352A5 RID: 217765
			SkillButton,
			// Token: 0x040352A6 RID: 217766
			CdCompletedNiagara,
			// Token: 0x040352A7 RID: 217767
			DynamicEffectNiagara,
			// Token: 0x040352A8 RID: 217768
			ExtraContainer,
			// Token: 0x040352A9 RID: 217769
			ExploreSkillEquip,
			// Token: 0x040352AA RID: 217770
			ClickEffectNiagara,
			// Token: 0x040352AB RID: 217771
			SkillNameText,
			// Token: 0x040352AC RID: 217772
			LinkExplosionNiagara
		}
	}
}
