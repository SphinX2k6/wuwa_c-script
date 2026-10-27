using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001942 RID: 6466
public class MediumItemGridVisionFetterComponent : MediumItemGridComponent
{
	// Token: 0x0600BCF2 RID: 48370 RVA: 0x002ABE33 File Offset: 0x002AA033
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRogue";
	}

	// Token: 0x0600BCF3 RID: 48371 RVA: 0x002ABE3C File Offset: 0x002AA03C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BCF4 RID: 48372 RVA: 0x002ABEA8 File Offset: 0x002AA0A8
	protected override UniTask OnBeforeStartAsync()
	{
		MediumItemGridVisionFetterComponent.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MediumItemGridVisionFetterComponent.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BCF5 RID: 48373 RVA: 0x002ABEEB File Offset: 0x002AA0EB
	protected override void OnActivate()
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x0600BCF6 RID: 48374 RVA: 0x002ABF00 File Offset: 0x002AA100
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (!(data is int))
		{
			return;
		}
		int groupId = (int)data;
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(groupId);
		this.SetActive(true);
		VisionFetterSuitItem visionFetterSuitItem = this.VisionFetterSuitItem;
		if (visionFetterSuitItem == null)
		{
			return;
		}
		visionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
	}

	// Token: 0x04005548 RID: 21832
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02007EA2 RID: 32418
	private class EComponent
	{
		// Token: 0x04029682 RID: 169602
		public const int ElementItem = 0;

		// Token: 0x04029683 RID: 169603
		public const int ElementNumText = 1;
	}
}
