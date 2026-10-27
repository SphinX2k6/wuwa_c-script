using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CFE RID: 15614
	public struct IAlwaysTrueBtNode : IFlatbufferObject
	{
		// Token: 0x17006B18 RID: 27416
		// (get) Token: 0x06015863 RID: 88163 RVA: 0x0031C1CC File Offset: 0x0031A3CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015864 RID: 88164 RVA: 0x0031C1D9 File Offset: 0x0031A3D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015865 RID: 88165 RVA: 0x0031C1E0 File Offset: 0x0031A3E0
		public static IAlwaysTrueBtNode GetRootAsIAlwaysTrueBtNode(ByteBuffer _bb)
		{
			return IAlwaysTrueBtNode.GetRootAsIAlwaysTrueBtNode(_bb, default(IAlwaysTrueBtNode));
		}

		// Token: 0x06015866 RID: 88166 RVA: 0x0031C1FC File Offset: 0x0031A3FC
		public static IAlwaysTrueBtNode GetRootAsIAlwaysTrueBtNode(ByteBuffer _bb, IAlwaysTrueBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015867 RID: 88167 RVA: 0x0031C219 File Offset: 0x0031A419
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015868 RID: 88168 RVA: 0x0031C228 File Offset: 0x0031A428
		public IAlwaysTrueBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B19 RID: 27417
		// (get) Token: 0x06015869 RID: 88169 RVA: 0x0031C238 File Offset: 0x0031A438
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

		// Token: 0x17006B1A RID: 27418
		// (get) Token: 0x0601586A RID: 88170 RVA: 0x0031C274 File Offset: 0x0031A474
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

		// Token: 0x17006B1B RID: 27419
		// (get) Token: 0x0601586B RID: 88171 RVA: 0x0031C2B0 File Offset: 0x0031A4B0
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

		// Token: 0x0601586C RID: 88172 RVA: 0x0031C2E7 File Offset: 0x0031A4E7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601586D RID: 88173 RVA: 0x0031C2F6 File Offset: 0x0031A4F6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17006B1C RID: 27420
		// (get) Token: 0x0601586E RID: 88174 RVA: 0x0031C304 File Offset: 0x0031A504
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

		// Token: 0x17006B1D RID: 27421
		// (get) Token: 0x0601586F RID: 88175 RVA: 0x0031C364 File Offset: 0x0031A564
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006B1E RID: 27422
		// (get) Token: 0x06015870 RID: 88176 RVA: 0x0031C3A4 File Offset: 0x0031A5A4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006B1F RID: 27423
		// (get) Token: 0x06015871 RID: 88177 RVA: 0x0031C3E4 File Offset: 0x0031A5E4
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

		// Token: 0x06015872 RID: 88178 RVA: 0x0031C424 File Offset: 0x0031A624
		public TTable? Child<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015873 RID: 88179 RVA: 0x0031C46C File Offset: 0x0031A66C
		public IActionBtNode ChildAsIActionBtNode()
		{
			return this.Child<IActionBtNode>().Value;
		}

		// Token: 0x06015874 RID: 88180 RVA: 0x0031C488 File Offset: 0x0031A688
		public IActionWithResultBtNode ChildAsIActionWithResultBtNode()
		{
			return this.Child<IActionWithResultBtNode>().Value;
		}

		// Token: 0x06015875 RID: 88181 RVA: 0x0031C4A4 File Offset: 0x0031A6A4
		public IAlwaysFalseBtNode ChildAsIAlwaysFalseBtNode()
		{
			return this.Child<IAlwaysFalseBtNode>().Value;
		}

		// Token: 0x06015876 RID: 88182 RVA: 0x0031C4C0 File Offset: 0x0031A6C0
		public IAlwaysTrueBtNode ChildAsIAlwaysTrueBtNode()
		{
			return this.Child<IAlwaysTrueBtNode>().Value;
		}

		// Token: 0x06015877 RID: 88183 RVA: 0x0031C4DC File Offset: 0x0031A6DC
		public IChildQuestBtNode ChildAsIChildQuestBtNode()
		{
			return this.Child<IChildQuestBtNode>().Value;
		}

		// Token: 0x06015878 RID: 88184 RVA: 0x0031C4F8 File Offset: 0x0031A6F8
		public IConditionBtNode ChildAsIConditionBtNode()
		{
			return this.Child<IConditionBtNode>().Value;
		}

		// Token: 0x06015879 RID: 88185 RVA: 0x0031C514 File Offset: 0x0031A714
		public IConditionSelectorBtNode ChildAsIConditionSelectorBtNode()
		{
			return this.Child<IConditionSelectorBtNode>().Value;
		}

		// Token: 0x0601587A RID: 88186 RVA: 0x0031C530 File Offset: 0x0031A730
		public IParallelSelectBtNode ChildAsIParallelSelectBtNode()
		{
			return this.Child<IParallelSelectBtNode>().Value;
		}

		// Token: 0x0601587B RID: 88187 RVA: 0x0031C54C File Offset: 0x0031A74C
		public IQuestFailedBtNode ChildAsIQuestFailedBtNode()
		{
			return this.Child<IQuestFailedBtNode>().Value;
		}

		// Token: 0x0601587C RID: 88188 RVA: 0x0031C568 File Offset: 0x0031A768
		public IQuestSucceedBtNode ChildAsIQuestSucceedBtNode()
		{
			return this.Child<IQuestSucceedBtNode>().Value;
		}

		// Token: 0x0601587D RID: 88189 RVA: 0x0031C584 File Offset: 0x0031A784
		public IRepeaterBtNode ChildAsIRepeaterBtNode()
		{
			return this.Child<IRepeaterBtNode>().Value;
		}

		// Token: 0x0601587E RID: 88190 RVA: 0x0031C5A0 File Offset: 0x0031A7A0
		public ISelectBtNode ChildAsISelectBtNode()
		{
			return this.Child<ISelectBtNode>().Value;
		}

		// Token: 0x0601587F RID: 88191 RVA: 0x0031C5BC File Offset: 0x0031A7BC
		public ISequenceBtNode ChildAsISequenceBtNode()
		{
			return this.Child<ISequenceBtNode>().Value;
		}

		// Token: 0x06015880 RID: 88192 RVA: 0x0031C5D8 File Offset: 0x0031A7D8
		public IStartBtNode ChildAsIStartBtNode()
		{
			return this.Child<IStartBtNode>().Value;
		}

		// Token: 0x17006B20 RID: 27424
		// (get) Token: 0x06015881 RID: 88193 RVA: 0x0031C5F4 File Offset: 0x0031A7F4
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

		// Token: 0x06015882 RID: 88194 RVA: 0x0031C634 File Offset: 0x0031A834
		public static Offset<IAlwaysTrueBtNode> CreateIAlwaysTrueBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, TBtNode Child_type = TBtNode.NONE, int ChildOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			IAlwaysTrueBtNode.AddChild(builder, ChildOffset);
			IAlwaysTrueBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IAlwaysTrueBtNode.AddDesc(builder, DescOffset);
			IAlwaysTrueBtNode.AddId(builder, Id);
			IAlwaysTrueBtNode.AddNullMask(builder, NullMask);
			IAlwaysTrueBtNode.AddChildType(builder, Child_type);
			IAlwaysTrueBtNode.AddDisabled(builder, Disabled);
			IAlwaysTrueBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IAlwaysTrueBtNode.AddType(builder, Type);
			return IAlwaysTrueBtNode.EndIAlwaysTrueBtNode(builder);
		}

		// Token: 0x06015883 RID: 88195 RVA: 0x0031C694 File Offset: 0x0031A894
		public static void StartIAlwaysTrueBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06015884 RID: 88196 RVA: 0x0031C69E File Offset: 0x0031A89E
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015885 RID: 88197 RVA: 0x0031C6A9 File Offset: 0x0031A8A9
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06015886 RID: 88198 RVA: 0x0031C6B4 File Offset: 0x0031A8B4
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06015887 RID: 88199 RVA: 0x0031C6C4 File Offset: 0x0031A8C4
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06015888 RID: 88200 RVA: 0x0031C6D4 File Offset: 0x0031A8D4
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06015889 RID: 88201 RVA: 0x0031C6DF File Offset: 0x0031A8DF
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x0601588A RID: 88202 RVA: 0x0031C6EA File Offset: 0x0031A8EA
		public static void AddChildType(FlatBufferBuilder builder, TBtNode childType)
		{
			builder.AddByte(6, (byte)childType, 0);
		}

		// Token: 0x0601588B RID: 88203 RVA: 0x0031C6F5 File Offset: 0x0031A8F5
		public static void AddChild(FlatBufferBuilder builder, int childOffset)
		{
			builder.AddOffset(7, childOffset, 0);
		}

		// Token: 0x0601588C RID: 88204 RVA: 0x0031C700 File Offset: 0x0031A900
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601588D RID: 88205 RVA: 0x0031C70B File Offset: 0x0031A90B
		public static Offset<IAlwaysTrueBtNode> EndIAlwaysTrueBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IAlwaysTrueBtNode>(builder.EndTable());
		}

		// Token: 0x0601588E RID: 88206 RVA: 0x0031C718 File Offset: 0x0031A918
		public IAlwaysTrueBtNodeT UnPack()
		{
			IAlwaysTrueBtNodeT alwaysTrueBtNodeT = new IAlwaysTrueBtNodeT();
			this.UnPackTo(alwaysTrueBtNodeT);
			return alwaysTrueBtNodeT;
		}

		// Token: 0x0601588F RID: 88207 RVA: 0x0031C734 File Offset: 0x0031A934
		public void UnPackTo(IAlwaysTrueBtNodeT _o)
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

		// Token: 0x06015890 RID: 88208 RVA: 0x0031CB5C File Offset: 0x0031AD5C
		public static Offset<IAlwaysTrueBtNode> Pack(FlatBufferBuilder builder, IAlwaysTrueBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAlwaysTrueBtNode>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<IFixProcessor>) : IFixProcessor.Pack(builder, _o.FixProcessor);
			TBtNode child_type = (_o.Child == null) ? TBtNode.NONE : _o.Child.Type;
			int childOffset = (_o.Child == null) ? 0 : TBtNodeUnion.Pack(builder, _o.Child);
			return IAlwaysTrueBtNode.CreateIAlwaysTrueBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, child_type, childOffset, _o.NullMask);
		}

		// Token: 0x0400B5A9 RID: 46505
		private Table __p;
	}
}
