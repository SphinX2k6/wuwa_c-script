using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B93 RID: 2963
	public struct CompositeRewardDisplay : IFlatbufferObject
	{
		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060057DC RID: 22492 RVA: 0x001FB9B5 File Offset: 0x001F9BB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060057DD RID: 22493 RVA: 0x001FB9C2 File Offset: 0x001F9BC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060057DE RID: 22494 RVA: 0x001FB9CC File Offset: 0x001F9BCC
		public static CompositeRewardDisplay GetRootAsCompositeRewardDisplay(ByteBuffer _bb)
		{
			return CompositeRewardDisplay.GetRootAsCompositeRewardDisplay(_bb, default(CompositeRewardDisplay));
		}

		// Token: 0x060057DF RID: 22495 RVA: 0x001FB9E8 File Offset: 0x001F9BE8
		public static CompositeRewardDisplay GetRootAsCompositeRewardDisplay(ByteBuffer _bb, CompositeRewardDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x001FBA05 File Offset: 0x001F9C05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060057E1 RID: 22497 RVA: 0x001FBA14 File Offset: 0x001F9C14
		public CompositeRewardDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060057E2 RID: 22498 RVA: 0x001FBA24 File Offset: 0x001F9C24
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

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060057E3 RID: 22499 RVA: 0x001FBA60 File Offset: 0x001F9C60
		public bool IsDragonPool
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060057E4 RID: 22500 RVA: 0x001FBAA0 File Offset: 0x001F9CA0
		public string Title
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

		// Token: 0x060057E5 RID: 22501 RVA: 0x001FBAD7 File Offset: 0x001F9CD7
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060057E6 RID: 22502 RVA: 0x001FBAE6 File Offset: 0x001F9CE6
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060057E7 RID: 22503 RVA: 0x001FBB00 File Offset: 0x001F9D00
		public string ContinueText
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

		// Token: 0x060057E8 RID: 22504 RVA: 0x001FBB38 File Offset: 0x001F9D38
		public Span<byte> GetContinueTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060057E9 RID: 22505 RVA: 0x001FBB48 File Offset: 0x001F9D48
		public byte[] GetContinueTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060057EA RID: 22506 RVA: 0x001FBB60 File Offset: 0x001F9D60
		public string TitleIconPath
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

		// Token: 0x060057EB RID: 22507 RVA: 0x001FBB98 File Offset: 0x001F9D98
		public Span<byte> GetTitleIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060057EC RID: 22508 RVA: 0x001FBBA8 File Offset: 0x001F9DA8
		public byte[] GetTitleIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060057ED RID: 22509 RVA: 0x001FBBC0 File Offset: 0x001F9DC0
		public bool IsProgressVisible
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x060057EE RID: 22510 RVA: 0x001FBC00 File Offset: 0x001F9E00
		public string ProgressBarTitle
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

		// Token: 0x060057EF RID: 22511 RVA: 0x001FBC38 File Offset: 0x001F9E38
		public Span<byte> GetProgressBarTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x001FBC48 File Offset: 0x001F9E48
		public byte[] GetProgressBarTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x060057F1 RID: 22513 RVA: 0x001FBC60 File Offset: 0x001F9E60
		public int ProgressBarAnimationTime
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 500;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x060057F2 RID: 22514 RVA: 0x001FBCA4 File Offset: 0x001F9EA4
		public bool IsItemVisible
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x060057F3 RID: 22515 RVA: 0x001FBCE4 File Offset: 0x001F9EE4
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x060057F4 RID: 22516 RVA: 0x001FBD24 File Offset: 0x001F9F24
		public string AudioId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060057F5 RID: 22517 RVA: 0x001FBD5C File Offset: 0x001F9F5C
		public Span<byte> GetAudioIdBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060057F6 RID: 22518 RVA: 0x001FBD6C File Offset: 0x001F9F6C
		public byte[] GetAudioIdArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x04004BA2 RID: 19362
		private Table __p;
	}
}
