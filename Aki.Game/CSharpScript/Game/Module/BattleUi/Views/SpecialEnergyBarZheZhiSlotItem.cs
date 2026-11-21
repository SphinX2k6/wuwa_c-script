using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DFE RID: 19966
	public class SpecialEnergyBarZheZhiSlotItem : SpecialEnergyBarSlotItem
	{
		// Token: 0x060323B2 RID: 205746 RVA: 0x00E14A04 File Offset: 0x00E12C04
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarZheZhiSlotItem.<OnBeforeStartAsync>d__1 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarZheZhiSlotItem.<OnBeforeStartAsync>d__1>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060323B3 RID: 205747 RVA: 0x00E14A47 File Offset: 0x00E12C47
		public void SetEffectItemVisible(bool value)
		{
			SpecialEnergyBarZheZhiEffectItem effectItem = this.EffectItem;
			if (effectItem == null)
			{
				return;
			}
			effectItem.SetVisible(value);
		}

		// Token: 0x060323B4 RID: 205748 RVA: 0x00E14A5A File Offset: 0x00E12C5A
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

		// Token: 0x0401A9E5 RID: 109029
		[Nullable(2)]
		private SpecialEnergyBarZheZhiEffectItem EffectItem;
	}
}
