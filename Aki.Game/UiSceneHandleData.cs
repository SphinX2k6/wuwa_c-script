using System;
using System.Runtime.CompilerServices;

// Token: 0x02002C62 RID: 11362
[NullableContext(1)]
[Nullable(0)]
public class UiSceneHandleData
{
	// Token: 0x06017BF4 RID: 97268 RVA: 0x00609930 File Offset: 0x00607B30
	public UiSceneHandleData()
	{
		this.CustomPromise = new CustomPromise<bool>();
	}

	// Token: 0x06017BF5 RID: 97269 RVA: 0x00609943 File Offset: 0x00607B43
	public void SetSequence(UiCameraSequence sequence)
	{
		this.Sequence = sequence;
	}

	// Token: 0x06017BF6 RID: 97270 RVA: 0x0060994C File Offset: 0x00607B4C
	public void DestroyUiCameraSequence()
	{
		UiCameraSequence sequence = this.Sequence;
		if (sequence != null)
		{
			sequence.DestroyUiCameraSequence(true);
		}
		this.Sequence = null;
	}

	// Token: 0x0400B0D3 RID: 45267
	public CustomPromise<bool> CustomPromise;

	// Token: 0x0400B0D4 RID: 45268
	[Nullable(2)]
	private UiCameraSequence Sequence;
}
