using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EBD RID: 24253
	public struct ICommonBtNodeBase : IFlatbufferObject
	{
		// Token: 0x1700B531 RID: 46385
		// (get) Token: 0x0602995F RID: 170335 RVA: 0x005B4461 File Offset: 0x005B2661
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029960 RID: 170336 RVA: 0x005B446E File Offset: 0x005B266E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029961 RID: 170337 RVA: 0x005B4478 File Offset: 0x005B2678
		public static ICommonBtNodeBase GetRootAsICommonBtNodeBase(ByteBuffer _bb)
		{
			return ICommonBtNodeBase.GetRootAsICommonBtNodeBase(_bb, default(ICommonBtNodeBase));
		}

		// Token: 0x06029962 RID: 170338 RVA: 0x005B4494 File Offset: 0x005B2694
		public static ICommonBtNodeBase GetRootAsICommonBtNodeBase(ByteBuffer _bb, ICommonBtNodeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029963 RID: 170339 RVA: 0x005B44B1 File Offset: 0x005B26B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029964 RID: 170340 RVA: 0x005B44C0 File Offset: 0x005B26C0
		public ICommonBtNodeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B532 RID: 46386
		// (get) Token: 0x06029965 RID: 170341 RVA: 0x005B44D0 File Offset: 0x005B26D0
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

		// Token: 0x1700B533 RID: 46387
		// (get) Token: 0x06029966 RID: 170342 RVA: 0x005B450C File Offset: 0x005B270C
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

		// Token: 0x1700B534 RID: 46388
		// (get) Token: 0x06029967 RID: 170343 RVA: 0x005B4548 File Offset: 0x005B2748
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

		// Token: 0x06029968 RID: 170344 RVA: 0x005B457F File Offset: 0x005B277F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06029969 RID: 170345 RVA: 0x005B458E File Offset: 0x005B278E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602996A RID: 170346 RVA: 0x005B459C File Offset: 0x005B279C
		public TCommonBtDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TCommonBtDecorator.NONE;
			}
			return (TCommonBtDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B535 RID: 46389
		// (get) Token: 0x0602996B RID: 170347 RVA: 0x005B45DC File Offset: 0x005B27DC
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

		// Token: 0x0602996C RID: 170348 RVA: 0x005B4608 File Offset: 0x005B2808
		public Span<TCommonBtDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtDecorator>(10, 1);
		}

		// Token: 0x0602996D RID: 170349 RVA: 0x005B4618 File Offset: 0x005B2818
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

		// Token: 0x0602996E RID: 170350 RVA: 0x005B4684 File Offset: 0x005B2884
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B536 RID: 46390
		// (get) Token: 0x0602996F RID: 170351 RVA: 0x005B46CC File Offset: 0x005B28CC
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

		// Token: 0x1700B537 RID: 46391
		// (get) Token: 0x06029970 RID: 170352 RVA: 0x005B46F8 File Offset: 0x005B28F8
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B538 RID: 46392
		// (get) Token: 0x06029971 RID: 170353 RVA: 0x005B4738 File Offset: 0x005B2938
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029972 RID: 170354 RVA: 0x005B4778 File Offset: 0x005B2978
		public static Offset<ICommonBtNodeBase> CreateICommonBtNodeBase(FlatBufferBuilder builder, ECommonBtNodeType Type = ECommonBtNodeType.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), VectorOffset Decorators_typeOffset = default(VectorOffset), VectorOffset DecoratorsOffset = default(VectorOffset), bool _foldedForTree = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			ICommonBtNodeBase.AddDecorators(builder, DecoratorsOffset);
			ICommonBtNodeBase.AddDecoratorsType(builder, Decorators_typeOffset);
			ICommonBtNodeBase.AddDesc(builder, DescOffset);
			ICommonBtNodeBase.AddId(builder, Id);
			ICommonBtNodeBase.AddNullMask(builder, NullMask);
			ICommonBtNodeBase.Add_FoldedForTree(builder, _foldedForTree);
			ICommonBtNodeBase.AddType(builder, Type);
			return ICommonBtNodeBase.EndICommonBtNodeBase(builder);
		}

		// Token: 0x06029973 RID: 170355 RVA: 0x005B47C7 File Offset: 0x005B29C7
		public static void StartICommonBtNodeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06029974 RID: 170356 RVA: 0x005B47D0 File Offset: 0x005B29D0
		public static void AddType(FlatBufferBuilder builder, ECommonBtNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029975 RID: 170357 RVA: 0x005B47DB File Offset: 0x005B29DB
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06029976 RID: 170358 RVA: 0x005B47E6 File Offset: 0x005B29E6
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06029977 RID: 170359 RVA: 0x005B47F6 File Offset: 0x005B29F6
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x06029978 RID: 170360 RVA: 0x005B4808 File Offset: 0x005B2A08
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029979 RID: 170361 RVA: 0x005B483F File Offset: 0x005B2A3F
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0602997A RID: 170362 RVA: 0x005B4859 File Offset: 0x005B2A59
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0602997B RID: 170363 RVA: 0x005B4877 File Offset: 0x005B2A77
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602997C RID: 170364 RVA: 0x005B4890 File Offset: 0x005B2A90
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602997D RID: 170365 RVA: 0x005B489B File Offset: 0x005B2A9B
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x0602997E RID: 170366 RVA: 0x005B48AC File Offset: 0x005B2AAC
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602997F RID: 170367 RVA: 0x005B48E3 File Offset: 0x005B2AE3
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029980 RID: 170368 RVA: 0x005B48FD File Offset: 0x005B2AFD
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029981 RID: 170369 RVA: 0x005B491B File Offset: 0x005B2B1B
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029982 RID: 170370 RVA: 0x005B4934 File Offset: 0x005B2B34
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029983 RID: 170371 RVA: 0x005B493F File Offset: 0x005B2B3F
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x06029984 RID: 170372 RVA: 0x005B494A File Offset: 0x005B2B4A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06029985 RID: 170373 RVA: 0x005B4955 File Offset: 0x005B2B55
		public static Offset<ICommonBtNodeBase> EndICommonBtNodeBase(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtNodeBase>(builder.EndTable());
		}

		// Token: 0x06029986 RID: 170374 RVA: 0x005B4964 File Offset: 0x005B2B64
		public ICommonBtNodeBaseT UnPack()
		{
			ICommonBtNodeBaseT commonBtNodeBaseT = new ICommonBtNodeBaseT();
			this.UnPackTo(commonBtNodeBaseT);
			return commonBtNodeBaseT;
		}

		// Token: 0x06029987 RID: 170375 RVA: 0x005B4980 File Offset: 0x005B2B80
		public void UnPackTo(ICommonBtNodeBaseT _o)
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029988 RID: 170376 RVA: 0x005B4B44 File Offset: 0x005B2D44
		public static Offset<ICommonBtNodeBase> Pack(FlatBufferBuilder builder, ICommonBtNodeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtNodeBase>);
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
				decorators_typeOffset = ICommonBtNodeBase.CreateDecoratorsTypeVector(builder, array);
			}
			VectorOffset decoratorsOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				int[] array2 = new int[_o.Decorators.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TCommonBtDecoratorUnion.Pack(builder, _o.Decorators[j]);
				}
				decoratorsOffset = ICommonBtNodeBase.CreateDecoratorsVector(builder, array2);
			}
			return ICommonBtNodeBase.CreateICommonBtNodeBase(builder, _o.Type, _o.Id, descOffset, decorators_typeOffset, decoratorsOffset, _o._FoldedForTree, _o.NullMask);
		}

		// Token: 0x0400F933 RID: 63795
		private Table __p;
	}
}
