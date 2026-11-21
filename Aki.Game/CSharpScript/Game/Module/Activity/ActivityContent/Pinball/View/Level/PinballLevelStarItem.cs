using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Level
{
	// Token: 0x020052BF RID: 21183
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballLevelStarItem : GridProxyAbstract<IPinballLevelStarData>
	{
		// Token: 0x06034BC4 RID: 216004 RVA: 0x00EBFAF4 File Offset: 0x00EBDCF4
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

		// Token: 0x06034BC5 RID: 216005 RVA: 0x00EBFB3C File Offset: 0x00EBDD3C
		[NullableContext(1)]
		public override void Refresh(IPinballLevelStarData data, bool isSelected, int gridIndex)
		{
			base.GetSprite(0).SetUIActive(data.Passed);
		}

		// Token: 0x0200AF3F RID: 44863
		private enum EStarComponent
		{
			// Token: 0x04036267 RID: 221799
			SprStar
		}
	}
}
