using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF0 RID: 3312
	public struct GASkill : IFlatbufferObject
	{
		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x06007996 RID: 31126 RVA: 0x002492F8 File Offset: 0x002474F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007997 RID: 31127 RVA: 0x00249305 File Offset: 0x00247505
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007998 RID: 31128 RVA: 0x0024930C File Offset: 0x0024750C
		public static GASkill GetRootAsGASkill(ByteBuffer _bb)
		{
			return GASkill.GetRootAsGASkill(_bb, default(GASkill));
		}

		// Token: 0x06007999 RID: 31129 RVA: 0x00249328 File Offset: 0x00247528
		public static GASkill GetRootAsGASkill(ByteBuffer _bb, GASkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600799A RID: 31130 RVA: 0x00249345 File Offset: 0x00247545
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600799B RID: 31131 RVA: 0x00249354 File Offset: 0x00247554
		public GASkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x0600799C RID: 31132 RVA: 0x00249364 File Offset: 0x00247564
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

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x0600799D RID: 31133 RVA: 0x002493A0 File Offset: 0x002475A0
		public int ConfigId
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

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x0600799E RID: 31134 RVA: 0x002493DC File Offset: 0x002475DC
		public int SkillId
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

		// Token: 0x0600799F RID: 31135 RVA: 0x00249418 File Offset: 0x00247618
		public int MontageId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x060079A0 RID: 31136 RVA: 0x00249458 File Offset: 0x00247658
		public int MontageIdLength
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

		// Token: 0x060079A1 RID: 31137 RVA: 0x00249484 File Offset: 0x00247684
		public Span<int> GetMontageIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060079A2 RID: 31138 RVA: 0x00249494 File Offset: 0x00247694
		public int[] GetMontageIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x060079A3 RID: 31139 RVA: 0x002494AC File Offset: 0x002476AC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MontageIdIter()或GetMontageIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MontageId()
		{
			GASkill gaskill = this;
			return gaskill.GetMontageIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x060079A4 RID: 31140 RVA: 0x002494D0 File Offset: 0x002476D0
		[NullableContext(1)]
		public readonly IEnumerable<int> MontageIdIter()
		{
			GASkill.<MontageIdIter>d__20 <MontageIdIter>d__ = new GASkill.<MontageIdIter>d__20(-2);
			<MontageIdIter>d__.<>3__<>4__this = this;
			return <MontageIdIter>d__;
		}

		// Token: 0x04004D61 RID: 19809
		private Table __p;
	}
}
