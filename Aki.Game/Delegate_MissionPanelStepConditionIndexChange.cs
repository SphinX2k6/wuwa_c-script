using System;
using CSharpScript.Game.Module.BattleUi.Views;

// Token: 0x0200056B RID: 1387
// (Invoke) Token: 0x0600320C RID: 12812
[EventRule(EEventName.MissionPanelStepConditionIndexChange)]
internal delegate void Delegate_MissionPanelStepConditionIndexChange(EMissionItemView viewId, int stepId, int? curConditionTextIndex);
