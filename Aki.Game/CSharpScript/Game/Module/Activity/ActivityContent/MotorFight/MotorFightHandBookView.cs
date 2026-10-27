using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006426 RID: 25638
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightHandBookView : UiViewBase
	{
		// Token: 0x06040770 RID: 264048 RVA: 0x00F997FF File Offset: 0x00F979FF
		public MotorFightHandBookView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06040771 RID: 264049 RVA: 0x00F9981C File Offset: 0x00F97A1C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040772 RID: 264050 RVA: 0x00F9990C File Offset: 0x00F97B0C
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightHandBookView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightHandBookView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040773 RID: 264051 RVA: 0x00F99950 File Offset: 0x00F97B50
		private void InitScrollViewData()
		{
			foreach (MotorFightItemType data in this.MotorFightActivityData.GetMotorFightItemTypeList())
			{
				MotorFightItemTypeTemplateData motorFightItemTypeTemplateData = new MotorFightItemTypeTemplateData();
				motorFightItemTypeTemplateData.Data = data;
				motorFightItemTypeTemplateData.GetUnlockNum = new Func<int, Tuple<int, int>>(this.GetUnlockNum);
				this.ScrollDataList.Add(motorFightItemTypeTemplateData);
				foreach (MotorFightItemData data2 in this.MotorFightActivityData.GetMotorFightItemDataListByType(data.Id))
				{
					MotorFightGridTemplateData motorFightGridTemplateData = new MotorFightGridTemplateData();
					motorFightGridTemplateData.Data = data2;
					motorFightGridTemplateData.OnClickCb = new Action<MotorFightItemData, int>(this.OnItemClick);
					motorFightGridTemplateData.IsSelected = new Func<int, bool>(this.IsSelected);
					this.ScrollDataList.Add(motorFightGridTemplateData);
				}
			}
		}

		// Token: 0x06040774 RID: 264052 RVA: 0x00F99A60 File Offset: 0x00F97C60
		protected override void OnBeforeHide()
		{
			this.MotorFightActivityData.ReadHandBookRedDot();
		}

		// Token: 0x06040775 RID: 264053 RVA: 0x00F99A6D File Offset: 0x00F97C6D
		private Tuple<int, int> GetUnlockNum(int type)
		{
			return this.MotorFightActivityData.GetItemUnlockNum(type);
		}

		// Token: 0x06040776 RID: 264054 RVA: 0x00F99A7C File Offset: 0x00F97C7C
		private void OnItemClick(MotorFightItemData data, int index)
		{
			this.SelectedItemData = data;
			this.ItemMultiTemplateScrollView.RefreshProxyDirectly(this.SelectedIndex);
			this.SelectedIndex = index;
			this.ItemMultiTemplateScrollView.RefreshProxyDirectly(index);
			MotorFightItemDetailPanel detailPanel = this.DetailPanel;
			if (detailPanel != null)
			{
				detailPanel.Refresh(data);
			}
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x06040777 RID: 264055 RVA: 0x00F99ADD File Offset: 0x00F97CDD
		private bool IsSelected(int id)
		{
			return this.SelectedItemData != null && this.SelectedItemData.Id == id;
		}

		// Token: 0x06040778 RID: 264056 RVA: 0x00F99AF7 File Offset: 0x00F97CF7
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04021838 RID: 137272
		[Nullable(2)]
		private MotorFightActivityData MotorFightActivityData;

		// Token: 0x04021839 RID: 137273
		private int SelectedIndex = 1;

		// Token: 0x0402183A RID: 137274
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0402183B RID: 137275
		private MotorFightItemDetailPanel DetailPanel;

		// Token: 0x0402183C RID: 137276
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0402183D RID: 137277
		[Nullable(2)]
		private MotorFightItemData SelectedItemData;

		// Token: 0x0402183E RID: 137278
		[Nullable(2)]
		private MultiTemplateScrollView ItemMultiTemplateScrollView;

		// Token: 0x0200C65A RID: 50778
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BE11 RID: 245265
			public const int ItemCaption = 0;

			// Token: 0x0403BE12 RID: 245266
			public const int ItemDetailPanel = 1;

			// Token: 0x0403BE13 RID: 245267
			public const int MultiTemplateScrollView = 2;

			// Token: 0x0403BE14 RID: 245268
			public const int ItemTitle = 3;

			// Token: 0x0403BE15 RID: 245269
			public const int ItemGrid = 4;

			// Token: 0x0403BE16 RID: 245270
			public const int TextCollectNum = 5;
		}
	}
}
