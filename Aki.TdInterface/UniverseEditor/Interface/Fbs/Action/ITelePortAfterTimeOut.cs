using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007373 RID: 29555
	public struct ITelePortAfterTimeOut : IFlatbufferObject
	{
		// Token: 0x1700E05E RID: 57438
		// (get) Token: 0x06035A34 RID: 219700 RVA: 0x0074DB7E File Offset: 0x0074BD7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035A35 RID: 219701 RVA: 0x0074DB8B File Offset: 0x0074BD8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035A36 RID: 219702 RVA: 0x0074DB94 File Offset: 0x0074BD94
		public static ITelePortAfterTimeOut GetRootAsITelePortAfterTimeOut(ByteBuffer _bb)
		{
			return ITelePortAfterTimeOut.GetRootAsITelePortAfterTimeOut(_bb, default(ITelePortAfterTimeOut));
		}

		// Token: 0x06035A37 RID: 219703 RVA: 0x0074DBB0 File Offset: 0x0074BDB0
		public static ITelePortAfterTimeOut GetRootAsITelePortAfterTimeOut(ByteBuffer _bb, ITelePortAfterTimeOut obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035A38 RID: 219704 RVA: 0x0074DBCD File Offset: 0x0074BDCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035A39 RID: 219705 RVA: 0x0074DBDC File Offset: 0x0074BDDC
		public ITelePortAfterTimeOut __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E05F RID: 57439
		// (get) Token: 0x06035A3A RID: 219706 RVA: 0x0074DBEC File Offset: 0x0074BDEC
		public ETeammateTeleportType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeammateTeleportType.TelePortAfterTimeOut;
				}
				return (ETeammateTeleportType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E060 RID: 57440
		// (get) Token: 0x06035A3B RID: 219707 RVA: 0x0074DC28 File Offset: 0x0074BE28
		public int TimeOut
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

		// Token: 0x06035A3C RID: 219708 RVA: 0x0074DC64 File Offset: 0x0074BE64
		public static Offset<ITelePortAfterTimeOut> CreateITelePortAfterTimeOut(FlatBufferBuilder builder, ETeammateTeleportType Type = ETeammateTeleportType.TelePortAfterTimeOut, int TimeOut = 0)
		{
			builder.StartTable(2);
			ITelePortAfterTimeOut.AddTimeOut(builder, TimeOut);
			ITelePortAfterTimeOut.AddType(builder, Type);
			return ITelePortAfterTimeOut.EndITelePortAfterTimeOut(builder);
		}

		// Token: 0x06035A3D RID: 219709 RVA: 0x0074DC81 File Offset: 0x0074BE81
		public static void StartITelePortAfterTimeOut(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035A3E RID: 219710 RVA: 0x0074DC8A File Offset: 0x0074BE8A
		public static void AddType(FlatBufferBuilder builder, ETeammateTeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035A3F RID: 219711 RVA: 0x0074DC95 File Offset: 0x0074BE95
		public static void AddTimeOut(FlatBufferBuilder builder, int timeOut)
		{
			builder.AddInt(1, timeOut, 0);
		}

		// Token: 0x06035A40 RID: 219712 RVA: 0x0074DCA0 File Offset: 0x0074BEA0
		public static Offset<ITelePortAfterTimeOut> EndITelePortAfterTimeOut(FlatBufferBuilder builder)
		{
			return new Offset<ITelePortAfterTimeOut>(builder.EndTable());
		}

		// Token: 0x06035A41 RID: 219713 RVA: 0x0074DCB0 File Offset: 0x0074BEB0
		public ITelePortAfterTimeOutT UnPack()
		{
			ITelePortAfterTimeOutT telePortAfterTimeOutT = new ITelePortAfterTimeOutT();
			this.UnPackTo(telePortAfterTimeOutT);
			return telePortAfterTimeOutT;
		}

		// Token: 0x06035A42 RID: 219714 RVA: 0x0074DCCB File Offset: 0x0074BECB
		public void UnPackTo(ITelePortAfterTimeOutT _o)
		{
			_o.Type = this.Type;
			_o.TimeOut = this.TimeOut;
		}

		// Token: 0x06035A43 RID: 219715 RVA: 0x0074DCE8 File Offset: 0x0074BEE8
		public static Offset<ITelePortAfterTimeOut> Pack(FlatBufferBuilder builder, ITelePortAfterTimeOutT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITelePortAfterTimeOut>);
			}
			return ITelePortAfterTimeOut.CreateITelePortAfterTimeOut(builder, _o.Type, _o.TimeOut);
		}

		// Token: 0x04012182 RID: 74114
		private Table __p;
	}
}
