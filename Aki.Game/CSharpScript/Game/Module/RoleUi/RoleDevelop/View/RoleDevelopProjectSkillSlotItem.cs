using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D11 RID: 15633
	public class RoleDevelopProjectSkillSlotItem : UiPanelBase
	{
		// Token: 0x06028037 RID: 163895 RVA: 0x00B33BEC File Offset: 0x00B31DEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISpriteTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnSkillSlotClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06028038 RID: 163896 RVA: 0x00B33D16 File Offset: 0x00B31F16
		[NullableContext(1)]
		public void Refresh(RoleDevelopSkillData data, bool clickEnabled = true)
		{
			this.Data = data;
			this.ClickEnabled = clickEnabled;
			this.RefreshView();
		}

		// Token: 0x06028039 RID: 163897 RVA: 0x00B33D2C File Offset: 0x00B31F2C
		private void RefreshView()
		{
			RoleDevelopSkillData data = this.Data;
			bool flag = RoleDevelopUtil.IsAnyProspectRole(data.RoleId);
			UUIText text = base.GetText(2);
			base.GetSprite(1).SetUIActive(flag);
			base.GetUiSpriteTransition(0).RootUIComp.Get().SetUIActive(!flag);
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				UUIItem uuiitem = sprite;
				bool bUseChangeColor = flag;
				FColor? fcolor = new FColor?(sprite.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			int currentLevel = data.CurrentLevel;
			if (flag)
			{
				LguiUtil.Instance.SetLocalText(text, "LevelRichText", new <>z__ReadOnlyArray<object>(new object[]
				{
					currentLevel,
					data.TargetLevel
				}));
				base.GetItem(4).SetUIActive(false);
			}
			else
			{
				int targetLevel = data.TargetLevel;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Lv.");
				defaultInterpolatedStringHandler.AppendFormatted<int>(currentLevel);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(targetLevel);
				string item = defaultInterpolatedStringHandler.ToStringAndClear();
				if (currentLevel >= targetLevel)
				{
					LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_SkillLevel01", new <>z__ReadOnlySingleElementList<object>(item));
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_SkillLevel02", new <>z__ReadOnlySingleElementList<object>(item));
				}
				SkillTree? skillTreeNode = RoleSkillConfig.Instance.GetSkillTreeNode(data.SkillNodeId);
				string path;
				if (skillTreeNode.Value.SkillId > 0)
				{
					path = RoleSkillConfig.Instance.GetSkillConfigById(skillTreeNode.Value.SkillId).Value.Icon;
				}
				else
				{
					path = skillTreeNode.Value.PropertyNodeIcon;
				}
				base.SetSpriteTransitionByPath(path, base.GetUiSpriteTransition(0), EUISelectableSelectionState.EUISelectableSelectionState_MAX);
				this.RefreshShowTag(skillTreeNode.Value.SkillId);
			}
			bool flag2 = RoleModel.Instance.IsRoleOwned(data.RoleId);
			base.GetButton(3).SetSelfInteractive(this.ClickEnabled && flag2);
		}

		// Token: 0x0602803A RID: 163898 RVA: 0x00B33F28 File Offset: 0x00B32128
		private void RefreshShowTag(int skillId)
		{
			UUIItem item = base.GetItem(4);
			UUITexture texture = base.GetTexture(5);
			int skillShowTagType = RoleSkillConfig.Instance.GetSkillConfigById(skillId).Value.SkillShowTagType;
			item.SetUIActive(skillShowTagType != 0);
			if (skillShowTagType == 1)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_RoleDevelopRecommendA");
				base.SetTextureByPath(resourcePath, texture, null, null);
				return;
			}
			if (skillShowTagType == 2)
			{
				string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("T_RoleDevelopRecommendB");
				base.SetTextureByPath(resourcePath2, texture, null, null);
			}
		}

		// Token: 0x0602803B RID: 163899 RVA: 0x00B33FBC File Offset: 0x00B321BC
		private void OnSkillSlotClick()
		{
			if (this.Data == null || !this.ClickEnabled)
			{
				return;
			}
			SkillTree? skillTreeNode = RoleSkillConfig.Instance.GetSkillTreeNode(this.Data.SkillNodeId);
			RoleDevSkillMergeViewParams param = new RoleDevSkillMergeViewParams
			{
				RoleId = this.Data.RoleId,
				SkillNodeIndex = ((skillTreeNode != null) ? skillTreeNode.GetValueOrDefault().NodeIndex : RoleDevConfig.Instance.GetDefaultSkillNodeIndex())
			};
			UiManager.Instance.OpenView(EUiViewName.RoleSkillMergeView, param, null);
		}

		// Token: 0x04015C89 RID: 89225
		[Nullable(2)]
		private RoleDevelopSkillData Data;

		// Token: 0x04015C8A RID: 89226
		private bool ClickEnabled = true;

		// Token: 0x020098E8 RID: 39144
		private enum EComponentType
		{
			// Token: 0x0402FB08 RID: 195336
			SpriteSkill,
			// Token: 0x0402FB09 RID: 195337
			SpriteLock,
			// Token: 0x0402FB0A RID: 195338
			TxtSkillNum,
			// Token: 0x0402FB0B RID: 195339
			BtnSkillSlot,
			// Token: 0x0402FB0C RID: 195340
			ItemTag,
			// Token: 0x0402FB0D RID: 195341
			TextureTag
		}
	}
}
