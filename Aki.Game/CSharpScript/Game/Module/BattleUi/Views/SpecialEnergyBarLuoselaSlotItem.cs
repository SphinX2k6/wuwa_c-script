using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DD4 RID: 19924
	public class SpecialEnergyBarLuoselaSlotItem : SpecialEnergyBarSlotItem
	{
		// Token: 0x060321A8 RID: 205224 RVA: 0x00E094F0 File Offset: 0x00E076F0
		[NullableContext(2)]
		protected new UUINiagara GetUiNiagara(int itemType)
		{
			if (itemType == 3 && this.IsUlt)
			{
				itemType = 9;
			}
			return base.GetUiNiagara(itemType);
		}

		// Token: 0x060321A9 RID: 205225 RVA: 0x00E09509 File Offset: 0x00E07709
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUINiagara)));
		}

		// Token: 0x060321AA RID: 205226 RVA: 0x00E09530 File Offset: 0x00E07730
		public void SetSlotItemUlt(bool ult, bool visible)
		{
			this.IsUlt = ult;
			if (this.State == 1)
			{
				base.GetUiNiagara(3).SetUIActive(!ult && visible);
				base.GetUiNiagara(9).SetUIActive(ult && visible);
				return;
			}
			base.GetUiNiagara(3).SetUIActive(false);
			base.GetUiNiagara(9).SetUIActive(false);
		}

		// Token: 0x0401A8A4 RID: 108708
		private bool IsUlt;

		// Token: 0x0200AB36 RID: 43830
		private class ESlotItemChildType
		{
			// Token: 0x04034F3C RID: 216892
			public const int FullEffectA = 3;

			// Token: 0x04034F3D RID: 216893
			public const int FullEffectB = 9;
		}
	}
}
