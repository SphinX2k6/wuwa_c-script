using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003E01 RID: 15873
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/PD_NpcSetupData.PD_NpcSetupData_C")]
	[UnrealStructLayout(792, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 792)]
	public class PD_NpcSetupData_C : UKuroNpcDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027A85 RID: 162437 RVA: 0x00997ACA File Offset: 0x00995CCA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_NpcSetupData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Npc/PD_NpcSetupData.PD_NpcSetupData_C");
			}
			return PD_NpcSetupData_C._ClassPtr;
		}

		// Token: 0x06027A86 RID: 162438 RVA: 0x00997AF0 File Offset: 0x00995CF0
		public PD_NpcSetupData_C() : this(BuiltinUtils.AllocNativeUObject(PD_NpcSetupData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027A87 RID: 162439 RVA: 0x00997B18 File Offset: 0x00995D18
		public PD_NpcSetupData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_NpcSetupData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700593D RID: 22845
		// (get) Token: 0x06027A88 RID: 162440 RVA: 0x00997B4B File Offset: 0x00995D4B
		// (set) Token: 0x06027A89 RID: 162441 RVA: 0x00997B5F File Offset: 0x00995D5F
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_Hair
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700593E RID: 22846
		// (get) Token: 0x06027A8A RID: 162442 RVA: 0x00997B74 File Offset: 0x00995D74
		// (set) Token: 0x06027A8B RID: 162443 RVA: 0x00997B88 File Offset: 0x00995D88
		public unsafe FColor Skel_Hair_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700593F RID: 22847
		// (get) Token: 0x06027A8C RID: 162444 RVA: 0x00997B9D File Offset: 0x00995D9D
		// (set) Token: 0x06027A8D RID: 162445 RVA: 0x00997BB1 File Offset: 0x00995DB1
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_Face
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005940 RID: 22848
		// (get) Token: 0x06027A8E RID: 162446 RVA: 0x00997BC6 File Offset: 0x00995DC6
		// (set) Token: 0x06027A8F RID: 162447 RVA: 0x00997BDA File Offset: 0x00995DDA
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_BodyUp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_4);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005941 RID: 22849
		// (get) Token: 0x06027A90 RID: 162448 RVA: 0x00997BEF File Offset: 0x00995DEF
		// (set) Token: 0x06027A91 RID: 162449 RVA: 0x00997C03 File Offset: 0x00995E03
		public unsafe FColor Skel_BodyUp_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005942 RID: 22850
		// (get) Token: 0x06027A92 RID: 162450 RVA: 0x00997C18 File Offset: 0x00995E18
		// (set) Token: 0x06027A93 RID: 162451 RVA: 0x00997C2C File Offset: 0x00995E2C
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_BodyDown
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_6);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005943 RID: 22851
		// (get) Token: 0x06027A94 RID: 162452 RVA: 0x00997C41 File Offset: 0x00995E41
		// (set) Token: 0x06027A95 RID: 162453 RVA: 0x00997C55 File Offset: 0x00995E55
		public unsafe FColor Skel_BodyDown_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005944 RID: 22852
		// (get) Token: 0x06027A96 RID: 162454 RVA: 0x00997C6A File Offset: 0x00995E6A
		// (set) Token: 0x06027A97 RID: 162455 RVA: 0x00997C7E File Offset: 0x00995E7E
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_Body
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_8);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005945 RID: 22853
		// (get) Token: 0x06027A98 RID: 162456 RVA: 0x00997C93 File Offset: 0x00995E93
		// (set) Token: 0x06027A99 RID: 162457 RVA: 0x00997CA3 File Offset: 0x00995EA3
		public unsafe bool bDyeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005946 RID: 22854
		// (get) Token: 0x06027A9A RID: 162458 RVA: 0x00997CB4 File Offset: 0x00995EB4
		// (set) Token: 0x06027A9B RID: 162459 RVA: 0x00997CC8 File Offset: 0x00995EC8
		public unsafe FLinearColor SkinDyeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005947 RID: 22855
		// (get) Token: 0x06027A9C RID: 162460 RVA: 0x00997CDD File Offset: 0x00995EDD
		// (set) Token: 0x06027A9D RID: 162461 RVA: 0x00997CF1 File Offset: 0x00995EF1
		[Nullable(0)]
		public unsafe TEnumAsByte<ENpcSetupType> NpcSetupType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_11);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005948 RID: 22856
		// (get) Token: 0x06027A9E RID: 162462 RVA: 0x00997D06 File Offset: 0x00995F06
		// (set) Token: 0x06027A9F RID: 162463 RVA: 0x00997D1A File Offset: 0x00995F1A
		[Nullable(2)]
		public unsafe USkeletalMesh Skel_Main
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_12);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17005949 RID: 22857
		// (get) Token: 0x06027AA0 RID: 162464 RVA: 0x00997D30 File Offset: 0x00995F30
		// (set) Token: 0x06027AA1 RID: 162465 RVA: 0x00997D69 File Offset: 0x00995F69
		public TArray<SNpcHookPart> Hook_Arm
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Arm) == null)
				{
					result = (this._Hook_Arm = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				this.Hook_Arm.CopyAssign(value);
			}
		}

		// Token: 0x1700594A RID: 22858
		// (get) Token: 0x06027AA2 RID: 162466 RVA: 0x00997D77 File Offset: 0x00995F77
		// (set) Token: 0x06027AA3 RID: 162467 RVA: 0x00997D8B File Offset: 0x00995F8B
		public unsafe FName Hook_Arm_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700594B RID: 22859
		// (get) Token: 0x06027AA4 RID: 162468 RVA: 0x00997DA0 File Offset: 0x00995FA0
		// (set) Token: 0x06027AA5 RID: 162469 RVA: 0x00997DD9 File Offset: 0x00995FD9
		public TArray<SNpcHookPart> Hook_Waist
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Waist) == null)
				{
					result = (this._Hook_Waist = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				this.Hook_Waist.CopyAssign(value);
			}
		}

		// Token: 0x1700594C RID: 22860
		// (get) Token: 0x06027AA6 RID: 162470 RVA: 0x00997DE7 File Offset: 0x00995FE7
		// (set) Token: 0x06027AA7 RID: 162471 RVA: 0x00997DFB File Offset: 0x00995FFB
		public unsafe FName Hook_Waist_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700594D RID: 22861
		// (get) Token: 0x06027AA8 RID: 162472 RVA: 0x00997E10 File Offset: 0x00996010
		// (set) Token: 0x06027AA9 RID: 162473 RVA: 0x00997E49 File Offset: 0x00996049
		public TArray<SNpcHookPart> Hook_Back
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Back) == null)
				{
					result = (this._Hook_Back = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				this.Hook_Back.CopyAssign(value);
			}
		}

		// Token: 0x1700594E RID: 22862
		// (get) Token: 0x06027AAA RID: 162474 RVA: 0x00997E57 File Offset: 0x00996057
		// (set) Token: 0x06027AAB RID: 162475 RVA: 0x00997E6B File Offset: 0x0099606B
		public unsafe FName Hook_Back_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700594F RID: 22863
		// (get) Token: 0x06027AAC RID: 162476 RVA: 0x00997E80 File Offset: 0x00996080
		// (set) Token: 0x06027AAD RID: 162477 RVA: 0x00997EB9 File Offset: 0x009960B9
		public TArray<SNpcHookPart> Hook_Weapon
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Weapon) == null)
				{
					result = (this._Hook_Weapon = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				this.Hook_Weapon.CopyAssign(value);
			}
		}

		// Token: 0x17005950 RID: 22864
		// (get) Token: 0x06027AAE RID: 162478 RVA: 0x00997EC7 File Offset: 0x009960C7
		// (set) Token: 0x06027AAF RID: 162479 RVA: 0x00997EDB File Offset: 0x009960DB
		public unsafe FName Hook_Weapon_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005951 RID: 22865
		// (get) Token: 0x06027AB0 RID: 162480 RVA: 0x00997EF0 File Offset: 0x009960F0
		// (set) Token: 0x06027AB1 RID: 162481 RVA: 0x00997F29 File Offset: 0x00996129
		public TArray<SNpcHookPart> Hook_Leg
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Leg) == null)
				{
					result = (this._Hook_Leg = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_21, this));
				}
				return result;
			}
			set
			{
				this.Hook_Leg.CopyAssign(value);
			}
		}

		// Token: 0x17005952 RID: 22866
		// (get) Token: 0x06027AB2 RID: 162482 RVA: 0x00997F37 File Offset: 0x00996137
		// (set) Token: 0x06027AB3 RID: 162483 RVA: 0x00997F4B File Offset: 0x0099614B
		public unsafe FName Hook_Leg_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005953 RID: 22867
		// (get) Token: 0x06027AB4 RID: 162484 RVA: 0x00997F60 File Offset: 0x00996160
		// (set) Token: 0x06027AB5 RID: 162485 RVA: 0x00997F74 File Offset: 0x00996174
		public unsafe FColor Body_Dyecolor01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005954 RID: 22868
		// (get) Token: 0x06027AB6 RID: 162486 RVA: 0x00997F89 File Offset: 0x00996189
		// (set) Token: 0x06027AB7 RID: 162487 RVA: 0x00997F9D File Offset: 0x0099619D
		public unsafe FColor Body_Dyecolor02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005955 RID: 22869
		// (get) Token: 0x06027AB8 RID: 162488 RVA: 0x00997FB4 File Offset: 0x009961B4
		// (set) Token: 0x06027AB9 RID: 162489 RVA: 0x00997FED File Offset: 0x009961ED
		public TArray<SNpcHookPart> Hook_Head
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Head) == null)
				{
					result = (this._Hook_Head = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_25, this));
				}
				return result;
			}
			set
			{
				this.Hook_Head.CopyAssign(value);
			}
		}

		// Token: 0x17005956 RID: 22870
		// (get) Token: 0x06027ABA RID: 162490 RVA: 0x00997FFB File Offset: 0x009961FB
		// (set) Token: 0x06027ABB RID: 162491 RVA: 0x0099800F File Offset: 0x0099620F
		public unsafe FName Hook_Head_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17005957 RID: 22871
		// (get) Token: 0x06027ABC RID: 162492 RVA: 0x00998024 File Offset: 0x00996224
		// (set) Token: 0x06027ABD RID: 162493 RVA: 0x00998038 File Offset: 0x00996238
		[Nullable(2)]
		public unsafe UMaterialInstance Hair_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_27);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17005958 RID: 22872
		// (get) Token: 0x06027ABE RID: 162494 RVA: 0x0099804D File Offset: 0x0099624D
		// (set) Token: 0x06027ABF RID: 162495 RVA: 0x00998061 File Offset: 0x00996261
		[Nullable(2)]
		public unsafe UMaterialInstance Skel_BodyUp_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_28);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17005959 RID: 22873
		// (get) Token: 0x06027AC0 RID: 162496 RVA: 0x00998076 File Offset: 0x00996276
		// (set) Token: 0x06027AC1 RID: 162497 RVA: 0x0099808A File Offset: 0x0099628A
		[Nullable(2)]
		public unsafe UMaterialInstance Skel_BodyDown_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_29);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x1700595A RID: 22874
		// (get) Token: 0x06027AC2 RID: 162498 RVA: 0x0099809F File Offset: 0x0099629F
		// (set) Token: 0x06027AC3 RID: 162499 RVA: 0x009980B3 File Offset: 0x009962B3
		[Nullable(2)]
		public unsafe UMaterialInstance Skel_Body_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_30);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x1700595B RID: 22875
		// (get) Token: 0x06027AC4 RID: 162500 RVA: 0x009980C8 File Offset: 0x009962C8
		// (set) Token: 0x06027AC5 RID: 162501 RVA: 0x00998101 File Offset: 0x00996301
		public TArray<UMaterialInstance> Skel_Body_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Skel_Body_Mat_Extra) == null)
				{
					result = (this._Skel_Body_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_31, this));
				}
				return result;
			}
			set
			{
				this.Skel_Body_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x1700595C RID: 22876
		// (get) Token: 0x06027AC6 RID: 162502 RVA: 0x00998110 File Offset: 0x00996310
		// (set) Token: 0x06027AC7 RID: 162503 RVA: 0x00998149 File Offset: 0x00996349
		public TArray<UMaterialInstance> Hair_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Hair_Mat_Extra) == null)
				{
					result = (this._Hair_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_32, this));
				}
				return result;
			}
			set
			{
				this.Hair_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x1700595D RID: 22877
		// (get) Token: 0x06027AC8 RID: 162504 RVA: 0x00998157 File Offset: 0x00996357
		// (set) Token: 0x06027AC9 RID: 162505 RVA: 0x0099816B File Offset: 0x0099636B
		[Nullable(2)]
		public unsafe UMaterialInstance Face_Mat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_33);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_NpcSetupData_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x1700595E RID: 22878
		// (get) Token: 0x06027ACA RID: 162506 RVA: 0x00998180 File Offset: 0x00996380
		// (set) Token: 0x06027ACB RID: 162507 RVA: 0x009981B9 File Offset: 0x009963B9
		public TArray<UMaterialInstance> Face_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Face_Mat_Extra) == null)
				{
					result = (this._Face_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_34, this));
				}
				return result;
			}
			set
			{
				this.Face_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x1700595F RID: 22879
		// (get) Token: 0x06027ACC RID: 162508 RVA: 0x009981C8 File Offset: 0x009963C8
		// (set) Token: 0x06027ACD RID: 162509 RVA: 0x00998201 File Offset: 0x00996401
		public TArray<UMaterialInstance> Skel_BodyUp_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Skel_BodyUp_Mat_Extra) == null)
				{
					result = (this._Skel_BodyUp_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_35, this));
				}
				return result;
			}
			set
			{
				this.Skel_BodyUp_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x17005960 RID: 22880
		// (get) Token: 0x06027ACE RID: 162510 RVA: 0x00998210 File Offset: 0x00996410
		// (set) Token: 0x06027ACF RID: 162511 RVA: 0x00998249 File Offset: 0x00996449
		public TArray<UMaterialInstance> Skel_BodyDown_Mat_Extra
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Skel_BodyDown_Mat_Extra) == null)
				{
					result = (this._Skel_BodyDown_Mat_Extra = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_36, this));
				}
				return result;
			}
			set
			{
				this.Skel_BodyDown_Mat_Extra.CopyAssign(value);
			}
		}

		// Token: 0x17005961 RID: 22881
		// (get) Token: 0x06027AD0 RID: 162512 RVA: 0x00998258 File Offset: 0x00996458
		// (set) Token: 0x06027AD1 RID: 162513 RVA: 0x00998291 File Offset: 0x00996491
		public TArray<UMaterialInterface> ReferencedOulineMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._ReferencedOulineMaterials) == null)
				{
					result = (this._ReferencedOulineMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_37, this));
				}
				return result;
			}
			set
			{
				this.ReferencedOulineMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17005962 RID: 22882
		// (get) Token: 0x06027AD2 RID: 162514 RVA: 0x009982A0 File Offset: 0x009964A0
		// (set) Token: 0x06027AD3 RID: 162515 RVA: 0x009982D9 File Offset: 0x009964D9
		public TArray<SNpcChildPart> ChildParts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcChildPart> result;
				if ((result = this._ChildParts) == null)
				{
					result = (this._ChildParts = new TArray<SNpcChildPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_38, this));
				}
				return result;
			}
			set
			{
				this.ChildParts.CopyAssign(value);
			}
		}

		// Token: 0x17005963 RID: 22883
		// (get) Token: 0x06027AD4 RID: 162516 RVA: 0x009982E8 File Offset: 0x009964E8
		// (set) Token: 0x06027AD5 RID: 162517 RVA: 0x00998321 File Offset: 0x00996521
		public TArray<FName> HideParentBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._HideParentBoneNames) == null)
				{
					result = (this._HideParentBoneNames = new TArray<FName>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_39, this));
				}
				return result;
			}
			set
			{
				this.HideParentBoneNames.CopyAssign(value);
			}
		}

		// Token: 0x17005964 RID: 22884
		// (get) Token: 0x06027AD6 RID: 162518 RVA: 0x00998330 File Offset: 0x00996530
		// (set) Token: 0x06027AD7 RID: 162519 RVA: 0x00998369 File Offset: 0x00996569
		public TArray<SNpcHookPart> Hook_Arm_L
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Arm_L) == null)
				{
					result = (this._Hook_Arm_L = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_40, this));
				}
				return result;
			}
			set
			{
				this.Hook_Arm_L.CopyAssign(value);
			}
		}

		// Token: 0x17005965 RID: 22885
		// (get) Token: 0x06027AD8 RID: 162520 RVA: 0x00998377 File Offset: 0x00996577
		// (set) Token: 0x06027AD9 RID: 162521 RVA: 0x0099838B File Offset: 0x0099658B
		public unsafe FName Hook_Arm_L_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17005966 RID: 22886
		// (get) Token: 0x06027ADA RID: 162522 RVA: 0x009983A0 File Offset: 0x009965A0
		// (set) Token: 0x06027ADB RID: 162523 RVA: 0x009983D9 File Offset: 0x009965D9
		public TArray<SNpcHookPart> Hook_Fore
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Fore) == null)
				{
					result = (this._Hook_Fore = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_42, this));
				}
				return result;
			}
			set
			{
				this.Hook_Fore.CopyAssign(value);
			}
		}

		// Token: 0x17005967 RID: 22887
		// (get) Token: 0x06027ADC RID: 162524 RVA: 0x009983E7 File Offset: 0x009965E7
		// (set) Token: 0x06027ADD RID: 162525 RVA: 0x009983FB File Offset: 0x009965FB
		public unsafe FName Hook_Fore_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17005968 RID: 22888
		// (get) Token: 0x06027ADE RID: 162526 RVA: 0x00998410 File Offset: 0x00996610
		// (set) Token: 0x06027ADF RID: 162527 RVA: 0x00998449 File Offset: 0x00996649
		public TArray<SNpcHookPart> Hook_Fore_L
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Fore_L) == null)
				{
					result = (this._Hook_Fore_L = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_44, this));
				}
				return result;
			}
			set
			{
				this.Hook_Fore_L.CopyAssign(value);
			}
		}

		// Token: 0x17005969 RID: 22889
		// (get) Token: 0x06027AE0 RID: 162528 RVA: 0x00998457 File Offset: 0x00996657
		// (set) Token: 0x06027AE1 RID: 162529 RVA: 0x0099846B File Offset: 0x0099666B
		public unsafe FName Hook_Fore_L_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x1700596A RID: 22890
		// (get) Token: 0x06027AE2 RID: 162530 RVA: 0x00998480 File Offset: 0x00996680
		// (set) Token: 0x06027AE3 RID: 162531 RVA: 0x009984B9 File Offset: 0x009966B9
		public TArray<SNpcHookPart> Hook_Leg_L
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Leg_L) == null)
				{
					result = (this._Hook_Leg_L = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_46, this));
				}
				return result;
			}
			set
			{
				this.Hook_Leg_L.CopyAssign(value);
			}
		}

		// Token: 0x1700596B RID: 22891
		// (get) Token: 0x06027AE4 RID: 162532 RVA: 0x009984C7 File Offset: 0x009966C7
		// (set) Token: 0x06027AE5 RID: 162533 RVA: 0x009984DB File Offset: 0x009966DB
		public unsafe FName Hook_Leg_L_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x1700596C RID: 22892
		// (get) Token: 0x06027AE6 RID: 162534 RVA: 0x009984F0 File Offset: 0x009966F0
		// (set) Token: 0x06027AE7 RID: 162535 RVA: 0x00998529 File Offset: 0x00996729
		public TArray<SNpcHookPart> Hook_Calf
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Calf) == null)
				{
					result = (this._Hook_Calf = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_48, this));
				}
				return result;
			}
			set
			{
				this.Hook_Calf.CopyAssign(value);
			}
		}

		// Token: 0x1700596D RID: 22893
		// (get) Token: 0x06027AE8 RID: 162536 RVA: 0x00998537 File Offset: 0x00996737
		// (set) Token: 0x06027AE9 RID: 162537 RVA: 0x0099854B File Offset: 0x0099674B
		public unsafe FName Hook_Calf_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x1700596E RID: 22894
		// (get) Token: 0x06027AEA RID: 162538 RVA: 0x00998560 File Offset: 0x00996760
		// (set) Token: 0x06027AEB RID: 162539 RVA: 0x00998599 File Offset: 0x00996799
		public TArray<SNpcHookPart> Hook_Calf_L
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SNpcHookPart> result;
				if ((result = this._Hook_Calf_L) == null)
				{
					result = (this._Hook_Calf_L = new TArray<SNpcHookPart>(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_50, this));
				}
				return result;
			}
			set
			{
				this.Hook_Calf_L.CopyAssign(value);
			}
		}

		// Token: 0x1700596F RID: 22895
		// (get) Token: 0x06027AEC RID: 162540 RVA: 0x009985A7 File Offset: 0x009967A7
		// (set) Token: 0x06027AED RID: 162541 RVA: 0x009985BB File Offset: 0x009967BB
		public unsafe FName Hook_Calf_L_Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17005970 RID: 22896
		// (get) Token: 0x06027AEE RID: 162542 RVA: 0x009985D0 File Offset: 0x009967D0
		// (set) Token: 0x06027AEF RID: 162543 RVA: 0x009985E4 File Offset: 0x009967E4
		public unsafe FColor Skel_Face_Skin_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17005971 RID: 22897
		// (get) Token: 0x06027AF0 RID: 162544 RVA: 0x009985F9 File Offset: 0x009967F9
		// (set) Token: 0x06027AF1 RID: 162545 RVA: 0x0099860D File Offset: 0x0099680D
		public unsafe FColor Skel_Face_SkinSubsurface_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17005972 RID: 22898
		// (get) Token: 0x06027AF2 RID: 162546 RVA: 0x00998622 File Offset: 0x00996822
		// (set) Token: 0x06027AF3 RID: 162547 RVA: 0x00998632 File Offset: 0x00996832
		public unsafe bool bOverrideSkin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005973 RID: 22899
		// (get) Token: 0x06027AF4 RID: 162548 RVA: 0x00998643 File Offset: 0x00996843
		// (set) Token: 0x06027AF5 RID: 162549 RVA: 0x00998657 File Offset: 0x00996857
		public unsafe FLinearColor SkinColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_55);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_55) = value;
			}
		}

		// Token: 0x17005974 RID: 22900
		// (get) Token: 0x06027AF6 RID: 162550 RVA: 0x0099866C File Offset: 0x0099686C
		// (set) Token: 0x06027AF7 RID: 162551 RVA: 0x00998680 File Offset: 0x00996880
		public unsafe FLinearColor SkinSubsurfaceColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_56);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_NpcSetupData_C.__PropertyOffset_56) = value;
			}
		}

		// Token: 0x06027AF8 RID: 162552 RVA: 0x00998698 File Offset: 0x00996898
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsSeq(ref bool bSeq)
		{
			PD_NpcSetupData_C.__IsSeq_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__IsSeq_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(PD_NpcSetupData_C.__IsSeq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__IsSeq_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bSeq = bSeq;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__IsSeq_NativeFunctionPtr, (void*)ptr);
			bSeq = ptr->bSeq;
		}

		// Token: 0x06027AF9 RID: 162553 RVA: 0x009986E7 File Offset: 0x009968E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetOLReference()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__SetOLReference_NativeFunctionPtr, null);
		}

		// Token: 0x06027AFA RID: 162554 RVA: 0x009986FC File Offset: 0x009968FC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027AFB RID: 162555 RVA: 0x009987D6 File Offset: 0x009969D6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixNPCOutline()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__FixNPCOutline_NativeFunctionPtr, null);
		}

		// Token: 0x06027AFC RID: 162556 RVA: 0x009987EC File Offset: 0x009969EC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027AFD RID: 162557 RVA: 0x009988B1 File Offset: 0x00996AB1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Override()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__Set_Override_NativeFunctionPtr, null);
		}

		// Token: 0x06027AFE RID: 162558 RVA: 0x009988C8 File Offset: 0x00996AC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027AFF RID: 162559 RVA: 0x00998940 File Offset: 0x00996B40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027B00 RID: 162560 RVA: 0x009989B8 File Offset: 0x00996BB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasSkelBody(ref bool Result)
		{
			PD_NpcSetupData_C.__HasSkelBody_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__HasSkelBody_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_NpcSetupData_C.__HasSkelBody_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__HasSkelBody_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__HasSkelBody_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06027B01 RID: 162561 RVA: 0x00998A08 File Offset: 0x00996C08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasSkelBodyDown(ref bool Result)
		{
			PD_NpcSetupData_C.__HasSkelBodyDown_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__HasSkelBodyDown_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_NpcSetupData_C.__HasSkelBodyDown_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__HasSkelBodyDown_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__HasSkelBodyDown_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06027B02 RID: 162562 RVA: 0x00998A58 File Offset: 0x00996C58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasSkelBodyUp(ref bool Result)
		{
			PD_NpcSetupData_C.__HasSkelBodyUp_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__HasSkelBodyUp_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_NpcSetupData_C.__HasSkelBodyUp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__HasSkelBodyUp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__HasSkelBodyUp_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06027B03 RID: 162563 RVA: 0x00998AA8 File Offset: 0x00996CA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasSkelFace(ref bool Result)
		{
			PD_NpcSetupData_C.__HasSkelFace_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__HasSkelFace_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_NpcSetupData_C.__HasSkelFace_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__HasSkelFace_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__HasSkelFace_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06027B04 RID: 162564 RVA: 0x00998AF8 File Offset: 0x00996CF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasSkelHair(ref bool Result)
		{
			PD_NpcSetupData_C.__HasSkelHair_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__HasSkelHair_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_NpcSetupData_C.__HasSkelHair_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__HasSkelHair_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__HasSkelHair_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06027B05 RID: 162565 RVA: 0x00998B48 File Offset: 0x00996D48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasSkelMain(ref bool Result)
		{
			PD_NpcSetupData_C.__HasSkelMain_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__HasSkelMain_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(PD_NpcSetupData_C.__HasSkelMain_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__HasSkelMain_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__HasSkelMain_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06027B06 RID: 162566 RVA: 0x00998B98 File Offset: 0x00996D98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsEmpty(ref bool Result)
		{
			PD_NpcSetupData_C.__IsEmpty_FunctionParams* ptr = stackalloc PD_NpcSetupData_C.__IsEmpty_FunctionParams[(UIntPtr)28] + 15L / (long)sizeof(PD_NpcSetupData_C.__IsEmpty_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_NpcSetupData_C.__IsEmpty_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__IsEmpty_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06027B07 RID: 162567 RVA: 0x00998BE7 File Offset: 0x00996DE7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnPreSave()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_NpcSetupData_C.__OnPreSave_NativeFunctionPtr, null);
		}

		// Token: 0x06027B08 RID: 162568 RVA: 0x00998BFB File Offset: 0x00996DFB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void OnPreSave_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, PD_NpcSetupData_C.__OnPreSave_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027B09 RID: 162569 RVA: 0x00998C10 File Offset: 0x00996E10
		protected PD_NpcSetupData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401411C RID: 82204
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/PD_NpcSetupData.PD_NpcSetupData_C";

		// Token: 0x0401411D RID: 82205
		private static IntPtr _ClassPtr;

		// Token: 0x0401411E RID: 82206
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401411F RID: 82207
		internal static int __PropertyOffset_1;

		// Token: 0x04014120 RID: 82208
		internal static int __PropertyOffset_2;

		// Token: 0x04014121 RID: 82209
		internal static int __PropertyOffset_3;

		// Token: 0x04014122 RID: 82210
		internal static int __PropertyOffset_4;

		// Token: 0x04014123 RID: 82211
		internal static int __PropertyOffset_5;

		// Token: 0x04014124 RID: 82212
		internal static int __PropertyOffset_6;

		// Token: 0x04014125 RID: 82213
		internal static int __PropertyOffset_7;

		// Token: 0x04014126 RID: 82214
		internal static int __PropertyOffset_8;

		// Token: 0x04014127 RID: 82215
		internal static int __PropertyOffset_9;

		// Token: 0x04014128 RID: 82216
		internal static int __PropertyOffset_10;

		// Token: 0x04014129 RID: 82217
		internal static int __PropertyOffset_11;

		// Token: 0x0401412A RID: 82218
		internal static int __PropertyOffset_12;

		// Token: 0x0401412B RID: 82219
		internal static int __PropertyOffset_13;

		// Token: 0x0401412C RID: 82220
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Arm;

		// Token: 0x0401412D RID: 82221
		internal static int __PropertyOffset_14;

		// Token: 0x0401412E RID: 82222
		internal static int __PropertyOffset_15;

		// Token: 0x0401412F RID: 82223
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Waist;

		// Token: 0x04014130 RID: 82224
		internal static int __PropertyOffset_16;

		// Token: 0x04014131 RID: 82225
		internal static int __PropertyOffset_17;

		// Token: 0x04014132 RID: 82226
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Back;

		// Token: 0x04014133 RID: 82227
		internal static int __PropertyOffset_18;

		// Token: 0x04014134 RID: 82228
		internal static int __PropertyOffset_19;

		// Token: 0x04014135 RID: 82229
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Weapon;

		// Token: 0x04014136 RID: 82230
		internal static int __PropertyOffset_20;

		// Token: 0x04014137 RID: 82231
		internal static int __PropertyOffset_21;

		// Token: 0x04014138 RID: 82232
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Leg;

		// Token: 0x04014139 RID: 82233
		internal static int __PropertyOffset_22;

		// Token: 0x0401413A RID: 82234
		internal static int __PropertyOffset_23;

		// Token: 0x0401413B RID: 82235
		internal static int __PropertyOffset_24;

		// Token: 0x0401413C RID: 82236
		internal static int __PropertyOffset_25;

		// Token: 0x0401413D RID: 82237
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Head;

		// Token: 0x0401413E RID: 82238
		internal static int __PropertyOffset_26;

		// Token: 0x0401413F RID: 82239
		internal static int __PropertyOffset_27;

		// Token: 0x04014140 RID: 82240
		internal static int __PropertyOffset_28;

		// Token: 0x04014141 RID: 82241
		internal static int __PropertyOffset_29;

		// Token: 0x04014142 RID: 82242
		internal static int __PropertyOffset_30;

		// Token: 0x04014143 RID: 82243
		internal static int __PropertyOffset_31;

		// Token: 0x04014144 RID: 82244
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Skel_Body_Mat_Extra;

		// Token: 0x04014145 RID: 82245
		internal static int __PropertyOffset_32;

		// Token: 0x04014146 RID: 82246
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Hair_Mat_Extra;

		// Token: 0x04014147 RID: 82247
		internal static int __PropertyOffset_33;

		// Token: 0x04014148 RID: 82248
		internal static int __PropertyOffset_34;

		// Token: 0x04014149 RID: 82249
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Face_Mat_Extra;

		// Token: 0x0401414A RID: 82250
		internal static int __PropertyOffset_35;

		// Token: 0x0401414B RID: 82251
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Skel_BodyUp_Mat_Extra;

		// Token: 0x0401414C RID: 82252
		internal static int __PropertyOffset_36;

		// Token: 0x0401414D RID: 82253
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Skel_BodyDown_Mat_Extra;

		// Token: 0x0401414E RID: 82254
		internal static int __PropertyOffset_37;

		// Token: 0x0401414F RID: 82255
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _ReferencedOulineMaterials;

		// Token: 0x04014150 RID: 82256
		internal static int __PropertyOffset_38;

		// Token: 0x04014151 RID: 82257
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcChildPart> _ChildParts;

		// Token: 0x04014152 RID: 82258
		internal static int __PropertyOffset_39;

		// Token: 0x04014153 RID: 82259
		[Nullable(2)]
		private TArray<FName> _HideParentBoneNames;

		// Token: 0x04014154 RID: 82260
		internal static int __PropertyOffset_40;

		// Token: 0x04014155 RID: 82261
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Arm_L;

		// Token: 0x04014156 RID: 82262
		internal static int __PropertyOffset_41;

		// Token: 0x04014157 RID: 82263
		internal static int __PropertyOffset_42;

		// Token: 0x04014158 RID: 82264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Fore;

		// Token: 0x04014159 RID: 82265
		internal static int __PropertyOffset_43;

		// Token: 0x0401415A RID: 82266
		internal static int __PropertyOffset_44;

		// Token: 0x0401415B RID: 82267
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Fore_L;

		// Token: 0x0401415C RID: 82268
		internal static int __PropertyOffset_45;

		// Token: 0x0401415D RID: 82269
		internal static int __PropertyOffset_46;

		// Token: 0x0401415E RID: 82270
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Leg_L;

		// Token: 0x0401415F RID: 82271
		internal static int __PropertyOffset_47;

		// Token: 0x04014160 RID: 82272
		internal static int __PropertyOffset_48;

		// Token: 0x04014161 RID: 82273
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Calf;

		// Token: 0x04014162 RID: 82274
		internal static int __PropertyOffset_49;

		// Token: 0x04014163 RID: 82275
		internal static int __PropertyOffset_50;

		// Token: 0x04014164 RID: 82276
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SNpcHookPart> _Hook_Calf_L;

		// Token: 0x04014165 RID: 82277
		internal static int __PropertyOffset_51;

		// Token: 0x04014166 RID: 82278
		internal static int __PropertyOffset_52;

		// Token: 0x04014167 RID: 82279
		internal static int __PropertyOffset_53;

		// Token: 0x04014168 RID: 82280
		internal static int __PropertyOffset_54;

		// Token: 0x04014169 RID: 82281
		internal static int __PropertyOffset_55;

		// Token: 0x0401416A RID: 82282
		internal static int __PropertyOffset_56;

		// Token: 0x0401416B RID: 82283
		private static IntPtr __IsSeq_NativeFunctionPtr;

		// Token: 0x0401416C RID: 82284
		private static IntPtr __SetOLReference_NativeFunctionPtr;

		// Token: 0x0401416D RID: 82285
		private static IntPtr __GetOutlineReference_NativeFunctionPtr;

		// Token: 0x0401416E RID: 82286
		private static IntPtr __FixNPCOutline_NativeFunctionPtr;

		// Token: 0x0401416F RID: 82287
		private static IntPtr __Set_Single_Override_NativeFunctionPtr;

		// Token: 0x04014170 RID: 82288
		private static IntPtr __Set_Override_NativeFunctionPtr;

		// Token: 0x04014171 RID: 82289
		private static IntPtr __GetAllPartMaterials_NativeFunctionPtr;

		// Token: 0x04014172 RID: 82290
		private static IntPtr __GetAllParts_NativeFunctionPtr;

		// Token: 0x04014173 RID: 82291
		private static IntPtr __HasSkelBody_NativeFunctionPtr;

		// Token: 0x04014174 RID: 82292
		private static IntPtr __HasSkelBodyDown_NativeFunctionPtr;

		// Token: 0x04014175 RID: 82293
		private static IntPtr __HasSkelBodyUp_NativeFunctionPtr;

		// Token: 0x04014176 RID: 82294
		private static IntPtr __HasSkelFace_NativeFunctionPtr;

		// Token: 0x04014177 RID: 82295
		private static IntPtr __HasSkelHair_NativeFunctionPtr;

		// Token: 0x04014178 RID: 82296
		private static IntPtr __HasSkelMain_NativeFunctionPtr;

		// Token: 0x04014179 RID: 82297
		private static IntPtr __IsEmpty_NativeFunctionPtr;

		// Token: 0x0401417A RID: 82298
		private static IntPtr __OnPreSave_NativeFunctionPtr;

		// Token: 0x0200A26A RID: 41578
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __IsSeq_FunctionParams
		{
			// Token: 0x04031F31 RID: 204593
			[FieldOffset(0)]
			public bool bSeq;
		}

		// Token: 0x0200A26B RID: 41579
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 560)]
		protected ref struct __GetOutlineReference_FunctionParams
		{
			// Token: 0x04031F32 RID: 204594
			[FieldOffset(0)]
			public bool bSeq;

			// Token: 0x04031F33 RID: 204595
			[FieldOffset(8)]
			public IntPtr Skel;

			// Token: 0x04031F34 RID: 204596
			[FieldOffset(16)]
			public IntPtr mat;

			// Token: 0x04031F35 RID: 204597
			[FieldOffset(24)]
			public byte mat_extra;

			// Token: 0x04031F36 RID: 204598
			[FieldOffset(40)]
			public byte OutOLMat;
		}

		// Token: 0x0200A26C RID: 41580
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 704)]
		protected ref struct __Set_Single_Override_FunctionParams
		{
			// Token: 0x04031F37 RID: 204599
			[FieldOffset(0)]
			public IntPtr skel_mesh;

			// Token: 0x04031F38 RID: 204600
			[FieldOffset(8)]
			public IntPtr mat;

			// Token: 0x04031F39 RID: 204601
			[FieldOffset(16)]
			public byte mat_extra;
		}

		// Token: 0x0200A26D RID: 41581
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetAllPartMaterials_FunctionParams
		{
			// Token: 0x04031F3A RID: 204602
			[FieldOffset(0)]
			public byte Results;
		}

		// Token: 0x0200A26E RID: 41582
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetAllParts_FunctionParams
		{
			// Token: 0x04031F3B RID: 204603
			[FieldOffset(0)]
			public byte OutParts;
		}

		// Token: 0x0200A26F RID: 41583
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelBody_FunctionParams
		{
			// Token: 0x04031F3C RID: 204604
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A270 RID: 41584
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelBodyDown_FunctionParams
		{
			// Token: 0x04031F3D RID: 204605
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A271 RID: 41585
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelBodyUp_FunctionParams
		{
			// Token: 0x04031F3E RID: 204606
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A272 RID: 41586
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelFace_FunctionParams
		{
			// Token: 0x04031F3F RID: 204607
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A273 RID: 41587
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelHair_FunctionParams
		{
			// Token: 0x04031F40 RID: 204608
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A274 RID: 41588
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSkelMain_FunctionParams
		{
			// Token: 0x04031F41 RID: 204609
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A275 RID: 41589
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 13)]
		protected ref struct __IsEmpty_FunctionParams
		{
			// Token: 0x04031F42 RID: 204610
			[FieldOffset(0)]
			public bool Result;
		}
	}
}
