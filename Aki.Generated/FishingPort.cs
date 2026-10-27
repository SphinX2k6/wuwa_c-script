using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C86 RID: 3206
	public struct FishingPort : IFlatbufferObject
	{
		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06006FEE RID: 28654 RVA: 0x0023298A File Offset: 0x00230B8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x00232997 File Offset: 0x00230B97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x002329A0 File Offset: 0x00230BA0
		public static FishingPort GetRootAsFishingPort(ByteBuffer _bb)
		{
			return FishingPort.GetRootAsFishingPort(_bb, default(FishingPort));
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x002329BC File Offset: 0x00230BBC
		public static FishingPort GetRootAsFishingPort(ByteBuffer _bb, FishingPort obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x002329D9 File Offset: 0x00230BD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006FF3 RID: 28659 RVA: 0x002329E8 File Offset: 0x00230BE8
		public FishingPort __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06006FF4 RID: 28660 RVA: 0x002329F8 File Offset: 0x00230BF8
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

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06006FF5 RID: 28661 RVA: 0x00232A34 File Offset: 0x00230C34
		public int EntityConfigId
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

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06006FF6 RID: 28662 RVA: 0x00232A70 File Offset: 0x00230C70
		public int NpcEntityConfigId
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

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06006FF7 RID: 28663 RVA: 0x00232AAC File Offset: 0x00230CAC
		public int UnlockCondition
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

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06006FF8 RID: 28664 RVA: 0x00232AEC File Offset: 0x00230CEC
		public int SceneConfigId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06006FF9 RID: 28665 RVA: 0x00232B2C File Offset: 0x00230D2C
		public int SailingPoint
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

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06006FFA RID: 28666 RVA: 0x00232B6C File Offset: 0x00230D6C
		public int AshorePoint
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06006FFB RID: 28667 RVA: 0x00232BAC File Offset: 0x00230DAC
		public int MarkId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06006FFC RID: 28668 RVA: 0x00232BEC File Offset: 0x00230DEC
		public int ShopId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x06006FFD RID: 28669 RVA: 0x00232C2C File Offset: 0x00230E2C
		public int EnterRange
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06006FFE RID: 28670 RVA: 0x00232C6C File Offset: 0x00230E6C
		public int LeaveRange
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06006FFF RID: 28671 RVA: 0x00232CAC File Offset: 0x00230EAC
		public int RangeCenter
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004CD8 RID: 19672
		private Table __p;
	}
}
