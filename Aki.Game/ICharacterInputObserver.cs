using System;
using CSharpScript.Game.Input;

// Token: 0x020025C0 RID: 9664
public interface ICharacterInputObserver
{
	// Token: 0x0601803E RID: 98366
	void OnInputPress(EInputAction action, float time);

	// Token: 0x0601803F RID: 98367
	void OnInputRelease(EInputAction action, float time);

	// Token: 0x06018040 RID: 98368 RVA: 0x0073190A File Offset: 0x0072FB0A
	void OnObserverCleared()
	{
	}
}
