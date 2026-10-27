using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MusicInteraction
{
	// Token: 0x02003C4B RID: 15435
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MusicInteraction/BP_GetMusicBeat.BP_GetMusicBeat_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class BP_GetMusicBeat_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023BEB RID: 146411 RVA: 0x0092BA2C File Offset: 0x00929C2C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GetMusicBeat_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MusicInteraction/BP_GetMusicBeat.BP_GetMusicBeat_C");
			}
			return BP_GetMusicBeat_C._ClassPtr;
		}

		// Token: 0x06023BEC RID: 146412 RVA: 0x0092BA50 File Offset: 0x00929C50
		public BP_GetMusicBeat_C() : this(BuiltinUtils.AllocNativeUObject(BP_GetMusicBeat_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023BED RID: 146413 RVA: 0x0092BA78 File Offset: 0x00929C78
		[NullableContext(1)]
		public BP_GetMusicBeat_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GetMusicBeat_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004354 RID: 17236
		// (get) Token: 0x06023BEE RID: 146414 RVA: 0x0092BAAB File Offset: 0x00929CAB
		// (set) Token: 0x06023BEF RID: 146415 RVA: 0x0092BABF File Offset: 0x00929CBF
		[Nullable(2)]
		public unsafe UBoxComponent AreaBox
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GetMusicBeat_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GetMusicBeat_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004355 RID: 17237
		// (get) Token: 0x06023BF0 RID: 146416 RVA: 0x0092BAD4 File Offset: 0x00929CD4
		// (set) Token: 0x06023BF1 RID: 146417 RVA: 0x0092BAE8 File Offset: 0x00929CE8
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GetMusicBeat_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GetMusicBeat_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004356 RID: 17238
		// (get) Token: 0x06023BF2 RID: 146418 RVA: 0x0092BAFD File Offset: 0x00929CFD
		// (set) Token: 0x06023BF3 RID: 146419 RVA: 0x0092BB0D File Offset: 0x00929D0D
		public unsafe bool Activate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004357 RID: 17239
		// (get) Token: 0x06023BF4 RID: 146420 RVA: 0x0092BB1E File Offset: 0x00929D1E
		// (set) Token: 0x06023BF5 RID: 146421 RVA: 0x0092BB2E File Offset: 0x00929D2E
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004358 RID: 17240
		// (get) Token: 0x06023BF6 RID: 146422 RVA: 0x0092BB3F File Offset: 0x00929D3F
		// (set) Token: 0x06023BF7 RID: 146423 RVA: 0x0092BB53 File Offset: 0x00929D53
		public unsafe FVector AreaExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004359 RID: 17241
		// (get) Token: 0x06023BF8 RID: 146424 RVA: 0x0092BB68 File Offset: 0x00929D68
		// (set) Token: 0x06023BF9 RID: 146425 RVA: 0x0092BB78 File Offset: 0x00929D78
		public unsafe bool DoubleBeat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700435A RID: 17242
		// (get) Token: 0x06023BFA RID: 146426 RVA: 0x0092BB89 File Offset: 0x00929D89
		// (set) Token: 0x06023BFB RID: 146427 RVA: 0x0092BB99 File Offset: 0x00929D99
		public unsafe float BeatTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700435B RID: 17243
		// (get) Token: 0x06023BFC RID: 146428 RVA: 0x0092BBAA File Offset: 0x00929DAA
		// (set) Token: 0x06023BFD RID: 146429 RVA: 0x0092BBBA File Offset: 0x00929DBA
		public unsafe float DoubleBeatTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700435C RID: 17244
		// (get) Token: 0x06023BFE RID: 146430 RVA: 0x0092BBCB File Offset: 0x00929DCB
		// (set) Token: 0x06023BFF RID: 146431 RVA: 0x0092BBDB File Offset: 0x00929DDB
		public unsafe float 单拍时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700435D RID: 17245
		// (get) Token: 0x06023C00 RID: 146432 RVA: 0x0092BBEC File Offset: 0x00929DEC
		// (set) Token: 0x06023C01 RID: 146433 RVA: 0x0092BBFC File Offset: 0x00929DFC
		public unsafe float LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GetMusicBeat_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x06023C02 RID: 146434 RVA: 0x0092BC0D File Offset: 0x00929E0D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GetMusicBeat_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023C03 RID: 146435 RVA: 0x0092BC21 File Offset: 0x00929E21
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GetMusicBeat_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023C04 RID: 146436 RVA: 0x0092BC36 File Offset: 0x00929E36
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GetMusicBeat_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023C05 RID: 146437 RVA: 0x0092BC4A File Offset: 0x00929E4A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GetMusicBeat_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023C06 RID: 146438 RVA: 0x0092BC60 File Offset: 0x00929E60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_GetMusicBeat_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GetMusicBeat_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GetMusicBeat_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GetMusicBeat_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GetMusicBeat_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023C07 RID: 146439 RVA: 0x0092BCA8 File Offset: 0x00929EA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_GetMusicBeat_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GetMusicBeat_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GetMusicBeat_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GetMusicBeat_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GetMusicBeat_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023C08 RID: 146440 RVA: 0x0092BCF0 File Offset: 0x00929EF0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 音乐节拍事件触发时_Event_0(string MusicEventType)
		{
			BP_GetMusicBeat_C.__音乐节拍事件触发时_Event_0_FunctionParams* ptr = stackalloc BP_GetMusicBeat_C.__音乐节拍事件触发时_Event_0_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_GetMusicBeat_C.__音乐节拍事件触发时_Event_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GetMusicBeat_C.__音乐节拍事件触发时_Event_0_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MusicEventType), MusicEventType);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GetMusicBeat_C.__音乐节拍事件触发时_Event_0_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_GetMusicBeat_C.__音乐节拍事件触发时_Event_0_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06023C09 RID: 146441 RVA: 0x0092BD50 File Offset: 0x00929F50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_GetMusicBeat_C.__EditorTick_FunctionParams* ptr = stackalloc BP_GetMusicBeat_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GetMusicBeat_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GetMusicBeat_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GetMusicBeat_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023C0A RID: 146442 RVA: 0x0092BD98 File Offset: 0x00929F98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_GetMusicBeat_C.__EditorTick_FunctionParams* ptr = stackalloc BP_GetMusicBeat_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GetMusicBeat_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GetMusicBeat_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GetMusicBeat_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023C0B RID: 146443 RVA: 0x0092BDDF File Offset: 0x00929FDF
		protected BP_GetMusicBeat_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011AA0 RID: 72352
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MusicInteraction/BP_GetMusicBeat.BP_GetMusicBeat_C";

		// Token: 0x04011AA1 RID: 72353
		private static IntPtr _ClassPtr;

		// Token: 0x04011AA2 RID: 72354
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011AA3 RID: 72355
		internal static int __PropertyOffset_1;

		// Token: 0x04011AA4 RID: 72356
		internal static int __PropertyOffset_2;

		// Token: 0x04011AA5 RID: 72357
		internal static int __PropertyOffset_3;

		// Token: 0x04011AA6 RID: 72358
		internal static int __PropertyOffset_4;

		// Token: 0x04011AA7 RID: 72359
		internal static int __PropertyOffset_5;

		// Token: 0x04011AA8 RID: 72360
		internal static int __PropertyOffset_6;

		// Token: 0x04011AA9 RID: 72361
		internal static int __PropertyOffset_7;

		// Token: 0x04011AAA RID: 72362
		internal static int __PropertyOffset_8;

		// Token: 0x04011AAB RID: 72363
		internal static int __PropertyOffset_9;

		// Token: 0x04011AAC RID: 72364
		internal static int __PropertyOffset_10;

		// Token: 0x04011AAD RID: 72365
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011AAE RID: 72366
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011AAF RID: 72367
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011AB0 RID: 72368
		private static IntPtr __音乐节拍事件触发时_Event_0_NativeFunctionPtr;

		// Token: 0x04011AB1 RID: 72369
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009E96 RID: 40598
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403175C RID: 202588
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E97 RID: 40599
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __音乐节拍事件触发时_Event_0_FunctionParams
		{
			// Token: 0x0403175D RID: 202589
			[FieldOffset(0)]
			public FString MusicEventType;
		}

		// Token: 0x02009E98 RID: 40600
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403175E RID: 202590
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
