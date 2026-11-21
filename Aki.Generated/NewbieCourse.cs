using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F65 RID: 3941
	public struct NewbieCourse : IFlatbufferObject
	{
		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x0600A471 RID: 42097 RVA: 0x002B9594 File Offset: 0x002B7794
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A472 RID: 42098 RVA: 0x002B95A1 File Offset: 0x002B77A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A473 RID: 42099 RVA: 0x002B95A8 File Offset: 0x002B77A8
		public static NewbieCourse GetRootAsNewbieCourse(ByteBuffer _bb)
		{
			return NewbieCourse.GetRootAsNewbieCourse(_bb, default(NewbieCourse));
		}

		// Token: 0x0600A474 RID: 42100 RVA: 0x002B95C4 File Offset: 0x002B77C4
		public static NewbieCourse GetRootAsNewbieCourse(ByteBuffer _bb, NewbieCourse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A475 RID: 42101 RVA: 0x002B95E1 File Offset: 0x002B77E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A476 RID: 42102 RVA: 0x002B95F0 File Offset: 0x002B77F0
		public NewbieCourse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x0600A477 RID: 42103 RVA: 0x002B9600 File Offset: 0x002B7800
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

		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x0600A478 RID: 42104 RVA: 0x002B963C File Offset: 0x002B783C
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

		// Token: 0x04005513 RID: 21779
		private Table __p;
	}
}
