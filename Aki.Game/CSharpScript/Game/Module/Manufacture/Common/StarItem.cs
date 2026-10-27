using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02005694 RID: 22164
	public class StarItem : UiPanelBase
	{
		// Token: 0x06038657 RID: 230999 RVA: 0x00D6310C File Offset: 0x00D6130C
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

		// Token: 0x06038658 RID: 231000 RVA: 0x00D6315F File Offset: 0x00D6135F
		public void SetState(bool isReached)
		{
			if (isReached)
			{
				base.GetSprite(0).SetUIActive(true);
				return;
			}
			base.GetSprite(0).SetUIActive(false);
		}

		// Token: 0x0200B856 RID: 47190
		private class EStarDefine
		{
			// Token: 0x04037CB2 RID: 228530
			public const int SprStar = 0;
		}
	}
}
