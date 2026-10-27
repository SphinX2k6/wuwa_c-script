using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.HeadLight.Common.Lensflare;
using AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.HeadLight.Common.VolumetricConeLight;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003E00 RID: 15872
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/PD_MotorExtraComponentData.PD_MotorExtraComponentData_C")]
	[UnrealStructLayout(352, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public class PD_MotorExtraComponentData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027A6B RID: 162411 RVA: 0x00997860 File Offset: 0x00995A60
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_MotorExtraComponentData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Npc/PD_MotorExtraComponentData.PD_MotorExtraComponentData_C");
			}
			return PD_MotorExtraComponentData_C._ClassPtr;
		}

		// Token: 0x06027A6C RID: 162412 RVA: 0x00997884 File Offset: 0x00995A84
		public PD_MotorExtraComponentData_C() : this(BuiltinUtils.AllocNativeUObject(PD_MotorExtraComponentData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027A6D RID: 162413 RVA: 0x009978AC File Offset: 0x00995AAC
		[NullableContext(1)]
		public PD_MotorExtraComponentData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_MotorExtraComponentData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005932 RID: 22834
		// (get) Token: 0x06027A6E RID: 162414 RVA: 0x009978DF File Offset: 0x00995ADF
		// (set) Token: 0x06027A6F RID: 162415 RVA: 0x009978F3 File Offset: 0x00995AF3
		public unsafe USkeletalMesh MotorMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_MotorExtraComponentData_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_MotorExtraComponentData_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005933 RID: 22835
		// (get) Token: 0x06027A70 RID: 162416 RVA: 0x00997908 File Offset: 0x00995B08
		// (set) Token: 0x06027A71 RID: 162417 RVA: 0x0099791C File Offset: 0x00995B1C
		public unsafe FName AO贴花插槽名
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005934 RID: 22836
		// (get) Token: 0x06027A72 RID: 162418 RVA: 0x00997931 File Offset: 0x00995B31
		// (set) Token: 0x06027A73 RID: 162419 RVA: 0x00997945 File Offset: 0x00995B45
		public unsafe FTransform AO贴花位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005935 RID: 22837
		// (get) Token: 0x06027A74 RID: 162420 RVA: 0x0099795A File Offset: 0x00995B5A
		// (set) Token: 0x06027A75 RID: 162421 RVA: 0x0099796E File Offset: 0x00995B6E
		public unsafe UMaterialInstance AO_Decal_Mat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_MotorExtraComponentData_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_MotorExtraComponentData_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005936 RID: 22838
		// (get) Token: 0x06027A76 RID: 162422 RVA: 0x00997984 File Offset: 0x00995B84
		// (set) Token: 0x06027A77 RID: 162423 RVA: 0x009979BD File Offset: 0x00995BBD
		[Nullable(1)]
		public TArray<PD_CharacterControllerData_C> FX_DA
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<PD_CharacterControllerData_C> result;
				if ((result = this._FX_DA) == null)
				{
					result = (this._FX_DA = new TArray<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FX_DA.CopyAssign(value);
			}
		}

		// Token: 0x17005937 RID: 22839
		// (get) Token: 0x06027A78 RID: 162424 RVA: 0x009979CB File Offset: 0x00995BCB
		// (set) Token: 0x06027A79 RID: 162425 RVA: 0x009979DF File Offset: 0x00995BDF
		public unsafe FName 车灯插槽名
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005938 RID: 22840
		// (get) Token: 0x06027A7A RID: 162426 RVA: 0x009979F4 File Offset: 0x00995BF4
		// (set) Token: 0x06027A7B RID: 162427 RVA: 0x00997A08 File Offset: 0x00995C08
		public unsafe FTransform 车灯位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005939 RID: 22841
		// (get) Token: 0x06027A7C RID: 162428 RVA: 0x00997A1D File Offset: 0x00995C1D
		// (set) Token: 0x06027A7D RID: 162429 RVA: 0x00997A31 File Offset: 0x00995C31
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<BP_VolumetricConeLightShaft_InMotor_C> 车灯蓝图
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_7);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700593A RID: 22842
		// (get) Token: 0x06027A7E RID: 162430 RVA: 0x00997A46 File Offset: 0x00995C46
		// (set) Token: 0x06027A7F RID: 162431 RVA: 0x00997A5A File Offset: 0x00995C5A
		public unsafe FName 炫光插槽名
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700593B RID: 22843
		// (get) Token: 0x06027A80 RID: 162432 RVA: 0x00997A6F File Offset: 0x00995C6F
		// (set) Token: 0x06027A81 RID: 162433 RVA: 0x00997A83 File Offset: 0x00995C83
		public unsafe FTransform 炫光位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700593C RID: 22844
		// (get) Token: 0x06027A82 RID: 162434 RVA: 0x00997A98 File Offset: 0x00995C98
		// (set) Token: 0x06027A83 RID: 162435 RVA: 0x00997AAC File Offset: 0x00995CAC
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<BP_SceneLensflare_Motor_C> 炫光蓝图
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_10);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x06027A84 RID: 162436 RVA: 0x00997AC1 File Offset: 0x00995CC1
		protected PD_MotorExtraComponentData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401410D RID: 82189
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/PD_MotorExtraComponentData.PD_MotorExtraComponentData_C";

		// Token: 0x0401410E RID: 82190
		private static IntPtr _ClassPtr;

		// Token: 0x0401410F RID: 82191
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014110 RID: 82192
		internal static int __PropertyOffset_0;

		// Token: 0x04014111 RID: 82193
		internal static int __PropertyOffset_1;

		// Token: 0x04014112 RID: 82194
		internal static int __PropertyOffset_2;

		// Token: 0x04014113 RID: 82195
		internal static int __PropertyOffset_3;

		// Token: 0x04014114 RID: 82196
		internal static int __PropertyOffset_4;

		// Token: 0x04014115 RID: 82197
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<PD_CharacterControllerData_C> _FX_DA;

		// Token: 0x04014116 RID: 82198
		internal static int __PropertyOffset_5;

		// Token: 0x04014117 RID: 82199
		internal static int __PropertyOffset_6;

		// Token: 0x04014118 RID: 82200
		internal static int __PropertyOffset_7;

		// Token: 0x04014119 RID: 82201
		internal static int __PropertyOffset_8;

		// Token: 0x0401411A RID: 82202
		internal static int __PropertyOffset_9;

		// Token: 0x0401411B RID: 82203
		internal static int __PropertyOffset_10;
	}
}
