using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001153 RID: 4435
	public struct TrapDefenseAttributeShow : IFlatbufferObject
	{
		// Token: 0x17003B97 RID: 15255
		// (get) Token: 0x0600E1F5 RID: 57845 RVA: 0x003350AD File Offset: 0x003332AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E1F6 RID: 57846 RVA: 0x003350BA File Offset: 0x003332BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E1F7 RID: 57847 RVA: 0x003350C4 File Offset: 0x003332C4
		public static TrapDefenseAttributeShow GetRootAsTrapDefenseAttributeShow(ByteBuffer _bb)
		{
			return TrapDefenseAttributeShow.GetRootAsTrapDefenseAttributeShow(_bb, default(TrapDefenseAttributeShow));
		}

		// Token: 0x0600E1F8 RID: 57848 RVA: 0x003350E0 File Offset: 0x003332E0
		public static TrapDefenseAttributeShow GetRootAsTrapDefenseAttributeShow(ByteBuffer _bb, TrapDefenseAttributeShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E1F9 RID: 57849 RVA: 0x003350FD File Offset: 0x003332FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E1FA RID: 57850 RVA: 0x0033510C File Offset: 0x0033330C
		public TrapDefenseAttributeShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B98 RID: 15256
		// (get) Token: 0x0600E1FB RID: 57851 RVA: 0x0033511C File Offset: 0x0033331C
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

		// Token: 0x17003B99 RID: 15257
		// (get) Token: 0x0600E1FC RID: 57852 RVA: 0x00335158 File Offset: 0x00333358
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

		// Token: 0x0600E1FD RID: 57853 RVA: 0x0033518F File Offset: 0x0033338F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E1FE RID: 57854 RVA: 0x0033519E File Offset: 0x0033339E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B9A RID: 15258
		// (get) Token: 0x0600E1FF RID: 57855 RVA: 0x003351B8 File Offset: 0x003333B8
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

		// Token: 0x0600E200 RID: 57856 RVA: 0x003351EF File Offset: 0x003333EF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E201 RID: 57857 RVA: 0x003351FE File Offset: 0x003333FE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B9B RID: 15259
		// (get) Token: 0x0600E202 RID: 57858 RVA: 0x00335218 File Offset: 0x00333418
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

		// Token: 0x0600E203 RID: 57859 RVA: 0x00335250 File Offset: 0x00333450
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E204 RID: 57860 RVA: 0x00335260 File Offset: 0x00333460
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B9C RID: 15260
		// (get) Token: 0x0600E205 RID: 57861 RVA: 0x00335278 File Offset: 0x00333478
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

		// Token: 0x0600E206 RID: 57862 RVA: 0x003352B0 File Offset: 0x003334B0
		public Span<byte> GetToMonsterBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E207 RID: 57863 RVA: 0x003352C0 File Offset: 0x003334C0
		public byte[] GetToMonsterArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005298 RID: 21144
		private Table __p;
	}
}
