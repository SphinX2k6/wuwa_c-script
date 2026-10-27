using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.BuffEffect
{
	// Token: 0x0200527E RID: 21118
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBuffEffectManager
	{
		// Token: 0x0603602A RID: 221226 RVA: 0x00CC80A8 File Offset: 0x00CC62A8
		public PhantomArenaBuffEffectManager(PhantomArenaBattleProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x0603602B RID: 221227 RVA: 0x00CC80B8 File Offset: 0x00CC62B8
		public UniTask ShowSkillEffect()
		{
			PhantomArenaBuffEffectManager.<ShowSkillEffect>d__2 <ShowSkillEffect>d__;
			<ShowSkillEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowSkillEffect>d__.<>4__this = this;
			<ShowSkillEffect>d__.<>1__state = -1;
			<ShowSkillEffect>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<ShowSkillEffect>d__2>(ref <ShowSkillEffect>d__);
			return <ShowSkillEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0603602C RID: 221228 RVA: 0x00CC80FC File Offset: 0x00CC62FC
		public UniTask TriggerSkillEffectByNpc(IBuffEffectData effectData)
		{
			PhantomArenaBuffEffectManager.<TriggerSkillEffectByNpc>d__3 <TriggerSkillEffectByNpc>d__;
			<TriggerSkillEffectByNpc>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TriggerSkillEffectByNpc>d__.<>4__this = this;
			<TriggerSkillEffectByNpc>d__.effectData = effectData;
			<TriggerSkillEffectByNpc>d__.<>1__state = -1;
			<TriggerSkillEffectByNpc>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<TriggerSkillEffectByNpc>d__3>(ref <TriggerSkillEffectByNpc>d__);
			return <TriggerSkillEffectByNpc>d__.<>t__builder.Task;
		}

		// Token: 0x0603602D RID: 221229 RVA: 0x00CC8148 File Offset: 0x00CC6348
		private UniTask ExecuteEffectContext(IBuffEffectData effectData)
		{
			PhantomArenaBuffEffectManager.<ExecuteEffectContext>d__4 <ExecuteEffectContext>d__;
			<ExecuteEffectContext>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteEffectContext>d__.<>4__this = this;
			<ExecuteEffectContext>d__.effectData = effectData;
			<ExecuteEffectContext>d__.<>1__state = -1;
			<ExecuteEffectContext>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<ExecuteEffectContext>d__4>(ref <ExecuteEffectContext>d__);
			return <ExecuteEffectContext>d__.<>t__builder.Task;
		}

		// Token: 0x0603602E RID: 221230 RVA: 0x00CC8194 File Offset: 0x00CC6394
		private UniTask PhantomBattleDealEffectContext(IBuffEffectData info)
		{
			PhantomArenaBuffEffectManager.<PhantomBattleDealEffectContext>d__5 <PhantomBattleDealEffectContext>d__;
			<PhantomBattleDealEffectContext>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PhantomBattleDealEffectContext>d__.<>4__this = this;
			<PhantomBattleDealEffectContext>d__.info = info;
			<PhantomBattleDealEffectContext>d__.<>1__state = -1;
			<PhantomBattleDealEffectContext>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<PhantomBattleDealEffectContext>d__5>(ref <PhantomBattleDealEffectContext>d__);
			return <PhantomBattleDealEffectContext>d__.<>t__builder.Task;
		}

		// Token: 0x0603602F RID: 221231 RVA: 0x00CC81E0 File Offset: 0x00CC63E0
		private UniTask NpcPhantomBattleDealEffectContext(IBuffEffectData info)
		{
			PhantomArenaBuffEffectManager.<NpcPhantomBattleDealEffectContext>d__6 <NpcPhantomBattleDealEffectContext>d__;
			<NpcPhantomBattleDealEffectContext>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NpcPhantomBattleDealEffectContext>d__.<>4__this = this;
			<NpcPhantomBattleDealEffectContext>d__.info = info;
			<NpcPhantomBattleDealEffectContext>d__.<>1__state = -1;
			<NpcPhantomBattleDealEffectContext>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<NpcPhantomBattleDealEffectContext>d__6>(ref <NpcPhantomBattleDealEffectContext>d__);
			return <NpcPhantomBattleDealEffectContext>d__.<>t__builder.Task;
		}

		// Token: 0x06036030 RID: 221232 RVA: 0x00CC822C File Offset: 0x00CC642C
		private UniTask PhantomBattleAddBuffEffectContext(IBuffEffectData info)
		{
			PhantomBattleEffectResultInfo effect = info.Effect;
			if (((effect != null) ? effect.PhantomBattleAddBuffEffectCtx : null) != null)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "触发添加buff效果", default(ReadOnlySpan<ValueTuple<string, object>>));
				new PhantomArenaBuffEffectAddBuff(info, this).ShowBuffEffect();
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x06036031 RID: 221233 RVA: 0x00CC8280 File Offset: 0x00CC6480
		private UniTask PhantomBattleCardSelectEffectContext(IBuffEffectData info)
		{
			PhantomBattleEffectResultInfo effect = info.Effect;
			if (((effect != null) ? effect.PhantomBattleCardSelectEffectCtx : null) != null)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "触发选牌效果", default(ReadOnlySpan<ValueTuple<string, object>>));
				new PhantomArenaBuffEffectChooseCard(info, this).ShowChooseCard();
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x06036032 RID: 221234 RVA: 0x00CC82D4 File Offset: 0x00CC64D4
		private UniTask NpcPhantomBattleCardSelectEffectContext(IBuffEffectData info)
		{
			PhantomArenaBuffEffectManager.<NpcPhantomBattleCardSelectEffectContext>d__9 <NpcPhantomBattleCardSelectEffectContext>d__;
			<NpcPhantomBattleCardSelectEffectContext>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NpcPhantomBattleCardSelectEffectContext>d__.<>4__this = this;
			<NpcPhantomBattleCardSelectEffectContext>d__.info = info;
			<NpcPhantomBattleCardSelectEffectContext>d__.<>1__state = -1;
			<NpcPhantomBattleCardSelectEffectContext>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<NpcPhantomBattleCardSelectEffectContext>d__9>(ref <NpcPhantomBattleCardSelectEffectContext>d__);
			return <NpcPhantomBattleCardSelectEffectContext>d__.<>t__builder.Task;
		}

		// Token: 0x06036033 RID: 221235 RVA: 0x00CC8320 File Offset: 0x00CC6520
		private UniTask PhantomBattleCopyCardEffectContext(IBuffEffectData info)
		{
			PhantomArenaBuffEffectManager.<PhantomBattleCopyCardEffectContext>d__10 <PhantomBattleCopyCardEffectContext>d__;
			<PhantomBattleCopyCardEffectContext>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PhantomBattleCopyCardEffectContext>d__.<>4__this = this;
			<PhantomBattleCopyCardEffectContext>d__.info = info;
			<PhantomBattleCopyCardEffectContext>d__.<>1__state = -1;
			<PhantomBattleCopyCardEffectContext>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<PhantomBattleCopyCardEffectContext>d__10>(ref <PhantomBattleCopyCardEffectContext>d__);
			return <PhantomBattleCopyCardEffectContext>d__.<>t__builder.Task;
		}

		// Token: 0x06036034 RID: 221236 RVA: 0x00CC836C File Offset: 0x00CC656C
		private UniTask PhantomBattleDestroyCardEffectContext(IBuffEffectData info)
		{
			PhantomArenaBuffEffectManager.<PhantomBattleDestroyCardEffectContext>d__11 <PhantomBattleDestroyCardEffectContext>d__;
			<PhantomBattleDestroyCardEffectContext>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PhantomBattleDestroyCardEffectContext>d__.<>4__this = this;
			<PhantomBattleDestroyCardEffectContext>d__.info = info;
			<PhantomBattleDestroyCardEffectContext>d__.<>1__state = -1;
			<PhantomBattleDestroyCardEffectContext>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<PhantomBattleDestroyCardEffectContext>d__11>(ref <PhantomBattleDestroyCardEffectContext>d__);
			return <PhantomBattleDestroyCardEffectContext>d__.<>t__builder.Task;
		}

		// Token: 0x06036035 RID: 221237 RVA: 0x00CC83B8 File Offset: 0x00CC65B8
		private UniTask PhantomBattleTakeTargetAttrEffectContext(IBuffEffectData info)
		{
			PhantomBattleEffectResultInfo effect = info.Effect;
			if (((effect != null) ? effect.PhantomBattleTakeTargetAttrEffectCtx : null) != null)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "触发获取目标属性效果", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (info.Effect.PhantomBattleTakeTargetAttrEffectCtx.Camp == PhantomBattleEffectCardCamp.GamerFighterPlayer)
				{
					PhantomArenaBattleModel.Instance.OwnData.RefreshCardAttr(info.Effect.PhantomBattleTakeTargetAttrEffectCtx.TargetUid, info.Effect.PhantomBattleTakeTargetAttrEffectCtx.TakeAttrInfo.BattleStatus.ToDictionary<int, int>());
				}
				else if (info.Effect.PhantomBattleTakeTargetAttrEffectCtx.Camp == PhantomBattleEffectCardCamp.GamerFighterNpc)
				{
					PhantomArenaBattleModel.Instance.OpponentData.RefreshCardAttr(info.Effect.PhantomBattleTakeTargetAttrEffectCtx.TargetUid, info.Effect.PhantomBattleTakeTargetAttrEffectCtx.TakeAttrInfo.BattleStatus.ToDictionary<int, int>());
				}
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x06036036 RID: 221238 RVA: 0x00CC849C File Offset: 0x00CC669C
		private UniTask PhantomBattleCallCardEffectContext(IBuffEffectData info)
		{
			PhantomArenaBuffEffectManager.<PhantomBattleCallCardEffectContext>d__13 <PhantomBattleCallCardEffectContext>d__;
			<PhantomBattleCallCardEffectContext>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PhantomBattleCallCardEffectContext>d__.<>4__this = this;
			<PhantomBattleCallCardEffectContext>d__.info = info;
			<PhantomBattleCallCardEffectContext>d__.<>1__state = -1;
			<PhantomBattleCallCardEffectContext>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<PhantomBattleCallCardEffectContext>d__13>(ref <PhantomBattleCallCardEffectContext>d__);
			return <PhantomBattleCallCardEffectContext>d__.<>t__builder.Task;
		}

		// Token: 0x06036037 RID: 221239 RVA: 0x00CC84E8 File Offset: 0x00CC66E8
		private UniTask HandleNpcFieldSealEffect(NpcPhantomBattleAreaLockEffectCtx effectContext)
		{
			PhantomArenaBuffEffectManager.<HandleNpcFieldSealEffect>d__14 <HandleNpcFieldSealEffect>d__;
			<HandleNpcFieldSealEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleNpcFieldSealEffect>d__.<>4__this = this;
			<HandleNpcFieldSealEffect>d__.effectContext = effectContext;
			<HandleNpcFieldSealEffect>d__.<>1__state = -1;
			<HandleNpcFieldSealEffect>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<HandleNpcFieldSealEffect>d__14>(ref <HandleNpcFieldSealEffect>d__);
			return <HandleNpcFieldSealEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06036038 RID: 221240 RVA: 0x00CC8534 File Offset: 0x00CC6734
		private UniTask HandleOwnFieldSealEffect(NpcPhantomBattleAreaLockEffectCtx context)
		{
			PhantomArenaBuffEffectManager.<HandleOwnFieldSealEffect>d__15 <HandleOwnFieldSealEffect>d__;
			<HandleOwnFieldSealEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleOwnFieldSealEffect>d__.<>4__this = this;
			<HandleOwnFieldSealEffect>d__.context = context;
			<HandleOwnFieldSealEffect>d__.<>1__state = -1;
			<HandleOwnFieldSealEffect>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<HandleOwnFieldSealEffect>d__15>(ref <HandleOwnFieldSealEffect>d__);
			return <HandleOwnFieldSealEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06036039 RID: 221241 RVA: 0x00CC8580 File Offset: 0x00CC6780
		private UniTask NpcPhantomBattleAreaLockEffectContext(IBuffEffectData info)
		{
			PhantomArenaBuffEffectManager.<NpcPhantomBattleAreaLockEffectContext>d__16 <NpcPhantomBattleAreaLockEffectContext>d__;
			<NpcPhantomBattleAreaLockEffectContext>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NpcPhantomBattleAreaLockEffectContext>d__.<>4__this = this;
			<NpcPhantomBattleAreaLockEffectContext>d__.info = info;
			<NpcPhantomBattleAreaLockEffectContext>d__.<>1__state = -1;
			<NpcPhantomBattleAreaLockEffectContext>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<NpcPhantomBattleAreaLockEffectContext>d__16>(ref <NpcPhantomBattleAreaLockEffectContext>d__);
			return <NpcPhantomBattleAreaLockEffectContext>d__.<>t__builder.Task;
		}

		// Token: 0x0603603A RID: 221242 RVA: 0x00CC85CC File Offset: 0x00CC67CC
		private UniTask PhantomBattleDirectDamage(IBuffEffectData info)
		{
			PhantomArenaBuffEffectManager.<PhantomBattleDirectDamage>d__17 <PhantomBattleDirectDamage>d__;
			<PhantomBattleDirectDamage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PhantomBattleDirectDamage>d__.<>4__this = this;
			<PhantomBattleDirectDamage>d__.info = info;
			<PhantomBattleDirectDamage>d__.<>1__state = -1;
			<PhantomBattleDirectDamage>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<PhantomBattleDirectDamage>d__17>(ref <PhantomBattleDirectDamage>d__);
			return <PhantomBattleDirectDamage>d__.<>t__builder.Task;
		}

		// Token: 0x0603603B RID: 221243 RVA: 0x00CC8618 File Offset: 0x00CC6818
		private UniTask PhantomBattleReconstruct(IBuffEffectData info)
		{
			PhantomArenaBuffEffectManager.<PhantomBattleReconstruct>d__18 <PhantomBattleReconstruct>d__;
			<PhantomBattleReconstruct>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PhantomBattleReconstruct>d__.<>4__this = this;
			<PhantomBattleReconstruct>d__.info = info;
			<PhantomBattleReconstruct>d__.<>1__state = -1;
			<PhantomBattleReconstruct>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<PhantomBattleReconstruct>d__18>(ref <PhantomBattleReconstruct>d__);
			return <PhantomBattleReconstruct>d__.<>t__builder.Task;
		}

		// Token: 0x0401C99A RID: 117146
		public PhantomArenaBattleProxy Proxy;
	}
}
