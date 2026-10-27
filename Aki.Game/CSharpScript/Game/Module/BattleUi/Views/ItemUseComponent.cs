using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CF3 RID: 23795
	public class ItemUseComponent : GridProxyAbstract<bool>
	{
		// Token: 0x0603C41A RID: 246810 RVA: 0x00E6CC64 File Offset: 0x00E6AE64
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C41B RID: 246811 RVA: 0x00E6CCAC File Offset: 0x00E6AEAC
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			this.SetSpriteVisible(data);
		}

		// Token: 0x0603C41C RID: 246812 RVA: 0x00E6CCB5 File Offset: 0x00E6AEB5
		public void SetSpriteVisible(bool bVisible)
		{
			base.GetSprite(0).SetUIActive(bVisible);
		}

		// Token: 0x0200BF56 RID: 48982
		private enum EItemUseItem
		{
			// Token: 0x04039B49 RID: 236361
			PointSprite
		}
	}
}
