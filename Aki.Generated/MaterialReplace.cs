using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E06 RID: 3590
	public struct MaterialReplace : IFlatbufferObject
	{
		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x06009368 RID: 37736 RVA: 0x00283BA8 File Offset: 0x00281DA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009369 RID: 37737 RVA: 0x00283BB5 File Offset: 0x00281DB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600936A RID: 37738 RVA: 0x00283BBC File Offset: 0x00281DBC
		public static MaterialReplace GetRootAsMaterialReplace(ByteBuffer _bb)
		{
			return MaterialReplace.GetRootAsMaterialReplace(_bb, default(MaterialReplace));
		}

		// Token: 0x0600936B RID: 37739 RVA: 0x00283BD8 File Offset: 0x00281DD8
		public static MaterialReplace GetRootAsMaterialReplace(ByteBuffer _bb, MaterialReplace obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600936C RID: 37740 RVA: 0x00283BF5 File Offset: 0x00281DF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600936D RID: 37741 RVA: 0x00283C04 File Offset: 0x00281E04
		public MaterialReplace __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x0600936E RID: 37742 RVA: 0x00283C14 File Offset: 0x00281E14
		public int ItemId
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

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x0600936F RID: 37743 RVA: 0x00283C50 File Offset: 0x00281E50
		public int GroupId
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

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x06009370 RID: 37744 RVA: 0x00283C8C File Offset: 0x00281E8C
		public int ShowGroupId
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

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x06009371 RID: 37745 RVA: 0x00283CC8 File Offset: 0x00281EC8
		public int SortId
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

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x06009372 RID: 37746 RVA: 0x00283D08 File Offset: 0x00281F08
		public int ExchangeParam
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004EA7 RID: 20135
		private Table __p;
	}
}
