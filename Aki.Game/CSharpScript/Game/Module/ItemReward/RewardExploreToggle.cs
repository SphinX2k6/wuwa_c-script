using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047E2 RID: 18402
	public class RewardExploreToggle : UiPanelBase
	{
		// Token: 0x0602E3BC RID: 189372 RVA: 0x00CE53CC File Offset: 0x00CE35CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E3BD RID: 189373 RVA: 0x00CE5435 File Offset: 0x00CE3635
		protected override void OnStart()
		{
			this.StateToggle = base.GetExtendToggle(1);
		}

		// Token: 0x0602E3BE RID: 189374 RVA: 0x00CE5444 File Offset: 0x00CE3644
		protected override void OnBeforeDestroy()
		{
			this.StateToggle = null;
		}

		// Token: 0x0602E3BF RID: 189375 RVA: 0x00CE5450 File Offset: 0x00CE3650
		[NullableContext(1)]
		public void Refresh(IRewardExploreToggle toggleData)
		{
			this.StateToggle.SetToggleState(toggleData.DefaultOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			if (toggleData.OnToggleClick != null)
			{
				this.StateToggle.OnStateChange.Add(toggleData.OnToggleClick);
			}
			if (!StringUtils.IsEmpty(toggleData.DescriptionTextId))
			{
				this.SetTitleText(toggleData.DescriptionTextId);
			}
		}

		// Token: 0x0602E3C0 RID: 189376 RVA: 0x00CE54B4 File Offset: 0x00CE36B4
		[NullableContext(1)]
		private void SetTitleText(string titleTextId)
		{
			if (StringUtils.IsEmpty(titleTextId))
			{
				return;
			}
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, titleTextId, Array.Empty<object>());
		}

		// Token: 0x0602E3C1 RID: 189377 RVA: 0x00CE54E4 File Offset: 0x00CE36E4
		public EToggleState? GetToggleState()
		{
			UUIExtendToggle stateToggle = this.StateToggle;
			if (stateToggle == null)
			{
				return null;
			}
			return new EToggleState?(stateToggle.GetToggleState());
		}

		// Token: 0x040189F1 RID: 100849
		[Nullable(2)]
		private UUIExtendToggle StateToggle;

		// Token: 0x0200A422 RID: 42018
		private class EChildType
		{
			// Token: 0x04032DB1 RID: 208305
			public const int TitleText = 0;

			// Token: 0x04032DB2 RID: 208306
			public const int StateToggle = 1;
		}
	}
}
