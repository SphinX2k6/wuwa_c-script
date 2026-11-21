using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A21 RID: 23073
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolGalleryEndingDetailView : UiViewBase
	{
		// Token: 0x06038D2A RID: 232746 RVA: 0x00FE8180 File Offset: 0x00FE6380
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIMultiTemplateLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.PreBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.NextBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038D2B RID: 232747 RVA: 0x00FE8420 File Offset: 0x00FE6620
		private void PreBtnClick()
		{
			int num = this.CurrentDataIndex - 1;
			if (num < 0)
			{
				return;
			}
			this.CurrentData = this.DataList[num];
			this.CurrentDataIndex = num;
			this.RefreshView();
			base.PlayOrReplaySequence("Switch_L", false, null);
		}

		// Token: 0x06038D2C RID: 232748 RVA: 0x00FE8470 File Offset: 0x00FE6670
		private void NextBtnClick()
		{
			int num = this.CurrentDataIndex + 1;
			if (num >= this.DataList.Count)
			{
				return;
			}
			this.CurrentData = this.DataList[num];
			this.CurrentDataIndex = num;
			this.RefreshView();
			base.PlayOrReplaySequence("Switch_R", false, null);
		}

		// Token: 0x06038D2D RID: 232749 RVA: 0x00FE84C9 File Offset: 0x00FE66C9
		public SolarSchoolGalleryEndingDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038D2E RID: 232750 RVA: 0x00FE84E4 File Offset: 0x00FE66E4
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolGalleryEndingDetailView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolGalleryEndingDetailView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038D2F RID: 232751 RVA: 0x00FE8528 File Offset: 0x00FE6728
		protected override void OnStart()
		{
			this.ActivityData = SolarSchoolModel.Instance.GetCurrentActivityData();
			this.DataList = this.ActivityData.GetGalleryDataList(SolarSchoolGalleryType.Ending);
			int id = (int)this.OpenParam;
			this.CurrentDataIndex = this.DataList.FindIndex((SolarSchoolGalleryData data) => data.Config.Id == id);
			this.CurrentData = this.DataList[this.CurrentDataIndex];
		}

		// Token: 0x06038D30 RID: 232752 RVA: 0x00FE85A2 File Offset: 0x00FE67A2
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x06038D31 RID: 232753 RVA: 0x00FE85AC File Offset: 0x00FE67AC
		private void OnClickGrid(MediumItemGridExtendCallback cb)
		{
			SolarSchoolGalleryData currentData = this.CurrentData;
			bool flag;
			if (currentData != null && !currentData.IsGetReward && currentData.IsUnlock)
			{
				SolarSchoolGallery config = currentData.Config;
				flag = (config.DropId > 0);
			}
			else
			{
				flag = false;
			}
			if (flag)
			{
				List<int> list = new List<int>();
				foreach (SolarSchoolGalleryData solarSchoolGalleryData in this.DataList)
				{
					if (solarSchoolGalleryData != null && !solarSchoolGalleryData.IsGetReward && solarSchoolGalleryData.IsUnlock)
					{
						SolarSchoolGallery config = solarSchoolGalleryData.Config;
						if (config.DropId > 0)
						{
							list.Add(solarSchoolGalleryData.Config.Id);
						}
					}
				}
				SolarSchoolController.Instance.GetGalleryReward(list);
				return;
			}
			TItem? itemGridData = this.ItemGridData;
			if (itemGridData != null)
			{
				TItem valueOrDefault = itemGridData.GetValueOrDefault();
				ItemController.Instance.OpenItemTipsByItemId(valueOrDefault.ItemData.ItemId, false, null, false);
			}
		}

		// Token: 0x06038D32 RID: 232754 RVA: 0x00FE86A8 File Offset: 0x00FE68A8
		private void RefreshView()
		{
			this.RefreshEndingInfo();
			this.RefreshConditionLayout();
			this.RefreshReward();
			this.RefreshBtnState();
		}

		// Token: 0x06038D33 RID: 232755 RVA: 0x00FE86C4 File Offset: 0x00FE68C4
		private void RefreshEndingInfo()
		{
			bool isUnlock = this.CurrentData.IsUnlock;
			SolarSchoolGallery config = this.CurrentData.Config;
			if (isUnlock)
			{
				EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
				base.SetTextureByPath((playerGender == EPlayerGender.Male) ? config.DetailResourceMale : config.DetailResourceFemale, base.GetTexture(1), null, null);
			}
			base.GetItem(14).SetUIActive(!isUnlock);
			SolarSchoolEnding? config2 = ConfigSolarSchoolEndingById.GetConfig(config.Param, true);
			if (config2 != null)
			{
				string textStringId = (!isUnlock && this.CurrentData.Config.IsLockHide) ? "PrefabTextItem_2022607613_Text" : config2.Value.Desc;
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), textStringId, Array.Empty<object>());
				this.StarLayout.RebuildLayout(config2.Value.Star);
			}
		}

		// Token: 0x06038D34 RID: 232756 RVA: 0x00FE87B0 File Offset: 0x00FE69B0
		private void RefreshConditionLayout()
		{
			SolarSchoolGallery config = this.CurrentData.Config;
			List<int> list = new List<int>();
			if (config.ClientCondition > 0)
			{
				foreach (int num in ActivityConditionConfig.Instance.GetConditionGroupConfig(config.ClientCondition).Value.GetGroupIdArray())
				{
					if (this.IsConditionDisplayable(num))
					{
						list.Add(num);
					}
				}
			}
			this.ConditionLayout.RefreshByData(list, null, false);
			base.GetItem(15).SetUIActive(list.Count <= 0);
		}

		// Token: 0x06038D35 RID: 232757 RVA: 0x00FE8850 File Offset: 0x00FE6A50
		private bool IsConditionDisplayable(int conditionId)
		{
			ActivityCondition? config = ConfigActivityConditionById.GetConfig(conditionId, true);
			return config != null && (config.Value.Type == 1 || !string.IsNullOrEmpty(config.Value.Description));
		}

		// Token: 0x06038D36 RID: 232758 RVA: 0x00FE88A0 File Offset: 0x00FE6AA0
		private void RefreshReward()
		{
			bool isGetReward = this.CurrentData.IsGetReward;
			base.GetItem(11).SetUIActive(!isGetReward);
			base.GetItem(12).SetUIActive(isGetReward);
			SolarSchoolGallery config = this.CurrentData.Config;
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(config.DropId);
			bool flag = dropPackagePreviewItemList.Count > 0;
			base.GetItem(13).SetUIActive(flag);
			if (!flag)
			{
				this.ItemGridData = null;
				this.Grid.SetRedDotVisible(new bool?(false));
				return;
			}
			this.ItemGridData = new TItem?(dropPackagePreviewItemList[0]);
			SolarSchoolGalleryData currentData = this.CurrentData;
			bool flag2;
			if (currentData != null && currentData.IsUnlock && !currentData.IsGetReward)
			{
				SolarSchoolGallery config2 = currentData.Config;
				flag2 = (config2.DropId > 0);
			}
			else
			{
				flag2 = false;
			}
			bool flag3 = flag2;
			this.Grid.Refresh(this.ItemGridData.Value);
			this.Grid.SetReceivedVisible(isGetReward);
			this.Grid.SetReceivableVisible(flag3);
			this.Grid.SetRedDotVisible(new bool?(flag3));
		}

		// Token: 0x06038D37 RID: 232759 RVA: 0x00FE89B8 File Offset: 0x00FE6BB8
		private void RefreshBtnState()
		{
			base.SetButtonUiActive(6, this.CurrentDataIndex > 0);
			base.SetButtonUiActive(7, this.CurrentDataIndex < this.DataList.Count - 1);
		}

		// Token: 0x06038D38 RID: 232760 RVA: 0x00FE89E6 File Offset: 0x00FE6BE6
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolGalleryUpdate, new Action(this.RefreshView));
		}

		// Token: 0x06038D39 RID: 232761 RVA: 0x00FE8A04 File Offset: 0x00FE6C04
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolGalleryUpdate, new Action(this.RefreshView));
		}

		// Token: 0x0401DE83 RID: 122499
		private TItem? ItemGridData;

		// Token: 0x0401DE84 RID: 122500
		[Nullable(2)]
		private SolarSchoolGalleryData CurrentData;

		// Token: 0x0401DE85 RID: 122501
		private int CurrentDataIndex = -1;

		// Token: 0x0401DE86 RID: 122502
		[Nullable(2)]
		private SolarSchoolActivityData ActivityData;

		// Token: 0x0401DE87 RID: 122503
		private List<SolarSchoolGalleryData> DataList = new List<SolarSchoolGalleryData>();

		// Token: 0x0401DE88 RID: 122504
		[Nullable(2)]
		private SimpleGenericLayout StarLayout;

		// Token: 0x0401DE89 RID: 122505
		private CommonItemSmallItemGrid Grid;

		// Token: 0x0401DE8A RID: 122506
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolGalleryEndingConditionItem, int> ConditionLayout;

		// Token: 0x0401DE8B RID: 122507
		[Nullable(2)]
		private SolarSchoolShortCaptionItem CaptionItem;

		// Token: 0x0200B5E9 RID: 46569
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038412 RID: 230418
			public const int CaptionItem = 0;

			// Token: 0x04038413 RID: 230419
			public const int Texture = 1;

			// Token: 0x04038414 RID: 230420
			public const int NameText = 2;

			// Token: 0x04038415 RID: 230421
			public const int StarLayout = 3;

			// Token: 0x04038416 RID: 230422
			public const int StarItem = 4;

			// Token: 0x04038417 RID: 230423
			public const int CompleteNumText = 5;

			// Token: 0x04038418 RID: 230424
			public const int PreBtn = 6;

			// Token: 0x04038419 RID: 230425
			public const int NextBtn = 7;

			// Token: 0x0403841A RID: 230426
			public const int ConditionPanelItem = 8;

			// Token: 0x0403841B RID: 230427
			public const int ConditionLayout = 9;

			// Token: 0x0403841C RID: 230428
			public const int ConditionItem = 10;

			// Token: 0x0403841D RID: 230429
			public const int RewardTitleItem = 11;

			// Token: 0x0403841E RID: 230430
			public const int RewardHasGetItem = 12;

			// Token: 0x0403841F RID: 230431
			public const int RewardItem = 13;

			// Token: 0x04038420 RID: 230432
			public const int NullItem = 14;

			// Token: 0x04038421 RID: 230433
			public const int NoConditionItem = 15;
		}
	}
}
