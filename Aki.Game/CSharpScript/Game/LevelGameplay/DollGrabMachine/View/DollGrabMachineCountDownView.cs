using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EE7 RID: 28391
	public class DollGrabMachineCountDownView : UiViewBase
	{
		// Token: 0x0604526A RID: 283242 RVA: 0x0111A85B File Offset: 0x01118A5B
		[NullableContext(1)]
		public DollGrabMachineCountDownView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0604526B RID: 283243 RVA: 0x0111A864 File Offset: 0x01118A64
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

		// Token: 0x0604526C RID: 283244 RVA: 0x0111A8AC File Offset: 0x01118AAC
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

		// Token: 0x0604526D RID: 283245 RVA: 0x0111A8F8 File Offset: 0x01118AF8
		protected override void OnAfterPlayStartSequence()
		{
			EventSystem.Instance.Emit(EEventName.OnDollGrabMachineEndCoolDown);
			EventSystem.Instance.Remove<EDollGrabMachineEndReason>(EEventName.OnDollGrabMachineEnd, new Action<EDollGrabMachineEndReason>(this.OnDollGrabMachineEnd));
			base.CloseMe(null);
		}

		// Token: 0x0604526E RID: 283246 RVA: 0x0111A92D File Offset: 0x01118B2D
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

		// Token: 0x0402404D RID: 147533
		[Nullable(2)]
		private UUIItem PnlTips;

		// Token: 0x0200CD64 RID: 52580
		private enum EViewComponent
		{
			// Token: 0x0403DE6C RID: 253548
			PnlTips
		}
	}
}
