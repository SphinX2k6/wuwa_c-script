using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000DFE RID: 3582
public class MediumItemGridVisionFetterComponent : MediumItemGridComponent
{
	// Token: 0x060090ED RID: 37101 RVA: 0x002B68FF File Offset: 0x002B4AFF
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRogue";
	}

	// Token: 0x060090EE RID: 37102 RVA: 0x002B6908 File Offset: 0x002B4B08
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

	// Token: 0x060090EF RID: 37103 RVA: 0x002B6974 File Offset: 0x002B4B74
	protected override UniTask OnBeforeStartAsync()
	{
		MediumItemGridVisionFetterComponent.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MediumItemGridVisionFetterComponent.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060090F0 RID: 37104 RVA: 0x002B69B7 File Offset: 0x002B4BB7
	protected override void OnActivate()
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x060090F1 RID: 37105 RVA: 0x002B69CC File Offset: 0x002B4BCC
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

	// Token: 0x040055F5 RID: 22005
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x0200702F RID: 28719
	private class EComponent
	{
		// Token: 0x040249BA RID: 149946
		public const int ElementItem = 0;

		// Token: 0x040249BB RID: 149947
		public const int ElementNumText = 1;
	}
}
