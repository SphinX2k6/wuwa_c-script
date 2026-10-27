using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DE7 RID: 24039
	internal class SpecialEnergyBarKeLaiTa : SpecialEnergyBarBase
	{
		// Token: 0x0603D1B8 RID: 250296 RVA: 0x00EB59EC File Offset: 0x00EB3BEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D1B9 RID: 250297 RVA: 0x00EB5ADC File Offset: 0x00EB3CDC
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarKeLaiTa.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarKeLaiTa.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D1BA RID: 250298 RVA: 0x00EB5B20 File Offset: 0x00EB3D20
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarKeLaiTa.<InitBarItem>d__9 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarKeLaiTa.<InitBarItem>d__9>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D1BB RID: 250299 RVA: 0x00EB5B63 File Offset: 0x00EB3D63
		protected override void OnStart()
		{
			base.OnStart();
			base.InitTweenAnim(5);
			this.BarItem.SetCustomEffectBasePercent(0.46341464f);
			this.RefreshBuff();
			this.SetRedState(this.Buff == null, true);
		}

		// Token: 0x0603D1BC RID: 250300 RVA: 0x00EB5B98 File Offset: 0x00EB3D98
		protected void RefreshBuff()
		{
			SpecialEnergyBarInfo config = this.Config;
			bool flag;
			if (config == null)
			{
				flag = false;
			}
			else
			{
				long buffId = config.BuffId;
				flag = true;
			}
			if (flag)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				this.Buff = ((buffComponent != null) ? buffComponent.GetBuffById(this.Config.BuffId) : null);
				IActiveBuff buff = this.Buff;
				this.BuffHandle = ((buff != null) ? buff.Handle : 0);
				return;
			}
			this.Buff = null;
			this.BuffHandle = 0;
		}

		// Token: 0x0603D1BD RID: 250301 RVA: 0x00EB5C08 File Offset: 0x00EB3E08
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarSlot barItem = this.BarItem;
			if (barItem != null)
			{
				barItem.Tick(delta);
			}
			if (this.Buff != null)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
				{
					goto IL_41;
				}
			}
			this.RefreshBuff();
			IL_41:
			if (this.Buff != null && this.Buff.Duration > 0f)
			{
				this.SetRedState(false, false);
				float buffBarPercent = 1f - this.Buff.GetRemainDuration() / this.Buff.Duration;
				this.SetBuffBarPercent(buffBarPercent);
				return;
			}
			this.SetRedState(true, false);
		}

		// Token: 0x0603D1BE RID: 250302 RVA: 0x00EB5CA6 File Offset: 0x00EB3EA6
		private void SetBuffBarPercent(float percent)
		{
			if (this.LastBuffBarPercent == percent)
			{
				return;
			}
			this.LastBuffBarPercent = percent;
			base.GetUiNiagara(3).SetNiagaraVarFloat("Dissolve", percent);
			base.GetUiNiagara(4).SetNiagaraVarFloat("Dissolve", percent);
		}

		// Token: 0x0603D1BF RID: 250303 RVA: 0x00EB5CE0 File Offset: 0x00EB3EE0
		private void SetRedState(bool isRed, bool bForce = false)
		{
			if (this.IsRedState == isRed && !bForce)
			{
				return;
			}
			this.IsRedState = isRed;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!isRed);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(isRed);
			}
			if (!isRed && !bForce)
			{
				base.PlayTweenAnim(5);
			}
		}

		// Token: 0x0401FD97 RID: 130455
		private const float EFFECT_BASE_PERCENT = 0.46341464f;

		// Token: 0x0401FD98 RID: 130456
		[Nullable(2)]
		private SpecialEnergyBarSlot BarItem;

		// Token: 0x0401FD99 RID: 130457
		[Nullable(2)]
		private IActiveBuff Buff;

		// Token: 0x0401FD9A RID: 130458
		private int BuffHandle;

		// Token: 0x0401FD9B RID: 130459
		private bool IsRedState;

		// Token: 0x0401FD9C RID: 130460
		private float LastBuffBarPercent = -1f;

		// Token: 0x0200C111 RID: 49425
		private enum EChildType
		{
			// Token: 0x0403A4B0 RID: 238768
			SlotBarItem,
			// Token: 0x0403A4B1 RID: 238769
			BlueItem,
			// Token: 0x0403A4B2 RID: 238770
			RedItem,
			// Token: 0x0403A4B3 RID: 238771
			BlueBarL,
			// Token: 0x0403A4B4 RID: 238772
			BlueBarR,
			// Token: 0x0403A4B5 RID: 238773
			AniBurst
		}
	}
}
