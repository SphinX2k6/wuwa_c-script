using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001031 RID: 4145
	public struct RogueWeekQualityConfig : IFlatbufferObject
	{
		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x0600C682 RID: 50818 RVA: 0x002F5B6D File Offset: 0x002F3D6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C683 RID: 50819 RVA: 0x002F5B7A File Offset: 0x002F3D7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C684 RID: 50820 RVA: 0x002F5B84 File Offset: 0x002F3D84
		public static RogueWeekQualityConfig GetRootAsRogueWeekQualityConfig(ByteBuffer _bb)
		{
			return RogueWeekQualityConfig.GetRootAsRogueWeekQualityConfig(_bb, default(RogueWeekQualityConfig));
		}

		// Token: 0x0600C685 RID: 50821 RVA: 0x002F5BA0 File Offset: 0x002F3DA0
		public static RogueWeekQualityConfig GetRootAsRogueWeekQualityConfig(ByteBuffer _bb, RogueWeekQualityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C686 RID: 50822 RVA: 0x002F5BBD File Offset: 0x002F3DBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C687 RID: 50823 RVA: 0x002F5BCC File Offset: 0x002F3DCC
		public RogueWeekQualityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x0600C688 RID: 50824 RVA: 0x002F5BDC File Offset: 0x002F3DDC
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

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x0600C689 RID: 50825 RVA: 0x002F5C18 File Offset: 0x002F3E18
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

		// Token: 0x0600C68A RID: 50826 RVA: 0x002F5C4F File Offset: 0x002F3E4F
		public Span<byte> GetPhantomBgABytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C68B RID: 50827 RVA: 0x002F5C5E File Offset: 0x002F3E5E
		public byte[] GetPhantomBgAArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x0600C68C RID: 50828 RVA: 0x002F5C78 File Offset: 0x002F3E78
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

		// Token: 0x0600C68D RID: 50829 RVA: 0x002F5CAF File Offset: 0x002F3EAF
		public Span<byte> GetPhantomBgBBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C68E RID: 50830 RVA: 0x002F5CBE File Offset: 0x002F3EBE
		public byte[] GetPhantomBgBArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x0600C68F RID: 50831 RVA: 0x002F5CD8 File Offset: 0x002F3ED8
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

		// Token: 0x0600C690 RID: 50832 RVA: 0x002F5D10 File Offset: 0x002F3F10
		public Span<byte> GetPhantomBgCBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C691 RID: 50833 RVA: 0x002F5D20 File Offset: 0x002F3F20
		public byte[] GetPhantomBgCArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x0600C692 RID: 50834 RVA: 0x002F5D38 File Offset: 0x002F3F38
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

		// Token: 0x0600C693 RID: 50835 RVA: 0x002F5D70 File Offset: 0x002F3F70
		public Span<byte> GetTokenBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C694 RID: 50836 RVA: 0x002F5D80 File Offset: 0x002F3F80
		public byte[] GetTokenBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x0600C695 RID: 50837 RVA: 0x002F5D98 File Offset: 0x002F3F98
		public string TokenBgNew
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

		// Token: 0x0600C696 RID: 50838 RVA: 0x002F5DD0 File Offset: 0x002F3FD0
		public Span<byte> GetTokenBgNewBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C697 RID: 50839 RVA: 0x002F5DE0 File Offset: 0x002F3FE0
		public byte[] GetTokenBgNewArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x0600C698 RID: 50840 RVA: 0x002F5DF8 File Offset: 0x002F3FF8
		public string TokenColor
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

		// Token: 0x0600C699 RID: 50841 RVA: 0x002F5E30 File Offset: 0x002F4030
		public Span<byte> GetTokenColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C69A RID: 50842 RVA: 0x002F5E40 File Offset: 0x002F4040
		public byte[] GetTokenColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x0600C69B RID: 50843 RVA: 0x002F5E58 File Offset: 0x002F4058
		public string RoleNiagaraColor
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

		// Token: 0x0600C69C RID: 50844 RVA: 0x002F5E90 File Offset: 0x002F4090
		public Span<byte> GetRoleNiagaraColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C69D RID: 50845 RVA: 0x002F5EA0 File Offset: 0x002F40A0
		public byte[] GetRoleNiagaraColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005129 RID: 20777
		private Table __p;
	}
}
