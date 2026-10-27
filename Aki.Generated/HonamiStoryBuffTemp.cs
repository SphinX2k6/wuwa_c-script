using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D31 RID: 3377
	public struct HonamiStoryBuffTemp : IFlatbufferObject
	{
		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x06007F2B RID: 32555 RVA: 0x00255C69 File Offset: 0x00253E69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F2C RID: 32556 RVA: 0x00255C76 File Offset: 0x00253E76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F2D RID: 32557 RVA: 0x00255C80 File Offset: 0x00253E80
		public static HonamiStoryBuffTemp GetRootAsHonamiStoryBuffTemp(ByteBuffer _bb)
		{
			return HonamiStoryBuffTemp.GetRootAsHonamiStoryBuffTemp(_bb, default(HonamiStoryBuffTemp));
		}

		// Token: 0x06007F2E RID: 32558 RVA: 0x00255C9C File Offset: 0x00253E9C
		public static HonamiStoryBuffTemp GetRootAsHonamiStoryBuffTemp(ByteBuffer _bb, HonamiStoryBuffTemp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F2F RID: 32559 RVA: 0x00255CB9 File Offset: 0x00253EB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F30 RID: 32560 RVA: 0x00255CC8 File Offset: 0x00253EC8
		public HonamiStoryBuffTemp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06007F31 RID: 32561 RVA: 0x00255CD8 File Offset: 0x00253ED8
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

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06007F32 RID: 32562 RVA: 0x00255D14 File Offset: 0x00253F14
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

		// Token: 0x06007F33 RID: 32563 RVA: 0x00255D4B File Offset: 0x00253F4B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007F34 RID: 32564 RVA: 0x00255D5A File Offset: 0x00253F5A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06007F35 RID: 32565 RVA: 0x00255D74 File Offset: 0x00253F74
		public string Desc
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

		// Token: 0x06007F36 RID: 32566 RVA: 0x00255DAB File Offset: 0x00253FAB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007F37 RID: 32567 RVA: 0x00255DBA File Offset: 0x00253FBA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06007F38 RID: 32568 RVA: 0x00255DD4 File Offset: 0x00253FD4
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06007F39 RID: 32569 RVA: 0x00255E10 File Offset: 0x00254010
		public int DescArgsLength
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

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06007F3A RID: 32570 RVA: 0x00255E3C File Offset: 0x0025403C
		public string DescSimple
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

		// Token: 0x06007F3B RID: 32571 RVA: 0x00255E74 File Offset: 0x00254074
		public Span<byte> GetDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007F3C RID: 32572 RVA: 0x00255E84 File Offset: 0x00254084
		public byte[] GetDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06007F3D RID: 32573 RVA: 0x00255E9C File Offset: 0x0025409C
		public string DescSimpleArgs(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06007F3E RID: 32574 RVA: 0x00255ED8 File Offset: 0x002540D8
		public int DescSimpleArgsLength
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

		// Token: 0x06007F3F RID: 32575 RVA: 0x00255F04 File Offset: 0x00254104
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescArgsIter()或GetDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x06007F40 RID: 32576 RVA: 0x00255F11 File Offset: 0x00254111
		[NullableContext(1)]
		public readonly IEnumerable<string> DescArgsIter()
		{
			HonamiStoryBuffTemp.<DescArgsIter>d__29 <DescArgsIter>d__ = new HonamiStoryBuffTemp.<DescArgsIter>d__29(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x06007F41 RID: 32577 RVA: 0x00255F26 File Offset: 0x00254126
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescSimpleArgsIter()或GetDescSimpleArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescSimpleArgs()
		{
			return this.DescSimpleArgsIter().ToArray<string>();
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x00255F33 File Offset: 0x00254133
		[NullableContext(1)]
		public readonly IEnumerable<string> DescSimpleArgsIter()
		{
			HonamiStoryBuffTemp.<DescSimpleArgsIter>d__31 <DescSimpleArgsIter>d__ = new HonamiStoryBuffTemp.<DescSimpleArgsIter>d__31(-2);
			<DescSimpleArgsIter>d__.<>3__<>4__this = this;
			return <DescSimpleArgsIter>d__;
		}

		// Token: 0x04004DAA RID: 19882
		private Table __p;
	}
}
