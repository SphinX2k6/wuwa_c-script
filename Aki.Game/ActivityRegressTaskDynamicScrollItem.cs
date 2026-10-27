using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014AD RID: 5293
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressTaskDynamicScrollItem : UiPanelBase, IDynamicScrollItem<ActivityRegressTaskDynamicData>
{
	// Token: 0x060095E7 RID: 38375 RVA: 0x00205398 File Offset: 0x00203598
	public UniTask Init(UUIItem actor)
	{
		ActivityRegressTaskDynamicScrollItem.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ActivityRegressTaskDynamicScrollItem.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060095E8 RID: 38376 RVA: 0x002053E3 File Offset: 0x002035E3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060095E9 RID: 38377 RVA: 0x0020541C File Offset: 0x0020361C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressTaskDynamicScrollItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressTaskDynamicScrollItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060095EA RID: 38378 RVA: 0x0020545F File Offset: 0x0020365F
	[return: Nullable(2)]
	public AUIBaseActor GetUsingItem(ActivityRegressTaskDynamicData data)
	{
		if (data.ItemType == ERegressTaskDynamicItemType.Title)
		{
			return this.GetItemActor(1);
		}
		if (data.ItemType == ERegressTaskDynamicItemType.Item)
		{
			return this.GetItemActor(0);
		}
		return null;
	}

	// Token: 0x060095EB RID: 38379 RVA: 0x00205483 File Offset: 0x00203683
	private AUIBaseActor GetItemActor(int key)
	{
		return (AUIBaseActor)base.GetItem(key).GetOwner();
	}

	// Token: 0x060095EC RID: 38380 RVA: 0x00205498 File Offset: 0x00203698
	public void Update(ActivityRegressTaskDynamicData data, int index)
	{
		bool flag = data.ItemType == ERegressTaskDynamicItemType.Title;
		this.TitleItem.SetUiActive(flag);
		this.ScrollItem.SetUiActive(!flag);
		if (flag)
		{
			this.TitleItem.RefreshByData(data);
			return;
		}
		if (!flag)
		{
			this.ScrollItem.GetRootItem().SetAnchorOffsetY(0f);
			this.ScrollItem.RefreshByData(data);
		}
	}

	// Token: 0x060095ED RID: 38381 RVA: 0x002054FE File Offset: 0x002036FE
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0400423E RID: 16958
	[Nullable(2)]
	private ActivityRegressTaskScrollItemPanel ScrollItem;

	// Token: 0x0400423F RID: 16959
	[Nullable(2)]
	private ActivityRegressTaskTitlePanel TitleItem;

	// Token: 0x02007AE1 RID: 31457
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040286BF RID: 165567
		public const int ScrollItem = 0;

		// Token: 0x040286C0 RID: 165568
		public const int TitlePanel = 1;
	}
}
