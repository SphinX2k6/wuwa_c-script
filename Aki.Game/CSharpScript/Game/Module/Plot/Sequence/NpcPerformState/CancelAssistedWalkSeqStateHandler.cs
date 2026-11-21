using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AssistedWalk;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove;

namespace CSharpScript.Game.Module.Plot.Sequence.NpcPerformState
{
	// Token: 0x02003FF4 RID: 16372
	[NullableContext(1)]
	[Nullable(0)]
	public class CancelAssistedWalkSeqStateHandler : SeqNpcPerformStateHandler
	{
		// Token: 0x170053D8 RID: 21464
		// (get) Token: 0x060296F9 RID: 169721 RVA: 0x00BAB8B5 File Offset: 0x00BA9AB5
		public override ENpcGroupPerformType PerformType
		{
			get
			{
				return ENpcGroupPerformType.CancelSupportedWalking;
			}
		}

		// Token: 0x170053D9 RID: 21465
		// (get) Token: 0x060296FA RID: 169722 RVA: 0x00BAB8B8 File Offset: 0x00BA9AB8
		public override ENpcRelationType RelationType
		{
			get
			{
				return ENpcRelationType.CancelAssistedWalk;
			}
		}

		// Token: 0x060296FB RID: 169723 RVA: 0x00BAB8BC File Offset: 0x00BA9ABC
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

		// Token: 0x060296FC RID: 169724 RVA: 0x00BAB90C File Offset: 0x00BA9B0C
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

		// Token: 0x060296FD RID: 169725 RVA: 0x00BAB98C File Offset: 0x00BA9B8C
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
