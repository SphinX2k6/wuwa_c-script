using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F33 RID: 3891
[NullableContext(1)]
[Nullable(0)]
public class AchievementSearchTitleItem : UiPanelBase
{
	// Token: 0x060062BD RID: 25277 RVA: 0x001354F5 File Offset: 0x001336F5
	public AchievementSearchTitleItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x060062BE RID: 25278 RVA: 0x00135504 File Offset: 0x00133704
	public UniTask Init()
	{
		AchievementSearchTitleItem.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementSearchTitleItem.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060062BF RID: 25279 RVA: 0x00135548 File Offset: 0x00133748
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

	// Token: 0x060062C0 RID: 25280 RVA: 0x00135590 File Offset: 0x00133790
	protected override void OnStart()
	{
	}

	// Token: 0x060062C1 RID: 25281 RVA: 0x00135592 File Offset: 0x00133792
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x060062C2 RID: 25282 RVA: 0x00135594 File Offset: 0x00133794
	public void Update(AchievementSearchData data)
	{
		this.Data = data;
		this.RefreshTitle();
	}

	// Token: 0x060062C3 RID: 25283 RVA: 0x001355A3 File Offset: 0x001337A3
	private void RefreshTitle()
	{
		if (this.Data != null)
		{
			base.GetText(0).SetText(this.Data.AchievementCategoryData.GetTitle(), true);
		}
	}

	// Token: 0x060062C4 RID: 25284 RVA: 0x001355CC File Offset: 0x001337CC
	public FVector2D GetItemSize(Vector2D vector)
	{
		UUIItem rootItem = base.GetRootItem();
		vector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
		return vector.ToUeVector2D(false);
	}

	// Token: 0x060062C5 RID: 25285 RVA: 0x001355FB File Offset: 0x001337FB
	public AUIBaseActor GetUsingItem()
	{
		return (AUIBaseActor)base.GetRootItem().GetOwner();
	}

	// Token: 0x060062C6 RID: 25286 RVA: 0x0013560D File Offset: 0x0013380D
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x04002CC9 RID: 11465
	[Nullable(2)]
	private AchievementSearchData Data;

	// Token: 0x04002CCA RID: 11466
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x0200757F RID: 30079
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04026D82 RID: 159106
		Text
	}
}
