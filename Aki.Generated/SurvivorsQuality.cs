using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001102 RID: 4354
	public struct SurvivorsQuality : IFlatbufferObject
	{
		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x0600DB01 RID: 56065 RVA: 0x003250E8 File Offset: 0x003232E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DB02 RID: 56066 RVA: 0x003250F5 File Offset: 0x003232F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DB03 RID: 56067 RVA: 0x003250FC File Offset: 0x003232FC
		public static SurvivorsQuality GetRootAsSurvivorsQuality(ByteBuffer _bb)
		{
			return SurvivorsQuality.GetRootAsSurvivorsQuality(_bb, default(SurvivorsQuality));
		}

		// Token: 0x0600DB04 RID: 56068 RVA: 0x00325118 File Offset: 0x00323318
		public static SurvivorsQuality GetRootAsSurvivorsQuality(ByteBuffer _bb, SurvivorsQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DB05 RID: 56069 RVA: 0x00325135 File Offset: 0x00323335
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DB06 RID: 56070 RVA: 0x00325144 File Offset: 0x00323344
		public SurvivorsQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x0600DB07 RID: 56071 RVA: 0x00325154 File Offset: 0x00323354
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

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x0600DB08 RID: 56072 RVA: 0x00325190 File Offset: 0x00323390
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

		// Token: 0x0600DB09 RID: 56073 RVA: 0x003251C7 File Offset: 0x003233C7
		public Span<byte> GetWeaponColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DB0A RID: 56074 RVA: 0x003251D6 File Offset: 0x003233D6
		public byte[] GetWeaponColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x0600DB0B RID: 56075 RVA: 0x003251F0 File Offset: 0x003233F0
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

		// Token: 0x0600DB0C RID: 56076 RVA: 0x00325227 File Offset: 0x00323427
		public Span<byte> GetEvolveColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DB0D RID: 56077 RVA: 0x00325236 File Offset: 0x00323436
		public byte[] GetEvolveColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x0600DB0E RID: 56078 RVA: 0x00325250 File Offset: 0x00323450
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

		// Token: 0x0600DB0F RID: 56079 RVA: 0x00325288 File Offset: 0x00323488
		public Span<byte> GetCardBasePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DB10 RID: 56080 RVA: 0x00325298 File Offset: 0x00323498
		public byte[] GetCardBasePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x0600DB11 RID: 56081 RVA: 0x003252B0 File Offset: 0x003234B0
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

		// Token: 0x0600DB12 RID: 56082 RVA: 0x003252E8 File Offset: 0x003234E8
		public Span<byte> GetWeaponBasePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DB13 RID: 56083 RVA: 0x003252F8 File Offset: 0x003234F8
		public byte[] GetWeaponBasePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x0600DB14 RID: 56084 RVA: 0x00325310 File Offset: 0x00323510
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

		// Token: 0x0600DB15 RID: 56085 RVA: 0x00325348 File Offset: 0x00323548
		public Span<byte> GetWeaponEvolvePathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DB16 RID: 56086 RVA: 0x00325358 File Offset: 0x00323558
		public byte[] GetWeaponEvolvePathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x0600DB17 RID: 56087 RVA: 0x00325370 File Offset: 0x00323570
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

		// Token: 0x0600DB18 RID: 56088 RVA: 0x003253A8 File Offset: 0x003235A8
		public Span<byte> GetWeaponEvolveTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DB19 RID: 56089 RVA: 0x003253B8 File Offset: 0x003235B8
		public byte[] GetWeaponEvolveTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x0600DB1A RID: 56090 RVA: 0x003253D0 File Offset: 0x003235D0
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

		// Token: 0x0600DB1B RID: 56091 RVA: 0x00325408 File Offset: 0x00323608
		public Span<byte> GetLvUpTagPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600DB1C RID: 56092 RVA: 0x00325418 File Offset: 0x00323618
		public byte[] GetLvUpTagPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0400523A RID: 21050
		private Table __p;
	}
}
