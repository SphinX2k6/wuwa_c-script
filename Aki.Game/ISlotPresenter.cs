using System;
using System.Runtime.CompilerServices;

// Token: 0x020010CF RID: 4303
[NullableContext(1)]
public interface ISlotPresenter
{
	// Token: 0x0600AB80 RID: 43904
	void Refresh(int position, IRoleSlotDisplayData data);

	// Token: 0x0600AB81 RID: 43905
	void Reset(int position);

	// Token: 0x0600AB82 RID: 43906
	void ResetAll();

	// Token: 0x0600AB83 RID: 43907
	void ActivateDragData();

	// Token: 0x0600AB84 RID: 43908
	void DestroyAll();

	// Token: 0x0600AB85 RID: 43909
	void OnTick(float delta);

	// Token: 0x0600AB86 RID: 43910
	void OnHandleLoadScene();

	// Token: 0x0600AB87 RID: 43911
	void OnHandleReleaseScene();
}
