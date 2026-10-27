using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017A4 RID: 6052
[NullableContext(1)]
[Nullable(0)]
public class ChatExpressionView : UiViewBase
{
	// Token: 0x0600B057 RID: 45143 RVA: 0x0027D6FD File Offset: 0x0027B8FD
	public ChatExpressionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B058 RID: 45144 RVA: 0x0027D714 File Offset: 0x0027B914
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

	// Token: 0x0600B059 RID: 45145 RVA: 0x0027D840 File Offset: 0x0027BA40
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

	// Token: 0x0600B05A RID: 45146 RVA: 0x0027D899 File Offset: 0x0027BA99
	protected override void OnBeforeDestroy()
	{
		this.ClearExpressionGroupItems();
		this.ExpressionGroupItemMap.Clear();
		this.CurrentGroupItem = null;
		this.ExpressionScrollView = null;
	}

	// Token: 0x0600B05B RID: 45147 RVA: 0x0027D8BC File Offset: 0x0027BABC
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

	// Token: 0x0600B05C RID: 45148 RVA: 0x0027D934 File Offset: 0x0027BB34
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

	// Token: 0x0600B05D RID: 45149 RVA: 0x0027D988 File Offset: 0x0027BB88
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

	// Token: 0x0600B05E RID: 45150 RVA: 0x0027D9F8 File Offset: 0x0027BBF8
	[NullableContext(2)]
	private ChatExpressionGroupItem GetExpressionGroupItem(int expressionGroupId)
	{
		ChatExpressionGroupItem result;
		this.ExpressionGroupItemMap.TryGetValue(expressionGroupId, out result);
		return result;
	}

	// Token: 0x0600B05F RID: 45151 RVA: 0x0027DA18 File Offset: 0x0027BC18
	private void ClearExpressionGroupItems()
	{
		foreach (ChatExpressionGroupItem chatExpressionGroupItem in this.ExpressionGroupItemMap.Values)
		{
			chatExpressionGroupItem.Destroy(null);
		}
	}

	// Token: 0x0600B060 RID: 45152 RVA: 0x0027DA70 File Offset: 0x0027BC70
	private ChatExpressionItem OnGridProxyCreate()
	{
		ChatExpressionItem chatExpressionItem = new ChatExpressionItem();
		chatExpressionItem.BindOnClicked(new Action<int>(this.OnClickedExpressionItem));
		return chatExpressionItem;
	}

	// Token: 0x0600B061 RID: 45153 RVA: 0x0027DA89 File Offset: 0x0027BC89
	private void OnClickedExpressionGroupItem(int expressionGroupId)
	{
		this.SelectExpressionGroup(expressionGroupId);
	}

	// Token: 0x0600B062 RID: 45154 RVA: 0x0027DA92 File Offset: 0x0027BC92
	private void OnClickedExpressionItem(int expressionId)
	{
		EventSystem.Instance.Emit<int>(EEventName.OnSelectExpression, expressionId);
		UiManager.Instance.CloseView(EUiViewName.ChatExpressionView, null);
	}

	// Token: 0x0600B063 RID: 45155 RVA: 0x0027DAB5 File Offset: 0x0027BCB5
	private void OnClickedMaskButton()
	{
		UiManager.Instance.CloseView(EUiViewName.ChatExpressionView, null);
	}

	// Token: 0x0400501D RID: 20509
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<ChatExpressionItem, ChatExpression> ExpressionScrollView;

	// Token: 0x0400501E RID: 20510
	private readonly Dictionary<int, ChatExpressionGroupItem> ExpressionGroupItemMap = new Dictionary<int, ChatExpressionGroupItem>();

	// Token: 0x0400501F RID: 20511
	[Nullable(2)]
	private ChatExpressionGroupItem CurrentGroupItem;

	// Token: 0x02007DB4 RID: 32180
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04029272 RID: 168562
		public const int SourceExpressionItem = 0;

		// Token: 0x04029273 RID: 168563
		public const int SourceExpressionGroupItem = 1;

		// Token: 0x04029274 RID: 168564
		public const int ExpressionContentItem = 2;

		// Token: 0x04029275 RID: 168565
		public const int ExpressionLoopScrollView = 3;

		// Token: 0x04029276 RID: 168566
		public const int ExpressionGroupContentItem = 4;

		// Token: 0x04029277 RID: 168567
		public const int MaskButton = 5;
	}
}
