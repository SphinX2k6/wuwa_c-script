using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02001204 RID: 4612
[NullableContext(2)]
public interface ITrapDefenseMachineSelectInterface
{
	// Token: 0x0600B74B RID: 46923
	void SelectMachine(TrapDefenseBuildingDevelopItemData data);

	// Token: 0x0600B74C RID: 46924
	void SliderPointerDown();

	// Token: 0x0600B74D RID: 46925
	void SliderValueChange(TrapDefenseBuildingDevelopItemData data);

	// Token: 0x0600B74E RID: 46926
	void SliderDragEnd();
}
