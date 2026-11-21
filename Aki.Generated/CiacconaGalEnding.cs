using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C5A RID: 3162
	public struct CiacconaGalEnding : IFlatbufferObject
	{
		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06005B23 RID: 23331 RVA: 0x002157A5 File Offset: 0x002139A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005B24 RID: 23332 RVA: 0x002157B2 File Offset: 0x002139B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x002157BC File Offset: 0x002139BC
		public static CiacconaGalEnding GetRootAsCiacconaGalEnding(ByteBuffer _bb)
		{
			return CiacconaGalEnding.GetRootAsCiacconaGalEnding(_bb, default(CiacconaGalEnding));
		}

		// Token: 0x06005B26 RID: 23334 RVA: 0x002157D8 File Offset: 0x002139D8
		public static CiacconaGalEnding GetRootAsCiacconaGalEnding(ByteBuffer _bb, CiacconaGalEnding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005B27 RID: 23335 RVA: 0x002157F5 File Offset: 0x002139F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005B28 RID: 23336 RVA: 0x00215804 File Offset: 0x00213A04
		public CiacconaGalEnding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06005B29 RID: 23337 RVA: 0x00215814 File Offset: 0x00213A14
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

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06005B2A RID: 23338 RVA: 0x00215850 File Offset: 0x00213A50
		public string BackgroundImage
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

		// Token: 0x06005B2B RID: 23339 RVA: 0x00215887 File Offset: 0x00213A87
		public Span<byte> GetBackgroundImageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005B2C RID: 23340 RVA: 0x00215896 File Offset: 0x00213A96
		public byte[] GetBackgroundImageArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06005B2D RID: 23341 RVA: 0x002158B0 File Offset: 0x00213AB0
		public string DetailBackgroundImage
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

		// Token: 0x06005B2E RID: 23342 RVA: 0x002158E7 File Offset: 0x00213AE7
		public Span<byte> GetDetailBackgroundImageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005B2F RID: 23343 RVA: 0x002158F6 File Offset: 0x00213AF6
		public byte[] GetDetailBackgroundImageArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06005B30 RID: 23344 RVA: 0x00215910 File Offset: 0x00213B10
		public string Title
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

		// Token: 0x06005B31 RID: 23345 RVA: 0x00215948 File Offset: 0x00213B48
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005B32 RID: 23346 RVA: 0x00215958 File Offset: 0x00213B58
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06005B33 RID: 23347 RVA: 0x00215970 File Offset: 0x00213B70
		public string Desc
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

		// Token: 0x06005B34 RID: 23348 RVA: 0x002159A8 File Offset: 0x00213BA8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005B35 RID: 23349 RVA: 0x002159B8 File Offset: 0x00213BB8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06005B36 RID: 23350 RVA: 0x002159D0 File Offset: 0x00213BD0
		public int Type
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06005B37 RID: 23351 RVA: 0x00215A10 File Offset: 0x00213C10
		public int Reward
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400515E RID: 20830
		private Table __p;
	}
}
