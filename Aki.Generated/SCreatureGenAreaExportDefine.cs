using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011DB RID: 4571
	public struct SCreatureGenAreaExportDefine : IFlatbufferObject
	{
		// Token: 0x17003F1A RID: 16154
		// (get) Token: 0x0600EB17 RID: 60183 RVA: 0x003495C8 File Offset: 0x003477C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB18 RID: 60184 RVA: 0x003495D5 File Offset: 0x003477D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB19 RID: 60185 RVA: 0x003495DC File Offset: 0x003477DC
		public static SCreatureGenAreaExportDefine GetRootAsSCreatureGenAreaExportDefine(ByteBuffer _bb)
		{
			return SCreatureGenAreaExportDefine.GetRootAsSCreatureGenAreaExportDefine(_bb, default(SCreatureGenAreaExportDefine));
		}

		// Token: 0x0600EB1A RID: 60186 RVA: 0x003495F8 File Offset: 0x003477F8
		public static SCreatureGenAreaExportDefine GetRootAsSCreatureGenAreaExportDefine(ByteBuffer _bb, SCreatureGenAreaExportDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB1B RID: 60187 RVA: 0x00349615 File Offset: 0x00347815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB1C RID: 60188 RVA: 0x00349624 File Offset: 0x00347824
		public SCreatureGenAreaExportDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F1B RID: 16155
		// (get) Token: 0x0600EB1D RID: 60189 RVA: 0x00349634 File Offset: 0x00347834
		public int ShapeType
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

		// Token: 0x0600EB1E RID: 60190 RVA: 0x00349670 File Offset: 0x00347870
		public IntVector? Transforms(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntVector?(default(IntVector).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003F1C RID: 16156
		// (get) Token: 0x0600EB1F RID: 60191 RVA: 0x003496D0 File Offset: 0x003478D0
		public int TransformsLength
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

		// Token: 0x17003F1D RID: 16157
		// (get) Token: 0x0600EB20 RID: 60192 RVA: 0x003496FC File Offset: 0x003478FC
		public float Weight
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EB21 RID: 60193 RVA: 0x0034973C File Offset: 0x0034793C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TransformsIter()或GetTransformsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntVector[] Transforms()
		{
			return this.TransformsIter().ToArray<IntVector>();
		}

		// Token: 0x0600EB22 RID: 60194 RVA: 0x00349749 File Offset: 0x00347949
		[NullableContext(1)]
		public readonly IEnumerable<IntVector> TransformsIter()
		{
			SCreatureGenAreaExportDefine.<TransformsIter>d__16 <TransformsIter>d__ = new SCreatureGenAreaExportDefine.<TransformsIter>d__16(-2);
			<TransformsIter>d__.<>3__<>4__this = this;
			return <TransformsIter>d__;
		}

		// Token: 0x0400534E RID: 21326
		private Table __p;
	}
}
