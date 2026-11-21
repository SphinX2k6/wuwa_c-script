using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005127 RID: 20775
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeTalentTreeView : UiViewBase
	{
		// Token: 0x06033F06 RID: 212742 RVA: 0x00E87D78 File Offset: 0x00E85F78
		public RoverlikeTalentTreeView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033F07 RID: 212743 RVA: 0x00E87D84 File Offset: 0x00E85F84
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033F08 RID: 212744 RVA: 0x00E87E50 File Offset: 0x00E86050
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeTalentTreeView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeTalentTreeView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033F09 RID: 212745 RVA: 0x00E87E94 File Offset: 0x00E86094
		protected override void OnStart()
		{
			if (this.TreeData == null)
			{
				return;
			}
			RoverlikeTalentNodeData defaultSelectNode = this.TreeData.GetDefaultSelectNode();
			if (defaultSelectNode != null)
			{
				this.OnClickNode(true, defaultSelectNode);
				this.ScrollToNode(defaultSelectNode, true).Forget();
			}
		}

		// Token: 0x06033F0A RID: 212746 RVA: 0x00E87ECE File Offset: 0x00E860CE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoverlikeTalentUnlockDataUpdate, new Action(this.OnTalentUnlockDataUpdate));
		}

		// Token: 0x06033F0B RID: 212747 RVA: 0x00E87EEC File Offset: 0x00E860EC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoverlikeTalentUnlockDataUpdate, new Action(this.OnTalentUnlockDataUpdate));
		}

		// Token: 0x06033F0C RID: 212748 RVA: 0x00E87F0A File Offset: 0x00E8610A
		protected override void OnBeforeDestroy()
		{
			RoverlikeTalentTreeData treeData = this.TreeData;
			if (treeData != null)
			{
				treeData.Reset();
			}
			this.TreeData = null;
		}

		// Token: 0x06033F0D RID: 212749 RVA: 0x00E87F24 File Offset: 0x00E86124
		private RoverlikeTalentTreeNodeRowItem CreateRowItem()
		{
			return new RoverlikeTalentTreeNodeRowItem();
		}

		// Token: 0x06033F0E RID: 212750 RVA: 0x00E87F2C File Offset: 0x00E8612C
		private UniTask ScrollToNode(RoverlikeTalentNodeData node, bool tween = false)
		{
			RoverlikeTalentTreeView.<ScrollToNode>d__13 <ScrollToNode>d__;
			<ScrollToNode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ScrollToNode>d__.<>4__this = this;
			<ScrollToNode>d__.node = node;
			<ScrollToNode>d__.tween = tween;
			<ScrollToNode>d__.<>1__state = -1;
			<ScrollToNode>d__.<>t__builder.Start<RoverlikeTalentTreeView.<ScrollToNode>d__13>(ref <ScrollToNode>d__);
			return <ScrollToNode>d__.<>t__builder.Task;
		}

		// Token: 0x06033F0F RID: 212751 RVA: 0x00E87F80 File Offset: 0x00E86180
		private void OnClickNode(bool isSelect, RoverlikeTalentNodeData data)
		{
			if (!isSelect || this.TreeData == null)
			{
				return;
			}
			if (this.TreeData.CurSelectNode != null)
			{
				Action<bool, bool> setNodeToggleState = this.TreeData.CurSelectNode.SetNodeToggleState;
				if (setNodeToggleState != null)
				{
					setNodeToggleState(false, false);
				}
			}
			this.TreeData.SelectNode(data);
			Action<bool, bool> setNodeToggleState2 = data.SetNodeToggleState;
			if (setNodeToggleState2 != null)
			{
				setNodeToggleState2(true, false);
			}
			RoverlikeTalentTreeDetailPanel detailPanel = this.DetailPanel;
			if (detailPanel == null)
			{
				return;
			}
			detailPanel.Refresh(data);
		}

		// Token: 0x06033F10 RID: 212752 RVA: 0x00E87FF3 File Offset: 0x00E861F3
		private void OnUnlockSuccess(RoverlikeTalentNodeData data)
		{
			if (this.TreeData == null)
			{
				return;
			}
			GenericScrollViewNew<RoverlikeTalentTreeNodeRowItem, RoverlikeTalentTreeNodeRowData> scrollView = this.ScrollView;
			if (scrollView == null)
			{
				return;
			}
			scrollView.RefreshByDataAsync(this.TreeData.RowDataList, false).Forget();
		}

		// Token: 0x06033F11 RID: 212753 RVA: 0x00E88020 File Offset: 0x00E86220
		private void OnTalentUnlockDataUpdate()
		{
			if (this.TreeData == null)
			{
				return;
			}
			GenericScrollViewNew<RoverlikeTalentTreeNodeRowItem, RoverlikeTalentTreeNodeRowData> scrollView = this.ScrollView;
			if (scrollView != null)
			{
				scrollView.RefreshByDataAsync(this.TreeData.RowDataList, false).Forget();
			}
			if (this.TreeData.CurSelectNode != null)
			{
				RoverlikeTalentTreeDetailPanel detailPanel = this.DetailPanel;
				if (detailPanel == null)
				{
					return;
				}
				detailPanel.Refresh(this.TreeData.CurSelectNode);
			}
		}

		// Token: 0x0401B7D0 RID: 112592
		[Nullable(2)]
		private RoverlikeTalentTreeData TreeData;

		// Token: 0x0401B7D1 RID: 112593
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B7D2 RID: 112594
		[Nullable(2)]
		private RoverlikeTalentTreeDetailPanel DetailPanel;

		// Token: 0x0401B7D3 RID: 112595
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoverlikeTalentTreeNodeRowItem, RoverlikeTalentTreeNodeRowData> ScrollView;

		// Token: 0x0200ADE1 RID: 44513
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04035BBB RID: 220091
			public const int CaptionItem = 0;

			// Token: 0x04035BBC RID: 220092
			public const int DetailPanelItem = 1;

			// Token: 0x04035BBD RID: 220093
			public const int ScrollView = 2;

			// Token: 0x04035BBE RID: 220094
			public const int TalentRowTemplateItem = 3;

			// Token: 0x04035BBF RID: 220095
			public const int BtnMask = 4;
		}
	}
}
