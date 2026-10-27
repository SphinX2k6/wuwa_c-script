using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E2E RID: 7726
public class MonsterHandBookDynamicItem : UiPanelBase, IDynamicScrollBaseItem<MonsterHandBookDynamicData>
{
	// Token: 0x0600EAF3 RID: 60147 RVA: 0x0037AAF0 File Offset: 0x00378CF0
	[NullableContext(1)]
	public UniTask Init(UUIItem actor)
	{
		MonsterHandBookDynamicItem.<Init>d__1 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<MonsterHandBookDynamicItem.<Init>d__1>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600EAF4 RID: 60148 RVA: 0x0037AB3B File Offset: 0x00378D3B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600EAF5 RID: 60149 RVA: 0x0037AB74 File Offset: 0x00378D74
	[NullableContext(1)]
	public FVector2D GetItemSize(MonsterHandBookDynamicData data)
	{
		if (!string.IsNullOrEmpty(data.TitleId))
		{
			UUIItem item = base.GetItem(0);
			return new FVector2D(item.GetWidth(), item.GetHeight());
		}
		UUIItem item2 = base.GetItem(1);
		return new FVector2D(item2.GetWidth(), item2.GetHeight());
	}

	// Token: 0x0600EAF6 RID: 60150 RVA: 0x0037ABC1 File Offset: 0x00378DC1
	public void ClearItem()
	{
	}

	// Token: 0x020083E2 RID: 33762
	private class EMonsterDynamicItemDefine
	{
		// Token: 0x0402AEEB RID: 175851
		public const int TitleItem = 0;

		// Token: 0x0402AEEC RID: 175852
		public const int LayoutItem = 1;
	}
}
