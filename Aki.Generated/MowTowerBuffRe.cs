using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E71 RID: 3697
	public struct MowTowerBuffRe : IFlatbufferObject
	{
		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x06009CF7 RID: 40183 RVA: 0x00299229 File Offset: 0x00297429
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009CF8 RID: 40184 RVA: 0x00299236 File Offset: 0x00297436
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009CF9 RID: 40185 RVA: 0x00299240 File Offset: 0x00297440
		public static MowTowerBuffRe GetRootAsMowTowerBuffRe(ByteBuffer _bb)
		{
			return MowTowerBuffRe.GetRootAsMowTowerBuffRe(_bb, default(MowTowerBuffRe));
		}

		// Token: 0x06009CFA RID: 40186 RVA: 0x0029925C File Offset: 0x0029745C
		public static MowTowerBuffRe GetRootAsMowTowerBuffRe(ByteBuffer _bb, MowTowerBuffRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009CFB RID: 40187 RVA: 0x00299279 File Offset: 0x00297479
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009CFC RID: 40188 RVA: 0x00299288 File Offset: 0x00297488
		public MowTowerBuffRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x06009CFD RID: 40189 RVA: 0x00299298 File Offset: 0x00297498
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

		// Token: 0x06009CFE RID: 40190 RVA: 0x002992D4 File Offset: 0x002974D4
		public long BuffId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x06009CFF RID: 40191 RVA: 0x00299314 File Offset: 0x00297514
		public int BuffIdLength
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

		// Token: 0x06009D00 RID: 40192 RVA: 0x0029933F File Offset: 0x0029753F
		public Span<long> GetBuffIdBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x06009D01 RID: 40193 RVA: 0x0029934E File Offset: 0x0029754E
		public long[] GetBuffIdArray()
		{
			return this.__p.__vector_as_array<long>(6) ?? Array.Empty<long>();
		}

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x06009D02 RID: 40194 RVA: 0x00299368 File Offset: 0x00297568
		public string Texture
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

		// Token: 0x06009D03 RID: 40195 RVA: 0x0029939F File Offset: 0x0029759F
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009D04 RID: 40196 RVA: 0x002993AE File Offset: 0x002975AE
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x06009D05 RID: 40197 RVA: 0x002993C8 File Offset: 0x002975C8
		public string Name
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

		// Token: 0x06009D06 RID: 40198 RVA: 0x00299400 File Offset: 0x00297600
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009D07 RID: 40199 RVA: 0x00299410 File Offset: 0x00297610
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x06009D08 RID: 40200 RVA: 0x00299428 File Offset: 0x00297628
		public string Description
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

		// Token: 0x06009D09 RID: 40201 RVA: 0x00299460 File Offset: 0x00297660
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009D0A RID: 40202 RVA: 0x00299470 File Offset: 0x00297670
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06009D0B RID: 40203 RVA: 0x00299488 File Offset: 0x00297688
		public string DescriptionParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x06009D0C RID: 40204 RVA: 0x002994C4 File Offset: 0x002976C4
		public int DescriptionParamLength
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

		// Token: 0x06009D0D RID: 40205 RVA: 0x002994F0 File Offset: 0x002976F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdIter()或GetBuffIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffId()
		{
			MowTowerBuffRe mowTowerBuffRe = this;
			return mowTowerBuffRe.GetBuffIdArray() ?? Array.Empty<long>();
		}

		// Token: 0x06009D0E RID: 40206 RVA: 0x00299514 File Offset: 0x00297714
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdIter()
		{
			MowTowerBuffRe.<BuffIdIter>d__31 <BuffIdIter>d__ = new MowTowerBuffRe.<BuffIdIter>d__31(-2);
			<BuffIdIter>d__.<>3__<>4__this = this;
			return <BuffIdIter>d__;
		}

		// Token: 0x06009D0F RID: 40207 RVA: 0x00299529 File Offset: 0x00297729
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescriptionParamIter()或GetDescriptionParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescriptionParam()
		{
			return this.DescriptionParamIter().ToArray<string>();
		}

		// Token: 0x06009D10 RID: 40208 RVA: 0x00299536 File Offset: 0x00297736
		[NullableContext(1)]
		public readonly IEnumerable<string> DescriptionParamIter()
		{
			MowTowerBuffRe.<DescriptionParamIter>d__33 <DescriptionParamIter>d__ = new MowTowerBuffRe.<DescriptionParamIter>d__33(-2);
			<DescriptionParamIter>d__.<>3__<>4__this = this;
			return <DescriptionParamIter>d__;
		}

		// Token: 0x04004F1F RID: 20255
		private Table __p;
	}
}
