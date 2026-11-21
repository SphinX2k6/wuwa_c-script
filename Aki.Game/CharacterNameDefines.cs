using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020023A6 RID: 9126
[NullableContext(1)]
[Nullable(0)]
public class CharacterNameDefines : Singleton
{
	// Token: 0x17002312 RID: 8978
	// (get) Token: 0x06016D6E RID: 93550 RVA: 0x006A7FFA File Offset: 0x006A61FA
	public static CharacterNameDefines Instance
	{
		get
		{
			if (CharacterNameDefines._instance == null)
			{
				CharacterNameDefines._instance = new CharacterNameDefines();
				CharacterNameDefines._instance.OnInit();
			}
			return CharacterNameDefines._instance;
		}
	}

	// Token: 0x06016D6F RID: 93551 RVA: 0x006A801D File Offset: 0x006A621D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016D70 RID: 93552 RVA: 0x006A801F File Offset: 0x006A621F
	public static void ResetStaticDefaultValue()
	{
		CharacterNameDefines instance = CharacterNameDefines._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CharacterNameDefines._instance = null;
	}

	// Token: 0x06016D71 RID: 93553 RVA: 0x006A8038 File Offset: 0x006A6238
	static CharacterNameDefines()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterNameDefines.CreateStaticDefaultValue), new Action(CharacterNameDefines.ResetStaticDefaultValue));
	}

	// Token: 0x0400BF65 RID: 48997
	public FName NORMAL = new FName("Normal");

	// Token: 0x0400BF66 RID: 48998
	public FName ABP_BASE = new FName("ABP_Base");

	// Token: 0x0400BF67 RID: 48999
	public FName ABP_GAMEPLAY = new FName("ABP_Gameplay");

	// Token: 0x0400BF68 RID: 49000
	public FName ABP_SPECIAL = new FName("ABP_Special");

	// Token: 0x0400BF69 RID: 49001
	public FName ROOT_ROTATABLE = new FName("RootRotatable");

	// Token: 0x0400BF6A RID: 49002
	public FName ROOT_X = new FName("RootX");

	// Token: 0x0400BF6B RID: 49003
	public FName ROOT_Y = new FName("RootY");

	// Token: 0x0400BF6C RID: 49004
	public FName ROOT_Z = new FName("RootZ");

	// Token: 0x0400BF6D RID: 49005
	public FName ROOT_LOOK = new FName("RootLook");

	// Token: 0x0400BF6E RID: 49006
	public FName SEAT_MORPH = new FName("SeatMorph");

	// Token: 0x0400BF6F RID: 49007
	public FName BIP_001_SPINE = new FName("Bip001Spine");

	// Token: 0x0400BF70 RID: 49008
	public FName BIP_001_HEAD = new FName("Bip001Head");

	// Token: 0x0400BF71 RID: 49009
	public FName BIP_001_NECK = new FName("Bip001Neck");

	// Token: 0x0400BF72 RID: 49010
	public FName NO_SLIDE = new FName("NoSlide");

	// Token: 0x0400BF73 RID: 49011
	public FName NO_VAULT = new FName("NoVault");

	// Token: 0x0400BF74 RID: 49012
	public FName INVALID_POS = new FName("InvalidPos");

	// Token: 0x0400BF75 RID: 49013
	public FName ROOT = new FName("Root");

	// Token: 0x0400BF76 RID: 49014
	public FName PAWN = new FName("Pawn");

	// Token: 0x0400BF77 RID: 49015
	public FName VANISH_PAWN = new FName("VanishPawn");

	// Token: 0x0400BF78 RID: 49016
	public FName ENABLE_MOVE_TRIGGER_TAG = new FName("EnableMoveTrigger");

	// Token: 0x0400BF79 RID: 49017
	public FName HULU_SOCKET_NAME = new FName("HuluProp01");

	// Token: 0x0400BF7A RID: 49018
	public FName HULU_GLIDEING_SOCKET_NAME = new FName("Bone_Piao012");

	// Token: 0x0400BF7B RID: 49019
	public FName HULU_HAND_SOCKET_NAME = new FName("WeaponProp07");

	// Token: 0x0400BF7C RID: 49020
	public FName HULU_EFFECT_SOCKET_NAME = new FName("WeaponProp02");

	// Token: 0x0400BF7D RID: 49021
	public FName ELEMENT_EFFECT_SOCKET_NAME = new FName("Bip001RHand");

	// Token: 0x0400BF7E RID: 49022
	public FName GLIDEING_SOCKETNAME = new FName("WeaponProp01");

	// Token: 0x0400BF7F RID: 49023
	public FName CHAR_MESH_COMP_NAME = new FName("CharacterMesh0");

	// Token: 0x0400BF80 RID: 49024
	public FName POINT_CLOUD_WORLD_COMP_NAME = new FName("KuroPointCloudWorldComponent");

	// Token: 0x0400BF81 RID: 49025
	public FName WEAPON_MESH_COMP_NAME_0 = new FName("WeaponCase0");

	// Token: 0x0400BF82 RID: 49026
	public FName WEAPON_MESH_COMP_NAME_1 = new FName("WeaponCase1");

	// Token: 0x0400BF83 RID: 49027
	public FName WEAPON_MESH_COMP_NAME_2 = new FName("WeaponCase2");

	// Token: 0x0400BF84 RID: 49028
	public FName HULU_MESH_COMP_NAME = new FName("HuluCase");

	// Token: 0x0400BF85 RID: 49029
	public FName PARAGLIDING_MESH_COMP_NAME = new FName("OtherCase0");

	// Token: 0x0400BF86 RID: 49030
	public FName SOAR_WING_MESH_COMP_NAME = new FName("GenericCase0");

	// Token: 0x0400BF87 RID: 49031
	public FName KEEP_WEAPON_OUT_NAME = new FName("KeepWeaponOut");

	// Token: 0x0400BF88 RID: 49032
	public FName PFT_NO_SPAWN = new FName("PFT_NoSpawn");

	// Token: 0x0400BF89 RID: 49033
	public FName START_SECTION = new FName("Start");

	// Token: 0x0400BF8A RID: 49034
	public FName END_SECTION = new FName("End");

	// Token: 0x0400BF8B RID: 49035
	public FName LOOP_SECTION = new FName("Loop");

	// Token: 0x0400BF8C RID: 49036
	public FName NULL_SECTION = new FName("Null");

	// Token: 0x0400BF8D RID: 49037
	public FName DEFAULT_SLOT = new FName("DefaultSlot");

	// Token: 0x0400BF8E RID: 49038
	public FName SEQUENCE_SLOT = new FName("KuroSequenceSlot");

	// Token: 0x0400BF8F RID: 49039
	public FName FACE_SLOT = new FName("SeqFace");

	// Token: 0x0400BF90 RID: 49040
	public FName DEFAULT_SECTION_NAME = new FName("Default");

	// Token: 0x0400BF91 RID: 49041
	public FName ROLE_TRIGGER_NAME = new FName("RoleTrigger");

	// Token: 0x0400BF92 RID: 49042
	public FName HULU_CASE = new FName("HuluCase");

	// Token: 0x0400BF93 RID: 49043
	public FName HULU_PROP_01 = new FName("HuluProp01");

	// Token: 0x0400BF94 RID: 49044
	public FName HIT_CASE_NAME = new FName("HitCase");

	// Token: 0x0400BF95 RID: 49045
	public FName ANIM_INSTANCE_ROLE = new FName("KuroAnimInstanceRole");

	// Token: 0x0400BF96 RID: 49046
	public FName ABP_BASEROLE = new FName("ABP_BaseRole_C");

	// Token: 0x0400BF97 RID: 49047
	public FName ABP_BASEROLENPC = new FName("ABP_BaseRoleNpc_C");

	// Token: 0x0400BF98 RID: 49048
	public FName ABP_MONSTERCOMMON = new FName("ABP_MonsterCommon_C");

	// Token: 0x0400BF99 RID: 49049
	public FName ABP_BASEANIMAL = new FName("ABP_BaseAnimal_C");

	// Token: 0x0400BF9A RID: 49050
	public FName ABP_BASERUNANIMAL = new FName("ABP_BaseRunAnimal_C");

	// Token: 0x0400BF9B RID: 49051
	public FName ABP_TEAM_ROLE_BASE = new FName("ABP_TeamRole_Base_C");

	// Token: 0x0400BF9C RID: 49052
	public FName BP_COMMONPET = new FName("BP_CommonPet_C");

	// Token: 0x0400BF9D RID: 49053
	public FName BP_BASEANIMAL = new FName("BP_BaseAnimal_C");

	// Token: 0x0400BF9E RID: 49054
	public FName BP_BASEITEM = new FName("BP_BaseItem_C");

	// Token: 0x0400BF9F RID: 49055
	public FName BP_BASEVISION = new FName("BP_BaseVision_C");

	// Token: 0x0400BFA0 RID: 49056
	public FName CHANGE_SKELETAL_MATERIALS_COMP_NAME = new FName("KuroChangeSkeletalMaterialsComponent");

	// Token: 0x0400BFA1 RID: 49057
	[Nullable(2)]
	private static CharacterNameDefines _instance;
}
