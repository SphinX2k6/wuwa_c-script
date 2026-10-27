using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E3E RID: 28222
	public class FishingGetScrollItem : UiPanelBase
	{
		// Token: 0x06044CD9 RID: 281817 RVA: 0x010FA5BC File Offset: 0x010F87BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06044CDA RID: 281818 RVA: 0x010FA628 File Offset: 0x010F8828
		protected override void OnStart()
		{
			ListSliderControlData<FishingGetItem> listSliderControlData = new ListSliderControlData<FishingGetItem>(base.GetItem(1).GetParentAsUIItem(), new Func<FishingGetItem>(this.CreateProxyFunction), new Func<bool>(this.CheckNext));
			listSliderControlData.MaxShowCount = new int?(7);
			listSliderControlData.AddItemTime = new float?((float)200);
			listSliderControlData.ItemSliderTime = new float?((float)CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetSliderTime());
			ListSliderControlData<FishingGetItem> listSliderControlData2 = listSliderControlData;
			int? intConfig = ConfigCommonParamById.GetIntConfig("FishingQteGetListItemShowTime");
			listSliderControlData2.ItemShowTime = ((intConfig != null) ? new float?((float)intConfig.GetValueOrDefault()) : null);
			listSliderControlData.ItemSliderTime = new float?((float)200);
			listSliderControlData.TickMode = new ETickItemMode?(ETickItemMode.TickOnlyTop);
			this.ListSlideControl = new ListSliderControl<FishingGetItem>(listSliderControlData);
			this.ListSlideControl.DisEnableParentLayout();
		}

		// Token: 0x06044CDB RID: 281819 RVA: 0x010FA6F8 File Offset: 0x010F88F8
		public void OnTick(float delta)
		{
			ListSliderControl<FishingGetItem> listSlideControl = this.ListSlideControl;
			if (listSlideControl == null)
			{
				return;
			}
			listSlideControl.Tick(delta);
		}

		// Token: 0x06044CDC RID: 281820 RVA: 0x010FA70B File Offset: 0x010F890B
		[NullableContext(1)]
		private FishingGetItem CreateProxyFunction()
		{
			return new FishingGetItem();
		}

		// Token: 0x06044CDD RID: 281821 RVA: 0x010FA712 File Offset: 0x010F8912
		private bool CheckNext()
		{
			return !FishingQteModel.Instance.IsTempGetDataEmpty();
		}

		// Token: 0x04023CB8 RID: 146616
		private const int MAX_LIST_COUNT = 7;

		// Token: 0x04023CB9 RID: 146617
		private const int ITEM_INTERVAL_TIME = 200;

		// Token: 0x04023CBA RID: 146618
		private const int ITEM_SILDER_TIME = 200;

		// Token: 0x04023CBB RID: 146619
		[Nullable(1)]
		protected ListSliderControl<FishingGetItem> ListSlideControl;

		// Token: 0x0200CCF0 RID: 52464
		private class EComponents
		{
			// Token: 0x0403DCD2 RID: 253138
			public const int Layout = 0;

			// Token: 0x0403DCD3 RID: 253139
			public const int Item = 1;
		}
	}
}
