using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060E5 RID: 24805
	public struct ITransportBoxElementalRange : IFlatbufferObject
	{
		// Token: 0x1700B881 RID: 47233
		// (get) Token: 0x0602A026 RID: 172070 RVA: 0x005BBFAD File Offset: 0x005BA1AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A027 RID: 172071 RVA: 0x005BBFBA File Offset: 0x005BA1BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A028 RID: 172072 RVA: 0x005BBFC4 File Offset: 0x005BA1C4
		public static ITransportBoxElementalRange GetRootAsITransportBoxElementalRange(ByteBuffer _bb)
		{
			return ITransportBoxElementalRange.GetRootAsITransportBoxElementalRange(_bb, default(ITransportBoxElementalRange));
		}

		// Token: 0x0602A029 RID: 172073 RVA: 0x005BBFE0 File Offset: 0x005BA1E0
		public static ITransportBoxElementalRange GetRootAsITransportBoxElementalRange(ByteBuffer _bb, ITransportBoxElementalRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A02A RID: 172074 RVA: 0x005BBFFD File Offset: 0x005BA1FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A02B RID: 172075 RVA: 0x005BC00C File Offset: 0x005BA20C
		public ITransportBoxElementalRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B882 RID: 47234
		// (get) Token: 0x0602A02C RID: 172076 RVA: 0x005BC01C File Offset: 0x005BA21C
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

		// Token: 0x0602A02D RID: 172077 RVA: 0x005BC058 File Offset: 0x005BA258
		public static Offset<ITransportBoxElementalRange> CreateITransportBoxElementalRange(FlatBufferBuilder builder, EElementalRangeType Type = EElementalRangeType.BaseShape)
		{
			builder.StartTable(1);
			ITransportBoxElementalRange.AddType(builder, Type);
			return ITransportBoxElementalRange.EndITransportBoxElementalRange(builder);
		}

		// Token: 0x0602A02E RID: 172078 RVA: 0x005BC06E File Offset: 0x005BA26E
		public static void StartITransportBoxElementalRange(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A02F RID: 172079 RVA: 0x005BC077 File Offset: 0x005BA277
		public static void AddType(FlatBufferBuilder builder, EElementalRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A030 RID: 172080 RVA: 0x005BC082 File Offset: 0x005BA282
		public static Offset<ITransportBoxElementalRange> EndITransportBoxElementalRange(FlatBufferBuilder builder)
		{
			return new Offset<ITransportBoxElementalRange>(builder.EndTable());
		}

		// Token: 0x0602A031 RID: 172081 RVA: 0x005BC090 File Offset: 0x005BA290
		public ITransportBoxElementalRangeT UnPack()
		{
			ITransportBoxElementalRangeT transportBoxElementalRangeT = new ITransportBoxElementalRangeT();
			this.UnPackTo(transportBoxElementalRangeT);
			return transportBoxElementalRangeT;
		}

		// Token: 0x0602A032 RID: 172082 RVA: 0x005BC0AB File Offset: 0x005BA2AB
		public void UnPackTo(ITransportBoxElementalRangeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A033 RID: 172083 RVA: 0x005BC0BC File Offset: 0x005BA2BC
		public static Offset<ITransportBoxElementalRange> Pack(FlatBufferBuilder builder, ITransportBoxElementalRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITransportBoxElementalRange>);
			}
			return ITransportBoxElementalRange.CreateITransportBoxElementalRange(builder, _o.Type);
		}

		// Token: 0x0400FEB3 RID: 65203
		private Table __p;
	}
}
