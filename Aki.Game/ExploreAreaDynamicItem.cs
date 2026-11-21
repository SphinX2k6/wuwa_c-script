using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F72 RID: 3954
public class ExploreAreaDynamicItem : UiPanelBase, IDynamicScrollBaseItem<ExploreAreaViewData>
{
	// Token: 0x06009E8D RID: 40589 RVA: 0x002ED468 File Offset: 0x002EB668
	[NullableContext(1)]
	public UniTask Init(UUIItem actor)
	{
		ExploreAreaDynamicItem.<Init>d__1 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ExploreAreaDynamicItem.<Init>d__1>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06009E8E RID: 40590 RVA: 0x002ED4B4 File Offset: 0x002EB6B4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009E8F RID: 40591 RVA: 0x002ED520 File Offset: 0x002EB720
	[NullableContext(1)]
	public FVector2D GetItemSize(ExploreAreaViewData data)
	{
		if (data.IsCountry)
		{
			UUIItem item = base.GetItem(0);
			return new FVector2D(item.GetWidth(), item.GetHeight());
		}
		UUIItem item2 = base.GetItem(1);
		return new FVector2D(item2.GetWidth(), item2.GetHeight());
	}

	// Token: 0x06009E90 RID: 40592 RVA: 0x002ED568 File Offset: 0x002EB768
	public void ClearItem()
	{
	}

	// Token: 0x02007195 RID: 29077
	private enum EChildType
	{
		// Token: 0x04024FF5 RID: 151541
		CountryItem,
		// Token: 0x04024FF6 RID: 151542
		AreaItem
	}
}
