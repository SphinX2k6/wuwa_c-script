using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061EB RID: 25067
	public struct IBattleSettlement : IFlatbufferObject
	{
		// Token: 0x1700BAE0 RID: 47840
		// (get) Token: 0x0602B34B RID: 176971 RVA: 0x005F441A File Offset: 0x005F261A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B34C RID: 176972 RVA: 0x005F4427 File Offset: 0x005F2627
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B34D RID: 176973 RVA: 0x005F4430 File Offset: 0x005F2630
		public static IBattleSettlement GetRootAsIBattleSettlement(ByteBuffer _bb)
		{
			return IBattleSettlement.GetRootAsIBattleSettlement(_bb, default(IBattleSettlement));
		}

		// Token: 0x0602B34E RID: 176974 RVA: 0x005F444C File Offset: 0x005F264C
		public static IBattleSettlement GetRootAsIBattleSettlement(ByteBuffer _bb, IBattleSettlement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B34F RID: 176975 RVA: 0x005F4469 File Offset: 0x005F2669
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B350 RID: 176976 RVA: 0x005F4478 File Offset: 0x005F2678
		public IBattleSettlement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAE1 RID: 47841
		// (get) Token: 0x0602B351 RID: 176977 RVA: 0x005F4488 File Offset: 0x005F2688
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

		// Token: 0x1700BAE2 RID: 47842
		// (get) Token: 0x0602B352 RID: 176978 RVA: 0x005F44C4 File Offset: 0x005F26C4
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

		// Token: 0x1700BAE3 RID: 47843
		// (get) Token: 0x0602B353 RID: 176979 RVA: 0x005F4500 File Offset: 0x005F2700
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

		// Token: 0x1700BAE4 RID: 47844
		// (get) Token: 0x0602B354 RID: 176980 RVA: 0x005F453C File Offset: 0x005F273C
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

		// Token: 0x0602B355 RID: 176981 RVA: 0x005F4579 File Offset: 0x005F2779
		public static Offset<IBattleSettlement> CreateIBattleSettlement(FlatBufferBuilder builder, EDynamicSettlementType Type = EDynamicSettlementType.Battle, int GamePlayCue = 0, EBattleSettlementBgmType BgmType = EBattleSettlementBgmType.BattleSoundWave, byte NullMask = 0)
		{
			builder.StartTable(4);
			IBattleSettlement.AddGamePlayCue(builder, GamePlayCue);
			IBattleSettlement.AddNullMask(builder, NullMask);
			IBattleSettlement.AddBgmType(builder, BgmType);
			IBattleSettlement.AddType(builder, Type);
			return IBattleSettlement.EndIBattleSettlement(builder);
		}

		// Token: 0x0602B356 RID: 176982 RVA: 0x005F45A5 File Offset: 0x005F27A5
		public static void StartIBattleSettlement(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602B357 RID: 176983 RVA: 0x005F45AE File Offset: 0x005F27AE
		public static void AddType(FlatBufferBuilder builder, EDynamicSettlementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B358 RID: 176984 RVA: 0x005F45B9 File Offset: 0x005F27B9
		public static void AddGamePlayCue(FlatBufferBuilder builder, int gamePlayCue)
		{
			builder.AddInt(1, gamePlayCue, 0);
		}

		// Token: 0x0602B359 RID: 176985 RVA: 0x005F45C4 File Offset: 0x005F27C4
		public static void AddBgmType(FlatBufferBuilder builder, EBattleSettlementBgmType bgmType)
		{
			builder.AddByte(2, (byte)bgmType, 0);
		}

		// Token: 0x0602B35A RID: 176986 RVA: 0x005F45CF File Offset: 0x005F27CF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602B35B RID: 176987 RVA: 0x005F45DA File Offset: 0x005F27DA
		public static Offset<IBattleSettlement> EndIBattleSettlement(FlatBufferBuilder builder)
		{
			return new Offset<IBattleSettlement>(builder.EndTable());
		}

		// Token: 0x0602B35C RID: 176988 RVA: 0x005F45E8 File Offset: 0x005F27E8
		public IBattleSettlementT UnPack()
		{
			IBattleSettlementT battleSettlementT = new IBattleSettlementT();
			this.UnPackTo(battleSettlementT);
			return battleSettlementT;
		}

		// Token: 0x0602B35D RID: 176989 RVA: 0x005F4603 File Offset: 0x005F2803
		public void UnPackTo(IBattleSettlementT _o)
		{
			_o.Type = this.Type;
			_o.GamePlayCue = this.GamePlayCue;
			_o.BgmType = this.BgmType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B35E RID: 176990 RVA: 0x005F4638 File Offset: 0x005F2838
		public static Offset<IBattleSettlement> Pack(FlatBufferBuilder builder, IBattleSettlementT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleSettlement>);
			}
			return IBattleSettlement.CreateIBattleSettlement(builder, _o.Type, _o.GamePlayCue, _o.BgmType, _o.NullMask);
		}

		// Token: 0x0401071E RID: 67358
		private Table __p;
	}
}
