using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E9C RID: 3740
	public struct KurotatoWaveLevel : IFlatbufferObject
	{
		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x06009223 RID: 37411 RVA: 0x00291DBB File Offset: 0x0028FFBB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009224 RID: 37412 RVA: 0x00291DC8 File Offset: 0x0028FFC8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009225 RID: 37413 RVA: 0x00291DD0 File Offset: 0x0028FFD0
		public static KurotatoWaveLevel GetRootAsKurotatoWaveLevel(ByteBuffer _bb)
		{
			return KurotatoWaveLevel.GetRootAsKurotatoWaveLevel(_bb, default(KurotatoWaveLevel));
		}

		// Token: 0x06009226 RID: 37414 RVA: 0x00291DEC File Offset: 0x0028FFEC
		public static KurotatoWaveLevel GetRootAsKurotatoWaveLevel(ByteBuffer _bb, KurotatoWaveLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009227 RID: 37415 RVA: 0x00291E09 File Offset: 0x00290009
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009228 RID: 37416 RVA: 0x00291E18 File Offset: 0x00290018
		public KurotatoWaveLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x06009229 RID: 37417 RVA: 0x00291E28 File Offset: 0x00290028
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

		// Token: 0x0600922A RID: 37418 RVA: 0x00291E64 File Offset: 0x00290064
		public int WaveRange(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x0600922B RID: 37419 RVA: 0x00291EA4 File Offset: 0x002900A4
		public int WaveRangeLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600922C RID: 37420 RVA: 0x00291ECF File Offset: 0x002900CF
		public Span<int> GetWaveRangeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600922D RID: 37421 RVA: 0x00291EDE File Offset: 0x002900DE
		public int[] GetWaveRangeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x0600922E RID: 37422 RVA: 0x00291EF8 File Offset: 0x002900F8
		public string Icon
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

		// Token: 0x0600922F RID: 37423 RVA: 0x00291F2F File Offset: 0x0029012F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009230 RID: 37424 RVA: 0x00291F3E File Offset: 0x0029013E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06009231 RID: 37425 RVA: 0x00291F55 File Offset: 0x00290155
		[NullableContext(1)]
		public int[] WaveRange()
		{
			return this.GetWaveRangeArray();
		}

		// Token: 0x06009232 RID: 37426 RVA: 0x00291F5D File Offset: 0x0029015D
		[NullableContext(1)]
		public IEnumerable<int> WaveRangeIter()
		{
			KurotatoWaveLevel.<WaveRangeIter>d__20 <WaveRangeIter>d__ = new KurotatoWaveLevel.<WaveRangeIter>d__20(-2);
			<WaveRangeIter>d__.<>3__<>4__this = this;
			return <WaveRangeIter>d__;
		}

		// Token: 0x04005430 RID: 21552
		private Table __p;
	}
}
