using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02005012 RID: 20498
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceDefine
	{
		// Token: 0x0401BF0C RID: 114444
		public const float FRAME_PER_MILLISECOND = 0.03f;

		// Token: 0x0401BF0D RID: 114445
		[StaticVariableRuleIgnore]
		public static FName MALE_TAG = new FName("Male");

		// Token: 0x0401BF0E RID: 114446
		[StaticVariableRuleIgnore]
		public static FName FEMALE_TAG = new FName("Female");

		// Token: 0x0401BF0F RID: 114447
		[StaticVariableRuleIgnore]
		public static FName HERO_TAG = new FName("Player");

		// Token: 0x0401BF10 RID: 114448
		[StaticVariableRuleIgnore]
		public static FName BOSS_TAG = new FName("BOSS");

		// Token: 0x0401BF11 RID: 114449
		[StaticVariableRuleIgnore]
		public static FName CAMERA_TAG = new FName("SequenceCamera");

		// Token: 0x0401BF12 RID: 114450
		[StaticVariableRuleIgnore]
		public static FName TALK_NPC_TAG = new FName("TalkNPC");

		// Token: 0x0401BF13 RID: 114451
		[StaticVariableRuleIgnore]
		public static FName FREEATTACH_TAG = new FName("FreeAttach");

		// Token: 0x0401BF14 RID: 114452
		[StaticVariableRuleIgnore]
		public static FName ABP_Base_Name = new FName("ABP_Base");

		// Token: 0x0401BF15 RID: 114453
		[StaticVariableRuleIgnore]
		public static FName ABP_Seq_Slot_Name = new FName("KuroSequenceSlot");

		// Token: 0x0401BF16 RID: 114454
		[StaticVariableRuleIgnore]
		public static FName ABP_Mouth_Slot_Name = new FName("SeqMouth");

		// Token: 0x0401BF17 RID: 114455
		[StaticVariableRuleIgnore]
		public static FName SeqStreamingSourceProxy_TAG = new FName("StreamingSource");

		// Token: 0x0401BF18 RID: 114456
		[StaticVariableRuleIgnore]
		public static FName FINAL_POS_TAG = new FName("FinalPos");

		// Token: 0x0401BF19 RID: 114457
		[StaticVariableRuleIgnore]
		public static FName MOTOR_TAG = new FName("Motor");

		// Token: 0x0401BF1A RID: 114458
		[StaticVariableRuleIgnore]
		public static FName DEFAULT_SEQ_SLOT = new FName("KuroSequenceSlot");

		// Token: 0x0401BF1B RID: 114459
		public const int MALE_SEQ_MODEL_ID = 110004;

		// Token: 0x0401BF1C RID: 114460
		public const int FEMALE_SEQ_MODEL_ID = 110006;

		// Token: 0x0401BF1D RID: 114461
		public const int PLOT_WAIT_ENTITY_TIME = -1;

		// Token: 0x0401BF1E RID: 114462
		public const int DEFAULT_LAST_SUBTITLE_TIME = 1;

		// Token: 0x0401BF1F RID: 114463
		public const int MAX_FRAME = 9999999;

		// Token: 0x0401BF20 RID: 114464
		public static readonly bool SHOW_SEAMLESS_SCREEN_DEBUG_INFO = false;

		// Token: 0x0401BF21 RID: 114465
		public const string MALE_DEFAULT = "/Game/Aki/Character/Role/MaleM/Nanzhu/Seq/BP_Nanzhu_Seq_V2.BP_Nanzhu_Seq_V2_C";

		// Token: 0x0401BF22 RID: 114466
		public const string FEMALE_DEFAULT = "/Game/Aki/Character/Role/FemaleM/Nvzhu/Seq/BP_Nvzhu_Seq_V2.BP_Nvzhu_Seq_V2_C";
	}
}
