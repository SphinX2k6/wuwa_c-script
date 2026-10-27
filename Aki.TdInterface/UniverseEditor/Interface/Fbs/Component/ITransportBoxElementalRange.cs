using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD8 RID: 23256
	public struct ITransportBoxElementalRange : IFlatbufferObject
	{
		// Token: 0x1700AF45 RID: 44869
		// (get) Token: 0x06027A9A RID: 162458 RVA: 0x00574B31 File Offset: 0x00572D31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027A9B RID: 162459 RVA: 0x00574B3E File Offset: 0x00572D3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027A9C RID: 162460 RVA: 0x00574B48 File Offset: 0x00572D48
		public static ITransportBoxElementalRange GetRootAsITransportBoxElementalRange(ByteBuffer _bb)
		{
			return ITransportBoxElementalRange.GetRootAsITransportBoxElementalRange(_bb, default(ITransportBoxElementalRange));
		}

		// Token: 0x06027A9D RID: 162461 RVA: 0x00574B64 File Offset: 0x00572D64
		public static ITransportBoxElementalRange GetRootAsITransportBoxElementalRange(ByteBuffer _bb, ITransportBoxElementalRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027A9E RID: 162462 RVA: 0x00574B81 File Offset: 0x00572D81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027A9F RID: 162463 RVA: 0x00574B90 File Offset: 0x00572D90
		public ITransportBoxElementalRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF46 RID: 44870
		// (get) Token: 0x06027AA0 RID: 162464 RVA: 0x00574BA0 File Offset: 0x00572DA0
		public EElementalRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalRangeType.BaseShape;
				}
				return (EElementalRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027AA1 RID: 162465 RVA: 0x00574BDC File Offset: 0x00572DDC
		public static Offset<ITransportBoxElementalRange> CreateITransportBoxElementalRange(FlatBufferBuilder builder, EElementalRangeType Type = EElementalRangeType.BaseShape)
		{
			builder.StartTable(1);
			ITransportBoxElementalRange.AddType(builder, Type);
			return ITransportBoxElementalRange.EndITransportBoxElementalRange(builder);
		}

		// Token: 0x06027AA2 RID: 162466 RVA: 0x00574BF2 File Offset: 0x00572DF2
		public static void StartITransportBoxElementalRange(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027AA3 RID: 162467 RVA: 0x00574BFB File Offset: 0x00572DFB
		public static void AddType(FlatBufferBuilder builder, EElementalRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027AA4 RID: 162468 RVA: 0x00574C06 File Offset: 0x00572E06
		public static Offset<ITransportBoxElementalRange> EndITransportBoxElementalRange(FlatBufferBuilder builder)
		{
			return new Offset<ITransportBoxElementalRange>(builder.EndTable());
		}

		// Token: 0x06027AA5 RID: 162469 RVA: 0x00574C14 File Offset: 0x00572E14
		public ITransportBoxElementalRangeT UnPack()
		{
			ITransportBoxElementalRangeT transportBoxElementalRangeT = new ITransportBoxElementalRangeT();
			this.UnPackTo(transportBoxElementalRangeT);
			return transportBoxElementalRangeT;
		}

		// Token: 0x06027AA6 RID: 162470 RVA: 0x00574C2F File Offset: 0x00572E2F
		public void UnPackTo(ITransportBoxElementalRangeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027AA7 RID: 162471 RVA: 0x00574C40 File Offset: 0x00572E40
		public static Offset<ITransportBoxElementalRange> Pack(FlatBufferBuilder builder, ITransportBoxElementalRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITransportBoxElementalRange>);
			}
			return ITransportBoxElementalRange.CreateITransportBoxElementalRange(builder, _o.Type);
		}

		// Token: 0x0400F1B9 RID: 61881
		private Table __p;
	}
}
