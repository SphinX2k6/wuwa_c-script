using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.LevelConditions;

// Token: 0x02001C26 RID: 7206
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RandomPlotController : ControllerBase
{
	// Token: 0x06011E94 RID: 73364 RVA: 0x00545E2C File Offset: 0x0054402C
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

	// Token: 0x06011E95 RID: 73365 RVA: 0x00545EC0 File Offset: 0x005440C0
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
		this.ClearAllCondition();
		RandomPlotModel.Instance.RandomPlotMap.Clear();
		RandomPlotModel.Instance.InstanceTriggerGroupMap.Clear();
		return true;
	}

	// Token: 0x06011E96 RID: 73366 RVA: 0x00545F0E File Offset: 0x0054410E
	protected override bool OnLeaveLevel()
	{
		RandomPlotModel.Instance.RandomPlotMap.Clear();
		return true;
	}

	// Token: 0x06011E97 RID: 73367 RVA: 0x00545F20 File Offset: 0x00544120
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

	// Token: 0x06011E98 RID: 73368 RVA: 0x0054605C File Offset: 0x0054425C
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

	// Token: 0x06011E99 RID: 73369 RVA: 0x005460DC File Offset: 0x005442DC
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

	// Token: 0x06011E9A RID: 73370 RVA: 0x00546134 File Offset: 0x00544334
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

	// Token: 0x17001B30 RID: 6960
	// (get) Token: 0x06011E9B RID: 73371 RVA: 0x005461B8 File Offset: 0x005443B8
	public static RandomPlotController Instance
	{
		get
		{
			return RandomPlotController._Instance;
		}
	}

	// Token: 0x06011E9C RID: 73372 RVA: 0x005461BF File Offset: 0x005443BF
	public static RandomPlotController GetOrCreateInstance()
	{
		if (RandomPlotController._Instance == null)
		{
			RandomPlotController.CreateInstance();
		}
		return RandomPlotController._Instance;
	}

	// Token: 0x06011E9D RID: 73373 RVA: 0x005461D3 File Offset: 0x005443D3
	public static bool CreateInstance()
	{
		if (RandomPlotController._Instance != null)
		{
			return true;
		}
		RandomPlotController._Instance = new RandomPlotController();
		return true;
	}

	// Token: 0x06011E9E RID: 73374 RVA: 0x005461E9 File Offset: 0x005443E9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011E9F RID: 73375 RVA: 0x005461EB File Offset: 0x005443EB
	public static void ResetStaticDefaultValue()
	{
		RandomPlotController._Instance = null;
	}

	// Token: 0x06011EA0 RID: 73376 RVA: 0x005461F3 File Offset: 0x005443F3
	static RandomPlotController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RandomPlotController.CreateStaticDefaultValue), new Action(RandomPlotController.ResetStaticDefaultValue));
	}

	// Token: 0x04009C2D RID: 39981
	[Nullable(2)]
	private static RandomPlotController _Instance;
}
