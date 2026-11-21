using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020021E3 RID: 8675
public class UiModelInputDataComponent : UiModelComponentBase
{
	// Token: 0x0601559F RID: 87455 RVA: 0x006353AF File Offset: 0x006335AF
	public float GetAxisInput(ERotateAxis axis)
	{
		return this.AxisInputMap.GetValueOrDefault(axis, 0f);
	}

	// Token: 0x060155A0 RID: 87456 RVA: 0x006353C2 File Offset: 0x006335C2
	public void UpdateAxisInput(ERotateAxis axis, float inputValue)
	{
		this.AxisInputMap[axis] = inputValue;
	}

	// Token: 0x0400B517 RID: 46359
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
