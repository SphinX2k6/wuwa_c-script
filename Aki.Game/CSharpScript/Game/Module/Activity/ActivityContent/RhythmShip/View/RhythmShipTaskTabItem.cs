using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x0200625E RID: 25182
	internal class RhythmShipTaskTabItem : GridProxyAbstract<int>
	{
		// Token: 0x0603F6AA RID: 259754 RVA: 0x00F54DC8 File Offset: 0x00F52FC8
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

		// Token: 0x0603F6AB RID: 259755 RVA: 0x00F54E48 File Offset: 0x00F53048
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

		// Token: 0x0603F6AC RID: 259756 RVA: 0x00F54EDE File Offset: 0x00F530DE
		private void OnClickToggle(EToggleState state)
		{
			Action<int, UUIExtendToggle> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(this.TabId, base.GetExtendToggle(0));
		}

		// Token: 0x0603F6AD RID: 259757 RVA: 0x00F54EFD File Offset: 0x00F530FD
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x0603F6AE RID: 259758 RVA: 0x00F54F10 File Offset: 0x00F53110
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RhythmShipTaskTab, base.GetItem(2), this.TabId);
		}

		// Token: 0x04021212 RID: 135698
		public int TabId;

		// Token: 0x04021213 RID: 135699
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIExtendToggle> OnClickToggleCallBack;
	}
}
