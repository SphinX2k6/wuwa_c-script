using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200482E RID: 18478
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class InteractionLongPressButton : UiPanelBase
	{
		// Token: 0x0602E70F RID: 190223
		protected abstract void ResolveComponents();

		// Token: 0x0602E710 RID: 190224
		protected abstract void SetProgress(float progress);

		// Token: 0x0602E711 RID: 190225 RVA: 0x00CF59FB File Offset: 0x00CF3BFB
		protected virtual void RefreshKeyItem(string actionName)
		{
		}

		// Token: 0x0602E712 RID: 190226 RVA: 0x00CF59FD File Offset: 0x00CF3BFD
		protected virtual void HideKeyItem()
		{
		}

		// Token: 0x0602E713 RID: 190227 RVA: 0x00CF59FF File Offset: 0x00CF3BFF
		protected virtual void PlayEnterSequence()
		{
		}

		// Token: 0x0602E714 RID: 190228 RVA: 0x00CF5A01 File Offset: 0x00CF3C01
		protected override void OnStart()
		{
			this.ResolveComponents();
			this.SetProgress(0f);
			this.SetActive(false);
		}

		// Token: 0x0602E715 RID: 190229 RVA: 0x00CF5A1C File Offset: 0x00CF3C1C
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

		// Token: 0x0602E716 RID: 190230 RVA: 0x00CF5A80 File Offset: 0x00CF3C80
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

		// Token: 0x0602E717 RID: 190231 RVA: 0x00CF5AF4 File Offset: 0x00CF3CF4
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

		// Token: 0x0602E718 RID: 190232 RVA: 0x00CF5B62 File Offset: 0x00CF3D62
		public void BindPress(Action<bool> callback)
		{
			this.OnPressCallback = callback;
		}

		// Token: 0x0602E719 RID: 190233 RVA: 0x00CF5B6C File Offset: 0x00CF3D6C
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

		// Token: 0x0602E71A RID: 190234 RVA: 0x00CF5BF7 File Offset: 0x00CF3DF7
		private void OnInteractionLongPressProgressChange(float progress)
		{
			this.SetProgress(progress);
		}

		// Token: 0x0602E71B RID: 190235 RVA: 0x00CF5C00 File Offset: 0x00CF3E00
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

		// Token: 0x0602E71C RID: 190236 RVA: 0x00CF5C1E File Offset: 0x00CF3E1E
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

		// Token: 0x04018B9D RID: 101277
		private UUIButtonComponent PressButton;

		// Token: 0x04018B9E RID: 101278
		private Action<bool> OnPressCallback;

		// Token: 0x04018B9F RID: 101279
		private Entity BoundEntity;
	}
}
