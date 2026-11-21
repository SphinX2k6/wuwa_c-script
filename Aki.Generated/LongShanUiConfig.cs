using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC2 RID: 3778
	public struct LongShanUiConfig : IFlatbufferObject
	{
		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x060095BB RID: 38331 RVA: 0x0029974C File Offset: 0x0029794C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060095BC RID: 38332 RVA: 0x00299759 File Offset: 0x00297959
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060095BD RID: 38333 RVA: 0x00299760 File Offset: 0x00297960
		public static LongShanUiConfig GetRootAsLongShanUiConfig(ByteBuffer _bb)
		{
			return LongShanUiConfig.GetRootAsLongShanUiConfig(_bb, default(LongShanUiConfig));
		}

		// Token: 0x060095BE RID: 38334 RVA: 0x0029977C File Offset: 0x0029797C
		public static LongShanUiConfig GetRootAsLongShanUiConfig(ByteBuffer _bb, LongShanUiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060095BF RID: 38335 RVA: 0x00299799 File Offset: 0x00297999
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060095C0 RID: 38336 RVA: 0x002997A8 File Offset: 0x002979A8
		public LongShanUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x060095C1 RID: 38337 RVA: 0x002997B8 File Offset: 0x002979B8
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

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x060095C2 RID: 38338 RVA: 0x002997F4 File Offset: 0x002979F4
		public string SubViewId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060095C3 RID: 38339 RVA: 0x0029982B File Offset: 0x00297A2B
		public Span<byte> GetSubViewIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060095C4 RID: 38340 RVA: 0x0029983A File Offset: 0x00297A3A
		public byte[] GetSubViewIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x060095C5 RID: 38341 RVA: 0x00299854 File Offset: 0x00297A54
		public string MainViewId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060095C6 RID: 38342 RVA: 0x0029988B File Offset: 0x00297A8B
		public Span<byte> GetMainViewIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060095C7 RID: 38343 RVA: 0x0029989A File Offset: 0x00297A9A
		public byte[] GetMainViewIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x060095C8 RID: 38344 RVA: 0x002998B4 File Offset: 0x00297AB4
		public string RewardViewId
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

		// Token: 0x060095C9 RID: 38345 RVA: 0x002998EC File Offset: 0x00297AEC
		public Span<byte> GetRewardViewIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060095CA RID: 38346 RVA: 0x002998FC File Offset: 0x00297AFC
		public byte[] GetRewardViewIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x060095CB RID: 38347 RVA: 0x00299914 File Offset: 0x00297B14
		public string OpenTipId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060095CC RID: 38348 RVA: 0x0029994C File Offset: 0x00297B4C
		public Span<byte> GetOpenTipIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060095CD RID: 38349 RVA: 0x0029995C File Offset: 0x00297B5C
		public byte[] GetOpenTipIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400545E RID: 21598
		private Table __p;
	}
}
