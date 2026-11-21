using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200116E RID: 4462
	public struct RoverRogueBlessGroup : IFlatbufferObject
	{
		// Token: 0x1700351E RID: 13598
		// (get) Token: 0x0600D4F4 RID: 54516 RVA: 0x0032422C File Offset: 0x0032242C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D4F5 RID: 54517 RVA: 0x00324239 File Offset: 0x00322439
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D4F6 RID: 54518 RVA: 0x00324240 File Offset: 0x00322440
		public static RoverRogueBlessGroup GetRootAsRoverRogueBlessGroup(ByteBuffer _bb)
		{
			return RoverRogueBlessGroup.GetRootAsRoverRogueBlessGroup(_bb, default(RoverRogueBlessGroup));
		}

		// Token: 0x0600D4F7 RID: 54519 RVA: 0x0032425C File Offset: 0x0032245C
		public static RoverRogueBlessGroup GetRootAsRoverRogueBlessGroup(ByteBuffer _bb, RoverRogueBlessGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D4F8 RID: 54520 RVA: 0x00324279 File Offset: 0x00322479
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D4F9 RID: 54521 RVA: 0x00324288 File Offset: 0x00322488
		public RoverRogueBlessGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700351F RID: 13599
		// (get) Token: 0x0600D4FA RID: 54522 RVA: 0x00324298 File Offset: 0x00322498
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

		// Token: 0x17003520 RID: 13600
		// (get) Token: 0x0600D4FB RID: 54523 RVA: 0x003242D4 File Offset: 0x003224D4
		public int BlessRoleId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400577B RID: 22395
		private Table __p;
	}
}
