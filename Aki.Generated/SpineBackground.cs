using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E2 RID: 4322
	public struct SpineBackground : IFlatbufferObject
	{
		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x0600D80F RID: 55311 RVA: 0x0031E561 File Offset: 0x0031C761
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D810 RID: 55312 RVA: 0x0031E56E File Offset: 0x0031C76E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D811 RID: 55313 RVA: 0x0031E578 File Offset: 0x0031C778
		public static SpineBackground GetRootAsSpineBackground(ByteBuffer _bb)
		{
			return SpineBackground.GetRootAsSpineBackground(_bb, default(SpineBackground));
		}

		// Token: 0x0600D812 RID: 55314 RVA: 0x0031E594 File Offset: 0x0031C794
		public static SpineBackground GetRootAsSpineBackground(ByteBuffer _bb, SpineBackground obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D813 RID: 55315 RVA: 0x0031E5B1 File Offset: 0x0031C7B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D814 RID: 55316 RVA: 0x0031E5C0 File Offset: 0x0031C7C0
		public SpineBackground __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x0600D815 RID: 55317 RVA: 0x0031E5D0 File Offset: 0x0031C7D0
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

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x0600D816 RID: 55318 RVA: 0x0031E60C File Offset: 0x0031C80C
		public string Remark
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

		// Token: 0x0600D817 RID: 55319 RVA: 0x0031E643 File Offset: 0x0031C843
		public Span<byte> GetRemarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D818 RID: 55320 RVA: 0x0031E652 File Offset: 0x0031C852
		public byte[] GetRemarkArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x0600D819 RID: 55321 RVA: 0x0031E66C File Offset: 0x0031C86C
		public string UiPrefabId
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

		// Token: 0x0600D81A RID: 55322 RVA: 0x0031E6A3 File Offset: 0x0031C8A3
		public Span<byte> GetUiPrefabIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D81B RID: 55323 RVA: 0x0031E6B2 File Offset: 0x0031C8B2
		public byte[] GetUiPrefabIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x0600D81C RID: 55324 RVA: 0x0031E6CC File Offset: 0x0031C8CC
		public string AnimationName
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

		// Token: 0x0600D81D RID: 55325 RVA: 0x0031E704 File Offset: 0x0031C904
		public Span<byte> GetAnimationNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D81E RID: 55326 RVA: 0x0031E714 File Offset: 0x0031C914
		public byte[] GetAnimationNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x0600D81F RID: 55327 RVA: 0x0031E72C File Offset: 0x0031C92C
		public string UiPrefabIdMaleVariant
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

		// Token: 0x0600D820 RID: 55328 RVA: 0x0031E764 File Offset: 0x0031C964
		public Span<byte> GetUiPrefabIdMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D821 RID: 55329 RVA: 0x0031E774 File Offset: 0x0031C974
		public byte[] GetUiPrefabIdMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x0600D822 RID: 55330 RVA: 0x0031E78C File Offset: 0x0031C98C
		public string AnimationNameMaleVariant
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

		// Token: 0x0600D823 RID: 55331 RVA: 0x0031E7C4 File Offset: 0x0031C9C4
		public Span<byte> GetAnimationNameMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D824 RID: 55332 RVA: 0x0031E7D4 File Offset: 0x0031C9D4
		public byte[] GetAnimationNameMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005215 RID: 21013
		private Table __p;
	}
}
