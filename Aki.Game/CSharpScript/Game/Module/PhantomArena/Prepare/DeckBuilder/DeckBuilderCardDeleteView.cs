using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004156 RID: 16726
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderCardDeleteView : UiViewBase
	{
		// Token: 0x0602A50E RID: 173326 RVA: 0x00BF2407 File Offset: 0x00BF0607
		public DeckBuilderCardDeleteView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602A50F RID: 173327 RVA: 0x00BF2428 File Offset: 0x00BF0628
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(3, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnCancelButtonClick)),
				new ValueTuple<int, Delegate>(1, new Action(this.OnConfirmButtonClick)),
				new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnPhysicalToggleClick))
			};
		}

		// Token: 0x0602A510 RID: 173328 RVA: 0x00BF2504 File Offset: 0x00BF0704
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderCardDeleteView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderCardDeleteView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A511 RID: 173329 RVA: 0x00BF2547 File Offset: 0x00BF0747
		private void OnCancelButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602A512 RID: 173330 RVA: 0x00BF2550 File Offset: 0x00BF0750
		private void OnConfirmButtonClick()
		{
			if (this.SelectedElementSet.Count == 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1125", Array.Empty<object>());
				return;
			}
			base.CloseMe(null);
			this.Data.DeleteFunc(this.SelectedElementSet);
		}

		// Token: 0x0602A513 RID: 173331 RVA: 0x00BF259C File Offset: 0x00BF079C
		private void OnPhysicalToggleClick(EToggleState toggleState)
		{
			if (base.GetExtendToggle(2).GetToggleState() == EToggleState.ETT_Checked)
			{
				this.SelectedElementSet.Add(ECardElement.Physical);
				return;
			}
			this.SelectedElementSet.Remove(ECardElement.Physical);
		}

		// Token: 0x0602A514 RID: 173332 RVA: 0x00BF25C8 File Offset: 0x00BF07C8
		private DeckBuilderCardDeleteFilterItem CreateFilterItem()
		{
			return new DeckBuilderCardDeleteFilterItem
			{
				OnItemToggleStateChange = new Action<int, EToggleState>(this.OnItemToggleStateChange)
			};
		}

		// Token: 0x0602A515 RID: 173333 RVA: 0x00BF25E4 File Offset: 0x00BF07E4
		private void OnItemToggleStateChange(int gridIndex, EToggleState state)
		{
			IDeckBuilderCardDeleteFilterItemData deckBuilderCardDeleteFilterItemData = this.FilterDataList[gridIndex];
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectedElementSet.Add(deckBuilderCardDeleteFilterItemData.Element);
				return;
			}
			this.SelectedElementSet.Remove(deckBuilderCardDeleteFilterItemData.Element);
		}

		// Token: 0x0401701E RID: 94238
		private readonly HashSet<ECardElement> SelectedElementSet = new HashSet<ECardElement>();

		// Token: 0x0401701F RID: 94239
		[Nullable(2)]
		private IDeckBuilderCardDeleteViewData Data;

		// Token: 0x04017020 RID: 94240
		private readonly List<IDeckBuilderCardDeleteFilterItemData> FilterDataList = new List<IDeckBuilderCardDeleteFilterItemData>();

		// Token: 0x04017021 RID: 94241
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DeckBuilderCardDeleteFilterItem, IDeckBuilderCardDeleteFilterItemData> FilterLayout;

		// Token: 0x02009D31 RID: 40241
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030E2E RID: 200238
			public const int CancelButton = 0;

			// Token: 0x04030E2F RID: 200239
			public const int ConfirmButton = 1;

			// Token: 0x04030E30 RID: 200240
			public const int PhysicalToggle = 2;

			// Token: 0x04030E31 RID: 200241
			public const int FilterLayout = 3;

			// Token: 0x04030E32 RID: 200242
			public const int FilterItem = 4;
		}
	}
}
