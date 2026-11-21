using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056EB RID: 22251
	public struct IEntityGroupFailureSequentialState : IFlatbufferObject
	{
		// Token: 0x1700A065 RID: 41061
		// (get) Token: 0x06023B3D RID: 146237 RVA: 0x004E8998 File Offset: 0x004E6B98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023B3E RID: 146238 RVA: 0x004E89A5 File Offset: 0x004E6BA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023B3F RID: 146239 RVA: 0x004E89AC File Offset: 0x004E6BAC
		public static IEntityGroupFailureSequentialState GetRootAsIEntityGroupFailureSequentialState(ByteBuffer _bb)
		{
			return IEntityGroupFailureSequentialState.GetRootAsIEntityGroupFailureSequentialState(_bb, default(IEntityGroupFailureSequentialState));
		}

		// Token: 0x06023B40 RID: 146240 RVA: 0x004E89C8 File Offset: 0x004E6BC8
		public static IEntityGroupFailureSequentialState GetRootAsIEntityGroupFailureSequentialState(ByteBuffer _bb, IEntityGroupFailureSequentialState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023B41 RID: 146241 RVA: 0x004E89E5 File Offset: 0x004E6BE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023B42 RID: 146242 RVA: 0x004E89F4 File Offset: 0x004E6BF4
		public IEntityGroupFailureSequentialState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A066 RID: 41062
		// (get) Token: 0x06023B43 RID: 146243 RVA: 0x004E8A04 File Offset: 0x004E6C04
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

		// Token: 0x06023B44 RID: 146244 RVA: 0x004E8A40 File Offset: 0x004E6C40
		public IEntityStateCondition? Order(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateCondition?(default(IEntityStateCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A067 RID: 41063
		// (get) Token: 0x06023B45 RID: 146245 RVA: 0x004E8AA0 File Offset: 0x004E6CA0
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

		// Token: 0x1700A068 RID: 41064
		// (get) Token: 0x06023B46 RID: 146246 RVA: 0x004E8ACC File Offset: 0x004E6CCC
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

		// Token: 0x06023B47 RID: 146247 RVA: 0x004E8B08 File Offset: 0x004E6D08
		public static Offset<IEntityGroupFailureSequentialState> CreateIEntityGroupFailureSequentialState(FlatBufferBuilder builder, EEntityGroupFailureCondition Type = EEntityGroupFailureCondition.SequentialState, VectorOffset OrderOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IEntityGroupFailureSequentialState.AddOrder(builder, OrderOffset);
			IEntityGroupFailureSequentialState.AddNullMask(builder, NullMask);
			IEntityGroupFailureSequentialState.AddType(builder, Type);
			return IEntityGroupFailureSequentialState.EndIEntityGroupFailureSequentialState(builder);
		}

		// Token: 0x06023B48 RID: 146248 RVA: 0x004E8B2C File Offset: 0x004E6D2C
		public static void StartIEntityGroupFailureSequentialState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023B49 RID: 146249 RVA: 0x004E8B35 File Offset: 0x004E6D35
		public static void AddType(FlatBufferBuilder builder, EEntityGroupFailureCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023B4A RID: 146250 RVA: 0x004E8B40 File Offset: 0x004E6D40
		public static void AddOrder(FlatBufferBuilder builder, VectorOffset orderOffset)
		{
			builder.AddOffset(1, orderOffset.Value, 0);
		}

		// Token: 0x06023B4B RID: 146251 RVA: 0x004E8B50 File Offset: 0x004E6D50
		public static VectorOffset CreateOrderVector(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023B4C RID: 146252 RVA: 0x004E8B90 File Offset: 0x004E6D90
		public static VectorOffset CreateOrderVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023B4D RID: 146253 RVA: 0x004E8BAA File Offset: 0x004E6DAA
		public static VectorOffset CreateOrderVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023B4E RID: 146254 RVA: 0x004E8BC8 File Offset: 0x004E6DC8
		public static VectorOffset CreateOrderVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023B4F RID: 146255 RVA: 0x004E8BE1 File Offset: 0x004E6DE1
		public static void StartOrderVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023B50 RID: 146256 RVA: 0x004E8BEC File Offset: 0x004E6DEC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06023B51 RID: 146257 RVA: 0x004E8BF7 File Offset: 0x004E6DF7
		public static Offset<IEntityGroupFailureSequentialState> EndIEntityGroupFailureSequentialState(FlatBufferBuilder builder)
		{
			return new Offset<IEntityGroupFailureSequentialState>(builder.EndTable());
		}

		// Token: 0x06023B52 RID: 146258 RVA: 0x004E8C04 File Offset: 0x004E6E04
		public IEntityGroupFailureSequentialStateT UnPack()
		{
			IEntityGroupFailureSequentialStateT entityGroupFailureSequentialStateT = new IEntityGroupFailureSequentialStateT();
			this.UnPackTo(entityGroupFailureSequentialStateT);
			return entityGroupFailureSequentialStateT;
		}

		// Token: 0x06023B53 RID: 146259 RVA: 0x004E8C20 File Offset: 0x004E6E20
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

		// Token: 0x06023B54 RID: 146260 RVA: 0x004E8C98 File Offset: 0x004E6E98
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

		// Token: 0x0400EE56 RID: 61014
		private Table __p;
	}
}
