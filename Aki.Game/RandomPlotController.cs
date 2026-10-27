using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.LevelConditions;

// Token: 0x0200273B RID: 10043
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RandomPlotController : ControllerBase
{
	// Token: 0x060149B2 RID: 84402 RVA: 0x00537120 File Offset: 0x00535320
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
		IReadOnlyList<InstanceRandomPlot> configList = ConfigInstanceRandomPlotAll.GetConfigList(true);
		if (configList != null)
		{
			Dictionary<int, int[]> instanceTriggerGroupMap = RandomPlotModel.Instance.InstanceTriggerGroupMap;
			foreach (InstanceRandomPlot instanceRandomPlot in configList)
			{
				int[] activeTriggerGroupIdListArray = instanceRandomPlot.GetActiveTriggerGroupIdListArray();
				instanceTriggerGroupMap[instanceRandomPlot.InstId] = (activeTriggerGroupIdListArray ?? Array.Empty<int>());
			}
		}
		return true;
	}

	// Token: 0x060149B3 RID: 84403 RVA: 0x005371B4 File Offset: 0x005353B4
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
		this.ClearAllCondition();
		RandomPlotModel.Instance.RandomPlotMap.Clear();
		RandomPlotModel.Instance.InstanceTriggerGroupMap.Clear();
		return true;
	}

	// Token: 0x060149B4 RID: 84404 RVA: 0x00537202 File Offset: 0x00535402
	protected override bool OnLeaveLevel()
	{
		RandomPlotModel.Instance.RandomPlotMap.Clear();
		return true;
	}

	// Token: 0x060149B5 RID: 84405 RVA: 0x00537214 File Offset: 0x00535414
	private void OnInstanceChange(int oldInstanceId, int newInstanceId)
	{
		if (oldInstanceId == newInstanceId)
		{
			return;
		}
		this.ClearAllCondition();
		int[] array;
		if (!RandomPlotModel.Instance.InstanceTriggerGroupMap.TryGetValue(newInstanceId, out array) || array == null || array.Length == 0)
		{
			return;
		}
		Dictionary<int, IRandomPlotCondition> dictionary = new Dictionary<int, IRandomPlotCondition>();
		RandomPlotModel.Instance.InstanceConditionMap = dictionary;
		int[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			IReadOnlyList<RandomPlotTrigger> configList = ConfigRandomPlotTriggerByTriggerGroupId.GetConfigList(array2[i], true);
			if (configList != null)
			{
				foreach (RandomPlotTrigger randomPlotTrigger in configList)
				{
					int id = randomPlotTrigger.Id;
					if (!dictionary.ContainsKey(id))
					{
						int triggerCondition = randomPlotTrigger.TriggerCondition;
						bool resetCondition = randomPlotTrigger.ResetCondition;
						ConditionPassCallback conditionPassCallback = new ConditionPassCallback(new TConditionPassCallback(this.OnConditionPass), new object[]
						{
							randomPlotTrigger.RandomPlotId,
							resetCondition,
							id
						});
						LevelConditionRegistry.Instance.RegisterConditionGroup(triggerCondition, conditionPassCallback);
						dictionary[id] = new RandomPlotCondition
						{
							ConditionGroupId = triggerCondition,
							Callback = conditionPassCallback
						};
					}
				}
			}
		}
	}

	// Token: 0x060149B6 RID: 84406 RVA: 0x00537350 File Offset: 0x00535550
	private void OnConditionPass([Nullable(new byte[]
	{
		2,
		1
	})] object[] parameters)
	{
		if (parameters == null)
		{
			return;
		}
		int randomPlotId = (int)parameters[0];
		this.PlayRandomPlot(randomPlotId);
		if (!(bool)parameters[1])
		{
			return;
		}
		int key = (int)parameters[2];
		Dictionary<int, IRandomPlotCondition> instanceConditionMap = RandomPlotModel.Instance.InstanceConditionMap;
		IRandomPlotCondition randomPlotCondition;
		if (instanceConditionMap == null || !instanceConditionMap.TryGetValue(key, out randomPlotCondition) || randomPlotCondition == null)
		{
			return;
		}
		int conditionGroupId = randomPlotCondition.ConditionGroupId;
		ConditionPassCallback callback = randomPlotCondition.Callback;
		LevelConditionRegistry.Instance.UnRegisterConditionGroup(conditionGroupId, callback);
		LevelConditionRegistry.Instance.RegisterConditionGroup(conditionGroupId, callback);
	}

	// Token: 0x060149B7 RID: 84407 RVA: 0x005373D0 File Offset: 0x005355D0
	public void PlayRandomPlot(int randomPlotId)
	{
		RandomPlotItem randomPlotItem;
		if (!RandomPlotModel.Instance.RandomPlotMap.TryGetValue(randomPlotId, out randomPlotItem))
		{
			RandomPlot? config = ConfigRandomPlotById.GetConfig(randomPlotId, true);
			if (config == null)
			{
				return;
			}
			randomPlotItem = RandomPlotItem.Create(config.Value);
			RandomPlotModel.Instance.RandomPlotMap[randomPlotId] = randomPlotItem;
		}
		randomPlotItem.PlayRandomPlot();
	}

	// Token: 0x060149B8 RID: 84408 RVA: 0x00537428 File Offset: 0x00535628
	private void ClearAllCondition()
	{
		Dictionary<int, IRandomPlotCondition> instanceConditionMap = RandomPlotModel.Instance.InstanceConditionMap;
		if (instanceConditionMap != null)
		{
			foreach (IRandomPlotCondition randomPlotCondition in instanceConditionMap.Values)
			{
				LevelConditionRegistry.Instance.UnRegisterConditionGroup(randomPlotCondition.ConditionGroupId, randomPlotCondition.Callback);
			}
			instanceConditionMap.Clear();
		}
		RandomPlotModel.Instance.InstanceConditionMap = null;
	}

	// Token: 0x17001AF8 RID: 6904
	// (get) Token: 0x060149B9 RID: 84409 RVA: 0x005374AC File Offset: 0x005356AC
	public static RandomPlotController Instance
	{
		get
		{
			return RandomPlotController._Instance;
		}
	}

	// Token: 0x060149BA RID: 84410 RVA: 0x005374B3 File Offset: 0x005356B3
	public static RandomPlotController GetOrCreateInstance()
	{
		if (RandomPlotController._Instance == null)
		{
			RandomPlotController.CreateInstance();
		}
		return RandomPlotController._Instance;
	}

	// Token: 0x060149BB RID: 84411 RVA: 0x005374C7 File Offset: 0x005356C7
	public static bool CreateInstance()
	{
		if (RandomPlotController._Instance != null)
		{
			return true;
		}
		RandomPlotController._Instance = new RandomPlotController();
		return true;
	}

	// Token: 0x060149BC RID: 84412 RVA: 0x005374DD File Offset: 0x005356DD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060149BD RID: 84413 RVA: 0x005374DF File Offset: 0x005356DF
	public static void ResetStaticDefaultValue()
	{
		RandomPlotController._Instance = null;
	}

	// Token: 0x060149BE RID: 84414 RVA: 0x005374E7 File Offset: 0x005356E7
	static RandomPlotController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RandomPlotController.CreateStaticDefaultValue), new Action(RandomPlotController.ResetStaticDefaultValue));
	}

	// Token: 0x04009AD5 RID: 39637
	[Nullable(2)]
	private static RandomPlotController _Instance;
}
