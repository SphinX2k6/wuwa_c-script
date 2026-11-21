using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D93 RID: 3475
	public struct FloroRanchReward : IFlatbufferObject
	{
		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x060079C3 RID: 31171 RVA: 0x0025AC10 File Offset: 0x00258E10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060079C4 RID: 31172 RVA: 0x0025AC1D File Offset: 0x00258E1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060079C5 RID: 31173 RVA: 0x0025AC24 File Offset: 0x00258E24
		public static FloroRanchReward GetRootAsFloroRanchReward(ByteBuffer _bb)
		{
			return FloroRanchReward.GetRootAsFloroRanchReward(_bb, default(FloroRanchReward));
		}

		// Token: 0x060079C6 RID: 31174 RVA: 0x0025AC40 File Offset: 0x00258E40
		public static FloroRanchReward GetRootAsFloroRanchReward(ByteBuffer _bb, FloroRanchReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060079C7 RID: 31175 RVA: 0x0025AC5D File Offset: 0x00258E5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060079C8 RID: 31176 RVA: 0x0025AC6C File Offset: 0x00258E6C
		public FloroRanchReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x060079C9 RID: 31177 RVA: 0x0025AC7C File Offset: 0x00258E7C
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

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x060079CA RID: 31178 RVA: 0x0025ACB8 File Offset: 0x00258EB8
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

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x060079CB RID: 31179 RVA: 0x0025ACF4 File Offset: 0x00258EF4
		public int Index
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

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x060079CC RID: 31180 RVA: 0x0025AD30 File Offset: 0x00258F30
		public int NeedNum
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

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x060079CD RID: 31181 RVA: 0x0025AD70 File Offset: 0x00258F70
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

		// Token: 0x040052F7 RID: 21239
		private Table __p;
	}
}
