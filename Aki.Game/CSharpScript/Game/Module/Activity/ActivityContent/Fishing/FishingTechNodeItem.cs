using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200662C RID: 26156
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingTechNodeItem : UiPanelBase
	{
		// Token: 0x17009609 RID: 38409
		// (get) Token: 0x06041917 RID: 268567 RVA: 0x00FE6DCC File Offset: 0x00FE4FCC
		public IFishingTechNode CurrentNode
		{
			get
			{
				return this.Node;
			}
		}

		// Token: 0x06041918 RID: 268568 RVA: 0x00FE6DD4 File Offset: 0x00FE4FD4
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

		// Token: 0x06041919 RID: 268569 RVA: 0x00FE6EBC File Offset: 0x00FE50BC
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

		// Token: 0x0604191A RID: 268570 RVA: 0x00FE6EFC File Offset: 0x00FE50FC
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnFishingTechNodeRefresh, new Action<int>(this.OnFishingTechNodeRefresh));
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingNormalTechNode, base.GetItem(3), this.Node.ConfigId);
		}

		// Token: 0x0604191B RID: 268571 RVA: 0x00FE6F3B File Offset: 0x00FE513B
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<IFishingTechNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(this.Node, base.GetExtendToggle(0));
		}

		// Token: 0x0604191C RID: 268572 RVA: 0x00FE6F5A File Offset: 0x00FE515A
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

		// Token: 0x0604191D RID: 268573 RVA: 0x00FE6F8C File Offset: 0x00FE518C
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

		// Token: 0x0604191E RID: 268574 RVA: 0x00FE6FEE File Offset: 0x00FE51EE
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

		// Token: 0x0604191F RID: 268575 RVA: 0x00FE7020 File Offset: 0x00FE5220
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

		// Token: 0x040221CC RID: 139724
		private IFishingTechNode Node;

		// Token: 0x040221CD RID: 139725
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<IFishingTechNode, UUIExtendToggle> OnClickToggleBack;

		// Token: 0x0200C846 RID: 51270
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C7F7 RID: 247799
			public const int Toggle = 0;

			// Token: 0x0403C7F8 RID: 247800
			public const int IconTexture = 1;

			// Token: 0x0403C7F9 RID: 247801
			public const int LockItem = 2;

			// Token: 0x0403C7FA RID: 247802
			public const int RedDotItem = 3;
		}
	}
}
