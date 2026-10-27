using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014AC RID: 5292
public class ActivityRegressTaskDynamicItem : UiPanelBase, IDynamicScrollBaseItem<ActivityRegressTaskDynamicData>
{
	// Token: 0x060095E2 RID: 38370 RVA: 0x002052C0 File Offset: 0x002034C0
	[NullableContext(1)]
	public UniTask Init(UUIItem actor)
	{
		ActivityRegressTaskDynamicItem.<Init>d__1 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ActivityRegressTaskDynamicItem.<Init>d__1>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060095E3 RID: 38371 RVA: 0x0020530B File Offset: 0x0020350B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060095E4 RID: 38372 RVA: 0x00205344 File Offset: 0x00203544
	[NullableContext(1)]
	public FVector2D GetItemSize(ActivityRegressTaskDynamicData data)
	{
		if (data.ItemType == ERegressTaskDynamicItemType.Item)
		{
			UUIItem item = base.GetItem(0);
			return new FVector2D(item.GetWidth(), item.GetHeight());
		}
		UUIItem item2 = base.GetItem(1);
		return new FVector2D(item2.GetWidth(), item2.GetHeight());
	}

	// Token: 0x060095E5 RID: 38373 RVA: 0x0020538D File Offset: 0x0020358D
	public void ClearItem()
	{
	}

	// Token: 0x02007ADF RID: 31455
	private class EComponents
	{
		// Token: 0x040286B8 RID: 165560
		public const int StripBtn = 0;

		// Token: 0x040286B9 RID: 165561
		public const int TitlePnl = 1;
	}
}
