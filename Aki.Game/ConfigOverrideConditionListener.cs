using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002E9E RID: 11934
[NullableContext(1)]
[Nullable(0)]
public class ConfigOverrideConditionListener : IClear
{
	// Token: 0x060197D4 RID: 104404 RVA: 0x00694538 File Offset: 0x00692738
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

	// Token: 0x060197D5 RID: 104405 RVA: 0x0069459C File Offset: 0x0069279C
	public long? GetCurrentConfigId(int listenerId)
	{
		ConfigOverrideConditionListener.ConfigOverrideListenerRuntime configOverrideListenerRuntime;
		if (this.listenerMap.TryGetValue(listenerId, out configOverrideListenerRuntime))
		{
			return configOverrideListenerRuntime.CurrentOverrideConfigId;
		}
		return null;
	}

	// Token: 0x060197D6 RID: 104406 RVA: 0x006945CC File Offset: 0x006927CC
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

	// Token: 0x060197D7 RID: 104407 RVA: 0x006946E8 File Offset: 0x006928E8
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

	// Token: 0x060197D8 RID: 104408 RVA: 0x0069476C File Offset: 0x0069296C
	public void Clear()
	{
		this.listenerMap.Clear();
		foreach (KeyValuePair<EConfigOverrideConditionType, int> keyValuePair in this.conditionListenerCountMap.ToList<KeyValuePair<EConfigOverrideConditionType, int>>())
		{
			if (keyValuePair.Value > 0)
			{
				this.UnregisterConditionEvent(keyValuePair.Key);
			}
		}
		this.conditionListenerCountMap.Clear();
	}

	// Token: 0x060197D9 RID: 104409 RVA: 0x006947EC File Offset: 0x006929EC
	public bool ClearObject()
	{
		return true;
	}

	// Token: 0x060197DA RID: 104410 RVA: 0x006947F0 File Offset: 0x006929F0
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

	// Token: 0x060197DB RID: 104411 RVA: 0x00694838 File Offset: 0x00692A38
	private bool CheckFormationRoleHasTag(string tagName)
	{
		return SceneTeamModel.Instance.GetTeamEntities(false).Any(delegate(EntityHandle entityHandle)
		{
			WorldEntity entity = entityHandle.Entity;
			object obj = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
			object obj2 = obj;
			return obj2 != null && obj2.HasTag(tagIdByName);
		});
	}

	// Token: 0x060197DC RID: 104412 RVA: 0x00694870 File Offset: 0x00692A70
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

