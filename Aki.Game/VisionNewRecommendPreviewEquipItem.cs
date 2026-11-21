using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019BC RID: 6588
public class VisionNewRecommendPreviewEquipItem : UiPanelBase
{
	// Token: 0x0601041C RID: 66588 RVA: 0x004BF734 File Offset: 0x004BD934
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

	// Token: 0x0601041D RID: 66589 RVA: 0x004BF7BC File Offset: 0x004BD9BC
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendPreviewEquipItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendPreviewEquipItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601041E RID: 66590 RVA: 0x004BF800 File Offset: 0x004BDA00
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

	// Token: 0x04009011 RID: 36881
	[Nullable(1)]
	private readonly List<VisionNewRecommendPhantomItem> AssembleItemList = new List<VisionNewRecommendPhantomItem>();

	// Token: 0x02007BED RID: 31725
	private enum EComp
	{
		// Token: 0x0402821D RID: 164381
		VisionAssembleItem1,
		// Token: 0x0402821E RID: 164382
		VisionAssembleItem2,
		// Token: 0x0402821F RID: 164383
		VisionAssembleItem3,
		// Token: 0x04028220 RID: 164384
		VisionAssembleItem4,
		// Token: 0x04028221 RID: 164385
		VisionAssembleItem5
	}
}
