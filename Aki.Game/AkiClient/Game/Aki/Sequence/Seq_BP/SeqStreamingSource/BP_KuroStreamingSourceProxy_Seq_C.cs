using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Seq_BP.SeqStreamingSource
{
	// Token: 0x02003A20 RID: 14880
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/SeqStreamingSource/BP_KuroStreamingSourceProxy_Seq.BP_KuroStreamingSourceProxy_Seq_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1484)]
	public class BP_KuroStreamingSourceProxy_Seq_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F3F7 RID: 127991 RVA: 0x008B29D5 File Offset: 0x008B0BD5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroStreamingSourceProxy_Seq_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/SeqStreamingSource/BP_KuroStreamingSourceProxy_Seq.BP_KuroStreamingSourceProxy_Seq_C");
			}
			return BP_KuroStreamingSourceProxy_Seq_C._ClassPtr;
		}

		// Token: 0x0601F3F8 RID: 127992 RVA: 0x008B29FC File Offset: 0x008B0BFC
		public BP_KuroStreamingSourceProxy_Seq_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroStreamingSourceProxy_Seq_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F3F9 RID: 127993 RVA: 0x008B2A24 File Offset: 0x008B0C24
		public BP_KuroStreamingSourceProxy_Seq_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroStreamingSourceProxy_Seq_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A66 RID: 10854
		// (get) Token: 0x0601F3FA RID: 127994 RVA: 0x008B2A57 File Offset: 0x008B0C57
		// (set) Token: 0x0601F3FB RID: 127995 RVA: 0x008B2A6B File Offset: 0x008B0C6B
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroStreamingSourceProxy_Seq_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroStreamingSourceProxy_Seq_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002A67 RID: 10855
		// (get) Token: 0x0601F3FC RID: 127996 RVA: 0x008B2A80 File Offset: 0x008B0C80
		// (set) Token: 0x0601F3FD RID: 127997 RVA: 0x008B2A94 File Offset: 0x008B0C94
		public unsafe string CurrSpeed
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_KuroStreamingSourceProxy_Seq_C.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_KuroStreamingSourceProxy_Seq_C.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17002A68 RID: 10856
		// (get) Token: 0x0601F3FE RID: 127998 RVA: 0x008B2AA9 File Offset: 0x008B0CA9
		// (set) Token: 0x0601F3FF RID: 127999 RVA: 0x008B2AB9 File Offset: 0x008B0CB9
		public unsafe float velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroStreamingSourceProxy_Seq_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroStreamingSourceProxy_Seq_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0601F400 RID: 128000 RVA: 0x008B2ACC File Offset: 0x008B0CCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_FunctionParams* ptr = stackalloc BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F401 RID: 128001 RVA: 0x008B2B14 File Offset: 0x008B0D14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_FunctionParams* ptr = stackalloc BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F402 RID: 128002 RVA: 0x008B2B5B File Offset: 0x008B0D5B
		protected BP_KuroStreamingSourceProxy_Seq_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EFBF RID: 61375
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/SeqStreamingSource/BP_KuroStreamingSourceProxy_Seq.BP_KuroStreamingSourceProxy_Seq_C";

		// Token: 0x0400EFC0 RID: 61376
		private static IntPtr _ClassPtr;

		// Token: 0x0400EFC1 RID: 61377
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EFC2 RID: 61378
		internal static int __PropertyOffset_1;

		// Token: 0x0400EFC3 RID: 61379
		internal static int __PropertyOffset_2;

		// Token: 0x0400EFC4 RID: 61380
		internal static int __PropertyOffset_3;

		// Token: 0x0400EFC5 RID: 61381
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009A9D RID: 39581
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031018 RID: 200728
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
