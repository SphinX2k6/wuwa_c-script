using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001186 RID: 4486
	public struct UiResource : IFlatbufferObject
	{
		// Token: 0x17003D42 RID: 15682
		// (get) Token: 0x0600E65A RID: 58970 RVA: 0x0033EE0D File Offset: 0x0033D00D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E65B RID: 58971 RVA: 0x0033EE1A File Offset: 0x0033D01A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E65C RID: 58972 RVA: 0x0033EE24 File Offset: 0x0033D024
		public static UiResource GetRootAsUiResource(ByteBuffer _bb)
		{
			return UiResource.GetRootAsUiResource(_bb, default(UiResource));
		}

		// Token: 0x0600E65D RID: 58973 RVA: 0x0033EE40 File Offset: 0x0033D040
		public static UiResource GetRootAsUiResource(ByteBuffer _bb, UiResource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E65E RID: 58974 RVA: 0x0033EE5D File Offset: 0x0033D05D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E65F RID: 58975 RVA: 0x0033EE6C File Offset: 0x0033D06C
		public UiResource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D43 RID: 15683
		// (get) Token: 0x0600E660 RID: 58976 RVA: 0x0033EE7C File Offset: 0x0033D07C
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E661 RID: 58977 RVA: 0x0033EEB3 File Offset: 0x0033D0B3
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600E662 RID: 58978 RVA: 0x0033EEC2 File Offset: 0x0033D0C2
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D44 RID: 15684
		// (get) Token: 0x0600E663 RID: 58979 RVA: 0x0033EEDC File Offset: 0x0033D0DC
		public string Path
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

		// Token: 0x0600E664 RID: 58980 RVA: 0x0033EF13 File Offset: 0x0033D113
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E665 RID: 58981 RVA: 0x0033EF22 File Offset: 0x0033D122
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D45 RID: 15685
		// (get) Token: 0x0600E666 RID: 58982 RVA: 0x0033EF3C File Offset: 0x0033D13C
		public string PcPath
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

		// Token: 0x0600E667 RID: 58983 RVA: 0x0033EF73 File Offset: 0x0033D173
		public Span<byte> GetPcPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E668 RID: 58984 RVA: 0x0033EF82 File Offset: 0x0033D182
		public byte[] GetPcPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D46 RID: 15686
		// (get) Token: 0x0600E669 RID: 58985 RVA: 0x0033EF9C File Offset: 0x0033D19C
		public string ResourceType
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

		// Token: 0x0600E66A RID: 58986 RVA: 0x0033EFD4 File Offset: 0x0033D1D4
		public Span<byte> GetResourceTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E66B RID: 58987 RVA: 0x0033EFE4 File Offset: 0x0033D1E4
		public byte[] GetResourceTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E66C RID: 58988 RVA: 0x0033EFFC File Offset: 0x0033D1FC
		public string ActivityType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D47 RID: 15687
		// (get) Token: 0x0600E66D RID: 58989 RVA: 0x0033F038 File Offset: 0x0033D238
		public int ActivityTypeLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E66E RID: 58990 RVA: 0x0033F064 File Offset: 0x0033D264
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ActivityTypeIter()或GetActivityTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ActivityType()
		{
			return this.ActivityTypeIter().ToArray<string>();
		}

		// Token: 0x0600E66F RID: 58991 RVA: 0x0033F071 File Offset: 0x0033D271
		[NullableContext(1)]
		public readonly IEnumerable<string> ActivityTypeIter()
		{
			UiResource.<ActivityTypeIter>d__28 <ActivityTypeIter>d__ = new UiResource.<ActivityTypeIter>d__28(-2);
			<ActivityTypeIter>d__.<>3__<>4__this = this;
			return <ActivityTypeIter>d__;
		}

		// Token: 0x040052CF RID: 21199
		private Table __p;
	}
}
