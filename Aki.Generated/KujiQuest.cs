using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E79 RID: 3705
	public struct KujiQuest : IFlatbufferObject
	{
		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x06008E88 RID: 36488 RVA: 0x0028A08D File Offset: 0x0028828D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008E89 RID: 36489 RVA: 0x0028A09A File Offset: 0x0028829A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008E8A RID: 36490 RVA: 0x0028A0A4 File Offset: 0x002882A4
		public static KujiQuest GetRootAsKujiQuest(ByteBuffer _bb)
		{
			return KujiQuest.GetRootAsKujiQuest(_bb, default(KujiQuest));
		}

		// Token: 0x06008E8B RID: 36491 RVA: 0x0028A0C0 File Offset: 0x002882C0
		public static KujiQuest GetRootAsKujiQuest(ByteBuffer _bb, KujiQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008E8C RID: 36492 RVA: 0x0028A0DD File Offset: 0x002882DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008E8D RID: 36493 RVA: 0x0028A0EC File Offset: 0x002882EC
		public KujiQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x06008E8E RID: 36494 RVA: 0x0028A0FC File Offset: 0x002882FC
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

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x06008E8F RID: 36495 RVA: 0x0028A138 File Offset: 0x00288338
		public int KujiId
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

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06008E90 RID: 36496 RVA: 0x0028A174 File Offset: 0x00288374
		public int CoinQuestId
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

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x06008E91 RID: 36497 RVA: 0x0028A1B0 File Offset: 0x002883B0
		public string QuestDesc
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

		// Token: 0x06008E92 RID: 36498 RVA: 0x0028A1E8 File Offset: 0x002883E8
		public Span<byte> GetQuestDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008E93 RID: 36499 RVA: 0x0028A1F8 File Offset: 0x002883F8
		public byte[] GetQuestDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005406 RID: 21510
		private Table __p;
	}
}
