using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001158 RID: 4440
	public struct TrapDefenseBd : IFlatbufferObject
	{
		// Token: 0x17003BCB RID: 15307
		// (get) Token: 0x0600E285 RID: 57989 RVA: 0x00336469 File Offset: 0x00334669
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E286 RID: 57990 RVA: 0x00336476 File Offset: 0x00334676
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E287 RID: 57991 RVA: 0x00336480 File Offset: 0x00334680
		public static TrapDefenseBd GetRootAsTrapDefenseBd(ByteBuffer _bb)
		{
			return TrapDefenseBd.GetRootAsTrapDefenseBd(_bb, default(TrapDefenseBd));
		}

		// Token: 0x0600E288 RID: 57992 RVA: 0x0033649C File Offset: 0x0033469C
		public static TrapDefenseBd GetRootAsTrapDefenseBd(ByteBuffer _bb, TrapDefenseBd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E289 RID: 57993 RVA: 0x003364B9 File Offset: 0x003346B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E28A RID: 57994 RVA: 0x003364C8 File Offset: 0x003346C8
		public TrapDefenseBd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BCC RID: 15308
		// (get) Token: 0x0600E28B RID: 57995 RVA: 0x003364D8 File Offset: 0x003346D8
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

		// Token: 0x17003BCD RID: 15309
		// (get) Token: 0x0600E28C RID: 57996 RVA: 0x00336514 File Offset: 0x00334714
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

		// Token: 0x0600E28D RID: 57997 RVA: 0x0033654B File Offset: 0x0033474B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E28E RID: 57998 RVA: 0x0033655A File Offset: 0x0033475A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BCE RID: 15310
		// (get) Token: 0x0600E28F RID: 57999 RVA: 0x00336574 File Offset: 0x00334774
		public string Desc
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

		// Token: 0x0600E290 RID: 58000 RVA: 0x003365AB File Offset: 0x003347AB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E291 RID: 58001 RVA: 0x003365BA File Offset: 0x003347BA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BCF RID: 15311
		// (get) Token: 0x0600E292 RID: 58002 RVA: 0x003365D4 File Offset: 0x003347D4
		public int PurpleBuffCount
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

		// Token: 0x17003BD0 RID: 15312
		// (get) Token: 0x0600E293 RID: 58003 RVA: 0x00336614 File Offset: 0x00334814
		public int GoldBuffCount
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BD1 RID: 15313
		// (get) Token: 0x0600E294 RID: 58004 RVA: 0x00336654 File Offset: 0x00334854
		public string Icon
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

		// Token: 0x0600E295 RID: 58005 RVA: 0x0033668C File Offset: 0x0033488C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E296 RID: 58006 RVA: 0x0033669C File Offset: 0x0033489C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BD2 RID: 15314
		// (get) Token: 0x0600E297 RID: 58007 RVA: 0x003366B4 File Offset: 0x003348B4
		public string SimpleDesc
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

		// Token: 0x0600E298 RID: 58008 RVA: 0x003366EC File Offset: 0x003348EC
		public Span<byte> GetSimpleDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E299 RID: 58009 RVA: 0x003366FC File Offset: 0x003348FC
		public byte[] GetSimpleDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BD3 RID: 15315
		// (get) Token: 0x0600E29A RID: 58010 RVA: 0x00336714 File Offset: 0x00334914
		public string IconSmall
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

		// Token: 0x0600E29B RID: 58011 RVA: 0x0033674C File Offset: 0x0033494C
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E29C RID: 58012 RVA: 0x0033675C File Offset: 0x0033495C
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0400529D RID: 21149
		private Table __p;
	}
}
