using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C16 RID: 19478
	public struct IEntityGroupCondition : IFlatbufferObject
	{
		// Token: 0x17008D7D RID: 36221
		// (get) Token: 0x0601EDA1 RID: 126369 RVA: 0x00451B60 File Offset: 0x0044FD60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EDA2 RID: 126370 RVA: 0x00451B6D File Offset: 0x0044FD6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EDA3 RID: 126371 RVA: 0x00451B74 File Offset: 0x0044FD74
		public static IEntityGroupCondition GetRootAsIEntityGroupCondition(ByteBuffer _bb)
		{
			return IEntityGroupCondition.GetRootAsIEntityGroupCondition(_bb, default(IEntityGroupCondition));
		}

		// Token: 0x0601EDA4 RID: 126372 RVA: 0x00451B90 File Offset: 0x0044FD90
		public static IEntityGroupCondition GetRootAsIEntityGroupCondition(ByteBuffer _bb, IEntityGroupCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EDA5 RID: 126373 RVA: 0x00451BAD File Offset: 0x0044FDAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EDA6 RID: 126374 RVA: 0x00451BBC File Offset: 0x0044FDBC
		public IEntityGroupCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D7E RID: 36222
		// (get) Token: 0x0601EDA7 RID: 126375 RVA: 0x00451BCC File Offset: 0x0044FDCC
		public int Count
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D7F RID: 36223
		// (get) Token: 0x0601EDA8 RID: 126376 RVA: 0x00451C08 File Offset: 0x0044FE08
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EDA9 RID: 126377 RVA: 0x00451C44 File Offset: 0x0044FE44
		public IEntityEventCondition? Conditions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IEntityEventCondition?(default(IEntityEventCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008D80 RID: 36224
		// (get) Token: 0x0601EDAA RID: 126378 RVA: 0x00451CA4 File Offset: 0x0044FEA4
		public int ConditionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17008D81 RID: 36225
		// (get) Token: 0x0601EDAB RID: 126379 RVA: 0x00451CD0 File Offset: 0x0044FED0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EDAC RID: 126380 RVA: 0x00451D0D File Offset: 0x0044FF0D
		public static Offset<IEntityGroupCondition> CreateIEntityGroupCondition(FlatBufferBuilder builder, int Count = 0, ECompare Compare = ECompare.Eq, VectorOffset ConditionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityGroupCondition.AddConditions(builder, ConditionsOffset);
			IEntityGroupCondition.AddCount(builder, Count);
			IEntityGroupCondition.AddNullMask(builder, NullMask);
			IEntityGroupCondition.AddCompare(builder, Compare);
			return IEntityGroupCondition.EndIEntityGroupCondition(builder);
		}

		// Token: 0x0601EDAD RID: 126381 RVA: 0x00451D39 File Offset: 0x0044FF39
		public static void StartIEntityGroupCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601EDAE RID: 126382 RVA: 0x00451D42 File Offset: 0x0044FF42
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(0, count, 0);
		}

		// Token: 0x0601EDAF RID: 126383 RVA: 0x00451D4D File Offset: 0x0044FF4D
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601EDB0 RID: 126384 RVA: 0x00451D58 File Offset: 0x0044FF58
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x0601EDB1 RID: 126385 RVA: 0x00451D68 File Offset: 0x0044FF68
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<IEntityEventCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EDB2 RID: 126386 RVA: 0x00451DA8 File Offset: 0x0044FFA8
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityEventCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityEventCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EDB3 RID: 126387 RVA: 0x00451DC2 File Offset: 0x0044FFC2
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityEventCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityEventCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EDB4 RID: 126388 RVA: 0x00451DE0 File Offset: 0x0044FFE0
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityEventCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EDB5 RID: 126389 RVA: 0x00451DF9 File Offset: 0x0044FFF9
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EDB6 RID: 126390 RVA: 0x00451E04 File Offset: 0x00450004
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601EDB7 RID: 126391 RVA: 0x00451E0F File Offset: 0x0045000F
		public static Offset<IEntityGroupCondition> EndIEntityGroupCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEntityGroupCondition>(builder.EndTable());
		}

		// Token: 0x0601EDB8 RID: 126392 RVA: 0x00451E1C File Offset: 0x0045001C
		public IEntityGroupConditionT UnPack()
		{
			IEntityGroupConditionT entityGroupConditionT = new IEntityGroupConditionT();
			this.UnPackTo(entityGroupConditionT);
			return entityGroupConditionT;
		}

		// Token: 0x0601EDB9 RID: 126393 RVA: 0x00451E38 File Offset: 0x00450038
		public void UnPackTo(IEntityGroupConditionT _o)
		{
			_o.Count = this.Count;
			_o.Compare = this.Compare;
			_o.Conditions = new List<IEntityEventConditionT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601EDBA RID: 126394 RVA: 0x00451EBC File Offset: 0x004500BC
		public static Offset<IEntityGroupCondition> Pack(FlatBufferBuilder builder, IEntityGroupConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityGroupCondition>);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<IEntityEventCondition>[] array = new Offset<IEntityEventCondition>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityEventCondition.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = IEntityGroupCondition.CreateConditionsVector(builder, array);
			}
			return IEntityGroupCondition.CreateIEntityGroupCondition(builder, _o.Count, _o.Compare, conditionsOffset, _o.NullMask);
		}

		// Token: 0x0400D5AD RID: 54701
		private Table __p;
	}
}
