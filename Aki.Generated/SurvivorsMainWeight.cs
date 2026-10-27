using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010FE RID: 4350
	public struct SurvivorsMainWeight : IFlatbufferObject
	{
		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x0600DACB RID: 56011 RVA: 0x00324A0E File Offset: 0x00322C0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DACC RID: 56012 RVA: 0x00324A1B File Offset: 0x00322C1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DACD RID: 56013 RVA: 0x00324A24 File Offset: 0x00322C24
		public static SurvivorsMainWeight GetRootAsSurvivorsMainWeight(ByteBuffer _bb)
		{
			return SurvivorsMainWeight.GetRootAsSurvivorsMainWeight(_bb, default(SurvivorsMainWeight));
		}

		// Token: 0x0600DACE RID: 56014 RVA: 0x00324A40 File Offset: 0x00322C40
		public static SurvivorsMainWeight GetRootAsSurvivorsMainWeight(ByteBuffer _bb, SurvivorsMainWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DACF RID: 56015 RVA: 0x00324A5D File Offset: 0x00322C5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DAD0 RID: 56016 RVA: 0x00324A6C File Offset: 0x00322C6C
		public SurvivorsMainWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x0600DAD1 RID: 56017 RVA: 0x00324A7C File Offset: 0x00322C7C
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

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x0600DAD2 RID: 56018 RVA: 0x00324AB8 File Offset: 0x00322CB8
		public int WeaponId
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

		// Token: 0x04005236 RID: 21046
		private Table __p;
	}
}
