using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000E38 RID: 3640
public class SmallItemGridLeftTopIconComponent : SmallItemGridComponent
{
	// Token: 0x060092F4 RID: 37620 RVA: 0x002BDF2B File Offset: 0x002BC12B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x060092F5 RID: 37621 RVA: 0x002BDF4E File Offset: 0x002BC14E
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_AddtionIcon";
	}

	// Token: 0x060092F6 RID: 37622 RVA: 0x002BDF58 File Offset: 0x002BC158
	[NullableContext(2)]
	protected override void OnRefresh(object tempData)
	{
		string path = (string)tempData;
		this.SetSpriteByPath(path, base.GetSprite(0), false, null, null);
		this.SetActive(true);
	}

	// Token: 0x02007055 RID: 28757
	private static class EChildType
	{
		// Token: 0x04024A42 RID: 150082
		public const int SpriteIcon = 0;
	}
}
