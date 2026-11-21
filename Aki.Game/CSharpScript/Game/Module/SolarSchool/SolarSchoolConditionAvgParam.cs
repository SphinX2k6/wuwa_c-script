using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005892 RID: 22674
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolConditionAvgParam : ActivityConditionBase
	{
		// Token: 0x17006B38 RID: 27448
		// (get) Token: 0x06037DDE RID: 228830 RVA: 0x00F9FEF2 File Offset: 0x00F9E0F2
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037DDF RID: 228831 RVA: 0x00F9FEF5 File Offset: 0x00F9E0F5
		protected override bool OnInitialize(ConditionParams p)
		{
			this.Key = p.GetString("Key", "");
			this.ExpectedValue = p.GetBool("Value", true);
			return true;
		}

		// Token: 0x06037DE0 RID: 228832 RVA: 0x00F9FF20 File Offset: 0x00F9E120
		protected override bool OnCheck()
		{
			return SolarSchoolGamePlayModel.Instance.AvgParamData.GetParam(this.Key) == this.ExpectedValue;
		}

		// Token: 0x06037DE1 RID: 228833 RVA: 0x00F9FF3F File Offset: 0x00F9E13F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolAvgParamChanged, new Action(this.OnAvgParamChanged));
		}

		// Token: 0x06037DE2 RID: 228834 RVA: 0x00F9FF5D File Offset: 0x00F9E15D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolAvgParamChanged, new Action(this.OnAvgParamChanged));
		}

		// Token: 0x06037DE3 RID: 228835 RVA: 0x00F9FF7B File Offset: 0x00F9E17B
		protected override void OnClear()
		{
			this.Key = string.Empty;
			this.ExpectedValue = false;
		}

		// Token: 0x06037DE4 RID: 228836 RVA: 0x00F9FF8F File Offset: 0x00F9E18F
		private void OnAvgParamChanged()
		{
			base.FinishExecute();
		}

		// Token: 0x0401D7C6 RID: 120774
		private string Key = string.Empty;

		// Token: 0x0401D7C7 RID: 120775
		private bool ExpectedValue;
	}
}
