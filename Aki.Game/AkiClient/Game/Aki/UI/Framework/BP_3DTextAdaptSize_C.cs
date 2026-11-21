using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Framework
{
	// Token: 0x0200305F RID: 12383
	[UnrealObjectPath("/Game/Aki/UI/Framework/BP_3DTextAdaptSize.BP_3DTextAdaptSize_C")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class BP_3DTextAdaptSize_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D661 RID: 120417 RVA: 0x008F3EC2 File Offset: 0x008F20C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_3DTextAdaptSize_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Framework/BP_3DTextAdaptSize.BP_3DTextAdaptSize_C");
			}
			return BP_3DTextAdaptSize_C._ClassPtr;
		}

		// Token: 0x0601D662 RID: 120418 RVA: 0x008F3EE8 File Offset: 0x008F20E8
		public BP_3DTextAdaptSize_C() : this(BuiltinUtils.AllocNativeUObject(BP_3DTextAdaptSize_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D663 RID: 120419 RVA: 0x008F3F10 File Offset: 0x008F2110
		[NullableContext(1)]
		public BP_3DTextAdaptSize_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_3DTextAdaptSize_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002EB7 RID: 11959
		// (get) Token: 0x0601D664 RID: 120420 RVA: 0x008F3F43 File Offset: 0x008F2143
		// (set) Token: 0x0601D665 RID: 120421 RVA: 0x008F3F57 File Offset: 0x008F2157
		public unsafe FVectorDouble CurrentLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_CurrentLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_CurrentLocation) = value;
			}
		}

		// Token: 0x17002EB8 RID: 11960
		// (get) Token: 0x0601D666 RID: 120422 RVA: 0x008F3F6C File Offset: 0x008F216C
		// (set) Token: 0x0601D667 RID: 120423 RVA: 0x008F3F80 File Offset: 0x008F2180
		[Nullable(2)]
		public unsafe UUIText UIText
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIText>(base.NativePtr / (IntPtr)sizeof(void*) + BP_3DTextAdaptSize_C.__PropertyOffset_UIText);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_3DTextAdaptSize_C.__PropertyOffset_UIText, value);
			}
		}

		// Token: 0x17002EB9 RID: 11961
		// (get) Token: 0x0601D668 RID: 120424 RVA: 0x008F3F95 File Offset: 0x008F2195
		// (set) Token: 0x0601D669 RID: 120425 RVA: 0x008F3FA5 File Offset: 0x008F21A5
		public unsafe double TargetDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_TargetDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_TargetDistance) = value;
			}
		}

		// Token: 0x17002EBA RID: 11962
		// (get) Token: 0x0601D66A RID: 120426 RVA: 0x008F3FB6 File Offset: 0x008F21B6
		// (set) Token: 0x0601D66B RID: 120427 RVA: 0x008F3FC6 File Offset: 0x008F21C6
		public unsafe float OriginalSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_OriginalSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_OriginalSize) = value;
			}
		}

		// Token: 0x17002EBB RID: 11963
		// (get) Token: 0x0601D66C RID: 120428 RVA: 0x008F3FD7 File Offset: 0x008F21D7
		// (set) Token: 0x0601D66D RID: 120429 RVA: 0x008F3FE7 File Offset: 0x008F21E7
		public unsafe bool bSetOriginRealSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_bSetOriginRealSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_bSetOriginRealSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EBC RID: 11964
		// (get) Token: 0x0601D66E RID: 120430 RVA: 0x008F3FF8 File Offset: 0x008F21F8
		// (set) Token: 0x0601D66F RID: 120431 RVA: 0x008F400C File Offset: 0x008F220C
		public unsafe FVector2D OriginalRealSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_OriginalRealSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_OriginalRealSize) = value;
			}
		}

		// Token: 0x17002EBD RID: 11965
		// (get) Token: 0x0601D670 RID: 120432 RVA: 0x008F4021 File Offset: 0x008F2221
		// (set) Token: 0x0601D671 RID: 120433 RVA: 0x008F4031 File Offset: 0x008F2231
		public unsafe bool AdaptEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_AdaptEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_AdaptEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EBE RID: 11966
		// (get) Token: 0x0601D672 RID: 120434 RVA: 0x008F4042 File Offset: 0x008F2242
		// (set) Token: 0x0601D673 RID: 120435 RVA: 0x008F4052 File Offset: 0x008F2252
		public unsafe bool Vertical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_Vertical) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_Vertical) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EBF RID: 11967
		// (get) Token: 0x0601D674 RID: 120436 RVA: 0x008F4063 File Offset: 0x008F2263
		// (set) Token: 0x0601D675 RID: 120437 RVA: 0x008F4073 File Offset: 0x008F2273
		public unsafe float FontSizeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_FontSizeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_FontSizeMax) = value;
			}
		}

		// Token: 0x0601D676 RID: 120438 RVA: 0x008F4084 File Offset: 0x008F2284
		[SkipLocalsInit]
		public unsafe virtual void GetAppropriateScale(ref float Result)
		{
			BP_3DTextAdaptSize_C.__GetAppropriateScale_FunctionParams* ptr = stackalloc BP_3DTextAdaptSize_C.__GetAppropriateScale_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_3DTextAdaptSize_C.__GetAppropriateScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_3DTextAdaptSize_C.__GetAppropriateScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__GetAppropriateScale_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0601D677 RID: 120439 RVA: 0x008F40D4 File Offset: 0x008F22D4
		[SkipLocalsInit]
		public unsafe virtual void AdjustTextSize(float ToAdjustSize)
		{
			BP_3DTextAdaptSize_C.__AdjustTextSize_FunctionParams* ptr = stackalloc BP_3DTextAdaptSize_C.__AdjustTextSize_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(BP_3DTextAdaptSize_C.__AdjustTextSize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_3DTextAdaptSize_C.__AdjustTextSize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ToAdjustSize = ToAdjustSize;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__AdjustTextSize_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D678 RID: 120440 RVA: 0x008F411C File Offset: 0x008F231C
		[SkipLocalsInit]
		public unsafe virtual void CalculateTargetDistance(float FontSize, ref double TargetDistance)
		{
			BP_3DTextAdaptSize_C.__CalculateTargetDistance_FunctionParams* ptr = stackalloc BP_3DTextAdaptSize_C.__CalculateTargetDistance_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_3DTextAdaptSize_C.__CalculateTargetDistance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_3DTextAdaptSize_C.__CalculateTargetDistance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FontSize = FontSize;
			ptr->TargetDistance = TargetDistance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__CalculateTargetDistance_NativeFunctionPtr, (void*)ptr);
			TargetDistance = ptr->TargetDistance;
		}

		// Token: 0x0601D679 RID: 120441 RVA: 0x008F4174 File Offset: 0x008F2374
		[SkipLocalsInit]
		public unsafe virtual void CalculatePower(float FontSize, ref float Power)
		{
			BP_3DTextAdaptSize_C.__CalculatePower_FunctionParams* ptr = stackalloc BP_3DTextAdaptSize_C.__CalculatePower_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_3DTextAdaptSize_C.__CalculatePower_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_3DTextAdaptSize_C.__CalculatePower_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FontSize = FontSize;
			ptr->Power = Power;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__CalculatePower_NativeFunctionPtr, (void*)ptr);
			Power = ptr->Power;
		}

		// Token: 0x0601D67A RID: 120442 RVA: 0x008F41CA File Offset: 0x008F23CA
		[SkipLocalsInit]
		public virtual void RefreshOriginalInfo()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__RefreshOriginalInfo_NativeFunctionPtr, null);
		}

		// Token: 0x0601D67B RID: 120443 RVA: 0x008F41DE File Offset: 0x008F23DE
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601D67C RID: 120444 RVA: 0x008F41F2 File Offset: 0x008F23F2
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601D67D RID: 120445 RVA: 0x008F4208 File Offset: 0x008F2408
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_3DTextAdaptSize_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_3DTextAdaptSize_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_3DTextAdaptSize_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_3DTextAdaptSize_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D67E RID: 120446 RVA: 0x008F4250 File Offset: 0x008F2450
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_3DTextAdaptSize_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_3DTextAdaptSize_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_3DTextAdaptSize_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_3DTextAdaptSize_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D67F RID: 120447 RVA: 0x008F4296 File Offset: 0x008F2496
		protected BP_3DTextAdaptSize_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F77A RID: 63354
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Framework/BP_3DTextAdaptSize.BP_3DTextAdaptSize_C";

		// Token: 0x0400F77B RID: 63355
		private static IntPtr _ClassPtr;

		// Token: 0x0400F77C RID: 63356
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F77D RID: 63357
		internal static int __PropertyOffset_CurrentLocation;

		// Token: 0x0400F77E RID: 63358
		internal static int __PropertyOffset_UIText;

		// Token: 0x0400F77F RID: 63359
		internal static int __PropertyOffset_TargetDistance;

		// Token: 0x0400F780 RID: 63360
		internal static int __PropertyOffset_OriginalSize;

		// Token: 0x0400F781 RID: 63361
		internal static int __PropertyOffset_bSetOriginRealSize;

		// Token: 0x0400F782 RID: 63362
		internal static int __PropertyOffset_OriginalRealSize;

		// Token: 0x0400F783 RID: 63363
		internal static int __PropertyOffset_AdaptEnabled;

		// Token: 0x0400F784 RID: 63364
		internal static int __PropertyOffset_Vertical;

		// Token: 0x0400F785 RID: 63365
		internal static int __PropertyOffset_FontSizeMax;

		// Token: 0x0400F786 RID: 63366
		private static IntPtr __GetAppropriateScale_NativeFunctionPtr;

		// Token: 0x0400F787 RID: 63367
		private static IntPtr __AdjustTextSize_NativeFunctionPtr;

		// Token: 0x0400F788 RID: 63368
		private static IntPtr __CalculateTargetDistance_NativeFunctionPtr;

		// Token: 0x0400F789 RID: 63369
		private static IntPtr __CalculatePower_NativeFunctionPtr;

		// Token: 0x0400F78A RID: 63370
		private static IntPtr __RefreshOriginalInfo_NativeFunctionPtr;

		// Token: 0x0400F78B RID: 63371
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F78C RID: 63372
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008CCF RID: 36047
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetAppropriateScale_FunctionParams
		{
			// Token: 0x0402C7E5 RID: 182245
			[FieldOffset(0)]
			public float Result;
		}

		// Token: 0x02008CD0 RID: 36048
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __AdjustTextSize_FunctionParams
		{
			// Token: 0x0402C7E6 RID: 182246
			[FieldOffset(0)]
			public float ToAdjustSize;
		}

		// Token: 0x02008CD1 RID: 36049
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CalculateTargetDistance_FunctionParams
		{
			// Token: 0x0402C7E7 RID: 182247
			[FieldOffset(0)]
			public float FontSize;

			// Token: 0x0402C7E8 RID: 182248
			[FieldOffset(8)]
			public double TargetDistance;
		}

		// Token: 0x02008CD2 RID: 36050
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CalculatePower_FunctionParams
		{
			// Token: 0x0402C7E9 RID: 182249
			[FieldOffset(0)]
			public float FontSize;

			// Token: 0x0402C7EA RID: 182250
			[FieldOffset(4)]
			public float Power;
		}

		// Token: 0x02008CD3 RID: 36051
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C7EB RID: 182251
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
