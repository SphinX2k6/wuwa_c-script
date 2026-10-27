using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E2B RID: 28203
	public struct IReignsCheckSettle : IFlatbufferObject
	{
		// Token: 0x1700D230 RID: 53808
		// (get) Token: 0x06031D4F RID: 204111 RVA: 0x006BECE8 File Offset: 0x006BCEE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031D50 RID: 204112 RVA: 0x006BECF5 File Offset: 0x006BCEF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031D51 RID: 204113 RVA: 0x006BECFC File Offset: 0x006BCEFC
		public static IReignsCheckSettle GetRootAsIReignsCheckSettle(ByteBuffer _bb)
		{
			return IReignsCheckSettle.GetRootAsIReignsCheckSettle(_bb, default(IReignsCheckSettle));
		}

		// Token: 0x06031D52 RID: 204114 RVA: 0x006BED18 File Offset: 0x006BCF18
		public static IReignsCheckSettle GetRootAsIReignsCheckSettle(ByteBuffer _bb, IReignsCheckSettle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031D53 RID: 204115 RVA: 0x006BED35 File Offset: 0x006BCF35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031D54 RID: 204116 RVA: 0x006BED44 File Offset: 0x006BCF44
		public IReignsCheckSettle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06031D55 RID: 204117 RVA: 0x006BED54 File Offset: 0x006BCF54
		public static void StartIReignsCheckSettle(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06031D56 RID: 204118 RVA: 0x006BED5D File Offset: 0x006BCF5D
		public static Offset<IReignsCheckSettle> EndIReignsCheckSettle(FlatBufferBuilder builder)
		{
			return new Offset<IReignsCheckSettle>(builder.EndTable());
		}

		// Token: 0x06031D57 RID: 204119 RVA: 0x006BED6C File Offset: 0x006BCF6C
		public IReignsCheckSettleT UnPack()
		{
			IReignsCheckSettleT reignsCheckSettleT = new IReignsCheckSettleT();
			this.UnPackTo(reignsCheckSettleT);
			return reignsCheckSettleT;
		}

		// Token: 0x06031D58 RID: 204120 RVA: 0x006BED87 File Offset: 0x006BCF87
		public void UnPackTo(IReignsCheckSettleT _o)
		{
		}

		// Token: 0x06031D59 RID: 204121 RVA: 0x006BED8C File Offset: 0x006BCF8C
		public static Offset<IReignsCheckSettle> Pack(FlatBufferBuilder builder, IReignsCheckSettleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsCheckSettle>);
			}
			IReignsCheckSettle.StartIReignsCheckSettle(builder);
			return IReignsCheckSettle.EndIReignsCheckSettle(builder);
		}

		// Token: 0x04011812 RID: 71698
		private Table __p;
	}
}
