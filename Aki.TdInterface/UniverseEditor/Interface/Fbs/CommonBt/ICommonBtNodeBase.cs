using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006500 RID: 25856
	public struct ICommonBtNodeBase : IFlatbufferObject
	{
		// Token: 0x1700BE9C RID: 48796
		// (get) Token: 0x0602C013 RID: 180243 RVA: 0x005FD945 File Offset: 0x005FBB45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C014 RID: 180244 RVA: 0x005FD952 File Offset: 0x005FBB52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C015 RID: 180245 RVA: 0x005FD95C File Offset: 0x005FBB5C
		public static ICommonBtNodeBase GetRootAsICommonBtNodeBase(ByteBuffer _bb)
		{
			return ICommonBtNodeBase.GetRootAsICommonBtNodeBase(_bb, default(ICommonBtNodeBase));
		}

		// Token: 0x0602C016 RID: 180246 RVA: 0x005FD978 File Offset: 0x005FBB78
		public static ICommonBtNodeBase GetRootAsICommonBtNodeBase(ByteBuffer _bb, ICommonBtNodeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C017 RID: 180247 RVA: 0x005FD995 File Offset: 0x005FBB95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C018 RID: 180248 RVA: 0x005FD9A4 File Offset: 0x005FBBA4
		public ICommonBtNodeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE9D RID: 48797
		// (get) Token: 0x0602C019 RID: 180249 RVA: 0x005FD9B4 File Offset: 0x005FBBB4
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

		// Token: 0x1700BE9E RID: 48798
		// (get) Token: 0x0602C01A RID: 180250 RVA: 0x005FD9F0 File Offset: 0x005FBBF0
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

		// Token: 0x1700BE9F RID: 48799
		// (get) Token: 0x0602C01B RID: 180251 RVA: 0x005FDA2C File Offset: 0x005FBC2C
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

		// Token: 0x0602C01C RID: 180252 RVA: 0x005FDA63 File Offset: 0x005FBC63
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602C01D RID: 180253 RVA: 0x005FDA72 File Offset: 0x005FBC72
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602C01E RID: 180254 RVA: 0x005FDA80 File Offset: 0x005FBC80
		public TCommonBtDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TCommonBtDecorator.NONE;
			}
			return (TCommonBtDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700BEA0 RID: 48800
		// (get) Token: 0x0602C01F RID: 180255 RVA: 0x005FDAC0 File Offset: 0x005FBCC0
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

		// Token: 0x0602C020 RID: 180256 RVA: 0x005FDAEC File Offset: 0x005FBCEC
		public Span<TCommonBtDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtDecorator>(10, 1);
		}

		// Token: 0x0602C021 RID: 180257 RVA: 0x005FDAFC File Offset: 0x005FBCFC
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

		// Token: 0x0602C022 RID: 180258 RVA: 0x005FDB68 File Offset: 0x005FBD68
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700BEA1 RID: 48801
		// (get) Token: 0x0602C023 RID: 180259 RVA: 0x005FDBB0 File Offset: 0x005FBDB0
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

		// Token: 0x1700BEA2 RID: 48802
		// (get) Token: 0x0602C024 RID: 180260 RVA: 0x005FDBDC File Offset: 0x005FBDDC
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BEA3 RID: 48803
		// (get) Token: 0x0602C025 RID: 180261 RVA: 0x005FDC1C File Offset: 0x005FBE1C
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

		// Token: 0x0602C026 RID: 180262 RVA: 0x005FDC5C File Offset: 0x005FBE5C
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

		// Token: 0x0602C027 RID: 180263 RVA: 0x005FDCAB File Offset: 0x005FBEAB
		public static void StartICommonBtNodeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602C028 RID: 180264 RVA: 0x005FDCB4 File Offset: 0x005FBEB4
		public static void AddType(FlatBufferBuilder builder, ECommonBtNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C029 RID: 180265 RVA: 0x005FDCBF File Offset: 0x005FBEBF
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602C02A RID: 180266 RVA: 0x005FDCCA File Offset: 0x005FBECA
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0602C02B RID: 180267 RVA: 0x005FDCDA File Offset: 0x005FBEDA
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x0602C02C RID: 180268 RVA: 0x005FDCEC File Offset: 0x005FBEEC
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C02D RID: 180269 RVA: 0x005FDD23 File Offset: 0x005FBF23
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C02E RID: 180270 RVA: 0x005FDD3D File Offset: 0x005FBF3D
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C02F RID: 180271 RVA: 0x005FDD5B File Offset: 0x005FBF5B
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C030 RID: 180272 RVA: 0x005FDD74 File Offset: 0x005FBF74
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602C031 RID: 180273 RVA: 0x005FDD7F File Offset: 0x005FBF7F
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x0602C032 RID: 180274 RVA: 0x005FDD90 File Offset: 0x005FBF90
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C033 RID: 180275 RVA: 0x005FDDC7 File Offset: 0x005FBFC7
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C034 RID: 180276 RVA: 0x005FDDE1 File Offset: 0x005FBFE1
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C035 RID: 180277 RVA: 0x005FDDFF File Offset: 0x005FBFFF
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C036 RID: 180278 RVA: 0x005FDE18 File Offset: 0x005FC018
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C037 RID: 180279 RVA: 0x005FDE23 File Offset: 0x005FC023
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x0602C038 RID: 180280 RVA: 0x005FDE2E File Offset: 0x005FC02E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602C039 RID: 180281 RVA: 0x005FDE39 File Offset: 0x005FC039
		public static Offset<ICommonBtNodeBase> EndICommonBtNodeBase(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtNodeBase>(builder.EndTable());
		}

		// Token: 0x0602C03A RID: 180282 RVA: 0x005FDE48 File Offset: 0x005FC048
		public ICommonBtNodeBaseT UnPack()
		{
			ICommonBtNodeBaseT commonBtNodeBaseT = new ICommonBtNodeBaseT();
			this.UnPackTo(commonBtNodeBaseT);
			return commonBtNodeBaseT;
		}

		// Token: 0x0602C03B RID: 180283 RVA: 0x005FDE64 File Offset: 0x005FC064
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

		// Token: 0x0602C03C RID: 180284 RVA: 0x005FE028 File Offset: 0x005FC228
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

		// Token: 0x04010696 RID: 67222
		private Table __p;
	}
}
