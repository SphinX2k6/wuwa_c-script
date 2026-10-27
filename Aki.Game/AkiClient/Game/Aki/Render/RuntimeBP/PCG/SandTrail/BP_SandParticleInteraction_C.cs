using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SandTrail
{
	// Token: 0x02003C21 RID: 15393
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SandTrail/BP_SandParticleInteraction.BP_SandParticleInteraction_C")]
	[UnrealStructLayout(1472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1472)]
	public class BP_SandParticleInteraction_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023498 RID: 144536 RVA: 0x0091FE29 File Offset: 0x0091E029
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SandParticleInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SandTrail/BP_SandParticleInteraction.BP_SandParticleInteraction_C");
			}
			return BP_SandParticleInteraction_C._ClassPtr;
		}

		// Token: 0x06023499 RID: 144537 RVA: 0x0091FE50 File Offset: 0x0091E050
		public BP_SandParticleInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_SandParticleInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602349A RID: 144538 RVA: 0x0091FE78 File Offset: 0x0091E078
		[NullableContext(1)]
		public BP_SandParticleInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SandParticleInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004081 RID: 16513
		// (get) Token: 0x0602349B RID: 144539 RVA: 0x0091FEAB File Offset: 0x0091E0AB
		// (set) Token: 0x0602349C RID: 144540 RVA: 0x0091FEBF File Offset: 0x0091E0BF
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SandParticleInteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SandParticleInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004082 RID: 16514
		// (get) Token: 0x0602349D RID: 144541 RVA: 0x0091FED4 File Offset: 0x0091E0D4
		// (set) Token: 0x0602349E RID: 144542 RVA: 0x0091FEE8 File Offset: 0x0091E0E8
		public unsafe UNiagaraComponent NS_InputForFluidSimu
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SandParticleInteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SandParticleInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004083 RID: 16515
		// (get) Token: 0x0602349F RID: 144543 RVA: 0x0091FEFD File Offset: 0x0091E0FD
		// (set) Token: 0x060234A0 RID: 144544 RVA: 0x0091FF11 File Offset: 0x0091E111
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SandParticleInteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SandParticleInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x060234A1 RID: 144545 RVA: 0x0091FF28 File Offset: 0x0091E128
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SandParticleInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SandParticleInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SandParticleInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SandParticleInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SandParticleInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060234A2 RID: 144546 RVA: 0x0091FF70 File Offset: 0x0091E170
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SandParticleInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SandParticleInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SandParticleInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SandParticleInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SandParticleInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060234A3 RID: 144547 RVA: 0x0091FFB7 File Offset: 0x0091E1B7
		protected BP_SandParticleInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011676 RID: 71286
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SandTrail/BP_SandParticleInteraction.BP_SandParticleInteraction_C";

		// Token: 0x04011677 RID: 71287
		private static IntPtr _ClassPtr;

		// Token: 0x04011678 RID: 71288
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011679 RID: 71289
		internal static int __PropertyOffset_1;

		// Token: 0x0401167A RID: 71290
		internal static int __PropertyOffset_2;

		// Token: 0x0401167B RID: 71291
		internal static int __PropertyOffset_3;

		// Token: 0x0401167C RID: 71292
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009E4D RID: 40525
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316BF RID: 202431
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
