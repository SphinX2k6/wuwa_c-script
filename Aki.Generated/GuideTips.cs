using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D1C RID: 3356
	public struct GuideTips : IFlatbufferObject
	{
		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06007D39 RID: 32057 RVA: 0x0025157C File Offset: 0x0024F77C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007D3A RID: 32058 RVA: 0x00251589 File Offset: 0x0024F789
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007D3B RID: 32059 RVA: 0x00251590 File Offset: 0x0024F790
		public static GuideTips GetRootAsGuideTips(ByteBuffer _bb)
		{
			return GuideTips.GetRootAsGuideTips(_bb, default(GuideTips));
		}

		// Token: 0x06007D3C RID: 32060 RVA: 0x002515AC File Offset: 0x0024F7AC
		public static GuideTips GetRootAsGuideTips(ByteBuffer _bb, GuideTips obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007D3D RID: 32061 RVA: 0x002515C9 File Offset: 0x0024F7C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007D3E RID: 32062 RVA: 0x002515D8 File Offset: 0x0024F7D8
		public GuideTips __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06007D3F RID: 32063 RVA: 0x002515E8 File Offset: 0x0024F7E8
		public int GuideId
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

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06007D40 RID: 32064 RVA: 0x00251624 File Offset: 0x0024F824
		public string Content
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

		// Token: 0x06007D41 RID: 32065 RVA: 0x0025165B File Offset: 0x0024F85B
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007D42 RID: 32066 RVA: 0x0025166A File Offset: 0x0024F86A
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06007D43 RID: 32067 RVA: 0x00251684 File Offset: 0x0024F884
		public string Button(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06007D44 RID: 32068 RVA: 0x002516C0 File Offset: 0x0024F8C0
		public int ButtonLength
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

		// Token: 0x06007D45 RID: 32069 RVA: 0x002516EC File Offset: 0x0024F8EC
		public string InputEnums(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x06007D46 RID: 32070 RVA: 0x00251728 File Offset: 0x0024F928
		public int InputEnumsLength
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

		// Token: 0x06007D47 RID: 32071 RVA: 0x00251754 File Offset: 0x0024F954
		public string LimitInputEnums(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x06007D48 RID: 32072 RVA: 0x00251790 File Offset: 0x0024F990
		public int LimitInputEnumsLength
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

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x06007D49 RID: 32073 RVA: 0x002517BC File Offset: 0x0024F9BC
		public bool UseLoopAnim
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06007D4A RID: 32074 RVA: 0x002517FC File Offset: 0x0024F9FC
		public int UseMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007D4B RID: 32075 RVA: 0x00251839 File Offset: 0x0024FA39
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ButtonIter()或GetButtonBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Button()
		{
			return this.ButtonIter().ToArray<string>();
		}

		// Token: 0x06007D4C RID: 32076 RVA: 0x00251846 File Offset: 0x0024FA46
		[NullableContext(1)]
		public readonly IEnumerable<string> ButtonIter()
		{
			GuideTips.<ButtonIter>d__28 <ButtonIter>d__ = new GuideTips.<ButtonIter>d__28(-2);
			<ButtonIter>d__.<>3__<>4__this = this;
			return <ButtonIter>d__;
		}

		// Token: 0x06007D4D RID: 32077 RVA: 0x0025185B File Offset: 0x0024FA5B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InputEnumsIter()或GetInputEnumsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] InputEnums()
		{
			return this.InputEnumsIter().ToArray<string>();
		}

		// Token: 0x06007D4E RID: 32078 RVA: 0x00251868 File Offset: 0x0024FA68
		[NullableContext(1)]
		public readonly IEnumerable<string> InputEnumsIter()
		{
			GuideTips.<InputEnumsIter>d__30 <InputEnumsIter>d__ = new GuideTips.<InputEnumsIter>d__30(-2);
			<InputEnumsIter>d__.<>3__<>4__this = this;
			return <InputEnumsIter>d__;
		}

		// Token: 0x06007D4F RID: 32079 RVA: 0x0025187D File Offset: 0x0024FA7D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LimitInputEnumsIter()或GetLimitInputEnumsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] LimitInputEnums()
		{
			return this.LimitInputEnumsIter().ToArray<string>();
		}

		// Token: 0x06007D50 RID: 32080 RVA: 0x0025188A File Offset: 0x0024FA8A
		[NullableContext(1)]
		public readonly IEnumerable<string> LimitInputEnumsIter()
		{
			GuideTips.<LimitInputEnumsIter>d__32 <LimitInputEnumsIter>d__ = new GuideTips.<LimitInputEnumsIter>d__32(-2);
			<LimitInputEnumsIter>d__.<>3__<>4__this = this;
			return <LimitInputEnumsIter>d__;
		}

		// Token: 0x04004D94 RID: 19860
		private Table __p;
	}
}
