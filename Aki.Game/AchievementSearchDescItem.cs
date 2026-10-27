using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F2E RID: 3886
[NullableContext(1)]
[Nullable(0)]
public class AchievementSearchDescItem : UiPanelBase
{
	// Token: 0x06006294 RID: 25236 RVA: 0x00134D9C File Offset: 0x00132F9C
	public AchievementSearchDescItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06006295 RID: 25237 RVA: 0x00134DAC File Offset: 0x00132FAC
	public UniTask Init()
	{
		AchievementSearchDescItem.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementSearchDescItem.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06006296 RID: 25238 RVA: 0x00134DF0 File Offset: 0x00132FF0
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

	// Token: 0x06006297 RID: 25239 RVA: 0x00134E38 File Offset: 0x00133038
	protected override void OnStart()
	{
	}

	// Token: 0x06006298 RID: 25240 RVA: 0x00134E3A File Offset: 0x0013303A
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06006299 RID: 25241 RVA: 0x00134E3C File Offset: 0x0013303C
	public void Update(AchievementSearchData data)
	{
		this.Data = data;
		this.RefreshDesc();
	}

	// Token: 0x0600629A RID: 25242 RVA: 0x00134E4B File Offset: 0x0013304B
	private void RefreshDesc()
	{
		if (this.Data != null)
		{
			base.GetText(0).SetText(this.Data.AchievementSearchGroupData.AchievementGroupData.GetTitle(), true);
		}
	}

	// Token: 0x0600629B RID: 25243 RVA: 0x00134E78 File Offset: 0x00133078
	public FVector2D GetItemSize(Vector2D vector)
	{
		UUIItem rootItem = base.GetRootItem();
		vector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
		return vector.ToUeVector2D(false);
	}

	// Token: 0x0600629C RID: 25244 RVA: 0x00134EA7 File Offset: 0x001330A7
	public AUIBaseActor GetUsingItem()
	{
		return (AUIBaseActor)base.GetRootItem().GetOwner();
	}

	// Token: 0x0600629D RID: 25245 RVA: 0x00134EB9 File Offset: 0x001330B9
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x04002CB9 RID: 11449
	[Nullable(2)]
	private AchievementSearchData Data;

	// Token: 0x04002CBA RID: 11450
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x02007577 RID: 30071
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04026D63 RID: 159075
		Text
	}
}
