using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC0 RID: 4032
	public struct RhythmBg : IFlatbufferObject
	{
		// Token: 0x17002E22 RID: 11810
		// (get) Token: 0x0600BC37 RID: 48183 RVA: 0x002DEA29 File Offset: 0x002DCC29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BC38 RID: 48184 RVA: 0x002DEA36 File Offset: 0x002DCC36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BC39 RID: 48185 RVA: 0x002DEA40 File Offset: 0x002DCC40
		public static RhythmBg GetRootAsRhythmBg(ByteBuffer _bb)
		{
			return RhythmBg.GetRootAsRhythmBg(_bb, default(RhythmBg));
		}

		// Token: 0x0600BC3A RID: 48186 RVA: 0x002DEA5C File Offset: 0x002DCC5C
		public static RhythmBg GetRootAsRhythmBg(ByteBuffer _bb, RhythmBg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BC3B RID: 48187 RVA: 0x002DEA79 File Offset: 0x002DCC79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BC3C RID: 48188 RVA: 0x002DEA88 File Offset: 0x002DCC88
		public RhythmBg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E23 RID: 11811
		// (get) Token: 0x0600BC3D RID: 48189 RVA: 0x002DEA98 File Offset: 0x002DCC98
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

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x0600BC3E RID: 48190 RVA: 0x002DEAD4 File Offset: 0x002DCCD4
		public string BgItemColor
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

		// Token: 0x0600BC3F RID: 48191 RVA: 0x002DEB0B File Offset: 0x002DCD0B
		public Span<byte> GetBgItemColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BC40 RID: 48192 RVA: 0x002DEB1A File Offset: 0x002DCD1A
		public byte[] GetBgItemColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x0600BC41 RID: 48193 RVA: 0x002DEB34 File Offset: 0x002DCD34
		public string BgMaskItemColor
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

		// Token: 0x0600BC42 RID: 48194 RVA: 0x002DEB6B File Offset: 0x002DCD6B
		public Span<byte> GetBgMaskItemColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BC43 RID: 48195 RVA: 0x002DEB7A File Offset: 0x002DCD7A
		public byte[] GetBgMaskItemColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x0600BC44 RID: 48196 RVA: 0x002DEB94 File Offset: 0x002DCD94
		public string StartLevelSequence
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

		// Token: 0x0600BC45 RID: 48197 RVA: 0x002DEBCC File Offset: 0x002DCDCC
		public Span<byte> GetStartLevelSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BC46 RID: 48198 RVA: 0x002DEBDC File Offset: 0x002DCDDC
		public byte[] GetStartLevelSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x0600BC47 RID: 48199 RVA: 0x002DEBF4 File Offset: 0x002DCDF4
		public string GlowItemTexture
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

		// Token: 0x0600BC48 RID: 48200 RVA: 0x002DEC2C File Offset: 0x002DCE2C
		public Span<byte> GetGlowItemTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BC49 RID: 48201 RVA: 0x002DEC3C File Offset: 0x002DCE3C
		public byte[] GetGlowItemTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x0600BC4A RID: 48202 RVA: 0x002DEC54 File Offset: 0x002DCE54
		public string GlowItemMaterial
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

		// Token: 0x0600BC4B RID: 48203 RVA: 0x002DEC8C File Offset: 0x002DCE8C
		public Span<byte> GetGlowItemMaterialBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BC4C RID: 48204 RVA: 0x002DEC9C File Offset: 0x002DCE9C
		public byte[] GetGlowItemMaterialArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x0600BC4D RID: 48205 RVA: 0x002DECB4 File Offset: 0x002DCEB4
		public string NiaSphereParWhiteColor
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

		// Token: 0x0600BC4E RID: 48206 RVA: 0x002DECEC File Offset: 0x002DCEEC
		public Span<byte> GetNiaSphereParWhiteColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BC4F RID: 48207 RVA: 0x002DECFC File Offset: 0x002DCEFC
		public byte[] GetNiaSphereParWhiteColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0400509A RID: 20634
		private Table __p;
	}
}
