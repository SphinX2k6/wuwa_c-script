using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x020030CF RID: 12495
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollShowCaseActor.BP_DollShowCaseActor_C")]
	[UnrealStructLayout(1616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class BP_DollShowCaseActor_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E13A RID: 123194 RVA: 0x0090A594 File Offset: 0x00908794
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollShowCaseActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollShowCaseActor.BP_DollShowCaseActor_C");
			}
			return BP_DollShowCaseActor_C._ClassPtr;
		}

		// Token: 0x0601E13B RID: 123195 RVA: 0x0090A5B8 File Offset: 0x009087B8
		public BP_DollShowCaseActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollShowCaseActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E13C RID: 123196 RVA: 0x0090A5E0 File Offset: 0x009087E0
		public BP_DollShowCaseActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollShowCaseActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x0601E13D RID: 123197 RVA: 0x0090A613 File Offset: 0x00908813
		// (set) Token: 0x0601E13E RID: 123198 RVA: 0x0090A627 File Offset: 0x00908827
		[Nullable(2)]
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollShowCaseActor_C.__PropertyOffset_SkeletalMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollShowCaseActor_C.__PropertyOffset_SkeletalMesh, value);
			}
		}

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x0601E13F RID: 123199 RVA: 0x0090A63C File Offset: 0x0090883C
		// (set) Token: 0x0601E140 RID: 123200 RVA: 0x0090A650 File Offset: 0x00908850
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollShowCaseActor_C.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollShowCaseActor_C.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x0601E141 RID: 123201 RVA: 0x0090A665 File Offset: 0x00908865
		// (set) Token: 0x0601E142 RID: 123202 RVA: 0x0090A679 File Offset: 0x00908879
		[Nullable(2)]
		public unsafe UPointLightComponent PointLight
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollShowCaseActor_C.__PropertyOffset_PointLight);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollShowCaseActor_C.__PropertyOffset_PointLight, value);
			}
		}

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x0601E143 RID: 123203 RVA: 0x0090A68E File Offset: 0x0090888E
		// (set) Token: 0x0601E144 RID: 123204 RVA: 0x0090A69E File Offset: 0x0090889E
		public unsafe int DollElementId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_DollElementId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_DollElementId) = value;
			}
		}

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x0601E145 RID: 123205 RVA: 0x0090A6B0 File Offset: 0x009088B0
		// (set) Token: 0x0601E146 RID: 123206 RVA: 0x0090A6E9 File Offset: 0x009088E9
		public TMap<int, USkeletalMeshComponent> SkeletalMeshMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, USkeletalMeshComponent> result;
				if ((result = this._SkeletalMeshMap) == null)
				{
					result = (this._SkeletalMeshMap = new TMap<int, USkeletalMeshComponent>(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_SkeletalMeshMap, this));
				}
				return result;
			}
			set
			{
				this.SkeletalMeshMap.CopyAssign(value);
			}
		}

		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x0601E147 RID: 123207 RVA: 0x0090A6F7 File Offset: 0x009088F7
		// (set) Token: 0x0601E148 RID: 123208 RVA: 0x0090A707 File Offset: 0x00908907
		public unsafe float PlayEffectIntervalTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_PlayEffectIntervalTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_PlayEffectIntervalTime) = value;
			}
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x0601E149 RID: 123209 RVA: 0x0090A718 File Offset: 0x00908918
		// (set) Token: 0x0601E14A RID: 123210 RVA: 0x0090A728 File Offset: 0x00908928
		public unsafe float CompleteEffectDurationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_CompleteEffectDurationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_CompleteEffectDurationTime) = value;
			}
		}

		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x0601E14B RID: 123211 RVA: 0x0090A739 File Offset: 0x00908939
		// (set) Token: 0x0601E14C RID: 123212 RVA: 0x0090A749 File Offset: 0x00908949
		public unsafe float SetMaterialDelayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_SetMaterialDelayTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_SetMaterialDelayTime) = value;
			}
		}

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x0601E14D RID: 123213 RVA: 0x0090A75C File Offset: 0x0090895C
		// (set) Token: 0x0601E14E RID: 123214 RVA: 0x0090A795 File Offset: 0x00908995
		public TArray<FVectorDouble> EffectOffsetLocationList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._EffectOffsetLocationList) == null)
				{
					result = (this._EffectOffsetLocationList = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_EffectOffsetLocationList, this));
				}
				return result;
			}
			set
			{
				this.EffectOffsetLocationList.CopyAssign(value);
			}
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x0601E14F RID: 123215 RVA: 0x0090A7A4 File Offset: 0x009089A4
		// (set) Token: 0x0601E150 RID: 123216 RVA: 0x0090A7DD File Offset: 0x009089DD
		public TArray<FVector> PartDollScaleList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PartDollScaleList) == null)
				{
					result = (this._PartDollScaleList = new TArray<FVector>(base.NativePtr + (IntPtr)BP_DollShowCaseActor_C.__PropertyOffset_PartDollScaleList, this));
				}
				return result;
			}
			set
			{
				this.PartDollScaleList.CopyAssign(value);
			}
		}

		// Token: 0x0601E151 RID: 123217 RVA: 0x0090A7EC File Offset: 0x009089EC
		[SkipLocalsInit]
		public unsafe virtual void SwitchLightState(int ActiveItemIdLength, bool IsComplete)
		{
			BP_DollShowCaseActor_C.__SwitchLightState_FunctionParams* ptr = stackalloc BP_DollShowCaseActor_C.__SwitchLightState_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_DollShowCaseActor_C.__SwitchLightState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollShowCaseActor_C.__SwitchLightState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ActiveItemIdLength = ActiveItemIdLength;
			ptr->IsComplete = IsComplete;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollShowCaseActor_C.__SwitchLightState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E152 RID: 123218 RVA: 0x0090A839 File Offset: 0x00908A39
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollShowCaseActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E153 RID: 123219 RVA: 0x0090A84D File Offset: 0x00908A4D
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DollShowCaseActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E154 RID: 123220 RVA: 0x0090A861 File Offset: 0x00908A61
		protected BP_DollShowCaseActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE63 RID: 65123
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollShowCaseActor.BP_DollShowCaseActor_C";

		// Token: 0x0400FE64 RID: 65124
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE65 RID: 65125
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE66 RID: 65126
		internal static int __PropertyOffset_SkeletalMesh;

		// Token: 0x0400FE67 RID: 65127
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400FE68 RID: 65128
		internal static int __PropertyOffset_PointLight;

		// Token: 0x0400FE69 RID: 65129
		internal static int __PropertyOffset_DollElementId;

		// Token: 0x0400FE6A RID: 65130
		internal static int __PropertyOffset_SkeletalMeshMap;

		// Token: 0x0400FE6B RID: 65131
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, USkeletalMeshComponent> _SkeletalMeshMap;

		// Token: 0x0400FE6C RID: 65132
		internal static int __PropertyOffset_PlayEffectIntervalTime;

		// Token: 0x0400FE6D RID: 65133
		internal static int __PropertyOffset_CompleteEffectDurationTime;

		// Token: 0x0400FE6E RID: 65134
		internal static int __PropertyOffset_SetMaterialDelayTime;

		// Token: 0x0400FE6F RID: 65135
		internal static int __PropertyOffset_EffectOffsetLocationList;

		// Token: 0x0400FE70 RID: 65136
		[Nullable(2)]
		private TArray<FVectorDouble> _EffectOffsetLocationList;

		// Token: 0x0400FE71 RID: 65137
		internal static int __PropertyOffset_PartDollScaleList;

		// Token: 0x0400FE72 RID: 65138
		[Nullable(2)]
		private TArray<FVector> _PartDollScaleList;

		// Token: 0x0400FE73 RID: 65139
		private static IntPtr __SwitchLightState_NativeFunctionPtr;

		// Token: 0x0400FE74 RID: 65140
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02008E16 RID: 36374
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SwitchLightState_FunctionParams
		{
			// Token: 0x0402CA54 RID: 182868
			[FieldOffset(0)]
			public int ActiveItemIdLength;

			// Token: 0x0402CA55 RID: 182869
			[FieldOffset(4)]
			public bool IsComplete;
		}
	}
}
