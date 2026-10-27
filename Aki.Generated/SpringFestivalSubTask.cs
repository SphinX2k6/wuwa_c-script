using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010ED RID: 4333
	public struct SpringFestivalSubTask : IFlatbufferObject
	{
		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x0600D909 RID: 55561 RVA: 0x00320969 File Offset: 0x0031EB69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D90A RID: 55562 RVA: 0x00320976 File Offset: 0x0031EB76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D90B RID: 55563 RVA: 0x00320980 File Offset: 0x0031EB80
		public static SpringFestivalSubTask GetRootAsSpringFestivalSubTask(ByteBuffer _bb)
		{
			return SpringFestivalSubTask.GetRootAsSpringFestivalSubTask(_bb, default(SpringFestivalSubTask));
		}

		// Token: 0x0600D90C RID: 55564 RVA: 0x0032099C File Offset: 0x0031EB9C
		public static SpringFestivalSubTask GetRootAsSpringFestivalSubTask(ByteBuffer _bb, SpringFestivalSubTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D90D RID: 55565 RVA: 0x003209B9 File Offset: 0x0031EBB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D90E RID: 55566 RVA: 0x003209C8 File Offset: 0x0031EBC8
		public SpringFestivalSubTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x0600D90F RID: 55567 RVA: 0x003209D8 File Offset: 0x0031EBD8
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

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x0600D910 RID: 55568 RVA: 0x00320A14 File Offset: 0x0031EC14
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

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x0600D911 RID: 55569 RVA: 0x00320A50 File Offset: 0x0031EC50
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

		// Token: 0x04005221 RID: 21025
		private Table __p;
	}
}
