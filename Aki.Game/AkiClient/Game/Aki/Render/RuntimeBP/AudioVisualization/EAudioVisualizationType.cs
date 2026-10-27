using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.AudioVisualization
{
	// Token: 0x02003E3C RID: 15932
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/AudioVisualization/EAudioVisualizationType.EAudioVisualizationType")]
	public enum EAudioVisualizationType : byte
	{
		// Token: 0x04014540 RID: 83264
		Burst,
		// Token: 0x04014541 RID: 83265
		BurstSustain,
		// Token: 0x04014542 RID: 83266
		KeepControl,
		// Token: 0x04014543 RID: 83267
		EAudioVisualizationType_MAX
	}
}
