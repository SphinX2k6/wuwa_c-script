using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B40 RID: 15168
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_InteractionGroup.BP_InteractionGroup_C")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class BP_InteractionGroup_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218CE RID: 137422 RVA: 0x008EF47B File Offset: 0x008ED67B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InteractionGroup_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_InteractionGroup.BP_InteractionGroup_C");
			}
			return BP_InteractionGroup_C._ClassPtr;
		}

		// Token: 0x060218CF RID: 137423 RVA: 0x008EF4A0 File Offset: 0x008ED6A0
		public BP_InteractionGroup_C() : this(BuiltinUtils.AllocNativeUObject(BP_InteractionGroup_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218D0 RID: 137424 RVA: 0x008EF4C8 File Offset: 0x008ED6C8
		public BP_InteractionGroup_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InteractionGroup_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x060218D1 RID: 137425 RVA: 0x008EF4FB File Offset: 0x008ED6FB
		// (set) Token: 0x060218D2 RID: 137426 RVA: 0x008EF50F File Offset: 0x008ED70F
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionGroup_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionGroup_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700372B RID: 14123
		// (get) Token: 0x060218D3 RID: 137427 RVA: 0x008EF524 File Offset: 0x008ED724
		// (set) Token: 0x060218D4 RID: 137428 RVA: 0x008EF534 File Offset: 0x008ED734
		public unsafe float Float
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionGroup_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionGroup_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700372C RID: 14124
		// (get) Token: 0x060218D5 RID: 137429 RVA: 0x008EF545 File Offset: 0x008ED745
		// (set) Token: 0x060218D6 RID: 137430 RVA: 0x008EF559 File Offset: 0x008ED759
		public unsafe string ScalarName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_InteractionGroup_C.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_InteractionGroup_C.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x060218D7 RID: 137431 RVA: 0x008EF570 File Offset: 0x008ED770
		// (set) Token: 0x060218D8 RID: 137432 RVA: 0x008EF5A9 File Offset: 0x008ED7A9
		public TArray<AActor> Actor
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Actor) == null)
				{
					result = (this._Actor = new TArray<AActor>(base.NativePtr + (IntPtr)BP_InteractionGroup_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.Actor.CopyAssign(value);
			}
		}

		// Token: 0x1700372E RID: 14126
		// (get) Token: 0x060218D9 RID: 137433 RVA: 0x008EF5B7 File Offset: 0x008ED7B7
		// (set) Token: 0x060218DA RID: 137434 RVA: 0x008EF5CB File Offset: 0x008ED7CB
		public unsafe string VectorName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_InteractionGroup_C.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_InteractionGroup_C.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x1700372F RID: 14127
		// (get) Token: 0x060218DB RID: 137435 RVA: 0x008EF5E0 File Offset: 0x008ED7E0
		// (set) Token: 0x060218DC RID: 137436 RVA: 0x008EF5F4 File Offset: 0x008ED7F4
		public unsafe FLinearColor Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionGroup_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionGroup_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x060218DD RID: 137437 RVA: 0x008EF609 File Offset: 0x008ED809
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionGroup_C.__DisableTick_NativeFunctionPtr, null);
		}

		// Token: 0x060218DE RID: 137438 RVA: 0x008EF61D File Offset: 0x008ED81D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EnableTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionGroup_C.__EnableTick_NativeFunctionPtr, null);
		}

		// Token: 0x060218DF RID: 137439 RVA: 0x008EF634 File Offset: 0x008ED834
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ChangeVectorParameter(FLinearColor VectorParameter, string VectorParameterName)
		{
			BP_InteractionGroup_C.__ChangeVectorParameter_FunctionParams* ptr = stackalloc BP_InteractionGroup_C.__ChangeVectorParameter_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_InteractionGroup_C.__ChangeVectorParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractionGroup_C.__ChangeVectorParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->VectorParameter = VectorParameter;
			FString.CopyFrom((void*)(&ptr->VectorParameterName), VectorParameterName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionGroup_C.__ChangeVectorParameter_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_InteractionGroup_C.__ChangeVectorParameter_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060218E0 RID: 137440 RVA: 0x008EF698 File Offset: 0x008ED898
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ChangeScalarParameter(float FloatParameter, string FloatParameterName)
		{
			BP_InteractionGroup_C.__ChangeScalarParameter_FunctionParams* ptr = stackalloc BP_InteractionGroup_C.__ChangeScalarParameter_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_InteractionGroup_C.__ChangeScalarParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractionGroup_C.__ChangeScalarParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FloatParameter = FloatParameter;
			FString.CopyFrom((void*)(&ptr->FloatParameterName), FloatParameterName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionGroup_C.__ChangeScalarParameter_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_InteractionGroup_C.__ChangeScalarParameter_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060218E1 RID: 137441 RVA: 0x008EF6FF File Offset: 0x008ED8FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ForEach()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionGroup_C.__ForEach_NativeFunctionPtr, null);
		}

		// Token: 0x060218E2 RID: 137442 RVA: 0x008EF713 File Offset: 0x008ED913
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Test()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionGroup_C.__Test_NativeFunctionPtr, null);
		}

		// Token: 0x060218E3 RID: 137443 RVA: 0x008EF727 File Offset: 0x008ED927
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionGroup_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060218E4 RID: 137444 RVA: 0x008EF73B File Offset: 0x008ED93B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractionGroup_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060218E5 RID: 137445 RVA: 0x008EF750 File Offset: 0x008ED950
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_InteractionGroup_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InteractionGroup_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractionGroup_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractionGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060218E6 RID: 137446 RVA: 0x008EF798 File Offset: 0x008ED998
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_InteractionGroup_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InteractionGroup_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractionGroup_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractionGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractionGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060218E7 RID: 137447 RVA: 0x008EF7DF File Offset: 0x008ED9DF
		protected BP_InteractionGroup_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040105A7 RID: 66983
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_InteractionGroup.BP_InteractionGroup_C";

		// Token: 0x040105A8 RID: 66984
		private static IntPtr _ClassPtr;

		// Token: 0x040105A9 RID: 66985
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040105AA RID: 66986
		internal static int __PropertyOffset_1;

		// Token: 0x040105AB RID: 66987
		internal static int __PropertyOffset_2;

		// Token: 0x040105AC RID: 66988
		internal static int __PropertyOffset_3;

		// Token: 0x040105AD RID: 66989
		internal static int __PropertyOffset_4;

		// Token: 0x040105AE RID: 66990
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Actor;

		// Token: 0x040105AF RID: 66991
		internal static int __PropertyOffset_5;

		// Token: 0x040105B0 RID: 66992
		internal static int __PropertyOffset_6;

		// Token: 0x040105B1 RID: 66993
		private static IntPtr __DisableTick_NativeFunctionPtr;

		// Token: 0x040105B2 RID: 66994
		private static IntPtr __EnableTick_NativeFunctionPtr;

		// Token: 0x040105B3 RID: 66995
		private static IntPtr __ChangeVectorParameter_NativeFunctionPtr;

		// Token: 0x040105B4 RID: 66996
		private static IntPtr __ChangeScalarParameter_NativeFunctionPtr;

		// Token: 0x040105B5 RID: 66997
		private static IntPtr __ForEach_NativeFunctionPtr;

		// Token: 0x040105B6 RID: 66998
		private static IntPtr __Test_NativeFunctionPtr;

		// Token: 0x040105B7 RID: 66999
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040105B8 RID: 67000
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009CA6 RID: 40102
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __ChangeVectorParameter_FunctionParams
		{
			// Token: 0x0403136F RID: 201583
			[FieldOffset(0)]
			public FLinearColor VectorParameter;

			// Token: 0x04031370 RID: 201584
			[FieldOffset(16)]
			public FString VectorParameterName;
		}

		// Token: 0x02009CA7 RID: 40103
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __ChangeScalarParameter_FunctionParams
		{
			// Token: 0x04031371 RID: 201585
			[FieldOffset(0)]
			public float FloatParameter;

			// Token: 0x04031372 RID: 201586
			[FieldOffset(8)]
			public FString FloatParameterName;
		}

		// Token: 0x02009CA8 RID: 40104
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031373 RID: 201587
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
