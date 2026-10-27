using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001575 RID: 5493
public class VersionPreheatQuestDetailRoleItem : UiPanelBase
{
	// Token: 0x06009D1C RID: 40220 RVA: 0x0022062C File Offset: 0x0021E82C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009D1D RID: 40221 RVA: 0x00220674 File Offset: 0x0021E874
	[NullableContext(1)]
	public void RefreshExternal(string iconPath)
	{
		base.SetTextureByPath(iconPath, base.GetTexture(0), null, null);
	}

	// Token: 0x02007BA6 RID: 31654
	private class ERoleComponent
	{
		// Token: 0x04028A73 RID: 166515
		public const int RoleIconTexture = 0;
	}
}
