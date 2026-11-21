using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02004316 RID: 17174
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueTaskTabItem : GridProxyAbstract<RogueTaskRewardTabData>
	{
		// Token: 0x0602B66C RID: 177772 RVA: 0x00C334A8 File Offset: 0x00C316A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnTabToggle))
			};
		}

		// Token: 0x0602B66D RID: 177773 RVA: 0x00C33528 File Offset: 0x00C31728
		public void SetToggleState(bool bSelect, bool bFire)
		{
			EToggleState state = bSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
		}

		// Token: 0x0602B66E RID: 177774 RVA: 0x00C3354E File Offset: 0x00C3174E
		private void SetRedDotVisible(bool bVisible)
		{
			base.GetItem(2).SetUIActive(bVisible);
		}

		// Token: 0x0602B66F RID: 177775 RVA: 0x00C33560 File Offset: 0x00C31760
		public void RefreshRedDot()
		{
			RogueTaskRewardTabData tabData = this.TabData;
			bool? flag;
			if (tabData == null)
			{
				flag = null;
			}
			else
			{
				Func<int, bool> refreshRedDot = tabData.RefreshRedDot;
				flag = ((refreshRedDot != null) ? new bool?(refreshRedDot(this.TabIndex)) : null);
			}
			bool? flag2 = flag;
			bool valueOrDefault = flag2.GetValueOrDefault();
			this.SetRedDotVisible(valueOrDefault);
		}

		// Token: 0x0602B670 RID: 177776 RVA: 0x00C335B6 File Offset: 0x00C317B6
		public override void Refresh(RogueTaskRewardTabData data, bool isSelected, int gridIndex)
		{
			this.TabData = data;
			this.TabIndex = data.Index;
			if (data.NameTextId != null)
			{
				UUIText text = base.GetText(0);
				if (text != null)
				{
					text.ShowTextNew(data.NameTextId);
				}
			}
			this.RefreshRedDot();
		}

		// Token: 0x0602B671 RID: 177777 RVA: 0x00C335F1 File Offset: 0x00C317F1
		private void OnTabToggle(EToggleState state)
		{
			RogueTaskRewardTabData tabData = this.TabData;
			if (tabData == null)
			{
				return;
			}
			Action<int> clickedCallback = tabData.ClickedCallback;
			if (clickedCallback == null)
			{
				return;
			}
			clickedCallback(this.TabIndex);
		}

		// Token: 0x0401773F RID: 96063
		[Nullable(2)]
		private RogueTaskRewardTabData TabData;

		// Token: 0x04017740 RID: 96064
		private int TabIndex = -1;
	}
}
