using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E8A RID: 3722
	public struct NewTowerBossBuff : IFlatbufferObject
	{
		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x06009EFB RID: 40699 RVA: 0x0029D614 File Offset: 0x0029B814
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009EFC RID: 40700 RVA: 0x0029D621 File Offset: 0x0029B821
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009EFD RID: 40701 RVA: 0x0029D628 File Offset: 0x0029B828
		public static NewTowerBossBuff GetRootAsNewTowerBossBuff(ByteBuffer _bb)
		{
			return NewTowerBossBuff.GetRootAsNewTowerBossBuff(_bb, default(NewTowerBossBuff));
		}

		// Token: 0x06009EFE RID: 40702 RVA: 0x0029D644 File Offset: 0x0029B844
		public static NewTowerBossBuff GetRootAsNewTowerBossBuff(ByteBuffer _bb, NewTowerBossBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009EFF RID: 40703 RVA: 0x0029D661 File Offset: 0x0029B861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009F00 RID: 40704 RVA: 0x0029D670 File Offset: 0x0029B870
		public NewTowerBossBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x06009F01 RID: 40705 RVA: 0x0029D680 File Offset: 0x0029B880
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

		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x06009F02 RID: 40706 RVA: 0x0029D6BC File Offset: 0x0029B8BC
		public string SkillBgQuality
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

		// Token: 0x06009F03 RID: 40707 RVA: 0x0029D6F3 File Offset: 0x0029B8F3
		public Span<byte> GetSkillBgQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009F04 RID: 40708 RVA: 0x0029D702 File Offset: 0x0029B902
		public byte[] GetSkillBgQualityArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x06009F05 RID: 40709 RVA: 0x0029D71C File Offset: 0x0029B91C
		public string SkillIconBgQuality
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

		// Token: 0x06009F06 RID: 40710 RVA: 0x0029D753 File Offset: 0x0029B953
		public Span<byte> GetSkillIconBgQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009F07 RID: 40711 RVA: 0x0029D762 File Offset: 0x0029B962
		public byte[] GetSkillIconBgQualityArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x06009F08 RID: 40712 RVA: 0x0029D77C File Offset: 0x0029B97C
		public string DetailTipBgQuality
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

		// Token: 0x06009F09 RID: 40713 RVA: 0x0029D7B4 File Offset: 0x0029B9B4
		public Span<byte> GetDetailTipBgQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009F0A RID: 40714 RVA: 0x0029D7C4 File Offset: 0x0029B9C4
		public byte[] GetDetailTipBgQualityArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x06009F0B RID: 40715 RVA: 0x0029D7DC File Offset: 0x0029B9DC
		public string BuffColor
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

		// Token: 0x06009F0C RID: 40716 RVA: 0x0029D814 File Offset: 0x0029BA14
		public Span<byte> GetBuffColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009F0D RID: 40717 RVA: 0x0029D824 File Offset: 0x0029BA24
		public byte[] GetBuffColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700233A RID: 9018
		// (get) Token: 0x06009F0E RID: 40718 RVA: 0x0029D83C File Offset: 0x0029BA3C
		public string SkillIcon
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

		// Token: 0x06009F0F RID: 40719 RVA: 0x0029D874 File Offset: 0x0029BA74
		public Span<byte> GetSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009F10 RID: 40720 RVA: 0x0029D884 File Offset: 0x0029BA84
		public byte[] GetSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x06009F11 RID: 40721 RVA: 0x0029D89C File Offset: 0x0029BA9C
		public string SmallIcon
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

		// Token: 0x06009F12 RID: 40722 RVA: 0x0029D8D4 File Offset: 0x0029BAD4
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009F13 RID: 40723 RVA: 0x0029D8E4 File Offset: 0x0029BAE4
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x06009F14 RID: 40724 RVA: 0x0029D8FC File Offset: 0x0029BAFC
		public string SkillTitle
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

		// Token: 0x06009F15 RID: 40725 RVA: 0x0029D934 File Offset: 0x0029BB34
		public Span<byte> GetSkillTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009F16 RID: 40726 RVA: 0x0029D944 File Offset: 0x0029BB44
		public byte[] GetSkillTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x06009F17 RID: 40727 RVA: 0x0029D95C File Offset: 0x0029BB5C
		public string SkillDesc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009F18 RID: 40728 RVA: 0x0029D994 File Offset: 0x0029BB94
		public Span<byte> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009F19 RID: 40729 RVA: 0x0029D9A4 File Offset: 0x0029BBA4
		public byte[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F38 RID: 20280
		private Table __p;
	}
}
