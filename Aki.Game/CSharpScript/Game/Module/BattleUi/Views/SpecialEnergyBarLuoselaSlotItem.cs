using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DEF RID: 24047
	public class SpecialEnergyBarLuoselaSlotItem : SpecialEnergyBarSlotItem
	{
		// Token: 0x0603D219 RID: 250393 RVA: 0x00EB7FB0 File Offset: 0x00EB61B0
		[NullableContext(2)]
		protected new UUINiagara GetUiNiagara(int itemType)
		{
			if (itemType == 3 && this.IsUlt)
			{
				itemType = 9;
			}
			return base.GetUiNiagara(itemType);
		}

		// Token: 0x0603D21A RID: 250394 RVA: 0x00EB7FC9 File Offset: 0x00EB61C9
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUINiagara)));
		}

		// Token: 0x0603D21B RID: 250395 RVA: 0x00EB7FF0 File Offset: 0x00EB61F0
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

		// Token: 0x0401FDDD RID: 130525
		private bool IsUlt;

		// Token: 0x0200C127 RID: 49447
		private class ESlotItemChildType
		{
			// Token: 0x0403A54A RID: 238922
			public const int FullEffectA = 3;

			// Token: 0x0403A54B RID: 238923
			public const int FullEffectB = 9;
		}
	}
}
