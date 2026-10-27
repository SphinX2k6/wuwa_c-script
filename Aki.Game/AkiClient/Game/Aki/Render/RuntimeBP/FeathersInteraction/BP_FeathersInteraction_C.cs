using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FeathersInteraction
{
	// Token: 0x02003DB2 RID: 15794
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FeathersInteraction/BP_FeathersInteraction.BP_FeathersInteraction_C")]
	[UnrealStructLayout(1288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1284)]
	public class BP_FeathersInteraction_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602736B RID: 160619 RVA: 0x0098B54C File Offset: 0x0098974C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FeathersInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FeathersInteraction/BP_FeathersInteraction.BP_FeathersInteraction_C");
			}
			return BP_FeathersInteraction_C._ClassPtr;
		}

		// Token: 0x0602736C RID: 160620 RVA: 0x0098B570 File Offset: 0x00989770
		public BP_FeathersInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_FeathersInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602736D RID: 160621 RVA: 0x0098B598 File Offset: 0x00989798
		[NullableContext(1)]
		public BP_FeathersInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FeathersInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170056D6 RID: 22230
		// (get) Token: 0x0602736E RID: 160622 RVA: 0x0098B5CB File Offset: 0x009897CB
		// (set) Token: 0x0602736F RID: 160623 RVA: 0x0098B5DF File Offset: 0x009897DF
		public unsafe UBoxComponent AreaBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FeathersInteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FeathersInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170056D7 RID: 22231
		// (get) Token: 0x06027370 RID: 160624 RVA: 0x0098B5F4 File Offset: 0x009897F4
		// (set) Token: 0x06027371 RID: 160625 RVA: 0x0098B608 File Offset: 0x00989808
		public unsafe UNiagaraComponent NS_FX_FeathersInteraction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FeathersInteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FeathersInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170056D8 RID: 22232
		// (get) Token: 0x06027372 RID: 160626 RVA: 0x0098B61D File Offset: 0x0098981D
		// (set) Token: 0x06027373 RID: 160627 RVA: 0x0098B631 File Offset: 0x00989831
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FeathersInteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FeathersInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170056D9 RID: 22233
		// (get) Token: 0x06027374 RID: 160628 RVA: 0x0098B646 File Offset: 0x00989846
		// (set) Token: 0x06027375 RID: 160629 RVA: 0x0098B65A File Offset: 0x0098985A
		public unsafe FVector FieldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170056DA RID: 22234
		// (get) Token: 0x06027376 RID: 160630 RVA: 0x0098B66F File Offset: 0x0098986F
		// (set) Token: 0x06027377 RID: 160631 RVA: 0x0098B67F File Offset: 0x0098987F
		public unsafe int Resolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170056DB RID: 22235
		// (get) Token: 0x06027378 RID: 160632 RVA: 0x0098B690 File Offset: 0x00989890
		// (set) Token: 0x06027379 RID: 160633 RVA: 0x0098B6A4 File Offset: 0x009898A4
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170056DC RID: 22236
		// (get) Token: 0x0602737A RID: 160634 RVA: 0x0098B6B9 File Offset: 0x009898B9
		// (set) Token: 0x0602737B RID: 160635 RVA: 0x0098B6CD File Offset: 0x009898CD
		public unsafe USkeletalMeshComponent Weapon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FeathersInteraction_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FeathersInteraction_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170056DD RID: 22237
		// (get) Token: 0x0602737C RID: 160636 RVA: 0x0098B6E2 File Offset: 0x009898E2
		// (set) Token: 0x0602737D RID: 160637 RVA: 0x0098B6F6 File Offset: 0x009898F6
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170056DE RID: 22238
		// (get) Token: 0x0602737E RID: 160638 RVA: 0x0098B70B File Offset: 0x0098990B
		// (set) Token: 0x0602737F RID: 160639 RVA: 0x0098B71F File Offset: 0x0098991F
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170056DF RID: 22239
		// (get) Token: 0x06027380 RID: 160640 RVA: 0x0098B734 File Offset: 0x00989934
		// (set) Token: 0x06027381 RID: 160641 RVA: 0x0098B748 File Offset: 0x00989948
		public unsafe FVector WeaponVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170056E0 RID: 22240
		// (get) Token: 0x06027382 RID: 160642 RVA: 0x0098B75D File Offset: 0x0098995D
		// (set) Token: 0x06027383 RID: 160643 RVA: 0x0098B771 File Offset: 0x00989971
		public unsafe UMaterialParameterCollection Global_MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FeathersInteraction_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FeathersInteraction_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170056E1 RID: 22241
		// (get) Token: 0x06027384 RID: 160644 RVA: 0x0098B786 File Offset: 0x00989986
		// (set) Token: 0x06027385 RID: 160645 RVA: 0x0098B796 File Offset: 0x00989996
		public unsafe bool isClear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056E2 RID: 22242
		// (get) Token: 0x06027386 RID: 160646 RVA: 0x0098B7A7 File Offset: 0x009899A7
		// (set) Token: 0x06027387 RID: 160647 RVA: 0x0098B7BB File Offset: 0x009899BB
		public unsafe FLinearColor GlobalWorldPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170056E3 RID: 22243
		// (get) Token: 0x06027388 RID: 160648 RVA: 0x0098B7D0 File Offset: 0x009899D0
		// (set) Token: 0x06027389 RID: 160649 RVA: 0x0098B7E0 File Offset: 0x009899E0
		public unsafe float PlayerSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170056E4 RID: 22244
		// (get) Token: 0x0602738A RID: 160650 RVA: 0x0098B7F1 File Offset: 0x009899F1
		// (set) Token: 0x0602738B RID: 160651 RVA: 0x0098B801 File Offset: 0x00989A01
		public unsafe float WeaponSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170056E5 RID: 22245
		// (get) Token: 0x0602738C RID: 160652 RVA: 0x0098B812 File Offset: 0x00989A12
		// (set) Token: 0x0602738D RID: 160653 RVA: 0x0098B826 File Offset: 0x00989A26
		public unsafe FVector DepthCapturePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170056E6 RID: 22246
		// (get) Token: 0x0602738E RID: 160654 RVA: 0x0098B83B File Offset: 0x00989A3B
		// (set) Token: 0x0602738F RID: 160655 RVA: 0x0098B84F File Offset: 0x00989A4F
		public unsafe UTexture DepthTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FeathersInteraction_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FeathersInteraction_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x170056E7 RID: 22247
		// (get) Token: 0x06027390 RID: 160656 RVA: 0x0098B864 File Offset: 0x00989A64
		// (set) Token: 0x06027391 RID: 160657 RVA: 0x0098B874 File Offset: 0x00989A74
		public unsafe int LeavesIDStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170056E8 RID: 22248
		// (get) Token: 0x06027392 RID: 160658 RVA: 0x0098B885 File Offset: 0x00989A85
		// (set) Token: 0x06027393 RID: 160659 RVA: 0x0098B895 File Offset: 0x00989A95
		public unsafe int LeavesIDEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170056E9 RID: 22249
		// (get) Token: 0x06027394 RID: 160660 RVA: 0x0098B8A6 File Offset: 0x00989AA6
		// (set) Token: 0x06027395 RID: 160661 RVA: 0x0098B8B6 File Offset: 0x00989AB6
		public unsafe int LeavesNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170056EA RID: 22250
		// (get) Token: 0x06027396 RID: 160662 RVA: 0x0098B8C7 File Offset: 0x00989AC7
		// (set) Token: 0x06027397 RID: 160663 RVA: 0x0098B8D7 File Offset: 0x00989AD7
		public unsafe float BoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170056EB RID: 22251
		// (get) Token: 0x06027398 RID: 160664 RVA: 0x0098B8E8 File Offset: 0x00989AE8
		// (set) Token: 0x06027399 RID: 160665 RVA: 0x0098B8F8 File Offset: 0x00989AF8
		public unsafe float LeavesScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170056EC RID: 22252
		// (get) Token: 0x0602739A RID: 160666 RVA: 0x0098B909 File Offset: 0x00989B09
		// (set) Token: 0x0602739B RID: 160667 RVA: 0x0098B919 File Offset: 0x00989B19
		public unsafe int LUTIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170056ED RID: 22253
		// (get) Token: 0x0602739C RID: 160668 RVA: 0x0098B92A File Offset: 0x00989B2A
		// (set) Token: 0x0602739D RID: 160669 RVA: 0x0098B93A File Offset: 0x00989B3A
		public unsafe float LeavesRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170056EE RID: 22254
		// (get) Token: 0x0602739E RID: 160670 RVA: 0x0098B94B File Offset: 0x00989B4B
		// (set) Token: 0x0602739F RID: 160671 RVA: 0x0098B95B File Offset: 0x00989B5B
		public unsafe float LeavesAO
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170056EF RID: 22255
		// (get) Token: 0x060273A0 RID: 160672 RVA: 0x0098B96C File Offset: 0x00989B6C
		// (set) Token: 0x060273A1 RID: 160673 RVA: 0x0098B97C File Offset: 0x00989B7C
		public unsafe float LutProbabilityPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170056F0 RID: 22256
		// (get) Token: 0x060273A2 RID: 160674 RVA: 0x0098B98D File Offset: 0x00989B8D
		// (set) Token: 0x060273A3 RID: 160675 RVA: 0x0098B9A1 File Offset: 0x00989BA1
		public unsafe UTexture LeavesMaskTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FeathersInteraction_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FeathersInteraction_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x170056F1 RID: 22257
		// (get) Token: 0x060273A4 RID: 160676 RVA: 0x0098B9B6 File Offset: 0x00989BB6
		// (set) Token: 0x060273A5 RID: 160677 RVA: 0x0098B9C6 File Offset: 0x00989BC6
		public unsafe bool UseLUT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056F2 RID: 22258
		// (get) Token: 0x060273A6 RID: 160678 RVA: 0x0098B9D7 File Offset: 0x00989BD7
		// (set) Token: 0x060273A7 RID: 160679 RVA: 0x0098B9E7 File Offset: 0x00989BE7
		public unsafe float Transparency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170056F3 RID: 22259
		// (get) Token: 0x060273A8 RID: 160680 RVA: 0x0098B9F8 File Offset: 0x00989BF8
		// (set) Token: 0x060273A9 RID: 160681 RVA: 0x0098BA08 File Offset: 0x00989C08
		public unsafe float GenerationHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x170056F4 RID: 22260
		// (get) Token: 0x060273AA RID: 160682 RVA: 0x0098BA19 File Offset: 0x00989C19
		// (set) Token: 0x060273AB RID: 160683 RVA: 0x0098BA29 File Offset: 0x00989C29
		public unsafe float PercentageInTheAir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170056F5 RID: 22261
		// (get) Token: 0x060273AC RID: 160684 RVA: 0x0098BA3A File Offset: 0x00989C3A
		// (set) Token: 0x060273AD RID: 160685 RVA: 0x0098BA4A File Offset: 0x00989C4A
		public unsafe float StayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FeathersInteraction_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x060273AE RID: 160686 RVA: 0x0098BA5B File Offset: 0x00989C5B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetLeavesParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FeathersInteraction_C.__SetLeavesParameters_NativeFunctionPtr, null);
		}

		// Token: 0x060273AF RID: 160687 RVA: 0x0098BA6F File Offset: 0x00989C6F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FeathersInteraction_C.__Debug_NativeFunctionPtr, null);
		}

		// Token: 0x060273B0 RID: 160688 RVA: 0x0098BA84 File Offset: 0x00989C84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Choose_Available_Point(FVectorDouble CollisionPoint, FVectorDouble WeaponPoint, BP_SceneBattleInteract_C ConfigDA, ref FVectorDouble AvailblePoint)
		{
			BP_FeathersInteraction_C.__Choose_Available_Point_FunctionParams* ptr = stackalloc BP_FeathersInteraction_C.__Choose_Available_Point_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_FeathersInteraction_C.__Choose_Available_Point_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FeathersInteraction_C.__Choose_Available_Point_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CollisionPoint = CollisionPoint;
			ptr->WeaponPoint = WeaponPoint;
			ptr->ConfigDA = ((ConfigDA != null) ? ConfigDA.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FeathersInteraction_C.__Choose_Available_Point_NativeFunctionPtr, (void*)ptr);
			AvailblePoint = ptr->AvailblePoint;
		}

		// Token: 0x060273B1 RID: 160689 RVA: 0x0098BB01 File Offset: 0x00989D01
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void WeaponData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FeathersInteraction_C.__WeaponData_NativeFunctionPtr, null);
		}

		// Token: 0x060273B2 RID: 160690 RVA: 0x0098BB18 File Offset: 0x00989D18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateParam(float dt)
		{
			BP_FeathersInteraction_C.__UpdateParam_FunctionParams* ptr = stackalloc BP_FeathersInteraction_C.__UpdateParam_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_FeathersInteraction_C.__UpdateParam_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FeathersInteraction_C.__UpdateParam_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dt = dt;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FeathersInteraction_C.__UpdateParam_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060273B3 RID: 160691 RVA: 0x0098BB5E File Offset: 0x00989D5E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FeathersInteraction_C.__InitParam_NativeFunctionPtr, null);
		}

		// Token: 0x060273B4 RID: 160692 RVA: 0x0098BB72 File Offset: 0x00989D72
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FeathersInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060273B5 RID: 160693 RVA: 0x0098BB86 File Offset: 0x00989D86
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FeathersInteraction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060273B6 RID: 160694 RVA: 0x0098BB9C File Offset: 0x00989D9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FeathersInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FeathersInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FeathersInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FeathersInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FeathersInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060273B7 RID: 160695 RVA: 0x0098BBE4 File Offset: 0x00989DE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FeathersInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FeathersInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FeathersInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FeathersInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FeathersInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060273B8 RID: 160696 RVA: 0x0098BC2B File Offset: 0x00989E2B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FeathersInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060273B9 RID: 160697 RVA: 0x0098BC3F File Offset: 0x00989E3F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FeathersInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060273BA RID: 160698 RVA: 0x0098BC54 File Offset: 0x00989E54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_FeathersInteraction_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_FeathersInteraction_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_FeathersInteraction_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FeathersInteraction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FeathersInteraction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060273BB RID: 160699 RVA: 0x0098BCB7 File Offset: 0x00989EB7
		protected BP_FeathersInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013C80 RID: 81024
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FeathersInteraction/BP_FeathersInteraction.BP_FeathersInteraction_C";

		// Token: 0x04013C81 RID: 81025
		private static IntPtr _ClassPtr;

		// Token: 0x04013C82 RID: 81026
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013C83 RID: 81027
		internal static int __PropertyOffset_1;

		// Token: 0x04013C84 RID: 81028
		internal static int __PropertyOffset_2;

		// Token: 0x04013C85 RID: 81029
		internal static int __PropertyOffset_3;

		// Token: 0x04013C86 RID: 81030
		internal static int __PropertyOffset_4;

		// Token: 0x04013C87 RID: 81031
		internal static int __PropertyOffset_5;

		// Token: 0x04013C88 RID: 81032
		internal static int __PropertyOffset_6;

		// Token: 0x04013C89 RID: 81033
		internal static int __PropertyOffset_7;

		// Token: 0x04013C8A RID: 81034
		internal static int __PropertyOffset_8;

		// Token: 0x04013C8B RID: 81035
		internal static int __PropertyOffset_9;

		// Token: 0x04013C8C RID: 81036
		internal static int __PropertyOffset_10;

		// Token: 0x04013C8D RID: 81037
		internal static int __PropertyOffset_11;

		// Token: 0x04013C8E RID: 81038
		internal static int __PropertyOffset_12;

		// Token: 0x04013C8F RID: 81039
		internal static int __PropertyOffset_13;

		// Token: 0x04013C90 RID: 81040
		internal static int __PropertyOffset_14;

		// Token: 0x04013C91 RID: 81041
		internal static int __PropertyOffset_15;

		// Token: 0x04013C92 RID: 81042
		internal static int __PropertyOffset_16;

		// Token: 0x04013C93 RID: 81043
		internal static int __PropertyOffset_17;

		// Token: 0x04013C94 RID: 81044
		internal static int __PropertyOffset_18;

		// Token: 0x04013C95 RID: 81045
		internal static int __PropertyOffset_19;

		// Token: 0x04013C96 RID: 81046
		internal static int __PropertyOffset_20;

		// Token: 0x04013C97 RID: 81047
		internal static int __PropertyOffset_21;

		// Token: 0x04013C98 RID: 81048
		internal static int __PropertyOffset_22;

		// Token: 0x04013C99 RID: 81049
		internal static int __PropertyOffset_23;

		// Token: 0x04013C9A RID: 81050
		internal static int __PropertyOffset_24;

		// Token: 0x04013C9B RID: 81051
		internal static int __PropertyOffset_25;

		// Token: 0x04013C9C RID: 81052
		internal static int __PropertyOffset_26;

		// Token: 0x04013C9D RID: 81053
		internal static int __PropertyOffset_27;

		// Token: 0x04013C9E RID: 81054
		internal static int __PropertyOffset_28;

		// Token: 0x04013C9F RID: 81055
		internal static int __PropertyOffset_29;

		// Token: 0x04013CA0 RID: 81056
		internal static int __PropertyOffset_30;

		// Token: 0x04013CA1 RID: 81057
		internal static int __PropertyOffset_31;

		// Token: 0x04013CA2 RID: 81058
		internal static int __PropertyOffset_32;

		// Token: 0x04013CA3 RID: 81059
		private static IntPtr __SetLeavesParameters_NativeFunctionPtr;

		// Token: 0x04013CA4 RID: 81060
		private static IntPtr __Debug_NativeFunctionPtr;

		// Token: 0x04013CA5 RID: 81061
		private static IntPtr __Choose_Available_Point_NativeFunctionPtr;

		// Token: 0x04013CA6 RID: 81062
		private static IntPtr __WeaponData_NativeFunctionPtr;

		// Token: 0x04013CA7 RID: 81063
		private static IntPtr __UpdateParam_NativeFunctionPtr;

		// Token: 0x04013CA8 RID: 81064
		private static IntPtr __InitParam_NativeFunctionPtr;

		// Token: 0x04013CA9 RID: 81065
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013CAA RID: 81066
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013CAB RID: 81067
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013CAC RID: 81068
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x0200A202 RID: 41474
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Choose_Available_Point_FunctionParams
		{
			// Token: 0x04031E65 RID: 204389
			[FieldOffset(0)]
			public FVectorDouble CollisionPoint;

			// Token: 0x04031E66 RID: 204390
			[FieldOffset(24)]
			public FVectorDouble WeaponPoint;

			// Token: 0x04031E67 RID: 204391
			[FieldOffset(48)]
			public IntPtr ConfigDA;

			// Token: 0x04031E68 RID: 204392
			[FieldOffset(56)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x0200A203 RID: 41475
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __UpdateParam_FunctionParams
		{
			// Token: 0x04031E69 RID: 204393
			[FieldOffset(0)]
			public float dt;
		}

		// Token: 0x0200A204 RID: 41476
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031E6A RID: 204394
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A205 RID: 41477
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031E6B RID: 204395
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031E6C RID: 204396
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031E6D RID: 204397
			[FieldOffset(32)]
			public int Id;
		}
	}
}
