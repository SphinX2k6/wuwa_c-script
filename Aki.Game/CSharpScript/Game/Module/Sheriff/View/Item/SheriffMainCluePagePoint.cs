using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02004C6B RID: 19563
	public class SheriffMainCluePagePoint : GridProxyAbstract<bool>
	{
		// Token: 0x06032926 RID: 207142 RVA: 0x00BC9710 File Offset: 0x00BC7910
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032927 RID: 207143 RVA: 0x00BC9779 File Offset: 0x00BC7979
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			base.GetSprite(1).SetUIActive(data);
			base.GetSprite(0).SetUIActive(!data);
		}

		// Token: 0x0200AE1E RID: 44574
		private static class EPagePoint
		{
			// Token: 0x04034E1C RID: 216604
			public const int SpriteBg = 0;

			// Token: 0x04034E1D RID: 216605
			public const int SpriteSelect = 1;
		}
	}
}
