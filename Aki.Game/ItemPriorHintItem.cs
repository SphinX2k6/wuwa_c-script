using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014D8 RID: 5336
public class ItemPriorHintItem : ItemHintItem
{
	// Token: 0x0600D5A3 RID: 54691 RVA: 0x003F731C File Offset: 0x003F551C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUISprite))
		};
	}

	// Token: 0x0600D5A4 RID: 54692 RVA: 0x003F73B8 File Offset: 0x003F55B8
	public override UniTask AsyncLoadUiResource()
	{
		ItemPriorHintItem.<AsyncLoadUiResource>d__2 <AsyncLoadUiResource>d__;
		<AsyncLoadUiResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AsyncLoadUiResource>d__.<>4__this = this;
		<AsyncLoadUiResource>d__.<>1__state = -1;
		<AsyncLoadUiResource>d__.<>t__builder.Start<ItemPriorHintItem.<AsyncLoadUiResource>d__2>(ref <AsyncLoadUiResource>d__);
		return <AsyncLoadUiResource>d__.<>t__builder.Task;
	}

	// Token: 0x02007793 RID: 30611
	private enum EItemPriorHintItemCom
	{
		// Token: 0x04026D14 RID: 158996
		ItemIcon,
		// Token: 0x04026D15 RID: 158997
		ItemNameText,
		// Token: 0x04026D16 RID: 158998
		ItemCountText,
		// Token: 0x04026D17 RID: 158999
		ItemXText,
		// Token: 0x04026D18 RID: 159000
		QualityTexture,
		// Token: 0x04026D19 RID: 159001
		QualitySprite
	}
}
