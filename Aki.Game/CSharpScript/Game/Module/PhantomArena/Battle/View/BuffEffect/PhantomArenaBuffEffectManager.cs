using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.BuffEffect
{
	// Token: 0x0200424E RID: 16974
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBuffEffectManager
	{
		// Token: 0x0602AF25 RID: 175909 RVA: 0x00C157A8 File Offset: 0x00C139A8
		public PhantomArenaBuffEffectManager(PhantomArenaBattleProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x0602AF26 RID: 175910 RVA: 0x00C157B8 File Offset: 0x00C139B8
		public UniTask ShowSkillEffect()
		{
			PhantomArenaBuffEffectManager.<ShowSkillEffect>d__2 <ShowSkillEffect>d__;
			<ShowSkillEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowSkillEffect>d__.<>4__this = this;
			<ShowSkillEffect>d__.<>1__state = -1;
			<ShowSkillEffect>d__.<>t__builder.Start<PhantomArenaBuffEffectManager.<ShowSkillEffect>d__2>(ref <ShowSkillEffect>d__);
			return <ShowSkillEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF27 RID: 175911 RVA: 0x00C157FC File Offset: 0x00C139FC
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

		// Token: 0x0602AF28 RID: 175912 RVA: 0x00C15848 File Offset: 0x00C13A48
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

		// Token: 0x0602AF29 RID: 175913 RVA: 0x00C15894 File Offset: 0x00C13A94
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

		// Token: 0x0602AF2A RID: 175914 RVA: 0x00C158E0 File Offset: 0x00C13AE0
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

		// Token: 0x0602AF2B RID: 175915 RVA: 0x00C1592C File Offset: 0x00C13B2C
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

		// Token: 0x0602AF2C RID: 175916 RVA: 0x00C15980 File Offset: 0x00C13B80
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

		// Token: 0x0602AF2D RID: 175917 RVA: 0x00C159D4 File Offset: 0x00C13BD4
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

		// Token: 0x0602AF2E RID: 175918 RVA: 0x00C15A20 File Offset: 0x00C13C20
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

		// Token: 0x0602AF2F RID: 175919 RVA: 0x00C15A6C File Offset: 0x00C13C6C
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

		// Token: 0x0602AF30 RID: 175920 RVA: 0x00C15AB8 File Offset: 0x00C13CB8
		private UniTask PhantomBattleTakeTargetAttrEffectContext(IBuffEffectData info)
		{
			PhantomBattleEffectResultInfo effect = info.Effect;
			if (((effect != null) ? effect.PhantomBattleTakeTargetAttrEffectCtx : null) != null)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "触发获取目标属性效果", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (info.Effect.PhantomBattleTakeTargetAttrEffectCtx.Camp == PhantomBattleEffectCardCamp.GamerFighterPlayer)
				{
					PhantomArenaOwnData ownData = PhantomArenaBattleModel.Instance.OwnData;
					NpcPhantomBattleCardAttrInfo takeAttrInfo = info.Effect.PhantomBattleTakeTargetAttrEffectCtx.TakeAttrInfo;
					ownData.RefreshCardAttr(info.Effect.PhantomBattleTakeTargetAttrEffectCtx.TargetUid, new Dictionary<int, int>(takeAttrInfo.BattleStatus));
				}
				else if (info.Effect.PhantomBattleTakeTargetAttrEffectCtx.Camp == PhantomBattleEffectCardCamp.GamerFighterNpc)
				{
					PhantomArenaOpponentData opponentData = PhantomArenaBattleModel.Instance.OpponentData;
					NpcPhantomBattleCardAttrInfo takeAttrInfo2 = info.Effect.PhantomBattleTakeTargetAttrEffectCtx.TakeAttrInfo;
					opponentData.RefreshCardAttr(info.Effect.PhantomBattleTakeTargetAttrEffectCtx.TargetUid, new Dictionary<int, int>(takeAttrInfo2.BattleStatus));
				}
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x0602AF31 RID: 175921 RVA: 0x00C15BA0 File Offset: 0x00C13DA0
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

		// Token: 0x0602AF32 RID: 175922 RVA: 0x00C15BEC File Offset: 0x00C13DEC
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

		// Token: 0x0602AF33 RID: 175923 RVA: 0x00C15C38 File Offset: 0x00C13E38
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

		// Token: 0x0602AF34 RID: 175924 RVA: 0x00C15C84 File Offset: 0x00C13E84
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

		// Token: 0x0602AF35 RID: 175925 RVA: 0x00C15CD0 File Offset: 0x00C13ED0
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

		// Token: 0x0602AF36 RID: 175926 RVA: 0x00C15D1C File Offset: 0x00C13F1C
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

		// Token: 0x040173CF RID: 95183
		public PhantomArenaBattleProxy Proxy;
	}
}
