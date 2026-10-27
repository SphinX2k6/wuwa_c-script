using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C75 RID: 3189
	public struct FishingActivityGroup : IFlatbufferObject
	{
		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06006EB1 RID: 28337 RVA: 0x0022F889 File Offset: 0x0022DA89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x0022F896 File Offset: 0x0022DA96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x0022F8A0 File Offset: 0x0022DAA0
		public static FishingActivityGroup GetRootAsFishingActivityGroup(ByteBuffer _bb)
		{
			return FishingActivityGroup.GetRootAsFishingActivityGroup(_bb, default(FishingActivityGroup));
		}

		// Token: 0x06006EB4 RID: 28340 RVA: 0x0022F8BC File Offset: 0x0022DABC
		public static FishingActivityGroup GetRootAsFishingActivityGroup(ByteBuffer _bb, FishingActivityGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006EB5 RID: 28341 RVA: 0x0022F8D9 File Offset: 0x0022DAD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x0022F8E8 File Offset: 0x0022DAE8
		public FishingActivityGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06006EB7 RID: 28343 RVA: 0x0022F8F8 File Offset: 0x0022DAF8
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

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06006EB8 RID: 28344 RVA: 0x0022F934 File Offset: 0x0022DB34
		public string GroupName
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

		// Token: 0x06006EB9 RID: 28345 RVA: 0x0022F96B File Offset: 0x0022DB6B
		public Span<byte> GetGroupNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x0022F97A File Offset: 0x0022DB7A
		public byte[] GetGroupNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CC0 RID: 19648
		private Table __p;
	}
}
