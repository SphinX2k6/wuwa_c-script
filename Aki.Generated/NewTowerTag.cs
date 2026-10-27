using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E95 RID: 3733
	public struct NewTowerTag : IFlatbufferObject
	{
		// Token: 0x1700239F RID: 9119
		// (get) Token: 0x0600A024 RID: 40996 RVA: 0x002A00F0 File Offset: 0x0029E2F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A025 RID: 40997 RVA: 0x002A00FD File Offset: 0x0029E2FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A026 RID: 40998 RVA: 0x002A0104 File Offset: 0x0029E304
		public static NewTowerTag GetRootAsNewTowerTag(ByteBuffer _bb)
		{
			return NewTowerTag.GetRootAsNewTowerTag(_bb, default(NewTowerTag));
		}

		// Token: 0x0600A027 RID: 40999 RVA: 0x002A0120 File Offset: 0x0029E320
		public static NewTowerTag GetRootAsNewTowerTag(ByteBuffer _bb, NewTowerTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A028 RID: 41000 RVA: 0x002A013D File Offset: 0x0029E33D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A029 RID: 41001 RVA: 0x002A014C File Offset: 0x0029E34C
		public NewTowerTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x0600A02A RID: 41002 RVA: 0x002A015C File Offset: 0x0029E35C
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

		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x0600A02B RID: 41003 RVA: 0x002A0198 File Offset: 0x0029E398
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

		// Token: 0x0600A02C RID: 41004 RVA: 0x002A01CF File Offset: 0x0029E3CF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A02D RID: 41005 RVA: 0x002A01DE File Offset: 0x0029E3DE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x0600A02E RID: 41006 RVA: 0x002A01F8 File Offset: 0x0029E3F8
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

		// Token: 0x0600A02F RID: 41007 RVA: 0x002A022F File Offset: 0x0029E42F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A030 RID: 41008 RVA: 0x002A023E File Offset: 0x0029E43E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170023A3 RID: 9123
		// (get) Token: 0x0600A031 RID: 41009 RVA: 0x002A0258 File Offset: 0x0029E458
		public string Path
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

		// Token: 0x0600A032 RID: 41010 RVA: 0x002A0290 File Offset: 0x0029E490
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A033 RID: 41011 RVA: 0x002A02A0 File Offset: 0x0029E4A0
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x0600A034 RID: 41012 RVA: 0x002A02B8 File Offset: 0x0029E4B8
		public string Color
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

		// Token: 0x0600A035 RID: 41013 RVA: 0x002A02F0 File Offset: 0x0029E4F0
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x002A0300 File Offset: 0x0029E500
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F48 RID: 20296
		private Table __p;
	}
}
