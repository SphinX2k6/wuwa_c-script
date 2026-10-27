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
	// Token: 0x02004D48 RID: 19784
	public class RoleDevelopProjectSkillSlotItem : UiPanelBase
	{
		// Token: 0x060331D4 RID: 209364 RVA: 0x00BEA8A8 File Offset: 0x00BE8AA8
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

		// Token: 0x060331D5 RID: 209365 RVA: 0x00BEA9D2 File Offset: 0x00BE8BD2
		[NullableContext(1)]
		public void Refresh(RoleDevelopSkillData data)
		{
			this.Data = data;
			this.RefreshView();
		}

		// Token: 0x060331D6 RID: 209366 RVA: 0x00BEA9E4 File Offset: 0x00BE8BE4
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
			bool selfInteractive = RoleModel.Instance.IsRoleOwned(data.RoleId);
			base.GetButton(3).SetSelfInteractive(selfInteractive);
		}

		// Token: 0x060331D7 RID: 209367 RVA: 0x00BEABD8 File Offset: 0x00BE8DD8
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
				string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("T_RoleDevelopRecommend");
				base.SetTextureByPath(resourcePath2, texture, null, null);
			}
		}

		// Token: 0x060331D8 RID: 209368 RVA: 0x00BEAC6C File Offset: 0x00BE8E6C
		private void OnSkillSlotClick()
		{
			if (this.Data == null)
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

		// Token: 0x0401B2B8 RID: 111288
		[Nullable(2)]
		private RoleDevelopSkillData Data;

		// Token: 0x0200AEB4 RID: 44724
		public static class EComponentType
		{
			// Token: 0x040350E3 RID: 217315
			public const int SpriteSkill = 0;

			// Token: 0x040350E4 RID: 217316
			public const int SpriteLock = 1;

			// Token: 0x040350E5 RID: 217317
			public const int TxtSkillNum = 2;

			// Token: 0x040350E6 RID: 217318
			public const int BtnSkillSlot = 3;

			// Token: 0x040350E7 RID: 217319
			public const int ItemTag = 4;

			// Token: 0x040350E8 RID: 217320
			public const int TextureTag = 5;
		}
	}
}
