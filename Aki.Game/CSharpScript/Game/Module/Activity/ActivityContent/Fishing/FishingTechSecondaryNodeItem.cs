using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020055AC RID: 21932
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingTechSecondaryNodeItem : UiPanelBase
	{
		// Token: 0x1700696C RID: 26988
		// (get) Token: 0x060365F6 RID: 222710 RVA: 0x00F2E6E4 File Offset: 0x00F2C8E4
		public IFishingTechNode CurrentNode
		{
			get
			{
				return this.Node;
			}
		}

		// Token: 0x060365F7 RID: 222711 RVA: 0x00F2E6EC File Offset: 0x00F2C8EC
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

		// Token: 0x060365F8 RID: 222712 RVA: 0x00F2E858 File Offset: 0x00F2CA58
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

		// Token: 0x060365F9 RID: 222713 RVA: 0x00F2E898 File Offset: 0x00F2CA98
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnFishingTechNodeRefresh, new Action<int>(this.OnFishingTechNodeRefresh));
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingNormalTechNode, base.GetItem(7), this.Node.ConfigId);
		}

		// Token: 0x060365FA RID: 222714 RVA: 0x00F2E8D7 File Offset: 0x00F2CAD7
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<IFishingTechNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(this.Node, base.GetExtendToggle(0));
		}

		// Token: 0x060365FB RID: 222715 RVA: 0x00F2E8F6 File Offset: 0x00F2CAF6
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

		// Token: 0x060365FC RID: 222716 RVA: 0x00F2E928 File Offset: 0x00F2CB28
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

		// Token: 0x060365FD RID: 222717 RVA: 0x00F2E98C File Offset: 0x00F2CB8C
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

		// Token: 0x060365FE RID: 222718 RVA: 0x00F2EA78 File Offset: 0x00F2CC78
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

		// Token: 0x060365FF RID: 222719 RVA: 0x00F2EACC File Offset: 0x00F2CCCC
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

		// Token: 0x0401CB05 RID: 117509
		private IFishingTechNode Node;

		// Token: 0x0401CB06 RID: 117510
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<IFishingTechNode, UUIExtendToggle> OnClickToggleBack;

		// Token: 0x0200B22D RID: 45613
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04037153 RID: 225619
			public const int Toggle = 0;

			// Token: 0x04037154 RID: 225620
			public const int IconTexture = 1;

			// Token: 0x04037155 RID: 225621
			public const int StarOneItem = 2;

			// Token: 0x04037156 RID: 225622
			public const int StarTwoItem = 3;

			// Token: 0x04037157 RID: 225623
			public const int StarThreeItem = 4;

			// Token: 0x04037158 RID: 225624
			public const int StarText = 5;

			// Token: 0x04037159 RID: 225625
			public const int LockItem = 6;

			// Token: 0x0403715A RID: 225626
			public const int RedDotItem = 7;
		}
	}
}
