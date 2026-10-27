using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AB3 RID: 6835
public class ExploreAreaDynamicItem : UiPanelBase, IDynamicScrollBaseItem<ExploreAreaViewData>
{
	// Token: 0x0600CA7C RID: 51836 RVA: 0x002E2318 File Offset: 0x002E0518
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

	// Token: 0x0600CA7D RID: 51837 RVA: 0x002E2364 File Offset: 0x002E0564
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

	// Token: 0x0600CA7E RID: 51838 RVA: 0x002E23D0 File Offset: 0x002E05D0
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

	// Token: 0x0600CA7F RID: 51839 RVA: 0x002E2418 File Offset: 0x002E0618
	public void ClearItem()
	{
	}

	// Token: 0x02008006 RID: 32774
	private enum EChildType
	{
		// Token: 0x04029CBB RID: 171195
		CountryItem,
		// Token: 0x04029CBC RID: 171196
		AreaItem
	}
}
