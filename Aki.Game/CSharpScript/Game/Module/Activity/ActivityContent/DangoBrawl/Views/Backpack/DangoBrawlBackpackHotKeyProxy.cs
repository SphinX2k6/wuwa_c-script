using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Backpack
{
	// Token: 0x0200684B RID: 26699
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlBackpackHotKeyProxy
	{
		// Token: 0x06042A52 RID: 272978 RVA: 0x01034980 File Offset: 0x01032B80
		public DangoBrawlBackpackHotKeyProxy(UUIItem pnlHotKey)
		{
			this.PnlHotKey = pnlHotKey;
		}

		// Token: 0x06042A53 RID: 272979 RVA: 0x0103498F File Offset: 0x01032B8F
		public void Start()
		{
			this.BindEvents();
			this.TickHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
		}

		// Token: 0x06042A54 RID: 272980 RVA: 0x010349C0 File Offset: 0x01032BC0
		public void Destroy()
		{
			this.UnBindEvents();
			this.ClearTickHandle();
		}

		// Token: 0x06042A55 RID: 272981 RVA: 0x010349CE File Offset: 0x01032BCE
		private void BindEvents()
		{
		}

		// Token: 0x06042A56 RID: 272982 RVA: 0x010349D0 File Offset: 0x01032BD0
		private void UnBindEvents()
		{
		}

		// Token: 0x06042A57 RID: 272983 RVA: 0x010349D2 File Offset: 0x01032BD2
		private void ClearTickHandle()
		{
			if (this.TickHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TickHandle);
				this.TickHandle = null;
			}
		}

		// Token: 0x06042A58 RID: 272984 RVA: 0x010349F4 File Offset: 0x01032BF4
		private void OnTick(float delta)
		{
			if (this.PnlHotKey == null || !this.PnlHotKey.IsValid())
			{
				return;
			}
			FVector2D fvector2D = DangoBrawlUtil.PointerToLgui(DangoBrawlBackpackHotKeyProxy.GetCurrentPointerPos());
			UUIItem parentAsUIItem = this.PnlHotKey.GetParentAsUIItem();
			if (parentAsUIItem == null)
			{
				return;
			}
			FVector lguispaceAbsolutePosition = parentAsUIItem.GetLGUISpaceAbsolutePosition();
			this.PnlHotKey.SetUIRelativeLocation(new FVector(fvector2D.X - lguispaceAbsolutePosition.X, fvector2D.Y - lguispaceAbsolutePosition.Y, 0f));
		}

		// Token: 0x06042A59 RID: 272985 RVA: 0x01034A68 File Offset: 0x01032C68
		private static FVector GetCurrentPointerPos()
		{
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
			FVector? fvector = (pointerEventData != null) ? new FVector?(pointerEventData.pointerPosition) : null;
			if (fvector != null)
			{
				FVector valueOrDefault = fvector.GetValueOrDefault();
				return new FVector(valueOrDefault.X, valueOrDefault.Y, 0f);
			}
			TsCharacterController characterController = Global.CharacterController;
			Vector2D vector2D = (characterController != null) ? characterController.GetCursorPosition() : null;
			if (vector2D == null)
			{
				return new FVector(0f, 0f, 0f);
			}
			return new FVector((float)vector2D.X, (float)vector2D.Y, 0f);
		}

		// Token: 0x04022B51 RID: 142161
		private readonly UUIItem PnlHotKey;

		// Token: 0x04022B52 RID: 142162
		private TimerHandle TickHandle;
	}
}
