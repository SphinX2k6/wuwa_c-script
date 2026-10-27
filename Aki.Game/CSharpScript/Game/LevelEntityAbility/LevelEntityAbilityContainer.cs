using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelEntityAbility
{
	// Token: 0x02006FB2 RID: 28594
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEntityAbilityContainer
	{
		// Token: 0x060457DB RID: 284635 RVA: 0x0113D2FC File Offset: 0x0113B4FC
		public LevelEntityAbilityContainer(Entity Entity)
		{
			this.Entity = Entity;
			for (int i = 0; i < 2; i++)
			{
				this.PhaseBuckets.Add(new List<LevelEntityAbilityBase>());
			}
		}

		// Token: 0x060457DC RID: 284636 RVA: 0x0113D374 File Offset: 0x0113B574
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

		// Token: 0x060457DD RID: 284637 RVA: 0x0113D4D4 File Offset: 0x0113B6D4
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

		// Token: 0x060457DE RID: 284638 RVA: 0x0113D52C File Offset: 0x0113B72C
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

		// Token: 0x060457DF RID: 284639 RVA: 0x0113D5D4 File Offset: 0x0113B7D4
		public void RemoveAbilities(List<ELevelEntityAbilityType> types)
		{
			foreach (ELevelEntityAbilityType type in types)
			{
				this.RemoveAbility(type);
			}
		}

		// Token: 0x060457E0 RID: 284640 RVA: 0x0113D624 File Offset: 0x0113B824
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

		// Token: 0x060457E1 RID: 284641 RVA: 0x0113D6C4 File Offset: 0x0113B8C4
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

		// Token: 0x060457E2 RID: 284642 RVA: 0x0113D71C File Offset: 0x0113B91C
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

		// Token: 0x060457E3 RID: 284643 RVA: 0x0113D768 File Offset: 0x0113B968
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

		// Token: 0x060457E4 RID: 284644 RVA: 0x0113D82C File Offset: 0x0113BA2C
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

		// Token: 0x060457E5 RID: 284645 RVA: 0x0113D8A8 File Offset: 0x0113BAA8
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

		// Token: 0x060457E6 RID: 284646 RVA: 0x0113D910 File Offset: 0x0113BB10
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

		// Token: 0x060457E7 RID: 284647 RVA: 0x0113D960 File Offset: 0x0113BB60
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

		// Token: 0x060457E8 RID: 284648 RVA: 0x0113D99C File Offset: 0x0113BB9C
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

		// Token: 0x060457E9 RID: 284649 RVA: 0x0113DA54 File Offset: 0x0113BC54
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

		// Token: 0x060457EA RID: 284650 RVA: 0x0113DAF0 File Offset: 0x0113BCF0
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

		// Token: 0x060457EB RID: 284651 RVA: 0x0113DB24 File Offset: 0x0113BD24
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

		// Token: 0x060457EC RID: 284652 RVA: 0x0113DC74 File Offset: 0x0113BE74
		public void Tick(float deltaMilliseconds)
		{
			this.RunPhase(EAbilityTickPhase.Tick, deltaMilliseconds);
		}

		// Token: 0x060457ED RID: 284653 RVA: 0x0113DC7E File Offset: 0x0113BE7E
		public void AfterTick(float deltaMilliseconds)
		{
			this.RunPhase(EAbilityTickPhase.AfterTick, deltaMilliseconds);
		}

		// Token: 0x060457EE RID: 284654 RVA: 0x0113DC88 File Offset: 0x0113BE88
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

		// Token: 0x060457EF RID: 284655 RVA: 0x0113DD5C File Offset: 0x0113BF5C
		private List<LevelEntityAbilityBase> GetPhaseList(EAbilityTickPhase phase)
		{
			if (this.SortedDirty)
			{
				this.RebuildPhaseBuckets();
				this.SortedDirty = false;
			}
			return this.PhaseBuckets[(int)phase];
		}

		// Token: 0x060457F0 RID: 284656 RVA: 0x0113DD80 File Offset: 0x0113BF80
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

		// Token: 0x0402441C RID: 148508
		private readonly Dictionary<ELevelEntityAbilityType, LevelEntityAbilityBase> Abilities = new Dictionary<ELevelEntityAbilityType, LevelEntityAbilityBase>();

		// Token: 0x0402441D RID: 148509
		private readonly List<List<LevelEntityAbilityBase>> PhaseBuckets = new List<List<LevelEntityAbilityBase>>();

		// Token: 0x0402441E RID: 148510
		private bool SortedDirty;

		// Token: 0x0402441F RID: 148511
		private readonly Dictionary<int, HashSet<ELevelEntityAbilityBlockKey>> BlockedTagMap = new Dictionary<int, HashSet<ELevelEntityAbilityBlockKey>>();

		// Token: 0x04024420 RID: 148512
		private readonly HashSet<ELevelEntityAbilityType> ActivatedAbilities = new HashSet<ELevelEntityAbilityType>();

		// Token: 0x04024421 RID: 148513
		private readonly HashSet<ELevelEntityAbilityType> BlockedAbilities = new HashSet<ELevelEntityAbilityType>();

		// Token: 0x04024422 RID: 148514
		private readonly Dictionary<ELevelEntityAbilityType, Delegate> AbilityEventHandlers = new Dictionary<ELevelEntityAbilityType, Delegate>();

		// Token: 0x04024423 RID: 148515
		private readonly Entity Entity;
	}
}
