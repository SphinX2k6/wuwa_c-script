using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B7B RID: 2939
	public struct CiacconaGalSubEnding : IFlatbufferObject
	{
		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06005591 RID: 21905 RVA: 0x001F6151 File Offset: 0x001F4351
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x001F615E File Offset: 0x001F435E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005593 RID: 21907 RVA: 0x001F6168 File Offset: 0x001F4368
		public static CiacconaGalSubEnding GetRootAsCiacconaGalSubEnding(ByteBuffer _bb)
		{
			return CiacconaGalSubEnding.GetRootAsCiacconaGalSubEnding(_bb, default(CiacconaGalSubEnding));
		}

		// Token: 0x06005594 RID: 21908 RVA: 0x001F6184 File Offset: 0x001F4384
		public static CiacconaGalSubEnding GetRootAsCiacconaGalSubEnding(ByteBuffer _bb, CiacconaGalSubEnding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x001F61A1 File Offset: 0x001F43A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x001F61B0 File Offset: 0x001F43B0
		public CiacconaGalSubEnding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06005597 RID: 21911 RVA: 0x001F61C0 File Offset: 0x001F43C0
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

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06005598 RID: 21912 RVA: 0x001F61FC File Offset: 0x001F43FC
		public string Title
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

		// Token: 0x06005599 RID: 21913 RVA: 0x001F6233 File Offset: 0x001F4433
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600559A RID: 21914 RVA: 0x001F6242 File Offset: 0x001F4442
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x0600559B RID: 21915 RVA: 0x001F625C File Offset: 0x001F445C
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

		// Token: 0x0600559C RID: 21916 RVA: 0x001F6293 File Offset: 0x001F4493
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x001F62A2 File Offset: 0x001F44A2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600559E RID: 21918 RVA: 0x001F62BC File Offset: 0x001F44BC
		public int Type
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x0600559F RID: 21919 RVA: 0x001F62FC File Offset: 0x001F44FC
		public string BackgroundImage
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

		// Token: 0x060055A0 RID: 21920 RVA: 0x001F6334 File Offset: 0x001F4534
		public Span<byte> GetBackgroundImageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060055A1 RID: 21921 RVA: 0x001F6344 File Offset: 0x001F4544
		public byte[] GetBackgroundImageArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060055A2 RID: 21922 RVA: 0x001F635C File Offset: 0x001F455C
		public int Reward
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060055A3 RID: 21923 RVA: 0x001F639C File Offset: 0x001F459C
		public int TriggerEnding
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

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060055A4 RID: 21924 RVA: 0x001F63DC File Offset: 0x001F45DC
		public bool ExitOnFinish
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004B7F RID: 19327
		private Table __p;
	}
}
