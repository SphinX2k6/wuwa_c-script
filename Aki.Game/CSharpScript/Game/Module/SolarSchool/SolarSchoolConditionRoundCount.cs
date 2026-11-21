using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058A3 RID: 22691
	public class SolarSchoolConditionRoundCount : ActivityConditionBase
	{
		// Token: 0x17006B48 RID: 27464
		// (get) Token: 0x06037E70 RID: 228976 RVA: 0x00FA0F0C File Offset: 0x00F9F10C
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E71 RID: 228977 RVA: 0x00FA0F0F File Offset: 0x00F9F10F
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.MinCount = p.GetInt("Min", int.MinValue);
			this.MaxCount = p.GetInt("Max", int.MaxValue);
			return true;
		}

		// Token: 0x06037E72 RID: 228978 RVA: 0x00FA0F40 File Offset: 0x00F9F140
		protected override bool OnCheck()
		{
			int conditionCycleCount = SolarSchoolGamePlayModel.Instance.GetConditionCycleCount();
			return conditionCycleCount >= this.MinCount && conditionCycleCount <= this.MaxCount;
		}

		// Token: 0x06037E73 RID: 228979 RVA: 0x00FA0F6F File Offset: 0x00F9F16F
		protected override void OnClear()
		{
			this.MinCount = 0;
			this.MaxCount = 0;
		}

		// Token: 0x0401D7ED RID: 120813
		private int MinCount;

		// Token: 0x0401D7EE RID: 120814
		private int MaxCount;
	}
}
