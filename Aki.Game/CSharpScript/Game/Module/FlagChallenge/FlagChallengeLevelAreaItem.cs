using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A64 RID: 23140
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeLevelAreaItem : UiPanelBase
	{
		// Token: 0x0603AA5A RID: 240218 RVA: 0x00DF6414 File Offset: 0x00DF4614
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIArtText)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUISprite)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton))
			};
		}

		// Token: 0x0603AA5B RID: 240219 RVA: 0x00DF652C File Offset: 0x00DF472C
		public void SetResIndex(int resIndex)
		{
			this.ResIndex = resIndex;
		}

		// Token: 0x0603AA5C RID: 240220 RVA: 0x00DF6535 File Offset: 0x00DF4735
		public void Refresh(FlagChallengeAreaData data, int index)
		{
			this.Data = data;
			this.Index = new int?(index);
			this.RefreshView();
		}

		// Token: 0x0603AA5D RID: 240221 RVA: 0x00DF6550 File Offset: 0x00DF4750
		public void RefreshView()
		{
			if (this.Data == null || this.Index == null)
			{
				return;
			}
			FlagChallengeAreaData data = this.Data;
			FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(data.ActivityId);
			EFlagChallengeUiStyleType uiStyle = flagChallengeData.GetLevelData(data.GetLevelId()).GetUiStyle();
			Dictionary<string, string> dictionary;
			if (!FlagChallengeDefine.Instance.flagChallengeStyleRes.TryGetValue(uiStyle, out dictionary))
			{
				return;
			}
			string dynamicRes = FlagChallengeUtils.GetDynamicRes(uiStyle, "AreaItemMap", this.ResIndex);
			UiResourceConfig instance = UiResourceConfig.Instance;
			string resourcePath = instance.GetResourcePath(dynamicRes);
			base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
			base.SetTextureByPath(resourcePath, base.GetTexture(9), null, null);
			base.SetTextureByPath(instance.GetResourcePath(dictionary["AreaItemBg"]), base.GetTexture(2), null, null);
			base.SetTextureByPath(data.Config.IconPath, base.GetTexture(5), null, null);
			this.SetSpriteByPath(instance.GetResourcePath(dictionary["AreaItemLevelBg"]), base.GetSprite(3), false, null, null);
			UiResourceConfig uiResourceConfig = instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendLiteral("SP_MoraleRome");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.Config.UiPos);
			this.SetSpriteByPath(uiResourceConfig.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear()), base.GetSprite(6), false, null, null);
			int[] recommendLevel = data.GetRecommendLevel();
			base.GetArtText(4).SetText(recommendLevel[1].ToString());
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(flagChallengeData.IsAreaAllBossStrongholdPass(this.Data.Id));
			}
			int num = 0;
			int[] strongholds = data.GetStrongholds();
			foreach (int strongholdId in strongholds)
			{
				FlagChallengeStrongholdData strongholdData = flagChallengeData.GetStrongholdData(strongholdId);
				if (strongholdData != null && strongholdData.IsPass)
				{
					num++;
				}
			}
			UUIText text = base.GetText(7);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(strongholds.Length);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0603AA5E RID: 240222 RVA: 0x00DF679F File Offset: 0x00DF499F
		public void SetButtonClickCallback(Action<int> cb)
		{
			this.ButtonClickCallback = cb;
		}

		// Token: 0x0603AA5F RID: 240223 RVA: 0x00DF67A8 File Offset: 0x00DF49A8
		private void OnClickButton()
		{
			Action<int> buttonClickCallback = this.ButtonClickCallback;
			if (buttonClickCallback == null)
			{
				return;
			}
			buttonClickCallback(this.Data.Id);
		}

		// Token: 0x0401E94E RID: 125262
		[Nullable(2)]
		private FlagChallengeAreaData Data;

		// Token: 0x0401E94F RID: 125263
		private int? Index;

		// Token: 0x0401E950 RID: 125264
		private int ResIndex;

		// Token: 0x0401E951 RID: 125265
		[Nullable(2)]
		private Action<int> ButtonClickCallback;
	}
}
