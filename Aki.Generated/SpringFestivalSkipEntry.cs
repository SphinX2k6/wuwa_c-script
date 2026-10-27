using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010EC RID: 4332
	public struct SpringFestivalSkipEntry : IFlatbufferObject
	{
		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x0600D8F1 RID: 55537 RVA: 0x003205F5 File Offset: 0x0031E7F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D8F2 RID: 55538 RVA: 0x00320602 File Offset: 0x0031E802
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D8F3 RID: 55539 RVA: 0x0032060C File Offset: 0x0031E80C
		public static SpringFestivalSkipEntry GetRootAsSpringFestivalSkipEntry(ByteBuffer _bb)
		{
			return SpringFestivalSkipEntry.GetRootAsSpringFestivalSkipEntry(_bb, default(SpringFestivalSkipEntry));
		}

		// Token: 0x0600D8F4 RID: 55540 RVA: 0x00320628 File Offset: 0x0031E828
		public static SpringFestivalSkipEntry GetRootAsSpringFestivalSkipEntry(ByteBuffer _bb, SpringFestivalSkipEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D8F5 RID: 55541 RVA: 0x00320645 File Offset: 0x0031E845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D8F6 RID: 55542 RVA: 0x00320654 File Offset: 0x0031E854
		public SpringFestivalSkipEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x0600D8F7 RID: 55543 RVA: 0x00320664 File Offset: 0x0031E864
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

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x0600D8F8 RID: 55544 RVA: 0x003206A0 File Offset: 0x0031E8A0
		public int Activity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x0600D8F9 RID: 55545 RVA: 0x003206DC File Offset: 0x0031E8DC
		public string Name
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

		// Token: 0x0600D8FA RID: 55546 RVA: 0x00320713 File Offset: 0x0031E913
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D8FB RID: 55547 RVA: 0x00320722 File Offset: 0x0031E922
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x0600D8FC RID: 55548 RVA: 0x0032073C File Offset: 0x0031E93C
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x0600D8FD RID: 55549 RVA: 0x0032077C File Offset: 0x0031E97C
		public int FinishCondition
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

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x0600D8FE RID: 55550 RVA: 0x003207BC File Offset: 0x0031E9BC
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D8FF RID: 55551 RVA: 0x003207FC File Offset: 0x0031E9FC
		public int TrackPosition(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x0600D900 RID: 55552 RVA: 0x0032083C File Offset: 0x0031EA3C
		public int TrackPositionLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D901 RID: 55553 RVA: 0x00320868 File Offset: 0x0031EA68
		public Span<int> GetTrackPositionBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600D902 RID: 55554 RVA: 0x00320878 File Offset: 0x0031EA78
		public int[] GetTrackPositionArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x0600D903 RID: 55555 RVA: 0x00320890 File Offset: 0x0031EA90
		public string TrackIconPath
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

		// Token: 0x0600D904 RID: 55556 RVA: 0x003208C8 File Offset: 0x0031EAC8
		public Span<byte> GetTrackIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D905 RID: 55557 RVA: 0x003208D8 File Offset: 0x0031EAD8
		public byte[] GetTrackIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x0600D906 RID: 55558 RVA: 0x003208F0 File Offset: 0x0031EAF0
		public bool IsTeleport
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600D907 RID: 55559 RVA: 0x00320930 File Offset: 0x0031EB30
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TrackPositionIter()或GetTrackPositionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TrackPosition()
		{
			SpringFestivalSkipEntry springFestivalSkipEntry = this;
			return springFestivalSkipEntry.GetTrackPositionArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D908 RID: 55560 RVA: 0x00320954 File Offset: 0x0031EB54
		[NullableContext(1)]
		public readonly IEnumerable<int> TrackPositionIter()
		{
			SpringFestivalSkipEntry.<TrackPositionIter>d__34 <TrackPositionIter>d__ = new SpringFestivalSkipEntry.<TrackPositionIter>d__34(-2);
			<TrackPositionIter>d__.<>3__<>4__this = this;
			return <TrackPositionIter>d__;
		}

		// Token: 0x04005220 RID: 21024
		private Table __p;
	}
}
