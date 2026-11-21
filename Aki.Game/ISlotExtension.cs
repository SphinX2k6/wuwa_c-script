using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001089 RID: 4233
[NullableContext(1)]
public interface ISlotExtension
{
	// Token: 0x0600A83B RID: 43067
	UniTask OnAttach(ISlotMountPoint mount, int position);

	// Token: 0x0600A83C RID: 43068
	void OnDetach();

	// Token: 0x0600A83D RID: 43069
	void OnRefresh(IRoleSlotDisplayData data);

	// Token: 0x0600A83E RID: 43070 RVA: 0x003183B0 File Offset: 0x003165B0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	UUIItem[] QueryGuideItem(string[] configParams)
	{
		return null;
	}

	// Token: 0x0600A83F RID: 43071 RVA: 0x003183B3 File Offset: 0x003165B3
	void OnSlotStartMove()
	{
	}

	// Token: 0x0600A840 RID: 43072 RVA: 0x003183B5 File Offset: 0x003165B5
	void OnSlotStopMove()
	{
	}
}
