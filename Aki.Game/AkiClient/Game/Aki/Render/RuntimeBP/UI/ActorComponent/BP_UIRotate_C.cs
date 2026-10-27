using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UI.ActorComponent
{
	// Token: 0x02003AA4 RID: 15012
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UI/ActorComponent/BP_UIRotate.BP_UIRotate_C")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 274)]
	public class BP_UIRotate_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020208 RID: 131592 RVA: 0x008CA644 File Offset: 0x008C8844
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_UIRotate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/UI/ActorComponent/BP_UIRotate.BP_UIRotate_C");
			}
			return BP_UIRotate_C._ClassPtr;
		}

		// Token: 0x06020209 RID: 131593 RVA: 0x008CA668 File Offset: 0x008C8868
		public BP_UIRotate_C() : this(BuiltinUtils.AllocNativeUObject(BP_UIRotate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602020A RID: 131594 RVA: 0x008CA690 File Offset: 0x008C8890
		[NullableContext(1)]
		public BP_UIRotate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_UIRotate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x0602020B RID: 131595 RVA: 0x008CA6C3 File Offset: 0x008C88C3
		// (set) Token: 0x0602020C RID: 131596 RVA: 0x008CA6D7 File Offset: 0x008C88D7
		public unsafe FVector2D ScaleXY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x0602020D RID: 131597 RVA: 0x008CA6EC File Offset: 0x008C88EC
		// (set) Token: 0x0602020E RID: 131598 RVA: 0x008CA6FC File Offset: 0x008C88FC
		public unsafe float LerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002F1A RID: 12058
		// (get) Token: 0x0602020F RID: 131599 RVA: 0x008CA70D File Offset: 0x008C890D
		// (set) Token: 0x06020210 RID: 131600 RVA: 0x008CA71D File Offset: 0x008C891D
		public unsafe float IdleLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002F1B RID: 12059
		// (get) Token: 0x06020211 RID: 131601 RVA: 0x008CA72E File Offset: 0x008C892E
		// (set) Token: 0x06020212 RID: 131602 RVA: 0x008CA742 File Offset: 0x008C8942
		public unsafe FVector2D VittualMousePos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x06020213 RID: 131603 RVA: 0x008CA757 File Offset: 0x008C8957
		// (set) Token: 0x06020214 RID: 131604 RVA: 0x008CA767 File Offset: 0x008C8967
		public unsafe bool MobilePlatform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x06020215 RID: 131605 RVA: 0x008CA778 File Offset: 0x008C8978
		// (set) Token: 0x06020216 RID: 131606 RVA: 0x008CA788 File Offset: 0x008C8988
		public unsafe float MobileSmoothLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002F1E RID: 12062
		// (get) Token: 0x06020217 RID: 131607 RVA: 0x008CA799 File Offset: 0x008C8999
		// (set) Token: 0x06020218 RID: 131608 RVA: 0x008CA7A9 File Offset: 0x008C89A9
		public unsafe float MobileOffsetFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002F1F RID: 12063
		// (get) Token: 0x06020219 RID: 131609 RVA: 0x008CA7BA File Offset: 0x008C89BA
		// (set) Token: 0x0602021A RID: 131610 RVA: 0x008CA7CE File Offset: 0x008C89CE
		public unsafe FRotator InitRotateRecord
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002F20 RID: 12064
		// (get) Token: 0x0602021B RID: 131611 RVA: 0x008CA7E3 File Offset: 0x008C89E3
		// (set) Token: 0x0602021C RID: 131612 RVA: 0x008CA7F7 File Offset: 0x008C89F7
		[Nullable(2)]
		public unsafe UUIItem UIItemCache
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIRotate_C.__PropertyOffset_9);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIRotate_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17002F21 RID: 12065
		// (get) Token: 0x0602021D RID: 131613 RVA: 0x008CA80C File Offset: 0x008C8A0C
		// (set) Token: 0x0602021E RID: 131614 RVA: 0x008CA81C File Offset: 0x008C8A1C
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F22 RID: 12066
		// (get) Token: 0x0602021F RID: 131615 RVA: 0x008CA82D File Offset: 0x008C8A2D
		// (set) Token: 0x06020220 RID: 131616 RVA: 0x008CA83D File Offset: 0x008C8A3D
		public unsafe bool EnableGamepad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIRotate_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020221 RID: 131617 RVA: 0x008CA850 File Offset: 0x008C8A50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetGamepadStickPos(ref FVector2D StickPos, ref bool Active)
		{
			BP_UIRotate_C.__GetGamepadStickPos_FunctionParams* ptr = stackalloc BP_UIRotate_C.__GetGamepadStickPos_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_UIRotate_C.__GetGamepadStickPos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIRotate_C.__GetGamepadStickPos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StickPos = StickPos;
			ptr->Active = Active;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIRotate_C.__GetGamepadStickPos_NativeFunctionPtr, (void*)ptr);
			StickPos = ptr->StickPos;
			Active = ptr->Active;
		}

		// Token: 0x06020222 RID: 131618 RVA: 0x008CA8B8 File Offset: 0x008C8AB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LrepVirtualMousePos(FVector2D NewPos, float DeltaSecond, ref FVector2D Output_Get)
		{
			BP_UIRotate_C.__LrepVirtualMousePos_FunctionParams* ptr = stackalloc BP_UIRotate_C.__LrepVirtualMousePos_FunctionParams[(UIntPtr)67] + 15L / (long)sizeof(BP_UIRotate_C.__LrepVirtualMousePos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIRotate_C.__LrepVirtualMousePos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewPos = NewPos;
			ptr->DeltaSecond = DeltaSecond;
			ptr->Output_Get = Output_Get;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIRotate_C.__LrepVirtualMousePos_NativeFunctionPtr, (void*)ptr);
			Output_Get = ptr->Output_Get;
		}

		// Token: 0x06020223 RID: 131619 RVA: 0x008CA91D File Offset: 0x008C8B1D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePlatform()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIRotate_C.__UpdatePlatform_NativeFunctionPtr, null);
		}

		// Token: 0x06020224 RID: 131620 RVA: 0x008CA934 File Offset: 0x008C8B34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetOffset(float DeltaSecond, ref FVector2D NewParam)
		{
			BP_UIRotate_C.__GetOffset_FunctionParams* ptr = stackalloc BP_UIRotate_C.__GetOffset_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_UIRotate_C.__GetOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIRotate_C.__GetOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSecond = DeltaSecond;
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIRotate_C.__GetOffset_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x06020225 RID: 131621 RVA: 0x008CA998 File Offset: 0x008C8B98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetMouseViewportPos(ref FVector2D NewParam)
		{
			BP_UIRotate_C.__GetMouseViewportPos_FunctionParams* ptr = stackalloc BP_UIRotate_C.__GetMouseViewportPos_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_UIRotate_C.__GetMouseViewportPos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIRotate_C.__GetMouseViewportPos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIRotate_C.__GetMouseViewportPos_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x06020226 RID: 131622 RVA: 0x008CA9F4 File Offset: 0x008C8BF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_UIRotate_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_UIRotate_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UIRotate_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIRotate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIRotate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020227 RID: 131623 RVA: 0x008CAA3C File Offset: 0x008C8C3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_UIRotate_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_UIRotate_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UIRotate_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIRotate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UIRotate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020228 RID: 131624 RVA: 0x008CAA83 File Offset: 0x008C8C83
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIRotate_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020229 RID: 131625 RVA: 0x008CAA97 File Offset: 0x008C8C97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UIRotate_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602022A RID: 131626 RVA: 0x008CAAAC File Offset: 0x008C8CAC
		protected BP_UIRotate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F853 RID: 63571
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/UI/ActorComponent/BP_UIRotate.BP_UIRotate_C";

		// Token: 0x0400F854 RID: 63572
		private static IntPtr _ClassPtr;

		// Token: 0x0400F855 RID: 63573
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F856 RID: 63574
		internal static int __PropertyOffset_1;

		// Token: 0x0400F857 RID: 63575
		internal static int __PropertyOffset_2;

		// Token: 0x0400F858 RID: 63576
		internal static int __PropertyOffset_3;

		// Token: 0x0400F859 RID: 63577
		internal static int __PropertyOffset_4;

		// Token: 0x0400F85A RID: 63578
		internal static int __PropertyOffset_5;

		// Token: 0x0400F85B RID: 63579
		internal static int __PropertyOffset_6;

		// Token: 0x0400F85C RID: 63580
		internal static int __PropertyOffset_7;

		// Token: 0x0400F85D RID: 63581
		internal static int __PropertyOffset_8;

		// Token: 0x0400F85E RID: 63582
		internal static int __PropertyOffset_9;

		// Token: 0x0400F85F RID: 63583
		internal static int __PropertyOffset_10;

		// Token: 0x0400F860 RID: 63584
		internal static int __PropertyOffset_11;

		// Token: 0x0400F861 RID: 63585
		private static IntPtr __GetGamepadStickPos_NativeFunctionPtr;

		// Token: 0x0400F862 RID: 63586
		private static IntPtr __LrepVirtualMousePos_NativeFunctionPtr;

		// Token: 0x0400F863 RID: 63587
		private static IntPtr __UpdatePlatform_NativeFunctionPtr;

		// Token: 0x0400F864 RID: 63588
		private static IntPtr __GetOffset_NativeFunctionPtr;

		// Token: 0x0400F865 RID: 63589
		private static IntPtr __GetMouseViewportPos_NativeFunctionPtr;

		// Token: 0x0400F866 RID: 63590
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F867 RID: 63591
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009B7C RID: 39804
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetGamepadStickPos_FunctionParams
		{
			// Token: 0x040311C3 RID: 201155
			[FieldOffset(0)]
			public FVector2D StickPos;

			// Token: 0x040311C4 RID: 201156
			[FieldOffset(8)]
			public bool Active;
		}

		// Token: 0x02009B7D RID: 39805
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		protected ref struct __LrepVirtualMousePos_FunctionParams
		{
			// Token: 0x040311C5 RID: 201157
			[FieldOffset(0)]
			public FVector2D NewPos;

			// Token: 0x040311C6 RID: 201158
			[FieldOffset(8)]
			public float DeltaSecond;

			// Token: 0x040311C7 RID: 201159
			[FieldOffset(12)]
			public FVector2D Output_Get;
		}

		// Token: 0x02009B7E RID: 39806
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __GetOffset_FunctionParams
		{
			// Token: 0x040311C8 RID: 201160
			[FieldOffset(0)]
			public float DeltaSecond;

			// Token: 0x040311C9 RID: 201161
			[FieldOffset(4)]
			public FVector2D NewParam;
		}

		// Token: 0x02009B7F RID: 39807
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __GetMouseViewportPos_FunctionParams
		{
			// Token: 0x040311CA RID: 201162
			[FieldOffset(0)]
			public FVector2D NewParam;
		}

		// Token: 0x02009B80 RID: 39808
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311CB RID: 201163
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
