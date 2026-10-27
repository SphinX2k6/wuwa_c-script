using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F9F RID: 3999
	public struct RecallEntity : IFlatbufferObject
	{
		// Token: 0x17002D4A RID: 11594
		// (get) Token: 0x0600B9DB RID: 47579 RVA: 0x002D95AC File Offset: 0x002D77AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B9DC RID: 47580 RVA: 0x002D95B9 File Offset: 0x002D77B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B9DD RID: 47581 RVA: 0x002D95C0 File Offset: 0x002D77C0
		public static RecallEntity GetRootAsRecallEntity(ByteBuffer _bb)
		{
			return RecallEntity.GetRootAsRecallEntity(_bb, default(RecallEntity));
		}

		// Token: 0x0600B9DE RID: 47582 RVA: 0x002D95DC File Offset: 0x002D77DC
		public static RecallEntity GetRootAsRecallEntity(ByteBuffer _bb, RecallEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B9DF RID: 47583 RVA: 0x002D95F9 File Offset: 0x002D77F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B9E0 RID: 47584 RVA: 0x002D9608 File Offset: 0x002D7808
		public RecallEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D4B RID: 11595
		// (get) Token: 0x0600B9E1 RID: 47585 RVA: 0x002D9618 File Offset: 0x002D7818
		public int RecallId
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

		// Token: 0x17002D4C RID: 11596
		// (get) Token: 0x0600B9E2 RID: 47586 RVA: 0x002D9654 File Offset: 0x002D7854
		public int InstanceId
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

		// Token: 0x0600B9E3 RID: 47587 RVA: 0x002D9690 File Offset: 0x002D7890
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D4D RID: 11597
		// (get) Token: 0x0600B9E4 RID: 47588 RVA: 0x002D96D0 File Offset: 0x002D78D0
		public int EntityIdsLength
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

		// Token: 0x0600B9E5 RID: 47589 RVA: 0x002D96FB File Offset: 0x002D78FB
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600B9E6 RID: 47590 RVA: 0x002D970A File Offset: 0x002D790A
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600B9E7 RID: 47591 RVA: 0x002D9724 File Offset: 0x002D7924
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EntityIdsIter()或GetEntityIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EntityIds()
		{
			RecallEntity recallEntity = this;
			return recallEntity.GetEntityIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B9E8 RID: 47592 RVA: 0x002D9748 File Offset: 0x002D7948
		[NullableContext(1)]
		public readonly IEnumerable<int> EntityIdsIter()
		{
			RecallEntity.<EntityIdsIter>d__18 <EntityIdsIter>d__ = new RecallEntity.<EntityIdsIter>d__18(-2);
			<EntityIdsIter>d__.<>3__<>4__this = this;
			return <EntityIdsIter>d__;
		}

		// Token: 0x04005072 RID: 20594
		private Table __p;
	}
}
