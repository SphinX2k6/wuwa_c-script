using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004AF6 RID: 19190
	public class StarItem : UiPanelBase
	{
		// Token: 0x0602FFE3 RID: 196579 RVA: 0x00D6334C File Offset: 0x00D6154C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0602FFE4 RID: 196580 RVA: 0x00D6339F File Offset: 0x00D6159F
		public void SetState(bool isReached)
		{
			if (isReached)
			{
				base.GetSprite(0).SetUIActive(true);
				return;
			}
			base.GetSprite(0).SetUIActive(false);
		}

		// Token: 0x0200A759 RID: 42841
		private enum EStarDefine
		{
			// Token: 0x04033B59 RID: 211801
			SprStar
		}
	}
}
