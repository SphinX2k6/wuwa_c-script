using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC3 RID: 3011
	public struct AiBattleWander : IFlatbufferObject
	{
		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06004B99 RID: 19353 RVA: 0x001F1F59 File Offset: 0x001F0159
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004B9A RID: 19354 RVA: 0x001F1F66 File Offset: 0x001F0166
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x001F1F70 File Offset: 0x001F0170
		public static AiBattleWander GetRootAsAiBattleWander(ByteBuffer _bb)
		{
			return AiBattleWander.GetRootAsAiBattleWander(_bb, default(AiBattleWander));
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x001F1F8C File Offset: 0x001F018C
		public static AiBattleWander GetRootAsAiBattleWander(ByteBuffer _bb, AiBattleWander obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x001F1FA9 File Offset: 0x001F01A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x001F1FB8 File Offset: 0x001F01B8
		public AiBattleWander __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06004B9F RID: 19359 RVA: 0x001F1FC8 File Offset: 0x001F01C8
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

		// Token: 0x06004BA0 RID: 19360 RVA: 0x001F2004 File Offset: 0x001F0204
		public int GroupIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x001F2044 File Offset: 0x001F0244
		public int GroupIdsLength
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

		// Token: 0x06004BA2 RID: 19362 RVA: 0x001F206F File Offset: 0x001F026F
		public Span<int> GetGroupIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06004BA3 RID: 19363 RVA: 0x001F207E File Offset: 0x001F027E
		public int[] GetGroupIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06004BA4 RID: 19364 RVA: 0x001F2095 File Offset: 0x001F0295
		[NullableContext(1)]
		public int[] GroupIds()
		{
			return this.GetGroupIdsArray();
		}

		// Token: 0x06004BA5 RID: 19365 RVA: 0x001F209D File Offset: 0x001F029D
		[NullableContext(1)]
		public IEnumerable<int> GroupIdsIter()
		{
			AiBattleWander.<GroupIdsIter>d__16 <GroupIdsIter>d__ = new AiBattleWander.<GroupIdsIter>d__16(-2);
			<GroupIdsIter>d__.<>3__<>4__this = this;
			return <GroupIdsIter>d__;
		}

		// Token: 0x040050A4 RID: 20644
		private Table __p;
	}
}
