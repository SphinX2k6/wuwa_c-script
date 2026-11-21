using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Backpack
{
	// Token: 0x0200579B RID: 22427
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlBackpackHotKeyProxy
	{
		// Token: 0x060375A7 RID: 226727 RVA: 0x00F75EA8 File Offset: 0x00F740A8
		public DangoBrawlBackpackHotKeyProxy(UUIItem pnlHotKey)
		{
			this.PnlHotKey = pnlHotKey;
		}

		// Token: 0x060375A8 RID: 226728 RVA: 0x00F75EB7 File Offset: 0x00F740B7
		public void Start()
		{
			this.BindEvents();
			this.TickHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
		}

		// Token: 0x060375A9 RID: 226729 RVA: 0x00F75EE8 File Offset: 0x00F740E8
		public void Destroy()
		{
			this.UnBindEvents();
			this.ClearTickHandle();
		}

		// Token: 0x060375AA RID: 226730 RVA: 0x00F75EF6 File Offset: 0x00F740F6
		private void BindEvents()
		{
		}

		// Token: 0x060375AB RID: 226731 RVA: 0x00F75EF8 File Offset: 0x00F740F8
		private void UnBindEvents()
		{
		}

		// Token: 0x060375AC RID: 226732 RVA: 0x00F75EFA File Offset: 0x00F740FA
		private void ClearTickHandle()
		{
			if (this.TickHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TickHandle);
				this.TickHandle = null;
			}
		}

		// Token: 0x060375AD RID: 226733 RVA: 0x00F75F1C File Offset: 0x00F7411C
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

		// Token: 0x060375AE RID: 226734 RVA: 0x00F75F90 File Offset: 0x00F74190
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

		// Token: 0x0401D3AE RID: 119726
		private readonly UUIItem PnlHotKey;

		// Token: 0x0401D3AF RID: 119727
		private TimerHandle TickHandle;
	}
}
