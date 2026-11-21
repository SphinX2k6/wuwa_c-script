using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050DF RID: 20703
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeLevelItem : GridProxyAbstract<RoverlikeLevelSelectItemData>
	{
		// Token: 0x06033CD4 RID: 212180 RVA: 0x00E7F9A8 File Offset: 0x00E7DBA8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChange));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033CD5 RID: 212181 RVA: 0x00E7FB14 File Offset: 0x00E7DD14
		public override void Refresh(RoverlikeLevelSelectItemData data, bool isSelected, int gridIndex)
		{
			this.InstId = data.InstId;
			RoverRogueIns? insConfig = RoverlikeConfig.Instance.GetInsConfig(this.InstId);
			int num = (insConfig != null) ? insConfig.GetValueOrDefault().SortId : 0;
			string text;
			if (num >= 10)
			{
				text = num.ToString();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("0");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string newText = text;
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetText(newText, true);
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(!data.Unlocked);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(data.Passed);
			}
			int num2 = (insConfig != null) ? insConfig.GetValueOrDefault().Difficulty : 0;
			if (num2 == 0)
			{
				num2 = 1;
			}
			int index = Math.Min(Math.Max(num2 - 1, 0), 2);
			base.TrySetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(RoverlikeLevelItem.DifficultySpriteNames[index]), base.GetSprite(4), false, null, null);
			base.TrySetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(RoverlikeLevelItem.DifficultySeleSpriteNames[index]), base.GetSprite(7), false, null, null);
			UUISprite sprite = base.GetSprite(5);
			if (sprite != null)
			{
				sprite.SetColor(RoverlikeLevelItem.DifficultyLightColors[index]);
			}
			UUISprite sprite2 = base.GetSprite(6);
			if (sprite2 != null)
			{
				sprite2.SetColor(RoverlikeLevelItem.DifficultyLineColors[index]);
			}
			this.SetToggleChecked(isSelected, false);
		}

		// Token: 0x06033CD6 RID: 212182 RVA: 0x00E7FCAA File Offset: 0x00E7DEAA
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleChecked(true, false);
		}

		// Token: 0x06033CD7 RID: 212183 RVA: 0x00E7FCB4 File Offset: 0x00E7DEB4
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleChecked(false, false);
		}

		// Token: 0x06033CD8 RID: 212184 RVA: 0x00E7FCBE File Offset: 0x00E7DEBE
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Bind(() => !this.IsSelected);
		}

		// Token: 0x06033CD9 RID: 212185 RVA: 0x00E7FCE2 File Offset: 0x00E7DEE2
		public override object GetKey(RoverlikeLevelSelectItemData data, int gridIndex)
		{
			return data.InstId;
		}

		// Token: 0x06033CDA RID: 212186 RVA: 0x00E7FCEF File Offset: 0x00E7DEEF
		public void SetToggleChecked(bool isChecked, bool fireEvent)
		{
			this.IsSelected = isChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isChecked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06033CDB RID: 212187 RVA: 0x00E7FD13 File Offset: 0x00E7DF13
		public int GetInstId()
		{
			return this.InstId;
		}

		// Token: 0x06033CDC RID: 212188 RVA: 0x00E7FD1B File Offset: 0x00E7DF1B
		private void OnToggleStateChange(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			Action<int> onSelectCallback = this.OnSelectCallback;
			if (onSelectCallback == null)
			{
				return;
			}
			onSelectCallback(this.InstId);
		}

		// Token: 0x0401B723 RID: 112419
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<string> DifficultySpriteNames = new List<string>
		{
			"SP_SeleLevelTabNorLineEasy",
			"SP_SeleLevelTabNorLineMedium",
			"SP_SeleLevelTabNorLineHard"
		};

		// Token: 0x0401B724 RID: 112420
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<string> DifficultySeleSpriteNames = new List<string>
		{
			"SP_SeleLevelTabSleLightEasy",
			"SP_SeleLevelTabSleLightMedium",
			"SP_SeleLevelTabSleLightHard"
		};

		// Token: 0x0401B725 RID: 112421
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<FColor> DifficultyLightColors = new List<FColor>
		{
			FColor.FromHex("#80B3FFFF"),
			FColor.FromHex("#5046D2FF"),
			FColor.FromHex("#B0233AFF")
		};

		// Token: 0x0401B726 RID: 112422
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<FColor> DifficultyLineColors = new List<FColor>
		{
			FColor.FromHex("#4D9EF2FF"),
			FColor.FromHex("#AD9CFFFF"),
			FColor.FromHex("#FF7484FF")
		};

		// Token: 0x0401B727 RID: 112423
		[Nullable(2)]
		public Action<int> OnSelectCallback;

		// Token: 0x0401B728 RID: 112424
		private int InstId;

		// Token: 0x0401B729 RID: 112425
		private bool IsSelected;

		// Token: 0x0200ADA8 RID: 44456
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035A71 RID: 219761
			public const int TogTabLevel = 0;

			// Token: 0x04035A72 RID: 219762
			public const int TxtLevel = 1;

			// Token: 0x04035A73 RID: 219763
			public const int PnlLock = 2;

			// Token: 0x04035A74 RID: 219764
			public const int PnlDone = 3;

			// Token: 0x04035A75 RID: 219765
			public const int SprDifficulty = 4;

			// Token: 0x04035A76 RID: 219766
			public const int SprDifficultyLight = 5;

			// Token: 0x04035A77 RID: 219767
			public const int SprDifficultyLine = 6;

			// Token: 0x04035A78 RID: 219768
			public const int SprSeleColor = 7;
		}
	}
}
