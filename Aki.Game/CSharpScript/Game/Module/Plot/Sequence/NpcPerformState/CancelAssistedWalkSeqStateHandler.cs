using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AssistedWalk;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove;

namespace CSharpScript.Game.Module.Plot.Sequence.NpcPerformState
{
	// Token: 0x0200502A RID: 20522
	[NullableContext(1)]
	[Nullable(0)]
	public class CancelAssistedWalkSeqStateHandler : SeqNpcPerformStateHandler
	{
		// Token: 0x17008023 RID: 32803
		// (get) Token: 0x06034856 RID: 215126 RVA: 0x00C6033D File Offset: 0x00C5E53D
		public override ENpcGroupPerformType PerformType
		{
			get
			{
				return ENpcGroupPerformType.CancelSupportedWalking;
			}
		}

		// Token: 0x17008024 RID: 32804
		// (get) Token: 0x06034857 RID: 215127 RVA: 0x00C60340 File Offset: 0x00C5E540
		public override ENpcRelationType RelationType
		{
			get
			{
				return ENpcRelationType.CancelAssistedWalk;
			}
		}

		// Token: 0x06034858 RID: 215128 RVA: 0x00C60344 File Offset: 0x00C5E544
		[return: Nullable(2)]
		public override NpcRelation Capture(string key)
		{
			if (AttachMoveUtils.Instance.GetRelation(key) == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[SeqNpcPerformState] 取消搀扶登记失败：关系表中查不到 Key";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Key", key);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return new CancelAssistedWalkSeqRelation
			{
				Key = key
			};
		}

		// Token: 0x06034859 RID: 215129 RVA: 0x00C60394 File Offset: 0x00C5E594
		public unsafe override void OnBattleCharacterHidden(NpcRelation relation, string reason)
		{
			CancelAssistedWalkSeqRelation cancelAssistedWalkSeqRelation = relation as CancelAssistedWalkSeqRelation;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[SeqNpcPerformState] 实机角色隐藏后解除搀扶";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", cancelAssistedWalkSeqRelation.Key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			AssistedWalkUtils.Instance.RequestStopAssistedWalk(cancelAssistedWalkSeqRelation.Key, reason, global::EHandType.Right);
		}

		// Token: 0x0603485A RID: 215130 RVA: 0x00C60414 File Offset: 0x00C5E614
		public override void Restore(NpcRelation relation, string reason)
		{
			CancelAssistedWalkSeqRelation cancelAssistedWalkSeqRelation = relation as CancelAssistedWalkSeqRelation;
			if (AttachMoveUtils.Instance.GetRelation(cancelAssistedWalkSeqRelation.Key) == null)
			{
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[SeqNpcPerformState] 取消搀扶兜底补解";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Key", cancelAssistedWalkSeqRelation.Key);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			AssistedWalkUtils.Instance.RequestStopAssistedWalk(cancelAssistedWalkSeqRelation.Key, reason, global::EHandType.Right);
		}
	}
}
