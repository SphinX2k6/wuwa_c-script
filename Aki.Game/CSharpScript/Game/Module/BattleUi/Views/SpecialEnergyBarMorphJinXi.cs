using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DE0 RID: 24032
	public class SpecialEnergyBarMorphJinXi : SpecialEnergyBarMorph
	{
		// Token: 0x0603D176 RID: 250230 RVA: 0x00EB3538 File Offset: 0x00EB1738
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			if (this.NiagaraList.ElementAtOrDefault(0) != null)
			{
				((SpecialEnergyBarPointGraduate)this.BarItem).ReplaceFullEffect(this.NiagaraList[0]);
			}
		}

		// Token: 0x0603D177 RID: 250231 RVA: 0x00EB356C File Offset: 0x00EB176C
		protected override void OnStart()
		{
			base.OnStart();
			int num = this.Config.SlotNum - 1;
			for (int i = 0; i < num; i++)
			{
				((SpecialEnergyBarPointGraduate)this.BarItem).SetGraduateItemOffset(i, this.Config.ExtraFloatParams[i + 1]);
			}
		}

		// Token: 0x0603D178 RID: 250232 RVA: 0x00EB35BD File Offset: 0x00EB17BD
		[NullableContext(1)]
		protected override Type GetSpecialEnergyBarClass()
		{
			return typeof(SpecialEnergyBarPointGraduate);
		}
	}
}
