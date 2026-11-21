using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02003F8B RID: 16267
	[NullableContext(2)]
	[Nullable(0)]
	public class QuestMultiLineSelectPanel : UiPanelBase
	{
		// Token: 0x0602927D RID: 168573 RVA: 0x00B8E994 File Offset: 0x00B8CB94
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
		}

		// Token: 0x0602927E RID: 168574 RVA: 0x00B8EA48 File Offset: 0x00B8CC48
		protected override UniTask OnBeforeStartAsync()
		{
			QuestMultiLineSelectPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuestMultiLineSelectPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602927F RID: 168575 RVA: 0x00B8EA8B File Offset: 0x00B8CC8B
		protected override void OnStart()
		{
			this.AdjustItemsWidth();
		}

		// Token: 0x06029280 RID: 168576 RVA: 0x00B8EA94 File Offset: 0x00B8CC94
		private void AdjustItemsWidth()
		{
			UUIItem item = base.GetItem(0);
			UUIItem item2 = base.GetItem(6);
			if (item == null || item2 == null)
			{
				return;
			}
			float num = item.GetWidth() - item2.GetWidth();
			if (num <= 0f)
			{
				return;
			}
			float num2 = num / 2f;
			foreach (int name in new int[]
			{
				1,
				2,
				3,
				4
			})
			{
				UUIItem item3 = base.GetItem(name);
				if (item3 != null)
				{
					item3.SetWidth(item3.GetWidth() + num2);
				}
			}
		}

		// Token: 0x06029281 RID: 168577 RVA: 0x00B8EB24 File Offset: 0x00B8CD24
		[NullableContext(1)]
		public unsafe void RefreshPanel(QuestMultiLineTimePointData timePoint)
		{
			this.ResetButton();
			QuestMultiLineBranchPageData branchPageData = timePoint.BranchPageData;
			if (branchPageData == null)
			{
				return;
			}
			this.BranchPageData = branchPageData;
			List<QuestMultiLineBranchData> list = branchPageData.BranchData ?? new List<QuestMultiLineBranchData>();
			if (list.Count != 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestMultiLine;
				ELogAuthor author = ELogAuthor.CCJ;
				string message = "QuestMultiLineSelectPanel: 分线数据数量异常，应为2条";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("pageId", branchPageData.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("count", list.Count);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			QuestMultiLineBranchData branchData = list[0];
			QuestMultiLineBranchData branchData2 = list[1];
			this.LeftNormalItem.RefreshItem(branchData);
			this.LeftNormalItem.SetClickFunction(new Action<int>(this.OnClickItem));
			this.LeftSelectItem.RefreshItem(branchData);
			this.LeftSelectItem.SetClickFunction(new Action<int>(this.OnClickEnsure));
			this.RightNormalItem.RefreshItem(branchData2);
			this.RightNormalItem.SetClickFunction(new Action<int>(this.OnClickItem));
			this.RightSelectItem.RefreshItem(branchData2);
			this.RightSelectItem.SetClickFunction(new Action<int>(this.OnClickEnsure));
		}

		// Token: 0x06029282 RID: 168578 RVA: 0x00B8EC68 File Offset: 0x00B8CE68
		public void RefreshButton(int branchId)
		{
			bool flag = branchId == this.BranchPageData.BranchData[0].BranchId;
			bool flag2 = branchId == this.BranchPageData.BranchData[1].BranchId;
			this.LeftNormalItem.SetUiActive(!flag);
			this.LeftSelectItem.SetUiActive(flag);
			this.RightNormalItem.SetUiActive(!flag2);
			this.RightSelectItem.SetUiActive(flag2);
		}

		// Token: 0x06029283 RID: 168579 RVA: 0x00B8ECDF File Offset: 0x00B8CEDF
		[NullableContext(1)]
		public void SetClickFunction(Action<int, int> clickFunction)
		{
			this.ClickFunction = clickFunction;
		}

		// Token: 0x06029284 RID: 168580 RVA: 0x00B8ECE8 File Offset: 0x00B8CEE8
		[NullableContext(1)]
		public void SetEnsureFunction(Action<int, int> clickFunction)
		{
			this.EnsureFunction = clickFunction;
		}

		// Token: 0x06029285 RID: 168581 RVA: 0x00B8ECF4 File Offset: 0x00B8CEF4
		private void ResetButton()
		{
			this.LeftNormalItem.SetUiActive(true);
			this.LeftNormalItem.ResetFinishIcon();
			this.LeftSelectItem.SetUiActive(false);
			this.RightNormalItem.SetUiActive(true);
			this.RightNormalItem.ResetFinishIcon();
			this.RightSelectItem.SetUiActive(false);
		}

		// Token: 0x06029286 RID: 168582 RVA: 0x00B8ED47 File Offset: 0x00B8CF47
		private void OnClickItem(int branchId)
		{
			this.RefreshButton(branchId);
			Action<int, int> clickFunction = this.ClickFunction;
			if (clickFunction == null)
			{
				return;
			}
			clickFunction(this.BranchPageData.Id, branchId);
		}

		// Token: 0x06029287 RID: 168583 RVA: 0x00B8ED6C File Offset: 0x00B8CF6C
		private void OnClickEnsure(int branchId)
		{
			Action<int, int> ensureFunction = this.EnsureFunction;
			if (ensureFunction == null)
			{
				return;
			}
			ensureFunction(this.BranchPageData.Id, branchId);
		}

		// Token: 0x04016676 RID: 91766
		private Action<int, int> ClickFunction;

		// Token: 0x04016677 RID: 91767
		private Action<int, int> EnsureFunction;

		// Token: 0x04016678 RID: 91768
		private QuestMultiLineBranchPageData BranchPageData;

		// Token: 0x04016679 RID: 91769
		private QuestMultiLineNormalItem LeftNormalItem;

		// Token: 0x0401667A RID: 91770
		private QuestMultiLineNormalItem RightNormalItem;

		// Token: 0x0401667B RID: 91771
		private QuestMultiLineSelectItem LeftSelectItem;

		// Token: 0x0401667C RID: 91772
		private QuestMultiLineSelectItem RightSelectItem;
	}
}
