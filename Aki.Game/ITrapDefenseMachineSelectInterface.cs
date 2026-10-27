using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02001D42 RID: 7490
[NullableContext(2)]
public interface ITrapDefenseMachineSelectInterface
{
	// Token: 0x0600E32E RID: 58158
	void SelectMachine(TrapDefenseBuildingDevelopItemData data);

	// Token: 0x0600E32F RID: 58159
	void SliderPointerDown();

	// Token: 0x0600E330 RID: 58160
	void SliderValueChange(TrapDefenseBuildingDevelopItemData data);

	// Token: 0x0600E331 RID: 58161
	void SliderDragEnd();
}
