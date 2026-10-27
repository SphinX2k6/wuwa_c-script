using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiRoleCamera.Struct
{
	// Token: 0x02003E85 RID: 16005
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Game/Aki/Data/UiRoleCamera/Struct/SUiRoleCameraOffsetSetting.SUiRoleCameraOffsetSetting")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct SUiRoleCameraOffsetSetting : IEqualityOperators<SUiRoleCameraOffsetSetting, SUiRoleCameraOffsetSetting, bool>, IEquatable<SUiRoleCameraOffsetSetting>, IUnrealScriptStruct
	{
		// Token: 0x06028683 RID: 165507 RVA: 0x009ABB25 File Offset: 0x009A9D25
		public SUiRoleCameraOffsetSetting(float 镜头浮动最大高度, float 镜头浮动最低高度, float 镜头浮动最短臂长, float 镜头浮动最长臂长)
		{
			this.镜头浮动最大高度 = 镜头浮动最大高度;
			this.镜头浮动最低高度 = 镜头浮动最低高度;
			this.镜头浮动最短臂长 = 镜头浮动最短臂长;
			this.镜头浮动最长臂长 = 镜头浮动最长臂长;
		}

		// Token: 0x06028684 RID: 165508 RVA: 0x009ABB44 File Offset: 0x009A9D44
		public static bool operator ==(SUiRoleCameraOffsetSetting left, SUiRoleCameraOffsetSetting right)
		{
			return left.镜头浮动最大高度 == right.镜头浮动最大高度 && left.镜头浮动最低高度 == right.镜头浮动最低高度 && left.镜头浮动最短臂长 == right.镜头浮动最短臂长 && left.镜头浮动最长臂长 == right.镜头浮动最长臂长;
		}

		// Token: 0x06028685 RID: 165509 RVA: 0x009ABB80 File Offset: 0x009A9D80
		public static bool operator !=(SUiRoleCameraOffsetSetting left, SUiRoleCameraOffsetSetting right)
		{
			return !(left == right);
		}

		// Token: 0x06028686 RID: 165510 RVA: 0x009ABB8C File Offset: 0x009A9D8C
		public bool Equals(SUiRoleCameraOffsetSetting other)
		{
			return this == other;
		}

		// Token: 0x06028687 RID: 165511 RVA: 0x009ABB9C File Offset: 0x009A9D9C
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

		// Token: 0x06028688 RID: 165512 RVA: 0x009ABBC1 File Offset: 0x009A9DC1
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.镜头浮动最大高度, this.镜头浮动最低高度, this.镜头浮动最短臂长, this.镜头浮动最长臂长);
		}

		// Token: 0x06028689 RID: 165513 RVA: 0x009ABBE0 File Offset: 0x009A9DE0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiRoleCameraOffsetSetting._ScriptStructPtr != 0) ? SUiRoleCameraOffsetSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiRoleCamera/Struct/SUiRoleCameraOffsetSetting.SUiRoleCameraOffsetSetting", ref SUiRoleCameraOffsetSetting._ScriptStructPtr);
		}

		// Token: 0x0401498C RID: 84364
		[FieldOffset(0)]
		public float 镜头浮动最大高度;

		// Token: 0x0401498D RID: 84365
		[FieldOffset(4)]
		public float 镜头浮动最低高度;

		// Token: 0x0401498E RID: 84366
		[FieldOffset(8)]
		public float 镜头浮动最短臂长;

		// Token: 0x0401498F RID: 84367
		[FieldOffset(12)]
		public float 镜头浮动最长臂长;

		// Token: 0x04014990 RID: 84368
		public const string __ObjectPath = "/Game/Aki/Data/UiRoleCamera/Struct/SUiRoleCameraOffsetSetting.SUiRoleCameraOffsetSetting";

		// Token: 0x04014991 RID: 84369
		private static IntPtr _ScriptStructPtr;
	}
}
