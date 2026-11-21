using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FAB RID: 4011
	public struct PhantomBattleCardReward : IFlatbufferObject
	{
		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x0600ABF1 RID: 44017 RVA: 0x002CA139 File Offset: 0x002C8339
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ABF2 RID: 44018 RVA: 0x002CA146 File Offset: 0x002C8346
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ABF3 RID: 44019 RVA: 0x002CA150 File Offset: 0x002C8350
		public static PhantomBattleCardReward GetRootAsPhantomBattleCardReward(ByteBuffer _bb)
		{
			return PhantomBattleCardReward.GetRootAsPhantomBattleCardReward(_bb, default(PhantomBattleCardReward));
		}

		// Token: 0x0600ABF4 RID: 44020 RVA: 0x002CA16C File Offset: 0x002C836C
		public static PhantomBattleCardReward GetRootAsPhantomBattleCardReward(ByteBuffer _bb, PhantomBattleCardReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ABF5 RID: 44021 RVA: 0x002CA189 File Offset: 0x002C8389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ABF6 RID: 44022 RVA: 0x002CA198 File Offset: 0x002C8398
		public PhantomBattleCardReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x0600ABF7 RID: 44023 RVA: 0x002CA1A8 File Offset: 0x002C83A8
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

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x0600ABF8 RID: 44024 RVA: 0x002CA1E4 File Offset: 0x002C83E4
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

		// Token: 0x1700262B RID: 9771
		// (get) Token: 0x0600ABF9 RID: 44025 RVA: 0x002CA220 File Offset: 0x002C8420
		public int DropId
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

		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x0600ABFA RID: 44026 RVA: 0x002CA25C File Offset: 0x002C845C
		public int BitFlagId
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

		// Token: 0x04005567 RID: 21863
		private Table __p;
	}
}
