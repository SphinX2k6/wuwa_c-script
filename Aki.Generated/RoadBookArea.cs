using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B8 RID: 4280
	public struct RoadBookArea : IFlatbufferObject
	{
		// Token: 0x17002F2B RID: 12075
		// (get) Token: 0x0600C3F2 RID: 50162 RVA: 0x002FE2AC File Offset: 0x002FC4AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C3F3 RID: 50163 RVA: 0x002FE2B9 File Offset: 0x002FC4B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C3F4 RID: 50164 RVA: 0x002FE2C0 File Offset: 0x002FC4C0
		public static RoadBookArea GetRootAsRoadBookArea(ByteBuffer _bb)
		{
			return RoadBookArea.GetRootAsRoadBookArea(_bb, default(RoadBookArea));
		}

		// Token: 0x0600C3F5 RID: 50165 RVA: 0x002FE2DC File Offset: 0x002FC4DC
		public static RoadBookArea GetRootAsRoadBookArea(ByteBuffer _bb, RoadBookArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C3F6 RID: 50166 RVA: 0x002FE2F9 File Offset: 0x002FC4F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C3F7 RID: 50167 RVA: 0x002FE308 File Offset: 0x002FC508
		public RoadBookArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F2C RID: 12076
		// (get) Token: 0x0600C3F8 RID: 50168 RVA: 0x002FE318 File Offset: 0x002FC518
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

		// Token: 0x17002F2D RID: 12077
		// (get) Token: 0x0600C3F9 RID: 50169 RVA: 0x002FE354 File Offset: 0x002FC554
		public int ActivityId
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

		// Token: 0x17002F2E RID: 12078
		// (get) Token: 0x0600C3FA RID: 50170 RVA: 0x002FE390 File Offset: 0x002FC590
		public int UnLockCondition
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

		// Token: 0x17002F2F RID: 12079
		// (get) Token: 0x0600C3FB RID: 50171 RVA: 0x002FE3CC File Offset: 0x002FC5CC
		public int UnlockAccessId
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

		// Token: 0x17002F30 RID: 12080
		// (get) Token: 0x0600C3FC RID: 50172 RVA: 0x002FE40C File Offset: 0x002FC60C
		public int Sort
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

		// Token: 0x04005693 RID: 22163
		private Table __p;
	}
}
