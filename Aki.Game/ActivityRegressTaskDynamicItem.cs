using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000960 RID: 2400
public class ActivityRegressTaskDynamicItem : UiPanelBase, IDynamicScrollBaseItem<ActivityRegressTaskDynamicData>
{
	// Token: 0x06006977 RID: 26999 RVA: 0x0020E228 File Offset: 0x0020C428
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

	// Token: 0x06006978 RID: 27000 RVA: 0x0020E273 File Offset: 0x0020C473
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06006979 RID: 27001 RVA: 0x0020E2AC File Offset: 0x0020C4AC
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

	// Token: 0x0600697A RID: 27002 RVA: 0x0020E2F5 File Offset: 0x0020C4F5
	public void ClearItem()
	{
	}

	// Token: 0x02006C63 RID: 27747
	private class EComponents
	{
		// Token: 0x040239D2 RID: 145874
		public const int StripBtn = 0;

		// Token: 0x040239D3 RID: 145875
		public const int TitlePnl = 1;
	}
}
