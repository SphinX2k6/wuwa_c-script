using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonComponentModel;
using CSharpScript.Game.Module.TowerDefence;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel
{
	// Token: 0x02005893 RID: 22675
	[NullableContext(2)]
	[Nullable(0)]
	public class TowerInstanceDungeonViewModel : InstanceDungeonViewModelBase
	{
		// Token: 0x17008A8C RID: 35468
		// (get) Token: 0x06039B35 RID: 236341 RVA: 0x00DB659C File Offset: 0x00DB479C
		// (set) Token: 0x06039B36 RID: 236342 RVA: 0x00DB65A4 File Offset: 0x00DB47A4
		public override RankTimeItemModelBase RankItemModel { get; set; } = new TowerDefenseRankTimeModel();

		// Token: 0x06039B37 RID: 236343 RVA: 0x00DB65B0 File Offset: 0x00DB47B0
		[NullableContext(1)]
		protected unsafe override Dictionary<int, List<int>> GetInstanceByTitleMap()
		{
			Dictionary<int, int> sortedByTitleEntranceInstanceIdList = TowerDefenseModel.Instance.GetSortedByTitleEntranceInstanceIdList();
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (KeyValuePair<int, int> keyValuePair in sortedByTitleEntranceInstanceIdList)
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int num3 = num;
				int num4 = num2;
				List<int> value;
				if (!dictionary.TryGetValue(num4, out value))
				{
					value = new List<int>();
					dictionary[num4] = value;
				}
				Dictionary<int, List<int>> dictionary2 = dictionary;
				int key = num4;
				List<int> list = dictionary[num4];
				num2 = 1 + list.Count;
				List<int> list2 = new List<int>(num2);
				CollectionsMarshal.SetCount<int>(list2, num2);
				Span<int> span = CollectionsMarshal.AsSpan<int>(list2);
				num = 0;
				Span<int> span2 = CollectionsMarshal.AsSpan<int>(list);
				span2.CopyTo(span.Slice(num, span2.Length));
				num += span2.Length;
				*span[num] = num3;
				dictionary2[key] = list2;
			}
			return dictionary;
		}

		// Token: 0x06039B38 RID: 236344 RVA: 0x00DB66A8 File Offset: 0x00DB48A8
		[NullableContext(1)]
		protected override void OnSortInstanceArray(List<int> instanceArray)
		{
			instanceArray.Sort(delegate(int aInstanceId, int bInstanceId)
			{
				TowerDefenceInstance? towerDefenseInstanceByInstance = InstanceDungeonConfig.Instance.GetTowerDefenseInstanceByInstance(aInstanceId);
				TowerDefenceInstance? towerDefenseInstanceByInstance2 = InstanceDungeonConfig.Instance.GetTowerDefenseInstanceByInstance(bInstanceId);
				if (towerDefenseInstanceByInstance != null && towerDefenseInstanceByInstance2 != null)
				{
					return towerDefenseInstanceByInstance.Value.Difficulty - towerDefenseInstanceByInstance2.Value.Difficulty;
				}
				return 0;
			});
		}

		// Token: 0x06039B39 RID: 236345 RVA: 0x00DB66D0 File Offset: 0x00DB48D0
		[NullableContext(1)]
		protected override string OnGetInstanceItemTextureBg(int instanceId)
		{
			TowerDefenceInstance? towerDefenseInstanceByInstance = InstanceDungeonConfig.Instance.GetTowerDefenseInstanceByInstance(instanceId);
			if (towerDefenseInstanceByInstance != null && towerDefenseInstanceByInstance.Value.IsDifficult)
			{
				return "T_TogHoldDeathmatch";
			}
			return "T_TogListNor";
		}

		// Token: 0x06039B3A RID: 236346 RVA: 0x00DB6710 File Offset: 0x00DB4910
		protected override TableTextArgNew OnGetUnlockConditionTextId(int instanceId)
		{
			int[] unlockCondition = InstanceDungeonConfig.Instance.GetUnlockCondition(instanceId);
			TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(unlockCondition[2]);
			if (TowerDefenseModel.Instance.PhantomMessageCache.IsStageUnLocked(towerDefenseConfigById.Value.InstanceId))
			{
				return new TableTextArgNew("OnlineGymnasium_LevelRst", Array.Empty<object>());
			}
			string text = TowerDefenseController.Instance.BuildInstanceCountDownTextParam(instanceId);
			if (text != null)
			{
				return new TableTextArgNew("OnlineGymnasium_LevelRst", new <>z__ReadOnlySingleElementList<object>(text));
			}
			return null;
		}

		// Token: 0x06039B3B RID: 236347 RVA: 0x00DB6788 File Offset: 0x00DB4988
		protected override bool OnIsFinishInstance(int instanceId)
		{
			return TowerDefenseController.Instance.CheckInstancePassedByInstanceId(instanceId);
		}

		// Token: 0x06039B3C RID: 236348 RVA: 0x00DB6795 File Offset: 0x00DB4995
		[NullableContext(1)]
		protected override string OnGetInstanceDetectItemIcon(int instanceId)
		{
			return "";
		}

		// Token: 0x06039B3D RID: 236349 RVA: 0x00DB679C File Offset: 0x00DB499C
		protected override InstanceDungeonEntranceViewSelectData OnGetDefaultSelectData()
		{
			if (TowerDefenseController.Instance.CheckInUiFlow())
			{
				int suitableInstanceId = TowerDefenseController.Instance.GetSuitableInstanceId();
				InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(suitableInstanceId);
				if (config != null)
				{
					return new InstanceDungeonEntranceViewSelectData
					{
						InstanceId = suitableInstanceId,
						SeriesId = config.Value.Title
					};
				}
			}
			return null;
		}

		// Token: 0x06039B3E RID: 236350 RVA: 0x00DB67F8 File Offset: 0x00DB49F8
		protected override bool OnCheckNeedOnTimer(int instanceId)
		{
			return TowerDefenseController.Instance.CheckInUiFlow() && !TowerDefenseController.Instance.CheckIsInstanceUnlock(instanceId);
		}

		// Token: 0x06039B3F RID: 236351 RVA: 0x00DB6816 File Offset: 0x00DB4A16
		protected override void OnTimerRefreshFunction(float delta)
		{
			this.View.RefreshTowerDefenseInstance();
		}

		// Token: 0x06039B40 RID: 236352 RVA: 0x00DB6824 File Offset: 0x00DB4A24
		protected override UniTask OnRequestServerData()
		{
			TowerInstanceDungeonViewModel.<OnRequestServerData>d__13 <OnRequestServerData>d__;
			<OnRequestServerData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnRequestServerData>d__.<>4__this = this;
			<OnRequestServerData>d__.<>1__state = -1;
			<OnRequestServerData>d__.<>t__builder.Start<TowerInstanceDungeonViewModel.<OnRequestServerData>d__13>(ref <OnRequestServerData>d__);
			return <OnRequestServerData>d__.<>t__builder.Task;
		}

		// Token: 0x06039B41 RID: 236353 RVA: 0x00DB6867 File Offset: 0x00DB4A67
		protected override bool OnCheckInstanceHasRedDot(int instanceId)
		{
			return TowerDefenseModel.Instance.CheckTowerDefenseInstanceHasRedDot(instanceId);
		}
	}
}
