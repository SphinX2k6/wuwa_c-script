using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A2D RID: 2605
public class VersionPreheatQuestDetailRoleItem : UiPanelBase
{
	// Token: 0x060070FA RID: 28922 RVA: 0x0022A3DC File Offset: 0x002285DC
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

	// Token: 0x060070FB RID: 28923 RVA: 0x0022A424 File Offset: 0x00228624
	[NullableContext(1)]
	public void RefreshExternal(string iconPath)
	{
		base.SetTextureByPath(iconPath, base.GetTexture(0), null, null);
	}

	// Token: 0x02006D31 RID: 27953
	private class ERoleComponent
	{
		// Token: 0x04023DAE RID: 146862
		public const int RoleIconTexture = 0;
	}
}
