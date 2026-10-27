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
	// Token: 0x02004FC2 RID: 20418
	[NullableContext(2)]
	[Nullable(0)]
	public class QuestMultiLineSelectPanel : UiPanelBase
	{
		// Token: 0x0603440F RID: 214031 RVA: 0x00C451DC File Offset: 0x00C433DC
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

		// Token: 0x06034410 RID: 214032 RVA: 0x00C45290 File Offset: 0x00C43490
		protected override UniTask OnBeforeStartAsync()
		{
			QuestMultiLineSelectPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuestMultiLineSelectPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034411 RID: 214033 RVA: 0x00C452D3 File Offset: 0x00C434D3
		protected override void OnStart()
		{
			this.AdjustItemsWidth();
		}

		// Token: 0x06034412 RID: 214034 RVA: 0x00C452DC File Offset: 0x00C434DC
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

		// Token: 0x06034413 RID: 214035 RVA: 0x00C4536C File Offset: 0x00C4356C
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

		// Token: 0x06034414 RID: 214036 RVA: 0x00C454B0 File Offset: 0x00C436B0
		public void RefreshButton(int branchId)
		{
			bool flag = branchId == this.BranchPageData.BranchData[0].BranchId;
			bool flag2 = branchId == this.BranchPageData.BranchData[1].BranchId;
			this.LeftNormalItem.SetUiActive(!flag);
			this.LeftSelectItem.SetUiActive(flag);
			this.RightNormalItem.SetUiActive(!flag2);
			this.RightSelectItem.SetUiActive(flag2);
		}

		// Token: 0x06034415 RID: 214037 RVA: 0x00C45527 File Offset: 0x00C43727
		[NullableContext(1)]
		public void SetClickFunction(Action<int, int> clickFunction)
		{
			this.ClickFunction = clickFunction;
		}

		// Token: 0x06034416 RID: 214038 RVA: 0x00C45530 File Offset: 0x00C43730
		[NullableContext(1)]
		public void SetEnsureFunction(Action<int, int> clickFunction)
		{
			this.EnsureFunction = clickFunction;
		}

		// Token: 0x06034417 RID: 214039 RVA: 0x00C4553C File Offset: 0x00C4373C
		private void ResetButton()
		{
			this.LeftNormalItem.SetUiActive(true);
			this.LeftNormalItem.ResetFinishIcon();
			this.LeftSelectItem.SetUiActive(false);
			this.RightNormalItem.SetUiActive(true);
			this.RightNormalItem.ResetFinishIcon();
			this.RightSelectItem.SetUiActive(false);
		}

		// Token: 0x06034418 RID: 214040 RVA: 0x00C4558F File Offset: 0x00C4378F
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

		// Token: 0x06034419 RID: 214041 RVA: 0x00C455B4 File Offset: 0x00C437B4
		private void OnClickEnsure(int branchId)
		{
			Action<int, int> ensureFunction = this.EnsureFunction;
			if (ensureFunction == null)
			{
				return;
			}
			ensureFunction(this.BranchPageData.Id, branchId);
		}

		// Token: 0x0401BCA1 RID: 113825
		private Action<int, int> ClickFunction;

		// Token: 0x0401BCA2 RID: 113826
		private Action<int, int> EnsureFunction;

		// Token: 0x0401BCA3 RID: 113827
		private QuestMultiLineBranchPageData BranchPageData;

		// Token: 0x0401BCA4 RID: 113828
		private QuestMultiLineNormalItem LeftNormalItem;

		// Token: 0x0401BCA5 RID: 113829
		private QuestMultiLineNormalItem RightNormalItem;

		// Token: 0x0401BCA6 RID: 113830
		private QuestMultiLineSelectItem LeftSelectItem;

		// Token: 0x0401BCA7 RID: 113831
		private QuestMultiLineSelectItem RightSelectItem;
	}
}
