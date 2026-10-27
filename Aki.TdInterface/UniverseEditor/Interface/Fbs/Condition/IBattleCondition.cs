using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004976 RID: 18806
	public struct IBattleCondition : IFlatbufferObject
	{
		// Token: 0x170087D5 RID: 34773
		// (get) Token: 0x0601D502 RID: 120066 RVA: 0x004226B4 File Offset: 0x004208B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D503 RID: 120067 RVA: 0x004226C1 File Offset: 0x004208C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D504 RID: 120068 RVA: 0x004226C8 File Offset: 0x004208C8
		public static IBattleCondition GetRootAsIBattleCondition(ByteBuffer _bb)
		{
			return IBattleCondition.GetRootAsIBattleCondition(_bb, default(IBattleCondition));
		}

		// Token: 0x0601D505 RID: 120069 RVA: 0x004226E4 File Offset: 0x004208E4
		public static IBattleCondition GetRootAsIBattleCondition(ByteBuffer _bb, IBattleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D506 RID: 120070 RVA: 0x00422701 File Offset: 0x00420901
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D507 RID: 120071 RVA: 0x00422710 File Offset: 0x00420910
		public IBattleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087D6 RID: 34774
		// (get) Token: 0x0601D508 RID: 120072 RVA: 0x00422720 File Offset: 0x00420920
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

		// Token: 0x0601D509 RID: 120073 RVA: 0x0042275C File Offset: 0x0042095C
		public static Offset<IBattleCondition> CreateIBattleCondition(FlatBufferBuilder builder, EBattleConditionType Type = EBattleConditionType.BattleTag)
		{
			builder.StartTable(1);
			IBattleCondition.AddType(builder, Type);
			return IBattleCondition.EndIBattleCondition(builder);
		}

		// Token: 0x0601D50A RID: 120074 RVA: 0x00422772 File Offset: 0x00420972
		public static void StartIBattleCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D50B RID: 120075 RVA: 0x0042277B File Offset: 0x0042097B
		public static void AddType(FlatBufferBuilder builder, EBattleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D50C RID: 120076 RVA: 0x00422786 File Offset: 0x00420986
		public static Offset<IBattleCondition> EndIBattleCondition(FlatBufferBuilder builder)
		{
			return new Offset<IBattleCondition>(builder.EndTable());
		}

		// Token: 0x0601D50D RID: 120077 RVA: 0x00422794 File Offset: 0x00420994
		public IBattleConditionT UnPack()
		{
			IBattleConditionT battleConditionT = new IBattleConditionT();
			this.UnPackTo(battleConditionT);
			return battleConditionT;
		}

		// Token: 0x0601D50E RID: 120078 RVA: 0x004227AF File Offset: 0x004209AF
		public void UnPackTo(IBattleConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601D50F RID: 120079 RVA: 0x004227C0 File Offset: 0x004209C0
		public static Offset<IBattleCondition> Pack(FlatBufferBuilder builder, IBattleConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleCondition>);
			}
			return IBattleCondition.CreateIBattleCondition(builder, _o.Type);
		}

		// Token: 0x0400D17B RID: 53627
		private Table __p;
	}
}
