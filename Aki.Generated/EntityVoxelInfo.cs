using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D1C RID: 3356
	public struct EntityVoxelInfo : IFlatbufferObject
	{
		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06006FCB RID: 28619 RVA: 0x00243ADC File Offset: 0x00241CDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006FCC RID: 28620 RVA: 0x00243AE9 File Offset: 0x00241CE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006FCD RID: 28621 RVA: 0x00243AF0 File Offset: 0x00241CF0
		public static EntityVoxelInfo GetRootAsEntityVoxelInfo(ByteBuffer _bb)
		{
			return EntityVoxelInfo.GetRootAsEntityVoxelInfo(_bb, default(EntityVoxelInfo));
		}

		// Token: 0x06006FCE RID: 28622 RVA: 0x00243B0C File Offset: 0x00241D0C
		public static EntityVoxelInfo GetRootAsEntityVoxelInfo(ByteBuffer _bb, EntityVoxelInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x00243B29 File Offset: 0x00241D29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006FD0 RID: 28624 RVA: 0x00243B38 File Offset: 0x00241D38
		public EntityVoxelInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06006FD1 RID: 28625 RVA: 0x00243B48 File Offset: 0x00241D48
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

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06006FD2 RID: 28626 RVA: 0x00243B84 File Offset: 0x00241D84
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

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06006FD3 RID: 28627 RVA: 0x00243BC0 File Offset: 0x00241DC0
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

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06006FD4 RID: 28628 RVA: 0x00243BFC File Offset: 0x00241DFC
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

		// Token: 0x0400525C RID: 21084
		private Table __p;
	}
}
