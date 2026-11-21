using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006067 RID: 24679
	public class DollGrabMachineCountDownView : UiViewBase
	{
		// Token: 0x0603B413 RID: 242707 RVA: 0x010C45EB File Offset: 0x010C27EB
		[NullableContext(1)]
		public DollGrabMachineCountDownView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B414 RID: 242708 RVA: 0x010C45F4 File Offset: 0x010C27F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B415 RID: 242709 RVA: 0x010C463C File Offset: 0x010C283C
		protected override void OnBeforeShow()
		{
			this.PnlTips = base.GetItem(0);
			UUIItem pnlTips = this.PnlTips;
			if (pnlTips != null)
			{
				pnlTips.SetAnchorOffsetY(0f);
			}
			EventSystem.Instance.Add<EDollGrabMachineEndReason>(EEventName.OnDollGrabMachineEnd, new Action<EDollGrabMachineEndReason>(this.OnDollGrabMachineEnd));
		}

		// Token: 0x0603B416 RID: 242710 RVA: 0x010C4688 File Offset: 0x010C2888
		protected override void OnAfterPlayStartSequence()
		{
			EventSystem.Instance.Emit(EEventName.OnDollGrabMachineEndCoolDown);
			EventSystem.Instance.Remove<EDollGrabMachineEndReason>(EEventName.OnDollGrabMachineEnd, new Action<EDollGrabMachineEndReason>(this.OnDollGrabMachineEnd));
			base.CloseMe(null);
		}

		// Token: 0x0603B417 RID: 242711 RVA: 0x010C46BD File Offset: 0x010C28BD
		private void OnDollGrabMachineEnd(EDollGrabMachineEndReason reason)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null && uiViewSequence.IsInSequence())
			{
				UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
				if (uiViewSequence2 == null)
				{
					return;
				}
				uiViewSequence2.StopSequenceByKey("Start", false, false);
			}
		}

		// Token: 0x0401F300 RID: 127744
		[Nullable(2)]
		private UUIItem PnlTips;

		// Token: 0x0200B954 RID: 47444
		private enum EViewComponent
		{
			// Token: 0x0403928E RID: 234126
			PnlTips
		}
	}
}
