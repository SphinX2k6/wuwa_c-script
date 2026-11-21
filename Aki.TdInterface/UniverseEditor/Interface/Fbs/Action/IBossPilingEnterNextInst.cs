using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006886 RID: 26758
	public struct IBossPilingEnterNextInst : IFlatbufferObject
	{
		// Token: 0x1700C4A7 RID: 50343
		// (get) Token: 0x0602DBD8 RID: 187352 RVA: 0x00640E1A File Offset: 0x0063F01A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DBD9 RID: 187353 RVA: 0x00640E27 File Offset: 0x0063F027
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DBDA RID: 187354 RVA: 0x00640E30 File Offset: 0x0063F030
		public static IBossPilingEnterNextInst GetRootAsIBossPilingEnterNextInst(ByteBuffer _bb)
		{
			return IBossPilingEnterNextInst.GetRootAsIBossPilingEnterNextInst(_bb, default(IBossPilingEnterNextInst));
		}

		// Token: 0x0602DBDB RID: 187355 RVA: 0x00640E4C File Offset: 0x0063F04C
		public static IBossPilingEnterNextInst GetRootAsIBossPilingEnterNextInst(ByteBuffer _bb, IBossPilingEnterNextInst obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DBDC RID: 187356 RVA: 0x00640E69 File Offset: 0x0063F069
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DBDD RID: 187357 RVA: 0x00640E78 File Offset: 0x0063F078
		public IBossPilingEnterNextInst __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602DBDE RID: 187358 RVA: 0x00640E88 File Offset: 0x0063F088
		public static void StartIBossPilingEnterNextInst(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602DBDF RID: 187359 RVA: 0x00640E91 File Offset: 0x0063F091
		public static Offset<IBossPilingEnterNextInst> EndIBossPilingEnterNextInst(FlatBufferBuilder builder)
		{
			return new Offset<IBossPilingEnterNextInst>(builder.EndTable());
		}

		// Token: 0x0602DBE0 RID: 187360 RVA: 0x00640EA0 File Offset: 0x0063F0A0
		public IBossPilingEnterNextInstT UnPack()
		{
			IBossPilingEnterNextInstT bossPilingEnterNextInstT = new IBossPilingEnterNextInstT();
			this.UnPackTo(bossPilingEnterNextInstT);
			return bossPilingEnterNextInstT;
		}

		// Token: 0x0602DBE1 RID: 187361 RVA: 0x00640EBB File Offset: 0x0063F0BB
		public void UnPackTo(IBossPilingEnterNextInstT _o)
		{
		}

		// Token: 0x0602DBE2 RID: 187362 RVA: 0x00640EC0 File Offset: 0x0063F0C0
		public static Offset<IBossPilingEnterNextInst> Pack(FlatBufferBuilder builder, IBossPilingEnterNextInstT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBossPilingEnterNextInst>);
			}
			IBossPilingEnterNextInst.StartIBossPilingEnterNextInst(builder);
			return IBossPilingEnterNextInst.EndIBossPilingEnterNextInst(builder);
		}

		// Token: 0x04011569 RID: 71017
		private Table __p;
	}
}
