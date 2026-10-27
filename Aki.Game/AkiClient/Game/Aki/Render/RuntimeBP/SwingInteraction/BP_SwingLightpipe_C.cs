using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.Physics_Actor;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SwingInteraction
{
	// Token: 0x02003AC3 RID: 15043
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_SwingLightpipe.BP_SwingLightpipe_C")]
	[UnrealStructLayout(1816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1812)]
	public class BP_SwingLightpipe_C : BP_PhysicsActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060205AF RID: 132527 RVA: 0x008D0570 File Offset: 0x008CE770
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SwingLightpipe_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_SwingLightpipe.BP_SwingLightpipe_C");
			}
			return BP_SwingLightpipe_C._ClassPtr;
		}

		// Token: 0x060205B0 RID: 132528 RVA: 0x008D0594 File Offset: 0x008CE794
		public BP_SwingLightpipe_C() : this(BuiltinUtils.AllocNativeUObject(BP_SwingLightpipe_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060205B1 RID: 132529 RVA: 0x008D05BC File Offset: 0x008CE7BC
		[NullableContext(1)]
		public BP_SwingLightpipe_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SwingLightpipe_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x060205B2 RID: 132530 RVA: 0x008D05EF File Offset: 0x008CE7EF
		// (set) Token: 0x060205B3 RID: 132531 RVA: 0x008D0603 File Offset: 0x008CE803
		public unsafe UStaticMeshComponent SM_Ins_Lig_02AS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x060205B4 RID: 132532 RVA: 0x008D0618 File Offset: 0x008CE818
		// (set) Token: 0x060205B5 RID: 132533 RVA: 0x008D062C File Offset: 0x008CE82C
		public unsafe UStaticMeshComponent StaticMeshOri
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x060205B6 RID: 132534 RVA: 0x008D0641 File Offset: 0x008CE841
		// (set) Token: 0x060205B7 RID: 132535 RVA: 0x008D0655 File Offset: 0x008CE855
		public unsafe UStaticMeshComponent SM_SwingSingleRopeR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x060205B8 RID: 132536 RVA: 0x008D066A File Offset: 0x008CE86A
		// (set) Token: 0x060205B9 RID: 132537 RVA: 0x008D067E File Offset: 0x008CE87E
		public unsafe UStaticMeshComponent SM_SwingSingleRopeL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x060205BA RID: 132538 RVA: 0x008D0693 File Offset: 0x008CE893
		// (set) Token: 0x060205BB RID: 132539 RVA: 0x008D06A7 File Offset: 0x008CE8A7
		public unsafe UStaticMeshComponent SM_SwingTop
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x060205BC RID: 132540 RVA: 0x008D06BC File Offset: 0x008CE8BC
		// (set) Token: 0x060205BD RID: 132541 RVA: 0x008D06D0 File Offset: 0x008CE8D0
		public unsafe UStaticMeshComponent StaticMesh_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x060205BE RID: 132542 RVA: 0x008D06E5 File Offset: 0x008CE8E5
		// (set) Token: 0x060205BF RID: 132543 RVA: 0x008D06F5 File Offset: 0x008CE8F5
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x060205C0 RID: 132544 RVA: 0x008D0706 File Offset: 0x008CE906
		// (set) Token: 0x060205C1 RID: 132545 RVA: 0x008D0716 File Offset: 0x008CE916
		public unsafe bool bUseConstantDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x060205C2 RID: 132546 RVA: 0x008D0727 File Offset: 0x008CE927
		// (set) Token: 0x060205C3 RID: 132547 RVA: 0x008D0737 File Offset: 0x008CE937
		public unsafe float Pipelength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700305B RID: 12379
		// (get) Token: 0x060205C4 RID: 132548 RVA: 0x008D0748 File Offset: 0x008CE948
		// (set) Token: 0x060205C5 RID: 132549 RVA: 0x008D0758 File Offset: 0x008CE958
		public unsafe float FakeWireLengthMulti
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700305C RID: 12380
		// (get) Token: 0x060205C6 RID: 132550 RVA: 0x008D0769 File Offset: 0x008CE969
		// (set) Token: 0x060205C7 RID: 132551 RVA: 0x008D0779 File Offset: 0x008CE979
		public unsafe float ConstantDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700305D RID: 12381
		// (get) Token: 0x060205C8 RID: 132552 RVA: 0x008D078A File Offset: 0x008CE98A
		// (set) Token: 0x060205C9 RID: 132553 RVA: 0x008D079A File Offset: 0x008CE99A
		public unsafe float GroundHeightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700305E RID: 12382
		// (get) Token: 0x060205CA RID: 132554 RVA: 0x008D07AB File Offset: 0x008CE9AB
		// (set) Token: 0x060205CB RID: 132555 RVA: 0x008D07BF File Offset: 0x008CE9BF
		public unsafe FVector LeftPosOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700305F RID: 12383
		// (get) Token: 0x060205CC RID: 132556 RVA: 0x008D07D4 File Offset: 0x008CE9D4
		// (set) Token: 0x060205CD RID: 132557 RVA: 0x008D07E8 File Offset: 0x008CE9E8
		public unsafe FVector StartOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003060 RID: 12384
		// (get) Token: 0x060205CE RID: 132558 RVA: 0x008D07FD File Offset: 0x008CE9FD
		// (set) Token: 0x060205CF RID: 132559 RVA: 0x008D0811 File Offset: 0x008CEA11
		public unsafe FVector RuntimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003061 RID: 12385
		// (get) Token: 0x060205D0 RID: 132560 RVA: 0x008D0826 File Offset: 0x008CEA26
		// (set) Token: 0x060205D1 RID: 132561 RVA: 0x008D0836 File Offset: 0x008CEA36
		public unsafe int particleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003062 RID: 12386
		// (get) Token: 0x060205D2 RID: 132562 RVA: 0x008D0847 File Offset: 0x008CEA47
		// (set) Token: 0x060205D3 RID: 132563 RVA: 0x008D0857 File Offset: 0x008CEA57
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003063 RID: 12387
		// (get) Token: 0x060205D4 RID: 132564 RVA: 0x008D0868 File Offset: 0x008CEA68
		// (set) Token: 0x060205D5 RID: 132565 RVA: 0x008D087C File Offset: 0x008CEA7C
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x060205D6 RID: 132566 RVA: 0x008D0891 File Offset: 0x008CEA91
		// (set) Token: 0x060205D7 RID: 132567 RVA: 0x008D08A1 File Offset: 0x008CEAA1
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x060205D8 RID: 132568 RVA: 0x008D08B2 File Offset: 0x008CEAB2
		// (set) Token: 0x060205D9 RID: 132569 RVA: 0x008D08C2 File Offset: 0x008CEAC2
		public unsafe float volDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x060205DA RID: 132570 RVA: 0x008D08D3 File Offset: 0x008CEAD3
		// (set) Token: 0x060205DB RID: 132571 RVA: 0x008D08E7 File Offset: 0x008CEAE7
		public unsafe FVector startPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x060205DC RID: 132572 RVA: 0x008D08FC File Offset: 0x008CEAFC
		// (set) Token: 0x060205DD RID: 132573 RVA: 0x008D0910 File Offset: 0x008CEB10
		public unsafe FVector endPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x060205DE RID: 132574 RVA: 0x008D0928 File Offset: 0x008CEB28
		// (set) Token: 0x060205DF RID: 132575 RVA: 0x008D0961 File Offset: 0x008CEB61
		[Nullable(1)]
		public TArray<FName> NameList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._NameList) == null)
				{
					result = (this._NameList = new TArray<FName>(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_23, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NameList.CopyAssign(value);
			}
		}

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x060205E0 RID: 132576 RVA: 0x008D096F File Offset: 0x008CEB6F
		// (set) Token: 0x060205E1 RID: 132577 RVA: 0x008D0983 File Offset: 0x008CEB83
		public unsafe FVector leftPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x060205E2 RID: 132578 RVA: 0x008D0998 File Offset: 0x008CEB98
		// (set) Token: 0x060205E3 RID: 132579 RVA: 0x008D09AC File Offset: 0x008CEBAC
		public unsafe FVector rightPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x1700306B RID: 12395
		// (get) Token: 0x060205E4 RID: 132580 RVA: 0x008D09C1 File Offset: 0x008CEBC1
		// (set) Token: 0x060205E5 RID: 132581 RVA: 0x008D09D5 File Offset: 0x008CEBD5
		public unsafe FVector leftNorm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x060205E6 RID: 132582 RVA: 0x008D09EC File Offset: 0x008CEBEC
		// (set) Token: 0x060205E7 RID: 132583 RVA: 0x008D0A25 File Offset: 0x008CEC25
		[Nullable(1)]
		public TArray<FParticle_QiuQian> particleArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FParticle_QiuQian> result;
				if ((result = this._particleArr) == null)
				{
					result = (this._particleArr = new TArray<FParticle_QiuQian>(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_27, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.particleArr.CopyAssign(value);
			}
		}

		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x060205E8 RID: 132584 RVA: 0x008D0A33 File Offset: 0x008CEC33
		// (set) Token: 0x060205E9 RID: 132585 RVA: 0x008D0A47 File Offset: 0x008CEC47
		public unsafe FVector rightNorm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x060205EA RID: 132586 RVA: 0x008D0A5C File Offset: 0x008CEC5C
		// (set) Token: 0x060205EB RID: 132587 RVA: 0x008D0A6C File Offset: 0x008CEC6C
		public unsafe float pushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x060205EC RID: 132588 RVA: 0x008D0A7D File Offset: 0x008CEC7D
		// (set) Token: 0x060205ED RID: 132589 RVA: 0x008D0A8D File Offset: 0x008CEC8D
		public unsafe float endParticleMassScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x060205EE RID: 132590 RVA: 0x008D0A9E File Offset: 0x008CEC9E
		// (set) Token: 0x060205EF RID: 132591 RVA: 0x008D0AAE File Offset: 0x008CECAE
		public unsafe float debugDrawDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x060205F0 RID: 132592 RVA: 0x008D0AC0 File Offset: 0x008CECC0
		// (set) Token: 0x060205F1 RID: 132593 RVA: 0x008D0AF9 File Offset: 0x008CECF9
		[Nullable(1)]
		public TArray<USplineMeshComponent> SplineMesh
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USplineMeshComponent> result;
				if ((result = this._SplineMesh) == null)
				{
					result = (this._SplineMesh = new TArray<USplineMeshComponent>(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_32, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SplineMesh.CopyAssign(value);
			}
		}

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x060205F2 RID: 132594 RVA: 0x008D0B08 File Offset: 0x008CED08
		// (set) Token: 0x060205F3 RID: 132595 RVA: 0x008D0B41 File Offset: 0x008CED41
		[Nullable(1)]
		public TArray<USplineMeshComponent> SplineMeshR
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USplineMeshComponent> result;
				if ((result = this._SplineMeshR) == null)
				{
					result = (this._SplineMeshR = new TArray<USplineMeshComponent>(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_33, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SplineMeshR.CopyAssign(value);
			}
		}

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x060205F4 RID: 132596 RVA: 0x008D0B4F File Offset: 0x008CED4F
		// (set) Token: 0x060205F5 RID: 132597 RVA: 0x008D0B5F File Offset: 0x008CED5F
		public unsafe bool IsEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x060205F6 RID: 132598 RVA: 0x008D0B70 File Offset: 0x008CED70
		// (set) Token: 0x060205F7 RID: 132599 RVA: 0x008D0B80 File Offset: 0x008CED80
		public unsafe bool IsPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x060205F8 RID: 132600 RVA: 0x008D0B91 File Offset: 0x008CED91
		// (set) Token: 0x060205F9 RID: 132601 RVA: 0x008D0BA5 File Offset: 0x008CEDA5
		public unsafe UMaterialInstanceDynamic DMI_RopeL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x060205FA RID: 132602 RVA: 0x008D0BBA File Offset: 0x008CEDBA
		// (set) Token: 0x060205FB RID: 132603 RVA: 0x008D0BCE File Offset: 0x008CEDCE
		public unsafe UMaterialInstanceDynamic DMI_RopeR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingLightpipe_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x060205FC RID: 132604 RVA: 0x008D0BE3 File Offset: 0x008CEDE3
		// (set) Token: 0x060205FD RID: 132605 RVA: 0x008D0BF3 File Offset: 0x008CEDF3
		public unsafe float CurrentAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x060205FE RID: 132606 RVA: 0x008D0C04 File Offset: 0x008CEE04
		// (set) Token: 0x060205FF RID: 132607 RVA: 0x008D0C14 File Offset: 0x008CEE14
		public unsafe float AngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x06020600 RID: 132608 RVA: 0x008D0C25 File Offset: 0x008CEE25
		// (set) Token: 0x06020601 RID: 132609 RVA: 0x008D0C35 File Offset: 0x008CEE35
		public unsafe float TargetAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x06020602 RID: 132610 RVA: 0x008D0C46 File Offset: 0x008CEE46
		// (set) Token: 0x06020603 RID: 132611 RVA: 0x008D0C56 File Offset: 0x008CEE56
		public unsafe float SpringK
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x1700307B RID: 12411
		// (get) Token: 0x06020604 RID: 132612 RVA: 0x008D0C67 File Offset: 0x008CEE67
		// (set) Token: 0x06020605 RID: 132613 RVA: 0x008D0C77 File Offset: 0x008CEE77
		public unsafe float DampingC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SwingLightpipe_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x06020606 RID: 132614 RVA: 0x008D0C88 File Offset: 0x008CEE88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeParticleArr()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingLightpipe_C.__InitializeParticleArr_NativeFunctionPtr, null);
		}

		// Token: 0x06020607 RID: 132615 RVA: 0x008D0C9C File Offset: 0x008CEE9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetDMIOffsetEnable(bool OffsetEnable)
		{
			BP_SwingLightpipe_C.__SetDMIOffsetEnable_FunctionParams* ptr = stackalloc BP_SwingLightpipe_C.__SetDMIOffsetEnable_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(BP_SwingLightpipe_C.__SetDMIOffsetEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SwingLightpipe_C.__SetDMIOffsetEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OffsetEnable = OffsetEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingLightpipe_C.__SetDMIOffsetEnable_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020608 RID: 132616 RVA: 0x008D0CE2 File Offset: 0x008CEEE2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateaDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingLightpipe_C.__UpdateaDMI_NativeFunctionPtr, null);
		}

		// Token: 0x06020609 RID: 132617 RVA: 0x008D0CF6 File Offset: 0x008CEEF6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingLightpipe_C.__InitializeDMI_NativeFunctionPtr, null);
		}

		// Token: 0x0602060A RID: 132618 RVA: 0x008D0D0C File Offset: 0x008CEF0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void solve(bool isPinned, FVector pos, FVector linkPos, float targetLen, FVector emitterOriginPos, ref FVector pos_new)
		{
			BP_SwingLightpipe_C.__solve_FunctionParams* ptr = stackalloc BP_SwingLightpipe_C.__solve_FunctionParams[(UIntPtr)131] + 15L / (long)sizeof(BP_SwingLightpipe_C.__solve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SwingLightpipe_C.__solve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isPinned = isPinned;
			ptr->pos = pos;
			ptr->linkPos = linkPos;
			ptr->targetLen = targetLen;
			ptr->emitterOriginPos = emitterOriginPos;
			ptr->pos_new = pos_new;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingLightpipe_C.__solve_NativeFunctionPtr, (void*)ptr);
			pos_new = ptr->pos_new;
		}

		// Token: 0x0602060B RID: 132619 RVA: 0x008D0D8D File Offset: 0x008CEF8D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingLightpipe_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602060C RID: 132620 RVA: 0x008D0DA1 File Offset: 0x008CEFA1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SwingLightpipe_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602060D RID: 132621 RVA: 0x008D0DB6 File Offset: 0x008CEFB6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingLightpipe_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602060E RID: 132622 RVA: 0x008D0DCA File Offset: 0x008CEFCA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SwingLightpipe_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602060F RID: 132623 RVA: 0x008D0DE0 File Offset: 0x008CEFE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SwingLightpipe_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SwingLightpipe_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SwingLightpipe_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SwingLightpipe_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingLightpipe_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020610 RID: 132624 RVA: 0x008D0E28 File Offset: 0x008CF028
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SwingLightpipe_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SwingLightpipe_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SwingLightpipe_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SwingLightpipe_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SwingLightpipe_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020611 RID: 132625 RVA: 0x008D0E6F File Offset: 0x008CF06F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void place_plank_event()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingLightpipe_C.__place_plank_event_NativeFunctionPtr, null);
		}

		// Token: 0x06020612 RID: 132626 RVA: 0x008D0E83 File Offset: 0x008CF083
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingLightpipe_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06020613 RID: 132627 RVA: 0x008D0E97 File Offset: 0x008CF097
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SwingLightpipe_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020614 RID: 132628 RVA: 0x008D0EAC File Offset: 0x008CF0AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingLightpipe_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06020615 RID: 132629 RVA: 0x008D0EC0 File Offset: 0x008CF0C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SwingLightpipe_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020616 RID: 132630 RVA: 0x008D0ED8 File Offset: 0x008CF0D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_SwingLightpipe_C.__BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_SwingLightpipe_C.__BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_SwingLightpipe_C.__BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SwingLightpipe_C.__BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingLightpipe_C.__BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020617 RID: 132631 RVA: 0x008D0F94 File Offset: 0x008CF194
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapBlockSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_SwingLightpipe_C.__BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapBlockSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_SwingLightpipe_C.__BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapBlockSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_SwingLightpipe_C.__BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapBlockSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SwingLightpipe_C.__BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapBlockSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingLightpipe_C.__BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapBlockSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020618 RID: 132632 RVA: 0x008D104E File Offset: 0x008CF24E
		protected BP_SwingLightpipe_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA79 RID: 64121
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_SwingLightpipe.BP_SwingLightpipe_C";

		// Token: 0x0400FA7A RID: 64122
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA7B RID: 64123
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA7C RID: 64124
		internal new static int __PropertyOffset_1;

		// Token: 0x0400FA7D RID: 64125
		internal static int __PropertyOffset_2;

		// Token: 0x0400FA7E RID: 64126
		internal static int __PropertyOffset_3;

		// Token: 0x0400FA7F RID: 64127
		internal static int __PropertyOffset_4;

		// Token: 0x0400FA80 RID: 64128
		internal static int __PropertyOffset_5;

		// Token: 0x0400FA81 RID: 64129
		internal static int __PropertyOffset_6;

		// Token: 0x0400FA82 RID: 64130
		internal static int __PropertyOffset_7;

		// Token: 0x0400FA83 RID: 64131
		internal static int __PropertyOffset_8;

		// Token: 0x0400FA84 RID: 64132
		internal static int __PropertyOffset_9;

		// Token: 0x0400FA85 RID: 64133
		internal static int __PropertyOffset_10;

		// Token: 0x0400FA86 RID: 64134
		internal static int __PropertyOffset_11;

		// Token: 0x0400FA87 RID: 64135
		internal static int __PropertyOffset_12;

		// Token: 0x0400FA88 RID: 64136
		internal static int __PropertyOffset_13;

		// Token: 0x0400FA89 RID: 64137
		internal static int __PropertyOffset_14;

		// Token: 0x0400FA8A RID: 64138
		internal static int __PropertyOffset_15;

		// Token: 0x0400FA8B RID: 64139
		internal static int __PropertyOffset_16;

		// Token: 0x0400FA8C RID: 64140
		internal static int __PropertyOffset_17;

		// Token: 0x0400FA8D RID: 64141
		internal static int __PropertyOffset_18;

		// Token: 0x0400FA8E RID: 64142
		internal static int __PropertyOffset_19;

		// Token: 0x0400FA8F RID: 64143
		internal static int __PropertyOffset_20;

		// Token: 0x0400FA90 RID: 64144
		internal static int __PropertyOffset_21;

		// Token: 0x0400FA91 RID: 64145
		internal static int __PropertyOffset_22;

		// Token: 0x0400FA92 RID: 64146
		internal static int __PropertyOffset_23;

		// Token: 0x0400FA93 RID: 64147
		private TArray<FName> _NameList;

		// Token: 0x0400FA94 RID: 64148
		internal static int __PropertyOffset_24;

		// Token: 0x0400FA95 RID: 64149
		internal static int __PropertyOffset_25;

		// Token: 0x0400FA96 RID: 64150
		internal static int __PropertyOffset_26;

		// Token: 0x0400FA97 RID: 64151
		internal static int __PropertyOffset_27;

		// Token: 0x0400FA98 RID: 64152
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FParticle_QiuQian> _particleArr;

		// Token: 0x0400FA99 RID: 64153
		internal static int __PropertyOffset_28;

		// Token: 0x0400FA9A RID: 64154
		internal static int __PropertyOffset_29;

		// Token: 0x0400FA9B RID: 64155
		internal static int __PropertyOffset_30;

		// Token: 0x0400FA9C RID: 64156
		internal static int __PropertyOffset_31;

		// Token: 0x0400FA9D RID: 64157
		internal static int __PropertyOffset_32;

		// Token: 0x0400FA9E RID: 64158
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USplineMeshComponent> _SplineMesh;

		// Token: 0x0400FA9F RID: 64159
		internal static int __PropertyOffset_33;

		// Token: 0x0400FAA0 RID: 64160
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USplineMeshComponent> _SplineMeshR;

		// Token: 0x0400FAA1 RID: 64161
		internal static int __PropertyOffset_34;

		// Token: 0x0400FAA2 RID: 64162
		internal static int __PropertyOffset_35;

		// Token: 0x0400FAA3 RID: 64163
		internal static int __PropertyOffset_36;

		// Token: 0x0400FAA4 RID: 64164
		internal static int __PropertyOffset_37;

		// Token: 0x0400FAA5 RID: 64165
		internal static int __PropertyOffset_38;

		// Token: 0x0400FAA6 RID: 64166
		internal static int __PropertyOffset_39;

		// Token: 0x0400FAA7 RID: 64167
		internal static int __PropertyOffset_40;

		// Token: 0x0400FAA8 RID: 64168
		internal static int __PropertyOffset_41;

		// Token: 0x0400FAA9 RID: 64169
		internal static int __PropertyOffset_42;

		// Token: 0x0400FAAA RID: 64170
		private static IntPtr __InitializeParticleArr_NativeFunctionPtr;

		// Token: 0x0400FAAB RID: 64171
		private static IntPtr __SetDMIOffsetEnable_NativeFunctionPtr;

		// Token: 0x0400FAAC RID: 64172
		private static IntPtr __UpdateaDMI_NativeFunctionPtr;

		// Token: 0x0400FAAD RID: 64173
		private static IntPtr __InitializeDMI_NativeFunctionPtr;

		// Token: 0x0400FAAE RID: 64174
		private static IntPtr __solve_NativeFunctionPtr;

		// Token: 0x0400FAAF RID: 64175
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FAB0 RID: 64176
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FAB1 RID: 64177
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FAB2 RID: 64178
		private static IntPtr __place_plank_event_NativeFunctionPtr;

		// Token: 0x0400FAB3 RID: 64179
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x0400FAB4 RID: 64180
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x0400FAB5 RID: 64181
		private static IntPtr __BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FAB6 RID: 64182
		private static IntPtr __BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapBlockSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009BA8 RID: 39848
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __SetDMIOffsetEnable_FunctionParams
		{
			// Token: 0x04031210 RID: 201232
			[FieldOffset(0)]
			public bool OffsetEnable;
		}

		// Token: 0x02009BA9 RID: 39849
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 116)]
		protected ref struct __solve_FunctionParams
		{
			// Token: 0x04031211 RID: 201233
			[FieldOffset(0)]
			public bool isPinned;

			// Token: 0x04031212 RID: 201234
			[FieldOffset(4)]
			public FVector pos;

			// Token: 0x04031213 RID: 201235
			[FieldOffset(16)]
			public FVector linkPos;

			// Token: 0x04031214 RID: 201236
			[FieldOffset(28)]
			public float targetLen;

			// Token: 0x04031215 RID: 201237
			[FieldOffset(32)]
			public FVector emitterOriginPos;

			// Token: 0x04031216 RID: 201238
			[FieldOffset(44)]
			public FVector pos_new;
		}

		// Token: 0x02009BAA RID: 39850
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031217 RID: 201239
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009BAB RID: 39851
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031218 RID: 201240
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031219 RID: 201241
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403121A RID: 201242
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403121B RID: 201243
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403121C RID: 201244
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403121D RID: 201245
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009BAC RID: 39852
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_SwingLightpipe_SM_Ins_Lig_02AS_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapBlockSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403121E RID: 201246
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403121F RID: 201247
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031220 RID: 201248
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031221 RID: 201249
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031222 RID: 201250
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031223 RID: 201251
			[FieldOffset(32)]
			public byte SweepResult;
		}
	}
}
