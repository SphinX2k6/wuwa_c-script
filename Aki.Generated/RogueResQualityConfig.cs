using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F7 RID: 4343
	public struct RogueResQualityConfig : IFlatbufferObject
	{
		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x0600C9E2 RID: 51682 RVA: 0x0030B1C5 File Offset: 0x003093C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C9E3 RID: 51683 RVA: 0x0030B1D2 File Offset: 0x003093D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C9E4 RID: 51684 RVA: 0x0030B1DC File Offset: 0x003093DC
		public static RogueResQualityConfig GetRootAsRogueResQualityConfig(ByteBuffer _bb)
		{
			return RogueResQualityConfig.GetRootAsRogueResQualityConfig(_bb, default(RogueResQualityConfig));
		}

		// Token: 0x0600C9E5 RID: 51685 RVA: 0x0030B1F8 File Offset: 0x003093F8
		public static RogueResQualityConfig GetRootAsRogueResQualityConfig(ByteBuffer _bb, RogueResQualityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C9E6 RID: 51686 RVA: 0x0030B215 File Offset: 0x00309415
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C9E7 RID: 51687 RVA: 0x0030B224 File Offset: 0x00309424
		public RogueResQualityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x0600C9E8 RID: 51688 RVA: 0x0030B234 File Offset: 0x00309434
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

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x0600C9E9 RID: 51689 RVA: 0x0030B270 File Offset: 0x00309470
		public string PhantomBgA
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

		// Token: 0x0600C9EA RID: 51690 RVA: 0x0030B2A7 File Offset: 0x003094A7
		public Span<byte> GetPhantomBgABytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C9EB RID: 51691 RVA: 0x0030B2B6 File Offset: 0x003094B6
		public byte[] GetPhantomBgAArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x0600C9EC RID: 51692 RVA: 0x0030B2D0 File Offset: 0x003094D0
		public string PhantomBgB
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

		// Token: 0x0600C9ED RID: 51693 RVA: 0x0030B307 File Offset: 0x00309507
		public Span<byte> GetPhantomBgBBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C9EE RID: 51694 RVA: 0x0030B316 File Offset: 0x00309516
		public byte[] GetPhantomBgBArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x0600C9EF RID: 51695 RVA: 0x0030B330 File Offset: 0x00309530
		public string PhantomBgC
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

		// Token: 0x0600C9F0 RID: 51696 RVA: 0x0030B368 File Offset: 0x00309568
		public Span<byte> GetPhantomBgCBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C9F1 RID: 51697 RVA: 0x0030B378 File Offset: 0x00309578
		public byte[] GetPhantomBgCArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x0600C9F2 RID: 51698 RVA: 0x0030B390 File Offset: 0x00309590
		public string TokenBg
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

		// Token: 0x0600C9F3 RID: 51699 RVA: 0x0030B3C8 File Offset: 0x003095C8
		public Span<byte> GetTokenBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C9F4 RID: 51700 RVA: 0x0030B3D8 File Offset: 0x003095D8
		public byte[] GetTokenBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x0600C9F5 RID: 51701 RVA: 0x0030B3F0 File Offset: 0x003095F0
		public string TokenColor
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

		// Token: 0x0600C9F6 RID: 51702 RVA: 0x0030B428 File Offset: 0x00309628
		public Span<byte> GetTokenColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C9F7 RID: 51703 RVA: 0x0030B438 File Offset: 0x00309638
		public byte[] GetTokenColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x0600C9F8 RID: 51704 RVA: 0x0030B450 File Offset: 0x00309650
		public string RoleNiagaraColor
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

		// Token: 0x0600C9F9 RID: 51705 RVA: 0x0030B488 File Offset: 0x00309688
		public Span<byte> GetRoleNiagaraColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C9FA RID: 51706 RVA: 0x0030B498 File Offset: 0x00309698
		public byte[] GetRoleNiagaraColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x040056E4 RID: 22244
		private Table __p;
	}
}
