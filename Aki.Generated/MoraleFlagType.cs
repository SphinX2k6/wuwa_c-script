using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E24 RID: 3620
	public struct MoraleFlagType : IFlatbufferObject
	{
		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x06009603 RID: 38403 RVA: 0x00289889 File Offset: 0x00287A89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009604 RID: 38404 RVA: 0x00289896 File Offset: 0x00287A96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009605 RID: 38405 RVA: 0x002898A0 File Offset: 0x00287AA0
		public static MoraleFlagType GetRootAsMoraleFlagType(ByteBuffer _bb)
		{
			return MoraleFlagType.GetRootAsMoraleFlagType(_bb, default(MoraleFlagType));
		}

		// Token: 0x06009606 RID: 38406 RVA: 0x002898BC File Offset: 0x00287ABC
		public static MoraleFlagType GetRootAsMoraleFlagType(ByteBuffer _bb, MoraleFlagType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009607 RID: 38407 RVA: 0x002898D9 File Offset: 0x00287AD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009608 RID: 38408 RVA: 0x002898E8 File Offset: 0x00287AE8
		public MoraleFlagType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x06009609 RID: 38409 RVA: 0x002898F8 File Offset: 0x00287AF8
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

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x0600960A RID: 38410 RVA: 0x00289934 File Offset: 0x00287B34
		public int TypeId
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

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x0600960B RID: 38411 RVA: 0x00289970 File Offset: 0x00287B70
		public int ShowUiMap
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600960C RID: 38412 RVA: 0x002899AC File Offset: 0x00287BAC
		public string IconPathNormal(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x0600960D RID: 38413 RVA: 0x002899E8 File Offset: 0x00287BE8
		public int IconPathNormalLength
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

		// Token: 0x0600960E RID: 38414 RVA: 0x00289A14 File Offset: 0x00287C14
		public string IconPathActive(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x0600960F RID: 38415 RVA: 0x00289A50 File Offset: 0x00287C50
		public int IconPathActiveLength
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

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x06009610 RID: 38416 RVA: 0x00289A7C File Offset: 0x00287C7C
		public string ResId
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

		// Token: 0x06009611 RID: 38417 RVA: 0x00289AB4 File Offset: 0x00287CB4
		public Span<byte> GetResIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009612 RID: 38418 RVA: 0x00289AC4 File Offset: 0x00287CC4
		public byte[] GetResIdArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x06009613 RID: 38419 RVA: 0x00289ADC File Offset: 0x00287CDC
		public string DescLightPath
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009614 RID: 38420 RVA: 0x00289B14 File Offset: 0x00287D14
		public Span<byte> GetDescLightPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009615 RID: 38421 RVA: 0x00289B24 File Offset: 0x00287D24
		public byte[] GetDescLightPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06009616 RID: 38422 RVA: 0x00289B3C File Offset: 0x00287D3C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IconPathActiveIter()或GetIconPathActiveBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] IconPathActive()
		{
			return this.IconPathActiveIter().ToArray<string>();
		}

		// Token: 0x06009617 RID: 38423 RVA: 0x00289B49 File Offset: 0x00287D49
		[NullableContext(1)]
		public readonly IEnumerable<string> IconPathActiveIter()
		{
			MoraleFlagType.<IconPathActiveIter>d__29 <IconPathActiveIter>d__ = new MoraleFlagType.<IconPathActiveIter>d__29(-2);
			<IconPathActiveIter>d__.<>3__<>4__this = this;
			return <IconPathActiveIter>d__;
		}

		// Token: 0x06009618 RID: 38424 RVA: 0x00289B5E File Offset: 0x00287D5E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IconPathNormalIter()或GetIconPathNormalBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] IconPathNormal()
		{
			return this.IconPathNormalIter().ToArray<string>();
		}

		// Token: 0x06009619 RID: 38425 RVA: 0x00289B6B File Offset: 0x00287D6B
		[NullableContext(1)]
		public readonly IEnumerable<string> IconPathNormalIter()
		{
			MoraleFlagType.<IconPathNormalIter>d__31 <IconPathNormalIter>d__ = new MoraleFlagType.<IconPathNormalIter>d__31(-2);
			<IconPathNormalIter>d__.<>3__<>4__this = this;
			return <IconPathNormalIter>d__;
		}

		// Token: 0x04004EC9 RID: 20169
		private Table __p;
	}
}
