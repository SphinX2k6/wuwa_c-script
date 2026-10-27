using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200179E RID: 6046
[NullableContext(1)]
[Nullable(0)]
public class ChatContentItem : UiPanelBase, IDynamicScrollItem<IChatContentDynamicData>
{
	// Token: 0x0600B02C RID: 45100 RVA: 0x0027C308 File Offset: 0x0027A508
	public UniTask Init(UUIItem actor)
	{
		ChatContentItem.<Init>d__5 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ChatContentItem.<Init>d__5>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600B02D RID: 45101 RVA: 0x0027C354 File Offset: 0x0027A554
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B02E RID: 45102 RVA: 0x0027C3E0 File Offset: 0x0027A5E0
	private UniTask InitChildItem()
	{
		ChatContentItem.<InitChildItem>d__7 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<ChatContentItem.<InitChildItem>d__7>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600B02F RID: 45103 RVA: 0x0027C424 File Offset: 0x0027A624
	public AUIBaseActor GetUsingItem(IChatContentDynamicData data)
	{
		switch (data.Type)
		{
		case EChatContentType.Left:
			return base.GetItem(1).GetOwner() as AUIBaseActor;
		case EChatContentType.Right:
			return base.GetItem(2).GetOwner() as AUIBaseActor;
		case EChatContentType.Tips:
			return base.GetItem(0).GetOwner() as AUIBaseActor;
		default:
			return base.GetItem(1).GetOwner() as AUIBaseActor;
		}
	}

	// Token: 0x0600B030 RID: 45104 RVA: 0x0027C493 File Offset: 0x0027A693
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0600B031 RID: 45105 RVA: 0x0027C49C File Offset: 0x0027A69C
	public void Update(IChatContentDynamicData data, int gridIndex)
	{
		this.Data = data;
		ChatContent rightItem = this.RightItem;
		if (rightItem != null)
		{
			rightItem.SetUiActive(false);
		}
		ChatContent leftItem = this.LeftItem;
		if (leftItem != null)
		{
			leftItem.SetUiActive(false);
		}
		ChatTeamTipsContent tipsItem = this.TipsItem;
		if (tipsItem != null)
		{
			tipsItem.SetUiActive(false);
		}
		switch (data.Type)
		{
		case EChatContentType.Left:
		{
			ChatContent leftItem2 = this.LeftItem;
			if (leftItem2 != null)
			{
				leftItem2.SetUiActive(true);
			}
			ChatContent leftItem3 = this.LeftItem;
			if (leftItem3 == null)
			{
				return;
			}
			leftItem3.Refresh(data.ChatContentData);
			return;
		}
		case EChatContentType.Right:
		{
			ChatContent rightItem2 = this.RightItem;
			if (rightItem2 != null)
			{
				rightItem2.SetUiActive(true);
			}
			ChatContent rightItem3 = this.RightItem;
			if (rightItem3 == null)
			{
				return;
			}
			rightItem3.Refresh(data.ChatContentData);
			return;
		}
		case EChatContentType.Tips:
		{
			ChatTeamTipsContent tipsItem2 = this.TipsItem;
			if (tipsItem2 != null)
			{
				tipsItem2.SetUiActive(true);
			}
			ChatTeamTipsContent tipsItem3 = this.TipsItem;
			if (tipsItem3 == null)
			{
				return;
			}
			tipsItem3.Refresh(data.ChatContentData);
			return;
		}
		default:
			return;
		}
	}

	// Token: 0x0600B032 RID: 45106 RVA: 0x0027C57A File Offset: 0x0027A77A
	public UUIItem GetInteractItem()
	{
		if (this.Data.Type == EChatContentType.Left)
		{
			return this.LeftItem.GetBtnItem();
		}
		return this.RightItem.GetBtnItem();
	}

	// Token: 0x0400500D RID: 20493
	[Nullable(2)]
	public IChatContentDynamicData Data;

	// Token: 0x0400500E RID: 20494
	[Nullable(2)]
	private ChatContent RightItem;

	// Token: 0x0400500F RID: 20495
	[Nullable(2)]
	private ChatContent LeftItem;

	// Token: 0x04005010 RID: 20496
	[Nullable(2)]
	private ChatTeamTipsContent TipsItem;
}
