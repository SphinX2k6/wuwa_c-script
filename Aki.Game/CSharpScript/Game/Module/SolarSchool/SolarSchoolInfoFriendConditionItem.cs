using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059B1 RID: 22961
	public class SolarSchoolInfoFriendConditionItem : UiPanelBase
	{
		// Token: 0x060389A6 RID: 231846 RVA: 0x00FD66D8 File Offset: 0x00FD48D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060389A7 RID: 231847 RVA: 0x00FD684C File Offset: 0x00FD4A4C
		[NullableContext(1)]
		public void Refresh(SolarSchoolRoleFavorLevelData data, bool showAffinityRedPoint)
		{
			string text = data.Config.PreUnlockIcon ?? string.Empty;
			bool flag = !string.IsNullOrEmpty(text);
			UUITexture texture = base.GetTexture(0);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			if (flag)
			{
				base.SetTextureShowUntilLoaded(text, base.GetTexture(0), null);
			}
			bool flag2 = data.IsUnlocked();
			bool flag3 = data.IsFavorLevelReached();
			bool flag4 = data.ShouldShowProgress();
			int favorTargetValue = data.GetFavorTargetValue();
			int favorCurrentValue = data.GetFavorCurrentValue();
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(flag2);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(!flag2);
			}
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				sprite.SetUIActive(flag3);
			}
			UUISliderComponent slider = base.GetSlider(7);
			if (slider != null)
			{
				UUIItem uuiitem = slider.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag4);
				}
			}
			UUIText text2 = base.GetText(8);
			if (text2 != null)
			{
				text2.SetUIActive(flag4);
			}
			UUIItem item3 = base.GetItem(9);
			if (item3 != null)
			{
				item3.SetUIActive(showAffinityRedPoint);
			}
			if (flag4)
			{
				UUISliderComponent slider2 = base.GetSlider(7);
				if (slider2 != null)
				{
					slider2.SetValue(data.GetFavorProgress(), true);
				}
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(8), "SolarSchool_HaoganNum", new <>z__ReadOnlyArray<object>(new object[]
				{
					favorCurrentValue,
					favorTargetValue
				}));
			}
			if (flag2)
			{
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(4), flag3 ? data.Config.SkillDesc : data.Config.UnlockHint, Array.Empty<object>());
				return;
			}
			string preUnlockConditionHintText = data.GetPreUnlockConditionHintText();
			if (string.IsNullOrEmpty(preUnlockConditionHintText))
			{
				string textStringId;
				object item4;
				if (data.IsCurrentLevel())
				{
					textStringId = "SolarSchool_CharacterUpgrade_num";
					item4 = favorTargetValue;
				}
				else
				{
					textStringId = "SolarSchool_CharacterUpgrade_grade";
					item4 = new TableTextArgNew(SolarSchoolPopupData.GetFavorLevelTextKey(data.Config.FavorLevel - 1), Array.Empty<object>());
				}
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(6), textStringId, new <>z__ReadOnlySingleElementList<object>(item4));
				return;
			}
			UUIText text3 = base.GetText(6);
			if (text3 == null)
			{
				return;
			}
			text3.SetText(preUnlockConditionHintText, true);
		}

		// Token: 0x060389A8 RID: 231848 RVA: 0x00FD6A68 File Offset: 0x00FD4C68
		public void Clear()
		{
			UUITexture texture = base.GetTexture(0);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUISliderComponent slider = base.GetSlider(7);
			if (slider != null)
			{
				UUIItem uuiitem = slider.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(false);
				}
			}
			UUIText text = base.GetText(8);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(9);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
		}

		// Token: 0x0200B55C RID: 46428
		private class EComponent
		{
			// Token: 0x04038130 RID: 229680
			public const int Icon = 0;

			// Token: 0x04038131 RID: 229681
			public const int Title = 1;

			// Token: 0x04038132 RID: 229682
			public const int PnlUnlock = 2;

			// Token: 0x04038133 RID: 229683
			public const int Check = 3;

			// Token: 0x04038134 RID: 229684
			public const int UnlockedContent = 4;

			// Token: 0x04038135 RID: 229685
			public const int PnlLock = 5;

			// Token: 0x04038136 RID: 229686
			public const int LockedContent = 6;

			// Token: 0x04038137 RID: 229687
			public const int Progress = 7;

			// Token: 0x04038138 RID: 229688
			public const int ProgressText = 8;

			// Token: 0x04038139 RID: 229689
			public const int PnlAffinityRedPoint = 9;
		}
	}
}
