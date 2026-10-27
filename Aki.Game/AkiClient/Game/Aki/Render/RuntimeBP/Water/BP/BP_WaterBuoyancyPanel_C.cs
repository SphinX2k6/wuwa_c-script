using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Water.BP
{
	// Token: 0x02003A8B RID: 14987
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Water/BP/BP_WaterBuoyancyPanel.BP_WaterBuoyancyPanel_C")]
	[UnrealStructLayout(1288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1281)]
	public class BP_WaterBuoyancyPanel_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FD9A RID: 130458 RVA: 0x008C44A8 File Offset: 0x008C26A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterBuoyancyPanel_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Water/BP/BP_WaterBuoyancyPanel.BP_WaterBuoyancyPanel_C");
			}
			return BP_WaterBuoyancyPanel_C._ClassPtr;
		}

		// Token: 0x0601FD9B RID: 130459 RVA: 0x008C44CC File Offset: 0x008C26CC
		public BP_WaterBuoyancyPanel_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterBuoyancyPanel_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FD9C RID: 130460 RVA: 0x008C44F4 File Offset: 0x008C26F4
		[NullableContext(1)]
		public BP_WaterBuoyancyPanel_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterBuoyancyPanel_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D3E RID: 11582
		// (get) Token: 0x0601FD9D RID: 130461 RVA: 0x008C4527 File Offset: 0x008C2727
		// (set) Token: 0x0601FD9E RID: 130462 RVA: 0x008C453B File Offset: 0x008C273B
		public unsafe UStaticMeshComponent PhysicsMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyPanel_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyPanel_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002D3F RID: 11583
		// (get) Token: 0x0601FD9F RID: 130463 RVA: 0x008C4550 File Offset: 0x008C2750
		// (set) Token: 0x0601FDA0 RID: 130464 RVA: 0x008C4564 File Offset: 0x008C2764
		public unsafe UStaticMeshComponent BlackMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyPanel_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyPanel_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002D40 RID: 11584
		// (get) Token: 0x0601FDA1 RID: 130465 RVA: 0x008C4579 File Offset: 0x008C2779
		// (set) Token: 0x0601FDA2 RID: 130466 RVA: 0x008C458D File Offset: 0x008C278D
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyPanel_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyPanel_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002D41 RID: 11585
		// (get) Token: 0x0601FDA3 RID: 130467 RVA: 0x008C45A2 File Offset: 0x008C27A2
		// (set) Token: 0x0601FDA4 RID: 130468 RVA: 0x008C45B6 File Offset: 0x008C27B6
		public unsafe UStaticMesh BuoyancyPanelStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyPanel_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyPanel_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002D42 RID: 11586
		// (get) Token: 0x0601FDA5 RID: 130469 RVA: 0x008C45CC File Offset: 0x008C27CC
		// (set) Token: 0x0601FDA6 RID: 130470 RVA: 0x008C4605 File Offset: 0x008C2805
		[Nullable(1)]
		public TArray<FVector4> sphereList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector4> result;
				if ((result = this._sphereList) == null)
				{
					result = (this._sphereList = new TArray<FVector4>(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.sphereList.CopyAssign(value);
			}
		}

		// Token: 0x17002D43 RID: 11587
		// (get) Token: 0x0601FDA7 RID: 130471 RVA: 0x008C4613 File Offset: 0x008C2813
		// (set) Token: 0x0601FDA8 RID: 130472 RVA: 0x008C4623 File Offset: 0x008C2823
		public unsafe float BuoyancyIntersity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002D44 RID: 11588
		// (get) Token: 0x0601FDA9 RID: 130473 RVA: 0x008C4634 File Offset: 0x008C2834
		// (set) Token: 0x0601FDAA RID: 130474 RVA: 0x008C4644 File Offset: 0x008C2844
		public unsafe double BuoyancyRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002D45 RID: 11589
		// (get) Token: 0x0601FDAB RID: 130475 RVA: 0x008C4655 File Offset: 0x008C2855
		// (set) Token: 0x0601FDAC RID: 130476 RVA: 0x008C4665 File Offset: 0x008C2865
		public unsafe float WaterHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002D46 RID: 11590
		// (get) Token: 0x0601FDAD RID: 130477 RVA: 0x008C4676 File Offset: 0x008C2876
		// (set) Token: 0x0601FDAE RID: 130478 RVA: 0x008C4686 File Offset: 0x008C2886
		public unsafe float StaticHeightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002D47 RID: 11591
		// (get) Token: 0x0601FDAF RID: 130479 RVA: 0x008C4697 File Offset: 0x008C2897
		// (set) Token: 0x0601FDB0 RID: 130480 RVA: 0x008C46A7 File Offset: 0x008C28A7
		public unsafe float LerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002D48 RID: 11592
		// (get) Token: 0x0601FDB1 RID: 130481 RVA: 0x008C46B8 File Offset: 0x008C28B8
		// (set) Token: 0x0601FDB2 RID: 130482 RVA: 0x008C46C8 File Offset: 0x008C28C8
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002D49 RID: 11593
		// (get) Token: 0x0601FDB3 RID: 130483 RVA: 0x008C46D9 File Offset: 0x008C28D9
		// (set) Token: 0x0601FDB4 RID: 130484 RVA: 0x008C46E9 File Offset: 0x008C28E9
		public unsafe float LinearDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002D4A RID: 11594
		// (get) Token: 0x0601FDB5 RID: 130485 RVA: 0x008C46FA File Offset: 0x008C28FA
		// (set) Token: 0x0601FDB6 RID: 130486 RVA: 0x008C470A File Offset: 0x008C290A
		public unsafe float AngularDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17002D4B RID: 11595
		// (get) Token: 0x0601FDB7 RID: 130487 RVA: 0x008C471B File Offset: 0x008C291B
		// (set) Token: 0x0601FDB8 RID: 130488 RVA: 0x008C472B File Offset: 0x008C292B
		public unsafe float MinDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002D4C RID: 11596
		// (get) Token: 0x0601FDB9 RID: 130489 RVA: 0x008C473C File Offset: 0x008C293C
		// (set) Token: 0x0601FDBA RID: 130490 RVA: 0x008C474C File Offset: 0x008C294C
		public unsafe float Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17002D4D RID: 11597
		// (get) Token: 0x0601FDBB RID: 130491 RVA: 0x008C475D File Offset: 0x008C295D
		// (set) Token: 0x0601FDBC RID: 130492 RVA: 0x008C476D File Offset: 0x008C296D
		public unsafe float TempWaterHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17002D4E RID: 11598
		// (get) Token: 0x0601FDBD RID: 130493 RVA: 0x008C477E File Offset: 0x008C297E
		// (set) Token: 0x0601FDBE RID: 130494 RVA: 0x008C478E File Offset: 0x008C298E
		public unsafe float PlayerImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17002D4F RID: 11599
		// (get) Token: 0x0601FDBF RID: 130495 RVA: 0x008C479F File Offset: 0x008C299F
		// (set) Token: 0x0601FDC0 RID: 130496 RVA: 0x008C47B3 File Offset: 0x008C29B3
		public unsafe FVectorDouble offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17002D50 RID: 11600
		// (get) Token: 0x0601FDC1 RID: 130497 RVA: 0x008C47C8 File Offset: 0x008C29C8
		// (set) Token: 0x0601FDC2 RID: 130498 RVA: 0x008C47D8 File Offset: 0x008C29D8
		public unsafe double dis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17002D51 RID: 11601
		// (get) Token: 0x0601FDC3 RID: 130499 RVA: 0x008C47E9 File Offset: 0x008C29E9
		// (set) Token: 0x0601FDC4 RID: 130500 RVA: 0x008C47F9 File Offset: 0x008C29F9
		public unsafe float PlayerImpulseLerpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17002D52 RID: 11602
		// (get) Token: 0x0601FDC5 RID: 130501 RVA: 0x008C480A File Offset: 0x008C2A0A
		// (set) Token: 0x0601FDC6 RID: 130502 RVA: 0x008C481A File Offset: 0x008C2A1A
		public unsafe float LerpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17002D53 RID: 11603
		// (get) Token: 0x0601FDC7 RID: 130503 RVA: 0x008C482B File Offset: 0x008C2A2B
		// (set) Token: 0x0601FDC8 RID: 130504 RVA: 0x008C483B File Offset: 0x008C2A3B
		public unsafe double DistforPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17002D54 RID: 11604
		// (get) Token: 0x0601FDC9 RID: 130505 RVA: 0x008C484C File Offset: 0x008C2A4C
		// (set) Token: 0x0601FDCA RID: 130506 RVA: 0x008C4860 File Offset: 0x008C2A60
		public unsafe FVectorDouble MeshPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17002D55 RID: 11605
		// (get) Token: 0x0601FDCB RID: 130507 RVA: 0x008C4875 File Offset: 0x008C2A75
		// (set) Token: 0x0601FDCC RID: 130508 RVA: 0x008C4889 File Offset: 0x008C2A89
		public unsafe FVectorDouble PosOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17002D56 RID: 11606
		// (get) Token: 0x0601FDCD RID: 130509 RVA: 0x008C489E File Offset: 0x008C2A9E
		// (set) Token: 0x0601FDCE RID: 130510 RVA: 0x008C48AE File Offset: 0x008C2AAE
		public unsafe float MeshBoundRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17002D57 RID: 11607
		// (get) Token: 0x0601FDCF RID: 130511 RVA: 0x008C48BF File Offset: 0x008C2ABF
		// (set) Token: 0x0601FDD0 RID: 130512 RVA: 0x008C48CF File Offset: 0x008C2ACF
		public unsafe double X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x0601FDD1 RID: 130513 RVA: 0x008C48E0 File Offset: 0x008C2AE0
		// (set) Token: 0x0601FDD2 RID: 130514 RVA: 0x008C48F0 File Offset: 0x008C2AF0
		public unsafe double Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17002D59 RID: 11609
		// (get) Token: 0x0601FDD3 RID: 130515 RVA: 0x008C4901 File Offset: 0x008C2B01
		// (set) Token: 0x0601FDD4 RID: 130516 RVA: 0x008C4911 File Offset: 0x008C2B11
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyPanel_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FDD5 RID: 130517 RVA: 0x008C4924 File Offset: 0x008C2B24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void VolumeSphereInWater(float in_h, FVector in_c, float in_r, ref float out_V, ref float out_SpheveV)
		{
			BP_WaterBuoyancyPanel_C.__VolumeSphereInWater_FunctionParams* ptr = stackalloc BP_WaterBuoyancyPanel_C.__VolumeSphereInWater_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(BP_WaterBuoyancyPanel_C.__VolumeSphereInWater_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBuoyancyPanel_C.__VolumeSphereInWater_NativeFunctionPtr, (void*)ptr, 1);
			ptr->in_h = in_h;
			ptr->in_c = in_c;
			ptr->in_r = in_r;
			ptr->out_V = out_V;
			ptr->out_SpheveV = out_SpheveV;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancyPanel_C.__VolumeSphereInWater_NativeFunctionPtr, (void*)ptr);
			out_V = ptr->out_V;
			out_SpheveV = ptr->out_SpheveV;
		}

		// Token: 0x0601FDD6 RID: 130518 RVA: 0x008C499F File Offset: 0x008C2B9F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancyPanel_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FDD7 RID: 130519 RVA: 0x008C49B3 File Offset: 0x008C2BB3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBuoyancyPanel_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FDD8 RID: 130520 RVA: 0x008C49C8 File Offset: 0x008C2BC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterBuoyancyPanel_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterBuoyancyPanel_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterBuoyancyPanel_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBuoyancyPanel_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancyPanel_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FDD9 RID: 130521 RVA: 0x008C4A10 File Offset: 0x008C2C10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterBuoyancyPanel_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterBuoyancyPanel_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterBuoyancyPanel_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBuoyancyPanel_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBuoyancyPanel_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FDDA RID: 130522 RVA: 0x008C4A57 File Offset: 0x008C2C57
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancyPanel_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FDDB RID: 130523 RVA: 0x008C4A6B File Offset: 0x008C2C6B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBuoyancyPanel_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FDDC RID: 130524 RVA: 0x008C4A80 File Offset: 0x008C2C80
		protected BP_WaterBuoyancyPanel_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F5AF RID: 62895
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Water/BP/BP_WaterBuoyancyPanel.BP_WaterBuoyancyPanel_C";

		// Token: 0x0400F5B0 RID: 62896
		private static IntPtr _ClassPtr;

		// Token: 0x0400F5B1 RID: 62897
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F5B2 RID: 62898
		internal static int __PropertyOffset_1;

		// Token: 0x0400F5B3 RID: 62899
		internal static int __PropertyOffset_2;

		// Token: 0x0400F5B4 RID: 62900
		internal static int __PropertyOffset_3;

		// Token: 0x0400F5B5 RID: 62901
		internal static int __PropertyOffset_4;

		// Token: 0x0400F5B6 RID: 62902
		internal static int __PropertyOffset_5;

		// Token: 0x0400F5B7 RID: 62903
		private TArray<FVector4> _sphereList;

		// Token: 0x0400F5B8 RID: 62904
		internal static int __PropertyOffset_6;

		// Token: 0x0400F5B9 RID: 62905
		internal static int __PropertyOffset_7;

		// Token: 0x0400F5BA RID: 62906
		internal static int __PropertyOffset_8;

		// Token: 0x0400F5BB RID: 62907
		internal static int __PropertyOffset_9;

		// Token: 0x0400F5BC RID: 62908
		internal static int __PropertyOffset_10;

		// Token: 0x0400F5BD RID: 62909
		internal static int __PropertyOffset_11;

		// Token: 0x0400F5BE RID: 62910
		internal static int __PropertyOffset_12;

		// Token: 0x0400F5BF RID: 62911
		internal static int __PropertyOffset_13;

		// Token: 0x0400F5C0 RID: 62912
		internal static int __PropertyOffset_14;

		// Token: 0x0400F5C1 RID: 62913
		internal static int __PropertyOffset_15;

		// Token: 0x0400F5C2 RID: 62914
		internal static int __PropertyOffset_16;

		// Token: 0x0400F5C3 RID: 62915
		internal static int __PropertyOffset_17;

		// Token: 0x0400F5C4 RID: 62916
		internal static int __PropertyOffset_18;

		// Token: 0x0400F5C5 RID: 62917
		internal static int __PropertyOffset_19;

		// Token: 0x0400F5C6 RID: 62918
		internal static int __PropertyOffset_20;

		// Token: 0x0400F5C7 RID: 62919
		internal static int __PropertyOffset_21;

		// Token: 0x0400F5C8 RID: 62920
		internal static int __PropertyOffset_22;

		// Token: 0x0400F5C9 RID: 62921
		internal static int __PropertyOffset_23;

		// Token: 0x0400F5CA RID: 62922
		internal static int __PropertyOffset_24;

		// Token: 0x0400F5CB RID: 62923
		internal static int __PropertyOffset_25;

		// Token: 0x0400F5CC RID: 62924
		internal static int __PropertyOffset_26;

		// Token: 0x0400F5CD RID: 62925
		internal static int __PropertyOffset_27;

		// Token: 0x0400F5CE RID: 62926
		internal static int __PropertyOffset_28;

		// Token: 0x0400F5CF RID: 62927
		private static IntPtr __VolumeSphereInWater_NativeFunctionPtr;

		// Token: 0x0400F5D0 RID: 62928
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F5D1 RID: 62929
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F5D2 RID: 62930
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009B5B RID: 39771
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __VolumeSphereInWater_FunctionParams
		{
			// Token: 0x04031185 RID: 201093
			[FieldOffset(0)]
			public float in_h;

			// Token: 0x04031186 RID: 201094
			[FieldOffset(4)]
			public FVector in_c;

			// Token: 0x04031187 RID: 201095
			[FieldOffset(16)]
			public float in_r;

			// Token: 0x04031188 RID: 201096
			[FieldOffset(20)]
			public float out_V;

			// Token: 0x04031189 RID: 201097
			[FieldOffset(24)]
			public float out_SpheveV;
		}

		// Token: 0x02009B5C RID: 39772
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403118A RID: 201098
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
