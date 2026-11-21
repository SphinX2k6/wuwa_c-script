using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D31 RID: 3377
	public struct ExploreProgressReward : IFlatbufferObject
	{
		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06007167 RID: 29031 RVA: 0x002475AE File Offset: 0x002457AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007168 RID: 29032 RVA: 0x002475BB File Offset: 0x002457BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007169 RID: 29033 RVA: 0x002475C4 File Offset: 0x002457C4
		public static ExploreProgressReward GetRootAsExploreProgressReward(ByteBuffer _bb)
		{
			return ExploreProgressReward.GetRootAsExploreProgressReward(_bb, default(ExploreProgressReward));
		}

		// Token: 0x0600716A RID: 29034 RVA: 0x002475E0 File Offset: 0x002457E0
		public static ExploreProgressReward GetRootAsExploreProgressReward(ByteBuffer _bb, ExploreProgressReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600716B RID: 29035 RVA: 0x002475FD File Offset: 0x002457FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600716C RID: 29036 RVA: 0x0024760C File Offset: 0x0024580C
		public ExploreProgressReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x0600716D RID: 29037 RVA: 0x0024761C File Offset: 0x0024581C
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

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x0600716E RID: 29038 RVA: 0x00247658 File Offset: 0x00245858
		public int Area
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

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x0600716F RID: 29039 RVA: 0x00247694 File Offset: 0x00245894
		public int StepId
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

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06007170 RID: 29040 RVA: 0x002476D0 File Offset: 0x002458D0
		public int DropReward
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06007171 RID: 29041 RVA: 0x00247710 File Offset: 0x00245910
		public int NeedExploreProgress
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005278 RID: 21112
		private Table __p;
	}
}
