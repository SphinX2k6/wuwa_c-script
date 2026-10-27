using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B89 RID: 2953
	public struct ComboTeachingCondition : IFlatbufferObject
	{
		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06005705 RID: 22277 RVA: 0x001F9D79 File Offset: 0x001F7F79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005706 RID: 22278 RVA: 0x001F9D86 File Offset: 0x001F7F86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005707 RID: 22279 RVA: 0x001F9D90 File Offset: 0x001F7F90
		public static ComboTeachingCondition GetRootAsComboTeachingCondition(ByteBuffer _bb)
		{
			return ComboTeachingCondition.GetRootAsComboTeachingCondition(_bb, default(ComboTeachingCondition));
		}

		// Token: 0x06005708 RID: 22280 RVA: 0x001F9DAC File Offset: 0x001F7FAC
		public static ComboTeachingCondition GetRootAsComboTeachingCondition(ByteBuffer _bb, ComboTeachingCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005709 RID: 22281 RVA: 0x001F9DC9 File Offset: 0x001F7FC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600570A RID: 22282 RVA: 0x001F9DD8 File Offset: 0x001F7FD8
		public ComboTeachingCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x0600570B RID: 22283 RVA: 0x001F9DE8 File Offset: 0x001F7FE8
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

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600570C RID: 22284 RVA: 0x001F9E24 File Offset: 0x001F8024
		public int CompleteCondition
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

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x0600570D RID: 22285 RVA: 0x001F9E60 File Offset: 0x001F8060
		public int CompleteDelay
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

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600570E RID: 22286 RVA: 0x001F9E9C File Offset: 0x001F809C
		public string CompleteParam
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

		// Token: 0x0600570F RID: 22287 RVA: 0x001F9ED4 File Offset: 0x001F80D4
		public Span<byte> GetCompleteParamBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005710 RID: 22288 RVA: 0x001F9EE4 File Offset: 0x001F80E4
		public byte[] GetCompleteParamArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06005711 RID: 22289 RVA: 0x001F9EFC File Offset: 0x001F80FC
		public int FailedCondition(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06005712 RID: 22290 RVA: 0x001F9F3C File Offset: 0x001F813C
		public int FailedConditionLength
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

		// Token: 0x06005713 RID: 22291 RVA: 0x001F9F68 File Offset: 0x001F8168
		public Span<int> GetFailedConditionBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06005714 RID: 22292 RVA: 0x001F9F78 File Offset: 0x001F8178
		public int[] GetFailedConditionArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06005715 RID: 22293 RVA: 0x001F9F90 File Offset: 0x001F8190
		public int FailDelay
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005716 RID: 22294 RVA: 0x001F9FD0 File Offset: 0x001F81D0
		public string FailedParam(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06005717 RID: 22295 RVA: 0x001FA00C File Offset: 0x001F820C
		public int FailedParamLength
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

		// Token: 0x06005718 RID: 22296 RVA: 0x001FA038 File Offset: 0x001F8238
		public int RemoveBuff(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06005719 RID: 22297 RVA: 0x001FA078 File Offset: 0x001F8278
		public int RemoveBuffLength
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

		// Token: 0x0600571A RID: 22298 RVA: 0x001FA0A4 File Offset: 0x001F82A4
		public Span<int> GetRemoveBuffBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600571B RID: 22299 RVA: 0x001FA0B4 File Offset: 0x001F82B4
		public int[] GetRemoveBuffArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600571C RID: 22300 RVA: 0x001FA0CC File Offset: 0x001F82CC
		public string RemoveBullet(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x0600571D RID: 22301 RVA: 0x001FA108 File Offset: 0x001F8308
		public int RemoveBulletLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x0600571E RID: 22302 RVA: 0x001FA134 File Offset: 0x001F8334
		public int SummonPos
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600571F RID: 22303 RVA: 0x001FA174 File Offset: 0x001F8374
		public int SummonRemoveBuff(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06005720 RID: 22304 RVA: 0x001FA1B4 File Offset: 0x001F83B4
		public int SummonRemoveBuffLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005721 RID: 22305 RVA: 0x001FA1E0 File Offset: 0x001F83E0
		public Span<int> GetSummonRemoveBuffBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06005722 RID: 22306 RVA: 0x001FA1F0 File Offset: 0x001F83F0
		public int[] GetSummonRemoveBuffArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06005723 RID: 22307 RVA: 0x001FA208 File Offset: 0x001F8408
		public int SummonAddBuff(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06005724 RID: 22308 RVA: 0x001FA248 File Offset: 0x001F8448
		public int SummonAddBuffLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005725 RID: 22309 RVA: 0x001FA274 File Offset: 0x001F8474
		public Span<int> GetSummonAddBuffBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06005726 RID: 22310 RVA: 0x001FA284 File Offset: 0x001F8484
		public int[] GetSummonAddBuffArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x06005727 RID: 22311 RVA: 0x001FA29C File Offset: 0x001F849C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FailedConditionIter()或GetFailedConditionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FailedCondition()
		{
			ComboTeachingCondition comboTeachingCondition = this;
			return comboTeachingCondition.GetFailedConditionArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005728 RID: 22312 RVA: 0x001FA2C0 File Offset: 0x001F84C0
		[NullableContext(1)]
		public readonly IEnumerable<int> FailedConditionIter()
		{
			ComboTeachingCondition.<FailedConditionIter>d__49 <FailedConditionIter>d__ = new ComboTeachingCondition.<FailedConditionIter>d__49(-2);
			<FailedConditionIter>d__.<>3__<>4__this = this;
			return <FailedConditionIter>d__;
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x001FA2D5 File Offset: 0x001F84D5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FailedParamIter()或GetFailedParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FailedParam()
		{
			return this.FailedParamIter().ToArray<string>();
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x001FA2E2 File Offset: 0x001F84E2
		[NullableContext(1)]
		public readonly IEnumerable<string> FailedParamIter()
		{
			ComboTeachingCondition.<FailedParamIter>d__51 <FailedParamIter>d__ = new ComboTeachingCondition.<FailedParamIter>d__51(-2);
			<FailedParamIter>d__.<>3__<>4__this = this;
			return <FailedParamIter>d__;
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x001FA2F8 File Offset: 0x001F84F8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RemoveBuffIter()或GetRemoveBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RemoveBuff()
		{
			ComboTeachingCondition comboTeachingCondition = this;
			return comboTeachingCondition.GetRemoveBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x001FA31C File Offset: 0x001F851C
		[NullableContext(1)]
		public readonly IEnumerable<int> RemoveBuffIter()
		{
			ComboTeachingCondition.<RemoveBuffIter>d__53 <RemoveBuffIter>d__ = new ComboTeachingCondition.<RemoveBuffIter>d__53(-2);
			<RemoveBuffIter>d__.<>3__<>4__this = this;
			return <RemoveBuffIter>d__;
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x001FA331 File Offset: 0x001F8531
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RemoveBulletIter()或GetRemoveBulletBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] RemoveBullet()
		{
			return this.RemoveBulletIter().ToArray<string>();
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x001FA33E File Offset: 0x001F853E
		[NullableContext(1)]
		public readonly IEnumerable<string> RemoveBulletIter()
		{
			ComboTeachingCondition.<RemoveBulletIter>d__55 <RemoveBulletIter>d__ = new ComboTeachingCondition.<RemoveBulletIter>d__55(-2);
			<RemoveBulletIter>d__.<>3__<>4__this = this;
			return <RemoveBulletIter>d__;
		}

		// Token: 0x0600572F RID: 22319 RVA: 0x001FA354 File Offset: 0x001F8554
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SummonAddBuffIter()或GetSummonAddBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SummonAddBuff()
		{
			ComboTeachingCondition comboTeachingCondition = this;
			return comboTeachingCondition.GetSummonAddBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005730 RID: 22320 RVA: 0x001FA378 File Offset: 0x001F8578
		[NullableContext(1)]
		public readonly IEnumerable<int> SummonAddBuffIter()
		{
			ComboTeachingCondition.<SummonAddBuffIter>d__57 <SummonAddBuffIter>d__ = new ComboTeachingCondition.<SummonAddBuffIter>d__57(-2);
			<SummonAddBuffIter>d__.<>3__<>4__this = this;
			return <SummonAddBuffIter>d__;
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x001FA390 File Offset: 0x001F8590
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SummonRemoveBuffIter()或GetSummonRemoveBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SummonRemoveBuff()
		{
			ComboTeachingCondition comboTeachingCondition = this;
			return comboTeachingCondition.GetSummonRemoveBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x001FA3B4 File Offset: 0x001F85B4
		[NullableContext(1)]
		public readonly IEnumerable<int> SummonRemoveBuffIter()
		{
			ComboTeachingCondition.<SummonRemoveBuffIter>d__59 <SummonRemoveBuffIter>d__ = new ComboTeachingCondition.<SummonRemoveBuffIter>d__59(-2);
			<SummonRemoveBuffIter>d__.<>3__<>4__this = this;
			return <SummonRemoveBuffIter>d__;
		}

		// Token: 0x04004B98 RID: 19352
		private Table __p;
	}
}
