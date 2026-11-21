using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006859 RID: 26713
	public struct IBattleSettlement : IFlatbufferObject
	{
		// Token: 0x1700C463 RID: 50275
		// (get) Token: 0x0602DA92 RID: 187026 RVA: 0x0063EE8E File Offset: 0x0063D08E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DA93 RID: 187027 RVA: 0x0063EE9B File Offset: 0x0063D09B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DA94 RID: 187028 RVA: 0x0063EEA4 File Offset: 0x0063D0A4
		public static IBattleSettlement GetRootAsIBattleSettlement(ByteBuffer _bb)
		{
			return IBattleSettlement.GetRootAsIBattleSettlement(_bb, default(IBattleSettlement));
		}

		// Token: 0x0602DA95 RID: 187029 RVA: 0x0063EEC0 File Offset: 0x0063D0C0
		public static IBattleSettlement GetRootAsIBattleSettlement(ByteBuffer _bb, IBattleSettlement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DA96 RID: 187030 RVA: 0x0063EEDD File Offset: 0x0063D0DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DA97 RID: 187031 RVA: 0x0063EEEC File Offset: 0x0063D0EC
		public IBattleSettlement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C464 RID: 50276
		// (get) Token: 0x0602DA98 RID: 187032 RVA: 0x0063EEFC File Offset: 0x0063D0FC
		public EDynamicSettlementType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDynamicSettlementType.Battle;
				}
				return (EDynamicSettlementType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C465 RID: 50277
		// (get) Token: 0x0602DA99 RID: 187033 RVA: 0x0063EF38 File Offset: 0x0063D138
		public int GamePlayCue
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

		// Token: 0x1700C466 RID: 50278
		// (get) Token: 0x0602DA9A RID: 187034 RVA: 0x0063EF74 File Offset: 0x0063D174
		public EBattleSettlementBgmType BgmType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EBattleSettlementBgmType.BattleSoundWave;
				}
				return (EBattleSettlementBgmType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C467 RID: 50279
		// (get) Token: 0x0602DA9B RID: 187035 RVA: 0x0063EFB0 File Offset: 0x0063D1B0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DA9C RID: 187036 RVA: 0x0063EFED File Offset: 0x0063D1ED
		public static Offset<IBattleSettlement> CreateIBattleSettlement(FlatBufferBuilder builder, EDynamicSettlementType Type = EDynamicSettlementType.Battle, int GamePlayCue = 0, EBattleSettlementBgmType BgmType = EBattleSettlementBgmType.BattleSoundWave, byte NullMask = 0)
		{
			builder.StartTable(4);
			IBattleSettlement.AddGamePlayCue(builder, GamePlayCue);
			IBattleSettlement.AddNullMask(builder, NullMask);
			IBattleSettlement.AddBgmType(builder, BgmType);
			IBattleSettlement.AddType(builder, Type);
			return IBattleSettlement.EndIBattleSettlement(builder);
		}

		// Token: 0x0602DA9D RID: 187037 RVA: 0x0063F019 File Offset: 0x0063D219
		public static void StartIBattleSettlement(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602DA9E RID: 187038 RVA: 0x0063F022 File Offset: 0x0063D222
		public static void AddType(FlatBufferBuilder builder, EDynamicSettlementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DA9F RID: 187039 RVA: 0x0063F02D File Offset: 0x0063D22D
		public static void AddGamePlayCue(FlatBufferBuilder builder, int gamePlayCue)
		{
			builder.AddInt(1, gamePlayCue, 0);
		}

		// Token: 0x0602DAA0 RID: 187040 RVA: 0x0063F038 File Offset: 0x0063D238
		public static void AddBgmType(FlatBufferBuilder builder, EBattleSettlementBgmType bgmType)
		{
			builder.AddByte(2, (byte)bgmType, 0);
		}

		// Token: 0x0602DAA1 RID: 187041 RVA: 0x0063F043 File Offset: 0x0063D243
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602DAA2 RID: 187042 RVA: 0x0063F04E File Offset: 0x0063D24E
		public static Offset<IBattleSettlement> EndIBattleSettlement(FlatBufferBuilder builder)
		{
			return new Offset<IBattleSettlement>(builder.EndTable());
		}

		// Token: 0x0602DAA3 RID: 187043 RVA: 0x0063F05C File Offset: 0x0063D25C
		public IBattleSettlementT UnPack()
		{
			IBattleSettlementT battleSettlementT = new IBattleSettlementT();
			this.UnPackTo(battleSettlementT);
			return battleSettlementT;
		}

		// Token: 0x0602DAA4 RID: 187044 RVA: 0x0063F077 File Offset: 0x0063D277
		public void UnPackTo(IBattleSettlementT _o)
		{
			_o.Type = this.Type;
			_o.GamePlayCue = this.GamePlayCue;
			_o.BgmType = this.BgmType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DAA5 RID: 187045 RVA: 0x0063F0AC File Offset: 0x0063D2AC
		public static Offset<IBattleSettlement> Pack(FlatBufferBuilder builder, IBattleSettlementT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleSettlement>);
			}
			return IBattleSettlement.CreateIBattleSettlement(builder, _o.Type, _o.GamePlayCue, _o.BgmType, _o.NullMask);
		}

		// Token: 0x04011530 RID: 70960
		private Table __p;
	}
}
