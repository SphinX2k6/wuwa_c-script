using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BAE RID: 31662
	public struct ITetrisGameComplete : IFlatbufferObject
	{
		// Token: 0x1700ED2C RID: 60716
		// (get) Token: 0x060390E9 RID: 233705 RVA: 0x007B650F File Offset: 0x007B470F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060390EA RID: 233706 RVA: 0x007B651C File Offset: 0x007B471C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060390EB RID: 233707 RVA: 0x007B6524 File Offset: 0x007B4724
		public static ITetrisGameComplete GetRootAsITetrisGameComplete(ByteBuffer _bb)
		{
			return ITetrisGameComplete.GetRootAsITetrisGameComplete(_bb, default(ITetrisGameComplete));
		}

		// Token: 0x060390EC RID: 233708 RVA: 0x007B6540 File Offset: 0x007B4740
		public static ITetrisGameComplete GetRootAsITetrisGameComplete(ByteBuffer _bb, ITetrisGameComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060390ED RID: 233709 RVA: 0x007B655D File Offset: 0x007B475D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060390EE RID: 233710 RVA: 0x007B656C File Offset: 0x007B476C
		public ITetrisGameComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060390EF RID: 233711 RVA: 0x007B657C File Offset: 0x007B477C
		public static void StartITetrisGameComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060390F0 RID: 233712 RVA: 0x007B6585 File Offset: 0x007B4785
		public static Offset<ITetrisGameComplete> EndITetrisGameComplete(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisGameComplete>(builder.EndTable());
		}

		// Token: 0x060390F1 RID: 233713 RVA: 0x007B6594 File Offset: 0x007B4794
		public ITetrisGameCompleteT UnPack()
		{
			ITetrisGameCompleteT tetrisGameCompleteT = new ITetrisGameCompleteT();
			this.UnPackTo(tetrisGameCompleteT);
			return tetrisGameCompleteT;
		}

		// Token: 0x060390F2 RID: 233714 RVA: 0x007B65AF File Offset: 0x007B47AF
		public void UnPackTo(ITetrisGameCompleteT _o)
		{
		}

		// Token: 0x060390F3 RID: 233715 RVA: 0x007B65B4 File Offset: 0x007B47B4
		public static Offset<ITetrisGameComplete> Pack(FlatBufferBuilder builder, ITetrisGameCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisGameComplete>);
			}
			ITetrisGameComplete.StartITetrisGameComplete(builder);
			return ITetrisGameComplete.EndITetrisGameComplete(builder);
		}

		// Token: 0x04013227 RID: 78375
		private Table __p;
	}
}
