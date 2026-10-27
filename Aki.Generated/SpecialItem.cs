using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E1 RID: 4321
	public struct SpecialItem : IFlatbufferObject
	{
		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x0600D7ED RID: 55277 RVA: 0x0031E06D File Offset: 0x0031C26D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D7EE RID: 55278 RVA: 0x0031E07A File Offset: 0x0031C27A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D7EF RID: 55279 RVA: 0x0031E084 File Offset: 0x0031C284
		public static SpecialItem GetRootAsSpecialItem(ByteBuffer _bb)
		{
			return SpecialItem.GetRootAsSpecialItem(_bb, default(SpecialItem));
		}

		// Token: 0x0600D7F0 RID: 55280 RVA: 0x0031E0A0 File Offset: 0x0031C2A0
		public static SpecialItem GetRootAsSpecialItem(ByteBuffer _bb, SpecialItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D7F1 RID: 55281 RVA: 0x0031E0BD File Offset: 0x0031C2BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D7F2 RID: 55282 RVA: 0x0031E0CC File Offset: 0x0031C2CC
		public SpecialItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x0600D7F3 RID: 55283 RVA: 0x0031E0DC File Offset: 0x0031C2DC
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

		// Token: 0x0600D7F4 RID: 55284 RVA: 0x0031E118 File Offset: 0x0031C318
		public int UseButtonAdditionParam(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x0600D7F5 RID: 55285 RVA: 0x0031E158 File Offset: 0x0031C358
		public int UseButtonAdditionParamLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D7F6 RID: 55286 RVA: 0x0031E183 File Offset: 0x0031C383
		public Span<int> GetUseButtonAdditionParamBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600D7F7 RID: 55287 RVA: 0x0031E192 File Offset: 0x0031C392
		public int[] GetUseButtonAdditionParamArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x0600D7F8 RID: 55288 RVA: 0x0031E1AC File Offset: 0x0031C3AC
		public int SpecialItemType
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

		// Token: 0x0600D7F9 RID: 55289 RVA: 0x0031E1E8 File Offset: 0x0031C3E8
		public string Parameters(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x0600D7FA RID: 55290 RVA: 0x0031E224 File Offset: 0x0031C424
		public int ParametersLength
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

		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x0600D7FB RID: 55291 RVA: 0x0031E250 File Offset: 0x0031C450
		public bool UseInMultiMode
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170037DA RID: 14298
		// (get) Token: 0x0600D7FC RID: 55292 RVA: 0x0031E290 File Offset: 0x0031C490
		public bool UseInstance
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600D7FD RID: 55293 RVA: 0x0031E2D0 File Offset: 0x0031C4D0
		public string BanTags(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037DB RID: 14299
		// (get) Token: 0x0600D7FE RID: 55294 RVA: 0x0031E30C File Offset: 0x0031C50C
		public int BanTagsLength
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

		// Token: 0x0600D7FF RID: 55295 RVA: 0x0031E338 File Offset: 0x0031C538
		public string AllowTags(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037DC RID: 14300
		// (get) Token: 0x0600D800 RID: 55296 RVA: 0x0031E374 File Offset: 0x0031C574
		public int AllowTagsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170037DD RID: 14301
		// (get) Token: 0x0600D801 RID: 55297 RVA: 0x0031E3A0 File Offset: 0x0031C5A0
		public int SummonConfigId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170037DE RID: 14302
		// (get) Token: 0x0600D802 RID: 55298 RVA: 0x0031E3E0 File Offset: 0x0031C5E0
		public bool NeedShowNum
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170037DF RID: 14303
		// (get) Token: 0x0600D803 RID: 55299 RVA: 0x0031E420 File Offset: 0x0031C620
		public int PreviewModelId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170037E0 RID: 14304
		// (get) Token: 0x0600D804 RID: 55300 RVA: 0x0031E460 File Offset: 0x0031C660
		public string PreviewMontage
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D805 RID: 55301 RVA: 0x0031E498 File Offset: 0x0031C698
		public Span<byte> GetPreviewMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600D806 RID: 55302 RVA: 0x0031E4A8 File Offset: 0x0031C6A8
		public byte[] GetPreviewMontageArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D807 RID: 55303 RVA: 0x0031E4C0 File Offset: 0x0031C6C0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AllowTagsIter()或GetAllowTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AllowTags()
		{
			return this.AllowTagsIter().ToArray<string>();
		}

		// Token: 0x0600D808 RID: 55304 RVA: 0x0031E4CD File Offset: 0x0031C6CD
		[NullableContext(1)]
		public readonly IEnumerable<string> AllowTagsIter()
		{
			SpecialItem.<AllowTagsIter>d__41 <AllowTagsIter>d__ = new SpecialItem.<AllowTagsIter>d__41(-2);
			<AllowTagsIter>d__.<>3__<>4__this = this;
			return <AllowTagsIter>d__;
		}

		// Token: 0x0600D809 RID: 55305 RVA: 0x0031E4E2 File Offset: 0x0031C6E2
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BanTagsIter()或GetBanTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BanTags()
		{
			return this.BanTagsIter().ToArray<string>();
		}

		// Token: 0x0600D80A RID: 55306 RVA: 0x0031E4EF File Offset: 0x0031C6EF
		[NullableContext(1)]
		public readonly IEnumerable<string> BanTagsIter()
		{
			SpecialItem.<BanTagsIter>d__43 <BanTagsIter>d__ = new SpecialItem.<BanTagsIter>d__43(-2);
			<BanTagsIter>d__.<>3__<>4__this = this;
			return <BanTagsIter>d__;
		}

		// Token: 0x0600D80B RID: 55307 RVA: 0x0031E504 File Offset: 0x0031C704
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParametersIter()或GetParametersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Parameters()
		{
			return this.ParametersIter().ToArray<string>();
		}

		// Token: 0x0600D80C RID: 55308 RVA: 0x0031E511 File Offset: 0x0031C711
		[NullableContext(1)]
		public readonly IEnumerable<string> ParametersIter()
		{
			SpecialItem.<ParametersIter>d__45 <ParametersIter>d__ = new SpecialItem.<ParametersIter>d__45(-2);
			<ParametersIter>d__.<>3__<>4__this = this;
			return <ParametersIter>d__;
		}

		// Token: 0x0600D80D RID: 55309 RVA: 0x0031E528 File Offset: 0x0031C728
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UseButtonAdditionParamIter()或GetUseButtonAdditionParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UseButtonAdditionParam()
		{
			SpecialItem specialItem = this;
			return specialItem.GetUseButtonAdditionParamArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D80E RID: 55310 RVA: 0x0031E54C File Offset: 0x0031C74C
		[NullableContext(1)]
		public readonly IEnumerable<int> UseButtonAdditionParamIter()
		{
			SpecialItem.<UseButtonAdditionParamIter>d__47 <UseButtonAdditionParamIter>d__ = new SpecialItem.<UseButtonAdditionParamIter>d__47(-2);
			<UseButtonAdditionParamIter>d__.<>3__<>4__this = this;
			return <UseButtonAdditionParamIter>d__;
		}

		// Token: 0x04005214 RID: 21012
		private Table __p;
	}
}
