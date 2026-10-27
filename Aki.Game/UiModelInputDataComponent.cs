using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002C8A RID: 11402
public class UiModelInputDataComponent : UiModelComponentBase
{
	// Token: 0x06017D2C RID: 97580 RVA: 0x0060F8DF File Offset: 0x0060DADF
	public float GetAxisInput(ERotateAxis axis)
	{
		return this.AxisInputMap.GetValueOrDefault(axis, 0f);
	}

	// Token: 0x06017D2D RID: 97581 RVA: 0x0060F8F2 File Offset: 0x0060DAF2
	public void UpdateAxisInput(ERotateAxis axis, float inputValue)
	{
		this.AxisInputMap[axis] = inputValue;
	}

	// Token: 0x0400B1AC RID: 45484
	[Nullable(1)]
	private readonly Dictionary<ERotateAxis, float> AxisInputMap = new Dictionary<ERotateAxis, float>
	{
		{
			ERotateAxis.Pitch,
			0f
		},
		{
			ERotateAxis.Yaw,
			0f
		},
		{
			ERotateAxis.Roll,
			0f
		}
	};
}
