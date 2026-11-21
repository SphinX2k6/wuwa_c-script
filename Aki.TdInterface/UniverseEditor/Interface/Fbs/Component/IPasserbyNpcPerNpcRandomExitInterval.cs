using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA5 RID: 23717
	public struct IPasserbyNpcPerNpcRandomExitInterval : IFlatbufferObject
	{
		// Token: 0x1700AE34 RID: 44596
		// (get) Token: 0x0602757F RID: 161151 RVA: 0x00562C40 File Offset: 0x00560E40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027580 RID: 161152 RVA: 0x00562C4D File Offset: 0x00560E4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027581 RID: 161153 RVA: 0x00562C54 File Offset: 0x00560E54
		public static IPasserbyNpcPerNpcRandomExitInterval GetRootAsIPasserbyNpcPerNpcRandomExitInterval(ByteBuffer _bb)
		{
			return IPasserbyNpcPerNpcRandomExitInterval.GetRootAsIPasserbyNpcPerNpcRandomExitInterval(_bb, default(IPasserbyNpcPerNpcRandomExitInterval));
		}

		// Token: 0x06027582 RID: 161154 RVA: 0x00562C70 File Offset: 0x00560E70
		public static IPasserbyNpcPerNpcRandomExitInterval GetRootAsIPasserbyNpcPerNpcRandomExitInterval(ByteBuffer _bb, IPasserbyNpcPerNpcRandomExitInterval obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027583 RID: 161155 RVA: 0x00562C8D File Offset: 0x00560E8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027584 RID: 161156 RVA: 0x00562C9C File Offset: 0x00560E9C
		public IPasserbyNpcPerNpcRandomExitInterval __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE35 RID: 44597
		// (get) Token: 0x06027585 RID: 161157 RVA: 0x00562CAC File Offset: 0x00560EAC
		public EPasserbyNpcExitIntervalType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcExitIntervalType.PerNpcRandom;
				}
				return (EPasserbyNpcExitIntervalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE36 RID: 44598
		// (get) Token: 0x06027586 RID: 161158 RVA: 0x00562CE8 File Offset: 0x00560EE8
		public IPasserbyNpcNearSplineStartFirstExitOrder? MoveOrder
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcNearSplineStartFirstExitOrder?(default(IPasserbyNpcNearSplineStartFirstExitOrder).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AE37 RID: 44599
		// (get) Token: 0x06027587 RID: 161159 RVA: 0x00562D48 File Offset: 0x00560F48
		public float MaxInterval
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE38 RID: 44600
		// (get) Token: 0x06027588 RID: 161160 RVA: 0x00562D88 File Offset: 0x00560F88
		public float MinInterval
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027589 RID: 161161 RVA: 0x00562DC9 File Offset: 0x00560FC9
		public static Offset<IPasserbyNpcPerNpcRandomExitInterval> CreateIPasserbyNpcPerNpcRandomExitInterval(FlatBufferBuilder builder, EPasserbyNpcExitIntervalType Type = EPasserbyNpcExitIntervalType.PerNpcRandom, Offset<IPasserbyNpcNearSplineStartFirstExitOrder> MoveOrderOffset = default(Offset<IPasserbyNpcNearSplineStartFirstExitOrder>), float MaxInterval = 0f, float MinInterval = 0f)
		{
			builder.StartTable(4);
			IPasserbyNpcPerNpcRandomExitInterval.AddMinInterval(builder, MinInterval);
			IPasserbyNpcPerNpcRandomExitInterval.AddMaxInterval(builder, MaxInterval);
			IPasserbyNpcPerNpcRandomExitInterval.AddMoveOrder(builder, MoveOrderOffset);
			IPasserbyNpcPerNpcRandomExitInterval.AddType(builder, Type);
			return IPasserbyNpcPerNpcRandomExitInterval.EndIPasserbyNpcPerNpcRandomExitInterval(builder);
		}

		// Token: 0x0602758A RID: 161162 RVA: 0x00562DF5 File Offset: 0x00560FF5
		public static void StartIPasserbyNpcPerNpcRandomExitInterval(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602758B RID: 161163 RVA: 0x00562DFE File Offset: 0x00560FFE
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcExitIntervalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602758C RID: 161164 RVA: 0x00562E09 File Offset: 0x00561009
		public static void AddMoveOrder(FlatBufferBuilder builder, Offset<IPasserbyNpcNearSplineStartFirstExitOrder> moveOrderOffset)
		{
			builder.AddOffset(1, moveOrderOffset.Value, 0);
		}

		// Token: 0x0602758D RID: 161165 RVA: 0x00562E19 File Offset: 0x00561019
		public static void AddMaxInterval(FlatBufferBuilder builder, float maxInterval)
		{
			builder.AddFloat(2, maxInterval, 0.0);
		}

		// Token: 0x0602758E RID: 161166 RVA: 0x00562E2C File Offset: 0x0056102C
		public static void AddMinInterval(FlatBufferBuilder builder, float minInterval)
		{
			builder.AddFloat(3, minInterval, 0.0);
		}

		// Token: 0x0602758F RID: 161167 RVA: 0x00562E3F File Offset: 0x0056103F
		public static Offset<IPasserbyNpcPerNpcRandomExitInterval> EndIPasserbyNpcPerNpcRandomExitInterval(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcPerNpcRandomExitInterval>(builder.EndTable());
		}

		// Token: 0x06027590 RID: 161168 RVA: 0x00562E4C File Offset: 0x0056104C
		public IPasserbyNpcPerNpcRandomExitIntervalT UnPack()
		{
			IPasserbyNpcPerNpcRandomExitIntervalT passerbyNpcPerNpcRandomExitIntervalT = new IPasserbyNpcPerNpcRandomExitIntervalT();
			this.UnPackTo(passerbyNpcPerNpcRandomExitIntervalT);
			return passerbyNpcPerNpcRandomExitIntervalT;
		}

		// Token: 0x06027591 RID: 161169 RVA: 0x00562E68 File Offset: 0x00561068
		public void UnPackTo(IPasserbyNpcPerNpcRandomExitIntervalT _o)
		{
			_o.Type = this.Type;
			_o.MoveOrder = ((this.MoveOrder != null) ? this.MoveOrder.Value.UnPack() : null);
			_o.MaxInterval = this.MaxInterval;
			_o.MinInterval = this.MinInterval;
		}

		// Token: 0x06027592 RID: 161170 RVA: 0x00562EC8 File Offset: 0x005610C8
		public static Offset<IPasserbyNpcPerNpcRandomExitInterval> Pack(FlatBufferBuilder builder, IPasserbyNpcPerNpcRandomExitIntervalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcPerNpcRandomExitInterval>);
			}
			Offset<IPasserbyNpcNearSplineStartFirstExitOrder> moveOrderOffset = (_o.MoveOrder == null) ? default(Offset<IPasserbyNpcNearSplineStartFirstExitOrder>) : IPasserbyNpcNearSplineStartFirstExitOrder.Pack(builder, _o.MoveOrder);
			return IPasserbyNpcPerNpcRandomExitInterval.CreateIPasserbyNpcPerNpcRandomExitInterval(builder, _o.Type, moveOrderOffset, _o.MaxInterval, _o.MinInterval);
		}

		// Token: 0x0400F7B7 RID: 63415
		private Table __p;
	}
}
