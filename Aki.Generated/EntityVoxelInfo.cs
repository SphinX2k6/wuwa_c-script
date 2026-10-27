using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C39 RID: 3129
	public struct EntityVoxelInfo : IFlatbufferObject
	{
		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x060069C9 RID: 27081 RVA: 0x00224794 File Offset: 0x00222994
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060069CA RID: 27082 RVA: 0x002247A1 File Offset: 0x002229A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060069CB RID: 27083 RVA: 0x002247A8 File Offset: 0x002229A8
		public static EntityVoxelInfo GetRootAsEntityVoxelInfo(ByteBuffer _bb)
		{
			return EntityVoxelInfo.GetRootAsEntityVoxelInfo(_bb, default(EntityVoxelInfo));
		}

		// Token: 0x060069CC RID: 27084 RVA: 0x002247C4 File Offset: 0x002229C4
		public static EntityVoxelInfo GetRootAsEntityVoxelInfo(ByteBuffer _bb, EntityVoxelInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060069CD RID: 27085 RVA: 0x002247E1 File Offset: 0x002229E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060069CE RID: 27086 RVA: 0x002247F0 File Offset: 0x002229F0
		public EntityVoxelInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x060069CF RID: 27087 RVA: 0x00224800 File Offset: 0x00222A00
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

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x060069D0 RID: 27088 RVA: 0x0022483C File Offset: 0x00222A3C
		public int MapId
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

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x060069D1 RID: 27089 RVA: 0x00224878 File Offset: 0x00222A78
		public int EntityId
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

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x060069D2 RID: 27090 RVA: 0x002248B4 File Offset: 0x00222AB4
		public int EnvType
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

		// Token: 0x04004C79 RID: 19577
		private Table __p;
	}
}
