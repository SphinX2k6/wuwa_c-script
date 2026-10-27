using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020015F4 RID: 5620
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class StrItem : GridProxyAbstract<WheelTowerStrItemData>
{
	// Token: 0x06009E9E RID: 40606 RVA: 0x0022A4A4 File Offset: 0x002286A4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009E9F RID: 40607 RVA: 0x0022A510 File Offset: 0x00228710
	public override void Refresh(WheelTowerStrItemData data, bool isSelected, int gridIndex)
	{
		string item = ConfigMultiTextLang.GetLocalTextNew(data.RoleName, null) ?? string.Empty;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "WheelBattleRoleInfo_StrTips", new <>z__ReadOnlySingleElementList<object>(item));
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(string.Join("\n", data.DescList), true);
	}
}
