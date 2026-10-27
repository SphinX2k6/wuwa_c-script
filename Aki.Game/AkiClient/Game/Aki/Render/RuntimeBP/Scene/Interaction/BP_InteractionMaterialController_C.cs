using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B41 RID: 15169
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_InteractionMaterialController.BP_InteractionMaterialController_C")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class BP_InteractionMaterialController_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218E8 RID: 137448 RVA: 0x008EF7E8 File Offset: 0x008ED9E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InteractionMaterialController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_InteractionMaterialController.BP_InteractionMaterialController_C");
			}
			return BP_InteractionMaterialController_C._ClassPtr;
		}

		// Token: 0x060218E9 RID: 137449 RVA: 0x008EF80C File Offset: 0x008EDA0C
		public BP_InteractionMaterialController_C() : this(BuiltinUtils.AllocNativeUObject(BP_InteractionMaterialController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218EA RID: 137450 RVA: 0x008EF834 File Offset: 0x008EDA34
		public BP_InteractionMaterialController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InteractionMaterialController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x060218EB RID: 137451 RVA: 0x008EF867 File Offset: 0x008EDA67
		// (set) Token: 0x060218EC RID: 137452 RVA: 0x008EF87B File Offset: 0x008EDA7B
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionMaterialController_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionMaterialController_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x060218ED RID: 137453 RVA: 0x008EF890 File Offset: 0x008EDA90
		// (set) Token: 0x060218EE RID: 137454 RVA: 0x008EF8A0 File Offset: 0x008EDAA0
		public unsafe float Float
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x060218EF RID: 137455 RVA: 0x008EF8B1 File Offset: 0x008EDAB1
		// (set) Token: 0x060218F0 RID: 137456 RVA: 0x008EF8C5 File Offset: 0x008EDAC5
		public unsafe string ScalarName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x060218F1 RID: 137457 RVA: 0x008EF8DC File Offset: 0x008EDADC
		// (set) Token: 0x060218F2 RID: 137458 RVA: 0x008EF915 File Offset: 0x008EDB15
		public TArray<AActor> Actor
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Actor) == null)
				{
					result = (this._Actor = new TArray<AActor>(base.NativePtr + (IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.Actor.CopyAssign(value);
			}
		}

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x060218F3 RID: 137459 RVA: 0x008EF923 File Offset: 0x008EDB23
		// (set) Token: 0x060218F4 RID: 137460 RVA: 0x008EF937 File Offset: 0x008EDB37
		public unsafe string VectorName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x060218F5 RID: 137461 RVA: 0x008EF94C File Offset: 0x008EDB4C
		// (set) Token: 0x060218F6 RID: 137462 RVA: 0x008EF960 File Offset: 0x008EDB60
		public unsafe FLinearColor Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x060218F7 RID: 137463 RVA: 0x008EF978 File Offset: 0x008EDB78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ChangeVectorParameter(FLinearColor VectorParameter, string VectorParameterName)
		{
			BP_InteractionMaterialController_C.__ChangeVectorParameter_FunctionParams* ptr = stackalloc BP_InteractionMaterialController_C.__ChangeVectorParameter_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_InteractionMaterialController_C.__ChangeVectorParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractionMaterialController_C.__ChangeVectorParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->VectorParameter = VectorParameter;
			FString.CopyFrom((void*)(&ptr->VectorParameterName), VectorParameterName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionMaterialController_C.__ChangeVectorParameter_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_InteractionMaterialController_C.__ChangeVectorParameter_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060218F8 RID: 137464 RVA: 0x008EF9DC File Offset: 0x008EDBDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ChangeScalarParameter(float FloatParameter, string FloatParameterName)
		{
			BP_InteractionMaterialController_C.__ChangeScalarParameter_FunctionParams* ptr = stackalloc BP_InteractionMaterialController_C.__ChangeScalarParameter_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_InteractionMaterialController_C.__ChangeScalarParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractionMaterialController_C.__ChangeScalarParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FloatParameter = FloatParameter;
			FString.CopyFrom((void*)(&ptr->FloatParameterName), FloatParameterName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionMaterialController_C.__ChangeScalarParameter_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_InteractionMaterialController_C.__ChangeScalarParameter_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060218F9 RID: 137465 RVA: 0x008EFA40 File Offset: 0x008EDC40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ForEach()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionMaterialController_C.__ForEach_NativeFunctionPtr, null);
		}

		// Token: 0x060218FA RID: 137466 RVA: 0x008EFA54 File Offset: 0x008EDC54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Test()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionMaterialController_C.__Test_NativeFunctionPtr, null);
		}

		// Token: 0x060218FB RID: 137467 RVA: 0x008EFA68 File Offset: 0x008EDC68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionMaterialController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060218FC RID: 137468 RVA: 0x008EFA7C File Offset: 0x008EDC7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractionMaterialController_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060218FD RID: 137469 RVA: 0x008EFA91 File Offset: 0x008EDC91
		protected BP_InteractionMaterialController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040105B9 RID: 67001
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_InteractionMaterialController.BP_InteractionMaterialController_C";

		// Token: 0x040105BA RID: 67002
		private static IntPtr _ClassPtr;

		// Token: 0x040105BB RID: 67003
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040105BC RID: 67004
		internal static int __PropertyOffset_1;

		// Token: 0x040105BD RID: 67005
		internal static int __PropertyOffset_2;

		// Token: 0x040105BE RID: 67006
		internal static int __PropertyOffset_3;

		// Token: 0x040105BF RID: 67007
		internal static int __PropertyOffset_4;

		// Token: 0x040105C0 RID: 67008
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Actor;

		// Token: 0x040105C1 RID: 67009
		internal static int __PropertyOffset_5;

		// Token: 0x040105C2 RID: 67010
		internal static int __PropertyOffset_6;

		// Token: 0x040105C3 RID: 67011
		private static IntPtr __ChangeVectorParameter_NativeFunctionPtr;

		// Token: 0x040105C4 RID: 67012
		private static IntPtr __ChangeScalarParameter_NativeFunctionPtr;

		// Token: 0x040105C5 RID: 67013
		private static IntPtr __ForEach_NativeFunctionPtr;

		// Token: 0x040105C6 RID: 67014
		private static IntPtr __Test_NativeFunctionPtr;

		// Token: 0x040105C7 RID: 67015
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009CA9 RID: 40105
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __ChangeVectorParameter_FunctionParams
		{
			// Token: 0x04031374 RID: 201588
			[FieldOffset(0)]
			public FLinearColor VectorParameter;

			// Token: 0x04031375 RID: 201589
			[FieldOffset(16)]
			public FString VectorParameterName;
		}

		// Token: 0x02009CAA RID: 40106
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __ChangeScalarParameter_FunctionParams
		{
			// Token: 0x04031376 RID: 201590
			[FieldOffset(0)]
			public float FloatParameter;

			// Token: 0x04031377 RID: 201591
			[FieldOffset(8)]
			public FString FloatParameterName;
		}
	}
}
