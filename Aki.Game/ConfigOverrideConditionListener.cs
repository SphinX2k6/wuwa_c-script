using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020023F1 RID: 9201
[NullableContext(1)]
[Nullable(0)]
public class ConfigOverrideConditionListener : IClear
{
	// Token: 0x060170AA RID: 94378 RVA: 0x006BA8F8 File Offset: 0x006B8AF8
	public IConfigOverrideRule ResolveOverrideConfigRule(List<IConfigOverrideRule> configOverrides)
	{
		if (configOverrides == null || configOverrides.Count == 0)
		{
			return null;
		}
		foreach (IConfigOverrideRule configOverrideRule in configOverrides)
		{
			if (this.EvaluateOverrideCondition(configOverrideRule))
			{
				return configOverrideRule;
			}
		}
		return null;
	}

	// Token: 0x060170AB RID: 94379 RVA: 0x006BA95C File Offset: 0x006B8B5C
	public long? GetCurrentConfigId(int listenerId)
	{
		ConfigOverrideConditionListener.ConfigOverrideListenerRuntime configOverrideListenerRuntime;
		if (this.listenerMap.TryGetValue(listenerId, out configOverrideListenerRuntime))
		{
			return configOverrideListenerRuntime.CurrentOverrideConfigId;
		}
		return null;
	}

	// Token: 0x060170AC RID: 94380 RVA: 0x006BA98C File Offset: 0x006B8B8C
	public ConfigOverrideConditionListener.ConfigOverrideListenerRegistration AddListener(List<IConfigOverrideRule> configOverrides, Action callback, bool triggerOnRegister, long currentOverrideConfigId)
	{
		if (configOverrides == null || configOverrides.Count == 0)
		{
			return null;
		}
		HashSet<EConfigOverrideConditionType> hashSet = new HashSet<EConfigOverrideConditionType>();
		foreach (IConfigOverrideRule configOverrideRule in configOverrides)
		{
			hashSet.Add(configOverrideRule.ConditionType);
		}
		foreach (EConfigOverrideConditionType conditionType in hashSet)
		{
			this.RegisterConditionListener(conditionType);
		}
		int num = this.listenerIdGenerator + 1;
		this.listenerIdGenerator = num;
		int num2 = num;
		ConfigOverrideConditionListener.ConfigOverrideListenerRuntime configOverrideListenerRuntime = new ConfigOverrideConditionListener.ConfigOverrideListenerRuntime
		{
			ListenerId = num2,
			ConditionTypes = hashSet,
			CurrentOverrideConfigId = new long?(currentOverrideConfigId),
			ConfigOverrides = new List<IConfigOverrideRule>(configOverrides),
			Callback = callback
		};
		this.listenerMap[num2] = configOverrideListenerRuntime;
		if (triggerOnRegister && callback != null)
		{
			callback();
		}
		return new ConfigOverrideConditionListener.ConfigOverrideListenerRegistration
		{
			ListenerId = configOverrideListenerRuntime.ListenerId
		};
	}

	// Token: 0x060170AD RID: 94381 RVA: 0x006BAAA8 File Offset: 0x006B8CA8
	public ConfigOverrideConditionListener.ConfigOverrideListenerRegistration RemoveListener(int listenerId)
	{
		ConfigOverrideConditionListener.ConfigOverrideListenerRuntime configOverrideListenerRuntime;
		if (!this.listenerMap.TryGetValue(listenerId, out configOverrideListenerRuntime))
		{
			return null;
		}
		this.listenerMap.Remove(listenerId);
		foreach (EConfigOverrideConditionType conditionType in configOverrideListenerRuntime.ConditionTypes)
		{
			this.UnregisterConditionListener(conditionType);
		}
		return new ConfigOverrideConditionListener.ConfigOverrideListenerRegistration
		{
			ListenerId = configOverrideListenerRuntime.ListenerId
		};
	}

	// Token: 0x060170AE RID: 94382 RVA: 0x006BAB2C File Offset: 0x006B8D2C
	public void Clear()
	{
		this.listenerMap.Clear();
		foreach (KeyValuePair<EConfigOverrideConditionType, int> keyValuePair in this.conditionListenerCountMap)
		{
			if (keyValuePair.Value > 0)
			{
				this.UnregisterConditionEvent(keyValuePair.Key);
			}
		}
		this.conditionListenerCountMap.Clear();
	}

	// Token: 0x060170AF RID: 94383 RVA: 0x006BABA8 File Offset: 0x006B8DA8
	public bool ClearObject()
	{
		return true;
	}

