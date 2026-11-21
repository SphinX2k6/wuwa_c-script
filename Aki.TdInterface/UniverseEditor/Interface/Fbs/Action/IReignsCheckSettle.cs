using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A9 RID: 30121
	public struct IReignsCheckSettle : IFlatbufferObject
	{
		// Token: 0x1700DD7F RID: 56703
		// (get) Token: 0x06034D65 RID: 216421 RVA: 0x0071A670 File Offset: 0x00718870
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034D66 RID: 216422 RVA: 0x0071A67D File Offset: 0x0071887D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034D67 RID: 216423 RVA: 0x0071A684 File Offset: 0x00718884
		public static IReignsCheckSettle GetRootAsIReignsCheckSettle(ByteBuffer _bb)
		{
			return IReignsCheckSettle.GetRootAsIReignsCheckSettle(_bb, default(IReignsCheckSettle));
		}

		// Token: 0x06034D68 RID: 216424 RVA: 0x0071A6A0 File Offset: 0x007188A0
		public static IReignsCheckSettle GetRootAsIReignsCheckSettle(ByteBuffer _bb, IReignsCheckSettle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034D69 RID: 216425 RVA: 0x0071A6BD File Offset: 0x007188BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034D6A RID: 216426 RVA: 0x0071A6CC File Offset: 0x007188CC
		public IReignsCheckSettle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06034D6B RID: 216427 RVA: 0x0071A6DC File Offset: 0x007188DC
		public static void StartIReignsCheckSettle(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06034D6C RID: 216428 RVA: 0x0071A6E5 File Offset: 0x007188E5
		public static Offset<IReignsCheckSettle> EndIReignsCheckSettle(FlatBufferBuilder builder)
		{
			return new Offset<IReignsCheckSettle>(builder.EndTable());
		}

		// Token: 0x06034D6D RID: 216429 RVA: 0x0071A6F4 File Offset: 0x007188F4
		public IReignsCheckSettleT UnPack()
		{
			IReignsCheckSettleT reignsCheckSettleT = new IReignsCheckSettleT();
			this.UnPackTo(reignsCheckSettleT);
			return reignsCheckSettleT;
		}

		// Token: 0x06034D6E RID: 216430 RVA: 0x0071A70F File Offset: 0x0071890F
		public void UnPackTo(IReignsCheckSettleT _o)
		{
		}

		// Token: 0x06034D6F RID: 216431 RVA: 0x0071A714 File Offset: 0x00718914
		public static Offset<IReignsCheckSettle> Pack(FlatBufferBuilder builder, IReignsCheckSettleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsCheckSettle>);
			}
			IReignsCheckSettle.StartIReignsCheckSettle(builder);
			return IReignsCheckSettle.EndIReignsCheckSettle(builder);
		}

		// Token: 0x04012792 RID: 75666
		private Table __p;
	}
}
