using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005346 RID: 21318
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueTaskTabItem : GridProxyAbstract<RogueTaskRewardTabData>
	{
		// Token: 0x06036770 RID: 223088 RVA: 0x00CE5AD8 File Offset: 0x00CE3CD8
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

		// Token: 0x06036771 RID: 223089 RVA: 0x00CE5B58 File Offset: 0x00CE3D58
		public void SetToggleState(bool bSelect, bool bFire)
		{
			EToggleState state = bSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
		}

		// Token: 0x06036772 RID: 223090 RVA: 0x00CE5B7E File Offset: 0x00CE3D7E
		private void SetRedDotVisible(bool bVisible)
		{
			base.GetItem(2).SetUIActive(bVisible);
		}

		// Token: 0x06036773 RID: 223091 RVA: 0x00CE5B90 File Offset: 0x00CE3D90
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

		// Token: 0x06036774 RID: 223092 RVA: 0x00CE5BE6 File Offset: 0x00CE3DE6
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

		// Token: 0x06036775 RID: 223093 RVA: 0x00CE5C21 File Offset: 0x00CE3E21
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

		// Token: 0x0401CD09 RID: 118025
		[Nullable(2)]
		private RogueTaskRewardTabData TabData;

		// Token: 0x0401CD0A RID: 118026
		private int TabIndex = -1;
	}
}
