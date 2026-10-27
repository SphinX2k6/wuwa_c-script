using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C10 RID: 7184
[NullableContext(1)]
public interface ISlotPresenter
{
	// Token: 0x0600D76C RID: 55148
	void Refresh(int position, IRoleSlotDisplayData data);

	// Token: 0x0600D76D RID: 55149
	void Reset(int position);

	// Token: 0x0600D76E RID: 55150
	void ResetAll();

	// Token: 0x0600D76F RID: 55151
	void ActivateDragData();

	// Token: 0x0600D770 RID: 55152
	void DestroyAll();

	// Token: 0x0600D771 RID: 55153
	void OnTick(float delta);

	// Token: 0x0600D772 RID: 55154
	void OnHandleLoadScene();

	// Token: 0x0600D773 RID: 55155
	void OnHandleReleaseScene();
}