	// Token: 0x060170B0 RID: 94384 RVA: 0x006BABAC File Offset: 0x006B8DAC
	private bool EvaluateOverrideCondition(IConfigOverrideRule overrideRule)
	{
		if (overrideRule.ConditionType != EConfigOverrideConditionType.FormationRoleHasTag)
		{
			return false;
		}
		string[] array = overrideRule.ConditionString.Split('#', StringSplitOptions.None);
		if (array.Length < 2)
		{
			return false;
		}
		if (int.Parse(array[0]) != 1)
		{
			return false;
		}
		string tagName = array[1];
		return this.CheckFormationRoleHasTag(tagName);
	}

	// Token: 0x060170B1 RID: 94385 RVA: 0x006BABF4 File Offset: 0x006B8DF4
	private bool CheckFormationRoleHasTag(string tagName)
	{
		List<EntityHandle> teamEntities = SceneTeamModel.Instance.GetTeamEntities(false);
		int i = 0;
		int count = teamEntities.Count;
		while (i < count)
		{
			WorldEntity entity = teamEntities[i].Entity;
			object obj = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
			object obj2 = obj;
			if (obj2 != null && obj2.HasTag(tagIdByName))
			{
				return true;
			}
			i++;
		}
		return false;
	}

	// Token: 0x060170B2 RID: 94386 RVA: 0x006BAC54 File Offset: 0x006B8E54
	private void RegisterConditionListener(EConfigOverrideConditionType conditionType)
	{
		int num;
		this.conditionListenerCountMap.TryGetValue(conditionType, out num);
		if (!this.conditionListenerCountMap.ContainsKey(conditionType))
		{
			num = 0;
		}
		if (num == 0)
		{
			this.RegisterConditionEvent(conditionType);
		}
		this.conditionListenerCountMap[conditionType] = num + 1;
	}

