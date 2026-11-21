using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200121E RID: 4638
	public struct SpringFestivalMainTask : IFlatbufferObject
	{
		// Token: 0x17003B77 RID: 15223
		// (get) Token: 0x0600E605 RID: 58885 RVA: 0x0034B3E6 File Offset: 0x003495E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E606 RID: 58886 RVA: 0x0034B3F3 File Offset: 0x003495F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E607 RID: 58887 RVA: 0x0034B3FC File Offset: 0x003495FC
		public static SpringFestivalMainTask GetRootAsSpringFestivalMainTask(ByteBuffer _bb)
		{
			return SpringFestivalMainTask.GetRootAsSpringFestivalMainTask(_bb, default(SpringFestivalMainTask));
		}

		// Token: 0x0600E608 RID: 58888 RVA: 0x0034B418 File Offset: 0x00349618
		public static SpringFestivalMainTask GetRootAsSpringFestivalMainTask(ByteBuffer _bb, SpringFestivalMainTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E609 RID: 58889 RVA: 0x0034B435 File Offset: 0x00349635
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E60A RID: 58890 RVA: 0x0034B444 File Offset: 0x00349644
		public SpringFestivalMainTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B78 RID: 15224
		// (get) Token: 0x0600E60B RID: 58891 RVA: 0x0034B454 File Offset: 0x00349654
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

		// Token: 0x17003B79 RID: 15225
		// (get) Token: 0x0600E60C RID: 58892 RVA: 0x0034B490 File Offset: 0x00349690
		public int QuestId
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

		// Token: 0x17003B7A RID: 15226
		// (get) Token: 0x0600E60D RID: 58893 RVA: 0x0034B4CC File Offset: 0x003496CC
		public int OpenDay
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

		// Token: 0x17003B7B RID: 15227
		// (get) Token: 0x0600E60E RID: 58894 RVA: 0x0034B508 File Offset: 0x00349708
		public string LockDesc
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

		// Token: 0x0600E60F RID: 58895 RVA: 0x0034B540 File Offset: 0x00349740
		public Span<byte> GetLockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E610 RID: 58896 RVA: 0x0034B550 File Offset: 0x00349750
		public byte[] GetLockDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400585F RID: 22623
		private Table __p;
	}
}
