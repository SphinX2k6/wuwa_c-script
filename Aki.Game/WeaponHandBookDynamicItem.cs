using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E46 RID: 7750
public class WeaponHandBookDynamicItem : UiPanelBase, IDynamicScrollBaseItem<WeaponHandBookDynamicData>
{
	// Token: 0x0600EBB3 RID: 60339 RVA: 0x0037EFCC File Offset: 0x0037D1CC
	[NullableContext(1)]
	public UniTask Init(UUIItem actor)
	{
		WeaponHandBookDynamicItem.<Init>d__1 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<WeaponHandBookDynamicItem.<Init>d__1>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600EBB4 RID: 60340 RVA: 0x0037F017 File Offset: 0x0037D217
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600EBB5 RID: 60341 RVA: 0x0037F050 File Offset: 0x0037D250
	[NullableContext(1)]
	public FVector2D GetItemSize(WeaponHandBookDynamicData data)
	{
		if (!string.IsNullOrEmpty(data.TitleId))
		{
			UUIItem item = base.GetItem(0);
			return new FVector2D(item.GetWidth(), item.GetHeight());
		}
		UUIItem item2 = base.GetItem(1);
		return new FVector2D(item2.GetWidth(), item2.GetHeight());
	}

	// Token: 0x0600EBB6 RID: 60342 RVA: 0x0037F09D File Offset: 0x0037D29D
	public void ClearItem()
	{
	}

	// Token: 0x020083F5 RID: 33781
	private class EWeaponDynamicItemDefine
	{
		// Token: 0x0402AF4F RID: 175951
		public const int TitleItem = 0;

		// Token: 0x0402AF50 RID: 175952
		public const int LayoutItem = 1;
	}
}
