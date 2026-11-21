using System;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200169C RID: 5788
public class LordGymThirdLevelItem : LordGymDifficultyItem
{
	// Token: 0x0600E15F RID: 57695 RVA: 0x00421430 File Offset: 0x0041F630
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos[1] = new ValueTuple<int, Type>(1, typeof(UUISprite));
	}

	// Token: 0x0600E160 RID: 57696 RVA: 0x00421454 File Offset: 0x0041F654
	protected override void SetLevelText(LordGym config)
	{
		string text = config.Difficulty.ToString();
		this.SetSpriteByPath(StringUtils.Format("/Game/Aki/UI/UIResources/Common/Atlas/SP_ComRomeText_0{0}.SP_ComRomeText_0{1}", new string[]
		{
			text,
			text
		}), base.GetSprite(1), true, null, null);
	}

	// Token: 0x0200788D RID: 30861
	private class EComponent
	{
		// Token: 0x040271C2 RID: 160194
		public const int NumSprite = 1;
	}
}
