using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x0200466A RID: 18026
	public class StarItem : UiPanelBase
	{
		// Token: 0x0602D554 RID: 185684 RVA: 0x00CB125C File Offset: 0x00CAF45C
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

		// Token: 0x0602D555 RID: 185685 RVA: 0x00CB12AF File Offset: 0x00CAF4AF
		public void SetState(bool isReached)
		{
			if (isReached)
			{
				base.GetSprite(0).SetUIActive(true);
				return;
			}
			base.GetSprite(0).SetUIActive(false);
		}

		// Token: 0x0200A27E RID: 41598
		private class EStarDefine
		{
			// Token: 0x040326CF RID: 206543
			public const int SprStar = 0;
		}
	}
}
