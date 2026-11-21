using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CD5 RID: 19669
	public class ItemUseComponent : GridProxyAbstract<bool>
	{
		// Token: 0x06031370 RID: 201584 RVA: 0x00DBD218 File Offset: 0x00DBB418
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

		// Token: 0x06031371 RID: 201585 RVA: 0x00DBD260 File Offset: 0x00DBB460
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			this.SetSpriteVisible(data);
		}

		// Token: 0x06031372 RID: 201586 RVA: 0x00DBD269 File Offset: 0x00DBB469
		public void SetSpriteVisible(bool bVisible)
		{
			base.GetSprite(0).SetUIActive(bVisible);
		}

		// Token: 0x0200A95C RID: 43356
		private enum EItemUseItem
		{
			// Token: 0x0403450B RID: 214283
			PointSprite
		}
	}
}
