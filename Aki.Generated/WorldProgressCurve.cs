using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012DD RID: 4829
	public struct WorldProgressCurve : IFlatbufferObject
	{
		// Token: 0x170041DF RID: 16863
		// (get) Token: 0x0600F6BE RID: 63166 RVA: 0x003709F4 File Offset: 0x0036EBF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F6BF RID: 63167 RVA: 0x00370A01 File Offset: 0x0036EC01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F6C0 RID: 63168 RVA: 0x00370A08 File Offset: 0x0036EC08
		public static WorldProgressCurve GetRootAsWorldProgressCurve(ByteBuffer _bb)
		{
			return WorldProgressCurve.GetRootAsWorldProgressCurve(_bb, default(WorldProgressCurve));
		}

		// Token: 0x0600F6C1 RID: 63169 RVA: 0x00370A24 File Offset: 0x0036EC24
		public static WorldProgressCurve GetRootAsWorldProgressCurve(ByteBuffer _bb, WorldProgressCurve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F6C2 RID: 63170 RVA: 0x00370A41 File Offset: 0x0036EC41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F6C3 RID: 63171 RVA: 0x00370A50 File Offset: 0x0036EC50
		public WorldProgressCurve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041E0 RID: 16864
		// (get) Token: 0x0600F6C4 RID: 63172 RVA: 0x00370A60 File Offset: 0x0036EC60
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

		// Token: 0x170041E1 RID: 16865
		// (get) Token: 0x0600F6C5 RID: 63173 RVA: 0x00370A9C File Offset: 0x0036EC9C
		public int OpenDay
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

		// Token: 0x170041E2 RID: 16866
		// (get) Token: 0x0600F6C6 RID: 63174 RVA: 0x00370AD8 File Offset: 0x0036ECD8
		public int PersonalScore
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

		// Token: 0x170041E3 RID: 16867
		// (get) Token: 0x0600F6C7 RID: 63175 RVA: 0x00370B14 File Offset: 0x0036ED14
		public int Percent
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

		// Token: 0x170041E4 RID: 16868
		// (get) Token: 0x0600F6C8 RID: 63176 RVA: 0x00370B54 File Offset: 0x0036ED54
		public int DropId
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

		// Token: 0x170041E5 RID: 16869
		// (get) Token: 0x0600F6C9 RID: 63177 RVA: 0x00370B94 File Offset: 0x0036ED94
		public int MotorPreviewId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005937 RID: 22839
		private Table __p;
	}
}
