using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUBoxSimulation
{
	// Token: 0x02003CBF RID: 15551
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/S_boxColSetupParams.S_boxColSetupParams")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 125)]
	public class S_boxColSetupParams : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024BD0 RID: 150480 RVA: 0x009470F4 File Offset: 0x009452F4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_boxColSetupParams._ScriptStructPtr != 0) ? S_boxColSetupParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/S_boxColSetupParams.S_boxColSetupParams", ref S_boxColSetupParams._ScriptStructPtr);
		}

		// Token: 0x170048CF RID: 18639
		// (get) Token: 0x06024BD1 RID: 150481 RVA: 0x00947118 File Offset: 0x00945318
		// (set) Token: 0x06024BD2 RID: 150482 RVA: 0x0094712C File Offset: 0x0094532C
		public unsafe UMaterialInstance InputMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + S_boxColSetupParams.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_boxColSetupParams.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170048D0 RID: 18640
		// (get) Token: 0x06024BD3 RID: 150483 RVA: 0x00947141 File Offset: 0x00945341
		// (set) Token: 0x06024BD4 RID: 150484 RVA: 0x00947155 File Offset: 0x00945355
		public unsafe UDataTable DT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + S_boxColSetupParams.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_boxColSetupParams.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170048D1 RID: 18641
		// (get) Token: 0x06024BD5 RID: 150485 RVA: 0x0094716A File Offset: 0x0094536A
		// (set) Token: 0x06024BD6 RID: 150486 RVA: 0x0094717A File Offset: 0x0094537A
		public unsafe bool _2DRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048D2 RID: 18642
		// (get) Token: 0x06024BD7 RID: 150487 RVA: 0x0094718B File Offset: 0x0094538B
		// (set) Token: 0x06024BD8 RID: 150488 RVA: 0x0094719B File Offset: 0x0094539B
		public unsafe int XCount_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170048D3 RID: 18643
		// (get) Token: 0x06024BD9 RID: 150489 RVA: 0x009471AC File Offset: 0x009453AC
		// (set) Token: 0x06024BDA RID: 150490 RVA: 0x009471BC File Offset: 0x009453BC
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170048D4 RID: 18644
		// (get) Token: 0x06024BDB RID: 150491 RVA: 0x009471CD File Offset: 0x009453CD
		// (set) Token: 0x06024BDC RID: 150492 RVA: 0x009471DD File Offset: 0x009453DD
		public unsafe bool RevertOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048D5 RID: 18645
		// (get) Token: 0x06024BDD RID: 150493 RVA: 0x009471EE File Offset: 0x009453EE
		// (set) Token: 0x06024BDE RID: 150494 RVA: 0x009471FE File Offset: 0x009453FE
		public unsafe float CollisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170048D6 RID: 18646
		// (get) Token: 0x06024BDF RID: 150495 RVA: 0x0094720F File Offset: 0x0094540F
		// (set) Token: 0x06024BE0 RID: 150496 RVA: 0x0094721F File Offset: 0x0094541F
		public unsafe float MoveableDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170048D7 RID: 18647
		// (get) Token: 0x06024BE1 RID: 150497 RVA: 0x00947230 File Offset: 0x00945430
		// (set) Token: 0x06024BE2 RID: 150498 RVA: 0x00947240 File Offset: 0x00945440
		public unsafe bool EnableCPURead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048D8 RID: 18648
		// (get) Token: 0x06024BE3 RID: 150499 RVA: 0x00947251 File Offset: 0x00945451
		// (set) Token: 0x06024BE4 RID: 150500 RVA: 0x00947261 File Offset: 0x00945461
		public unsafe float SpringK
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170048D9 RID: 18649
		// (get) Token: 0x06024BE5 RID: 150501 RVA: 0x00947272 File Offset: 0x00945472
		// (set) Token: 0x06024BE6 RID: 150502 RVA: 0x00947282 File Offset: 0x00945482
		public unsafe float SpringC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170048DA RID: 18650
		// (get) Token: 0x06024BE7 RID: 150503 RVA: 0x00947293 File Offset: 0x00945493
		// (set) Token: 0x06024BE8 RID: 150504 RVA: 0x009472A3 File Offset: 0x009454A3
		public unsafe float pushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170048DB RID: 18651
		// (get) Token: 0x06024BE9 RID: 150505 RVA: 0x009472B4 File Offset: 0x009454B4
		// (set) Token: 0x06024BEA RID: 150506 RVA: 0x009472C4 File Offset: 0x009454C4
		public unsafe bool NeedDistanceConsOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048DC RID: 18652
		// (get) Token: 0x06024BEB RID: 150507 RVA: 0x009472D5 File Offset: 0x009454D5
		// (set) Token: 0x06024BEC RID: 150508 RVA: 0x009472E5 File Offset: 0x009454E5
		public unsafe bool SimulationPhysicOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048DD RID: 18653
		// (get) Token: 0x06024BED RID: 150509 RVA: 0x009472F6 File Offset: 0x009454F6
		// (set) Token: 0x06024BEE RID: 150510 RVA: 0x00947306 File Offset: 0x00945506
		public unsafe float Attackstrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170048DE RID: 18654
		// (get) Token: 0x06024BEF RID: 150511 RVA: 0x00947317 File Offset: 0x00945517
		// (set) Token: 0x06024BF0 RID: 150512 RVA: 0x00947327 File Offset: 0x00945527
		public unsafe float MeshMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170048DF RID: 18655
		// (get) Token: 0x06024BF1 RID: 150513 RVA: 0x00947338 File Offset: 0x00945538
		// (set) Token: 0x06024BF2 RID: 150514 RVA: 0x00947348 File Offset: 0x00945548
		public unsafe bool MaterialSlot1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048E0 RID: 18656
		// (get) Token: 0x06024BF3 RID: 150515 RVA: 0x00947359 File Offset: 0x00945559
		// (set) Token: 0x06024BF4 RID: 150516 RVA: 0x0094736D File Offset: 0x0094556D
		public unsafe UMaterialInstance InputMat1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + S_boxColSetupParams.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_boxColSetupParams.__PropertyOffset_17, value);
			}
		}

		// Token: 0x170048E1 RID: 18657
		// (get) Token: 0x06024BF5 RID: 150517 RVA: 0x00947382 File Offset: 0x00945582
		// (set) Token: 0x06024BF6 RID: 150518 RVA: 0x00947392 File Offset: 0x00945592
		public unsafe int lockXYZ_0_do_nothing__1_lock_x___2_lock_y___3_lock_z_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170048E2 RID: 18658
		// (get) Token: 0x06024BF7 RID: 150519 RVA: 0x009473A3 File Offset: 0x009455A3
		// (set) Token: 0x06024BF8 RID: 150520 RVA: 0x009473B7 File Offset: 0x009455B7
		public unsafe FVector gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170048E3 RID: 18659
		// (get) Token: 0x06024BF9 RID: 150521 RVA: 0x009473CC File Offset: 0x009455CC
		// (set) Token: 0x06024BFA RID: 150522 RVA: 0x009473DC File Offset: 0x009455DC
		public unsafe bool ReadDAINBeginPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048E4 RID: 18660
		// (get) Token: 0x06024BFB RID: 150523 RVA: 0x009473F0 File Offset: 0x009455F0
		// (set) Token: 0x06024BFC RID: 150524 RVA: 0x00947433 File Offset: 0x00945633
		[Nullable(1)]
		public TArray<FKuroCSUnifiedCollider_genericCloth> CollisionArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSUnifiedCollider_genericCloth> result;
				if ((result = this._CollisionArr) == null)
				{
					result = (this._CollisionArr = new TArray<FKuroCSUnifiedCollider_genericCloth>(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_21, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CollisionArr.CopyAssign(value);
			}
		}

		// Token: 0x170048E5 RID: 18661
		// (get) Token: 0x06024BFD RID: 150525 RVA: 0x00947441 File Offset: 0x00945641
		// (set) Token: 0x06024BFE RID: 150526 RVA: 0x00947451 File Offset: 0x00945651
		public unsafe int subCount_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170048E6 RID: 18662
		// (get) Token: 0x06024BFF RID: 150527 RVA: 0x00947462 File Offset: 0x00945662
		// (set) Token: 0x06024C00 RID: 150528 RVA: 0x00947472 File Offset: 0x00945672
		public unsafe bool ForcePlayerCol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_boxColSetupParams.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024C01 RID: 150529 RVA: 0x00947483 File Offset: 0x00945683
		public S_boxColSetupParams()
		{
		}

		// Token: 0x06024C02 RID: 150530 RVA: 0x0094748C File Offset: 0x0094568C
		[NullableContext(1)]
		public S_boxColSetupParams(UMaterialInstance InputMat, UDataTable DT, bool _2DRT, int XCount_0, float DisStiffness, bool RevertOrNot, float CollisionR, float MoveableDis, bool EnableCPURead, float SpringK, float SpringC, float pushStrength, bool NeedDistanceConsOrNot, bool SimulationPhysicOrNot, float Attackstrength, float MeshMass, bool MaterialSlot1, UMaterialInstance InputMat1, int lockXYZ_0_do_nothing__1_lock_x___2_lock_y___3_lock_z_, FVector gravity, bool ReadDAINBeginPlay, TArray<FKuroCSUnifiedCollider_genericCloth> CollisionArr, int subCount_0, bool ForcePlayerCol)
		{
			this.InputMat = InputMat;
			this.DT = DT;
			this._2DRT = _2DRT;
			this.XCount_0 = XCount_0;
			this.DisStiffness = DisStiffness;
			this.RevertOrNot = RevertOrNot;
			this.CollisionR = CollisionR;
			this.MoveableDis = MoveableDis;
			this.EnableCPURead = EnableCPURead;
			this.SpringK = SpringK;
			this.SpringC = SpringC;
			this.pushStrength = pushStrength;
			this.NeedDistanceConsOrNot = NeedDistanceConsOrNot;
			this.SimulationPhysicOrNot = SimulationPhysicOrNot;
			this.Attackstrength = Attackstrength;
			this.MeshMass = MeshMass;
			this.MaterialSlot1 = MaterialSlot1;
			this.InputMat1 = InputMat1;
			this.lockXYZ_0_do_nothing__1_lock_x___2_lock_y___3_lock_z_ = lockXYZ_0_do_nothing__1_lock_x___2_lock_y___3_lock_z_;
			this.gravity = gravity;
			this.ReadDAINBeginPlay = ReadDAINBeginPlay;
			this.CollisionArr = CollisionArr;
			this.subCount_0 = subCount_0;
			this.ForcePlayerCol = ForcePlayerCol;
		}

		// Token: 0x06024C03 RID: 150531 RVA: 0x0094755C File Offset: 0x0094575C
		protected override IntPtr GetUStructPtr()
		{
			return S_boxColSetupParams.StaticStruct();
		}

		// Token: 0x06024C04 RID: 150532 RVA: 0x00947568 File Offset: 0x00945768
		public S_boxColSetupParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024C05 RID: 150533 RVA: 0x00947572 File Offset: 0x00945772
		public S_boxColSetupParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024C06 RID: 150534 RVA: 0x0094757D File Offset: 0x0094577D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_boxColSetupParams(Pointer, false, true);
		}

		// Token: 0x06024C07 RID: 150535 RVA: 0x00947587 File Offset: 0x00945787
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_boxColSetupParams(Pointer, MemoryOwner);
		}

		// Token: 0x0401240A RID: 74762
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/S_boxColSetupParams.S_boxColSetupParams";

		// Token: 0x0401240B RID: 74763
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401240C RID: 74764
		internal static int __PropertyOffset_0;

		// Token: 0x0401240D RID: 74765
		internal static int __PropertyOffset_1;

		// Token: 0x0401240E RID: 74766
		internal static int __PropertyOffset_2;

		// Token: 0x0401240F RID: 74767
		internal static int __PropertyOffset_3;

		// Token: 0x04012410 RID: 74768
		internal static int __PropertyOffset_4;

		// Token: 0x04012411 RID: 74769
		internal static int __PropertyOffset_5;

		// Token: 0x04012412 RID: 74770
		internal static int __PropertyOffset_6;

		// Token: 0x04012413 RID: 74771
		internal static int __PropertyOffset_7;

		// Token: 0x04012414 RID: 74772
		internal static int __PropertyOffset_8;

		// Token: 0x04012415 RID: 74773
		internal static int __PropertyOffset_9;

		// Token: 0x04012416 RID: 74774
		internal static int __PropertyOffset_10;

		// Token: 0x04012417 RID: 74775
		internal static int __PropertyOffset_11;

		// Token: 0x04012418 RID: 74776
		internal static int __PropertyOffset_12;

		// Token: 0x04012419 RID: 74777
		internal static int __PropertyOffset_13;

		// Token: 0x0401241A RID: 74778
		internal static int __PropertyOffset_14;

		// Token: 0x0401241B RID: 74779
		internal static int __PropertyOffset_15;

		// Token: 0x0401241C RID: 74780
		internal static int __PropertyOffset_16;

		// Token: 0x0401241D RID: 74781
		internal static int __PropertyOffset_17;

		// Token: 0x0401241E RID: 74782
		internal static int __PropertyOffset_18;

		// Token: 0x0401241F RID: 74783
		internal static int __PropertyOffset_19;

		// Token: 0x04012420 RID: 74784
		internal static int __PropertyOffset_20;

		// Token: 0x04012421 RID: 74785
		internal static int __PropertyOffset_21;

		// Token: 0x04012422 RID: 74786
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSUnifiedCollider_genericCloth> _CollisionArr;

		// Token: 0x04012423 RID: 74787
		internal static int __PropertyOffset_22;

		// Token: 0x04012424 RID: 74788
		internal static int __PropertyOffset_23;
	}
}
