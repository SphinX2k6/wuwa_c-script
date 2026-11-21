using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Seq_BP.SeqStreamingSource
{
	// Token: 0x0200306D RID: 12397
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/SeqStreamingSource/BP_KuroStreamingSourceProxy_Seq.BP_KuroStreamingSourceProxy_Seq_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1484)]
	public class BP_KuroStreamingSourceProxy_Seq_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D7A8 RID: 120744 RVA: 0x008F89A7 File Offset: 0x008F6BA7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroStreamingSourceProxy_Seq_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/SeqStreamingSource/BP_KuroStreamingSourceProxy_Seq.BP_KuroStreamingSourceProxy_Seq_C");
			}
			return BP_KuroStreamingSourceProxy_Seq_C._ClassPtr;
		}

		// Token: 0x0601D7A9 RID: 120745 RVA: 0x008F89CC File Offset: 0x008F6BCC
		public BP_KuroStreamingSourceProxy_Seq_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroStreamingSourceProxy_Seq_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D7AA RID: 120746 RVA: 0x008F89F4 File Offset: 0x008F6BF4
		public BP_KuroStreamingSourceProxy_Seq_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroStreamingSourceProxy_Seq_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002EF5 RID: 12021
		// (get) Token: 0x0601D7AB RID: 120747 RVA: 0x008F8A27 File Offset: 0x008F6C27
		// (set) Token: 0x0601D7AC RID: 120748 RVA: 0x008F8A3B File Offset: 0x008F6C3B
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroStreamingSourceProxy_Seq_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroStreamingSourceProxy_Seq_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17002EF6 RID: 12022
		// (get) Token: 0x0601D7AD RID: 120749 RVA: 0x008F8A50 File Offset: 0x008F6C50
		// (set) Token: 0x0601D7AE RID: 120750 RVA: 0x008F8A64 File Offset: 0x008F6C64
		public unsafe string CurrSpeed
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_KuroStreamingSourceProxy_Seq_C.__PropertyOffset_CurrSpeed)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_KuroStreamingSourceProxy_Seq_C.__PropertyOffset_CurrSpeed)), value);
			}
		}

		// Token: 0x17002EF7 RID: 12023
		// (get) Token: 0x0601D7AF RID: 120751 RVA: 0x008F8A79 File Offset: 0x008F6C79
		// (set) Token: 0x0601D7B0 RID: 120752 RVA: 0x008F8A89 File Offset: 0x008F6C89
		public unsafe float velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroStreamingSourceProxy_Seq_C.__PropertyOffset_velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroStreamingSourceProxy_Seq_C.__PropertyOffset_velocity) = value;
			}
		}

		// Token: 0x0601D7B1 RID: 120753 RVA: 0x008F8A9C File Offset: 0x008F6C9C
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_FunctionParams* ptr = stackalloc BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D7B2 RID: 120754 RVA: 0x008F8AE4 File Offset: 0x008F6CE4
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_FunctionParams* ptr = stackalloc BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroStreamingSourceProxy_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D7B3 RID: 120755 RVA: 0x008F8B2A File Offset: 0x008F6D2A
		protected BP_KuroStreamingSourceProxy_Seq_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F85D RID: 63581
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/SeqStreamingSource/BP_KuroStreamingSourceProxy_Seq.BP_KuroStreamingSourceProxy_Seq_C";

		// Token: 0x0400F85E RID: 63582
		private static IntPtr _ClassPtr;

		// Token: 0x0400F85F RID: 63583
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F860 RID: 63584
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400F861 RID: 63585
		internal static int __PropertyOffset_CurrSpeed;

		// Token: 0x0400F862 RID: 63586
		internal static int __PropertyOffset_velocity;

		// Token: 0x0400F863 RID: 63587
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02008D33 RID: 36147
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402C896 RID: 182422
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
