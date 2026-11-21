using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012F0 RID: 4848
public class MonsterHandBookDynamicItem : UiPanelBase, IDynamicScrollBaseItem<MonsterHandBookDynamicData>
{
	// Token: 0x0600BF12 RID: 48914 RVA: 0x0038677C File Offset: 0x0038497C
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

	// Token: 0x0600BF13 RID: 48915 RVA: 0x003867C7 File Offset: 0x003849C7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600BF14 RID: 48916 RVA: 0x00386800 File Offset: 0x00384A00
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

	// Token: 0x0600BF15 RID: 48917 RVA: 0x0038684D File Offset: 0x00384A4D
	public void ClearItem()
	{
	}

	// Token: 0x02007567 RID: 30055
	private class EMonsterDynamicItemDefine
	{
		// Token: 0x0402620E RID: 156174
		public const int TitleItem = 0;

		// Token: 0x0402620F RID: 156175
		public const int LayoutItem = 1;
	}
}
