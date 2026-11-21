using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058AB RID: 22699
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolConditionWeekday : ActivityConditionBase
	{
		// Token: 0x17006B50 RID: 27472
		// (get) Token: 0x06037EB9 RID: 229049 RVA: 0x00FA167A File Offset: 0x00F9F87A
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037EBA RID: 229050 RVA: 0x00FA167D File Offset: 0x00F9F87D
		protected override bool OnInitialize(ConditionParams p)
		{
			this.Weekdays = p.GetIntList("Weekdays").ToArray();
			return true;
		}

		// Token: 0x06037EBB RID: 229051 RVA: 0x00FA1698 File Offset: 0x00F9F898
		protected override bool OnCheck()
		{
			int currentWeekday = SolarSchoolGamePlayModel.Instance.TimeData.CurrentWeekday;
			int[] weekdays = this.Weekdays;
			for (int i = 0; i < weekdays.Length; i++)
			{
				if (weekdays[i] == currentWeekday)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06037EBC RID: 229052 RVA: 0x00FA16D3 File Offset: 0x00F9F8D3
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
		}

		// Token: 0x06037EBD RID: 229053 RVA: 0x00FA16F1 File Offset: 0x00F9F8F1
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
		}

		// Token: 0x06037EBE RID: 229054 RVA: 0x00FA170F File Offset: 0x00F9F90F
		protected override void OnClear()
		{
			this.Weekdays = Array.Empty<int>();
		}

		// Token: 0x06037EBF RID: 229055 RVA: 0x00FA171C File Offset: 0x00F9F91C
		private void OnTimeChanged()
		{
			base.FinishExecute();
		}

		// Token: 0x0401D801 RID: 120833
		private int[] Weekdays = Array.Empty<int>();
	}
}
