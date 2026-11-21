using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047CE RID: 18382
	public struct IPerformerAiNodeBase : IFlatbufferObject
	{
		// Token: 0x17007FFF RID: 32767
		// (get) Token: 0x0601B122 RID: 110882 RVA: 0x003D5715 File Offset: 0x003D3915
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B123 RID: 110883 RVA: 0x003D5722 File Offset: 0x003D3922
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B124 RID: 110884 RVA: 0x003D572C File Offset: 0x003D392C
		public static IPerformerAiNodeBase GetRootAsIPerformerAiNodeBase(ByteBuffer _bb)
		{
			return IPerformerAiNodeBase.GetRootAsIPerformerAiNodeBase(_bb, default(IPerformerAiNodeBase));
		}

		// Token: 0x0601B125 RID: 110885 RVA: 0x003D5748 File Offset: 0x003D3948
		public static IPerformerAiNodeBase GetRootAsIPerformerAiNodeBase(ByteBuffer _bb, IPerformerAiNodeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B126 RID: 110886 RVA: 0x003D5765 File Offset: 0x003D3965
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B127 RID: 110887 RVA: 0x003D5774 File Offset: 0x003D3974
		public IPerformerAiNodeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008000 RID: 32768
		// (get) Token: 0x0601B128 RID: 110888 RVA: 0x003D5784 File Offset: 0x003D3984
		public EPerformerAiNodeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformerAiNodeType.Start;
				}
				return (EPerformerAiNodeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008001 RID: 32769
		// (get) Token: 0x0601B129 RID: 110889 RVA: 0x003D57C0 File Offset: 0x003D39C0
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

		// Token: 0x17008002 RID: 32770
		// (get) Token: 0x0601B12A RID: 110890 RVA: 0x003D57FC File Offset: 0x003D39FC
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

		// Token: 0x0601B12B RID: 110891 RVA: 0x003D5833 File Offset: 0x003D3A33
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B12C RID: 110892 RVA: 0x003D5842 File Offset: 0x003D3A42
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601B12D RID: 110893 RVA: 0x003D5850 File Offset: 0x003D3A50
		public TPerformerAiDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TPerformerAiDecorator.NONE;
			}
			return (TPerformerAiDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008003 RID: 32771
		// (get) Token: 0x0601B12E RID: 110894 RVA: 0x003D5890 File Offset: 0x003D3A90
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

		// Token: 0x0601B12F RID: 110895 RVA: 0x003D58BC File Offset: 0x003D3ABC
		public Span<TPerformerAiDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiDecorator>(10, 1);
		}

		// Token: 0x0601B130 RID: 110896 RVA: 0x003D58CC File Offset: 0x003D3ACC
		public TPerformerAiDecorator[] GetDecoratorsTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TPerformerAiDecorator[] array = new TPerformerAiDecorator[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TPerformerAiDecorator)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601B131 RID: 110897 RVA: 0x003D5938 File Offset: 0x003D3B38
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008004 RID: 32772
		// (get) Token: 0x0601B132 RID: 110898 RVA: 0x003D5980 File Offset: 0x003D3B80
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

		// Token: 0x17008005 RID: 32773
		// (get) Token: 0x0601B133 RID: 110899 RVA: 0x003D59AC File Offset: 0x003D3BAC
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008006 RID: 32774
		// (get) Token: 0x0601B134 RID: 110900 RVA: 0x003D59EC File Offset: 0x003D3BEC
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

		// Token: 0x0601B135 RID: 110901 RVA: 0x003D5A2C File Offset: 0x003D3C2C
		public static Offset<IPerformerAiNodeBase> CreateIPerformerAiNodeBase(FlatBufferBuilder builder, EPerformerAiNodeType Type = EPerformerAiNodeType.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), VectorOffset Decorators_typeOffset = default(VectorOffset), VectorOffset DecoratorsOffset = default(VectorOffset), bool _foldedForTree = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IPerformerAiNodeBase.AddDecorators(builder, DecoratorsOffset);
			IPerformerAiNodeBase.AddDecoratorsType(builder, Decorators_typeOffset);
			IPerformerAiNodeBase.AddDesc(builder, DescOffset);
			IPerformerAiNodeBase.AddId(builder, Id);
			IPerformerAiNodeBase.AddNullMask(builder, NullMask);
			IPerformerAiNodeBase.Add_FoldedForTree(builder, _foldedForTree);
			IPerformerAiNodeBase.AddType(builder, Type);
			return IPerformerAiNodeBase.EndIPerformerAiNodeBase(builder);
		}

		// Token: 0x0601B136 RID: 110902 RVA: 0x003D5A7B File Offset: 0x003D3C7B
		public static void StartIPerformerAiNodeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601B137 RID: 110903 RVA: 0x003D5A84 File Offset: 0x003D3C84
		public static void AddType(FlatBufferBuilder builder, EPerformerAiNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B138 RID: 110904 RVA: 0x003D5A8F File Offset: 0x003D3C8F
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601B139 RID: 110905 RVA: 0x003D5A9A File Offset: 0x003D3C9A
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0601B13A RID: 110906 RVA: 0x003D5AAA File Offset: 0x003D3CAA
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x0601B13B RID: 110907 RVA: 0x003D5ABC File Offset: 0x003D3CBC
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B13C RID: 110908 RVA: 0x003D5AF3 File Offset: 0x003D3CF3
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B13D RID: 110909 RVA: 0x003D5B0D File Offset: 0x003D3D0D
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B13E RID: 110910 RVA: 0x003D5B2B File Offset: 0x003D3D2B
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B13F RID: 110911 RVA: 0x003D5B44 File Offset: 0x003D3D44
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601B140 RID: 110912 RVA: 0x003D5B4F File Offset: 0x003D3D4F
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x0601B141 RID: 110913 RVA: 0x003D5B60 File Offset: 0x003D3D60
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B142 RID: 110914 RVA: 0x003D5B97 File Offset: 0x003D3D97
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B143 RID: 110915 RVA: 0x003D5BB1 File Offset: 0x003D3DB1
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B144 RID: 110916 RVA: 0x003D5BCF File Offset: 0x003D3DCF
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B145 RID: 110917 RVA: 0x003D5BE8 File Offset: 0x003D3DE8
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B146 RID: 110918 RVA: 0x003D5BF3 File Offset: 0x003D3DF3
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x0601B147 RID: 110919 RVA: 0x003D5BFE File Offset: 0x003D3DFE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601B148 RID: 110920 RVA: 0x003D5C09 File Offset: 0x003D3E09
		public static Offset<IPerformerAiNodeBase> EndIPerformerAiNodeBase(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiNodeBase>(builder.EndTable());
		}

		// Token: 0x0601B149 RID: 110921 RVA: 0x003D5C18 File Offset: 0x003D3E18
		public IPerformerAiNodeBaseT UnPack()
		{
			IPerformerAiNodeBaseT performerAiNodeBaseT = new IPerformerAiNodeBaseT();
			this.UnPackTo(performerAiNodeBaseT);
			return performerAiNodeBaseT;
		}

		// Token: 0x0601B14A RID: 110922 RVA: 0x003D5C34 File Offset: 0x003D3E34
		public void UnPackTo(IPerformerAiNodeBaseT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.Decorators = new List<TPerformerAiDecoratorUnion>();
			for (int i = 0; i < this.DecoratorsLength; i++)
			{
				TPerformerAiDecoratorUnion tperformerAiDecoratorUnion = new TPerformerAiDecoratorUnion();
				tperformerAiDecoratorUnion.Type = this.DecoratorsType(i);
				switch (this.DecoratorsType(i))
				{
				case TPerformerAiDecorator.IPerformerAiAlwaysFalseDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiAlwaysFalseDecorator>(i) != null) ? this.Decorators<IPerformerAiAlwaysFalseDecorator>(i).Value.UnPack() : null);
					break;
				case TPerformerAiDecorator.IPerformerAiAlwaysTrueDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiAlwaysTrueDecorator>(i) != null) ? this.Decorators<IPerformerAiAlwaysTrueDecorator>(i).Value.UnPack() : null);
					break;
				case TPerformerAiDecorator.IPerformerAiConditionDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiConditionDecorator>(i) != null) ? this.Decorators<IPerformerAiConditionDecorator>(i).Value.UnPack() : null);
					break;
				case TPerformerAiDecorator.IPerformerAiCoolDownDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiCoolDownDecorator>(i) != null) ? this.Decorators<IPerformerAiCoolDownDecorator>(i).Value.UnPack() : null);
					break;
				case TPerformerAiDecorator.IPerformerAiDoOnceDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiDoOnceDecorator>(i) != null) ? this.Decorators<IPerformerAiDoOnceDecorator>(i).Value.UnPack() : null);
					break;
				}
				_o.Decorators.Add(tperformerAiDecoratorUnion);
			}
			_o._FoldedForTree = this._FoldedForTree;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B14B RID: 110923 RVA: 0x003D5DF8 File Offset: 0x003D3FF8
		public static Offset<IPerformerAiNodeBase> Pack(FlatBufferBuilder builder, IPerformerAiNodeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiNodeBase>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			VectorOffset decorators_typeOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				TPerformerAiDecorator[] array = new TPerformerAiDecorator[_o.Decorators.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Decorators[i].Type;
				}
				decorators_typeOffset = IPerformerAiNodeBase.CreateDecoratorsTypeVector(builder, array);
			}
			VectorOffset decoratorsOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				int[] array2 = new int[_o.Decorators.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TPerformerAiDecoratorUnion.Pack(builder, _o.Decorators[j]);
				}
				decoratorsOffset = IPerformerAiNodeBase.CreateDecoratorsVector(builder, array2);
			}
			return IPerformerAiNodeBase.CreateIPerformerAiNodeBase(builder, _o.Type, _o.Id, descOffset, decorators_typeOffset, decoratorsOffset, _o._FoldedForTree, _o.NullMask);
		}

		// Token: 0x0400CB82 RID: 52098
		private Table __p;
	}
}
