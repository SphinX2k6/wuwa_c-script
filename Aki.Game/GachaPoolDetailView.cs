using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001142 RID: 4418
public class GachaPoolDetailView : UiViewBase
{
	// Token: 0x0600B058 RID: 45144 RVA: 0x00340DF4 File Offset: 0x0033EFF4
	[NullableContext(1)]
	public GachaPoolDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B059 RID: 45145 RVA: 0x00340E00 File Offset: 0x0033F000
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B05A RID: 45146 RVA: 0x00340EAC File Offset: 0x0033F0AC
	protected override UniTask OnBeforeStartAsync()
	{
		GachaPoolDetailView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaPoolDetailView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B05B RID: 45147 RVA: 0x00340EF0 File Offset: 0x0033F0F0
	[NullableContext(1)]
	[CompilerGenerated]
	internal static List<GachaPoolDrop> <OnBeforeStartAsync>g__SortByUpPriority|3_0(IEnumerable<GachaPoolDrop> source)
	{
		List<GachaPoolDrop> list = new List<GachaPoolDrop>();
		foreach (GachaPoolDrop gachaPoolDrop in source)
		{
			if (gachaPoolDrop.IsUp)
			{
				list.Add(gachaPoolDrop);
			}
		}
		foreach (GachaPoolDrop gachaPoolDrop2 in source)
		{
			if (!gachaPoolDrop2.IsUp)
			{
				list.Add(gachaPoolDrop2);
			}
		}
		return list;
	}

	// Token: 0x020073DF RID: 29663
	private enum EGachaPoolDetailViewDefine
	{
		// Token: 0x04025B94 RID: 154516
		TxtDetail,
		// Token: 0x04025B95 RID: 154517
		GridContent,
		// Token: 0x04025B96 RID: 154518
		GridItem,
		// Token: 0x04025B97 RID: 154519
		TxtTitle
	}
}
