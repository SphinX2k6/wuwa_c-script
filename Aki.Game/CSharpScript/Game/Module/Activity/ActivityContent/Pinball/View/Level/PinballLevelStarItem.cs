using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Level
{
	// Token: 0x02006341 RID: 25409
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballLevelStarItem : GridProxyAbstract<IPinballLevelStarData>
	{
		// Token: 0x0603FF03 RID: 261891 RVA: 0x00F78B94 File Offset: 0x00F76D94
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

		// Token: 0x0603FF04 RID: 261892 RVA: 0x00F78BDC File Offset: 0x00F76DDC
		[NullableContext(1)]
		public override void Refresh(IPinballLevelStarData data, bool isSelected, int gridIndex)
		{
			base.GetSprite(0).SetUIActive(data.Passed);
		}

		// Token: 0x0200C558 RID: 50520
		private enum EStarComponent
		{
			// Token: 0x0403B905 RID: 243973
			SprStar
		}
	}
}
