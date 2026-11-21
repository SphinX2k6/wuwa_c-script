using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EFB RID: 20219
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityInstanceEntranceInfoItem : UiPanelBase
	{
		// Token: 0x06032D07 RID: 208135 RVA: 0x00E43E18 File Offset: 0x00E42018
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032D08 RID: 208136 RVA: 0x00E43EA4 File Offset: 0x00E420A4
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityInstanceEntranceInfoItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityInstanceEntranceInfoItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032D09 RID: 208137 RVA: 0x00E43EE7 File Offset: 0x00E420E7
		public void RefreshView(ActivityInstanceEntranceData data)
		{
			this.RefreshTitleItem(data);
			this.RefreshStartItem(data);
			this.RefreshLockItem(data);
			this.RefreshRecommendLevelItem(data).Forget();
			this.RefreshDropDownItem(data).Forget();
			this.RefreshMonsterTipsItem(data).Forget();
		}

		// Token: 0x06032D0A RID: 208138 RVA: 0x00E43F24 File Offset: 0x00E42124
		private void RefreshTitleItem(ActivityInstanceEntranceData data)
		{
			if (data == null || data.GetActivityEntranceDescInfoData() == null)
			{
				InstanceDungeonRightTitleItem instanceDungeonRightTitleItem = this.InstanceDungeonRightTitleItem;
				if (instanceDungeonRightTitleItem == null)
				{
					return;
				}
				instanceDungeonRightTitleItem.SetUiActive(false);
				return;
			}
			else
			{
				InstanceDungeonRightTitleItem instanceDungeonRightTitleItem2 = this.InstanceDungeonRightTitleItem;
				if (instanceDungeonRightTitleItem2 != null)
				{
					instanceDungeonRightTitleItem2.SetUiActive(true);
				}
				ActivityEntranceDescInfoData activityEntranceDescInfoData = data.GetActivityEntranceDescInfoData();
				ActivityEntranceSelectItemData activityEntranceSelectItemData = data.GetActivityEntranceSelectItemData();
				int? num;
				if (activityEntranceSelectItemData == null)
				{
					num = null;
				}
				else
				{
					ActivityEntranceItemData currentSelectData = activityEntranceSelectItemData.GetCurrentSelectData();
					num = ((currentSelectData != null) ? new int?(currentSelectData.GetSelectDataIndex()) : null);
				}
				int? num2 = num;
				int valueOrDefault = num2.GetValueOrDefault();
				InstanceDungeonRightTitleItem instanceDungeonRightTitleItem3 = this.InstanceDungeonRightTitleItem;
				if (instanceDungeonRightTitleItem3 != null)
				{
					instanceDungeonRightTitleItem3.RefreshName(activityEntranceDescInfoData.GetName(valueOrDefault));
				}
				InstanceDungeonRightTitleItem instanceDungeonRightTitleItem4 = this.InstanceDungeonRightTitleItem;
				if (instanceDungeonRightTitleItem4 != null)
				{
					instanceDungeonRightTitleItem4.RefreshDesc(activityEntranceDescInfoData.GetDesc(valueOrDefault));
				}
				InstanceDungeonRightTitleItem instanceDungeonRightTitleItem5 = this.InstanceDungeonRightTitleItem;
				if (instanceDungeonRightTitleItem5 == null)
				{
					return;
				}
				instanceDungeonRightTitleItem5.UpdateInstanceDungeonRecommendElementItem(activityEntranceDescInfoData.GetRecommendElement(valueOrDefault));
				return;
			}
		}

		// Token: 0x06032D0B RID: 208139 RVA: 0x00E43FEC File Offset: 0x00E421EC
		private void RefreshStartItem(ActivityInstanceEntranceData data)
		{
			ActivityInstanceEntranceInfoItem.<>c__DisplayClass14_0 CS$<>8__locals1 = new ActivityInstanceEntranceInfoItem.<>c__DisplayClass14_0();
			CS$<>8__locals1.data = data;
			if (CS$<>8__locals1.data == null)
			{
				this.InstanceDungeonStartButtonItem.SetUiActive(false);
				return;
			}
			this.InstanceDungeonStartButtonItem.SetUiActive(true);
			this.InstanceDungeonStartButtonItem.RefreshItem(InstOnlineType.Single);
			InstanceDungeonModel.Instance.InstanceContinue = false;
			this.InstanceDungeonStartButtonItem.OnClickBtnSoloCallBack = new Action(CS$<>8__locals1.<RefreshStartItem>g__callback|0);
			bool lockState = CS$<>8__locals1.data.GetActivityEntranceSelectItemData().GetCurrentSelectData().GetLockState();
			InstanceDungeonStartButtonItem instanceDungeonStartButtonItem = this.InstanceDungeonStartButtonItem;
			if (instanceDungeonStartButtonItem == null)
			{
				return;
			}
			instanceDungeonStartButtonItem.SetActive(!lockState);
		}

		// Token: 0x06032D0C RID: 208140 RVA: 0x00E44080 File Offset: 0x00E42280
		private void RefreshLockItem(ActivityInstanceEntranceData data)
		{
			if (data == null)
			{
				this.InstanceDungeonLockItem.SetUiActive(false);
				return;
			}
			bool lockState = data.GetActivityEntranceSelectItemData().GetCurrentSelectData().GetLockState();
			this.InstanceDungeonLockItem.SetUiActive(lockState);
			string text;
			if (lockState)
			{
				ActivityEntranceItemData currentSelectData = data.GetActivityEntranceSelectItemData().GetCurrentSelectData();
				text = ((currentSelectData != null) ? currentSelectData.GetUnLockDesc() : null);
			}
			else
			{
				text = "";
			}
			string text2 = text;
			if (lockState && text2 != "")
			{
				this.InstanceDungeonLockItem.SetLockText(text2);
			}
		}

		// Token: 0x06032D0D RID: 208141 RVA: 0x00E440F8 File Offset: 0x00E422F8
		public UniTask RefreshDropDownItem(ActivityInstanceEntranceData data)
		{
			ActivityInstanceEntranceInfoItem.<RefreshDropDownItem>d__16 <RefreshDropDownItem>d__;
			<RefreshDropDownItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDropDownItem>d__.<>4__this = this;
			<RefreshDropDownItem>d__.data = data;
			<RefreshDropDownItem>d__.<>1__state = -1;
			<RefreshDropDownItem>d__.<>t__builder.Start<ActivityInstanceEntranceInfoItem.<RefreshDropDownItem>d__16>(ref <RefreshDropDownItem>d__);
			return <RefreshDropDownItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032D0E RID: 208142 RVA: 0x00E44144 File Offset: 0x00E42344
		public UniTask RefreshRecommendLevelItem(ActivityInstanceEntranceData data)
		{
			ActivityInstanceEntranceInfoItem.<RefreshRecommendLevelItem>d__17 <RefreshRecommendLevelItem>d__;
			<RefreshRecommendLevelItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRecommendLevelItem>d__.<>4__this = this;
			<RefreshRecommendLevelItem>d__.data = data;
			<RefreshRecommendLevelItem>d__.<>1__state = -1;
			<RefreshRecommendLevelItem>d__.<>t__builder.Start<ActivityInstanceEntranceInfoItem.<RefreshRecommendLevelItem>d__17>(ref <RefreshRecommendLevelItem>d__);
			return <RefreshRecommendLevelItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032D0F RID: 208143 RVA: 0x00E44190 File Offset: 0x00E42390
		public UniTask RefreshMonsterTipsItem(ActivityInstanceEntranceData data)
		{
			ActivityInstanceEntranceInfoItem.<RefreshMonsterTipsItem>d__18 <RefreshMonsterTipsItem>d__;
			<RefreshMonsterTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshMonsterTipsItem>d__.<>4__this = this;
			<RefreshMonsterTipsItem>d__.data = data;
			<RefreshMonsterTipsItem>d__.<>1__state = -1;
			<RefreshMonsterTipsItem>d__.<>t__builder.Start<ActivityInstanceEntranceInfoItem.<RefreshMonsterTipsItem>d__18>(ref <RefreshMonsterTipsItem>d__);
			return <RefreshMonsterTipsItem>d__.<>t__builder.Task;
		}

		// Token: 0x0401AF9A RID: 110490
		private InstanceDungeonRightTitleItem InstanceDungeonRightTitleItem;

		// Token: 0x0401AF9B RID: 110491
		private InstanceDungeonStartButtonItem InstanceDungeonStartButtonItem;

		// Token: 0x0401AF9C RID: 110492
		private InstanceDungeonLockItem InstanceDungeonLockItem;

		// Token: 0x0401AF9D RID: 110493
		private InstanceDungeonRecommendLevelItem InstanceDungeonRecommendLevelItem;

		// Token: 0x0401AF9E RID: 110494
		private ActivityInstanceEntranceDropDownItem ActivityInstanceEntranceDropDownItem;

		// Token: 0x0401AF9F RID: 110495
		private ActivityInstanceEntranceMonsterTipsItem ActivityInstanceEntranceMonsterTipsItem;

		// Token: 0x0401AFA0 RID: 110496
		private CustomPromise ActivityInstanceEntranceDropDownItemPromise;

		// Token: 0x0401AFA1 RID: 110497
		private CustomPromise InstanceDungeonRecommendLevelItemPromise;

		// Token: 0x0401AFA2 RID: 110498
		private CustomPromise ActivityInstanceEntranceMonsterTipsItemPromise;

		// Token: 0x0200AC51 RID: 44113
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040354F7 RID: 218359
			TopItem,
			// Token: 0x040354F8 RID: 218360
			BottomItem,
			// Token: 0x040354F9 RID: 218361
			ButtonItem
		}
	}
}
