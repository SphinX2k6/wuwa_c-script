using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000A58 RID: 2648
public class WheelTowerBuffGridItem : GridProxyAbstract<int>
{
	// Token: 0x0600716E RID: 29038 RVA: 0x0022CF20 File Offset: 0x0022B120
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600716F RID: 29039 RVA: 0x0022CF68 File Offset: 0x0022B168
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerBuffGridItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerBuffGridItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007170 RID: 29040 RVA: 0x0022CFAC File Offset: 0x0022B1AC
	protected override void OnStart()
	{
		MediumItemGrid gridItem = this.GridItem;
		if (gridItem != null)
		{
			gridItem.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		}
		MediumItemGrid gridItem2 = this.GridItem;
		if (gridItem2 == null)
		{
			return;
		}
		gridItem2.SetToggleInteractive(false);
	}

	// Token: 0x06007171 RID: 29041 RVA: 0x0022CFFC File Offset: 0x0022B1FC
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		NewTowerBuff? buffConfigById = WheelTowerConfig.Instance.GetBuffConfigById(data);
		if (buffConfigById == null)
		{
			return;
		}
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			IconPath = buffConfigById.Value.Icon,
			BottomTextId = buffConfigById.Value.Name,
			IsQualityHidden = new bool?(true)
		};
		MediumItemGrid gridItem = this.GridItem;
		if (gridItem == null)
		{
			return;
		}
		gridItem.Apply<PropMediumItemGrid>(parameters);
	}

	// Token: 0x0400461F RID: 17951
	[Nullable(2)]
	private MediumItemGrid GridItem;
}
