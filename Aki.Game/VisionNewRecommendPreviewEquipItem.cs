using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024D5 RID: 9429
public class VisionNewRecommendPreviewEquipItem : UiPanelBase
{
	// Token: 0x06012F5D RID: 77661 RVA: 0x004B1B34 File Offset: 0x004AFD34
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06012F5E RID: 77662 RVA: 0x004B1BBC File Offset: 0x004AFDBC
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendPreviewEquipItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendPreviewEquipItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012F5F RID: 77663 RVA: 0x004B1C00 File Offset: 0x004AFE00
	public void Update([Nullable(new byte[]
	{
		1,
		2
	})] List<VisionNewRecommendPhantomItemData> data)
	{
		for (int i = 0; i < this.AssembleItemList.Count; i++)
		{
			VisionNewRecommendPhantomItemData visionNewRecommendPhantomItemData = (i < data.Count) ? data[i] : null;
			if (visionNewRecommendPhantomItemData != null)
			{
				this.AssembleItemList[i].Update(visionNewRecommendPhantomItemData);
			}
			else
			{
				this.AssembleItemList[i].Reset();
			}
		}
	}

	// Token: 0x04008EC7 RID: 36551
	[Nullable(1)]
	private readonly List<VisionNewRecommendPhantomItem> AssembleItemList = new List<VisionNewRecommendPhantomItem>();

	// Token: 0x02008A64 RID: 35428
	private enum EComp
	{
		// Token: 0x0402CEFF RID: 184063
		VisionAssembleItem1,
		// Token: 0x0402CF00 RID: 184064
		VisionAssembleItem2,
		// Token: 0x0402CF01 RID: 184065
		VisionAssembleItem3,
		// Token: 0x0402CF02 RID: 184066
		VisionAssembleItem4,
		// Token: 0x0402CF03 RID: 184067
		VisionAssembleItem5
	}
}
