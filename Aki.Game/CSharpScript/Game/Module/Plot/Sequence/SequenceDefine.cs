using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02003FDC RID: 16348
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceDefine
	{
		// Token: 0x040168F5 RID: 92405
		public const float FRAME_PER_MILLISECOND = 0.03f;

		// Token: 0x040168F6 RID: 92406
		[StaticVariableRuleIgnore]
		public static FName MALE_TAG = new FName("Male");

		// Token: 0x040168F7 RID: 92407
		[StaticVariableRuleIgnore]
		public static FName FEMALE_TAG = new FName("Female");

		// Token: 0x040168F8 RID: 92408
		[StaticVariableRuleIgnore]
		public static FName HERO_TAG = new FName("Player");

		// Token: 0x040168F9 RID: 92409
		[StaticVariableRuleIgnore]
		public static FName BOSS_TAG = new FName("BOSS");

		// Token: 0x040168FA RID: 92410
		[StaticVariableRuleIgnore]
		public static FName CAMERA_TAG = new FName("SequenceCamera");

		// Token: 0x040168FB RID: 92411
		[StaticVariableRuleIgnore]
		public static FName TALK_NPC_TAG = new FName("TalkNPC");

		// Token: 0x040168FC RID: 92412
		[StaticVariableRuleIgnore]
		public static FName FREEATTACH_TAG = new FName("FreeAttach");

		// Token: 0x040168FD RID: 92413
		[StaticVariableRuleIgnore]
		public static FName ABP_Base_Name = new FName("ABP_Base");

		// Token: 0x040168FE RID: 92414
		[StaticVariableRuleIgnore]
		public static FName ABP_Seq_Slot_Name = new FName("KuroSequenceSlot");

		// Token: 0x040168FF RID: 92415
		[StaticVariableRuleIgnore]
		public static FName ABP_Mouth_Slot_Name = new FName("SeqMouth");

		// Token: 0x04016900 RID: 92416
		[StaticVariableRuleIgnore]
		public static FName SeqStreamingSourceProxy_TAG = new FName("StreamingSource");

		// Token: 0x04016901 RID: 92417
		[StaticVariableRuleIgnore]
		public static FName FINAL_POS_TAG = new FName("FinalPos");

		// Token: 0x04016902 RID: 92418
		[StaticVariableRuleIgnore]
		public static FName MOTOR_TAG = new FName("Motor");

		// Token: 0x04016903 RID: 92419
		[StaticVariableRuleIgnore]
		public static FName DEFAULT_SEQ_SLOT = new FName("KuroSequenceSlot");

		// Token: 0x04016904 RID: 92420
		public const int MALE_SEQ_MODEL_ID = 110004;

		// Token: 0x04016905 RID: 92421
		public const int FEMALE_SEQ_MODEL_ID = 110006;

		// Token: 0x04016906 RID: 92422
		public const int PLOT_WAIT_ENTITY_TIME = -1;

		// Token: 0x04016907 RID: 92423
		public const int DEFAULT_LAST_SUBTITLE_TIME = 1;

		// Token: 0x04016908 RID: 92424
		public const int MAX_FRAME = 9999999;

		// Token: 0x04016909 RID: 92425
		public static readonly bool SHOW_SEAMLESS_SCREEN_DEBUG_INFO = false;

		// Token: 0x0401690A RID: 92426
		public const string MALE_DEFAULT = "/Game/Aki/Character/Role/MaleM/Nanzhu/Seq/BP_Nanzhu_Seq_V2.BP_Nanzhu_Seq_V2_C";

		// Token: 0x0401690B RID: 92427
		public const string FEMALE_DEFAULT = "/Game/Aki/Character/Role/FemaleM/Nvzhu/Seq/BP_Nvzhu_Seq_V2.BP_Nvzhu_Seq_V2_C";
	}
}
