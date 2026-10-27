using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005315 RID: 21269
	public class RogueIllustratedEventItem : GridProxyAbstract<int>
	{
		// Token: 0x06036662 RID: 222818 RVA: 0x00CDF9EC File Offset: 0x00CDDBEC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06036663 RID: 222819 RVA: 0x00CDFA46 File Offset: 0x00CDDC46
		protected override void OnStartImplement()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.ExtendToggleStateChanged));
		}

		// Token: 0x06036664 RID: 222820 RVA: 0x00CDFA6A File Offset: 0x00CDDC6A
		protected override void OnBeforeDestroyImplement()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.ExtendToggleStateChanged));
		}

		// Token: 0x06036665 RID: 222821 RVA: 0x00CDFA90 File Offset: 0x00CDDC90
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

		// Token: 0x06036666 RID: 222822 RVA: 0x00CDFB89 File Offset: 0x00CDDD89
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x06036667 RID: 222823 RVA: 0x00CDFB93 File Offset: 0x00CDDD93
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x06036668 RID: 222824 RVA: 0x00CDFBA0 File Offset: 0x00CDDDA0
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

		// Token: 0x06036669 RID: 222825 RVA: 0x00CDFBEB File Offset: 0x00CDDDEB
		[NullableContext(1)]
		public void BindOnItemButtonClickedCallback(Action<int, SignState> onItemButtonClicked)
		{
			this.OnItemButtonClickedCallback = onItemButtonClicked;
		}

		// Token: 0x0603666A RID: 222826 RVA: 0x00CDFBF4 File Offset: 0x00CDDDF4
		private void ExtendToggleStateChanged(EToggleState state)
		{
			if (this.OnItemButtonClickedCallback != null)
			{
				this.OnItemButtonClickedCallback(this.EventIdKey, this.State);
			}
		}

		// Token: 0x0401CBFD RID: 117757
		private int EventIdKey;

		// Token: 0x0401CBFE RID: 117758
		private SignState State;

		// Token: 0x0401CBFF RID: 117759
		[Nullable(2)]
		private Action<int, SignState> OnItemButtonClickedCallback;
	}
}
