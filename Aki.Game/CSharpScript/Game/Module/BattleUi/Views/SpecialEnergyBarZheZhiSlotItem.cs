using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E19 RID: 24089
	public class SpecialEnergyBarZheZhiSlotItem : SpecialEnergyBarSlotItem
	{
		// Token: 0x0603D423 RID: 250915 RVA: 0x00EC34A4 File Offset: 0x00EC16A4
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarZheZhiSlotItem.<OnBeforeStartAsync>d__1 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarZheZhiSlotItem.<OnBeforeStartAsync>d__1>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D424 RID: 250916 RVA: 0x00EC34E7 File Offset: 0x00EC16E7
		public void SetEffectItemVisible(bool value)
		{
			SpecialEnergyBarZheZhiEffectItem effectItem = this.EffectItem;
			if (effectItem == null)
			{
				return;
			}
			effectItem.SetVisible(value);
		}

		// Token: 0x0603D425 RID: 250917 RVA: 0x00EC34FA File Offset: 0x00EC16FA
		[NullableContext(1)]
		public void SetEffectItemNiagaraParam(string varName, float value)
		{
			SpecialEnergyBarZheZhiEffectItem effectItem = this.EffectItem;
			if (effectItem == null)
			{
				return;
			}
			effectItem.SetNiagaraParam(varName, value);
		}

		// Token: 0x0401FF1E RID: 130846
		[Nullable(2)]
		private SpecialEnergyBarZheZhiEffectItem EffectItem;
	}
}
