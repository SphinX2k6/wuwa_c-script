using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004744 RID: 18244
	public class TManyChildrenBtNodeUnion
	{
		// Token: 0x17007F83 RID: 32643
		// (get) Token: 0x0601ADE9 RID: 110057 RVA: 0x003D02EA File Offset: 0x003CE4EA
		// (set) Token: 0x0601ADEA RID: 110058 RVA: 0x003D02F2 File Offset: 0x003CE4F2
		public TManyChildrenBtNode Type { get; set; }

		// Token: 0x17007F84 RID: 32644
		// (get) Token: 0x0601ADEB RID: 110059 RVA: 0x003D02FB File Offset: 0x003CE4FB
		// (set) Token: 0x0601ADEC RID: 110060 RVA: 0x003D0303 File Offset: 0x003CE503
		public object Value { get; set; }

		// Token: 0x0601ADED RID: 110061 RVA: 0x003D030C File Offset: 0x003CE50C
		public TManyChildrenBtNodeUnion()
		{
			this.Type = TManyChildrenBtNode.NONE;
			this.Value = null;
		}

		// Token: 0x0601ADEE RID: 110062 RVA: 0x003D0322 File Offset: 0x003CE522
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601ADEF RID: 110063 RVA: 0x003D0334 File Offset: 0x003CE534
		public IParallelSelectBtNodeT AsIParallelSelectBtNode()
		{
			return this.As<IParallelSelectBtNodeT>();
		}

		// Token: 0x0601ADF0 RID: 110064 RVA: 0x003D033C File Offset: 0x003CE53C
		public static TManyChildrenBtNodeUnion FromIParallelSelectBtNode(IParallelSelectBtNodeT _iparallelselectbtnode)
		{
			return new TManyChildrenBtNodeUnion
			{
				Type = TManyChildrenBtNode.IParallelSelectBtNode,
				Value = _iparallelselectbtnode
			};
		}

		// Token: 0x0601ADF1 RID: 110065 RVA: 0x003D0351 File Offset: 0x003CE551
		public ISelectBtNodeT AsISelectBtNode()
		{
			return this.As<ISelectBtNodeT>();
		}

		// Token: 0x0601ADF2 RID: 110066 RVA: 0x003D0359 File Offset: 0x003CE559
		public static TManyChildrenBtNodeUnion FromISelectBtNode(ISelectBtNodeT _iselectbtnode)
		{
			return new TManyChildrenBtNodeUnion
			{
				Type = TManyChildrenBtNode.ISelectBtNode,
				Value = _iselectbtnode
			};
		}

		// Token: 0x0601ADF3 RID: 110067 RVA: 0x003D036E File Offset: 0x003CE56E
		public ISequenceBtNodeT AsISequenceBtNode()
		{
			return this.As<ISequenceBtNodeT>();
		}

		// Token: 0x0601ADF4 RID: 110068 RVA: 0x003D0376 File Offset: 0x003CE576
		public static TManyChildrenBtNodeUnion FromISequenceBtNode(ISequenceBtNodeT _isequencebtnode)
		{
			return new TManyChildrenBtNodeUnion
			{
				Type = TManyChildrenBtNode.ISequenceBtNode,
				Value = _isequencebtnode
			};
		}

		// Token: 0x0601ADF5 RID: 110069 RVA: 0x003D038B File Offset: 0x003CE58B
		public IConditionSelectorBtNodeT AsIConditionSelectorBtNode()
		{
			return this.As<IConditionSelectorBtNodeT>();
		}

		// Token: 0x0601ADF6 RID: 110070 RVA: 0x003D0393 File Offset: 0x003CE593
		public static TManyChildrenBtNodeUnion FromIConditionSelectorBtNode(IConditionSelectorBtNodeT _iconditionselectorbtnode)
		{
			return new TManyChildrenBtNodeUnion
			{
				Type = TManyChildrenBtNode.IConditionSelectorBtNode,
				Value = _iconditionselectorbtnode
			};
		}

		// Token: 0x0601ADF7 RID: 110071 RVA: 0x003D03A8 File Offset: 0x003CE5A8
		public static int Pack(FlatBufferBuilder builder, TManyChildrenBtNodeUnion _o)
		{
			switch (_o.Type)
			{
			case TManyChildrenBtNode.IParallelSelectBtNode:
				return IParallelSelectBtNode.Pack(builder, _o.AsIParallelSelectBtNode()).Value;
			case TManyChildrenBtNode.ISelectBtNode:
				return ISelectBtNode.Pack(builder, _o.AsISelectBtNode()).Value;
			case TManyChildrenBtNode.ISequenceBtNode:
				return ISequenceBtNode.Pack(builder, _o.AsISequenceBtNode()).Value;
			case TManyChildrenBtNode.IConditionSelectorBtNode:
				return IConditionSelectorBtNode.Pack(builder, _o.AsIConditionSelectorBtNode()).Value;
			default:
				return 0;
			}
		}
	}
}
