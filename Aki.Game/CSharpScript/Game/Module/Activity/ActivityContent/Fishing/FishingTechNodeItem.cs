using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020055AA RID: 21930
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingTechNodeItem : UiPanelBase
	{
		// Token: 0x1700696B RID: 26987
		// (get) Token: 0x060365DC RID: 222684 RVA: 0x00F2DE84 File Offset: 0x00F2C084
		public IFishingTechNode CurrentNode
		{
			get
			{
				return this.Node;
			}
		}

		// Token: 0x060365DD RID: 222685 RVA: 0x00F2DE8C File Offset: 0x00F2C08C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
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
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060365DE RID: 222686 RVA: 0x00F2DF74 File Offset: 0x00F2C174
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

		// Token: 0x060365DF RID: 222687 RVA: 0x00F2DFB4 File Offset: 0x00F2C1B4
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnFishingTechNodeRefresh, new Action<int>(this.OnFishingTechNodeRefresh));
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingNormalTechNode, base.GetItem(3), this.Node.ConfigId);
		}

		// Token: 0x060365E0 RID: 222688 RVA: 0x00F2DFF3 File Offset: 0x00F2C1F3
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<IFishingTechNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(this.Node, base.GetExtendToggle(0));
		}

		// Token: 0x060365E1 RID: 222689 RVA: 0x00F2E012 File Offset: 0x00F2C212
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

		// Token: 0x060365E2 RID: 222690 RVA: 0x00F2E044 File Offset: 0x00F2C244
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

		// Token: 0x060365E3 RID: 222691 RVA: 0x00F2E0A6 File Offset: 0x00F2C2A6
		public void SelectNode()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			Action<IFishingTechNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(this.Node, base.GetExtendToggle(0));
		}

		// Token: 0x060365E4 RID: 222692 RVA: 0x00F2E0D8 File Offset: 0x00F2C2D8
		[NullableContext(1)]
		public void RefreshNode(IFishingTechNode node)
		{
			if (node == null)
			{
				return;
			}
			if (this.Node != null)
			{
				RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingNormalTechNode, base.GetItem(3), this.Node.ConfigId);
			}
			this.Node = node;
			base.SetTextureByPath(FishingConfig.Instance.GetFishingTechById(this.Node.ConfigId).Icon, base.GetTexture(1), null, null);
			bool nodePreNodeUnlock = FishingModel.Instance.GetNodePreNodeUnlock(this.Node.ConfigId);
			base.GetItem(2).SetUIActive(!nodePreNodeUnlock);
			if (!FishingModel.Instance.GetFishingTechUnlock(this.Node.ConfigId))
			{
				base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
			}
			else
			{
				base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			RedDotController.Instance.BindRedDot(ERedDotName.FishingNormalTechNode, base.GetItem(3), null, this.Node.ConfigId);
			EventSystem.Instance.Emit<int>(EEventName.OnFishingTechNodeRedDotRefresh, this.Node.ConfigId);
		}

		// Token: 0x0401CAFD RID: 117501
		private IFishingTechNode Node;

		// Token: 0x0401CAFE RID: 117502
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<IFishingTechNode, UUIExtendToggle> OnClickToggleBack;

		// Token: 0x0200B228 RID: 45608
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403713C RID: 225596
			public const int Toggle = 0;

			// Token: 0x0403713D RID: 225597
			public const int IconTexture = 1;

			// Token: 0x0403713E RID: 225598
			public const int LockItem = 2;

			// Token: 0x0403713F RID: 225599
			public const int RedDotItem = 3;
		}
	}
}
