using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Ice
{
	// Token: 0x02003C9D RID: 15517
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Ice/BP_Ice_Floeberg.BP_Ice_Floeberg_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class BP_Ice_Floeberg_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024631 RID: 149041 RVA: 0x0093D2DE File Offset: 0x0093B4DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Ice_Floeberg_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Ice/BP_Ice_Floeberg.BP_Ice_Floeberg_C");
			}
			return BP_Ice_Floeberg_C._ClassPtr;
		}

		// Token: 0x06024632 RID: 149042 RVA: 0x0093D304 File Offset: 0x0093B504
		public BP_Ice_Floeberg_C() : this(BuiltinUtils.AllocNativeUObject(BP_Ice_Floeberg_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024633 RID: 149043 RVA: 0x0093D32C File Offset: 0x0093B52C
		[NullableContext(1)]
		public BP_Ice_Floeberg_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Ice_Floeberg_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170046C7 RID: 18119
		// (get) Token: 0x06024634 RID: 149044 RVA: 0x0093D35F File Offset: 0x0093B55F
		// (set) Token: 0x06024635 RID: 149045 RVA: 0x0093D373 File Offset: 0x0093B573
		public unsafe UStaticMeshComponent IceMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Ice_Floeberg_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Ice_Floeberg_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170046C8 RID: 18120
		// (get) Token: 0x06024636 RID: 149046 RVA: 0x0093D388 File Offset: 0x0093B588
		// (set) Token: 0x06024637 RID: 149047 RVA: 0x0093D39C File Offset: 0x0093B59C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Ice_Floeberg_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Ice_Floeberg_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170046C9 RID: 18121
		// (get) Token: 0x06024638 RID: 149048 RVA: 0x0093D3B1 File Offset: 0x0093B5B1
		// (set) Token: 0x06024639 RID: 149049 RVA: 0x0093D3C1 File Offset: 0x0093B5C1
		public unsafe float Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ice_Floeberg_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ice_Floeberg_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170046CA RID: 18122
		// (get) Token: 0x0602463A RID: 149050 RVA: 0x0093D3D2 File Offset: 0x0093B5D2
		// (set) Token: 0x0602463B RID: 149051 RVA: 0x0093D3E6 File Offset: 0x0093B5E6
		public unsafe FVectorDouble ActorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ice_Floeberg_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ice_Floeberg_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170046CB RID: 18123
		// (get) Token: 0x0602463C RID: 149052 RVA: 0x0093D3FB File Offset: 0x0093B5FB
		// (set) Token: 0x0602463D RID: 149053 RVA: 0x0093D40B File Offset: 0x0093B60B
		public unsafe double ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ice_Floeberg_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ice_Floeberg_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170046CC RID: 18124
		// (get) Token: 0x0602463E RID: 149054 RVA: 0x0093D41C File Offset: 0x0093B61C
		// (set) Token: 0x0602463F RID: 149055 RVA: 0x0093D42C File Offset: 0x0093B62C
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ice_Floeberg_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ice_Floeberg_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170046CD RID: 18125
		// (get) Token: 0x06024640 RID: 149056 RVA: 0x0093D43D File Offset: 0x0093B63D
		// (set) Token: 0x06024641 RID: 149057 RVA: 0x0093D44D File Offset: 0x0093B64D
		public unsafe float X_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ice_Floeberg_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ice_Floeberg_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170046CE RID: 18126
		// (get) Token: 0x06024642 RID: 149058 RVA: 0x0093D45E File Offset: 0x0093B65E
		// (set) Token: 0x06024643 RID: 149059 RVA: 0x0093D46E File Offset: 0x0093B66E
		public unsafe float Y_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ice_Floeberg_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ice_Floeberg_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170046CF RID: 18127
		// (get) Token: 0x06024644 RID: 149060 RVA: 0x0093D47F File Offset: 0x0093B67F
		// (set) Token: 0x06024645 RID: 149061 RVA: 0x0093D48F File Offset: 0x0093B68F
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Ice_Floeberg_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Ice_Floeberg_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x06024646 RID: 149062 RVA: 0x0093D4A0 File Offset: 0x0093B6A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void WaterWave(float ID, float T, ref float H)
		{
			BP_Ice_Floeberg_C.__WaterWave_FunctionParams* ptr = stackalloc BP_Ice_Floeberg_C.__WaterWave_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(BP_Ice_Floeberg_C.__WaterWave_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Ice_Floeberg_C.__WaterWave_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ID = ID;
			ptr->T = T;
			ptr->H = H;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Ice_Floeberg_C.__WaterWave_NativeFunctionPtr, (void*)ptr);
			H = ptr->H;
		}

		// Token: 0x06024647 RID: 149063 RVA: 0x0093D4FD File Offset: 0x0093B6FD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Ice_Floeberg_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024648 RID: 149064 RVA: 0x0093D511 File Offset: 0x0093B711
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Ice_Floeberg_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024649 RID: 149065 RVA: 0x0093D528 File Offset: 0x0093B728
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Ice_Floeberg_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Ice_Floeberg_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Ice_Floeberg_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Ice_Floeberg_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Ice_Floeberg_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602464A RID: 149066 RVA: 0x0093D570 File Offset: 0x0093B770
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Ice_Floeberg_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Ice_Floeberg_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Ice_Floeberg_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Ice_Floeberg_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Ice_Floeberg_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602464B RID: 149067 RVA: 0x0093D5B7 File Offset: 0x0093B7B7
		protected BP_Ice_Floeberg_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040120D4 RID: 73940
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Ice/BP_Ice_Floeberg.BP_Ice_Floeberg_C";

		// Token: 0x040120D5 RID: 73941
		private static IntPtr _ClassPtr;

		// Token: 0x040120D6 RID: 73942
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040120D7 RID: 73943
		internal static int __PropertyOffset_1;

		// Token: 0x040120D8 RID: 73944
		internal static int __PropertyOffset_2;

		// Token: 0x040120D9 RID: 73945
		internal static int __PropertyOffset_3;

		// Token: 0x040120DA RID: 73946
		internal static int __PropertyOffset_4;

		// Token: 0x040120DB RID: 73947
		internal static int __PropertyOffset_5;

		// Token: 0x040120DC RID: 73948
		internal static int __PropertyOffset_6;

		// Token: 0x040120DD RID: 73949
		internal static int __PropertyOffset_7;

		// Token: 0x040120DE RID: 73950
		internal static int __PropertyOffset_8;

		// Token: 0x040120DF RID: 73951
		internal static int __PropertyOffset_9;

		// Token: 0x040120E0 RID: 73952
		private static IntPtr __WaterWave_NativeFunctionPtr;

		// Token: 0x040120E1 RID: 73953
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040120E2 RID: 73954
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009F10 RID: 40720
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __WaterWave_FunctionParams
		{
			// Token: 0x04031862 RID: 202850
			[FieldOffset(0)]
			public float ID;

			// Token: 0x04031863 RID: 202851
			[FieldOffset(4)]
			public float T;

			// Token: 0x04031864 RID: 202852
			[FieldOffset(8)]
			public float H;
		}

		// Token: 0x02009F11 RID: 40721
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031865 RID: 202853
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
