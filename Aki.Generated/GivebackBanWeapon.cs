using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE6 RID: 3558
	public struct GivebackBanWeapon : IFlatbufferObject
	{
		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x060080F1 RID: 33009 RVA: 0x0026ACAE File Offset: 0x00268EAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060080F2 RID: 33010 RVA: 0x0026ACBB File Offset: 0x00268EBB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060080F3 RID: 33011 RVA: 0x0026ACC4 File Offset: 0x00268EC4
		public static GivebackBanWeapon GetRootAsGivebackBanWeapon(ByteBuffer _bb)
		{
			return GivebackBanWeapon.GetRootAsGivebackBanWeapon(_bb, default(GivebackBanWeapon));
		}

		// Token: 0x060080F4 RID: 33012 RVA: 0x0026ACE0 File Offset: 0x00268EE0
		public static GivebackBanWeapon GetRootAsGivebackBanWeapon(ByteBuffer _bb, GivebackBanWeapon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060080F5 RID: 33013 RVA: 0x0026ACFD File Offset: 0x00268EFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060080F6 RID: 33014 RVA: 0x0026AD0C File Offset: 0x00268F0C
		public GivebackBanWeapon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x060080F7 RID: 33015 RVA: 0x0026AD1C File Offset: 0x00268F1C
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

		// Token: 0x0400535C RID: 21340
		private Table __p;
	}
}
