using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.Consume
{
	// Token: 0x02005B85 RID: 23429
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonConditionFilterComponent : UiNavigationView
	{
		// Token: 0x0603B477 RID: 242807 RVA: 0x00E20FCC File Offset: 0x00E1F1CC
		public CommonConditionFilterComponent(UUIItem uiItem, TCommonConditionFilterFunction conditionFunction)
		{
			this.ConditionFunction = conditionFunction;
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B478 RID: 242808 RVA: 0x00E20FE8 File Offset: 0x00E1F1E8
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

		// Token: 0x0603B479 RID: 242809 RVA: 0x00E210B0 File Offset: 0x00E1F2B0
		private void MaskClick()
		{
			UiLayer.Instance.SetShowMaskLayer("CommonConditionFilterComponent", true);
			this.LevelSequencePlayer.PlayLevelSequenceByName("hide", false, null, false);
		}

		// Token: 0x0603B47A RID: 242810 RVA: 0x00E210E8 File Offset: 0x00E1F2E8
		protected override void OnStart()
		{
			this.Layout = new GenericLayoutNew<CommonConditionFilterItem>(base.GetVerticalLayout(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonConditionFilterItem>(this.InitItem), null);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceFinishEvent), false);
		}

		// Token: 0x0603B47B RID: 242811 RVA: 0x00E21140 File Offset: 0x00E1F340
		public void RefreshQualityList(IReadOnlyList<QualityInfo> data)
		{
			this.Layout.RebuildLayoutByDataNew<QualityInfo>(data.ToArray<QualityInfo>(), null);
			this.Layout.GetLayoutItemByKey(0).SetToggleState(true, true);
		}

		// Token: 0x0603B47C RID: 242812 RVA: 0x00E2117F File Offset: 0x00E1F37F
		private void SequenceFinishEvent(string sequenceName)
		{
			if (sequenceName == "hide")
			{
				this.SetActive(false);
				UiLayer.Instance.SetShowMaskLayer("CommonConditionFilterComponent", false);
			}
		}

		// Token: 0x0603B47D RID: 242813 RVA: 0x00E211A8 File Offset: 0x00E1F3A8
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

		// Token: 0x0603B47E RID: 242814 RVA: 0x00E211EC File Offset: 0x00E1F3EC
		private void ToggleFunction(int qualityId, string text)
		{
			this.ResetComponent();
			this.SetActive(false);
			if (this.ConditionFunction != null)
			{
				this.ConditionFunction(qualityId, text);
			}
		}

		// Token: 0x0603B47F RID: 242815 RVA: 0x00E21210 File Offset: 0x00E1F410
		protected void ResetComponent()
		{
			foreach (CommonConditionFilterItem commonConditionFilterItem in this.Layout.GetLayoutItemMap().Values)
			{
				commonConditionFilterItem.SetToggleState(false, false);
			}
		}

		// Token: 0x0603B480 RID: 242816 RVA: 0x00E2126C File Offset: 0x00E1F46C
		protected override void OnBeforeDestroy()
		{
			if (this.Layout != null)
			{
				this.Layout.ClearChildren();
				this.Layout = null;
			}
		}

		// Token: 0x0603B481 RID: 242817 RVA: 0x00E21288 File Offset: 0x00E1F488
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

		// Token: 0x0401EE6D RID: 126573
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayoutNew<CommonConditionFilterItem> Layout;

		// Token: 0x0401EE6E RID: 126574
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401EE6F RID: 126575
		protected TCommonConditionFilterFunction ConditionFunction;

		// Token: 0x0200BD91 RID: 48529
		[NullableContext(0)]
		private class ECommonConditionFilterComponent
		{
			// Token: 0x040392D1 RID: 234193
			public const int MaskButton = 0;

			// Token: 0x040392D2 RID: 234194
			public const int ConditionViewItem = 1;

			// Token: 0x040392D3 RID: 234195
			public const int Layout = 2;
		}
	}
}
