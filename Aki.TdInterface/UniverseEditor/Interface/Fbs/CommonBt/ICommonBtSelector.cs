using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EC6 RID: 24262
	public struct ICommonBtSelector : IFlatbufferObject
	{
		// Token: 0x1700B554 RID: 46420
		// (get) Token: 0x06029A03 RID: 170499 RVA: 0x005B5F3E File Offset: 0x005B413E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029A04 RID: 170500 RVA: 0x005B5F4B File Offset: 0x005B414B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029A05 RID: 170501 RVA: 0x005B5F54 File Offset: 0x005B4154
		public static ICommonBtSelector GetRootAsICommonBtSelector(ByteBuffer _bb)
		{
			return ICommonBtSelector.GetRootAsICommonBtSelector(_bb, default(ICommonBtSelector));
		}

		// Token: 0x06029A06 RID: 170502 RVA: 0x005B5F70 File Offset: 0x005B4170
		public static ICommonBtSelector GetRootAsICommonBtSelector(ByteBuffer _bb, ICommonBtSelector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029A07 RID: 170503 RVA: 0x005B5F8D File Offset: 0x005B418D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029A08 RID: 170504 RVA: 0x005B5F9C File Offset: 0x005B419C
		public ICommonBtSelector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B555 RID: 46421
		// (get) Token: 0x06029A09 RID: 170505 RVA: 0x005B5FAC File Offset: 0x005B41AC
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

		// Token: 0x1700B556 RID: 46422
		// (get) Token: 0x06029A0A RID: 170506 RVA: 0x005B5FE8 File Offset: 0x005B41E8
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

		// Token: 0x1700B557 RID: 46423
		// (get) Token: 0x06029A0B RID: 170507 RVA: 0x005B6024 File Offset: 0x005B4224
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

		// Token: 0x06029A0C RID: 170508 RVA: 0x005B605B File Offset: 0x005B425B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06029A0D RID: 170509 RVA: 0x005B606A File Offset: 0x005B426A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06029A0E RID: 170510 RVA: 0x005B6078 File Offset: 0x005B4278
		public TCommonBtDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TCommonBtDecorator.NONE;
			}
			return (TCommonBtDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B558 RID: 46424
		// (get) Token: 0x06029A0F RID: 170511 RVA: 0x005B60B8 File Offset: 0x005B42B8
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

		// Token: 0x06029A10 RID: 170512 RVA: 0x005B60E4 File Offset: 0x005B42E4
		public Span<TCommonBtDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtDecorator>(10, 1);
		}

		// Token: 0x06029A11 RID: 170513 RVA: 0x005B60F4 File Offset: 0x005B42F4
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

		// Token: 0x06029A12 RID: 170514 RVA: 0x005B6160 File Offset: 0x005B4360
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B559 RID: 46425
		// (get) Token: 0x06029A13 RID: 170515 RVA: 0x005B61A8 File Offset: 0x005B43A8
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

		// Token: 0x1700B55A RID: 46426
		// (get) Token: 0x06029A14 RID: 170516 RVA: 0x005B61D4 File Offset: 0x005B43D4
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06029A15 RID: 170517 RVA: 0x005B6214 File Offset: 0x005B4414
		public TCommonBtNode ChildrenType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return TCommonBtNode.NONE;
			}
			return (TCommonBtNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B55B RID: 46427
		// (get) Token: 0x06029A16 RID: 170518 RVA: 0x005B6254 File Offset: 0x005B4454
		public int ChildrenTypeLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06029A17 RID: 170519 RVA: 0x005B6280 File Offset: 0x005B4480
		public Span<TCommonBtNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtNode>(16, 1);
		}

		// Token: 0x06029A18 RID: 170520 RVA: 0x005B6290 File Offset: 0x005B4490
		public TCommonBtNode[] GetChildrenTypeArray()
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TCommonBtNode[] array = new TCommonBtNode[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TCommonBtNode)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06029A19 RID: 170521 RVA: 0x005B62FC File Offset: 0x005B44FC
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B55C RID: 46428
		// (get) Token: 0x06029A1A RID: 170522 RVA: 0x005B6344 File Offset: 0x005B4544
		public int ChildrenLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B55D RID: 46429
		// (get) Token: 0x06029A1B RID: 170523 RVA: 0x005B6370 File Offset: 0x005B4570
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

		// Token: 0x06029A1C RID: 170524 RVA: 0x005B63B0 File Offset: 0x005B45B0
		public static Offset<ICommonBtSelector> CreateICommonBtSelector(FlatBufferBuilder builder, ECommonBtNodeType Type = ECommonBtNodeType.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), VectorOffset Decorators_typeOffset = default(VectorOffset), VectorOffset DecoratorsOffset = default(VectorOffset), bool _foldedForTree = false, VectorOffset Children_typeOffset = default(VectorOffset), VectorOffset ChildrenOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			ICommonBtSelector.AddChildren(builder, ChildrenOffset);
			ICommonBtSelector.AddChildrenType(builder, Children_typeOffset);
			ICommonBtSelector.AddDecorators(builder, DecoratorsOffset);
			ICommonBtSelector.AddDecoratorsType(builder, Decorators_typeOffset);
			ICommonBtSelector.AddDesc(builder, DescOffset);
			ICommonBtSelector.AddId(builder, Id);
			ICommonBtSelector.AddNullMask(builder, NullMask);
			ICommonBtSelector.Add_FoldedForTree(builder, _foldedForTree);
			ICommonBtSelector.AddType(builder, Type);
			return ICommonBtSelector.EndICommonBtSelector(builder);
		}

		// Token: 0x06029A1D RID: 170525 RVA: 0x005B6410 File Offset: 0x005B4610
		public static void StartICommonBtSelector(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06029A1E RID: 170526 RVA: 0x005B641A File Offset: 0x005B461A
		public static void AddType(FlatBufferBuilder builder, ECommonBtNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029A1F RID: 170527 RVA: 0x005B6425 File Offset: 0x005B4625
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06029A20 RID: 170528 RVA: 0x005B6430 File Offset: 0x005B4630
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06029A21 RID: 170529 RVA: 0x005B6440 File Offset: 0x005B4640
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x06029A22 RID: 170530 RVA: 0x005B6450 File Offset: 0x005B4650
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029A23 RID: 170531 RVA: 0x005B6487 File Offset: 0x005B4687
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A24 RID: 170532 RVA: 0x005B64A1 File Offset: 0x005B46A1
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A25 RID: 170533 RVA: 0x005B64BF File Offset: 0x005B46BF
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029A26 RID: 170534 RVA: 0x005B64D8 File Offset: 0x005B46D8
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06029A27 RID: 170535 RVA: 0x005B64E3 File Offset: 0x005B46E3
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x06029A28 RID: 170536 RVA: 0x005B64F4 File Offset: 0x005B46F4
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029A29 RID: 170537 RVA: 0x005B652B File Offset: 0x005B472B
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A2A RID: 170538 RVA: 0x005B6545 File Offset: 0x005B4745
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A2B RID: 170539 RVA: 0x005B6563 File Offset: 0x005B4763
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029A2C RID: 170540 RVA: 0x005B657C File Offset: 0x005B477C
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029A2D RID: 170541 RVA: 0x005B6587 File Offset: 0x005B4787
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x06029A2E RID: 170542 RVA: 0x005B6592 File Offset: 0x005B4792
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(6, childrenTypeOffset.Value, 0);
		}

		// Token: 0x06029A2F RID: 170543 RVA: 0x005B65A4 File Offset: 0x005B47A4
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TCommonBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029A30 RID: 170544 RVA: 0x005B65DB File Offset: 0x005B47DB
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TCommonBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A31 RID: 170545 RVA: 0x005B65F5 File Offset: 0x005B47F5
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A32 RID: 170546 RVA: 0x005B6613 File Offset: 0x005B4813
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029A33 RID: 170547 RVA: 0x005B662C File Offset: 0x005B482C
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06029A34 RID: 170548 RVA: 0x005B6637 File Offset: 0x005B4837
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(7, childrenOffset.Value, 0);
		}

		// Token: 0x06029A35 RID: 170549 RVA: 0x005B6648 File Offset: 0x005B4848
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029A36 RID: 170550 RVA: 0x005B667F File Offset: 0x005B487F
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A37 RID: 170551 RVA: 0x005B6699 File Offset: 0x005B4899
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A38 RID: 170552 RVA: 0x005B66B7 File Offset: 0x005B48B7
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029A39 RID: 170553 RVA: 0x005B66D0 File Offset: 0x005B48D0
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029A3A RID: 170554 RVA: 0x005B66DB File Offset: 0x005B48DB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06029A3B RID: 170555 RVA: 0x005B66E6 File Offset: 0x005B48E6
		public static Offset<ICommonBtSelector> EndICommonBtSelector(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtSelector>(builder.EndTable());
		}

		// Token: 0x06029A3C RID: 170556 RVA: 0x005B66F4 File Offset: 0x005B48F4
		public ICommonBtSelectorT UnPack()
		{
			ICommonBtSelectorT commonBtSelectorT = new ICommonBtSelectorT();
			this.UnPackTo(commonBtSelectorT);
			return commonBtSelectorT;
		}

		// Token: 0x06029A3D RID: 170557 RVA: 0x005B6710 File Offset: 0x005B4910
		public void UnPackTo(ICommonBtSelectorT _o)
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
			_o.Children = new List<TCommonBtNodeUnion>();
			for (int j = 0; j < this.ChildrenLength; j++)
			{
				TCommonBtNodeUnion tcommonBtNodeUnion = new TCommonBtNodeUnion();
				tcommonBtNodeUnion.Type = this.ChildrenType(j);
				switch (this.ChildrenType(j))
				{
				case TCommonBtNode.ICommonBtProbability:
					tcommonBtNodeUnion.Value = ((this.Children<ICommonBtProbability>(j) != null) ? this.Children<ICommonBtProbability>(j).Value.UnPack() : null);
					break;
				case TCommonBtNode.ICommonBtSelector:
					tcommonBtNodeUnion.Value = ((this.Children<ICommonBtSelector>(j) != null) ? this.Children<ICommonBtSelector>(j).Value.UnPack() : null);
					break;
				case TCommonBtNode.ICommonBtSequence:
					tcommonBtNodeUnion.Value = ((this.Children<ICommonBtSequence>(j) != null) ? this.Children<ICommonBtSequence>(j).Value.UnPack() : null);
					break;
				case TCommonBtNode.ICommonBtStart:
					tcommonBtNodeUnion.Value = ((this.Children<ICommonBtStart>(j) != null) ? this.Children<ICommonBtStart>(j).Value.UnPack() : null);
					break;
				case TCommonBtNode.ICommonBtTask:
					tcommonBtNodeUnion.Value = ((this.Children<ICommonBtTask>(j) != null) ? this.Children<ICommonBtTask>(j).Value.UnPack() : null);
					break;
				}
				_o.Children.Add(tcommonBtNodeUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029A3E RID: 170558 RVA: 0x005B6A6C File Offset: 0x005B4C6C
		public static Offset<ICommonBtSelector> Pack(FlatBufferBuilder builder, ICommonBtSelectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtSelector>);
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
				decorators_typeOffset = ICommonBtSelector.CreateDecoratorsTypeVector(builder, array);
			}
			VectorOffset decoratorsOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				int[] array2 = new int[_o.Decorators.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TCommonBtDecoratorUnion.Pack(builder, _o.Decorators[j]);
				}
				decoratorsOffset = ICommonBtSelector.CreateDecoratorsVector(builder, array2);
			}
			VectorOffset children_typeOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				TCommonBtNode[] array3 = new TCommonBtNode[_o.Children.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = _o.Children[k].Type;
				}
				children_typeOffset = ICommonBtSelector.CreateChildrenTypeVector(builder, array3);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				int[] array4 = new int[_o.Children.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TCommonBtNodeUnion.Pack(builder, _o.Children[l]);
				}
				childrenOffset = ICommonBtSelector.CreateChildrenVector(builder, array4);
			}
			return ICommonBtSelector.CreateICommonBtSelector(builder, _o.Type, _o.Id, descOffset, decorators_typeOffset, decoratorsOffset, _o._FoldedForTree, children_typeOffset, childrenOffset, _o.NullMask);
		}

		// Token: 0x0400F94D RID: 63821
		private Table __p;
	}
}
