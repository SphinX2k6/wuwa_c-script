using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BFE RID: 3070
	public struct BabelTowerDeEffect : IFlatbufferObject
	{
		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06005078 RID: 20600 RVA: 0x001FD18F File Offset: 0x001FB38F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x001FD19C File Offset: 0x001FB39C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x001FD1A4 File Offset: 0x001FB3A4
		public static BabelTowerDeEffect GetRootAsBabelTowerDeEffect(ByteBuffer _bb)
		{
			return BabelTowerDeEffect.GetRootAsBabelTowerDeEffect(_bb, default(BabelTowerDeEffect));
		}

		// Token: 0x0600507B RID: 20603 RVA: 0x001FD1C0 File Offset: 0x001FB3C0
		public static BabelTowerDeEffect GetRootAsBabelTowerDeEffect(ByteBuffer _bb, BabelTowerDeEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600507C RID: 20604 RVA: 0x001FD1DD File Offset: 0x001FB3DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600507D RID: 20605 RVA: 0x001FD1EC File Offset: 0x001FB3EC
		public BabelTowerDeEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600507E RID: 20606 RVA: 0x001FD1FC File Offset: 0x001FB3FC
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

		// Token: 0x040050EE RID: 20718
		private Table __p;
	}
}
