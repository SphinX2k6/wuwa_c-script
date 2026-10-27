using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D23 RID: 23843
	public class FishingHpItem : UiPanelBase
	{
		// Token: 0x0603C71E RID: 247582 RVA: 0x00E7E9E0 File Offset: 0x00E7CBE0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C71F RID: 247583 RVA: 0x00E7EA49 File Offset: 0x00E7CC49
		public void SetHpVisible(bool bVisible)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(bVisible);
		}

		// Token: 0x0200BFA9 RID: 49065
		private enum EChildType
		{
			// Token: 0x04039D26 RID: 236838
			HpSprite,
			// Token: 0x04039D27 RID: 236839
			BgItem
		}
	}
}
