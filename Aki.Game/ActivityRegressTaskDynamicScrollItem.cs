using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000961 RID: 2401
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressTaskDynamicScrollItem : UiPanelBase, IDynamicScrollItem<ActivityRegressTaskDynamicData>
{
	// Token: 0x0600697C RID: 27004 RVA: 0x0020E300 File Offset: 0x0020C500
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

	// Token: 0x0600697D RID: 27005 RVA: 0x0020E34B File Offset: 0x0020C54B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600697E RID: 27006 RVA: 0x0020E384 File Offset: 0x0020C584
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressTaskDynamicScrollItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressTaskDynamicScrollItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600697F RID: 27007 RVA: 0x0020E3C7 File Offset: 0x0020C5C7
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

	// Token: 0x06006980 RID: 27008 RVA: 0x0020E3EB File Offset: 0x0020C5EB
	private AUIBaseActor GetItemActor(int key)
	{
		return (AUIBaseActor)base.GetItem(key).GetOwner();
	}

	// Token: 0x06006981 RID: 27009 RVA: 0x0020E400 File Offset: 0x0020C600
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

	// Token: 0x06006982 RID: 27010 RVA: 0x0020E466 File Offset: 0x0020C666
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x040042D6 RID: 17110
	[Nullable(2)]
	private ActivityRegressTaskScrollItemPanel ScrollItem;

	// Token: 0x040042D7 RID: 17111
	[Nullable(2)]
	private ActivityRegressTaskTitlePanel TitleItem;

	// Token: 0x02006C65 RID: 27749
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040239D9 RID: 145881
		public const int ScrollItem = 0;

		// Token: 0x040239DA RID: 145882
		public const int TitlePanel = 1;
	}
}
