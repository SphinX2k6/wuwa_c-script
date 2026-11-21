using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelEntityAbility
{
	// Token: 0x02006133 RID: 24883
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEntityAbilityContainer
	{
		// Token: 0x0603B98B RID: 244107 RVA: 0x010E7128 File Offset: 0x010E5328
		public LevelEntityAbilityContainer(Entity Entity)
		{
			this.Entity = Entity;
			for (int i = 0; i < 2; i++)
			{
				this.PhaseBuckets.Add(new List<LevelEntityAbilityBase>());
			}
		}

		// Token: 0x0603B98C RID: 244108 RVA: 0x010E71A0 File Offset: 0x010E53A0
		public void Destroy()
		{
			foreach (ELevelEntityAbilityType elevelEntityAbilityType in this.ActivatedAbilities)
			{
				try
				{
					LevelEntityAbilityBase valueOrDefault = this.Abilities.GetValueOrDefault(elevelEntityAbilityType);
					if (valueOrDefault != null)
					{
						valueOrDefault.OnDeactivated(this.Entity);
					}
				}
				catch (Exception err)
				{
					this.LogAbilityError("LevelEntityAbility Deactivated执行异常", elevelEntityAbilityType, err);
				}
			}
			foreach (KeyValuePair<ELevelEntityAbilityType, LevelEntityAbilityBase> keyValuePair in this.Abilities)
			{
				this.UnregisterEvents(keyValuePair.Key);
				keyValuePair.Value.OnDestroy(this.Entity);
			}
			this.ActivatedAbilities.Clear();
			this.Abilities.Clear();
			this.AbilityEventHandlers.Clear();
			this.BlockedAbilities.Clear();
			this.BlockedTagMap.Clear();
			this.SortedDirty = false;
			foreach (List<LevelEntityAbilityBase> list in this.PhaseBuckets)
			{
				list.Clear();
			}
		}

		// Token: 0x0603B98D RID: 244109 RVA: 0x010E7300 File Offset: 0x010E5500
		public bool AddAbilities(List<ELevelEntityAbilityType> types)
		{
			foreach (ELevelEntityAbilityType type in types)
			{
				if (!this.AddAbility(type))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603B98E RID: 244110 RVA: 0x010E7358 File Offset: 0x010E5558
		public bool AddAbility(ELevelEntityAbilityType type)
		{
			if (this.Abilities.ContainsKey(type))
			{
				return true;
			}
			LevelEntityAbilityBase levelEntityAbilityBase = LevelEntityAbilityCenter.Instance.CreateAbility(type);
			if (levelEntityAbilityBase == null || !levelEntityAbilityBase.OnAddAbility(this.Entity))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Capability;
				ELogAuthor author = ELogAuthor.LYY;
				string message = "LevelEntityAbility AddAbility失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.Abilities[type] = levelEntityAbilityBase;
			this.SortedDirty = true;
			this.RegisterEvents(type);
			if (this.IsAbilityBlocked(type))
			{
				this.BlockedAbilities.Add(type);
				return true;
			}
			this.SafeEvaluateAbility(levelEntityAbilityBase);
			return true;
		}

		// Token: 0x0603B98F RID: 244111 RVA: 0x010E7400 File Offset: 0x010E5600
		public void RemoveAbilities(List<ELevelEntityAbilityType> types)
		{
			foreach (ELevelEntityAbilityType type in types)
			{
				this.RemoveAbility(type);
			}
		}

		// Token: 0x0603B990 RID: 244112 RVA: 0x010E7450 File Offset: 0x010E5650
		public void RemoveAbility(ELevelEntityAbilityType type)
		{
			if (!this.Abilities.ContainsKey(type))
			{
				return;
			}
			if (this.ActivatedAbilities.Contains(type))
			{
				this.ActivatedAbilities.Remove(type);
				try
				{
					LevelEntityAbilityBase valueOrDefault = this.Abilities.GetValueOrDefault(type);
					if (valueOrDefault != null)
					{
						valueOrDefault.OnDeactivated(this.Entity);
					}
				}
				catch (Exception err)
				{
					this.LogAbilityError("LevelEntityAbility Deactivated执行异常", type, err);
				}
			}
			this.UnregisterEvents(type);
			this.Abilities.Remove(type);
			this.BlockedAbilities.Remove(type);
			this.SortedDirty = true;
		}

		// Token: 0x0603B991 RID: 244113 RVA: 0x010E74F0 File Offset: 0x010E56F0
		public void BlockAbilities(int tag, ELevelEntityAbilityBlockKey key)
		{
			HashSet<ELevelEntityAbilityBlockKey> hashSet = this.BlockedTagMap.GetValueOrDefault(tag);
			if (hashSet == null)
			{
				hashSet = new HashSet<ELevelEntityAbilityBlockKey>();
				this.BlockedTagMap[tag] = hashSet;
			}
			int count = hashSet.Count;
			if (hashSet.Contains(key))
			{
				return;
			}
			hashSet.Add(key);
			if (count > 0)
			{
				return;
			}
			this.RefreshBlockAbilities(tag);
		}

		// Token: 0x0603B992 RID: 244114 RVA: 0x010E7548 File Offset: 0x010E5748
		public void UnblockAbilities(int tag, ELevelEntityAbilityBlockKey key)
		{
			HashSet<ELevelEntityAbilityBlockKey> valueOrDefault = this.BlockedTagMap.GetValueOrDefault(tag);
			if (valueOrDefault == null || !valueOrDefault.Contains(key))
			{
				return;
			}
			valueOrDefault.Remove(key);
			if (valueOrDefault.Count == 0)
			{
				this.BlockedTagMap.Remove(tag);
				this.RefreshBlockAbilities(tag);
			}
		}

		// Token: 0x0603B993 RID: 244115 RVA: 0x010E7594 File Offset: 0x010E5794
		private void RefreshBlockAbilities(int tag)
		{
			IReadOnlySet<ELevelEntityAbilityType> abilitiesByBlockTag = LevelEntityAbilityCenter.Instance.GetAbilitiesByBlockTag(tag);
			if (abilitiesByBlockTag == null)
			{
				return;
			}
			foreach (ELevelEntityAbilityType elevelEntityAbilityType in abilitiesByBlockTag)
			{
				LevelEntityAbilityBase valueOrDefault = this.Abilities.GetValueOrDefault(elevelEntityAbilityType);
				if (valueOrDefault != null)
				{
					if (!this.IsAbilityBlocked(elevelEntityAbilityType))
					{
						if (this.BlockedAbilities.Remove(elevelEntityAbilityType))
						{
							this.SafeEvaluateAbility(valueOrDefault);
						}
					}
					else if (!this.BlockedAbilities.Contains(elevelEntityAbilityType))
					{
						this.BlockedAbilities.Add(elevelEntityAbilityType);
						try
						{
							this.UpdateAbilityActivate(valueOrDefault, false);
						}
						catch (Exception err)
						{
							this.LogAbilityError("LevelEntityAbility Deactivated执行异常", elevelEntityAbilityType, err);
						}
					}
				}
			}
		}

		// Token: 0x0603B994 RID: 244116 RVA: 0x010E7658 File Offset: 0x010E5858
		private bool IsAbilityBlocked(ELevelEntityAbilityType type)
		{
			ILevelAbilityConfig config = LevelEntityAbilityCenter.Instance.GetConfig(type);
			List<int> list = (config != null) ? config.BlockedTags : null;
			if (list == null)
			{
				return false;
			}
			foreach (int key in list)
			{
				if (this.BlockedTagMap.ContainsKey(key))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603B995 RID: 244117 RVA: 0x010E76D4 File Offset: 0x010E58D4
		private void UpdateAbilityActivate(LevelEntityAbilityBase abilityBase, bool activate)
		{
			ELevelEntityAbilityType type = abilityBase.Type;
			if (activate)
			{
				if (!this.ActivatedAbilities.Contains(type))
				{
					this.ActivatedAbilities.Add(type);
					abilityBase.OnActivated(this.Entity);
				}
				return;
			}
			if (this.ActivatedAbilities.Contains(type))
			{
				this.ActivatedAbilities.Remove(type);
				abilityBase.OnDeactivated(this.Entity);
			}
		}

		// Token: 0x0603B996 RID: 244118 RVA: 0x010E773C File Offset: 0x010E593C
		private void EvaluateAbility(LevelEntityAbilityBase abilityBase)
		{
			ELevelEntityAbilityType type = abilityBase.Type;
			if (this.ActivatedAbilities.Contains(type))
			{
				if (abilityBase.ShouldDeactivate(this.Entity))
				{
					this.UpdateAbilityActivate(abilityBase, false);
					return;
				}
			}
			else if (abilityBase.ShouldActivate(this.Entity))
			{
				this.UpdateAbilityActivate(abilityBase, true);
			}
		}

		// Token: 0x0603B997 RID: 244119 RVA: 0x010E778C File Offset: 0x010E598C
		private void SafeEvaluateAbility(LevelEntityAbilityBase abilityBase)
		{
			try
			{
				this.EvaluateAbility(abilityBase);
			}
			catch (Exception err)
			{
				this.LogAbilityError("LevelEntityAbility Evaluate执行异常", abilityBase.Type, err);
			}
		}

		// Token: 0x0603B998 RID: 244120 RVA: 0x010E77C8 File Offset: 0x010E59C8
		private void RegisterEvents(ELevelEntityAbilityType type)
		{
			ILevelAbilityConfig config = LevelEntityAbilityCenter.Instance.GetConfig(type);
			List<EEventName> list = (config != null) ? config.Events : null;
			if (list == null)
			{
				return;
			}
			Entity entity = this.Entity;
			if (entity == null)
			{
				return;
			}
			Delegate @delegate = new Action(delegate()
			{
				this.RequestEvaluate(type);
			});
			this.AbilityEventHandlers[type] = @delegate;
			foreach (EEventName name in list)
			{
				EventSystem.Instance.AddWithTarget(entity, name, @delegate);
			}
		}

		// Token: 0x0603B999 RID: 244121 RVA: 0x010E7880 File Offset: 0x010E5A80
		private void UnregisterEvents(ELevelEntityAbilityType type)
		{
			Delegate valueOrDefault = this.AbilityEventHandlers.GetValueOrDefault(type);
			if (valueOrDefault == null)
			{
				return;
			}
			Entity entity = this.Entity;
			ILevelAbilityConfig config = LevelEntityAbilityCenter.Instance.GetConfig(type);
			List<EEventName> list = (config != null) ? config.Events : null;
			if (entity != null && list != null)
			{
				foreach (EEventName name in list)
				{
					EventSystem.Instance.RemoveWithTarget(entity, name, valueOrDefault);
				}
			}
			this.AbilityEventHandlers.Remove(type);
		}

		// Token: 0x0603B99A RID: 244122 RVA: 0x010E791C File Offset: 0x010E5B1C
		private void RequestEvaluate(ELevelEntityAbilityType type)
		{
			if (this.BlockedAbilities.Contains(type))
			{
				return;
			}
			LevelEntityAbilityBase valueOrDefault = this.Abilities.GetValueOrDefault(type);
			if (valueOrDefault == null)
			{
				return;
			}
			this.SafeEvaluateAbility(valueOrDefault);
		}

		// Token: 0x0603B99B RID: 244123 RVA: 0x010E7950 File Offset: 0x010E5B50
		private unsafe void LogAbilityError(string message, ELevelEntityAbilityType type, [Nullable(2)] object err)
		{
			Exception ex = err as Exception;
			if (ex != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Capability;
				ELogAuthor author = ELogAuthor.LYY;
				Exception error = ex;
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("type", type);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "entity";
				Entity entity = this.Entity;
				ptr = new ValueTuple<string, object>(item, (entity != null) ? new int?(entity.Id) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("error", ex.Message);
				instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Capability;
			ELogAuthor author2 = ELogAuthor.LYY;
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("type", type);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
			string item2 = "entity";
			Entity entity2 = this.Entity;
			ptr2 = new ValueTuple<string, object>(item2, (entity2 != null) ? new int?(entity2.Id) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("error", (err != null) ? err.ToString() : null);
			instance2.Error(module2, author2, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}

		// Token: 0x0603B99C RID: 244124 RVA: 0x010E7AA0 File Offset: 0x010E5CA0
		public void Tick(float deltaMilliseconds)
		{
			this.RunPhase(EAbilityTickPhase.Tick, deltaMilliseconds);
		}

		// Token: 0x0603B99D RID: 244125 RVA: 0x010E7AAA File Offset: 0x010E5CAA
		public void AfterTick(float deltaMilliseconds)
		{
			this.RunPhase(EAbilityTickPhase.AfterTick, deltaMilliseconds);
		}

		// Token: 0x0603B99E RID: 244126 RVA: 0x010E7AB4 File Offset: 0x010E5CB4
		private void RunPhase(EAbilityTickPhase phase, float deltaMilliseconds)
		{
			if (this.Abilities.Count == 0)
			{
				return;
			}
			List<LevelEntityAbilityBase> phaseList = this.GetPhaseList(phase);
			if (phaseList.Count == 0)
			{
				return;
			}
			foreach (LevelEntityAbilityBase levelEntityAbilityBase in phaseList)
			{
				ELevelEntityAbilityType type = levelEntityAbilityBase.Type;
				if (this.Abilities.ContainsKey(type) && !this.BlockedAbilities.Contains(type))
				{
					try
					{
						if (levelEntityAbilityBase.NeedTickActivate)
						{
							this.EvaluateAbility(levelEntityAbilityBase);
						}
						if (this.ActivatedAbilities.Contains(type))
						{
							levelEntityAbilityBase.OnTick(this.Entity, deltaMilliseconds);
						}
					}
					catch (Exception err)
					{
						this.LogAbilityError("LevelEntityAbility Run执行异常", type, err);
					}
				}
			}
		}

		// Token: 0x0603B99F RID: 244127 RVA: 0x010E7B88 File Offset: 0x010E5D88
		private List<LevelEntityAbilityBase> GetPhaseList(EAbilityTickPhase phase)
		{
			if (this.SortedDirty)
			{
				this.RebuildPhaseBuckets();
				this.SortedDirty = false;
			}
			return this.PhaseBuckets[(int)phase];
		}

		// Token: 0x0603B9A0 RID: 244128 RVA: 0x010E7BAC File Offset: 0x010E5DAC
		private void RebuildPhaseBuckets()
		{
			foreach (List<LevelEntityAbilityBase> list in this.PhaseBuckets)
			{
				list.Clear();
			}
			foreach (LevelEntityAbilityBase levelEntityAbilityBase in this.Abilities.Values)
			{
				if (levelEntityAbilityBase.NeedTickActivate || levelEntityAbilityBase.NeedTick)
				{
					this.PhaseBuckets[(int)levelEntityAbilityBase.TickPhase].Add(levelEntityAbilityBase);
				}
			}
			using (List<List<LevelEntityAbilityBase>>.Enumerator enumerator = this.PhaseBuckets.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.Sort((LevelEntityAbilityBase a, LevelEntityAbilityBase b) => a.TickOrder - b.TickOrder);
				}
			}
		}

		// Token: 0x0401F6D1 RID: 128721
		private readonly Dictionary<ELevelEntityAbilityType, LevelEntityAbilityBase> Abilities = new Dictionary<ELevelEntityAbilityType, LevelEntityAbilityBase>();

		// Token: 0x0401F6D2 RID: 128722
		private readonly List<List<LevelEntityAbilityBase>> PhaseBuckets = new List<List<LevelEntityAbilityBase>>();

		// Token: 0x0401F6D3 RID: 128723
		private bool SortedDirty;

		// Token: 0x0401F6D4 RID: 128724
		private readonly Dictionary<int, HashSet<ELevelEntityAbilityBlockKey>> BlockedTagMap = new Dictionary<int, HashSet<ELevelEntityAbilityBlockKey>>();

		// Token: 0x0401F6D5 RID: 128725
		private readonly HashSet<ELevelEntityAbilityType> ActivatedAbilities = new HashSet<ELevelEntityAbilityType>();

		// Token: 0x0401F6D6 RID: 128726
		private readonly HashSet<ELevelEntityAbilityType> BlockedAbilities = new HashSet<ELevelEntityAbilityType>();

		// Token: 0x0401F6D7 RID: 128727
		private readonly Dictionary<ELevelEntityAbilityType, Delegate> AbilityEventHandlers = new Dictionary<ELevelEntityAbilityType, Delegate>();

		// Token: 0x0401F6D8 RID: 128728
		private readonly Entity Entity;
	}
}
