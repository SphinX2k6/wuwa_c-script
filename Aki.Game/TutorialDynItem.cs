using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C22 RID: 11298
[NullableContext(1)]
[Nullable(0)]
public class TutorialDynItem : UiPanelBase, IDynamicScrollBaseItem<TutorialItemData>
{
	// Token: 0x060178AC RID: 96428 RVA: 0x005FC7D4 File Offset: 0x005FA9D4
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

	// Token: 0x060178AD RID: 96429 RVA: 0x005FC820 File Offset: 0x005FAA20
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

	// Token: 0x060178AE RID: 96430 RVA: 0x005FC8A8 File Offset: 0x005FAAA8
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

	// Token: 0x060178AF RID: 96431 RVA: 0x005FC92A File Offset: 0x005FAB2A
	public void ClearItem()
	{
	}

	// Token: 0x0400AFA1 RID: 44961
	[Nullable(2)]
	private Vector2D ItemSizeVector;
}
