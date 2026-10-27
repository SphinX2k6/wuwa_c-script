using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001123 RID: 4387
	public struct TetrisAchievement : IFlatbufferObject
	{
		// Token: 0x17003A29 RID: 14889
		// (get) Token: 0x0600DE0A RID: 56842 RVA: 0x0032C1E4 File Offset: 0x0032A3E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE0B RID: 56843 RVA: 0x0032C1F1 File Offset: 0x0032A3F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE0C RID: 56844 RVA: 0x0032C1F8 File Offset: 0x0032A3F8
		public static TetrisAchievement GetRootAsTetrisAchievement(ByteBuffer _bb)
		{
			return TetrisAchievement.GetRootAsTetrisAchievement(_bb, default(TetrisAchievement));
		}

		// Token: 0x0600DE0D RID: 56845 RVA: 0x0032C214 File Offset: 0x0032A414
		public static TetrisAchievement GetRootAsTetrisAchievement(ByteBuffer _bb, TetrisAchievement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE0E RID: 56846 RVA: 0x0032C231 File Offset: 0x0032A431
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE0F RID: 56847 RVA: 0x0032C240 File Offset: 0x0032A440
		public TetrisAchievement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A2A RID: 14890
		// (get) Token: 0x0600DE10 RID: 56848 RVA: 0x0032C250 File Offset: 0x0032A450
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

		// Token: 0x17003A2B RID: 14891
		// (get) Token: 0x0600DE11 RID: 56849 RVA: 0x0032C28C File Offset: 0x0032A48C
		public int Condition
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

		// Token: 0x04005261 RID: 21089
		private Table __p;
	}
}
