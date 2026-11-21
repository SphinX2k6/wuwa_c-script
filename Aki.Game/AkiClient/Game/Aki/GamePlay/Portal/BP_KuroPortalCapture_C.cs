using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.Portal
{
	// Token: 0x0200314B RID: 12619
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/Portal/BP_KuroPortalCapture.BP_KuroPortalCapture_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class BP_KuroPortalCapture_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F080 RID: 127104 RVA: 0x00924912 File Offset: 0x00922B12
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroPortalCapture_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/Portal/BP_KuroPortalCapture.BP_KuroPortalCapture_C");
			}
			return BP_KuroPortalCapture_C._ClassPtr;
		}

		// Token: 0x0601F081 RID: 127105 RVA: 0x00924938 File Offset: 0x00922B38
		public BP_KuroPortalCapture_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroPortalCapture_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F082 RID: 127106 RVA: 0x00924960 File Offset: 0x00922B60
		[NullableContext(1)]
		public BP_KuroPortalCapture_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroPortalCapture_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036F7 RID: 14071
		// (get) Token: 0x0601F083 RID: 127107 RVA: 0x00924993 File Offset: 0x00922B93
		// (set) Token: 0x0601F084 RID: 127108 RVA: 0x009249A7 File Offset: 0x00922BA7
		public unsafe UArrowComponent Arrow1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_Arrow1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_Arrow1, value);
			}
		}

		// Token: 0x170036F8 RID: 14072
		// (get) Token: 0x0601F085 RID: 127109 RVA: 0x009249BC File Offset: 0x00922BBC
		// (set) Token: 0x0601F086 RID: 127110 RVA: 0x009249D0 File Offset: 0x00922BD0
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_Arrow);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_Arrow, value);
			}
		}

		// Token: 0x170036F9 RID: 14073
		// (get) Token: 0x0601F087 RID: 127111 RVA: 0x009249E5 File Offset: 0x00922BE5
		// (set) Token: 0x0601F088 RID: 127112 RVA: 0x009249F9 File Offset: 0x00922BF9
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_Plane);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_Plane, value);
			}
		}

		// Token: 0x170036FA RID: 14074
		// (get) Token: 0x0601F089 RID: 127113 RVA: 0x00924A0E File Offset: 0x00922C0E
		// (set) Token: 0x0601F08A RID: 127114 RVA: 0x00924A22 File Offset: 0x00922C22
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_Scene);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_Scene, value);
			}
		}

		// Token: 0x170036FB RID: 14075
		// (get) Token: 0x0601F08B RID: 127115 RVA: 0x00924A37 File Offset: 0x00922C37
		// (set) Token: 0x0601F08C RID: 127116 RVA: 0x00924A4B File Offset: 0x00922C4B
		public unsafe AActor Target
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_Target);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroPortalCapture_C.__PropertyOffset_Target, value);
			}
		}

		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x0601F08D RID: 127117 RVA: 0x00924A60 File Offset: 0x00922C60
		// (set) Token: 0x0601F08E RID: 127118 RVA: 0x00924A70 File Offset: 0x00922C70
		public unsafe float offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_offset) = value;
			}
		}

		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x0601F08F RID: 127119 RVA: 0x00924A81 File Offset: 0x00922C81
		// (set) Token: 0x0601F090 RID: 127120 RVA: 0x00924A91 File Offset: 0x00922C91
		public unsafe bool EnableCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_EnableCamera) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_EnableCamera) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x0601F091 RID: 127121 RVA: 0x00924AA4 File Offset: 0x00922CA4
		// (set) Token: 0x0601F092 RID: 127122 RVA: 0x00924ADD File Offset: 0x00922CDD
		[Nullable(1)]
		public RoleTeleport RoleTeleport
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				RoleTeleport result;
				if ((result = this._RoleTeleport) == null)
				{
					result = (this._RoleTeleport = new RoleTeleport(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_RoleTeleport, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_RoleTeleport, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x0601F093 RID: 127123 RVA: 0x00924AFE File Offset: 0x00922CFE
		// (set) Token: 0x0601F094 RID: 127124 RVA: 0x00924B0E File Offset: 0x00922D0E
		public unsafe int PbdataId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_PbdataId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_PbdataId) = value;
			}
		}

		// Token: 0x17003700 RID: 14080
		// (get) Token: 0x0601F095 RID: 127125 RVA: 0x00924B1F File Offset: 0x00922D1F
		// (set) Token: 0x0601F096 RID: 127126 RVA: 0x00924B2F File Offset: 0x00922D2F
		public unsafe float Hight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_Hight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroPortalCapture_C.__PropertyOffset_Hight) = value;
			}
		}

		// Token: 0x0601F097 RID: 127127 RVA: 0x00924B40 File Offset: 0x00922D40
		[SkipLocalsInit]
		public unsafe virtual void ToggleDebug(bool Enable)
		{
			BP_KuroPortalCapture_C.__ToggleDebug_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__ToggleDebug_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__ToggleDebug_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__ToggleDebug_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__ToggleDebug_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F098 RID: 127128 RVA: 0x00924B88 File Offset: 0x00922D88
		[SkipLocalsInit]
		public unsafe virtual void GetPair(ref BP_KuroPortalCapture_C Target)
		{
			BP_KuroPortalCapture_C.__GetPair_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__GetPair_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__GetPair_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__GetPair_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_KuroPortalCapture_C.__GetPair_FunctionParams ptr2 = ref *ptr;
			BP_KuroPortalCapture_C bp_KuroPortalCapture_C = Target;
			ptr2.Target = ((bp_KuroPortalCapture_C != null) ? bp_KuroPortalCapture_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__GetPair_NativeFunctionPtr, (void*)ptr);
			Target = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_KuroPortalCapture_C>(ptr->Target);
		}

		// Token: 0x0601F099 RID: 127129 RVA: 0x00924BEC File Offset: 0x00922DEC
		[SkipLocalsInit]
		public unsafe virtual void GetPortalTrans(ref FTransformDouble NewParam)
		{
			BP_KuroPortalCapture_C.__GetPortalTrans_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__GetPortalTrans_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__GetPortalTrans_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__GetPortalTrans_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__GetPortalTrans_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x0601F09A RID: 127130 RVA: 0x00924C48 File Offset: 0x00922E48
		[SkipLocalsInit]
		public unsafe virtual void SetPbDataId(int PbdataId)
		{
			BP_KuroPortalCapture_C.__SetPbDataId_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__SetPbDataId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__SetPbDataId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__SetPbDataId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PbdataId = PbdataId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__SetPbDataId_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F09B RID: 127131 RVA: 0x00924C90 File Offset: 0x00922E90
		[SkipLocalsInit]
		public unsafe virtual void SetPair(AActor Pair)
		{
			BP_KuroPortalCapture_C.__SetPair_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__SetPair_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__SetPair_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__SetPair_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Pair = ((Pair != null) ? Pair.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__SetPair_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F09C RID: 127132 RVA: 0x00924CE8 File Offset: 0x00922EE8
		[SkipLocalsInit]
		public unsafe virtual void Teleport(FTransformDouble InTrans, AActor InActor, bool IsRole)
		{
			BP_KuroPortalCapture_C.__Teleport_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__Teleport_FunctionParams[(UIntPtr)3135] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__Teleport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__Teleport_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTrans = InTrans;
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			ptr->IsRole = IsRole;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__Teleport_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F09D RID: 127133 RVA: 0x00924D4E File Offset: 0x00922F4E
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F09E RID: 127134 RVA: 0x00924D62 File Offset: 0x00922F62
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroPortalCapture_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F09F RID: 127135 RVA: 0x00924D78 File Offset: 0x00922F78
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroPortalCapture_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroPortalCapture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F0A0 RID: 127136 RVA: 0x00924DC0 File Offset: 0x00922FC0
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroPortalCapture_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroPortalCapture_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroPortalCapture_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroPortalCapture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroPortalCapture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F0A1 RID: 127137 RVA: 0x00924E06 File Offset: 0x00923006
		protected BP_KuroPortalCapture_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401093D RID: 67901
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/Portal/BP_KuroPortalCapture.BP_KuroPortalCapture_C";

		// Token: 0x0401093E RID: 67902
		private static IntPtr _ClassPtr;

		// Token: 0x0401093F RID: 67903
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010940 RID: 67904
		public static IntPtr __RoleTeleport__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010941 RID: 67905
		internal static int __PropertyOffset_Arrow1;

		// Token: 0x04010942 RID: 67906
		internal static int __PropertyOffset_Arrow;

		// Token: 0x04010943 RID: 67907
		internal static int __PropertyOffset_Plane;

		// Token: 0x04010944 RID: 67908
		internal static int __PropertyOffset_Scene;

		// Token: 0x04010945 RID: 67909
		internal static int __PropertyOffset_Target;

		// Token: 0x04010946 RID: 67910
		internal static int __PropertyOffset_offset;

		// Token: 0x04010947 RID: 67911
		internal static int __PropertyOffset_EnableCamera;

		// Token: 0x04010948 RID: 67912
		internal static int __PropertyOffset_RoleTeleport;

		// Token: 0x04010949 RID: 67913
		private RoleTeleport _RoleTeleport;

		// Token: 0x0401094A RID: 67914
		internal static int __PropertyOffset_PbdataId;

		// Token: 0x0401094B RID: 67915
		internal static int __PropertyOffset_Hight;

		// Token: 0x0401094C RID: 67916
		private static IntPtr __ToggleDebug_NativeFunctionPtr;

		// Token: 0x0401094D RID: 67917
		private static IntPtr __GetPair_NativeFunctionPtr;

		// Token: 0x0401094E RID: 67918
		private static IntPtr __GetPortalTrans_NativeFunctionPtr;

		// Token: 0x0401094F RID: 67919
		private static IntPtr __SetPbDataId_NativeFunctionPtr;

		// Token: 0x04010950 RID: 67920
		private static IntPtr __SetPair_NativeFunctionPtr;

		// Token: 0x04010951 RID: 67921
		private static IntPtr __Teleport_NativeFunctionPtr;

		// Token: 0x04010952 RID: 67922
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010953 RID: 67923
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008F16 RID: 36630
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ToggleDebug_FunctionParams
		{
			// Token: 0x0402CC45 RID: 183365
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x02008F17 RID: 36631
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetPair_FunctionParams
		{
			// Token: 0x0402CC46 RID: 183366
			[FieldOffset(0)]
			public IntPtr Target;
		}

		// Token: 0x02008F18 RID: 36632
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __GetPortalTrans_FunctionParams
		{
			// Token: 0x0402CC47 RID: 183367
			[FieldOffset(0)]
			public FTransformDouble NewParam;
		}

		// Token: 0x02008F19 RID: 36633
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPbDataId_FunctionParams
		{
			// Token: 0x0402CC48 RID: 183368
			[FieldOffset(0)]
			public int PbdataId;
		}

		// Token: 0x02008F1A RID: 36634
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetPair_FunctionParams
		{
			// Token: 0x0402CC49 RID: 183369
			[FieldOffset(0)]
			public IntPtr Pair;
		}

		// Token: 0x02008F1B RID: 36635
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3120)]
		protected ref struct __Teleport_FunctionParams
		{
			// Token: 0x0402CC4A RID: 183370
			[FieldOffset(0)]
			public FTransformDouble InTrans;

			// Token: 0x0402CC4B RID: 183371
			[FieldOffset(64)]
			public IntPtr InActor;

			// Token: 0x0402CC4C RID: 183372
			[FieldOffset(72)]
			public bool IsRole;
		}

		// Token: 0x02008F1C RID: 36636
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CC4D RID: 183373
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