	// Token: 0x060197DD RID: 104413 RVA: 0x006948B5 File Offset: 0x00692AB5
	private void RegisterConditionEvent(EConfigOverrideConditionType conditionType)
	{
		if (conditionType == EConfigOverrideConditionType.FormationRoleHasTag)
		{
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationConditionChanged));
		}
	}

	// Token: 0x060197DE RID: 104414 RVA: 0x006948D8 File Offset: 0x00692AD8
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

	// Token: 0x060197DF RID: 104415 RVA: 0x00694915 File Offset: 0x00692B15
	private void UnregisterConditionEvent(EConfigOverrideConditionType conditionType)
	{
		if (conditionType == EConfigOverrideConditionType.FormationRoleHasTag)
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationConditionChanged));
		}
	}

	// Token: 0x060197E0 RID: 104416 RVA: 0x00694937 File Offset: 0x00692B37
	private void OnFormationConditionChanged()
	{
		this.DispatchFormationListeners();
	}

	// Token: 0x060197E1 RID: 104417 RVA: 0x00694940 File Offset: 0x00692B40
	private void DispatchFormationListeners()
	{
		foreach (KeyValuePair<int, ConfigOverrideConditionListener.ConfigOverrideListenerRuntime> keyValuePair in this.listenerMap.ToList<KeyValuePair<int, ConfigOverrideConditionListener.ConfigOverrideListenerRuntime>>())
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

	// Token: 0x060197E2 RID: 104418 RVA: 0x006949C0 File Offset: 0x00692BC0
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

	// Token: 0x0400BE32 RID: 48690
	private readonly Dictionary<int, ConfigOverrideConditionListener.ConfigOverrideListenerRuntime> listenerMap = new Dictionary<int, ConfigOverrideConditionListener.ConfigOverrideListenerRuntime>();

	// Token: 0x0400BE33 RID: 48691
	private int listenerIdGenerator;

	// Token: 0x0400BE34 RID: 48692
	private readonly Dictionary<EConfigOverrideConditionType, int> conditionListenerCountMap = new Dictionary<EConfigOverrideConditionType, int>();

	// Token: 0x020095D6 RID: 38358
	[Nullable(0)]
	public class ConfigOverrideRule : IConfigOverrideRule
	{
		// Token: 0x1700A0B9 RID: 41145
		// (get) Token: 0x0604C0A6 RID: 311462 RVA: 0x0140D693 File Offset: 0x0140B893
		// (set) Token: 0x0604C0A7 RID: 311463 RVA: 0x0140D69B File Offset: 0x0140B89B
		public long OverrideConfigId { get; set; }

		// Token: 0x1700A0BA RID: 41146
		// (get) Token: 0x0604C0A8 RID: 311464 RVA: 0x0140D6A4 File Offset: 0x0140B8A4
		// (set) Token: 0x0604C0A9 RID: 311465 RVA: 0x0140D6AC File Offset: 0x0140B8AC
		public EConfigOverrideConditionType ConditionType { get; set; }

		// Token: 0x1700A0BB RID: 41147
		// (get) Token: 0x0604C0AA RID: 311466 RVA: 0x0140D6B5 File Offset: 0x0140B8B5
		// (set) Token: 0x0604C0AB RID: 311467 RVA: 0x0140D6BD File Offset: 0x0140B8BD
		public string ConditionString { get; set; }
	}

	// Token: 0x020095D7 RID: 38359
	[Nullable(0)]
	private class ConfigOverrideListenerRuntime
	{
		// Token: 0x1700A0BC RID: 41148
		// (get) Token: 0x0604C0AD RID: 311469 RVA: 0x0140D6CE File Offset: 0x0140B8CE
		// (set) Token: 0x0604C0AE RID: 311470 RVA: 0x0140D6D6 File Offset: 0x0140B8D6
		public int ListenerId { get; set; }

		// Token: 0x1700A0BD RID: 41149
		// (get) Token: 0x0604C0AF RID: 311471 RVA: 0x0140D6DF File Offset: 0x0140B8DF
		// (set) Token: 0x0604C0B0 RID: 311472 RVA: 0x0140D6E7 File Offset: 0x0140B8E7
		public HashSet<EConfigOverrideConditionType> ConditionTypes { get; set; }

		// Token: 0x1700A0BE RID: 41150
		// (get) Token: 0x0604C0B1 RID: 311473 RVA: 0x0140D6F0 File Offset: 0x0140B8F0
		// (set) Token: 0x0604C0B2 RID: 311474 RVA: 0x0140D6F8 File Offset: 0x0140B8F8
		public long? CurrentOverrideConfigId { get; set; }

		// Token: 0x1700A0BF RID: 41151
		// (get) Token: 0x0604C0B3 RID: 311475 RVA: 0x0140D701 File Offset: 0x0140B901
		// (set) Token: 0x0604C0B4 RID: 311476 RVA: 0x0140D709 File Offset: 0x0140B909
		public List<IConfigOverrideRule> ConfigOverrides { get; set; }

		// Token: 0x1700A0C0 RID: 41152
		// (get) Token: 0x0604C0B5 RID: 311477 RVA: 0x0140D712 File Offset: 0x0140B912
		// (set) Token: 0x0604C0B6 RID: 311478 RVA: 0x0140D71A File Offset: 0x0140B91A
		public Action Callback { get; set; }
	}

	// Token: 0x020095D8 RID: 38360
	[NullableContext(0)]
	public class ConfigOverrideListenerRegistration
	{
		// Token: 0x1700A0C1 RID: 41153
		// (get) Token: 0x0604C0B8 RID: 311480 RVA: 0x0140D72B File Offset: 0x0140B92B
		// (set) Token: 0x0604C0B9 RID: 311481 RVA: 0x0140D733 File Offset: 0x0140B933
		public int ListenerId { get; set; }
	}
}
