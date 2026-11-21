using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059FC RID: 23036
	public abstract class SolarSchoolRewardTipIconTextItemBase : SolarSchoolRewardTipItemBase
	{
		// Token: 0x06038BAE RID: 232366 RVA: 0x00FE0588 File Offset: 0x00FDE788
		protected unsafe sealed override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0200B5A8 RID: 46504
		protected enum EComponent
		{
			// Token: 0x040382CC RID: 230092
			Quality,
			// Token: 0x040382CD RID: 230093
			Title,
			// Token: 0x040382CE RID: 230094
			Description,
			// Token: 0x040382CF RID: 230095
			Icon
		}
	}
}
