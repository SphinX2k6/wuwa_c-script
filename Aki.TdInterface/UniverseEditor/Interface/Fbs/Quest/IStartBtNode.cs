using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004145 RID: 16709
	public struct IStartBtNode : IFlatbufferObject
	{
		// Token: 0x1700764E RID: 30286
		// (get) Token: 0x06018812 RID: 100370 RVA: 0x00388181 File Offset: 0x00386381
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018813 RID: 100371 RVA: 0x0038818E File Offset: 0x0038638E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018814 RID: 100372 RVA: 0x00388198 File Offset: 0x00386398
		public static IStartBtNode GetRootAsIStartBtNode(ByteBuffer _bb)
		{
			return IStartBtNode.GetRootAsIStartBtNode(_bb, default(IStartBtNode));
		}

		// Token: 0x06018815 RID: 100373 RVA: 0x003881B4 File Offset: 0x003863B4
		public static IStartBtNode GetRootAsIStartBtNode(ByteBuffer _bb, IStartBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018816 RID: 100374 RVA: 0x003881D1 File Offset: 0x003863D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018817 RID: 100375 RVA: 0x003881E0 File Offset: 0x003863E0
		public IStartBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700764F RID: 30287
		// (get) Token: 0x06018818 RID: 100376 RVA: 0x003881F0 File Offset: 0x003863F0
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

		// Token: 0x17007650 RID: 30288
		// (get) Token: 0x06018819 RID: 100377 RVA: 0x0038822C File Offset: 0x0038642C
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

		// Token: 0x17007651 RID: 30289
		// (get) Token: 0x0601881A RID: 100378 RVA: 0x00388268 File Offset: 0x00386468
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

		// Token: 0x0601881B RID: 100379 RVA: 0x0038829F File Offset: 0x0038649F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601881C RID: 100380 RVA: 0x003882AE File Offset: 0x003864AE
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007652 RID: 30290
		// (get) Token: 0x0601881D RID: 100381 RVA: 0x003882BC File Offset: 0x003864BC
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

		// Token: 0x17007653 RID: 30291
		// (get) Token: 0x0601881E RID: 100382 RVA: 0x0038831C File Offset: 0x0038651C
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007654 RID: 30292
		// (get) Token: 0x0601881F RID: 100383 RVA: 0x0038835C File Offset: 0x0038655C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007655 RID: 30293
		// (get) Token: 0x06018820 RID: 100384 RVA: 0x0038839C File Offset: 0x0038659C
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

		// Token: 0x06018821 RID: 100385 RVA: 0x003883DC File Offset: 0x003865DC
		public TTable? Child<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018822 RID: 100386 RVA: 0x00388424 File Offset: 0x00386624
		public IActionBtNode ChildAsIActionBtNode()
		{
			return this.Child<IActionBtNode>().Value;
		}

		// Token: 0x06018823 RID: 100387 RVA: 0x00388440 File Offset: 0x00386640
		public IActionWithResultBtNode ChildAsIActionWithResultBtNode()
		{
			return this.Child<IActionWithResultBtNode>().Value;
		}

		// Token: 0x06018824 RID: 100388 RVA: 0x0038845C File Offset: 0x0038665C
		public IAlwaysFalseBtNode ChildAsIAlwaysFalseBtNode()
		{
			return this.Child<IAlwaysFalseBtNode>().Value;
		}

		// Token: 0x06018825 RID: 100389 RVA: 0x00388478 File Offset: 0x00386678
		public IAlwaysTrueBtNode ChildAsIAlwaysTrueBtNode()
		{
			return this.Child<IAlwaysTrueBtNode>().Value;
		}

		// Token: 0x06018826 RID: 100390 RVA: 0x00388494 File Offset: 0x00386694
		public IChildQuestBtNode ChildAsIChildQuestBtNode()
		{
			return this.Child<IChildQuestBtNode>().Value;
		}

		// Token: 0x06018827 RID: 100391 RVA: 0x003884B0 File Offset: 0x003866B0
		public IConditionBtNode ChildAsIConditionBtNode()
		{
			return this.Child<IConditionBtNode>().Value;
		}

		// Token: 0x06018828 RID: 100392 RVA: 0x003884CC File Offset: 0x003866CC
		public IConditionSelectorBtNode ChildAsIConditionSelectorBtNode()
		{
			return this.Child<IConditionSelectorBtNode>().Value;
		}

		// Token: 0x06018829 RID: 100393 RVA: 0x003884E8 File Offset: 0x003866E8
		public IParallelSelectBtNode ChildAsIParallelSelectBtNode()
		{
			return this.Child<IParallelSelectBtNode>().Value;
		}

		// Token: 0x0601882A RID: 100394 RVA: 0x00388504 File Offset: 0x00386704
		public IQuestFailedBtNode ChildAsIQuestFailedBtNode()
		{
			return this.Child<IQuestFailedBtNode>().Value;
		}

		// Token: 0x0601882B RID: 100395 RVA: 0x00388520 File Offset: 0x00386720
		public IQuestSucceedBtNode ChildAsIQuestSucceedBtNode()
		{
			return this.Child<IQuestSucceedBtNode>().Value;
		}

		// Token: 0x0601882C RID: 100396 RVA: 0x0038853C File Offset: 0x0038673C
		public IRepeaterBtNode ChildAsIRepeaterBtNode()
		{
			return this.Child<IRepeaterBtNode>().Value;
		}

		// Token: 0x0601882D RID: 100397 RVA: 0x00388558 File Offset: 0x00386758
		public ISelectBtNode ChildAsISelectBtNode()
		{
			return this.Child<ISelectBtNode>().Value;
		}

		// Token: 0x0601882E RID: 100398 RVA: 0x00388574 File Offset: 0x00386774
		public ISequenceBtNode ChildAsISequenceBtNode()
		{
			return this.Child<ISequenceBtNode>().Value;
		}

		// Token: 0x0601882F RID: 100399 RVA: 0x00388590 File Offset: 0x00386790
		public IStartBtNode ChildAsIStartBtNode()
		{
			return this.Child<IStartBtNode>().Value;
		}

		// Token: 0x17007656 RID: 30294
		// (get) Token: 0x06018830 RID: 100400 RVA: 0x003885AC File Offset: 0x003867AC
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

		// Token: 0x06018831 RID: 100401 RVA: 0x003885EC File Offset: 0x003867EC
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

		// Token: 0x06018832 RID: 100402 RVA: 0x0038864C File Offset: 0x0038684C
		public static void StartIStartBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06018833 RID: 100403 RVA: 0x00388656 File Offset: 0x00386856
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018834 RID: 100404 RVA: 0x00388661 File Offset: 0x00386861
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06018835 RID: 100405 RVA: 0x0038866C File Offset: 0x0038686C
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06018836 RID: 100406 RVA: 0x0038867C File Offset: 0x0038687C
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06018837 RID: 100407 RVA: 0x0038868C File Offset: 0x0038688C
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06018838 RID: 100408 RVA: 0x00388697 File Offset: 0x00386897
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06018839 RID: 100409 RVA: 0x003886A2 File Offset: 0x003868A2
		public static void AddChildType(FlatBufferBuilder builder, TBtNode childType)
		{
			builder.AddByte(6, (byte)childType, 0);
		}

		// Token: 0x0601883A RID: 100410 RVA: 0x003886AD File Offset: 0x003868AD
		public static void AddChild(FlatBufferBuilder builder, int childOffset)
		{
			builder.AddOffset(7, childOffset, 0);
		}

		// Token: 0x0601883B RID: 100411 RVA: 0x003886B8 File Offset: 0x003868B8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601883C RID: 100412 RVA: 0x003886C3 File Offset: 0x003868C3
		public static Offset<IStartBtNode> EndIStartBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IStartBtNode>(builder.EndTable());
		}

		// Token: 0x0601883D RID: 100413 RVA: 0x003886D0 File Offset: 0x003868D0
		public IStartBtNodeT UnPack()
		{
			IStartBtNodeT startBtNodeT = new IStartBtNodeT();
			this.UnPackTo(startBtNodeT);
			return startBtNodeT;
		}

		// Token: 0x0601883E RID: 100414 RVA: 0x003886EC File Offset: 0x003868EC
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

		// Token: 0x0601883F RID: 100415 RVA: 0x00388B14 File Offset: 0x00386D14
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

		// Token: 0x0400BD4E RID: 48462
		private Table __p;
	}
}
