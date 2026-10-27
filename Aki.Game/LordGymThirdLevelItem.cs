using System;
using Aki.Config;
using UnrealEngine;

// Token: 0x020021B8 RID: 8632
public class LordGymThirdLevelItem : LordGymDifficultyItem
{
	// Token: 0x06010CCE RID: 68814 RVA: 0x00414B50 File Offset: 0x00412D50
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos[1] = new ValueTuple<int, Type>(1, typeof(UUISprite));
	}

	// Token: 0x06010CCF RID: 68815 RVA: 0x00414B74 File Offset: 0x00412D74
	protected override void SetLevelText(LordGym config)
	{
		string text = config.Difficulty.ToString();
		this.SetSpriteByPath(StringUtils.Format("/Game/Aki/UI/UIResources/Common/Atlas/SP_ComRomeText_0{0}.SP_ComRomeText_0{1}", new string[]
		{
			text,
			text
		}), base.GetSprite(1), true, null, null);
	}

	// Token: 0x02008702 RID: 34562
	private class EComponent
	{
		// Token: 0x0402BEA1 RID: 179873
		public const int NumSprite = 1;
	}
}
