using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002217 RID: 8727
[NullableContext(1)]
public interface IUiModelRenderingMaterialChange
{
	// Token: 0x06015788 RID: 87944
	void OnRenderingMaterialAdd(int materialId, UObject data, bool isGroup, bool withAnimObject);

	// Token: 0x06015789 RID: 87945
	void OnRenderingMaterialRemove(int materialId, bool isGroup, bool withEnding);
}
