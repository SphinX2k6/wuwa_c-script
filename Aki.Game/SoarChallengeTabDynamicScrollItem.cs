using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012E0 RID: 4832
[NullableContext(1)]
[Nullable(0)]
public class SoarChallengeTabDynamicScrollItem : UiPanelBase, IDynamicScrollItem<SoarChallengePlayData>
{
	// Token: 0x06008542 RID: 34114 RVA: 0x001C56C4 File Offset: 0x001C38C4
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

	// Token: 0x06008543 RID: 34115 RVA: 0x001C5710 File Offset: 0x001C3910
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

	// Token: 0x06008544 RID: 34116 RVA: 0x001C577C File Offset: 0x001C397C
	protected override UniTask OnBeforeStartAsync()
	{
		SoarChallengeTabDynamicScrollItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SoarChallengeTabDynamicScrollItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008545 RID: 34117 RVA: 0x001C57BF File Offset: 0x001C39BF
	public AUIBaseActor GetUsingItem(SoarChallengePlayData data)
	{
		if (data.IsUnlock)
		{
			return this.GetItemActor(1);
		}
		return this.GetItemActor(0);
	}

	// Token: 0x06008546 RID: 34118 RVA: 0x001C57D8 File Offset: 0x001C39D8
	private AUIBaseActor GetItemActor(int key)
	{
		return base.GetItem(key).GetOwner() as AUIBaseActor;
	}

	// Token: 0x06008547 RID: 34119 RVA: 0x001C57EC File Offset: 0x001C39EC
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

	// Token: 0x06008548 RID: 34120 RVA: 0x001C586E File Offset: 0x001C3A6E
	public void SetSelected(bool bOn, bool bFireEvent)
	{
		this.LockItem.SetToggleState(bOn, bFireEvent && !this.Data.IsUnlock);
		this.NormalItem.SetToggleState(bOn, bFireEvent && this.Data.IsUnlock);
	}

	// Token: 0x06008549 RID: 34121 RVA: 0x001C58AD File Offset: 0x001C3AAD
	public void SetItemNewVisible(bool bVisible)
	{
		if (this.Data == null || !this.Data.IsUnlock)
		{
			return;
		}
		this.NormalItem.SetItemNewVisible(bVisible);
	}

	// Token: 0x0600854A RID: 34122 RVA: 0x001C58D1 File Offset: 0x001C3AD1
	public void BindSelectedCallBack(Action<SoarChallengePlayData> selectCallback)
	{
		this.SelectedCallBack = selectCallback;
	}

	// Token: 0x0600854B RID: 34123 RVA: 0x001C58DA File Offset: 0x001C3ADA
	public void BindIsSelectedOn(Func<SoarChallengePlayData, bool> isSelectedOn)
	{
		this.IsSelectedOn = isSelectedOn;
	}

	// Token: 0x0600854C RID: 34124 RVA: 0x001C58E3 File Offset: 0x001C3AE3
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x04003BC7 RID: 15303
	[Nullable(2)]
	private MapTravelTabItem NormalItem;

	// Token: 0x04003BC8 RID: 15304
	[Nullable(2)]
	private MapTravelTabItemLock LockItem;

	// Token: 0x04003BC9 RID: 15305
	[Nullable(2)]
	protected SoarChallengePlayData Data;

	// Token: 0x04003BCA RID: 15306
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Action<SoarChallengePlayData> SelectedCallBack;

	// Token: 0x04003BCB RID: 15307
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Func<SoarChallengePlayData, bool> IsSelectedOn;

	// Token: 0x020078F3 RID: 30963
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027D83 RID: 163203
		public const int NormalItem = 0;

		// Token: 0x04027D84 RID: 163204
		public const int LockItem = 1;
	}
}
