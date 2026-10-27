using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CFB RID: 15611
	public struct IAlwaysFalseBtNode : IFlatbufferObject
	{
		// Token: 0x17006B07 RID: 27399
		// (get) Token: 0x06015823 RID: 88099 RVA: 0x0031B5DC File Offset: 0x003197DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015824 RID: 88100 RVA: 0x0031B5E9 File Offset: 0x003197E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015825 RID: 88101 RVA: 0x0031B5F0 File Offset: 0x003197F0
		public static IAlwaysFalseBtNode GetRootAsIAlwaysFalseBtNode(ByteBuffer _bb)
		{
			return IAlwaysFalseBtNode.GetRootAsIAlwaysFalseBtNode(_bb, default(IAlwaysFalseBtNode));
		}

		// Token: 0x06015826 RID: 88102 RVA: 0x0031B60C File Offset: 0x0031980C
		public static IAlwaysFalseBtNode GetRootAsIAlwaysFalseBtNode(ByteBuffer _bb, IAlwaysFalseBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015827 RID: 88103 RVA: 0x0031B629 File Offset: 0x00319829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015828 RID: 88104 RVA: 0x0031B638 File Offset: 0x00319838
		public IAlwaysFalseBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B08 RID: 27400
		// (get) Token: 0x06015829 RID: 88105 RVA: 0x0031B648 File Offset: 0x00319848
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

		// Token: 0x17006B09 RID: 27401
		// (get) Token: 0x0601582A RID: 88106 RVA: 0x0031B684 File Offset: 0x00319884
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

		// Token: 0x17006B0A RID: 27402
		// (get) Token: 0x0601582B RID: 88107 RVA: 0x0031B6C0 File Offset: 0x003198C0
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

		// Token: 0x0601582C RID: 88108 RVA: 0x0031B6F7 File Offset: 0x003198F7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601582D RID: 88109 RVA: 0x0031B706 File Offset: 0x00319906
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17006B0B RID: 27403
		// (get) Token: 0x0601582E RID: 88110 RVA: 0x0031B714 File Offset: 0x00319914
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

		// Token: 0x17006B0C RID: 27404
		// (get) Token: 0x0601582F RID: 88111 RVA: 0x0031B774 File Offset: 0x00319974
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006B0D RID: 27405
		// (get) Token: 0x06015830 RID: 88112 RVA: 0x0031B7B4 File Offset: 0x003199B4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006B0E RID: 27406
		// (get) Token: 0x06015831 RID: 88113 RVA: 0x0031B7F4 File Offset: 0x003199F4
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

		// Token: 0x06015832 RID: 88114 RVA: 0x0031B834 File Offset: 0x00319A34
		public TTable? Child<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015833 RID: 88115 RVA: 0x0031B87C File Offset: 0x00319A7C
		public IActionBtNode ChildAsIActionBtNode()
		{
			return this.Child<IActionBtNode>().Value;
		}

		// Token: 0x06015834 RID: 88116 RVA: 0x0031B898 File Offset: 0x00319A98
		public IActionWithResultBtNode ChildAsIActionWithResultBtNode()
		{
			return this.Child<IActionWithResultBtNode>().Value;
		}

		// Token: 0x06015835 RID: 88117 RVA: 0x0031B8B4 File Offset: 0x00319AB4
		public IAlwaysFalseBtNode ChildAsIAlwaysFalseBtNode()
		{
			return this.Child<IAlwaysFalseBtNode>().Value;
		}

		// Token: 0x06015836 RID: 88118 RVA: 0x0031B8D0 File Offset: 0x00319AD0
		public IAlwaysTrueBtNode ChildAsIAlwaysTrueBtNode()
		{
			return this.Child<IAlwaysTrueBtNode>().Value;
		}

		// Token: 0x06015837 RID: 88119 RVA: 0x0031B8EC File Offset: 0x00319AEC
		public IChildQuestBtNode ChildAsIChildQuestBtNode()
		{
			return this.Child<IChildQuestBtNode>().Value;
		}

		// Token: 0x06015838 RID: 88120 RVA: 0x0031B908 File Offset: 0x00319B08
		public IConditionBtNode ChildAsIConditionBtNode()
		{
			return this.Child<IConditionBtNode>().Value;
		}

		// Token: 0x06015839 RID: 88121 RVA: 0x0031B924 File Offset: 0x00319B24
		public IConditionSelectorBtNode ChildAsIConditionSelectorBtNode()
		{
			return this.Child<IConditionSelectorBtNode>().Value;
		}

		// Token: 0x0601583A RID: 88122 RVA: 0x0031B940 File Offset: 0x00319B40
		public IParallelSelectBtNode ChildAsIParallelSelectBtNode()
		{
			return this.Child<IParallelSelectBtNode>().Value;
		}

		// Token: 0x0601583B RID: 88123 RVA: 0x0031B95C File Offset: 0x00319B5C
		public IQuestFailedBtNode ChildAsIQuestFailedBtNode()
		{
			return this.Child<IQuestFailedBtNode>().Value;
		}

		// Token: 0x0601583C RID: 88124 RVA: 0x0031B978 File Offset: 0x00319B78
		public IQuestSucceedBtNode ChildAsIQuestSucceedBtNode()
		{
			return this.Child<IQuestSucceedBtNode>().Value;
		}

		// Token: 0x0601583D RID: 88125 RVA: 0x0031B994 File Offset: 0x00319B94
		public IRepeaterBtNode ChildAsIRepeaterBtNode()
		{
			return this.Child<IRepeaterBtNode>().Value;
		}

		// Token: 0x0601583E RID: 88126 RVA: 0x0031B9B0 File Offset: 0x00319BB0
		public ISelectBtNode ChildAsISelectBtNode()
		{
			return this.Child<ISelectBtNode>().Value;
		}

		// Token: 0x0601583F RID: 88127 RVA: 0x0031B9CC File Offset: 0x00319BCC
		public ISequenceBtNode ChildAsISequenceBtNode()
		{
			return this.Child<ISequenceBtNode>().Value;
		}

		// Token: 0x06015840 RID: 88128 RVA: 0x0031B9E8 File Offset: 0x00319BE8
		public IStartBtNode ChildAsIStartBtNode()
		{
			return this.Child<IStartBtNode>().Value;
		}

		// Token: 0x17006B0F RID: 27407
		// (get) Token: 0x06015841 RID: 88129 RVA: 0x0031BA04 File Offset: 0x00319C04
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

		// Token: 0x06015842 RID: 88130 RVA: 0x0031BA44 File Offset: 0x00319C44
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

		// Token: 0x06015843 RID: 88131 RVA: 0x0031BAA4 File Offset: 0x00319CA4
		public static void StartIAlwaysFalseBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06015844 RID: 88132 RVA: 0x0031BAAE File Offset: 0x00319CAE
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015845 RID: 88133 RVA: 0x0031BAB9 File Offset: 0x00319CB9
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06015846 RID: 88134 RVA: 0x0031BAC4 File Offset: 0x00319CC4
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06015847 RID: 88135 RVA: 0x0031BAD4 File Offset: 0x00319CD4
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06015848 RID: 88136 RVA: 0x0031BAE4 File Offset: 0x00319CE4
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06015849 RID: 88137 RVA: 0x0031BAEF File Offset: 0x00319CEF
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x0601584A RID: 88138 RVA: 0x0031BAFA File Offset: 0x00319CFA
		public static void AddChildType(FlatBufferBuilder builder, TBtNode childType)
		{
			builder.AddByte(6, (byte)childType, 0);
		}

		// Token: 0x0601584B RID: 88139 RVA: 0x0031BB05 File Offset: 0x00319D05
		public static void AddChild(FlatBufferBuilder builder, int childOffset)
		{
			builder.AddOffset(7, childOffset, 0);
		}

		// Token: 0x0601584C RID: 88140 RVA: 0x0031BB10 File Offset: 0x00319D10
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601584D RID: 88141 RVA: 0x0031BB1B File Offset: 0x00319D1B
		public static Offset<IAlwaysFalseBtNode> EndIAlwaysFalseBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IAlwaysFalseBtNode>(builder.EndTable());
		}

		// Token: 0x0601584E RID: 88142 RVA: 0x0031BB28 File Offset: 0x00319D28
		public IAlwaysFalseBtNodeT UnPack()
		{
			IAlwaysFalseBtNodeT alwaysFalseBtNodeT = new IAlwaysFalseBtNodeT();
			this.UnPackTo(alwaysFalseBtNodeT);
			return alwaysFalseBtNodeT;
		}

		// Token: 0x0601584F RID: 88143 RVA: 0x0031BB44 File Offset: 0x00319D44
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

		// Token: 0x06015850 RID: 88144 RVA: 0x0031BF6C File Offset: 0x0031A16C
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

		// Token: 0x0400B5A0 RID: 46496
		private Table __p;
	}
}
