using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D9B RID: 3483
	public struct FloroRanchTask : IFlatbufferObject
	{
		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06007A9D RID: 31389 RVA: 0x0025CD92 File Offset: 0x0025AF92
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A9E RID: 31390 RVA: 0x0025CD9F File Offset: 0x0025AF9F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A9F RID: 31391 RVA: 0x0025CDA8 File Offset: 0x0025AFA8
		public static FloroRanchTask GetRootAsFloroRanchTask(ByteBuffer _bb)
		{
			return FloroRanchTask.GetRootAsFloroRanchTask(_bb, default(FloroRanchTask));
		}

		// Token: 0x06007AA0 RID: 31392 RVA: 0x0025CDC4 File Offset: 0x0025AFC4
		public static FloroRanchTask GetRootAsFloroRanchTask(ByteBuffer _bb, FloroRanchTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007AA1 RID: 31393 RVA: 0x0025CDE1 File Offset: 0x0025AFE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007AA2 RID: 31394 RVA: 0x0025CDF0 File Offset: 0x0025AFF0
		public FloroRanchTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x06007AA3 RID: 31395 RVA: 0x0025CE00 File Offset: 0x0025B000
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

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06007AA4 RID: 31396 RVA: 0x0025CE3C File Offset: 0x0025B03C
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

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06007AA5 RID: 31397 RVA: 0x0025CE78 File Offset: 0x0025B078
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

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06007AA6 RID: 31398 RVA: 0x0025CEB4 File Offset: 0x0025B0B4
		public string RewardName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007AA7 RID: 31399 RVA: 0x0025CEEC File Offset: 0x0025B0EC
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007AA8 RID: 31400 RVA: 0x0025CEFC File Offset: 0x0025B0FC
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06007AA9 RID: 31401 RVA: 0x0025CF14 File Offset: 0x0025B114
		public int PageType
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

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06007AAA RID: 31402 RVA: 0x0025CF54 File Offset: 0x0025B154
		public bool LimitTime
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06007AAB RID: 31403 RVA: 0x0025CF94 File Offset: 0x0025B194
		public int DelayTime
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

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06007AAC RID: 31404 RVA: 0x0025CFD4 File Offset: 0x0025B1D4
		public int DropId
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

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x06007AAD RID: 31405 RVA: 0x0025D014 File Offset: 0x0025B214
		public int JumpId
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

		// Token: 0x04005308 RID: 21256
		private Table __p;
	}
}
