using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB3 RID: 4019
	public struct RegressRewards : IFlatbufferObject
	{
		// Token: 0x17002DCA RID: 11722
		// (get) Token: 0x0600BB3D RID: 47933 RVA: 0x002DC8A9 File Offset: 0x002DAAA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB3E RID: 47934 RVA: 0x002DC8B6 File Offset: 0x002DAAB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB3F RID: 47935 RVA: 0x002DC8C0 File Offset: 0x002DAAC0
		public static RegressRewards GetRootAsRegressRewards(ByteBuffer _bb)
		{
			return RegressRewards.GetRootAsRegressRewards(_bb, default(RegressRewards));
		}

		// Token: 0x0600BB40 RID: 47936 RVA: 0x002DC8DC File Offset: 0x002DAADC
		public static RegressRewards GetRootAsRegressRewards(ByteBuffer _bb, RegressRewards obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB41 RID: 47937 RVA: 0x002DC8F9 File Offset: 0x002DAAF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB42 RID: 47938 RVA: 0x002DC908 File Offset: 0x002DAB08
		public RegressRewards __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x0600BB43 RID: 47939 RVA: 0x002DC918 File Offset: 0x002DAB18
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

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x0600BB44 RID: 47940 RVA: 0x002DC954 File Offset: 0x002DAB54
		public int RewardGroup
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

		// Token: 0x0400508C RID: 20620
		private Table __p;
	}
}
