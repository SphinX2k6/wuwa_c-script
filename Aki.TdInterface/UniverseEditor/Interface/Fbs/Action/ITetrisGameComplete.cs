using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C7 RID: 29639
	public struct ITetrisGameComplete : IFlatbufferObject
	{
		// Token: 0x1700E11C RID: 57628
		// (get) Token: 0x06035D4E RID: 220494 RVA: 0x00753FCF File Offset: 0x007521CF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035D4F RID: 220495 RVA: 0x00753FDC File Offset: 0x007521DC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035D50 RID: 220496 RVA: 0x00753FE4 File Offset: 0x007521E4
		public static ITetrisGameComplete GetRootAsITetrisGameComplete(ByteBuffer _bb)
		{
			return ITetrisGameComplete.GetRootAsITetrisGameComplete(_bb, default(ITetrisGameComplete));
		}

		// Token: 0x06035D51 RID: 220497 RVA: 0x00754000 File Offset: 0x00752200
		public static ITetrisGameComplete GetRootAsITetrisGameComplete(ByteBuffer _bb, ITetrisGameComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035D52 RID: 220498 RVA: 0x0075401D File Offset: 0x0075221D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035D53 RID: 220499 RVA: 0x0075402C File Offset: 0x0075222C
		public ITetrisGameComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06035D54 RID: 220500 RVA: 0x0075403C File Offset: 0x0075223C
		public static void StartITetrisGameComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06035D55 RID: 220501 RVA: 0x00754045 File Offset: 0x00752245
		public static Offset<ITetrisGameComplete> EndITetrisGameComplete(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisGameComplete>(builder.EndTable());
		}

		// Token: 0x06035D56 RID: 220502 RVA: 0x00754054 File Offset: 0x00752254
		public ITetrisGameCompleteT UnPack()
		{
			ITetrisGameCompleteT tetrisGameCompleteT = new ITetrisGameCompleteT();
			this.UnPackTo(tetrisGameCompleteT);
			return tetrisGameCompleteT;
		}

		// Token: 0x06035D57 RID: 220503 RVA: 0x0075406F File Offset: 0x0075226F
		public void UnPackTo(ITetrisGameCompleteT _o)
		{
		}

		// Token: 0x06035D58 RID: 220504 RVA: 0x00754074 File Offset: 0x00752274
		public static Offset<ITetrisGameComplete> Pack(FlatBufferBuilder builder, ITetrisGameCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisGameComplete>);
			}
			ITetrisGameComplete.StartITetrisGameComplete(builder);
			return ITetrisGameComplete.EndITetrisGameComplete(builder);
		}

		// Token: 0x0401220E RID: 74254
		private Table __p;
	}
}
