using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061E3 RID: 25059
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookTabItemBase : UiPanelBase
	{
		// Token: 0x0603F42A RID: 259114 RVA: 0x00F49369 File Offset: 0x00F47569
		public RoadBookTabItemBase(ActivityRoadBookData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0603F42B RID: 259115 RVA: 0x00F49378 File Offset: 0x00F47578
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleSelectOn))
			};
		}

		// Token: 0x0603F42C RID: 259116 RVA: 0x00F49421 File Offset: 0x00F47621
		private void OnToggleSelectOn(EToggleState toggleState)
		{
			if (this.Data != null)
			{
				Action<RoadBookAreaData, int> selectedCallBack = this.SelectedCallBack;
				if (selectedCallBack == null)
				{
					return;
				}
				selectedCallBack(this.Data, this.Index);
			}
		}

		// Token: 0x0603F42D RID: 259117 RVA: 0x00F49448 File Offset: 0x00F47648
		public void SetToggleState(bool bOn, bool bFireEvent)
		{
			EToggleState state = bOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, bFireEvent, false, false);
		}

		// Token: 0x0603F42E RID: 259118 RVA: 0x00F4946E File Offset: 0x00F4766E
		public virtual void RefreshByData(RoadBookAreaData data, int index)
		{
			this.Data = data;
			this.Index = index;
		}

		// Token: 0x04020FC8 RID: 135112
		[Nullable(2)]
		protected RoadBookAreaData Data;

		// Token: 0x04020FC9 RID: 135113
		protected int Index;

		// Token: 0x04020FCA RID: 135114
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoadBookAreaData, int> SelectedCallBack;

		// Token: 0x04020FCB RID: 135115
		protected ActivityRoadBookData ActivityBaseData;
	}
}
