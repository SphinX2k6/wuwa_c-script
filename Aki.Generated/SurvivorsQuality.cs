using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001238 RID: 4664
	public struct SurvivorsQuality : IFlatbufferObject
	{
		// Token: 0x17003C4E RID: 15438
		// (get) Token: 0x0600E84C RID: 59468 RVA: 0x00350420 File Offset: 0x0034E620
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E84D RID: 59469 RVA: 0x0035042D File Offset: 0x0034E62D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E84E RID: 59470 RVA: 0x00350434 File Offset: 0x0034E634
		public static SurvivorsQuality GetRootAsSurvivorsQuality(ByteBuffer _bb)
		{
			return SurvivorsQuality.GetRootAsSurvivorsQuality(_bb, default(SurvivorsQuality));
		}

		// Token: 0x0600E84F RID: 59471 RVA: 0x00350450 File Offset: 0x0034E650
		public static SurvivorsQuality GetRootAsSurvivorsQuality(ByteBuffer _bb, SurvivorsQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E850 RID: 59472 RVA: 0x0035046D File Offset: 0x0034E66D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E851 RID: 59473 RVA: 0x0035047C File Offset: 0x0034E67C
		public SurvivorsQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C4F RID: 15439
		// (get) Token: 0x0600E852 RID: 59474 RVA: 0x0035048C File Offset: 0x0034E68C
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

		// Token: 0x17003C50 RID: 15440
		// (get) Token: 0x0600E853 RID: 59475 RVA: 0x003504C8 File Offset: 0x0034E6C8
		public string WeaponColor
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

		// Token: 0x0600E854 RID: 59476 RVA: 0x003504FF File Offset: 0x0034E6FF
		public Span<byte> GetWeaponColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E855 RID: 59477 RVA: 0x0035050E File Offset: 0x0034E70E
		public byte[] GetWeaponColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C51 RID: 15441
		// (get) Token: 0x0600E856 RID: 59478 RVA: 0x00350528 File Offset: 0x0034E728
		public string EvolveColor
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

		// Token: 0x0600E857 RID: 59479 RVA: 0x0035055F File Offset: 0x0034E75F
		public Span<byte> GetEvolveColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E858 RID: 59480 RVA: 0x0035056E File Offset: 0x0034E76E
		public byte[] GetEvolveColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C52 RID: 15442
		// (get) Token: 0x0600E859 RID: 59481 RVA: 0x00350588 File Offset: 0x0034E788
		public string CardBasePath
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

		// Token: 0x0600E85A RID: 59482 RVA: 0x003505C0 File Offset: 0x0034E7C0
		public Span<byte> GetCardBasePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E85B RID: 59483 RVA: 0x003505D0 File Offset: 0x0034E7D0
		public byte[] GetCardBasePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C53 RID: 15443
		// (get) Token: 0x0600E85C RID: 59484 RVA: 0x003505E8 File Offset: 0x0034E7E8
		public string WeaponBasePath
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

		// Token: 0x0600E85D RID: 59485 RVA: 0x00350620 File Offset: 0x0034E820
		public Span<byte> GetWeaponBasePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E85E RID: 59486 RVA: 0x00350630 File Offset: 0x0034E830
		public byte[] GetWeaponBasePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C54 RID: 15444
		// (get) Token: 0x0600E85F RID: 59487 RVA: 0x00350648 File Offset: 0x0034E848
		public string WeaponEvolvePath
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

		// Token: 0x0600E860 RID: 59488 RVA: 0x00350680 File Offset: 0x0034E880
		public Span<byte> GetWeaponEvolvePathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E861 RID: 59489 RVA: 0x00350690 File Offset: 0x0034E890
		public byte[] GetWeaponEvolvePathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C55 RID: 15445
		// (get) Token: 0x0600E862 RID: 59490 RVA: 0x003506A8 File Offset: 0x0034E8A8
		public string WeaponEvolveTitle
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

		// Token: 0x0600E863 RID: 59491 RVA: 0x003506E0 File Offset: 0x0034E8E0
		public Span<byte> GetWeaponEvolveTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E864 RID: 59492 RVA: 0x003506F0 File Offset: 0x0034E8F0
		public byte[] GetWeaponEvolveTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C56 RID: 15446
		// (get) Token: 0x0600E865 RID: 59493 RVA: 0x00350708 File Offset: 0x0034E908
		public string LvUpTagPath
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E866 RID: 59494 RVA: 0x00350740 File Offset: 0x0034E940
		public Span<byte> GetLvUpTagPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E867 RID: 59495 RVA: 0x00350750 File Offset: 0x0034E950
		public byte[] GetLvUpTagPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0400587D RID: 22653
		private Table __p;
	}
}
