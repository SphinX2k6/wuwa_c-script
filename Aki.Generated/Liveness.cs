using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB8 RID: 3768
	public struct Liveness : IFlatbufferObject
	{
		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x0600950A RID: 38154 RVA: 0x00297DDD File Offset: 0x00295FDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600950B RID: 38155 RVA: 0x00297DEA File Offset: 0x00295FEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600950C RID: 38156 RVA: 0x00297DF4 File Offset: 0x00295FF4
		public static Liveness GetRootAsLiveness(ByteBuffer _bb)
		{
			return Liveness.GetRootAsLiveness(_bb, default(Liveness));
		}

		// Token: 0x0600950D RID: 38157 RVA: 0x00297E10 File Offset: 0x00296010
		public static Liveness GetRootAsLiveness(ByteBuffer _bb, Liveness obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600950E RID: 38158 RVA: 0x00297E2D File Offset: 0x0029602D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600950F RID: 38159 RVA: 0x00297E3C File Offset: 0x0029603C
		public Liveness __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06009510 RID: 38160 RVA: 0x00297E4C File Offset: 0x0029604C
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

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x06009511 RID: 38161 RVA: 0x00297E88 File Offset: 0x00296088
		public int Goal
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

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x06009512 RID: 38162 RVA: 0x00297EC4 File Offset: 0x002960C4
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

		// Token: 0x04005452 RID: 21586
		private Table __p;
	}
}
