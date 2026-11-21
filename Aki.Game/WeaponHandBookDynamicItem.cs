using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001308 RID: 4872
public class WeaponHandBookDynamicItem : UiPanelBase, IDynamicScrollBaseItem<WeaponHandBookDynamicData>
{
	// Token: 0x0600BFD2 RID: 49106 RVA: 0x0038AC5C File Offset: 0x00388E5C
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

	// Token: 0x0600BFD3 RID: 49107 RVA: 0x0038ACA7 File Offset: 0x00388EA7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600BFD4 RID: 49108 RVA: 0x0038ACE0 File Offset: 0x00388EE0
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

	// Token: 0x0600BFD5 RID: 49109 RVA: 0x0038AD2D File Offset: 0x00388F2D
	public void ClearItem()
	{
	}

	// Token: 0x0200757A RID: 30074
	private class EWeaponDynamicItemDefine
	{
		// Token: 0x04026273 RID: 156275
		public const int TitleItem = 0;

		// Token: 0x04026274 RID: 156276
		public const int LayoutItem = 1;
	}
}
