using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb
{
	// Token: 0x020041CC RID: 16844
	public class EvolveItem : UiPanelBase
	{
		// Token: 0x0602AA18 RID: 174616 RVA: 0x00C04670 File Offset: 0x00C02870
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x0602AA19 RID: 174617 RVA: 0x00C04693 File Offset: 0x00C02893
		protected override void OnStart()
		{
			this.SetEffectActive(false);
		}

		// Token: 0x0602AA1A RID: 174618 RVA: 0x00C0469C File Offset: 0x00C0289C
		public override void SetActive(bool value)
		{
			base.SetUiActive(value);
		}

		// Token: 0x0602AA1B RID: 174619 RVA: 0x00C046A5 File Offset: 0x00C028A5
		public void SetEffectActive(bool value)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(value);
		}

		// Token: 0x02009DC7 RID: 40391
		private static class EEffectItem
		{
			// Token: 0x0403111D RID: 200989
			public const int EffectItem = 0;
		}
	}
}
