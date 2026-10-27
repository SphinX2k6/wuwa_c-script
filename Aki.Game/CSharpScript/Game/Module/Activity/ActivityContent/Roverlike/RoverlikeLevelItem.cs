using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006161 RID: 24929
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeLevelItem : GridProxyAbstract<RoverlikeLevelSelectItemData>
	{
		// Token: 0x0603F014 RID: 258068 RVA: 0x00F38AD4 File Offset: 0x00F36CD4
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

		// Token: 0x0603F015 RID: 258069 RVA: 0x00F38C40 File Offset: 0x00F36E40
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

		// Token: 0x0603F016 RID: 258070 RVA: 0x00F38DD6 File Offset: 0x00F36FD6
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleChecked(true, false);
		}

		// Token: 0x0603F017 RID: 258071 RVA: 0x00F38DE0 File Offset: 0x00F36FE0
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleChecked(false, false);
		}

		// Token: 0x0603F018 RID: 258072 RVA: 0x00F38DEA File Offset: 0x00F36FEA
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Bind(() => !this.IsSelected);
		}

		// Token: 0x0603F019 RID: 258073 RVA: 0x00F38E0E File Offset: 0x00F3700E
		public override object GetKey(RoverlikeLevelSelectItemData data, int gridIndex)
		{
			return data.InstId;
		}

		// Token: 0x0603F01A RID: 258074 RVA: 0x00F38E1B File Offset: 0x00F3701B
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

		// Token: 0x0603F01B RID: 258075 RVA: 0x00F38E3F File Offset: 0x00F3703F
		public int GetInstId()
		{
			return this.InstId;
		}

		// Token: 0x0603F01C RID: 258076 RVA: 0x00F38E47 File Offset: 0x00F37047
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

		// Token: 0x04020DF6 RID: 134646
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<string> DifficultySpriteNames = new List<string>
		{
			"SP_SeleLevelTabNorLineEasy",
			"SP_SeleLevelTabNorLineMedium",
			"SP_SeleLevelTabNorLineHard"
		};

		// Token: 0x04020DF7 RID: 134647
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<string> DifficultySeleSpriteNames = new List<string>
		{
			"SP_SeleLevelTabSleLightEasy",
			"SP_SeleLevelTabSleLightMedium",
			"SP_SeleLevelTabSleLightHard"
		};

		// Token: 0x04020DF8 RID: 134648
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<FColor> DifficultyLightColors = new List<FColor>
		{
			FColor.FromHex("#80B3FFFF"),
			FColor.FromHex("#5046D2FF"),
			FColor.FromHex("#B0233AFF")
		};

		// Token: 0x04020DF9 RID: 134649
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<FColor> DifficultyLineColors = new List<FColor>
		{
			FColor.FromHex("#4D9EF2FF"),
			FColor.FromHex("#AD9CFFFF"),
			FColor.FromHex("#FF7484FF")
		};

		// Token: 0x04020DFA RID: 134650
		[Nullable(2)]
		public Action<int> OnSelectCallback;

		// Token: 0x04020DFB RID: 134651
		private int InstId;

		// Token: 0x04020DFC RID: 134652
		private bool IsSelected;

		// Token: 0x0200C3C1 RID: 50113
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B110 RID: 241936
			public const int TogTabLevel = 0;

			// Token: 0x0403B111 RID: 241937
			public const int TxtLevel = 1;

			// Token: 0x0403B112 RID: 241938
			public const int PnlLock = 2;

			// Token: 0x0403B113 RID: 241939
			public const int PnlDone = 3;

			// Token: 0x0403B114 RID: 241940
			public const int SprDifficulty = 4;

			// Token: 0x0403B115 RID: 241941
			public const int SprDifficultyLight = 5;

			// Token: 0x0403B116 RID: 241942
			public const int SprDifficultyLine = 6;

			// Token: 0x0403B117 RID: 241943
			public const int SprSeleColor = 7;
		}
	}
}
