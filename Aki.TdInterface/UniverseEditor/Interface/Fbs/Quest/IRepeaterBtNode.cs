using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044E4 RID: 17636
	public struct IRepeaterBtNode : IFlatbufferObject
	{
		// Token: 0x17007AC6 RID: 31430
		// (get) Token: 0x0601980E RID: 104462 RVA: 0x003A302B File Offset: 0x003A122B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601980F RID: 104463 RVA: 0x003A3038 File Offset: 0x003A1238
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019810 RID: 104464 RVA: 0x003A3040 File Offset: 0x003A1240
		public static IRepeaterBtNode GetRootAsIRepeaterBtNode(ByteBuffer _bb)
		{
			return IRepeaterBtNode.GetRootAsIRepeaterBtNode(_bb, default(IRepeaterBtNode));
		}

		// Token: 0x06019811 RID: 104465 RVA: 0x003A305C File Offset: 0x003A125C
		public static IRepeaterBtNode GetRootAsIRepeaterBtNode(ByteBuffer _bb, IRepeaterBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019812 RID: 104466 RVA: 0x003A3079 File Offset: 0x003A1279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019813 RID: 104467 RVA: 0x003A3088 File Offset: 0x003A1288
		public IRepeaterBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AC7 RID: 31431
		// (get) Token: 0x06019814 RID: 104468 RVA: 0x003A3098 File Offset: 0x003A1298
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

		// Token: 0x17007AC8 RID: 31432
		// (get) Token: 0x06019815 RID: 104469 RVA: 0x003A30D4 File Offset: 0x003A12D4
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

		// Token: 0x17007AC9 RID: 31433
		// (get) Token: 0x06019816 RID: 104470 RVA: 0x003A3110 File Offset: 0x003A1310
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

		// Token: 0x06019817 RID: 104471 RVA: 0x003A3147 File Offset: 0x003A1347
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06019818 RID: 104472 RVA: 0x003A3156 File Offset: 0x003A1356
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007ACA RID: 31434
		// (get) Token: 0x06019819 RID: 104473 RVA: 0x003A3164 File Offset: 0x003A1364
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

		// Token: 0x17007ACB RID: 31435
		// (get) Token: 0x0601981A RID: 104474 RVA: 0x003A31C4 File Offset: 0x003A13C4
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007ACC RID: 31436
		// (get) Token: 0x0601981B RID: 104475 RVA: 0x003A3204 File Offset: 0x003A1404
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007ACD RID: 31437
		// (get) Token: 0x0601981C RID: 104476 RVA: 0x003A3244 File Offset: 0x003A1444
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

		// Token: 0x0601981D RID: 104477 RVA: 0x003A3284 File Offset: 0x003A1484
		public TTable? Child<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601981E RID: 104478 RVA: 0x003A32CC File Offset: 0x003A14CC
		public IActionBtNode ChildAsIActionBtNode()
		{
			return this.Child<IActionBtNode>().Value;
		}

		// Token: 0x0601981F RID: 104479 RVA: 0x003A32E8 File Offset: 0x003A14E8
		public IActionWithResultBtNode ChildAsIActionWithResultBtNode()
		{
			return this.Child<IActionWithResultBtNode>().Value;
		}

		// Token: 0x06019820 RID: 104480 RVA: 0x003A3304 File Offset: 0x003A1504
		public IAlwaysFalseBtNode ChildAsIAlwaysFalseBtNode()
		{
			return this.Child<IAlwaysFalseBtNode>().Value;
		}

		// Token: 0x06019821 RID: 104481 RVA: 0x003A3320 File Offset: 0x003A1520
		public IAlwaysTrueBtNode ChildAsIAlwaysTrueBtNode()
		{
			return this.Child<IAlwaysTrueBtNode>().Value;
		}

		// Token: 0x06019822 RID: 104482 RVA: 0x003A333C File Offset: 0x003A153C
		public IChildQuestBtNode ChildAsIChildQuestBtNode()
		{
			return this.Child<IChildQuestBtNode>().Value;
		}

		// Token: 0x06019823 RID: 104483 RVA: 0x003A3358 File Offset: 0x003A1558
		public IConditionBtNode ChildAsIConditionBtNode()
		{
			return this.Child<IConditionBtNode>().Value;
		}

		// Token: 0x06019824 RID: 104484 RVA: 0x003A3374 File Offset: 0x003A1574
		public IConditionSelectorBtNode ChildAsIConditionSelectorBtNode()
		{
			return this.Child<IConditionSelectorBtNode>().Value;
		}

		// Token: 0x06019825 RID: 104485 RVA: 0x003A3390 File Offset: 0x003A1590
		public IParallelSelectBtNode ChildAsIParallelSelectBtNode()
		{
			return this.Child<IParallelSelectBtNode>().Value;
		}

		// Token: 0x06019826 RID: 104486 RVA: 0x003A33AC File Offset: 0x003A15AC
		public IQuestFailedBtNode ChildAsIQuestFailedBtNode()
		{
			return this.Child<IQuestFailedBtNode>().Value;
		}

		// Token: 0x06019827 RID: 104487 RVA: 0x003A33C8 File Offset: 0x003A15C8
		public IQuestSucceedBtNode ChildAsIQuestSucceedBtNode()
		{
			return this.Child<IQuestSucceedBtNode>().Value;
		}

		// Token: 0x06019828 RID: 104488 RVA: 0x003A33E4 File Offset: 0x003A15E4
		public IRepeaterBtNode ChildAsIRepeaterBtNode()
		{
			return this.Child<IRepeaterBtNode>().Value;
		}

		// Token: 0x06019829 RID: 104489 RVA: 0x003A3400 File Offset: 0x003A1600
		public ISelectBtNode ChildAsISelectBtNode()
		{
			return this.Child<ISelectBtNode>().Value;
		}

		// Token: 0x0601982A RID: 104490 RVA: 0x003A341C File Offset: 0x003A161C
		public ISequenceBtNode ChildAsISequenceBtNode()
		{
			return this.Child<ISequenceBtNode>().Value;
		}

		// Token: 0x0601982B RID: 104491 RVA: 0x003A3438 File Offset: 0x003A1638
		public IStartBtNode ChildAsIStartBtNode()
		{
			return this.Child<IStartBtNode>().Value;
		}

		// Token: 0x17007ACE RID: 31438
		// (get) Token: 0x0601982C RID: 104492 RVA: 0x003A3454 File Offset: 0x003A1654
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

		// Token: 0x17007ACF RID: 31439
		// (get) Token: 0x0601982D RID: 104493 RVA: 0x003A3494 File Offset: 0x003A1694
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

		// Token: 0x17007AD0 RID: 31440
		// (get) Token: 0x0601982E RID: 104494 RVA: 0x003A34F4 File Offset: 0x003A16F4
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

		// Token: 0x0601982F RID: 104495 RVA: 0x003A3534 File Offset: 0x003A1734
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

		// Token: 0x06019830 RID: 104496 RVA: 0x003A35A4 File Offset: 0x003A17A4
		public static void StartIRepeaterBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06019831 RID: 104497 RVA: 0x003A35AE File Offset: 0x003A17AE
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019832 RID: 104498 RVA: 0x003A35B9 File Offset: 0x003A17B9
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06019833 RID: 104499 RVA: 0x003A35C4 File Offset: 0x003A17C4
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06019834 RID: 104500 RVA: 0x003A35D4 File Offset: 0x003A17D4
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06019835 RID: 104501 RVA: 0x003A35E4 File Offset: 0x003A17E4
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06019836 RID: 104502 RVA: 0x003A35EF File Offset: 0x003A17EF
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06019837 RID: 104503 RVA: 0x003A35FA File Offset: 0x003A17FA
		public static void AddChildType(FlatBufferBuilder builder, TBtNode childType)
		{
			builder.AddByte(6, (byte)childType, 0);
		}

		// Token: 0x06019838 RID: 104504 RVA: 0x003A3605 File Offset: 0x003A1805
		public static void AddChild(FlatBufferBuilder builder, int childOffset)
		{
			builder.AddOffset(7, childOffset, 0);
		}

		// Token: 0x06019839 RID: 104505 RVA: 0x003A3610 File Offset: 0x003A1810
		public static void AddMaxRepeatTimes(FlatBufferBuilder builder, int maxRepeatTimes)
		{
			builder.AddInt(8, maxRepeatTimes, 0);
		}

		// Token: 0x0601983A RID: 104506 RVA: 0x003A361B File Offset: 0x003A181B
		public static void AddExitCondition(FlatBufferBuilder builder, Offset<IConditionGroup> exitConditionOffset)
		{
			builder.AddOffset(9, exitConditionOffset.Value, 0);
		}

		// Token: 0x0601983B RID: 104507 RVA: 0x003A362C File Offset: 0x003A182C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x0601983C RID: 104508 RVA: 0x003A3638 File Offset: 0x003A1838
		public static Offset<IRepeaterBtNode> EndIRepeaterBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IRepeaterBtNode>(builder.EndTable());
		}

		// Token: 0x0601983D RID: 104509 RVA: 0x003A3648 File Offset: 0x003A1848
		public IRepeaterBtNodeT UnPack()
		{
			IRepeaterBtNodeT repeaterBtNodeT = new IRepeaterBtNodeT();
			this.UnPackTo(repeaterBtNodeT);
			return repeaterBtNodeT;
		}

		// Token: 0x0601983E RID: 104510 RVA: 0x003A3664 File Offset: 0x003A1864
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

		// Token: 0x0601983F RID: 104511 RVA: 0x003A3ACC File Offset: 0x003A1CCC
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

		// Token: 0x0400C61A RID: 50714
		private Table __p;
	}
}
