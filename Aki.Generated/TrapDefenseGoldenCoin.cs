using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001298 RID: 4760
	public struct TrapDefenseGoldenCoin : IFlatbufferObject
	{
		// Token: 0x17003F8E RID: 16270
		// (get) Token: 0x0600F10D RID: 61709 RVA: 0x00363BC0 File Offset: 0x00361DC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F10E RID: 61710 RVA: 0x00363BCD File Offset: 0x00361DCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F10F RID: 61711 RVA: 0x00363BD4 File Offset: 0x00361DD4
		public static TrapDefenseGoldenCoin GetRootAsTrapDefenseGoldenCoin(ByteBuffer _bb)
		{
			return TrapDefenseGoldenCoin.GetRootAsTrapDefenseGoldenCoin(_bb, default(TrapDefenseGoldenCoin));
		}

		// Token: 0x0600F110 RID: 61712 RVA: 0x00363BF0 File Offset: 0x00361DF0
		public static TrapDefenseGoldenCoin GetRootAsTrapDefenseGoldenCoin(ByteBuffer _bb, TrapDefenseGoldenCoin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F111 RID: 61713 RVA: 0x00363C0D File Offset: 0x00361E0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F112 RID: 61714 RVA: 0x00363C1C File Offset: 0x00361E1C
		public TrapDefenseGoldenCoin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F8F RID: 16271
		// (get) Token: 0x0600F113 RID: 61715 RVA: 0x00363C2C File Offset: 0x00361E2C
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

		// Token: 0x17003F90 RID: 16272
		// (get) Token: 0x0600F114 RID: 61716 RVA: 0x00363C68 File Offset: 0x00361E68
		public int TemplateId
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

		// Token: 0x17003F91 RID: 16273
		// (get) Token: 0x0600F115 RID: 61717 RVA: 0x00363CA4 File Offset: 0x00361EA4
		public int SimpleCombatSubtypeId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003F92 RID: 16274
		// (get) Token: 0x0600F116 RID: 61718 RVA: 0x00363CE0 File Offset: 0x00361EE0
		public int AbsorbGold
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040058EB RID: 22763
		private Table __p;
	}
}
