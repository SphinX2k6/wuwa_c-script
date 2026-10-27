using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F25 RID: 3877
[NullableContext(1)]
[Nullable(0)]
public class AchievementGroupSmallDynItem : UiPanelBase, IDynamicScrollBaseItem<AchievementGroupData>
{
	// Token: 0x0600622F RID: 25135 RVA: 0x00132F40 File Offset: 0x00131140
	public UniTask Init(UUIItem actor)
	{
		AchievementGroupSmallDynItem.<Init>d__1 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementGroupSmallDynItem.<Init>d__1>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06006230 RID: 25136 RVA: 0x00132F8C File Offset: 0x0013118C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006231 RID: 25137 RVA: 0x00133038 File Offset: 0x00131238
	public FVector2D GetItemSize(AchievementGroupData data)
	{
		if (this.ItemSizeVector == null)
		{
			this.ItemSizeVector = Vector2D.Create();
		}
		UUIItem rootItem = base.GetRootItem();
		this.ItemSizeVector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
		return this.ItemSizeVector.ToUeVector2D(false);
	}

	// Token: 0x06006232 RID: 25138 RVA: 0x00133084 File Offset: 0x00131284
	public void ClearItem()
	{
	}

	// Token: 0x04002C95 RID: 11413
	[Nullable(2)]
	private Vector2D ItemSizeVector;
}
