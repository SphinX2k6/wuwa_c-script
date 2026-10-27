using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F97 RID: 3991
	public struct RandomSummon : IFlatbufferObject
	{
		// Token: 0x17002D03 RID: 11523
		// (get) Token: 0x0600B91B RID: 47387 RVA: 0x002D78C8 File Offset: 0x002D5AC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B91C RID: 47388 RVA: 0x002D78D5 File Offset: 0x002D5AD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B91D RID: 47389 RVA: 0x002D78DC File Offset: 0x002D5ADC
		public static RandomSummon GetRootAsRandomSummon(ByteBuffer _bb)
		{
			return RandomSummon.GetRootAsRandomSummon(_bb, default(RandomSummon));
		}

		// Token: 0x0600B91E RID: 47390 RVA: 0x002D78F8 File Offset: 0x002D5AF8
		public static RandomSummon GetRootAsRandomSummon(ByteBuffer _bb, RandomSummon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B91F RID: 47391 RVA: 0x002D7915 File Offset: 0x002D5B15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B920 RID: 47392 RVA: 0x002D7924 File Offset: 0x002D5B24
		public RandomSummon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D04 RID: 11524
		// (get) Token: 0x0600B921 RID: 47393 RVA: 0x002D7934 File Offset: 0x002D5B34
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

		// Token: 0x0600B922 RID: 47394 RVA: 0x002D7970 File Offset: 0x002D5B70
		public IntArray? Random(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002D05 RID: 11525
		// (get) Token: 0x0600B923 RID: 47395 RVA: 0x002D79D0 File Offset: 0x002D5BD0
		public int RandomLength
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

		// Token: 0x17002D06 RID: 11526
		// (get) Token: 0x0600B924 RID: 47396 RVA: 0x002D79FC File Offset: 0x002D5BFC
		public int Count
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

		// Token: 0x0600B925 RID: 47397 RVA: 0x002D7A38 File Offset: 0x002D5C38
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RandomIter()或GetRandomBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] Random()
		{
			return this.RandomIter().ToArray<IntArray>();
		}

		// Token: 0x0600B926 RID: 47398 RVA: 0x002D7A45 File Offset: 0x002D5C45
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> RandomIter()
		{
			RandomSummon.<RandomIter>d__16 <RandomIter>d__ = new RandomSummon.<RandomIter>d__16(-2);
			<RandomIter>d__.<>3__<>4__this = this;
			return <RandomIter>d__;
		}

		// Token: 0x04005067 RID: 20583
		private Table __p;
	}
}
