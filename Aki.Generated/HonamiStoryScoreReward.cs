using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E34 RID: 3636
	public struct HonamiStoryScoreReward : IFlatbufferObject
	{
		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x0600875A RID: 34650 RVA: 0x00278C20 File Offset: 0x00276E20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600875B RID: 34651 RVA: 0x00278C2D File Offset: 0x00276E2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600875C RID: 34652 RVA: 0x00278C34 File Offset: 0x00276E34
		public static HonamiStoryScoreReward GetRootAsHonamiStoryScoreReward(ByteBuffer _bb)
		{
			return HonamiStoryScoreReward.GetRootAsHonamiStoryScoreReward(_bb, default(HonamiStoryScoreReward));
		}

		// Token: 0x0600875D RID: 34653 RVA: 0x00278C50 File Offset: 0x00276E50
		public static HonamiStoryScoreReward GetRootAsHonamiStoryScoreReward(ByteBuffer _bb, HonamiStoryScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600875E RID: 34654 RVA: 0x00278C6D File Offset: 0x00276E6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600875F RID: 34655 RVA: 0x00278C7C File Offset: 0x00276E7C
		public HonamiStoryScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x06008760 RID: 34656 RVA: 0x00278C8C File Offset: 0x00276E8C
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

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x06008761 RID: 34657 RVA: 0x00278CC8 File Offset: 0x00276EC8
		public int ActivityId
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

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x06008762 RID: 34658 RVA: 0x00278D04 File Offset: 0x00276F04
		public int Score
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

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x06008763 RID: 34659 RVA: 0x00278D40 File Offset: 0x00276F40
		public int DropId
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

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06008764 RID: 34660 RVA: 0x00278D80 File Offset: 0x00276F80
		public string Name
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

		// Token: 0x06008765 RID: 34661 RVA: 0x00278DB8 File Offset: 0x00276FB8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008766 RID: 34662 RVA: 0x00278DC8 File Offset: 0x00276FC8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x06008767 RID: 34663 RVA: 0x00278DE0 File Offset: 0x00276FE0
		public string LockTip
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008768 RID: 34664 RVA: 0x00278E18 File Offset: 0x00277018
		public Span<byte> GetLockTipBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008769 RID: 34665 RVA: 0x00278E28 File Offset: 0x00277028
		public byte[] GetLockTipArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040053B1 RID: 21425
		private Table __p;
	}
}
