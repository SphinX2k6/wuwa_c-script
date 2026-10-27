using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB7 RID: 3511
	public struct KurotatoWaveLevel : IFlatbufferObject
	{
		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x06008C07 RID: 35847 RVA: 0x00273531 File Offset: 0x00271731
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008C08 RID: 35848 RVA: 0x0027353E File Offset: 0x0027173E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008C09 RID: 35849 RVA: 0x00273548 File Offset: 0x00271748
		public static KurotatoWaveLevel GetRootAsKurotatoWaveLevel(ByteBuffer _bb)
		{
			return KurotatoWaveLevel.GetRootAsKurotatoWaveLevel(_bb, default(KurotatoWaveLevel));
		}

		// Token: 0x06008C0A RID: 35850 RVA: 0x00273564 File Offset: 0x00271764
		public static KurotatoWaveLevel GetRootAsKurotatoWaveLevel(ByteBuffer _bb, KurotatoWaveLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008C0B RID: 35851 RVA: 0x00273581 File Offset: 0x00271781
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008C0C RID: 35852 RVA: 0x00273590 File Offset: 0x00271790
		public KurotatoWaveLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x06008C0D RID: 35853 RVA: 0x002735A0 File Offset: 0x002717A0
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

		// Token: 0x06008C0E RID: 35854 RVA: 0x002735DC File Offset: 0x002717DC
		public int WaveRange(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06008C0F RID: 35855 RVA: 0x0027361C File Offset: 0x0027181C
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

		// Token: 0x06008C10 RID: 35856 RVA: 0x00273647 File Offset: 0x00271847
		public Span<int> GetWaveRangeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008C11 RID: 35857 RVA: 0x00273656 File Offset: 0x00271856
		public int[] GetWaveRangeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06008C12 RID: 35858 RVA: 0x00273670 File Offset: 0x00271870
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

		// Token: 0x06008C13 RID: 35859 RVA: 0x002736A7 File Offset: 0x002718A7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008C14 RID: 35860 RVA: 0x002736B6 File Offset: 0x002718B6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06008C15 RID: 35861 RVA: 0x002736D0 File Offset: 0x002718D0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaveRangeIter()或GetWaveRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WaveRange()
		{
			KurotatoWaveLevel kurotatoWaveLevel = this;
			return kurotatoWaveLevel.GetWaveRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008C16 RID: 35862 RVA: 0x002736F4 File Offset: 0x002718F4
		[NullableContext(1)]
		public readonly IEnumerable<int> WaveRangeIter()
		{
			KurotatoWaveLevel.<WaveRangeIter>d__20 <WaveRangeIter>d__ = new KurotatoWaveLevel.<WaveRangeIter>d__20(-2);
			<WaveRangeIter>d__.<>3__<>4__this = this;
			return <WaveRangeIter>d__;
		}

		// Token: 0x04004E4B RID: 20043
		private Table __p;
	}
}
