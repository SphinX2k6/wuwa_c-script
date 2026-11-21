using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02005644 RID: 22084
	public class DropCatchGameplayDropItemFxView : DropCatchGameplayPoolPanelBase
	{
		// Token: 0x06036904 RID: 223492 RVA: 0x00F39C7C File Offset: 0x00F37E7C
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

		// Token: 0x06036905 RID: 223493 RVA: 0x00F39CEC File Offset: 0x00F37EEC
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

		// Token: 0x06036906 RID: 223494 RVA: 0x00F39DFF File Offset: 0x00F37FFF
		[NullableContext(1)]
		protected void InitPos(Vector2D pos)
		{
			base.GetRootItem().SetAnchorOffset(pos.ToUeVector2D(false));
		}

		// Token: 0x06036907 RID: 223495 RVA: 0x00F39E13 File Offset: 0x00F38013
		private void ClearTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			}
			this.TimerHandle = null;
		}

		// Token: 0x06036908 RID: 223496 RVA: 0x00F39E3F File Offset: 0x00F3803F
		protected override void OnBeforeDestroy()
		{
			this.ClearTimer();
		}

		// Token: 0x0401CD32 RID: 118066
		private readonly int RECYCLE_TIME = 2000;

		// Token: 0x0401CD33 RID: 118067
		[Nullable(2)]
		private TimerHandle TimerHandle;
	}
}
