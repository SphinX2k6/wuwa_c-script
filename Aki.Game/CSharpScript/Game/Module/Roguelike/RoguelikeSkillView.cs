using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DF9 RID: 15865
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSkillView : UiViewBase
	{
		// Token: 0x0602882D RID: 165933 RVA: 0x00B5D15F File Offset: 0x00B5B35F
		public RoguelikeSkillView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602882E RID: 165934 RVA: 0x00B5D168 File Offset: 0x00B5B368
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
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
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnSkillOverViewClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602882F RID: 165935 RVA: 0x00B5D294 File Offset: 0x00B5B494
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeSkillView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeSkillView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028830 RID: 165936 RVA: 0x00B5D2D8 File Offset: 0x00B5B4D8
		protected override void OnStart()
		{
			RoguelikeTalentTreeNodeData defaultSelectNode = this.Vm.GetDefaultSelectNode();
			this.OnClickNode(true, defaultSelectNode);
			this.ScrollToNode(defaultSelectNode, true);
		}

		// Token: 0x06028831 RID: 165937 RVA: 0x00B5D302 File Offset: 0x00B5B502
		protected override void OnBeforeDestroy()
		{
			RoguelikeModel.Instance.ClearTalentTreeViewModel();
		}

		// Token: 0x06028832 RID: 165938 RVA: 0x00B5D30E File Offset: 0x00B5B50E
		protected RoguelikeTalentTreeNodeRowItem CreateRowItem()
		{
			return new RoguelikeTalentTreeNodeRowItem();
		}

		// Token: 0x06028833 RID: 165939 RVA: 0x00B5D315 File Offset: 0x00B5B515
		protected void OnBtnSkillOverViewClick()
		{
			UiManager.Instance.OpenView(EUiViewName.RoguelikeSkillOverView, null, null);
		}

		// Token: 0x06028834 RID: 165940 RVA: 0x00B5D328 File Offset: 0x00B5B528
		private UniTask ScrollToNode(RoguelikeTalentTreeNodeData node, bool tween = false)
		{
			RoguelikeSkillView.<ScrollToNode>d__12 <ScrollToNode>d__;
			<ScrollToNode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ScrollToNode>d__.<>4__this = this;
			<ScrollToNode>d__.node = node;
			<ScrollToNode>d__.tween = tween;
			<ScrollToNode>d__.<>1__state = -1;
			<ScrollToNode>d__.<>t__builder.Start<RoguelikeSkillView.<ScrollToNode>d__12>(ref <ScrollToNode>d__);
			return <ScrollToNode>d__.<>t__builder.Task;
		}

		// Token: 0x06028835 RID: 165941 RVA: 0x00B5D37C File Offset: 0x00B5B57C
		private void OnClickNode(bool isSelect, RoguelikeTalentTreeNodeData data)
		{
			if (!isSelect)
			{
				return;
			}
			if (this.Vm.CurSelectNode != null)
			{
				Action<bool, bool> setNodeToggleState = this.Vm.CurSelectNode.SetNodeToggleState;
				if (setNodeToggleState != null)
				{
					setNodeToggleState(false, false);
				}
			}
			this.Vm.SelectNode(data);
			Action<bool, bool> setNodeToggleState2 = data.SetNodeToggleState;
			if (setNodeToggleState2 != null)
			{
				setNodeToggleState2(true, false);
			}
			this.SkillDetailPanel.Refresh(data.Config);
		}

		// Token: 0x04015FCD RID: 90061
		private RoguelikeTalentTreeViewModel Vm;

		// Token: 0x04015FCE RID: 90062
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04015FCF RID: 90063
		[Nullable(2)]
		private RoguelikeSkillDetail SkillDetailPanel;

		// Token: 0x04015FD0 RID: 90064
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoguelikeTalentTreeNodeRowItem, RoguelikeTalentTreeNodeRowData> ScrollView;

		// Token: 0x02009A17 RID: 39447
		[NullableContext(0)]
		private class ERoguelikeSkillViewDefine
		{
			// Token: 0x04030097 RID: 196759
			public const int CaptionItem = 0;

			// Token: 0x04030098 RID: 196760
			public const int SkillDetailPanelItem = 1;

			// Token: 0x04030099 RID: 196761
			public const int BtnSkillOverView = 2;

			// Token: 0x0403009A RID: 196762
			public const int ScrollView = 3;

			// Token: 0x0403009B RID: 196763
			public const int TalentContentItem = 4;

			// Token: 0x0403009C RID: 196764
			public const int BtnMask = 5;
		}
	}
}
