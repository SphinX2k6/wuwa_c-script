using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C29 RID: 3113
	public struct BossRushTaskTab : IFlatbufferObject
	{
		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06005517 RID: 21783 RVA: 0x002081C1 File Offset: 0x002063C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x002081CE File Offset: 0x002063CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x002081D8 File Offset: 0x002063D8
		public static BossRushTaskTab GetRootAsBossRushTaskTab(ByteBuffer _bb)
		{
			return BossRushTaskTab.GetRootAsBossRushTaskTab(_bb, default(BossRushTaskTab));
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x002081F4 File Offset: 0x002063F4
		public static BossRushTaskTab GetRootAsBossRushTaskTab(ByteBuffer _bb, BossRushTaskTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x00208211 File Offset: 0x00206411
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600551C RID: 21788 RVA: 0x00208220 File Offset: 0x00206420
		public BossRushTaskTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600551D RID: 21789 RVA: 0x00208230 File Offset: 0x00206430
		public int TabId
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

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600551E RID: 21790 RVA: 0x0020826C File Offset: 0x0020646C
		public int ActivityId
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

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600551F RID: 21791 RVA: 0x002082A8 File Offset: 0x002064A8
		public string Texture
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x002082DF File Offset: 0x002064DF
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x002082EE File Offset: 0x002064EE
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06005522 RID: 21794 RVA: 0x00208308 File Offset: 0x00206508
		public string TabTitle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x00208340 File Offset: 0x00206540
		public Span<byte> GetTabTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x00208350 File Offset: 0x00206550
		public byte[] GetTabTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005124 RID: 20772
		private Table __p;
	}
}
