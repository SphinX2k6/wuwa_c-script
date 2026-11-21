using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02003C1C RID: 15388
	public class SheriffMainCluePagePoint : GridProxyAbstract<bool>
	{
		// Token: 0x060276D9 RID: 161497 RVA: 0x00B0E374 File Offset: 0x00B0C574
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

		// Token: 0x060276DA RID: 161498 RVA: 0x00B0E3DD File Offset: 0x00B0C5DD
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			base.GetSprite(1).SetUIActive(data);
			base.GetSprite(0).SetUIActive(!data);
		}

		// Token: 0x0200983C RID: 38972
		private static class EPagePoint
		{
			// Token: 0x0402F7C1 RID: 194497
			public const int SpriteBg = 0;

			// Token: 0x0402F7C2 RID: 194498
			public const int SpriteSelect = 1;
		}
	}
}
