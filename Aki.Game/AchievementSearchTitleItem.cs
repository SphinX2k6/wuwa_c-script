using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020003E8 RID: 1000
[NullableContext(1)]
[Nullable(0)]
public class AchievementSearchTitleItem : UiPanelBase
{
	// Token: 0x06003655 RID: 13909 RVA: 0x0013DE1D File Offset: 0x0013C01D
	public AchievementSearchTitleItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06003656 RID: 13910 RVA: 0x0013DE2C File Offset: 0x0013C02C
	public UniTask Init()
	{
		AchievementSearchTitleItem.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementSearchTitleItem.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06003657 RID: 13911 RVA: 0x0013DE70 File Offset: 0x0013C070
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06003658 RID: 13912 RVA: 0x0013DEB8 File Offset: 0x0013C0B8
	protected override void OnStart()
	{
	}

	// Token: 0x06003659 RID: 13913 RVA: 0x0013DEBA File Offset: 0x0013C0BA
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x0600365A RID: 13914 RVA: 0x0013DEBC File Offset: 0x0013C0BC
	public void Update(AchievementSearchData data)
	{
		this.Data = data;
		this.RefreshTitle();
	}

	// Token: 0x0600365B RID: 13915 RVA: 0x0013DECB File Offset: 0x0013C0CB
	private void RefreshTitle()
	{
		if (this.Data != null)
		{
			base.GetText(0).SetText(this.Data.AchievementCategoryData.GetTitle(), true);
		}
	}

	// Token: 0x0600365C RID: 13916 RVA: 0x0013DEF4 File Offset: 0x0013C0F4
	public FVector2D GetItemSize(Vector2D vector)
	{
		UUIItem rootItem = base.GetRootItem();
		vector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
		return vector.ToUeVector2D(false);
	}

	// Token: 0x0600365D RID: 13917 RVA: 0x0013DF23 File Offset: 0x0013C123
	public AUIBaseActor GetUsingItem()
	{
		return (AUIBaseActor)base.GetRootItem().GetOwner();
	}

	// Token: 0x0600365E RID: 13918 RVA: 0x0013DF35 File Offset: 0x0013C135
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x04002D62 RID: 11618
	[Nullable(2)]
	private AchievementSearchData Data;

	// Token: 0x04002D63 RID: 11619
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x02006713 RID: 26387
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040220CD RID: 139469
		Text
	}
}
