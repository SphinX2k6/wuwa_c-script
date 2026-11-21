using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041CC RID: 16844
	public struct IConditionSelectorBtNodeSlot : IFlatbufferObject
	{
		// Token: 0x170072BF RID: 29375
		// (get) Token: 0x0601759D RID: 95645 RVA: 0x003563E3 File Offset: 0x003545E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601759E RID: 95646 RVA: 0x003563F0 File Offset: 0x003545F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601759F RID: 95647 RVA: 0x003563F8 File Offset: 0x003545F8
		public static IConditionSelectorBtNodeSlot GetRootAsIConditionSelectorBtNodeSlot(ByteBuffer _bb)
		{
			return IConditionSelectorBtNodeSlot.GetRootAsIConditionSelectorBtNodeSlot(_bb, default(IConditionSelectorBtNodeSlot));
		}

		// Token: 0x060175A0 RID: 95648 RVA: 0x00356414 File Offset: 0x00354614
		public static IConditionSelectorBtNodeSlot GetRootAsIConditionSelectorBtNodeSlot(ByteBuffer _bb, IConditionSelectorBtNodeSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060175A1 RID: 95649 RVA: 0x00356431 File Offset: 0x00354631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060175A2 RID: 95650 RVA: 0x00356440 File Offset: 0x00354640
		public IConditionSelectorBtNodeSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072C0 RID: 29376
		// (get) Token: 0x060175A3 RID: 95651 RVA: 0x00356450 File Offset: 0x00354650
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170072C1 RID: 29377
		// (get) Token: 0x060175A4 RID: 95652 RVA: 0x003564B0 File Offset: 0x003546B0
		public TBtNode NodeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TBtNode.NONE;
				}
				return (TBtNode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060175A5 RID: 95653 RVA: 0x003564EC File Offset: 0x003546EC
		public TTable? Node<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060175A6 RID: 95654 RVA: 0x00356530 File Offset: 0x00354730
		public IActionBtNode NodeAsIActionBtNode()
		{
			return this.Node<IActionBtNode>().Value;
		}

		// Token: 0x060175A7 RID: 95655 RVA: 0x0035654C File Offset: 0x0035474C
		public IActionWithResultBtNode NodeAsIActionWithResultBtNode()
		{
			return this.Node<IActionWithResultBtNode>().Value;
		}

		// Token: 0x060175A8 RID: 95656 RVA: 0x00356568 File Offset: 0x00354768
		public IAlwaysFalseBtNode NodeAsIAlwaysFalseBtNode()
		{
			return this.Node<IAlwaysFalseBtNode>().Value;
		}

		// Token: 0x060175A9 RID: 95657 RVA: 0x00356584 File Offset: 0x00354784
		public IAlwaysTrueBtNode NodeAsIAlwaysTrueBtNode()
		{
			return this.Node<IAlwaysTrueBtNode>().Value;
		}

		// Token: 0x060175AA RID: 95658 RVA: 0x003565A0 File Offset: 0x003547A0
		public IChildQuestBtNode NodeAsIChildQuestBtNode()
		{
			return this.Node<IChildQuestBtNode>().Value;
		}

		// Token: 0x060175AB RID: 95659 RVA: 0x003565BC File Offset: 0x003547BC
		public IConditionBtNode NodeAsIConditionBtNode()
		{
			return this.Node<IConditionBtNode>().Value;
		}

		// Token: 0x060175AC RID: 95660 RVA: 0x003565D8 File Offset: 0x003547D8
		public IConditionSelectorBtNode NodeAsIConditionSelectorBtNode()
		{
			return this.Node<IConditionSelectorBtNode>().Value;
		}

		// Token: 0x060175AD RID: 95661 RVA: 0x003565F4 File Offset: 0x003547F4
		public IParallelSelectBtNode NodeAsIParallelSelectBtNode()
		{
			return this.Node<IParallelSelectBtNode>().Value;
		}

		// Token: 0x060175AE RID: 95662 RVA: 0x00356610 File Offset: 0x00354810
		public IQuestFailedBtNode NodeAsIQuestFailedBtNode()
		{
			return this.Node<IQuestFailedBtNode>().Value;
		}

		// Token: 0x060175AF RID: 95663 RVA: 0x0035662C File Offset: 0x0035482C
		public IQuestSucceedBtNode NodeAsIQuestSucceedBtNode()
		{
			return this.Node<IQuestSucceedBtNode>().Value;
		}

		// Token: 0x060175B0 RID: 95664 RVA: 0x00356648 File Offset: 0x00354848
		public IRepeaterBtNode NodeAsIRepeaterBtNode()
		{
			return this.Node<IRepeaterBtNode>().Value;
		}

		// Token: 0x060175B1 RID: 95665 RVA: 0x00356664 File Offset: 0x00354864
		public ISelectBtNode NodeAsISelectBtNode()
		{
			return this.Node<ISelectBtNode>().Value;
		}

		// Token: 0x060175B2 RID: 95666 RVA: 0x00356680 File Offset: 0x00354880
		public ISequenceBtNode NodeAsISequenceBtNode()
		{
			return this.Node<ISequenceBtNode>().Value;
		}

		// Token: 0x060175B3 RID: 95667 RVA: 0x0035669C File Offset: 0x0035489C
		public IStartBtNode NodeAsIStartBtNode()
		{
			return this.Node<IStartBtNode>().Value;
		}

		// Token: 0x170072C2 RID: 29378
		// (get) Token: 0x060175B4 RID: 95668 RVA: 0x003566B8 File Offset: 0x003548B8
		public IPerformanceSetting? PerformanceSetting
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IPerformanceSetting?(default(IPerformanceSetting).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060175B5 RID: 95669 RVA: 0x00356716 File Offset: 0x00354916
		public static Offset<IConditionSelectorBtNodeSlot> CreateIConditionSelectorBtNodeSlot(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), TBtNode Node_type = TBtNode.NONE, int NodeOffset = 0, Offset<IPerformanceSetting> PerformanceSettingOffset = default(Offset<IPerformanceSetting>))
		{
			builder.StartTable(4);
			IConditionSelectorBtNodeSlot.AddPerformanceSetting(builder, PerformanceSettingOffset);
			IConditionSelectorBtNodeSlot.AddNode(builder, NodeOffset);
			IConditionSelectorBtNodeSlot.AddCondition(builder, ConditionOffset);
			IConditionSelectorBtNodeSlot.AddNodeType(builder, Node_type);
			return IConditionSelectorBtNodeSlot.EndIConditionSelectorBtNodeSlot(builder);
		}

		// Token: 0x060175B6 RID: 95670 RVA: 0x00356742 File Offset: 0x00354942
		public static void StartIConditionSelectorBtNodeSlot(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060175B7 RID: 95671 RVA: 0x0035674B File Offset: 0x0035494B
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060175B8 RID: 95672 RVA: 0x0035675B File Offset: 0x0035495B
		public static void AddNodeType(FlatBufferBuilder builder, TBtNode nodeType)
		{
			builder.AddByte(1, (byte)nodeType, 0);
		}

		// Token: 0x060175B9 RID: 95673 RVA: 0x00356766 File Offset: 0x00354966
		public static void AddNode(FlatBufferBuilder builder, int nodeOffset)
		{
			builder.AddOffset(2, nodeOffset, 0);
		}

		// Token: 0x060175BA RID: 95674 RVA: 0x00356771 File Offset: 0x00354971
		public static void AddPerformanceSetting(FlatBufferBuilder builder, Offset<IPerformanceSetting> performanceSettingOffset)
		{
			builder.AddOffset(3, performanceSettingOffset.Value, 0);
		}

		// Token: 0x060175BB RID: 95675 RVA: 0x00356781 File Offset: 0x00354981
		public static Offset<IConditionSelectorBtNodeSlot> EndIConditionSelectorBtNodeSlot(FlatBufferBuilder builder)
		{
			return new Offset<IConditionSelectorBtNodeSlot>(builder.EndTable());
		}

		// Token: 0x060175BC RID: 95676 RVA: 0x00356790 File Offset: 0x00354990
		public IConditionSelectorBtNodeSlotT UnPack()
		{
			IConditionSelectorBtNodeSlotT conditionSelectorBtNodeSlotT = new IConditionSelectorBtNodeSlotT();
			this.UnPackTo(conditionSelectorBtNodeSlotT);
			return conditionSelectorBtNodeSlotT;
		}

		// Token: 0x060175BD RID: 95677 RVA: 0x003567AC File Offset: 0x003549AC
		public void UnPackTo(IConditionSelectorBtNodeSlotT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Node = new TBtNodeUnion();
			_o.Node.Type = this.NodeType;
			switch (this.NodeType)
			{
			case TBtNode.IActionBtNode:
				_o.Node.Value = ((this.Node<IActionBtNode>() != null) ? this.Node<IActionBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IActionWithResultBtNode:
				_o.Node.Value = ((this.Node<IActionWithResultBtNode>() != null) ? this.Node<IActionWithResultBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IAlwaysFalseBtNode:
				_o.Node.Value = ((this.Node<IAlwaysFalseBtNode>() != null) ? this.Node<IAlwaysFalseBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IAlwaysTrueBtNode:
				_o.Node.Value = ((this.Node<IAlwaysTrueBtNode>() != null) ? this.Node<IAlwaysTrueBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IChildQuestBtNode:
				_o.Node.Value = ((this.Node<IChildQuestBtNode>() != null) ? this.Node<IChildQuestBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IConditionBtNode:
				_o.Node.Value = ((this.Node<IConditionBtNode>() != null) ? this.Node<IConditionBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IConditionSelectorBtNode:
				_o.Node.Value = ((this.Node<IConditionSelectorBtNode>() != null) ? this.Node<IConditionSelectorBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IParallelSelectBtNode:
				_o.Node.Value = ((this.Node<IParallelSelectBtNode>() != null) ? this.Node<IParallelSelectBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IQuestFailedBtNode:
				_o.Node.Value = ((this.Node<IQuestFailedBtNode>() != null) ? this.Node<IQuestFailedBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IQuestSucceedBtNode:
				_o.Node.Value = ((this.Node<IQuestSucceedBtNode>() != null) ? this.Node<IQuestSucceedBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IRepeaterBtNode:
				_o.Node.Value = ((this.Node<IRepeaterBtNode>() != null) ? this.Node<IRepeaterBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.ISelectBtNode:
				_o.Node.Value = ((this.Node<ISelectBtNode>() != null) ? this.Node<ISelectBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.ISequenceBtNode:
				_o.Node.Value = ((this.Node<ISequenceBtNode>() != null) ? this.Node<ISequenceBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IStartBtNode:
				_o.Node.Value = ((this.Node<IStartBtNode>() != null) ? this.Node<IStartBtNode>().Value.UnPack() : null);
				break;
			}
			_o.PerformanceSetting = ((this.PerformanceSetting != null) ? this.PerformanceSetting.Value.UnPack() : null);
		}

		// Token: 0x060175BE RID: 95678 RVA: 0x00356BC0 File Offset: 0x00354DC0
		public static Offset<IConditionSelectorBtNodeSlot> Pack(FlatBufferBuilder builder, IConditionSelectorBtNodeSlotT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionSelectorBtNodeSlot>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			TBtNode node_type = (_o.Node == null) ? TBtNode.NONE : _o.Node.Type;
			int nodeOffset = (_o.Node == null) ? 0 : TBtNodeUnion.Pack(builder, _o.Node);
			Offset<IPerformanceSetting> performanceSettingOffset = (_o.PerformanceSetting == null) ? default(Offset<IPerformanceSetting>) : IPerformanceSetting.Pack(builder, _o.PerformanceSetting);
			return IConditionSelectorBtNodeSlot.CreateIConditionSelectorBtNodeSlot(builder, conditionOffset, node_type, nodeOffset, performanceSettingOffset);
		}

		// Token: 0x0400C09F RID: 49311
		private Table __p;
	}
}
