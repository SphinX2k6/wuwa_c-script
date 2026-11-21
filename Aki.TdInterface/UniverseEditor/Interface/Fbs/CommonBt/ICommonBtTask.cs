using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006512 RID: 25874
	public struct ICommonBtTask : IFlatbufferObject
	{
		// Token: 0x1700BEF1 RID: 48881
		// (get) Token: 0x0602C192 RID: 180626 RVA: 0x00601C75 File Offset: 0x005FFE75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C193 RID: 180627 RVA: 0x00601C82 File Offset: 0x005FFE82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C194 RID: 180628 RVA: 0x00601C8C File Offset: 0x005FFE8C
		public static ICommonBtTask GetRootAsICommonBtTask(ByteBuffer _bb)
		{
			return ICommonBtTask.GetRootAsICommonBtTask(_bb, default(ICommonBtTask));
		}

		// Token: 0x0602C195 RID: 180629 RVA: 0x00601CA8 File Offset: 0x005FFEA8
		public static ICommonBtTask GetRootAsICommonBtTask(ByteBuffer _bb, ICommonBtTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C196 RID: 180630 RVA: 0x00601CC5 File Offset: 0x005FFEC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C197 RID: 180631 RVA: 0x00601CD4 File Offset: 0x005FFED4
		public ICommonBtTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEF2 RID: 48882
		// (get) Token: 0x0602C198 RID: 180632 RVA: 0x00601CE4 File Offset: 0x005FFEE4
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

		// Token: 0x1700BEF3 RID: 48883
		// (get) Token: 0x0602C199 RID: 180633 RVA: 0x00601D20 File Offset: 0x005FFF20
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

		// Token: 0x1700BEF4 RID: 48884
		// (get) Token: 0x0602C19A RID: 180634 RVA: 0x00601D5C File Offset: 0x005FFF5C
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

		// Token: 0x0602C19B RID: 180635 RVA: 0x00601D93 File Offset: 0x005FFF93
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602C19C RID: 180636 RVA: 0x00601DA2 File Offset: 0x005FFFA2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602C19D RID: 180637 RVA: 0x00601DB0 File Offset: 0x005FFFB0
		public TCommonBtDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TCommonBtDecorator.NONE;
			}
			return (TCommonBtDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700BEF5 RID: 48885
		// (get) Token: 0x0602C19E RID: 180638 RVA: 0x00601DF0 File Offset: 0x005FFFF0
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

		// Token: 0x0602C19F RID: 180639 RVA: 0x00601E1C File Offset: 0x0060001C
		public Span<TCommonBtDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtDecorator>(10, 1);
		}

		// Token: 0x0602C1A0 RID: 180640 RVA: 0x00601E2C File Offset: 0x0060002C
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

		// Token: 0x0602C1A1 RID: 180641 RVA: 0x00601E98 File Offset: 0x00600098
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700BEF6 RID: 48886
		// (get) Token: 0x0602C1A2 RID: 180642 RVA: 0x00601EE0 File Offset: 0x006000E0
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

		// Token: 0x1700BEF7 RID: 48887
		// (get) Token: 0x0602C1A3 RID: 180643 RVA: 0x00601F0C File Offset: 0x0060010C
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BEF8 RID: 48888
		// (get) Token: 0x0602C1A4 RID: 180644 RVA: 0x00601F4C File Offset: 0x0060014C
		public ICommonBtActionInfo? ActionInfo
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ICommonBtActionInfo?(default(ICommonBtActionInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BEF9 RID: 48889
		// (get) Token: 0x0602C1A5 RID: 180645 RVA: 0x00601FAC File Offset: 0x006001AC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C1A6 RID: 180646 RVA: 0x00601FEC File Offset: 0x006001EC
		public static Offset<ICommonBtTask> CreateICommonBtTask(FlatBufferBuilder builder, ECommonBtNodeType Type = ECommonBtNodeType.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), VectorOffset Decorators_typeOffset = default(VectorOffset), VectorOffset DecoratorsOffset = default(VectorOffset), bool _foldedForTree = false, Offset<ICommonBtActionInfo> ActionInfoOffset = default(Offset<ICommonBtActionInfo>), byte NullMask = 0)
		{
			builder.StartTable(8);
			ICommonBtTask.AddActionInfo(builder, ActionInfoOffset);
			ICommonBtTask.AddDecorators(builder, DecoratorsOffset);
			ICommonBtTask.AddDecoratorsType(builder, Decorators_typeOffset);
			ICommonBtTask.AddDesc(builder, DescOffset);
			ICommonBtTask.AddId(builder, Id);
			ICommonBtTask.AddNullMask(builder, NullMask);
			ICommonBtTask.Add_FoldedForTree(builder, _foldedForTree);
			ICommonBtTask.AddType(builder, Type);
			return ICommonBtTask.EndICommonBtTask(builder);
		}

		// Token: 0x0602C1A7 RID: 180647 RVA: 0x00602043 File Offset: 0x00600243
		public static void StartICommonBtTask(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602C1A8 RID: 180648 RVA: 0x0060204C File Offset: 0x0060024C
		public static void AddType(FlatBufferBuilder builder, ECommonBtNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C1A9 RID: 180649 RVA: 0x00602057 File Offset: 0x00600257
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602C1AA RID: 180650 RVA: 0x00602062 File Offset: 0x00600262
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0602C1AB RID: 180651 RVA: 0x00602072 File Offset: 0x00600272
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x0602C1AC RID: 180652 RVA: 0x00602084 File Offset: 0x00600284
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C1AD RID: 180653 RVA: 0x006020BB File Offset: 0x006002BB
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C1AE RID: 180654 RVA: 0x006020D5 File Offset: 0x006002D5
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C1AF RID: 180655 RVA: 0x006020F3 File Offset: 0x006002F3
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C1B0 RID: 180656 RVA: 0x0060210C File Offset: 0x0060030C
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602C1B1 RID: 180657 RVA: 0x00602117 File Offset: 0x00600317
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x0602C1B2 RID: 180658 RVA: 0x00602128 File Offset: 0x00600328
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C1B3 RID: 180659 RVA: 0x0060215F File Offset: 0x0060035F
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C1B4 RID: 180660 RVA: 0x00602179 File Offset: 0x00600379
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C1B5 RID: 180661 RVA: 0x00602197 File Offset: 0x00600397
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C1B6 RID: 180662 RVA: 0x006021B0 File Offset: 0x006003B0
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C1B7 RID: 180663 RVA: 0x006021BB File Offset: 0x006003BB
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x0602C1B8 RID: 180664 RVA: 0x006021C6 File Offset: 0x006003C6
		public static void AddActionInfo(FlatBufferBuilder builder, Offset<ICommonBtActionInfo> actionInfoOffset)
		{
			builder.AddOffset(6, actionInfoOffset.Value, 0);
		}

		// Token: 0x0602C1B9 RID: 180665 RVA: 0x006021D6 File Offset: 0x006003D6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602C1BA RID: 180666 RVA: 0x006021E1 File Offset: 0x006003E1
		public static Offset<ICommonBtTask> EndICommonBtTask(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtTask>(builder.EndTable());
		}

		// Token: 0x0602C1BB RID: 180667 RVA: 0x006021F0 File Offset: 0x006003F0
		public ICommonBtTaskT UnPack()
		{
			ICommonBtTaskT commonBtTaskT = new ICommonBtTaskT();
			this.UnPackTo(commonBtTaskT);
			return commonBtTaskT;
		}

		// Token: 0x0602C1BC RID: 180668 RVA: 0x0060220C File Offset: 0x0060040C
		public void UnPackTo(ICommonBtTaskT _o)
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
			_o.ActionInfo = ((this.ActionInfo != null) ? this.ActionInfo.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C1BD RID: 180669 RVA: 0x00602404 File Offset: 0x00600604
		public static Offset<ICommonBtTask> Pack(FlatBufferBuilder builder, ICommonBtTaskT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtTask>);
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
				decorators_typeOffset = ICommonBtTask.CreateDecoratorsTypeVector(builder, array);
			}
			VectorOffset decoratorsOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				int[] array2 = new int[_o.Decorators.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TCommonBtDecoratorUnion.Pack(builder, _o.Decorators[j]);
				}
				decoratorsOffset = ICommonBtTask.CreateDecoratorsVector(builder, array2);
			}
			Offset<ICommonBtActionInfo> actionInfoOffset = (_o.ActionInfo == null) ? default(Offset<ICommonBtActionInfo>) : ICommonBtActionInfo.Pack(builder, _o.ActionInfo);
			return ICommonBtTask.CreateICommonBtTask(builder, _o.Type, _o.Id, descOffset, decorators_typeOffset, decoratorsOffset, _o._FoldedForTree, actionInfoOffset, _o.NullMask);
		}

		// Token: 0x040106C8 RID: 67272
		private Table __p;
	}
}
