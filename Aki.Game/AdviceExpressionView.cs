using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020016D3 RID: 5843
[NullableContext(1)]
[Nullable(0)]
public class AdviceExpressionView : UiViewBase
{
	// Token: 0x0600A71F RID: 42783 RVA: 0x002577F1 File Offset: 0x002559F1
	public AdviceExpressionView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A720 RID: 42784 RVA: 0x002577FC File Offset: 0x002559FC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickCancelBtn)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickConfirmBtn))
		};
	}

	// Token: 0x0600A721 RID: 42785 RVA: 0x002578D4 File Offset: 0x00255AD4
	protected override UniTask OnBeforeStartAsync()
	{
		AdviceExpressionView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AdviceExpressionView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A722 RID: 42786 RVA: 0x00257917 File Offset: 0x00255B17
	private void OnClickConfirmBtn()
	{
		AdviceModel.Instance.CurrentExpressionId = AdviceModel.Instance.PreSelectExpressionId;
		EventSystem.Instance.Emit(EEventName.OnSelectAdviceExpression);
		base.CloseMe(null);
	}

	// Token: 0x0600A723 RID: 42787 RVA: 0x00257944 File Offset: 0x00255B44
	private void OnClickCancelBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600A724 RID: 42788 RVA: 0x0025794D File Offset: 0x00255B4D
	private AdviceExpressionItem OnGridProxyCreate()
	{
		return new AdviceExpressionItem();
	}

	// Token: 0x0600A725 RID: 42789 RVA: 0x00257954 File Offset: 0x00255B54
	private AdviceExpressionSwitchItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new AdviceExpressionSwitchItem();
	}

	// Token: 0x0600A726 RID: 42790 RVA: 0x0025795B File Offset: 0x00255B5B
	private void ToggleCallBack(int groupId)
	{
		this.UpdateExpressions(groupId);
	}

	// Token: 0x0600A727 RID: 42791 RVA: 0x00257964 File Offset: 0x00255B64
	private void UpdateExpressions(int groupId)
	{
		IReadOnlyList<ChatExpression> allExpressionConfigByGroupId = ChatConfig.Instance.GetAllExpressionConfigByGroupId(groupId);
		LoopScrollView<AdviceExpressionItem, ChatExpression> expressionScrollView = this.ExpressionScrollView;
		if (expressionScrollView == null)
		{
			return;
		}
		expressionScrollView.ReloadData(allExpressionConfigByGroupId ?? Array.Empty<ChatExpression>(), false);
	}

	// Token: 0x0600A728 RID: 42792 RVA: 0x00257998 File Offset: 0x00255B98
	private int FindExpressionGroupId()
	{
		int result = 0;
		IReadOnlyList<ChatExpression> allExpressionConfig = ChatConfig.Instance.GetAllExpressionConfig();
		if (allExpressionConfig == null)
		{
			return result;
		}
		for (int i = 0; i < allExpressionConfig.Count; i++)
		{
			if (allExpressionConfig[i].Id == AdviceModel.Instance.PreSelectExpressionId)
			{
				result = allExpressionConfig[i].GroupId;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600A729 RID: 42793 RVA: 0x002579F8 File Offset: 0x00255BF8
	private void UpdateTabs()
	{
		IReadOnlyList<ChatExpressionGroup> allExpressionGroupConfig = ChatConfig.Instance.GetAllExpressionGroupConfig();
		if (allExpressionGroupConfig == null || this.TabGroup == null)
		{
			return;
		}
		foreach (KeyValuePair<int, AdviceExpressionSwitchItem> keyValuePair in this.TabGroup.GetTabItemMap())
		{
			keyValuePair.Value.UpdateView(allExpressionGroupConfig[keyValuePair.Key].Id);
		}
	}

	// Token: 0x0600A72A RID: 42794 RVA: 0x00257A84 File Offset: 0x00255C84
	protected override void OnBeforeDestroy()
	{
		LoopScrollView<AdviceExpressionItem, ChatExpression> expressionScrollView = this.ExpressionScrollView;
		if (expressionScrollView != null)
		{
			expressionScrollView.ClearGridProxies();
		}
		TabComponent<AdviceExpressionSwitchItem> tabGroup = this.TabGroup;
		if (tabGroup == null)
		{
			return;
		}
		tabGroup.Destroy(null);
	}

	// Token: 0x04004B7A RID: 19322
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<AdviceExpressionItem, ChatExpression> ExpressionScrollView;

	// Token: 0x04004B7B RID: 19323
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<AdviceExpressionSwitchItem> TabGroup;

	// Token: 0x02007CA6 RID: 31910
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04028E2C RID: 167468
		public const int ExpressionScroller = 0;

		// Token: 0x04028E2D RID: 167469
		public const int ExpressionItem = 1;

		// Token: 0x04028E2E RID: 167470
		public const int HoriGroupScroller = 2;

		// Token: 0x04028E2F RID: 167471
		public const int HoriGroupItem = 3;

		// Token: 0x04028E30 RID: 167472
		public const int CancelBtn = 4;

		// Token: 0x04028E31 RID: 167473
		public const int ConfirmBtn = 5;
	}
}
