using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence
{
	// Token: 0x02003ADD RID: 15069
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/BP_SequenceMaterialReplacelWithBoneLocationInfo.BP_SequenceMaterialReplacelWithBoneLocationInfo_C")]
	[UnrealStructLayout(1176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1172)]
	public class BP_SequenceMaterialReplacelWithBoneLocationInfo_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060208B1 RID: 133297 RVA: 0x008D5BB1 File Offset: 0x008D3DB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SequenceMaterialReplacelWithBoneLocationInfo_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/BP_SequenceMaterialReplacelWithBoneLocationInfo.BP_SequenceMaterialReplacelWithBoneLocationInfo_C");
			}
			return BP_SequenceMaterialReplacelWithBoneLocationInfo_C._ClassPtr;
		}

		// Token: 0x060208B2 RID: 133298 RVA: 0x008D5BD8 File Offset: 0x008D3DD8
		public BP_SequenceMaterialReplacelWithBoneLocationInfo_C() : this(BuiltinUtils.AllocNativeUObject(BP_SequenceMaterialReplacelWithBoneLocationInfo_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060208B3 RID: 133299 RVA: 0x008D5C00 File Offset: 0x008D3E00
		public BP_SequenceMaterialReplacelWithBoneLocationInfo_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SequenceMaterialReplacelWithBoneLocationInfo_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x060208B4 RID: 133300 RVA: 0x008D5C33 File Offset: 0x008D3E33
		// (set) Token: 0x060208B5 RID: 133301 RVA: 0x008D5C47 File Offset: 0x008D3E47
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x060208B6 RID: 133302 RVA: 0x008D5C5C File Offset: 0x008D3E5C
		// (set) Token: 0x060208B7 RID: 133303 RVA: 0x008D5C70 File Offset: 0x008D3E70
		[Nullable(2)]
		public unsafe AActor Actor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x060208B8 RID: 133304 RVA: 0x008D5C85 File Offset: 0x008D3E85
		// (set) Token: 0x060208B9 RID: 133305 RVA: 0x008D5C99 File Offset: 0x008D3E99
		[Nullable(2)]
		public unsafe UMaterialInterface MaterialToReplace
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x060208BA RID: 133306 RVA: 0x008D5CB0 File Offset: 0x008D3EB0
		// (set) Token: 0x060208BB RID: 133307 RVA: 0x008D5CE9 File Offset: 0x008D3EE9
		public TArray<UMaterialInstanceDynamic> DMIs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._DMIs) == null)
				{
					result = (this._DMIs = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.DMIs.CopyAssign(value);
			}
		}

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x060208BC RID: 133308 RVA: 0x008D5CF8 File Offset: 0x008D3EF8
		// (set) Token: 0x060208BD RID: 133309 RVA: 0x008D5D31 File Offset: 0x008D3F31
		public TArray<FKuroCharMaterialControllerFloatParameter> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCharMaterialControllerFloatParameter> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TArray<FKuroCharMaterialControllerFloatParameter>(base.NativePtr + (IntPtr)BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x060208BE RID: 133310 RVA: 0x008D5D40 File Offset: 0x008D3F40
		// (set) Token: 0x060208BF RID: 133311 RVA: 0x008D5D79 File Offset: 0x008D3F79
		public TArray<FKuroCharMaterialControllerColorParameter> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCharMaterialControllerColorParameter> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TArray<FKuroCharMaterialControllerColorParameter>(base.NativePtr + (IntPtr)BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x060208C0 RID: 133312 RVA: 0x008D5D87 File Offset: 0x008D3F87
		// (set) Token: 0x060208C1 RID: 133313 RVA: 0x008D5D97 File Offset: 0x008D3F97
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x060208C2 RID: 133314 RVA: 0x008D5DA8 File Offset: 0x008D3FA8
		// (set) Token: 0x060208C3 RID: 133315 RVA: 0x008D5DB8 File Offset: 0x008D3FB8
		public unsafe bool IsPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x060208C4 RID: 133316 RVA: 0x008D5DC9 File Offset: 0x008D3FC9
		// (set) Token: 0x060208C5 RID: 133317 RVA: 0x008D5DDD File Offset: 0x008D3FDD
		public unsafe FName ParameterName_Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x060208C6 RID: 133318 RVA: 0x008D5DF2 File Offset: 0x008D3FF2
		// (set) Token: 0x060208C7 RID: 133319 RVA: 0x008D5E06 File Offset: 0x008D4006
		public unsafe FName BoneName_Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x060208C8 RID: 133320 RVA: 0x008D5E1B File Offset: 0x008D401B
		// (set) Token: 0x060208C9 RID: 133321 RVA: 0x008D5E2F File Offset: 0x008D402F
		public unsafe FVector CenterBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x060208CA RID: 133322 RVA: 0x008D5E44 File Offset: 0x008D4044
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x060208CB RID: 133323 RVA: 0x008D5E58 File Offset: 0x008D4058
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsReady(ref bool Result)
		{
			BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__IsReady_FunctionParams* ptr = stackalloc BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__IsReady_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__IsReady_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__IsReady_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__IsReady_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x060208CC RID: 133324 RVA: 0x008D5EA8 File Offset: 0x008D40A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060208CD RID: 133325 RVA: 0x008D5EF0 File Offset: 0x008D40F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceMaterialReplacelWithBoneLocationInfo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060208CE RID: 133326 RVA: 0x008D5F37 File Offset: 0x008D4137
		protected BP_SequenceMaterialReplacelWithBoneLocationInfo_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC53 RID: 64595
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/BP_SequenceMaterialReplacelWithBoneLocationInfo.BP_SequenceMaterialReplacelWithBoneLocationInfo_C";

		// Token: 0x0400FC54 RID: 64596
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC55 RID: 64597
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC56 RID: 64598
		internal static int __PropertyOffset_1;

		// Token: 0x0400FC57 RID: 64599
		internal static int __PropertyOffset_2;

		// Token: 0x0400FC58 RID: 64600
		internal static int __PropertyOffset_3;

		// Token: 0x0400FC59 RID: 64601
		internal static int __PropertyOffset_4;

		// Token: 0x0400FC5A RID: 64602
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _DMIs;

		// Token: 0x0400FC5B RID: 64603
		internal static int __PropertyOffset_5;

		// Token: 0x0400FC5C RID: 64604
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCharMaterialControllerFloatParameter> _FloatParameters;

		// Token: 0x0400FC5D RID: 64605
		internal static int __PropertyOffset_6;

		// Token: 0x0400FC5E RID: 64606
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCharMaterialControllerColorParameter> _ColorParameters;

		// Token: 0x0400FC5F RID: 64607
		internal static int __PropertyOffset_7;

		// Token: 0x0400FC60 RID: 64608
		internal static int __PropertyOffset_8;

		// Token: 0x0400FC61 RID: 64609
		internal static int __PropertyOffset_9;

		// Token: 0x0400FC62 RID: 64610
		internal static int __PropertyOffset_10;

		// Token: 0x0400FC63 RID: 64611
		internal static int __PropertyOffset_11;

		// Token: 0x0400FC64 RID: 64612
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x0400FC65 RID: 64613
		private static IntPtr __IsReady_NativeFunctionPtr;

		// Token: 0x0400FC66 RID: 64614
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009BD7 RID: 39895
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __IsReady_FunctionParams
		{
			// Token: 0x04031269 RID: 201321
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x02009BD8 RID: 39896
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403126A RID: 201322
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
