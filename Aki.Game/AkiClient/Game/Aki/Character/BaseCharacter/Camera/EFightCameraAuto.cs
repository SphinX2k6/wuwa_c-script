using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043AA RID: 17322
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraAuto.EFightCameraAuto")]
	public enum EFightCameraAuto : byte
	{
		// Token: 0x04017B09 RID: 97033
		None,
		// Token: 0x04017B0A RID: 97034
		目标比角色更靠近镜头时额外臂长,
		// Token: 0x04017B0B RID: 97035
		额外臂长最小增量_目标距离_,
		// Token: 0x04017B0C RID: 97036
		额外臂长最大增量_目标距离_,
		// Token: 0x04017B0D RID: 97037
		额外臂长最大距离_目标距离_,
		// Token: 0x04017B0E RID: 97038
		额外臂长最小增量_目标高度_,
		// Token: 0x04017B0F RID: 97039
		角色屏幕高度参考,
		// Token: 0x04017B10 RID: 97040
		额外臂垂直偏移系数_角色屏幕高度与参考值差_,
		// Token: 0x04017B11 RID: 97041
		额外臂长最大增量_目标高度_,
		// Token: 0x04017B12 RID: 97042
		额外臂长最大距离_目标高度_,
		// Token: 0x04017B13 RID: 97043
		额外臂水平偏移最小偏移_目标距离_,
		// Token: 0x04017B14 RID: 97044
		臂长过渡速度,
		// Token: 0x04017B15 RID: 97045
		臂偏移过渡速度,
		// Token: 0x04017B16 RID: 97046
		检测屏幕内MinX_外_,
		// Token: 0x04017B17 RID: 97047
		检测屏幕内MaxX_外_,
		// Token: 0x04017B18 RID: 97048
		检测屏幕内MinY_外_,
		// Token: 0x04017B19 RID: 97049
		检测屏幕内MaxY_外_,
		// Token: 0x04017B1A RID: 97050
		额外臂水平偏移最大偏移_目标距离_,
		// Token: 0x04017B1B RID: 97051
		额外臂水平偏移最大距离_目标距离_,
		// Token: 0x04017B1C RID: 97052
		额外臂垂直偏移最小偏移_目标高度差_,
		// Token: 0x04017B1D RID: 97053
		额外臂垂直偏移最大偏移_目标高度差_,
		// Token: 0x04017B1E RID: 97054
		额外臂垂直偏移与目标最大高度差_目标高度差_,
		// Token: 0x04017B1F RID: 97055
		额外臂垂直偏移速度,
		// Token: 0x04017B20 RID: 97056
		额外臂垂直偏移与目标最小高度差_目标高度差_,
		// Token: 0x04017B21 RID: 97057
		EFightCameraAuto_MAX
	}
}
