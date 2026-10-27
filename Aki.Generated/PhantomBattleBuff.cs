using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EBF RID: 3775
	public struct PhantomBattleBuff : IFlatbufferObject
	{
		// Token: 0x17002546 RID: 9542
		// (get) Token: 0x0600A489 RID: 42121 RVA: 0x002AA125 File Offset: 0x002A8325
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A48A RID: 42122 RVA: 0x002AA132 File Offset: 0x002A8332
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A48B RID: 42123 RVA: 0x002AA13C File Offset: 0x002A833C
		public static PhantomBattleBuff GetRootAsPhantomBattleBuff(ByteBuffer _bb)
		{
			return PhantomBattleBuff.GetRootAsPhantomBattleBuff(_bb, default(PhantomBattleBuff));
		}

		// Token: 0x0600A48C RID: 42124 RVA: 0x002AA158 File Offset: 0x002A8358
		public static PhantomBattleBuff GetRootAsPhantomBattleBuff(ByteBuffer _bb, PhantomBattleBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A48D RID: 42125 RVA: 0x002AA175 File Offset: 0x002A8375
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A48E RID: 42126 RVA: 0x002AA184 File Offset: 0x002A8384
		public PhantomBattleBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002547 RID: 9543
		// (get) Token: 0x0600A48F RID: 42127 RVA: 0x002AA194 File Offset: 0x002A8394
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

		// Token: 0x17002548 RID: 9544
		// (get) Token: 0x0600A490 RID: 42128 RVA: 0x002AA1D0 File Offset: 0x002A83D0
		public int TargetSelectType
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

		// Token: 0x0600A491 RID: 42129 RVA: 0x002AA20C File Offset: 0x002A840C
		public string TargetSelectParams(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002549 RID: 9545
		// (get) Token: 0x0600A492 RID: 42130 RVA: 0x002AA248 File Offset: 0x002A8448
		public int TargetSelectParamsLength
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

		// Token: 0x1700254A RID: 9546
		// (get) Token: 0x0600A493 RID: 42131 RVA: 0x002AA274 File Offset: 0x002A8474
		public int BuffShowType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700254B RID: 9547
		// (get) Token: 0x0600A494 RID: 42132 RVA: 0x002AA2B4 File Offset: 0x002A84B4
		public int EffectType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A495 RID: 42133 RVA: 0x002AA2F4 File Offset: 0x002A84F4
		public string EffectParams(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700254C RID: 9548
		// (get) Token: 0x0600A496 RID: 42134 RVA: 0x002AA330 File Offset: 0x002A8530
		public int EffectParamsLength
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

		// Token: 0x0600A497 RID: 42135 RVA: 0x002AA35C File Offset: 0x002A855C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectParamsIter()或GetEffectParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EffectParams()
		{
			return this.EffectParamsIter().ToArray<string>();
		}

		// Token: 0x0600A498 RID: 42136 RVA: 0x002AA369 File Offset: 0x002A8569
		[NullableContext(1)]
		public readonly IEnumerable<string> EffectParamsIter()
		{
			PhantomBattleBuff.<EffectParamsIter>d__23 <EffectParamsIter>d__ = new PhantomBattleBuff.<EffectParamsIter>d__23(-2);
			<EffectParamsIter>d__.<>3__<>4__this = this;
			return <EffectParamsIter>d__;
		}

		// Token: 0x0600A499 RID: 42137 RVA: 0x002AA37E File Offset: 0x002A857E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetSelectParamsIter()或GetTargetSelectParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TargetSelectParams()
		{
			return this.TargetSelectParamsIter().ToArray<string>();
		}

		// Token: 0x0600A49A RID: 42138 RVA: 0x002AA38B File Offset: 0x002A858B
		[NullableContext(1)]
		public readonly IEnumerable<string> TargetSelectParamsIter()
		{
			PhantomBattleBuff.<TargetSelectParamsIter>d__25 <TargetSelectParamsIter>d__ = new PhantomBattleBuff.<TargetSelectParamsIter>d__25(-2);
			<TargetSelectParamsIter>d__.<>3__<>4__this = this;
			return <TargetSelectParamsIter>d__;
		}

		// Token: 0x04004F7A RID: 20346
		private Table __p;
	}
}
