using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DCB RID: 19915
	internal class SpecialEnergyBarKeLaiTa : SpecialEnergyBarBase
	{
		// Token: 0x0603212F RID: 205103 RVA: 0x00E068EC File Offset: 0x00E04AEC
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

		// Token: 0x06032130 RID: 205104 RVA: 0x00E069DC File Offset: 0x00E04BDC
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarKeLaiTa.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarKeLaiTa.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032131 RID: 205105 RVA: 0x00E06A20 File Offset: 0x00E04C20
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarKeLaiTa.<InitBarItem>d__9 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarKeLaiTa.<InitBarItem>d__9>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032132 RID: 205106 RVA: 0x00E06A63 File Offset: 0x00E04C63
		protected override void OnStart()
		{
			base.OnStart();
			base.InitTweenAnim(5);
			this.BarItem.SetCustomEffectBasePercent(0.46341464f);
			this.RefreshBuff();
			this.SetRedState(this.Buff == null, true);
		}

		// Token: 0x06032133 RID: 205107 RVA: 0x00E06A98 File Offset: 0x00E04C98
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

		// Token: 0x06032134 RID: 205108 RVA: 0x00E06B08 File Offset: 0x00E04D08
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

		// Token: 0x06032135 RID: 205109 RVA: 0x00E06BA8 File Offset: 0x00E04DA8
		private void SetBuffBarPercent(float percent)
		{
			if (this.LastBuffBarPercent == percent)
			{
				return;
			}
			this.LastBuffBarPercent = percent;
			UUINiagara uiNiagara = base.GetUiNiagara(3);
			if (uiNiagara != null)
			{
				uiNiagara.SetNiagaraVarFloat("Dissolve", percent);
			}
			UUINiagara uiNiagara2 = base.GetUiNiagara(4);
			if (uiNiagara2 == null)
			{
				return;
			}
			uiNiagara2.SetNiagaraVarFloat("Dissolve", percent);
		}

		// Token: 0x06032136 RID: 205110 RVA: 0x00E06BF8 File Offset: 0x00E04DF8
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

		// Token: 0x0401A854 RID: 108628
		private const float EFFECT_BASE_PERCENT = 0.46341464f;

		// Token: 0x0401A855 RID: 108629
		[Nullable(2)]
		private SpecialEnergyBarSlot BarItem;

		// Token: 0x0401A856 RID: 108630
		[Nullable(2)]
		private IActiveBuff Buff;

		// Token: 0x0401A857 RID: 108631
		private int BuffHandle;

		// Token: 0x0401A858 RID: 108632
		private bool IsRedState;

		// Token: 0x0401A859 RID: 108633
		private float LastBuffBarPercent = -1f;

		// Token: 0x0200AB1A RID: 43802
		private enum EChildType
		{
			// Token: 0x04034E82 RID: 216706
			SlotBarItem,
			// Token: 0x04034E83 RID: 216707
			BlueItem,
			// Token: 0x04034E84 RID: 216708
			RedItem,
			// Token: 0x04034E85 RID: 216709
			BlueBarL,
			// Token: 0x04034E86 RID: 216710
			BlueBarR,
			// Token: 0x04034E87 RID: 216711
			AniBurst
		}
	}
}
