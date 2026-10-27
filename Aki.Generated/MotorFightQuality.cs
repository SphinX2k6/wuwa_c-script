using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E4B RID: 3659
	public struct MotorFightQuality : IFlatbufferObject
	{
		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x060098FD RID: 39165 RVA: 0x002903CD File Offset: 0x0028E5CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060098FE RID: 39166 RVA: 0x002903DA File Offset: 0x0028E5DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060098FF RID: 39167 RVA: 0x002903E4 File Offset: 0x0028E5E4
		public static MotorFightQuality GetRootAsMotorFightQuality(ByteBuffer _bb)
		{
			return MotorFightQuality.GetRootAsMotorFightQuality(_bb, default(MotorFightQuality));
		}

		// Token: 0x06009900 RID: 39168 RVA: 0x00290400 File Offset: 0x0028E600
		public static MotorFightQuality GetRootAsMotorFightQuality(ByteBuffer _bb, MotorFightQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009901 RID: 39169 RVA: 0x0029041D File Offset: 0x0028E61D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009902 RID: 39170 RVA: 0x0029042C File Offset: 0x0028E62C
		public MotorFightQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x06009903 RID: 39171 RVA: 0x0029043C File Offset: 0x0028E63C
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

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06009904 RID: 39172 RVA: 0x00290478 File Offset: 0x0028E678
		public string SmallGridBg
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

		// Token: 0x06009905 RID: 39173 RVA: 0x002904AF File Offset: 0x0028E6AF
		public Span<byte> GetSmallGridBgBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009906 RID: 39174 RVA: 0x002904BE File Offset: 0x0028E6BE
		public byte[] GetSmallGridBgArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x06009907 RID: 39175 RVA: 0x002904D8 File Offset: 0x0028E6D8
		public string DetailCardBg
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

		// Token: 0x06009908 RID: 39176 RVA: 0x0029050F File Offset: 0x0028E70F
		public Span<byte> GetDetailCardBgBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009909 RID: 39177 RVA: 0x0029051E File Offset: 0x0028E71E
		public byte[] GetDetailCardBgArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x0600990A RID: 39178 RVA: 0x00290538 File Offset: 0x0028E738
		public string BgColor
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

		// Token: 0x0600990B RID: 39179 RVA: 0x00290570 File Offset: 0x0028E770
		public Span<byte> GetBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600990C RID: 39180 RVA: 0x00290580 File Offset: 0x0028E780
		public byte[] GetBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x0600990D RID: 39181 RVA: 0x00290598 File Offset: 0x0028E798
		public string DoorBuffGateBg
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

		// Token: 0x0600990E RID: 39182 RVA: 0x002905D0 File Offset: 0x0028E7D0
		public Span<byte> GetDoorBuffGateBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600990F RID: 39183 RVA: 0x002905E0 File Offset: 0x0028E7E0
		public byte[] GetDoorBuffGateBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x06009910 RID: 39184 RVA: 0x002905F8 File Offset: 0x0028E7F8
		public string DropBuffGateBg
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

		// Token: 0x06009911 RID: 39185 RVA: 0x00290630 File Offset: 0x0028E830
		public Span<byte> GetDropBuffGateBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009912 RID: 39186 RVA: 0x00290640 File Offset: 0x0028E840
		public byte[] GetDropBuffGateBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EF3 RID: 20211
		private Table __p;
	}
}
