using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001312 RID: 4882
	public struct SCreatureGenAreaExportDefine : IFlatbufferObject
	{
		// Token: 0x17004282 RID: 17026
		// (get) Token: 0x0600F890 RID: 63632 RVA: 0x003742B8 File Offset: 0x003724B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F891 RID: 63633 RVA: 0x003742C5 File Offset: 0x003724C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F892 RID: 63634 RVA: 0x003742CC File Offset: 0x003724CC
		public static SCreatureGenAreaExportDefine GetRootAsSCreatureGenAreaExportDefine(ByteBuffer _bb)
		{
			return SCreatureGenAreaExportDefine.GetRootAsSCreatureGenAreaExportDefine(_bb, default(SCreatureGenAreaExportDefine));
		}

		// Token: 0x0600F893 RID: 63635 RVA: 0x003742E8 File Offset: 0x003724E8
		public static SCreatureGenAreaExportDefine GetRootAsSCreatureGenAreaExportDefine(ByteBuffer _bb, SCreatureGenAreaExportDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F894 RID: 63636 RVA: 0x00374305 File Offset: 0x00372505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F895 RID: 63637 RVA: 0x00374314 File Offset: 0x00372514
		public SCreatureGenAreaExportDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004283 RID: 17027
		// (get) Token: 0x0600F896 RID: 63638 RVA: 0x00374324 File Offset: 0x00372524
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

		// Token: 0x0600F897 RID: 63639 RVA: 0x00374360 File Offset: 0x00372560
		public IntVector? Transforms(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntVector?(default(IntVector).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17004284 RID: 17028
		// (get) Token: 0x0600F898 RID: 63640 RVA: 0x003743C0 File Offset: 0x003725C0
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

		// Token: 0x17004285 RID: 17029
		// (get) Token: 0x0600F899 RID: 63641 RVA: 0x003743EC File Offset: 0x003725EC
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

		// Token: 0x0600F89A RID: 63642 RVA: 0x0037442C File Offset: 0x0037262C
		[NullableContext(1)]
		public IntVector[] Transforms()
		{
			return this.TransformsIter().ToArray<IntVector>();
		}

		// Token: 0x0600F89B RID: 63643 RVA: 0x00374439 File Offset: 0x00372639
		[NullableContext(1)]
		public IEnumerable<IntVector> TransformsIter()
		{
			SCreatureGenAreaExportDefine.<TransformsIter>d__16 <TransformsIter>d__ = new SCreatureGenAreaExportDefine.<TransformsIter>d__16(-2);
			<TransformsIter>d__.<>3__<>4__this = this;
			return <TransformsIter>d__;
		}

		// Token: 0x04005992 RID: 22930
		private Table __p;
	}
}
