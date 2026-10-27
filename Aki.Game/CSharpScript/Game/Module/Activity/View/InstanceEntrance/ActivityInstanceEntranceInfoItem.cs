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
	// Token: 0x02005F14 RID: 24340
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityInstanceEntranceInfoItem : UiPanelBase
	{
		// Token: 0x0603DD6C RID: 253292 RVA: 0x00EF2110 File Offset: 0x00EF0310
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

		// Token: 0x0603DD6D RID: 253293 RVA: 0x00EF219C File Offset: 0x00EF039C
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityInstanceEntranceInfoItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityInstanceEntranceInfoItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603DD6E RID: 253294 RVA: 0x00EF21DF File Offset: 0x00EF03DF
		public void RefreshView(ActivityInstanceEntranceData data)
		{
			this.RefreshTitleItem(data);
			this.RefreshStartItem(data);
			this.RefreshLockItem(data);
			this.RefreshRecommendLevelItem(data).Forget();
			this.RefreshDropDownItem(data).Forget();
			this.RefreshMonsterTipsItem(data).Forget();
		}

		// Token: 0x0603DD6F RID: 253295 RVA: 0x00EF221C File Offset: 0x00EF041C
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

		// Token: 0x0603DD70 RID: 253296 RVA: 0x00EF22E4 File Offset: 0x00EF04E4
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

		// Token: 0x0603DD71 RID: 253297 RVA: 0x00EF2378 File Offset: 0x00EF0578
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

		// Token: 0x0603DD72 RID: 253298 RVA: 0x00EF23F0 File Offset: 0x00EF05F0
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

		// Token: 0x0603DD73 RID: 253299 RVA: 0x00EF243C File Offset: 0x00EF063C
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

		// Token: 0x0603DD74 RID: 253300 RVA: 0x00EF2488 File Offset: 0x00EF0688
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

		// Token: 0x040204C8 RID: 132296
		private InstanceDungeonRightTitleItem InstanceDungeonRightTitleItem;

		// Token: 0x040204C9 RID: 132297
		private InstanceDungeonStartButtonItem InstanceDungeonStartButtonItem;

		// Token: 0x040204CA RID: 132298
		private InstanceDungeonLockItem InstanceDungeonLockItem;

		// Token: 0x040204CB RID: 132299
		private InstanceDungeonRecommendLevelItem InstanceDungeonRecommendLevelItem;

		// Token: 0x040204CC RID: 132300
		private ActivityInstanceEntranceDropDownItem ActivityInstanceEntranceDropDownItem;

		// Token: 0x040204CD RID: 132301
		private ActivityInstanceEntranceMonsterTipsItem ActivityInstanceEntranceMonsterTipsItem;

		// Token: 0x040204CE RID: 132302
		private CustomPromise ActivityInstanceEntranceDropDownItemPromise;

		// Token: 0x040204CF RID: 132303
		private CustomPromise InstanceDungeonRecommendLevelItemPromise;

		// Token: 0x040204D0 RID: 132304
		private CustomPromise ActivityInstanceEntranceMonsterTipsItemPromise;

		// Token: 0x0200C244 RID: 49732
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403AB05 RID: 240389
			TopItem,
			// Token: 0x0403AB06 RID: 240390
			BottomItem,
			// Token: 0x0403AB07 RID: 240391
			ButtonItem
		}
	}
}
