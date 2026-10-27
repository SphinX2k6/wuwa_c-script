using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02001A6C RID: 6764
[NullableContext(1)]
[Nullable(0)]
public class DangoPerformEffectConfig
{
	// Token: 0x04005BC0 RID: 23488
	public string EffectPath = "";

	// Token: 0x04005BC1 RID: 23489
	public EDangoPerformLocationType PerformLocationType = EDangoPerformLocationType.当前团子位置;

	// Token: 0x04005BC2 RID: 23490
	public Vector LocationOffset = Vector.Create();

	// Token: 0x04005BC3 RID: 23491
	public FName? AttachSocket;

	// Token: 0x04005BC4 RID: 23492
	public int DelayTime;
}
