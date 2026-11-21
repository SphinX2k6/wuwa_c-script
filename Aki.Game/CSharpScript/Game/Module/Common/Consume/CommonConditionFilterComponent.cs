using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.Consume
{
	// Token: 0x02004B65 RID: 19301
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonConditionFilterComponent : UiNavigationView
	{
		// Token: 0x060303C4 RID: 197572 RVA: 0x00D71540 File Offset: 0x00D6F740
		public CommonConditionFilterComponent(UUIItem uiItem, TCommonConditionFilterFunction conditionFunction)
		{
			this.ConditionFunction = conditionFunction;
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x060303C5 RID: 197573 RVA: 0x00D7155C File Offset: 0x00D6F75C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.MaskClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060303C6 RID: 197574 RVA: 0x00D71624 File Offset: 0x00D6F824
		private void MaskClick()
		{
			UiLayer.Instance.SetShowMaskLayer("CommonConditionFilterComponent", true);
			this.LevelSequencePlayer.PlayLevelSequenceByName("hide", false, null, false);
		}

		// Token: 0x060303C7 RID: 197575 RVA: 0x00D7165C File Offset: 0x00D6F85C
		protected override void OnStart()
		{
			this.Layout = new GenericLayoutNew<CommonConditionFilterItem>(base.GetVerticalLayout(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonConditionFilterItem>(this.InitItem), null);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceFinishEvent), false);
		}

		// Token: 0x060303C8 RID: 197576 RVA: 0x00D716B4 File Offset: 0x00D6F8B4
		public void RefreshQualityList(IReadOnlyList<QualityInfo> data)
		{
			this.Layout.RebuildLayoutByDataNew<QualityInfo>(data, null);
			this.Layout.GetLayoutItemByKey(0).SetToggleState(true, true);
		}

		// Token: 0x060303C9 RID: 197577 RVA: 0x00D716EE File Offset: 0x00D6F8EE
		private void SequenceFinishEvent(string sequenceName)
		{
			if (sequenceName == "hide")
			{
				this.SetActive(false);
				UiLayer.Instance.SetShowMaskLayer("CommonConditionFilterComponent", false);
			}
		}

		// Token: 0x060303CA RID: 197578 RVA: 0x00D71714 File Offset: 0x00D6F914
		private ILayoutItem<CommonConditionFilterItem> InitItem(object qualityInfo, UUIItem uiItem, int index)
		{
			CommonConditionFilterItem commonConditionFilterItem = new CommonConditionFilterItem(uiItem, (QualityInfo)qualityInfo);
			commonConditionFilterItem.SetToggleFunction(new TCommonConditionFilterItemFunction(this.ToggleFunction));
			return new LayoutItem<CommonConditionFilterItem>
			{
				Key = index,
				Value = commonConditionFilterItem
			};
		}

		// Token: 0x060303CB RID: 197579 RVA: 0x00D71758 File Offset: 0x00D6F958
		private void ToggleFunction(int qualityId, string text)
		{
			this.ResetComponent();
			this.SetActive(false);
			if (this.ConditionFunction != null)
			{
				this.ConditionFunction(qualityId, text);
			}
		}

		// Token: 0x060303CC RID: 197580 RVA: 0x00D7177C File Offset: 0x00D6F97C
		protected void ResetComponent()
		{
			foreach (CommonConditionFilterItem commonConditionFilterItem in this.Layout.GetLayoutItemMap().Values)
			{
				commonConditionFilterItem.SetToggleState(false, false);
			}
		}

		// Token: 0x060303CD RID: 197581 RVA: 0x00D717D8 File Offset: 0x00D6F9D8
		protected override void OnBeforeDestroy()
		{
			if (this.Layout != null)
			{
				this.Layout.ClearChildren();
				this.Layout = null;
			}
		}

		// Token: 0x060303CE RID: 197582 RVA: 0x00D717F4 File Offset: 0x00D6F9F4
		public void UpdateComponent(int qualityId)
		{
			this.SetActive(true);
			foreach (CommonConditionFilterItem commonConditionFilterItem in this.Layout.GetLayoutItemMap().Values)
			{
				if (commonConditionFilterItem.GetQualityInfo().Id == qualityId)
				{
					commonConditionFilterItem.SetToggleState(true, false);
				}
			}
			this.LevelSequencePlayer.PlayLevelSequenceByName("show", false, null, false);
		}

		// Token: 0x0401991E RID: 104734
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayoutNew<CommonConditionFilterItem> Layout;

		// Token: 0x0401991F RID: 104735
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04019920 RID: 104736
		protected TCommonConditionFilterFunction ConditionFunction;

		// Token: 0x0200A79B RID: 42907
		[NullableContext(0)]
		private class ECommonConditionFilterComponent
		{
			// Token: 0x04033C9F RID: 212127
			public const int MaskButton = 0;

			// Token: 0x04033CA0 RID: 212128
			public const int ConditionViewItem = 1;

			// Token: 0x04033CA1 RID: 212129
			public const int Layout = 2;
		}
	}
}
