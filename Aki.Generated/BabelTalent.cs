using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BFA RID: 3066
	public struct BabelTalent : IFlatbufferObject
	{
		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x0600502E RID: 20526 RVA: 0x001FC78C File Offset: 0x001FA98C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x001FC799 File Offset: 0x001FA999
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x001FC7A0 File Offset: 0x001FA9A0
		public static BabelTalent GetRootAsBabelTalent(ByteBuffer _bb)
		{
			return BabelTalent.GetRootAsBabelTalent(_bb, default(BabelTalent));
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x001FC7BC File Offset: 0x001FA9BC
		public static BabelTalent GetRootAsBabelTalent(ByteBuffer _bb, BabelTalent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x001FC7D9 File Offset: 0x001FA9D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x001FC7E8 File Offset: 0x001FA9E8
		public BabelTalent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06005034 RID: 20532 RVA: 0x001FC7F8 File Offset: 0x001FA9F8
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040050E9 RID: 20713
		private Table __p;
	}
}
