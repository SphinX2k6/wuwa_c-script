using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003E02 RID: 15874
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/PD_RoleSetupData.PD_RoleSetupData_C")]
	[UnrealStructLayout(576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class PD_RoleSetupData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027B0A RID: 162570 RVA: 0x00998C19 File Offset: 0x00996E19
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_RoleSetupData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Npc/PD_RoleSetupData.PD_RoleSetupData_C");
			}
			return PD_RoleSetupData_C._ClassPtr;
		}

		// Token: 0x06027B0B RID: 162571 RVA: 0x00998C40 File Offset: 0x00996E40
		public PD_RoleSetupData_C() : this(BuiltinUtils.AllocNativeUObject(PD_RoleSetupData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027B0C RID: 162572 RVA: 0x00998C68 File Offset: 0x00996E68
		public PD_RoleSetupData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_RoleSetupData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005975 RID: 22901
		// (get) Token: 0x06027B0D RID: 162573 RVA: 0x00998C9B File Offset: 0x00996E9B
		// (set) Token: 0x06027B0E RID: 162574 RVA: 0x00998CAF File Offset: 0x00996EAF
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_Hair
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005976 RID: 22902
		// (get) Token: 0x06027B0F RID: 162575 RVA: 0x00998CC4 File Offset: 0x00996EC4
		// (set) Token: 0x06027B10 RID: 162576 RVA: 0x00998CD8 File Offset: 0x00996ED8
		public unsafe FColor Skel_Hair_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005977 RID: 22903
		// (get) Token: 0x06027B11 RID: 162577 RVA: 0x00998CED File Offset: 0x00996EED
		// (set) Token: 0x06027B12 RID: 162578 RVA: 0x00998D01 File Offset: 0x00996F01
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_Face
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005978 RID: 22904
		// (get) Token: 0x06027B13 RID: 162579 RVA: 0x00998D16 File Offset: 0x00996F16
		// (set) Token: 0x06027B14 RID: 162580 RVA: 0x00998D2A File Offset: 0x00996F2A
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_BodyUp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005979 RID: 22905
		// (get) Token: 0x06027B15 RID: 162581 RVA: 0x00998D3F File Offset: 0x00996F3F
		// (set) Token: 0x06027B16 RID: 162582 RVA: 0x00998D53 File Offset: 0x00996F53
		public unsafe FColor Skel_BodyUp_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700597A RID: 22906
		// (get) Token: 0x06027B17 RID: 162583 RVA: 0x00998D68 File Offset: 0x00996F68
		// (set) Token: 0x06027B18 RID: 162584 RVA: 0x00998D7C File Offset: 0x00996F7C
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_BodyDown
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_5);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700597B RID: 22907
		// (get) Token: 0x06027B19 RID: 162585 RVA: 0x00998D91 File Offset: 0x00996F91
		// (set) Token: 0x06027B1A RID: 162586 RVA: 0x00998DA5 File Offset: 0x00996FA5
		public unsafe FColor Skel_BodyDown_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700597C RID: 22908
		// (get) Token: 0x06027B1B RID: 162587 RVA: 0x00998DBA File Offset: 0x00996FBA
		// (set) Token: 0x06027B1C RID: 162588 RVA: 0x00998DCE File Offset: 0x00996FCE
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_Body
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_7);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x1700597D RID: 22909
		// (get) Token: 0x06027B1D RID: 162589 RVA: 0x00998DE3 File Offset: 0x00996FE3
		// (set) Token: 0x06027B1E RID: 162590 RVA: 0x00998DF3 File Offset: 0x00996FF3
		public unsafe bool bDyeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700597E RID: 22910
		// (get) Token: 0x06027B1F RID: 162591 RVA: 0x00998E04 File Offset: 0x00997004
		// (set) Token: 0x06027B20 RID: 162592 RVA: 0x00998E18 File Offset: 0x00997018
		public unsafe FLinearColor SkinDyeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700597F RID: 22911
		// (get) Token: 0x06027B21 RID: 162593 RVA: 0x00998E2D File Offset: 0x0099702D
		// (set) Token: 0x06027B22 RID: 162594 RVA: 0x00998E41 File Offset: 0x00997041
		[Nullable(0)]
		public unsafe TEnumAsByte<ERoleSetupType> RoleSetupType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_10);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005980 RID: 22912
		// (get) Token: 0x06027B23 RID: 162595 RVA: 0x00998E56 File Offset: 0x00997056
		// (set) Token: 0x06027B24 RID: 162596 RVA: 0x00998E6A File Offset: 0x0099706A
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_Main
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_11);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17005981 RID: 22913
		// (get) Token: 0x06027B25 RID: 162597 RVA: 0x00998E80 File Offset: 0x00997080
		// (set) Token: 0x06027B26 RID: 162598 RVA: 0x00998EB9 File Offset: 0x009970B9
		public TArray<SRoleHookPart> Hook_Arm
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SRoleHookPart> result;
				if ((result = this._Hook_Arm) == null)
				{
					result = (this._Hook_Arm = new TArray<SRoleHookPart>(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.Hook_Arm.CopyAssign(value);
			}
		}

		// Token: 0x17005982 RID: 22914
		// (get) Token: 0x06027B27 RID: 162599 RVA: 0x00998EC7 File Offset: 0x009970C7
		// (set) Token: 0x06027B28 RID: 162600 RVA: 0x00998EDB File Offset: 0x009970DB
		public unsafe FName Hook_Arm_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005983 RID: 22915
		// (get) Token: 0x06027B29 RID: 162601 RVA: 0x00998EF0 File Offset: 0x009970F0
		// (set) Token: 0x06027B2A RID: 162602 RVA: 0x00998F29 File Offset: 0x00997129
		public TArray<SRoleHookPart> Hook_Waist
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SRoleHookPart> result;
				if ((result = this._Hook_Waist) == null)
				{
					result = (this._Hook_Waist = new TArray<SRoleHookPart>(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				this.Hook_Waist.CopyAssign(value);
			}
		}

		// Token: 0x17005984 RID: 22916
		// (get) Token: 0x06027B2B RID: 162603 RVA: 0x00998F37 File Offset: 0x00997137
		// (set) Token: 0x06027B2C RID: 162604 RVA: 0x00998F4B File Offset: 0x0099714B
		public unsafe FName Hook_Waist_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005985 RID: 22917
		// (get) Token: 0x06027B2D RID: 162605 RVA: 0x00998F60 File Offset: 0x00997160
		// (set) Token: 0x06027B2E RID: 162606 RVA: 0x00998F99 File Offset: 0x00997199
		public TArray<SRoleHookPart> Hook_Back
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SRoleHookPart> result;
				if ((result = this._Hook_Back) == null)
				{
					result = (this._Hook_Back = new TArray<SRoleHookPart>(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				this.Hook_Back.CopyAssign(value);
			}
		}

		// Token: 0x17005986 RID: 22918
		// (get) Token: 0x06027B2F RID: 162607 RVA: 0x00998FA7 File Offset: 0x009971A7
		// (set) Token: 0x06027B30 RID: 162608 RVA: 0x00998FBB File Offset: 0x009971BB
		public unsafe FName Hook_Back_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005987 RID: 22919
		// (get) Token: 0x06027B31 RID: 162609 RVA: 0x00998FD0 File Offset: 0x009971D0
		// (set) Token: 0x06027B32 RID: 162610 RVA: 0x00999009 File Offset: 0x00997209
		public TArray<SRoleHookPart> Hook_Weapon
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SRoleHookPart> result;
				if ((result = this._Hook_Weapon) == null)
				{
					result = (this._Hook_Weapon = new TArray<SRoleHookPart>(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_18, this));
				}
				return result;
			}
			set
			{
				this.Hook_Weapon.CopyAssign(value);
			}
		}

		// Token: 0x17005988 RID: 22920
		// (get) Token: 0x06027B33 RID: 162611 RVA: 0x00999017 File Offset: 0x00997217
		// (set) Token: 0x06027B34 RID: 162612 RVA: 0x0099902B File Offset: 0x0099722B
		public unsafe FName Hook_Weapon_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005989 RID: 22921
		// (get) Token: 0x06027B35 RID: 162613 RVA: 0x00999040 File Offset: 0x00997240
		// (set) Token: 0x06027B36 RID: 162614 RVA: 0x00999079 File Offset: 0x00997279
		public TArray<SRoleHookPart> Hook_Leg
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SRoleHookPart> result;
				if ((result = this._Hook_Leg) == null)
				{
					result = (this._Hook_Leg = new TArray<SRoleHookPart>(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_20, this));
				}
				return result;
			}
			set
			{
				this.Hook_Leg.CopyAssign(value);
			}
		}

		// Token: 0x1700598A RID: 22922
		// (get) Token: 0x06027B37 RID: 162615 RVA: 0x00999087 File Offset: 0x00997287
		// (set) Token: 0x06027B38 RID: 162616 RVA: 0x0099909B File Offset: 0x0099729B
		public unsafe FName Hook_Leg_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700598B RID: 22923
		// (get) Token: 0x06027B39 RID: 162617 RVA: 0x009990B0 File Offset: 0x009972B0
		// (set) Token: 0x06027B3A RID: 162618 RVA: 0x009990C4 File Offset: 0x009972C4
		public unsafe FColor Body_Dyecolor01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700598C RID: 22924
		// (get) Token: 0x06027B3B RID: 162619 RVA: 0x009990D9 File Offset: 0x009972D9
		// (set) Token: 0x06027B3C RID: 162620 RVA: 0x009990ED File Offset: 0x009972ED
		public unsafe FColor Body_Dyecolor02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x1700598D RID: 22925
		// (get) Token: 0x06027B3D RID: 162621 RVA: 0x00999104 File Offset: 0x00997304
		// (set) Token: 0x06027B3E RID: 162622 RVA: 0x0099913D File Offset: 0x0099733D
		public TArray<SRoleHookPart> Hook_Head
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SRoleHookPart> result;
				if ((result = this._Hook_Head) == null)
				{
					result = (this._Hook_Head = new TArray<SRoleHookPart>(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_24, this));
				}
				return result;
			}
			set
			{
				this.Hook_Head.CopyAssign(value);
			}
		}

		// Token: 0x1700598E RID: 22926
		// (get) Token: 0x06027B3F RID: 162623 RVA: 0x0099914B File Offset: 0x0099734B
		// (set) Token: 0x06027B40 RID: 162624 RVA: 0x0099915F File Offset: 0x0099735F
		public unsafe FName Hook_Head_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x1700598F RID: 22927
		// (get) Token: 0x06027B41 RID: 162625 RVA: 0x00999174 File Offset: 0x00997374
		// (set) Token: 0x06027B42 RID: 162626 RVA: 0x00999188 File Offset: 0x00997388
		[Nullable(2)]
		public unsafe UMaterialInstance Hair_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_26);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17005990 RID: 22928
		// (get) Token: 0x06027B43 RID: 162627 RVA: 0x0099919D File Offset: 0x0099739D
		// (set) Token: 0x06027B44 RID: 162628 RVA: 0x009991B1 File Offset: 0x009973B1
		[Nullable(2)]
		public unsafe UMaterialInstance Face_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_27);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17005991 RID: 22929
		// (get) Token: 0x06027B45 RID: 162629 RVA: 0x009991C6 File Offset: 0x009973C6
		// (set) Token: 0x06027B46 RID: 162630 RVA: 0x009991DA File Offset: 0x009973DA
		[Nullable(2)]
		public unsafe UMaterialInstance Skel_BodyUp_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_28);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17005992 RID: 22930
		// (get) Token: 0x06027B47 RID: 162631 RVA: 0x009991EF File Offset: 0x009973EF
		// (set) Token: 0x06027B48 RID: 162632 RVA: 0x00999203 File Offset: 0x00997403
		[Nullable(2)]
		public unsafe UMaterialInstance Skel_BodyDown_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_29);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17005993 RID: 22931
		// (get) Token: 0x06027B49 RID: 162633 RVA: 0x00999218 File Offset: 0x00997418
		// (set) Token: 0x06027B4A RID: 162634 RVA: 0x0099922C File Offset: 0x0099742C
		[Nullable(2)]
		public unsafe UMaterialInstance Skel_Body_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_30);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x17005994 RID: 22932
		// (get) Token: 0x06027B4B RID: 162635 RVA: 0x00999244 File Offset: 0x00997444
		// (set) Token: 0x06027B4C RID: 162636 RVA: 0x0099927D File Offset: 0x0099747D
		public TArray<UMaterialInstance> Skel_Body_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Skel_Body_Mat_Extra) == null)
				{
					result = (this._Skel_Body_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_31, this));
				}
				return result;
			}
			set
			{
				this.Skel_Body_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x17005995 RID: 22933
		// (get) Token: 0x06027B4D RID: 162637 RVA: 0x0099928C File Offset: 0x0099748C
		// (set) Token: 0x06027B4E RID: 162638 RVA: 0x009992C5 File Offset: 0x009974C5
		public TArray<UMaterialInstance> Hair_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Hair_Mat_Extra) == null)
				{
					result = (this._Hair_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_32, this));
				}
				return result;
			}
			set
			{
				this.Hair_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x17005996 RID: 22934
		// (get) Token: 0x06027B4F RID: 162639 RVA: 0x009992D4 File Offset: 0x009974D4
		// (set) Token: 0x06027B50 RID: 162640 RVA: 0x0099930D File Offset: 0x0099750D
		public TArray<UMaterialInstance> Face_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Face_Mat_Extra) == null)
				{
					result = (this._Face_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_33, this));
				}
				return result;
			}
			set
			{
				this.Face_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x17005997 RID: 22935
		// (get) Token: 0x06027B51 RID: 162641 RVA: 0x0099931C File Offset: 0x0099751C
		// (set) Token: 0x06027B52 RID: 162642 RVA: 0x00999355 File Offset: 0x00997555
		public TArray<UMaterialInstance> Skel_BodyUp_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Skel_BodyUp_Mat_Extra) == null)
				{
					result = (this._Skel_BodyUp_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_34, this));
				}
				return result;
			}
			set
			{
				this.Skel_BodyUp_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x17005998 RID: 22936
		// (get) Token: 0x06027B53 RID: 162643 RVA: 0x00999364 File Offset: 0x00997564
		// (set) Token: 0x06027B54 RID: 162644 RVA: 0x0099939D File Offset: 0x0099759D
		public TArray<UMaterialInstance> Skel_BodyDown_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Skel_BodyDown_Mat_Extra) == null)
				{
					result = (this._Skel_BodyDown_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_35, this));
				}
				return result;
			}
			set
			{
				this.Skel_BodyDown_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x17005999 RID: 22937
		// (get) Token: 0x06027B55 RID: 162645 RVA: 0x009993AB File Offset: 0x009975AB
		// (set) Token: 0x06027B56 RID: 162646 RVA: 0x009993BF File Offset: 0x009975BF
		[Nullable(2)]
		public unsafe USkeletalMesh CharacterMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_36);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x1700599A RID: 22938
		// (get) Token: 0x06027B57 RID: 162647 RVA: 0x009993D4 File Offset: 0x009975D4
		// (set) Token: 0x06027B58 RID: 162648 RVA: 0x0099940D File Offset: 0x0099760D
		public TArray<USkeletalMesh> WeaponCase
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalMesh> result;
				if ((result = this._WeaponCase) == null)
				{
					result = (this._WeaponCase = new TArray<USkeletalMesh>(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_37, this));
				}
				return result;
			}
			set
			{
				this.WeaponCase.CopyAssign(value);
			}
		}

		// Token: 0x1700599B RID: 22939
		// (get) Token: 0x06027B59 RID: 162649 RVA: 0x0099941C File Offset: 0x0099761C
		// (set) Token: 0x06027B5A RID: 162650 RVA: 0x00999455 File Offset: 0x00997655
		public TArray<SRoleOtherCasePart> OtherCase
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SRoleOtherCasePart> result;
				if ((result = this._OtherCase) == null)
				{
					result = (this._OtherCase = new TArray<SRoleOtherCasePart>(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_38, this));
				}
				return result;
			}
			set
			{
				this.OtherCase.CopyAssign(value);
			}
		}

		// Token: 0x1700599C RID: 22940
		// (get) Token: 0x06027B5B RID: 162651 RVA: 0x00999463 File Offset: 0x00997663
		// (set) Token: 0x06027B5C RID: 162652 RVA: 0x00999477 File Offset: 0x00997677
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAnimInstance> 动画实例
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_39);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x1700599D RID: 22941
		// (get) Token: 0x06027B5D RID: 162653 RVA: 0x0099948C File Offset: 0x0099768C
		// (set) Token: 0x06027B5E RID: 162654 RVA: 0x009994A0 File Offset: 0x009976A0
		[Nullable(2)]
		public unsafe UAnimSequence 动画序列
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_40);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_40, value);
			}
		}

		// Token: 0x1700599E RID: 22942
		// (get) Token: 0x06027B5F RID: 162655 RVA: 0x009994B8 File Offset: 0x009976B8
		// (set) Token: 0x06027B60 RID: 162656 RVA: 0x009994F1 File Offset: 0x009976F1
		public TArray<PD_CharacterControllerData_C> 材质控制器特效
		{
			get
			{
				base.FastCheckIsValid();
				TArray<PD_CharacterControllerData_C> result;
				if ((result = this._材质控制器特效) == null)
				{
					result = (this._材质控制器特效 = new TArray<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)PD_RoleSetupData_C.__PropertyOffset_41, this));
				}
				return result;
			}
			set
			{
				this.材质控制器特效.CopyAssign(value);
			}
		}

		// Token: 0x1700599F RID: 22943
		// (get) Token: 0x06027B61 RID: 162657 RVA: 0x009994FF File Offset: 0x009976FF
		// (set) Token: 0x06027B62 RID: 162658 RVA: 0x00999513 File Offset: 0x00997713
		[Nullable(2)]
		public unsafe UKuroCharWetControllerConfigDataAsset 湿身DA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCharWetControllerConfigDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_42);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_RoleSetupData_C.__PropertyOffset_42, value);
			}
		}

		// Token: 0x06027B63 RID: 162659 RVA: 0x00999528 File Offset: 0x00997728
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetAllPartMaterials([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UMaterialInstance> Results)
		{
			PD_RoleSetupData_C.__GetAllPartMaterials_FunctionParams* ptr = stackalloc PD_RoleSetupData_C.__GetAllPartMaterials_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(PD_RoleSetupData_C.__GetAllPartMaterials_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_RoleSetupData_C.__GetAllPartMaterials_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UMaterialInstance> tarray = Results;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Results);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_RoleSetupData_C.__GetAllPartMaterials_NativeFunctionPtr, (void*)ptr);
			TArray<UMaterialInstance> tarray2 = Results;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Results);
			}
			UnrealReflectionUtils.DestroyStruct(PD_RoleSetupData_C.__GetAllPartMaterials_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027B64 RID: 162660 RVA: 0x009995A0 File Offset: 0x009977A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetAllParts([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USkeletalMesh> OutParts)
		{
			PD_RoleSetupData_C.__GetAllParts_FunctionParams* ptr = stackalloc PD_RoleSetupData_C.__GetAllParts_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(PD_RoleSetupData_C.__GetAllParts_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_RoleSetupData_C.__GetAllParts_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USkeletalMesh> tarray = OutParts;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutParts);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_RoleSetupData_C.__GetAllParts_NativeFunctionPtr, (void*)ptr);
			TArray<USkeletalMesh> tarray2 = OutParts;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutParts);
			}
			UnrealReflectionUtils.DestroyStruct(PD_RoleSetupData_C.__GetAllParts_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027B65 RID: 162661 RVA: 0x00999618 File Offset: 0x00997818
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasSkelBody(ref bool Result)
		{
			PD_RoleSetupData_C.__HasSkelBody_FunctionParams* ptr = stackalloc PD_RoleSetupData_C.__HasSkelBody_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_RoleSetupData_C.__HasSkelBody_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_RoleSetupData_C.__HasSkelBody_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_RoleSetupData_C.__HasSkelBody_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06027B66 RID: 162662 RVA: 0x00999668 File Offset: 0x00997868
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasSkelBodyDown(ref bool Result)
		{
			PD_RoleSetupData_C.__HasSkelBodyDown_FunctionParams* ptr = stackalloc PD_RoleSetupData_C.__HasSkelBodyDown_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_RoleSetupData_C.__HasSkelBodyDown_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_RoleSetupData_C.__HasSkelBodyDown_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_RoleSetupData_C.__HasSkelBodyDown_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06027B67 RID: 162663 RVA: 0x009996B8 File Offset: 0x009978B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasSkelBodyUp(ref bool Result)
		{
			PD_RoleSetupData_C.__HasSkelBodyUp_FunctionParams* ptr = stackalloc PD_RoleSetupData_C.__HasSkelBodyUp_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_RoleSetupData_C.__HasSkelBodyUp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_RoleSetupData_C.__HasSkelBodyUp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_RoleSetupData_C.__HasSkelBodyUp_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06027B68 RID: 162664 RVA: 0x00999708 File Offset: 0x00997908
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasSkelFace(ref bool Result)
		{
			PD_RoleSetupData_C.__HasSkelFace_FunctionParams* ptr = stackalloc PD_RoleSetupData_C.__HasSkelFace_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_RoleSetupData_C.__HasSkelFace_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_RoleSetupData_C.__HasSkelFace_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_RoleSetupData_C.__HasSkelFace_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06027B69 RID: 162665 RVA: 0x00999758 File Offset: 0x00997958
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasSkelHair(ref bool Result)
		{
			PD_RoleSetupData_C.__HasSkelHair_FunctionParams* ptr = stackalloc PD_RoleSetupData_C.__HasSkelHair_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_RoleSetupData_C.__HasSkelHair_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_RoleSetupData_C.__HasSkelHair_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_RoleSetupData_C.__HasSkelHair_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06027B6A RID: 162666 RVA: 0x009997A8 File Offset: 0x009979A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasSkelMain(ref bool Result)
		{
			PD_RoleSetupData_C.__HasSkelMain_FunctionParams* ptr = stackalloc PD_RoleSetupData_C.__HasSkelMain_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_RoleSetupData_C.__HasSkelMain_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_RoleSetupData_C.__HasSkelMain_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_RoleSetupData_C.__HasSkelMain_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06027B6B RID: 162667 RVA: 0x009997F8 File Offset: 0x009979F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsEmpty(ref bool Result)
		{
			PD_RoleSetupData_C.__IsEmpty_FunctionParams* ptr = stackalloc PD_RoleSetupData_C.__IsEmpty_FunctionParams[(UIntPtr)28] + 15L / (long)sizeof(PD_RoleSetupData_C.__IsEmpty_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_RoleSetupData_C.__IsEmpty_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_RoleSetupData_C.__IsEmpty_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06027B6C RID: 162668 RVA: 0x00999847 File Offset: 0x00997A47
		protected PD_RoleSetupData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401417B RID: 82299
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/PD_RoleSetupData.PD_RoleSetupData_C";

		// Token: 0x0401417C RID: 82300
		private static IntPtr _ClassPtr;

		// Token: 0x0401417D RID: 82301
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401417E RID: 82302
		internal static int __PropertyOffset_0;

		// Token: 0x0401417F RID: 82303
		internal static int __PropertyOffset_1;

		// Token: 0x04014180 RID: 82304
		internal static int __PropertyOffset_2;

		// Token: 0x04014181 RID: 82305
		internal static int __PropertyOffset_3;

		// Token: 0x04014182 RID: 82306
		internal static int __PropertyOffset_4;

		// Token: 0x04014183 RID: 82307
		internal static int __PropertyOffset_5;

		// Token: 0x04014184 RID: 82308
		internal static int __PropertyOffset_6;

		// Token: 0x04014185 RID: 82309
		internal static int __PropertyOffset_7;

		// Token: 0x04014186 RID: 82310
		internal static int __PropertyOffset_8;

		// Token: 0x04014187 RID: 82311
		internal static int __PropertyOffset_9;

		// Token: 0x04014188 RID: 82312
		internal static int __PropertyOffset_10;

		// Token: 0x04014189 RID: 82313
		internal static int __PropertyOffset_11;

		// Token: 0x0401418A RID: 82314
		internal static int __PropertyOffset_12;

		// Token: 0x0401418B RID: 82315
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SRoleHookPart> _Hook_Arm;

		// Token: 0x0401418C RID: 82316
		internal static int __PropertyOffset_13;

		// Token: 0x0401418D RID: 82317
		internal static int __PropertyOffset_14;

		// Token: 0x0401418E RID: 82318
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SRoleHookPart> _Hook_Waist;

		// Token: 0x0401418F RID: 82319
		internal static int __PropertyOffset_15;

		// Token: 0x04014190 RID: 82320
		internal static int __PropertyOffset_16;

		// Token: 0x04014191 RID: 82321
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SRoleHookPart> _Hook_Back;

		// Token: 0x04014192 RID: 82322
		internal static int __PropertyOffset_17;

		// Token: 0x04014193 RID: 82323
		internal static int __PropertyOffset_18;

		// Token: 0x04014194 RID: 82324
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SRoleHookPart> _Hook_Weapon;

		// Token: 0x04014195 RID: 82325
		internal static int __PropertyOffset_19;

		// Token: 0x04014196 RID: 82326
		internal static int __PropertyOffset_20;

		// Token: 0x04014197 RID: 82327
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SRoleHookPart> _Hook_Leg;

		// Token: 0x04014198 RID: 82328
		internal static int __PropertyOffset_21;

		// Token: 0x04014199 RID: 82329
		internal static int __PropertyOffset_22;

		// Token: 0x0401419A RID: 82330
		internal static int __PropertyOffset_23;

		// Token: 0x0401419B RID: 82331
		internal static int __PropertyOffset_24;

		// Token: 0x0401419C RID: 82332
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SRoleHookPart> _Hook_Head;

		// Token: 0x0401419D RID: 82333
		internal static int __PropertyOffset_25;

		// Token: 0x0401419E RID: 82334
		internal static int __PropertyOffset_26;

		// Token: 0x0401419F RID: 82335
		internal static int __PropertyOffset_27;

		// Token: 0x040141A0 RID: 82336
		internal static int __PropertyOffset_28;

		// Token: 0x040141A1 RID: 82337
		internal static int __PropertyOffset_29;

		// Token: 0x040141A2 RID: 82338
		internal static int __PropertyOffset_30;

		// Token: 0x040141A3 RID: 82339
		internal static int __PropertyOffset_31;

		// Token: 0x040141A4 RID: 82340
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Skel_Body_Mat_Extra;

		// Token: 0x040141A5 RID: 82341
		internal static int __PropertyOffset_32;

		// Token: 0x040141A6 RID: 82342
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Hair_Mat_Extra;

		// Token: 0x040141A7 RID: 82343
		internal static int __PropertyOffset_33;

		// Token: 0x040141A8 RID: 82344
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Face_Mat_Extra;

		// Token: 0x040141A9 RID: 82345
		internal static int __PropertyOffset_34;

		// Token: 0x040141AA RID: 82346
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Skel_BodyUp_Mat_Extra;

		// Token: 0x040141AB RID: 82347
		internal static int __PropertyOffset_35;

		// Token: 0x040141AC RID: 82348
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Skel_BodyDown_Mat_Extra;

		// Token: 0x040141AD RID: 82349
		internal static int __PropertyOffset_36;

		// Token: 0x040141AE RID: 82350
		internal static int __PropertyOffset_37;

		// Token: 0x040141AF RID: 82351
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMesh> _WeaponCase;

		// Token: 0x040141B0 RID: 82352
		internal static int __PropertyOffset_38;

		// Token: 0x040141B1 RID: 82353
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SRoleOtherCasePart> _OtherCase;

		// Token: 0x040141B2 RID: 82354
		internal static int __PropertyOffset_39;

		// Token: 0x040141B3 RID: 82355
		internal static int __PropertyOffset_40;

		// Token: 0x040141B4 RID: 82356
		internal static int __PropertyOffset_41;

		// Token: 0x040141B5 RID: 82357
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<PD_CharacterControllerData_C> _材质控制器特效;

		// Token: 0x040141B6 RID: 82358
		internal static int __PropertyOffset_42;

		// Token: 0x040141B7 RID: 82359
		private static IntPtr __GetAllPartMaterials_NativeFunctionPtr;

		// Token: 0x040141B8 RID: 82360
		private static IntPtr __GetAllParts_NativeFunctionPtr;

		// Token: 0x040141B9 RID: 82361
		private static IntPtr __HasSkelBody_NativeFunctionPtr;

		// Token: 0x040141BA RID: 82362
		private static IntPtr __HasSkelBodyDown_NativeFunctionPtr;

		// Token: 0x040141BB RID: 82363
		private static IntPtr __HasSkelBodyUp_NativeFunctionPtr;

		// Token: 0x040141BC RID: 82364
		private static IntPtr __HasSkelFace_NativeFunctionPtr;

		// Token: 0x040141BD RID: 82365
		private static IntPtr __HasSkelHair_NativeFunctionPtr;

		// Token: 0x040141BE RID: 82366
		private static IntPtr __HasSkelMain_NativeFunctionPtr;

		// Token: 0x040141BF RID: 82367
		private static IntPtr __IsEmpty_NativeFunctionPtr;

		// Token: 0x0200A276 RID: 41590
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetAllPartMaterials_FunctionParams
		{
			// Token: 0x04031F43 RID: 204611
			[FieldOffset(0)]
			public byte Results;
		}

		// Token: 0x0200A277 RID: 41591
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetAllParts_FunctionParams
		{
			// Token: 0x04031F44 RID: 204612
			[FieldOffset(0)]
			public byte OutParts;
		}

		// Token: 0x0200A278 RID: 41592
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelBody_FunctionParams
		{
			// Token: 0x04031F45 RID: 204613
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A279 RID: 41593
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelBodyDown_FunctionParams
		{
			// Token: 0x04031F46 RID: 204614
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A27A RID: 41594
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelBodyUp_FunctionParams
		{
			// Token: 0x04031F47 RID: 204615
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A27B RID: 41595
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelFace_FunctionParams
		{
			// Token: 0x04031F48 RID: 204616
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A27C RID: 41596
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelHair_FunctionParams
		{
			// Token: 0x04031F49 RID: 204617
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A27D RID: 41597
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelMain_FunctionParams
		{
			// Token: 0x04031F4A RID: 204618
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A27E RID: 41598
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 13)]
		protected ref struct __IsEmpty_FunctionParams
		{
			// Token: 0x04031F4B RID: 204619
			[FieldOffset(0)]
			public bool Result;
		}
	}
}
