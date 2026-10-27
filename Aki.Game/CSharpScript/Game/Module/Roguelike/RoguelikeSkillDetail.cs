using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E2A RID: 20010
	public class RoguelikeSkillDetail : UiPanelBase
	{
		// Token: 0x06033998 RID: 211352 RVA: 0x00C12758 File Offset: 0x00C10958
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickBtnUpgrade));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033999 RID: 211353 RVA: 0x00C12A19 File Offset: 0x00C10C19
		protected override void OnStart()
		{
		}

		// Token: 0x0603399A RID: 211354 RVA: 0x00C12A1C File Offset: 0x00C10C1C
		private void OnClickBtnUpgrade()
		{
			int skillPoint = RoguelikeModel.Instance.GetParamConfigBySeasonId(null).Value.SkillPoint;
			int? num = new int?(InventoryModel.Instance.GetItemCountByConfigId(skillPoint, 0));
			int num2 = RoguelikeModel.Instance.RoguelikeSkillDataMap[this.Data.Value.Id];
			if (((this.Data != null && num2 >= 0 && num2 < this.Data.Value.ConsuleLength) ? this.Data.Value.Consule(num2) : 0) > num.Value)
			{
				ScrollingTipsController.Instance.ShowTipsById("Roguelike_Skill_Point_Not_Enough", Array.Empty<object>());
				return;
			}
			RogueTalentTree? data = this.Data;
			RoguelikeController.Instance.RoguelikeTalentLevelUpRequest(this.Data.Value.Id).ContinueWith(delegate()
			{
				this.Refresh(this.Data.Value);
				ILevelUpSuccessEffectData data;
				RogueTalentTreeDesc? rogueTalentTreeDescConfig = RoguelikeConfig.Instance.GetRogueTalentTreeDescConfig(data.Value.Describe);
				data = new LevelUpSuccessEffectData
				{
					Title = "Text_ResonanceUnlockSuccess_Text",
					TextList = new List<SingleText>
					{
						new SingleText
						{
							TextId = rogueTalentTreeDescConfig.Value.BaseDesc,
							Params = rogueTalentTreeDescConfig.Value.Params()
						}
					}
				};
				RoleLevelUpSuccessController.Instance.OpenSuccessEffectView(data, null);
			});
		}

		// Token: 0x0603399B RID: 211355 RVA: 0x00C12B30 File Offset: 0x00C10D30
		public void Refresh(RogueTalentTree data)
		{
			this.Data = new RogueTalentTree?(data);
			int num = RoguelikeModel.Instance.RoguelikeSkillDataMap[data.Id];
			RogueTalentTreeDesc? rogueTalentTreeDescConfig = RoguelikeConfig.Instance.GetRogueTalentTreeDescConfig(data.Describe);
			bool isMax = num >= data.ConsuleLength;
			string talentIcon = rogueTalentTreeDescConfig.Value.TalentIcon;
			bool flag = talentIcon.Contains("Atlas");
			UUITexture texture = base.GetTexture(17);
			texture.SetUIActive(!flag);
			UUISprite sprite = base.GetSprite(1);
			sprite.SetUIActive(flag);
			if (flag)
			{
				this.SetSpriteByPath(talentIcon, sprite, false, null, null);
			}
			else
			{
				base.SetTextureByPath(talentIcon, texture, null, null);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), rogueTalentTreeDescConfig.Value.TalentName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Text_LevelNumber_Text", new <>z__ReadOnlySingleElementList<object>(num));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), rogueTalentTreeDescConfig.Value.BaseDesc, rogueTalentTreeDescConfig.Value.Params());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Text_LevelNumber_Text", new <>z__ReadOnlySingleElementList<object>(num + 1));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), rogueTalentTreeDescConfig.Value.BaseDesc, rogueTalentTreeDescConfig.Value.Params());
			RogueParam? paramConfigBySeasonId = RoguelikeModel.Instance.GetParamConfigBySeasonId(null);
			RogueCurrency? rogueCurrencyConfig = RoguelikeConfig.Instance.GetRogueCurrencyConfig(paramConfigBySeasonId.Value.SkillPoint);
			int roguelikeCurrency = RoguelikeModel.Instance.GetRoguelikeCurrency(paramConfigBySeasonId.Value.SkillPoint);
			int? num2 = (num >= 0 && num < data.ConsuleLength) ? new int?(data.Consule(num)) : null;
			bool flag2 = num2 != null && roguelikeCurrency >= num2.Value;
			UUIText text = base.GetText(8);
			text.SetText(((num2 != null) ? num2.GetValueOrDefault().ToString() : null) ?? "", true);
			if (flag2)
			{
				UUIItem uuiitem = text;
				bool bUseChangeColor = false;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			else
			{
				UUIItem uuiitem2 = text;
				bool bUseChangeColor2 = true;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			}
			base.SetTextureByPath(rogueCurrencyConfig.Value.IconSmall, base.GetTexture(12), null, null);
			this.UpdateDetail(num, isMax);
		}

		// Token: 0x0603399C RID: 211356 RVA: 0x00C12DF0 File Offset: 0x00C10FF0
		public void UpdateDetail(int level, bool isMax)
		{
			if (level < 0)
			{
				base.GetItem(2).SetUIActive(false);
				base.GetItem(5).SetUIActive(false);
				base.GetItem(16).SetUIActive(false);
				base.GetButton(9).RootUIComp.Get().SetUIActive(false);
				base.GetItem(14).SetUIActive(true);
				base.GetItem(13).SetUIActive(false);
				return;
			}
			if (level == 0)
			{
				base.GetItem(2).SetUIActive(false);
				base.GetItem(5).SetUIActive(false);
				base.GetItem(16).SetUIActive(true);
				base.GetButton(9).RootUIComp.Get().SetUIActive(true);
				base.GetItem(14).SetUIActive(false);
				base.GetItem(13).SetUIActive(false);
				return;
			}
			base.GetItem(2).SetUIActive(!isMax);
			base.GetItem(5).SetUIActive(!isMax);
			base.GetItem(16).SetUIActive(!isMax);
			base.GetButton(9).RootUIComp.Get().SetUIActive(!isMax);
			base.GetItem(14).SetUIActive(false);
			base.GetItem(13).SetUIActive(isMax);
		}

		// Token: 0x0401B5EC RID: 112108
		public RogueTalentTree? Data;

		// Token: 0x0200AFD7 RID: 45015
		private static class ERoguelikeSkillDetailDefine
		{
			// Token: 0x0403561E RID: 218654
			public const int TxtSkillName = 0;

			// Token: 0x0403561F RID: 218655
			public const int SprSkillIcon = 1;

			// Token: 0x04035620 RID: 218656
			public const int PanelCurLevel = 2;

			// Token: 0x04035621 RID: 218657
			public const int TxtCurLevel = 3;

			// Token: 0x04035622 RID: 218658
			public const int TxtCurDesc = 4;

			// Token: 0x04035623 RID: 218659
			public const int PanelNextItem = 5;

			// Token: 0x04035624 RID: 218660
			public const int TxtNextLevel = 6;

			// Token: 0x04035625 RID: 218661
			public const int TxtNextDesc = 7;

			// Token: 0x04035626 RID: 218662
			public const int TxtCost = 8;

			// Token: 0x04035627 RID: 218663
			public const int BtnUpgrade = 9;

			// Token: 0x04035628 RID: 218664
			public const int TxtBtnUpgrade = 10;

			// Token: 0x04035629 RID: 218665
			public const int CostPanel = 11;

			// Token: 0x0403562A RID: 218666
			public const int TexCostIcon = 12;

			// Token: 0x0403562B RID: 218667
			public const int PanelMaxLevel = 13;

			// Token: 0x0403562C RID: 218668
			public const int PanelActivateCondition = 14;

			// Token: 0x0403562D RID: 218669
			public const int TxtActivateCondition = 15;

			// Token: 0x0403562E RID: 218670
			public const int PanelCost = 16;

			// Token: 0x0403562F RID: 218671
			public const int TexSkillIcon = 17;
		}
	}
}
