using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C5D RID: 3165
[NullableContext(1)]
[Nullable(0)]
public class ChatExpressionView : UiViewBase
{
	// Token: 0x0600843F RID: 33855 RVA: 0x00287C95 File Offset: 0x00285E95
	public ChatExpressionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008440 RID: 33856 RVA: 0x00287CAC File Offset: 0x00285EAC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickedMaskButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008441 RID: 33857 RVA: 0x00287DD8 File Offset: 0x00285FD8
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(1);
		UUIItem item2 = base.GetItem(0);
		AUIBaseActor gridActor = item2.GetOwner() as AUIBaseActor;
		this.ExpressionScrollView = new LoopScrollView<ChatExpressionItem, ChatExpression>(base.GetLoopScrollViewComponent(3), gridActor, new Func<ChatExpressionItem>(this.OnGridProxyCreate), false);
		item2.SetUIActive(false);
		item.SetUIActive(false);
		this.Refresh();
	}

	// Token: 0x06008442 RID: 33858 RVA: 0x00287E31 File Offset: 0x00286031
	protected override void OnBeforeDestroy()
	{
		this.ClearExpressionGroupItems();
		this.ExpressionGroupItemMap.Clear();
		this.CurrentGroupItem = null;
		this.ExpressionScrollView = null;
	}

	// Token: 0x06008443 RID: 33859 RVA: 0x00287E54 File Offset: 0x00286054
	private void Refresh()
	{
		this.ClearExpressionGroupItems();
		IReadOnlyList<ChatExpressionGroup> allExpressionGroupConfig = ChatConfig.Instance.GetAllExpressionGroupConfig();
		if (allExpressionGroupConfig == null)
		{
			return;
		}
		foreach (ChatExpressionGroup expressionGroupConfig in allExpressionGroupConfig)
		{
			this.NewExpressionGroupItem(expressionGroupConfig);
		}
		int id = allExpressionGroupConfig[0].Id;
		this.SelectExpressionGroup(id);
	}

	// Token: 0x06008444 RID: 33860 RVA: 0x00287ECC File Offset: 0x002860CC
	private void SelectExpressionGroup(int groupId)
	{
		if (this.CurrentGroupItem != null)
		{
			this.CurrentGroupItem.SetState(EToggleState.ETT_UnChecked, false);
		}
		ChatExpressionGroupItem expressionGroupItem = this.GetExpressionGroupItem(groupId);
		expressionGroupItem.SetState(EToggleState.ETT_Checked, false);
		this.CurrentGroupItem = expressionGroupItem;
		IReadOnlyList<ChatExpression> allExpressionConfigByGroupId = ChatConfig.Instance.GetAllExpressionConfigByGroupId(groupId);
		this.ExpressionScrollView.ReloadData(allExpressionConfigByGroupId, false);
	}

	// Token: 0x06008445 RID: 33861 RVA: 0x00287F20 File Offset: 0x00286120
	private void NewExpressionGroupItem(ChatExpressionGroup expressionGroupConfig)
	{
		AActor owner = base.GetItem(1).GetOwner();
		ChatExpressionGroupItem chatExpressionGroupItem = new ChatExpressionGroupItem(LguiUtil.Instance.DuplicateActor(owner, base.GetItem(4)));
		chatExpressionGroupItem.Refresh(expressionGroupConfig);
		chatExpressionGroupItem.SetState(EToggleState.ETT_UnChecked, false);
		chatExpressionGroupItem.BindOnClicked(new Action<int>(this.OnClickedExpressionGroupItem));
		chatExpressionGroupItem.SetActive(true);
		this.ExpressionGroupItemMap[expressionGroupConfig.Id] = chatExpressionGroupItem;
	}

	// Token: 0x06008446 RID: 33862 RVA: 0x00287F90 File Offset: 0x00286190
	[NullableContext(2)]
	private ChatExpressionGroupItem GetExpressionGroupItem(int expressionGroupId)
	{
		ChatExpressionGroupItem result;
		this.ExpressionGroupItemMap.TryGetValue(expressionGroupId, out result);
		return result;
	}

	// Token: 0x06008447 RID: 33863 RVA: 0x00287FB0 File Offset: 0x002861B0
	private void ClearExpressionGroupItems()
	{
		foreach (ChatExpressionGroupItem chatExpressionGroupItem in this.ExpressionGroupItemMap.Values)
		{
			chatExpressionGroupItem.Destroy(null);
		}
	}

	// Token: 0x06008448 RID: 33864 RVA: 0x00288008 File Offset: 0x00286208
	private ChatExpressionItem OnGridProxyCreate()
	{
		ChatExpressionItem chatExpressionItem = new ChatExpressionItem();
		chatExpressionItem.BindOnClicked(new Action<int>(this.OnClickedExpressionItem));
		return chatExpressionItem;
	}

	// Token: 0x06008449 RID: 33865 RVA: 0x00288021 File Offset: 0x00286221
	private void OnClickedExpressionGroupItem(int expressionGroupId)
	{
		this.SelectExpressionGroup(expressionGroupId);
	}

	// Token: 0x0600844A RID: 33866 RVA: 0x0028802A File Offset: 0x0028622A
	private void OnClickedExpressionItem(int expressionId)
	{
		EventSystem.Instance.Emit<int>(EEventName.OnSelectExpression, expressionId);
		UiManager.Instance.CloseView(EUiViewName.ChatExpressionView, null);
	}

	// Token: 0x0600844B RID: 33867 RVA: 0x0028804D File Offset: 0x0028624D
	private void OnClickedMaskButton()
	{
		UiManager.Instance.CloseView(EUiViewName.ChatExpressionView, null);
	}

	// Token: 0x040050C7 RID: 20679
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<ChatExpressionItem, ChatExpression> ExpressionScrollView;

	// Token: 0x040050C8 RID: 20680
	private readonly Dictionary<int, ChatExpressionGroupItem> ExpressionGroupItemMap = new Dictionary<int, ChatExpressionGroupItem>();

	// Token: 0x040050C9 RID: 20681
	[Nullable(2)]
	private ChatExpressionGroupItem CurrentGroupItem;

	// Token: 0x02006F3A RID: 28474
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402459D RID: 148893
		public const int SourceExpressionItem = 0;

		// Token: 0x0402459E RID: 148894
		public const int SourceExpressionGroupItem = 1;

		// Token: 0x0402459F RID: 148895
		public const int ExpressionContentItem = 2;

		// Token: 0x040245A0 RID: 148896
		public const int ExpressionLoopScrollView = 3;

		// Token: 0x040245A1 RID: 148897
		public const int ExpressionGroupContentItem = 4;

		// Token: 0x040245A2 RID: 148898
		public const int MaskButton = 5;
	}
}
