using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D9 RID: 4313
	public struct SoundBoxMark : IFlatbufferObject
	{
		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x0600D772 RID: 55154 RVA: 0x0031D06D File Offset: 0x0031B26D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D773 RID: 55155 RVA: 0x0031D07A File Offset: 0x0031B27A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D774 RID: 55156 RVA: 0x0031D084 File Offset: 0x0031B284
		public static SoundBoxMark GetRootAsSoundBoxMark(ByteBuffer _bb)
		{
			return SoundBoxMark.GetRootAsSoundBoxMark(_bb, default(SoundBoxMark));
		}

		// Token: 0x0600D775 RID: 55157 RVA: 0x0031D0A0 File Offset: 0x0031B2A0
		public static SoundBoxMark GetRootAsSoundBoxMark(ByteBuffer _bb, SoundBoxMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D776 RID: 55158 RVA: 0x0031D0BD File Offset: 0x0031B2BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D777 RID: 55159 RVA: 0x0031D0CC File Offset: 0x0031B2CC
		public SoundBoxMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x0600D778 RID: 55160 RVA: 0x0031D0DC File Offset: 0x0031B2DC
		public int MarkId
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

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x0600D779 RID: 55161 RVA: 0x0031D118 File Offset: 0x0031B318
		public string MarkPic
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

		// Token: 0x0600D77A RID: 55162 RVA: 0x0031D14F File Offset: 0x0031B34F
		public Span<byte> GetMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D77B RID: 55163 RVA: 0x0031D15E File Offset: 0x0031B35E
		public byte[] GetMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x0600D77C RID: 55164 RVA: 0x0031D178 File Offset: 0x0031B378
		public string MarkTitle
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

		// Token: 0x0600D77D RID: 55165 RVA: 0x0031D1AF File Offset: 0x0031B3AF
		public Span<byte> GetMarkTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D77E RID: 55166 RVA: 0x0031D1BE File Offset: 0x0031B3BE
		public byte[] GetMarkTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x0600D77F RID: 55167 RVA: 0x0031D1D8 File Offset: 0x0031B3D8
		public string MarkDesc
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

		// Token: 0x0600D780 RID: 55168 RVA: 0x0031D210 File Offset: 0x0031B410
		public Span<byte> GetMarkDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D781 RID: 55169 RVA: 0x0031D220 File Offset: 0x0031B420
		public byte[] GetMarkDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x0600D782 RID: 55170 RVA: 0x0031D238 File Offset: 0x0031B438
		public int ShowPriority
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D783 RID: 55171 RVA: 0x0031D278 File Offset: 0x0031B478
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x0600D784 RID: 55172 RVA: 0x0031D2B8 File Offset: 0x0031B4B8
		public int ShowRangeLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D785 RID: 55173 RVA: 0x0031D2E4 File Offset: 0x0031B4E4
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600D786 RID: 55174 RVA: 0x0031D2F4 File Offset: 0x0031B4F4
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x0600D787 RID: 55175 RVA: 0x0031D30C File Offset: 0x0031B50C
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D788 RID: 55176 RVA: 0x0031D350 File Offset: 0x0031B550
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowRangeIter()或GetShowRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowRange()
		{
			SoundBoxMark soundBoxMark = this;
			return soundBoxMark.GetShowRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D789 RID: 55177 RVA: 0x0031D374 File Offset: 0x0031B574
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowRangeIter()
		{
			SoundBoxMark.<ShowRangeIter>d__32 <ShowRangeIter>d__ = new SoundBoxMark.<ShowRangeIter>d__32(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x0400520C RID: 21004
		private Table __p;
	}
}
