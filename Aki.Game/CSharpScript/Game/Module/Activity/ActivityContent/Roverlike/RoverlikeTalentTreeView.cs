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
	// Token: 0x020061A9 RID: 25001
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeTalentTreeView : UiViewBase
	{
		// Token: 0x0603F246 RID: 258630 RVA: 0x00F40EB0 File Offset: 0x00F3F0B0
		public RoverlikeTalentTreeView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603F247 RID: 258631 RVA: 0x00F40EBC File Offset: 0x00F3F0BC
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

		// Token: 0x0603F248 RID: 258632 RVA: 0x00F40F88 File Offset: 0x00F3F188
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeTalentTreeView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeTalentTreeView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F249 RID: 258633 RVA: 0x00F40FCC File Offset: 0x00F3F1CC
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

		// Token: 0x0603F24A RID: 258634 RVA: 0x00F41006 File Offset: 0x00F3F206
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoverlikeTalentUnlockDataUpdate, new Action(this.OnTalentUnlockDataUpdate));
		}

		// Token: 0x0603F24B RID: 258635 RVA: 0x00F41024 File Offset: 0x00F3F224
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoverlikeTalentUnlockDataUpdate, new Action(this.OnTalentUnlockDataUpdate));
		}

		// Token: 0x0603F24C RID: 258636 RVA: 0x00F41042 File Offset: 0x00F3F242
		protected override void OnBeforeDestroy()
		{
			RoverlikeTalentTreeData treeData = this.TreeData;
			if (treeData != null)
			{
				treeData.Reset();
			}
			this.TreeData = null;
		}

		// Token: 0x0603F24D RID: 258637 RVA: 0x00F4105C File Offset: 0x00F3F25C
		private RoverlikeTalentTreeNodeRowItem CreateRowItem()
		{
			return new RoverlikeTalentTreeNodeRowItem();
		}

		// Token: 0x0603F24E RID: 258638 RVA: 0x00F41064 File Offset: 0x00F3F264
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

		// Token: 0x0603F24F RID: 258639 RVA: 0x00F410B8 File Offset: 0x00F3F2B8
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

		// Token: 0x0603F250 RID: 258640 RVA: 0x00F4112B File Offset: 0x00F3F32B
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

		// Token: 0x0603F251 RID: 258641 RVA: 0x00F41158 File Offset: 0x00F3F358
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

		// Token: 0x04020EA3 RID: 134819
		[Nullable(2)]
		private RoverlikeTalentTreeData TreeData;

		// Token: 0x04020EA4 RID: 134820
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020EA5 RID: 134821
		[Nullable(2)]
		private RoverlikeTalentTreeDetailPanel DetailPanel;

		// Token: 0x04020EA6 RID: 134822
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoverlikeTalentTreeNodeRowItem, RoverlikeTalentTreeNodeRowData> ScrollView;

		// Token: 0x0200C3FA RID: 50170
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403B25A RID: 242266
			public const int CaptionItem = 0;

			// Token: 0x0403B25B RID: 242267
			public const int DetailPanelItem = 1;

			// Token: 0x0403B25C RID: 242268
			public const int ScrollView = 2;

			// Token: 0x0403B25D RID: 242269
			public const int TalentRowTemplateItem = 3;

			// Token: 0x0403B25E RID: 242270
			public const int BtnMask = 4;
		}
	}
}
