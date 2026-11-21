using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000794 RID: 1940
[NullableContext(1)]
[Nullable(0)]
public class SoarChallengeTabDynamicScrollItem : UiPanelBase, IDynamicScrollItem<SoarChallengePlayData>
{
	// Token: 0x060058DD RID: 22749 RVA: 0x001CE520 File Offset: 0x001CC720
	public UniTask Init(UUIItem actor)
	{
		SoarChallengeTabDynamicScrollItem.<Init>d__5 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<SoarChallengeTabDynamicScrollItem.<Init>d__5>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060058DE RID: 22750 RVA: 0x001CE56C File Offset: 0x001CC76C
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

	// Token: 0x060058DF RID: 22751 RVA: 0x001CE5D8 File Offset: 0x001CC7D8
	protected override UniTask OnBeforeStartAsync()
	{
		SoarChallengeTabDynamicScrollItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SoarChallengeTabDynamicScrollItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060058E0 RID: 22752 RVA: 0x001CE61B File Offset: 0x001CC81B
	public AUIBaseActor GetUsingItem(SoarChallengePlayData data)
	{
		if (data.IsUnlock)
		{
			return this.GetItemActor(1);
		}
		return this.GetItemActor(0);
	}

	// Token: 0x060058E1 RID: 22753 RVA: 0x001CE634 File Offset: 0x001CC834
	private AUIBaseActor GetItemActor(int key)
	{
		return base.GetItem(key).GetOwner() as AUIBaseActor;
	}

	// Token: 0x060058E2 RID: 22754 RVA: 0x001CE648 File Offset: 0x001CC848
	public void Update(SoarChallengePlayData data, int index)
	{
		this.Data = data;
		this.LockItem.SetUiActive(!data.IsUnlock);
		this.NormalItem.SetUiActive(data.IsUnlock);
		if (!data.IsUnlock)
		{
			this.LockItem.RefreshByData(data);
		}
		else
		{
			this.NormalItem.RefreshByData(data);
		}
		if (this.IsSelectedOn != null && this.IsSelectedOn(data))
		{
			this.SetSelected(true, false);
			return;
		}
		this.SetSelected(false, false);
	}

	// Token: 0x060058E3 RID: 22755 RVA: 0x001CE6CA File Offset: 0x001CC8CA
	public void SetSelected(bool bOn, bool bFireEvent)
	{
		this.LockItem.SetToggleState(bOn, bFireEvent && !this.Data.IsUnlock);
		this.NormalItem.SetToggleState(bOn, bFireEvent && this.Data.IsUnlock);
	}

	// Token: 0x060058E4 RID: 22756 RVA: 0x001CE709 File Offset: 0x001CC909
	public void SetItemNewVisible(bool bVisible)
	{
		if (this.Data == null || !this.Data.IsUnlock)
		{
			return;
		}
		this.NormalItem.SetItemNewVisible(bVisible);
	}

	// Token: 0x060058E5 RID: 22757 RVA: 0x001CE72D File Offset: 0x001CC92D
	public void BindSelectedCallBack(Action<SoarChallengePlayData> selectCallback)
	{
		this.SelectedCallBack = selectCallback;
	}

	// Token: 0x060058E6 RID: 22758 RVA: 0x001CE736 File Offset: 0x001CC936
	public void BindIsSelectedOn(Func<SoarChallengePlayData, bool> isSelectedOn)
	{
		this.IsSelectedOn = isSelectedOn;
	}

	// Token: 0x060058E7 RID: 22759 RVA: 0x001CE73F File Offset: 0x001CC93F
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x04003C5F RID: 15455
	[Nullable(2)]
	private MapTravelTabItem NormalItem;

	// Token: 0x04003C60 RID: 15456
	[Nullable(2)]
	private MapTravelTabItemLock LockItem;

	// Token: 0x04003C61 RID: 15457
	[Nullable(2)]
	protected SoarChallengePlayData Data;

	// Token: 0x04003C62 RID: 15458
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Action<SoarChallengePlayData> SelectedCallBack;

	// Token: 0x04003C63 RID: 15459
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Func<SoarChallengePlayData, bool> IsSelectedOn;

	// Token: 0x02006A7D RID: 27261
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040230B1 RID: 143537
		public const int NormalItem = 0;

		// Token: 0x040230B2 RID: 143538
		public const int LockItem = 1;
	}
}
