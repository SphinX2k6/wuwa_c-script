using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004115 RID: 16661
	public struct IAlwaysTrueBtNode : IFlatbufferObject
	{
		// Token: 0x170070D2 RID: 28882
		// (get) Token: 0x06016D9B RID: 93595 RVA: 0x00343444 File Offset: 0x00341644
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016D9C RID: 93596 RVA: 0x00343451 File Offset: 0x00341651
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016D9D RID: 93597 RVA: 0x00343458 File Offset: 0x00341658
		public static IAlwaysTrueBtNode GetRootAsIAlwaysTrueBtNode(ByteBuffer _bb)
		{
			return IAlwaysTrueBtNode.GetRootAsIAlwaysTrueBtNode(_bb, default(IAlwaysTrueBtNode));
		}

		// Token: 0x06016D9E RID: 93598 RVA: 0x00343474 File Offset: 0x00341674
		public static IAlwaysTrueBtNode GetRootAsIAlwaysTrueBtNode(ByteBuffer _bb, IAlwaysTrueBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016D9F RID: 93599 RVA: 0x00343491 File Offset: 0x00341691
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016DA0 RID: 93600 RVA: 0x003434A0 File Offset: 0x003416A0
		public IAlwaysTrueBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070D3 RID: 28883
		// (get) Token: 0x06016DA1 RID: 93601 RVA: 0x003434B0 File Offset: 0x003416B0
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

		// Token: 0x170070D4 RID: 28884
		// (get) Token: 0x06016DA2 RID: 93602 RVA: 0x003434EC File Offset: 0x003416EC
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

		// Token: 0x170070D5 RID: 28885
		// (get) Token: 0x06016DA3 RID: 93603 RVA: 0x00343528 File Offset: 0x00341728
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

		// Token: 0x06016DA4 RID: 93604 RVA: 0x0034355F File Offset: 0x0034175F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06016DA5 RID: 93605 RVA: 0x0034356E File Offset: 0x0034176E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170070D6 RID: 28886
		// (get) Token: 0x06016DA6 RID: 93606 RVA: 0x0034357C File Offset: 0x0034177C
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

		// Token: 0x170070D7 RID: 28887
		// (get) Token: 0x06016DA7 RID: 93607 RVA: 0x003435DC File Offset: 0x003417DC
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170070D8 RID: 28888
		// (get) Token: 0x06016DA8 RID: 93608 RVA: 0x0034361C File Offset: 0x0034181C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170070D9 RID: 28889
		// (get) Token: 0x06016DA9 RID: 93609 RVA: 0x0034365C File Offset: 0x0034185C
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

		// Token: 0x06016DAA RID: 93610 RVA: 0x0034369C File Offset: 0x0034189C
		public TTable? Child<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016DAB RID: 93611 RVA: 0x003436E4 File Offset: 0x003418E4
		public IActionBtNode ChildAsIActionBtNode()
		{
			return this.Child<IActionBtNode>().Value;
		}

		// Token: 0x06016DAC RID: 93612 RVA: 0x00343700 File Offset: 0x00341900
		public IActionWithResultBtNode ChildAsIActionWithResultBtNode()
		{
			return this.Child<IActionWithResultBtNode>().Value;
		}

		// Token: 0x06016DAD RID: 93613 RVA: 0x0034371C File Offset: 0x0034191C
		public IAlwaysFalseBtNode ChildAsIAlwaysFalseBtNode()
		{
			return this.Child<IAlwaysFalseBtNode>().Value;
		}

		// Token: 0x06016DAE RID: 93614 RVA: 0x00343738 File Offset: 0x00341938
		public IAlwaysTrueBtNode ChildAsIAlwaysTrueBtNode()
		{
			return this.Child<IAlwaysTrueBtNode>().Value;
		}

		// Token: 0x06016DAF RID: 93615 RVA: 0x00343754 File Offset: 0x00341954
		public IChildQuestBtNode ChildAsIChildQuestBtNode()
		{
			return this.Child<IChildQuestBtNode>().Value;
		}

		// Token: 0x06016DB0 RID: 93616 RVA: 0x00343770 File Offset: 0x00341970
		public IConditionBtNode ChildAsIConditionBtNode()
		{
			return this.Child<IConditionBtNode>().Value;
		}

		// Token: 0x06016DB1 RID: 93617 RVA: 0x0034378C File Offset: 0x0034198C
		public IConditionSelectorBtNode ChildAsIConditionSelectorBtNode()
		{
			return this.Child<IConditionSelectorBtNode>().Value;
		}

		// Token: 0x06016DB2 RID: 93618 RVA: 0x003437A8 File Offset: 0x003419A8
		public IParallelSelectBtNode ChildAsIParallelSelectBtNode()
		{
			return this.Child<IParallelSelectBtNode>().Value;
		}

		// Token: 0x06016DB3 RID: 93619 RVA: 0x003437C4 File Offset: 0x003419C4
		public IQuestFailedBtNode ChildAsIQuestFailedBtNode()
		{
			return this.Child<IQuestFailedBtNode>().Value;
		}

		// Token: 0x06016DB4 RID: 93620 RVA: 0x003437E0 File Offset: 0x003419E0
		public IQuestSucceedBtNode ChildAsIQuestSucceedBtNode()
		{
			return this.Child<IQuestSucceedBtNode>().Value;
		}

		// Token: 0x06016DB5 RID: 93621 RVA: 0x003437FC File Offset: 0x003419FC
		public IRepeaterBtNode ChildAsIRepeaterBtNode()
		{
			return this.Child<IRepeaterBtNode>().Value;
		}

		// Token: 0x06016DB6 RID: 93622 RVA: 0x00343818 File Offset: 0x00341A18
		public ISelectBtNode ChildAsISelectBtNode()
		{
			return this.Child<ISelectBtNode>().Value;
		}

		// Token: 0x06016DB7 RID: 93623 RVA: 0x00343834 File Offset: 0x00341A34
		public ISequenceBtNode ChildAsISequenceBtNode()
		{
			return this.Child<ISequenceBtNode>().Value;
		}

		// Token: 0x06016DB8 RID: 93624 RVA: 0x00343850 File Offset: 0x00341A50
		public IStartBtNode ChildAsIStartBtNode()
		{
			return this.Child<IStartBtNode>().Value;
		}

		// Token: 0x170070DA RID: 28890
		// (get) Token: 0x06016DB9 RID: 93625 RVA: 0x0034386C File Offset: 0x00341A6C
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

		// Token: 0x06016DBA RID: 93626 RVA: 0x003438AC File Offset: 0x00341AAC
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

		// Token: 0x06016DBB RID: 93627 RVA: 0x0034390C File Offset: 0x00341B0C
		public static void StartIAlwaysTrueBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06016DBC RID: 93628 RVA: 0x00343916 File Offset: 0x00341B16
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016DBD RID: 93629 RVA: 0x00343921 File Offset: 0x00341B21
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06016DBE RID: 93630 RVA: 0x0034392C File Offset: 0x00341B2C
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06016DBF RID: 93631 RVA: 0x0034393C File Offset: 0x00341B3C
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06016DC0 RID: 93632 RVA: 0x0034394C File Offset: 0x00341B4C
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06016DC1 RID: 93633 RVA: 0x00343957 File Offset: 0x00341B57
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06016DC2 RID: 93634 RVA: 0x00343962 File Offset: 0x00341B62
		public static void AddChildType(FlatBufferBuilder builder, TBtNode childType)
		{
			builder.AddByte(6, (byte)childType, 0);
		}

		// Token: 0x06016DC3 RID: 93635 RVA: 0x0034396D File Offset: 0x00341B6D
		public static void AddChild(FlatBufferBuilder builder, int childOffset)
		{
			builder.AddOffset(7, childOffset, 0);
		}

		// Token: 0x06016DC4 RID: 93636 RVA: 0x00343978 File Offset: 0x00341B78
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06016DC5 RID: 93637 RVA: 0x00343983 File Offset: 0x00341B83
		public static Offset<IAlwaysTrueBtNode> EndIAlwaysTrueBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IAlwaysTrueBtNode>(builder.EndTable());
		}

		// Token: 0x06016DC6 RID: 93638 RVA: 0x00343990 File Offset: 0x00341B90
		public IAlwaysTrueBtNodeT UnPack()
		{
			IAlwaysTrueBtNodeT alwaysTrueBtNodeT = new IAlwaysTrueBtNodeT();
			this.UnPackTo(alwaysTrueBtNodeT);
			return alwaysTrueBtNodeT;
		}

		// Token: 0x06016DC7 RID: 93639 RVA: 0x003439AC File Offset: 0x00341BAC
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

		// Token: 0x06016DC8 RID: 93640 RVA: 0x00343DD4 File Offset: 0x00341FD4
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

		// Token: 0x0400BF56 RID: 48982
		private Table __p;
	}
}
