using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001160 RID: 4448
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GachaShareResultItem : GridProxyAbstract<GachaResult>
{
	// Token: 0x0600B167 RID: 45415 RVA: 0x00347994 File Offset: 0x00345B94
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x0600B168 RID: 45416 RVA: 0x003479F0 File Offset: 0x00345BF0
	protected override UniTask OnBeforeStartAsync()
	{
		GachaShareResultItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaShareResultItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B169 RID: 45417 RVA: 0x00347A34 File Offset: 0x00345C34
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

	// Token: 0x0600B16A RID: 45418 RVA: 0x00347AEC File Offset: 0x00345CEC
	public override void Refresh(GachaResult data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x04006667 RID: 26215
	[Nullable(2)]
	private GachaResultItemNew InfoItem;

	// Token: 0x0200740D RID: 29709
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04025C83 RID: 154755
		CommonItem,
		// Token: 0x04025C84 RID: 154756
		CommonFrame,
		// Token: 0x04025C85 RID: 154757
		TextureFrame
	}
}
