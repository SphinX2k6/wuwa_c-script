using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x0200650F RID: 25871
	public struct ICommonBtStart : IFlatbufferObject
	{
		// Token: 0x1700BEE1 RID: 48865
		// (get) Token: 0x0602C14F RID: 180559 RVA: 0x00601054 File Offset: 0x005FF254
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C150 RID: 180560 RVA: 0x00601061 File Offset: 0x005FF261
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C151 RID: 180561 RVA: 0x00601068 File Offset: 0x005FF268
		public static ICommonBtStart GetRootAsICommonBtStart(ByteBuffer _bb)
		{
			return ICommonBtStart.GetRootAsICommonBtStart(_bb, default(ICommonBtStart));
		}

		// Token: 0x0602C152 RID: 180562 RVA: 0x00601084 File Offset: 0x005FF284
		public static ICommonBtStart GetRootAsICommonBtStart(ByteBuffer _bb, ICommonBtStart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C153 RID: 180563 RVA: 0x006010A1 File Offset: 0x005FF2A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C154 RID: 180564 RVA: 0x006010B0 File Offset: 0x005FF2B0
		public ICommonBtStart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEE2 RID: 48866
		// (get) Token: 0x0602C155 RID: 180565 RVA: 0x006010C0 File Offset: 0x005FF2C0
		public ECommonBtNodeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonBtNodeType.Start;
				}
				return (ECommonBtNodeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BEE3 RID: 48867
		// (get) Token: 0x0602C156 RID: 180566 RVA: 0x006010FC File Offset: 0x005FF2FC
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

		// Token: 0x1700BEE4 RID: 48868
		// (get) Token: 0x0602C157 RID: 180567 RVA: 0x00601138 File Offset: 0x005FF338
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

		// Token: 0x0602C158 RID: 180568 RVA: 0x0060116F File Offset: 0x005FF36F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602C159 RID: 180569 RVA: 0x0060117E File Offset: 0x005FF37E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602C15A RID: 180570 RVA: 0x0060118C File Offset: 0x005FF38C
		public TCommonBtDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TCommonBtDecorator.NONE;
			}
			return (TCommonBtDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700BEE5 RID: 48869
		// (get) Token: 0x0602C15B RID: 180571 RVA: 0x006011CC File Offset: 0x005FF3CC
		public int DecoratorsTypeLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602C15C RID: 180572 RVA: 0x006011F8 File Offset: 0x005FF3F8
		public Span<TCommonBtDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtDecorator>(10, 1);
		}

		// Token: 0x0602C15D RID: 180573 RVA: 0x00601208 File Offset: 0x005FF408
		public TCommonBtDecorator[] GetDecoratorsTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TCommonBtDecorator[] array = new TCommonBtDecorator[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TCommonBtDecorator)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0602C15E RID: 180574 RVA: 0x00601274 File Offset: 0x005FF474
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700BEE6 RID: 48870
		// (get) Token: 0x0602C15F RID: 180575 RVA: 0x006012BC File Offset: 0x005FF4BC
		public int DecoratorsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700BEE7 RID: 48871
		// (get) Token: 0x0602C160 RID: 180576 RVA: 0x006012E8 File Offset: 0x005FF4E8
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BEE8 RID: 48872
		// (get) Token: 0x0602C161 RID: 180577 RVA: 0x00601328 File Offset: 0x005FF528
		public TCommonBtNode ChildType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return TCommonBtNode.NONE;
				}
				return (TCommonBtNode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C162 RID: 180578 RVA: 0x00601368 File Offset: 0x005FF568
		public TTable? Child<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C163 RID: 180579 RVA: 0x006013B0 File Offset: 0x005FF5B0
		public ICommonBtProbability ChildAsICommonBtProbability()
		{
			return this.Child<ICommonBtProbability>().Value;
		}

		// Token: 0x0602C164 RID: 180580 RVA: 0x006013CC File Offset: 0x005FF5CC
		public ICommonBtSelector ChildAsICommonBtSelector()
		{
			return this.Child<ICommonBtSelector>().Value;
		}

		// Token: 0x0602C165 RID: 180581 RVA: 0x006013E8 File Offset: 0x005FF5E8
		public ICommonBtSequence ChildAsICommonBtSequence()
		{
			return this.Child<ICommonBtSequence>().Value;
		}

		// Token: 0x0602C166 RID: 180582 RVA: 0x00601404 File Offset: 0x005FF604
		public ICommonBtStart ChildAsICommonBtStart()
		{
			return this.Child<ICommonBtStart>().Value;
		}

		// Token: 0x0602C167 RID: 180583 RVA: 0x00601420 File Offset: 0x005FF620
		public ICommonBtTask ChildAsICommonBtTask()
		{
			return this.Child<ICommonBtTask>().Value;
		}

		// Token: 0x1700BEE9 RID: 48873
		// (get) Token: 0x0602C168 RID: 180584 RVA: 0x0060143C File Offset: 0x005FF63C
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

		// Token: 0x0602C169 RID: 180585 RVA: 0x0060147C File Offset: 0x005FF67C
		public static Offset<ICommonBtStart> CreateICommonBtStart(FlatBufferBuilder builder, ECommonBtNodeType Type = ECommonBtNodeType.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), VectorOffset Decorators_typeOffset = default(VectorOffset), VectorOffset DecoratorsOffset = default(VectorOffset), bool _foldedForTree = false, TCommonBtNode Child_type = TCommonBtNode.NONE, int ChildOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			ICommonBtStart.AddChild(builder, ChildOffset);
			ICommonBtStart.AddDecorators(builder, DecoratorsOffset);
			ICommonBtStart.AddDecoratorsType(builder, Decorators_typeOffset);
			ICommonBtStart.AddDesc(builder, DescOffset);
			ICommonBtStart.AddId(builder, Id);
			ICommonBtStart.AddNullMask(builder, NullMask);
			ICommonBtStart.AddChildType(builder, Child_type);
			ICommonBtStart.Add_FoldedForTree(builder, _foldedForTree);
			ICommonBtStart.AddType(builder, Type);
			return ICommonBtStart.EndICommonBtStart(builder);
		}

		// Token: 0x0602C16A RID: 180586 RVA: 0x006014DC File Offset: 0x005FF6DC
		public static void StartICommonBtStart(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602C16B RID: 180587 RVA: 0x006014E6 File Offset: 0x005FF6E6
		public static void AddType(FlatBufferBuilder builder, ECommonBtNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C16C RID: 180588 RVA: 0x006014F1 File Offset: 0x005FF6F1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602C16D RID: 180589 RVA: 0x006014FC File Offset: 0x005FF6FC
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0602C16E RID: 180590 RVA: 0x0060150C File Offset: 0x005FF70C
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x0602C16F RID: 180591 RVA: 0x0060151C File Offset: 0x005FF71C
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C170 RID: 180592 RVA: 0x00601553 File Offset: 0x005FF753
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C171 RID: 180593 RVA: 0x0060156D File Offset: 0x005FF76D
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C172 RID: 180594 RVA: 0x0060158B File Offset: 0x005FF78B
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C173 RID: 180595 RVA: 0x006015A4 File Offset: 0x005FF7A4
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602C174 RID: 180596 RVA: 0x006015AF File Offset: 0x005FF7AF
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x0602C175 RID: 180597 RVA: 0x006015C0 File Offset: 0x005FF7C0
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C176 RID: 180598 RVA: 0x006015F7 File Offset: 0x005FF7F7
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C177 RID: 180599 RVA: 0x00601611 File Offset: 0x005FF811
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C178 RID: 180600 RVA: 0x0060162F File Offset: 0x005FF82F
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C179 RID: 180601 RVA: 0x00601648 File Offset: 0x005FF848
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C17A RID: 180602 RVA: 0x00601653 File Offset: 0x005FF853
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x0602C17B RID: 180603 RVA: 0x0060165E File Offset: 0x005FF85E
		public static void AddChildType(FlatBufferBuilder builder, TCommonBtNode childType)
		{
			builder.AddByte(6, (byte)childType, 0);
		}

		// Token: 0x0602C17C RID: 180604 RVA: 0x00601669 File Offset: 0x005FF869
		public static void AddChild(FlatBufferBuilder builder, int childOffset)
		{
			builder.AddOffset(7, childOffset, 0);
		}

		// Token: 0x0602C17D RID: 180605 RVA: 0x00601674 File Offset: 0x005FF874
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602C17E RID: 180606 RVA: 0x0060167F File Offset: 0x005FF87F
		public static Offset<ICommonBtStart> EndICommonBtStart(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtStart>(builder.EndTable());
		}

		// Token: 0x0602C17F RID: 180607 RVA: 0x0060168C File Offset: 0x005FF88C
		public ICommonBtStartT UnPack()
		{
			ICommonBtStartT commonBtStartT = new ICommonBtStartT();
			this.UnPackTo(commonBtStartT);
			return commonBtStartT;
		}

		// Token: 0x0602C180 RID: 180608 RVA: 0x006016A8 File Offset: 0x005FF8A8
		public void UnPackTo(ICommonBtStartT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.Decorators = new List<TCommonBtDecoratorUnion>();
			for (int i = 0; i < this.DecoratorsLength; i++)
			{
				TCommonBtDecoratorUnion tcommonBtDecoratorUnion = new TCommonBtDecoratorUnion();
				tcommonBtDecoratorUnion.Type = this.DecoratorsType(i);
				switch (this.DecoratorsType(i))
				{
				case TCommonBtDecorator.ICommonBtAlwaysFalseDecorator:
					tcommonBtDecoratorUnion.Value = ((this.Decorators<ICommonBtAlwaysFalseDecorator>(i) != null) ? this.Decorators<ICommonBtAlwaysFalseDecorator>(i).Value.UnPack() : null);
					break;
				case TCommonBtDecorator.ICommonBtAlwaysTrueDecorator:
					tcommonBtDecoratorUnion.Value = ((this.Decorators<ICommonBtAlwaysTrueDecorator>(i) != null) ? this.Decorators<ICommonBtAlwaysTrueDecorator>(i).Value.UnPack() : null);
					break;
				case TCommonBtDecorator.ICommonBtConditionDecorator:
					tcommonBtDecoratorUnion.Value = ((this.Decorators<ICommonBtConditionDecorator>(i) != null) ? this.Decorators<ICommonBtConditionDecorator>(i).Value.UnPack() : null);
					break;
				case TCommonBtDecorator.ICommonBtCoolDownDecorator:
					tcommonBtDecoratorUnion.Value = ((this.Decorators<ICommonBtCoolDownDecorator>(i) != null) ? this.Decorators<ICommonBtCoolDownDecorator>(i).Value.UnPack() : null);
					break;
				case TCommonBtDecorator.ICommonBtDoOnceDecorator:
					tcommonBtDecoratorUnion.Value = ((this.Decorators<ICommonBtDoOnceDecorator>(i) != null) ? this.Decorators<ICommonBtDoOnceDecorator>(i).Value.UnPack() : null);
					break;
				}
				_o.Decorators.Add(tcommonBtDecoratorUnion);
			}
			_o._FoldedForTree = this._FoldedForTree;
			_o.Child = new TCommonBtNodeUnion();
			_o.Child.Type = this.ChildType;
			switch (this.ChildType)
			{
			case TCommonBtNode.ICommonBtProbability:
				_o.Child.Value = ((this.Child<ICommonBtProbability>() != null) ? this.Child<ICommonBtProbability>().Value.UnPack() : null);
				break;
			case TCommonBtNode.ICommonBtSelector:
				_o.Child.Value = ((this.Child<ICommonBtSelector>() != null) ? this.Child<ICommonBtSelector>().Value.UnPack() : null);
				break;
			case TCommonBtNode.ICommonBtSequence:
				_o.Child.Value = ((this.Child<ICommonBtSequence>() != null) ? this.Child<ICommonBtSequence>().Value.UnPack() : null);
				break;
			case TCommonBtNode.ICommonBtStart:
				_o.Child.Value = ((this.Child<ICommonBtStart>() != null) ? this.Child<ICommonBtStart>().Value.UnPack() : null);
				break;
			case TCommonBtNode.ICommonBtTask:
				_o.Child.Value = ((this.Child<ICommonBtTask>() != null) ? this.Child<ICommonBtTask>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C181 RID: 180609 RVA: 0x006019D4 File Offset: 0x005FFBD4
		public static Offset<ICommonBtStart> Pack(FlatBufferBuilder builder, ICommonBtStartT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtStart>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			VectorOffset decorators_typeOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				TCommonBtDecorator[] array = new TCommonBtDecorator[_o.Decorators.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Decorators[i].Type;
				}
				decorators_typeOffset = ICommonBtStart.CreateDecoratorsTypeVector(builder, array);
			}
			VectorOffset decoratorsOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				int[] array2 = new int[_o.Decorators.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TCommonBtDecoratorUnion.Pack(builder, _o.Decorators[j]);
				}
				decoratorsOffset = ICommonBtStart.CreateDecoratorsVector(builder, array2);
			}
			TCommonBtNode child_type = (_o.Child == null) ? TCommonBtNode.NONE : _o.Child.Type;
			int childOffset = (_o.Child == null) ? 0 : TCommonBtNodeUnion.Pack(builder, _o.Child);
			return ICommonBtStart.CreateICommonBtStart(builder, _o.Type, _o.Id, descOffset, decorators_typeOffset, decoratorsOffset, _o._FoldedForTree, child_type, childOffset, _o.NullMask);
		}

		// Token: 0x040106C0 RID: 67264
		private Table __p;
	}
}
