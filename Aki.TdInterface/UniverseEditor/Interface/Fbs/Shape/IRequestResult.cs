using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004046 RID: 16454
	public struct IRequestResult : IFlatbufferObject
	{
		// Token: 0x17006FDA RID: 28634
		// (get) Token: 0x060169A3 RID: 92579 RVA: 0x0033BA7E File Offset: 0x00339C7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060169A4 RID: 92580 RVA: 0x0033BA8B File Offset: 0x00339C8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060169A5 RID: 92581 RVA: 0x0033BA94 File Offset: 0x00339C94
		public static IRequestResult GetRootAsIRequestResult(ByteBuffer _bb)
		{
			return IRequestResult.GetRootAsIRequestResult(_bb, default(IRequestResult));
		}

		// Token: 0x060169A6 RID: 92582 RVA: 0x0033BAB0 File Offset: 0x00339CB0
		public static IRequestResult GetRootAsIRequestResult(ByteBuffer _bb, IRequestResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060169A7 RID: 92583 RVA: 0x0033BACD File Offset: 0x00339CCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060169A8 RID: 92584 RVA: 0x0033BADC File Offset: 0x00339CDC
		public IRequestResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FDB RID: 28635
		// (get) Token: 0x060169A9 RID: 92585 RVA: 0x0033BAEC File Offset: 0x00339CEC
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006FDC RID: 28636
		// (get) Token: 0x060169AA RID: 92586 RVA: 0x0033BB2C File Offset: 0x00339D2C
		public string Reason
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060169AB RID: 92587 RVA: 0x0033BB63 File Offset: 0x00339D63
		public Span<byte> GetReasonBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060169AC RID: 92588 RVA: 0x0033BB72 File Offset: 0x00339D72
		public byte[] GetReasonArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060169AD RID: 92589 RVA: 0x0033BB80 File Offset: 0x00339D80
		public static Offset<IRequestResult> CreateIRequestResult(FlatBufferBuilder builder, bool IsSuccess = false, StringOffset ReasonOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRequestResult.AddReason(builder, ReasonOffset);
			IRequestResult.AddIsSuccess(builder, IsSuccess);
			return IRequestResult.EndIRequestResult(builder);
		}

		// Token: 0x060169AE RID: 92590 RVA: 0x0033BB9D File Offset: 0x00339D9D
		public static void StartIRequestResult(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060169AF RID: 92591 RVA: 0x0033BBA6 File Offset: 0x00339DA6
		public static void AddIsSuccess(FlatBufferBuilder builder, bool isSuccess)
		{
			builder.AddBool(0, isSuccess, false);
		}

		// Token: 0x060169B0 RID: 92592 RVA: 0x0033BBB1 File Offset: 0x00339DB1
		public static void AddReason(FlatBufferBuilder builder, StringOffset reasonOffset)
		{
			builder.AddOffset(1, reasonOffset.Value, 0);
		}

		// Token: 0x060169B1 RID: 92593 RVA: 0x0033BBC1 File Offset: 0x00339DC1
		public static Offset<IRequestResult> EndIRequestResult(FlatBufferBuilder builder)
		{
			return new Offset<IRequestResult>(builder.EndTable());
		}

		// Token: 0x060169B2 RID: 92594 RVA: 0x0033BBD0 File Offset: 0x00339DD0
		public IRequestResultT UnPack()
		{
			IRequestResultT requestResultT = new IRequestResultT();
			this.UnPackTo(requestResultT);
			return requestResultT;
		}

		// Token: 0x060169B3 RID: 92595 RVA: 0x0033BBEB File Offset: 0x00339DEB
		public void UnPackTo(IRequestResultT _o)
		{
			_o.IsSuccess = this.IsSuccess;
			_o.Reason = this.Reason;
		}

		// Token: 0x060169B4 RID: 92596 RVA: 0x0033BC08 File Offset: 0x00339E08
		public static Offset<IRequestResult> Pack(FlatBufferBuilder builder, IRequestResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRequestResult>);
			}
			StringOffset reasonOffset = (_o.Reason == null) ? default(StringOffset) : builder.CreateString(_o.Reason);
			return IRequestResult.CreateIRequestResult(builder, _o.IsSuccess, reasonOffset);
		}

		// Token: 0x0400BBC8 RID: 48072
		private Table __p;
	}
}
