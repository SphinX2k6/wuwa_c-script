using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Roguelike;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel
{
	// Token: 0x02004869 RID: 18537
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeDungeonViewModel : InstanceDungeonViewModelBase
	{
		// Token: 0x0602EA4E RID: 191054 RVA: 0x00D050F0 File Offset: 0x00D032F0
		public override UniTask OnBeforeStartAsync()
		{
			RoguelikeDungeonViewModel.<OnBeforeStartAsync>d__1 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeDungeonViewModel.<OnBeforeStartAsync>d__1>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EA4F RID: 191055 RVA: 0x00D05134 File Offset: 0x00D03334
		private UniTask CreateRoguelikeBtnPanel()
		{
			RoguelikeDungeonViewModel.<CreateRoguelikeBtnPanel>d__2 <CreateRoguelikeBtnPanel>d__;
			<CreateRoguelikeBtnPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRoguelikeBtnPanel>d__.<>4__this = this;
			<CreateRoguelikeBtnPanel>d__.<>1__state = -1;
			<CreateRoguelikeBtnPanel>d__.<>t__builder.Start<RoguelikeDungeonViewModel.<CreateRoguelikeBtnPanel>d__2>(ref <CreateRoguelikeBtnPanel>d__);
			return <CreateRoguelikeBtnPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602EA50 RID: 191056 RVA: 0x00D05178 File Offset: 0x00D03378
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public override ValueTuple<InstanceDetectionDynamicData[], int> GetDiyInstanceDetectionDynamicData(int currentSeriesId, int currentInstanceId)
		{
			int num = 0;
			List<InstanceDetectionDynamicData> list = new List<InstanceDetectionDynamicData>();
			ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
			RogueSeasonData rogueSeasonData = (currentActivityData != null) ? currentActivityData.SeasonData : null;
			if (rogueSeasonData == null)
			{
				return new ValueTuple<InstanceDetectionDynamicData[], int>(list.ToArray(), num);
			}
			RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(rogueSeasonData.SeasonId);
			if (rogueSeasonConfigById == null)
			{
				return new ValueTuple<InstanceDetectionDynamicData[], int>(list.ToArray(), num);
			}
			bool flag = false;
			for (int i = 0; i < rogueSeasonConfigById.Value.InstanceDungeonListLength; i++)
			{
				DicIntIntArray value = rogueSeasonConfigById.Value.InstanceDungeonList(i).Value;
				int key = value.Key;
				IntArray? value2 = value.Value;
				list.Add(new InstanceDetectionDynamicData
				{
					InstanceGirdId = key,
					IsSelect = false,
					IsShow = true,
					ExtraType = EInstanceDetectionExtraType.TextOnly,
					ExtraText = (RoguelikeDungeonViewModel.GetInstanceDungeonTypeNameByKey(rogueSeasonConfigById.Value, key) ?? "")
				});
				if (!flag)
				{
					num++;
				}
				foreach (int num2 in value2.Value.GetArrayIntArray())
				{
					InstanceDetectionDynamicData instanceDetectionDynamicData = new InstanceDetectionDynamicData();
					instanceDetectionDynamicData.InstanceGirdId = num2;
					instanceDetectionDynamicData.IsSelect = (num2 == currentInstanceId);
					instanceDetectionDynamicData.IsShow = true;
					list.Add(instanceDetectionDynamicData);
					if (instanceDetectionDynamicData.IsSelect)
					{
						flag = true;
					}
					if (!flag)
					{
						num++;
					}
				}
			}
			return new ValueTuple<InstanceDetectionDynamicData[], int>(list.ToArray(), num);
		}

		// Token: 0x0602EA51 RID: 191057 RVA: 0x00D05300 File Offset: 0x00D03500
		public override void OnBeforeDestroy()
		{
			RoguelikeInstanceBtnPanel roguelikeBtnPanel = this.RoguelikeBtnPanel;
			if (roguelikeBtnPanel == null)
			{
				return;
			}
			roguelikeBtnPanel.UnBindRedDot();
		}

		// Token: 0x0602EA52 RID: 191058 RVA: 0x00D05314 File Offset: 0x00D03514
		private static string GetInstanceDungeonTypeNameByKey(RogueSeason season, int typeId)
		{
			for (int i = 0; i < season.InstanceDungeonTypeNameLength; i++)
			{
				DicIntString? dicIntString = season.InstanceDungeonTypeName(i);
				if (dicIntString != null && dicIntString.GetValueOrDefault().Key == typeId)
				{
					return dicIntString.Value.Value;
				}
			}
			return null;
		}

		// Token: 0x0602EA53 RID: 191059 RVA: 0x00D05370 File Offset: 0x00D03570
		protected override InstanceDungeonEntranceViewSelectData OnGetDefaultSelectData()
		{
			ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
			RogueSeasonData rogueSeasonData = (currentActivityData != null) ? currentActivityData.SeasonData : null;
			if (rogueSeasonData == null)
			{
				return null;
			}
			RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(rogueSeasonData.SeasonId);
			if (rogueSeasonConfigById == null)
			{
				return null;
			}
			int num = 0;
			bool flag = true;
			for (int i = 0; i < rogueSeasonConfigById.Value.InstanceDungeonListLength; i++)
			{
				int[] array = rogueSeasonConfigById.Value.InstanceDungeonList(i).Value.Value.Value.ArrayInt();
				foreach (int instanceId in array)
				{
					if (!ExchangeRewardModel.Instance.IsFinishInstance(instanceId))
					{
						flag = false;
						break;
					}
				}
				num = array[array.Length - 1];
			}
			if (!flag)
			{
				return null;
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(num);
			return new InstanceDungeonEntranceViewSelectData
			{
				InstanceId = num,
				SeriesId = config.Value.Title
			};
		}

		// Token: 0x04018CE1 RID: 101601
		private RoguelikeInstanceBtnPanel RoguelikeBtnPanel;
	}
}
