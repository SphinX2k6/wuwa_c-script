using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003DA5 RID: 15781
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/QuantizerMode.QuantizerMode")]
	public enum QuantizerMode : byte
	{
		// Token: 0x04013C0D RID: 80909
		No_Quantizer___No_Texture_Offset,
		// Token: 0x04013C0E RID: 80910
		No_Quantizer___Texture_Offset_Manually_Set,
		// Token: 0x04013C0F RID: 80911
		No_Quantizer___Texture_Offset_Automatic___Extremes_Corrected,
		// Token: 0x04013C10 RID: 80912
		No_Quantizer___Texture_Offset_Automatic,
		// Token: 0x04013C11 RID: 80913
		Step__1_meter___Texture_Offset_Automatic,
		// Token: 0x04013C12 RID: 80914
		Step__2_meters___Texture_Offset_Automatic,
		// Token: 0x04013C13 RID: 80915
		Step__3_meters___Texture_Offset_Automatic,
		// Token: 0x04013C14 RID: 80916
		Step__4_meters___Texture_Offset_Automatic,
		// Token: 0x04013C15 RID: 80917
		Step__5_meters___Texture_Offset_Automatic,
		// Token: 0x04013C16 RID: 80918
		Step__10_meters___Texture_Offset_Automatic,
		// Token: 0x04013C17 RID: 80919
		Step__20_meters___Texture_Offset_Automatic,
		// Token: 0x04013C18 RID: 80920
		Step__30_meters___Texture_Offset_Automatic,
		// Token: 0x04013C19 RID: 80921
		Step__50_meters___Texture_Offset_Automatic,
		// Token: 0x04013C1A RID: 80922
		Step__100_meters___Texture_Offset_Automatic,
		// Token: 0x04013C1B RID: 80923
		Step__500_meters___Texture_Offset_Automatic,
		// Token: 0x04013C1C RID: 80924
		QuantizerMode_MAX
	}
}
