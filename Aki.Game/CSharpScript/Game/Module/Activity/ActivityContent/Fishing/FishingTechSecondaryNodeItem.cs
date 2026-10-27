using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200662E RID: 26158
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingTechSecondaryNodeItem : UiPanelBase
	{
		// Token: 0x1700960A RID: 38410
		// (get) Token: 0x06041931 RID: 268593 RVA: 0x00FE762C File Offset: 0x00FE582C
		public IFishingTechNode CurrentNode
		{
			get
			{
				return this.Node;
			}
		}

		// Token: 0x06041932 RID: 268594 RVA: 0x00FE7634 File Offset: 0x00FE5834
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06041933 RID: 268595 RVA: 0x00FE77A0 File Offset: 0x00FE59A0
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int>(EEventName.OnFishingTechNodeRefresh, new Action<int>(this.OnFishingTechNodeRefresh));
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnUndeterminedClicked.Add(new Action(this.OnClickToggleOnUndetermined));
		}

		// Token: 0x06041934 RID: 268596 RVA: 0x00FE77E0 File Offset: 0x00FE59E0
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnFishingTechNodeRefresh, new Action<int>(this.OnFishingTechNodeRefresh));
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingNormalTechNode, base.GetItem(7), this.Node.ConfigId);
		}

		// Token: 0x06041935 RID: 268597 RVA: 0x00FE781F File Offset: 0x00FE5A1F
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<IFishingTechNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(this.Node, base.GetExtendToggle(0));
		}

		// Token: 0x06041936 RID: 268598 RVA: 0x00FE783E File Offset: 0x00FE5A3E
		private void OnClickToggleOnUndetermined()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			Action<IFishingTechNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(this.Node, base.GetExtendToggle(0));
		}

		// Token: 0x06041937 RID: 268599 RVA: 0x00FE7870 File Offset: 0x00FE5A70
		private void OnFishingTechNodeRefresh(int nodeId)
		{
			IFishingTechNode node = this.Node;
			if (node == null || node.ConfigId != nodeId)
			{
				IFishingTechNode node2 = this.Node;
				if (node2 == null || node2.PreNode != nodeId)
				{
					return;
				}
			}
			this.RefreshNode(this.Node);
			EventSystem.Instance.Emit<int>(EEventName.OnFishingTechNodeRedDotRefresh, this.Node.ConfigId);
		}

		// Token: 0x06041938 RID: 268600 RVA: 0x00FE78D4 File Offset: 0x00FE5AD4
		[NullableContext(1)]
		public void RefreshNode(IFishingTechNode node)
		{
			this.Node = node;
			base.SetTextureByPath(FishingConfig.Instance.GetFishingTechById(this.Node.ConfigId).Icon, base.GetTexture(1), null, null);
			bool nodePreNodeUnlock = FishingModel.Instance.GetNodePreNodeUnlock(this.Node.ConfigId);
			base.GetItem(6).SetUIActive(!nodePreNodeUnlock);
			if (!FishingModel.Instance.GetFishingTechUnlock(this.Node.ConfigId))
			{
				base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
			}
			else
			{
				base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.RefreshStarItem();
			RedDotController.Instance.BindRedDot(ERedDotName.FishingNormalTechNode, base.GetItem(7), null, this.Node.ConfigId);
			EventSystem.Instance.Emit<int>(EEventName.OnFishingTechNodeRedDotRefresh, this.Node.ConfigId);
		}

		// Token: 0x06041939 RID: 268601 RVA: 0x00FE79C0 File Offset: 0x00FE5BC0
		public void SelectNode()
		{
			if (FishingModel.Instance.GetFishingTechUnlock(this.Node.ConfigId))
			{
				base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
				return;
			}
			Action<IFishingTechNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(this.Node, base.GetExtendToggle(0));
		}

		// Token: 0x0604193A RID: 268602 RVA: 0x00FE7A14 File Offset: 0x00FE5C14
		private void RefreshStarItem()
		{
			int techNodeCurrentLevel = FishingModel.Instance.GetTechNodeCurrentLevel(this.Node.ConfigId);
			int techNodeMaxLevel = FishingModel.Instance.GetTechNodeMaxLevel(this.Node.ConfigId);
			UUIText text = base.GetText(5);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Lv ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(techNodeCurrentLevel);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(techNodeMaxLevel);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			base.GetItem(2).SetUIActive(techNodeCurrentLevel > 0);
			base.GetItem(3).SetUIActive(techNodeCurrentLevel > 1);
			base.GetItem(4).SetUIActive(techNodeCurrentLevel > 2);
		}

		// Token: 0x040221D4 RID: 139732
		private IFishingTechNode Node;

		// Token: 0x040221D5 RID: 139733
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<IFishingTechNode, UUIExtendToggle> OnClickToggleBack;

		// Token: 0x0200C84B RID: 51275
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C80E RID: 247822
			public const int Toggle = 0;

			// Token: 0x0403C80F RID: 247823
			public const int IconTexture = 1;

			// Token: 0x0403C810 RID: 247824
			public const int StarOneItem = 2;

			// Token: 0x0403C811 RID: 247825
			public const int StarTwoItem = 3;

			// Token: 0x0403C812 RID: 247826
			public const int StarThreeItem = 4;

			// Token: 0x0403C813 RID: 247827
			public const int StarText = 5;

			// Token: 0x0403C814 RID: 247828
			public const int LockItem = 6;

			// Token: 0x0403C815 RID: 247829
			public const int RedDotItem = 7;
		}
	}
}
