using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DC4 RID: 19908
	public class SpecialEnergyBarMorphJinXi : SpecialEnergyBarMorph
	{
		// Token: 0x060320ED RID: 205037 RVA: 0x00E0442C File Offset: 0x00E0262C
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			if (this.NiagaraList.Count > 0 && this.NiagaraList[0] != null)
			{
				((SpecialEnergyBarPointGraduate)this.BarItem).ReplaceFullEffect(this.NiagaraList[0]);
			}
		}

		// Token: 0x060320EE RID: 205038 RVA: 0x00E0446C File Offset: 0x00E0266C
		protected override void OnStart()
		{
			base.OnStart();
			int num = this.Config.SlotNum - 1;
			for (int i = 0; i < num; i++)
			{
				((SpecialEnergyBarPointGraduate)this.BarItem).SetGraduateItemOffset(i, this.Config.ExtraFloatParams[i + 1]);
			}
		}

		// Token: 0x060320EF RID: 205039 RVA: 0x00E044BD File Offset: 0x00E026BD
		[NullableContext(1)]
		protected override Type GetSpecialEnergyBarClass()
		{
			return typeof(SpecialEnergyBarPointGraduate);
		}
	}
}
