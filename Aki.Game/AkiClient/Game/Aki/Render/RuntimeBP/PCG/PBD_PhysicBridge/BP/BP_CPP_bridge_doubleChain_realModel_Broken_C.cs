using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_PhysicBridge.BP
{
	// Token: 0x02003C42 RID: 15426
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_CPP_bridge_doubleChain_realModel_Broken.BP_CPP_bridge_doubleChain_realModel_Broken_C")]
	[UnrealStructLayout(1912, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1906)]
	public class BP_CPP_bridge_doubleChain_realModel_Broken_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023A83 RID: 146051 RVA: 0x009290EF File Offset: 0x009272EF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CPP_bridge_doubleChain_realModel_Broken_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_CPP_bridge_doubleChain_realModel_Broken.BP_CPP_bridge_doubleChain_realModel_Broken_C");
			}
			return BP_CPP_bridge_doubleChain_realModel_Broken_C._ClassPtr;
		}

		// Token: 0x06023A84 RID: 146052 RVA: 0x00929114 File Offset: 0x00927314
		public BP_CPP_bridge_doubleChain_realModel_Broken_C() : this(BuiltinUtils.AllocNativeUObject(BP_CPP_bridge_doubleChain_realModel_Broken_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023A85 RID: 146053 RVA: 0x0092913C File Offset: 0x0092733C
		public BP_CPP_bridge_doubleChain_realModel_Broken_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CPP_bridge_doubleChain_realModel_Broken_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042D0 RID: 17104
		// (get) Token: 0x06023A86 RID: 146054 RVA: 0x0092916F File Offset: 0x0092736F
		// (set) Token: 0x06023A87 RID: 146055 RVA: 0x00929183 File Offset: 0x00927383
		[Nullable(2)]
		public unsafe USphereComponent Sphere1
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170042D1 RID: 17105
		// (get) Token: 0x06023A88 RID: 146056 RVA: 0x00929198 File Offset: 0x00927398
		// (set) Token: 0x06023A89 RID: 146057 RVA: 0x009291AC File Offset: 0x009273AC
		[Nullable(2)]
		public unsafe USphereComponent Sphere
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170042D2 RID: 17106
		// (get) Token: 0x06023A8A RID: 146058 RVA: 0x009291C1 File Offset: 0x009273C1
		// (set) Token: 0x06023A8B RID: 146059 RVA: 0x009291D5 File Offset: 0x009273D5
		[Nullable(2)]
		public unsafe UBoxComponent Box
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170042D3 RID: 17107
		// (get) Token: 0x06023A8C RID: 146060 RVA: 0x009291EA File Offset: 0x009273EA
		// (set) Token: 0x06023A8D RID: 146061 RVA: 0x009291FE File Offset: 0x009273FE
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_4);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170042D4 RID: 17108
		// (get) Token: 0x06023A8E RID: 146062 RVA: 0x00929214 File Offset: 0x00927414
		// (set) Token: 0x06023A8F RID: 146063 RVA: 0x0092924D File Offset: 0x0092744D
		public TArray<FVector> posArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._posArr) == null)
				{
					result = (this._posArr = new TArray<FVector>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.posArr.CopyAssign(value);
			}
		}

		// Token: 0x170042D5 RID: 17109
		// (get) Token: 0x06023A90 RID: 146064 RVA: 0x0092925C File Offset: 0x0092745C
		// (set) Token: 0x06023A91 RID: 146065 RVA: 0x00929295 File Offset: 0x00927495
		public TArray<FVector> volArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._volArr) == null)
				{
					result = (this._volArr = new TArray<FVector>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.volArr.CopyAssign(value);
			}
		}

		// Token: 0x170042D6 RID: 17110
		// (get) Token: 0x06023A92 RID: 146066 RVA: 0x009292A4 File Offset: 0x009274A4
		// (set) Token: 0x06023A93 RID: 146067 RVA: 0x009292DD File Offset: 0x009274DD
		public TArray<FVector> posArr_foe
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._posArr_foe) == null)
				{
					result = (this._posArr_foe = new TArray<FVector>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.posArr_foe.CopyAssign(value);
			}
		}

		// Token: 0x170042D7 RID: 17111
		// (get) Token: 0x06023A94 RID: 146068 RVA: 0x009292EB File Offset: 0x009274EB
		// (set) Token: 0x06023A95 RID: 146069 RVA: 0x009292FB File Offset: 0x009274FB
		public unsafe int particleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170042D8 RID: 17112
		// (get) Token: 0x06023A96 RID: 146070 RVA: 0x0092930C File Offset: 0x0092750C
		// (set) Token: 0x06023A97 RID: 146071 RVA: 0x0092931C File Offset: 0x0092751C
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170042D9 RID: 17113
		// (get) Token: 0x06023A98 RID: 146072 RVA: 0x0092932D File Offset: 0x0092752D
		// (set) Token: 0x06023A99 RID: 146073 RVA: 0x00929341 File Offset: 0x00927541
		public unsafe FVector emitterOriginPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170042DA RID: 17114
		// (get) Token: 0x06023A9A RID: 146074 RVA: 0x00929356 File Offset: 0x00927556
		// (set) Token: 0x06023A9B RID: 146075 RVA: 0x0092936A File Offset: 0x0092756A
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170042DB RID: 17115
		// (get) Token: 0x06023A9C RID: 146076 RVA: 0x0092937F File Offset: 0x0092757F
		// (set) Token: 0x06023A9D RID: 146077 RVA: 0x0092938F File Offset: 0x0092758F
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170042DC RID: 17116
		// (get) Token: 0x06023A9E RID: 146078 RVA: 0x009293A0 File Offset: 0x009275A0
		// (set) Token: 0x06023A9F RID: 146079 RVA: 0x009293B0 File Offset: 0x009275B0
		public unsafe long frameID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170042DD RID: 17117
		// (get) Token: 0x06023AA0 RID: 146080 RVA: 0x009293C1 File Offset: 0x009275C1
		// (set) Token: 0x06023AA1 RID: 146081 RVA: 0x009293D1 File Offset: 0x009275D1
		public unsafe float volDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170042DE RID: 17118
		// (get) Token: 0x06023AA2 RID: 146082 RVA: 0x009293E2 File Offset: 0x009275E2
		// (set) Token: 0x06023AA3 RID: 146083 RVA: 0x009293F6 File Offset: 0x009275F6
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic DMI
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_15);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x170042DF RID: 17119
		// (get) Token: 0x06023AA4 RID: 146084 RVA: 0x0092940B File Offset: 0x0092760B
		// (set) Token: 0x06023AA5 RID: 146085 RVA: 0x0092941F File Offset: 0x0092761F
		public unsafe FVector startPinPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170042E0 RID: 17120
		// (get) Token: 0x06023AA6 RID: 146086 RVA: 0x00929434 File Offset: 0x00927634
		// (set) Token: 0x06023AA7 RID: 146087 RVA: 0x00929448 File Offset: 0x00927648
		public unsafe FVector endPinPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170042E1 RID: 17121
		// (get) Token: 0x06023AA8 RID: 146088 RVA: 0x00929460 File Offset: 0x00927660
		// (set) Token: 0x06023AA9 RID: 146089 RVA: 0x00929499 File Offset: 0x00927699
		public TArray<UStaticMeshComponent> plankList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._plankList) == null)
				{
					result = (this._plankList = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_18, this));
				}
				return result;
			}
			set
			{
				this.plankList.CopyAssign(value);
			}
		}

		// Token: 0x170042E2 RID: 17122
		// (get) Token: 0x06023AAA RID: 146090 RVA: 0x009294A7 File Offset: 0x009276A7
		// (set) Token: 0x06023AAB RID: 146091 RVA: 0x009294B7 File Offset: 0x009276B7
		public unsafe float pushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170042E3 RID: 17123
		// (get) Token: 0x06023AAC RID: 146092 RVA: 0x009294C8 File Offset: 0x009276C8
		// (set) Token: 0x06023AAD RID: 146093 RVA: 0x00929501 File Offset: 0x00927701
		public TArray<FVector> posArr_r
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._posArr_r) == null)
				{
					result = (this._posArr_r = new TArray<FVector>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_20, this));
				}
				return result;
			}
			set
			{
				this.posArr_r.CopyAssign(value);
			}
		}

		// Token: 0x170042E4 RID: 17124
		// (get) Token: 0x06023AAE RID: 146094 RVA: 0x00929510 File Offset: 0x00927710
		// (set) Token: 0x06023AAF RID: 146095 RVA: 0x00929549 File Offset: 0x00927749
		public TArray<FVector> volArr_r
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._volArr_r) == null)
				{
					result = (this._volArr_r = new TArray<FVector>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_21, this));
				}
				return result;
			}
			set
			{
				this.volArr_r.CopyAssign(value);
			}
		}

		// Token: 0x170042E5 RID: 17125
		// (get) Token: 0x06023AB0 RID: 146096 RVA: 0x00929558 File Offset: 0x00927758
		// (set) Token: 0x06023AB1 RID: 146097 RVA: 0x00929591 File Offset: 0x00927791
		public TArray<FVector> posArr_foe_r
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._posArr_foe_r) == null)
				{
					result = (this._posArr_foe_r = new TArray<FVector>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_22, this));
				}
				return result;
			}
			set
			{
				this.posArr_foe_r.CopyAssign(value);
			}
		}

		// Token: 0x170042E6 RID: 17126
		// (get) Token: 0x06023AB2 RID: 146098 RVA: 0x0092959F File Offset: 0x0092779F
		// (set) Token: 0x06023AB3 RID: 146099 RVA: 0x009295B3 File Offset: 0x009277B3
		public unsafe FVector startPinPos_r
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170042E7 RID: 17127
		// (get) Token: 0x06023AB4 RID: 146100 RVA: 0x009295C8 File Offset: 0x009277C8
		// (set) Token: 0x06023AB5 RID: 146101 RVA: 0x009295DC File Offset: 0x009277DC
		public unsafe FVector endPinPos_r
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170042E8 RID: 17128
		// (get) Token: 0x06023AB6 RID: 146102 RVA: 0x009295F1 File Offset: 0x009277F1
		// (set) Token: 0x06023AB7 RID: 146103 RVA: 0x00929601 File Offset: 0x00927801
		public unsafe float percentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170042E9 RID: 17129
		// (get) Token: 0x06023AB8 RID: 146104 RVA: 0x00929612 File Offset: 0x00927812
		// (set) Token: 0x06023AB9 RID: 146105 RVA: 0x00929622 File Offset: 0x00927822
		public unsafe bool onBridge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042EA RID: 17130
		// (get) Token: 0x06023ABA RID: 146106 RVA: 0x00929634 File Offset: 0x00927834
		// (set) Token: 0x06023ABB RID: 146107 RVA: 0x0092966D File Offset: 0x0092786D
		public TArray<float> foeDisList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._foeDisList) == null)
				{
					result = (this._foeDisList = new TArray<float>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_27, this));
				}
				return result;
			}
			set
			{
				this.foeDisList.CopyAssign(value);
			}
		}

		// Token: 0x170042EB RID: 17131
		// (get) Token: 0x06023ABC RID: 146108 RVA: 0x0092967C File Offset: 0x0092787C
		// (set) Token: 0x06023ABD RID: 146109 RVA: 0x009296B5 File Offset: 0x009278B5
		public TArray<float> foeDisList_r
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._foeDisList_r) == null)
				{
					result = (this._foeDisList_r = new TArray<float>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_28, this));
				}
				return result;
			}
			set
			{
				this.foeDisList_r.CopyAssign(value);
			}
		}

		// Token: 0x170042EC RID: 17132
		// (get) Token: 0x06023ABE RID: 146110 RVA: 0x009296C4 File Offset: 0x009278C4
		// (set) Token: 0x06023ABF RID: 146111 RVA: 0x009296FD File Offset: 0x009278FD
		public TArray<float> nxtDisList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._nxtDisList) == null)
				{
					result = (this._nxtDisList = new TArray<float>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_29, this));
				}
				return result;
			}
			set
			{
				this.nxtDisList.CopyAssign(value);
			}
		}

		// Token: 0x170042ED RID: 17133
		// (get) Token: 0x06023AC0 RID: 146112 RVA: 0x0092970C File Offset: 0x0092790C
		// (set) Token: 0x06023AC1 RID: 146113 RVA: 0x00929745 File Offset: 0x00927945
		public TArray<float> nxtDisList_r
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._nxtDisList_r) == null)
				{
					result = (this._nxtDisList_r = new TArray<float>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_30, this));
				}
				return result;
			}
			set
			{
				this.nxtDisList_r.CopyAssign(value);
			}
		}

		// Token: 0x170042EE RID: 17134
		// (get) Token: 0x06023AC2 RID: 146114 RVA: 0x00929753 File Offset: 0x00927953
		// (set) Token: 0x06023AC3 RID: 146115 RVA: 0x00929763 File Offset: 0x00927963
		public unsafe float offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170042EF RID: 17135
		// (get) Token: 0x06023AC4 RID: 146116 RVA: 0x00929774 File Offset: 0x00927974
		// (set) Token: 0x06023AC5 RID: 146117 RVA: 0x00929784 File Offset: 0x00927984
		public unsafe float linkDisScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170042F0 RID: 17136
		// (get) Token: 0x06023AC6 RID: 146118 RVA: 0x00929795 File Offset: 0x00927995
		// (set) Token: 0x06023AC7 RID: 146119 RVA: 0x009297A9 File Offset: 0x009279A9
		[Nullable(2)]
		public unsafe AActor bridgeModels
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_33);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x170042F1 RID: 17137
		// (get) Token: 0x06023AC8 RID: 146120 RVA: 0x009297BE File Offset: 0x009279BE
		// (set) Token: 0x06023AC9 RID: 146121 RVA: 0x009297CE File Offset: 0x009279CE
		public unsafe float BreakPushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x170042F2 RID: 17138
		// (get) Token: 0x06023ACA RID: 146122 RVA: 0x009297DF File Offset: 0x009279DF
		// (set) Token: 0x06023ACB RID: 146123 RVA: 0x009297EF File Offset: 0x009279EF
		public unsafe bool Broken
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042F3 RID: 17139
		// (get) Token: 0x06023ACC RID: 146124 RVA: 0x00929800 File Offset: 0x00927A00
		// (set) Token: 0x06023ACD RID: 146125 RVA: 0x00929814 File Offset: 0x00927A14
		public unsafe FVector Broken_Sim_Accel_Ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x170042F4 RID: 17140
		// (get) Token: 0x06023ACE RID: 146126 RVA: 0x00929829 File Offset: 0x00927A29
		// (set) Token: 0x06023ACF RID: 146127 RVA: 0x00929839 File Offset: 0x00927A39
		public unsafe float Broken_Sim_Vol_Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x170042F5 RID: 17141
		// (get) Token: 0x06023AD0 RID: 146128 RVA: 0x0092984A File Offset: 0x00927A4A
		// (set) Token: 0x06023AD1 RID: 146129 RVA: 0x0092985A File Offset: 0x00927A5A
		public unsafe int BreakBothIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x170042F6 RID: 17142
		// (get) Token: 0x06023AD2 RID: 146130 RVA: 0x0092986B File Offset: 0x00927A6B
		// (set) Token: 0x06023AD3 RID: 146131 RVA: 0x0092987B File Offset: 0x00927A7B
		public unsafe int LeftBreakExtraStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x170042F7 RID: 17143
		// (get) Token: 0x06023AD4 RID: 146132 RVA: 0x0092988C File Offset: 0x00927A8C
		// (set) Token: 0x06023AD5 RID: 146133 RVA: 0x0092989C File Offset: 0x00927A9C
		public unsafe int LeftBreakExtraEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x170042F8 RID: 17144
		// (get) Token: 0x06023AD6 RID: 146134 RVA: 0x009298AD File Offset: 0x00927AAD
		// (set) Token: 0x06023AD7 RID: 146135 RVA: 0x009298BD File Offset: 0x00927ABD
		public unsafe int RightBreakExtraStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x170042F9 RID: 17145
		// (get) Token: 0x06023AD8 RID: 146136 RVA: 0x009298CE File Offset: 0x00927ACE
		// (set) Token: 0x06023AD9 RID: 146137 RVA: 0x009298DE File Offset: 0x00927ADE
		public unsafe int RightBreakExtraEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x170042FA RID: 17146
		// (get) Token: 0x06023ADA RID: 146138 RVA: 0x009298EF File Offset: 0x00927AEF
		// (set) Token: 0x06023ADB RID: 146139 RVA: 0x009298FF File Offset: 0x00927AFF
		public unsafe float Plank_Rest_Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x170042FB RID: 17147
		// (get) Token: 0x06023ADC RID: 146140 RVA: 0x00929910 File Offset: 0x00927B10
		// (set) Token: 0x06023ADD RID: 146141 RVA: 0x00929949 File Offset: 0x00927B49
		public TArray<byte> Particle_Chain_Link_Mask
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._Particle_Chain_Link_Mask) == null)
				{
					result = (this._Particle_Chain_Link_Mask = new TArray<byte>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_44, this));
				}
				return result;
			}
			set
			{
				this.Particle_Chain_Link_Mask.CopyAssign(value);
			}
		}

		// Token: 0x170042FC RID: 17148
		// (get) Token: 0x06023ADE RID: 146142 RVA: 0x00929958 File Offset: 0x00927B58
		// (set) Token: 0x06023ADF RID: 146143 RVA: 0x00929991 File Offset: 0x00927B91
		public TArray<byte> Particle_Chain_Link_Mask_R
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._Particle_Chain_Link_Mask_R) == null)
				{
					result = (this._Particle_Chain_Link_Mask_R = new TArray<byte>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_45, this));
				}
				return result;
			}
			set
			{
				this.Particle_Chain_Link_Mask_R.CopyAssign(value);
			}
		}

		// Token: 0x170042FD RID: 17149
		// (get) Token: 0x06023AE0 RID: 146144 RVA: 0x0092999F File Offset: 0x00927B9F
		// (set) Token: 0x06023AE1 RID: 146145 RVA: 0x009299AF File Offset: 0x00927BAF
		public unsafe float GroundZOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x170042FE RID: 17150
		// (get) Token: 0x06023AE2 RID: 146146 RVA: 0x009299C0 File Offset: 0x00927BC0
		// (set) Token: 0x06023AE3 RID: 146147 RVA: 0x009299D0 File Offset: 0x00927BD0
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_47) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_47) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042FF RID: 17151
		// (get) Token: 0x06023AE4 RID: 146148 RVA: 0x009299E4 File Offset: 0x00927BE4
		// (set) Token: 0x06023AE5 RID: 146149 RVA: 0x00929A1D File Offset: 0x00927C1D
		public TArray<FKuroBridgeChunkMeshList> BridgeFractureSet
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroBridgeChunkMeshList> result;
				if ((result = this._BridgeFractureSet) == null)
				{
					result = (this._BridgeFractureSet = new TArray<FKuroBridgeChunkMeshList>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_48, this));
				}
				return result;
			}
			set
			{
				this.BridgeFractureSet.CopyAssign(value);
			}
		}

		// Token: 0x17004300 RID: 17152
		// (get) Token: 0x06023AE6 RID: 146150 RVA: 0x00929A2B File Offset: 0x00927C2B
		// (set) Token: 0x06023AE7 RID: 146151 RVA: 0x00929A3B File Offset: 0x00927C3B
		public unsafe bool bIsBreakable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004301 RID: 17153
		// (get) Token: 0x06023AE8 RID: 146152 RVA: 0x00929A4C File Offset: 0x00927C4C
		// (set) Token: 0x06023AE9 RID: 146153 RVA: 0x00929A5C File Offset: 0x00927C5C
		public unsafe bool bInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_50) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_Broken_C.__PropertyOffset_50) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023AEA RID: 146154 RVA: 0x00929A6D File Offset: 0x00927C6D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RecoverSideBlock()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_Broken_C.__RecoverSideBlock_NativeFunctionPtr, null);
		}

		// Token: 0x06023AEB RID: 146155 RVA: 0x00929A84 File Offset: 0x00927C84
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void getTangent(ref TArray<FVector> posArr, ref TArray<FVector> posArrR, int index, ref FVector tangent)
		{
			BP_CPP_bridge_doubleChain_realModel_Broken_C.__getTangent_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_Broken_C.__getTangent_FunctionParams[(UIntPtr)311] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_Broken_C.__getTangent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_Broken_C.__getTangent_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVector> tarray = posArr;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->posArr);
			}
			TArray<FVector> tarray2 = posArrR;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->posArrR);
			}
			ptr->index = index;
			ptr->tangent = tangent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_Broken_C.__getTangent_NativeFunctionPtr, (void*)ptr);
			TArray<FVector> tarray3 = posArr;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->posArr);
			}
			TArray<FVector> tarray4 = posArrR;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->posArrR);
			}
			tangent = ptr->tangent;
			UnrealReflectionUtils.DestroyStruct(BP_CPP_bridge_doubleChain_realModel_Broken_C.__getTangent_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06023AEC RID: 146156 RVA: 0x00929B48 File Offset: 0x00927D48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void solve(bool isPinned, FVector pos, FVector linkPos, float targetLen, FVector emitterOriginPos, ref FVector pos_new)
		{
			BP_CPP_bridge_doubleChain_realModel_Broken_C.__solve_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_Broken_C.__solve_FunctionParams[(UIntPtr)131] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_Broken_C.__solve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_Broken_C.__solve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isPinned = isPinned;
			ptr->pos = pos;
			ptr->linkPos = linkPos;
			ptr->targetLen = targetLen;
			ptr->emitterOriginPos = emitterOriginPos;
			ptr->pos_new = pos_new;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_Broken_C.__solve_NativeFunctionPtr, (void*)ptr);
			pos_new = ptr->pos_new;
		}

		// Token: 0x06023AED RID: 146157 RVA: 0x00929BC9 File Offset: 0x00927DC9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_Broken_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023AEE RID: 146158 RVA: 0x00929BDD File Offset: 0x00927DDD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_Broken_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023AEF RID: 146159 RVA: 0x00929BF4 File Offset: 0x00927DF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_9ED3A0014CAE76088E4760B193BF3A56(int PlayingID)
		{
			BP_CPP_bridge_doubleChain_realModel_Broken_C.__Completed_9ED3A0014CAE76088E4760B193BF3A56_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_Broken_C.__Completed_9ED3A0014CAE76088E4760B193BF3A56_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_Broken_C.__Completed_9ED3A0014CAE76088E4760B193BF3A56_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_Broken_C.__Completed_9ED3A0014CAE76088E4760B193BF3A56_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_Broken_C.__Completed_9ED3A0014CAE76088E4760B193BF3A56_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023AF0 RID: 146160 RVA: 0x00929C3C File Offset: 0x00927E3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_D335450D4E966E00060072B19DB6B342(int PlayingID)
		{
			BP_CPP_bridge_doubleChain_realModel_Broken_C.__Completed_D335450D4E966E00060072B19DB6B342_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_Broken_C.__Completed_D335450D4E966E00060072B19DB6B342_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_Broken_C.__Completed_D335450D4E966E00060072B19DB6B342_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_Broken_C.__Completed_D335450D4E966E00060072B19DB6B342_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_Broken_C.__Completed_D335450D4E966E00060072B19DB6B342_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023AF1 RID: 146161 RVA: 0x00929C82 File Offset: 0x00927E82
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_Broken_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023AF2 RID: 146162 RVA: 0x00929C96 File Offset: 0x00927E96
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_Broken_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023AF3 RID: 146163 RVA: 0x00929CAC File Offset: 0x00927EAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CPP_bridge_doubleChain_realModel_Broken_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_Broken_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_Broken_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_Broken_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_Broken_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023AF4 RID: 146164 RVA: 0x00929CF4 File Offset: 0x00927EF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CPP_bridge_doubleChain_realModel_Broken_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_Broken_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_Broken_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_Broken_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_Broken_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023AF5 RID: 146165 RVA: 0x00929D3C File Offset: 0x00927F3C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_CPP_bridge_doubleChain_realModel_Broken_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_Broken_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_Broken_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_Broken_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_Broken_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023AF6 RID: 146166 RVA: 0x00929DF8 File Offset: 0x00927FF8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_CPP_bridge_doubleChain_realModel_Broken_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_Broken_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_Broken_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_Broken_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_Broken_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023AF7 RID: 146167 RVA: 0x00929E84 File Offset: 0x00928084
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_CPP_bridge_doubleChain_realModel_Broken_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_Broken_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_Broken_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_Broken_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_Broken_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023AF8 RID: 146168 RVA: 0x00929EE7 File Offset: 0x009280E7
		protected BP_CPP_bridge_doubleChain_realModel_Broken_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040119C2 RID: 72130
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_CPP_bridge_doubleChain_realModel_Broken.BP_CPP_bridge_doubleChain_realModel_Broken_C";

		// Token: 0x040119C3 RID: 72131
		private static IntPtr _ClassPtr;

		// Token: 0x040119C4 RID: 72132
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119C5 RID: 72133
		internal static int __PropertyOffset_1;

		// Token: 0x040119C6 RID: 72134
		internal static int __PropertyOffset_2;

		// Token: 0x040119C7 RID: 72135
		internal static int __PropertyOffset_3;

		// Token: 0x040119C8 RID: 72136
		internal static int __PropertyOffset_4;

		// Token: 0x040119C9 RID: 72137
		internal static int __PropertyOffset_5;

		// Token: 0x040119CA RID: 72138
		[Nullable(2)]
		private TArray<FVector> _posArr;

		// Token: 0x040119CB RID: 72139
		internal static int __PropertyOffset_6;

		// Token: 0x040119CC RID: 72140
		[Nullable(2)]
		private TArray<FVector> _volArr;

		// Token: 0x040119CD RID: 72141
		internal static int __PropertyOffset_7;

		// Token: 0x040119CE RID: 72142
		[Nullable(2)]
		private TArray<FVector> _posArr_foe;

		// Token: 0x040119CF RID: 72143
		internal static int __PropertyOffset_8;

		// Token: 0x040119D0 RID: 72144
		internal static int __PropertyOffset_9;

		// Token: 0x040119D1 RID: 72145
		internal static int __PropertyOffset_10;

		// Token: 0x040119D2 RID: 72146
		internal static int __PropertyOffset_11;

		// Token: 0x040119D3 RID: 72147
		internal static int __PropertyOffset_12;

		// Token: 0x040119D4 RID: 72148
		internal static int __PropertyOffset_13;

		// Token: 0x040119D5 RID: 72149
		internal static int __PropertyOffset_14;

		// Token: 0x040119D6 RID: 72150
		internal static int __PropertyOffset_15;

		// Token: 0x040119D7 RID: 72151
		internal static int __PropertyOffset_16;

		// Token: 0x040119D8 RID: 72152
		internal static int __PropertyOffset_17;

		// Token: 0x040119D9 RID: 72153
		internal static int __PropertyOffset_18;

		// Token: 0x040119DA RID: 72154
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _plankList;

		// Token: 0x040119DB RID: 72155
		internal static int __PropertyOffset_19;

		// Token: 0x040119DC RID: 72156
		internal static int __PropertyOffset_20;

		// Token: 0x040119DD RID: 72157
		[Nullable(2)]
		private TArray<FVector> _posArr_r;

		// Token: 0x040119DE RID: 72158
		internal static int __PropertyOffset_21;

		// Token: 0x040119DF RID: 72159
		[Nullable(2)]
		private TArray<FVector> _volArr_r;

		// Token: 0x040119E0 RID: 72160
		internal static int __PropertyOffset_22;

		// Token: 0x040119E1 RID: 72161
		[Nullable(2)]
		private TArray<FVector> _posArr_foe_r;

		// Token: 0x040119E2 RID: 72162
		internal static int __PropertyOffset_23;

		// Token: 0x040119E3 RID: 72163
		internal static int __PropertyOffset_24;

		// Token: 0x040119E4 RID: 72164
		internal static int __PropertyOffset_25;

		// Token: 0x040119E5 RID: 72165
		internal static int __PropertyOffset_26;

		// Token: 0x040119E6 RID: 72166
		internal static int __PropertyOffset_27;

		// Token: 0x040119E7 RID: 72167
		[Nullable(2)]
		private TArray<float> _foeDisList;

		// Token: 0x040119E8 RID: 72168
		internal static int __PropertyOffset_28;

		// Token: 0x040119E9 RID: 72169
		[Nullable(2)]
		private TArray<float> _foeDisList_r;

		// Token: 0x040119EA RID: 72170
		internal static int __PropertyOffset_29;

		// Token: 0x040119EB RID: 72171
		[Nullable(2)]
		private TArray<float> _nxtDisList;

		// Token: 0x040119EC RID: 72172
		internal static int __PropertyOffset_30;

		// Token: 0x040119ED RID: 72173
		[Nullable(2)]
		private TArray<float> _nxtDisList_r;

		// Token: 0x040119EE RID: 72174
		internal static int __PropertyOffset_31;

		// Token: 0x040119EF RID: 72175
		internal static int __PropertyOffset_32;

		// Token: 0x040119F0 RID: 72176
		internal static int __PropertyOffset_33;

		// Token: 0x040119F1 RID: 72177
		internal static int __PropertyOffset_34;

		// Token: 0x040119F2 RID: 72178
		internal static int __PropertyOffset_35;

		// Token: 0x040119F3 RID: 72179
		internal static int __PropertyOffset_36;

		// Token: 0x040119F4 RID: 72180
		internal static int __PropertyOffset_37;

		// Token: 0x040119F5 RID: 72181
		internal static int __PropertyOffset_38;

		// Token: 0x040119F6 RID: 72182
		internal static int __PropertyOffset_39;

		// Token: 0x040119F7 RID: 72183
		internal static int __PropertyOffset_40;

		// Token: 0x040119F8 RID: 72184
		internal static int __PropertyOffset_41;

		// Token: 0x040119F9 RID: 72185
		internal static int __PropertyOffset_42;

		// Token: 0x040119FA RID: 72186
		internal static int __PropertyOffset_43;

		// Token: 0x040119FB RID: 72187
		internal static int __PropertyOffset_44;

		// Token: 0x040119FC RID: 72188
		[Nullable(2)]
		private TArray<byte> _Particle_Chain_Link_Mask;

		// Token: 0x040119FD RID: 72189
		internal static int __PropertyOffset_45;

		// Token: 0x040119FE RID: 72190
		[Nullable(2)]
		private TArray<byte> _Particle_Chain_Link_Mask_R;

		// Token: 0x040119FF RID: 72191
		internal static int __PropertyOffset_46;

		// Token: 0x04011A00 RID: 72192
		internal static int __PropertyOffset_47;

		// Token: 0x04011A01 RID: 72193
		internal static int __PropertyOffset_48;

		// Token: 0x04011A02 RID: 72194
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroBridgeChunkMeshList> _BridgeFractureSet;

		// Token: 0x04011A03 RID: 72195
		internal static int __PropertyOffset_49;

		// Token: 0x04011A04 RID: 72196
		internal static int __PropertyOffset_50;

		// Token: 0x04011A05 RID: 72197
		private static IntPtr __RecoverSideBlock_NativeFunctionPtr;

		// Token: 0x04011A06 RID: 72198
		private static IntPtr __getTangent_NativeFunctionPtr;

		// Token: 0x04011A07 RID: 72199
		private static IntPtr __solve_NativeFunctionPtr;

		// Token: 0x04011A08 RID: 72200
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011A09 RID: 72201
		private static IntPtr __Completed_9ED3A0014CAE76088E4760B193BF3A56_NativeFunctionPtr;

		// Token: 0x04011A0A RID: 72202
		private static IntPtr __Completed_D335450D4E966E00060072B19DB6B342_NativeFunctionPtr;

		// Token: 0x04011A0B RID: 72203
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011A0C RID: 72204
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011A0D RID: 72205
		private static IntPtr __BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011A0E RID: 72206
		private static IntPtr __BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011A0F RID: 72207
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x02009E7F RID: 40575
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 296)]
		protected ref struct __getTangent_FunctionParams
		{
			// Token: 0x0403171F RID: 202527
			[FieldOffset(0)]
			public byte posArr;

			// Token: 0x04031720 RID: 202528
			[FieldOffset(16)]
			public byte posArrR;

			// Token: 0x04031721 RID: 202529
			[FieldOffset(32)]
			public int index;

			// Token: 0x04031722 RID: 202530
			[FieldOffset(36)]
			public FVector tangent;
		}

		// Token: 0x02009E80 RID: 40576
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 116)]
		protected ref struct __solve_FunctionParams
		{
			// Token: 0x04031723 RID: 202531
			[FieldOffset(0)]
			public bool isPinned;

			// Token: 0x04031724 RID: 202532
			[FieldOffset(4)]
			public FVector pos;

			// Token: 0x04031725 RID: 202533
			[FieldOffset(16)]
			public FVector linkPos;

			// Token: 0x04031726 RID: 202534
			[FieldOffset(28)]
			public float targetLen;

			// Token: 0x04031727 RID: 202535
			[FieldOffset(32)]
			public FVector emitterOriginPos;

			// Token: 0x04031728 RID: 202536
			[FieldOffset(44)]
			public FVector pos_new;
		}

		// Token: 0x02009E81 RID: 40577
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_9ED3A0014CAE76088E4760B193BF3A56_FunctionParams
		{
			// Token: 0x04031729 RID: 202537
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009E82 RID: 40578
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_D335450D4E966E00060072B19DB6B342_FunctionParams
		{
			// Token: 0x0403172A RID: 202538
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009E83 RID: 40579
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403172B RID: 202539
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E84 RID: 40580
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403172C RID: 202540
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403172D RID: 202541
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403172E RID: 202542
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403172F RID: 202543
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031730 RID: 202544
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031731 RID: 202545
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009E85 RID: 40581
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031732 RID: 202546
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031733 RID: 202547
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031734 RID: 202548
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031735 RID: 202549
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009E86 RID: 40582
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031736 RID: 202550
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031737 RID: 202551
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031738 RID: 202552
			[FieldOffset(32)]
			public int Id;
		}
	}
}
