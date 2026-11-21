using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E31 RID: 3633
	public struct HonamiStoryResidentTask : IFlatbufferObject
	{
		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x06008734 RID: 34612 RVA: 0x00278679 File Offset: 0x00276879
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008735 RID: 34613 RVA: 0x00278686 File Offset: 0x00276886
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008736 RID: 34614 RVA: 0x00278690 File Offset: 0x00276890
		public static HonamiStoryResidentTask GetRootAsHonamiStoryResidentTask(ByteBuffer _bb)
		{
			return HonamiStoryResidentTask.GetRootAsHonamiStoryResidentTask(_bb, default(HonamiStoryResidentTask));
		}

		// Token: 0x06008737 RID: 34615 RVA: 0x002786AC File Offset: 0x002768AC
		public static HonamiStoryResidentTask GetRootAsHonamiStoryResidentTask(ByteBuffer _bb, HonamiStoryResidentTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008738 RID: 34616 RVA: 0x002786C9 File Offset: 0x002768C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008739 RID: 34617 RVA: 0x002786D8 File Offset: 0x002768D8
		public HonamiStoryResidentTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x0600873A RID: 34618 RVA: 0x002786E8 File Offset: 0x002768E8
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

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x0600873B RID: 34619 RVA: 0x00278724 File Offset: 0x00276924
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

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x0600873C RID: 34620 RVA: 0x00278760 File Offset: 0x00276960
		public int DropId
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

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x0600873D RID: 34621 RVA: 0x0027879C File Offset: 0x0027699C
		public string RewardName
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

		// Token: 0x0600873E RID: 34622 RVA: 0x002787D4 File Offset: 0x002769D4
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600873F RID: 34623 RVA: 0x002787E4 File Offset: 0x002769E4
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x06008740 RID: 34624 RVA: 0x002787FC File Offset: 0x002769FC
		public int JumpId
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

		// Token: 0x040053AD RID: 21421
		private Table __p;
	}
}
