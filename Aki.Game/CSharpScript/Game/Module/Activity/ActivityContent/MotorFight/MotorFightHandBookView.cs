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
	// Token: 0x020053A4 RID: 21412
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightHandBookView : UiViewBase
	{
		// Token: 0x06035431 RID: 218161 RVA: 0x00EE079F File Offset: 0x00EDE99F
		public MotorFightHandBookView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035432 RID: 218162 RVA: 0x00EE07BC File Offset: 0x00EDE9BC
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

		// Token: 0x06035433 RID: 218163 RVA: 0x00EE08AC File Offset: 0x00EDEAAC
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightHandBookView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightHandBookView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035434 RID: 218164 RVA: 0x00EE08F0 File Offset: 0x00EDEAF0
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

		// Token: 0x06035435 RID: 218165 RVA: 0x00EE0A00 File Offset: 0x00EDEC00
		protected override void OnBeforeHide()
		{
			this.MotorFightActivityData.ReadHandBookRedDot();
		}

		// Token: 0x06035436 RID: 218166 RVA: 0x00EE0A0D File Offset: 0x00EDEC0D
		private Tuple<int, int> GetUnlockNum(int type)
		{
			return this.MotorFightActivityData.GetItemUnlockNum(type);
		}

		// Token: 0x06035437 RID: 218167 RVA: 0x00EE0A1C File Offset: 0x00EDEC1C
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

		// Token: 0x06035438 RID: 218168 RVA: 0x00EE0A7D File Offset: 0x00EDEC7D
		private bool IsSelected(int id)
		{
			return this.SelectedItemData != null && this.SelectedItemData.Id == id;
		}

		// Token: 0x06035439 RID: 218169 RVA: 0x00EE0A97 File Offset: 0x00EDEC97
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401C167 RID: 115047
		[Nullable(2)]
		private MotorFightActivityData MotorFightActivityData;

		// Token: 0x0401C168 RID: 115048
		private int SelectedIndex = 1;

		// Token: 0x0401C169 RID: 115049
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401C16A RID: 115050
		private MotorFightItemDetailPanel DetailPanel;

		// Token: 0x0401C16B RID: 115051
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C16C RID: 115052
		[Nullable(2)]
		private MotorFightItemData SelectedItemData;

		// Token: 0x0401C16D RID: 115053
		[Nullable(2)]
		private MultiTemplateScrollView ItemMultiTemplateScrollView;

		// Token: 0x0200B041 RID: 45121
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403676E RID: 223086
			public const int ItemCaption = 0;

			// Token: 0x0403676F RID: 223087
			public const int ItemDetailPanel = 1;

			// Token: 0x04036770 RID: 223088
			public const int MultiTemplateScrollView = 2;

			// Token: 0x04036771 RID: 223089
			public const int ItemTitle = 3;

			// Token: 0x04036772 RID: 223090
			public const int ItemGrid = 4;

			// Token: 0x04036773 RID: 223091
			public const int TextCollectNum = 5;
		}
	}
}
