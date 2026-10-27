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
	// Token: 0x02004E30 RID: 20016
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSkillView : UiViewBase
	{
		// Token: 0x060339C2 RID: 211394 RVA: 0x00C13C33 File Offset: 0x00C11E33
		public RoguelikeSkillView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060339C3 RID: 211395 RVA: 0x00C13C3C File Offset: 0x00C11E3C
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

		// Token: 0x060339C4 RID: 211396 RVA: 0x00C13D68 File Offset: 0x00C11F68
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeSkillView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeSkillView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060339C5 RID: 211397 RVA: 0x00C13DAC File Offset: 0x00C11FAC
		protected override void OnStart()
		{
			RoguelikeTalentTreeNodeData defaultSelectNode = this.Vm.GetDefaultSelectNode();
			this.OnClickNode(true, defaultSelectNode);
			this.ScrollToNode(defaultSelectNode, true);
		}

		// Token: 0x060339C6 RID: 211398 RVA: 0x00C13DD6 File Offset: 0x00C11FD6
		protected override void OnBeforeDestroy()
		{
			RoguelikeModel.Instance.ClearTalentTreeViewModel();
		}

		// Token: 0x060339C7 RID: 211399 RVA: 0x00C13DE2 File Offset: 0x00C11FE2
		protected RoguelikeTalentTreeNodeRowItem CreateRowItem()
		{
			return new RoguelikeTalentTreeNodeRowItem();
		}

		// Token: 0x060339C8 RID: 211400 RVA: 0x00C13DE9 File Offset: 0x00C11FE9
		protected void OnBtnSkillOverViewClick()
		{
			UiManager.Instance.OpenView(EUiViewName.RoguelikeSkillOverView, null, null);
		}

		// Token: 0x060339C9 RID: 211401 RVA: 0x00C13DFC File Offset: 0x00C11FFC
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

		// Token: 0x060339CA RID: 211402 RVA: 0x00C13E50 File Offset: 0x00C12050
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

		// Token: 0x0401B5FA RID: 112122
		private RoguelikeTalentTreeViewModel Vm;

		// Token: 0x0401B5FB RID: 112123
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B5FC RID: 112124
		[Nullable(2)]
		private RoguelikeSkillDetail SkillDetailPanel;

		// Token: 0x0401B5FD RID: 112125
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoguelikeTalentTreeNodeRowItem, RoguelikeTalentTreeNodeRowData> ScrollView;

		// Token: 0x0200AFE5 RID: 45029
		[NullableContext(0)]
		private class ERoguelikeSkillViewDefine
		{
			// Token: 0x04035667 RID: 218727
			public const int CaptionItem = 0;

			// Token: 0x04035668 RID: 218728
			public const int SkillDetailPanelItem = 1;

			// Token: 0x04035669 RID: 218729
			public const int BtnSkillOverView = 2;

			// Token: 0x0403566A RID: 218730
			public const int ScrollView = 3;

			// Token: 0x0403566B RID: 218731
			public const int TalentContentItem = 4;

			// Token: 0x0403566C RID: 218732
			public const int BtnMask = 5;
		}
	}
}
