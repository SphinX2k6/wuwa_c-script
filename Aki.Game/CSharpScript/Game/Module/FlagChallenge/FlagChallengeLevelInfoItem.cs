using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A66 RID: 23142
	public class FlagChallengeLevelInfoItem : UiPanelBase
	{
		// Token: 0x0603AA61 RID: 240225 RVA: 0x00DF67CD File Offset: 0x00DF49CD
		public FlagChallengeLevelInfoItem(int activityId)
		{
			this.ActivityId = activityId;
		}

		// Token: 0x0603AA62 RID: 240226 RVA: 0x00DF67DC File Offset: 0x00DF49DC
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

		// Token: 0x0603AA63 RID: 240227 RVA: 0x00DF6888 File Offset: 0x00DF4A88
		protected override void OnStart()
		{
			int roleLevelHelpId = FlagChallengeConfig.Instance.GetRoleLevelHelpId();
			base.GetButton(3).RootUIComp.Get().SetUIActive(roleLevelHelpId > 0);
		}

		// Token: 0x0603AA64 RID: 240228 RVA: 0x00DF68C0 File Offset: 0x00DF4AC0
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

		// Token: 0x0603AA65 RID: 240229 RVA: 0x00DF69AC File Offset: 0x00DF4BAC
		private void OnHelpBtnClick()
		{
			int roleLevelHelpId = FlagChallengeConfig.Instance.GetRoleLevelHelpId();
			HelpController.Instance.OpenHelpById(roleLevelHelpId);
		}

		// Token: 0x0401E958 RID: 125272
		private readonly int ActivityId;
	}
}
