using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02005856 RID: 22614
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class InteractionLongPressButton : UiPanelBase
	{
		// Token: 0x060397F2 RID: 235506
		protected abstract void ResolveComponents();

		// Token: 0x060397F3 RID: 235507
		protected abstract void SetProgress(float progress);

		// Token: 0x060397F4 RID: 235508 RVA: 0x00DA6CD3 File Offset: 0x00DA4ED3
		protected virtual void RefreshKeyItem(string actionName)
		{
		}

		// Token: 0x060397F5 RID: 235509 RVA: 0x00DA6CD5 File Offset: 0x00DA4ED5
		protected virtual void HideKeyItem()
		{
		}

		// Token: 0x060397F6 RID: 235510 RVA: 0x00DA6CD7 File Offset: 0x00DA4ED7
		protected virtual void PlayEnterSequence()
		{
		}

		// Token: 0x060397F7 RID: 235511 RVA: 0x00DA6CD9 File Offset: 0x00DA4ED9
		protected override void OnStart()
		{
			this.ResolveComponents();
			this.SetProgress(0f);
			this.SetActive(false);
		}

		// Token: 0x060397F8 RID: 235512 RVA: 0x00DA6CF4 File Offset: 0x00DA4EF4
		protected override void OnBeforeDestroy()
		{
			UUIButtonComponent pressButton = this.PressButton;
			if (pressButton != null)
			{
				pressButton.OnPointDownCallBack.Unbind();
			}
			UUIButtonComponent pressButton2 = this.PressButton;
			if (pressButton2 != null)
			{
				pressButton2.OnPointUpCallBack.Unbind();
			}
			UUIButtonComponent pressButton3 = this.PressButton;
			if (pressButton3 != null)
			{
				pressButton3.OnPointExitCallBack.Unbind();
			}
			this.PressButton = null;
			this.OnPressCallback = null;
			this.UnbindEntity();
		}

		// Token: 0x060397F9 RID: 235513 RVA: 0x00DA6D58 File Offset: 0x00DA4F58
		public void BindEntity(Entity entity, string actionName = null)
		{
			if (this.BoundEntity == entity)
			{
				return;
			}
			this.UnbindEntity();
			if (entity == null || !entity.Valid)
			{
				return;
			}
			this.BoundEntity = entity;
			EventSystem.Instance.AddWithTarget<float>(entity, EEventName.OnInteractionLongPressProgressChange, new Action<float>(this.OnInteractionLongPressProgressChange));
			this.SetProgress(0f);
			this.RefreshKeyItem(actionName);
			this.SetActive(true);
			this.PlayEnterSequence();
		}

		// Token: 0x060397FA RID: 235514 RVA: 0x00DA6DCC File Offset: 0x00DA4FCC
		public void UnbindEntity()
		{
			if (this.BoundEntity != null)
			{
				if (EventSystem.Instance.HasWithTarget<float>(this.BoundEntity, EEventName.OnInteractionLongPressProgressChange, new Action<float>(this.OnInteractionLongPressProgressChange)))
				{
					EventSystem.Instance.RemoveWithTarget<float>(this.BoundEntity, EEventName.OnInteractionLongPressProgressChange, new Action<float>(this.OnInteractionLongPressProgressChange));
				}
				this.BoundEntity = null;
			}
			this.HideKeyItem();
			this.SetActive(false);
		}

		// Token: 0x060397FB RID: 235515 RVA: 0x00DA6E3A File Offset: 0x00DA503A
		public void BindPress(Action<bool> callback)
		{
			this.OnPressCallback = callback;
		}

		// Token: 0x060397FC RID: 235516 RVA: 0x00DA6E44 File Offset: 0x00DA5044
		protected void SetupPressButton(UUIButtonComponent button)
		{
			this.PressButton = button;
			UUIButtonComponent pressButton = this.PressButton;
			if (pressButton != null)
			{
				pressButton.SetSelfInteractive(true);
			}
			UUIButtonComponent pressButton2 = this.PressButton;
			if (pressButton2 != null)
			{
				pressButton2.OnPointDownCallBack.Bind(new Action(this.OnButtonPointDown));
			}
			UUIButtonComponent pressButton3 = this.PressButton;
			if (pressButton3 != null)
			{
				pressButton3.OnPointUpCallBack.Bind(new Action(this.OnButtonPointUp));
			}
			UUIButtonComponent pressButton4 = this.PressButton;
			if (pressButton4 == null)
			{
				return;
			}
			pressButton4.OnPointExitCallBack.Bind(new Action(this.OnButtonPointUp));
		}

		// Token: 0x060397FD RID: 235517 RVA: 0x00DA6ECF File Offset: 0x00DA50CF
		private void OnInteractionLongPressProgressChange(float progress)
		{
			this.SetProgress(progress);
		}

		// Token: 0x060397FE RID: 235518 RVA: 0x00DA6ED8 File Offset: 0x00DA50D8
		private void OnButtonPointDown()
		{
			this.SetProgress(0f);
			Action<bool> onPressCallback = this.OnPressCallback;
			if (onPressCallback == null)
			{
				return;
			}
			onPressCallback(true);
		}

		// Token: 0x060397FF RID: 235519 RVA: 0x00DA6EF6 File Offset: 0x00DA50F6
		private void OnButtonPointUp()
		{
			this.SetProgress(0f);
			Action<bool> onPressCallback = this.OnPressCallback;
			if (onPressCallback == null)
			{
				return;
			}
			onPressCallback(false);
		}

		// Token: 0x0401E100 RID: 123136
		private UUIButtonComponent PressButton;

		// Token: 0x0401E101 RID: 123137
		private Action<bool> OnPressCallback;

		// Token: 0x0401E102 RID: 123138
		private Entity BoundEntity;
	}
}
