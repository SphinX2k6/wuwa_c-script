using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001997 RID: 6551
public class SmallItemGridVisionFetterComponent : SmallItemGridComponent
{
	// Token: 0x0600BF55 RID: 48981 RVA: 0x002B3BC6 File Offset: 0x002B1DC6
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBElementB";
	}

	// Token: 0x0600BF56 RID: 48982 RVA: 0x002B3BD0 File Offset: 0x002B1DD0
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

	// Token: 0x0600BF57 RID: 48983 RVA: 0x002B3C18 File Offset: 0x002B1E18
	protected override UniTask OnBeforeStartAsync()
	{
		SmallItemGridVisionFetterComponent.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SmallItemGridVisionFetterComponent.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BF58 RID: 48984 RVA: 0x002B3C5C File Offset: 0x002B1E5C
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById((int)data);
		this.SetActive(true);
		this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
	}

	// Token: 0x040055D6 RID: 21974
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02007ECF RID: 32463
	private enum EComponent
	{
		// Token: 0x0402971A RID: 169754
		ElementItem
	}
}
