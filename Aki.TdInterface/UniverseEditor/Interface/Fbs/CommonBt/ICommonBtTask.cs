using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005ECF RID: 24271
	public struct ICommonBtTask : IFlatbufferObject
	{
		// Token: 0x1700B586 RID: 46470
		// (get) Token: 0x06029ADE RID: 170718 RVA: 0x005B8791 File Offset: 0x005B6991
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029ADF RID: 170719 RVA: 0x005B879E File Offset: 0x005B699E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029AE0 RID: 170720 RVA: 0x005B87A8 File Offset: 0x005B69A8
		public static ICommonBtTask GetRootAsICommonBtTask(ByteBuffer _bb)
		{
			return ICommonBtTask.GetRootAsICommonBtTask(_bb, default(ICommonBtTask));
		}

		// Token: 0x06029AE1 RID: 170721 RVA: 0x005B87C4 File Offset: 0x005B69C4
		public static ICommonBtTask GetRootAsICommonBtTask(ByteBuffer _bb, ICommonBtTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029AE2 RID: 170722 RVA: 0x005B87E1 File Offset: 0x005B69E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029AE3 RID: 170723 RVA: 0x005B87F0 File Offset: 0x005B69F0
		public ICommonBtTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B587 RID: 46471
		// (get) Token: 0x06029AE4 RID: 170724 RVA: 0x005B8800 File Offset: 0x005B6A00
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

		// Token: 0x1700B588 RID: 46472
		// (get) Token: 0x06029AE5 RID: 170725 RVA: 0x005B883C File Offset: 0x005B6A3C
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

		// Token: 0x1700B589 RID: 46473
		// (get) Token: 0x06029AE6 RID: 170726 RVA: 0x005B8878 File Offset: 0x005B6A78
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

		// Token: 0x06029AE7 RID: 170727 RVA: 0x005B88AF File Offset: 0x005B6AAF
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06029AE8 RID: 170728 RVA: 0x005B88BE File Offset: 0x005B6ABE
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06029AE9 RID: 170729 RVA: 0x005B88CC File Offset: 0x005B6ACC
		public TCommonBtDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TCommonBtDecorator.NONE;
			}
			return (TCommonBtDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B58A RID: 46474
		// (get) Token: 0x06029AEA RID: 170730 RVA: 0x005B890C File Offset: 0x005B6B0C
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

		// Token: 0x06029AEB RID: 170731 RVA: 0x005B8938 File Offset: 0x005B6B38
		public Span<TCommonBtDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtDecorator>(10, 1);
		}

		// Token: 0x06029AEC RID: 170732 RVA: 0x005B8948 File Offset: 0x005B6B48
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

		// Token: 0x06029AED RID: 170733 RVA: 0x005B89B4 File Offset: 0x005B6BB4
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B58B RID: 46475
		// (get) Token: 0x06029AEE RID: 170734 RVA: 0x005B89FC File Offset: 0x005B6BFC
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

		// Token: 0x1700B58C RID: 46476
		// (get) Token: 0x06029AEF RID: 170735 RVA: 0x005B8A28 File Offset: 0x005B6C28
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B58D RID: 46477
		// (get) Token: 0x06029AF0 RID: 170736 RVA: 0x005B8A68 File Offset: 0x005B6C68
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

		// Token: 0x1700B58E RID: 46478
		// (get) Token: 0x06029AF1 RID: 170737 RVA: 0x005B8AC8 File Offset: 0x005B6CC8
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

		// Token: 0x06029AF2 RID: 170738 RVA: 0x005B8B08 File Offset: 0x005B6D08
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

		// Token: 0x06029AF3 RID: 170739 RVA: 0x005B8B5F File Offset: 0x005B6D5F
		public static void StartICommonBtTask(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06029AF4 RID: 170740 RVA: 0x005B8B68 File Offset: 0x005B6D68
		public static void AddType(FlatBufferBuilder builder, ECommonBtNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029AF5 RID: 170741 RVA: 0x005B8B73 File Offset: 0x005B6D73
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06029AF6 RID: 170742 RVA: 0x005B8B7E File Offset: 0x005B6D7E
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06029AF7 RID: 170743 RVA: 0x005B8B8E File Offset: 0x005B6D8E
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x06029AF8 RID: 170744 RVA: 0x005B8BA0 File Offset: 0x005B6DA0
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029AF9 RID: 170745 RVA: 0x005B8BD7 File Offset: 0x005B6DD7
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06029AFA RID: 170746 RVA: 0x005B8BF1 File Offset: 0x005B6DF1
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06029AFB RID: 170747 RVA: 0x005B8C0F File Offset: 0x005B6E0F
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029AFC RID: 170748 RVA: 0x005B8C28 File Offset: 0x005B6E28
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06029AFD RID: 170749 RVA: 0x005B8C33 File Offset: 0x005B6E33
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x06029AFE RID: 170750 RVA: 0x005B8C44 File Offset: 0x005B6E44
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029AFF RID: 170751 RVA: 0x005B8C7B File Offset: 0x005B6E7B
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029B00 RID: 170752 RVA: 0x005B8C95 File Offset: 0x005B6E95
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029B01 RID: 170753 RVA: 0x005B8CB3 File Offset: 0x005B6EB3
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029B02 RID: 170754 RVA: 0x005B8CCC File Offset: 0x005B6ECC
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029B03 RID: 170755 RVA: 0x005B8CD7 File Offset: 0x005B6ED7
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x06029B04 RID: 170756 RVA: 0x005B8CE2 File Offset: 0x005B6EE2
		public static void AddActionInfo(FlatBufferBuilder builder, Offset<ICommonBtActionInfo> actionInfoOffset)
		{
			builder.AddOffset(6, actionInfoOffset.Value, 0);
		}

		// Token: 0x06029B05 RID: 170757 RVA: 0x005B8CF2 File Offset: 0x005B6EF2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06029B06 RID: 170758 RVA: 0x005B8CFD File Offset: 0x005B6EFD
		public static Offset<ICommonBtTask> EndICommonBtTask(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtTask>(builder.EndTable());
		}

		// Token: 0x06029B07 RID: 170759 RVA: 0x005B8D0C File Offset: 0x005B6F0C
		public ICommonBtTaskT UnPack()
		{
			ICommonBtTaskT commonBtTaskT = new ICommonBtTaskT();
			this.UnPackTo(commonBtTaskT);
			return commonBtTaskT;
		}

		// Token: 0x06029B08 RID: 170760 RVA: 0x005B8D28 File Offset: 0x005B6F28
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

		// Token: 0x06029B09 RID: 170761 RVA: 0x005B8F20 File Offset: 0x005B7120
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

		// Token: 0x0400F965 RID: 63845
		private Table __p;
	}
}
