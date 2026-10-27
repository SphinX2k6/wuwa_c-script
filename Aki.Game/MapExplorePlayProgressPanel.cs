using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001ACB RID: 6859
[NullableContext(1)]
[Nullable(0)]
public class MapExplorePlayProgressPanel : UiPanelBase
{
	// Token: 0x0600CB8C RID: 52108 RVA: 0x002E7544 File Offset: 0x002E5744
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CB8D RID: 52109 RVA: 0x002E75B0 File Offset: 0x002E57B0
	public UniTask Init(UUIItem item)
	{
		MapExplorePlayProgressPanel.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<MapExplorePlayProgressPanel.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600CB8E RID: 52110 RVA: 0x002E75FB File Offset: 0x002E57FB
	protected override void OnBeforeShow()
	{
		this.PlayLayout = new GenericLayout<MapExplorePlayProgressItem, IExplorePlayProgressItemData>(base.GetHorizontalLayout(0), () => new MapExplorePlayProgressItem(), null, false, true);
	}

	// Token: 0x0600CB8F RID: 52111 RVA: 0x002E7634 File Offset: 0x002E5834
	public void UpdateData(List<IExplorePlayProgressItemData> data, [Nullable(2)] Action finishCallback = null)
	{
		GenericLayout<MapExplorePlayProgressItem, IExplorePlayProgressItemData> playLayout = this.PlayLayout;
		if (playLayout == null)
		{
			return;
		}
		playLayout.RefreshByData(data, delegate
		{
			Action finishCallback2 = finishCallback;
			if (finishCallback2 == null)
			{
				return;
			}
			finishCallback2();
		}, false);
	}

	// Token: 0x0600CB90 RID: 52112 RVA: 0x002E766C File Offset: 0x002E586C
	public void CheckPlayStateChanged()
	{
		GenericLayout<MapExplorePlayProgressItem, IExplorePlayProgressItemData> playLayout = this.PlayLayout;
		List<MapExplorePlayProgressItem> list = (playLayout != null) ? playLayout.GetLayoutItemList() : null;
		if (list == null)
		{
			return;
		}
		foreach (MapExplorePlayProgressItem mapExplorePlayProgressItem in list)
		{
			mapExplorePlayProgressItem.CheckPlayStateChanged();
		}
	}

	// Token: 0x04005D9F RID: 23967
	private GenericLayout<MapExplorePlayProgressItem, IExplorePlayProgressItemData> PlayLayout;

	// Token: 0x02008029 RID: 32809
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029D8A RID: 171402
		RootLayout,
		// Token: 0x04029D8B RID: 171403
		PlayPointItem
	}
}
