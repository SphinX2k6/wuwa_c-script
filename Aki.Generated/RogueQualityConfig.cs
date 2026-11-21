using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D3 RID: 4307
	public struct RogueQualityConfig : IFlatbufferObject
	{
		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x0600C683 RID: 50819 RVA: 0x00303CE5 File Offset: 0x00301EE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C684 RID: 50820 RVA: 0x00303CF2 File Offset: 0x00301EF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C685 RID: 50821 RVA: 0x00303CFC File Offset: 0x00301EFC
		public static RogueQualityConfig GetRootAsRogueQualityConfig(ByteBuffer _bb)
		{
			return RogueQualityConfig.GetRootAsRogueQualityConfig(_bb, default(RogueQualityConfig));
		}

		// Token: 0x0600C686 RID: 50822 RVA: 0x00303D18 File Offset: 0x00301F18
		public static RogueQualityConfig GetRootAsRogueQualityConfig(ByteBuffer _bb, RogueQualityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C687 RID: 50823 RVA: 0x00303D35 File Offset: 0x00301F35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C688 RID: 50824 RVA: 0x00303D44 File Offset: 0x00301F44
		public RogueQualityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x0600C689 RID: 50825 RVA: 0x00303D54 File Offset: 0x00301F54
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

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x0600C68A RID: 50826 RVA: 0x00303D90 File Offset: 0x00301F90
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

		// Token: 0x0600C68B RID: 50827 RVA: 0x00303DC7 File Offset: 0x00301FC7
		public Span<byte> GetPhantomBgABytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C68C RID: 50828 RVA: 0x00303DD6 File Offset: 0x00301FD6
		public byte[] GetPhantomBgAArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x0600C68D RID: 50829 RVA: 0x00303DF0 File Offset: 0x00301FF0
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

		// Token: 0x0600C68E RID: 50830 RVA: 0x00303E27 File Offset: 0x00302027
		public Span<byte> GetPhantomBgBBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C68F RID: 50831 RVA: 0x00303E36 File Offset: 0x00302036
		public byte[] GetPhantomBgBArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x0600C690 RID: 50832 RVA: 0x00303E50 File Offset: 0x00302050
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

		// Token: 0x0600C691 RID: 50833 RVA: 0x00303E88 File Offset: 0x00302088
		public Span<byte> GetPhantomBgCBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C692 RID: 50834 RVA: 0x00303E98 File Offset: 0x00302098
		public byte[] GetPhantomBgCArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x0600C693 RID: 50835 RVA: 0x00303EB0 File Offset: 0x003020B0
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

		// Token: 0x0600C694 RID: 50836 RVA: 0x00303EE8 File Offset: 0x003020E8
		public Span<byte> GetTokenBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C695 RID: 50837 RVA: 0x00303EF8 File Offset: 0x003020F8
		public byte[] GetTokenBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x0600C696 RID: 50838 RVA: 0x00303F10 File Offset: 0x00302110
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

		// Token: 0x0600C697 RID: 50839 RVA: 0x00303F48 File Offset: 0x00302148
		public Span<byte> GetTokenColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C698 RID: 50840 RVA: 0x00303F58 File Offset: 0x00302158
		public byte[] GetTokenColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003017 RID: 12311
		// (get) Token: 0x0600C699 RID: 50841 RVA: 0x00303F70 File Offset: 0x00302170
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

		// Token: 0x0600C69A RID: 50842 RVA: 0x00303FA8 File Offset: 0x003021A8
		public Span<byte> GetRoleNiagaraColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C69B RID: 50843 RVA: 0x00303FB8 File Offset: 0x003021B8
		public byte[] GetRoleNiagaraColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x040056B4 RID: 22196
		private Table __p;
	}
}
