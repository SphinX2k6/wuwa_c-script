using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B91 RID: 15249
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollShowCaseActor.BP_DollShowCaseActor_C")]
	[UnrealStructLayout(1616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class BP_DollShowCaseActor_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F24 RID: 139044 RVA: 0x008FA421 File Offset: 0x008F8621
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollShowCaseActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollShowCaseActor.BP_DollShowCaseActor_C");
			}
			return BP_DollShowCaseActor_C._ClassPtr;
		}

		// Token: 0x06021F25 RID: 139045 RVA: 0x008FA448 File Offset: 0x008F8648
		public BP_DollShowCaseActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollShowCaseActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F26 RID: 139046 RVA: 0x008FA470 File Offset: 0x008F8670
		[NullableContext(1)]
		public BP_DollShowCaseActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollShowCaseActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003919 RID: 14617
		// (get) Token: 0x06021F27 RID: 139047 RVA: 0x008FA4A3 File Offset: 0x008F86A3
		// (set) Token: 0x06021F28 RID: 139048 RVA: 0x008FA4B7 File Offset: 0x008F86B7
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollShowCaseActor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollShowCaseActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700391A RID: 14618
		// (get) Token: 0x06021F29 RID: 139049 RVA: 0x008FA4CC File Offset: 0x008F86CC
		// (set) Token: 0x06021F2A RID: 139050 RVA: 0x008FA4E0 File Offset: 0x008F86E0
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollShowCaseActor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollShowCaseActor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700391B RID: 14619
		// (get) Token: 0x06021F2B RID: 139051 RVA: 0x008FA4F5 File Offset: 0x008F86F5
		// (set) Token: 0x06021F2C RID: 139052 RVA: 0x008FA509 File Offset: 0x008F8709
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollShowCaseActor_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollShowCaseActor_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700391C RID: 14620
		// (get) Token: 0x06021F2D RID: 139053 RVA: 0x008FA51E File Offset: 0x008F871E
		// (set) Token: 0x06021F2E RID: 139054 RVA: 0x008FA52E File Offset: 0x008F872E
		public unsafe int DollElementId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700391D RID: 14621
		// (get) Token: 0x06021F2F RID: 139055 RVA: 0x008FA540 File Offset: 0x008F8740
		// (set) Token: 0x06021F30 RID: 139056 RVA: 0x008FA579 File Offset: 0x008F8779
		[Nullable(1)]
		public TMap<int, USkeletalMeshComponent> SkeletalMeshMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<int, USkeletalMeshComponent> result;
				if ((result = this._SkeletalMeshMap) == null)
				{
					result = (this._SkeletalMeshMap = new TMap<int, USkeletalMeshComponent>(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SkeletalMeshMap.CopyAssign(value);
			}
		}

		// Token: 0x1700391E RID: 14622
		// (get) Token: 0x06021F31 RID: 139057 RVA: 0x008FA587 File Offset: 0x008F8787
		// (set) Token: 0x06021F32 RID: 139058 RVA: 0x008FA59B File Offset: 0x008F879B
		public unsafe BP_DollGrabLight_C BP_Light
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_DollGrabLight_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollShowCaseActor_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollShowCaseActor_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x06021F33 RID: 139059 RVA: 0x008FA5B0 File Offset: 0x008F87B0
		// (set) Token: 0x06021F34 RID: 139060 RVA: 0x008FA5C0 File Offset: 0x008F87C0
		public unsafe float PlayEffectIntervalTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x06021F35 RID: 139061 RVA: 0x008FA5D1 File Offset: 0x008F87D1
		// (set) Token: 0x06021F36 RID: 139062 RVA: 0x008FA5E1 File Offset: 0x008F87E1
		public unsafe float CompleteEffectDurationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003921 RID: 14625
		// (get) Token: 0x06021F37 RID: 139063 RVA: 0x008FA5F2 File Offset: 0x008F87F2
		// (set) Token: 0x06021F38 RID: 139064 RVA: 0x008FA602 File Offset: 0x008F8802
		public unsafe float SetMaterialDelayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003922 RID: 14626
		// (get) Token: 0x06021F39 RID: 139065 RVA: 0x008FA614 File Offset: 0x008F8814
		// (set) Token: 0x06021F3A RID: 139066 RVA: 0x008FA64D File Offset: 0x008F884D
		[Nullable(1)]
		public TArray<FVectorDouble> EffectOffsetLocationList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._EffectOffsetLocationList) == null)
				{
					result = (this._EffectOffsetLocationList = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.EffectOffsetLocationList.CopyAssign(value);
			}
		}

		// Token: 0x17003923 RID: 14627
		// (get) Token: 0x06021F3B RID: 139067 RVA: 0x008FA65C File Offset: 0x008F885C
		// (set) Token: 0x06021F3C RID: 139068 RVA: 0x008FA695 File Offset: 0x008F8895
		[Nullable(1)]
		public TArray<FVector> PartDollScaleList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PartDollScaleList) == null)
				{
					result = (this._PartDollScaleList = new TArray<FVector>(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PartDollScaleList.CopyAssign(value);
			}
		}

		// Token: 0x06021F3D RID: 139069 RVA: 0x008FA6A4 File Offset: 0x008F88A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SwitchLightState(int ActiveItemIdLength, bool IsComplete)
		{
			BP_DollShowCaseActor_C.__SwitchLightState_FunctionParams* ptr = stackalloc BP_DollShowCaseActor_C.__SwitchLightState_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_DollShowCaseActor_C.__SwitchLightState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollShowCaseActor_C.__SwitchLightState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ActiveItemIdLength = ActiveItemIdLength;
			ptr->IsComplete = IsComplete;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollShowCaseActor_C.__SwitchLightState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021F3E RID: 139070 RVA: 0x008FA6F1 File Offset: 0x008F88F1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollShowCaseActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021F3F RID: 139071 RVA: 0x008FA705 File Offset: 0x008F8905
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DollShowCaseActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021F40 RID: 139072 RVA: 0x008FA71A File Offset: 0x008F891A
		protected BP_DollShowCaseActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401098D RID: 67981
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollShowCaseActor.BP_DollShowCaseActor_C";

		// Token: 0x0401098E RID: 67982
		private static IntPtr _ClassPtr;

		// Token: 0x0401098F RID: 67983
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010990 RID: 67984
		internal static int __PropertyOffset_1;

		// Token: 0x04010991 RID: 67985
		internal static int __PropertyOffset_2;

		// Token: 0x04010992 RID: 67986
		internal static int __PropertyOffset_3;

		// Token: 0x04010993 RID: 67987
		internal static int __PropertyOffset_4;

		// Token: 0x04010994 RID: 67988
		internal static int __PropertyOffset_5;

		// Token: 0x04010995 RID: 67989
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, USkeletalMeshComponent> _SkeletalMeshMap;

		// Token: 0x04010996 RID: 67990
		internal static int __PropertyOffset_6;

		// Token: 0x04010997 RID: 67991
		internal static int __PropertyOffset_7;

		// Token: 0x04010998 RID: 67992
		internal static int __PropertyOffset_8;

		// Token: 0x04010999 RID: 67993
		internal static int __PropertyOffset_9;

		// Token: 0x0401099A RID: 67994
		internal static int __PropertyOffset_10;

		// Token: 0x0401099B RID: 67995
		private TArray<FVectorDouble> _EffectOffsetLocationList;

		// Token: 0x0401099C RID: 67996
		internal static int __PropertyOffset_11;

		// Token: 0x0401099D RID: 67997
		private TArray<FVector> _PartDollScaleList;

		// Token: 0x0401099E RID: 67998
		private static IntPtr __SwitchLightState_NativeFunctionPtr;

		// Token: 0x0401099F RID: 67999
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009CF6 RID: 40182
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SwitchLightState_FunctionParams
		{
			// Token: 0x040313F7 RID: 201719
			[FieldOffset(0)]
			public int ActiveItemIdLength;

			// Token: 0x040313F8 RID: 201720
			[FieldOffset(4)]
			public bool IsComplete;
		}
	}
}
