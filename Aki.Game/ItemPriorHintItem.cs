using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002005 RID: 8197
public class ItemPriorHintItem : ItemHintItem
{
	// Token: 0x0601013B RID: 65851 RVA: 0x003EAD24 File Offset: 0x003E8F24
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

	// Token: 0x0601013C RID: 65852 RVA: 0x003EADC0 File Offset: 0x003E8FC0
	public override UniTask AsyncLoadUiResource()
	{
		ItemPriorHintItem.<AsyncLoadUiResource>d__2 <AsyncLoadUiResource>d__;
		<AsyncLoadUiResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AsyncLoadUiResource>d__.<>4__this = this;
		<AsyncLoadUiResource>d__.<>1__state = -1;
		<AsyncLoadUiResource>d__.<>t__builder.Start<ItemPriorHintItem.<AsyncLoadUiResource>d__2>(ref <AsyncLoadUiResource>d__);
		return <AsyncLoadUiResource>d__.<>t__builder.Task;
	}

	// Token: 0x0200860C RID: 34316
	private enum EItemPriorHintItemCom
	{
		// Token: 0x0402BA05 RID: 178693
		ItemIcon,
		// Token: 0x0402BA06 RID: 178694
		ItemNameText,
		// Token: 0x0402BA07 RID: 178695
		ItemCountText,
		// Token: 0x0402BA08 RID: 178696
		ItemXText,
		// Token: 0x0402BA09 RID: 178697
		QualityTexture,
		// Token: 0x0402BA0A RID: 178698
		QualitySprite
	}
}
