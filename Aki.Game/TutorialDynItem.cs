using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200219D RID: 8605
[NullableContext(1)]
[Nullable(0)]
public class TutorialDynItem : UiPanelBase, IDynamicScrollBaseItem<TutorialItemData>
{
	// Token: 0x060152DE RID: 86750 RVA: 0x006291F8 File Offset: 0x006273F8
	public UniTask Init(UUIItem actor)
	{
		TutorialDynItem.<Init>d__1 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<TutorialDynItem.<Init>d__1>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060152DF RID: 86751 RVA: 0x00629244 File Offset: 0x00627444
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
	}

	// Token: 0x060152E0 RID: 86752 RVA: 0x006292CC File Offset: 0x006274CC
	public FVector2D GetItemSize(TutorialItemData data)
	{
		if (this.ItemSizeVector == null)
		{
			this.ItemSizeVector = Vector2D.Create();
		}
		if (data.IsTypeTitle)
		{
			UUIItem item = base.GetItem(0);
			this.ItemSizeVector.Set((double)item.GetWidth(), (double)item.GetHeight());
			return this.ItemSizeVector.ToUeVector2D(false);
		}
		UUIItem rootItem = base.GetRootItem();
		this.ItemSizeVector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
		return this.ItemSizeVector.ToUeVector2D(false);
	}

	// Token: 0x060152E1 RID: 86753 RVA: 0x0062934E File Offset: 0x0062754E
	public void ClearItem()
	{
	}

	// Token: 0x0400B3A6 RID: 45990
	[Nullable(2)]
	private Vector2D ItemSizeVector;
}
