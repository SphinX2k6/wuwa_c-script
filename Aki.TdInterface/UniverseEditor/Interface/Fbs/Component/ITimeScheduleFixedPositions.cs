using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060A9 RID: 24745
	public struct ITimeScheduleFixedPositions : IFlatbufferObject
	{
		// Token: 0x1700B7FC RID: 47100
		// (get) Token: 0x06029DE6 RID: 171494 RVA: 0x005B7396 File Offset: 0x005B5596
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029DE7 RID: 171495 RVA: 0x005B73A3 File Offset: 0x005B55A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029DE8 RID: 171496 RVA: 0x005B73AC File Offset: 0x005B55AC
		public static ITimeScheduleFixedPositions GetRootAsITimeScheduleFixedPositions(ByteBuffer _bb)
		{
			return ITimeScheduleFixedPositions.GetRootAsITimeScheduleFixedPositions(_bb, default(ITimeScheduleFixedPositions));
		}

		// Token: 0x06029DE9 RID: 171497 RVA: 0x005B73C8 File Offset: 0x005B55C8
		public static ITimeScheduleFixedPositions GetRootAsITimeScheduleFixedPositions(ByteBuffer _bb, ITimeScheduleFixedPositions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029DEA RID: 171498 RVA: 0x005B73E5 File Offset: 0x005B55E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029DEB RID: 171499 RVA: 0x005B73F4 File Offset: 0x005B55F4
		public ITimeScheduleFixedPositions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7FD RID: 47101
		// (get) Token: 0x06029DEC RID: 171500 RVA: 0x005B7404 File Offset: 0x005B5604
		public ETimeScheduleRefreshPositionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeScheduleRefreshPositionType.FixedPositions;
				}
				return (ETimeScheduleRefreshPositionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029DED RID: 171501 RVA: 0x005B7440 File Offset: 0x005B5640
		public IPosA? Positions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPosA?(default(IPosA).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B7FE RID: 47102
		// (get) Token: 0x06029DEE RID: 171502 RVA: 0x005B74A0 File Offset: 0x005B56A0
		public int PositionsLength
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

		// Token: 0x06029DEF RID: 171503 RVA: 0x005B74CB File Offset: 0x005B56CB
		public static Offset<ITimeScheduleFixedPositions> CreateITimeScheduleFixedPositions(FlatBufferBuilder builder, ETimeScheduleRefreshPositionType Type = ETimeScheduleRefreshPositionType.FixedPositions, VectorOffset PositionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ITimeScheduleFixedPositions.AddPositions(builder, PositionsOffset);
			ITimeScheduleFixedPositions.AddType(builder, Type);
			return ITimeScheduleFixedPositions.EndITimeScheduleFixedPositions(builder);
		}

		// Token: 0x06029DF0 RID: 171504 RVA: 0x005B74E8 File Offset: 0x005B56E8
		public static void StartITimeScheduleFixedPositions(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029DF1 RID: 171505 RVA: 0x005B74F1 File Offset: 0x005B56F1
		public static void AddType(FlatBufferBuilder builder, ETimeScheduleRefreshPositionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029DF2 RID: 171506 RVA: 0x005B74FC File Offset: 0x005B56FC
		public static void AddPositions(FlatBufferBuilder builder, VectorOffset positionsOffset)
		{
			builder.AddOffset(1, positionsOffset.Value, 0);
		}

		// Token: 0x06029DF3 RID: 171507 RVA: 0x005B750C File Offset: 0x005B570C
		public static VectorOffset CreatePositionsVector(FlatBufferBuilder builder, Offset<IPosA>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029DF4 RID: 171508 RVA: 0x005B754C File Offset: 0x005B574C
		public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, Offset<IPosA>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPosA>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029DF5 RID: 171509 RVA: 0x005B7566 File Offset: 0x005B5766
		public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPosA>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPosA>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029DF6 RID: 171510 RVA: 0x005B7584 File Offset: 0x005B5784
		public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPosA>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029DF7 RID: 171511 RVA: 0x005B759D File Offset: 0x005B579D
		public static void StartPositionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029DF8 RID: 171512 RVA: 0x005B75A8 File Offset: 0x005B57A8
		public static Offset<ITimeScheduleFixedPositions> EndITimeScheduleFixedPositions(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleFixedPositions>(builder.EndTable());
		}

		// Token: 0x06029DF9 RID: 171513 RVA: 0x005B75B8 File Offset: 0x005B57B8
		public ITimeScheduleFixedPositionsT UnPack()
		{
			ITimeScheduleFixedPositionsT timeScheduleFixedPositionsT = new ITimeScheduleFixedPositionsT();
			this.UnPackTo(timeScheduleFixedPositionsT);
			return timeScheduleFixedPositionsT;
		}

		// Token: 0x06029DFA RID: 171514 RVA: 0x005B75D4 File Offset: 0x005B57D4
		public void UnPackTo(ITimeScheduleFixedPositionsT _o)
		{
			_o.Type = this.Type;
			_o.Positions = new List<IPosAT>();
			for (int i = 0; i < this.PositionsLength; i++)
			{
				_o.Positions.Add((this.Positions(i) != null) ? this.Positions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029DFB RID: 171515 RVA: 0x005B7640 File Offset: 0x005B5840
		public static Offset<ITimeScheduleFixedPositions> Pack(FlatBufferBuilder builder, ITimeScheduleFixedPositionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleFixedPositions>);
			}
			VectorOffset positionsOffset = default(VectorOffset);
			if (_o.Positions != null)
			{
				Offset<IPosA>[] array = new Offset<IPosA>[_o.Positions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPosA.Pack(builder, _o.Positions[i]);
				}
				positionsOffset = ITimeScheduleFixedPositions.CreatePositionsVector(builder, array);
			}
			return ITimeScheduleFixedPositions.CreateITimeScheduleFixedPositions(builder, _o.Type, positionsOffset);
		}

		// Token: 0x0400FE54 RID: 65108
		private Table __p;
	}
}
