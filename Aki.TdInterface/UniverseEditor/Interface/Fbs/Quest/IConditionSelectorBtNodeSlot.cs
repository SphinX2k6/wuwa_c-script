using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DB5 RID: 15797
	public struct IConditionSelectorBtNodeSlot : IFlatbufferObject
	{
		// Token: 0x17006D05 RID: 27909
		// (get) Token: 0x06016064 RID: 90212 RVA: 0x0032F05B File Offset: 0x0032D25B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016065 RID: 90213 RVA: 0x0032F068 File Offset: 0x0032D268
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016066 RID: 90214 RVA: 0x0032F070 File Offset: 0x0032D270
		public static IConditionSelectorBtNodeSlot GetRootAsIConditionSelectorBtNodeSlot(ByteBuffer _bb)
		{
			return IConditionSelectorBtNodeSlot.GetRootAsIConditionSelectorBtNodeSlot(_bb, default(IConditionSelectorBtNodeSlot));
		}

		// Token: 0x06016067 RID: 90215 RVA: 0x0032F08C File Offset: 0x0032D28C
		public static IConditionSelectorBtNodeSlot GetRootAsIConditionSelectorBtNodeSlot(ByteBuffer _bb, IConditionSelectorBtNodeSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016068 RID: 90216 RVA: 0x0032F0A9 File Offset: 0x0032D2A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016069 RID: 90217 RVA: 0x0032F0B8 File Offset: 0x0032D2B8
		public IConditionSelectorBtNodeSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D06 RID: 27910
		// (get) Token: 0x0601606A RID: 90218 RVA: 0x0032F0C8 File Offset: 0x0032D2C8
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

		// Token: 0x17006D07 RID: 27911
		// (get) Token: 0x0601606B RID: 90219 RVA: 0x0032F128 File Offset: 0x0032D328
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

		// Token: 0x0601606C RID: 90220 RVA: 0x0032F164 File Offset: 0x0032D364
		public TTable? Node<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601606D RID: 90221 RVA: 0x0032F1A8 File Offset: 0x0032D3A8
		public IActionBtNode NodeAsIActionBtNode()
		{
			return this.Node<IActionBtNode>().Value;
		}

		// Token: 0x0601606E RID: 90222 RVA: 0x0032F1C4 File Offset: 0x0032D3C4
		public IActionWithResultBtNode NodeAsIActionWithResultBtNode()
		{
			return this.Node<IActionWithResultBtNode>().Value;
		}

		// Token: 0x0601606F RID: 90223 RVA: 0x0032F1E0 File Offset: 0x0032D3E0
		public IAlwaysFalseBtNode NodeAsIAlwaysFalseBtNode()
		{
			return this.Node<IAlwaysFalseBtNode>().Value;
		}

		// Token: 0x06016070 RID: 90224 RVA: 0x0032F1FC File Offset: 0x0032D3FC
		public IAlwaysTrueBtNode NodeAsIAlwaysTrueBtNode()
		{
			return this.Node<IAlwaysTrueBtNode>().Value;
		}

		// Token: 0x06016071 RID: 90225 RVA: 0x0032F218 File Offset: 0x0032D418
		public IChildQuestBtNode NodeAsIChildQuestBtNode()
		{
			return this.Node<IChildQuestBtNode>().Value;
		}

		// Token: 0x06016072 RID: 90226 RVA: 0x0032F234 File Offset: 0x0032D434
		public IConditionBtNode NodeAsIConditionBtNode()
		{
			return this.Node<IConditionBtNode>().Value;
		}

		// Token: 0x06016073 RID: 90227 RVA: 0x0032F250 File Offset: 0x0032D450
		public IConditionSelectorBtNode NodeAsIConditionSelectorBtNode()
		{
			return this.Node<IConditionSelectorBtNode>().Value;
		}

		// Token: 0x06016074 RID: 90228 RVA: 0x0032F26C File Offset: 0x0032D46C
		public IParallelSelectBtNode NodeAsIParallelSelectBtNode()
		{
			return this.Node<IParallelSelectBtNode>().Value;
		}

		// Token: 0x06016075 RID: 90229 RVA: 0x0032F288 File Offset: 0x0032D488
		public IQuestFailedBtNode NodeAsIQuestFailedBtNode()
		{
			return this.Node<IQuestFailedBtNode>().Value;
		}

		// Token: 0x06016076 RID: 90230 RVA: 0x0032F2A4 File Offset: 0x0032D4A4
		public IQuestSucceedBtNode NodeAsIQuestSucceedBtNode()
		{
			return this.Node<IQuestSucceedBtNode>().Value;
		}

		// Token: 0x06016077 RID: 90231 RVA: 0x0032F2C0 File Offset: 0x0032D4C0
		public IRepeaterBtNode NodeAsIRepeaterBtNode()
		{
			return this.Node<IRepeaterBtNode>().Value;
		}

		// Token: 0x06016078 RID: 90232 RVA: 0x0032F2DC File Offset: 0x0032D4DC
		public ISelectBtNode NodeAsISelectBtNode()
		{
			return this.Node<ISelectBtNode>().Value;
		}

		// Token: 0x06016079 RID: 90233 RVA: 0x0032F2F8 File Offset: 0x0032D4F8
		public ISequenceBtNode NodeAsISequenceBtNode()
		{
			return this.Node<ISequenceBtNode>().Value;
		}

		// Token: 0x0601607A RID: 90234 RVA: 0x0032F314 File Offset: 0x0032D514
		public IStartBtNode NodeAsIStartBtNode()
		{
			return this.Node<IStartBtNode>().Value;
		}

		// Token: 0x17006D08 RID: 27912
		// (get) Token: 0x0601607B RID: 90235 RVA: 0x0032F330 File Offset: 0x0032D530
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

		// Token: 0x0601607C RID: 90236 RVA: 0x0032F38E File Offset: 0x0032D58E
		public static Offset<IConditionSelectorBtNodeSlot> CreateIConditionSelectorBtNodeSlot(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), TBtNode Node_type = TBtNode.NONE, int NodeOffset = 0, Offset<IPerformanceSetting> PerformanceSettingOffset = default(Offset<IPerformanceSetting>))
		{
			builder.StartTable(4);
			IConditionSelectorBtNodeSlot.AddPerformanceSetting(builder, PerformanceSettingOffset);
			IConditionSelectorBtNodeSlot.AddNode(builder, NodeOffset);
			IConditionSelectorBtNodeSlot.AddCondition(builder, ConditionOffset);
			IConditionSelectorBtNodeSlot.AddNodeType(builder, Node_type);
			return IConditionSelectorBtNodeSlot.EndIConditionSelectorBtNodeSlot(builder);
		}

		// Token: 0x0601607D RID: 90237 RVA: 0x0032F3BA File Offset: 0x0032D5BA
		public static void StartIConditionSelectorBtNodeSlot(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601607E RID: 90238 RVA: 0x0032F3C3 File Offset: 0x0032D5C3
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x0601607F RID: 90239 RVA: 0x0032F3D3 File Offset: 0x0032D5D3
		public static void AddNodeType(FlatBufferBuilder builder, TBtNode nodeType)
		{
			builder.AddByte(1, (byte)nodeType, 0);
		}

		// Token: 0x06016080 RID: 90240 RVA: 0x0032F3DE File Offset: 0x0032D5DE
		public static void AddNode(FlatBufferBuilder builder, int nodeOffset)
		{
			builder.AddOffset(2, nodeOffset, 0);
		}

		// Token: 0x06016081 RID: 90241 RVA: 0x0032F3E9 File Offset: 0x0032D5E9
		public static void AddPerformanceSetting(FlatBufferBuilder builder, Offset<IPerformanceSetting> performanceSettingOffset)
		{
			builder.AddOffset(3, performanceSettingOffset.Value, 0);
		}

		// Token: 0x06016082 RID: 90242 RVA: 0x0032F3F9 File Offset: 0x0032D5F9
		public static Offset<IConditionSelectorBtNodeSlot> EndIConditionSelectorBtNodeSlot(FlatBufferBuilder builder)
		{
			return new Offset<IConditionSelectorBtNodeSlot>(builder.EndTable());
		}

		// Token: 0x06016083 RID: 90243 RVA: 0x0032F408 File Offset: 0x0032D608
		public IConditionSelectorBtNodeSlotT UnPack()
		{
			IConditionSelectorBtNodeSlotT conditionSelectorBtNodeSlotT = new IConditionSelectorBtNodeSlotT();
			this.UnPackTo(conditionSelectorBtNodeSlotT);
			return conditionSelectorBtNodeSlotT;
		}

		// Token: 0x06016084 RID: 90244 RVA: 0x0032F424 File Offset: 0x0032D624
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

		// Token: 0x06016085 RID: 90245 RVA: 0x0032F838 File Offset: 0x0032DA38
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

		// Token: 0x0400B6F2 RID: 46834
		private Table __p;
	}
}
