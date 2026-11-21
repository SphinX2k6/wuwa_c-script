using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004589 RID: 17801
	public struct IStartBtNode : IFlatbufferObject
	{
		// Token: 0x17007C5D RID: 31837
		// (get) Token: 0x06019EDA RID: 106202 RVA: 0x003B273D File Offset: 0x003B093D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019EDB RID: 106203 RVA: 0x003B274A File Offset: 0x003B094A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019EDC RID: 106204 RVA: 0x003B2754 File Offset: 0x003B0954
		public static IStartBtNode GetRootAsIStartBtNode(ByteBuffer _bb)
		{
			return IStartBtNode.GetRootAsIStartBtNode(_bb, default(IStartBtNode));
		}

		// Token: 0x06019EDD RID: 106205 RVA: 0x003B2770 File Offset: 0x003B0970
		public static IStartBtNode GetRootAsIStartBtNode(ByteBuffer _bb, IStartBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019EDE RID: 106206 RVA: 0x003B278D File Offset: 0x003B098D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019EDF RID: 106207 RVA: 0x003B279C File Offset: 0x003B099C
		public IStartBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C5E RID: 31838
		// (get) Token: 0x06019EE0 RID: 106208 RVA: 0x003B27AC File Offset: 0x003B09AC
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

		// Token: 0x17007C5F RID: 31839
		// (get) Token: 0x06019EE1 RID: 106209 RVA: 0x003B27E8 File Offset: 0x003B09E8
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

		// Token: 0x17007C60 RID: 31840
		// (get) Token: 0x06019EE2 RID: 106210 RVA: 0x003B2824 File Offset: 0x003B0A24
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

		// Token: 0x06019EE3 RID: 106211 RVA: 0x003B285B File Offset: 0x003B0A5B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06019EE4 RID: 106212 RVA: 0x003B286A File Offset: 0x003B0A6A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007C61 RID: 31841
		// (get) Token: 0x06019EE5 RID: 106213 RVA: 0x003B2878 File Offset: 0x003B0A78
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

		// Token: 0x17007C62 RID: 31842
		// (get) Token: 0x06019EE6 RID: 106214 RVA: 0x003B28D8 File Offset: 0x003B0AD8
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007C63 RID: 31843
		// (get) Token: 0x06019EE7 RID: 106215 RVA: 0x003B2918 File Offset: 0x003B0B18
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007C64 RID: 31844
		// (get) Token: 0x06019EE8 RID: 106216 RVA: 0x003B2958 File Offset: 0x003B0B58
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

		// Token: 0x06019EE9 RID: 106217 RVA: 0x003B2998 File Offset: 0x003B0B98
		public TTable? Child<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019EEA RID: 106218 RVA: 0x003B29E0 File Offset: 0x003B0BE0
		public IActionBtNode ChildAsIActionBtNode()
		{
			return this.Child<IActionBtNode>().Value;
		}

		// Token: 0x06019EEB RID: 106219 RVA: 0x003B29FC File Offset: 0x003B0BFC
		public IActionWithResultBtNode ChildAsIActionWithResultBtNode()
		{
			return this.Child<IActionWithResultBtNode>().Value;
		}

		// Token: 0x06019EEC RID: 106220 RVA: 0x003B2A18 File Offset: 0x003B0C18
		public IAlwaysFalseBtNode ChildAsIAlwaysFalseBtNode()
		{
			return this.Child<IAlwaysFalseBtNode>().Value;
		}

		// Token: 0x06019EED RID: 106221 RVA: 0x003B2A34 File Offset: 0x003B0C34
		public IAlwaysTrueBtNode ChildAsIAlwaysTrueBtNode()
		{
			return this.Child<IAlwaysTrueBtNode>().Value;
		}

		// Token: 0x06019EEE RID: 106222 RVA: 0x003B2A50 File Offset: 0x003B0C50
		public IChildQuestBtNode ChildAsIChildQuestBtNode()
		{
			return this.Child<IChildQuestBtNode>().Value;
		}

		// Token: 0x06019EEF RID: 106223 RVA: 0x003B2A6C File Offset: 0x003B0C6C
		public IConditionBtNode ChildAsIConditionBtNode()
		{
			return this.Child<IConditionBtNode>().Value;
		}

		// Token: 0x06019EF0 RID: 106224 RVA: 0x003B2A88 File Offset: 0x003B0C88
		public IConditionSelectorBtNode ChildAsIConditionSelectorBtNode()
		{
			return this.Child<IConditionSelectorBtNode>().Value;
		}

		// Token: 0x06019EF1 RID: 106225 RVA: 0x003B2AA4 File Offset: 0x003B0CA4
		public IParallelSelectBtNode ChildAsIParallelSelectBtNode()
		{
			return this.Child<IParallelSelectBtNode>().Value;
		}

		// Token: 0x06019EF2 RID: 106226 RVA: 0x003B2AC0 File Offset: 0x003B0CC0
		public IQuestFailedBtNode ChildAsIQuestFailedBtNode()
		{
			return this.Child<IQuestFailedBtNode>().Value;
		}

		// Token: 0x06019EF3 RID: 106227 RVA: 0x003B2ADC File Offset: 0x003B0CDC
		public IQuestSucceedBtNode ChildAsIQuestSucceedBtNode()
		{
			return this.Child<IQuestSucceedBtNode>().Value;
		}

		// Token: 0x06019EF4 RID: 106228 RVA: 0x003B2AF8 File Offset: 0x003B0CF8
		public IRepeaterBtNode ChildAsIRepeaterBtNode()
		{
			return this.Child<IRepeaterBtNode>().Value;
		}

		// Token: 0x06019EF5 RID: 106229 RVA: 0x003B2B14 File Offset: 0x003B0D14
		public ISelectBtNode ChildAsISelectBtNode()
		{
			return this.Child<ISelectBtNode>().Value;
		}

		// Token: 0x06019EF6 RID: 106230 RVA: 0x003B2B30 File Offset: 0x003B0D30
		public ISequenceBtNode ChildAsISequenceBtNode()
		{
			return this.Child<ISequenceBtNode>().Value;
		}

		// Token: 0x06019EF7 RID: 106231 RVA: 0x003B2B4C File Offset: 0x003B0D4C
		public IStartBtNode ChildAsIStartBtNode()
		{
			return this.Child<IStartBtNode>().Value;
		}

		// Token: 0x17007C65 RID: 31845
		// (get) Token: 0x06019EF8 RID: 106232 RVA: 0x003B2B68 File Offset: 0x003B0D68
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

		// Token: 0x06019EF9 RID: 106233 RVA: 0x003B2BA8 File Offset: 0x003B0DA8
		public static Offset<IStartBtNode> CreateIStartBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, TBtNode Child_type = TBtNode.NONE, int ChildOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			IStartBtNode.AddChild(builder, ChildOffset);
			IStartBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IStartBtNode.AddDesc(builder, DescOffset);
			IStartBtNode.AddId(builder, Id);
			IStartBtNode.AddNullMask(builder, NullMask);
			IStartBtNode.AddChildType(builder, Child_type);
			IStartBtNode.AddDisabled(builder, Disabled);
			IStartBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IStartBtNode.AddType(builder, Type);
			return IStartBtNode.EndIStartBtNode(builder);
		}

		// Token: 0x06019EFA RID: 106234 RVA: 0x003B2C08 File Offset: 0x003B0E08
		public static void StartIStartBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06019EFB RID: 106235 RVA: 0x003B2C12 File Offset: 0x003B0E12
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019EFC RID: 106236 RVA: 0x003B2C1D File Offset: 0x003B0E1D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06019EFD RID: 106237 RVA: 0x003B2C28 File Offset: 0x003B0E28
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06019EFE RID: 106238 RVA: 0x003B2C38 File Offset: 0x003B0E38
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06019EFF RID: 106239 RVA: 0x003B2C48 File Offset: 0x003B0E48
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06019F00 RID: 106240 RVA: 0x003B2C53 File Offset: 0x003B0E53
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06019F01 RID: 106241 RVA: 0x003B2C5E File Offset: 0x003B0E5E
		public static void AddChildType(FlatBufferBuilder builder, TBtNode childType)
		{
			builder.AddByte(6, (byte)childType, 0);
		}

		// Token: 0x06019F02 RID: 106242 RVA: 0x003B2C69 File Offset: 0x003B0E69
		public static void AddChild(FlatBufferBuilder builder, int childOffset)
		{
			builder.AddOffset(7, childOffset, 0);
		}

		// Token: 0x06019F03 RID: 106243 RVA: 0x003B2C74 File Offset: 0x003B0E74
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06019F04 RID: 106244 RVA: 0x003B2C7F File Offset: 0x003B0E7F
		public static Offset<IStartBtNode> EndIStartBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IStartBtNode>(builder.EndTable());
		}

		// Token: 0x06019F05 RID: 106245 RVA: 0x003B2C8C File Offset: 0x003B0E8C
		public IStartBtNodeT UnPack()
		{
			IStartBtNodeT startBtNodeT = new IStartBtNodeT();
			this.UnPackTo(startBtNodeT);
			return startBtNodeT;
		}

		// Token: 0x06019F06 RID: 106246 RVA: 0x003B2CA8 File Offset: 0x003B0EA8
		public void UnPackTo(IStartBtNodeT _o)
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

		// Token: 0x06019F07 RID: 106247 RVA: 0x003B30D0 File Offset: 0x003B12D0
		public static Offset<IStartBtNode> Pack(FlatBufferBuilder builder, IStartBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStartBtNode>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<IFixProcessor>) : IFixProcessor.Pack(builder, _o.FixProcessor);
			TBtNode child_type = (_o.Child == null) ? TBtNode.NONE : _o.Child.Type;
			int childOffset = (_o.Child == null) ? 0 : TBtNodeUnion.Pack(builder, _o.Child);
			return IStartBtNode.CreateIStartBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, child_type, childOffset, _o.NullMask);
		}

		// Token: 0x0400C73C RID: 51004
		private Table __p;
	}
}
