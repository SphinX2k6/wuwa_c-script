using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C78 RID: 3192
	public struct FishingBait : IFlatbufferObject
	{
		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06006ED4 RID: 28372 RVA: 0x0022FD35 File Offset: 0x0022DF35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006ED5 RID: 28373 RVA: 0x0022FD42 File Offset: 0x0022DF42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006ED6 RID: 28374 RVA: 0x0022FD4C File Offset: 0x0022DF4C
		public static FishingBait GetRootAsFishingBait(ByteBuffer _bb)
		{
			return FishingBait.GetRootAsFishingBait(_bb, default(FishingBait));
		}

		// Token: 0x06006ED7 RID: 28375 RVA: 0x0022FD68 File Offset: 0x0022DF68
		public static FishingBait GetRootAsFishingBait(ByteBuffer _bb, FishingBait obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006ED8 RID: 28376 RVA: 0x0022FD85 File Offset: 0x0022DF85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006ED9 RID: 28377 RVA: 0x0022FD94 File Offset: 0x0022DF94
		public FishingBait __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06006EDA RID: 28378 RVA: 0x0022FDA4 File Offset: 0x0022DFA4
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

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06006EDB RID: 28379 RVA: 0x0022FDE0 File Offset: 0x0022DFE0
		public int ExploreToolId
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

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06006EDC RID: 28380 RVA: 0x0022FE1C File Offset: 0x0022E01C
		public int AreaId
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

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06006EDD RID: 28381 RVA: 0x0022FE58 File Offset: 0x0022E058
		public int GamePlayId
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

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06006EDE RID: 28382 RVA: 0x0022FE98 File Offset: 0x0022E098
		public int ItemId
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

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06006EDF RID: 28383 RVA: 0x0022FED8 File Offset: 0x0022E0D8
		public int CountLimit
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

		// Token: 0x04004CC3 RID: 19651
		private Table __p;
	}
}
