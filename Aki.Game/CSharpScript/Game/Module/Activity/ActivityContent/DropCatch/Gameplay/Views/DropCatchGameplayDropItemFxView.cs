using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x020066F4 RID: 26356
	public class DropCatchGameplayDropItemFxView : DropCatchGameplayPoolPanelBase
	{
		// Token: 0x06041DB8 RID: 269752 RVA: 0x00FF8888 File Offset: 0x00FF6A88
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUINiagara)),
				new ValueTuple<int, Type>(1, typeof(UUINiagara)),
				new ValueTuple<int, Type>(2, typeof(UUINiagara)),
				new ValueTuple<int, Type>(3, typeof(UUINiagara))
			};
		}

		// Token: 0x06041DB9 RID: 269753 RVA: 0x00FF88F8 File Offset: 0x00FF6AF8
		protected override void OnBeforeShow()
		{
			this.ClearTimer();
			UUINiagara uiNiagara = base.GetUiNiagara(0);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(false);
			}
			UUINiagara uiNiagara2 = base.GetUiNiagara(1);
			if (uiNiagara2 != null)
			{
				uiNiagara2.SetUIActive(false);
			}
			UUINiagara uiNiagara3 = base.GetUiNiagara(2);
			if (uiNiagara3 != null)
			{
				uiNiagara3.SetUIActive(false);
			}
			UUINiagara uiNiagara4 = base.GetUiNiagara(3);
			if (uiNiagara4 != null)
			{
				uiNiagara4.SetUIActive(false);
			}
			IDropCatchGameplayDropItemFxViewParams dropCatchGameplayDropItemFxViewParams = this.OpenParam as IDropCatchGameplayDropItemFxViewParams;
			this.InitPos(dropCatchGameplayDropItemFxViewParams.Pos);
			switch (dropCatchGameplayDropItemFxViewParams.Type)
			{
			case EDropCatchDropItemNiagaraType.Nor:
			{
				UUINiagara uiNiagara5 = base.GetUiNiagara(0);
				if (uiNiagara5 != null)
				{
					uiNiagara5.SetUIActive(true);
				}
				break;
			}
			case EDropCatchDropItemNiagaraType.Mid:
			{
				UUINiagara uiNiagara6 = base.GetUiNiagara(1);
				if (uiNiagara6 != null)
				{
					uiNiagara6.SetUIActive(true);
				}
				break;
			}
			case EDropCatchDropItemNiagaraType.High:
			{
				UUINiagara uiNiagara7 = base.GetUiNiagara(2);
				if (uiNiagara7 != null)
				{
					uiNiagara7.SetUIActive(true);
				}
				break;
			}
			case EDropCatchDropItemNiagaraType.Bad:
			{
				UUINiagara uiNiagara8 = base.GetUiNiagara(3);
				if (uiNiagara8 != null)
				{
					uiNiagara8.SetUIActive(true);
				}
				break;
			}
			}
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				Action<DropCatchGameplayPoolPanelBase> onRecycle = this.OnRecycle;
				if (onRecycle == null)
				{
					return;
				}
				onRecycle(this);
			}, (float)this.RECYCLE_TIME, null, null, true, 1f);
		}

		// Token: 0x06041DBA RID: 269754 RVA: 0x00FF8A0B File Offset: 0x00FF6C0B
		[NullableContext(1)]
		protected void InitPos(Vector2D pos)
		{
			base.GetRootItem().SetAnchorOffset(pos.ToUeVector2D(false));
		}

		// Token: 0x06041DBB RID: 269755 RVA: 0x00FF8A1F File Offset: 0x00FF6C1F
		private void ClearTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			}
			this.TimerHandle = null;
		}

		// Token: 0x06041DBC RID: 269756 RVA: 0x00FF8A4B File Offset: 0x00FF6C4B
		protected override void OnBeforeDestroy()
		{
			this.ClearTimer();
		}

		// Token: 0x040224D9 RID: 140505
		private readonly int RECYCLE_TIME = 2000;

		// Token: 0x040224DA RID: 140506
		[Nullable(2)]
		private TimerHandle TimerHandle;
	}
}
