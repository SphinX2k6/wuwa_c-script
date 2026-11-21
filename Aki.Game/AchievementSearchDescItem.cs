using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020003E3 RID: 995
[NullableContext(1)]
[Nullable(0)]
public class AchievementSearchDescItem : UiPanelBase
{
	// Token: 0x0600362C RID: 13868 RVA: 0x0013D6C4 File Offset: 0x0013B8C4
	public AchievementSearchDescItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x0600362D RID: 13869 RVA: 0x0013D6D4 File Offset: 0x0013B8D4
	public UniTask Init()
	{
		AchievementSearchDescItem.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementSearchDescItem.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600362E RID: 13870 RVA: 0x0013D718 File Offset: 0x0013B918
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

	// Token: 0x0600362F RID: 13871 RVA: 0x0013D760 File Offset: 0x0013B960
	protected override void OnStart()
	{
	}

	// Token: 0x06003630 RID: 13872 RVA: 0x0013D762 File Offset: 0x0013B962
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06003631 RID: 13873 RVA: 0x0013D764 File Offset: 0x0013B964
	public void Update(AchievementSearchData data)
	{
		this.Data = data;
		this.RefreshDesc();
	}

	// Token: 0x06003632 RID: 13874 RVA: 0x0013D773 File Offset: 0x0013B973
	private void RefreshDesc()
	{
		if (this.Data != null)
		{
			base.GetText(0).SetText(this.Data.AchievementSearchGroupData.AchievementGroupData.GetTitle(), true);
		}
	}

	// Token: 0x06003633 RID: 13875 RVA: 0x0013D7A0 File Offset: 0x0013B9A0
	public FVector2D GetItemSize(Vector2D vector)
	{
		UUIItem rootItem = base.GetRootItem();
		vector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
		return vector.ToUeVector2D(false);
	}

	// Token: 0x06003634 RID: 13876 RVA: 0x0013D7CF File Offset: 0x0013B9CF
	public AUIBaseActor GetUsingItem()
	{
		return (AUIBaseActor)base.GetRootItem().GetOwner();
	}

	// Token: 0x06003635 RID: 13877 RVA: 0x0013D7E1 File Offset: 0x0013B9E1
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x04002D52 RID: 11602
	[Nullable(2)]
	private AchievementSearchData Data;

	// Token: 0x04002D53 RID: 11603
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x0200670B RID: 26379
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040220AE RID: 139438
		Text
	}
}
