using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058A8 RID: 22696
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolConditionTimeSlot : ActivityConditionBase
	{
		// Token: 0x17006B4D RID: 27469
		// (get) Token: 0x06037EA0 RID: 229024 RVA: 0x00FA13F7 File Offset: 0x00F9F5F7
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037EA1 RID: 229025 RVA: 0x00FA13FA File Offset: 0x00F9F5FA
		protected override bool OnInitialize(ConditionParams p)
		{
			this.TimeSlots = p.GetIntList("TimeSlots").ToArray();
			return true;
		}

		// Token: 0x06037EA2 RID: 229026 RVA: 0x00FA1414 File Offset: 0x00F9F614
		protected override bool OnCheck()
		{
			int currentSlot = (int)SolarSchoolGamePlayModel.Instance.TimeData.CurrentSlot;
			int[] timeSlots = this.TimeSlots;
			for (int i = 0; i < timeSlots.Length; i++)
			{
				if (timeSlots[i] == currentSlot)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06037EA3 RID: 229027 RVA: 0x00FA144F File Offset: 0x00F9F64F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
		}

		// Token: 0x06037EA4 RID: 229028 RVA: 0x00FA146D File Offset: 0x00F9F66D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
		}

		// Token: 0x06037EA5 RID: 229029 RVA: 0x00FA148B File Offset: 0x00F9F68B
		protected override void OnClear()
		{
			this.TimeSlots = Array.Empty<int>();
		}

		// Token: 0x06037EA6 RID: 229030 RVA: 0x00FA1498 File Offset: 0x00F9F698
		private void OnTimeChanged()
		{
			base.FinishExecute();
		}

		// Token: 0x0401D7FE RID: 120830
		private int[] TimeSlots = Array.Empty<int>();
	}
}
