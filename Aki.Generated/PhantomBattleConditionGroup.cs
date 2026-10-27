using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ECB RID: 3787
	public struct PhantomBattleConditionGroup : IFlatbufferObject
	{
		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x0600A6C9 RID: 42697 RVA: 0x002AF480 File Offset: 0x002AD680
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A6CA RID: 42698 RVA: 0x002AF48D File Offset: 0x002AD68D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A6CB RID: 42699 RVA: 0x002AF494 File Offset: 0x002AD694
		public static PhantomBattleConditionGroup GetRootAsPhantomBattleConditionGroup(ByteBuffer _bb)
		{
			return PhantomBattleConditionGroup.GetRootAsPhantomBattleConditionGroup(_bb, default(PhantomBattleConditionGroup));
		}

		// Token: 0x0600A6CC RID: 42700 RVA: 0x002AF4B0 File Offset: 0x002AD6B0
		public static PhantomBattleConditionGroup GetRootAsPhantomBattleConditionGroup(ByteBuffer _bb, PhantomBattleConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A6CD RID: 42701 RVA: 0x002AF4CD File Offset: 0x002AD6CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A6CE RID: 42702 RVA: 0x002AF4DC File Offset: 0x002AD6DC
		public PhantomBattleConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x0600A6CF RID: 42703 RVA: 0x002AF4EC File Offset: 0x002AD6EC
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

		// Token: 0x0600A6D0 RID: 42704 RVA: 0x002AF528 File Offset: 0x002AD728
		public int PhantomBattleConditionId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002621 RID: 9761
		// (get) Token: 0x0600A6D1 RID: 42705 RVA: 0x002AF568 File Offset: 0x002AD768
		public int PhantomBattleConditionIdLength
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

		// Token: 0x0600A6D2 RID: 42706 RVA: 0x002AF593 File Offset: 0x002AD793
		public Span<int> GetPhantomBattleConditionIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600A6D3 RID: 42707 RVA: 0x002AF5A2 File Offset: 0x002AD7A2
		public int[] GetPhantomBattleConditionIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600A6D4 RID: 42708 RVA: 0x002AF5BC File Offset: 0x002AD7BC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhantomBattleConditionIdIter()或GetPhantomBattleConditionIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PhantomBattleConditionId()
		{
			PhantomBattleConditionGroup phantomBattleConditionGroup = this;
			return phantomBattleConditionGroup.GetPhantomBattleConditionIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A6D5 RID: 42709 RVA: 0x002AF5E0 File Offset: 0x002AD7E0
		[NullableContext(1)]
		public readonly IEnumerable<int> PhantomBattleConditionIdIter()
		{
			PhantomBattleConditionGroup.<PhantomBattleConditionIdIter>d__16 <PhantomBattleConditionIdIter>d__ = new PhantomBattleConditionGroup.<PhantomBattleConditionIdIter>d__16(-2);
			<PhantomBattleConditionIdIter>d__.<>3__<>4__this = this;
			return <PhantomBattleConditionIdIter>d__;
		}

		// Token: 0x04004F89 RID: 20361
		private Table __p;
	}
}
