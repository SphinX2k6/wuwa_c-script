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
	// Token: 0x02005D00 RID: 23808
	[NullableContext(2)]
	[Nullable(0)]
	public class BehaviorButton : BattleChildView
	{
		// Token: 0x0603C4C7 RID: 246983 RVA: 0x00E7110C File Offset: 0x00E6F30C
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

		// Token: 0x0603C4C8 RID: 246984 RVA: 0x00E711E0 File Offset: 0x00E6F3E0
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

		// Token: 0x0603C4C9 RID: 246985 RVA: 0x00E71264 File Offset: 0x00E6F464
		protected override UniTask InitializeAsync(object param = null)
		{
			BehaviorButton.<InitializeAsync>d__16 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<BehaviorButton.<InitializeAsync>d__16>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C4CA RID: 246986 RVA: 0x00E712A8 File Offset: 0x00E6F4A8
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

		// Token: 0x0603C4CB RID: 246987 RVA: 0x00E71335 File Offset: 0x00E6F535
		private void AddEvents()
		{
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointDownCallBack.Bind(new Action(this.OnPressBehaviorButton));
			button.OnPointUpCallBack.Bind(new Action(this.OnReleaseBehaviorButton));
		}

		// Token: 0x0603C4CC RID: 246988 RVA: 0x00E7136B File Offset: 0x00E6F56B
		private void RemoveEvents()
		{
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointDownCallBack.Unbind();
			button.OnPointUpCallBack.Unbind();
		}

		// Token: 0x0603C4CD RID: 246989 RVA: 0x00E71389 File Offset: 0x00E6F589
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

		// Token: 0x0603C4CE RID: 246990 RVA: 0x00E713C8 File Offset: 0x00E6F5C8
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

		// Token: 0x0603C4CF RID: 246991 RVA: 0x00E71434 File Offset: 0x00E6F634
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

		// Token: 0x0603C4D0 RID: 246992 RVA: 0x00E7148F File Offset: 0x00E6F68F
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

		// Token: 0x0603C4D1 RID: 246993 RVA: 0x00E714B7 File Offset: 0x00E6F6B7
		public void RefreshAll()
		{
			if (this.BehaviorButtonData == null)
			{
				return;
			}
			this.Refresh(this.BehaviorButtonData);
		}

		// Token: 0x0603C4D2 RID: 246994 RVA: 0x00E714CE File Offset: 0x00E6F6CE
		private void InputAction(CSharpScript.Game.Input.EInputAction inputAction, EInputState inputState)
		{
			this.OnInputAction();
			InputController.Instance.InputAction(inputAction, inputState);
		}

		// Token: 0x0603C4D3 RID: 246995 RVA: 0x00E714E2 File Offset: 0x00E6F6E2
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

		// Token: 0x0603C4D4 RID: 246996 RVA: 0x00E71504 File Offset: 0x00E6F704
		public void RefreshSkillIcon()
		{
			if (this.BehaviorButtonData == null)
			{
				return;
			}
			string skillTexturePath = this.BehaviorButtonData.GetSkillTexturePath();
			this.SetSkillIcon(skillTexturePath);
		}

		// Token: 0x0603C4D5 RID: 246997 RVA: 0x00E71530 File Offset: 0x00E6F730
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

		// Token: 0x0603C4D6 RID: 246998 RVA: 0x00E715DC File Offset: 0x00E6F7DC
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

		// Token: 0x0603C4D7 RID: 246999 RVA: 0x00E71641 File Offset: 0x00E6F841
		public bool IsVisible()
		{
			return this.BehaviorButtonData != null && (this.BehaviorType != EBehaviorType.LockTarget || FunctionModel.Instance.IsOpen(10031)) && this.BehaviorButtonData.IsVisible();
		}

		// Token: 0x0603C4D8 RID: 247000 RVA: 0x00E71675 File Offset: 0x00E6F875
		public void RefreshEnable(bool bForce)
		{
		}

		// Token: 0x0603C4D9 RID: 247001 RVA: 0x00E71678 File Offset: 0x00E6F878
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

		// Token: 0x0603C4DA RID: 247002 RVA: 0x00E7174E File Offset: 0x00E6F94E
		[NullableContext(1)]
		public void SetOnVisibleChangedCallback(Action callback)
		{
			this.OnVisibleChangedCallback = callback;
		}

		// Token: 0x0603C4DB RID: 247003 RVA: 0x00E71758 File Offset: 0x00E6F958
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

		// Token: 0x0603C4DC RID: 247004 RVA: 0x00E71780 File Offset: 0x00E6F980
		protected SkillButtonEffect? GetDynamicEffectConfig()
		{
			if (this.BehaviorButtonData == null)
			{
				return null;
			}
			return this.BehaviorButtonData.GetDynamicEffectConfig();
		}

		// Token: 0x0603C4DD RID: 247005 RVA: 0x00E717AA File Offset: 0x00E6F9AA
		public InputMultiKeyItem GetKeyItem()
		{
			return this.KeyItem;
		}

		// Token: 0x0603C4DE RID: 247006 RVA: 0x00E717B4 File Offset: 0x00E6F9B4
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

		// Token: 0x0603C4DF RID: 247007 RVA: 0x00E7181F File Offset: 0x00E6FA1F
		public string GetActionName()
		{
			return this.KeyActionName;
		}

		// Token: 0x0401F69F RID: 128671
		private BehaviorButtonData BehaviorButtonData;

		// Token: 0x0401F6A0 RID: 128672
		[Nullable(1)]
		private string SkillIconPath = string.Empty;

		// Token: 0x0401F6A1 RID: 128673
		private int? LoadIconHandleId;

		// Token: 0x0401F6A2 RID: 128674
		private UUISpriteTransition SpriteTransition;

		// Token: 0x0401F6A3 RID: 128675
		protected string KeyActionName;

		// Token: 0x0401F6A4 RID: 128676
		public EBehaviorType BehaviorType = EBehaviorType.Aim;

		// Token: 0x0401F6A5 RID: 128677
		private InputMultiKeyItem KeyItem;

		// Token: 0x0401F6A6 RID: 128678
		private BattleUiNiagaraItem ClickEffect;

		// Token: 0x0401F6A7 RID: 128679
		private ULGUIPlayTweenComponent AlphaTweenComp;

		// Token: 0x0401F6A8 RID: 128680
		private float TargetAlpha = 1f;

		// Token: 0x0401F6A9 RID: 128681
		private float BaseAlpha = 1f;

		// Token: 0x0401F6AA RID: 128682
		private Action OnVisibleChangedCallback;

		// Token: 0x0401F6AB RID: 128683
		private BattleSkillItemDynamicEffect DynamicEffect;

		// Token: 0x0200BF74 RID: 49012
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039BC6 RID: 236486
			BehaviorButton,
			// Token: 0x04039BC7 RID: 236487
			IconSprite,
			// Token: 0x04039BC8 RID: 236488
			ClickEffectNiagara,
			// Token: 0x04039BC9 RID: 236489
			DynamicEffectNiagara,
			// Token: 0x04039BCA RID: 236490
			KeyItem
		}
	}
}
