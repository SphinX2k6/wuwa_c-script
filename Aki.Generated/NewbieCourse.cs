using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E80 RID: 3712
	public struct NewbieCourse : IFlatbufferObject
	{
		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x06009E51 RID: 40529 RVA: 0x0029BF00 File Offset: 0x0029A100
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E52 RID: 40530 RVA: 0x0029BF0D File Offset: 0x0029A10D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E53 RID: 40531 RVA: 0x0029BF14 File Offset: 0x0029A114
		public static NewbieCourse GetRootAsNewbieCourse(ByteBuffer _bb)
		{
			return NewbieCourse.GetRootAsNewbieCourse(_bb, default(NewbieCourse));
		}

		// Token: 0x06009E54 RID: 40532 RVA: 0x0029BF30 File Offset: 0x0029A130
		public static NewbieCourse GetRootAsNewbieCourse(ByteBuffer _bb, NewbieCourse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E55 RID: 40533 RVA: 0x0029BF4D File Offset: 0x0029A14D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E56 RID: 40534 RVA: 0x0029BF5C File Offset: 0x0029A15C
		public NewbieCourse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x06009E57 RID: 40535 RVA: 0x0029BF6C File Offset: 0x0029A16C
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

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x06009E58 RID: 40536 RVA: 0x0029BFA8 File Offset: 0x0029A1A8
		public int Reward
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

		// Token: 0x04004F2E RID: 20270
		private Table __p;
	}
}
