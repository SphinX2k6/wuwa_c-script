using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C0E RID: 3086
	public struct DropCatchReward : IFlatbufferObject
	{
		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x060065A3 RID: 26019 RVA: 0x0021B7F1 File Offset: 0x002199F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060065A4 RID: 26020 RVA: 0x0021B7FE File Offset: 0x002199FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060065A5 RID: 26021 RVA: 0x0021B808 File Offset: 0x00219A08
		public static DropCatchReward GetRootAsDropCatchReward(ByteBuffer _bb)
		{
			return DropCatchReward.GetRootAsDropCatchReward(_bb, default(DropCatchReward));
		}

		// Token: 0x060065A6 RID: 26022 RVA: 0x0021B824 File Offset: 0x00219A24
		public static DropCatchReward GetRootAsDropCatchReward(ByteBuffer _bb, DropCatchReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060065A7 RID: 26023 RVA: 0x0021B841 File Offset: 0x00219A41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x0021B850 File Offset: 0x00219A50
		public DropCatchReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x060065A9 RID: 26025 RVA: 0x0021B860 File Offset: 0x00219A60
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

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x060065AA RID: 26026 RVA: 0x0021B89C File Offset: 0x00219A9C
		public int DropId
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

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x060065AB RID: 26027 RVA: 0x0021B8D8 File Offset: 0x00219AD8
		public int Score
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

		// Token: 0x04004C4B RID: 19531
		private Table __p;
	}
}
