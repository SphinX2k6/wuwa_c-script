using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.DreamLink;
using UnrealEngine;

// Token: 0x020013C6 RID: 5062
public class NewPlayerSupportRoleSpineItem : NewPlayerSupportRoleBaseItem
{
	// Token: 0x06008EDD RID: 36573 RVA: 0x001ED898 File Offset: 0x001EBA98
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(USpineSkeletonAnimationComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008EDE RID: 36574 RVA: 0x001ED922 File Offset: 0x001EBB22
	protected override void OnStart()
	{
		base.OnStart();
		base.GetItem(0).SetUIActive(false);
		base.GetTexture(1).SetUIActive(false);
	}

	// Token: 0x06008EDF RID: 36575 RVA: 0x001ED944 File Offset: 0x001EBB44
	public override void Refresh()
	{
		base.GetSpine(2).SetAnimation(0, EDreamLinkSpineDefine.Idle.ToString(), true);
	}

	// Token: 0x02007A47 RID: 31303
	private class EComponentType
	{
		// Token: 0x040283F7 RID: 164855
		public const int DescItem = 0;

		// Token: 0x040283F8 RID: 164856
		public const int ThemeTextTexture = 1;

		// Token: 0x040283F9 RID: 164857
		public const int SpineActor = 2;
	}
}
