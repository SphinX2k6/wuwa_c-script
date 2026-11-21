using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB4 RID: 4020
	public struct PhantomBattleEntry : IFlatbufferObject
	{
		// Token: 0x17002696 RID: 9878
		// (get) Token: 0x0600AD16 RID: 44310 RVA: 0x002CCB21 File Offset: 0x002CAD21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD17 RID: 44311 RVA: 0x002CCB2E File Offset: 0x002CAD2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD18 RID: 44312 RVA: 0x002CCB38 File Offset: 0x002CAD38
		public static PhantomBattleEntry GetRootAsPhantomBattleEntry(ByteBuffer _bb)
		{
			return PhantomBattleEntry.GetRootAsPhantomBattleEntry(_bb, default(PhantomBattleEntry));
		}

		// Token: 0x0600AD19 RID: 44313 RVA: 0x002CCB54 File Offset: 0x002CAD54
		public static PhantomBattleEntry GetRootAsPhantomBattleEntry(ByteBuffer _bb, PhantomBattleEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD1A RID: 44314 RVA: 0x002CCB71 File Offset: 0x002CAD71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD1B RID: 44315 RVA: 0x002CCB80 File Offset: 0x002CAD80
		public PhantomBattleEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002697 RID: 9879
		// (get) Token: 0x0600AD1C RID: 44316 RVA: 0x002CCB90 File Offset: 0x002CAD90
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

		// Token: 0x17002698 RID: 9880
		// (get) Token: 0x0600AD1D RID: 44317 RVA: 0x002CCBCC File Offset: 0x002CADCC
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AD1E RID: 44318 RVA: 0x002CCC03 File Offset: 0x002CAE03
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AD1F RID: 44319 RVA: 0x002CCC12 File Offset: 0x002CAE12
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002699 RID: 9881
		// (get) Token: 0x0600AD20 RID: 44320 RVA: 0x002CCC2C File Offset: 0x002CAE2C
		public string Description
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AD21 RID: 44321 RVA: 0x002CCC63 File Offset: 0x002CAE63
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AD22 RID: 44322 RVA: 0x002CCC72 File Offset: 0x002CAE72
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005572 RID: 21874
		private Table __p;
	}
}
