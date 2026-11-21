using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season
{
	// Token: 0x02004F51 RID: 20305
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerSeasonOverviewItem : GridProxyAbstract<int>
	{
		// Token: 0x06032FDD RID: 208861 RVA: 0x00E4A59C File Offset: 0x00E4879C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnSeasonItemClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032FDE RID: 208862 RVA: 0x00E4A818 File Offset: 0x00E48A18
		protected override void OnStart()
		{
			this.MedalLayout = new GenericLayout<WheelTowerSeasonMedalSmallItem, IWheelTowerMedalItemData>(base.GetHorizontalLayout(7), new Func<WheelTowerSeasonMedalSmallItem>(this.CreateMedalItem), base.GetItem(8).GetOwner() as AUIBaseActor, false, true);
			this.ScoreLayout = new GenericLayout<WheelTowerStageMedalSmallItem, IWheelTowerMedalItemData>(base.GetHorizontalLayout(9), new Func<WheelTowerStageMedalSmallItem>(this.CreateScoreItem), base.GetItem(10).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06032FDF RID: 208863 RVA: 0x00E4A88C File Offset: 0x00E48A8C
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.SeasonId = data;
			NewTowerSeason? seasonConfig = WheelTowerConfig.Instance.GetSeasonConfig(data);
			if (seasonConfig == null)
			{
				return;
			}
			this.RefreshSeasonHeader(seasonConfig.Value);
			this.RefreshMedalPanel(data);
			this.SetSelected(isSelected);
		}

		// Token: 0x06032FE0 RID: 208864 RVA: 0x00E4A8D4 File Offset: 0x00E48AD4
		private void RefreshSeasonHeader(NewTowerSeason seasonConfig)
		{
			UUIText text = base.GetText(2);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("S");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.SeasonId);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), seasonConfig.Name, Array.Empty<object>());
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetText(seasonConfig.StartVersionId + "-" + seasonConfig.EndVersionId, true);
			}
			base.SetTextureByPath(seasonConfig.BossPortrait, base.GetTexture(1), null, null);
			int seasonId = this.SeasonId;
			WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
			bool uiactive = seasonId == ((activityData != null) ? activityData.SeasonId : 0);
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			UUIItem item2 = base.GetItem(14);
			if (item2 != null)
			{
				item2.SetUIActive(uiactive);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "NewTower_CurrentSeason", Array.Empty<object>());
		}

		// Token: 0x06032FE1 RID: 208865 RVA: 0x00E4A9E8 File Offset: 0x00E48BE8
		private void RefreshMedalPanel(int seasonId)
		{
			WheelTowerModel instance = WheelTowerModel.Instance;
			List<IWheelTowerMedalGroupData> seasonMedalGroupList = instance.GetSeasonMedalGroupList(seasonId, EWheelTowerMedalType.Season);
			List<IWheelTowerMedalGroupData> seasonMedalGroupList2 = instance.GetSeasonMedalGroupList(seasonId, EWheelTowerMedalType.Stage);
			List<IWheelTowerMedalGroupData> list = this.FilterAchieved(seasonMedalGroupList);
			List<IWheelTowerMedalGroupData> list2 = this.FilterAchieved(seasonMedalGroupList2);
			bool flag = list.Count > 0 || list2.Count > 0;
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			GenericLayout<WheelTowerSeasonMedalSmallItem, IWheelTowerMedalItemData> medalLayout = this.MedalLayout;
			if (medalLayout != null)
			{
				medalLayout.SetActive(list.Count > 0);
			}
			GenericLayout<WheelTowerStageMedalSmallItem, IWheelTowerMedalItemData> scoreLayout = this.ScoreLayout;
			if (scoreLayout != null)
			{
				scoreLayout.SetActive(list2.Count > 0);
			}
			GenericLayout<WheelTowerSeasonMedalSmallItem, IWheelTowerMedalItemData> medalLayout2 = this.MedalLayout;
			if (medalLayout2 != null)
			{
				medalLayout2.RefreshByData(this.BuildItemDataList(list), null, false);
			}
			GenericLayout<WheelTowerStageMedalSmallItem, IWheelTowerMedalItemData> scoreLayout2 = this.ScoreLayout;
			if (scoreLayout2 != null)
			{
				scoreLayout2.RefreshByData(this.BuildItemDataList(list2), null, false);
			}
			bool uiactive = flag && this.AllAchieved(seasonMedalGroupList) && this.AllAchieved(seasonMedalGroupList2);
			UUIItem item3 = base.GetItem(11);
			if (item3 != null)
			{
				item3.SetUIActive(uiactive);
			}
			UUIItem item4 = base.GetItem(15);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(uiactive);
		}

		// Token: 0x06032FE2 RID: 208866 RVA: 0x00E4AB07 File Offset: 0x00E48D07
		public override object GetKey(int data, int displayIndex)
		{
			return this.SeasonId;
		}

		// Token: 0x06032FE3 RID: 208867 RVA: 0x00E4AB14 File Offset: 0x00E48D14
		public void SetSelected(bool selected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, true);
		}

		// Token: 0x06032FE4 RID: 208868 RVA: 0x00E4AB32 File Offset: 0x00E48D32
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06032FE5 RID: 208869 RVA: 0x00E4AB3C File Offset: 0x00E48D3C
		private List<IWheelTowerMedalGroupData> FilterAchieved(IReadOnlyList<IWheelTowerMedalGroupData> groupList)
		{
			List<IWheelTowerMedalGroupData> list = new List<IWheelTowerMedalGroupData>();
			for (int i = 0; i < groupList.Count; i++)
			{
				if (groupList[i].CurrentMedalId != 0)
				{
					list.Add(groupList[i]);
				}
			}
			return list;
		}

		// Token: 0x06032FE6 RID: 208870 RVA: 0x00E4AB7C File Offset: 0x00E48D7C
		private bool AllAchieved(IReadOnlyList<IWheelTowerMedalGroupData> groupList)
		{
			for (int i = 0; i < groupList.Count; i++)
			{
				if (groupList[i].CurrentMedalId == 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06032FE7 RID: 208871 RVA: 0x00E4ABAC File Offset: 0x00E48DAC
		private List<IWheelTowerMedalItemData> BuildItemDataList(IReadOnlyList<IWheelTowerMedalGroupData> groupList)
		{
			List<IWheelTowerMedalItemData> list = new List<IWheelTowerMedalItemData>();
			for (int i = 0; i < groupList.Count; i++)
			{
				list.Add(new WheelTowerMedalItemData
				{
					GroupId = groupList[i].GroupId
				});
			}
			return list;
		}

		// Token: 0x06032FE8 RID: 208872 RVA: 0x00E4ABEE File Offset: 0x00E48DEE
		private WheelTowerSeasonMedalSmallItem CreateMedalItem()
		{
			return new WheelTowerSeasonMedalSmallItem();
		}

		// Token: 0x06032FE9 RID: 208873 RVA: 0x00E4ABF5 File Offset: 0x00E48DF5
		private WheelTowerStageMedalSmallItem CreateScoreItem()
		{
			return new WheelTowerStageMedalSmallItem();
		}

		// Token: 0x06032FEA RID: 208874 RVA: 0x00E4ABFC File Offset: 0x00E48DFC
		private void OnSeasonItemClick(EToggleState state)
		{
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.SeasonId);
		}

		// Token: 0x0401B0E9 RID: 110825
		private int SeasonId;

		// Token: 0x0401B0EA RID: 110826
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WheelTowerSeasonMedalSmallItem, IWheelTowerMedalItemData> MedalLayout;

		// Token: 0x0401B0EB RID: 110827
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WheelTowerStageMedalSmallItem, IWheelTowerMedalItemData> ScoreLayout;

		// Token: 0x0401B0EC RID: 110828
		[Nullable(2)]
		private Action<int> ClickCallback;
	}
}
