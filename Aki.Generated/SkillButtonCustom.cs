using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B8 RID: 4280
	public struct SkillButtonCustom : IFlatbufferObject
	{
		// Token: 0x17003670 RID: 13936
		// (get) Token: 0x0600D3AA RID: 54186 RVA: 0x00313924 File Offset: 0x00311B24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D3AB RID: 54187 RVA: 0x00313931 File Offset: 0x00311B31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D3AC RID: 54188 RVA: 0x00313938 File Offset: 0x00311B38
		public static SkillButtonCustom GetRootAsSkillButtonCustom(ByteBuffer _bb)
		{
			return SkillButtonCustom.GetRootAsSkillButtonCustom(_bb, default(SkillButtonCustom));
		}

		// Token: 0x0600D3AD RID: 54189 RVA: 0x00313954 File Offset: 0x00311B54
		public static SkillButtonCustom GetRootAsSkillButtonCustom(ByteBuffer _bb, SkillButtonCustom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D3AE RID: 54190 RVA: 0x00313971 File Offset: 0x00311B71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D3AF RID: 54191 RVA: 0x00313980 File Offset: 0x00311B80
		public SkillButtonCustom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003671 RID: 13937
		// (get) Token: 0x0600D3B0 RID: 54192 RVA: 0x00313990 File Offset: 0x00311B90
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

		// Token: 0x17003672 RID: 13938
		// (get) Token: 0x0600D3B1 RID: 54193 RVA: 0x003139CC File Offset: 0x00311BCC
		public int Type
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

		// Token: 0x0600D3B2 RID: 54194 RVA: 0x00313A08 File Offset: 0x00311C08
		public int TagIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003673 RID: 13939
		// (get) Token: 0x0600D3B3 RID: 54195 RVA: 0x00313A48 File Offset: 0x00311C48
		public int TagIdsLength
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

		// Token: 0x0600D3B4 RID: 54196 RVA: 0x00313A73 File Offset: 0x00311C73
		public Span<int> GetTagIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600D3B5 RID: 54197 RVA: 0x00313A82 File Offset: 0x00311C82
		public int[] GetTagIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600D3B6 RID: 54198 RVA: 0x00313A9C File Offset: 0x00311C9C
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(10);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003674 RID: 13940
		// (get) Token: 0x0600D3B7 RID: 54199 RVA: 0x00313AE8 File Offset: 0x00311CE8
		public int BuffIdsLength
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

		// Token: 0x0600D3B8 RID: 54200 RVA: 0x00313B14 File Offset: 0x00311D14
		public Span<long> GetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(10, 8));
		}

		// Token: 0x0600D3B9 RID: 54201 RVA: 0x00313B29 File Offset: 0x00311D29
		public long[] GetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(10) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600D3BA RID: 54202 RVA: 0x00313B68 File Offset: 0x00311D68
		public string Params(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003675 RID: 13941
		// (get) Token: 0x0600D3BB RID: 54203 RVA: 0x00313BA4 File Offset: 0x00311DA4
		public int ParamsLength
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

		// Token: 0x0600D3BC RID: 54204 RVA: 0x00313BD0 File Offset: 0x00311DD0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdsIter()或GetBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffIds()
		{
			SkillButtonCustom skillButtonCustom = this;
			return skillButtonCustom.GetBuffIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600D3BD RID: 54205 RVA: 0x00313BF4 File Offset: 0x00311DF4
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdsIter()
		{
			SkillButtonCustom.<BuffIdsIter>d__26 <BuffIdsIter>d__ = new SkillButtonCustom.<BuffIdsIter>d__26(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x0600D3BE RID: 54206 RVA: 0x00313C09 File Offset: 0x00311E09
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamsIter()或GetParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Params()
		{
			return this.ParamsIter().ToArray<string>();
		}

		// Token: 0x0600D3BF RID: 54207 RVA: 0x00313C16 File Offset: 0x00311E16
		[NullableContext(1)]
		public readonly IEnumerable<string> ParamsIter()
		{
			SkillButtonCustom.<ParamsIter>d__28 <ParamsIter>d__ = new SkillButtonCustom.<ParamsIter>d__28(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x0600D3C0 RID: 54208 RVA: 0x00313C2C File Offset: 0x00311E2C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagIdsIter()或GetTagIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TagIds()
		{
			SkillButtonCustom skillButtonCustom = this;
			return skillButtonCustom.GetTagIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D3C1 RID: 54209 RVA: 0x00313C50 File Offset: 0x00311E50
		[NullableContext(1)]
		public readonly IEnumerable<int> TagIdsIter()
		{
			SkillButtonCustom.<TagIdsIter>d__30 <TagIdsIter>d__ = new SkillButtonCustom.<TagIdsIter>d__30(-2);
			<TagIdsIter>d__.<>3__<>4__this = this;
			return <TagIdsIter>d__;
		}

		// Token: 0x040051D2 RID: 20946
		private Table __p;
	}
}
