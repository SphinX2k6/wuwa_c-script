using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.Vehicle
{
	// Token: 0x020031BC RID: 12732
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Level/Vehicle/SFloatThresholdAndCameraShake.SFloatThresholdAndCameraShake")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SFloatThresholdAndCameraShake : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F7B2 RID: 128946 RVA: 0x0092EBB4 File Offset: 0x0092CDB4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFloatThresholdAndCameraShake._ScriptStructPtr != 0) ? SFloatThresholdAndCameraShake._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/Vehicle/SFloatThresholdAndCameraShake.SFloatThresholdAndCameraShake", ref SFloatThresholdAndCameraShake._ScriptStructPtr);
		}

		// Token: 0x1700398F RID: 14735
		// (get) Token: 0x0601F7B3 RID: 128947 RVA: 0x0092EBD8 File Offset: 0x0092CDD8
		// (set) Token: 0x0601F7B4 RID: 128948 RVA: 0x0092EBE8 File Offset: 0x0092CDE8
		public unsafe float Threshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFloatThresholdAndCameraShake.__PropertyOffset_Threshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFloatThresholdAndCameraShake.__PropertyOffset_Threshold) = value;
			}
		}

		// Token: 0x17003990 RID: 14736
		// (get) Token: 0x0601F7B5 RID: 128949 RVA: 0x0092EBF9 File Offset: 0x0092CDF9
		// (set) Token: 0x0601F7B6 RID: 128950 RVA: 0x0092EC0D File Offset: 0x0092CE0D
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<BP_CameraShakeAndForceFeedback_C> CameraShakeAndForceFeedback
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)SFloatThresholdAndCameraShake.__PropertyOffset_CameraShakeAndForceFeedback);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)SFloatThresholdAndCameraShake.__PropertyOffset_CameraShakeAndForceFeedback) = value;
			}
		}

		// Token: 0x0601F7B7 RID: 128951 RVA: 0x0092EC22 File Offset: 0x0092CE22
		public SFloatThresholdAndCameraShake()
		{
		}

		// Token: 0x0601F7B8 RID: 128952 RVA: 0x0092EC2A File Offset: 0x0092CE2A
		protected override IntPtr GetUStructPtr()
		{
			return SFloatThresholdAndCameraShake.StaticStruct();
		}

		// Token: 0x0601F7B9 RID: 128953 RVA: 0x0092EC36 File Offset: 0x0092CE36
		[NullableContext(2)]
		public SFloatThresholdAndCameraShake(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F7BA RID: 128954 RVA: 0x0092EC40 File Offset: 0x0092CE40
		public SFloatThresholdAndCameraShake(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F7BB RID: 128955 RVA: 0x0092EC4B File Offset: 0x0092CE4B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFloatThresholdAndCameraShake(Pointer, false, true);
		}

		// Token: 0x0601F7BC RID: 128956 RVA: 0x0092EC55 File Offset: 0x0092CE55
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFloatThresholdAndCameraShake(Pointer, MemoryOwner);
		}

		// Token: 0x04010E28 RID: 69160
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Level/Vehicle/SFloatThresholdAndCameraShake.SFloatThresholdAndCameraShake";

		// Token: 0x04010E29 RID: 69161
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010E2A RID: 69162
		internal static int __PropertyOffset_Threshold;

		// Token: 0x04010E2B RID: 69163
		internal static int __PropertyOffset_CameraShakeAndForceFeedback;
	}
}
