using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058A9 RID: 22697
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolConditionTired : ActivityConditionBase
	{
		// Token: 0x17006B4E RID: 27470
		// (get) Token: 0x06037EA8 RID: 229032 RVA: 0x00FA14B3 File Offset: 0x00F9F6B3
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037EA9 RID: 229033 RVA: 0x00FA14B6 File Offset: 0x00F9F6B6
		protected override bool OnInitialize(ConditionParams p)
		{
			this.Stages = p.GetIntList("Stages").ToArray();
			return this.Stages.Length != 0;
		}

		// Token: 0x06037EAA RID: 229034 RVA: 0x00FA14D8 File Offset: 0x00F9F6D8
		protected override bool OnCheck()
		{
			int currentStage = (int)this.GetCurrentStage();
			int[] stages = this.Stages;
			for (int i = 0; i < stages.Length; i++)
			{
				if (stages[i] == currentStage)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06037EAB RID: 229035 RVA: 0x00FA150A File Offset: 0x00F9F70A
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
		}

		// Token: 0x06037EAC RID: 229036 RVA: 0x00FA1528 File Offset: 0x00F9F728
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
		}

		// Token: 0x06037EAD RID: 229037 RVA: 0x00FA1546 File Offset: 0x00F9F746
		protected override void OnClear()
		{
			this.Stages = Array.Empty<int>();
		}

		// Token: 0x06037EAE RID: 229038 RVA: 0x00FA1553 File Offset: 0x00F9F753
		private void OnAttrChanged(ESolarSchoolSecondAttr attr)
		{
			if (attr == ESolarSchoolSecondAttr.Fatigue)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x06037EAF RID: 229039 RVA: 0x00FA1560 File Offset: 0x00F9F760
		private ESolarSchoolFatigueStage GetCurrentStage()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			int paramNumber = SolarSchoolConfig.Instance.GetParamNumber(instance.ActivityId, "TiredThreshold", 0);
			int paramNumber2 = SolarSchoolConfig.Instance.GetParamNumber(instance.ActivityId, "SickThreshold", 0);
			return SolarSchoolUtils.CalcFatigueStage(instance.GetConditionAttr(ESolarSchoolSecondAttr.Fatigue), paramNumber, paramNumber2);
		}

		// Token: 0x0401D7FF RID: 120831
		private int[] Stages = Array.Empty<int>();
	}
}
