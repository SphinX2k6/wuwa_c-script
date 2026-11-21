using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Sequence.NpcPerformState
{
	// Token: 0x02003FF5 RID: 16373
	[NullableContext(1)]
	[Nullable(0)]
	public class HoldingHandsSeqStateHandler : SeqNpcPerformStateHandler
	{
		// Token: 0x170053DA RID: 21466
		// (get) Token: 0x060296FF RID: 169727 RVA: 0x00BAB9F9 File Offset: 0x00BA9BF9
		public override ENpcGroupPerformType PerformType
		{
			get
			{
				return ENpcGroupPerformType.HandInHand;
			}
		}

		// Token: 0x170053DB RID: 21467
		// (get) Token: 0x06029700 RID: 169728 RVA: 0x00BAB9FC File Offset: 0x00BA9BFC
		public override ENpcRelationType RelationType
		{
			get
			{
				return ENpcRelationType.HoldingHands;
			}
		}

		// Token: 0x06029701 RID: 169729 RVA: 0x00BAB9FF File Offset: 0x00BA9BFF
		[return: Nullable(2)]
		public override NpcRelation Capture(string key)
		{
			return HoldingHandsModel.Instance.GetRelation(key);
		}

		// Token: 0x06029702 RID: 169730 RVA: 0x00BABA0C File Offset: 0x00BA9C0C
		public unsafe override void Restore(NpcRelation relation, string reason)
		{
			HoldingHandsRelation holdingHandsRelation = relation as HoldingHandsRelation;
			CharacterModel instance = CharacterModel.Instance;
			CharacterHoldingHandsComponent leader = holdingHandsRelation.Leader;
			EntityHandle handleByEntity = instance.GetHandleByEntity((leader != null) ? leader.Entity : null);
			CharacterModel instance2 = CharacterModel.Instance;
			CharacterHoldingHandsComponent follower = holdingHandsRelation.Follower;
			EntityHandle handleByEntity2 = instance2.GetHandleByEntity((follower != null) ? follower.Entity : null);
			if (handleByEntity == null || handleByEntity2 == null)
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[SeqNpcPerformState] 牵手者获取失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("leaderHandle", handleByEntity);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("followerHandle", handleByEntity2);
				instance3.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			HoldingHandsController.Instance.RequestHoldHands(holdingHandsRelation.Key, handleByEntity, handleByEntity2, holdingHandsRelation.LeaderHandType, new bool?(false), false, reason);
		}
	}
}
