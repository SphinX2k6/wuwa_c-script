using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F8A RID: 3978
[NullableContext(1)]
[Nullable(0)]
public class MapExplorePlayProgressPanel : UiPanelBase
{
	// Token: 0x06009F9D RID: 40861 RVA: 0x002F2698 File Offset: 0x002F0898
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

	// Token: 0x06009F9E RID: 40862 RVA: 0x002F2704 File Offset: 0x002F0904
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

	// Token: 0x06009F9F RID: 40863 RVA: 0x002F274F File Offset: 0x002F094F
	protected override void OnBeforeShow()
	{
		this.PlayLayout = new GenericLayout<MapExplorePlayProgressItem, IExplorePlayProgressItemData>(base.GetHorizontalLayout(0), () => new MapExplorePlayProgressItem(), null, false, true);
	}

	// Token: 0x06009FA0 RID: 40864 RVA: 0x002F2788 File Offset: 0x002F0988
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

	// Token: 0x06009FA1 RID: 40865 RVA: 0x002F27C0 File Offset: 0x002F09C0
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

	// Token: 0x04005E6E RID: 24174
	private GenericLayout<MapExplorePlayProgressItem, IExplorePlayProgressItemData> PlayLayout;

	// Token: 0x020071B7 RID: 29111
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040250BE RID: 151742
		RootLayout,
		// Token: 0x040250BF RID: 151743
		PlayPointItem
	}
}
