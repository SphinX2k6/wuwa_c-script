using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004112 RID: 16658
	public struct IAlwaysFalseBtNode : IFlatbufferObject
	{
		// Token: 0x170070C1 RID: 28865
		// (get) Token: 0x06016D5B RID: 93531 RVA: 0x00342854 File Offset: 0x00340A54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016D5C RID: 93532 RVA: 0x00342861 File Offset: 0x00340A61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016D5D RID: 93533 RVA: 0x00342868 File Offset: 0x00340A68
		public static IAlwaysFalseBtNode GetRootAsIAlwaysFalseBtNode(ByteBuffer _bb)
		{
			return IAlwaysFalseBtNode.GetRootAsIAlwaysFalseBtNode(_bb, default(IAlwaysFalseBtNode));
		}

		// Token: 0x06016D5E RID: 93534 RVA: 0x00342884 File Offset: 0x00340A84
		public static IAlwaysFalseBtNode GetRootAsIAlwaysFalseBtNode(ByteBuffer _bb, IAlwaysFalseBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016D5F RID: 93535 RVA: 0x003428A1 File Offset: 0x00340AA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016D60 RID: 93536 RVA: 0x003428B0 File Offset: 0x00340AB0
		public IAlwaysFalseBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070C2 RID: 28866
		// (get) Token: 0x06016D61 RID: 93537 RVA: 0x003428C0 File Offset: 0x00340AC0
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

		// Token: 0x170070C3 RID: 28867
		// (get) Token: 0x06016D62 RID: 93538 RVA: 0x003428FC File Offset: 0x00340AFC
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

		// Token: 0x170070C4 RID: 28868
		// (get) Token: 0x06016D63 RID: 93539 RVA: 0x00342938 File Offset: 0x00340B38
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

		// Token: 0x06016D64 RID: 93540 RVA: 0x0034296F File Offset: 0x00340B6F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06016D65 RID: 93541 RVA: 0x0034297E File Offset: 0x00340B7E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170070C5 RID: 28869
		// (get) Token: 0x06016D66 RID: 93542 RVA: 0x0034298C File Offset: 0x00340B8C
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

		// Token: 0x170070C6 RID: 28870
		// (get) Token: 0x06016D67 RID: 93543 RVA: 0x003429EC File Offset: 0x00340BEC
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170070C7 RID: 28871
		// (get) Token: 0x06016D68 RID: 93544 RVA: 0x00342A2C File Offset: 0x00340C2C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170070C8 RID: 28872
		// (get) Token: 0x06016D69 RID: 93545 RVA: 0x00342A6C File Offset: 0x00340C6C
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

		// Token: 0x06016D6A RID: 93546 RVA: 0x00342AAC File Offset: 0x00340CAC
		public TTable? Child<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016D6B RID: 93547 RVA: 0x00342AF4 File Offset: 0x00340CF4
		public IActionBtNode ChildAsIActionBtNode()
		{
			return this.Child<IActionBtNode>().Value;
		}

		// Token: 0x06016D6C RID: 93548 RVA: 0x00342B10 File Offset: 0x00340D10
		public IActionWithResultBtNode ChildAsIActionWithResultBtNode()
		{
			return this.Child<IActionWithResultBtNode>().Value;
		}

		// Token: 0x06016D6D RID: 93549 RVA: 0x00342B2C File Offset: 0x00340D2C
		public IAlwaysFalseBtNode ChildAsIAlwaysFalseBtNode()
		{
			return this.Child<IAlwaysFalseBtNode>().Value;
		}

		// Token: 0x06016D6E RID: 93550 RVA: 0x00342B48 File Offset: 0x00340D48
		public IAlwaysTrueBtNode ChildAsIAlwaysTrueBtNode()
		{
			return this.Child<IAlwaysTrueBtNode>().Value;
		}

		// Token: 0x06016D6F RID: 93551 RVA: 0x00342B64 File Offset: 0x00340D64
		public IChildQuestBtNode ChildAsIChildQuestBtNode()
		{
			return this.Child<IChildQuestBtNode>().Value;
		}

		// Token: 0x06016D70 RID: 93552 RVA: 0x00342B80 File Offset: 0x00340D80
		public IConditionBtNode ChildAsIConditionBtNode()
		{
			return this.Child<IConditionBtNode>().Value;
		}

		// Token: 0x06016D71 RID: 93553 RVA: 0x00342B9C File Offset: 0x00340D9C
		public IConditionSelectorBtNode ChildAsIConditionSelectorBtNode()
		{
			return this.Child<IConditionSelectorBtNode>().Value;
		}

		// Token: 0x06016D72 RID: 93554 RVA: 0x00342BB8 File Offset: 0x00340DB8
		public IParallelSelectBtNode ChildAsIParallelSelectBtNode()
		{
			return this.Child<IParallelSelectBtNode>().Value;
		}

		// Token: 0x06016D73 RID: 93555 RVA: 0x00342BD4 File Offset: 0x00340DD4
		public IQuestFailedBtNode ChildAsIQuestFailedBtNode()
		{
			return this.Child<IQuestFailedBtNode>().Value;
		}

		// Token: 0x06016D74 RID: 93556 RVA: 0x00342BF0 File Offset: 0x00340DF0
		public IQuestSucceedBtNode ChildAsIQuestSucceedBtNode()
		{
			return this.Child<IQuestSucceedBtNode>().Value;
		}

		// Token: 0x06016D75 RID: 93557 RVA: 0x00342C0C File Offset: 0x00340E0C
		public IRepeaterBtNode ChildAsIRepeaterBtNode()
		{
			return this.Child<IRepeaterBtNode>().Value;
		}

		// Token: 0x06016D76 RID: 93558 RVA: 0x00342C28 File Offset: 0x00340E28
		public ISelectBtNode ChildAsISelectBtNode()
		{
			return this.Child<ISelectBtNode>().Value;
		}

		// Token: 0x06016D77 RID: 93559 RVA: 0x00342C44 File Offset: 0x00340E44
		public ISequenceBtNode ChildAsISequenceBtNode()
		{
			return this.Child<ISequenceBtNode>().Value;
		}

		// Token: 0x06016D78 RID: 93560 RVA: 0x00342C60 File Offset: 0x00340E60
		public IStartBtNode ChildAsIStartBtNode()
		{
			return this.Child<IStartBtNode>().Value;
		}

		// Token: 0x170070C9 RID: 28873
		// (get) Token: 0x06016D79 RID: 93561 RVA: 0x00342C7C File Offset: 0x00340E7C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016D7A RID: 93562 RVA: 0x00342CBC File Offset: 0x00340EBC
		public static Offset<IAlwaysFalseBtNode> CreateIAlwaysFalseBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, TBtNode Child_type = TBtNode.NONE, int ChildOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			IAlwaysFalseBtNode.AddChild(builder, ChildOffset);
			IAlwaysFalseBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IAlwaysFalseBtNode.AddDesc(builder, DescOffset);
			IAlwaysFalseBtNode.AddId(builder, Id);
			IAlwaysFalseBtNode.AddNullMask(builder, NullMask);
			IAlwaysFalseBtNode.AddChildType(builder, Child_type);
			IAlwaysFalseBtNode.AddDisabled(builder, Disabled);
			IAlwaysFalseBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IAlwaysFalseBtNode.AddType(builder, Type);
			return IAlwaysFalseBtNode.EndIAlwaysFalseBtNode(builder);
		}

		// Token: 0x06016D7B RID: 93563 RVA: 0x00342D1C File Offset: 0x00340F1C
		public static void StartIAlwaysFalseBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06016D7C RID: 93564 RVA: 0x00342D26 File Offset: 0x00340F26
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016D7D RID: 93565 RVA: 0x00342D31 File Offset: 0x00340F31
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06016D7E RID: 93566 RVA: 0x00342D3C File Offset: 0x00340F3C
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06016D7F RID: 93567 RVA: 0x00342D4C File Offset: 0x00340F4C
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06016D80 RID: 93568 RVA: 0x00342D5C File Offset: 0x00340F5C
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06016D81 RID: 93569 RVA: 0x00342D67 File Offset: 0x00340F67
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06016D82 RID: 93570 RVA: 0x00342D72 File Offset: 0x00340F72
		public static void AddChildType(FlatBufferBuilder builder, TBtNode childType)
		{
			builder.AddByte(6, (byte)childType, 0);
		}

		// Token: 0x06016D83 RID: 93571 RVA: 0x00342D7D File Offset: 0x00340F7D
		public static void AddChild(FlatBufferBuilder builder, int childOffset)
		{
			builder.AddOffset(7, childOffset, 0);
		}

		// Token: 0x06016D84 RID: 93572 RVA: 0x00342D88 File Offset: 0x00340F88
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06016D85 RID: 93573 RVA: 0x00342D93 File Offset: 0x00340F93
		public static Offset<IAlwaysFalseBtNode> EndIAlwaysFalseBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IAlwaysFalseBtNode>(builder.EndTable());
		}

		// Token: 0x06016D86 RID: 93574 RVA: 0x00342DA0 File Offset: 0x00340FA0
		public IAlwaysFalseBtNodeT UnPack()
		{
			IAlwaysFalseBtNodeT alwaysFalseBtNodeT = new IAlwaysFalseBtNodeT();
			this.UnPackTo(alwaysFalseBtNodeT);
			return alwaysFalseBtNodeT;
		}

		// Token: 0x06016D87 RID: 93575 RVA: 0x00342DBC File Offset: 0x00340FBC
		public void UnPackTo(IAlwaysFalseBtNodeT _o)
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016D88 RID: 93576 RVA: 0x003431E4 File Offset: 0x003413E4
		public static Offset<IAlwaysFalseBtNode> Pack(FlatBufferBuilder builder, IAlwaysFalseBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAlwaysFalseBtNode>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<IFixProcessor>) : IFixProcessor.Pack(builder, _o.FixProcessor);
			TBtNode child_type = (_o.Child == null) ? TBtNode.NONE : _o.Child.Type;
			int childOffset = (_o.Child == null) ? 0 : TBtNodeUnion.Pack(builder, _o.Child);
			return IAlwaysFalseBtNode.CreateIAlwaysFalseBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, child_type, childOffset, _o.NullMask);
		}

		// Token: 0x0400BF4D RID: 48973
		private Table __p;
	}
}
