using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_PhysicBridge.BP
{
	// Token: 0x02003C43 RID: 15427
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_CPP_bridge_doubleChain_realModel.BP_CPP_bridge_doubleChain_realModel_C")]
	[UnrealStructLayout(1784, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1784)]
	public class BP_CPP_bridge_doubleChain_realModel_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023AF9 RID: 146169 RVA: 0x00929EF0 File Offset: 0x009280F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CPP_bridge_doubleChain_realModel_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_CPP_bridge_doubleChain_realModel.BP_CPP_bridge_doubleChain_realModel_C");
			}
			return BP_CPP_bridge_doubleChain_realModel_C._ClassPtr;
		}

		// Token: 0x06023AFA RID: 146170 RVA: 0x00929F14 File Offset: 0x00928114
		public BP_CPP_bridge_doubleChain_realModel_C() : this(BuiltinUtils.AllocNativeUObject(BP_CPP_bridge_doubleChain_realModel_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023AFB RID: 146171 RVA: 0x00929F3C File Offset: 0x0092813C
		public BP_CPP_bridge_doubleChain_realModel_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CPP_bridge_doubleChain_realModel_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004302 RID: 17154
		// (get) Token: 0x06023AFC RID: 146172 RVA: 0x00929F6F File Offset: 0x0092816F
		// (set) Token: 0x06023AFD RID: 146173 RVA: 0x00929F83 File Offset: 0x00928183
		[Nullable(2)]
		public unsafe UBoxComponent Box
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004303 RID: 17155
		// (get) Token: 0x06023AFE RID: 146174 RVA: 0x00929F98 File Offset: 0x00928198
		// (set) Token: 0x06023AFF RID: 146175 RVA: 0x00929FAC File Offset: 0x009281AC
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004304 RID: 17156
		// (get) Token: 0x06023B00 RID: 146176 RVA: 0x00929FC4 File Offset: 0x009281C4
		// (set) Token: 0x06023B01 RID: 146177 RVA: 0x00929FFD File Offset: 0x009281FD
		public TArray<FVector> posArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._posArr) == null)
				{
					result = (this._posArr = new TArray<FVector>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.posArr.CopyAssign(value);
			}
		}

		// Token: 0x17004305 RID: 17157
		// (get) Token: 0x06023B02 RID: 146178 RVA: 0x0092A00C File Offset: 0x0092820C
		// (set) Token: 0x06023B03 RID: 146179 RVA: 0x0092A045 File Offset: 0x00928245
		public TArray<FVector> volArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._volArr) == null)
				{
					result = (this._volArr = new TArray<FVector>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.volArr.CopyAssign(value);
			}
		}

		// Token: 0x17004306 RID: 17158
		// (get) Token: 0x06023B04 RID: 146180 RVA: 0x0092A053 File Offset: 0x00928253
		// (set) Token: 0x06023B05 RID: 146181 RVA: 0x0092A063 File Offset: 0x00928263
		public unsafe int particleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004307 RID: 17159
		// (get) Token: 0x06023B06 RID: 146182 RVA: 0x0092A074 File Offset: 0x00928274
		// (set) Token: 0x06023B07 RID: 146183 RVA: 0x0092A084 File Offset: 0x00928284
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004308 RID: 17160
		// (get) Token: 0x06023B08 RID: 146184 RVA: 0x0092A095 File Offset: 0x00928295
		// (set) Token: 0x06023B09 RID: 146185 RVA: 0x0092A0A9 File Offset: 0x009282A9
		public unsafe FVector emitterOriginPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004309 RID: 17161
		// (get) Token: 0x06023B0A RID: 146186 RVA: 0x0092A0BE File Offset: 0x009282BE
		// (set) Token: 0x06023B0B RID: 146187 RVA: 0x0092A0D2 File Offset: 0x009282D2
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700430A RID: 17162
		// (get) Token: 0x06023B0C RID: 146188 RVA: 0x0092A0E8 File Offset: 0x009282E8
		// (set) Token: 0x06023B0D RID: 146189 RVA: 0x0092A121 File Offset: 0x00928321
		public TArray<FVector> posArr_foe
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._posArr_foe) == null)
				{
					result = (this._posArr_foe = new TArray<FVector>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				this.posArr_foe.CopyAssign(value);
			}
		}

		// Token: 0x1700430B RID: 17163
		// (get) Token: 0x06023B0E RID: 146190 RVA: 0x0092A12F File Offset: 0x0092832F
		// (set) Token: 0x06023B0F RID: 146191 RVA: 0x0092A13F File Offset: 0x0092833F
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700430C RID: 17164
		// (get) Token: 0x06023B10 RID: 146192 RVA: 0x0092A150 File Offset: 0x00928350
		// (set) Token: 0x06023B11 RID: 146193 RVA: 0x0092A160 File Offset: 0x00928360
		public unsafe long frameID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700430D RID: 17165
		// (get) Token: 0x06023B12 RID: 146194 RVA: 0x0092A171 File Offset: 0x00928371
		// (set) Token: 0x06023B13 RID: 146195 RVA: 0x0092A181 File Offset: 0x00928381
		public unsafe float volDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700430E RID: 17166
		// (get) Token: 0x06023B14 RID: 146196 RVA: 0x0092A192 File Offset: 0x00928392
		// (set) Token: 0x06023B15 RID: 146197 RVA: 0x0092A1A6 File Offset: 0x009283A6
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic DMI
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_13);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x1700430F RID: 17167
		// (get) Token: 0x06023B16 RID: 146198 RVA: 0x0092A1BB File Offset: 0x009283BB
		// (set) Token: 0x06023B17 RID: 146199 RVA: 0x0092A1CF File Offset: 0x009283CF
		public unsafe FVector startPinPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004310 RID: 17168
		// (get) Token: 0x06023B18 RID: 146200 RVA: 0x0092A1E4 File Offset: 0x009283E4
		// (set) Token: 0x06023B19 RID: 146201 RVA: 0x0092A1F8 File Offset: 0x009283F8
		public unsafe FVector endPinPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004311 RID: 17169
		// (get) Token: 0x06023B1A RID: 146202 RVA: 0x0092A210 File Offset: 0x00928410
		// (set) Token: 0x06023B1B RID: 146203 RVA: 0x0092A249 File Offset: 0x00928449
		public TArray<UStaticMeshComponent> plankList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._plankList) == null)
				{
					result = (this._plankList = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				this.plankList.CopyAssign(value);
			}
		}

		// Token: 0x17004312 RID: 17170
		// (get) Token: 0x06023B1C RID: 146204 RVA: 0x0092A257 File Offset: 0x00928457
		// (set) Token: 0x06023B1D RID: 146205 RVA: 0x0092A267 File Offset: 0x00928467
		public unsafe float pushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004313 RID: 17171
		// (get) Token: 0x06023B1E RID: 146206 RVA: 0x0092A278 File Offset: 0x00928478
		// (set) Token: 0x06023B1F RID: 146207 RVA: 0x0092A2B1 File Offset: 0x009284B1
		public TArray<FVector> posArr_r
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._posArr_r) == null)
				{
					result = (this._posArr_r = new TArray<FVector>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_18, this));
				}
				return result;
			}
			set
			{
				this.posArr_r.CopyAssign(value);
			}
		}

		// Token: 0x17004314 RID: 17172
		// (get) Token: 0x06023B20 RID: 146208 RVA: 0x0092A2C0 File Offset: 0x009284C0
		// (set) Token: 0x06023B21 RID: 146209 RVA: 0x0092A2F9 File Offset: 0x009284F9
		public TArray<FVector> volArr_r
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._volArr_r) == null)
				{
					result = (this._volArr_r = new TArray<FVector>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				this.volArr_r.CopyAssign(value);
			}
		}

		// Token: 0x17004315 RID: 17173
		// (get) Token: 0x06023B22 RID: 146210 RVA: 0x0092A308 File Offset: 0x00928508
		// (set) Token: 0x06023B23 RID: 146211 RVA: 0x0092A341 File Offset: 0x00928541
		public TArray<FVector> posArr_foe_r
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._posArr_foe_r) == null)
				{
					result = (this._posArr_foe_r = new TArray<FVector>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_20, this));
				}
				return result;
			}
			set
			{
				this.posArr_foe_r.CopyAssign(value);
			}
		}

		// Token: 0x17004316 RID: 17174
		// (get) Token: 0x06023B24 RID: 146212 RVA: 0x0092A34F File Offset: 0x0092854F
		// (set) Token: 0x06023B25 RID: 146213 RVA: 0x0092A363 File Offset: 0x00928563
		public unsafe FVector startPinPos_r
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004317 RID: 17175
		// (get) Token: 0x06023B26 RID: 146214 RVA: 0x0092A378 File Offset: 0x00928578
		// (set) Token: 0x06023B27 RID: 146215 RVA: 0x0092A38C File Offset: 0x0092858C
		public unsafe FVector endPinPos_r
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004318 RID: 17176
		// (get) Token: 0x06023B28 RID: 146216 RVA: 0x0092A3A1 File Offset: 0x009285A1
		// (set) Token: 0x06023B29 RID: 146217 RVA: 0x0092A3B1 File Offset: 0x009285B1
		public unsafe float percentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004319 RID: 17177
		// (get) Token: 0x06023B2A RID: 146218 RVA: 0x0092A3C2 File Offset: 0x009285C2
		// (set) Token: 0x06023B2B RID: 146219 RVA: 0x0092A3D2 File Offset: 0x009285D2
		public unsafe bool onBridge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700431A RID: 17178
		// (get) Token: 0x06023B2C RID: 146220 RVA: 0x0092A3E4 File Offset: 0x009285E4
		// (set) Token: 0x06023B2D RID: 146221 RVA: 0x0092A41D File Offset: 0x0092861D
		public TArray<float> foeDisList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._foeDisList) == null)
				{
					result = (this._foeDisList = new TArray<float>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_25, this));
				}
				return result;
			}
			set
			{
				this.foeDisList.CopyAssign(value);
			}
		}

		// Token: 0x1700431B RID: 17179
		// (get) Token: 0x06023B2E RID: 146222 RVA: 0x0092A42C File Offset: 0x0092862C
		// (set) Token: 0x06023B2F RID: 146223 RVA: 0x0092A465 File Offset: 0x00928665
		public TArray<float> foeDisList_r
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._foeDisList_r) == null)
				{
					result = (this._foeDisList_r = new TArray<float>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_26, this));
				}
				return result;
			}
			set
			{
				this.foeDisList_r.CopyAssign(value);
			}
		}

		// Token: 0x1700431C RID: 17180
		// (get) Token: 0x06023B30 RID: 146224 RVA: 0x0092A474 File Offset: 0x00928674
		// (set) Token: 0x06023B31 RID: 146225 RVA: 0x0092A4AD File Offset: 0x009286AD
		public TArray<float> nxtDisList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._nxtDisList) == null)
				{
					result = (this._nxtDisList = new TArray<float>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_27, this));
				}
				return result;
			}
			set
			{
				this.nxtDisList.CopyAssign(value);
			}
		}

		// Token: 0x1700431D RID: 17181
		// (get) Token: 0x06023B32 RID: 146226 RVA: 0x0092A4BC File Offset: 0x009286BC
		// (set) Token: 0x06023B33 RID: 146227 RVA: 0x0092A4F5 File Offset: 0x009286F5
		public TArray<float> nxtDisList_r
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._nxtDisList_r) == null)
				{
					result = (this._nxtDisList_r = new TArray<float>(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_28, this));
				}
				return result;
			}
			set
			{
				this.nxtDisList_r.CopyAssign(value);
			}
		}

		// Token: 0x1700431E RID: 17182
		// (get) Token: 0x06023B34 RID: 146228 RVA: 0x0092A503 File Offset: 0x00928703
		// (set) Token: 0x06023B35 RID: 146229 RVA: 0x0092A513 File Offset: 0x00928713
		public unsafe float offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x1700431F RID: 17183
		// (get) Token: 0x06023B36 RID: 146230 RVA: 0x0092A524 File Offset: 0x00928724
		// (set) Token: 0x06023B37 RID: 146231 RVA: 0x0092A534 File Offset: 0x00928734
		public unsafe float linkDisScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17004320 RID: 17184
		// (get) Token: 0x06023B38 RID: 146232 RVA: 0x0092A545 File Offset: 0x00928745
		// (set) Token: 0x06023B39 RID: 146233 RVA: 0x0092A559 File Offset: 0x00928759
		[Nullable(2)]
		public unsafe AActor bridgeModels
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_31);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CPP_bridge_doubleChain_realModel_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x06023B3A RID: 146234 RVA: 0x0092A570 File Offset: 0x00928770
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void getTangent(ref TArray<FVector> posArr, ref TArray<FVector> posArrR, int index, ref FVector tangent)
		{
			BP_CPP_bridge_doubleChain_realModel_C.__getTangent_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_C.__getTangent_FunctionParams[(UIntPtr)311] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_C.__getTangent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_C.__getTangent_NativeFunctionPtr, (void*)ptr, 1);
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
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_C.__getTangent_NativeFunctionPtr, (void*)ptr);
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
			UnrealReflectionUtils.DestroyStruct(BP_CPP_bridge_doubleChain_realModel_C.__getTangent_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06023B3B RID: 146235 RVA: 0x0092A634 File Offset: 0x00928834
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void solve(bool isPinned, FVector pos, FVector linkPos, float targetLen, FVector emitterOriginPos, ref FVector pos_new)
		{
			BP_CPP_bridge_doubleChain_realModel_C.__solve_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_C.__solve_FunctionParams[(UIntPtr)131] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_C.__solve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_C.__solve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isPinned = isPinned;
			ptr->pos = pos;
			ptr->linkPos = linkPos;
			ptr->targetLen = targetLen;
			ptr->emitterOriginPos = emitterOriginPos;
			ptr->pos_new = pos_new;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_C.__solve_NativeFunctionPtr, (void*)ptr);
			pos_new = ptr->pos_new;
		}

		// Token: 0x06023B3C RID: 146236 RVA: 0x0092A6B5 File Offset: 0x009288B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023B3D RID: 146237 RVA: 0x0092A6C9 File Offset: 0x009288C9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023B3E RID: 146238 RVA: 0x0092A6DE File Offset: 0x009288DE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023B3F RID: 146239 RVA: 0x0092A6F2 File Offset: 0x009288F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023B40 RID: 146240 RVA: 0x0092A708 File Offset: 0x00928908
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CPP_bridge_doubleChain_realModel_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023B41 RID: 146241 RVA: 0x0092A750 File Offset: 0x00928950
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CPP_bridge_doubleChain_realModel_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023B42 RID: 146242 RVA: 0x0092A798 File Offset: 0x00928998
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_CPP_bridge_doubleChain_realModel_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023B43 RID: 146243 RVA: 0x0092A854 File Offset: 0x00928A54
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_CPP_bridge_doubleChain_realModel_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_CPP_bridge_doubleChain_realModel_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CPP_bridge_doubleChain_realModel_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CPP_bridge_doubleChain_realModel_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CPP_bridge_doubleChain_realModel_C.__BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023B44 RID: 146244 RVA: 0x0092A8DD File Offset: 0x00928ADD
		protected BP_CPP_bridge_doubleChain_realModel_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A10 RID: 72208
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_CPP_bridge_doubleChain_realModel.BP_CPP_bridge_doubleChain_realModel_C";

		// Token: 0x04011A11 RID: 72209
		private static IntPtr _ClassPtr;

		// Token: 0x04011A12 RID: 72210
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A13 RID: 72211
		internal static int __PropertyOffset_1;

		// Token: 0x04011A14 RID: 72212
		internal static int __PropertyOffset_2;

		// Token: 0x04011A15 RID: 72213
		internal static int __PropertyOffset_3;

		// Token: 0x04011A16 RID: 72214
		[Nullable(2)]
		private TArray<FVector> _posArr;

		// Token: 0x04011A17 RID: 72215
		internal static int __PropertyOffset_4;

		// Token: 0x04011A18 RID: 72216
		[Nullable(2)]
		private TArray<FVector> _volArr;

		// Token: 0x04011A19 RID: 72217
		internal static int __PropertyOffset_5;

		// Token: 0x04011A1A RID: 72218
		internal static int __PropertyOffset_6;

		// Token: 0x04011A1B RID: 72219
		internal static int __PropertyOffset_7;

		// Token: 0x04011A1C RID: 72220
		internal static int __PropertyOffset_8;

		// Token: 0x04011A1D RID: 72221
		internal static int __PropertyOffset_9;

		// Token: 0x04011A1E RID: 72222
		[Nullable(2)]
		private TArray<FVector> _posArr_foe;

		// Token: 0x04011A1F RID: 72223
		internal static int __PropertyOffset_10;

		// Token: 0x04011A20 RID: 72224
		internal static int __PropertyOffset_11;

		// Token: 0x04011A21 RID: 72225
		internal static int __PropertyOffset_12;

		// Token: 0x04011A22 RID: 72226
		internal static int __PropertyOffset_13;

		// Token: 0x04011A23 RID: 72227
		internal static int __PropertyOffset_14;

		// Token: 0x04011A24 RID: 72228
		internal static int __PropertyOffset_15;

		// Token: 0x04011A25 RID: 72229
		internal static int __PropertyOffset_16;

		// Token: 0x04011A26 RID: 72230
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _plankList;

		// Token: 0x04011A27 RID: 72231
		internal static int __PropertyOffset_17;

		// Token: 0x04011A28 RID: 72232
		internal static int __PropertyOffset_18;

		// Token: 0x04011A29 RID: 72233
		[Nullable(2)]
		private TArray<FVector> _posArr_r;

		// Token: 0x04011A2A RID: 72234
		internal static int __PropertyOffset_19;

		// Token: 0x04011A2B RID: 72235
		[Nullable(2)]
		private TArray<FVector> _volArr_r;

		// Token: 0x04011A2C RID: 72236
		internal static int __PropertyOffset_20;

		// Token: 0x04011A2D RID: 72237
		[Nullable(2)]
		private TArray<FVector> _posArr_foe_r;

		// Token: 0x04011A2E RID: 72238
		internal static int __PropertyOffset_21;

		// Token: 0x04011A2F RID: 72239
		internal static int __PropertyOffset_22;

		// Token: 0x04011A30 RID: 72240
		internal static int __PropertyOffset_23;

		// Token: 0x04011A31 RID: 72241
		internal static int __PropertyOffset_24;

		// Token: 0x04011A32 RID: 72242
		internal static int __PropertyOffset_25;

		// Token: 0x04011A33 RID: 72243
		[Nullable(2)]
		private TArray<float> _foeDisList;

		// Token: 0x04011A34 RID: 72244
		internal static int __PropertyOffset_26;

		// Token: 0x04011A35 RID: 72245
		[Nullable(2)]
		private TArray<float> _foeDisList_r;

		// Token: 0x04011A36 RID: 72246
		internal static int __PropertyOffset_27;

		// Token: 0x04011A37 RID: 72247
		[Nullable(2)]
		private TArray<float> _nxtDisList;

		// Token: 0x04011A38 RID: 72248
		internal static int __PropertyOffset_28;

		// Token: 0x04011A39 RID: 72249
		[Nullable(2)]
		private TArray<float> _nxtDisList_r;

		// Token: 0x04011A3A RID: 72250
		internal static int __PropertyOffset_29;

		// Token: 0x04011A3B RID: 72251
		internal static int __PropertyOffset_30;

		// Token: 0x04011A3C RID: 72252
		internal static int __PropertyOffset_31;

		// Token: 0x04011A3D RID: 72253
		private static IntPtr __getTangent_NativeFunctionPtr;

		// Token: 0x04011A3E RID: 72254
		private static IntPtr __solve_NativeFunctionPtr;

		// Token: 0x04011A3F RID: 72255
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011A40 RID: 72256
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011A41 RID: 72257
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011A42 RID: 72258
		private static IntPtr __BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011A43 RID: 72259
		private static IntPtr __BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009E87 RID: 40583
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 296)]
		protected ref struct __getTangent_FunctionParams
		{
			// Token: 0x04031739 RID: 202553
			[FieldOffset(0)]
			public byte posArr;

			// Token: 0x0403173A RID: 202554
			[FieldOffset(16)]
			public byte posArrR;

			// Token: 0x0403173B RID: 202555
			[FieldOffset(32)]
			public int index;

			// Token: 0x0403173C RID: 202556
			[FieldOffset(36)]
			public FVector tangent;
		}

		// Token: 0x02009E88 RID: 40584
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 116)]
		protected ref struct __solve_FunctionParams
		{
			// Token: 0x0403173D RID: 202557
			[FieldOffset(0)]
			public bool isPinned;

			// Token: 0x0403173E RID: 202558
			[FieldOffset(4)]
			public FVector pos;

			// Token: 0x0403173F RID: 202559
			[FieldOffset(16)]
			public FVector linkPos;

			// Token: 0x04031740 RID: 202560
			[FieldOffset(28)]
			public float targetLen;

			// Token: 0x04031741 RID: 202561
			[FieldOffset(32)]
			public FVector emitterOriginPos;

			// Token: 0x04031742 RID: 202562
			[FieldOffset(44)]
			public FVector pos_new;
		}

		// Token: 0x02009E89 RID: 40585
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031743 RID: 202563
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E8A RID: 40586
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031744 RID: 202564
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031745 RID: 202565
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031746 RID: 202566
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031747 RID: 202567
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031748 RID: 202568
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031749 RID: 202569
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009E8B RID: 40587
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_CPP_bridge_doubleChain_realModel_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403174A RID: 202570
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403174B RID: 202571
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403174C RID: 202572
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403174D RID: 202573
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
