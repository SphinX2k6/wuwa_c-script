using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.YangYangBirds
{
	// Token: 0x02003A77 RID: 14967
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/YangYangBirds/BP_YangYangBirds.BP_YangYangBirds_C")]
	[UnrealStructLayout(1440, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1440)]
	public class BP_YangYangBirds_C : AKuroYangYangBirds, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FB23 RID: 129827 RVA: 0x008BFFA2 File Offset: 0x008BE1A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_YangYangBirds_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/YangYangBirds/BP_YangYangBirds.BP_YangYangBirds_C");
			}
			return BP_YangYangBirds_C._ClassPtr;
		}

		// Token: 0x0601FB24 RID: 129828 RVA: 0x008BFFC8 File Offset: 0x008BE1C8
		public BP_YangYangBirds_C() : this(BuiltinUtils.AllocNativeUObject(BP_YangYangBirds_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FB25 RID: 129829 RVA: 0x008BFFF0 File Offset: 0x008BE1F0
		[NullableContext(1)]
		public BP_YangYangBirds_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_YangYangBirds_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C72 RID: 11378
		// (get) Token: 0x0601FB26 RID: 129830 RVA: 0x008C0023 File Offset: 0x008BE223
		// (set) Token: 0x0601FB27 RID: 129831 RVA: 0x008C0033 File Offset: 0x008BE233
		public unsafe float CharFrightenStrengthMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17002C73 RID: 11379
		// (get) Token: 0x0601FB28 RID: 129832 RVA: 0x008C0044 File Offset: 0x008BE244
		// (set) Token: 0x0601FB29 RID: 129833 RVA: 0x008C0054 File Offset: 0x008BE254
		public unsafe float FrightenRadiusFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002C74 RID: 11380
		// (get) Token: 0x0601FB2A RID: 129834 RVA: 0x008C0065 File Offset: 0x008BE265
		// (set) Token: 0x0601FB2B RID: 129835 RVA: 0x008C0075 File Offset: 0x008BE275
		public unsafe float CharFrightenStrengthFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x0601FB2C RID: 129836 RVA: 0x008C0086 File Offset: 0x008BE286
		// (set) Token: 0x0601FB2D RID: 129837 RVA: 0x008C0096 File Offset: 0x008BE296
		public unsafe bool PendingDisappear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x0601FB2E RID: 129838 RVA: 0x008C00A8 File Offset: 0x008BE2A8
		// (set) Token: 0x0601FB2F RID: 129839 RVA: 0x008C00E1 File Offset: 0x008BE2E1
		[Nullable(1)]
		public TMap<int, SYYBirdWeaponItem> WeaponItems
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<int, SYYBirdWeaponItem> result;
				if ((result = this._WeaponItems) == null)
				{
					result = (this._WeaponItems = new TMap<int, SYYBirdWeaponItem>(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.WeaponItems.CopyAssign(value);
			}
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x0601FB30 RID: 129840 RVA: 0x008C00EF File Offset: 0x008BE2EF
		// (set) Token: 0x0601FB31 RID: 129841 RVA: 0x008C0103 File Offset: 0x008BE303
		public unsafe FVector4 WeaponImpactionRangeMap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x0601FB32 RID: 129842 RVA: 0x008C0118 File Offset: 0x008BE318
		// (set) Token: 0x0601FB33 RID: 129843 RVA: 0x008C0128 File Offset: 0x008BE328
		public unsafe float FadeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x0601FB34 RID: 129844 RVA: 0x008C0139 File Offset: 0x008BE339
		// (set) Token: 0x0601FB35 RID: 129845 RVA: 0x008C014D File Offset: 0x008BE34D
		public unsafe FVectorDouble LastActorLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x0601FB36 RID: 129846 RVA: 0x008C0162 File Offset: 0x008BE362
		// (set) Token: 0x0601FB37 RID: 129847 RVA: 0x008C0172 File Offset: 0x008BE372
		public unsafe float LastActorTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x0601FB38 RID: 129848 RVA: 0x008C0183 File Offset: 0x008BE383
		// (set) Token: 0x0601FB39 RID: 129849 RVA: 0x008C0197 File Offset: 0x008BE397
		[Nullable(2)]
		public unsafe USceneComponent FollowComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_YangYangBirds_C.__PropertyOffset_10);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_YangYangBirds_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x0601FB3A RID: 129850 RVA: 0x008C01AC File Offset: 0x008BE3AC
		// (set) Token: 0x0601FB3B RID: 129851 RVA: 0x008C01E5 File Offset: 0x008BE3E5
		[Nullable(1)]
		public FKuroYangYangBirdsFrightenPoint DebugFrightenInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroYangYangBirdsFrightenPoint result;
				if ((result = this._DebugFrightenInfo) == null)
				{
					result = (this._DebugFrightenInfo = new FKuroYangYangBirdsFrightenPoint(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroYangYangBirdsFrightenPoint.StaticStruct(), base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_11, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x0601FB3C RID: 129852 RVA: 0x008C0206 File Offset: 0x008BE406
		// (set) Token: 0x0601FB3D RID: 129853 RVA: 0x008C0216 File Offset: 0x008BE416
		public unsafe bool Failed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YangYangBirds_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C7E RID: 11390
		// (get) Token: 0x0601FB3E RID: 129854 RVA: 0x008C0227 File Offset: 0x008BE427
		// (set) Token: 0x0601FB3F RID: 129855 RVA: 0x008C023B File Offset: 0x008BE43B
		[Nullable(2)]
		public unsafe UStaticMesh staticmesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_YangYangBirds_C.__PropertyOffset_13);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_YangYangBirds_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x0601FB40 RID: 129856 RVA: 0x008C0250 File Offset: 0x008BE450
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool ShouldDisappear()
		{
			BP_YangYangBirds_C.__ShouldDisappear_FunctionParams* ptr = stackalloc BP_YangYangBirds_C.__ShouldDisappear_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_YangYangBirds_C.__ShouldDisappear_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirds_C.__ShouldDisappear_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__ShouldDisappear_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601FB41 RID: 129857 RVA: 0x008C0298 File Offset: 0x008BE498
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override bool ShouldDisappear_Implementation()
		{
			BP_YangYangBirds_C.__ShouldDisappear_FunctionParams* ptr = stackalloc BP_YangYangBirds_C.__ShouldDisappear_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_YangYangBirds_C.__ShouldDisappear_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirds_C.__ShouldDisappear_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YangYangBirds_C.__ShouldDisappear_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601FB42 RID: 129858 RVA: 0x008C02DE File Offset: 0x008BE4DE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void MarkPendingDisappear()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__MarkPendingDisappear_NativeFunctionPtr, null);
		}

		// Token: 0x0601FB43 RID: 129859 RVA: 0x008C02F2 File Offset: 0x008BE4F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DebugFrighten()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__DebugFrighten_NativeFunctionPtr, null);
		}

		// Token: 0x0601FB44 RID: 129860 RVA: 0x008C0308 File Offset: 0x008BE508
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateFrighten(float DeltaTime)
		{
			BP_YangYangBirds_C.__UpdateFrighten_FunctionParams* ptr = stackalloc BP_YangYangBirds_C.__UpdateFrighten_FunctionParams[(UIntPtr)311] + 15L / (long)sizeof(BP_YangYangBirds_C.__UpdateFrighten_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirds_C.__UpdateFrighten_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__UpdateFrighten_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FB45 RID: 129861 RVA: 0x008C0354 File Offset: 0x008BE554
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool ShouldTakeOff()
		{
			BP_YangYangBirds_C.__ShouldTakeOff_FunctionParams* ptr = stackalloc BP_YangYangBirds_C.__ShouldTakeOff_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(BP_YangYangBirds_C.__ShouldTakeOff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirds_C.__ShouldTakeOff_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__ShouldTakeOff_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601FB46 RID: 129862 RVA: 0x008C039C File Offset: 0x008BE59C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override bool ShouldTakeOff_Implementation()
		{
			BP_YangYangBirds_C.__ShouldTakeOff_FunctionParams* ptr = stackalloc BP_YangYangBirds_C.__ShouldTakeOff_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(BP_YangYangBirds_C.__ShouldTakeOff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirds_C.__ShouldTakeOff_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YangYangBirds_C.__ShouldTakeOff_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601FB47 RID: 129863 RVA: 0x008C03E4 File Offset: 0x008BE5E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool ShouldLand()
		{
			BP_YangYangBirds_C.__ShouldLand_FunctionParams* ptr = stackalloc BP_YangYangBirds_C.__ShouldLand_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_YangYangBirds_C.__ShouldLand_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirds_C.__ShouldLand_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__ShouldLand_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601FB48 RID: 129864 RVA: 0x008C042C File Offset: 0x008BE62C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override bool ShouldLand_Implementation()
		{
			BP_YangYangBirds_C.__ShouldLand_FunctionParams* ptr = stackalloc BP_YangYangBirds_C.__ShouldLand_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_YangYangBirds_C.__ShouldLand_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirds_C.__ShouldLand_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YangYangBirds_C.__ShouldLand_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601FB49 RID: 129865 RVA: 0x008C0474 File Offset: 0x008BE674
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool ShouldAppear()
		{
			BP_YangYangBirds_C.__ShouldAppear_FunctionParams* ptr = stackalloc BP_YangYangBirds_C.__ShouldAppear_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_YangYangBirds_C.__ShouldAppear_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirds_C.__ShouldAppear_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__ShouldAppear_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601FB4A RID: 129866 RVA: 0x008C04BC File Offset: 0x008BE6BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override bool ShouldAppear_Implementation()
		{
			BP_YangYangBirds_C.__ShouldAppear_FunctionParams* ptr = stackalloc BP_YangYangBirds_C.__ShouldAppear_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_YangYangBirds_C.__ShouldAppear_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirds_C.__ShouldAppear_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YangYangBirds_C.__ShouldAppear_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601FB4B RID: 129867 RVA: 0x008C0502 File Offset: 0x008BE702
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UpdateInterestPointGround()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__UpdateInterestPointGround_NativeFunctionPtr, null);
		}

		// Token: 0x0601FB4C RID: 129868 RVA: 0x008C0516 File Offset: 0x008BE716
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UpdateInterestPointGround_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YangYangBirds_C.__UpdateInterestPointGround_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FB4D RID: 129869 RVA: 0x008C052B File Offset: 0x008BE72B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UpdateInterestPointAir()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__UpdateInterestPointAir_NativeFunctionPtr, null);
		}

		// Token: 0x0601FB4E RID: 129870 RVA: 0x008C053F File Offset: 0x008BE73F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UpdateInterestPointAir_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YangYangBirds_C.__UpdateInterestPointAir_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FB4F RID: 129871 RVA: 0x008C0554 File Offset: 0x008BE754
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_YangYangBirds_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_YangYangBirds_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_YangYangBirds_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FB50 RID: 129872 RVA: 0x008C059C File Offset: 0x008BE79C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_YangYangBirds_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_YangYangBirds_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_YangYangBirds_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YangYangBirds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FB51 RID: 129873 RVA: 0x008C05E3 File Offset: 0x008BE7E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FB52 RID: 129874 RVA: 0x008C05F7 File Offset: 0x008BE7F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YangYangBirds_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FB53 RID: 129875 RVA: 0x008C060C File Offset: 0x008BE80C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CustomEvent(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_YangYangBirds_C.__CustomEvent_FunctionParams* ptr = stackalloc BP_YangYangBirds_C.__CustomEvent_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_YangYangBirds_C.__CustomEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirds_C.__CustomEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__CustomEvent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FB54 RID: 129876 RVA: 0x008C0670 File Offset: 0x008BE870
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveBirdsFail(EYangYangBirdsTendency FailedTendency)
		{
			BP_YangYangBirds_C.__ReceiveBirdsFail_FunctionParams* ptr = stackalloc BP_YangYangBirds_C.__ReceiveBirdsFail_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_YangYangBirds_C.__ReceiveBirdsFail_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirds_C.__ReceiveBirdsFail_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FailedTendency = FailedTendency;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__ReceiveBirdsFail_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FB55 RID: 129877 RVA: 0x008C06B8 File Offset: 0x008BE8B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveBirdsFail_Implementation(EYangYangBirdsTendency FailedTendency)
		{
			BP_YangYangBirds_C.__ReceiveBirdsFail_FunctionParams* ptr = stackalloc BP_YangYangBirds_C.__ReceiveBirdsFail_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_YangYangBirds_C.__ReceiveBirdsFail_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_YangYangBirds_C.__ReceiveBirdsFail_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FailedTendency = FailedTendency;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YangYangBirds_C.__ReceiveBirdsFail_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FB56 RID: 129878 RVA: 0x008C06FF File Offset: 0x008BE8FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBirdsDisappear()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__ReceiveBirdsDisappear_NativeFunctionPtr, null);
		}

		// Token: 0x0601FB57 RID: 129879 RVA: 0x008C0713 File Offset: 0x008BE913
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBirdsDisappear_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YangYangBirds_C.__ReceiveBirdsDisappear_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FB58 RID: 129880 RVA: 0x008C0728 File Offset: 0x008BE928
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBirdsAppear()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangYangBirds_C.__ReceiveBirdsAppear_NativeFunctionPtr, null);
		}

		// Token: 0x0601FB59 RID: 129881 RVA: 0x008C073C File Offset: 0x008BE93C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBirdsAppear_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YangYangBirds_C.__ReceiveBirdsAppear_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FB5A RID: 129882 RVA: 0x008C0751 File Offset: 0x008BE951
		protected BP_YangYangBirds_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F437 RID: 62519
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/YangYangBirds/BP_YangYangBirds.BP_YangYangBirds_C";

		// Token: 0x0400F438 RID: 62520
		private static IntPtr _ClassPtr;

		// Token: 0x0400F439 RID: 62521
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F43A RID: 62522
		internal static int __PropertyOffset_1;

		// Token: 0x0400F43B RID: 62523
		internal static int __PropertyOffset_2;

		// Token: 0x0400F43C RID: 62524
		internal static int __PropertyOffset_3;

		// Token: 0x0400F43D RID: 62525
		internal static int __PropertyOffset_4;

		// Token: 0x0400F43E RID: 62526
		internal static int __PropertyOffset_5;

		// Token: 0x0400F43F RID: 62527
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, SYYBirdWeaponItem> _WeaponItems;

		// Token: 0x0400F440 RID: 62528
		internal static int __PropertyOffset_6;

		// Token: 0x0400F441 RID: 62529
		internal static int __PropertyOffset_7;

		// Token: 0x0400F442 RID: 62530
		internal static int __PropertyOffset_8;

		// Token: 0x0400F443 RID: 62531
		internal static int __PropertyOffset_9;

		// Token: 0x0400F444 RID: 62532
		internal static int __PropertyOffset_10;

		// Token: 0x0400F445 RID: 62533
		internal static int __PropertyOffset_11;

		// Token: 0x0400F446 RID: 62534
		[Nullable(2)]
		private FKuroYangYangBirdsFrightenPoint _DebugFrightenInfo;

		// Token: 0x0400F447 RID: 62535
		internal static int __PropertyOffset_12;

		// Token: 0x0400F448 RID: 62536
		internal static int __PropertyOffset_13;

		// Token: 0x0400F449 RID: 62537
		private static IntPtr __ShouldDisappear_NativeFunctionPtr;

		// Token: 0x0400F44A RID: 62538
		private static IntPtr __MarkPendingDisappear_NativeFunctionPtr;

		// Token: 0x0400F44B RID: 62539
		private static IntPtr __DebugFrighten_NativeFunctionPtr;

		// Token: 0x0400F44C RID: 62540
		private static IntPtr __UpdateFrighten_NativeFunctionPtr;

		// Token: 0x0400F44D RID: 62541
		private static IntPtr __ShouldTakeOff_NativeFunctionPtr;

		// Token: 0x0400F44E RID: 62542
		private static IntPtr __ShouldLand_NativeFunctionPtr;

		// Token: 0x0400F44F RID: 62543
		private static IntPtr __ShouldAppear_NativeFunctionPtr;

		// Token: 0x0400F450 RID: 62544
		private static IntPtr __UpdateInterestPointGround_NativeFunctionPtr;

		// Token: 0x0400F451 RID: 62545
		private static IntPtr __UpdateInterestPointAir_NativeFunctionPtr;

		// Token: 0x0400F452 RID: 62546
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F453 RID: 62547
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F454 RID: 62548
		private static IntPtr __CustomEvent_NativeFunctionPtr;

		// Token: 0x0400F455 RID: 62549
		private static IntPtr __ReceiveBirdsFail_NativeFunctionPtr;

		// Token: 0x0400F456 RID: 62550
		private static IntPtr __ReceiveBirdsDisappear_NativeFunctionPtr;

		// Token: 0x0400F457 RID: 62551
		private static IntPtr __ReceiveBirdsAppear_NativeFunctionPtr;

		// Token: 0x02009B39 RID: 39737
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ShouldDisappear_FunctionParams
		{
			// Token: 0x0403114C RID: 201036
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02009B3A RID: 39738
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 296)]
		protected ref struct __UpdateFrighten_FunctionParams
		{
			// Token: 0x0403114D RID: 201037
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02009B3B RID: 39739
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected new ref struct __ShouldTakeOff_FunctionParams
		{
			// Token: 0x0403114E RID: 201038
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02009B3C RID: 39740
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ShouldLand_FunctionParams
		{
			// Token: 0x0403114F RID: 201039
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02009B3D RID: 39741
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected new ref struct __ShouldAppear_FunctionParams
		{
			// Token: 0x04031150 RID: 201040
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02009B3E RID: 39742
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031151 RID: 201041
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009B3F RID: 39743
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CustomEvent_FunctionParams
		{
			// Token: 0x04031152 RID: 201042
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031153 RID: 201043
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031154 RID: 201044
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009B40 RID: 39744
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveBirdsFail_FunctionParams
		{
			// Token: 0x04031155 RID: 201045
			[FieldOffset(0)]
			public EYangYangBirdsTendency FailedTendency;
		}
	}
}
