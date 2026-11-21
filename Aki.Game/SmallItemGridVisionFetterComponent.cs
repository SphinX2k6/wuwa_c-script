using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000E54 RID: 3668
public class SmallItemGridVisionFetterComponent : SmallItemGridComponent
{
	// Token: 0x0600935D RID: 37725 RVA: 0x002BEB4A File Offset: 0x002BCD4A
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBElementB";
	}

	// Token: 0x0600935E RID: 37726 RVA: 0x002BEB54 File Offset: 0x002BCD54
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600935F RID: 37727 RVA: 0x002BEB9C File Offset: 0x002BCD9C
	protected override UniTask OnBeforeStartAsync()
	{
		SmallItemGridVisionFetterComponent.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SmallItemGridVisionFetterComponent.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009360 RID: 37728 RVA: 0x002BEBE0 File Offset: 0x002BCDE0
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById((int)data);
		this.SetActive(true);
		this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
	}

	// Token: 0x04005683 RID: 22147
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x0200705E RID: 28766
	private enum EComponent
	{
		// Token: 0x04024A57 RID: 150103
		ElementItem
	}
}
