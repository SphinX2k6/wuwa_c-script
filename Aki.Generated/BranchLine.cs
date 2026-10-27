using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B4D RID: 2893
	public struct BranchLine : IFlatbufferObject
	{
		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06004F94 RID: 20372 RVA: 0x001E885D File Offset: 0x001E6A5D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F95 RID: 20373 RVA: 0x001E886A File Offset: 0x001E6A6A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F96 RID: 20374 RVA: 0x001E8874 File Offset: 0x001E6A74
		public static BranchLine GetRootAsBranchLine(ByteBuffer _bb)
		{
			return BranchLine.GetRootAsBranchLine(_bb, default(BranchLine));
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x001E8890 File Offset: 0x001E6A90
		public static BranchLine GetRootAsBranchLine(ByteBuffer _bb, BranchLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x001E88AD File Offset: 0x001E6AAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F99 RID: 20377 RVA: 0x001E88BC File Offset: 0x001E6ABC
		public BranchLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06004F9A RID: 20378 RVA: 0x001E88CC File Offset: 0x001E6ACC
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

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06004F9B RID: 20379 RVA: 0x001E8908 File Offset: 0x001E6B08
		public int TaskId
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

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06004F9C RID: 20380 RVA: 0x001E8944 File Offset: 0x001E6B44
		public int JumpBuildingId
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

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06004F9D RID: 20381 RVA: 0x001E8980 File Offset: 0x001E6B80
		public int AssociateRole
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

		// Token: 0x04004B48 RID: 19272
		private Table __p;
	}
}
