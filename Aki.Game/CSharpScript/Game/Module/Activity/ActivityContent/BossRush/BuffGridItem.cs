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
	// Token: 0x020068FE RID: 26878
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class BuffGridItem : GridProxyAbstract<BuffGridItemData>
	{
		// Token: 0x06043079 RID: 274553 RVA: 0x01053FB0 File Offset: 0x010521B0
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

		// Token: 0x0604307A RID: 274554 RVA: 0x010540BC File Offset: 0x010522BC
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Unbind();
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanClickLikeToggle));
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0604307B RID: 274555 RVA: 0x01054108 File Offset: 0x01052308
		private bool CanClickLikeToggle()
		{
			return this.CurrentData != null && ((this.CurrentData.State == BossRushBuffSelectionStatus.BuffLocked && base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_UnChecked) || this.CurrentData.CheckClickAble(this.CurrentData));
		}

		// Token: 0x0604307C RID: 274556 RVA: 0x01054148 File Offset: 0x01052348
		private void OnClickToggle(EToggleState state)
		{
			this.CurrentData.OnClickToggle(this.CurrentData);
		}

		// Token: 0x0604307D RID: 274557 RVA: 0x01054160 File Offset: 0x01052360
		public void SetToggleActiveState(bool state)
		{
			base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(state);
		}

		// Token: 0x0604307E RID: 274558 RVA: 0x01054188 File Offset: 0x01052388
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

		// Token: 0x0604307F RID: 274559 RVA: 0x010541F2 File Offset: 0x010523F2
		private void RefreshSelectedTag()
		{
			base.GetItem(4).SetUIActive(this.CurrentData.SelectedAtStart);
		}

		// Token: 0x06043080 RID: 274560 RVA: 0x0105420C File Offset: 0x0105240C
		private void RefreshName()
		{
			BossRushBuff? bossRushBuffConfigById = BossRushConfig.Instance.GetBossRushBuffConfigById(this.CurrentData.BuffId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), bossRushBuffConfigById.Value.Name, Array.Empty<object>());
		}

		// Token: 0x06043081 RID: 274561 RVA: 0x01054254 File Offset: 0x01052454
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

		// Token: 0x06043082 RID: 274562 RVA: 0x0105432C File Offset: 0x0105252C
		private void RefreshBuffTexture()
		{
			string texture = BossRushConfig.Instance.GetBossRushBuffConfigById(this.CurrentData.BuffId).Value.Texture;
			base.SetTextureByPath(texture, base.GetTexture(1), null, null);
		}

		// Token: 0x04022E4D RID: 142925
		[Nullable(2)]
		private BuffScrollItemData CurrentData;

		// Token: 0x04022E4E RID: 142926
		[StaticVariableRuleIgnore]
		private static Regex regex = new Regex("\\[(.*?)\\]");

		// Token: 0x0200CAB2 RID: 51890
		[NullableContext(0)]
		private class EBuffScrollItemComponent
		{
			// Token: 0x0403D427 RID: 250919
			public const int Toggle = 0;

			// Token: 0x0403D428 RID: 250920
			public const int BuffTexture = 1;

			// Token: 0x0403D429 RID: 250921
			public const int BuffName = 2;

			// Token: 0x0403D42A RID: 250922
			public const int BuffDesc = 3;

			// Token: 0x0403D42B RID: 250923
			public const int SelectedTag = 4;
		}
	}
}
