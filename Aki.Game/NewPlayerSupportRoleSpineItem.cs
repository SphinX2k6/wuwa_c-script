using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.DreamLink;
using UnrealEngine;

// Token: 0x0200087A RID: 2170
public class NewPlayerSupportRoleSpineItem : NewPlayerSupportRoleBaseItem
{
	// Token: 0x06006272 RID: 25202 RVA: 0x001F63B8 File Offset: 0x001F45B8
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

	// Token: 0x06006273 RID: 25203 RVA: 0x001F6442 File Offset: 0x001F4642
	protected override void OnStart()
	{
		base.OnStart();
		base.GetItem(0).SetUIActive(false);
		base.GetTexture(1).SetUIActive(false);
	}

	// Token: 0x06006274 RID: 25204 RVA: 0x001F6464 File Offset: 0x001F4664
	public override void Refresh()
	{
		base.GetSpine(2).SetAnimation(0, EDreamLinkSpineDefine.Idle.ToString(), true);
	}

	// Token: 0x02006BCD RID: 27597
	private class EComponentType
	{
		// Token: 0x04023714 RID: 145172
		public const int DescItem = 0;

		// Token: 0x04023715 RID: 145173
		public const int ThemeTextTexture = 1;

		// Token: 0x04023716 RID: 145174
		public const int SpineActor = 2;
	}
}
