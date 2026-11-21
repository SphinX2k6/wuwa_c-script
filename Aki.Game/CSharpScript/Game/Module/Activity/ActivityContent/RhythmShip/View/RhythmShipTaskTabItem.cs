using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051DC RID: 20956
	internal class RhythmShipTaskTabItem : GridProxyAbstract<int>
	{
		// Token: 0x0603436B RID: 213867 RVA: 0x00E9BD24 File Offset: 0x00E99F24
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
			};
		}

		// Token: 0x0603436C RID: 213868 RVA: 0x00E9BDA4 File Offset: 0x00E99FA4
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			if (this.TabId > 0)
			{
				RedDotController.Instance.UnBindGivenUi(ERedDotName.RhythmShipTaskTab, base.GetItem(2), this.TabId);
			}
			this.TabId = data;
			RhythmTaskTab? rhythmShipTaskTabById = RhythmShipConfig.Instance.GetRhythmShipTaskTabById(this.TabId);
			if (rhythmShipTaskTabById == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rhythmShipTaskTabById.Value.TabName, Array.Empty<object>());
			RedDotController.Instance.BindRedDot(ERedDotName.RhythmShipTaskTab, base.GetItem(2), null, this.TabId);
		}

		// Token: 0x0603436D RID: 213869 RVA: 0x00E9BE3A File Offset: 0x00E9A03A
		private void OnClickToggle(EToggleState state)
		{
			Action<int, UUIExtendToggle> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(this.TabId, base.GetExtendToggle(0));
		}

		// Token: 0x0603436E RID: 213870 RVA: 0x00E9BE59 File Offset: 0x00E9A059
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x0603436F RID: 213871 RVA: 0x00E9BE6C File Offset: 0x00E9A06C
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RhythmShipTaskTab, base.GetItem(2), this.TabId);
		}

		// Token: 0x0401BB41 RID: 113473
		public int TabId;

		// Token: 0x0401BB42 RID: 113474
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIExtendToggle> OnClickToggleCallBack;
	}
}
