using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001BCA RID: 7114
[NullableContext(1)]
public interface ISlotExtension
{
	// Token: 0x0600D429 RID: 54313
	UniTask OnAttach(ISlotMountPoint mount, int position);

	// Token: 0x0600D42A RID: 54314
	void OnDetach();

	// Token: 0x0600D42B RID: 54315
	void OnRefresh(IRoleSlotDisplayData data);

	// Token: 0x0600D42C RID: 54316 RVA: 0x0030D23C File Offset: 0x0030B43C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	UUIItem[] QueryGuideItem(string[] configParams)
	{
		return null;
	}

	// Token: 0x0600D42D RID: 54317 RVA: 0x0030D23F File Offset: 0x0030B43F
	void OnSlotStartMove()
	{
	}

	// Token: 0x0600D42E RID: 54318 RVA: 0x0030D241 File Offset: 0x0030B441
	void OnSlotStopMove()
	{
	}
}
