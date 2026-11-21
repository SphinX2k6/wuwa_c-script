using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005680 RID: 22144
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayDropItemMgr : DropCatchGameplayBaseMgr
	{
		// Token: 0x06036A25 RID: 223781 RVA: 0x00F3F0E0 File Offset: 0x00F3D2E0
		public DropCatchGameplayDropItemMgr(IGameplayLogicContext context) : base(context)
		{
		}

		// Token: 0x06036A26 RID: 223782 RVA: 0x00F3F148 File Offset: 0x00F3D348
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

		// Token: 0x06036A27 RID: 223783 RVA: 0x00F3F394 File Offset: 0x00F3D594
		public override void OnTick(float deltaTime)
		{
			this.UpdateConvertRules(deltaTime);
			this.UpdateDropPools();
			this.UpdateDropItems(deltaTime);
		}

		// Token: 0x06036A28 RID: 223784 RVA: 0x00F3F3AC File Offset: 0x00F3D5AC
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

		// Token: 0x06036A29 RID: 223785 RVA: 0x00F3F518 File Offset: 0x00F3D718
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

		// Token: 0x06036A2A RID: 223786 RVA: 0x00F3F5F8 File Offset: 0x00F3D7F8
		private double GetInitSpawnPosX(IDropPoolRuntime pool, double itemHalfWidth)
		{
			DropCatchDropPool? dropCatchDropPoolById = DropCatchConfig.Instance.GetDropCatchDropPoolById(pool.PoolId);
			if (dropCatchDropPoolById == null || dropCatchDropPoolById.Value.DropInitPosX == this.INVALID_SPAWN_POS_X)
			{
				return MathUtils.Instance.GetRandomRange(this.Context.GetGameplayArea().MinX + itemHalfWidth, this.Context.GetGameplayArea().MaxX - itemHalfWidth);
			}
			return (double)dropCatchDropPoolById.Value.DropInitPosX;
		}

		// Token: 0x06036A2B RID: 223787 RVA: 0x00F3F678 File Offset: 0x00F3D878
		private double GetRandomSpawnPosX(double posInterval, double lastPosX, double itemHalfWidth)
		{
			double num = this.Context.GetGameplayArea().MinX + itemHalfWidth;
			double num2 = this.Context.GetGameplayArea().MaxX - itemHalfWidth - num;
			double randomRange = MathUtils.Instance.GetRandomRange(-posInterval, posInterval);
			return ((lastPosX + randomRange - num) % num2 + num2) % num2 + num;
		}

		// Token: 0x06036A2C RID: 223788 RVA: 0x00F3F6C8 File Offset: 0x00F3D8C8
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

		// Token: 0x06036A2D RID: 223789 RVA: 0x00F3F724 File Offset: 0x00F3D924
		private void UpdateDropItems(float deltaTime)
		{
			foreach (IDropItemInstance dropItemInstance in this.ActiveDropItems.Values)
			{
				dropItemInstance.OnTick(deltaTime);
			}
		}

		// Token: 0x06036A2E RID: 223790 RVA: 0x00F3F77C File Offset: 0x00F3D97C
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

		// Token: 0x06036A2F RID: 223791 RVA: 0x00F3F7CC File Offset: 0x00F3D9CC
		[NullableContext(2)]
		public IDropItemInstance GetDropItem(int instanceId)
		{
			IDropItemInstance result;
			this.ActiveDropItems.TryGetValue(instanceId, out result);
			return result;
		}

		// Token: 0x06036A30 RID: 223792 RVA: 0x00F3F7EC File Offset: 0x00F3D9EC
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

		// Token: 0x06036A31 RID: 223793 RVA: 0x00F3F814 File Offset: 0x00F3DA14
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

		// Token: 0x06036A32 RID: 223794 RVA: 0x00F3F86C File Offset: 0x00F3DA6C
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

		// Token: 0x06036A33 RID: 223795 RVA: 0x00F3F96C File Offset: 0x00F3DB6C
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

		// Token: 0x06036A34 RID: 223796 RVA: 0x00F3F9E8 File Offset: 0x00F3DBE8
		public Dictionary<int, IDropPoolRuntime> GetDropPools()
		{
			return this.DropPools;
		}

		// Token: 0x06036A35 RID: 223797 RVA: 0x00F3F9F0 File Offset: 0x00F3DBF0
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

		// Token: 0x0401CDF6 RID: 118262
		private readonly float INVALID_SPAWN_POS_X = 9999f;

		// Token: 0x0401CDF7 RID: 118263
		private readonly Dictionary<int, IDropPoolRuntime> DropPools = new Dictionary<int, IDropPoolRuntime>();

		// Token: 0x0401CDF8 RID: 118264
		private int NextInstanceId = 1;

		// Token: 0x0401CDF9 RID: 118265
		private readonly Dictionary<int, IDropItemInstance> ActiveDropItems = new Dictionary<int, IDropItemInstance>();

		// Token: 0x0401CDFA RID: 118266
		private readonly List<IDropItemInstance> DropItemPool = new List<IDropItemInstance>();

		// Token: 0x0401CDFB RID: 118267
		private int ConvertRuleId;

		// Token: 0x0401CDFC RID: 118268
		private readonly List<int> RuleIdToRemove = new List<int>();

		// Token: 0x0401CDFD RID: 118269
		private readonly Dictionary<int, IConvertRule> ConvertRules = new Dictionary<int, IConvertRule>();

		// Token: 0x0401CDFE RID: 118270
		private readonly List<int> ExpiredPoolIds = new List<int>();
	}
}
