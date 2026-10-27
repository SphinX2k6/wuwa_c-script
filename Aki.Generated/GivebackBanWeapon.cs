using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D01 RID: 3329
	public struct GivebackBanWeapon : IFlatbufferObject
	{
		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06007AD9 RID: 31449 RVA: 0x0024C13E File Offset: 0x0024A33E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007ADA RID: 31450 RVA: 0x0024C14B File Offset: 0x0024A34B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007ADB RID: 31451 RVA: 0x0024C154 File Offset: 0x0024A354
		public static GivebackBanWeapon GetRootAsGivebackBanWeapon(ByteBuffer _bb)
		{
			return GivebackBanWeapon.GetRootAsGivebackBanWeapon(_bb, default(GivebackBanWeapon));
		}

		// Token: 0x06007ADC RID: 31452 RVA: 0x0024C170 File Offset: 0x0024A370
		public static GivebackBanWeapon GetRootAsGivebackBanWeapon(ByteBuffer _bb, GivebackBanWeapon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007ADD RID: 31453 RVA: 0x0024C18D File Offset: 0x0024A38D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007ADE RID: 31454 RVA: 0x0024C19C File Offset: 0x0024A39C
		public GivebackBanWeapon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06007ADF RID: 31455 RVA: 0x0024C1AC File Offset: 0x0024A3AC
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

		// Token: 0x04004D77 RID: 19831
		private Table __p;
	}
}
