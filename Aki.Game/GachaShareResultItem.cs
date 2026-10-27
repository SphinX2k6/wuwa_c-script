using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CA1 RID: 7329
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GachaShareResultItem : GridProxyAbstract<GachaResult>
{
	// Token: 0x0600DD51 RID: 56657 RVA: 0x0033C548 File Offset: 0x0033A748
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x0600DD52 RID: 56658 RVA: 0x0033C5A4 File Offset: 0x0033A7A4
	protected override UniTask OnBeforeStartAsync()
	{
		GachaShareResultItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaShareResultItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DD53 RID: 56659 RVA: 0x0033C5E8 File Offset: 0x0033A7E8
	public void Refresh(GachaResult data)
	{
		GachaResultItemNew infoItem = this.InfoItem;
		if (infoItem != null)
		{
			infoItem.Update(data);
		}
		GachaResultItemNew infoItem2 = this.InfoItem;
		if (infoItem2 != null)
		{
			infoItem2.RefreshShare();
		}
		if (data.Proto_GachaReward == null)
		{
			return;
		}
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(data.Proto_GachaReward.ItemId);
		if (itemConfigData == null)
		{
			return;
		}
		int qualityId = itemConfigData.QualityId;
		base.GetItem(1).SetUIActive(qualityId < 4);
		base.GetTexture(2).SetUIActive(qualityId >= 4);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath((qualityId == 5) ? "UiTexture_ShareFrameGold" : "UiTexture_ShareFramePurple");
		if (!string.IsNullOrEmpty(resourcePath))
		{
			base.SetTextureByPath(resourcePath, base.GetTexture(2), null, null);
		}
	}

	// Token: 0x0600DD54 RID: 56660 RVA: 0x0033C6A0 File Offset: 0x0033A8A0
	public override void Refresh(GachaResult data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x04006596 RID: 26006
	[Nullable(2)]
	private GachaResultItemNew InfoItem;

	// Token: 0x02008286 RID: 33414
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A965 RID: 174437
		CommonItem,
		// Token: 0x0402A966 RID: 174438
		CommonFrame,
		// Token: 0x0402A967 RID: 174439
		TextureFrame
	}
}
