using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.BP
{
	// Token: 0x02003AB7 RID: 15031
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/BP/BP_TrailSystem.BP_TrailSystem_C")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1588)]
	public class BP_TrailSystem_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060203BC RID: 132028 RVA: 0x008CD55F File Offset: 0x008CB75F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrailSystem_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/BP/BP_TrailSystem.BP_TrailSystem_C");
			}
			return BP_TrailSystem_C._ClassPtr;
		}

		// Token: 0x060203BD RID: 132029 RVA: 0x008CD584 File Offset: 0x008CB784
		public BP_TrailSystem_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrailSystem_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060203BE RID: 132030 RVA: 0x008CD5AC File Offset: 0x008CB7AC
		[NullableContext(1)]
		public BP_TrailSystem_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrailSystem_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x060203BF RID: 132031 RVA: 0x008CD5DF File Offset: 0x008CB7DF
		// (set) Token: 0x060203C0 RID: 132032 RVA: 0x008CD5F3 File Offset: 0x008CB7F3
		public unsafe UNiagaraComponent NS_SnowTrail
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSystem_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSystem_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x060203C1 RID: 132033 RVA: 0x008CD608 File Offset: 0x008CB808
		// (set) Token: 0x060203C2 RID: 132034 RVA: 0x008CD61C File Offset: 0x008CB81C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSystem_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSystem_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x060203C3 RID: 132035 RVA: 0x008CD631 File Offset: 0x008CB831
		// (set) Token: 0x060203C4 RID: 132036 RVA: 0x008CD645 File Offset: 0x008CB845
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSystem_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSystem_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002FA5 RID: 12197
		// (get) Token: 0x060203C5 RID: 132037 RVA: 0x008CD65A File Offset: 0x008CB85A
		// (set) Token: 0x060203C6 RID: 132038 RVA: 0x008CD66A File Offset: 0x008CB86A
		public unsafe float Threshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSystem_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSystem_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002FA6 RID: 12198
		// (get) Token: 0x060203C7 RID: 132039 RVA: 0x008CD67B File Offset: 0x008CB87B
		// (set) Token: 0x060203C8 RID: 132040 RVA: 0x008CD68F File Offset: 0x008CB88F
		public unsafe FVectorDouble PrezCharacterPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSystem_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSystem_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002FA7 RID: 12199
		// (get) Token: 0x060203C9 RID: 132041 RVA: 0x008CD6A4 File Offset: 0x008CB8A4
		// (set) Token: 0x060203CA RID: 132042 RVA: 0x008CD6B8 File Offset: 0x008CB8B8
		public unsafe FTransformDouble CharacterTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSystem_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSystem_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002FA8 RID: 12200
		// (get) Token: 0x060203CB RID: 132043 RVA: 0x008CD6CD File Offset: 0x008CB8CD
		// (set) Token: 0x060203CC RID: 132044 RVA: 0x008CD6DD File Offset: 0x008CB8DD
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSystem_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSystem_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x060203CD RID: 132045 RVA: 0x008CD6EE File Offset: 0x008CB8EE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSystem_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060203CE RID: 132046 RVA: 0x008CD702 File Offset: 0x008CB902
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailSystem_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060203CF RID: 132047 RVA: 0x008CD718 File Offset: 0x008CB918
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_TrailSystem_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TrailSystem_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailSystem_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailSystem_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSystem_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060203D0 RID: 132048 RVA: 0x008CD760 File Offset: 0x008CB960
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_TrailSystem_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TrailSystem_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailSystem_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailSystem_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailSystem_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060203D1 RID: 132049 RVA: 0x008CD7A8 File Offset: 0x008CB9A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_TrailSystem_C.__EditorTick_FunctionParams* ptr = stackalloc BP_TrailSystem_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailSystem_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailSystem_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSystem_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060203D2 RID: 132050 RVA: 0x008CD7F0 File Offset: 0x008CB9F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_TrailSystem_C.__EditorTick_FunctionParams* ptr = stackalloc BP_TrailSystem_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailSystem_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailSystem_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailSystem_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060203D3 RID: 132051 RVA: 0x008CD837 File Offset: 0x008CBA37
		protected BP_TrailSystem_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F95A RID: 63834
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/BP/BP_TrailSystem.BP_TrailSystem_C";

		// Token: 0x0400F95B RID: 63835
		private static IntPtr _ClassPtr;

		// Token: 0x0400F95C RID: 63836
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F95D RID: 63837
		internal static int __PropertyOffset_1;

		// Token: 0x0400F95E RID: 63838
		internal static int __PropertyOffset_2;

		// Token: 0x0400F95F RID: 63839
		internal static int __PropertyOffset_3;

		// Token: 0x0400F960 RID: 63840
		internal static int __PropertyOffset_4;

		// Token: 0x0400F961 RID: 63841
		internal static int __PropertyOffset_5;

		// Token: 0x0400F962 RID: 63842
		internal static int __PropertyOffset_6;

		// Token: 0x0400F963 RID: 63843
		internal static int __PropertyOffset_7;

		// Token: 0x0400F964 RID: 63844
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F965 RID: 63845
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F966 RID: 63846
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009B97 RID: 39831
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311EB RID: 201195
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009B98 RID: 39832
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040311EC RID: 201196
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
