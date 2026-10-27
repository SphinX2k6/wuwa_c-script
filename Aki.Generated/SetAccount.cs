using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001097 RID: 4247
	public struct SetAccount : IFlatbufferObject
	{
		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x0600D035 RID: 53301 RVA: 0x0030B489 File Offset: 0x00309689
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D036 RID: 53302 RVA: 0x0030B496 File Offset: 0x00309696
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D037 RID: 53303 RVA: 0x0030B4A0 File Offset: 0x003096A0
		public static SetAccount GetRootAsSetAccount(ByteBuffer _bb)
		{
			return SetAccount.GetRootAsSetAccount(_bb, default(SetAccount));
		}

		// Token: 0x0600D038 RID: 53304 RVA: 0x0030B4BC File Offset: 0x003096BC
		public static SetAccount GetRootAsSetAccount(ByteBuffer _bb, SetAccount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D039 RID: 53305 RVA: 0x0030B4D9 File Offset: 0x003096D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D03A RID: 53306 RVA: 0x0030B4E8 File Offset: 0x003096E8
		public SetAccount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003529 RID: 13609
		// (get) Token: 0x0600D03B RID: 53307 RVA: 0x0030B4F8 File Offset: 0x003096F8
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

		// Token: 0x1700352A RID: 13610
		// (get) Token: 0x0600D03C RID: 53308 RVA: 0x0030B534 File Offset: 0x00309734
		public int PackageType
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

		// Token: 0x0600D03D RID: 53309 RVA: 0x0030B570 File Offset: 0x00309770
		public string Language(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700352B RID: 13611
		// (get) Token: 0x0600D03E RID: 53310 RVA: 0x0030B5AC File Offset: 0x003097AC
		public int LanguageLength
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

		// Token: 0x0600D03F RID: 53311 RVA: 0x0030B5D8 File Offset: 0x003097D8
		public string PackageId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700352C RID: 13612
		// (get) Token: 0x0600D040 RID: 53312 RVA: 0x0030B614 File Offset: 0x00309814
		public int PackageIdLength
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

		// Token: 0x0600D041 RID: 53313 RVA: 0x0030B640 File Offset: 0x00309840
		public int Channel(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700352D RID: 13613
		// (get) Token: 0x0600D042 RID: 53314 RVA: 0x0030B680 File Offset: 0x00309880
		public int ChannelLength
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

		// Token: 0x0600D043 RID: 53315 RVA: 0x0030B6AC File Offset: 0x003098AC
		public Span<int> GetChannelBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600D044 RID: 53316 RVA: 0x0030B6BC File Offset: 0x003098BC
		public int[] GetChannelArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x1700352E RID: 13614
		// (get) Token: 0x0600D045 RID: 53317 RVA: 0x0030B6D4 File Offset: 0x003098D4
		public string Adress
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

		// Token: 0x0600D046 RID: 53318 RVA: 0x0030B70C File Offset: 0x0030990C
		public Span<byte> GetAdressBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D047 RID: 53319 RVA: 0x0030B71C File Offset: 0x0030991C
		public byte[] GetAdressArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D048 RID: 53320 RVA: 0x0030B734 File Offset: 0x00309934
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ChannelIter()或GetChannelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Channel()
		{
			SetAccount setAccount = this;
			return setAccount.GetChannelArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D049 RID: 53321 RVA: 0x0030B758 File Offset: 0x00309958
		[NullableContext(1)]
		public readonly IEnumerable<int> ChannelIter()
		{
			SetAccount.<ChannelIter>d__28 <ChannelIter>d__ = new SetAccount.<ChannelIter>d__28(-2);
			<ChannelIter>d__.<>3__<>4__this = this;
			return <ChannelIter>d__;
		}

		// Token: 0x0600D04A RID: 53322 RVA: 0x0030B76D File Offset: 0x0030996D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LanguageIter()或GetLanguageBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Language()
		{
			return this.LanguageIter().ToArray<string>();
		}

		// Token: 0x0600D04B RID: 53323 RVA: 0x0030B77A File Offset: 0x0030997A
		[NullableContext(1)]
		public readonly IEnumerable<string> LanguageIter()
		{
			SetAccount.<LanguageIter>d__30 <LanguageIter>d__ = new SetAccount.<LanguageIter>d__30(-2);
			<LanguageIter>d__.<>3__<>4__this = this;
			return <LanguageIter>d__;
		}

		// Token: 0x0600D04C RID: 53324 RVA: 0x0030B78F File Offset: 0x0030998F
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PackageIdIter()或GetPackageIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] PackageId()
		{
			return this.PackageIdIter().ToArray<string>();
		}

		// Token: 0x0600D04D RID: 53325 RVA: 0x0030B79C File Offset: 0x0030999C
		[NullableContext(1)]
		public readonly IEnumerable<string> PackageIdIter()
		{
			SetAccount.<PackageIdIter>d__32 <PackageIdIter>d__ = new SetAccount.<PackageIdIter>d__32(-2);
			<PackageIdIter>d__.<>3__<>4__this = this;
			return <PackageIdIter>d__;
		}

		// Token: 0x040051A4 RID: 20900
		private Table __p;
	}
}
