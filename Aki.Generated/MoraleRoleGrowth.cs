using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E2C RID: 3628
	public struct MoraleRoleGrowth : IFlatbufferObject
	{
		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x06009675 RID: 38517 RVA: 0x0028A6D9 File Offset: 0x002888D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009676 RID: 38518 RVA: 0x0028A6E6 File Offset: 0x002888E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009677 RID: 38519 RVA: 0x0028A6F0 File Offset: 0x002888F0
		public static MoraleRoleGrowth GetRootAsMoraleRoleGrowth(ByteBuffer _bb)
		{
			return MoraleRoleGrowth.GetRootAsMoraleRoleGrowth(_bb, default(MoraleRoleGrowth));
		}

		// Token: 0x06009678 RID: 38520 RVA: 0x0028A70C File Offset: 0x0028890C
		public static MoraleRoleGrowth GetRootAsMoraleRoleGrowth(ByteBuffer _bb, MoraleRoleGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009679 RID: 38521 RVA: 0x0028A729 File Offset: 0x00288929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600967A RID: 38522 RVA: 0x0028A738 File Offset: 0x00288938
		public MoraleRoleGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x0600967B RID: 38523 RVA: 0x0028A748 File Offset: 0x00288948
		public int Level
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

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x0600967C RID: 38524 RVA: 0x0028A784 File Offset: 0x00288984
		public int LifeMaxRatio
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

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x0600967D RID: 38525 RVA: 0x0028A7C0 File Offset: 0x002889C0
		public int AtkRatio
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

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x0600967E RID: 38526 RVA: 0x0028A7FC File Offset: 0x002889FC
		public int DefRatio
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

		// Token: 0x04004ED1 RID: 20177
		private Table __p;
	}
}
