using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005186 RID: 20870
	public struct IEntityGroupFailureSequentialState : IFlatbufferObject
	{
		// Token: 0x17009876 RID: 39030
		// (get) Token: 0x06021BE5 RID: 138213 RVA: 0x004AE978 File Offset: 0x004ACB78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021BE6 RID: 138214 RVA: 0x004AE985 File Offset: 0x004ACB85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021BE7 RID: 138215 RVA: 0x004AE98C File Offset: 0x004ACB8C
		public static IEntityGroupFailureSequentialState GetRootAsIEntityGroupFailureSequentialState(ByteBuffer _bb)
		{
			return IEntityGroupFailureSequentialState.GetRootAsIEntityGroupFailureSequentialState(_bb, default(IEntityGroupFailureSequentialState));
		}

		// Token: 0x06021BE8 RID: 138216 RVA: 0x004AE9A8 File Offset: 0x004ACBA8
		public static IEntityGroupFailureSequentialState GetRootAsIEntityGroupFailureSequentialState(ByteBuffer _bb, IEntityGroupFailureSequentialState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021BE9 RID: 138217 RVA: 0x004AE9C5 File Offset: 0x004ACBC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021BEA RID: 138218 RVA: 0x004AE9D4 File Offset: 0x004ACBD4
		public IEntityGroupFailureSequentialState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009877 RID: 39031
		// (get) Token: 0x06021BEB RID: 138219 RVA: 0x004AE9E4 File Offset: 0x004ACBE4
		public EEntityGroupFailureCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityGroupFailureCondition.SequentialState;
				}
				return (EEntityGroupFailureCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021BEC RID: 138220 RVA: 0x004AEA20 File Offset: 0x004ACC20
		public IEntityStateCondition? Order(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateCondition?(default(IEntityStateCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009878 RID: 39032
		// (get) Token: 0x06021BED RID: 138221 RVA: 0x004AEA80 File Offset: 0x004ACC80
		public int OrderLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009879 RID: 39033
		// (get) Token: 0x06021BEE RID: 138222 RVA: 0x004AEAAC File Offset: 0x004ACCAC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021BEF RID: 138223 RVA: 0x004AEAE8 File Offset: 0x004ACCE8
		public static Offset<IEntityGroupFailureSequentialState> CreateIEntityGroupFailureSequentialState(FlatBufferBuilder builder, EEntityGroupFailureCondition Type = EEntityGroupFailureCondition.SequentialState, VectorOffset OrderOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IEntityGroupFailureSequentialState.AddOrder(builder, OrderOffset);
			IEntityGroupFailureSequentialState.AddNullMask(builder, NullMask);
			IEntityGroupFailureSequentialState.AddType(builder, Type);
			return IEntityGroupFailureSequentialState.EndIEntityGroupFailureSequentialState(builder);
		}

		// Token: 0x06021BF0 RID: 138224 RVA: 0x004AEB0C File Offset: 0x004ACD0C
		public static void StartIEntityGroupFailureSequentialState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021BF1 RID: 138225 RVA: 0x004AEB15 File Offset: 0x004ACD15
		public static void AddType(FlatBufferBuilder builder, EEntityGroupFailureCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021BF2 RID: 138226 RVA: 0x004AEB20 File Offset: 0x004ACD20
		public static void AddOrder(FlatBufferBuilder builder, VectorOffset orderOffset)
		{
			builder.AddOffset(1, orderOffset.Value, 0);
		}

		// Token: 0x06021BF3 RID: 138227 RVA: 0x004AEB30 File Offset: 0x004ACD30
		public static VectorOffset CreateOrderVector(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021BF4 RID: 138228 RVA: 0x004AEB70 File Offset: 0x004ACD70
		public static VectorOffset CreateOrderVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021BF5 RID: 138229 RVA: 0x004AEB8A File Offset: 0x004ACD8A
		public static VectorOffset CreateOrderVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021BF6 RID: 138230 RVA: 0x004AEBA8 File Offset: 0x004ACDA8
		public static VectorOffset CreateOrderVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021BF7 RID: 138231 RVA: 0x004AEBC1 File Offset: 0x004ACDC1
		public static void StartOrderVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021BF8 RID: 138232 RVA: 0x004AEBCC File Offset: 0x004ACDCC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06021BF9 RID: 138233 RVA: 0x004AEBD7 File Offset: 0x004ACDD7
		public static Offset<IEntityGroupFailureSequentialState> EndIEntityGroupFailureSequentialState(FlatBufferBuilder builder)
		{
			return new Offset<IEntityGroupFailureSequentialState>(builder.EndTable());
		}

		// Token: 0x06021BFA RID: 138234 RVA: 0x004AEBE4 File Offset: 0x004ACDE4
		public IEntityGroupFailureSequentialStateT UnPack()
		{
			IEntityGroupFailureSequentialStateT entityGroupFailureSequentialStateT = new IEntityGroupFailureSequentialStateT();
			this.UnPackTo(entityGroupFailureSequentialStateT);
			return entityGroupFailureSequentialStateT;
		}

		// Token: 0x06021BFB RID: 138235 RVA: 0x004AEC00 File Offset: 0x004ACE00
		public void UnPackTo(IEntityGroupFailureSequentialStateT _o)
		{
			_o.Type = this.Type;
			_o.Order = new List<IEntityStateConditionT>();
			for (int i = 0; i < this.OrderLength; i++)
			{
				_o.Order.Add((this.Order(i) != null) ? this.Order(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021BFC RID: 138236 RVA: 0x004AEC78 File Offset: 0x004ACE78
		public static Offset<IEntityGroupFailureSequentialState> Pack(FlatBufferBuilder builder, IEntityGroupFailureSequentialStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityGroupFailureSequentialState>);
			}
			VectorOffset orderOffset = default(VectorOffset);
			if (_o.Order != null)
			{
				Offset<IEntityStateCondition>[] array = new Offset<IEntityStateCondition>[_o.Order.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityStateCondition.Pack(builder, _o.Order[i]);
				}
				orderOffset = IEntityGroupFailureSequentialState.CreateOrderVector(builder, array);
			}
			return IEntityGroupFailureSequentialState.CreateIEntityGroupFailureSequentialState(builder, _o.Type, orderOffset, _o.NullMask);
		}

		// Token: 0x0400E258 RID: 57944
		private Table __p;
	}
}
