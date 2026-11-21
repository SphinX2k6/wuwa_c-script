using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200084F RID: 2127
[NullableContext(1)]
[Nullable(0)]
public class NewbieCourseV2Define : IStaticVariableResetter
{
	// Token: 0x06006062 RID: 24674 RVA: 0x001EBF74 File Offset: 0x001EA174
	static NewbieCourseV2Define()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NewbieCourseV2Define.CreateStaticDefaultValue), new Action(NewbieCourseV2Define.ResetStaticDefaultValue));
	}

	// Token: 0x06006063 RID: 24675 RVA: 0x001EBF94 File Offset: 0x001EA194
	public static void CreateStaticDefaultValue()
	{
		NewbieCourseV2Define.LevelPrefixSpriteIds = new Dictionary<ENewbieCourseV2ItemState, string>
		{
			{
				ENewbieCourseV2ItemState.Unaccomplished,
				"SP_SynesthesiaLvBlue"
			},
			{
				ENewbieCourseV2ItemState.CanReceive,
				"SP_SynesthesiaLvGold"
			},
			{
				ENewbieCourseV2ItemState.HasReceived,
				"SP_SynesthesiaLvPurple"
			}
		};
		NewbieCourseV2Define.BackgroundTextureIds = new Dictionary<ENewbieCourseV2ItemState, string>
		{
			{
				ENewbieCourseV2ItemState.Unaccomplished,
				"T_TogSynesthesiaANor"
			},
			{
				ENewbieCourseV2ItemState.CanReceive,
				"T_TogSynesthesiaCNor"
			},
			{
				ENewbieCourseV2ItemState.HasReceived,
				"T_TogSynesthesiaBNor"
			}
		};
		NewbieCourseV2Define.BackgroundHoldTextureIds = new Dictionary<ENewbieCourseV2ItemState, string>
		{
			{
				ENewbieCourseV2ItemState.Unaccomplished,
				"T_TogSynesthesiaAHold"
			},
			{
				ENewbieCourseV2ItemState.CanReceive,
				"T_TogSynesthesiaCHold"
			},
			{
				ENewbieCourseV2ItemState.HasReceived,
				"T_TogSynesthesiaBHold"
			}
		};
		NewbieCourseV2Define.LeftDigitMaterialIds = new Dictionary<ENewbieCourseV2ItemState, string>
		{
			{
				ENewbieCourseV2ItemState.Unaccomplished,
				"MI_TextureClipAlphaLockL"
			},
			{
				ENewbieCourseV2ItemState.CanReceive,
				"MI_TextureClipAlphaRewardL"
			},
			{
				ENewbieCourseV2ItemState.HasReceived,
				"MI_TextureClipAlphaDoneL"
			}
		};
		NewbieCourseV2Define.RightDigitMaterialIds = new Dictionary<ENewbieCourseV2ItemState, string>
		{
			{
				ENewbieCourseV2ItemState.Unaccomplished,
				"MI_TextureClipAlphaLockR"
			},
			{
				ENewbieCourseV2ItemState.CanReceive,
				"MI_TextureClipAlphaRewardR"
			},
			{
				ENewbieCourseV2ItemState.HasReceived,
				"MI_TextureClipAlphaDoneR"
			}
		};
	}

	// Token: 0x06006064 RID: 24676 RVA: 0x001EC087 File Offset: 0x001EA287
	public static void ResetStaticDefaultValue()
	{
		NewbieCourseV2Define.LevelPrefixSpriteIds = null;
		NewbieCourseV2Define.BackgroundTextureIds = null;
		NewbieCourseV2Define.BackgroundHoldTextureIds = null;
		NewbieCourseV2Define.LeftDigitMaterialIds = null;
		NewbieCourseV2Define.RightDigitMaterialIds = null;
	}

	// Token: 0x04003F09 RID: 16137
	public const float RewardListContentTopPadding = 16f;

	// Token: 0x04003F0A RID: 16138
	public static Dictionary<ENewbieCourseV2ItemState, string> LevelPrefixSpriteIds;

	// Token: 0x04003F0B RID: 16139
	public static Dictionary<ENewbieCourseV2ItemState, string> BackgroundTextureIds;

	// Token: 0x04003F0C RID: 16140
	public static Dictionary<ENewbieCourseV2ItemState, string> BackgroundHoldTextureIds;

	// Token: 0x04003F0D RID: 16141
	public static Dictionary<ENewbieCourseV2ItemState, string> LeftDigitMaterialIds;

	// Token: 0x04003F0E RID: 16142
	public static Dictionary<ENewbieCourseV2ItemState, string> RightDigitMaterialIds;
}
