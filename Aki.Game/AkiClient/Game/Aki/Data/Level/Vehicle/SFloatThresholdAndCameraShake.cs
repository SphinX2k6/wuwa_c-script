using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.Vehicle
{
	// Token: 0x02003EFF RID: 16127
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Level/Vehicle/SFloatThresholdAndCameraShake.SFloatThresholdAndCameraShake")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SFloatThresholdAndCameraShake : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028E15 RID: 167445 RVA: 0x009B6AEC File Offset: 0x009B4CEC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFloatThresholdAndCameraShake._ScriptStructPtr != 0) ? SFloatThresholdAndCameraShake._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/Vehicle/SFloatThresholdAndCameraShake.SFloatThresholdAndCameraShake", ref SFloatThresholdAndCameraShake._ScriptStructPtr);
		}

		// Token: 0x17006022 RID: 24610
		// (get) Token: 0x06028E16 RID: 167446 RVA: 0x009B6B10 File Offset: 0x009B4D10
		// (set) Token: 0x06028E17 RID: 167447 RVA: 0x009B6B20 File Offset: 0x009B4D20
		public unsafe float Threshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFloatThresholdAndCameraShake.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFloatThresholdAndCameraShake.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006023 RID: 24611
		// (get) Token: 0x06028E18 RID: 167448 RVA: 0x009B6B31 File Offset: 0x009B4D31
		// (set) Token: 0x06028E19 RID: 167449 RVA: 0x009B6B45 File Offset: 0x009B4D45
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
				return *(base.NativePtr + (IntPtr)SFloatThresholdAndCameraShake.__PropertyOffset_1);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)SFloatThresholdAndCameraShake.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x06028E1A RID: 167450 RVA: 0x009B6B5A File Offset: 0x009B4D5A
		public SFloatThresholdAndCameraShake()
		{
		}

		// Token: 0x06028E1B RID: 167451 RVA: 0x009B6B62 File Offset: 0x009B4D62
		public SFloatThresholdAndCameraShake(float Threshold, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<BP_CameraShakeAndForceFeedback_C> CameraShakeAndForceFeedback)
		{
			this.Threshold = Threshold;
			this.CameraShakeAndForceFeedback = CameraShakeAndForceFeedback;
		}

		// Token: 0x06028E1C RID: 167452 RVA: 0x009B6B78 File Offset: 0x009B4D78
		protected override IntPtr GetUStructPtr()
		{
			return SFloatThresholdAndCameraShake.StaticStruct();
		}

		// Token: 0x06028E1D RID: 167453 RVA: 0x009B6B84 File Offset: 0x009B4D84
		[NullableContext(2)]
		public SFloatThresholdAndCameraShake(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028E1E RID: 167454 RVA: 0x009B6B8E File Offset: 0x009B4D8E
		public SFloatThresholdAndCameraShake(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028E1F RID: 167455 RVA: 0x009B6B99 File Offset: 0x009B4D99
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFloatThresholdAndCameraShake(Pointer, false, true);
		}

		// Token: 0x06028E20 RID: 167456 RVA: 0x009B6BA3 File Offset: 0x009B4DA3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFloatThresholdAndCameraShake(Pointer, MemoryOwner);
		}

		// Token: 0x04014E83 RID: 85635
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Level/Vehicle/SFloatThresholdAndCameraShake.SFloatThresholdAndCameraShake";

		// Token: 0x04014E84 RID: 85636
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014E85 RID: 85637
		internal static int __PropertyOffset_0;

		// Token: 0x04014E86 RID: 85638
		internal static int __PropertyOffset_1;
	}
}
