using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D05 RID: 19717
	public class FishingHpItem : UiPanelBase
	{
		// Token: 0x06031677 RID: 202359 RVA: 0x00DCF180 File Offset: 0x00DCD380
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

		// Token: 0x06031678 RID: 202360 RVA: 0x00DCF1E9 File Offset: 0x00DCD3E9
		public void SetHpVisible(bool bVisible)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(bVisible);
		}

		// Token: 0x0200A9AF RID: 43439
		private enum EChildType
		{
			// Token: 0x040346E8 RID: 214760
			HpSprite,
			// Token: 0x040346E9 RID: 214761
			BgItem
		}
	}
}
