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
	// Token: 0x0200486B RID: 18539
	[NullableContext(2)]
	[Nullable(0)]
	public class TowerInstanceDungeonViewModel : InstanceDungeonViewModelBase
	{
		// Token: 0x17005E58 RID: 24152
		// (get) Token: 0x0602EA58 RID: 191064 RVA: 0x00D054B4 File Offset: 0x00D036B4
		// (set) Token: 0x0602EA59 RID: 191065 RVA: 0x00D054BC File Offset: 0x00D036BC
		public override RankTimeItemModelBase RankItemModel { get; set; } = new TowerDefenseRankTimeModel();

		// Token: 0x0602EA5A RID: 191066 RVA: 0x00D054C8 File Offset: 0x00D036C8
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

		// Token: 0x0602EA5B RID: 191067 RVA: 0x00D055C0 File Offset: 0x00D037C0
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

		// Token: 0x0602EA5C RID: 191068 RVA: 0x00D055E8 File Offset: 0x00D037E8
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

		// Token: 0x0602EA5D RID: 191069 RVA: 0x00D05628 File Offset: 0x00D03828
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

		// Token: 0x0602EA5E RID: 191070 RVA: 0x00D056A0 File Offset: 0x00D038A0
		protected override bool OnIsFinishInstance(int instanceId)
		{
			return TowerDefenseController.Instance.CheckInstancePassedByInstanceId(instanceId);
		}

		// Token: 0x0602EA5F RID: 191071 RVA: 0x00D056AD File Offset: 0x00D038AD
		[NullableContext(1)]
		protected override string OnGetInstanceDetectItemIcon(int instanceId)
		{
			return "";
		}

		// Token: 0x0602EA60 RID: 191072 RVA: 0x00D056B4 File Offset: 0x00D038B4
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

		// Token: 0x0602EA61 RID: 191073 RVA: 0x00D05710 File Offset: 0x00D03910
		protected override bool OnCheckNeedOnTimer(int instanceId)
		{
			return TowerDefenseController.Instance.CheckInUiFlow() && !TowerDefenseController.Instance.CheckIsInstanceUnlock(instanceId);
		}

		// Token: 0x0602EA62 RID: 191074 RVA: 0x00D0572E File Offset: 0x00D0392E
		protected override void OnTimerRefreshFunction(float delta)
		{
			this.View.RefreshTowerDefenseInstance();
		}

		// Token: 0x0602EA63 RID: 191075 RVA: 0x00D0573C File Offset: 0x00D0393C
		protected override UniTask OnRequestServerData()
		{
			TowerInstanceDungeonViewModel.<OnRequestServerData>d__13 <OnRequestServerData>d__;
			<OnRequestServerData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnRequestServerData>d__.<>4__this = this;
			<OnRequestServerData>d__.<>1__state = -1;
			<OnRequestServerData>d__.<>t__builder.Start<TowerInstanceDungeonViewModel.<OnRequestServerData>d__13>(ref <OnRequestServerData>d__);
			return <OnRequestServerData>d__.<>t__builder.Task;
		}

		// Token: 0x0602EA64 RID: 191076 RVA: 0x00D0577F File Offset: 0x00D0397F
		protected override bool OnCheckInstanceHasRedDot(int instanceId)
		{
			return TowerDefenseModel.Instance.CheckTowerDefenseInstanceHasRedDot(instanceId);
		}
	}
}
