using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040A3 RID: 16547
	public struct IRepeaterBtNode : IFlatbufferObject
	{
		// Token: 0x170074C0 RID: 29888
		// (get) Token: 0x0601816D RID: 98669 RVA: 0x003790DB File Offset: 0x003772DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601816E RID: 98670 RVA: 0x003790E8 File Offset: 0x003772E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601816F RID: 98671 RVA: 0x003790F0 File Offset: 0x003772F0
		public static IRepeaterBtNode GetRootAsIRepeaterBtNode(ByteBuffer _bb)
		{
			return IRepeaterBtNode.GetRootAsIRepeaterBtNode(_bb, default(IRepeaterBtNode));
		}

		// Token: 0x06018170 RID: 98672 RVA: 0x0037910C File Offset: 0x0037730C
		public static IRepeaterBtNode GetRootAsIRepeaterBtNode(ByteBuffer _bb, IRepeaterBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018171 RID: 98673 RVA: 0x00379129 File Offset: 0x00377329
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018172 RID: 98674 RVA: 0x00379138 File Offset: 0x00377338
		public IRepeaterBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074C1 RID: 29889
		// (get) Token: 0x06018173 RID: 98675 RVA: 0x00379148 File Offset: 0x00377348
		public EBtNode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBtNode.Start;
				}
				return (EBtNode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170074C2 RID: 29890
		// (get) Token: 0x06018174 RID: 98676 RVA: 0x00379184 File Offset: 0x00377384
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170074C3 RID: 29891
		// (get) Token: 0x06018175 RID: 98677 RVA: 0x003791C0 File Offset: 0x003773C0
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018176 RID: 98678 RVA: 0x003791F7 File Offset: 0x003773F7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06018177 RID: 98679 RVA: 0x00379206 File Offset: 0x00377406
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170074C4 RID: 29892
		// (get) Token: 0x06018178 RID: 98680 RVA: 0x00379214 File Offset: 0x00377414
		public IFixProcessor? FixProcessor
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IFixProcessor?(default(IFixProcessor).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170074C5 RID: 29893
		// (get) Token: 0x06018179 RID: 98681 RVA: 0x00379274 File Offset: 0x00377474
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170074C6 RID: 29894
		// (get) Token: 0x0601817A RID: 98682 RVA: 0x003792B4 File Offset: 0x003774B4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170074C7 RID: 29895
		// (get) Token: 0x0601817B RID: 98683 RVA: 0x003792F4 File Offset: 0x003774F4
		public TBtNode ChildType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return TBtNode.NONE;
				}
				return (TBtNode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601817C RID: 98684 RVA: 0x00379334 File Offset: 0x00377534
		public TTable? Child<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601817D RID: 98685 RVA: 0x0037937C File Offset: 0x0037757C
		public IActionBtNode ChildAsIActionBtNode()
		{
			return this.Child<IActionBtNode>().Value;
		}

		// Token: 0x0601817E RID: 98686 RVA: 0x00379398 File Offset: 0x00377598
		public IActionWithResultBtNode ChildAsIActionWithResultBtNode()
		{
			return this.Child<IActionWithResultBtNode>().Value;
		}

		// Token: 0x0601817F RID: 98687 RVA: 0x003793B4 File Offset: 0x003775B4
		public IAlwaysFalseBtNode ChildAsIAlwaysFalseBtNode()
		{
			return this.Child<IAlwaysFalseBtNode>().Value;
		}

		// Token: 0x06018180 RID: 98688 RVA: 0x003793D0 File Offset: 0x003775D0
		public IAlwaysTrueBtNode ChildAsIAlwaysTrueBtNode()
		{
			return this.Child<IAlwaysTrueBtNode>().Value;
		}

		// Token: 0x06018181 RID: 98689 RVA: 0x003793EC File Offset: 0x003775EC
		public IChildQuestBtNode ChildAsIChildQuestBtNode()
		{
			return this.Child<IChildQuestBtNode>().Value;
		}

		// Token: 0x06018182 RID: 98690 RVA: 0x00379408 File Offset: 0x00377608
		public IConditionBtNode ChildAsIConditionBtNode()
		{
			return this.Child<IConditionBtNode>().Value;
		}

		// Token: 0x06018183 RID: 98691 RVA: 0x00379424 File Offset: 0x00377624
		public IConditionSelectorBtNode ChildAsIConditionSelectorBtNode()
		{
			return this.Child<IConditionSelectorBtNode>().Value;
		}

		// Token: 0x06018184 RID: 98692 RVA: 0x00379440 File Offset: 0x00377640
		public IParallelSelectBtNode ChildAsIParallelSelectBtNode()
		{
			return this.Child<IParallelSelectBtNode>().Value;
		}

		// Token: 0x06018185 RID: 98693 RVA: 0x0037945C File Offset: 0x0037765C
		public IQuestFailedBtNode ChildAsIQuestFailedBtNode()
		{
			return this.Child<IQuestFailedBtNode>().Value;
		}

		// Token: 0x06018186 RID: 98694 RVA: 0x00379478 File Offset: 0x00377678
		public IQuestSucceedBtNode ChildAsIQuestSucceedBtNode()
		{
			return this.Child<IQuestSucceedBtNode>().Value;
		}

		// Token: 0x06018187 RID: 98695 RVA: 0x00379494 File Offset: 0x00377694
		public IRepeaterBtNode ChildAsIRepeaterBtNode()
		{
			return this.Child<IRepeaterBtNode>().Value;
		}

		// Token: 0x06018188 RID: 98696 RVA: 0x003794B0 File Offset: 0x003776B0
		public ISelectBtNode ChildAsISelectBtNode()
		{
			return this.Child<ISelectBtNode>().Value;
		}

		// Token: 0x06018189 RID: 98697 RVA: 0x003794CC File Offset: 0x003776CC
		public ISequenceBtNode ChildAsISequenceBtNode()
		{
			return this.Child<ISequenceBtNode>().Value;
		}

		// Token: 0x0601818A RID: 98698 RVA: 0x003794E8 File Offset: 0x003776E8
		public IStartBtNode ChildAsIStartBtNode()
		{
			return this.Child<IStartBtNode>().Value;
		}

		// Token: 0x170074C8 RID: 29896
		// (get) Token: 0x0601818B RID: 98699 RVA: 0x00379504 File Offset: 0x00377704
		public int MaxRepeatTimes
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170074C9 RID: 29897
		// (get) Token: 0x0601818C RID: 98700 RVA: 0x00379544 File Offset: 0x00377744
		public IConditionGroup? ExitCondition
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170074CA RID: 29898
		// (get) Token: 0x0601818D RID: 98701 RVA: 0x003795A4 File Offset: 0x003777A4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601818E RID: 98702 RVA: 0x003795E4 File Offset: 0x003777E4
		public static Offset<IRepeaterBtNode> CreateIRepeaterBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, TBtNode Child_type = TBtNode.NONE, int ChildOffset = 0, int MaxRepeatTimes = 0, Offset<IConditionGroup> ExitConditionOffset = default(Offset<IConditionGroup>), byte NullMask = 0)
		{
			builder.StartTable(11);
			IRepeaterBtNode.AddExitCondition(builder, ExitConditionOffset);
			IRepeaterBtNode.AddMaxRepeatTimes(builder, MaxRepeatTimes);
			IRepeaterBtNode.AddChild(builder, ChildOffset);
			IRepeaterBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IRepeaterBtNode.AddDesc(builder, DescOffset);
			IRepeaterBtNode.AddId(builder, Id);
			IRepeaterBtNode.AddNullMask(builder, NullMask);
			IRepeaterBtNode.AddChildType(builder, Child_type);
			IRepeaterBtNode.AddDisabled(builder, Disabled);
			IRepeaterBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IRepeaterBtNode.AddType(builder, Type);
			return IRepeaterBtNode.EndIRepeaterBtNode(builder);
		}

		// Token: 0x0601818F RID: 98703 RVA: 0x00379654 File Offset: 0x00377854
		public static void StartIRepeaterBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06018190 RID: 98704 RVA: 0x0037965E File Offset: 0x0037785E
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018191 RID: 98705 RVA: 0x00379669 File Offset: 0x00377869
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06018192 RID: 98706 RVA: 0x00379674 File Offset: 0x00377874
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06018193 RID: 98707 RVA: 0x00379684 File Offset: 0x00377884
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06018194 RID: 98708 RVA: 0x00379694 File Offset: 0x00377894
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06018195 RID: 98709 RVA: 0x0037969F File Offset: 0x0037789F
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06018196 RID: 98710 RVA: 0x003796AA File Offset: 0x003778AA
		public static void AddChildType(FlatBufferBuilder builder, TBtNode childType)
		{
			builder.AddByte(6, (byte)childType, 0);
		}

		// Token: 0x06018197 RID: 98711 RVA: 0x003796B5 File Offset: 0x003778B5
		public static void AddChild(FlatBufferBuilder builder, int childOffset)
		{
			builder.AddOffset(7, childOffset, 0);
		}

		// Token: 0x06018198 RID: 98712 RVA: 0x003796C0 File Offset: 0x003778C0
		public static void AddMaxRepeatTimes(FlatBufferBuilder builder, int maxRepeatTimes)
		{
			builder.AddInt(8, maxRepeatTimes, 0);
		}

		// Token: 0x06018199 RID: 98713 RVA: 0x003796CB File Offset: 0x003778CB
		public static void AddExitCondition(FlatBufferBuilder builder, Offset<IConditionGroup> exitConditionOffset)
		{
			builder.AddOffset(9, exitConditionOffset.Value, 0);
		}

		// Token: 0x0601819A RID: 98714 RVA: 0x003796DC File Offset: 0x003778DC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x0601819B RID: 98715 RVA: 0x003796E8 File Offset: 0x003778E8
		public static Offset<IRepeaterBtNode> EndIRepeaterBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IRepeaterBtNode>(builder.EndTable());
		}

		// Token: 0x0601819C RID: 98716 RVA: 0x003796F8 File Offset: 0x003778F8
		public IRepeaterBtNodeT UnPack()
		{
			IRepeaterBtNodeT repeaterBtNodeT = new IRepeaterBtNodeT();
			this.UnPackTo(repeaterBtNodeT);
			return repeaterBtNodeT;
		}

		// Token: 0x0601819D RID: 98717 RVA: 0x00379714 File Offset: 0x00377914
		public void UnPackTo(IRepeaterBtNodeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.FixProcessor = ((this.FixProcessor != null) ? this.FixProcessor.Value.UnPack() : null);
			_o._FoldedForTree = this._FoldedForTree;
			_o.Disabled = this.Disabled;
			_o.Child = new TBtNodeUnion();
			_o.Child.Type = this.ChildType;
			switch (this.ChildType)
			{
			case TBtNode.IActionBtNode:
				_o.Child.Value = ((this.Child<IActionBtNode>() != null) ? this.Child<IActionBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IActionWithResultBtNode:
				_o.Child.Value = ((this.Child<IActionWithResultBtNode>() != null) ? this.Child<IActionWithResultBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IAlwaysFalseBtNode:
				_o.Child.Value = ((this.Child<IAlwaysFalseBtNode>() != null) ? this.Child<IAlwaysFalseBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IAlwaysTrueBtNode:
				_o.Child.Value = ((this.Child<IAlwaysTrueBtNode>() != null) ? this.Child<IAlwaysTrueBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IChildQuestBtNode:
				_o.Child.Value = ((this.Child<IChildQuestBtNode>() != null) ? this.Child<IChildQuestBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IConditionBtNode:
				_o.Child.Value = ((this.Child<IConditionBtNode>() != null) ? this.Child<IConditionBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IConditionSelectorBtNode:
				_o.Child.Value = ((this.Child<IConditionSelectorBtNode>() != null) ? this.Child<IConditionSelectorBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IParallelSelectBtNode:
				_o.Child.Value = ((this.Child<IParallelSelectBtNode>() != null) ? this.Child<IParallelSelectBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IQuestFailedBtNode:
				_o.Child.Value = ((this.Child<IQuestFailedBtNode>() != null) ? this.Child<IQuestFailedBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IQuestSucceedBtNode:
				_o.Child.Value = ((this.Child<IQuestSucceedBtNode>() != null) ? this.Child<IQuestSucceedBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IRepeaterBtNode:
				_o.Child.Value = ((this.Child<IRepeaterBtNode>() != null) ? this.Child<IRepeaterBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.ISelectBtNode:
				_o.Child.Value = ((this.Child<ISelectBtNode>() != null) ? this.Child<ISelectBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.ISequenceBtNode:
				_o.Child.Value = ((this.Child<ISequenceBtNode>() != null) ? this.Child<ISequenceBtNode>().Value.UnPack() : null);
				break;
			case TBtNode.IStartBtNode:
				_o.Child.Value = ((this.Child<IStartBtNode>() != null) ? this.Child<IStartBtNode>().Value.UnPack() : null);
				break;
			}
			_o.MaxRepeatTimes = this.MaxRepeatTimes;
			_o.ExitCondition = ((this.ExitCondition != null) ? this.ExitCondition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601819E RID: 98718 RVA: 0x00379B7C File Offset: 0x00377D7C
		public static Offset<IRepeaterBtNode> Pack(FlatBufferBuilder builder, IRepeaterBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRepeaterBtNode>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<IFixProcessor>) : IFixProcessor.Pack(builder, _o.FixProcessor);
			TBtNode child_type = (_o.Child == null) ? TBtNode.NONE : _o.Child.Type;
			int childOffset = (_o.Child == null) ? 0 : TBtNodeUnion.Pack(builder, _o.Child);
			Offset<IConditionGroup> exitConditionOffset = (_o.ExitCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.ExitCondition);
			return IRepeaterBtNode.CreateIRepeaterBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, child_type, childOffset, _o.MaxRepeatTimes, exitConditionOffset, _o.NullMask);
		}

		// Token: 0x0400BC31 RID: 48177
		private Table __p;
	}
}
