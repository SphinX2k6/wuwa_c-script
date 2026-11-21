using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A8 RID: 4264
	public struct RhythmBg : IFlatbufferObject
	{
		// Token: 0x17002E9D RID: 11933
		// (get) Token: 0x0600C281 RID: 49793 RVA: 0x002FB106 File Offset: 0x002F9306
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C282 RID: 49794 RVA: 0x002FB113 File Offset: 0x002F9313
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C283 RID: 49795 RVA: 0x002FB11C File Offset: 0x002F931C
		public static RhythmBg GetRootAsRhythmBg(ByteBuffer _bb)
		{
			return RhythmBg.GetRootAsRhythmBg(_bb, default(RhythmBg));
		}

		// Token: 0x0600C284 RID: 49796 RVA: 0x002FB138 File Offset: 0x002F9338
		public static RhythmBg GetRootAsRhythmBg(ByteBuffer _bb, RhythmBg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C285 RID: 49797 RVA: 0x002FB155 File Offset: 0x002F9355
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C286 RID: 49798 RVA: 0x002FB164 File Offset: 0x002F9364
		public RhythmBg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E9E RID: 11934
		// (get) Token: 0x0600C287 RID: 49799 RVA: 0x002FB174 File Offset: 0x002F9374
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

		// Token: 0x17002E9F RID: 11935
		// (get) Token: 0x0600C288 RID: 49800 RVA: 0x002FB1B0 File Offset: 0x002F93B0
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

		// Token: 0x0600C289 RID: 49801 RVA: 0x002FB1E7 File Offset: 0x002F93E7
		public Span<byte> GetBgItemColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C28A RID: 49802 RVA: 0x002FB1F6 File Offset: 0x002F93F6
		public byte[] GetBgItemColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x0600C28B RID: 49803 RVA: 0x002FB210 File Offset: 0x002F9410
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

		// Token: 0x0600C28C RID: 49804 RVA: 0x002FB247 File Offset: 0x002F9447
		public Span<byte> GetBgMaskItemColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C28D RID: 49805 RVA: 0x002FB256 File Offset: 0x002F9456
		public byte[] GetBgMaskItemColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x0600C28E RID: 49806 RVA: 0x002FB270 File Offset: 0x002F9470
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

		// Token: 0x0600C28F RID: 49807 RVA: 0x002FB2A8 File Offset: 0x002F94A8
		public Span<byte> GetStartLevelSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C290 RID: 49808 RVA: 0x002FB2B8 File Offset: 0x002F94B8
		public byte[] GetStartLevelSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x0600C291 RID: 49809 RVA: 0x002FB2D0 File Offset: 0x002F94D0
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

		// Token: 0x0600C292 RID: 49810 RVA: 0x002FB308 File Offset: 0x002F9508
		public Span<byte> GetGlowItemTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C293 RID: 49811 RVA: 0x002FB318 File Offset: 0x002F9518
		public byte[] GetGlowItemTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x0600C294 RID: 49812 RVA: 0x002FB330 File Offset: 0x002F9530
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

		// Token: 0x0600C295 RID: 49813 RVA: 0x002FB368 File Offset: 0x002F9568
		public Span<byte> GetGlowItemMaterialBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C296 RID: 49814 RVA: 0x002FB378 File Offset: 0x002F9578
		public byte[] GetGlowItemMaterialArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x0600C297 RID: 49815 RVA: 0x002FB390 File Offset: 0x002F9590
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

		// Token: 0x0600C298 RID: 49816 RVA: 0x002FB3C8 File Offset: 0x002F95C8
		public Span<byte> GetNiaSphereParWhiteColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C299 RID: 49817 RVA: 0x002FB3D8 File Offset: 0x002F95D8
		public byte[] GetNiaSphereParWhiteColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005682 RID: 22146
		private Table __p;
	}
}
