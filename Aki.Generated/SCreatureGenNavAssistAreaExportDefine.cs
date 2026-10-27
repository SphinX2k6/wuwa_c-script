using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011DE RID: 4574
	public struct SCreatureGenNavAssistAreaExportDefine : IFlatbufferObject
	{
		// Token: 0x17003F26 RID: 16166
		// (get) Token: 0x0600EB59 RID: 60249 RVA: 0x0034A1F4 File Offset: 0x003483F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB5A RID: 60250 RVA: 0x0034A201 File Offset: 0x00348401
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB5B RID: 60251 RVA: 0x0034A208 File Offset: 0x00348408
		public static SCreatureGenNavAssistAreaExportDefine GetRootAsSCreatureGenNavAssistAreaExportDefine(ByteBuffer _bb)
		{
			return SCreatureGenNavAssistAreaExportDefine.GetRootAsSCreatureGenNavAssistAreaExportDefine(_bb, default(SCreatureGenNavAssistAreaExportDefine));
		}

		// Token: 0x0600EB5C RID: 60252 RVA: 0x0034A224 File Offset: 0x00348424
		public static SCreatureGenNavAssistAreaExportDefine GetRootAsSCreatureGenNavAssistAreaExportDefine(ByteBuffer _bb, SCreatureGenNavAssistAreaExportDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB5D RID: 60253 RVA: 0x0034A241 File Offset: 0x00348441
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB5E RID: 60254 RVA: 0x0034A250 File Offset: 0x00348450
		public SCreatureGenNavAssistAreaExportDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600EB5F RID: 60255 RVA: 0x0034A260 File Offset: 0x00348460
		public IntVector? Points(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IntVector?(default(IntVector).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003F27 RID: 16167
		// (get) Token: 0x0600EB60 RID: 60256 RVA: 0x0034A2C0 File Offset: 0x003484C0
		public int PointsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EB61 RID: 60257 RVA: 0x0034A2EB File Offset: 0x003484EB
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PointsIter()或GetPointsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntVector[] Points()
		{
			return this.PointsIter().ToArray<IntVector>();
		}

		// Token: 0x0600EB62 RID: 60258 RVA: 0x0034A2F8 File Offset: 0x003484F8
		[NullableContext(1)]
		public readonly IEnumerable<IntVector> PointsIter()
		{
			SCreatureGenNavAssistAreaExportDefine.<PointsIter>d__12 <PointsIter>d__ = new SCreatureGenNavAssistAreaExportDefine.<PointsIter>d__12(-2);
			<PointsIter>d__.<>3__<>4__this = this;
			return <PointsIter>d__;
		}

		// Token: 0x04005357 RID: 21335
		private Table __p;
	}
}
