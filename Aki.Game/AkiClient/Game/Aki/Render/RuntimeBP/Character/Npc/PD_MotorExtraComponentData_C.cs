using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x0200311E RID: 12574
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/PD_MotorExtraComponentData.PD_MotorExtraComponentData_C")]
	[UnrealStructLayout(352, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public class PD_MotorExtraComponentData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ED20 RID: 126240 RVA: 0x0091E85F File Offset: 0x0091CA5F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_MotorExtraComponentData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Npc/PD_MotorExtraComponentData.PD_MotorExtraComponentData_C");
			}
			return PD_MotorExtraComponentData_C._ClassPtr;
		}

		// Token: 0x0601ED21 RID: 126241 RVA: 0x0091E884 File Offset: 0x0091CA84
		public PD_MotorExtraComponentData_C() : this(BuiltinUtils.AllocNativeUObject(PD_MotorExtraComponentData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ED22 RID: 126242 RVA: 0x0091E8AC File Offset: 0x0091CAAC
		[NullableContext(1)]
		public PD_MotorExtraComponentData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_MotorExtraComponentData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x0601ED23 RID: 126243 RVA: 0x0091E8DF File Offset: 0x0091CADF
		// (set) Token: 0x0601ED24 RID: 126244 RVA: 0x0091E8F3 File Offset: 0x0091CAF3
		public unsafe USkeletalMesh MotorMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_MotorExtraComponentData_C.__PropertyOffset_MotorMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_MotorExtraComponentData_C.__PropertyOffset_MotorMesh, value);
			}
		}

		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x0601ED25 RID: 126245 RVA: 0x0091E908 File Offset: 0x0091CB08
		// (set) Token: 0x0601ED26 RID: 126246 RVA: 0x0091E91C File Offset: 0x0091CB1C
		public unsafe FName AO贴花插槽名
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_AO贴花插槽名);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_AO贴花插槽名) = value;
			}
		}

		// Token: 0x170035B6 RID: 13750
		// (get) Token: 0x0601ED27 RID: 126247 RVA: 0x0091E931 File Offset: 0x0091CB31
		// (set) Token: 0x0601ED28 RID: 126248 RVA: 0x0091E945 File Offset: 0x0091CB45
		public unsafe FTransform AO贴花位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_AO贴花位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_AO贴花位置) = value;
			}
		}

		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x0601ED29 RID: 126249 RVA: 0x0091E95A File Offset: 0x0091CB5A
		// (set) Token: 0x0601ED2A RID: 126250 RVA: 0x0091E96E File Offset: 0x0091CB6E
		public unsafe UMaterialInstance AO_Decal_Mat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_MotorExtraComponentData_C.__PropertyOffset_AO_Decal_Mat);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_MotorExtraComponentData_C.__PropertyOffset_AO_Decal_Mat, value);
			}
		}

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x0601ED2B RID: 126251 RVA: 0x0091E984 File Offset: 0x0091CB84
		// (set) Token: 0x0601ED2C RID: 126252 RVA: 0x0091E9BD File Offset: 0x0091CBBD
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
					result = (this._FX_DA = new TArray<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_FX_DA, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FX_DA.CopyAssign(value);
			}
		}

		// Token: 0x170035B9 RID: 13753
		// (get) Token: 0x0601ED2D RID: 126253 RVA: 0x0091E9CB File Offset: 0x0091CBCB
		// (set) Token: 0x0601ED2E RID: 126254 RVA: 0x0091E9DF File Offset: 0x0091CBDF
		public unsafe FName 车灯插槽名
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_车灯插槽名);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_车灯插槽名) = value;
			}
		}

		// Token: 0x170035BA RID: 13754
		// (get) Token: 0x0601ED2F RID: 126255 RVA: 0x0091E9F4 File Offset: 0x0091CBF4
		// (set) Token: 0x0601ED30 RID: 126256 RVA: 0x0091EA08 File Offset: 0x0091CC08
		public unsafe FTransform 车灯位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_车灯位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_车灯位置) = value;
			}
		}

		// Token: 0x170035BB RID: 13755
		// (get) Token: 0x0601ED31 RID: 126257 RVA: 0x0091EA1D File Offset: 0x0091CC1D
		// (set) Token: 0x0601ED32 RID: 126258 RVA: 0x0091EA31 File Offset: 0x0091CC31
		public unsafe FName 炫光插槽名
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_炫光插槽名);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_炫光插槽名) = value;
			}
		}

		// Token: 0x170035BC RID: 13756
		// (get) Token: 0x0601ED33 RID: 126259 RVA: 0x0091EA46 File Offset: 0x0091CC46
		// (set) Token: 0x0601ED34 RID: 126260 RVA: 0x0091EA5A File Offset: 0x0091CC5A
		public unsafe FTransform 炫光位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_炫光位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_MotorExtraComponentData_C.__PropertyOffset_炫光位置) = value;
			}
		}

		// Token: 0x0601ED35 RID: 126261 RVA: 0x0091EA6F File Offset: 0x0091CC6F
		protected PD_MotorExtraComponentData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401061A RID: 67098
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/PD_MotorExtraComponentData.PD_MotorExtraComponentData_C";

		// Token: 0x0401061B RID: 67099
		private static IntPtr _ClassPtr;

		// Token: 0x0401061C RID: 67100
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401061D RID: 67101
		internal static int __PropertyOffset_MotorMesh;

		// Token: 0x0401061E RID: 67102
		internal static int __PropertyOffset_AO贴花插槽名;

		// Token: 0x0401061F RID: 67103
		internal static int __PropertyOffset_AO贴花位置;

		// Token: 0x04010620 RID: 67104
		internal static int __PropertyOffset_AO_Decal_Mat;

		// Token: 0x04010621 RID: 67105
		internal static int __PropertyOffset_FX_DA;

		// Token: 0x04010622 RID: 67106
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<PD_CharacterControllerData_C> _FX_DA;

		// Token: 0x04010623 RID: 67107
		internal static int __PropertyOffset_车灯插槽名;

		// Token: 0x04010624 RID: 67108
		internal static int __PropertyOffset_车灯位置;

		// Token: 0x04010625 RID: 67109
		internal static int __PropertyOffset_炫光插槽名;

		// Token: 0x04010626 RID: 67110
		internal static int __PropertyOffset_炫光位置;
	}
}
