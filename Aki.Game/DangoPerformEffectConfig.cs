using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02000F2B RID: 3883
[NullableContext(1)]
[Nullable(0)]
public class DangoPerformEffectConfig
{
	// Token: 0x04005C8F RID: 23695
	public string EffectPath = "";

	// Token: 0x04005C90 RID: 23696
	public EDangoPerformLocationType PerformLocationType = EDangoPerformLocationType.当前团子位置;

	// Token: 0x04005C91 RID: 23697
	public Vector LocationOffset = Vector.Create();

	// Token: 0x04005C92 RID: 23698
	public FName? AttachSocket;

	// Token: 0x04005C93 RID: 23699
	public int DelayTime;
}
