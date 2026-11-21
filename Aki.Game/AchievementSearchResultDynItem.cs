using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020003E5 RID: 997
[NullableContext(1)]
[Nullable(0)]
public class AchievementSearchResultDynItem : UiPanelBase, IDynamicScrollBaseItem<AchievementSearchData>
{
	// Token: 0x06003645 RID: 13893 RVA: 0x0013DAB8 File Offset: 0x0013BCB8
	public UniTask Init(UUIItem actor)
	{
		AchievementSearchResultDynItem.<Init>d__2 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementSearchResultDynItem.<Init>d__2>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06003646 RID: 13894 RVA: 0x0013DB04 File Offset: 0x0013BD04
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06003647 RID: 13895 RVA: 0x0013DB70 File Offset: 0x0013BD70
	protected override void OnStart()
	{
		this.DescVec = Vector2D.Create();
		UUIItem item = base.GetItem(0);
		this.DescVec.Set((double)item.GetWidth(), (double)item.GetHeight());
		this.ItemVec = Vector2D.Create();
		item = base.GetItem(1);
		this.ItemVec.Set((double)item.GetWidth(), (double)item.GetHeight());
	}

	// Token: 0x06003648 RID: 13896 RVA: 0x0013DBD5 File Offset: 0x0013BDD5
	public FVector2D GetItemSize(AchievementSearchData data)
	{
		if (data.AchievementSearchGroupData != null)
		{
			return this.DescVec.ToUeVector2D(false);
		}
		if (data.AchievementData != null)
		{
			return this.ItemVec.ToUeVector2D(false);
		}
		return new Vector2D().ToUeVector2D(false);
	}

	// Token: 0x06003649 RID: 13897 RVA: 0x0013DC0C File Offset: 0x0013BE0C
	public void ClearItem()
	{
	}

	// Token: 0x04002D59 RID: 11609
	[Nullable(2)]
	private Vector2D DescVec;

	// Token: 0x04002D5A RID: 11610
	[Nullable(2)]
	private Vector2D ItemVec;
}
