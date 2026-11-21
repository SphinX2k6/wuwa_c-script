using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001289 RID: 4745
	public struct TrapDefenseAttributeShow : IFlatbufferObject
	{
		// Token: 0x17003EFB RID: 16123
		// (get) Token: 0x0600EF63 RID: 61283 RVA: 0x003602F2 File Offset: 0x0035E4F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EF64 RID: 61284 RVA: 0x003602FF File Offset: 0x0035E4FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EF65 RID: 61285 RVA: 0x00360308 File Offset: 0x0035E508
		public static TrapDefenseAttributeShow GetRootAsTrapDefenseAttributeShow(ByteBuffer _bb)
		{
			return TrapDefenseAttributeShow.GetRootAsTrapDefenseAttributeShow(_bb, default(TrapDefenseAttributeShow));
		}

		// Token: 0x0600EF66 RID: 61286 RVA: 0x00360324 File Offset: 0x0035E524
		public static TrapDefenseAttributeShow GetRootAsTrapDefenseAttributeShow(ByteBuffer _bb, TrapDefenseAttributeShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EF67 RID: 61287 RVA: 0x00360341 File Offset: 0x0035E541
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EF68 RID: 61288 RVA: 0x00360350 File Offset: 0x0035E550
		public TrapDefenseAttributeShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EFC RID: 16124
		// (get) Token: 0x0600EF69 RID: 61289 RVA: 0x00360360 File Offset: 0x0035E560
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

		// Token: 0x17003EFD RID: 16125
		// (get) Token: 0x0600EF6A RID: 61290 RVA: 0x0036039C File Offset: 0x0035E59C
		public string Key
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

		// Token: 0x0600EF6B RID: 61291 RVA: 0x003603D3 File Offset: 0x0035E5D3
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EF6C RID: 61292 RVA: 0x003603E2 File Offset: 0x0035E5E2
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EFE RID: 16126
		// (get) Token: 0x0600EF6D RID: 61293 RVA: 0x003603FC File Offset: 0x0035E5FC
		public string Name
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

		// Token: 0x0600EF6E RID: 61294 RVA: 0x00360433 File Offset: 0x0035E633
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EF6F RID: 61295 RVA: 0x00360442 File Offset: 0x0035E642
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EFF RID: 16127
		// (get) Token: 0x0600EF70 RID: 61296 RVA: 0x0036045C File Offset: 0x0035E65C
		public string Icon
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

		// Token: 0x0600EF71 RID: 61297 RVA: 0x00360494 File Offset: 0x0035E694
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EF72 RID: 61298 RVA: 0x003604A4 File Offset: 0x0035E6A4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F00 RID: 16128
		// (get) Token: 0x0600EF73 RID: 61299 RVA: 0x003604BC File Offset: 0x0035E6BC
		public string ToMonster
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

		// Token: 0x0600EF74 RID: 61300 RVA: 0x003604F4 File Offset: 0x0035E6F4
		public Span<byte> GetToMonsterBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600EF75 RID: 61301 RVA: 0x00360504 File Offset: 0x0035E704
		public byte[] GetToMonsterArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040058DB RID: 22747
		private Table __p;
	}
}
