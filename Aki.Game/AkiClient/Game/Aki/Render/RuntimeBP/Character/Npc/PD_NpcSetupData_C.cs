using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x0200311F RID: 12575
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/PD_NpcSetupData.PD_NpcSetupData_C")]
	[UnrealStructLayout(832, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 832)]
	public class PD_NpcSetupData_C : UKuroNpcDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ED36 RID: 126262 RVA: 0x0091EA78 File Offset: 0x0091CC78
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_NpcSetupData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Npc/PD_NpcSetupData.PD_NpcSetupData_C");
			}
			return PD_NpcSetupData_C._ClassPtr;
		}

		// Token: 0x0601ED37 RID: 126263 RVA: 0x0091EA9C File Offset: 0x0091CC9C
		public PD_NpcSetupData_C() : this(BuiltinUtils.AllocNativeUObject(PD_NpcSetupData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ED38 RID: 126264 RVA: 0x0091EAC4 File Offset: 0x0091CCC4
		public PD_NpcSetupData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_NpcSetupData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x0601ED39 RID: 126265 RVA: 0x0091EAF7 File Offset: 0x0091CCF7
		// (set) Token: 0x0601ED3A RID: 126266 RVA: 0x0091EB0B File Offset: 0x0091CD0B
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_Hair
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_Hair);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_Hair, value);
			}
		}

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x0601ED3B RID: 126267 RVA: 0x0091EB20 File Offset: 0x0091CD20
		// (set) Token: 0x0601ED3C RID: 126268 RVA: 0x0091EB34 File Offset: 0x0091CD34
		public unsafe FColor Skel_Hair_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Skel_Hair_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Skel_Hair_Color) = value;
			}
		}

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x0601ED3D RID: 126269 RVA: 0x0091EB49 File Offset: 0x0091CD49
		// (set) Token: 0x0601ED3E RID: 126270 RVA: 0x0091EB5D File Offset: 0x0091CD5D
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_Face
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_Face);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_Face, value);
			}
		}

		// Token: 0x170035C0 RID: 13760
		// (get) Token: 0x0601ED3F RID: 126271 RVA: 0x0091EB72 File Offset: 0x0091CD72
		// (set) Token: 0x0601ED40 RID: 126272 RVA: 0x0091EB86 File Offset: 0x0091CD86
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_BodyUp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_BodyUp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_BodyUp, value);
			}
		}

		// Token: 0x170035C1 RID: 13761
		// (get) Token: 0x0601ED41 RID: 126273 RVA: 0x0091EB9B File Offset: 0x0091CD9B
		// (set) Token: 0x0601ED42 RID: 126274 RVA: 0x0091EBAF File Offset: 0x0091CDAF
		public unsafe FColor Skel_BodyUp_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Skel_BodyUp_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Skel_BodyUp_Color) = value;
			}
		}

		// Token: 0x170035C2 RID: 13762
		// (get) Token: 0x0601ED43 RID: 126275 RVA: 0x0091EBC4 File Offset: 0x0091CDC4
		// (set) Token: 0x0601ED44 RID: 126276 RVA: 0x0091EBD8 File Offset: 0x0091CDD8
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_BodyDown
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_BodyDown);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_BodyDown, value);
			}
		}

		// Token: 0x170035C3 RID: 13763
		// (get) Token: 0x0601ED45 RID: 126277 RVA: 0x0091EBED File Offset: 0x0091CDED
		// (set) Token: 0x0601ED46 RID: 126278 RVA: 0x0091EC01 File Offset: 0x0091CE01
		public unsafe FColor Skel_BodyDown_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Skel_BodyDown_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Skel_BodyDown_Color) = value;
			}
		}

		// Token: 0x170035C4 RID: 13764
		// (get) Token: 0x0601ED47 RID: 126279 RVA: 0x0091EC16 File Offset: 0x0091CE16
		// (set) Token: 0x0601ED48 RID: 126280 RVA: 0x0091EC2A File Offset: 0x0091CE2A
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_Body
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_Body);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_Body, value);
			}
		}

		// Token: 0x170035C5 RID: 13765
		// (get) Token: 0x0601ED49 RID: 126281 RVA: 0x0091EC3F File Offset: 0x0091CE3F
		// (set) Token: 0x0601ED4A RID: 126282 RVA: 0x0091EC4F File Offset: 0x0091CE4F
		public unsafe bool bDyeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_bDyeColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_bDyeColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170035C6 RID: 13766
		// (get) Token: 0x0601ED4B RID: 126283 RVA: 0x0091EC60 File Offset: 0x0091CE60
		// (set) Token: 0x0601ED4C RID: 126284 RVA: 0x0091EC74 File Offset: 0x0091CE74
		public unsafe FLinearColor SkinDyeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_SkinDyeColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_SkinDyeColor) = value;
			}
		}

		// Token: 0x170035C7 RID: 13767
		// (get) Token: 0x0601ED4D RID: 126285 RVA: 0x0091EC89 File Offset: 0x0091CE89
		// (set) Token: 0x0601ED4E RID: 126286 RVA: 0x0091EC9D File Offset: 0x0091CE9D
		[Nullable(0)]
		public unsafe TEnumAsByte<ENpcSetupType> NpcSetupType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_NpcSetupType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_NpcSetupType) = value;
			}
		}

		// Token: 0x170035C8 RID: 13768
		// (get) Token: 0x0601ED4F RID: 126287 RVA: 0x0091ECB2 File Offset: 0x0091CEB2
		// (set) Token: 0x0601ED50 RID: 126288 RVA: 0x0091ECC6 File Offset: 0x0091CEC6
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_Main
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_Main);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_Main, value);
			}
		}

		// Token: 0x170035C9 RID: 13769
		// (get) Token: 0x0601ED51 RID: 126289 RVA: 0x0091ECDC File Offset: 0x0091CEDC
		// (set) Token: 0x0601ED52 RID: 126290 RVA: 0x0091ED15 File Offset: 0x0091CF15
		public TArray<SNpcHookPart> Hook_Arm
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Arm) == null)
				{
					result = (this._Hook_Arm = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Arm, this));
				}
				return result;
			}
			set
			{
				this.Hook_Arm.CopyAssign(value);
			}
		}

		// Token: 0x170035CA RID: 13770
		// (get) Token: 0x0601ED53 RID: 126291 RVA: 0x0091ED23 File Offset: 0x0091CF23
		// (set) Token: 0x0601ED54 RID: 126292 RVA: 0x0091ED37 File Offset: 0x0091CF37
		public unsafe FName Hook_Arm_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Arm_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Arm_Socket) = value;
			}
		}

		// Token: 0x170035CB RID: 13771
		// (get) Token: 0x0601ED55 RID: 126293 RVA: 0x0091ED4C File Offset: 0x0091CF4C
		// (set) Token: 0x0601ED56 RID: 126294 RVA: 0x0091ED85 File Offset: 0x0091CF85
		public TArray<SNpcHookPart> Hook_Waist
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Waist) == null)
				{
					result = (this._Hook_Waist = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Waist, this));
				}
				return result;
			}
			set
			{
				this.Hook_Waist.CopyAssign(value);
			}
		}

		// Token: 0x170035CC RID: 13772
		// (get) Token: 0x0601ED57 RID: 126295 RVA: 0x0091ED93 File Offset: 0x0091CF93
		// (set) Token: 0x0601ED58 RID: 126296 RVA: 0x0091EDA7 File Offset: 0x0091CFA7
		public unsafe FName Hook_Waist_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Waist_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Waist_Socket) = value;
			}
		}

		// Token: 0x170035CD RID: 13773
		// (get) Token: 0x0601ED59 RID: 126297 RVA: 0x0091EDBC File Offset: 0x0091CFBC
		// (set) Token: 0x0601ED5A RID: 126298 RVA: 0x0091EDF5 File Offset: 0x0091CFF5
		public TArray<SNpcHookPart> Hook_Back
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Back) == null)
				{
					result = (this._Hook_Back = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Back, this));
				}
				return result;
			}
			set
			{
				this.Hook_Back.CopyAssign(value);
			}
		}

		// Token: 0x170035CE RID: 13774
		// (get) Token: 0x0601ED5B RID: 126299 RVA: 0x0091EE03 File Offset: 0x0091D003
		// (set) Token: 0x0601ED5C RID: 126300 RVA: 0x0091EE17 File Offset: 0x0091D017
		public unsafe FName Hook_Back_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Back_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Back_Socket) = value;
			}
		}

		// Token: 0x170035CF RID: 13775
		// (get) Token: 0x0601ED5D RID: 126301 RVA: 0x0091EE2C File Offset: 0x0091D02C
		// (set) Token: 0x0601ED5E RID: 126302 RVA: 0x0091EE65 File Offset: 0x0091D065
		public TArray<SNpcHookPart> Hook_Weapon
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Weapon) == null)
				{
					result = (this._Hook_Weapon = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Weapon, this));
				}
				return result;
			}
			set
			{
				this.Hook_Weapon.CopyAssign(value);
			}
		}

		// Token: 0x170035D0 RID: 13776
		// (get) Token: 0x0601ED5F RID: 126303 RVA: 0x0091EE73 File Offset: 0x0091D073
		// (set) Token: 0x0601ED60 RID: 126304 RVA: 0x0091EE87 File Offset: 0x0091D087
		public unsafe FName Hook_Weapon_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Weapon_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Weapon_Socket) = value;
			}
		}

		// Token: 0x170035D1 RID: 13777
		// (get) Token: 0x0601ED61 RID: 126305 RVA: 0x0091EE9C File Offset: 0x0091D09C
		// (set) Token: 0x0601ED62 RID: 126306 RVA: 0x0091EED5 File Offset: 0x0091D0D5
		public TArray<SNpcHookPart> Hook_Leg
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Leg) == null)
				{
					result = (this._Hook_Leg = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Leg, this));
				}
				return result;
			}
			set
			{
				this.Hook_Leg.CopyAssign(value);
			}
		}

		// Token: 0x170035D2 RID: 13778
		// (get) Token: 0x0601ED63 RID: 126307 RVA: 0x0091EEE3 File Offset: 0x0091D0E3
		// (set) Token: 0x0601ED64 RID: 126308 RVA: 0x0091EEF7 File Offset: 0x0091D0F7
		public unsafe FName Hook_Leg_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Leg_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Leg_Socket) = value;
			}
		}

		// Token: 0x170035D3 RID: 13779
		// (get) Token: 0x0601ED65 RID: 126309 RVA: 0x0091EF0C File Offset: 0x0091D10C
		// (set) Token: 0x0601ED66 RID: 126310 RVA: 0x0091EF20 File Offset: 0x0091D120
		public unsafe FColor Body_Dyecolor01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Body_Dyecolor01);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Body_Dyecolor01) = value;
			}
		}

		// Token: 0x170035D4 RID: 13780
		// (get) Token: 0x0601ED67 RID: 126311 RVA: 0x0091EF35 File Offset: 0x0091D135
		// (set) Token: 0x0601ED68 RID: 126312 RVA: 0x0091EF49 File Offset: 0x0091D149
		public unsafe FColor Body_Dyecolor02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Body_Dyecolor02);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Body_Dyecolor02) = value;
			}
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x0601ED69 RID: 126313 RVA: 0x0091EF60 File Offset: 0x0091D160
		// (set) Token: 0x0601ED6A RID: 126314 RVA: 0x0091EF99 File Offset: 0x0091D199
		public TArray<SNpcHookPart> Hook_Head
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Head) == null)
				{
					result = (this._Hook_Head = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Head, this));
				}
				return result;
			}
			set
			{
				this.Hook_Head.CopyAssign(value);
			}
		}

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x0601ED6B RID: 126315 RVA: 0x0091EFA7 File Offset: 0x0091D1A7
		// (set) Token: 0x0601ED6C RID: 126316 RVA: 0x0091EFBB File Offset: 0x0091D1BB
		public unsafe FName Hook_Head_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Head_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Head_Socket) = value;
			}
		}

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x0601ED6D RID: 126317 RVA: 0x0091EFD0 File Offset: 0x0091D1D0
		// (set) Token: 0x0601ED6E RID: 126318 RVA: 0x0091EFE4 File Offset: 0x0091D1E4
		[Nullable(2)]
		public unsafe UMaterialInstance Hair_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Hair_Mat);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Hair_Mat, value);
			}
		}

		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x0601ED6F RID: 126319 RVA: 0x0091EFF9 File Offset: 0x0091D1F9
		// (set) Token: 0x0601ED70 RID: 126320 RVA: 0x0091F00D File Offset: 0x0091D20D
		[Nullable(2)]
		public unsafe UMaterialInstance Skel_BodyUp_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_BodyUp_Mat);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_BodyUp_Mat, value);
			}
		}

		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x0601ED71 RID: 126321 RVA: 0x0091F022 File Offset: 0x0091D222
		// (set) Token: 0x0601ED72 RID: 126322 RVA: 0x0091F036 File Offset: 0x0091D236
		[Nullable(2)]
		public unsafe UMaterialInstance Skel_BodyDown_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_BodyDown_Mat);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_BodyDown_Mat, value);
			}
		}

		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x0601ED73 RID: 126323 RVA: 0x0091F04B File Offset: 0x0091D24B
		// (set) Token: 0x0601ED74 RID: 126324 RVA: 0x0091F05F File Offset: 0x0091D25F
		[Nullable(2)]
		public unsafe UMaterialInstance Skel_Body_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_Body_Mat);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Skel_Body_Mat, value);
			}
		}

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x0601ED75 RID: 126325 RVA: 0x0091F074 File Offset: 0x0091D274
		// (set) Token: 0x0601ED76 RID: 126326 RVA: 0x0091F0AD File Offset: 0x0091D2AD
		public TArray<UMaterialInstance> Skel_Body_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Skel_Body_Mat_Extra) == null)
				{
					result = (this._Skel_Body_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Skel_Body_Mat_Extra, this));
				}
				return result;
			}
			set
			{
				this.Skel_Body_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x0601ED77 RID: 126327 RVA: 0x0091F0BC File Offset: 0x0091D2BC
		// (set) Token: 0x0601ED78 RID: 126328 RVA: 0x0091F0F5 File Offset: 0x0091D2F5
		public TArray<UMaterialInstance> Hair_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Hair_Mat_Extra) == null)
				{
					result = (this._Hair_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hair_Mat_Extra, this));
				}
				return result;
			}
			set
			{
				this.Hair_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x0601ED79 RID: 126329 RVA: 0x0091F103 File Offset: 0x0091D303
		// (set) Token: 0x0601ED7A RID: 126330 RVA: 0x0091F117 File Offset: 0x0091D317
		[Nullable(2)]
		public unsafe UMaterialInstance Face_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Face_Mat);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_Face_Mat, value);
			}
		}

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x0601ED7B RID: 126331 RVA: 0x0091F12C File Offset: 0x0091D32C
		// (set) Token: 0x0601ED7C RID: 126332 RVA: 0x0091F165 File Offset: 0x0091D365
		public TArray<UMaterialInstance> Face_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Face_Mat_Extra) == null)
				{
					result = (this._Face_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Face_Mat_Extra, this));
				}
				return result;
			}
			set
			{
				this.Face_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x0601ED7D RID: 126333 RVA: 0x0091F174 File Offset: 0x0091D374
		// (set) Token: 0x0601ED7E RID: 126334 RVA: 0x0091F1AD File Offset: 0x0091D3AD
		public TArray<UMaterialInstance> Skel_BodyUp_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Skel_BodyUp_Mat_Extra) == null)
				{
					result = (this._Skel_BodyUp_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Skel_BodyUp_Mat_Extra, this));
				}
				return result;
			}
			set
			{
				this.Skel_BodyUp_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x0601ED7F RID: 126335 RVA: 0x0091F1BC File Offset: 0x0091D3BC
		// (set) Token: 0x0601ED80 RID: 126336 RVA: 0x0091F1F5 File Offset: 0x0091D3F5
		public TArray<UMaterialInstance> Skel_BodyDown_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Skel_BodyDown_Mat_Extra) == null)
				{
					result = (this._Skel_BodyDown_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Skel_BodyDown_Mat_Extra, this));
				}
				return result;
			}
			set
			{
				this.Skel_BodyDown_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x0601ED81 RID: 126337 RVA: 0x0091F204 File Offset: 0x0091D404
		// (set) Token: 0x0601ED82 RID: 126338 RVA: 0x0091F23D File Offset: 0x0091D43D
		public TArray<UMaterialInterface> ReferencedOulineMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._ReferencedOulineMaterials) == null)
				{
					result = (this._ReferencedOulineMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_ReferencedOulineMaterials, this));
				}
				return result;
			}
			set
			{
				this.ReferencedOulineMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x0601ED83 RID: 126339 RVA: 0x0091F24C File Offset: 0x0091D44C
		// (set) Token: 0x0601ED84 RID: 126340 RVA: 0x0091F285 File Offset: 0x0091D485
		public TArray<SNpcChildPart> ChildParts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcChildPart> result;
				if ((result = this._ChildParts) == null)
				{
					result = (this._ChildParts = new TArray<SNpcChildPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_ChildParts, this));
				}
				return result;
			}
			set
			{
				this.ChildParts.CopyAssign(value);
			}
		}

		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x0601ED85 RID: 126341 RVA: 0x0091F294 File Offset: 0x0091D494
		// (set) Token: 0x0601ED86 RID: 126342 RVA: 0x0091F2CD File Offset: 0x0091D4CD
		public TArray<FName> HideParentBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._HideParentBoneNames) == null)
				{
					result = (this._HideParentBoneNames = new TArray<FName>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_HideParentBoneNames, this));
				}
				return result;
			}
			set
			{
				this.HideParentBoneNames.CopyAssign(value);
			}
		}

		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x0601ED87 RID: 126343 RVA: 0x0091F2DC File Offset: 0x0091D4DC
		// (set) Token: 0x0601ED88 RID: 126344 RVA: 0x0091F315 File Offset: 0x0091D515
		public TArray<SNpcHookPart> Hook_Arm_L
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Arm_L) == null)
				{
					result = (this._Hook_Arm_L = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Arm_L, this));
				}
				return result;
			}
			set
			{
				this.Hook_Arm_L.CopyAssign(value);
			}
		}

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x0601ED89 RID: 126345 RVA: 0x0091F323 File Offset: 0x0091D523
		// (set) Token: 0x0601ED8A RID: 126346 RVA: 0x0091F337 File Offset: 0x0091D537
		public unsafe FName Hook_Arm_L_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Arm_L_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Arm_L_Socket) = value;
			}
		}

		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x0601ED8B RID: 126347 RVA: 0x0091F34C File Offset: 0x0091D54C
		// (set) Token: 0x0601ED8C RID: 126348 RVA: 0x0091F385 File Offset: 0x0091D585
		public TArray<SNpcHookPart> Hook_Fore
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Fore) == null)
				{
					result = (this._Hook_Fore = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Fore, this));
				}
				return result;
			}
			set
			{
				this.Hook_Fore.CopyAssign(value);
			}
		}

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x0601ED8D RID: 126349 RVA: 0x0091F393 File Offset: 0x0091D593
		// (set) Token: 0x0601ED8E RID: 126350 RVA: 0x0091F3A7 File Offset: 0x0091D5A7
		public unsafe FName Hook_Fore_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Fore_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Fore_Socket) = value;
			}
		}

		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x0601ED8F RID: 126351 RVA: 0x0091F3BC File Offset: 0x0091D5BC
		// (set) Token: 0x0601ED90 RID: 126352 RVA: 0x0091F3F5 File Offset: 0x0091D5F5
		public TArray<SNpcHookPart> Hook_Fore_L
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Fore_L) == null)
				{
					result = (this._Hook_Fore_L = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Fore_L, this));
				}
				return result;
			}
			set
			{
				this.Hook_Fore_L.CopyAssign(value);
			}
		}

		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x0601ED91 RID: 126353 RVA: 0x0091F403 File Offset: 0x0091D603
		// (set) Token: 0x0601ED92 RID: 126354 RVA: 0x0091F417 File Offset: 0x0091D617
		public unsafe FName Hook_Fore_L_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Fore_L_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Fore_L_Socket) = value;
			}
		}

		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x0601ED93 RID: 126355 RVA: 0x0091F42C File Offset: 0x0091D62C
		// (set) Token: 0x0601ED94 RID: 126356 RVA: 0x0091F465 File Offset: 0x0091D665
		public TArray<SNpcHookPart> Hook_Leg_L
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Leg_L) == null)
				{
					result = (this._Hook_Leg_L = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Leg_L, this));
				}
				return result;
			}
			set
			{
				this.Hook_Leg_L.CopyAssign(value);
			}
		}

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x0601ED95 RID: 126357 RVA: 0x0091F473 File Offset: 0x0091D673
		// (set) Token: 0x0601ED96 RID: 126358 RVA: 0x0091F487 File Offset: 0x0091D687
		public unsafe FName Hook_Leg_L_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Leg_L_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Leg_L_Socket) = value;
			}
		}

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x0601ED97 RID: 126359 RVA: 0x0091F49C File Offset: 0x0091D69C
		// (set) Token: 0x0601ED98 RID: 126360 RVA: 0x0091F4D5 File Offset: 0x0091D6D5
		public TArray<SNpcHookPart> Hook_Calf
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Calf) == null)
				{
					result = (this._Hook_Calf = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Calf, this));
				}
				return result;
			}
			set
			{
				this.Hook_Calf.CopyAssign(value);
			}
		}

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x0601ED99 RID: 126361 RVA: 0x0091F4E3 File Offset: 0x0091D6E3
		// (set) Token: 0x0601ED9A RID: 126362 RVA: 0x0091F4F7 File Offset: 0x0091D6F7
		public unsafe FName Hook_Calf_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Calf_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Calf_Socket) = value;
			}
		}

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x0601ED9B RID: 126363 RVA: 0x0091F50C File Offset: 0x0091D70C
		// (set) Token: 0x0601ED9C RID: 126364 RVA: 0x0091F545 File Offset: 0x0091D745
		public TArray<SNpcHookPart> Hook_Calf_L
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Calf_L) == null)
				{
					result = (this._Hook_Calf_L = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Calf_L, this));
				}
				return result;
			}
			set
			{
				this.Hook_Calf_L.CopyAssign(value);
			}
		}

		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x0601ED9D RID: 126365 RVA: 0x0091F553 File Offset: 0x0091D753
		// (set) Token: 0x0601ED9E RID: 126366 RVA: 0x0091F567 File Offset: 0x0091D767
		public unsafe FName Hook_Calf_L_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Calf_L_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Hook_Calf_L_Socket) = value;
			}
		}

		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x0601ED9F RID: 126367 RVA: 0x0091F57C File Offset: 0x0091D77C
		// (set) Token: 0x0601EDA0 RID: 126368 RVA: 0x0091F590 File Offset: 0x0091D790
		public unsafe FColor Skel_Face_Skin_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Skel_Face_Skin_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Skel_Face_Skin_Color) = value;
			}
		}

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x0601EDA1 RID: 126369 RVA: 0x0091F5A5 File Offset: 0x0091D7A5
		// (set) Token: 0x0601EDA2 RID: 126370 RVA: 0x0091F5B9 File Offset: 0x0091D7B9
		public unsafe FColor Skel_Face_SkinSubsurface_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Skel_Face_SkinSubsurface_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_Skel_Face_SkinSubsurface_Color) = value;
			}
		}

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x0601EDA3 RID: 126371 RVA: 0x0091F5CE File Offset: 0x0091D7CE
		// (set) Token: 0x0601EDA4 RID: 126372 RVA: 0x0091F5DE File Offset: 0x0091D7DE
		public unsafe bool bOverrideSkin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_bOverrideSkin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_bOverrideSkin) = (value ? 1 : 0);
			}
		}

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x0601EDA5 RID: 126373 RVA: 0x0091F5EF File Offset: 0x0091D7EF
		// (set) Token: 0x0601EDA6 RID: 126374 RVA: 0x0091F603 File Offset: 0x0091D803
		public unsafe FLinearColor SkinColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_SkinColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_SkinColor) = value;
			}
		}

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x0601EDA7 RID: 126375 RVA: 0x0091F618 File Offset: 0x0091D818
		// (set) Token: 0x0601EDA8 RID: 126376 RVA: 0x0091F62C File Offset: 0x0091D82C
		public unsafe FLinearColor SkinSubsurfaceColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_SkinSubsurfaceColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_SkinSubsurfaceColor) = value;
			}
		}

		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x0601EDA9 RID: 126377 RVA: 0x0091F644 File Offset: 0x0091D844
		// (set) Token: 0x0601EDAA RID: 126378 RVA: 0x0091F67D File Offset: 0x0091D87D
		public FMorphTargetPreviewItem MorphTarget
		{
			get
			{
				base.FastCheckIsValid();
				FMorphTargetPreviewItem result;
				if ((result = this._MorphTarget) == null)
				{
					result = (this._MorphTarget = new FMorphTargetPreviewItem(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_MorphTarget, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMorphTargetPreviewItem.StaticStruct(), base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_MorphTarget, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601EDAB RID: 126379 RVA: 0x0091F6A0 File Offset: 0x0091D8A0
		[SkipLocalsInit]
		public unsafe virtual void IsSeq(ref bool bSeq)
		{
			PD_NpcSetupData_C.__IsSeq_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__IsSeq_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(PD_NpcSetupData_C.__IsSeq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__IsSeq_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bSeq = bSeq;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__IsSeq_NativeFunctionPtr, (void*)ptr);
			bSeq = ptr->bSeq;
		}

		// Token: 0x0601EDAC RID: 126380 RVA: 0x0091F6EF File Offset: 0x0091D8EF
		[SkipLocalsInit]
		public virtual void SetOLReference()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__SetOLReference_NativeFunctionPtr, null);
		}

		// Token: 0x0601EDAD RID: 126381 RVA: 0x0091F704 File Offset: 0x0091D904
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void GetOutlineReference(bool bSeq, USkeletalMesh Skel, UMaterialInterface mat, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UMaterialInterface> mat_extra, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UMaterialInterface> OutOLMat)
		{
			PD_NpcSetupData_C.__GetOutlineReference_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__GetOutlineReference_FunctionParams[(UIntPtr)575] + 15L / (long)sizeof(PD_NpcSetupData_C.__GetOutlineReference_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__GetOutlineReference_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bSeq = bSeq;
			ptr->Skel = ((Skel != null) ? Skel.NativePtr : IntPtr.Zero);
			ptr->mat = ((mat != null) ? mat.NativePtr : IntPtr.Zero);
			TArray<UMaterialInterface> tarray = mat_extra;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->mat_extra);
			}
			TArray<UMaterialInterface> tarray2 = OutOLMat;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->OutOLMat);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__GetOutlineReference_NativeFunctionPtr, (void*)ptr);
			TArray<UMaterialInterface> tarray3 = mat_extra;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->mat_extra);
			}
			TArray<UMaterialInterface> tarray4 = OutOLMat;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->OutOLMat);
			}
			UnrealReflectionUtils.DestroyStruct(PD_NpcSetupData_C.__GetOutlineReference_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601EDAE RID: 126382 RVA: 0x0091F7DE File Offset: 0x0091D9DE
		[SkipLocalsInit]
		public virtual void FixNPCOutline()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__FixNPCOutline_NativeFunctionPtr, null);
		}

		// Token: 0x0601EDAF RID: 126383 RVA: 0x0091F7F4 File Offset: 0x0091D9F4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void Set_Single_Override(ref USkeletalMesh skel_mesh, ref UMaterialInstance mat, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UMaterialInstance> mat_extra)
		{
			PD_NpcSetupData_C.__Set_Single_Override_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__Set_Single_Override_FunctionParams[(UIntPtr)719] + 15L / (long)sizeof(PD_NpcSetupData_C.__Set_Single_Override_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__Set_Single_Override_NativeFunctionPtr, (void*)ptr, 1);
			ref PD_NpcSetupData_C.__Set_Single_Override_FunctionParams ptr2 = ref *ptr;
			USkeletalMesh uskeletalMesh = skel_mesh;
			ptr2.skel_mesh = ((uskeletalMesh != null) ? uskeletalMesh.NativePtr : IntPtr.Zero);
			ref PD_NpcSetupData_C.__Set_Single_Override_FunctionParams ptr3 = ref *ptr;
			UMaterialInstance umaterialInstance = mat;
			ptr3.mat = ((umaterialInstance != null) ? umaterialInstance.NativePtr : IntPtr.Zero);
			TArray<UMaterialInstance> tarray = mat_extra;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->mat_extra);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__Set_Single_Override_NativeFunctionPtr, (void*)ptr);
			skel_mesh = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMesh>(ptr->skel_mesh);
			mat = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstance>(ptr->mat);
			TArray<UMaterialInstance> tarray2 = mat_extra;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->mat_extra);
			}
			UnrealReflectionUtils.DestroyStruct(PD_NpcSetupData_C.__Set_Single_Override_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601EDB0 RID: 126384 RVA: 0x0091F8B9 File Offset: 0x0091DAB9
		[SkipLocalsInit]
		public virtual void Set_Override()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__Set_Override_NativeFunctionPtr, null);
		}

		// Token: 0x0601EDB1 RID: 126385 RVA: 0x0091F8D0 File Offset: 0x0091DAD0
		[SkipLocalsInit]
		public unsafe virtual void GetAllPartMaterials([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UMaterialInstance> Results)
		{
			PD_NpcSetupData_C.__GetAllPartMaterials_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__GetAllPartMaterials_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(PD_NpcSetupData_C.__GetAllPartMaterials_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__GetAllPartMaterials_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UMaterialInstance> tarray = Results;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Results);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__GetAllPartMaterials_NativeFunctionPtr, (void*)ptr);
			TArray<UMaterialInstance> tarray2 = Results;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Results);
			}
			UnrealReflectionUtils.DestroyStruct(PD_NpcSetupData_C.__GetAllPartMaterials_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601EDB2 RID: 126386 RVA: 0x0091F948 File Offset: 0x0091DB48
		[SkipLocalsInit]
		public unsafe virtual void GetAllParts([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USkeletalMesh> OutParts)
		{
			PD_NpcSetupData_C.__GetAllParts_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__GetAllParts_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(PD_NpcSetupData_C.__GetAllParts_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__GetAllParts_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USkeletalMesh> tarray = OutParts;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutParts);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__GetAllParts_NativeFunctionPtr, (void*)ptr);
			TArray<USkeletalMesh> tarray2 = OutParts;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutParts);
			}
			UnrealReflectionUtils.DestroyStruct(PD_NpcSetupData_C.__GetAllParts_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601EDB3 RID: 126387 RVA: 0x0091F9C0 File Offset: 0x0091DBC0
		[SkipLocalsInit]
		public unsafe virtual void HasSkelBody(ref bool Result)
		{
			PD_NpcSetupData_C.__HasSkelBody_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__HasSkelBody_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_NpcSetupData_C.__HasSkelBody_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__HasSkelBody_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__HasSkelBody_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0601EDB4 RID: 126388 RVA: 0x0091FA10 File Offset: 0x0091DC10
		[SkipLocalsInit]
		public unsafe virtual void HasSkelBodyDown(ref bool Result)
		{
			PD_NpcSetupData_C.__HasSkelBodyDown_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__HasSkelBodyDown_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_NpcSetupData_C.__HasSkelBodyDown_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__HasSkelBodyDown_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__HasSkelBodyDown_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0601EDB5 RID: 126389 RVA: 0x0091FA60 File Offset: 0x0091DC60
		[SkipLocalsInit]
		public unsafe virtual void HasSkelBodyUp(ref bool Result)
		{
			PD_NpcSetupData_C.__HasSkelBodyUp_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__HasSkelBodyUp_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_NpcSetupData_C.__HasSkelBodyUp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__HasSkelBodyUp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__HasSkelBodyUp_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0601EDB6 RID: 126390 RVA: 0x0091FAB0 File Offset: 0x0091DCB0
		[SkipLocalsInit]
		public unsafe virtual void HasSkelFace(ref bool Result)
		{
			PD_NpcSetupData_C.__HasSkelFace_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__HasSkelFace_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_NpcSetupData_C.__HasSkelFace_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__HasSkelFace_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__HasSkelFace_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0601EDB7 RID: 126391 RVA: 0x0091FB00 File Offset: 0x0091DD00
		[SkipLocalsInit]
		public unsafe virtual void HasSkelHair(ref bool Result)
		{
			PD_NpcSetupData_C.__HasSkelHair_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__HasSkelHair_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_NpcSetupData_C.__HasSkelHair_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__HasSkelHair_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__HasSkelHair_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0601EDB8 RID: 126392 RVA: 0x0091FB50 File Offset: 0x0091DD50
		[SkipLocalsInit]
		public unsafe virtual void HasSkelMain(ref bool Result)
		{
			PD_NpcSetupData_C.__HasSkelMain_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__HasSkelMain_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_NpcSetupData_C.__HasSkelMain_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__HasSkelMain_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__HasSkelMain_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0601EDB9 RID: 126393 RVA: 0x0091FBA0 File Offset: 0x0091DDA0
		[SkipLocalsInit]
		public unsafe virtual void IsEmpty(ref bool Result)
		{
			PD_NpcSetupData_C.__IsEmpty_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__IsEmpty_FunctionParams[(UIntPtr)28] + 15L / (long)sizeof(PD_NpcSetupData_C.__IsEmpty_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__IsEmpty_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__IsEmpty_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0601EDBA RID: 126394 RVA: 0x0091FBEF File Offset: 0x0091DDEF
		[SkipLocalsInit]
		public override void OnPreSave()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__OnPreSave_NativeFunctionPtr, null);
		}

		// Token: 0x0601EDBB RID: 126395 RVA: 0x0091FC03 File Offset: 0x0091DE03
		[SkipLocalsInit]
		protected override void OnPreSave_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, PD_NpcSetupData_C.__OnPreSave_NativeFunctionPtr, null);
		}

		// Token: 0x0601EDBC RID: 126396 RVA: 0x0091FC17 File Offset: 0x0091DE17
		protected PD_NpcSetupData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010627 RID: 67111
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/PD_NpcSetupData.PD_NpcSetupData_C";

		// Token: 0x04010628 RID: 67112
		private static IntPtr _ClassPtr;

		// Token: 0x04010629 RID: 67113
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401062A RID: 67114
		internal static int __PropertyOffset_Skel_Hair;

		// Token: 0x0401062B RID: 67115
		internal static int __PropertyOffset_Skel_Hair_Color;

		// Token: 0x0401062C RID: 67116
		internal static int __PropertyOffset_Skel_Face;

		// Token: 0x0401062D RID: 67117
		internal static int __PropertyOffset_Skel_BodyUp;

		// Token: 0x0401062E RID: 67118
		internal static int __PropertyOffset_Skel_BodyUp_Color;

		// Token: 0x0401062F RID: 67119
		internal static int __PropertyOffset_Skel_BodyDown;

		// Token: 0x04010630 RID: 67120
		internal static int __PropertyOffset_Skel_BodyDown_Color;

		// Token: 0x04010631 RID: 67121
		internal static int __PropertyOffset_Skel_Body;

		// Token: 0x04010632 RID: 67122
		internal static int __PropertyOffset_bDyeColor;

		// Token: 0x04010633 RID: 67123
		internal static int __PropertyOffset_SkinDyeColor;

		// Token: 0x04010634 RID: 67124
		internal static int __PropertyOffset_NpcSetupType;

		// Token: 0x04010635 RID: 67125
		internal static int __PropertyOffset_Skel_Main;

		// Token: 0x04010636 RID: 67126
		internal static int __PropertyOffset_Hook_Arm;

		// Token: 0x04010637 RID: 67127
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Arm;

		// Token: 0x04010638 RID: 67128
		internal static int __PropertyOffset_Hook_Arm_Socket;

		// Token: 0x04010639 RID: 67129
		internal static int __PropertyOffset_Hook_Waist;

		// Token: 0x0401063A RID: 67130
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Waist;

		// Token: 0x0401063B RID: 67131
		internal static int __PropertyOffset_Hook_Waist_Socket;

		// Token: 0x0401063C RID: 67132
		internal static int __PropertyOffset_Hook_Back;

		// Token: 0x0401063D RID: 67133
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Back;

		// Token: 0x0401063E RID: 67134
		internal static int __PropertyOffset_Hook_Back_Socket;

		// Token: 0x0401063F RID: 67135
		internal static int __PropertyOffset_Hook_Weapon;

		// Token: 0x04010640 RID: 67136
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Weapon;

		// Token: 0x04010641 RID: 67137
		internal static int __PropertyOffset_Hook_Weapon_Socket;

		// Token: 0x04010642 RID: 67138
		internal static int __PropertyOffset_Hook_Leg;

		// Token: 0x04010643 RID: 67139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Leg;

		// Token: 0x04010644 RID: 67140
		internal static int __PropertyOffset_Hook_Leg_Socket;

		// Token: 0x04010645 RID: 67141
		internal static int __PropertyOffset_Body_Dyecolor01;

		// Token: 0x04010646 RID: 67142
		internal static int __PropertyOffset_Body_Dyecolor02;

		// Token: 0x04010647 RID: 67143
		internal static int __PropertyOffset_Hook_Head;

		// Token: 0x04010648 RID: 67144
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Head;

		// Token: 0x04010649 RID: 67145
		internal static int __PropertyOffset_Hook_Head_Socket;

		// Token: 0x0401064A RID: 67146
		internal static int __PropertyOffset_Hair_Mat;

		// Token: 0x0401064B RID: 67147
		internal static int __PropertyOffset_Skel_BodyUp_Mat;

		// Token: 0x0401064C RID: 67148
		internal static int __PropertyOffset_Skel_BodyDown_Mat;

		// Token: 0x0401064D RID: 67149
		internal static int __PropertyOffset_Skel_Body_Mat;

		// Token: 0x0401064E RID: 67150
		internal static int __PropertyOffset_Skel_Body_Mat_Extra;

		// Token: 0x0401064F RID: 67151
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Skel_Body_Mat_Extra;

		// Token: 0x04010650 RID: 67152
		internal static int __PropertyOffset_Hair_Mat_Extra;

		// Token: 0x04010651 RID: 67153
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Hair_Mat_Extra;

		// Token: 0x04010652 RID: 67154
		internal static int __PropertyOffset_Face_Mat;

		// Token: 0x04010653 RID: 67155
		internal static int __PropertyOffset_Face_Mat_Extra;

		// Token: 0x04010654 RID: 67156
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Face_Mat_Extra;

		// Token: 0x04010655 RID: 67157
		internal static int __PropertyOffset_Skel_BodyUp_Mat_Extra;

		// Token: 0x04010656 RID: 67158
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Skel_BodyUp_Mat_Extra;

		// Token: 0x04010657 RID: 67159
		internal static int __PropertyOffset_Skel_BodyDown_Mat_Extra;

		// Token: 0x04010658 RID: 67160
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Skel_BodyDown_Mat_Extra;

		// Token: 0x04010659 RID: 67161
		internal static int __PropertyOffset_ReferencedOulineMaterials;

		// Token: 0x0401065A RID: 67162
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _ReferencedOulineMaterials;

		// Token: 0x0401065B RID: 67163
		internal static int __PropertyOffset_ChildParts;

		// Token: 0x0401065C RID: 67164
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcChildPart> _ChildParts;

		// Token: 0x0401065D RID: 67165
		internal static int __PropertyOffset_HideParentBoneNames;

		// Token: 0x0401065E RID: 67166
		[Nullable(2)]
		private TArray<FName> _HideParentBoneNames;

		// Token: 0x0401065F RID: 67167
		internal static int __PropertyOffset_Hook_Arm_L;

		// Token: 0x04010660 RID: 67168
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Arm_L;

		// Token: 0x04010661 RID: 67169
		internal static int __PropertyOffset_Hook_Arm_L_Socket;

		// Token: 0x04010662 RID: 67170
		internal static int __PropertyOffset_Hook_Fore;

		// Token: 0x04010663 RID: 67171
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Fore;

		// Token: 0x04010664 RID: 67172
		internal static int __PropertyOffset_Hook_Fore_Socket;

		// Token: 0x04010665 RID: 67173
		internal static int __PropertyOffset_Hook_Fore_L;

		// Token: 0x04010666 RID: 67174
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Fore_L;

		// Token: 0x04010667 RID: 67175
		internal static int __PropertyOffset_Hook_Fore_L_Socket;

		// Token: 0x04010668 RID: 67176
		internal static int __PropertyOffset_Hook_Leg_L;

		// Token: 0x04010669 RID: 67177
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Leg_L;

		// Token: 0x0401066A RID: 67178
		internal static int __PropertyOffset_Hook_Leg_L_Socket;

		// Token: 0x0401066B RID: 67179
		internal static int __PropertyOffset_Hook_Calf;

		// Token: 0x0401066C RID: 67180
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Calf;

		// Token: 0x0401066D RID: 67181
		internal static int __PropertyOffset_Hook_Calf_Socket;

		// Token: 0x0401066E RID: 67182
		internal static int __PropertyOffset_Hook_Calf_L;

		// Token: 0x0401066F RID: 67183
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Calf_L;

		// Token: 0x04010670 RID: 67184
		internal static int __PropertyOffset_Hook_Calf_L_Socket;

		// Token: 0x04010671 RID: 67185
		internal static int __PropertyOffset_Skel_Face_Skin_Color;

		// Token: 0x04010672 RID: 67186
		internal static int __PropertyOffset_Skel_Face_SkinSubsurface_Color;

		// Token: 0x04010673 RID: 67187
		internal static int __PropertyOffset_bOverrideSkin;

		// Token: 0x04010674 RID: 67188
		internal static int __PropertyOffset_SkinColor;

		// Token: 0x04010675 RID: 67189
		internal static int __PropertyOffset_SkinSubsurfaceColor;

		// Token: 0x04010676 RID: 67190
		internal static int __PropertyOffset_MorphTarget;

		// Token: 0x04010677 RID: 67191
		[Nullable(2)]
		private FMorphTargetPreviewItem _MorphTarget;

		// Token: 0x04010678 RID: 67192
		private static IntPtr __IsSeq_NativeFunctionPtr;

		// Token: 0x04010679 RID: 67193
		private static IntPtr __SetOLReference_NativeFunctionPtr;

		// Token: 0x0401067A RID: 67194
		private static IntPtr __GetOutlineReference_NativeFunctionPtr;

		// Token: 0x0401067B RID: 67195
		private static IntPtr __FixNPCOutline_NativeFunctionPtr;

		// Token: 0x0401067C RID: 67196
		private static IntPtr __Set_Single_Override_NativeFunctionPtr;

		// Token: 0x0401067D RID: 67197
		private static IntPtr __Set_Override_NativeFunctionPtr;

		// Token: 0x0401067E RID: 67198
		private static IntPtr __GetAllPartMaterials_NativeFunctionPtr;

		// Token: 0x0401067F RID: 67199
		private static IntPtr __GetAllParts_NativeFunctionPtr;

		// Token: 0x04010680 RID: 67200
		private static IntPtr __HasSkelBody_NativeFunctionPtr;

		// Token: 0x04010681 RID: 67201
		private static IntPtr __HasSkelBodyDown_NativeFunctionPtr;

		// Token: 0x04010682 RID: 67202
		private static IntPtr __HasSkelBodyUp_NativeFunctionPtr;

		// Token: 0x04010683 RID: 67203
		private static IntPtr __HasSkelFace_NativeFunctionPtr;

		// Token: 0x04010684 RID: 67204
		private static IntPtr __HasSkelHair_NativeFunctionPtr;

		// Token: 0x04010685 RID: 67205
		private static IntPtr __HasSkelMain_NativeFunctionPtr;

		// Token: 0x04010686 RID: 67206
		private static IntPtr __IsEmpty_NativeFunctionPtr;

		// Token: 0x04010687 RID: 67207
		private static IntPtr __OnPreSave_NativeFunctionPtr;

		// Token: 0x02008EEA RID: 36586
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __IsSeq_FunctionParams
		{
			// Token: 0x0402CBD0 RID: 183248
			[FieldOffset(0)]
			public bool bSeq;
		}

		// Token: 0x02008EEB RID: 36587
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 560)]
		protected ref struct __GetOutlineReference_FunctionParams
		{
			// Token: 0x0402CBD1 RID: 183249
			[FieldOffset(0)]
			public bool bSeq;

			// Token: 0x0402CBD2 RID: 183250
			[FieldOffset(8)]
			public IntPtr Skel;

			// Token: 0x0402CBD3 RID: 183251
			[FieldOffset(16)]
			public IntPtr mat;

			// Token: 0x0402CBD4 RID: 183252
			[FieldOffset(24)]
			public byte mat_extra;

			// Token: 0x0402CBD5 RID: 183253
			[FieldOffset(40)]
			public byte OutOLMat;
		}

		// Token: 0x02008EEC RID: 36588
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 704)]
		protected ref struct __Set_Single_Override_FunctionParams
		{
			// Token: 0x0402CBD6 RID: 183254
			[FieldOffset(0)]
			public IntPtr skel_mesh;

			// Token: 0x0402CBD7 RID: 183255
			[FieldOffset(8)]
			public IntPtr mat;

			// Token: 0x0402CBD8 RID: 183256
			[FieldOffset(16)]
			public byte mat_extra;
		}

		// Token: 0x02008EED RID: 36589
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetAllPartMaterials_FunctionParams
		{
			// Token: 0x0402CBD9 RID: 183257
			[FieldOffset(0)]
			public byte Results;
		}

		// Token: 0x02008EEE RID: 36590
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetAllParts_FunctionParams
		{
			// Token: 0x0402CBDA RID: 183258
			[FieldOffset(0)]
			public byte OutParts;
		}

		// Token: 0x02008EEF RID: 36591
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelBody_FunctionParams
		{
			// Token: 0x0402CBDB RID: 183259
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x02008EF0 RID: 36592
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelBodyDown_FunctionParams
		{
			// Token: 0x0402CBDC RID: 183260
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x02008EF1 RID: 36593
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelBodyUp_FunctionParams
		{
			// Token: 0x0402CBDD RID: 183261
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x02008EF2 RID: 36594
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelFace_FunctionParams
		{
			// Token: 0x0402CBDE RID: 183262
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x02008EF3 RID: 36595
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelHair_FunctionParams
		{
			// Token: 0x0402CBDF RID: 183263
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x02008EF4 RID: 36596
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelMain_FunctionParams
		{
			// Token: 0x0402CBE0 RID: 183264
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x02008EF5 RID: 36597
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 13)]
		protected ref struct __IsEmpty_FunctionParams
		{
			// Token: 0x0402CBE1 RID: 183265
			[FieldOffset(0)]
			public bool Result;
		}
	}
}
