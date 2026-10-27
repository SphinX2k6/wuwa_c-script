using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb
{
	// Token: 0x020051FC RID: 20988
	public class EvolveItem : UiPanelBase
	{
		// Token: 0x06035B1D RID: 219933 RVA: 0x00CB7034 File Offset: 0x00CB5234
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x06035B1E RID: 219934 RVA: 0x00CB7057 File Offset: 0x00CB5257
		protected override void OnStart()
		{
			this.SetEffectActive(false);
		}

		// Token: 0x06035B1F RID: 219935 RVA: 0x00CB7060 File Offset: 0x00CB5260
		public override void SetActive(bool value)
		{
			base.SetUiActive(value);
		}

		// Token: 0x06035B20 RID: 219936 RVA: 0x00CB7069 File Offset: 0x00CB5269
		public void SetEffectActive(bool value)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(value);
		}

		// Token: 0x0200B38F RID: 45967
		private static class EEffectItem
		{
			// Token: 0x040366CA RID: 222922
			public const int EffectItem = 0;
		}
	}
}
