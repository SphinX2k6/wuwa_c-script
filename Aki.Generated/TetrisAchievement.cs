using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001259 RID: 4697
	public struct TetrisAchievement : IFlatbufferObject
	{
		// Token: 0x17003D83 RID: 15747
		// (get) Token: 0x0600EB59 RID: 60249 RVA: 0x00357404 File Offset: 0x00355604
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB5A RID: 60250 RVA: 0x00357411 File Offset: 0x00355611
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB5B RID: 60251 RVA: 0x00357418 File Offset: 0x00355618
		public static TetrisAchievement GetRootAsTetrisAchievement(ByteBuffer _bb)
		{
			return TetrisAchievement.GetRootAsTetrisAchievement(_bb, default(TetrisAchievement));
		}

		// Token: 0x0600EB5C RID: 60252 RVA: 0x00357434 File Offset: 0x00355634
		public static TetrisAchievement GetRootAsTetrisAchievement(ByteBuffer _bb, TetrisAchievement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB5D RID: 60253 RVA: 0x00357451 File Offset: 0x00355651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB5E RID: 60254 RVA: 0x00357460 File Offset: 0x00355660
		public TetrisAchievement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D84 RID: 15748
		// (get) Token: 0x0600EB5F RID: 60255 RVA: 0x00357470 File Offset: 0x00355670
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

		// Token: 0x17003D85 RID: 15749
		// (get) Token: 0x0600EB60 RID: 60256 RVA: 0x003574AC File Offset: 0x003556AC
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

		// Token: 0x040058A4 RID: 22692
		private Table __p;
	}
}
