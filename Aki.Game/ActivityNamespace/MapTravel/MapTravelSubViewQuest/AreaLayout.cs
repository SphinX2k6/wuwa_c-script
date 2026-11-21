using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace ActivityNamespace.MapTravel.MapTravelSubViewQuest
{
	// Token: 0x02002F6A RID: 12138
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class AreaLayout : GridProxyAbstract<MapTravelAreaData>
	{
		// Token: 0x0601CBF6 RID: 117750 RVA: 0x008C6154 File Offset: 0x008C4354
		public AreaLayout(ActivityMapTravelData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0601CBF7 RID: 117751 RVA: 0x008C6164 File Offset: 0x008C4364
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIMultiTemplateLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601CBF8 RID: 117752 RVA: 0x008C620F File Offset: 0x008C440F
		protected override void OnStart()
		{
			this.QuestLayout = new GenericLayout<QuestCardItem, int>(base.GetMultiTemplateLayout(1), new Func<QuestCardItem>(this.InitItem), null, false, true);
		}

		// Token: 0x0601CBF9 RID: 117753 RVA: 0x008C6232 File Offset: 0x008C4432
		private QuestCardItem InitItem()
		{
			return new QuestCardItem(this.ActivityBaseData);
		}

		// Token: 0x0601CBFA RID: 117754 RVA: 0x008C623F File Offset: 0x008C443F
		[NullableContext(2)]
		public UUIItem GetTitleItem()
		{
			return base.GetText(0);
		}

		// Token: 0x0601CBFB RID: 117755 RVA: 0x008C6248 File Offset: 0x008C4448
		public override void Refresh(MapTravelAreaData data, bool isSelected, int gridIndex)
		{
			Area? areaInfo = AreaConfig.Instance.GetAreaInfo(data.AreaId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), areaInfo.Value.Title, Array.Empty<object>());
			int num = 0;
			int num2 = 0;
			List<int> list = new List<int>(data.PhantomTaskIdSet);
			list.Sort(this.ActivityBaseData.SortPhantomQuestItem);
			foreach (int id in list)
			{
				TravelPhantomQuest? questConfig = ActivityMapTravelConfig.Instance.GetQuestConfig(id);
				int questState = (int)QuestNewModel.Instance.GetQuestState(questConfig.Value.QuestId);
				int count = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(questConfig.Value.QuestReward)[0].Count;
				if (questState == 3)
				{
					num += count;
				}
				num2 += count;
			}
			this.QuestLayout.RefreshByData(list, null, true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "TravelPhantomQuest_Progress", new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				num2
			}));
		}

		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x0601CBFC RID: 117756 RVA: 0x008C6388 File Offset: 0x008C4588
		// (set) Token: 0x0601CBFD RID: 117757 RVA: 0x008C6390 File Offset: 0x008C4590
		protected ActivityMapTravelData ActivityBaseData { get; set; }

		// Token: 0x0400F245 RID: 62021
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayout<QuestCardItem, int> QuestLayout;

		// Token: 0x02008C07 RID: 35847
		[NullableContext(0)]
		private class ELayoutDefine
		{
			// Token: 0x0402C5AB RID: 181675
			public const int Title = 0;

			// Token: 0x0402C5AC RID: 181676
			public const int Layout = 1;

			// Token: 0x0402C5AD RID: 181677
			public const int CardItem = 2;

			// Token: 0x0402C5AE RID: 181678
			public const int TxtCount = 3;
		}
	}
}
