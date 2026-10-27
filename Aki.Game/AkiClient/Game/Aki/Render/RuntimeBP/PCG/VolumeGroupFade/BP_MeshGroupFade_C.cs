using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.VolumeGroupFade
{
	// Token: 0x02003BE5 RID: 15333
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/VolumeGroupFade/BP_MeshGroupFade.BP_MeshGroupFade_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class BP_MeshGroupFade_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022A6D RID: 141933 RVA: 0x0090ED0C File Offset: 0x0090CF0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MeshGroupFade_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/VolumeGroupFade/BP_MeshGroupFade.BP_MeshGroupFade_C");
			}
			return BP_MeshGroupFade_C._ClassPtr;
		}

		// Token: 0x06022A6E RID: 141934 RVA: 0x0090ED30 File Offset: 0x0090CF30
		public BP_MeshGroupFade_C() : this(BuiltinUtils.AllocNativeUObject(BP_MeshGroupFade_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022A6F RID: 141935 RVA: 0x0090ED58 File Offset: 0x0090CF58
		[NullableContext(1)]
		public BP_MeshGroupFade_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MeshGroupFade_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003CE0 RID: 15584
		// (get) Token: 0x06022A70 RID: 141936 RVA: 0x0090ED8B File Offset: 0x0090CF8B
		// (set) Token: 0x06022A71 RID: 141937 RVA: 0x0090ED9F File Offset: 0x0090CF9F
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshGroupFade_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshGroupFade_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003CE1 RID: 15585
		// (get) Token: 0x06022A72 RID: 141938 RVA: 0x0090EDB4 File Offset: 0x0090CFB4
		// (set) Token: 0x06022A73 RID: 141939 RVA: 0x0090EDED File Offset: 0x0090CFED
		[Nullable(1)]
		public TArray<AStaticMeshActor> StaticMesh
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._StaticMesh) == null)
				{
					result = (this._StaticMesh = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StaticMesh.CopyAssign(value);
			}
		}

		// Token: 0x17003CE2 RID: 15586
		// (get) Token: 0x06022A74 RID: 141940 RVA: 0x0090EDFB File Offset: 0x0090CFFB
		// (set) Token: 0x06022A75 RID: 141941 RVA: 0x0090EE0B File Offset: 0x0090D00B
		public unsafe float FadeValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003CE3 RID: 15587
		// (get) Token: 0x06022A76 RID: 141942 RVA: 0x0090EE1C File Offset: 0x0090D01C
		// (set) Token: 0x06022A77 RID: 141943 RVA: 0x0090EE2C File Offset: 0x0090D02C
		public unsafe int FadeGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003CE4 RID: 15588
		// (get) Token: 0x06022A78 RID: 141944 RVA: 0x0090EE3D File Offset: 0x0090D03D
		// (set) Token: 0x06022A79 RID: 141945 RVA: 0x0090EE51 File Offset: 0x0090D051
		public unsafe FName Parameter_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003CE5 RID: 15589
		// (get) Token: 0x06022A7A RID: 141946 RVA: 0x0090EE66 File Offset: 0x0090D066
		// (set) Token: 0x06022A7B RID: 141947 RVA: 0x0090EE76 File Offset: 0x0090D076
		public unsafe bool bHide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CE6 RID: 15590
		// (get) Token: 0x06022A7C RID: 141948 RVA: 0x0090EE87 File Offset: 0x0090D087
		// (set) Token: 0x06022A7D RID: 141949 RVA: 0x0090EE97 File Offset: 0x0090D097
		public unsafe bool bInverseVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CE7 RID: 15591
		// (get) Token: 0x06022A7E RID: 141950 RVA: 0x0090EEA8 File Offset: 0x0090D0A8
		// (set) Token: 0x06022A7F RID: 141951 RVA: 0x0090EEBC File Offset: 0x0090D0BC
		public unsafe UStaticMeshComponent Static_Mesh_Component
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshGroupFade_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshGroupFade_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003CE8 RID: 15592
		// (get) Token: 0x06022A80 RID: 141952 RVA: 0x0090EED1 File Offset: 0x0090D0D1
		// (set) Token: 0x06022A81 RID: 141953 RVA: 0x0090EEE1 File Offset: 0x0090D0E1
		public unsafe bool bUpdateFinished
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CE9 RID: 15593
		// (get) Token: 0x06022A82 RID: 141954 RVA: 0x0090EEF2 File Offset: 0x0090D0F2
		// (set) Token: 0x06022A83 RID: 141955 RVA: 0x0090EF02 File Offset: 0x0090D102
		public unsafe int maxProcessCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003CEA RID: 15594
		// (get) Token: 0x06022A84 RID: 141956 RVA: 0x0090EF13 File Offset: 0x0090D113
		// (set) Token: 0x06022A85 RID: 141957 RVA: 0x0090EF23 File Offset: 0x0090D123
		public unsafe int currentIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003CEB RID: 15595
		// (get) Token: 0x06022A86 RID: 141958 RVA: 0x0090EF34 File Offset: 0x0090D134
		// (set) Token: 0x06022A87 RID: 141959 RVA: 0x0090EF44 File Offset: 0x0090D144
		public unsafe int MeshCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshGroupFade_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x06022A88 RID: 141960 RVA: 0x0090EF55 File Offset: 0x0090D155
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshGroupFade_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x06022A89 RID: 141961 RVA: 0x0090EF69 File Offset: 0x0090D169
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshGroupFade_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022A8A RID: 141962 RVA: 0x0090EF7D File Offset: 0x0090D17D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshGroupFade_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022A8B RID: 141963 RVA: 0x0090EF92 File Offset: 0x0090D192
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshGroupFade_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022A8C RID: 141964 RVA: 0x0090EFA6 File Offset: 0x0090D1A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshGroupFade_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022A8D RID: 141965 RVA: 0x0090EFBC File Offset: 0x0090D1BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MeshGroupFade_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshGroupFade_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshGroupFade_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshGroupFade_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshGroupFade_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022A8E RID: 141966 RVA: 0x0090F004 File Offset: 0x0090D204
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MeshGroupFade_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshGroupFade_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshGroupFade_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshGroupFade_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshGroupFade_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022A8F RID: 141967 RVA: 0x0090F04C File Offset: 0x0090D24C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_MeshGroupFade_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MeshGroupFade_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshGroupFade_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshGroupFade_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshGroupFade_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022A90 RID: 141968 RVA: 0x0090F094 File Offset: 0x0090D294
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_MeshGroupFade_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MeshGroupFade_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshGroupFade_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshGroupFade_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshGroupFade_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022A91 RID: 141969 RVA: 0x0090F0DB File Offset: 0x0090D2DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateStat()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshGroupFade_C.__UpdateStat_NativeFunctionPtr, null);
		}

		// Token: 0x06022A92 RID: 141970 RVA: 0x0090F0EF File Offset: 0x0090D2EF
		protected BP_MeshGroupFade_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011087 RID: 69767
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/VolumeGroupFade/BP_MeshGroupFade.BP_MeshGroupFade_C";

		// Token: 0x04011088 RID: 69768
		private static IntPtr _ClassPtr;

		// Token: 0x04011089 RID: 69769
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401108A RID: 69770
		internal static int __PropertyOffset_1;

		// Token: 0x0401108B RID: 69771
		internal static int __PropertyOffset_2;

		// Token: 0x0401108C RID: 69772
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _StaticMesh;

		// Token: 0x0401108D RID: 69773
		internal static int __PropertyOffset_3;

		// Token: 0x0401108E RID: 69774
		internal static int __PropertyOffset_4;

		// Token: 0x0401108F RID: 69775
		internal static int __PropertyOffset_5;

		// Token: 0x04011090 RID: 69776
		internal static int __PropertyOffset_6;

		// Token: 0x04011091 RID: 69777
		internal static int __PropertyOffset_7;

		// Token: 0x04011092 RID: 69778
		internal static int __PropertyOffset_8;

		// Token: 0x04011093 RID: 69779
		internal static int __PropertyOffset_9;

		// Token: 0x04011094 RID: 69780
		internal static int __PropertyOffset_10;

		// Token: 0x04011095 RID: 69781
		internal static int __PropertyOffset_11;

		// Token: 0x04011096 RID: 69782
		internal static int __PropertyOffset_12;

		// Token: 0x04011097 RID: 69783
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x04011098 RID: 69784
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011099 RID: 69785
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401109A RID: 69786
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401109B RID: 69787
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401109C RID: 69788
		private static IntPtr __UpdateStat_NativeFunctionPtr;

		// Token: 0x02009DB1 RID: 40369
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031593 RID: 202131
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009DB2 RID: 40370
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031594 RID: 202132
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
