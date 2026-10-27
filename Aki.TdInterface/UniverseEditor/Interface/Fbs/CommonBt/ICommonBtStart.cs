using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005ECC RID: 24268
	public struct ICommonBtStart : IFlatbufferObject
	{
		// Token: 0x1700B576 RID: 46454
		// (get) Token: 0x06029A9B RID: 170651 RVA: 0x005B7B70 File Offset: 0x005B5D70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029A9C RID: 170652 RVA: 0x005B7B7D File Offset: 0x005B5D7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029A9D RID: 170653 RVA: 0x005B7B84 File Offset: 0x005B5D84
		public static ICommonBtStart GetRootAsICommonBtStart(ByteBuffer _bb)
		{
			return ICommonBtStart.GetRootAsICommonBtStart(_bb, default(ICommonBtStart));
		}

		// Token: 0x06029A9E RID: 170654 RVA: 0x005B7BA0 File Offset: 0x005B5DA0
		public static ICommonBtStart GetRootAsICommonBtStart(ByteBuffer _bb, ICommonBtStart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029A9F RID: 170655 RVA: 0x005B7BBD File Offset: 0x005B5DBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029AA0 RID: 170656 RVA: 0x005B7BCC File Offset: 0x005B5DCC
		public ICommonBtStart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B577 RID: 46455
		// (get) Token: 0x06029AA1 RID: 170657 RVA: 0x005B7BDC File Offset: 0x005B5DDC
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

		// Token: 0x1700B578 RID: 46456
		// (get) Token: 0x06029AA2 RID: 170658 RVA: 0x005B7C18 File Offset: 0x005B5E18
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

		// Token: 0x1700B579 RID: 46457
		// (get) Token: 0x06029AA3 RID: 170659 RVA: 0x005B7C54 File Offset: 0x005B5E54
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

		// Token: 0x06029AA4 RID: 170660 RVA: 0x005B7C8B File Offset: 0x005B5E8B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06029AA5 RID: 170661 RVA: 0x005B7C9A File Offset: 0x005B5E9A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06029AA6 RID: 170662 RVA: 0x005B7CA8 File Offset: 0x005B5EA8
		public TCommonBtDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TCommonBtDecorator.NONE;
			}
			return (TCommonBtDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B57A RID: 46458
		// (get) Token: 0x06029AA7 RID: 170663 RVA: 0x005B7CE8 File Offset: 0x005B5EE8
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

		// Token: 0x06029AA8 RID: 170664 RVA: 0x005B7D14 File Offset: 0x005B5F14
		public Span<TCommonBtDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtDecorator>(10, 1);
		}

		// Token: 0x06029AA9 RID: 170665 RVA: 0x005B7D24 File Offset: 0x005B5F24
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

		// Token: 0x06029AAA RID: 170666 RVA: 0x005B7D90 File Offset: 0x005B5F90
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B57B RID: 46459
		// (get) Token: 0x06029AAB RID: 170667 RVA: 0x005B7DD8 File Offset: 0x005B5FD8
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

		// Token: 0x1700B57C RID: 46460
		// (get) Token: 0x06029AAC RID: 170668 RVA: 0x005B7E04 File Offset: 0x005B6004
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B57D RID: 46461
		// (get) Token: 0x06029AAD RID: 170669 RVA: 0x005B7E44 File Offset: 0x005B6044
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

		// Token: 0x06029AAE RID: 170670 RVA: 0x005B7E84 File Offset: 0x005B6084
		public TTable? Child<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06029AAF RID: 170671 RVA: 0x005B7ECC File Offset: 0x005B60CC
		public ICommonBtProbability ChildAsICommonBtProbability()
		{
			return this.Child<ICommonBtProbability>().Value;
		}

		// Token: 0x06029AB0 RID: 170672 RVA: 0x005B7EE8 File Offset: 0x005B60E8
		public ICommonBtSelector ChildAsICommonBtSelector()
		{
			return this.Child<ICommonBtSelector>().Value;
		}

		// Token: 0x06029AB1 RID: 170673 RVA: 0x005B7F04 File Offset: 0x005B6104
		public ICommonBtSequence ChildAsICommonBtSequence()
		{
			return this.Child<ICommonBtSequence>().Value;
		}

		// Token: 0x06029AB2 RID: 170674 RVA: 0x005B7F20 File Offset: 0x005B6120
		public ICommonBtStart ChildAsICommonBtStart()
		{
			return this.Child<ICommonBtStart>().Value;
		}

		// Token: 0x06029AB3 RID: 170675 RVA: 0x005B7F3C File Offset: 0x005B613C
		public ICommonBtTask ChildAsICommonBtTask()
		{
			return this.Child<ICommonBtTask>().Value;
		}

		// Token: 0x1700B57E RID: 46462
		// (get) Token: 0x06029AB4 RID: 170676 RVA: 0x005B7F58 File Offset: 0x005B6158
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

		// Token: 0x06029AB5 RID: 170677 RVA: 0x005B7F98 File Offset: 0x005B6198
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

		// Token: 0x06029AB6 RID: 170678 RVA: 0x005B7FF8 File Offset: 0x005B61F8
		public static void StartICommonBtStart(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06029AB7 RID: 170679 RVA: 0x005B8002 File Offset: 0x005B6202
		public static void AddType(FlatBufferBuilder builder, ECommonBtNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029AB8 RID: 170680 RVA: 0x005B800D File Offset: 0x005B620D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06029AB9 RID: 170681 RVA: 0x005B8018 File Offset: 0x005B6218
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06029ABA RID: 170682 RVA: 0x005B8028 File Offset: 0x005B6228
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x06029ABB RID: 170683 RVA: 0x005B8038 File Offset: 0x005B6238
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029ABC RID: 170684 RVA: 0x005B806F File Offset: 0x005B626F
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06029ABD RID: 170685 RVA: 0x005B8089 File Offset: 0x005B6289
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06029ABE RID: 170686 RVA: 0x005B80A7 File Offset: 0x005B62A7
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029ABF RID: 170687 RVA: 0x005B80C0 File Offset: 0x005B62C0
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06029AC0 RID: 170688 RVA: 0x005B80CB File Offset: 0x005B62CB
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x06029AC1 RID: 170689 RVA: 0x005B80DC File Offset: 0x005B62DC
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029AC2 RID: 170690 RVA: 0x005B8113 File Offset: 0x005B6313
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029AC3 RID: 170691 RVA: 0x005B812D File Offset: 0x005B632D
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029AC4 RID: 170692 RVA: 0x005B814B File Offset: 0x005B634B
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029AC5 RID: 170693 RVA: 0x005B8164 File Offset: 0x005B6364
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029AC6 RID: 170694 RVA: 0x005B816F File Offset: 0x005B636F
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x06029AC7 RID: 170695 RVA: 0x005B817A File Offset: 0x005B637A
		public static void AddChildType(FlatBufferBuilder builder, TCommonBtNode childType)
		{
			builder.AddByte(6, (byte)childType, 0);
		}

		// Token: 0x06029AC8 RID: 170696 RVA: 0x005B8185 File Offset: 0x005B6385
		public static void AddChild(FlatBufferBuilder builder, int childOffset)
		{
			builder.AddOffset(7, childOffset, 0);
		}

		// Token: 0x06029AC9 RID: 170697 RVA: 0x005B8190 File Offset: 0x005B6390
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06029ACA RID: 170698 RVA: 0x005B819B File Offset: 0x005B639B
		public static Offset<ICommonBtStart> EndICommonBtStart(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtStart>(builder.EndTable());
		}

		// Token: 0x06029ACB RID: 170699 RVA: 0x005B81A8 File Offset: 0x005B63A8
		public ICommonBtStartT UnPack()
		{
			ICommonBtStartT commonBtStartT = new ICommonBtStartT();
			this.UnPackTo(commonBtStartT);
			return commonBtStartT;
		}

		// Token: 0x06029ACC RID: 170700 RVA: 0x005B81C4 File Offset: 0x005B63C4
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

		// Token: 0x06029ACD RID: 170701 RVA: 0x005B84F0 File Offset: 0x005B66F0
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

		// Token: 0x0400F95D RID: 63837
		private Table __p;
	}
}
