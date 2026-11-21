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

// Token: 0x02000B8B RID: 2955
[NullableContext(1)]
[Nullable(0)]
public class AdviceExpressionView : UiViewBase
{
	// Token: 0x06007AFF RID: 31487 RVA: 0x00261BFD File Offset: 0x0025FDFD
	public AdviceExpressionView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06007B00 RID: 31488 RVA: 0x00261C08 File Offset: 0x0025FE08
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

	// Token: 0x06007B01 RID: 31489 RVA: 0x00261CE0 File Offset: 0x0025FEE0
	protected override UniTask OnBeforeStartAsync()
	{
		AdviceExpressionView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AdviceExpressionView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007B02 RID: 31490 RVA: 0x00261D23 File Offset: 0x0025FF23
	private void OnClickConfirmBtn()
	{
		AdviceModel.Instance.CurrentExpressionId = AdviceModel.Instance.PreSelectExpressionId;
		EventSystem.Instance.Emit(EEventName.OnSelectAdviceExpression);
		base.CloseMe(null);
	}

	// Token: 0x06007B03 RID: 31491 RVA: 0x00261D50 File Offset: 0x0025FF50
	private void OnClickCancelBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06007B04 RID: 31492 RVA: 0x00261D59 File Offset: 0x0025FF59
	private AdviceExpressionItem OnGridProxyCreate()
	{
		return new AdviceExpressionItem();
	}

	// Token: 0x06007B05 RID: 31493 RVA: 0x00261D60 File Offset: 0x0025FF60
	private AdviceExpressionSwitchItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new AdviceExpressionSwitchItem();
	}

	// Token: 0x06007B06 RID: 31494 RVA: 0x00261D67 File Offset: 0x0025FF67
	private void ToggleCallBack(int groupId)
	{
		this.UpdateExpressions(groupId);
	}

	// Token: 0x06007B07 RID: 31495 RVA: 0x00261D70 File Offset: 0x0025FF70
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

	// Token: 0x06007B08 RID: 31496 RVA: 0x00261DA4 File Offset: 0x0025FFA4
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

	// Token: 0x06007B09 RID: 31497 RVA: 0x00261E04 File Offset: 0x00260004
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

	// Token: 0x06007B0A RID: 31498 RVA: 0x00261E90 File Offset: 0x00260090
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

	// Token: 0x04004C21 RID: 19489
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<AdviceExpressionItem, ChatExpression> ExpressionScrollView;

	// Token: 0x04004C22 RID: 19490
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<AdviceExpressionSwitchItem> TabGroup;

	// Token: 0x02006E2B RID: 28203
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04024155 RID: 147797
		public const int ExpressionScroller = 0;

		// Token: 0x04024156 RID: 147798
		public const int ExpressionItem = 1;

		// Token: 0x04024157 RID: 147799
		public const int HoriGroupScroller = 2;

		// Token: 0x04024158 RID: 147800
		public const int HoriGroupItem = 3;

		// Token: 0x04024159 RID: 147801
		public const int CancelBtn = 4;

		// Token: 0x0402415A RID: 147802
		public const int ConfirmBtn = 5;
	}
}
