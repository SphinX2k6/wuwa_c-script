using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E2D RID: 20013
	public struct IBattleCondition : IFlatbufferObject
	{
		// Token: 0x17008E90 RID: 36496
		// (get) Token: 0x0601EF27 RID: 126759 RVA: 0x00452B68 File Offset: 0x00450D68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EF28 RID: 126760 RVA: 0x00452B75 File Offset: 0x00450D75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EF29 RID: 126761 RVA: 0x00452B7C File Offset: 0x00450D7C
		public static IBattleCondition GetRootAsIBattleCondition(ByteBuffer _bb)
		{
			return IBattleCondition.GetRootAsIBattleCondition(_bb, default(IBattleCondition));
		}

		// Token: 0x0601EF2A RID: 126762 RVA: 0x00452B98 File Offset: 0x00450D98
		public static IBattleCondition GetRootAsIBattleCondition(ByteBuffer _bb, IBattleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EF2B RID: 126763 RVA: 0x00452BB5 File Offset: 0x00450DB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EF2C RID: 126764 RVA: 0x00452BC4 File Offset: 0x00450DC4
		public IBattleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E91 RID: 36497
		// (get) Token: 0x0601EF2D RID: 126765 RVA: 0x00452BD4 File Offset: 0x00450DD4
		public EBattleConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBattleConditionType.BattleTag;
				}
				return (EBattleConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EF2E RID: 126766 RVA: 0x00452C10 File Offset: 0x00450E10
		public static Offset<IBattleCondition> CreateIBattleCondition(FlatBufferBuilder builder, EBattleConditionType Type = EBattleConditionType.BattleTag)
		{
			builder.StartTable(1);
			IBattleCondition.AddType(builder, Type);
			return IBattleCondition.EndIBattleCondition(builder);
		}

		// Token: 0x0601EF2F RID: 126767 RVA: 0x00452C26 File Offset: 0x00450E26
		public static void StartIBattleCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EF30 RID: 126768 RVA: 0x00452C2F File Offset: 0x00450E2F
		public static void AddType(FlatBufferBuilder builder, EBattleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EF31 RID: 126769 RVA: 0x00452C3A File Offset: 0x00450E3A
		public static Offset<IBattleCondition> EndIBattleCondition(FlatBufferBuilder builder)
		{
			return new Offset<IBattleCondition>(builder.EndTable());
		}

		// Token: 0x0601EF32 RID: 126770 RVA: 0x00452C48 File Offset: 0x00450E48
		public IBattleConditionT UnPack()
		{
			IBattleConditionT battleConditionT = new IBattleConditionT();
			this.UnPackTo(battleConditionT);
			return battleConditionT;
		}

		// Token: 0x0601EF33 RID: 126771 RVA: 0x00452C63 File Offset: 0x00450E63
		public void UnPackTo(IBattleConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601EF34 RID: 126772 RVA: 0x00452C74 File Offset: 0x00450E74
		public static Offset<IBattleCondition> Pack(FlatBufferBuilder builder, IBattleConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleCondition>);
			}
			return IBattleCondition.CreateIBattleCondition(builder, _o.Type);
		}

		// Token: 0x0400DC43 RID: 56387
		private Table __p;
	}
}
