using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042E5 RID: 17125
	public class RogueIllustratedEventItem : GridProxyAbstract<int>
	{
		// Token: 0x0602B55E RID: 177502 RVA: 0x00C2D3BC File Offset: 0x00C2B5BC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602B55F RID: 177503 RVA: 0x00C2D416 File Offset: 0x00C2B616
		protected override void OnStartImplement()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.ExtendToggleStateChanged));
		}

		// Token: 0x0602B560 RID: 177504 RVA: 0x00C2D43A File Offset: 0x00C2B63A
		protected override void OnBeforeDestroyImplement()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.ExtendToggleStateChanged));
		}

		// Token: 0x0602B561 RID: 177505 RVA: 0x00C2D460 File Offset: 0x00C2B660
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.EventIdKey = data;
			RogueResCollection value = ConfigRogueResCollectionByIdKey.GetConfig(data, true).Value;
			this.State = ActivityPermanentRogueModel.Instance.GetCollectItemState(this.EventIdKey);
			base.GetItem(2).SetUIActive(this.State == SignState.Unlock);
			if (this.State == SignState.Lock)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RogueRes_CollectionEventLock", Array.Empty<object>());
			}
			else if (value.Type == 1)
			{
				RogueResGridEvent? config = ConfigRogueResGridEventById.GetConfig(value.Id, true);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.Value.Title, Array.Empty<object>());
			}
			else if (value.Type == 2)
			{
				RogueResGridEvent? config2 = ConfigRogueResGridEventById.GetConfig(value.Id, true);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config2.Value.Title, Array.Empty<object>());
			}
			this.SetSelected(isSelected, false);
		}

		// Token: 0x0602B562 RID: 177506 RVA: 0x00C2D559 File Offset: 0x00C2B759
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x0602B563 RID: 177507 RVA: 0x00C2D563 File Offset: 0x00C2B763
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x0602B564 RID: 177508 RVA: 0x00C2D570 File Offset: 0x00C2B770
		public void SetSelected(bool bSelected, bool bForce = false)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (bSelected)
			{
				if (bForce)
				{
					extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
					return;
				}
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				return;
			}
			else
			{
				if (bForce)
				{
					extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
					return;
				}
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				return;
			}
		}

		// Token: 0x0602B565 RID: 177509 RVA: 0x00C2D5BB File Offset: 0x00C2B7BB
		[NullableContext(1)]
		public void BindOnItemButtonClickedCallback(Action<int, SignState> onItemButtonClicked)
		{
			this.OnItemButtonClickedCallback = onItemButtonClicked;
		}

		// Token: 0x0602B566 RID: 177510 RVA: 0x00C2D5C4 File Offset: 0x00C2B7C4
		private void ExtendToggleStateChanged(EToggleState state)
		{
			if (this.OnItemButtonClickedCallback != null)
			{
				this.OnItemButtonClickedCallback(this.EventIdKey, this.State);
			}
		}

		// Token: 0x04017633 RID: 95795
		private int EventIdKey;

		// Token: 0x04017634 RID: 95796
		private SignState State;

		// Token: 0x04017635 RID: 95797
		[Nullable(2)]
		private Action<int, SignState> OnItemButtonClickedCallback;
	}
}
