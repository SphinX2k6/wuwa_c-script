using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Sequence.NpcPerformState
{
	// Token: 0x0200502B RID: 20523
	[NullableContext(1)]
	[Nullable(0)]
	public class HoldingHandsSeqStateHandler : SeqNpcPerformStateHandler
	{
		// Token: 0x17008025 RID: 32805
		// (get) Token: 0x0603485C RID: 215132 RVA: 0x00C60481 File Offset: 0x00C5E681
		public override ENpcGroupPerformType PerformType
		{
			get
			{
				return ENpcGroupPerformType.HandInHand;
			}
		}

		// Token: 0x17008026 RID: 32806
		// (get) Token: 0x0603485D RID: 215133 RVA: 0x00C60484 File Offset: 0x00C5E684
		public override ENpcRelationType RelationType
		{
			get
			{
				return ENpcRelationType.HoldingHands;
			}
		}

		// Token: 0x0603485E RID: 215134 RVA: 0x00C60487 File Offset: 0x00C5E687
		[return: Nullable(2)]
		public override NpcRelation Capture(string key)
		{
			return HoldingHandsModel.Instance.GetRelation(key);
		}

		// Token: 0x0603485F RID: 215135 RVA: 0x00C60494 File Offset: 0x00C5E694
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