	// Token: 0x060170B3 RID: 94387 RVA: 0x006BAC99 File Offset: 0x006B8E99
	private void RegisterConditionEvent(EConfigOverrideConditionType conditionType)
	{
		if (conditionType == EConfigOverrideConditionType.FormationRoleHasTag)
		{
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationConditionChanged));
		}
	}

	// Token: 0x060170B4 RID: 94388 RVA: 0x006BACBC File Offset: 0x006B8EBC
	private void UnregisterConditionListener(EConfigOverrideConditionType conditionType)
	{
		int num;
		if (!this.conditionListenerCountMap.TryGetValue(conditionType, out num) || num <= 0)
		{
			return;
		}
		int num2 = num - 1;
		this.conditionListenerCountMap[conditionType] = num2;
		if (num2 == 0)
		{
			this.UnregisterConditionEvent(conditionType);
		}
	}

	// Token: 0x060170B5 RID: 94389 RVA: 0x006BACF9 File Offset: 0x006B8EF9
	private void UnregisterConditionEvent(EConfigOverrideConditionType conditionType)
	{
		if (conditionType == EConfigOverrideConditionType.FormationRoleHasTag)
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationConditionChanged));
		}
	}

	// Token: 0x060170B6 RID: 94390 RVA: 0x006BAD1B File Offset: 0x006B8F1B
	private void OnFormationConditionChanged()
	{
		this.DispatchFormationListeners();
	}

	// Token: 0x060170B7 RID: 94391 RVA: 0x006BAD24 File Offset: 0x006B8F24
	private void DispatchFormationListeners()
	{
		foreach (KeyValuePair<int, ConfigOverrideConditionListener.ConfigOverrideListenerRuntime> keyValuePair in this.listenerMap)
		{
			if (keyValuePair.Value.ConditionTypes.Contains(EConfigOverrideConditionType.FormationRoleHasTag))
			{
				this.DispatchListeners(new List<int>
				{
					keyValuePair.Key
				});
			}
		}
	}

	// Token: 0x060170B8 RID: 94392 RVA: 0x006BAD9C File Offset: 0x006B8F9C
	private void DispatchListeners(List<int> listenerIds)
	{
		foreach (int key in listenerIds)
		{
			ConfigOverrideConditionListener.ConfigOverrideListenerRuntime configOverrideListenerRuntime;
			if (this.listenerMap.TryGetValue(key, out configOverrideListenerRuntime))
			{
				IConfigOverrideRule configOverrideRule = this.ResolveOverrideConfigRule(configOverrideListenerRuntime.ConfigOverrides);
				long? num = (configOverrideRule != null) ? new long?(configOverrideRule.OverrideConfigId) : null;
				long? num2 = num;
				long? currentOverrideConfigId = configOverrideListenerRuntime.CurrentOverrideConfigId;
				if (!(num2.GetValueOrDefault() == currentOverrideConfigId.GetValueOrDefault() & num2 != null == (currentOverrideConfigId != null)))
				{
					configOverrideListenerRuntime.CurrentOverrideConfigId = num;
					Action callback = configOverrideListenerRuntime.Callback;
					if (callback != null)
					{
						callback();
					}
				}
			}
		}
	}

	// Token: 0x0400C1CD RID: 49613
	private readonly Dictionary<int, ConfigOverrideConditionListener.ConfigOverrideListenerRuntime> listenerMap = new Dictionary<int, ConfigOverrideConditionListener.ConfigOverrideListenerRuntime>();

	// Token: 0x0400C1CE RID: 49614
	private int listenerIdGenerator;

	// Token: 0x0400C1CF RID: 49615
	private readonly Dictionary<EConfigOverrideConditionType, int> conditionListenerCountMap = new Dictionary<EConfigOverrideConditionType, int>();

	// Token: 0x020087FF RID: 34815
	[Nullable(0)]
	public class ConfigOverrideRule : IConfigOverrideRule
	{
		// Token: 0x17007848 RID: 30792
		// (get) Token: 0x06042541 RID: 271681 RVA: 0x013B82A3 File Offset: 0x013B64A3
		// (set) Token: 0x06042542 RID: 271682 RVA: 0x013B82AB File Offset: 0x013B64AB
		public long OverrideConfigId { get; set; }

		// Token: 0x17007849 RID: 30793
		// (get) Token: 0x06042543 RID: 271683 RVA: 0x013B82B4 File Offset: 0x013B64B4
		// (set) Token: 0x06042544 RID: 271684 RVA: 0x013B82BC File Offset: 0x013B64BC
		public EConfigOverrideConditionType ConditionType { get; set; }

		// Token: 0x1700784A RID: 30794
		// (get) Token: 0x06042545 RID: 271685 RVA: 0x013B82C5 File Offset: 0x013B64C5
		// (set) Token: 0x06042546 RID: 271686 RVA: 0x013B82CD File Offset: 0x013B64CD
		public string ConditionString { get; set; }
	}

	// Token: 0x02008800 RID: 34816
	[Nullable(0)]
	private class ConfigOverrideListenerRuntime
	{
		// Token: 0x1700784B RID: 30795
		// (get) Token: 0x06042548 RID: 271688 RVA: 0x013B82DE File Offset: 0x013B64DE
		// (set) Token: 0x06042549 RID: 271689 RVA: 0x013B82E6 File Offset: 0x013B64E6
		public int ListenerId { get; set; }

		// Token: 0x1700784C RID: 30796
		// (get) Token: 0x0604254A RID: 271690 RVA: 0x013B82EF File Offset: 0x013B64EF
		// (set) Token: 0x0604254B RID: 271691 RVA: 0x013B82F7 File Offset: 0x013B64F7
		public HashSet<EConfigOverrideConditionType> ConditionTypes { get; set; }

		// Token: 0x1700784D RID: 30797
		// (get) Token: 0x0604254C RID: 271692 RVA: 0x013B8300 File Offset: 0x013B6500
		// (set) Token: 0x0604254D RID: 271693 RVA: 0x013B8308 File Offset: 0x013B6508
		public long? CurrentOverrideConfigId { get; set; }

		// Token: 0x1700784E RID: 30798
		// (get) Token: 0x0604254E RID: 271694 RVA: 0x013B8311 File Offset: 0x013B6511
		// (set) Token: 0x0604254F RID: 271695 RVA: 0x013B8319 File Offset: 0x013B6519
		public List<IConfigOverrideRule> ConfigOverrides { get; set; }

		// Token: 0x1700784F RID: 30799
		// (get) Token: 0x06042550 RID: 271696 RVA: 0x013B8322 File Offset: 0x013B6522
		// (set) Token: 0x06042551 RID: 271697 RVA: 0x013B832A File Offset: 0x013B652A
		public Action Callback { get; set; }
	}

	// Token: 0x02008801 RID: 34817
	[NullableContext(0)]
	public class ConfigOverrideListenerRegistration
	{
		// Token: 0x17007850 RID: 30800
		// (get) Token: 0x06042553 RID: 271699 RVA: 0x013B833B File Offset: 0x013B653B
		// (set) Token: 0x06042554 RID: 271700 RVA: 0x013B8343 File Offset: 0x013B6543
		public int ListenerId { get; set; }
	}
}
