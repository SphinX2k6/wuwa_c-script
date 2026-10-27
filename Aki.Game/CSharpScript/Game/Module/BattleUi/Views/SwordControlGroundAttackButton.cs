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
	// Token: 0x02005E3C RID: 24124
	[NullableContext(2)]
	[Nullable(0)]
	public class SwordControlGroundAttackButton : UiPanelBase
	{
		// Token: 0x17008E71 RID: 36465
		// (get) Token: 0x0603D56A RID: 251242 RVA: 0x00EC9571 File Offset: 0x00EC7771
		private static CSharpScript.Game.Input.EInputAction AttackAction
		{
			get
			{
				return CSharpScript.Game.Input.EInputAction.攻击;
			}
		}

		// Token: 0x17008E72 RID: 36466
		// (get) Token: 0x0603D56B RID: 251243 RVA: 0x00EC9578 File Offset: 0x00EC7778
		[Nullable(1)]
		private static string AttackActionName
		{
			[NullableContext(1)]
			get
			{
				return SwordControlGroundAttackButton.AttackAction.Name;
			}
		}

		// Token: 0x0603D56C RID: 251244 RVA: 0x00EC9584 File Offset: 0x00EC7784
		public SwordControlGroundAttackButton()
		{
			base.SkipDestroyActor = true;
		}

		// Token: 0x0603D56D RID: 251245 RVA: 0x00EC9594 File Offset: 0x00EC7794
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

		// Token: 0x0603D56E RID: 251246 RVA: 0x00EC9770 File Offset: 0x00EC7970
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

		// Token: 0x0603D56F RID: 251247 RVA: 0x00EC9813 File Offset: 0x00EC7A13
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

		// Token: 0x0603D570 RID: 251248 RVA: 0x00EC984D File Offset: 0x00EC7A4D
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

		// Token: 0x0603D571 RID: 251249 RVA: 0x00EC9880 File Offset: 0x00EC7A80
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

		// Token: 0x0603D572 RID: 251250 RVA: 0x00EC98F4 File Offset: 0x00EC7AF4
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

		// Token: 0x0603D573 RID: 251251 RVA: 0x00EC9942 File Offset: 0x00EC7B42
		private void BindInputAction()
		{
			if (this.HasBindInputAction || Info.Instance.OperationType == EOperationType.Pad)
			{
				return;
			}
			InputDistributeController.Instance.BindAction(SwordControlGroundAttackButton.AttackActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			this.HasBindInputAction = true;
		}

		// Token: 0x0603D574 RID: 251252 RVA: 0x00EC997C File Offset: 0x00EC7B7C
		private void UnBindInputAction()
		{
			if (!this.HasBindInputAction)
			{
				return;
			}
			InputDistributeController.Instance.UnBindAction(SwordControlGroundAttackButton.AttackActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			this.HasBindInputAction = false;
		}

		// Token: 0x0603D575 RID: 251253 RVA: 0x00EC99A9 File Offset: 0x00EC7BA9
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

		// Token: 0x0603D576 RID: 251254 RVA: 0x00EC99E0 File Offset: 0x00EC7BE0
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

		// Token: 0x0603D577 RID: 251255 RVA: 0x00EC9A45 File Offset: 0x00EC7C45
		private void OnReleaseButton()
		{
			this.ReleaseAttackInput();
		}

		// Token: 0x0603D578 RID: 251256 RVA: 0x00EC9A4D File Offset: 0x00EC7C4D
		private bool CanPlayClickEffect()
		{
			if (this.IsInteractive && base.IsUiActiveInHierarchy())
			{
				BattleInputModel instance = BattleInputModel.Instance;
				return instance == null || instance.GetInputEnable(SwordControlGroundAttackButton.AttackAction);
			}
			return false;
		}

		// Token: 0x0603D579 RID: 251257 RVA: 0x00EC9A78 File Offset: 0x00EC7C78
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

		// Token: 0x0603D57A RID: 251258 RVA: 0x00EC9AC4 File Offset: 0x00EC7CC4
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

		// Token: 0x0401FFED RID: 131053
		private UUIButtonComponent SkillButton;

		// Token: 0x0401FFEE RID: 131054
		private BattleUiNiagaraItem ClickEffect;

		// Token: 0x0401FFEF RID: 131055
		private UUIText SkillNameText;

		// Token: 0x0401FFF0 RID: 131056
		private bool IsInteractive;

		// Token: 0x0401FFF1 RID: 131057
		private bool HasBindInputAction;

		// Token: 0x0401FFF2 RID: 131058
		private bool HasPressedAttackInput;

		// Token: 0x0200C1BB RID: 49595
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A8AE RID: 239790
			CoolDownItem,
			// Token: 0x0403A8AF RID: 239791
			CoolDownBarSprite,
			// Token: 0x0403A8B0 RID: 239792
			CoolDownText,
			// Token: 0x0403A8B1 RID: 239793
			SkillSprite,
			// Token: 0x0403A8B2 RID: 239794
			SkillTexture,
			// Token: 0x0403A8B3 RID: 239795
			SkillButton,
			// Token: 0x0403A8B4 RID: 239796
			CdCompletedNiagara,
			// Token: 0x0403A8B5 RID: 239797
			DynamicEffectNiagara,
			// Token: 0x0403A8B6 RID: 239798
			ExtraContainer,
			// Token: 0x0403A8B7 RID: 239799
			ExploreSkillEquip,
			// Token: 0x0403A8B8 RID: 239800
			ClickEffectNiagara,
			// Token: 0x0403A8B9 RID: 239801
			SkillNameText,
			// Token: 0x0403A8BA RID: 239802
			LinkExplosionNiagara
		}
	}
}
