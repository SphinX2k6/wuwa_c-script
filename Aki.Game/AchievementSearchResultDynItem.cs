using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F30 RID: 3888
[NullableContext(1)]
[Nullable(0)]
public class AchievementSearchResultDynItem : UiPanelBase, IDynamicScrollBaseItem<AchievementSearchData>
{
	// Token: 0x060062AD RID: 25261 RVA: 0x00135190 File Offset: 0x00133390
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

	// Token: 0x060062AE RID: 25262 RVA: 0x001351DC File Offset: 0x001333DC
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

	// Token: 0x060062AF RID: 25263 RVA: 0x00135248 File Offset: 0x00133448
	protected override void OnStart()
	{
		this.DescVec = Vector2D.Create();
		UUIItem item = base.GetItem(0);
		this.DescVec.Set((double)item.GetWidth(), (double)item.GetHeight());
		this.ItemVec = Vector2D.Create();
		item = base.GetItem(1);
		this.ItemVec.Set((double)item.GetWidth(), (double)item.GetHeight());
	}

	// Token: 0x060062B0 RID: 25264 RVA: 0x001352AD File Offset: 0x001334AD
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

	// Token: 0x060062B1 RID: 25265 RVA: 0x001352E4 File Offset: 0x001334E4
	public void ClearItem()
	{
	}

	// Token: 0x04002CC0 RID: 11456
	[Nullable(2)]
	private Vector2D DescVec;

	// Token: 0x04002CC1 RID: 11457
	[Nullable(2)]
	private Vector2D ItemVec;
}
