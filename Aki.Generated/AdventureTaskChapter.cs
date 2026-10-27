using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD4 RID: 2772
	public struct AdventureTaskChapter : IFlatbufferObject
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06004471 RID: 17521 RVA: 0x001CE6C4 File Offset: 0x001CC8C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x001CE6D1 File Offset: 0x001CC8D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x001CE6D8 File Offset: 0x001CC8D8
		public static AdventureTaskChapter GetRootAsAdventureTaskChapter(ByteBuffer _bb)
		{
			return AdventureTaskChapter.GetRootAsAdventureTaskChapter(_bb, default(AdventureTaskChapter));
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x001CE6F4 File Offset: 0x001CC8F4
		public static AdventureTaskChapter GetRootAsAdventureTaskChapter(ByteBuffer _bb, AdventureTaskChapter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x001CE711 File Offset: 0x001CC911
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x001CE720 File Offset: 0x001CC920
		public AdventureTaskChapter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06004477 RID: 17527 RVA: 0x001CE730 File Offset: 0x001CC930
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

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06004478 RID: 17528 RVA: 0x001CE76C File Offset: 0x001CC96C
		public string Name
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

		// Token: 0x06004479 RID: 17529 RVA: 0x001CE7A3 File Offset: 0x001CC9A3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x001CE7B2 File Offset: 0x001CC9B2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600447B RID: 17531 RVA: 0x001CE7CC File Offset: 0x001CC9CC
		public int DropIds
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

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600447C RID: 17532 RVA: 0x001CE808 File Offset: 0x001CCA08
		public int UnLockCondition
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

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600447D RID: 17533 RVA: 0x001CE848 File Offset: 0x001CCA48
		public int LevelUnlockCount
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

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x001CE888 File Offset: 0x001CCA88
		public int RewardUnlockCount
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

		// Token: 0x04004AB2 RID: 19122
		private Table __p;
	}
}
