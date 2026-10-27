using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F32 RID: 3890
[NullableContext(2)]
[Nullable(0)]
public class AchievementSearchResultItem : UiPanelBase, IDynamicScrollItem<AchievementSearchData>
{
	// Token: 0x060062B4 RID: 25268 RVA: 0x001352FC File Offset: 0x001334FC
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

	// Token: 0x060062B5 RID: 25269 RVA: 0x00135348 File Offset: 0x00133548
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

	// Token: 0x060062B6 RID: 25270 RVA: 0x001353B4 File Offset: 0x001335B4
	protected override UniTask OnBeforeStartAsync()
	{
		AchievementSearchResultItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AchievementSearchResultItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060062B7 RID: 25271 RVA: 0x001353F7 File Offset: 0x001335F7
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

	// Token: 0x060062B8 RID: 25272 RVA: 0x00135430 File Offset: 0x00133630
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

	// Token: 0x060062B9 RID: 25273 RVA: 0x001354A2 File Offset: 0x001336A2
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x060062BA RID: 25274 RVA: 0x001354AB File Offset: 0x001336AB
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

	// Token: 0x04002CC5 RID: 11461
	protected AchievementSearchData Data;

	// Token: 0x04002CC6 RID: 11462
	private AchievementSearchDescItem DescItem;

	// Token: 0x04002CC7 RID: 11463
	private AchievementDataItem ContentItem;

	// Token: 0x04002CC8 RID: 11464
	private Vector2D VectorValue;
}
