using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200139B RID: 5019
[NullableContext(1)]
[Nullable(0)]
public class NewbieCourseV2Define : IStaticVariableResetter
{
	// Token: 0x06008CC9 RID: 36041 RVA: 0x001E31C4 File Offset: 0x001E13C4
	static NewbieCourseV2Define()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NewbieCourseV2Define.CreateStaticDefaultValue), new Action(NewbieCourseV2Define.ResetStaticDefaultValue));
	}

	// Token: 0x06008CCA RID: 36042 RVA: 0x001E31E4 File Offset: 0x001E13E4
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

	// Token: 0x06008CCB RID: 36043 RVA: 0x001E32D7 File Offset: 0x001E14D7
	public static void ResetStaticDefaultValue()
	{
		NewbieCourseV2Define.LevelPrefixSpriteIds = null;
		NewbieCourseV2Define.BackgroundTextureIds = null;
		NewbieCourseV2Define.BackgroundHoldTextureIds = null;
		NewbieCourseV2Define.LeftDigitMaterialIds = null;
		NewbieCourseV2Define.RightDigitMaterialIds = null;
	}

	// Token: 0x04003E71 RID: 15985
	public const float RewardListContentTopPadding = 16f;

	// Token: 0x04003E72 RID: 15986
	public static Dictionary<ENewbieCourseV2ItemState, string> LevelPrefixSpriteIds;

	// Token: 0x04003E73 RID: 15987
	public static Dictionary<ENewbieCourseV2ItemState, string> BackgroundTextureIds;

	// Token: 0x04003E74 RID: 15988
	public static Dictionary<ENewbieCourseV2ItemState, string> BackgroundHoldTextureIds;

	// Token: 0x04003E75 RID: 15989
	public static Dictionary<ENewbieCourseV2ItemState, string> LeftDigitMaterialIds;

	// Token: 0x04003E76 RID: 15990
	public static Dictionary<ENewbieCourseV2ItemState, string> RightDigitMaterialIds;
}
