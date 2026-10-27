using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D3E RID: 15678
	public class IBtNode_UnionUnion
	{
		// Token: 0x17006B8D RID: 27533
		// (get) Token: 0x06015A85 RID: 88709 RVA: 0x003201AE File Offset: 0x0031E3AE
		// (set) Token: 0x06015A86 RID: 88710 RVA: 0x003201B6 File Offset: 0x0031E3B6
		public IBtNode_Union Type { get; set; }

		// Token: 0x17006B8E RID: 27534
		// (get) Token: 0x06015A87 RID: 88711 RVA: 0x003201BF File Offset: 0x0031E3BF
		// (set) Token: 0x06015A88 RID: 88712 RVA: 0x003201C7 File Offset: 0x0031E3C7
		public object Value { get; set; }

		// Token: 0x06015A89 RID: 88713 RVA: 0x003201D0 File Offset: 0x0031E3D0
		public IBtNode_UnionUnion()
		{
			this.Type = IBtNode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015A8A RID: 88714 RVA: 0x003201E6 File Offset: 0x0031E3E6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015A8B RID: 88715 RVA: 0x003201F8 File Offset: 0x0031E3F8
		public IBtNodeT AsIBtNode()
		{
			return this.As<IBtNodeT>();
		}

		// Token: 0x06015A8C RID: 88716 RVA: 0x00320200 File Offset: 0x0031E400
		public static IBtNode_UnionUnion FromIBtNode(IBtNodeT _ibtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IBtNode,
				Value = _ibtnode
			};
		}

		// Token: 0x06015A8D RID: 88717 RVA: 0x00320215 File Offset: 0x0031E415
		public IStartBtNodeT AsIStartBtNode()
		{
			return this.As<IStartBtNodeT>();
		}

		// Token: 0x06015A8E RID: 88718 RVA: 0x0032021D File Offset: 0x0031E41D
		public static IBtNode_UnionUnion FromIStartBtNode(IStartBtNodeT _istartbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IStartBtNode,
				Value = _istartbtnode
			};
		}

		// Token: 0x06015A8F RID: 88719 RVA: 0x00320232 File Offset: 0x0031E432
		public IQuestSucceedBtNodeT AsIQuestSucceedBtNode()
		{
			return this.As<IQuestSucceedBtNodeT>();
		}

		// Token: 0x06015A90 RID: 88720 RVA: 0x0032023A File Offset: 0x0031E43A
		public static IBtNode_UnionUnion FromIQuestSucceedBtNode(IQuestSucceedBtNodeT _iquestsucceedbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IQuestSucceedBtNode,
				Value = _iquestsucceedbtnode
			};
		}

		// Token: 0x06015A91 RID: 88721 RVA: 0x0032024F File Offset: 0x0031E44F
		public IQuestFailedBtNodeT AsIQuestFailedBtNode()
		{
			return this.As<IQuestFailedBtNodeT>();
		}

		// Token: 0x06015A92 RID: 88722 RVA: 0x00320257 File Offset: 0x0031E457
		public static IBtNode_UnionUnion FromIQuestFailedBtNode(IQuestFailedBtNodeT _iquestfailedbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IQuestFailedBtNode,
				Value = _iquestfailedbtnode
			};
		}

		// Token: 0x06015A93 RID: 88723 RVA: 0x0032026C File Offset: 0x0031E46C
		public IAlwaysTrueBtNodeT AsIAlwaysTrueBtNode()
		{
			return this.As<IAlwaysTrueBtNodeT>();
		}

		// Token: 0x06015A94 RID: 88724 RVA: 0x00320274 File Offset: 0x0031E474
		public static IBtNode_UnionUnion FromIAlwaysTrueBtNode(IAlwaysTrueBtNodeT _ialwaystruebtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IAlwaysTrueBtNode,
				Value = _ialwaystruebtnode
			};
		}

		// Token: 0x06015A95 RID: 88725 RVA: 0x00320289 File Offset: 0x0031E489
		public IAlwaysFalseBtNodeT AsIAlwaysFalseBtNode()
		{
			return this.As<IAlwaysFalseBtNodeT>();
		}

		// Token: 0x06015A96 RID: 88726 RVA: 0x00320291 File Offset: 0x0031E491
		public static IBtNode_UnionUnion FromIAlwaysFalseBtNode(IAlwaysFalseBtNodeT _ialwaysfalsebtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IAlwaysFalseBtNode,
				Value = _ialwaysfalsebtnode
			};
		}

		// Token: 0x06015A97 RID: 88727 RVA: 0x003202A6 File Offset: 0x0031E4A6
		public IRepeaterBtNodeT AsIRepeaterBtNode()
		{
			return this.As<IRepeaterBtNodeT>();
		}

		// Token: 0x06015A98 RID: 88728 RVA: 0x003202AE File Offset: 0x0031E4AE
		public static IBtNode_UnionUnion FromIRepeaterBtNode(IRepeaterBtNodeT _irepeaterbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IRepeaterBtNode,
				Value = _irepeaterbtnode
			};
		}

		// Token: 0x06015A99 RID: 88729 RVA: 0x003202C3 File Offset: 0x0031E4C3
		public ILogicBtNodeT AsILogicBtNode()
		{
			return this.As<ILogicBtNodeT>();
		}

		// Token: 0x06015A9A RID: 88730 RVA: 0x003202CB File Offset: 0x0031E4CB
		public static IBtNode_UnionUnion FromILogicBtNode(ILogicBtNodeT _ilogicbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.ILogicBtNode,
				Value = _ilogicbtnode
			};
		}

		// Token: 0x06015A9B RID: 88731 RVA: 0x003202E0 File Offset: 0x0031E4E0
		public ISequenceBtNodeT AsISequenceBtNode()
		{
			return this.As<ISequenceBtNodeT>();
		}

		// Token: 0x06015A9C RID: 88732 RVA: 0x003202E8 File Offset: 0x0031E4E8
		public static IBtNode_UnionUnion FromISequenceBtNode(ISequenceBtNodeT _isequencebtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.ISequenceBtNode,
				Value = _isequencebtnode
			};
		}

		// Token: 0x06015A9D RID: 88733 RVA: 0x003202FE File Offset: 0x0031E4FE
		public ISelectBtNodeT AsISelectBtNode()
		{
			return this.As<ISelectBtNodeT>();
		}

		// Token: 0x06015A9E RID: 88734 RVA: 0x00320306 File Offset: 0x0031E506
		public static IBtNode_UnionUnion FromISelectBtNode(ISelectBtNodeT _iselectbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.ISelectBtNode,
				Value = _iselectbtnode
			};
		}

		// Token: 0x06015A9F RID: 88735 RVA: 0x0032031C File Offset: 0x0031E51C
		public IParallelSelectBtNodeT AsIParallelSelectBtNode()
		{
			return this.As<IParallelSelectBtNodeT>();
		}

		// Token: 0x06015AA0 RID: 88736 RVA: 0x00320324 File Offset: 0x0031E524
		public static IBtNode_UnionUnion FromIParallelSelectBtNode(IParallelSelectBtNodeT _iparallelselectbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IParallelSelectBtNode,
				Value = _iparallelselectbtnode
			};
		}

		// Token: 0x06015AA1 RID: 88737 RVA: 0x0032033A File Offset: 0x0031E53A
		public IConditionSelectorBtNodeT AsIConditionSelectorBtNode()
		{
			return this.As<IConditionSelectorBtNodeT>();
		}

		// Token: 0x06015AA2 RID: 88738 RVA: 0x00320342 File Offset: 0x0031E542
		public static IBtNode_UnionUnion FromIConditionSelectorBtNode(IConditionSelectorBtNodeT _iconditionselectorbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IConditionSelectorBtNode,
				Value = _iconditionselectorbtnode
			};
		}

		// Token: 0x06015AA3 RID: 88739 RVA: 0x00320358 File Offset: 0x0031E558
		public IConditionBtNodeT AsIConditionBtNode()
		{
			return this.As<IConditionBtNodeT>();
		}

		// Token: 0x06015AA4 RID: 88740 RVA: 0x00320360 File Offset: 0x0031E560
		public static IBtNode_UnionUnion FromIConditionBtNode(IConditionBtNodeT _iconditionbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IConditionBtNode,
				Value = _iconditionbtnode
			};
		}

		// Token: 0x06015AA5 RID: 88741 RVA: 0x00320376 File Offset: 0x0031E576
		public IChildQuestBtNodeT AsIChildQuestBtNode()
		{
			return this.As<IChildQuestBtNodeT>();
		}

		// Token: 0x06015AA6 RID: 88742 RVA: 0x0032037E File Offset: 0x0031E57E
		public static IBtNode_UnionUnion FromIChildQuestBtNode(IChildQuestBtNodeT _ichildquestbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IChildQuestBtNode,
				Value = _ichildquestbtnode
			};
		}

		// Token: 0x06015AA7 RID: 88743 RVA: 0x00320394 File Offset: 0x0031E594
		public IActionBtNodeT AsIActionBtNode()
		{
			return this.As<IActionBtNodeT>();
		}

		// Token: 0x06015AA8 RID: 88744 RVA: 0x0032039C File Offset: 0x0031E59C
		public static IBtNode_UnionUnion FromIActionBtNode(IActionBtNodeT _iactionbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IActionBtNode,
				Value = _iactionbtnode
			};
		}

		// Token: 0x06015AA9 RID: 88745 RVA: 0x003203B2 File Offset: 0x0031E5B2
		public IActionWithResultBtNodeT AsIActionWithResultBtNode()
		{
			return this.As<IActionWithResultBtNodeT>();
		}

		// Token: 0x06015AAA RID: 88746 RVA: 0x003203BA File Offset: 0x0031E5BA
		public static IBtNode_UnionUnion FromIActionWithResultBtNode(IActionWithResultBtNodeT _iactionwithresultbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IActionWithResultBtNode,
				Value = _iactionwithresultbtnode
			};
		}

		// Token: 0x06015AAB RID: 88747 RVA: 0x003203D0 File Offset: 0x0031E5D0
		public static int Pack(FlatBufferBuilder builder, IBtNode_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBtNode_Union.IBtNode:
				return IBtNode.Pack(builder, _o.AsIBtNode()).Value;
			case IBtNode_Union.IStartBtNode:
				return IStartBtNode.Pack(builder, _o.AsIStartBtNode()).Value;
			case IBtNode_Union.IQuestSucceedBtNode:
				return IQuestSucceedBtNode.Pack(builder, _o.AsIQuestSucceedBtNode()).Value;
			case IBtNode_Union.IQuestFailedBtNode:
				return IQuestFailedBtNode.Pack(builder, _o.AsIQuestFailedBtNode()).Value;
			case IBtNode_Union.IAlwaysTrueBtNode:
				return IAlwaysTrueBtNode.Pack(builder, _o.AsIAlwaysTrueBtNode()).Value;
			case IBtNode_Union.IAlwaysFalseBtNode:
				return IAlwaysFalseBtNode.Pack(builder, _o.AsIAlwaysFalseBtNode()).Value;
			case IBtNode_Union.IRepeaterBtNode:
				return IRepeaterBtNode.Pack(builder, _o.AsIRepeaterBtNode()).Value;
			case IBtNode_Union.ILogicBtNode:
				return ILogicBtNode.Pack(builder, _o.AsILogicBtNode()).Value;
			case IBtNode_Union.ISequenceBtNode:
				return ISequenceBtNode.Pack(builder, _o.AsISequenceBtNode()).Value;
			case IBtNode_Union.ISelectBtNode:
				return ISelectBtNode.Pack(builder, _o.AsISelectBtNode()).Value;
			case IBtNode_Union.IParallelSelectBtNode:
				return IParallelSelectBtNode.Pack(builder, _o.AsIParallelSelectBtNode()).Value;
			case IBtNode_Union.IConditionSelectorBtNode:
				return IConditionSelectorBtNode.Pack(builder, _o.AsIConditionSelectorBtNode()).Value;
			case IBtNode_Union.IConditionBtNode:
				return IConditionBtNode.Pack(builder, _o.AsIConditionBtNode()).Value;
			case IBtNode_Union.IChildQuestBtNode:
				return IChildQuestBtNode.Pack(builder, _o.AsIChildQuestBtNode()).Value;
			case IBtNode_Union.IActionBtNode:
				return IActionBtNode.Pack(builder, _o.AsIActionBtNode()).Value;
			case IBtNode_Union.IActionWithResultBtNode:
				return IActionWithResultBtNode.Pack(builder, _o.AsIActionWithResultBtNode()).Value;
			default:
				return 0;
			}
		}
	}
}
