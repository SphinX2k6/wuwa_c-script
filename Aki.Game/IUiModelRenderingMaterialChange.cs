using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002CBE RID: 11454
[NullableContext(1)]
public interface IUiModelRenderingMaterialChange
{
	// Token: 0x06017F0F RID: 98063
	void OnRenderingMaterialAdd(int materialId, UObject data, bool isGroup, bool withAnimObject);

	// Token: 0x06017F10 RID: 98064
	void OnRenderingMaterialRemove(int materialId, bool isGroup, bool withEnding);
}
