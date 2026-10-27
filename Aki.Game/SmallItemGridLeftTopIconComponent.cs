using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200197B RID: 6523
public class SmallItemGridLeftTopIconComponent : SmallItemGridComponent
{
	// Token: 0x0600BEEC RID: 48876 RVA: 0x002B2FA7 File Offset: 0x002B11A7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600BEED RID: 48877 RVA: 0x002B2FCA File Offset: 0x002B11CA
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_AddtionIcon";
	}

	// Token: 0x0600BEEE RID: 48878 RVA: 0x002B2FD4 File Offset: 0x002B11D4
	[NullableContext(2)]
	protected override void OnRefresh(object tempData)
	{
		string path = (string)tempData;
		this.SetSpriteByPath(path, base.GetSprite(0), false, null, null);
		this.SetActive(true);
	}

	// Token: 0x02007EC6 RID: 32454
	private static class EChildType
	{
		// Token: 0x04029705 RID: 169733
		public const int SpriteIcon = 0;
	}
}
