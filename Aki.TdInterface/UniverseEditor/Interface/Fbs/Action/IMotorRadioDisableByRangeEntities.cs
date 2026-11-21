using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007264 RID: 29284
	public struct IMotorRadioDisableByRangeEntities : IFlatbufferObject
	{
		// Token: 0x1700D6BA RID: 54970
		// (get) Token: 0x0603306E RID: 209006 RVA: 0x006E34FF File Offset: 0x006E16FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603306F RID: 209007 RVA: 0x006E350C File Offset: 0x006E170C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033070 RID: 209008 RVA: 0x006E3514 File Offset: 0x006E1714
		public static IMotorRadioDisableByRangeEntities GetRootAsIMotorRadioDisableByRangeEntities(ByteBuffer _bb)
		{
			return IMotorRadioDisableByRangeEntities.GetRootAsIMotorRadioDisableByRangeEntities(_bb, default(IMotorRadioDisableByRangeEntities));
		}

		// Token: 0x06033071 RID: 209009 RVA: 0x006E3530 File Offset: 0x006E1730
		public static IMotorRadioDisableByRangeEntities GetRootAsIMotorRadioDisableByRangeEntities(ByteBuffer _bb, IMotorRadioDisableByRangeEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033072 RID: 209010 RVA: 0x006E354D File Offset: 0x006E174D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033073 RID: 209011 RVA: 0x006E355C File Offset: 0x006E175C
		public IMotorRadioDisableByRangeEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6BB RID: 54971
		// (get) Token: 0x06033074 RID: 209012 RVA: 0x006E356C File Offset: 0x006E176C
		public EMotorRadioDisableRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorRadioDisableRangeType.ByAreaId;
				}
				return (EMotorRadioDisableRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033075 RID: 209013 RVA: 0x006E35A8 File Offset: 0x006E17A8
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D6BC RID: 54972
		// (get) Token: 0x06033076 RID: 209014 RVA: 0x006E35E8 File Offset: 0x006E17E8
		public int RangeEntitiesLength
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

		// Token: 0x06033077 RID: 209015 RVA: 0x006E3613 File Offset: 0x006E1813
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06033078 RID: 209016 RVA: 0x006E3622 File Offset: 0x006E1822
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06033079 RID: 209017 RVA: 0x006E3630 File Offset: 0x006E1830
		public static Offset<IMotorRadioDisableByRangeEntities> CreateIMotorRadioDisableByRangeEntities(FlatBufferBuilder builder, EMotorRadioDisableRangeType Type = EMotorRadioDisableRangeType.ByAreaId, VectorOffset RangeEntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IMotorRadioDisableByRangeEntities.AddRangeEntities(builder, RangeEntitiesOffset);
			IMotorRadioDisableByRangeEntities.AddType(builder, Type);
			return IMotorRadioDisableByRangeEntities.EndIMotorRadioDisableByRangeEntities(builder);
		}

		// Token: 0x0603307A RID: 209018 RVA: 0x006E364D File Offset: 0x006E184D
		public static void StartIMotorRadioDisableByRangeEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603307B RID: 209019 RVA: 0x006E3656 File Offset: 0x006E1856
		public static void AddType(FlatBufferBuilder builder, EMotorRadioDisableRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603307C RID: 209020 RVA: 0x006E3661 File Offset: 0x006E1861
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(1, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0603307D RID: 209021 RVA: 0x006E3674 File Offset: 0x006E1874
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603307E RID: 209022 RVA: 0x006E36AB File Offset: 0x006E18AB
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603307F RID: 209023 RVA: 0x006E36C5 File Offset: 0x006E18C5
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033080 RID: 209024 RVA: 0x006E36E3 File Offset: 0x006E18E3
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033081 RID: 209025 RVA: 0x006E36FC File Offset: 0x006E18FC
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033082 RID: 209026 RVA: 0x006E3707 File Offset: 0x006E1907
		public static Offset<IMotorRadioDisableByRangeEntities> EndIMotorRadioDisableByRangeEntities(FlatBufferBuilder builder)
		{
			return new Offset<IMotorRadioDisableByRangeEntities>(builder.EndTable());
		}

		// Token: 0x06033083 RID: 209027 RVA: 0x006E3714 File Offset: 0x006E1914
		public IMotorRadioDisableByRangeEntitiesT UnPack()
		{
			IMotorRadioDisableByRangeEntitiesT motorRadioDisableByRangeEntitiesT = new IMotorRadioDisableByRangeEntitiesT();
			this.UnPackTo(motorRadioDisableByRangeEntitiesT);
			return motorRadioDisableByRangeEntitiesT;
		}

		// Token: 0x06033084 RID: 209028 RVA: 0x006E3730 File Offset: 0x006E1930
		public void UnPackTo(IMotorRadioDisableByRangeEntitiesT _o)
		{
			_o.Type = this.Type;
			_o.RangeEntities = new List<int>();
			for (int i = 0; i < this.RangeEntitiesLength; i++)
			{
				_o.RangeEntities.Add(this.RangeEntities(i));
			}
		}

		// Token: 0x06033085 RID: 209029 RVA: 0x006E3778 File Offset: 0x006E1978
		public static Offset<IMotorRadioDisableByRangeEntities> Pack(FlatBufferBuilder builder, IMotorRadioDisableByRangeEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorRadioDisableByRangeEntities>);
			}
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = IMotorRadioDisableByRangeEntities.CreateRangeEntitiesVector(builder, data);
			}
			return IMotorRadioDisableByRangeEntities.CreateIMotorRadioDisableByRangeEntities(builder, _o.Type, rangeEntitiesOffset);
		}

		// Token: 0x040122D7 RID: 74455
		private Table __p;
	}
}
