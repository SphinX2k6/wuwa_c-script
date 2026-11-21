using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004155 RID: 16725
	public class IBtNode_UnionUnion
	{
		// Token: 0x17007147 RID: 28999
		// (get) Token: 0x06016FBD RID: 94141 RVA: 0x00347426 File Offset: 0x00345626
		// (set) Token: 0x06016FBE RID: 94142 RVA: 0x0034742E File Offset: 0x0034562E
		public IBtNode_Union Type { get; set; }

		// Token: 0x17007148 RID: 29000
		// (get) Token: 0x06016FBF RID: 94143 RVA: 0x00347437 File Offset: 0x00345637
		// (set) Token: 0x06016FC0 RID: 94144 RVA: 0x0034743F File Offset: 0x0034563F
		public object Value { get; set; }

		// Token: 0x06016FC1 RID: 94145 RVA: 0x00347448 File Offset: 0x00345648
		public IBtNode_UnionUnion()
		{
			this.Type = IBtNode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016FC2 RID: 94146 RVA: 0x0034745E File Offset: 0x0034565E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016FC3 RID: 94147 RVA: 0x00347470 File Offset: 0x00345670
		public IBtNodeT AsIBtNode()
		{
			return this.As<IBtNodeT>();
		}

		// Token: 0x06016FC4 RID: 94148 RVA: 0x00347478 File Offset: 0x00345678
		public static IBtNode_UnionUnion FromIBtNode(IBtNodeT _ibtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IBtNode,
				Value = _ibtnode
			};
		}

		// Token: 0x06016FC5 RID: 94149 RVA: 0x0034748D File Offset: 0x0034568D
		public IStartBtNodeT AsIStartBtNode()
		{
			return this.As<IStartBtNodeT>();
		}

		// Token: 0x06016FC6 RID: 94150 RVA: 0x00347495 File Offset: 0x00345695
		public static IBtNode_UnionUnion FromIStartBtNode(IStartBtNodeT _istartbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IStartBtNode,
				Value = _istartbtnode
			};
		}

		// Token: 0x06016FC7 RID: 94151 RVA: 0x003474AA File Offset: 0x003456AA
		public IQuestSucceedBtNodeT AsIQuestSucceedBtNode()
		{
			return this.As<IQuestSucceedBtNodeT>();
		}

		// Token: 0x06016FC8 RID: 94152 RVA: 0x003474B2 File Offset: 0x003456B2
		public static IBtNode_UnionUnion FromIQuestSucceedBtNode(IQuestSucceedBtNodeT _iquestsucceedbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IQuestSucceedBtNode,
				Value = _iquestsucceedbtnode
			};
		}

		// Token: 0x06016FC9 RID: 94153 RVA: 0x003474C7 File Offset: 0x003456C7
		public IQuestFailedBtNodeT AsIQuestFailedBtNode()
		{
			return this.As<IQuestFailedBtNodeT>();
		}

		// Token: 0x06016FCA RID: 94154 RVA: 0x003474CF File Offset: 0x003456CF
		public static IBtNode_UnionUnion FromIQuestFailedBtNode(IQuestFailedBtNodeT _iquestfailedbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IQuestFailedBtNode,
				Value = _iquestfailedbtnode
			};
		}

		// Token: 0x06016FCB RID: 94155 RVA: 0x003474E4 File Offset: 0x003456E4
		public IAlwaysTrueBtNodeT AsIAlwaysTrueBtNode()
		{
			return this.As<IAlwaysTrueBtNodeT>();
		}

		// Token: 0x06016FCC RID: 94156 RVA: 0x003474EC File Offset: 0x003456EC
		public static IBtNode_UnionUnion FromIAlwaysTrueBtNode(IAlwaysTrueBtNodeT _ialwaystruebtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IAlwaysTrueBtNode,
				Value = _ialwaystruebtnode
			};
		}

		// Token: 0x06016FCD RID: 94157 RVA: 0x00347501 File Offset: 0x00345701
		public IAlwaysFalseBtNodeT AsIAlwaysFalseBtNode()
		{
			return this.As<IAlwaysFalseBtNodeT>();
		}

		// Token: 0x06016FCE RID: 94158 RVA: 0x00347509 File Offset: 0x00345709
		public static IBtNode_UnionUnion FromIAlwaysFalseBtNode(IAlwaysFalseBtNodeT _ialwaysfalsebtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IAlwaysFalseBtNode,
				Value = _ialwaysfalsebtnode
			};
		}

		// Token: 0x06016FCF RID: 94159 RVA: 0x0034751E File Offset: 0x0034571E
		public IRepeaterBtNodeT AsIRepeaterBtNode()
		{
			return this.As<IRepeaterBtNodeT>();
		}

		// Token: 0x06016FD0 RID: 94160 RVA: 0x00347526 File Offset: 0x00345726
		public static IBtNode_UnionUnion FromIRepeaterBtNode(IRepeaterBtNodeT _irepeaterbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IRepeaterBtNode,
				Value = _irepeaterbtnode
			};
		}

		// Token: 0x06016FD1 RID: 94161 RVA: 0x0034753B File Offset: 0x0034573B
		public ILogicBtNodeT AsILogicBtNode()
		{
			return this.As<ILogicBtNodeT>();
		}

		// Token: 0x06016FD2 RID: 94162 RVA: 0x00347543 File Offset: 0x00345743
		public static IBtNode_UnionUnion FromILogicBtNode(ILogicBtNodeT _ilogicbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.ILogicBtNode,
				Value = _ilogicbtnode
			};
		}

		// Token: 0x06016FD3 RID: 94163 RVA: 0x00347558 File Offset: 0x00345758
		public ISequenceBtNodeT AsISequenceBtNode()
		{
			return this.As<ISequenceBtNodeT>();
		}

		// Token: 0x06016FD4 RID: 94164 RVA: 0x00347560 File Offset: 0x00345760
		public static IBtNode_UnionUnion FromISequenceBtNode(ISequenceBtNodeT _isequencebtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.ISequenceBtNode,
				Value = _isequencebtnode
			};
		}

		// Token: 0x06016FD5 RID: 94165 RVA: 0x00347576 File Offset: 0x00345776
		public ISelectBtNodeT AsISelectBtNode()
		{
			return this.As<ISelectBtNodeT>();
		}

		// Token: 0x06016FD6 RID: 94166 RVA: 0x0034757E File Offset: 0x0034577E
		public static IBtNode_UnionUnion FromISelectBtNode(ISelectBtNodeT _iselectbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.ISelectBtNode,
				Value = _iselectbtnode
			};
		}

		// Token: 0x06016FD7 RID: 94167 RVA: 0x00347594 File Offset: 0x00345794
		public IParallelSelectBtNodeT AsIParallelSelectBtNode()
		{
			return this.As<IParallelSelectBtNodeT>();
		}

		// Token: 0x06016FD8 RID: 94168 RVA: 0x0034759C File Offset: 0x0034579C
		public static IBtNode_UnionUnion FromIParallelSelectBtNode(IParallelSelectBtNodeT _iparallelselectbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IParallelSelectBtNode,
				Value = _iparallelselectbtnode
			};
		}

		// Token: 0x06016FD9 RID: 94169 RVA: 0x003475B2 File Offset: 0x003457B2
		public IConditionSelectorBtNodeT AsIConditionSelectorBtNode()
		{
			return this.As<IConditionSelectorBtNodeT>();
		}

		// Token: 0x06016FDA RID: 94170 RVA: 0x003475BA File Offset: 0x003457BA
		public static IBtNode_UnionUnion FromIConditionSelectorBtNode(IConditionSelectorBtNodeT _iconditionselectorbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IConditionSelectorBtNode,
				Value = _iconditionselectorbtnode
			};
		}

		// Token: 0x06016FDB RID: 94171 RVA: 0x003475D0 File Offset: 0x003457D0
		public IConditionBtNodeT AsIConditionBtNode()
		{
			return this.As<IConditionBtNodeT>();
		}

		// Token: 0x06016FDC RID: 94172 RVA: 0x003475D8 File Offset: 0x003457D8
		public static IBtNode_UnionUnion FromIConditionBtNode(IConditionBtNodeT _iconditionbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IConditionBtNode,
				Value = _iconditionbtnode
			};
		}

		// Token: 0x06016FDD RID: 94173 RVA: 0x003475EE File Offset: 0x003457EE
		public IChildQuestBtNodeT AsIChildQuestBtNode()
		{
			return this.As<IChildQuestBtNodeT>();
		}

		// Token: 0x06016FDE RID: 94174 RVA: 0x003475F6 File Offset: 0x003457F6
		public static IBtNode_UnionUnion FromIChildQuestBtNode(IChildQuestBtNodeT _ichildquestbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IChildQuestBtNode,
				Value = _ichildquestbtnode
			};
		}

		// Token: 0x06016FDF RID: 94175 RVA: 0x0034760C File Offset: 0x0034580C
		public IActionBtNodeT AsIActionBtNode()
		{
			return this.As<IActionBtNodeT>();
		}

		// Token: 0x06016FE0 RID: 94176 RVA: 0x00347614 File Offset: 0x00345814
		public static IBtNode_UnionUnion FromIActionBtNode(IActionBtNodeT _iactionbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IActionBtNode,
				Value = _iactionbtnode
			};
		}

		// Token: 0x06016FE1 RID: 94177 RVA: 0x0034762A File Offset: 0x0034582A
		public IActionWithResultBtNodeT AsIActionWithResultBtNode()
		{
			return this.As<IActionWithResultBtNodeT>();
		}

		// Token: 0x06016FE2 RID: 94178 RVA: 0x00347632 File Offset: 0x00345832
		public static IBtNode_UnionUnion FromIActionWithResultBtNode(IActionWithResultBtNodeT _iactionwithresultbtnode)
		{
			return new IBtNode_UnionUnion
			{
				Type = IBtNode_Union.IActionWithResultBtNode,
				Value = _iactionwithresultbtnode
			};
		}

		// Token: 0x06016FE3 RID: 94179 RVA: 0x00347648 File Offset: 0x00345848
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
