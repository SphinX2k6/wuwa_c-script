using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x0200584E RID: 22606
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class BuffGridItem : GridProxyAbstract<BuffGridItemData>
	{
		// Token: 0x06037BD1 RID: 228305 RVA: 0x00F955D8 File Offset: 0x00F937D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06037BD2 RID: 228306 RVA: 0x00F956E4 File Offset: 0x00F938E4
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Unbind();
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanClickLikeToggle));
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06037BD3 RID: 228307 RVA: 0x00F95730 File Offset: 0x00F93930
		private bool CanClickLikeToggle()
		{
			return this.CurrentData != null && ((this.CurrentData.State == BossRushBuffSelectionStatus.BuffLocked && base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_UnChecked) || this.CurrentData.CheckClickAble(this.CurrentData));
		}

		// Token: 0x06037BD4 RID: 228308 RVA: 0x00F95770 File Offset: 0x00F93970
		private void OnClickToggle(EToggleState state)
		{
			this.CurrentData.OnClickToggle(this.CurrentData);
		}

		// Token: 0x06037BD5 RID: 228309 RVA: 0x00F95788 File Offset: 0x00F93988
		public void SetToggleActiveState(bool state)
		{
			base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(state);
		}

		// Token: 0x06037BD6 RID: 228310 RVA: 0x00F957B0 File Offset: 0x00F939B0
		public override void Refresh(BuffGridItemData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data.BuffScrollItemData1;
			if (data.BuffScrollItemData1.State == BossRushBuffSelectionStatus.BuffInactive)
			{
				return;
			}
			BuffScrollItemData buffScrollItemData = data.BuffScrollItemData1;
			EToggleState state = (buffScrollItemData != null && buffScrollItemData.Selected) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
			this.RefreshName();
			this.RefreshDesc();
			this.RefreshBuffTexture();
			this.RefreshSelectedTag();
		}

		// Token: 0x06037BD7 RID: 228311 RVA: 0x00F9581A File Offset: 0x00F93A1A
		private void RefreshSelectedTag()
		{
			base.GetItem(4).SetUIActive(this.CurrentData.SelectedAtStart);
		}

		// Token: 0x06037BD8 RID: 228312 RVA: 0x00F95834 File Offset: 0x00F93A34
		private void RefreshName()
		{
			BossRushBuff? bossRushBuffConfigById = BossRushConfig.Instance.GetBossRushBuffConfigById(this.CurrentData.BuffId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), bossRushBuffConfigById.Value.Name, Array.Empty<object>());
		}

		// Token: 0x06037BD9 RID: 228313 RVA: 0x00F9587C File Offset: 0x00F93A7C
		private void RefreshDesc()
		{
			BossRushBuff? bossRushBuffConfigById = BossRushConfig.Instance.GetBossRushBuffConfigById(this.CurrentData.BuffId);
			List<string> list = new List<string>();
			foreach (string input in bossRushBuffConfigById.Value.DescriptionParamIter())
			{
				Match match = BuffGridItem.regex.Match(input);
				if (match.Success && match.Groups.Count > 1)
				{
					list.AddRange(match.Groups[1].Value.Split(',', StringSplitOptions.None));
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), bossRushBuffConfigById.Value.Description, list.ToArray());
		}

		// Token: 0x06037BDA RID: 228314 RVA: 0x00F95954 File Offset: 0x00F93B54
		private void RefreshBuffTexture()
		{
			string texture = BossRushConfig.Instance.GetBossRushBuffConfigById(this.CurrentData.BuffId).Value.Texture;
			base.SetTextureByPath(texture, base.GetTexture(1), null, null);
		}

		// Token: 0x0401D6A9 RID: 120489
		[Nullable(2)]
		private BuffScrollItemData CurrentData;

		// Token: 0x0401D6AA RID: 120490
		[StaticVariableRuleIgnore]
		private static Regex regex = new Regex("\\[(.*?)\\]");

		// Token: 0x0200B47A RID: 46202
		[NullableContext(0)]
		private class EBuffScrollItemComponent
		{
			// Token: 0x04037D01 RID: 228609
			public const int Toggle = 0;

			// Token: 0x04037D02 RID: 228610
			public const int BuffTexture = 1;

			// Token: 0x04037D03 RID: 228611
			public const int BuffName = 2;

			// Token: 0x04037D04 RID: 228612
			public const int BuffDesc = 3;

			// Token: 0x04037D05 RID: 228613
			public const int SelectedTag = 4;
		}
	}
}
