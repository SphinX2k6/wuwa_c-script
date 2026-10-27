using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020043E0 RID: 17376
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting_FollowTarget.SMovieCameraConfigItem_SequenceSetting_FollowTarget")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SMovieCameraConfigItem_SequenceSetting_FollowTarget : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D03C RID: 184380 RVA: 0x00A2E6AC File Offset: 0x00A2C8AC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovieCameraConfigItem_SequenceSetting_FollowTarget._ScriptStructPtr != 0) ? SMovieCameraConfigItem_SequenceSetting_FollowTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting_FollowTarget.SMovieCameraConfigItem_SequenceSetting_FollowTarget", ref SMovieCameraConfigItem_SequenceSetting_FollowTarget._ScriptStructPtr);
		}

		// Token: 0x1700720D RID: 29197
		// (get) Token: 0x0602D03D RID: 184381 RVA: 0x00A2E6D0 File Offset: 0x00A2C8D0
		// (set) Token: 0x0602D03E RID: 184382 RVA: 0x00A2E6E0 File Offset: 0x00A2C8E0
		public unsafe bool IsFollowTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700720E RID: 29198
		// (get) Token: 0x0602D03F RID: 184383 RVA: 0x00A2E6F1 File Offset: 0x00A2C8F1
		// (set) Token: 0x0602D040 RID: 184384 RVA: 0x00A2E705 File Offset: 0x00A2C905
		public unsafe TEnumAsByte<EMovieCameraSequenceSettingFollowTargetType> FollowType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700720F RID: 29199
		// (get) Token: 0x0602D041 RID: 184385 RVA: 0x00A2E71A File Offset: 0x00A2C91A
		// (set) Token: 0x0602D042 RID: 184386 RVA: 0x00A2E72A File Offset: 0x00A2C92A
		public unsafe float FollowSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17007210 RID: 29200
		// (get) Token: 0x0602D043 RID: 184387 RVA: 0x00A2E73B File Offset: 0x00A2C93B
		// (set) Token: 0x0602D044 RID: 184388 RVA: 0x00A2E74B File Offset: 0x00A2C94B
		public unsafe float PitchFollowSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17007211 RID: 29201
		// (get) Token: 0x0602D045 RID: 184389 RVA: 0x00A2E75C File Offset: 0x00A2C95C
		// (set) Token: 0x0602D046 RID: 184390 RVA: 0x00A2E76C File Offset: 0x00A2C96C
		public unsafe float AngleFollowSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602D047 RID: 184391 RVA: 0x00A2E77D File Offset: 0x00A2C97D
		public SMovieCameraConfigItem_SequenceSetting_FollowTarget()
		{
		}

		// Token: 0x0602D048 RID: 184392 RVA: 0x00A2E785 File Offset: 0x00A2C985
		public SMovieCameraConfigItem_SequenceSetting_FollowTarget(bool IsFollowTarget, TEnumAsByte<EMovieCameraSequenceSettingFollowTargetType> FollowType, float FollowSpeed, float PitchFollowSpeed, float AngleFollowSpeed)
		{
			this.IsFollowTarget = IsFollowTarget;
			this.FollowType = FollowType;
			this.FollowSpeed = FollowSpeed;
			this.PitchFollowSpeed = PitchFollowSpeed;
			this.AngleFollowSpeed = AngleFollowSpeed;
		}

		// Token: 0x0602D049 RID: 184393 RVA: 0x00A2E7B2 File Offset: 0x00A2C9B2
		protected override IntPtr GetUStructPtr()
		{
			return SMovieCameraConfigItem_SequenceSetting_FollowTarget.StaticStruct();
		}

		// Token: 0x0602D04A RID: 184394 RVA: 0x00A2E7BE File Offset: 0x00A2C9BE
		[NullableContext(2)]
		public SMovieCameraConfigItem_SequenceSetting_FollowTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D04B RID: 184395 RVA: 0x00A2E7C8 File Offset: 0x00A2C9C8
		public SMovieCameraConfigItem_SequenceSetting_FollowTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D04C RID: 184396 RVA: 0x00A2E7D3 File Offset: 0x00A2C9D3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovieCameraConfigItem_SequenceSetting_FollowTarget(Pointer, false, true);
		}

		// Token: 0x0602D04D RID: 184397 RVA: 0x00A2E7DD File Offset: 0x00A2C9DD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovieCameraConfigItem_SequenceSetting_FollowTarget(Pointer, MemoryOwner);
		}

		// Token: 0x04017E34 RID: 97844
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting_FollowTarget.SMovieCameraConfigItem_SequenceSetting_FollowTarget";

		// Token: 0x04017E35 RID: 97845
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017E36 RID: 97846
		internal static int __PropertyOffset_0;

		// Token: 0x04017E37 RID: 97847
		internal static int __PropertyOffset_1;

		// Token: 0x04017E38 RID: 97848
		internal static int __PropertyOffset_2;

		// Token: 0x04017E39 RID: 97849
		internal static int __PropertyOffset_3;

		// Token: 0x04017E3A RID: 97850
		internal static int __PropertyOffset_4;
	}
}
