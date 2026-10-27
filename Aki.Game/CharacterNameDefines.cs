using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002E4A RID: 11850
[NullableContext(1)]
[Nullable(0)]
public class CharacterNameDefines : Singleton
{
	// Token: 0x1700229E RID: 8862
	// (get) Token: 0x06019490 RID: 103568 RVA: 0x00681C6E File Offset: 0x0067FE6E
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

	// Token: 0x06019491 RID: 103569 RVA: 0x00681C91 File Offset: 0x0067FE91
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06019492 RID: 103570 RVA: 0x00681C93 File Offset: 0x0067FE93
	public static void ResetStaticDefaultValue()
	{
		CharacterNameDefines instance = CharacterNameDefines._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CharacterNameDefines._instance = null;
	}

	// Token: 0x06019493 RID: 103571 RVA: 0x00681CAC File Offset: 0x0067FEAC
	static CharacterNameDefines()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterNameDefines.CreateStaticDefaultValue), new Action(CharacterNameDefines.ResetStaticDefaultValue));
	}

	// Token: 0x0400BBD2 RID: 48082
	public FName NORMAL = new FName("Normal");

	// Token: 0x0400BBD3 RID: 48083
	public FName ABP_BASE = new FName("ABP_Base");

	// Token: 0x0400BBD4 RID: 48084
	public FName ABP_GAMEPLAY = new FName("ABP_Gameplay");

	// Token: 0x0400BBD5 RID: 48085
	public FName ABP_SPECIAL = new FName("ABP_Special");

	// Token: 0x0400BBD6 RID: 48086
	public FName ROOT_ROTATABLE = new FName("RootRotatable");

	// Token: 0x0400BBD7 RID: 48087
	public FName ROOT_X = new FName("RootX");

	// Token: 0x0400BBD8 RID: 48088
	public FName ROOT_Y = new FName("RootY");

	// Token: 0x0400BBD9 RID: 48089
	public FName ROOT_Z = new FName("RootZ");

	// Token: 0x0400BBDA RID: 48090
	public FName ROOT_LOOK = new FName("RootLook");

	// Token: 0x0400BBDB RID: 48091
	public FName SEAT_MORPH = new FName("SeatMorph");

	// Token: 0x0400BBDC RID: 48092
	public FName BIP_001_SPINE = new FName("Bip001Spine");

	// Token: 0x0400BBDD RID: 48093
	public FName BIP_001_HEAD = new FName("Bip001Head");

	// Token: 0x0400BBDE RID: 48094
	public FName BIP_001_NECK = new FName("Bip001Neck");

	// Token: 0x0400BBDF RID: 48095
	public FName NO_SLIDE = new FName("NoSlide");

	// Token: 0x0400BBE0 RID: 48096
	public FName NO_VAULT = new FName("NoVault");

	// Token: 0x0400BBE1 RID: 48097
	public FName INVALID_POS = new FName("InvalidPos");

	// Token: 0x0400BBE2 RID: 48098
	public FName ROOT = new FName("Root");

	// Token: 0x0400BBE3 RID: 48099
	public FName PAWN = new FName("Pawn");

	// Token: 0x0400BBE4 RID: 48100
	public FName VANISH_PAWN = new FName("VanishPawn");

	// Token: 0x0400BBE5 RID: 48101
	public FName ENABLE_MOVE_TRIGGER_TAG = new FName("EnableMoveTrigger");

	// Token: 0x0400BBE6 RID: 48102
	public FName HULU_SOCKET_NAME = new FName("HuluProp01");

	// Token: 0x0400BBE7 RID: 48103
	public FName HULU_GLIDEING_SOCKET_NAME = new FName("Bone_Piao012");

	// Token: 0x0400BBE8 RID: 48104
	public FName HULU_HAND_SOCKET_NAME = new FName("WeaponProp07");

	// Token: 0x0400BBE9 RID: 48105
	public FName HULU_EFFECT_SOCKET_NAME = new FName("WeaponProp02");

	// Token: 0x0400BBEA RID: 48106
	public FName ELEMENT_EFFECT_SOCKET_NAME = new FName("Bip001RHand");

	// Token: 0x0400BBEB RID: 48107
	public FName GLIDEING_SOCKETNAME = new FName("WeaponProp01");

	// Token: 0x0400BBEC RID: 48108
	public FName CHAR_MESH_COMP_NAME = new FName("CharacterMesh0");

	// Token: 0x0400BBED RID: 48109
	public FName POINT_CLOUD_WORLD_COMP_NAME = new FName("KuroPointCloudWorldComponent");

	// Token: 0x0400BBEE RID: 48110
	public FName WEAPON_MESH_COMP_NAME_0 = new FName("WeaponCase0");

	// Token: 0x0400BBEF RID: 48111
	public FName WEAPON_MESH_COMP_NAME_1 = new FName("WeaponCase1");

	// Token: 0x0400BBF0 RID: 48112
	public FName WEAPON_MESH_COMP_NAME_2 = new FName("WeaponCase2");

	// Token: 0x0400BBF1 RID: 48113
	public FName HULU_MESH_COMP_NAME = new FName("HuluCase");

	// Token: 0x0400BBF2 RID: 48114
	public FName PARAGLIDING_MESH_COMP_NAME = new FName("OtherCase0");

	// Token: 0x0400BBF3 RID: 48115
	public FName SOAR_WING_MESH_COMP_NAME = new FName("GenericCase0");

	// Token: 0x0400BBF4 RID: 48116
	public FName KEEP_WEAPON_OUT_NAME = new FName("KeepWeaponOut");

	// Token: 0x0400BBF5 RID: 48117
	public FName PFT_NO_SPAWN = new FName("PFT_NoSpawn");

	// Token: 0x0400BBF6 RID: 48118
	public FName START_SECTION = new FName("Start");

	// Token: 0x0400BBF7 RID: 48119
	public FName END_SECTION = new FName("End");

	// Token: 0x0400BBF8 RID: 48120
	public FName LOOP_SECTION = new FName("Loop");

	// Token: 0x0400BBF9 RID: 48121
	public FName NULL_SECTION = new FName("Null");

	// Token: 0x0400BBFA RID: 48122
	public FName DEFAULT_SLOT = new FName("DefaultSlot");

	// Token: 0x0400BBFB RID: 48123
	public FName SEQUENCE_SLOT = new FName("KuroSequenceSlot");

	// Token: 0x0400BBFC RID: 48124
	public FName FACE_SLOT = new FName("SeqFace");

	// Token: 0x0400BBFD RID: 48125
	public FName DEFAULT_SECTION_NAME = new FName("Default");

	// Token: 0x0400BBFE RID: 48126
	public FName ROLE_TRIGGER_NAME = new FName("RoleTrigger");

	// Token: 0x0400BBFF RID: 48127
	public FName HULU_CASE = new FName("HuluCase");

	// Token: 0x0400BC00 RID: 48128
	public FName HULU_PROP_01 = new FName("HuluProp01");

	// Token: 0x0400BC01 RID: 48129
	public FName HIT_CASE_NAME = new FName("HitCase");

	// Token: 0x0400BC02 RID: 48130
	public FName ANIM_INSTANCE_ROLE = new FName("KuroAnimInstanceRole");

	// Token: 0x0400BC03 RID: 48131
	public FName ABP_BASEROLE = new FName("ABP_BaseRole_C");

	// Token: 0x0400BC04 RID: 48132
	public FName ABP_BASEROLENPC = new FName("ABP_BaseRoleNpc_C");

	// Token: 0x0400BC05 RID: 48133
	public FName ABP_MONSTERCOMMON = new FName("ABP_MonsterCommon_C");

	// Token: 0x0400BC06 RID: 48134
	public FName ABP_BASEANIMAL = new FName("ABP_BaseAnimal_C");

	// Token: 0x0400BC07 RID: 48135
	public FName ABP_BASERUNANIMAL = new FName("ABP_BaseRunAnimal_C");

	// Token: 0x0400BC08 RID: 48136
	public FName ABP_TEAM_ROLE_BASE = new FName("ABP_TeamRole_Base_C");

	// Token: 0x0400BC09 RID: 48137
	public FName BP_COMMONPET = new FName("BP_CommonPet_C");

	// Token: 0x0400BC0A RID: 48138
	public FName BP_BASEANIMAL = new FName("BP_BaseAnimal_C");

	// Token: 0x0400BC0B RID: 48139
	public FName BP_BASEITEM = new FName("BP_BaseItem_C");

	// Token: 0x0400BC0C RID: 48140
	public FName BP_BASEVISION = new FName("BP_BaseVision_C");

	// Token: 0x0400BC0D RID: 48141
	public FName CHANGE_SKELETAL_MATERIALS_COMP_NAME = new FName("KuroChangeSkeletalMaterialsComponent");

	// Token: 0x0400BC0E RID: 48142
	[Nullable(2)]
	private static CharacterNameDefines _instance;
}
