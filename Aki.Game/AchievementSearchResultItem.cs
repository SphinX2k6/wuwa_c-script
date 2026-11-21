using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020003E7 RID: 999
[NullableContext(2)]
[Nullable(0)]
public class AchievementSearchResultItem : UiPanelBase, IDynamicScrollItem<AchievementSearchData>
{
	// Token: 0x0600364C RID: 13900 RVA: 0x0013DC24 File Offset: 0x0013BE24
	[NullableContext(1)]
	public UniTask Init(UUIItem actor)
	{
		AchievementSearchResultItem.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementSearchResultItem.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600364D RID: 13901 RVA: 0x0013DC70 File Offset: 0x0013BE70
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

	// Token: 0x0600364E RID: 13902 RVA: 0x0013DCDC File Offset: 0x0013BEDC
	protected override UniTask OnBeforeStartAsync()
	{
		AchievementSearchResultItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AchievementSearchResultItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600364F RID: 13903 RVA: 0x0013DD1F File Offset: 0x0013BF1F
	[NullableContext(1)]
	[return: Nullable(2)]
	public AUIBaseActor GetUsingItem(AchievementSearchData data)
	{
		if (data.AchievementSearchGroupData != null)
		{
			return (AUIBaseActor)base.GetItem(0).GetOwner();
		}
		if (data.AchievementData != null)
		{
			return (AUIBaseActor)base.GetItem(1).GetOwner();
		}
		return null;
	}

	// Token: 0x06003650 RID: 13904 RVA: 0x0013DD58 File Offset: 0x0013BF58
	[NullableContext(1)]
	public void Update(AchievementSearchData data, int index)
	{
		this.Data = data;
		this.DescItem.SetActive(false);
		this.ContentItem.SetActive(false);
		if (data.AchievementSearchGroupData != null)
		{
			this.DescItem.SetActive(true);
			this.DescItem.Update(data);
			return;
		}
		if (data.AchievementData != null)
		{
			this.ContentItem.SetActive(true);
			this.ContentItem.RefreshUi(data.AchievementData);
		}
	}

	// Token: 0x06003651 RID: 13905 RVA: 0x0013DDCA File Offset: 0x0013BFCA
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x06003652 RID: 13906 RVA: 0x0013DDD3 File Offset: 0x0013BFD3
	protected override void OnBeforeDestroy()
	{
		if (this.DescItem != null)
		{
			this.DescItem.ClearItem();
		}
		if (this.ContentItem != null)
		{
			this.ContentItem.ClearItem();
		}
		if (this.VectorValue != null)
		{
			this.VectorValue = null;
		}
	}

	// Token: 0x04002D5E RID: 11614
	protected AchievementSearchData Data;

	// Token: 0x04002D5F RID: 11615
	private AchievementSearchDescItem DescItem;

	// Token: 0x04002D60 RID: 11616
	private AchievementDataItem ContentItem;

	// Token: 0x04002D61 RID: 11617
	private Vector2D VectorValue;
}
