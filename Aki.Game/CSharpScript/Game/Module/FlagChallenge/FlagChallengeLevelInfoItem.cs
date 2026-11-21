using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A42 RID: 19010
	public class FlagChallengeLevelInfoItem : UiPanelBase
	{
		// Token: 0x0602F9AA RID: 194986 RVA: 0x00D46D51 File Offset: 0x00D44F51
		public FlagChallengeLevelInfoItem(int activityId)
		{
			this.ActivityId = activityId;
		}

		// Token: 0x0602F9AB RID: 194987 RVA: 0x00D46D60 File Offset: 0x00D44F60
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIArtText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnHelpBtnClick))
			};
		}

		// Token: 0x0602F9AC RID: 194988 RVA: 0x00D46E0C File Offset: 0x00D4500C
		protected override void OnStart()
		{
			int roleLevelHelpId = FlagChallengeConfig.Instance.GetRoleLevelHelpId();
			base.GetButton(3).RootUIComp.Get().SetUIActive(roleLevelHelpId > 0);
		}

		// Token: 0x0602F9AD RID: 194989 RVA: 0x00D46E44 File Offset: 0x00D45044
		public void RefreshView()
		{
			FlagChallengeModel instance = FlagChallengeModel.Instance;
			int totalLevel = instance.GetTotalLevel(this.ActivityId);
			int totalLevelExp = instance.GetTotalLevelExp(this.ActivityId);
			base.GetArtText(0).SetText(totalLevel.ToString());
			int targetLevelExp = instance.GetTargetLevelExp(this.ActivityId, new int?(totalLevel), new int?(totalLevelExp));
			int targetLevelUpExp = instance.GetTargetLevelUpExp(this.ActivityId, new int?(totalLevel));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(targetLevelExp);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(targetLevelUpExp);
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(newText, true);
			}
			float targetLevelExpProgress = instance.GetTargetLevelExpProgress(this.ActivityId, new int?(totalLevel), new int?(totalLevelExp));
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetFillAmount(targetLevelExpProgress);
			}
			base.GetText(4).ShowTextNew("Morale_32_Main_Lv");
		}

		// Token: 0x0602F9AE RID: 194990 RVA: 0x00D46F30 File Offset: 0x00D45130
		private void OnHelpBtnClick()
		{
			int roleLevelHelpId = FlagChallengeConfig.Instance.GetRoleLevelHelpId();
			HelpController.Instance.OpenHelpById(roleLevelHelpId);
		}

		// Token: 0x040193FF RID: 103423
		private readonly int ActivityId;
	}
}
