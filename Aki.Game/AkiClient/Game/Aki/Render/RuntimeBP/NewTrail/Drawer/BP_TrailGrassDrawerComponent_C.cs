using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.NewTrail.Drawer
{
	// Token: 0x02003CEA RID: 15594
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/NewTrail/Drawer/BP_TrailGrassDrawerComponent.BP_TrailGrassDrawerComponent_C")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class BP_TrailGrassDrawerComponent_C : UKuroTrailDrawerComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025211 RID: 152081 RVA: 0x00951DEF File Offset: 0x0094FFEF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrailGrassDrawerComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/NewTrail/Drawer/BP_TrailGrassDrawerComponent.BP_TrailGrassDrawerComponent_C");
			}
			return BP_TrailGrassDrawerComponent_C._ClassPtr;
		}

		// Token: 0x06025212 RID: 152082 RVA: 0x00951E14 File Offset: 0x00950014
		public BP_TrailGrassDrawerComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrailGrassDrawerComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025213 RID: 152083 RVA: 0x00951E3C File Offset: 0x0095003C
		[NullableContext(1)]
		public BP_TrailGrassDrawerComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrailGrassDrawerComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025214 RID: 152084 RVA: 0x00951E6F File Offset: 0x0095006F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnDrawerBegin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailGrassDrawerComponent_C.__OnDrawerBegin_NativeFunctionPtr, null);
		}

		// Token: 0x06025215 RID: 152085 RVA: 0x00951E84 File Offset: 0x00950084
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnDrawerEnd(EEndPlayReason EndPlayReason)
		{
			BP_TrailGrassDrawerComponent_C.__OnDrawerEnd_FunctionParams* ptr = stackalloc BP_TrailGrassDrawerComponent_C.__OnDrawerEnd_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_TrailGrassDrawerComponent_C.__OnDrawerEnd_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailGrassDrawerComponent_C.__OnDrawerEnd_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailGrassDrawerComponent_C.__OnDrawerEnd_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025216 RID: 152086 RVA: 0x00951ED0 File Offset: 0x009500D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnDrawerTick(float DeltaTime)
		{
			BP_TrailGrassDrawerComponent_C.__OnDrawerTick_FunctionParams* ptr = stackalloc BP_TrailGrassDrawerComponent_C.__OnDrawerTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailGrassDrawerComponent_C.__OnDrawerTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailGrassDrawerComponent_C.__OnDrawerTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailGrassDrawerComponent_C.__OnDrawerTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025217 RID: 152087 RVA: 0x00951F16 File Offset: 0x00950116
		protected BP_TrailGrassDrawerComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040127C8 RID: 75720
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/NewTrail/Drawer/BP_TrailGrassDrawerComponent.BP_TrailGrassDrawerComponent_C";

		// Token: 0x040127C9 RID: 75721
		private static IntPtr _ClassPtr;

		// Token: 0x040127CA RID: 75722
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040127CB RID: 75723
		private static IntPtr __OnDrawerBegin_NativeFunctionPtr;

		// Token: 0x040127CC RID: 75724
		private static IntPtr __OnDrawerEnd_NativeFunctionPtr;

		// Token: 0x040127CD RID: 75725
		private static IntPtr __OnDrawerTick_NativeFunctionPtr;

		// Token: 0x02009FB5 RID: 40885
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnDrawerEnd_FunctionParams
		{
			// Token: 0x04031A15 RID: 203285
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009FB6 RID: 40886
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnDrawerTick_FunctionParams
		{
			// Token: 0x04031A16 RID: 203286
			[FieldOffset(0)]
			public float DeltaTime;
		}
	}
}
