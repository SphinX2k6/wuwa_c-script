using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C8B RID: 3211
	public struct FishingShipSkin : IFlatbufferObject
	{
		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x0600706A RID: 28778 RVA: 0x00233D69 File Offset: 0x00231F69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600706B RID: 28779 RVA: 0x00233D76 File Offset: 0x00231F76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600706C RID: 28780 RVA: 0x00233D80 File Offset: 0x00231F80
		public static FishingShipSkin GetRootAsFishingShipSkin(ByteBuffer _bb)
		{
			return FishingShipSkin.GetRootAsFishingShipSkin(_bb, default(FishingShipSkin));
		}

		// Token: 0x0600706D RID: 28781 RVA: 0x00233D9C File Offset: 0x00231F9C
		public static FishingShipSkin GetRootAsFishingShipSkin(ByteBuffer _bb, FishingShipSkin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600706E RID: 28782 RVA: 0x00233DB9 File Offset: 0x00231FB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600706F RID: 28783 RVA: 0x00233DC8 File Offset: 0x00231FC8
		public FishingShipSkin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06007070 RID: 28784 RVA: 0x00233DD8 File Offset: 0x00231FD8
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

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06007071 RID: 28785 RVA: 0x00233E14 File Offset: 0x00232014
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x00233E4B File Offset: 0x0023204B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x00233E5A File Offset: 0x0023205A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06007074 RID: 28788 RVA: 0x00233E74 File Offset: 0x00232074
		public string IconTexture
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

		// Token: 0x06007075 RID: 28789 RVA: 0x00233EAB File Offset: 0x002320AB
		public Span<byte> GetIconTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007076 RID: 28790 RVA: 0x00233EBA File Offset: 0x002320BA
		public byte[] GetIconTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06007077 RID: 28791 RVA: 0x00233ED4 File Offset: 0x002320D4
		public string BigTexture
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

		// Token: 0x06007078 RID: 28792 RVA: 0x00233F0C File Offset: 0x0023210C
		public Span<byte> GetBigTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007079 RID: 28793 RVA: 0x00233F1C File Offset: 0x0023211C
		public byte[] GetBigTextureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x0600707A RID: 28794 RVA: 0x00233F34 File Offset: 0x00232134
		public string DesText
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x00233F6C File Offset: 0x0023216C
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600707C RID: 28796 RVA: 0x00233F7C File Offset: 0x0023217C
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x0600707D RID: 28797 RVA: 0x00233F94 File Offset: 0x00232194
		public string LockText
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600707E RID: 28798 RVA: 0x00233FCC File Offset: 0x002321CC
		public Span<byte> GetLockTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600707F RID: 28799 RVA: 0x00233FDC File Offset: 0x002321DC
		public byte[] GetLockTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06007080 RID: 28800 RVA: 0x00233FF4 File Offset: 0x002321F4
		public string Mesh
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007081 RID: 28801 RVA: 0x0023402C File Offset: 0x0023222C
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007082 RID: 28802 RVA: 0x0023403C File Offset: 0x0023223C
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06007083 RID: 28803 RVA: 0x00234054 File Offset: 0x00232254
		public int TemplateId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06007084 RID: 28804 RVA: 0x00234094 File Offset: 0x00232294
		public int TechLevel
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06007085 RID: 28805 RVA: 0x002340D4 File Offset: 0x002322D4
		public int TechEffect
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004CE0 RID: 19680
		private Table __p;
	}
}
