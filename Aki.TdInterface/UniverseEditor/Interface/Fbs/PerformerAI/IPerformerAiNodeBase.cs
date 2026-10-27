using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200436C RID: 17260
	public struct IPerformerAiNodeBase : IFlatbufferObject
	{
		// Token: 0x170079CA RID: 31178
		// (get) Token: 0x06019994 RID: 104852 RVA: 0x003A9CED File Offset: 0x003A7EED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019995 RID: 104853 RVA: 0x003A9CFA File Offset: 0x003A7EFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019996 RID: 104854 RVA: 0x003A9D04 File Offset: 0x003A7F04
		public static IPerformerAiNodeBase GetRootAsIPerformerAiNodeBase(ByteBuffer _bb)
		{
			return IPerformerAiNodeBase.GetRootAsIPerformerAiNodeBase(_bb, default(IPerformerAiNodeBase));
		}

		// Token: 0x06019997 RID: 104855 RVA: 0x003A9D20 File Offset: 0x003A7F20
		public static IPerformerAiNodeBase GetRootAsIPerformerAiNodeBase(ByteBuffer _bb, IPerformerAiNodeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019998 RID: 104856 RVA: 0x003A9D3D File Offset: 0x003A7F3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019999 RID: 104857 RVA: 0x003A9D4C File Offset: 0x003A7F4C
		public IPerformerAiNodeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079CB RID: 31179
		// (get) Token: 0x0601999A RID: 104858 RVA: 0x003A9D5C File Offset: 0x003A7F5C
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

		// Token: 0x170079CC RID: 31180
		// (get) Token: 0x0601999B RID: 104859 RVA: 0x003A9D98 File Offset: 0x003A7F98
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

		// Token: 0x170079CD RID: 31181
		// (get) Token: 0x0601999C RID: 104860 RVA: 0x003A9DD4 File Offset: 0x003A7FD4
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

		// Token: 0x0601999D RID: 104861 RVA: 0x003A9E0B File Offset: 0x003A800B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601999E RID: 104862 RVA: 0x003A9E1A File Offset: 0x003A801A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601999F RID: 104863 RVA: 0x003A9E28 File Offset: 0x003A8028
		public TPerformerAiDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TPerformerAiDecorator.NONE;
			}
			return (TPerformerAiDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170079CE RID: 31182
		// (get) Token: 0x060199A0 RID: 104864 RVA: 0x003A9E68 File Offset: 0x003A8068
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

		// Token: 0x060199A1 RID: 104865 RVA: 0x003A9E94 File Offset: 0x003A8094
		public Span<TPerformerAiDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiDecorator>(10, 1);
		}

		// Token: 0x060199A2 RID: 104866 RVA: 0x003A9EA4 File Offset: 0x003A80A4
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

		// Token: 0x060199A3 RID: 104867 RVA: 0x003A9F10 File Offset: 0x003A8110
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170079CF RID: 31183
		// (get) Token: 0x060199A4 RID: 104868 RVA: 0x003A9F58 File Offset: 0x003A8158
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

		// Token: 0x170079D0 RID: 31184
		// (get) Token: 0x060199A5 RID: 104869 RVA: 0x003A9F84 File Offset: 0x003A8184
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170079D1 RID: 31185
		// (get) Token: 0x060199A6 RID: 104870 RVA: 0x003A9FC4 File Offset: 0x003A81C4
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

		// Token: 0x060199A7 RID: 104871 RVA: 0x003AA004 File Offset: 0x003A8204
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

		// Token: 0x060199A8 RID: 104872 RVA: 0x003AA053 File Offset: 0x003A8253
		public static void StartIPerformerAiNodeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060199A9 RID: 104873 RVA: 0x003AA05C File Offset: 0x003A825C
		public static void AddType(FlatBufferBuilder builder, EPerformerAiNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060199AA RID: 104874 RVA: 0x003AA067 File Offset: 0x003A8267
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060199AB RID: 104875 RVA: 0x003AA072 File Offset: 0x003A8272
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x060199AC RID: 104876 RVA: 0x003AA082 File Offset: 0x003A8282
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x060199AD RID: 104877 RVA: 0x003AA094 File Offset: 0x003A8294
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060199AE RID: 104878 RVA: 0x003AA0CB File Offset: 0x003A82CB
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x060199AF RID: 104879 RVA: 0x003AA0E5 File Offset: 0x003A82E5
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x060199B0 RID: 104880 RVA: 0x003AA103 File Offset: 0x003A8303
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060199B1 RID: 104881 RVA: 0x003AA11C File Offset: 0x003A831C
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060199B2 RID: 104882 RVA: 0x003AA127 File Offset: 0x003A8327
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x060199B3 RID: 104883 RVA: 0x003AA138 File Offset: 0x003A8338
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060199B4 RID: 104884 RVA: 0x003AA16F File Offset: 0x003A836F
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060199B5 RID: 104885 RVA: 0x003AA189 File Offset: 0x003A8389
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060199B6 RID: 104886 RVA: 0x003AA1A7 File Offset: 0x003A83A7
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060199B7 RID: 104887 RVA: 0x003AA1C0 File Offset: 0x003A83C0
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060199B8 RID: 104888 RVA: 0x003AA1CB File Offset: 0x003A83CB
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x060199B9 RID: 104889 RVA: 0x003AA1D6 File Offset: 0x003A83D6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060199BA RID: 104890 RVA: 0x003AA1E1 File Offset: 0x003A83E1
		public static Offset<IPerformerAiNodeBase> EndIPerformerAiNodeBase(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiNodeBase>(builder.EndTable());
		}

		// Token: 0x060199BB RID: 104891 RVA: 0x003AA1F0 File Offset: 0x003A83F0
		public IPerformerAiNodeBaseT UnPack()
		{
			IPerformerAiNodeBaseT performerAiNodeBaseT = new IPerformerAiNodeBaseT();
			this.UnPackTo(performerAiNodeBaseT);
			return performerAiNodeBaseT;
		}

		// Token: 0x060199BC RID: 104892 RVA: 0x003AA20C File Offset: 0x003A840C
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

		// Token: 0x060199BD RID: 104893 RVA: 0x003AA3D0 File Offset: 0x003A85D0
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

		// Token: 0x0400C164 RID: 49508
		private Table __p;
	}
}
