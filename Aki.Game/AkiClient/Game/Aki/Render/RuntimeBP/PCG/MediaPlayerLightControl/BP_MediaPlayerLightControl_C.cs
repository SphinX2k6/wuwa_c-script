using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MediaPlayerLightControl
{
	// Token: 0x020030E6 RID: 12518
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MediaPlayerLightControl/BP_MediaPlayerLightControl.BP_MediaPlayerLightControl_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1508)]
	public class BP_MediaPlayerLightControl_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_SceneBp_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601E437 RID: 123959 RVA: 0x0090F9EF File Offset: 0x0090DBEF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MediaPlayerLightControl_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MediaPlayerLightControl/BP_MediaPlayerLightControl.BP_MediaPlayerLightControl_C");
			}
			return BP_MediaPlayerLightControl_C._ClassPtr;
		}

		// Token: 0x0601E438 RID: 123960 RVA: 0x0090FA14 File Offset: 0x0090DC14
		public BP_MediaPlayerLightControl_C() : this(BuiltinUtils.AllocNativeUObject(BP_MediaPlayerLightControl_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E439 RID: 123961 RVA: 0x0090FA3C File Offset: 0x0090DC3C
		[NullableContext(1)]
		public BP_MediaPlayerLightControl_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MediaPlayerLightControl_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x0601E43A RID: 123962 RVA: 0x0090FA6F File Offset: 0x0090DC6F
		// (set) Token: 0x0601E43B RID: 123963 RVA: 0x0090FA83 File Offset: 0x0090DC83
		public unsafe UTextRenderComponent Play
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_Play);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_Play, value);
			}
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x0601E43C RID: 123964 RVA: 0x0090FA98 File Offset: 0x0090DC98
		// (set) Token: 0x0601E43D RID: 123965 RVA: 0x0090FAAC File Offset: 0x0090DCAC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x0601E43E RID: 123966 RVA: 0x0090FAC1 File Offset: 0x0090DCC1
		// (set) Token: 0x0601E43F RID: 123967 RVA: 0x0090FAD5 File Offset: 0x0090DCD5
		public unsafe ULevelSequence Sequence
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_Sequence);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_Sequence, value);
			}
		}

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x0601E440 RID: 123968 RVA: 0x0090FAEA File Offset: 0x0090DCEA
		// (set) Token: 0x0601E441 RID: 123969 RVA: 0x0090FAFA File Offset: 0x0090DCFA
		public unsafe bool SequenceDebugCanvas
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaPlayerLightControl_C.__PropertyOffset_SequenceDebugCanvas) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaPlayerLightControl_C.__PropertyOffset_SequenceDebugCanvas) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x0601E442 RID: 123970 RVA: 0x0090FB0B File Offset: 0x0090DD0B
		// (set) Token: 0x0601E443 RID: 123971 RVA: 0x0090FB1F File Offset: 0x0090DD1F
		public unsafe UMaterialInstance MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_MaterialInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_MaterialInstance, value);
			}
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x0601E444 RID: 123972 RVA: 0x0090FB34 File Offset: 0x0090DD34
		// (set) Token: 0x0601E445 RID: 123973 RVA: 0x0090FB48 File Offset: 0x0090DD48
		public unsafe FVector World_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaPlayerLightControl_C.__PropertyOffset_World_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaPlayerLightControl_C.__PropertyOffset_World_Scale) = value;
			}
		}

		// Token: 0x0601E446 RID: 123974 RVA: 0x0090FB60 File Offset: 0x0090DD60
		[SkipLocalsInit]
		public unsafe virtual void ShouldStopOnHide(ref bool ret)
		{
			BP_MediaPlayerLightControl_C.__ShouldStopOnHide_FunctionParams* ptr = stackalloc BP_MediaPlayerLightControl_C.__ShouldStopOnHide_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_MediaPlayerLightControl_C.__ShouldStopOnHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaPlayerLightControl_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0601E447 RID: 123975 RVA: 0x0090FBB0 File Offset: 0x0090DDB0
		[SkipLocalsInit]
		public unsafe virtual void GetAoiRange(ref int ret)
		{
			BP_MediaPlayerLightControl_C.__GetAoiRange_FunctionParams* ptr = stackalloc BP_MediaPlayerLightControl_C.__GetAoiRange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaPlayerLightControl_C.__GetAoiRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaPlayerLightControl_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0601E448 RID: 123976 RVA: 0x0090FBFF File Offset: 0x0090DDFF
		[SkipLocalsInit]
		public virtual void TickOutside()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__TickOutside_NativeFunctionPtr, null);
		}

		// Token: 0x0601E449 RID: 123977 RVA: 0x0090FC13 File Offset: 0x0090DE13
		[SkipLocalsInit]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x0601E44A RID: 123978 RVA: 0x0090FC27 File Offset: 0x0090DE27
		[SkipLocalsInit]
		public virtual void Stop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x0601E44B RID: 123979 RVA: 0x0090FC3B File Offset: 0x0090DE3B
		[SkipLocalsInit]
		public virtual void Pause()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__Pause_NativeFunctionPtr, null);
		}

		// Token: 0x0601E44C RID: 123980 RVA: 0x0090FC4F File Offset: 0x0090DE4F
		[SkipLocalsInit]
		public virtual void Resume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__Resume_NativeFunctionPtr, null);
		}

		// Token: 0x0601E44D RID: 123981 RVA: 0x0090FC63 File Offset: 0x0090DE63
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E44E RID: 123982 RVA: 0x0090FC77 File Offset: 0x0090DE77
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E44F RID: 123983 RVA: 0x0090FC8C File Offset: 0x0090DE8C
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_MediaPlayerLightControl_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MediaPlayerLightControl_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaPlayerLightControl_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaPlayerLightControl_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E450 RID: 123984 RVA: 0x0090FCD4 File Offset: 0x0090DED4
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_MediaPlayerLightControl_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MediaPlayerLightControl_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaPlayerLightControl_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaPlayerLightControl_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E451 RID: 123985 RVA: 0x0090FD1C File Offset: 0x0090DF1C
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_MediaPlayerLightControl_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_MediaPlayerLightControl_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_MediaPlayerLightControl_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaPlayerLightControl_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E452 RID: 123986 RVA: 0x0090FD68 File Offset: 0x0090DF68
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_MediaPlayerLightControl_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_MediaPlayerLightControl_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_MediaPlayerLightControl_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaPlayerLightControl_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E453 RID: 123987 RVA: 0x0090FDB3 File Offset: 0x0090DFB3
		protected BP_MediaPlayerLightControl_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010046 RID: 65606
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MediaPlayerLightControl/BP_MediaPlayerLightControl.BP_MediaPlayerLightControl_C";

		// Token: 0x04010047 RID: 65607
		private static IntPtr _ClassPtr;

		// Token: 0x04010048 RID: 65608
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010049 RID: 65609
		internal static int __PropertyOffset_Play;

		// Token: 0x0401004A RID: 65610
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0401004B RID: 65611
		internal static int __PropertyOffset_Sequence;

		// Token: 0x0401004C RID: 65612
		internal static int __PropertyOffset_SequenceDebugCanvas;

		// Token: 0x0401004D RID: 65613
		internal static int __PropertyOffset_MaterialInstance;

		// Token: 0x0401004E RID: 65614
		internal static int __PropertyOffset_World_Scale;

		// Token: 0x0401004F RID: 65615
		private static IntPtr __ShouldStopOnHide_NativeFunctionPtr;

		// Token: 0x04010050 RID: 65616
		private static IntPtr __GetAoiRange_NativeFunctionPtr;

		// Token: 0x04010051 RID: 65617
		private static IntPtr __TickOutside_NativeFunctionPtr;

		// Token: 0x04010052 RID: 65618
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x04010053 RID: 65619
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x04010054 RID: 65620
		private static IntPtr __Pause_NativeFunctionPtr;

		// Token: 0x04010055 RID: 65621
		private static IntPtr __Resume_NativeFunctionPtr;

		// Token: 0x04010056 RID: 65622
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010057 RID: 65623
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010058 RID: 65624
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02008E58 RID: 36440
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShouldStopOnHide_FunctionParams
		{
			// Token: 0x0402CAA3 RID: 182947
			[FieldOffset(0)]
			public bool ret;
		}

		// Token: 0x02008E59 RID: 36441
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetAoiRange_FunctionParams
		{
			// Token: 0x0402CAA4 RID: 182948
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02008E5A RID: 36442
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CAA5 RID: 182949
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E5B RID: 36443
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402CAA6 RID: 182950
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
