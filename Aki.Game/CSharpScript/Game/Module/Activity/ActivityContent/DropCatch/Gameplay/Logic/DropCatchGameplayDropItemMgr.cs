using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006730 RID: 26416
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayDropItemMgr : DropCatchGameplayBaseMgr
	{
		// Token: 0x06041ED9 RID: 270041 RVA: 0x00FFDD14 File Offset: 0x00FFBF14
		public DropCatchGameplayDropItemMgr(IGameplayLogicContext context) : base(context)
		{
		}

		// Token: 0x06041EDA RID: 270042 RVA: 0x00FFDD7C File Offset: 0x00FFBF7C
		public override void Init()
		{
			DropCatchGameplay? gameplayConfig = this.Context.GetProxy().GetGameplayConfig();
			if (gameplayConfig == null)
			{
				Log.Instance.Error(ELogModule.DropCatch, ELogAuthor.CB, "DropCatchGameplayDropItemMgr init failed, gameplayConfig is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.DropPools.Clear();
			this.NextInstanceId = 1;
			foreach (int instanceId in new List<int>(this.ActiveDropItems.Keys))
			{
				this.RecycleDropItem(instanceId);
			}
			this.ConvertRules.Clear();
			this.RuleIdToRemove.Clear();
			this.ConvertRuleId = 0;
			foreach (int num in gameplayConfig.Value.DropPoolListIter())
			{
				DropCatchDropPool? dropCatchDropPoolById = DropCatchConfig.Instance.GetDropCatchDropPoolById(num);
				if (dropCatchDropPoolById != null)
				{
					DropCatchGameplayAttribute spawnTimeInterval = new DropCatchGameplayAttribute("SpawnTimeInterval", dropCatchDropPoolById.Value.DropTimeInterval);
					IDropPoolRuntime dropPoolRuntime = new IDropPoolRuntime
					{
						PoolId = num,
						LastSpawnTime = -1.0,
						SpawnTimeInterval = spawnTimeInterval,
						LastSpawnPosX = 0.0,
						SpawnPosInterval = (double)dropCatchDropPoolById.Value.DropPosInterval,
						AliasTable = DropCatchGameplayHelper.BuildAliasTable(dropCatchDropPoolById.Value.DropItemList())
					};
					dropPoolRuntime.TimeRange.Add((double)(dropCatchDropPoolById.Value.TimeRange(0) * (float)TimeUtil.Instance.InverseMillisecond));
					if (dropCatchDropPoolById.Value.TimeRange().Length > 1)
					{
						dropPoolRuntime.TimeRange.Add(dropPoolRuntime.TimeRange[0] + (double)(dropCatchDropPoolById.Value.TimeRange(1) * (float)TimeUtil.Instance.InverseMillisecond));
					}
					this.DropPools.Add(num, dropPoolRuntime);
				}
			}
		}

		// Token: 0x06041EDB RID: 270043 RVA: 0x00FFDFC8 File Offset: 0x00FFC1C8
		public override void OnTick(float deltaTime)
		{
			this.UpdateConvertRules(deltaTime);
			this.UpdateDropPools();
			this.UpdateDropItems(deltaTime);
		}

		// Token: 0x06041EDC RID: 270044 RVA: 0x00FFDFE0 File Offset: 0x00FFC1E0
		private void UpdateDropPools()
		{
			this.ExpiredPoolIds.Clear();
			float time = this.Context.GetGameplayTimeMgr().GetTime();
			foreach (KeyValuePair<int, IDropPoolRuntime> keyValuePair in this.DropPools)
			{
				int key = keyValuePair.Key;
				IDropPoolRuntime value = keyValuePair.Value;
				if ((double)time >= value.TimeRange[0])
				{
					if (value.TimeRange.Count > 1 && (double)time > value.TimeRange[1])
					{
						this.ExpiredPoolIds.Add(key);
					}
					else if (value.LastSpawnTime == -1.0)
					{
						this.SpawnFromPool(value, true);
						value.LastSpawnTime = (double)time;
					}
					else if ((double)time - value.LastSpawnTime >= (double)(value.SpawnTimeInterval.GetFinalValue() * (float)TimeUtil.Instance.InverseMillisecond))
					{
						this.SpawnFromPool(value, false);
						value.LastSpawnTime = (double)time;
					}
				}
			}
			foreach (int key2 in this.ExpiredPoolIds)
			{
				this.DropPools.Remove(key2);
			}
		}

		// Token: 0x06041EDD RID: 270045 RVA: 0x00FFE14C File Offset: 0x00FFC34C
		private void SpawnFromPool(IDropPoolRuntime pool, bool isFirstTime)
		{
			int num = DropCatchGameplayHelper.SampleFromAliasTable(pool.AliasTable);
			if (num == -1)
			{
				return;
			}
			num = this.ConvertItem(num);
			DropCatchDropItem? dropCatchDropItemById = DropCatchConfig.Instance.GetDropCatchDropItemById(num);
			if (dropCatchDropItemById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DropCatch;
				ELogAuthor author = ELogAuthor.CB;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 1);
				defaultInterpolatedStringHandler.AppendLiteral("SpawnFromPool failed, itemId ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral(" not found in config");
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			float num2 = dropCatchDropItemById.Value.Size(0) / 2f;
			double num3 = isFirstTime ? this.GetInitSpawnPosX(pool, (double)num2) : this.GetRandomSpawnPosX(pool.SpawnPosInterval, pool.LastSpawnPosX, (double)num2);
			this.SpawnDropItem(num, num3, null);
			pool.LastSpawnPosX = num3;
		}

		// Token: 0x06041EDE RID: 270046 RVA: 0x00FFE22C File Offset: 0x00FFC42C
		private double GetInitSpawnPosX(IDropPoolRuntime pool, double itemHalfWidth)
		{
			DropCatchDropPool? dropCatchDropPoolById = DropCatchConfig.Instance.GetDropCatchDropPoolById(pool.PoolId);
			if (dropCatchDropPoolById == null || dropCatchDropPoolById.Value.DropInitPosX == this.INVALID_SPAWN_POS_X)
			{
				return MathUtils.Instance.GetRandomRange(this.Context.GetGameplayArea().MinX + itemHalfWidth, this.Context.GetGameplayArea().MaxX - itemHalfWidth);
			}
			return (double)dropCatchDropPoolById.Value.DropInitPosX;
		}

		// Token: 0x06041EDF RID: 270047 RVA: 0x00FFE2AC File Offset: 0x00FFC4AC
		private double GetRandomSpawnPosX(double posInterval, double lastPosX, double itemHalfWidth)
		{
			double num = this.Context.GetGameplayArea().MinX + itemHalfWidth;
			double num2 = this.Context.GetGameplayArea().MaxX - itemHalfWidth - num;
			double randomRange = MathUtils.Instance.GetRandomRange(-posInterval, posInterval);
			return ((lastPosX + randomRange - num) % num2 + num2) % num2 + num;
		}

		// Token: 0x06041EE0 RID: 270048 RVA: 0x00FFE2FC File Offset: 0x00FFC4FC
		public UniTask SpawnDropItem(int itemId, double posX, double? posY = null)
		{
			DropCatchGameplayDropItemMgr.<SpawnDropItem>d__16 <SpawnDropItem>d__;
			<SpawnDropItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SpawnDropItem>d__.<>4__this = this;
			<SpawnDropItem>d__.itemId = itemId;
			<SpawnDropItem>d__.posX = posX;
			<SpawnDropItem>d__.posY = posY;
			<SpawnDropItem>d__.<>1__state = -1;
			<SpawnDropItem>d__.<>t__builder.Start<DropCatchGameplayDropItemMgr.<SpawnDropItem>d__16>(ref <SpawnDropItem>d__);
			return <SpawnDropItem>d__.<>t__builder.Task;
		}

		// Token: 0x06041EE1 RID: 270049 RVA: 0x00FFE358 File Offset: 0x00FFC558
		private void UpdateDropItems(float deltaTime)
		{
			foreach (IDropItemInstance dropItemInstance in this.ActiveDropItems.Values)
			{
				dropItemInstance.OnTick(deltaTime);
			}
		}

		// Token: 0x06041EE2 RID: 270050 RVA: 0x00FFE3B0 File Offset: 0x00FFC5B0
		public void RecycleDropItem(int instanceId)
		{
			this.Context.GetGameplayCollisionMgr().RemoveCheckCollisionDropItemInstanceId(instanceId);
			IDropItemInstance dropItemInstance;
			if (!this.ActiveDropItems.TryGetValue(instanceId, out dropItemInstance))
			{
				return;
			}
			dropItemInstance.OnRecycle();
			this.DropItemPool.Add(dropItemInstance);
			this.ActiveDropItems.Remove(instanceId);
		}

		// Token: 0x06041EE3 RID: 270051 RVA: 0x00FFE400 File Offset: 0x00FFC600
		[NullableContext(2)]
		public IDropItemInstance GetDropItem(int instanceId)
		{
			IDropItemInstance result;
			this.ActiveDropItems.TryGetValue(instanceId, out result);
			return result;
		}

		// Token: 0x06041EE4 RID: 270052 RVA: 0x00FFE420 File Offset: 0x00FFC620
		[NullableContext(2)]
		public DropCatchGameplayAttribute GetSpawnTimeIntervalAttrByPoolId(int poolId)
		{
			IDropPoolRuntime dropPoolRuntime;
			this.DropPools.TryGetValue(poolId, out dropPoolRuntime);
			if (dropPoolRuntime == null)
			{
				return null;
			}
			return dropPoolRuntime.SpawnTimeInterval;
		}

		// Token: 0x06041EE5 RID: 270053 RVA: 0x00FFE448 File Offset: 0x00FFC648
		public void ConvertDropItem(int[] sourceItemId, int targetItemId, float duration = 0f)
		{
			Dictionary<int, IConvertRule> convertRules = this.ConvertRules;
			int convertRuleId = this.ConvertRuleId;
			this.ConvertRuleId = convertRuleId + 1;
			convertRules.Add(convertRuleId, new IConvertRule
			{
				SourceItemIds = new HashSet<int>(sourceItemId),
				TargetItemId = targetItemId,
				Duration = (double)(duration * (float)TimeUtil.Instance.InverseMillisecond)
			});
		}

		// Token: 0x06041EE6 RID: 270054 RVA: 0x00FFE4A0 File Offset: 0x00FFC6A0
		private void UpdateConvertRules(float deltaTime)
		{
			if (this.ConvertRules.Count == 0)
			{
				return;
			}
			this.RuleIdToRemove.Clear();
			foreach (KeyValuePair<int, IConvertRule> keyValuePair in this.ConvertRules)
			{
				int key = keyValuePair.Key;
				IConvertRule value = keyValuePair.Value;
				if (value.Duration > 0.0)
				{
					value.Duration -= (double)deltaTime;
					if (value.Duration <= 0.0)
					{
						this.RuleIdToRemove.Add(key);
					}
				}
			}
			foreach (int key2 in this.RuleIdToRemove)
			{
				this.ConvertRules.Remove(key2);
			}
		}

		// Token: 0x06041EE7 RID: 270055 RVA: 0x00FFE5A0 File Offset: 0x00FFC7A0
		private int ConvertItem(int itemId)
		{
			if (this.ConvertRules.Count == 0)
			{
				return itemId;
			}
			foreach (IConvertRule convertRule in this.ConvertRules.Values)
			{
				if (convertRule.SourceItemIds.Contains(itemId))
				{
					return convertRule.TargetItemId;
				}
			}
			return itemId;
		}

		// Token: 0x06041EE8 RID: 270056 RVA: 0x00FFE61C File Offset: 0x00FFC81C
		public Dictionary<int, IDropPoolRuntime> GetDropPools()
		{
			return this.DropPools;
		}

		// Token: 0x06041EE9 RID: 270057 RVA: 0x00FFE624 File Offset: 0x00FFC824
		public override void Destroy()
		{
			foreach (IDropItemInstance dropItemInstance in this.ActiveDropItems.Values)
			{
				dropItemInstance.Destroy();
			}
			foreach (IDropItemInstance dropItemInstance2 in this.DropItemPool)
			{
				dropItemInstance2.Destroy();
			}
			this.ActiveDropItems.Clear();
			this.DropItemPool.Clear();
			this.ConvertRules.Clear();
		}

		// Token: 0x0402259D RID: 140701
		private readonly float INVALID_SPAWN_POS_X = 9999f;

		// Token: 0x0402259E RID: 140702
		private readonly Dictionary<int, IDropPoolRuntime> DropPools = new Dictionary<int, IDropPoolRuntime>();

		// Token: 0x0402259F RID: 140703
		private int NextInstanceId = 1;

		// Token: 0x040225A0 RID: 140704
		private readonly Dictionary<int, IDropItemInstance> ActiveDropItems = new Dictionary<int, IDropItemInstance>();

		// Token: 0x040225A1 RID: 140705
		private readonly List<IDropItemInstance> DropItemPool = new List<IDropItemInstance>();

		// Token: 0x040225A2 RID: 140706
		private int ConvertRuleId;

		// Token: 0x040225A3 RID: 140707
		private readonly List<int> RuleIdToRemove = new List<int>();

		// Token: 0x040225A4 RID: 140708
		private readonly Dictionary<int, IConvertRule> ConvertRules = new Dictionary<int, IConvertRule>();

		// Token: 0x040225A5 RID: 140709
		private readonly List<int> ExpiredPoolIds = new List<int>();
	}
}
