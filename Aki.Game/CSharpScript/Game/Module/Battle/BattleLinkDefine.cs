using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C47 RID: 23623
	[NullableContext(1)]
	[Nullable(0)]
	public static class BattleLinkDefine
	{
		// Token: 0x0401F125 RID: 127269
		public const string BATTLE_LINK_BP_PATH = "/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/BP_SplitScreen.BP_SplitScreen_C";

		// Token: 0x0401F126 RID: 127270
		public const string BATTLE_LINK_BP_NEW_PATH = "/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/BP_SplitScreen_New.BP_SplitScreen_New_C";

		// Token: 0x0401F127 RID: 127271
		public const string THREE_ROLE_SEQ_PATH = "/Game/Aki/Character/SequenceCamera/Connet_Skill_Seq/SC3_Connect_Skill.SC3_Connect_Skill";

		// Token: 0x0401F128 RID: 127272
		public const string THREE_ROLE_SEQ_NEW_PATH = "/Game/Aki/Character/SequenceCamera/Connet_Skill_Seq/NewLink/SC3_Connect_Skill_New.SC3_Connect_Skill_New";

		// Token: 0x0401F129 RID: 127273
		public const string TWO_ROLE_SEQ_PATH = "/Game/Aki/Character/SequenceCamera/Connet_Skill_Seq/SC2_Connect_Skill.SC2_Connect_Skill";

		// Token: 0x0401F12A RID: 127274
		public const string TWO_ROLE_SEQ_NEW_PATH = "/Game/Aki/Character/SequenceCamera/Connet_Skill_Seq/NewLink/SC2_Connect_Skill_New.SC2_Connect_Skill_New";

		// Token: 0x0401F12B RID: 127275
		public const string EXPLOSION_EFFECT_PATH = "/Game/Aki/Effect/DataAsset/PostProcess/BigWorld/DA_Fx_Post_Link.DA_Fx_Post_Link";

		// Token: 0x0401F12C RID: 127276
		public const string SKILL_BUTTON_EFFECT_PATH = "/Game/Aki/Effect/UI/Niagaras/Common/NS_Fx_LGUI_Fight_Link.NS_Fx_LGUI_Fight_Link";

		// Token: 0x0401F12D RID: 127277
		public const float LINK_POST_EFFECT_DURATION = 0.3f;

		// Token: 0x0401F12E RID: 127278
		public const float LINK_TRIGGER_INTERVAL = 200f;

		// Token: 0x0401F12F RID: 127279
		public const int LINK_BURST_POST_EFFECT = 10010093;

		// Token: 0x0401F130 RID: 127280
		public const string ZHEZHI_WEAPON_MESH = "/Game/Aki/Character/Weapon/Prop/Role/ZhezhiProp/EZhezhiMaobixiaoMd10011/Model/EZhezhiMaobixiaoMd10011.EZhezhiMaobixiaoMd10011";

		// Token: 0x0401F131 RID: 127281
		public const string ZHEZHI_WEAPON_ANIM = "/Game/Aki/Character/Weapon/Prop/Role/ZhezhiProp/EZhezhiMaobixiaoMd10011/BaseAnim/Maobi_CosPose.Maobi_CosPose";
	}
}
