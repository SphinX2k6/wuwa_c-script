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
	// Token: 0x02005186 RID: 20870
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderCardDeleteView : UiViewBase
	{
		// Token: 0x06035613 RID: 218643 RVA: 0x00CA4E4F File Offset: 0x00CA304F
		public DeckBuilderCardDeleteView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06035614 RID: 218644 RVA: 0x00CA4E70 File Offset: 0x00CA3070
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

		// Token: 0x06035615 RID: 218645 RVA: 0x00CA4F4C File Offset: 0x00CA314C
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderCardDeleteView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderCardDeleteView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035616 RID: 218646 RVA: 0x00CA4F8F File Offset: 0x00CA318F
		private void OnCancelButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06035617 RID: 218647 RVA: 0x00CA4F98 File Offset: 0x00CA3198
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

		// Token: 0x06035618 RID: 218648 RVA: 0x00CA4FE4 File Offset: 0x00CA31E4
		private void OnPhysicalToggleClick(EToggleState toggleState)
		{
			if (base.GetExtendToggle(2).GetToggleState() == EToggleState.ETT_Checked)
			{
				this.SelectedElementSet.Add(ECardElement.Physical);
				return;
			}
			this.SelectedElementSet.Remove(ECardElement.Physical);
		}

		// Token: 0x06035619 RID: 218649 RVA: 0x00CA5010 File Offset: 0x00CA3210
		private DeckBuilderCardDeleteFilterItem CreateFilterItem()
		{
			return new DeckBuilderCardDeleteFilterItem
			{
				OnItemToggleStateChange = new Action<int, EToggleState>(this.OnItemToggleStateChange)
			};
		}

		// Token: 0x0603561A RID: 218650 RVA: 0x00CA502C File Offset: 0x00CA322C
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

		// Token: 0x0401C5E9 RID: 116201
		private readonly HashSet<ECardElement> SelectedElementSet = new HashSet<ECardElement>();

		// Token: 0x0401C5EA RID: 116202
		[Nullable(2)]
		private IDeckBuilderCardDeleteViewData Data;

		// Token: 0x0401C5EB RID: 116203
		private readonly List<IDeckBuilderCardDeleteFilterItemData> FilterDataList = new List<IDeckBuilderCardDeleteFilterItemData>();

		// Token: 0x0401C5EC RID: 116204
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DeckBuilderCardDeleteFilterItem, IDeckBuilderCardDeleteFilterItemData> FilterLayout;

		// Token: 0x0200B2F8 RID: 45816
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040363D9 RID: 222169
			public const int CancelButton = 0;

			// Token: 0x040363DA RID: 222170
			public const int ConfirmButton = 1;

			// Token: 0x040363DB RID: 222171
			public const int PhysicalToggle = 2;

			// Token: 0x040363DC RID: 222172
			public const int FilterLayout = 3;

			// Token: 0x040363DD RID: 222173
			public const int FilterItem = 4;
		}
	}
}
