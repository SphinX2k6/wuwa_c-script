using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CCA RID: 3274
	public struct FoleySynthConfig : IFlatbufferObject
	{
		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x06007648 RID: 30280 RVA: 0x00241C7D File Offset: 0x0023FE7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007649 RID: 30281 RVA: 0x00241C8A File Offset: 0x0023FE8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600764A RID: 30282 RVA: 0x00241C94 File Offset: 0x0023FE94
		public static FoleySynthConfig GetRootAsFoleySynthConfig(ByteBuffer _bb)
		{
			return FoleySynthConfig.GetRootAsFoleySynthConfig(_bb, default(FoleySynthConfig));
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x00241CB0 File Offset: 0x0023FEB0
		public static FoleySynthConfig GetRootAsFoleySynthConfig(ByteBuffer _bb, FoleySynthConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600764C RID: 30284 RVA: 0x00241CCD File Offset: 0x0023FECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x00241CDC File Offset: 0x0023FEDC
		public FoleySynthConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x0600764E RID: 30286 RVA: 0x00241CEC File Offset: 0x0023FEEC
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

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x0600764F RID: 30287 RVA: 0x00241D28 File Offset: 0x0023FF28
		public string Name
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

		// Token: 0x06007650 RID: 30288 RVA: 0x00241D5F File Offset: 0x0023FF5F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007651 RID: 30289 RVA: 0x00241D6E File Offset: 0x0023FF6E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06007652 RID: 30290 RVA: 0x00241D88 File Offset: 0x0023FF88
		public int Model1Config(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x06007653 RID: 30291 RVA: 0x00241DC8 File Offset: 0x0023FFC8
		public int Model1ConfigLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x00241DF3 File Offset: 0x0023FFF3
		public Span<int> GetModel1ConfigBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007655 RID: 30293 RVA: 0x00241E02 File Offset: 0x00240002
		public int[] GetModel1ConfigArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06007656 RID: 30294 RVA: 0x00241E1C File Offset: 0x0024001C
		public int Model2Config(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x06007657 RID: 30295 RVA: 0x00241E5C File Offset: 0x0024005C
		public int Model2ConfigLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007658 RID: 30296 RVA: 0x00241E88 File Offset: 0x00240088
		public Span<int> GetModel2ConfigBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06007659 RID: 30297 RVA: 0x00241E98 File Offset: 0x00240098
		public int[] GetModel2ConfigArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x0600765A RID: 30298 RVA: 0x00241EB0 File Offset: 0x002400B0
		public int Model2AccMaxCount
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x0600765B RID: 30299 RVA: 0x00241EF0 File Offset: 0x002400F0
		public int Model2VelMaxCount
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 5;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x00241F30 File Offset: 0x00240130
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Model1ConfigIter()或GetModel1ConfigBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Model1Config()
		{
			FoleySynthConfig foleySynthConfig = this;
			return foleySynthConfig.GetModel1ConfigArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x00241F54 File Offset: 0x00240154
		[NullableContext(1)]
		public readonly IEnumerable<int> Model1ConfigIter()
		{
			FoleySynthConfig.<Model1ConfigIter>d__29 <Model1ConfigIter>d__ = new FoleySynthConfig.<Model1ConfigIter>d__29(-2);
			<Model1ConfigIter>d__.<>3__<>4__this = this;
			return <Model1ConfigIter>d__;
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x00241F6C File Offset: 0x0024016C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Model2ConfigIter()或GetModel2ConfigBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Model2Config()
		{
			FoleySynthConfig foleySynthConfig = this;
			return foleySynthConfig.GetModel2ConfigArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x00241F90 File Offset: 0x00240190
		[NullableContext(1)]
		public readonly IEnumerable<int> Model2ConfigIter()
		{
			FoleySynthConfig.<Model2ConfigIter>d__31 <Model2ConfigIter>d__ = new FoleySynthConfig.<Model2ConfigIter>d__31(-2);
			<Model2ConfigIter>d__.<>3__<>4__this = this;
			return <Model2ConfigIter>d__;
		}

		// Token: 0x04004D3A RID: 19770
		private Table __p;
	}
}
