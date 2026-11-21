using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.SkillButtonUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CE2 RID: 19682
	[NullableContext(2)]
	[Nullable(0)]
	public class BehaviorButton : BattleChildView
	{
		// Token: 0x06031420 RID: 201760 RVA: 0x00DC1774 File Offset: 0x00DBF974
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
			if (!Info.Instance.IsInTouch())
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
			}
		}

		// Token: 0x06031421 RID: 201761 RVA: 0x00DC1848 File Offset: 0x00DBFA48
		public override void Initialize(object paramsObj = null)
		{
			base.Initialize(paramsObj);
			if (paramsObj is EBehaviorType)
			{
				EBehaviorType behaviorType = (EBehaviorType)paramsObj;
				this.BehaviorType = behaviorType;
				this.AddEvents();
				UUISprite sprite = base.GetSprite(1);
				this.SpriteTransition = (sprite.GetOwner().GetComponentByClass(UUISpriteTransition.StaticClass()) as UUISpriteTransition);
				this.ClickEffect = new BattleUiNiagaraItem(base.GetUiNiagara(2));
				this.DynamicEffect = new BattleSkillItemDynamicEffect(base.GetUiNiagara(3));
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06031422 RID: 201762 RVA: 0x00DC18CC File Offset: 0x00DBFACC
		protected override UniTask InitializeAsync(object param = null)
		{
			BehaviorButton.<InitializeAsync>d__16 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<BehaviorButton.<InitializeAsync>d__16>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031423 RID: 201763 RVA: 0x00DC1910 File Offset: 0x00DBFB10
		protected override void OnBeforeDestroy()
		{
			this.BehaviorButtonData = null;
			this.KeyItem = null;
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect != null)
			{
				clickEffect.Stop();
			}
			this.ClickEffect = null;
			if (this.LoadIconHandleId != null)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadIconHandleId.Value);
				this.LoadIconHandleId = null;
			}
			BattleSkillItemDynamicEffect dynamicEffect = this.DynamicEffect;
			if (dynamicEffect != null)
			{
				dynamicEffect.Reset();
			}
			this.DynamicEffect = null;
			this.RemoveEvents();
			this.AlphaTweenComp = null;
			this.OnVisibleChangedCallback = null;
		}

		// Token: 0x06031424 RID: 201764 RVA: 0x00DC199D File Offset: 0x00DBFB9D
		private void AddEvents()
		{
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointDownCallBack.Bind(new Action(this.OnPressBehaviorButton));
			button.OnPointUpCallBack.Bind(new Action(this.OnReleaseBehaviorButton));
		}

		// Token: 0x06031425 RID: 201765 RVA: 0x00DC19D3 File Offset: 0x00DBFBD3
		private void RemoveEvents()
		{
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointDownCallBack.Unbind();
			button.OnPointUpCallBack.Unbind();
		}

		// Token: 0x06031426 RID: 201766 RVA: 0x00DC19F1 File Offset: 0x00DBFBF1
		public void UpdateAlpha()
		{
			this.BaseAlpha = this.RootItem.GetAlpha();
			if (this.BaseAlpha > this.TargetAlpha)
			{
				this.RootItem.SetAlpha(this.TargetAlpha);
				return;
			}
			this.TargetAlpha = this.BaseAlpha;
		}

		// Token: 0x06031427 RID: 201767 RVA: 0x00DC1A30 File Offset: 0x00DBFC30
		private void OnPressBehaviorButton()
		{
			if (this.TargetAlpha == 0f)
			{
				return;
			}
			BehaviorButtonData behaviorButtonData = this.BehaviorButtonData;
			CSharpScript.Game.Input.EInputAction? einputAction = (behaviorButtonData != null) ? new CSharpScript.Game.Input.EInputAction?(behaviorButtonData.InputAction) : null;
			if (einputAction != null)
			{
				this.InputAction(einputAction.Value, EInputState.Press);
			}
			EventSystem.Instance.Emit<bool, EBehaviorType>(EEventName.OnPressOrReleaseBehaviorButton, true, this.BehaviorType);
		}

		// Token: 0x06031428 RID: 201768 RVA: 0x00DC1A9C File Offset: 0x00DBFC9C
		private void OnReleaseBehaviorButton()
		{
			BehaviorButtonData behaviorButtonData = this.BehaviorButtonData;
			CSharpScript.Game.Input.EInputAction? einputAction = (behaviorButtonData != null) ? new CSharpScript.Game.Input.EInputAction?(behaviorButtonData.InputAction) : null;
			if (einputAction != null)
			{
				this.InputAction(einputAction.Value, EInputState.Release);
			}
			EventSystem.Instance.Emit<bool, EBehaviorType>(EEventName.OnPressOrReleaseBehaviorButton, false, this.BehaviorType);
		}

		// Token: 0x06031429 RID: 201769 RVA: 0x00DC1AF7 File Offset: 0x00DBFCF7
		[NullableContext(1)]
		public void Refresh(BehaviorButtonData behaviorButtonData)
		{
			this.BehaviorButtonData = behaviorButtonData;
			this.RefreshVisible();
			this.RefreshEnable(true);
			this.RefreshSkillIcon();
			this.RefreshDynamicEffect();
			this.RefreshKey();
		}

		// Token: 0x0603142A RID: 201770 RVA: 0x00DC1B1F File Offset: 0x00DBFD1F
		public void RefreshAll()
		{
			if (this.BehaviorButtonData == null)
			{
				return;
			}
			this.Refresh(this.BehaviorButtonData);
		}

		// Token: 0x0603142B RID: 201771 RVA: 0x00DC1B36 File Offset: 0x00DBFD36
		private void InputAction(CSharpScript.Game.Input.EInputAction inputAction, EInputState inputState)
		{
			this.OnInputAction();
			InputController.Instance.InputAction(inputAction, inputState);
		}

		// Token: 0x0603142C RID: 201772 RVA: 0x00DC1B4A File Offset: 0x00DBFD4A
		public void OnInputAction()
		{
			if (this.TargetAlpha == 0f)
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

		// Token: 0x0603142D RID: 201773 RVA: 0x00DC1B6C File Offset: 0x00DBFD6C
		public void RefreshSkillIcon()
		{
			if (this.BehaviorButtonData == null)
			{
				return;
			}
			string skillTexturePath = this.BehaviorButtonData.GetSkillTexturePath();
			this.SetSkillIcon(skillTexturePath);
		}

		// Token: 0x0603142E RID: 201774 RVA: 0x00DC1B98 File Offset: 0x00DBFD98
		[NullableContext(1)]
		private void SetSkillIcon(string skillIconPath)
		{
			if (string.IsNullOrEmpty(skillIconPath))
			{
				return;
			}
			if (this.SkillIconPath == skillIconPath)
			{
				return;
			}
			if (this.LoadIconHandleId != null)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadIconHandleId.Value);
			}
			UUISprite skillSprite = base.GetSprite(1);
			bool loading = true;
			this.LoadIconHandleId = new int?(ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(skillIconPath, delegate([Nullable(2)] ULGUISpriteData_BaseObject skillIconSprite, string _)
			{
				loading = false;
				this.LoadIconHandleId = null;
				if (skillSprite == null)
				{
					return;
				}
				if (skillIconSprite == null)
				{
					return;
				}
				skillSprite.SetSprite(skillIconSprite, false);
				if (!skillSprite.bIsUIActive)
				{
					skillSprite.SetUIActive(true);
				}
				if (this.SpriteTransition != null)
				{
					this.SpriteTransition.SetAllTransitionSprite(skillIconSprite);
				}
			}, 100, "js_undefined"));
			this.SkillIconPath = skillIconPath;
			if (!loading)
			{
				this.LoadIconHandleId = null;
			}
		}

		// Token: 0x0603142F RID: 201775 RVA: 0x00DC1C44 File Offset: 0x00DBFE44
		public void RefreshVisible()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null || !rootItem.IsValid())
			{
				return;
			}
			bool flag = this.IsVisible();
			if (flag == this.RootItem.bIsUIActive)
			{
				return;
			}
			if (flag)
			{
				base.Show(null);
				this.RefreshEnable(true);
			}
			else
			{
				base.Hide(null);
			}
			Action onVisibleChangedCallback = this.OnVisibleChangedCallback;
			if (onVisibleChangedCallback == null)
			{
				return;
			}
			onVisibleChangedCallback();
		}

		// Token: 0x06031430 RID: 201776 RVA: 0x00DC1CA9 File Offset: 0x00DBFEA9
		public bool IsVisible()
		{
			return this.BehaviorButtonData != null && (this.BehaviorType != EBehaviorType.LockTarget || FunctionModel.Instance.IsOpen(10031)) && this.BehaviorButtonData.IsVisible();
		}

		// Token: 0x06031431 RID: 201777 RVA: 0x00DC1CDD File Offset: 0x00DBFEDD
		public void RefreshEnable(bool bForce)
		{
		}

		// Token: 0x06031432 RID: 201778 RVA: 0x00DC1CE0 File Offset: 0x00DBFEE0
		public void SetVisibleByExploreMode(bool visible, bool anim = false)
		{
			bool raycastTarget = false;
			if (visible)
			{
				this.TargetAlpha = this.BaseAlpha;
				raycastTarget = true;
			}
			else
			{
				this.TargetAlpha = 0f;
			}
			if (this.RootItem == null)
			{
				return;
			}
			this.RootItem.SetRaycastTarget(raycastTarget);
			if (!anim)
			{
				if (this.AlphaTweenComp != null)
				{
					this.AlphaTweenComp.Stop();
				}
				this.RootItem.SetAlpha(this.TargetAlpha);
				return;
			}
			if (this.AlphaTweenComp == null)
			{
				this.AlphaTweenComp = (this.RootActor.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			}
			else
			{
				this.AlphaTweenComp.Stop();
			}
			ULGUIPlayTween_Float ulguiplayTween_Float = this.AlphaTweenComp.GetPlayTween() as ULGUIPlayTween_Float;
			ulguiplayTween_Float.from = this.RootItem.GetAlpha();
			ulguiplayTween_Float.to = this.TargetAlpha;
			this.AlphaTweenComp.Play();
		}

		// Token: 0x06031433 RID: 201779 RVA: 0x00DC1DB6 File Offset: 0x00DBFFB6
		[NullableContext(1)]
		public void SetOnVisibleChangedCallback(Action callback)
		{
			this.OnVisibleChangedCallback = callback;
		}

		// Token: 0x06031434 RID: 201780 RVA: 0x00DC1DC0 File Offset: 0x00DBFFC0
		public void RefreshDynamicEffect()
		{
			SkillButtonEffect? dynamicEffectConfig = this.GetDynamicEffectConfig();
			BattleSkillItemDynamicEffect dynamicEffect = this.DynamicEffect;
			if (dynamicEffect == null)
			{
				return;
			}
			dynamicEffect.RefreshDynamicEffect(dynamicEffectConfig);
		}

		// Token: 0x06031435 RID: 201781 RVA: 0x00DC1DE8 File Offset: 0x00DBFFE8
		protected SkillButtonEffect? GetDynamicEffectConfig()
		{
			if (this.BehaviorButtonData == null)
			{
				return null;
			}
			return this.BehaviorButtonData.GetDynamicEffectConfig();
		}

		// Token: 0x06031436 RID: 201782 RVA: 0x00DC1E12 File Offset: 0x00DC0012
		public InputMultiKeyItem GetKeyItem()
		{
			return this.KeyItem;
		}

		// Token: 0x06031437 RID: 201783 RVA: 0x00DC1E1C File Offset: 0x00DC001C
		public void RefreshKey()
		{
			if (Info.Instance.OperationType != EOperationType.Desktop)
			{
				return;
			}
			string actionName = this.BehaviorButtonData.GetActionName();
			if (this.KeyActionName == actionName)
			{
				return;
			}
			if (this.KeyItem != null)
			{
				InputActionOrAxisKeyItem actionOrAxisKeyItem = new InputActionOrAxisKeyItem
				{
					ActionOrAxisName = actionName
				};
				this.KeyItem.RefreshByActionOrAxis(actionOrAxisKeyItem, false);
				this.KeyItem.SetActive(true);
			}
			this.KeyActionName = actionName;
		}

		// Token: 0x06031438 RID: 201784 RVA: 0x00DC1E87 File Offset: 0x00DC0087
		public string GetActionName()
		{
			return this.KeyActionName;
		}

		// Token: 0x0401A158 RID: 106840
		private BehaviorButtonData BehaviorButtonData;

		// Token: 0x0401A159 RID: 106841
		[Nullable(1)]
		private string SkillIconPath = string.Empty;

		// Token: 0x0401A15A RID: 106842
		private int? LoadIconHandleId;

		// Token: 0x0401A15B RID: 106843
		private UUISpriteTransition SpriteTransition;

		// Token: 0x0401A15C RID: 106844
		protected string KeyActionName;

		// Token: 0x0401A15D RID: 106845
		public EBehaviorType BehaviorType = EBehaviorType.Aim;

		// Token: 0x0401A15E RID: 106846
		private InputMultiKeyItem KeyItem;

		// Token: 0x0401A15F RID: 106847
		private BattleUiNiagaraItem ClickEffect;

		// Token: 0x0401A160 RID: 106848
		private ULGUIPlayTweenComponent AlphaTweenComp;

		// Token: 0x0401A161 RID: 106849
		private float TargetAlpha = 1f;

		// Token: 0x0401A162 RID: 106850
		private float BaseAlpha = 1f;

		// Token: 0x0401A163 RID: 106851
		private Action OnVisibleChangedCallback;

		// Token: 0x0401A164 RID: 106852
		private BattleSkillItemDynamicEffect DynamicEffect;

		// Token: 0x0200A97A RID: 43386
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034588 RID: 214408
			BehaviorButton,
			// Token: 0x04034589 RID: 214409
			IconSprite,
			// Token: 0x0403458A RID: 214410
			ClickEffectNiagara,
			// Token: 0x0403458B RID: 214411
			DynamicEffectNiagara,
			// Token: 0x0403458C RID: 214412
			KeyItem
		}
	}
}
