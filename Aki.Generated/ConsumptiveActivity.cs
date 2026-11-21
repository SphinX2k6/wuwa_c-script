using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C7B RID: 3195
	public struct ConsumptiveActivity : IFlatbufferObject
	{
		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06005ED6 RID: 24278 RVA: 0x0021E9F5 File Offset: 0x0021CBF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005ED7 RID: 24279 RVA: 0x0021EA02 File Offset: 0x0021CC02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005ED8 RID: 24280 RVA: 0x0021EA0C File Offset: 0x0021CC0C
		public static ConsumptiveActivity GetRootAsConsumptiveActivity(ByteBuffer _bb)
		{
			return ConsumptiveActivity.GetRootAsConsumptiveActivity(_bb, default(ConsumptiveActivity));
		}

		// Token: 0x06005ED9 RID: 24281 RVA: 0x0021EA28 File Offset: 0x0021CC28
		public static ConsumptiveActivity GetRootAsConsumptiveActivity(ByteBuffer _bb, ConsumptiveActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005EDA RID: 24282 RVA: 0x0021EA45 File Offset: 0x0021CC45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005EDB RID: 24283 RVA: 0x0021EA54 File Offset: 0x0021CC54
		public ConsumptiveActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06005EDC RID: 24284 RVA: 0x0021EA64 File Offset: 0x0021CC64
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

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06005EDD RID: 24285 RVA: 0x0021EAA0 File Offset: 0x0021CCA0
		public int ScoreItemId
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

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06005EDE RID: 24286 RVA: 0x0021EADC File Offset: 0x0021CCDC
		public int ShopId
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

		// Token: 0x0400519C RID: 20892
		private Table __p;
	}
}
