using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001223 RID: 4643
	public struct SpringFestivalSubTask : IFlatbufferObject
	{
		// Token: 0x17003B9B RID: 15259
		// (get) Token: 0x0600E654 RID: 58964 RVA: 0x0034BEED File Offset: 0x0034A0ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E655 RID: 58965 RVA: 0x0034BEFA File Offset: 0x0034A0FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E656 RID: 58966 RVA: 0x0034BF04 File Offset: 0x0034A104
		public static SpringFestivalSubTask GetRootAsSpringFestivalSubTask(ByteBuffer _bb)
		{
			return SpringFestivalSubTask.GetRootAsSpringFestivalSubTask(_bb, default(SpringFestivalSubTask));
		}

		// Token: 0x0600E657 RID: 58967 RVA: 0x0034BF20 File Offset: 0x0034A120
		public static SpringFestivalSubTask GetRootAsSpringFestivalSubTask(ByteBuffer _bb, SpringFestivalSubTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E658 RID: 58968 RVA: 0x0034BF3D File Offset: 0x0034A13D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E659 RID: 58969 RVA: 0x0034BF4C File Offset: 0x0034A14C
		public SpringFestivalSubTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B9C RID: 15260
		// (get) Token: 0x0600E65A RID: 58970 RVA: 0x0034BF5C File Offset: 0x0034A15C
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

		// Token: 0x17003B9D RID: 15261
		// (get) Token: 0x0600E65B RID: 58971 RVA: 0x0034BF98 File Offset: 0x0034A198
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

		// Token: 0x17003B9E RID: 15262
		// (get) Token: 0x0600E65C RID: 58972 RVA: 0x0034BFD4 File Offset: 0x0034A1D4
		public int TrackEntity
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

		// Token: 0x04005864 RID: 22628
		private Table __p;
	}
}
