using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200473E RID: 18238
	public class TLeafBtNodeUnion
	{
		// Token: 0x17007F7F RID: 32639
		// (get) Token: 0x0601ADBD RID: 110013 RVA: 0x003CFE4A File Offset: 0x003CE04A
		// (set) Token: 0x0601ADBE RID: 110014 RVA: 0x003CFE52 File Offset: 0x003CE052
		public TLeafBtNode Type { get; set; }

		// Token: 0x17007F80 RID: 32640
		// (get) Token: 0x0601ADBF RID: 110015 RVA: 0x003CFE5B File Offset: 0x003CE05B
		// (set) Token: 0x0601ADC0 RID: 110016 RVA: 0x003CFE63 File Offset: 0x003CE063
		public object Value { get; set; }

		// Token: 0x0601ADC1 RID: 110017 RVA: 0x003CFE6C File Offset: 0x003CE06C
		public TLeafBtNodeUnion()
		{
			this.Type = TLeafBtNode.NONE;
			this.Value = null;
		}

		// Token: 0x0601ADC2 RID: 110018 RVA: 0x003CFE82 File Offset: 0x003CE082
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601ADC3 RID: 110019 RVA: 0x003CFE94 File Offset: 0x003CE094
		public IActionBtNodeT AsIActionBtNode()
		{
			return this.As<IActionBtNodeT>();
		}

		// Token: 0x0601ADC4 RID: 110020 RVA: 0x003CFE9C File Offset: 0x003CE09C
		public static TLeafBtNodeUnion FromIActionBtNode(IActionBtNodeT _iactionbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IActionBtNode,
				Value = _iactionbtnode
			};
		}

		// Token: 0x0601ADC5 RID: 110021 RVA: 0x003CFEB1 File Offset: 0x003CE0B1
		public IActionWithResultBtNodeT AsIActionWithResultBtNode()
		{
			return this.As<IActionWithResultBtNodeT>();
		}

		// Token: 0x0601ADC6 RID: 110022 RVA: 0x003CFEB9 File Offset: 0x003CE0B9
		public static TLeafBtNodeUnion FromIActionWithResultBtNode(IActionWithResultBtNodeT _iactionwithresultbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IActionWithResultBtNode,
				Value = _iactionwithresultbtnode
			};
		}

		// Token: 0x0601ADC7 RID: 110023 RVA: 0x003CFECE File Offset: 0x003CE0CE
		public IChildQuestBtNodeT AsIChildQuestBtNode()
		{
			return this.As<IChildQuestBtNodeT>();
		}

		// Token: 0x0601ADC8 RID: 110024 RVA: 0x003CFED6 File Offset: 0x003CE0D6
		public static TLeafBtNodeUnion FromIChildQuestBtNode(IChildQuestBtNodeT _ichildquestbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IChildQuestBtNode,
				Value = _ichildquestbtnode
			};
		}

		// Token: 0x0601ADC9 RID: 110025 RVA: 0x003CFEEB File Offset: 0x003CE0EB
		public IConditionBtNodeT AsIConditionBtNode()
		{
			return this.As<IConditionBtNodeT>();
		}

		// Token: 0x0601ADCA RID: 110026 RVA: 0x003CFEF3 File Offset: 0x003CE0F3
		public static TLeafBtNodeUnion FromIConditionBtNode(IConditionBtNodeT _iconditionbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IConditionBtNode,
				Value = _iconditionbtnode
			};
		}

		// Token: 0x0601ADCB RID: 110027 RVA: 0x003CFF08 File Offset: 0x003CE108
		public IQuestFailedBtNodeT AsIQuestFailedBtNode()
		{
			return this.As<IQuestFailedBtNodeT>();
		}

		// Token: 0x0601ADCC RID: 110028 RVA: 0x003CFF10 File Offset: 0x003CE110
		public static TLeafBtNodeUnion FromIQuestFailedBtNode(IQuestFailedBtNodeT _iquestfailedbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IQuestFailedBtNode,
				Value = _iquestfailedbtnode
			};
		}

		// Token: 0x0601ADCD RID: 110029 RVA: 0x003CFF25 File Offset: 0x003CE125
		public IQuestSucceedBtNodeT AsIQuestSucceedBtNode()
		{
			return this.As<IQuestSucceedBtNodeT>();
		}

		// Token: 0x0601ADCE RID: 110030 RVA: 0x003CFF2D File Offset: 0x003CE12D
		public static TLeafBtNodeUnion FromIQuestSucceedBtNode(IQuestSucceedBtNodeT _iquestsucceedbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IQuestSucceedBtNode,
				Value = _iquestsucceedbtnode
			};
		}

		// Token: 0x0601ADCF RID: 110031 RVA: 0x003CFF42 File Offset: 0x003CE142
		public IStartBtNodeT AsIStartBtNode()
		{
			return this.As<IStartBtNodeT>();
		}

		// Token: 0x0601ADD0 RID: 110032 RVA: 0x003CFF4A File Offset: 0x003CE14A
		public static TLeafBtNodeUnion FromIStartBtNode(IStartBtNodeT _istartbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IStartBtNode,
				Value = _istartbtnode
			};
		}

		// Token: 0x0601ADD1 RID: 110033 RVA: 0x003CFF5F File Offset: 0x003CE15F
		public IAlwaysTrueBtNodeT AsIAlwaysTrueBtNode()
		{
			return this.As<IAlwaysTrueBtNodeT>();
		}

		// Token: 0x0601ADD2 RID: 110034 RVA: 0x003CFF67 File Offset: 0x003CE167
		public static TLeafBtNodeUnion FromIAlwaysTrueBtNode(IAlwaysTrueBtNodeT _ialwaystruebtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IAlwaysTrueBtNode,
				Value = _ialwaystruebtnode
			};
		}

		// Token: 0x0601ADD3 RID: 110035 RVA: 0x003CFF7C File Offset: 0x003CE17C
		public IAlwaysFalseBtNodeT AsIAlwaysFalseBtNode()
		{
			return this.As<IAlwaysFalseBtNodeT>();
		}

		// Token: 0x0601ADD4 RID: 110036 RVA: 0x003CFF84 File Offset: 0x003CE184
		public static TLeafBtNodeUnion FromIAlwaysFalseBtNode(IAlwaysFalseBtNodeT _ialwaysfalsebtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IAlwaysFalseBtNode,
				Value = _ialwaysfalsebtnode
			};
		}

		// Token: 0x0601ADD5 RID: 110037 RVA: 0x003CFF9A File Offset: 0x003CE19A
		public IRepeaterBtNodeT AsIRepeaterBtNode()
		{
			return this.As<IRepeaterBtNodeT>();
		}

		// Token: 0x0601ADD6 RID: 110038 RVA: 0x003CFFA2 File Offset: 0x003CE1A2
		public static TLeafBtNodeUnion FromIRepeaterBtNode(IRepeaterBtNodeT _irepeaterbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IRepeaterBtNode,
				Value = _irepeaterbtnode
			};
		}

		// Token: 0x0601ADD7 RID: 110039 RVA: 0x003CFFB8 File Offset: 0x003CE1B8
		public static int Pack(FlatBufferBuilder builder, TLeafBtNodeUnion _o)
		{
			switch (_o.Type)
			{
			case TLeafBtNode.IActionBtNode:
				return IActionBtNode.Pack(builder, _o.AsIActionBtNode()).Value;
			case TLeafBtNode.IActionWithResultBtNode:
				return IActionWithResultBtNode.Pack(builder, _o.AsIActionWithResultBtNode()).Value;
			case TLeafBtNode.IChildQuestBtNode:
				return IChildQuestBtNode.Pack(builder, _o.AsIChildQuestBtNode()).Value;
			case TLeafBtNode.IConditionBtNode:
				return IConditionBtNode.Pack(builder, _o.AsIConditionBtNode()).Value;
			case TLeafBtNode.IQuestFailedBtNode:
				return IQuestFailedBtNode.Pack(builder, _o.AsIQuestFailedBtNode()).Value;
			case TLeafBtNode.IQuestSucceedBtNode:
				return IQuestSucceedBtNode.Pack(builder, _o.AsIQuestSucceedBtNode()).Value;
			case TLeafBtNode.IStartBtNode:
				return IStartBtNode.Pack(builder, _o.AsIStartBtNode()).Value;
			case TLeafBtNode.IAlwaysTrueBtNode:
				return IAlwaysTrueBtNode.Pack(builder, _o.AsIAlwaysTrueBtNode()).Value;
			case TLeafBtNode.IAlwaysFalseBtNode:
				return IAlwaysFalseBtNode.Pack(builder, _o.AsIAlwaysFalseBtNode()).Value;
			case TLeafBtNode.IRepeaterBtNode:
				return IRepeaterBtNode.Pack(builder, _o.AsIRepeaterBtNode()).Value;
			default:
				return 0;
			}
		}
	}
}
