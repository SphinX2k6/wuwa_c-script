using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.BirdInteraction
{
	// Token: 0x02003CD0 RID: 15568
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/BirdInteraction/BP_BirdInteractionManager.BP_BirdInteractionManager_C")]
	[UnrealStructLayout(2152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2148)]
	public class BP_BirdInteractionManager_C : AKuroBirdInteractionManager, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024E7F RID: 151167 RVA: 0x0094BA86 File Offset: 0x00949C86
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BirdInteractionManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/BirdInteraction/BP_BirdInteractionManager.BP_BirdInteractionManager_C");
			}
			return BP_BirdInteractionManager_C._ClassPtr;
		}

		// Token: 0x06024E80 RID: 151168 RVA: 0x0094BAAC File Offset: 0x00949CAC
		public BP_BirdInteractionManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_BirdInteractionManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024E81 RID: 151169 RVA: 0x0094BAD4 File Offset: 0x00949CD4
		[NullableContext(1)]
		public BP_BirdInteractionManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BirdInteractionManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170049C9 RID: 18889
		// (get) Token: 0x06024E82 RID: 151170 RVA: 0x0094BB07 File Offset: 0x00949D07
		// (set) Token: 0x06024E83 RID: 151171 RVA: 0x0094BB1B File Offset: 0x00949D1B
		public unsafe UBoxComponent Box1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BirdInteractionManager_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BirdInteractionManager_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170049CA RID: 18890
		// (get) Token: 0x06024E84 RID: 151172 RVA: 0x0094BB30 File Offset: 0x00949D30
		// (set) Token: 0x06024E85 RID: 151173 RVA: 0x0094BB44 File Offset: 0x00949D44
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BirdInteractionManager_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BirdInteractionManager_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170049CB RID: 18891
		// (get) Token: 0x06024E86 RID: 151174 RVA: 0x0094BB59 File Offset: 0x00949D59
		// (set) Token: 0x06024E87 RID: 151175 RVA: 0x0094BB69 File Offset: 0x00949D69
		public unsafe int BirdCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BirdInteractionManager_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BirdInteractionManager_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170049CC RID: 18892
		// (get) Token: 0x06024E88 RID: 151176 RVA: 0x0094BB7C File Offset: 0x00949D7C
		// (set) Token: 0x06024E89 RID: 151177 RVA: 0x0094BBB5 File Offset: 0x00949DB5
		[Nullable(1)]
		public TArray<FTransform> BirdTransforms
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._BirdTransforms) == null)
				{
					result = (this._BirdTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)BP_BirdInteractionManager_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BirdTransforms.CopyAssign(value);
			}
		}

		// Token: 0x170049CD RID: 18893
		// (get) Token: 0x06024E8A RID: 151178 RVA: 0x0094BBC3 File Offset: 0x00949DC3
		// (set) Token: 0x06024E8B RID: 151179 RVA: 0x0094BBD7 File Offset: 0x00949DD7
		public unsafe FVector LandingBoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BirdInteractionManager_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BirdInteractionManager_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x06024E8C RID: 151180 RVA: 0x0094BBEC File Offset: 0x00949DEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWorldOffset(FVector Offset)
		{
			BP_BirdInteractionManager_C.__OnWorldOffset_FunctionParams* ptr = stackalloc BP_BirdInteractionManager_C.__OnWorldOffset_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_BirdInteractionManager_C.__OnWorldOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BirdInteractionManager_C.__OnWorldOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BirdInteractionManager_C.__OnWorldOffset_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024E8D RID: 151181 RVA: 0x0094BC35 File Offset: 0x00949E35
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetBirdTransforms()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BirdInteractionManager_C.__SetBirdTransforms_NativeFunctionPtr, null);
		}

		// Token: 0x06024E8E RID: 151182 RVA: 0x0094BC49 File Offset: 0x00949E49
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BirdInteractionManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024E8F RID: 151183 RVA: 0x0094BC5D File Offset: 0x00949E5D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BirdInteractionManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024E90 RID: 151184 RVA: 0x0094BC74 File Offset: 0x00949E74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnApplyWorldOffset(in FVector InWorldOffset, bool bWorldShift)
		{
			BP_BirdInteractionManager_C.__OnApplyWorldOffset_FunctionParams* ptr = stackalloc BP_BirdInteractionManager_C.__OnApplyWorldOffset_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_BirdInteractionManager_C.__OnApplyWorldOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BirdInteractionManager_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InWorldOffset = InWorldOffset;
			ptr->bWorldShift = bWorldShift;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BirdInteractionManager_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024E91 RID: 151185 RVA: 0x0094BCC8 File Offset: 0x00949EC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnApplyWorldOffset_Implementation(in FVector InWorldOffset, bool bWorldShift)
		{
			BP_BirdInteractionManager_C.__OnApplyWorldOffset_FunctionParams* ptr = stackalloc BP_BirdInteractionManager_C.__OnApplyWorldOffset_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_BirdInteractionManager_C.__OnApplyWorldOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BirdInteractionManager_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InWorldOffset = InWorldOffset;
			ptr->bWorldShift = bWorldShift;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BirdInteractionManager_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024E92 RID: 151186 RVA: 0x0094BD1B File Offset: 0x00949F1B
		protected BP_BirdInteractionManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012595 RID: 75157
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/BirdInteraction/BP_BirdInteractionManager.BP_BirdInteractionManager_C";

		// Token: 0x04012596 RID: 75158
		private static IntPtr _ClassPtr;

		// Token: 0x04012597 RID: 75159
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012598 RID: 75160
		internal static int __PropertyOffset_1;

		// Token: 0x04012599 RID: 75161
		internal static int __PropertyOffset_2;

		// Token: 0x0401259A RID: 75162
		internal static int __PropertyOffset_3;

		// Token: 0x0401259B RID: 75163
		internal static int __PropertyOffset_4;

		// Token: 0x0401259C RID: 75164
		private TArray<FTransform> _BirdTransforms;

		// Token: 0x0401259D RID: 75165
		internal static int __PropertyOffset_5;

		// Token: 0x0401259E RID: 75166
		private static IntPtr __OnWorldOffset_NativeFunctionPtr;

		// Token: 0x0401259F RID: 75167
		private static IntPtr __SetBirdTransforms_NativeFunctionPtr;

		// Token: 0x040125A0 RID: 75168
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040125A1 RID: 75169
		private static IntPtr __OnApplyWorldOffset_NativeFunctionPtr;

		// Token: 0x02009F88 RID: 40840
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __OnWorldOffset_FunctionParams
		{
			// Token: 0x040319A9 RID: 203177
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02009F89 RID: 40841
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected new ref struct __OnApplyWorldOffset_FunctionParams
		{
			// Token: 0x040319AA RID: 203178
			[FieldOffset(0)]
			public FVector InWorldOffset;

			// Token: 0x040319AB RID: 203179
			[FieldOffset(12)]
			public bool bWorldShift;
		}
	}
}
