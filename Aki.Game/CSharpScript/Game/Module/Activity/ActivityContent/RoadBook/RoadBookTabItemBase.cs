using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005161 RID: 20833
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookTabItemBase : UiPanelBase
	{
		// Token: 0x060340EB RID: 213227 RVA: 0x00E902C1 File Offset: 0x00E8E4C1
		public RoadBookTabItemBase(ActivityRoadBookData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x060340EC RID: 213228 RVA: 0x00E902D0 File Offset: 0x00E8E4D0
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

		// Token: 0x060340ED RID: 213229 RVA: 0x00E90379 File Offset: 0x00E8E579
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

		// Token: 0x060340EE RID: 213230 RVA: 0x00E903A0 File Offset: 0x00E8E5A0
		public void SetToggleState(bool bOn, bool bFireEvent)
		{
			EToggleState state = bOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, bFireEvent, false, false);
		}

		// Token: 0x060340EF RID: 213231 RVA: 0x00E903C6 File Offset: 0x00E8E5C6
		public virtual void RefreshByData(RoadBookAreaData data, int index)
		{
			this.Data = data;
			this.Index = index;
		}

		// Token: 0x0401B8F7 RID: 112887
		[Nullable(2)]
		protected RoadBookAreaData Data;

		// Token: 0x0401B8F8 RID: 112888
		protected int Index;

		// Token: 0x0401B8F9 RID: 112889
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoadBookAreaData, int> SelectedCallBack;

		// Token: 0x0401B8FA RID: 112890
		protected ActivityRoadBookData ActivityBaseData;
	}
}
