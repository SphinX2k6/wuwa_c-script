using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C26 RID: 3110
	public struct BossRushMapMark : IFlatbufferObject
	{
		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060054F9 RID: 21753 RVA: 0x00207E00 File Offset: 0x00206000
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060054FA RID: 21754 RVA: 0x00207E0D File Offset: 0x0020600D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060054FB RID: 21755 RVA: 0x00207E14 File Offset: 0x00206014
		public static BossRushMapMark GetRootAsBossRushMapMark(ByteBuffer _bb)
		{
			return BossRushMapMark.GetRootAsBossRushMapMark(_bb, default(BossRushMapMark));
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x00207E30 File Offset: 0x00206030
		public static BossRushMapMark GetRootAsBossRushMapMark(ByteBuffer _bb, BossRushMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x00207E4D File Offset: 0x0020604D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x00207E5C File Offset: 0x0020605C
		public BossRushMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060054FF RID: 21759 RVA: 0x00207E6C File Offset: 0x0020606C
		public int ActivityId
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

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06005500 RID: 21760 RVA: 0x00207EA8 File Offset: 0x002060A8
		public int MarkId
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

		// Token: 0x04005121 RID: 20769
		private Table __p;
	}
}
