using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FDC RID: 4060
	public struct RogueCharacterBuff : IFlatbufferObject
	{
		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x0600BE84 RID: 48772 RVA: 0x002E3BD5 File Offset: 0x002E1DD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE85 RID: 48773 RVA: 0x002E3BE2 File Offset: 0x002E1DE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE86 RID: 48774 RVA: 0x002E3BEC File Offset: 0x002E1DEC
		public static RogueCharacterBuff GetRootAsRogueCharacterBuff(ByteBuffer _bb)
		{
			return RogueCharacterBuff.GetRootAsRogueCharacterBuff(_bb, default(RogueCharacterBuff));
		}

		// Token: 0x0600BE87 RID: 48775 RVA: 0x002E3C08 File Offset: 0x002E1E08
		public static RogueCharacterBuff GetRootAsRogueCharacterBuff(ByteBuffer _bb, RogueCharacterBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE88 RID: 48776 RVA: 0x002E3C25 File Offset: 0x002E1E25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE89 RID: 48777 RVA: 0x002E3C34 File Offset: 0x002E1E34
		public RogueCharacterBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x0600BE8A RID: 48778 RVA: 0x002E3C44 File Offset: 0x002E1E44
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

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x0600BE8B RID: 48779 RVA: 0x002E3C80 File Offset: 0x002E1E80
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600BE8C RID: 48780 RVA: 0x002E3CC8 File Offset: 0x002E1EC8
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x0600BE8D RID: 48781 RVA: 0x002E3D14 File Offset: 0x002E1F14
		public int BuffIdsLength
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

		// Token: 0x0600BE8E RID: 48782 RVA: 0x002E3D3F File Offset: 0x002E1F3F
		public Span<long> GetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x0600BE8F RID: 48783 RVA: 0x002E3D53 File Offset: 0x002E1F53
		public long[] GetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600BE90 RID: 48784 RVA: 0x002E3D90 File Offset: 0x002E1F90
		public string AffixTypeList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x0600BE91 RID: 48785 RVA: 0x002E3DCC File Offset: 0x002E1FCC
		public int AffixTypeListLength
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

		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x0600BE92 RID: 48786 RVA: 0x002E3DF8 File Offset: 0x002E1FF8
		public string AffixDesc
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

		// Token: 0x0600BE93 RID: 48787 RVA: 0x002E3E30 File Offset: 0x002E2030
		public Span<byte> GetAffixDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BE94 RID: 48788 RVA: 0x002E3E40 File Offset: 0x002E2040
		public byte[] GetAffixDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BE95 RID: 48789 RVA: 0x002E3E58 File Offset: 0x002E2058
		public string AffixDescParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x0600BE96 RID: 48790 RVA: 0x002E3E94 File Offset: 0x002E2094
		public int AffixDescParamLength
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

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x0600BE97 RID: 48791 RVA: 0x002E3EC0 File Offset: 0x002E20C0
		public string AffixDescSimple
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

		// Token: 0x0600BE98 RID: 48792 RVA: 0x002E3EF8 File Offset: 0x002E20F8
		public Span<byte> GetAffixDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BE99 RID: 48793 RVA: 0x002E3F08 File Offset: 0x002E2108
		public byte[] GetAffixDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F0D RID: 12045
		// (get) Token: 0x0600BE9A RID: 48794 RVA: 0x002E3F20 File Offset: 0x002E2120
		public string AffixTitle
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

		// Token: 0x0600BE9B RID: 48795 RVA: 0x002E3F58 File Offset: 0x002E2158
		public Span<byte> GetAffixTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BE9C RID: 48796 RVA: 0x002E3F68 File Offset: 0x002E2168
		public byte[] GetAffixTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F0E RID: 12046
		// (get) Token: 0x0600BE9D RID: 48797 RVA: 0x002E3F80 File Offset: 0x002E2180
		public string AffixIcon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BE9E RID: 48798 RVA: 0x002E3FB8 File Offset: 0x002E21B8
		public Span<byte> GetAffixIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BE9F RID: 48799 RVA: 0x002E3FC8 File Offset: 0x002E21C8
		public byte[] GetAffixIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BEA0 RID: 48800 RVA: 0x002E3FE0 File Offset: 0x002E21E0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AffixDescParamIter()或GetAffixDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AffixDescParam()
		{
			return this.AffixDescParamIter().ToArray<string>();
		}

		// Token: 0x0600BEA1 RID: 48801 RVA: 0x002E3FED File Offset: 0x002E21ED
		[NullableContext(1)]
		public readonly IEnumerable<string> AffixDescParamIter()
		{
			RogueCharacterBuff.<AffixDescParamIter>d__40 <AffixDescParamIter>d__ = new RogueCharacterBuff.<AffixDescParamIter>d__40(-2);
			<AffixDescParamIter>d__.<>3__<>4__this = this;
			return <AffixDescParamIter>d__;
		}

		// Token: 0x0600BEA2 RID: 48802 RVA: 0x002E4002 File Offset: 0x002E2202
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AffixTypeListIter()或GetAffixTypeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AffixTypeList()
		{
			return this.AffixTypeListIter().ToArray<string>();
		}

		// Token: 0x0600BEA3 RID: 48803 RVA: 0x002E400F File Offset: 0x002E220F
		[NullableContext(1)]
		public readonly IEnumerable<string> AffixTypeListIter()
		{
			RogueCharacterBuff.<AffixTypeListIter>d__42 <AffixTypeListIter>d__ = new RogueCharacterBuff.<AffixTypeListIter>d__42(-2);
			<AffixTypeListIter>d__.<>3__<>4__this = this;
			return <AffixTypeListIter>d__;
		}

		// Token: 0x0600BEA4 RID: 48804 RVA: 0x002E4024 File Offset: 0x002E2224
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdsIter()或GetBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffIds()
		{
			RogueCharacterBuff rogueCharacterBuff = this;
			return rogueCharacterBuff.GetBuffIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600BEA5 RID: 48805 RVA: 0x002E4048 File Offset: 0x002E2248
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdsIter()
		{
			RogueCharacterBuff.<BuffIdsIter>d__44 <BuffIdsIter>d__ = new RogueCharacterBuff.<BuffIdsIter>d__44(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x040050B9 RID: 20665
		private Table __p;
	}
}
