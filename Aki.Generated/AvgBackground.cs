using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BED RID: 3053
	public struct AvgBackground : IFlatbufferObject
	{
		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06004F18 RID: 20248 RVA: 0x001FA080 File Offset: 0x001F8280
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x001FA08D File Offset: 0x001F828D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x001FA094 File Offset: 0x001F8294
		public static AvgBackground GetRootAsAvgBackground(ByteBuffer _bb)
		{
			return AvgBackground.GetRootAsAvgBackground(_bb, default(AvgBackground));
		}

		// Token: 0x06004F1B RID: 20251 RVA: 0x001FA0B0 File Offset: 0x001F82B0
		public static AvgBackground GetRootAsAvgBackground(ByteBuffer _bb, AvgBackground obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x001FA0CD File Offset: 0x001F82CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x001FA0DC File Offset: 0x001F82DC
		public AvgBackground __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06004F1E RID: 20254 RVA: 0x001FA0EC File Offset: 0x001F82EC
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

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06004F1F RID: 20255 RVA: 0x001FA128 File Offset: 0x001F8328
		public string Description
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

		// Token: 0x06004F20 RID: 20256 RVA: 0x001FA15F File Offset: 0x001F835F
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x001FA16E File Offset: 0x001F836E
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06004F22 RID: 20258 RVA: 0x001FA188 File Offset: 0x001F8388
		public string DayPicPath
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

		// Token: 0x06004F23 RID: 20259 RVA: 0x001FA1BF File Offset: 0x001F83BF
		public Span<byte> GetDayPicPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x001FA1CE File Offset: 0x001F83CE
		public byte[] GetDayPicPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06004F25 RID: 20261 RVA: 0x001FA1E8 File Offset: 0x001F83E8
		public string NightPicPath
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

		// Token: 0x06004F26 RID: 20262 RVA: 0x001FA220 File Offset: 0x001F8420
		public Span<byte> GetNightPicPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x001FA230 File Offset: 0x001F8430
		public byte[] GetNightPicPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040050D5 RID: 20693
		private Table __p;
	}
}
