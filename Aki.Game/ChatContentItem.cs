using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C57 RID: 3159
[NullableContext(1)]
[Nullable(0)]
public class ChatContentItem : UiPanelBase, IDynamicScrollItem<IChatContentDynamicData>
{
	// Token: 0x06008414 RID: 33812 RVA: 0x002868A0 File Offset: 0x00284AA0
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

	// Token: 0x06008415 RID: 33813 RVA: 0x002868EC File Offset: 0x00284AEC
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

	// Token: 0x06008416 RID: 33814 RVA: 0x00286978 File Offset: 0x00284B78
	private UniTask InitChildItem()
	{
		ChatContentItem.<InitChildItem>d__7 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<ChatContentItem.<InitChildItem>d__7>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x06008417 RID: 33815 RVA: 0x002869BC File Offset: 0x00284BBC
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

	// Token: 0x06008418 RID: 33816 RVA: 0x00286A2B File Offset: 0x00284C2B
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x06008419 RID: 33817 RVA: 0x00286A34 File Offset: 0x00284C34
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

	// Token: 0x0600841A RID: 33818 RVA: 0x00286B12 File Offset: 0x00284D12
	public UUIItem GetInteractItem()
	{
		if (this.Data.Type == EChatContentType.Left)
		{
			return this.LeftItem.GetBtnItem();
		}
		return this.RightItem.GetBtnItem();
	}

	// Token: 0x040050B7 RID: 20663
	[Nullable(2)]
	public IChatContentDynamicData Data;

	// Token: 0x040050B8 RID: 20664
	[Nullable(2)]
	private ChatContent RightItem;

	// Token: 0x040050B9 RID: 20665
	[Nullable(2)]
	private ChatContent LeftItem;

	// Token: 0x040050BA RID: 20666
	[Nullable(2)]
	private ChatTeamTipsContent TipsItem;
}
