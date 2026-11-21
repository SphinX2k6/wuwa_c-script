using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiRoleCamera.Struct
{
	// Token: 0x0200315C RID: 12636
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Game/Aki/Data/UiRoleCamera/Struct/SUiRoleCameraOffsetSetting.SUiRoleCameraOffsetSetting")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct SUiRoleCameraOffsetSetting : IEqualityOperators<SUiRoleCameraOffsetSetting, SUiRoleCameraOffsetSetting, bool>, IEquatable<SUiRoleCameraOffsetSetting>, IUnrealScriptStruct
	{
		// Token: 0x0601F1EB RID: 127467 RVA: 0x00926BF5 File Offset: 0x00924DF5
		public SUiRoleCameraOffsetSetting(float 镜头浮动最大高度, float 镜头浮动最低高度, float 镜头浮动最短臂长, float 镜头浮动最长臂长)
		{
			this.镜头浮动最大高度 = 镜头浮动最大高度;
			this.镜头浮动最低高度 = 镜头浮动最低高度;
			this.镜头浮动最短臂长 = 镜头浮动最短臂长;
			this.镜头浮动最长臂长 = 镜头浮动最长臂长;
		}

		// Token: 0x0601F1EC RID: 127468 RVA: 0x00926C14 File Offset: 0x00924E14
		public static bool operator ==(SUiRoleCameraOffsetSetting left, SUiRoleCameraOffsetSetting right)
		{
			return left.镜头浮动最大高度 == right.镜头浮动最大高度 && left.镜头浮动最低高度 == right.镜头浮动最低高度 && left.镜头浮动最短臂长 == right.镜头浮动最短臂长 && left.镜头浮动最长臂长 == right.镜头浮动最长臂长;
		}

		// Token: 0x0601F1ED RID: 127469 RVA: 0x00926C50 File Offset: 0x00924E50
		public static bool operator !=(SUiRoleCameraOffsetSetting left, SUiRoleCameraOffsetSetting right)
		{
			return !(left == right);
		}

		// Token: 0x0601F1EE RID: 127470 RVA: 0x00926C5C File Offset: 0x00924E5C
		public bool Equals(SUiRoleCameraOffsetSetting other)
		{
			return this == other;
		}

		// Token: 0x0601F1EF RID: 127471 RVA: 0x00926C6C File Offset: 0x00924E6C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SUiRoleCameraOffsetSetting)
			{
				SUiRoleCameraOffsetSetting other = (SUiRoleCameraOffsetSetting)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601F1F0 RID: 127472 RVA: 0x00926C91 File Offset: 0x00924E91
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.镜头浮动最大高度, this.镜头浮动最低高度, this.镜头浮动最短臂长, this.镜头浮动最长臂长);
		}

		// Token: 0x0601F1F1 RID: 127473 RVA: 0x00926CB0 File Offset: 0x00924EB0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiRoleCameraOffsetSetting._ScriptStructPtr != 0) ? SUiRoleCameraOffsetSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiRoleCamera/Struct/SUiRoleCameraOffsetSetting.SUiRoleCameraOffsetSetting", ref SUiRoleCameraOffsetSetting._ScriptStructPtr);
		}

		// Token: 0x04010A0D RID: 68109
		[FieldOffset(0)]
		public float 镜头浮动最大高度;

		// Token: 0x04010A0E RID: 68110
		[FieldOffset(4)]
		public float 镜头浮动最低高度;

		// Token: 0x04010A0F RID: 68111
		[FieldOffset(8)]
		public float 镜头浮动最短臂长;

		// Token: 0x04010A10 RID: 68112
		[FieldOffset(12)]
		public float 镜头浮动最长臂长;

		// Token: 0x04010A11 RID: 68113
		public const string __ObjectPath = "/Game/Aki/Data/UiRoleCamera/Struct/SUiRoleCameraOffsetSetting.SUiRoleCameraOffsetSetting";

		// Token: 0x04010A12 RID: 68114
		private static IntPtr _ScriptStructPtr;
	}
}
