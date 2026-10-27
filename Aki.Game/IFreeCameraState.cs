using System;
using System.Runtime.CompilerServices;

// Token: 0x02001081 RID: 4225
[NullableContext(2)]
internal interface IFreeCameraState
{
	// Token: 0x1700090A RID: 2314
	// (get) Token: 0x06006D75 RID: 28021
	// (set) Token: 0x06006D76 RID: 28022
	[Nullable(1)]
	IFreeCameraConfig Config { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700090B RID: 2315
	// (get) Token: 0x06006D77 RID: 28023
	// (set) Token: 0x06006D78 RID: 28024
	float Timer { get; set; }

	// Token: 0x1700090C RID: 2316
	// (get) Token: 0x06006D79 RID: 28025
	// (set) Token: 0x06006D7A RID: 28026
	int LastDirection { get; set; }

	// Token: 0x1700090D RID: 2317
	// (get) Token: 0x06006D7B RID: 28027
	// (set) Token: 0x06006D7C RID: 28028
	bool IsInterpolating { get; set; }

	// Token: 0x1700090E RID: 2318
	// (get) Token: 0x06006D7D RID: 28029
	// (set) Token: 0x06006D7E RID: 28030
	float InterpolationElapsedTime { get; set; }

	// Token: 0x1700090F RID: 2319
	// (get) Token: 0x06006D7F RID: 28031
	// (set) Token: 0x06006D80 RID: 28032
	int StartDirection { get; set; }

	// Token: 0x17000910 RID: 2320
	// (get) Token: 0x06006D81 RID: 28033
	// (set) Token: 0x06006D82 RID: 28034
	int TargetDirection { get; set; }

	// Token: 0x17000911 RID: 2321
	// (get) Token: 0x06006D83 RID: 28035
	// (set) Token: 0x06006D84 RID: 28036
	bool? IsExiting { get; set; }

	// Token: 0x17000912 RID: 2322
	// (get) Token: 0x06006D85 RID: 28037
	// (set) Token: 0x06006D86 RID: 28038
	Vector ExitRelativePos { get; set; }

	// Token: 0x17000913 RID: 2323
	// (get) Token: 0x06006D87 RID: 28039
	// (set) Token: 0x06006D88 RID: 28040
	Rotator ExitRelativeRot { get; set; }

	// Token: 0x17000914 RID: 2324
	// (get) Token: 0x06006D89 RID: 28041
	// (set) Token: 0x06006D8A RID: 28042
	int? ExitFollowConfigIndex { get; set; }
}
